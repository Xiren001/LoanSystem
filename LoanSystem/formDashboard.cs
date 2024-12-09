using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LoanSystem
{
    public partial class formDashboard : Form
    {
        // Update with your database connection string
        private string connectionString = "Data Source=XIREN\\SQLEXPRESS;Initial Catalog=LoanWise;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";

        public formDashboard()
        {
            InitializeComponent();
        }

        private void formDashboard_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            UpdateCounts();
        }

        private void UpdateCounts()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Get counts
                    newApplication.Text = GetCount(connection, "newapplication").ToString();
                    approvedLoan.Text = GetCount(connection, "approvedApplications").ToString();
                    rejected.Text = GetCount(connection, "rejectedApplications").ToString();
                    clients.Text = GetCount(connection, "client").ToString();
                    activeBorrower.Text = GetCount(connection, "repaymenttable").ToString();
                    completedLoans.Text = GetCount(connection, "paidtable").ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating counts: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetCount(SqlConnection connection, string tableName)
        {
            string query = $"SELECT COUNT(*) FROM {tableName}";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                return (int)command.ExecuteScalar();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
