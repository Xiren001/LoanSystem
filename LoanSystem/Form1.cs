using System.Data;
using System.Data.SqlClient;

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

                    String query = "SELECT email, usertype FROM users_tbl WHERE email = @Email AND password = @Pass";
                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        cmd.Parameters.AddWithValue("@Email", SigninEmail.Text);
                        cmd.Parameters.AddWithValue("@Pass", SigninPassword.Text);

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count >= 1)
                        {
                            string userTypeString = table.Rows[0]["usertype"].ToString();
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
