using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace LoanSystem
{
    public partial class formApproved : Form
    {
        public formApproved()
        {
            InitializeComponent();
        }

        private void formApproved_Load(object sender, EventArgs e)
        {
            // Disable ControlBox (close, maximize, minimize buttons)
            this.ControlBox = false;

            // Load data into DataGridView
            LoadApprovedData();

            // Optional: Add cell formatting for visual enhancements
            dataGridView1.CellFormatting += DataGridView1_CellFormatting;
        }

        private void DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Example: Highlight rows based on loan type
            if (dataGridView1.Columns[e.ColumnIndex].Name == "loanTypeColumn" && e.Value != null)
            {
                string loanType = e.Value.ToString();

                if (loanType == "Personal Loan")
                {
                    e.CellStyle.BackColor = Color.LightBlue;
                    e.CellStyle.ForeColor = Color.Black;
                }
                else if (loanType == "Business Loan")
                {
                    e.CellStyle.BackColor = Color.LightGreen;
                    e.CellStyle.ForeColor = Color.Black;
                }
            }
        }

        private void LoadApprovedData()
        {
            string connectionString = "Data Source=XIREN\\SQLEXPRESS;Initial Catalog=LoanWise;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";

            try
            {
                string query = "SELECT Id, lastname, firstname, dob, gender, loantype, amount, repaymentterm, " +
                               "CreditScore, MonthlyPayment, TotalRepayment, applicationdate " +
                               "FROM approvedApplications";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;

                    ConfigureDataGridViewColumns();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigureDataGridViewColumns()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            // Set columns
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // ID Column
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "ID",
                DataPropertyName = "Id",
                Name = "idColumn"
            });

            // Last Name Column
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Last Name",
                DataPropertyName = "lastname",
                Name = "lastNameColumn"
            });

            // First Name Column
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "First Name",
                DataPropertyName = "firstname",
                Name = "firstNameColumn"
            });

            // Date of Birth Column
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Date of Birth",
                DataPropertyName = "dob",
                Name = "dobColumn"
            });

            // Gender Column
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Gender",
                DataPropertyName = "gender",
                Name = "genderColumn"
            });

            // Loan Type Column
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Loan Type",
                DataPropertyName = "loantype",
                Name = "loanTypeColumn"
            });

            // Amount Column
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Amount",
                DataPropertyName = "amount",
                Name = "amountColumn"
            });

            // Repayment Term Column
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Repayment Term",
                DataPropertyName = "repaymentterm",
                Name = "repaymentTermColumn"
            });

            // Credit Score Column
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Credit Score",
                DataPropertyName = "CreditScore",
                Name = "creditScoreColumn"
            });

            // Monthly Payment Column
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Monthly Payment",
                DataPropertyName = "MonthlyPayment",
                Name = "monthlyPaymentColumn"
            });

            // Total Repayment Column
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Total Repayment",
                DataPropertyName = "TotalRepayment",
                Name = "totalRepaymentColumn"
            });

            // Application Date Column
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Application Date",
                DataPropertyName = "applicationdate",
                Name = "applicationDateColumn"
            });
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
