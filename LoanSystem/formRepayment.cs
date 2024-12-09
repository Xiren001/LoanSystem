using MySqlX.XDevAPI.Relational;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace LoanSystem
{
    public partial class formRepayment : Form
    {
        private string connectionString = "Data Source=XIREN\\SQLEXPRESS;Initial Catalog=LoanWise;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;MultipleActiveResultSets=True;";

        public formRepayment()
        {
            InitializeComponent();
        }

        private void formRepayment_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            LoadRepaymentData();
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        }


        private void LoadRepaymentData()
        {
            try
            {
                string query = "SELECT Id, CONCAT(firstname, ' ', lastname) AS Name, loantype AS LoanType, TransferDate, repaymentterm FROM repaymenttable";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Add a Status column to the DataTable
                    dataTable.Columns.Add("Status", typeof(string));

                    foreach (DataRow row in dataTable.Rows)
                    {
                        DateTime transferDate = Convert.ToDateTime(row["TransferDate"]);
                        int repaymentTermMonths = ExtractNumericValue(row["repaymentterm"].ToString());

                        // Calculate Next Payment Date
                        DateTime nextPaymentDate = transferDate.AddMonths(1);

                        // Determine status
                        row["Status"] = DateTime.Now > nextPaymentDate ? "Overdue" : "Active";
                    }

                    dataGridView1.DataSource = dataTable;
                    ConfigureDataGridView();
                    UpdateStatusInDataGridView();
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

            // ID Column
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "ID",
                DataPropertyName = "Id",
                Name = "idColumn",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });

            // Name Column
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Name",
                DataPropertyName = "Name",
                Name = "nameColumn",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            // Loan Type Column
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Loan Type",
                DataPropertyName = "LoanType",
                Name = "loanTypeColumn",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });

            // Status Column
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Status",
                DataPropertyName = "Status",  // Bind to the Status column in DataTable
                Name = "statusColumn",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });

            // Set default values and format
            dataGridView1.CellFormatting += DataGridView1_CellFormatting;
        }


        private void DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "statusColumn")
            {
                string status = e.Value?.ToString();
                if (status == "Overdue")
                {
                    e.CellStyle.BackColor = Color.IndianRed;
                    e.CellStyle.ForeColor = Color.White;
                }
                else if (status == "Active")
                {
                    e.CellStyle.BackColor = Color.SeaGreen;
                    e.CellStyle.ForeColor = Color.White;
                }
                else
                {
                    e.CellStyle.BackColor = Color.Gray;
                }
            }
        }


        private void UpdateStatusInDataGridView()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["idColumn"].Value != null)
                {
                    int applicationId = Convert.ToInt32(row.Cells["idColumn"].Value);

                    // Fetch nextPaymentDate from database
                    string query = "SELECT nextPaymentDate FROM repaymenttable WHERE Id = @Id";
                    try
                    {
                        using (SqlConnection conn = new SqlConnection(connectionString))
                        {
                            conn.Open();
                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@Id", applicationId);
                                object result = cmd.ExecuteScalar();

                                if (result != null && DateTime.TryParse(result.ToString(), out DateTime nextPaymentDate))
                                {
                                    // Determine status
                                    string status = DateTime.Now > nextPaymentDate ? "Overdue" : "Active";

                                    // Update the status column in the DataGridView
                                    row.Cells["statusColumn"].Value = status;
                                }
                                else
                                {
                                    // Handle cases where nextPaymentDate is null or invalid
                                    row.Cells["statusColumn"].Value = "Unknown";
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error fetching nextPaymentDate: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell click events if necessary
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row's ID
                int selectedId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["idColumn"].Value);

                // Fetch data from the database
                FetchAndDisplayDetails(selectedId);
            }
        }

        private void FetchAndDisplayDetails(int applicationId)
        {
            string query = "SELECT * FROM repaymenttable WHERE Id = @Id";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", applicationId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                repaymentApplicationId.Text = reader["Id"].ToString();
                                repaymentApplicantName.Text = $"{reader["firstname"]} {reader["lastname"]}";

                                // Extract and format numeric data
                                decimal originalLoanAmount = Convert.ToDecimal(reader["amount"]);
                                decimal totalPrincipalPaid = Convert.ToDecimal(reader["totalPrincipalPaid"]);

                                // Retrieve the outstanding balance as a string
                                string rawOutstandingBalance = reader["outstandingbalance"].ToString();
                                string cleanedBalance = rawOutstandingBalance.Replace("?", "").Replace(",", "");

                                decimal outstandingBalance = 0;

                                if (decimal.TryParse(cleanedBalance, out outstandingBalance))
                                {
                                    // Successfully parsed the balance
                                    Console.WriteLine($"Parsed outstanding balance: {outstandingBalance}");
                                }
                                else
                                {
                                    // Handle conversion failure
                                    Console.WriteLine("Failed to parse the outstanding balance.");
                                }

                                decimal principalDebt = originalLoanAmount - totalPrincipalPaid;
                                decimal outstandingLTV = (outstandingBalance / originalLoanAmount) * 100;

                                repaymentLoanAmount.Text = FormatAsNumber(reader["amount"].ToString());
                                repaymentInterest.Text = FormatAsNumber(reader["Interest"].ToString());
                                repaymentOriginalLoanAmount.Text = FormatAsNumber(reader["amount"].ToString());

                                // Handle and parse MonthlyPayment
                                string monthlyPaymentString = reader["MonthlyPayment"].ToString();
                                monthlyPaymentString = monthlyPaymentString.Replace("?", "").Replace(",", "").Trim();
                                decimal monthlyPayment = 0;
                                if (!decimal.TryParse(monthlyPaymentString, out monthlyPayment))
                                {
                                    monthlyPayment = 0;
                                    MessageBox.Show("Monthly Payment data is invalid and could not be processed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                repaymentMonthlyPayment.Text = FormatAsNumber(monthlyPayment.ToString());

                                repaymentLoanTerm.Text = reader["repaymentterm"].ToString();
                                repaymentLoantermm.Text = reader["repaymentterm"].ToString();
                                repaymentIssueDate.Text = Convert.ToDateTime(reader["TransferDate"]).ToString("yyyy-MM-dd");
                                repaymentInterestrate.Text = reader["Percent"].ToString();
                                repaymentBalance.Text = FormatAsNumber(reader["outstandingbalance"].ToString());

                                // Parse dates and calculate maturity date
                                DateTime issueDate = Convert.ToDateTime(reader["TransferDate"]);
                                string loanTermText = reader["repaymentterm"].ToString();
                                int repaymentTermMonths = ExtractNumericValue(loanTermText);

                                DateTime maturityDate = issueDate.AddMonths(repaymentTermMonths);
                                repaymentMaturityDate.Text = maturityDate.ToString("yyyy-MM-dd");


                                // Calculate next payment date
                                DateTime nextPaymentDate = Convert.ToDateTime(reader["nextPaymentDate"]);
                                repaymentNextPayment.Text = nextPaymentDate.ToString("yyyy-MM-dd");

                                // Parse interest rate
                                string percentString = reader["Percent"].ToString();
                                decimal annualInterestRate = 0;

                                if (!string.IsNullOrEmpty(percentString) && percentString.Contains("%"))
                                {
                                    percentString = percentString.Replace("%", "").Trim();
                                    annualInterestRate = Convert.ToDecimal(percentString) / 100;
                                }
                                decimal dailyInterestRate = annualInterestRate / 365;

                                // Determine loan status
                                string status = DateTime.Now > nextPaymentDate ? "Overdue" : "Active";
                                repaymentStat.Text = status;


                                if (status == "Overdue")
                                {
                                    int overdueDays = (DateTime.Now - nextPaymentDate).Days;

                                    if (overdueDays > 0)
                                    {
                                        decimal overdueInterest = outstandingBalance * dailyInterestRate * overdueDays;
                                        repaymentOverdueInterest.Text = FormatAsNumber(overdueInterest.ToString());

                                        // Add overdue interest to monthly payment
                                        monthlyPayment += overdueInterest;
                                        repaymentMonthlyPayment.Text = $"{FormatAsNumber(monthlyPayment.ToString())} (+{FormatAsNumber(overdueInterest.ToString())})";

                                        outstandingBalance += overdueInterest;
                                        repaymentBalance.Text = $"{FormatAsNumber(outstandingBalance.ToString())} (+{FormatAsNumber(overdueInterest.ToString())})";

                                        // Set the text color to red for overdue payments
                                        repaymentMonthlyPayment.ForeColor = Color.IndianRed;
                                        repaymentBalance.ForeColor = Color.IndianRed;

                                        // Calculate overdue principal debt
                                        decimal overduePrincipalDebt = principalDebt * (overdueDays / (decimal)repaymentTermMonths);
                                        repaymentOverduePrincipalDept.Text = FormatAsNumber(overduePrincipalDebt.ToString());
                                    }
                                }
                                else
                                {
                                    // Revert overdue indicators and restore active state visuals
                                    repaymentOverdueInterest.Text = "₱0.00";
                                    repaymentMonthlyPayment.Text = FormatAsNumber(monthlyPayment.ToString());
                                    repaymentBalance.Text = FormatAsNumber(outstandingBalance.ToString());
                                    repaymentOverduePrincipalDept.Text = "₱0.00";

                                    // Reset text colors to default
                                    repaymentMonthlyPayment.ForeColor = SystemColors.ControlText;
                                    repaymentBalance.ForeColor = SystemColors.ControlText;


                                }


                                //UpdateNextPaymentDate(applicationId, nextPaymentDate);
                                // Display the updated next payment date
                                repaymentPrincipalDept.Text = FormatAsNumber(principalDebt.ToString());
                                repaymentOutstandingLtv.Text = $"{outstandingLTV:N2}%";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while fetching details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Helper method to extract numeric value from a string
        private int ExtractNumericValue(string input)
        {
            // Use regular expressions to extract numeric part
            var match = System.Text.RegularExpressions.Regex.Match(input, @"\d+");
            return match.Success ? int.Parse(match.Value) : 0;
        }



        // Helper method to format a string as a numeric value
        private string FormatAsNumber(string input)
        {
            // Use regex to keep only digits and decimal points
            string numericString = System.Text.RegularExpressions.Regex.Replace(input, @"[^\d.]", "");
            if (decimal.TryParse(numericString, out decimal value))
            {
                return $"₱{value:N2}"; // Format with peso sign, commas, and two decimal places
            }
            return "₱0.00"; // Return default if parsing fails
        }
        private void repaymentbtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["idColumn"].Value);

                // Fetch loan amount for the selected ID
                string query = "SELECT outstandingbalance FROM repaymenttable WHERE Id = @Id";

                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Id", selectedId);
                            object result = cmd.ExecuteScalar();

                            decimal loanAmount = ParseOutstandingBalance(result);

                            if (loanAmount > 0)
                            {
                                // Open Repayment Form
                                RepaymentForm repaymentForm = new RepaymentForm(selectedId, connectionString, loanAmount);
                                DialogResult dialogResult = repaymentForm.ShowDialog();
                                if (dialogResult == DialogResult.OK)
                                {
                                    LoadRepaymentData();
                                    CheckAndMovePaidLoans();
                                }
                                else
                                {
                                    LoadRepaymentData();
                                    
                                }

                            }
                            else
                            {
                                MessageBox.Show("Invalid loan amount. Please check the data.",
                                                "Error",
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while processing the repayment: {ex.Message}",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a record first.",
                                "Info",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }


        private decimal ParseOutstandingBalance(object balance)
        {
            if (balance == null) return 0;

            string rawBalance = balance.ToString();
            string cleanedBalance = rawBalance.Replace("?", "").Replace(",", "");

            return decimal.TryParse(cleanedBalance, out decimal result) ? result : 0;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            LoadRepaymentData();
            CheckAndMovePaidLoans();
        }

        private void CheckAndMovePaidLoans()
        {
            try
            {
                string selectQuery = "SELECT * FROM repaymenttable WHERE CAST(outstandingbalance AS DECIMAL) = 0";
                string insertQuery = @"INSERT INTO paidtable (
                                    Id, lastname, firstname, middlename, dob, gender, martialstatus, idtype, idnumber, 
                                    phonenumber, email, address, employername, employmentstatus, position, annualincome, 
                                    yearsemployment, employercontact, incomeproof, identtityproof, collateraldocument, 
                                    loantype, amount, loanpurpose, repaymentterm, collateraltype, estimatedvalue, 
                                    collateraldescription, monthlyincome, expenses, applicationdate, CreditScore, 
                                    RBP, Interest, [Percent], CreditLimit, MonthlyPayment, TotalRepayment, 
                                    RBP_Interest, RBP_Percent, RBP_MonthlyPayment, RBP_TotalRepayment, TransferDate, 
                                    outstandingbalance, totalPrincipalPaid, paymentTrack, nextPaymentDate
                                ) 
                                VALUES (
                                    @Id, @lastname, @firstname, @middlename, @dob, @gender, @martialstatus, @idtype, @idnumber, 
                                    @phonenumber, @email, @address, @employername, @employmentstatus, @position, @annualincome, 
                                    @yearsemployment, @employercontact, @incomeproof, @identtityproof, @collateraldocument, 
                                    @loantype, @amount, @loanpurpose, @repaymentterm, @collateraltype, @estimatedvalue, 
                                    @collateraldescription, @monthlyincome, @expenses, @applicationdate, @CreditScore, 
                                    @RBP, @Interest, @Percent, @CreditLimit, @MonthlyPayment, @TotalRepayment, 
                                    @RBP_Interest, @RBP_Percent, @RBP_MonthlyPayment, @RBP_TotalRepayment, @TransferDate, 
                                    @outstandingbalance, @totalPrincipalPaid, @paymentTrack, @nextPaymentDate)";

                string deleteQuery = "DELETE FROM repaymenttable WHERE Id = @Id";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand selectCmd = new SqlCommand(selectQuery, conn))
                    {
                        using (SqlDataReader reader = selectCmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string fullName = $"{reader["firstname"]} {reader["lastname"]}";
                                string message = $"The loan record for {fullName} (ID: {reader["Id"]}) has been fully repaid. Do you want to move this record to the Completed table?";
                                DialogResult dialogResult = MessageBox.Show(message, "Confirm Move", MessageBoxButtons.OK, MessageBoxIcon.Question);

                                if (dialogResult == DialogResult.OK)
                                {
                                    try
                                    {
                                        using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                                        {
                                            insertCmd.Parameters.AddWithValue("@Id", reader["Id"]);
                                            insertCmd.Parameters.AddWithValue("@lastname", reader["lastname"]);
                                            insertCmd.Parameters.AddWithValue("@firstname", reader["firstname"]);
                                            insertCmd.Parameters.AddWithValue("@middlename", reader["middlename"]);
                                            insertCmd.Parameters.AddWithValue("@dob", reader["dob"]);
                                            insertCmd.Parameters.AddWithValue("@gender", reader["gender"]);
                                            insertCmd.Parameters.AddWithValue("@martialstatus", reader["martialstatus"]);
                                            insertCmd.Parameters.AddWithValue("@idtype", reader["idtype"]);
                                            insertCmd.Parameters.AddWithValue("@idnumber", reader["idnumber"]);
                                            insertCmd.Parameters.AddWithValue("@phonenumber", reader["phonenumber"]);
                                            insertCmd.Parameters.AddWithValue("@email", reader["email"]);
                                            insertCmd.Parameters.AddWithValue("@address", reader["address"]);
                                            insertCmd.Parameters.AddWithValue("@employername", reader["employername"]);
                                            insertCmd.Parameters.AddWithValue("@employmentstatus", reader["employmentstatus"]);
                                            insertCmd.Parameters.AddWithValue("@position", reader["position"]);
                                            insertCmd.Parameters.AddWithValue("@annualincome", reader["annualincome"]);
                                            insertCmd.Parameters.AddWithValue("@yearsemployment", reader["yearsemployment"]);
                                            insertCmd.Parameters.AddWithValue("@employercontact", reader["employercontact"]);
                                            insertCmd.Parameters.AddWithValue("@incomeproof", reader["incomeproof"]);
                                            insertCmd.Parameters.AddWithValue("@identtityproof", reader["identtityproof"]);
                                            insertCmd.Parameters.AddWithValue("@collateraldocument", reader["collateraldocument"]);
                                            insertCmd.Parameters.AddWithValue("@loantype", reader["loantype"]);
                                            insertCmd.Parameters.AddWithValue("@amount", reader["amount"]);
                                            insertCmd.Parameters.AddWithValue("@loanpurpose", reader["loanpurpose"]);
                                            insertCmd.Parameters.AddWithValue("@repaymentterm", reader["repaymentterm"]);
                                            insertCmd.Parameters.AddWithValue("@collateraltype", reader["collateraltype"]);
                                            insertCmd.Parameters.AddWithValue("@estimatedvalue", reader["estimatedvalue"]);
                                            insertCmd.Parameters.AddWithValue("@collateraldescription", reader["collateraldescription"]);
                                            insertCmd.Parameters.AddWithValue("@monthlyincome", reader["monthlyincome"]);
                                            insertCmd.Parameters.AddWithValue("@expenses", reader["expenses"]);
                                            insertCmd.Parameters.AddWithValue("@applicationdate", reader["applicationdate"]);
                                            insertCmd.Parameters.AddWithValue("@CreditScore", reader["CreditScore"]);
                                            insertCmd.Parameters.AddWithValue("@RBP", reader["RBP"]);
                                            insertCmd.Parameters.AddWithValue("@Interest", reader["Interest"]);
                                            insertCmd.Parameters.AddWithValue("@Percent", reader["Percent"]);
                                            insertCmd.Parameters.AddWithValue("@CreditLimit", reader["CreditLimit"]);
                                            insertCmd.Parameters.AddWithValue("@MonthlyPayment", reader["MonthlyPayment"]);
                                            insertCmd.Parameters.AddWithValue("@TotalRepayment", reader["TotalRepayment"]); 
                                            insertCmd.Parameters.AddWithValue("@RBP_Interest", reader["RBP_Interest"]);
                                            insertCmd.Parameters.AddWithValue("@RBP_Percent", reader["RBP_Percent"]);
                                            insertCmd.Parameters.AddWithValue("@RBP_MonthlyPayment", reader["RBP_MonthlyPayment"]);
                                            insertCmd.Parameters.AddWithValue("@RBP_TotalRepayment", reader["RBP_TotalRepayment"]);
                                            insertCmd.Parameters.AddWithValue("@OutstandingBalance", reader["OutstandingBalance"]);
                                            insertCmd.Parameters.AddWithValue("@totalPrincipalPaid", reader["totalPrincipalPaid"]);
                                            insertCmd.Parameters.AddWithValue("@paymentTrack", reader["paymentTrack"]);
                                            insertCmd.Parameters.AddWithValue("@TransferDate", reader["TransferDate"]);
                                            insertCmd.Parameters.AddWithValue("@nextPaymentDate", reader["nextPaymentDate"]);     

                                            insertCmd.ExecuteNonQuery();
                                        }

                                        using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn))
                                        {
                                            deleteCmd.Parameters.AddWithValue("@Id", reader["Id"]);
                                            deleteCmd.ExecuteNonQuery();
                                        }

                                        MessageBox.Show($"Record for {fullName} moved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        LoadRepaymentData();
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show($"Error moving record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database operation failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
}
