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
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(signupEmail.Text) ||
                string.IsNullOrWhiteSpace(signupName.Text) ||
                string.IsNullOrWhiteSpace(signupPass.Text) ||
                string.IsNullOrWhiteSpace(signupConpass.Text))
            {
                MessageBox.Show("All fields are required. Please fill in all fields.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (signupPass.Text.Trim() != signupConpass.Text.Trim())
            {
                MessageBox.Show("Passwords do not match. Please re-enter your password.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string checkUserName = "SELECT * FROM users_tbl WHERE username = @username";

                    using (SqlCommand checkUser = new SqlCommand(checkUserName, connect))
                    {
                        checkUser.Parameters.AddWithValue("@username", signupName.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(checkUser);
                        DataTable table = new DataTable();

                        adapter.Fill(table);

                        if (table.Rows.Count > 0)
                        {
                            MessageBox.Show(signupName.Text + " already exists", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string insertData = "INSERT INTO users_tbl (email, username, password, usertype, date_created, contact, homeaddress, emergencycontact, dob) " +
                                                "VALUES (@Email, @Username, @Password, @Position, @DateCreated, @Contact, @HomeAddress, @EmergencyContact, @Dob)";

                            using (SqlCommand cmd = new SqlCommand(insertData, connect))
                            {
                                cmd.Parameters.AddWithValue("@Email", signupEmail.Text.Trim());
                                cmd.Parameters.AddWithValue("@Username", signupName.Text.Trim());
                                cmd.Parameters.AddWithValue("@Password", signupPass.Text.Trim());
                                cmd.Parameters.AddWithValue("@Position", signupPosition.Text.Trim());
                                cmd.Parameters.AddWithValue("@DateCreated", DateTime.Now);
                                cmd.Parameters.AddWithValue("@Contact", signupContact.Text.Trim());
                                cmd.Parameters.AddWithValue("@HomeAddress", signupHome.Text.Trim());
                                cmd.Parameters.AddWithValue("@EmergencyContact", signupEmergency.Text.Trim());
                                cmd.Parameters.AddWithValue("@Dob", signupDob.Value);

                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Added successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Clear text fields
                                signupEmail.Text = "";
                                signupName.Text = "";
                                signupPass.Text = "";
                                signupConpass.Text = "";

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


        private void LoadData()
        {
            // Connection string - replace placeholders with your database details
            string connectionString = "Data Source=XIREN\\SQLEXPRESS;Initial Catalog=LoanWise;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";

            try
            {
                // Corrected SQL query to retrieve data from your table
                string query = "SELECT id, email, username, usertype FROM users_tbl";

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

            // Add ID column
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Employee ID",
                DataPropertyName = "id",
                Name = "idColumn"
            });

            // Add  Name column
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Full Name",
                DataPropertyName = "username",
                Name = "FullNameColumn"
            });

            // Add EMail column
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
