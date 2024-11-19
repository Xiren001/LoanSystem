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
            if (SigninShowpass.Checked)
            {
                SigninPassword.PasswordChar = '\0';
            }
            else
            {
                SigninPassword.PasswordChar = '*';
            }
        }

        private void SignInBtn_Click(object sender, EventArgs e)
        {
            if (SigninEmail.Text == "" || SigninPassword.Text == "")
            {
                MessageBox.Show("Please fil all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();

                        String selectData = "SELECT * FROM users_tbl WHERE email = @email AND password = @pass";
                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@email", SigninEmail.Text);
                            cmd.Parameters.AddWithValue("@pass", SigninPassword.Text);
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show("Logged In successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                Dashboard mForm = new Dashboard();
                                mForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Incorrect Username/Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Connecting: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void panelSign_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
