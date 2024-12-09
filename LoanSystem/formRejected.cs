using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LoanSystem
{
    public partial class formRejected : Form
    {
        public formRejected()
        {
            InitializeComponent();
        }

        private void formRejected_Load_1(object sender, EventArgs e)
        {
            // Disable the ControlBox (close, minimize, maximize)
            this.ControlBox = false;

            // Load rejected applications data into DataGridView
            LoadRejectedApplications();

            // Attach event for DataGridView clicks
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
        }

        private void LoadRejectedApplications()
        {
            string connectionString = "Data Source=XIREN\\SQLEXPRESS;Initial Catalog=LoanWise;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";

            try
            {
                string query = @"SELECT Id, lastname, firstname, phonenumber, email, employername, amount, loanpurpose, applicationdate, repaymentterm, CreditScore FROM rejectedApplications";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;

                    // Dynamically configure the DataGridView columns
                    ConfigureDataGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading rejected application data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigureDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Map database fields dynamically
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Application ID",
                DataPropertyName = "Id",
                Name = "idColumn"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Last Name",
                DataPropertyName = "lastname",
                Name = "lastNameColumn"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "First Name",
                DataPropertyName = "firstname",
                Name = "firstNameColumn"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Phone Number",
                DataPropertyName = "phonenumber",
                Name = "phoneColumn"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Email Address",
                DataPropertyName = "email",
                Name = "emailColumn"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Employer Name",
                DataPropertyName = "employername",
                Name = "employerColumn"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Loan Purpose",
                DataPropertyName = "loanpurpose",
                Name = "loanPurposeColumn"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Loan Amount",
                DataPropertyName = "amount",
                Name = "loanAmountColumn"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Application Date",
                DataPropertyName = "applicationdate",
                Name = "applicationDateColumn"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Repayment Term",
                DataPropertyName = "repaymentterm",
                Name = "repaymentTermColumn"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Credit Score",
                DataPropertyName = "CreditScore",
                Name = "creditScoreColumn"
            });
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Ensure valid row and column index
            {
                // Handle clicks on the DataGridView rows
                string applicationId = dataGridView1.Rows[e.RowIndex].Cells["idColumn"].Value.ToString();
                string clientName = $"{dataGridView1.Rows[e.RowIndex].Cells["lastNameColumn"].Value} {dataGridView1.Rows[e.RowIndex].Cells["firstNameColumn"].Value}";

                MessageBox.Show($"Clicked on Application ID: {applicationId}\nName: {clientName}", "Record Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
