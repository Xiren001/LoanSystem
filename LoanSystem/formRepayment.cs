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
                                // Update labels with data from the database
                                repaymentApplicationId.Text = reader["Id"].ToString();
                                repaymentApplicantName.Text = $"{reader["firstname"]} {reader["lastname"]}";
                                repaymentLoanAmount.Text = reader["amount"].ToString();
                                repaymentMonthlyPayment.Text = reader["MonthlyPayment"].ToString();
                                repaymentNextPayment.Text = ""; // Replace with appropriate data if available
                                repaymentStat.Text = ""; // Replace with status data if available
                                repaymentLoanTerm.Text = reader["repaymentterm"].ToString();
                                repaymentLoantermm.Text = reader["repaymentterm"].ToString();
                                repaymentInterest.Text = reader["Interest"].ToString();
                                repaymentPrincipalDept.Text = ""; // Replace with appropriate data if available
                                repaymentBalance.Text = ""; // Replace with balance data if available
                                repaymentMaturityDate.Text = ""; // Replace with maturity date if available
                                repaymentOriginalLoanAmount.Text = reader["amount"].ToString();
                                repaymentIssueDate.Text = reader["applicationdate"].ToString();
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

    }
}
