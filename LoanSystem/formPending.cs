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

namespace LoanSystem
{
    public partial class formPending : Form
    {
        public formPending()
        {
            InitializeComponent();
        }

        private void formPending_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;

            // Load data into DataGridView when the form loads
            LoadData();
        }

        private void LoadData()
        {
            // Connection string - replace placeholders with your database details
            string connectionString = "Data Source=XIREN\\SQLEXPRESS;Initial Catalog=LoanWise;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";

            try
            {
                // SQL query to retrieve data from your table
                string query = "SELECT id, lastname, applicationdate, loantype, amount, " +
                               "employmentstatus, annualincome, status, assignedofficer " +
                               "FROM newapplication";

                // Establish a connection to the SQL Server
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Fetch data using SqlDataAdapter
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Bind the data to the DataGridView
                    dataGridView1.DataSource = dataTable;

                    // Adjust column headers and data mappings
                    ConfigureDataGridViewColumns();
                }
            }
            catch (Exception ex)
            {
                // Show error message if something goes wrong
                MessageBox.Show($"An error occurred while loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigureDataGridViewColumns()
        {
            // Clear existing columns to avoid duplication
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            // Set DataGridView to fill all columns proportionally
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Add Application ID column
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Application ID",
                DataPropertyName = "id",
                Name = "idColumn"
            });

            // Add Applicant Name column
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Applicant Name",
                DataPropertyName = "lastname",
                Name = "applicantNameColumn"
            });

            // Add Application Date column
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Application Date",
                DataPropertyName = "applicationdate",
                Name = "applicationDateColumn"
            });

            // Add Loan Type column
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Loan Type",
                DataPropertyName = "loantype",
                Name = "loanTypeColumn"
            });

            // Add Amount column
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Amount",
                DataPropertyName = "amount",
                Name = "amountColumn"
            });

            // Add Employment Status column
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Employment Status",
                DataPropertyName = "employmentstatus",
                Name = "employmentStatusColumn"
            });

            // Add Annual Income column
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Annual Income",
                DataPropertyName = "annualincome",
                Name = "annualIncomeColumn"
            });

            // Add Status column
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Verification Status",
                DataPropertyName = "status",
                Name = "statusColumn"
            });

            // Add Assigned Officer column
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Assigned Officer",
                DataPropertyName = "assignedofficer",
                Name = "assignedOfficerColumn"
            });
        }

    }
}
