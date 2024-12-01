using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace LoanSystem
{
    public partial class formCustomer : Form
    {
        public formCustomer()
        {
            InitializeComponent();
        }

        private void formCustomer_Load(object sender, EventArgs e)
        {
            // Disable the ControlBox (close, maximize, minimize buttons)
            this.ControlBox = false;

            // Load client data into DataGridView when the form loads
            LoadClientData();

            // Attach cell click event handler
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
        }

        private void LoadClientData()
        {
            // Connection string - replace with your actual database connection string
            string connectionString = "Data Source=XIREN\\SQLEXPRESS;Initial Catalog=LoanWise;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";

            try
            {
                // SQL query to fetch client data
                string query = "SELECT Id, lastname, firstname, middlename, dob, gender, martialstatus, phonenumber, email FROM client";

                // Establish a connection to the database
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Fetch data using SqlDataAdapter
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Bind the data to the DataGridView
                    dataGridView1.DataSource = dataTable;

                    // Configure the DataGridView columns
                    ConfigureDataGridViewColumns();
                }
            }
            catch (Exception ex)
            {
                // Show error message if data loading fails
                MessageBox.Show($"An error occurred while loading client data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigureDataGridViewColumns()
        {
            // Clear existing columns to avoid duplication
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            // Set DataGridView to adjust column sizes proportionally
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Add columns for client data
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Client ID",
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
                HeaderText = "Middle Name",
                DataPropertyName = "middlename",
                Name = "middleNameColumn"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Date of Birth",
                DataPropertyName = "dob",
                Name = "dobColumn"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Gender",
                DataPropertyName = "gender",
                Name = "genderColumn"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Marital Status",
                DataPropertyName = "martialstatus",
                Name = "maritalStatusColumn"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Phone Number",
                DataPropertyName = "phonenumber",
                Name = "phoneNumberColumn"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Email",
                DataPropertyName = "email",
                Name = "emailColumn"
            });
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Ensure a valid cell is clicked
            {
                // Retrieve the selected client's ID and name
                string clientId = dataGridView1.Rows[e.RowIndex].Cells["idColumn"].Value.ToString();
                string clientName = dataGridView1.Rows[e.RowIndex].Cells["lastNameColumn"].Value.ToString();

                // Show a message or perform an action
                MessageBox.Show($"You clicked on Client ID: {clientId}, Name: {clientName}", "Cell Clicked", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
