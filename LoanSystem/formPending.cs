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

        private int? currentSelectedId = null; // Stores the currently selected ID
        private int? previousSelectedId = null; // Tracks the previously selected ID

        public formPending()
        {
            InitializeComponent();
            this.FormClosing += FormPending_FormClosing;
        }

        private void formPending_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;

            // Load data into DataGridView when the form loads
            LoadData();

            // Attach SelectionChanged event handler
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;

            dataGridView1.CellFormatting += DataGridView1_CellFormatting;
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) // Ensure a row is selected
            {
                var selectedRow = dataGridView1.SelectedRows[0];

                // Get the selected ID and status
                if (int.TryParse(selectedRow.Cells["idColumn"].Value?.ToString(), out int selectedId))
                {
                    string currentStatus = selectedRow.Cells["statusColumn"].Value?.ToString();

                    // Skip updating to "On KYC" if the status is "Approved" or "Rejected"
                    if (currentStatus == "Approved" || currentStatus == "Rejected")
                    {
                        return;
                    }

                    // Revert the status of the previously selected row if necessary
                    if (previousSelectedId != null && previousSelectedId != selectedId)
                    {
                        // Get the status of the previous row
                        var previousRow = dataGridView1.Rows.Cast<DataGridViewRow>()
                                               .FirstOrDefault(r => r.Cells["idColumn"].Value.ToString() == previousSelectedId.ToString());

                        if (previousRow != null)
                        {
                            string previousStatus = previousRow.Cells["statusColumn"].Value?.ToString();

                            // Only revert the status if it is "On KYC"
                            if (previousStatus == "On KYC")
                            {
                                UpdateRowStatus(previousSelectedId.Value, "Pending");
                                previousRow.Cells["statusColumn"].Value = "Pending";
                            }
                        }
                    }

                    // Update the status of the currently selected row to "On KYC"
                    UpdateRowStatus(selectedId, "On KYC");
                    selectedRow.Cells["statusColumn"].Value = "On KYC";

                    // Load full details for the selected ID
                    LoadFullDetailsById(selectedId);

                    // Update tracking variables
                    previousSelectedId = currentSelectedId; // Set the previous ID to the last current ID
                    currentSelectedId = selectedId;         // Set the current ID to the newly selected ID
                }
                else
                {
                    MessageBox.Show("Invalid ID selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // If no row is selected, clear selection and labels
                ClearPanelLabels();
                currentSelectedId = null;
                previousSelectedId = null;
            }
        }

        private void UpdateRowStatus(int id, string status)
        {
            // Connection string - replace with your database details
            string connectionString = "Data Source=XIREN\\SQLEXPRESS;Initial Catalog=LoanWise;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";

            try
            {
                // SQL query to update the status of the row
                string query = "UPDATE newapplication SET status = @Status WHERE id = @Id";

                // Establish a connection to the SQL Server
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Prepare the SQL command
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Add parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@Status", status);
                        cmd.Parameters.AddWithValue("@Id", id);

                        // Execute the query
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any errors during the update operation
                MessageBox.Show($"An error occurred while updating the status: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pendingUpdateStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (currentSelectedId == null)
            {
                MessageBox.Show("Please select an application first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get the selected status from the dropdown
            string selectedStatus = pendingUpdateStatus.SelectedItem?.ToString();

            // Ensure the status is either "Approved" or "Rejected"
            if (selectedStatus == "Approved" || selectedStatus == "Rejected")
            {
                try
                {
                    // Update the status in the database
                    UpdateRowStatus(currentSelectedId.Value, selectedStatus);

                    // Find the row in the DataGridView and update its status
                    var row = dataGridView1.Rows.Cast<DataGridViewRow>()
                                                .FirstOrDefault(r => r.Cells["idColumn"].Value.ToString() == currentSelectedId.ToString());
                    if (row != null)
                    {
                        row.Cells["statusColumn"].Value = selectedStatus;
                    }

                    MessageBox.Show($"Application status updated to '{selectedStatus}'.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Reset the combo box to show its default text
                  
                    pendingUpdateStatus.Text = "Operation"; // Set default text

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while updating the status: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Automatically reset the combo box to default if an invalid selection is made
                
                pendingUpdateStatus.Text = "Operation"; // Reset text
            }
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
            }
        }


        private void ClearPanelLabels()
        {
            pendingApplicationId.Text = "N/A";
            pendingApplicantName.Text = "N/A";
            pendingLoanAmount.Text = "N/A";
            pendingStatus.Text = "N/A";
            pendingRepaymentTerm.Text = "N/A";

            // Add clearing for other labels if necessary
        }

        private void LoadFullDetailsById(int selectedId)
        {
            // Connection string - replace with your database details
            string connectionString = "Data Source=XIREN\\SQLEXPRESS;Initial Catalog=LoanWise;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";

            try
            {
                // SQL query to fetch the full row data based on the selected id
                string query = "SELECT * FROM newapplication WHERE id = @Id";

                // Establish a connection to the SQL Server
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Prepare the SQL command
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Add parameter to prevent SQL injection
                        cmd.Parameters.AddWithValue("@Id", selectedId);

                        // Execute the query
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {

                                // Concatenate firstname, middlename, and lastname
                                string firstname = reader["firstname"].ToString();
                                string middlename = reader["middlename"].ToString();
                                string lastname = reader["lastname"].ToString();
                                string number = reader["phonenumber"].ToString();
                                string amount = reader["amount"].ToString();

                                // Populate the labels with the data retrieved
                                pendingApplicationId.Text = reader["id"].ToString();
                                pendingApplicantName.Text = $"{firstname} {middlename} {lastname}".Trim();
                                pendingPhoneNumber.Text = $"+63{number}".Trim();
                                pendingLastName.Text = reader["lastname"].ToString();
                                pendingFirstName.Text = reader["firstname"].ToString();
                                pendingMiddleName.Text = reader["middlename"].ToString();
                                pendingId.Text = reader["idtype"].ToString();
                                pendingGender.Text = reader["gender"].ToString();
                                pendingAddress.Text = reader["address"].ToString();
                                pendingEmail.Text = reader["email"].ToString();

                                // Add additional fields if required
                                pendingLoanAmount.Text = $"₱{amount}".Trim();
                                pendingStatus.Text = reader["status"].ToString();
                                pendingRepaymentTerm.Text = reader["repaymentterm"].ToString();

                                // Employment Details
                                pendingEmployeName.Text = reader["employername"].ToString();
                                pendingEmployementStatus.Text = reader["employmentstatus"].ToString();
                                pendingPosition.Text = reader["position"].ToString();
                                pendingIncome.Text = reader["annualincome"].ToString();
                                pendingYear.Text = reader["yearsemployment"].ToString();

                            }
                            else
                            {
                                // If no data is found, clear the labels
                                ClearPanelLabels();
                                MessageBox.Show("No details found for the selected ID.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any errors during database connection or query execution
                MessageBox.Show($"An error occurred while retrieving details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormPending_FormClosing(object sender, FormClosingEventArgs e)
        {
            RevertOnKYCToPending();
        }

        private void RevertOnKYCToPending()
        {
            string connectionString = "Data Source=XIREN\\SQLEXPRESS;Initial Catalog=LoanWise;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";

            try
            {
                // SQL query to update all "On KYC" statuses to "Pending"
                string query = "UPDATE newapplication SET status = 'Pending' WHERE status = 'On KYC'";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        int rowsAffected = cmd.ExecuteNonQuery(); // Execute the update
                        if (rowsAffected > 0)
                        {
                            Console.WriteLine($"{rowsAffected} rows updated to 'Pending' status.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions during the update process
                MessageBox.Show($"An error occurred while reverting statuses: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadData()
        {
            // Connection string - replace with your database details
            string connectionString = "Data Source=XIREN\\SQLEXPRESS;Initial Catalog=LoanWise;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";

            try
            {
                // SQL query to retrieve data from your table with a WHERE clause for filtering
                string query = "SELECT id, lastname, amount, " +
                               "status, repaymentterm " +
                               "FROM newapplication " +
                               "WHERE status IN ('Pending', 'On KYC')";

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

            // Add Amount column
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Amount",
                DataPropertyName = "amount",
                Name = "amountColumn"
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
                HeaderText = "Repayment Term",
                DataPropertyName = "repaymentterm",
                Name = "repaymenttermColumn"
            });
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
    }
}
