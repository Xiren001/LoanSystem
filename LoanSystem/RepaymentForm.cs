using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace LoanSystem
{
    public partial class RepaymentForm : Form
    {

        private int applicationId;
        private string connectionString;
        private decimal outstandingbalance;

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
            if (decimal.TryParse(txtRepaymentAmount.Text, out decimal repaymentAmount))
            {
                if (repaymentAmount > outstandingbalance)
                {
                    MessageBox.Show("Repayment amount exceeds the outstanding balance.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                decimal newBalance = outstandingbalance - repaymentAmount;

                try
                {
                    string updateQuery = "UPDATE repaymenttable SET outstandingbalance = @NewBalance WHERE Id = @Id";

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@NewBalance", newBalance);
                            cmd.Parameters.AddWithValue("@Id", applicationId);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show($"Repayment successful! New balance: ₱{newBalance:N2}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
