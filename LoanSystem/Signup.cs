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

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            // Check if all required fields are filled
            if (string.IsNullOrWhiteSpace(signupEmail.Text) ||
                string.IsNullOrWhiteSpace(signupName.Text) ||
                string.IsNullOrWhiteSpace(signupPass.Text) ||
                string.IsNullOrWhiteSpace(signupConpass.Text))
            {
                MessageBox.Show("All fields are required. Please fill in all fields.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method if any field is empty
            }

            // Check if the passwords match
            if (signupPass.Text.Trim() != signupConpass.Text.Trim())
            {
                MessageBox.Show("Passwords do not match. Please re-enter your password.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method if passwords don't match
            }

            // Ensure connection is not null and set correctly
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    // Parameterized query to check for existing username
                    string checkUserName = "SELECT * FROM users_tbl WHERE username = @username";

                    using (SqlCommand checkUser = new SqlCommand(checkUserName, connect))
                    {
                        checkUser.Parameters.AddWithValue("@username", signupName.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(checkUser);
                        DataTable table = new DataTable();

                        // Fill the table with results from the query
                        adapter.Fill(table);

                        if (table.Rows.Count > 0) // Check if any rows were returned
                        {
                            MessageBox.Show(signupName.Text + " already exists", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            // Parameterized query to insert new user data
                            string insertData = "INSERT INTO users_tbl (email, username, password, date_created) " +
                                                "VALUES (@Email, @Username, @Password, @DateCreated)";

                            DateTime date = DateTime.Today;

                            using (SqlCommand cmd = new SqlCommand(insertData, connect))
                            {
                                cmd.Parameters.AddWithValue("@Email", signupEmail.Text.Trim());
                                cmd.Parameters.AddWithValue("@Username", signupName.Text.Trim());
                                cmd.Parameters.AddWithValue("@Password", signupPass.Text.Trim());
                                cmd.Parameters.AddWithValue("@DateCreated", date);

                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Registered successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Clear the text fields
                                signupEmail.Text = "";
                                signupName.Text = "";
                                signupPass.Text = "";
                                signupConpass.Text = "";
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
    }
}
