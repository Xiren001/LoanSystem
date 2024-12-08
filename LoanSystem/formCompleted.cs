using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LoanSystem
{
    public partial class formCompleted : Form
    {
        public formCompleted()
        {
            InitializeComponent();
        }

        private void formCompleted_Load(object sender, EventArgs e)
        {
            // Disable window buttons to restrict the close, minimize, or maximize
            this.ControlBox = false;

            // Load data into DataGridView from database
            LoadCompletedPayments();

            // Attach click event
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
        }

        private void LoadCompletedPayments()
        {
            string connectionString = "Data Source=XIREN\\SQLEXPRESS;Initial Catalog=LoanWise;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";

            try
            {
                // Execute SQL query
                string query = @"
                    SELECT Id, lastname, firstname, phonenumber, email, employername, amount ,loanpurpose, applicationdate, repaymentterm, TransferDate, outstandingbalance FROM paidtable";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;

                    ConfigureDataGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigureDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "ID",
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

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Employer Name",
                DataPropertyName = "employername",
                Name = "employerNameColumn"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Loan Amount",
                DataPropertyName = "amount",
                Name = "loanAmountColumn"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Loan Purpose",
                DataPropertyName = "loanpurpose",
                Name = "loanPurposeColumn"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Application Date",
                DataPropertyName = "applicationdate",
                Name = "applicationDateColumn"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Repayment Term",
                DataPropertyName = "repaymentterm",
                Name = "repaymentTermColumn"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Transfer Date",
                DataPropertyName = "TransferDate",
                Name = "transferDateColumn"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Outstanding Balance",
                DataPropertyName = "outstandingbalance",
                Name = "outstandingBalanceColumn"
            });
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string selectedId = dataGridView1.Rows[e.RowIndex].Cells["idColumn"].Value.ToString();
                MessageBox.Show($"You clicked on the payment with ID: {selectedId}", "Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
