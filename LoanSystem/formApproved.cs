using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace LoanSystem
{
    public partial class formApproved : Form
    {

        private string connectionString = "Data Source=XIREN\\SQLEXPRESS;Initial Catalog=LoanWise;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";

        public formApproved()
        {
            InitializeComponent();
        }

        private void formApproved_Load(object sender, EventArgs e)
        {
            // Disable ControlBox (close, maximize, minimize buttons)
            this.ControlBox = false;

            // Load data into DataGridView
            LoadApprovedData();

            // Optional: Add cell formatting for visual enhancements
            dataGridView1.CellFormatting += DataGridView1_CellFormatting;
        }

        private void DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Example: Highlight rows based on loan type
            if (dataGridView1.Columns[e.ColumnIndex].Name == "loanTypeColumn" && e.Value != null)
            {
                string loanType = e.Value.ToString();

                if (loanType == "Personal Loan")
                {
                    e.CellStyle.BackColor = Color.LightBlue;
                    e.CellStyle.ForeColor = Color.Black;
                }
                else if (loanType == "Business Loan")
                {
                    e.CellStyle.BackColor = Color.LightGreen;
                    e.CellStyle.ForeColor = Color.Black;
                }
            }

            if (dataGridView1.Columns[e.ColumnIndex].Name == "statusColumn" && e.Value != null)
            {
                if (e.Value.ToString() == "Active")
                {
                    e.CellStyle.BackColor = Color.LightGreen;
                }
                else
                {
                    e.CellStyle.BackColor = Color.White; // Reset to default for other rows
                }
            }

            // List of column names that require numeric formatting
            var numericColumns = new[] { "amountColumn", "monthlyPaymentColumn", "totalRepaymentColumn" };

            // Check if the column is numeric and if the cell value is not null or DBNull
            if (numericColumns.Contains(dataGridView1.Columns[e.ColumnIndex].Name) &&
                e.Value != null && e.Value != DBNull.Value)
            {
                string numericString = System.Text.RegularExpressions.Regex.Replace(e.Value.ToString(), @"[^\d.]", "");
                if (decimal.TryParse(numericString, out decimal value))
                {
                    e.Value = $"₱{value:N2}"; // Format as currency
                    e.FormattingApplied = true;
                }
            }
        }

        private void LoadApprovedData()
        {
            string connectionString = "Data Source=XIREN\\SQLEXPRESS;Initial Catalog=LoanWise;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";

            try
            {
                string query = @"
            SELECT 
                a.Id, 
                a.lastname, 
                a.firstname, 
                a.dob, 
                a.gender, 
                a.loantype, 
                a.amount, 
                a.repaymentterm, 
                a.CreditScore, 
                a.MonthlyPayment, 
                a.TotalRepayment, 
                a.applicationdate, 
                CASE 
                    WHEN EXISTS (SELECT 1 FROM repaymenttable r WHERE r.Id = a.Id) THEN 'Active'
                    ELSE ''
                END AS Status
            FROM 
                approvedApplications a";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;

                    ConfigureDataGridViewColumns();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigureDataGridViewColumns()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            // Set columns
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // ID Column
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "ID",
                DataPropertyName = "Id",
                Name = "idColumn"
            });

            // Last Name Column
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Last Name",
                DataPropertyName = "lastname",
                Name = "lastNameColumn"
            });

            // First Name Column
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "First Name",
                DataPropertyName = "firstname",
                Name = "firstNameColumn"
            });

            // Date of Birth Column
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Date of Birth",
                DataPropertyName = "dob",
                Name = "dobColumn"
            });

            // Gender Column
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Gender",
                DataPropertyName = "gender",
                Name = "genderColumn"
            });

            // Loan Type Column
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Loan Type",
                DataPropertyName = "loantype",
                Name = "loanTypeColumn"
            });

            // Amount Column
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Amount",
                DataPropertyName = "amount",
                Name = "amountColumn"
            });

            // Repayment Term Column
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Repayment Term",
                DataPropertyName = "repaymentterm",
                Name = "repaymentTermColumn"
            });

            // Credit Score Column
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Credit Score",
                DataPropertyName = "CreditScore",
                Name = "creditScoreColumn"
            });

            // Monthly Payment Column
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Monthly Payment",
                DataPropertyName = "MonthlyPayment",
                Name = "monthlyPaymentColumn"
            });

            // Total Repayment Column
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Total Repayment",
                DataPropertyName = "TotalRepayment",
                Name = "totalRepaymentColumn"
            });

            // Application Date Column
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Application Date",
                DataPropertyName = "applicationdate",
                Name = "applicationDateColumn"
            });

            // Status Column
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Status",
                DataPropertyName = "Status",
                Name = "statusColumn"
            });

            // Attach the CellFormatting event for custom formatting
            dataGridView1.CellFormatting += DataGridView1_CellFormatting;
        }

     



        private void TransferToRepayment(int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Check if the record already exists in repaymenttable
                    string checkQuery = "SELECT COUNT(1) FROM repaymenttable WHERE Id = @Id";
                    SqlCommand checkCommand = new SqlCommand(checkQuery, conn);
                    checkCommand.Parameters.AddWithValue("@Id", id);

                    int recordExists = (int)checkCommand.ExecuteScalar();

                    if (recordExists > 0)
                    {
                        MessageBox.Show("This record already exists.", "Duplicate Record", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Fetch data from approvedApplications
                    string fetchQuery = "SELECT * FROM approvedApplications WHERE Id = @Id";
                    SqlCommand fetchCommand = new SqlCommand(fetchQuery, conn);
                    fetchCommand.Parameters.AddWithValue("@Id", id);

                    SqlDataReader reader = fetchCommand.ExecuteReader();
                    if (reader.Read())
                    {
                        // Insert data into repaymenttable
                        string insertQuery = "INSERT INTO repaymenttable (Id, lastname, firstname, middlename, dob, gender, martialstatus, idtype, idnumber, " +
                                             "phonenumber, email, address, employername, employmentstatus, position, annualincome, yearsemployment, employercontact, " +
                                             "incomeproof, identtityproof, collateraldocument, loantype, amount, loanpurpose, repaymentterm, collateraltype, " +
                                             "estimatedvalue, collateraldescription, monthlyincome, expenses, applicationdate, CreditScore, RBP, Interest, [Percent], " +
                                             "CreditLimit, MonthlyPayment, TotalRepayment, RBP_Interest, RBP_Percent, RBP_MonthlyPayment, RBP_TotalRepayment, TransferDate, outstandingbalance, nextPaymentDate) " +
                                             "VALUES (@Id, @LastName, @FirstName, @MiddleName, @Dob, @Gender, @MartialStatus, @IdType, @IdNumber, " +
                                             "@PhoneNumber, @Email, @Address, @EmployerName, @EmploymentStatus, @Position, @AnnualIncome, @YearsEmployment, " +
                                             "@EmployerContact, @IncomeProof, @IdentityProof, @CollateralDocument, @LoanType, @Amount, @LoanPurpose, " +
                                             "@RepaymentTerm, @CollateralType, @EstimatedValue, @CollateralDescription, @MonthlyIncome, @Expenses, @ApplicationDate, " +
                                             "@CreditScore, @RBP, @Interest, @Percent, @CreditLimit, @MonthlyPayment, @TotalRepayment, @RBP_Interest, @RBP_Percent, " +
                                             "@RBP_MonthlyPayment, @RBP_TotalRepayment, @TransferDate, @Outstandingbalance, @NextPaymentDate)";

                        SqlCommand insertCommand = new SqlCommand(insertQuery, conn);

                        // Map data to insert parameters
                        insertCommand.Parameters.AddWithValue("@Id", reader["Id"]);
                        insertCommand.Parameters.AddWithValue("@LastName", reader["lastname"]);
                        insertCommand.Parameters.AddWithValue("@FirstName", reader["firstname"]);
                        insertCommand.Parameters.AddWithValue("@MiddleName", reader["middlename"]);
                        insertCommand.Parameters.AddWithValue("@Dob", reader["dob"]);
                        insertCommand.Parameters.AddWithValue("@Gender", reader["gender"]);
                        insertCommand.Parameters.AddWithValue("@MartialStatus", reader["martialstatus"]);
                        insertCommand.Parameters.AddWithValue("@IdType", reader["idtype"]);
                        insertCommand.Parameters.AddWithValue("@IdNumber", reader["idnumber"]);
                        insertCommand.Parameters.AddWithValue("@PhoneNumber", reader["phonenumber"]);
                        insertCommand.Parameters.AddWithValue("@Email", reader["email"]);
                        insertCommand.Parameters.AddWithValue("@Address", reader["address"]);
                        insertCommand.Parameters.AddWithValue("@EmployerName", reader["employername"]);
                        insertCommand.Parameters.AddWithValue("@EmploymentStatus", reader["employmentstatus"]);
                        insertCommand.Parameters.AddWithValue("@Position", reader["position"]);
                        insertCommand.Parameters.AddWithValue("@AnnualIncome", reader["annualincome"]);
                        insertCommand.Parameters.AddWithValue("@YearsEmployment", reader["yearsemployment"]);
                        insertCommand.Parameters.AddWithValue("@EmployerContact", reader["employercontact"]);
                        insertCommand.Parameters.AddWithValue("@IncomeProof", reader["incomeproof"]);
                        insertCommand.Parameters.AddWithValue("@IdentityProof", reader["identtityproof"]);
                        insertCommand.Parameters.AddWithValue("@CollateralDocument", reader["collateraldocument"]);
                        insertCommand.Parameters.AddWithValue("@LoanType", reader["loantype"]);
                        insertCommand.Parameters.AddWithValue("@Amount", reader["amount"]);
                        insertCommand.Parameters.AddWithValue("@LoanPurpose", reader["loanpurpose"]);
                        insertCommand.Parameters.AddWithValue("@RepaymentTerm", reader["repaymentterm"]);
                        insertCommand.Parameters.AddWithValue("@CollateralType", reader["collateraltype"]);
                        insertCommand.Parameters.AddWithValue("@EstimatedValue", reader["estimatedvalue"]);
                        insertCommand.Parameters.AddWithValue("@CollateralDescription", reader["collateraldescription"]);
                        insertCommand.Parameters.AddWithValue("@MonthlyIncome", reader["monthlyincome"]);
                        insertCommand.Parameters.AddWithValue("@Expenses", reader["expenses"]);
                        insertCommand.Parameters.AddWithValue("@ApplicationDate", reader["applicationdate"]);
                        insertCommand.Parameters.AddWithValue("@CreditScore", reader["CreditScore"]);
                        insertCommand.Parameters.AddWithValue("@RBP", reader["RBP"]);
                        insertCommand.Parameters.AddWithValue("@Interest", reader["Interest"]);
                        insertCommand.Parameters.AddWithValue("@Percent", reader["Percent"]);
                        insertCommand.Parameters.AddWithValue("@CreditLimit", reader["CreditLimit"]);
                        insertCommand.Parameters.AddWithValue("@MonthlyPayment", reader["MonthlyPayment"]);
                        insertCommand.Parameters.AddWithValue("@TotalRepayment", reader["TotalRepayment"]);
                        insertCommand.Parameters.AddWithValue("@RBP_Interest", reader["RBP_Interest"]);
                        insertCommand.Parameters.AddWithValue("@RBP_Percent", reader["RBP_Percent"]);
                        insertCommand.Parameters.AddWithValue("@RBP_MonthlyPayment", reader["RBP_MonthlyPayment"]);
                        insertCommand.Parameters.AddWithValue("@RBP_TotalRepayment", reader["RBP_TotalRepayment"]);
                        insertCommand.Parameters.AddWithValue("@TransferDate", DateTime.Now);
                        insertCommand.Parameters.AddWithValue("@OutstandingBalance", reader["TotalRepayment"]);
                        insertCommand.Parameters.AddWithValue("@NextPaymentDate", DateTime.Now.AddMonths(1));


                        reader.Close();
                        insertCommand.ExecuteNonQuery();
                        MessageBox.Show("Record successfully activated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Record not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTransfer_Click_1(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["idColumn"].Value);
                TransferToRepayment(id);
                LoadApprovedData(); // Refresh the table after transfer
            }
            else
            {
                MessageBox.Show("Please select a record to activate.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
