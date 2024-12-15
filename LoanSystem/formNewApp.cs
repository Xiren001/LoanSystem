using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LoanSystem
{
    public partial class formNewApp : Form
    {
        public formNewApp()
        {
            InitializeComponent();
        }

        private void formNewApp_Load(object sender, EventArgs e)
        {
            // Disable the ControlBox (close, maximize, minimize buttons)
            this.ControlBox = false;

            // Load data into DataGridView when the form loads
            LoadData();

            dataGridView1.CellFormatting += DataGridView1_CellFormatting;
        }


        private void DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Check if the current column is the status column
            if (dataGridView1.Columns[e.ColumnIndex].Name == "statusColumn" && e.Value != null)
            {
                string status = e.Value.ToString();

                if (status == "Pending")
                {
                    e.CellStyle.BackColor = Color.Khaki;  // Set the background color to yellow
                    e.CellStyle.ForeColor = Color.Black;  // Ensure the text is readable
                }
                else if (status == "On KYC")
                {
                    e.CellStyle.BackColor = Color.LightGray; // Set the background color to light gray
                    e.CellStyle.ForeColor = Color.Black;    // Ensure the text is readable
                }
                else if (status == "Approved")
                {
                    e.CellStyle.BackColor = Color.SeaGreen; // Set the background color to light gray
                    e.CellStyle.ForeColor = Color.Black;    // Ensure the text is readable
                }
                else if (status == "Rejected")
                {
                    e.CellStyle.BackColor = Color.IndianRed; // Set the background color to light gray
                    e.CellStyle.ForeColor = Color.Black;    // Ensure the text is readable
                }
            }
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
                HeaderText = "Status",
                DataPropertyName = "status",
                Name = "statusColumn"
            });
        }

        private void newAppBtn_Click(object sender, EventArgs e)
        {
            // Open the form for creating a new application
            newAppCreate newAppForm = new newAppCreate();
            newAppForm.MdiParent = this.MdiParent;  // Set the parent form for the new form
            newAppForm.Dock = DockStyle.Fill;       // Dock the new form to fill the parent form
            newAppForm.Show();
            this.Close();                           // Close the current form
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0) // Ensure it's a valid row
            {
                int selectedId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["idColumn"].Value);
                newAppCreate updateForm = new newAppCreate(selectedId);
                string applicantName = dataGridView1.Rows[e.RowIndex].Cells["applicantNameColumn"].Value.ToString();
                MessageBox.Show($"You clicked on: {applicantName}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void newAppUpdate_Click(object sender, EventArgs e)
        {
            // Ensure a row is selected
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the Application ID from the selected row
                int selectedId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["idColumn"].Value);

                // Pass the selected ID to the update form
                newAppCreate updateForm = new newAppCreate(selectedId);
                updateForm.MdiParent = this.MdiParent;  // Set the parent form
                updateForm.Dock = DockStyle.Fill;       // Dock the form to fill the parent form
                updateForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select a row to update.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}

