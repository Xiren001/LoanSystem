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

        private void formRejected_Load(object sender, EventArgs e)
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
            // Connection string - replace with your actual database connection string
            string connectionString = "Data Source=XIREN\\SQLEXPRESS;Initial Catalog=LoanWise;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";

            try
            {
                string query = @"SELECT Id, lastname, firstname, phonenumber, email, employername, amount ,loanpurpose, applicationdate, repaymentterm, applicationdate, CreditScore FROM rejectedApplications";

                // Create a connection and data adapter
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();

                    // Fetch data
                    adapter.Fill(dataTable);

                    // Bind data to DataGridView
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
            // Clear and manually set the column headers to ensure only relevant fields are visible
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Dynamically map only important fields
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Application ID",
                DataPropertyName = "Id",
                Name = "idColumn"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Last Name",
                DataPropertyName = "Last Name",
                Name = "lastNameColumn"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "First Name",
                DataPropertyName = "First Name",
                Name = "firstNameColumn"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Date of Birth",
                DataPropertyName = "Date of Birth",
                Name = "dobColumn"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Gender",
                DataPropertyName = "Gender",
                Name = "genderColumn"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Phone Number",
                DataPropertyName = "Phone Number",
                Name = "phoneColumn"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Email Address",
                DataPropertyName = "Email Address",
                Name = "emailColumn"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Employer",
                DataPropertyName = "Employer",
                Name = "employerColumn"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Loan Type",
                DataPropertyName = "Loan Type",
                Name = "loanTypeColumn"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Loan Amount",
                DataPropertyName = "Loan Amount",
                Name = "loanAmountColumn"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Application Date",
                DataPropertyName = "Application Date",
                Name = "applicationDateColumn"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Credit Score",
                DataPropertyName = "Credit Score",
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
