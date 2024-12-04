using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace LoanSystem
{
    public partial class SignInForm : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=XIREN\SQLEXPRESS;Initial Catalog=LoanWise;Integrated Security=True");

        public SignInForm()
        {
            InitializeComponent();
        }

        private void closeSignin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SignInForm_Load(object sender, EventArgs e)
        {
        }

        private void SigninShowpass_CheckedChanged(object sender, EventArgs e)
        {
            SigninPassword.PasswordChar = SigninShowpass.Checked ? '\0' : '*';
        }

        private void SignInBtn_Click(object sender, EventArgs e)
        {
            if (SigninEmail.Text == "" || SigninPassword.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string query = "SELECT email, usertype, password FROM users_tbl WHERE email = @Email";
                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        cmd.Parameters.AddWithValue("@Email", SigninEmail.Text);

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count >= 1)
                        {
                            // Get the stored password
                            string storedPassword = table.Rows[0]["password"].ToString();
                            string userTypeString = table.Rows[0]["usertype"].ToString();
                            string inputPassword = SigninPassword.Text;

                            bool isValidPassword = false;

                            // Check if the stored password is hashed
                            if (storedPassword.Length == 64) // Assuming SHA-256 hash
                            {
                                // Hash the input password and compare
                                string hashedInputPassword = ComputeSHA256Hash(inputPassword);
                                isValidPassword = storedPassword.Equals(hashedInputPassword, StringComparison.OrdinalIgnoreCase);
                            }
                            else
                            {
                                // Compare directly for unhashed passwords
                                isValidPassword = storedPassword.Equals(inputPassword);
                            }

                            if (isValidPassword)
                            {
                                CurrentUser.Email = table.Rows[0]["email"].ToString();
                                CurrentUser.Usertype = GetUserType(userTypeString);

                                if (CurrentUser.Usertype == UserType.Unknown)
                                {
                                    MessageBox.Show("Invalid user type detected. Contact administrator.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }

                                MessageBox.Show("Logged in successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                Dashboard dashboard = new Dashboard();
                                dashboard.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Incorrect Username/Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Incorrect Username/Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Connecting: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private string ComputeSHA256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }


        private UserType GetUserType(string userTypeString)
        {
            return userTypeString switch
            {
                "LoanOfficer" => UserType.LoanOfficer,
                "BranchManager" => UserType.BranchManager,
                "Accountant" => UserType.Accountant,
                "SystemAdministrator" => UserType.SystemAdministrator,
                _ => UserType.Unknown,
            };
        }
    }
}
