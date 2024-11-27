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
    public partial class SignupForm : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=XIREN\SQLEXPRESS;Initial Catalog=LoanWise;Integrated Security=True");

        public SignupForm()
        {
            InitializeComponent();
        }

        private void SignupForm_Load(object sender, EventArgs e)
        {
            // Load data into DataGridView when the form loads
            LoadData();

            // Initialize the DateTimePicker with no value
            signupDob.Format = DateTimePickerFormat.Custom;
            signupDob.CustomFormat = " "; // Display as blank initially

            // Attach the ValueChanged event
            signupDob.ValueChanged += dateTimePicker1_ValueChanged;

        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // Set the format to display the date when a date is selected
            signupDob.Format = DateTimePickerFormat.Short;
        }


        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            // Check if all necessary fields are filled
            if (string.IsNullOrWhiteSpace(signupEmail.Text) ||
                string.IsNullOrWhiteSpace(signupName.Text) ||
                string.IsNullOrWhiteSpace(signupPosition.Text) ||
                string.IsNullOrWhiteSpace(signupContact.Text) ||
                string.IsNullOrWhiteSpace(signupHome.Text) ||
                string.IsNullOrWhiteSpace(signupEmergency.Text))

            {
                MessageBox.Show("All fields are required. Please fill in all fields.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Connect to database if it's not open
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    // Check if username already exists in the database
                    string checkUserName = "SELECT * FROM users_tbl WHERE email = @Email";

                    using (SqlCommand checkUser = new SqlCommand(checkUserName, connect))
                    {
                        checkUser.Parameters.AddWithValue("@email", signupEmail.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(checkUser);
                        DataTable table = new DataTable();

                        adapter.Fill(table);

                        if (table.Rows.Count > 0)
                        {
                            MessageBox.Show(signupEmail.Text + " already exists", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            // Insert new user into the database
                            string insertData = "INSERT INTO users_tbl (email, username, password, usertype, date_created, contact, homeaddress, emergencycontact, dob) " +
                                                "VALUES (@Email, @Username, @Password, @Position, @DateCreated, @Contact, @HomeAddress, @EmergencyContact, @Dob); " +
                                                "SELECT SCOPE_IDENTITY();"; // Get the auto-generated user ID

                            using (SqlCommand cmd = new SqlCommand(insertData, connect))
                            {
                                cmd.Parameters.AddWithValue("@Email", signupEmail.Text.Trim());
                                cmd.Parameters.AddWithValue("@Username", signupName.Text.Trim());
                                cmd.Parameters.AddWithValue("@Password", GeneratePassword(0, signupName.Text.Trim()));
                                cmd.Parameters.AddWithValue("@Position", signupPosition.Text.Trim());
                                cmd.Parameters.AddWithValue("@DateCreated", DateTime.Now);
                                cmd.Parameters.AddWithValue("@Contact", signupContact.Text.Trim());
                                cmd.Parameters.AddWithValue("@HomeAddress", signupHome.Text.Trim());
                                cmd.Parameters.AddWithValue("@EmergencyContact", signupEmergency.Text.Trim());
                                cmd.Parameters.AddWithValue("@Dob", signupDob.Value);

                                // Execute the query and retrieve the new user ID
                                int userId = Convert.ToInt32(cmd.ExecuteScalar()); // Get the newly inserted user's ID

                                // Now generate the password using the correct userId and username
                                string generatedPassword = GeneratePassword(userId, signupName.Text.Trim());

                                // Update the user password with the generated password
                                string updatePasswordQuery = "UPDATE users_tbl SET password = @Password WHERE id = @UserId";

                                using (SqlCommand updateCmd = new SqlCommand(updatePasswordQuery, connect))
                                {
                                    updateCmd.Parameters.AddWithValue("@Password", generatedPassword);
                                    updateCmd.Parameters.AddWithValue("@UserId", userId);
                                    updateCmd.ExecuteNonQuery();
                                }

                                // Show the generated password to the user
                                MessageBox.Show($"Account created successfully!\n\nEmployee Password: {generatedPassword}",
                                                "Account Created",
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Information);

                                // Clear the fields after successful insertion
                                signupEmail.Text = "";
                                signupName.Text = "";
                                signupPosition.Text = "";
                                signupContact.Text = "";
                                signupHome.Text = "";
                                signupEmergency.Text = "";
                                signupDob.Format = DateTimePickerFormat.Custom;
                                signupDob.CustomFormat = " "; // Display as blank initially

                                // Refresh DataGridView
                                LoadData();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Connecting Database: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private string GeneratePassword(int userId, string userName)
        {
            // Combine userId and userName to generate the password as a string
            return userId.ToString() + userName; // For example, "8myko"
        }



        private void LoadData()
        {
            // Connection string for database
            string connectionString = "Data Source=XIREN\\SQLEXPRESS;Initial Catalog=LoanWise;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";

            try
            {
                // Query to fetch data from the users_tbl
                string query = "SELECT id, email, username, usertype FROM users_tbl";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Fetch data using SqlDataAdapter
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Bind the data to DataGridView
                    dataGridView1.DataSource = dataTable;

                    // Adjust the DataGridView columns
                    ConfigureDataGridViewColumns();
                }
            }
            catch (Exception ex)
            {
                // Show error message if data loading fails
                MessageBox.Show($"An error occurred while loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigureDataGridViewColumns()
        {
            // Clear any existing columns to avoid duplication
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            // Set DataGridView to fill all columns proportionally
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Add ID column
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Employee ID",
                DataPropertyName = "id",
                Name = "idColumn"
            });

            // Add Full Name column
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Full Name",
                DataPropertyName = "username",
                Name = "FullNameColumn"
            });

            // Add Email column
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Email",
                DataPropertyName = "email",
                Name = "EmailColumn"
            });

            // Add Position column
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Position",
                DataPropertyName = "usertype",
                Name = "PositionColumn"
            });
        }

        private void signupBtnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(signupEmail.Text) ||
                string.IsNullOrWhiteSpace(signupName.Text) ||
                string.IsNullOrWhiteSpace(signupPosition.Text) ||
                string.IsNullOrWhiteSpace(signupContact.Text) ||
                string.IsNullOrWhiteSpace(signupHome.Text) ||
                string.IsNullOrWhiteSpace(signupEmergency.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (connect.State != ConnectionState.Open)
                {
                    connect.Open();
                }

                // Get the selected user's ID from the DataGridView
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int userId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["idColumn"].Value);

                    // Update query
                    string updateQuery = "UPDATE users_tbl SET email = @Email, username = @Username, usertype = @Position, " +
                                         "contact = @Contact, homeaddress = @HomeAddress, emergencycontact = @EmergencyContact, dob = @Dob " +
                                         "WHERE id = @UserId";

                    using (SqlCommand cmd = new SqlCommand(updateQuery, connect))
                    {
                        cmd.Parameters.AddWithValue("@Email", signupEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@Username", signupName.Text.Trim());
                        cmd.Parameters.AddWithValue("@Position", signupPosition.Text.Trim());
                        cmd.Parameters.AddWithValue("@Contact", signupContact.Text.Trim());
                        cmd.Parameters.AddWithValue("@HomeAddress", signupHome.Text.Trim());
                        cmd.Parameters.AddWithValue("@EmergencyContact", signupEmergency.Text.Trim());
                        cmd.Parameters.AddWithValue("@Dob", signupDob.Value);
                        cmd.Parameters.AddWithValue("@UserId", userId);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Employee information updated successfully!", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Refresh the DataGridView
                            LoadData();

                            // Clear the form fields
                            ClearFormFields();
                        }
                        else
                        {
                            MessageBox.Show("No changes were made.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a row to update.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating the employee: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
        }

        private void ClearFormFields()
        {
            signupEmail.Text = "";
            signupName.Text = "";
            signupPosition.Text = "";
            signupContact.Text = "";
            signupHome.Text = "";
            signupEmergency.Text = "";
            signupDob.Format = DateTimePickerFormat.Custom;
            signupDob.CustomFormat = " "; // Display as blank initially
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure a valid row is clicked
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                signupEmail.Text = row.Cells["EmailColumn"].Value.ToString();
                signupName.Text = row.Cells["FullNameColumn"].Value.ToString();
                signupPosition.Text = row.Cells["PositionColumn"].Value.ToString();
                // Assuming Contact, HomeAddress, and EmergencyContact columns are present
                signupContact.Text = row.Cells["ContactColumn"].Value.ToString();
                signupHome.Text = row.Cells["HomeAddressColumn"].Value.ToString();
                signupEmergency.Text = row.Cells["EmergencyContactColumn"].Value.ToString();
                signupDob.Value = Convert.ToDateTime(row.Cells["DobColumn"].Value);
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
