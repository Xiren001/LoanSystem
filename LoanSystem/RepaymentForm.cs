using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Printing;
using Font = System.Drawing.Font;


namespace LoanSystem
{
    public partial class RepaymentForm : Form
    {

        private int applicationId;
        private string connectionString;
        private decimal outstandingbalance;
        private PrintDocument printDocument;
        private string receiptContent;

        public RepaymentForm(int appId, string connString, decimal loanAmount)
        {
            InitializeComponent();
            applicationId = appId;
            connectionString = connString;
            outstandingbalance = loanAmount;

            // Attach event handlers
            txtRepaymentAmount.TextChanged += TxtRepaymentAmount_TextChanged;
            txtRepaymentAmount.KeyPress += TxtRepaymentAmount_KeyPress;
        }

        private void TxtRepaymentAmount_TextChanged(object sender, EventArgs e)
        {
            // Temporarily detach the TextChanged event to prevent recursive calls
            txtRepaymentAmount.TextChanged -= TxtRepaymentAmount_TextChanged;

            string text = txtRepaymentAmount.Text.Replace(",", ""); // Remove commas
            int cursorPosition = txtRepaymentAmount.SelectionStart; // Save cursor position

            if (decimal.TryParse(text, out decimal value))
            {
                // Re-format the input with commas while keeping the user input intact
                string[] parts = text.Split('.');
                if (parts.Length > 1)
                {
                    // Format integer part and keep the decimal part untouched
                    txtRepaymentAmount.Text = string.Format("{0:N0}", decimal.Parse(parts[0])) + "." + parts[1];
                }
                else
                {
                    // Format integer part only
                    txtRepaymentAmount.Text = string.Format("{0:N0}", value);
                }
            }
            else
            {
                // Restore the text as-is if it's not a valid number yet
                txtRepaymentAmount.Text = text;
            }

            // Restore the cursor position
            txtRepaymentAmount.SelectionStart = Math.Min(cursorPosition, txtRepaymentAmount.Text.Length);

            // Re-attach the TextChanged event
            txtRepaymentAmount.TextChanged += TxtRepaymentAmount_TextChanged;
        }


        private void TxtRepaymentAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits, control characters (e.g., backspace), and a decimal point
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Only allow one decimal point
            if (e.KeyChar == '.' && txtRepaymentAmount.Text.Contains("."))
            {
                e.Handled = true;
            }
        }


