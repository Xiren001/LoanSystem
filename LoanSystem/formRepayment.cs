using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace LoanSystem
{
    public partial class formRepayment : Form
    {
        private string connectionString = "Data Source=XIREN\\SQLEXPRESS;Initial Catalog=LoanWise;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";

        public formRepayment()
        {
            InitializeComponent();
        }

        private void formRepayment_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            LoadRepaymentData();
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        }


        private void LoadRepaymentData()
        {
            try
            {
                string query = "SELECT Id, CONCAT(firstname, ' ', lastname) AS Name, loantype AS LoanType FROM repaymenttable";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;

                    ConfigureDataGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigureDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            // ID Column
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "ID",
                DataPropertyName = "Id",
                Name = "idColumn",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });

            // Name Column
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Name",
                DataPropertyName = "Name",
                Name = "nameColumn",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            // Loan Type Column
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Loan Type",
                DataPropertyName = "LoanType",
                Name = "loanTypeColumn",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell click events if necessary
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row's ID
                int selectedId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["idColumn"].Value);

                // Fetch data from the database
                FetchAndDisplayDetails(selectedId);
            }
        }

        private void FetchAndDisplayDetails(int applicationId)
        {
            string query = "SELECT * FROM repaymenttable WHERE Id = @Id";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", applicationId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                repaymentApplicationId.Text = reader["Id"].ToString();
                                repaymentApplicantName.Text = $"{reader["firstname"]} {reader["lastname"]}";

                                // Extract numbers, format as decimal with commas, and remove special characters
                                repaymentLoanAmount.Text = FormatAsNumber(reader["amount"].ToString());
                                repaymentInterest.Text = FormatAsNumber(reader["Interest"].ToString());
                                repaymentOriginalLoanAmount.Text = FormatAsNumber(reader["amount"].ToString());
                                repaymentMonthlyPayment.Text = FormatAsNumber(reader["MonthlyPayment"].ToString());
                                repaymentLoanTerm.Text = reader["repaymentterm"].ToString();
                                repaymentLoantermm.Text = reader["repaymentterm"].ToString();
                                repaymentIssueDate.Text = Convert.ToDateTime(reader["TransferDate"]).ToString("yyyy-MM-dd");
                                repaymentInterestrate.Text = reader["Percent"].ToString();

                                // Extract and parse loan term
                                DateTime issueDate = Convert.ToDateTime(reader["TransferDate"]);
                                string loanTermText = reader["repaymentterm"].ToString(); // e.g., "12 months"
                                int repaymentTermMonths = ExtractNumericValue(loanTermText);

                                // Calculate Next Payment Date (1 month after issue date)
                                DateTime nextPaymentDate = issueDate.AddMonths(1);
                                repaymentNextPayment.Text = nextPaymentDate.ToString("yyyy-MM-dd");

                                // Calculate Maturity Date
                                DateTime maturityDate = issueDate.AddMonths(repaymentTermMonths);
                                repaymentMaturityDate.Text = maturityDate.ToString("yyyy-MM-dd");

                                repaymentStat.Text = ""; // Replace with status data if available
                                repaymentPrincipalDept.Text = ""; // Replace with appropriate data if available
                                repaymentBalance.Text = ""; // Replace with balance data if available

                                repaymentOutstandingLtv.Text = ""; // Replace with appropriate data if available
                                repaymentOverdueInterest.Text = ""; // Replace with overdue interest data if available
                                repaymentOverduePrincipalDept.Text = ""; // Replace with overdue principal debt if available
                                repaymentInterestBalance.Text = ""; // Replace with interest balance if available
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while fetching details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Helper method to extract numeric value from a string
        private int ExtractNumericValue(string input)
        {
            // Use regular expressions to extract numeric part
            var match = System.Text.RegularExpressions.Regex.Match(input, @"\d+");
            return match.Success ? int.Parse(match.Value) : 0;
        }



        // Helper method to format a string as a numeric value
        private string FormatAsNumber(string input)
        {
            // Use regex to keep only digits and decimal points
            string numericString = System.Text.RegularExpressions.Regex.Replace(input, @"[^\d.]", "");
            if (decimal.TryParse(numericString, out decimal value))
            {
                return $"₱{value:N2}"; // Format with peso sign, commas, and two decimal places
            }
            return "₱0.00"; // Return default if parsing fails
        }




    }
}