        private void btnConfirmRepayment_Click_2(object sender, EventArgs e)
        {
            decimal monthlyPayment = 0;

            try
            {
                // Fetch and clean the monthly payment from the database
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT monthlyPayment FROM repaymenttable WHERE Id = @Id";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", applicationId);
                        string rawMonthlyPayment = Convert.ToString(cmd.ExecuteScalar());

                        // Clean and parse the string to a valid decimal
                        string cleanedMonthlyPaymentString = Regex.Replace(rawMonthlyPayment, @"[^\d.\-]", "");

                        if (!decimal.TryParse(cleanedMonthlyPaymentString, out monthlyPayment))
                        {
                            MessageBox.Show("Error: Could not parse the monthly payment value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching or parsing monthly payment: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (decimal.TryParse(txtRepaymentAmount.Text, out decimal repaymentAmount))
            {
                // Ensure the repayment amount is valid
                if (repaymentAmount < monthlyPayment)
                {
                    MessageBox.Show($"Payment amount must be at least the monthly payment amount of ₱{monthlyPayment:N2}.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (repaymentAmount > outstandingbalance)
                {
                    MessageBox.Show("Repayment amount exceeds the outstanding balance.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                decimal newBalance = outstandingbalance - repaymentAmount;
                decimal newTotalPrincipalPaid = 0;
                DateTime newNextPaymentDate = DateTime.Now; // Declare outside for proper scope

                try
                {
                    string fetchQuery = "SELECT totalPrincipalPaid, nextPaymentDate FROM repaymenttable WHERE Id = @Id";
                    string updateQuery = "UPDATE repaymenttable SET outstandingbalance = @NewBalance, totalPrincipalPaid = @NewTotalPrincipalPaid, nextPaymentDate = @NewNextPaymentDate WHERE Id = @Id";
                    string incrementPaymentTrackQuery = "UPDATE repaymenttable SET paymentTrack = paymentTrack + 1 WHERE Id = @Id";

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        // Fetch current totalPrincipalPaid and nextPaymentDate
                        decimal currentPrincipalPaid = 0;
                        DateTime currentNextPaymentDate = DateTime.Now; // Default fallback value

                        using (SqlCommand fetchCmd = new SqlCommand(fetchQuery, conn))
                        {
                            fetchCmd.Parameters.AddWithValue("@Id", applicationId);
                            using (SqlDataReader reader = fetchCmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    currentPrincipalPaid = Convert.ToDecimal(reader["totalPrincipalPaid"]);
                                    currentNextPaymentDate = reader["nextPaymentDate"] != DBNull.Value
                                        ? Convert.ToDateTime(reader["nextPaymentDate"])
                                        : DateTime.Now; // Default to now if null
                                }
                            }
                        }

                        // Calculate the new totalPrincipalPaid and nextPaymentDate
                        newTotalPrincipalPaid = currentPrincipalPaid + repaymentAmount;
                        newNextPaymentDate = currentNextPaymentDate.AddMonths(1); // Add 1 month

                        // Update the outstanding balance, total principal paid, and next payment date
                        using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn))
                        {
                            updateCmd.Parameters.AddWithValue("@NewBalance", newBalance);
                            updateCmd.Parameters.AddWithValue("@NewTotalPrincipalPaid", newTotalPrincipalPaid);
                            updateCmd.Parameters.AddWithValue("@NewNextPaymentDate", newNextPaymentDate);
                            updateCmd.Parameters.AddWithValue("@Id", applicationId);
                            updateCmd.ExecuteNonQuery();
                        }

                        // Increment the paymentTrack column
                        using (SqlCommand incrementCmd = new SqlCommand(incrementPaymentTrackQuery, conn))
                        {
                            incrementCmd.Parameters.AddWithValue("@Id", applicationId);
                            incrementCmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show($"Repayment successful!" +
                                    $"\nNew Balance: ₱{newBalance:N2}" +
                                    $"\nTotal Principal Paid: ₱{newTotalPrincipalPaid:N2}" +
                                    $"\nNext Payment Date: {newNextPaymentDate:yyyy-MM-dd}","Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Generate receipt
                    GenerateReceipt(repaymentAmount, newBalance, newTotalPrincipalPaid, newNextPaymentDate);

                    // Print the receipt
                    PrintReceipt();

                    // Optionally, save the receipt to a file
                    SaveReceiptToFile(receiptContent);

                    this.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid repayment amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GenerateReceipt(decimal repaymentAmount, decimal newBalance, decimal totalPrincipalPaid, DateTime nextPaymentDate)
        {
            StringBuilder receiptBuilder = new StringBuilder();
            receiptBuilder.AppendLine("------------- Receipt -------------");
            receiptBuilder.AppendLine($"Payment Date: {DateTime.Now:yyyy-MM-dd HH:mm:ss}");
            receiptBuilder.AppendLine($"Repayment Amount: ₱{repaymentAmount:N2}");
            receiptBuilder.AppendLine($"New Outstanding Balance: ₱{newBalance:N2}");
            receiptBuilder.AppendLine($"Total Principal Paid: ₱{totalPrincipalPaid:N2}");
            receiptBuilder.AppendLine($"Next Payment Date: {nextPaymentDate:yyyy-MM-dd}");
            receiptBuilder.AppendLine("-----------------------------------");
            receiptBuilder.AppendLine("Thank you for your payment!");

            receiptContent = receiptBuilder.ToString();
        }

        private void InitializePrintDocument()
        {
            printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Print the receipt content
            e.Graphics.DrawString(receiptContent, new Font("Arial", 12), Brushes.Black, new PointF(50, 50));
        }

        private void PrintReceipt()
        {
            try
            {
                if (printDocument == null)
                {
                    InitializePrintDocument();
                }

                PrintDialog printDialog = new PrintDialog
                {
                    Document = printDocument
                };

                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    printDocument.Print();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while printing: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveReceiptToFile(string content)
        {
            string directory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "LoanReceipts");
            Directory.CreateDirectory(directory);

            string filePath = Path.Combine(directory, $"Receipt_{DateTime.Now:yyyyMMdd_HHmmss}.txt");
            File.WriteAllText(filePath, content);
            MessageBox.Show($"Receipt saved to {filePath}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}
