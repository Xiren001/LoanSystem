using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoanSystem
{
    public partial class formPending : Form
    {

        private int? currentSelectedId = null; // Stores the currently selected ID
        private int? previousSelectedId = null; // Tracks the previously selected ID

        public formPending()
        {
            InitializeComponent();
            this.FormClosing += FormPending_FormClosing;
        }

        private void formPending_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;

            // Load data into DataGridView when the form loads
            LoadData();

            // Attach SelectionChanged event handler
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;

            dataGridView1.CellFormatting += DataGridView1_CellFormatting;
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) // Ensure a row is selected
            {
                var selectedRow = dataGridView1.SelectedRows[0];

                // Get the selected ID and status
                if (int.TryParse(selectedRow.Cells["idColumn"].Value?.ToString(), out int selectedId))
                {
                    string currentStatus = selectedRow.Cells["statusColumn"].Value?.ToString();

                    // Skip updating to "On KYC" if the status is "Approved" or "Rejected"
                    if (currentStatus == "Approved" || currentStatus == "Rejected")
                    {
                        return;
                    }

                    // Revert the status of the previously selected row if necessary
                    if (previousSelectedId != null && previousSelectedId != selectedId)
                    {
                        // Get the status of the previous row
                        var previousRow = dataGridView1.Rows.Cast<DataGridViewRow>()
                                               .FirstOrDefault(r => r.Cells["idColumn"].Value.ToString() == previousSelectedId.ToString());

                        if (previousRow != null)
                        {
                            string previousStatus = previousRow.Cells["statusColumn"].Value?.ToString();

                            // Only revert the status if it is "On KYC"
                            if (previousStatus == "On KYC")
                            {
                                UpdateRowStatus(previousSelectedId.Value, "Pending");
                                previousRow.Cells["statusColumn"].Value = "Pending";
                            }
                        }
                    }

                    // Update the status of the currently selected row to "On KYC"
                    UpdateRowStatus(selectedId, "On KYC");
                    selectedRow.Cells["statusColumn"].Value = "On KYC";

                    // Load full details for the selected ID
                    LoadFullDetailsById(selectedId);

                    // Update tracking variables
                    previousSelectedId = currentSelectedId; // Set the previous ID to the last current ID
                    currentSelectedId = selectedId;         // Set the current ID to the newly selected ID
                }
                else
                {
                    MessageBox.Show("Invalid ID selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // If no row is selected, clear selection and labels
                ClearPanelLabels();
                currentSelectedId = null;
                previousSelectedId = null;
            }
        }

        private void UpdateRowStatus(int id, string status)
        {
            // Connection string - replace with your database details
            string connectionString = "Data Source=XIREN\\SQLEXPRESS;Initial Catalog=LoanWise;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";

            try
            {
                // SQL query to update the status of the row
                string query = "UPDATE newapplication SET status = @Status WHERE id = @Id";

                // Establish a connection to the SQL Server
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Prepare the SQL command
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Add parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@Status", status);
                        cmd.Parameters.AddWithValue("@Id", id);

                        // Execute the query
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any errors during the update operation
                MessageBox.Show($"An error occurred while updating the status: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pendingUpdateStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (currentSelectedId == null)
            {
                MessageBox.Show("Please select an application first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedStatus = pendingUpdateStatus.SelectedItem?.ToString();
            if (string.IsNullOrWhiteSpace(selectedStatus) || (selectedStatus != "Approved" && selectedStatus != "Rejected"))
            {
                pendingUpdateStatus.Text = "Operation"; // Reset dropdown
                MessageBox.Show("Invalid status selected. Please choose Approved or Rejected.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string targetTable = selectedStatus == "Approved" ? "approvedApplications" : "rejectedApplications";
                string connectionString = "Data Source=XIREN\\SQLEXPRESS;Initial Catalog=LoanWise;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            // Fetch data
                            string fetchQuery = "SELECT * FROM newapplication WHERE id = @Id";
                            string insertQuery = $@"
                INSERT INTO {targetTable} (
                    lastname, firstname, middlename, dob, gender, martialstatus, idtype, idnumber,
                    phonenumber, email, address, employername, employmentstatus, position, annualincome,
                    yearsemployment, employercontact, incomeproof, identtityproof, collateraldocument,
                    loantype, amount, loanpurpose, repaymentterm, collateraltype, estimatedvalue, 
                    collateraldescription, monthlyincome, expenses, applicationdate, 
                    CreditScore, RBP, Interest, [Percent], CreditLimit, 
                    MonthlyPayment, TotalRepayment, RBP_Interest, RBP_Percent, 
                    RBP_MonthlyPayment, RBP_TotalRepayment
                )
                VALUES (
                    @Lastname, @Firstname, @Middlename, @DOB, @Gender, @MaritalStatus, @IdType, @IdNumber,
                    @PhoneNumber, @Email, @Address, @EmployerName, @EmploymentStatus, @Position, @AnnualIncome,
                    @YearsEmployment, @EmployerContact, @IncomeProof, @IdentityProof, @CollateralDocument,
                    @LoanType, @Amount, @LoanPurpose, @RepaymentTerm, @CollateralType, @EstimatedValue, 
                    @CollateralDescription, @MonthlyIncome, @Expenses, @ApplicationDate, 
                    @CreditScore, @RBP, @Interest, @Percent, @CreditLimit, 
                    @MonthlyPayment, @TotalRepayment, @RBP_Interest, @RBP_Percent, 
                    @RBP_MonthlyPayment, @RBP_TotalRepayment
                )";

                            string clientInsertQuery = @"
                        INSERT INTO client (
                            lastname, firstname, middlename, dob, gender, martialstatus, idtype, idnumber,
                            phonenumber, email, address, employername, employmentstatus, position, annualincome,
                    yearsemployment, employercontact, loantype, amount, loanpurpose, repaymentterm, collateraltype, estimatedvalue, 
                    collateraldescription, monthlyincome, expenses, applicationdate, 
                    CreditScore,CreditLimit, MonthlyPayment, TotalRepayment
                        )
                        VALUES (
                            @Lastname, @Firstname, @Middlename, @DOB, @Gender, @MaritalStatus, @IdType, @IdNumber,
                            @PhoneNumber, @Email, @Address, @EmployerName, @EmploymentStatus, @Position, @AnnualIncome,
                    @YearsEmployment, @EmployerContact, @LoanType, @Amount, @LoanPurpose, @RepaymentTerm, @CollateralType, @EstimatedValue, 
                    @CollateralDescription, @MonthlyIncome, @Expenses, @ApplicationDate, 
                    @CreditScore,@CreditLimit, @MonthlyPayment, @TotalRepayment
                        )";


                            string deleteQuery = "DELETE FROM newapplication WHERE id = @Id";

                            Dictionary<string, object> parameters = new Dictionary<string, object>();

                            using (SqlCommand fetchCmd = new SqlCommand(fetchQuery, conn, transaction))
                            {
                                fetchCmd.Parameters.AddWithValue("@Id", currentSelectedId.Value);
                                using (SqlDataReader reader = fetchCmd.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        // Map columns to parameters
                                        // Use reader.IsDBNull() to handle NULL values safely
                                        parameters["@Lastname"] = reader["lastname"];
                                        parameters["@Firstname"] = reader["firstname"];
                                        parameters["@Middlename"] = reader["middlename"];
                                        parameters["@DOB"] = reader["dob"];
                                        parameters["@Gender"] = reader["gender"];
                                        parameters["@MaritalStatus"] = reader["martialstatus"];
                                        parameters["@IdType"] = reader["idtype"];
                                        parameters["@IdNumber"] = reader["idnumber"];
                                        parameters["@PhoneNumber"] = reader["phonenumber"];
                                        parameters["@Email"] = reader["email"];
                                        parameters["@Address"] = reader["address"];
                                        parameters["@EmployerName"] = reader["employername"];
                                        parameters["@EmploymentStatus"] = reader["employmentstatus"];
                                        parameters["@Position"] = reader["position"];
                                        parameters["@AnnualIncome"] = reader["annualincome"];
                                        parameters["@YearsEmployment"] = reader["yearsemployment"];
                                        parameters["@EmployerContact"] = reader["employercontact"];
                                        parameters["@IncomeProof"] = reader["incomeproof"];
                                        parameters["@IdentityProof"] = reader["identtityproof"];
                                        parameters["@CollateralDocument"] = reader["collateraldocument"];
                                        parameters["@LoanType"] = reader["loantype"];
                                        parameters["@Amount"] = reader["amount"];
                                        parameters["@LoanPurpose"] = reader["loanpurpose"];
                                        parameters["@RepaymentTerm"] = reader["repaymentterm"];
                                        parameters["@CollateralType"] = reader["collateraltype"];
                                        parameters["@EstimatedValue"] = reader["estimatedvalue"];
                                        parameters["@CollateralDescription"] = reader["collateraldescription"];
                                        parameters["@MonthlyIncome"] = reader["monthlyincome"];
                                        parameters["@Expenses"] = reader["expenses"];
                                        parameters["@ApplicationDate"] = reader["applicationdate"];

                                        parameters["@CreditScore"] = pendingCreditScore.Text;
                                        parameters["@RBP"] = pendingRBP.Text;
                                        parameters["@Interest"] = pendingInterest.Text;
                                        parameters["@Percent"] = pendingPercent.Text;
                                        parameters["@CreditLimit"] = pendingCreditLimit.Text;
                                        parameters["@MonthlyPayment"] = pendingMonthlyPayment.Text;
                                        parameters["@TotalRepayment"] = pendingTotalRepayment.Text;
                                        parameters["@RBP_Interest"] = interestRBP.Text;
                                        parameters["@RBP_Percent"] = percentRBP.Text;
                                        parameters["@RBP_MonthlyPayment"] = monthlyRBP.Text;
                                        parameters["@RBP_TotalRepayment"] = repaymentRBP.Text;

                                        //parameters["@CreditScore"] = creditScore;
                                        //parameters["@RBP"] = recommendedAmount;
                                        //parameters["@Interest"] = totalInterest;
                                        //parameters["@Percent"] = interestPercentage;
                                        //parameters["@CreditLimit"] = finalCreditLimit;
                                        //parameters["@MonthlyPayment"] = monthlyPayment;
                                        //parameters["@TotalRepayment"] = totalRepayment;
                                        //parameters["@RBP_Interest"] = rbpTotalInterest;
                                        //parameters["@RBP_Percent"] = rbpInterestPercentage;
                                        //parameters["@RBP_MonthlyPayment"] = rbpMonthlyPayment;
                                        //parameters["@RBP_TotalRepayment"] = rbpTotalRepayment;
                                    }
                                    else
                                    {
                                        throw new Exception("Application not found.");
                                    }
                                }
                            }

                            // Insert data
                            using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn, transaction))
                            {
                                foreach (var param in parameters)
                                    insertCmd.Parameters.AddWithValue(param.Key, param.Value);
                                insertCmd.ExecuteNonQuery();
                            }


                            // Insert data into client table (only if Approved)
                            if (selectedStatus == "Approved")
                            {
                                using (SqlCommand clientInsertCmd = new SqlCommand(clientInsertQuery, conn, transaction))
                                {
                                    clientInsertCmd.Parameters.AddWithValue("@Lastname", parameters["@Lastname"]);
                                    clientInsertCmd.Parameters.AddWithValue("@Firstname", parameters["@Firstname"]);
                                    clientInsertCmd.Parameters.AddWithValue("@Middlename", parameters["@Middlename"]);
                                    clientInsertCmd.Parameters.AddWithValue("@DOB", parameters["@DOB"]);
                                    clientInsertCmd.Parameters.AddWithValue("@Gender", parameters["@Gender"]);
                                    clientInsertCmd.Parameters.AddWithValue("@MaritalStatus", parameters["@MaritalStatus"]);
                                    clientInsertCmd.Parameters.AddWithValue("@IdType", parameters["@IdType"]);
                                    clientInsertCmd.Parameters.AddWithValue("@IdNumber", parameters["@IdNumber"]);
                                    clientInsertCmd.Parameters.AddWithValue("@PhoneNumber", parameters["@PhoneNumber"]);
                                    clientInsertCmd.Parameters.AddWithValue("@Email", parameters["@Email"]);
                                    clientInsertCmd.Parameters.AddWithValue("@Address", parameters["@Address"]);
                                    clientInsertCmd.Parameters.AddWithValue("@EmployerName", parameters["@EmployerName"]);
                                    clientInsertCmd.Parameters.AddWithValue("@EmploymentStatus", parameters["@EmploymentStatus"]);
                                    clientInsertCmd.Parameters.AddWithValue("@Position", parameters["@Position"]);
                                    clientInsertCmd.Parameters.AddWithValue("@AnnualIncome", parameters["@AnnualIncome"]);
                                    clientInsertCmd.Parameters.AddWithValue("@YearsEmployment", parameters["@YearsEmployment"]);
                                    clientInsertCmd.Parameters.AddWithValue("@EmployerContact", parameters["@EmployerContact"]);
                                    clientInsertCmd.Parameters.AddWithValue("@LoanType", parameters["@LoanType"]);
                                    clientInsertCmd.Parameters.AddWithValue("@Amount", parameters["@Amount"]);
                                    clientInsertCmd.Parameters.AddWithValue("@LoanPurpose", parameters["@LoanPurpose"]);
                                    clientInsertCmd.Parameters.AddWithValue("@RepaymentTerm", parameters["@RepaymentTerm"]);
                                    clientInsertCmd.Parameters.AddWithValue("@CollateralType", parameters["@CollateralType"]);
                                    clientInsertCmd.Parameters.AddWithValue("@EstimatedValue", parameters["@EstimatedValue"]);
                                    clientInsertCmd.Parameters.AddWithValue("@CollateralDescription", parameters["@CollateralDescription"]);
                                    clientInsertCmd.Parameters.AddWithValue("@MonthlyIncome", parameters["@MonthlyIncome"]);
                                    clientInsertCmd.Parameters.AddWithValue("@Expenses", parameters["@Expenses"]);
                                    clientInsertCmd.Parameters.AddWithValue("@ApplicationDate", parameters["@ApplicationDate"]);
                                    clientInsertCmd.Parameters.AddWithValue("@CreditScore", parameters["@CreditScore"]);
                                    clientInsertCmd.Parameters.AddWithValue("@CreditLimit", parameters["@CreditLimit"]);
                                    clientInsertCmd.Parameters.AddWithValue("@MonthlyPayment", parameters["@MonthlyPayment"]);
                                    clientInsertCmd.Parameters.AddWithValue("@TotalRepayment", parameters["@TotalRepayment"]);

                                    clientInsertCmd.ExecuteNonQuery();
                                }
                            }

                            // Delete old record
                            using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn, transaction))
                            {
                                deleteCmd.Parameters.AddWithValue("@Id", currentSelectedId.Value);
                                deleteCmd.ExecuteNonQuery();
                            }

                            transaction.Commit();
                        }
                        catch
                        {
                            transaction.Rollback();
                            throw;
                        }
                    }
                }

                MessageBox.Show($"Application successfully moved to '{targetTable}'.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData(); // Refresh UI
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Check if the current column is the status column
            if (dataGridView1.Columns[e.ColumnIndex].Name == "statusColumn" && e.Value != null)
            {
                string status = e.Value.ToString();

                if (status == "Pending")
                {
                    e.CellStyle.BackColor = Color.Khaki;  // Set the background color to yellow
                    e.CellStyle.ForeColor = Color.Black;  // Ensure the text is readable
                }
                else if (status == "On KYC")
                {
                    e.CellStyle.BackColor = Color.LightGray; // Set the background color to light gray
                    e.CellStyle.ForeColor = Color.Black;    // Ensure the text is readable
                }
                else if (status == "Approved")
                {
                    e.CellStyle.BackColor = Color.SeaGreen; // Set the background color to light gray
                    e.CellStyle.ForeColor = Color.White;    // Ensure the text is readable
                }
                else if (status == "Rejected")
                {
                    e.CellStyle.BackColor = Color.IndianRed; // Set the background color to light gray
                    e.CellStyle.ForeColor = Color.White;    // Ensure the text is readable
                }
            }
        }


        private void ClearPanelLabels()
        {
            pendingApplicationId.Text = "N/A";
            pendingApplicantName.Text = "N/A";
            pendingLoanAmount.Text = "N/A";
            pendingStatus.Text = "N/A";
            pendingRepaymentTerm.Text = "N/A";

            // Add clearing for other labels if necessary
        }

        private void LoadFullDetailsById(int selectedId)
        {
            string connectionString = "Data Source=XIREN\\SQLEXPRESS;Initial Catalog=LoanWise;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";

            try
            {
                string query = "SELECT * FROM newapplication WHERE id = @Id";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", selectedId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Basic Information
                                string firstname = reader["firstname"].ToString();
                                string middlename = reader["middlename"].ToString();
                                string lastname = reader["lastname"].ToString();
                                string number = reader["phonenumber"].ToString();
                                decimal loanAmount = reader["amount"] != DBNull.Value ? Convert.ToDecimal(reader["amount"]) : 0;

                                // Populate Labels
                                pendingApplicationId.Text = reader["id"].ToString();
                                pendingApplicantName.Text = $"{firstname} {middlename} {lastname}".Trim();
                                pendingPhoneNumber.Text = $"+63{number}".Trim();
                                pendingLastName.Text = lastname;
                                pendingFirstName.Text = firstname;
                                pendingMiddleName.Text = middlename;
                                pendingId.Text = reader["idtype"].ToString();
                                pendingGender.Text = reader["gender"].ToString();
                                pendingAddress.Text = reader["address"].ToString();
                                pendingEmail.Text = reader["email"].ToString();
                                pendingLoanAmount.Text = $"₱{loanAmount:N2}";
                                pendingStatus.Text = reader["status"].ToString();
                                pendingRepaymentTerm.Text = reader["repaymentterm"].ToString();
                                pendingRepaymentTerm2.Text = reader["repaymentterm"].ToString();

                                // Employment Details
                                pendingEmployeName.Text = reader["employername"].ToString();
                                pendingEmployementStatus.Text = reader["employmentstatus"].ToString();
                                pendingPosition.Text = reader["position"].ToString();
                                pendingIncome.Text = reader["annualincome"].ToString();
                                pendingYear.Text = reader["yearsemployment"].ToString();



                                // Credit Scoring Fields
                                decimal annualIncome = reader["annualincome"] != DBNull.Value ? Convert.ToDecimal(reader["annualincome"]) : 0;
                                decimal monthlyIncome = reader["monthlyincome"] != DBNull.Value ? Convert.ToDecimal(reader["monthlyincome"]) : 0;
                                decimal expenses = reader["expenses"] != DBNull.Value ? Convert.ToDecimal(reader["expenses"]) : 0;
                                decimal estimatedValue = reader["estimatedvalue"] != DBNull.Value ? Convert.ToDecimal(reader["estimatedvalue"]) : 0;
                                string employmentStatus = reader["employmentstatus"].ToString();
                                int yearsEmployment = reader["yearsemployment"] != DBNull.Value ? Convert.ToInt32(reader["yearsemployment"]) : 0;
                                string loanPurpose = reader["loanpurpose"].ToString();
                                string loanType = reader["loantype"].ToString();

                                string repaymentTermString = reader["repaymentterm"].ToString(); // Read the value from the database
                                decimal repaymentTerm = 0;

                                if (!string.IsNullOrWhiteSpace(repaymentTermString))
                                {
                                    string numericPart = Regex.Match(repaymentTermString, @"\d+").Value;

                                    if (!string.IsNullOrWhiteSpace(numericPart))
                                    {
                                        repaymentTerm = Convert.ToDecimal(numericPart); // Months
                                    }
                                }

                                // Calculate Interest Rate, Monthly Payment, Total Repayment, and Interest Percentage
                                decimal annualInterestRate = 10; // Example: 10% annual interest rate
                                decimal monthlyInterestRate = annualInterestRate / 100 / 12;
                                decimal denominator = (decimal)(Math.Pow((double)(1 + monthlyInterestRate), (double)repaymentTerm) - 1);
                                decimal monthlyPayment = loanAmount * (monthlyInterestRate + (monthlyInterestRate / denominator));
                                decimal totalRepayment = monthlyPayment * repaymentTerm;
                                decimal totalInterest = totalRepayment - loanAmount;
                                decimal interestPercentage = totalInterest / loanAmount * 100;

                                // Populate the new fields
                                pendingMonthlyPayment.Text = $"₱{monthlyPayment:N2}";
                                pendingTotalRepayment.Text = $"₱{totalRepayment:N2}";
                                pendingInterest.Text = $"₱{totalInterest:N2}";
                                pendingPercent.Text = $"{interestPercentage:N2}%";

                                // Step 1: Assess Financial Capacity
                                decimal mdi = monthlyIncome - expenses; // Monthly Disposable Income
                                decimal repaymentPercentage = 0.4M; // Example: 40% of MDI
                                decimal repaymentCapacity = mdi * repaymentPercentage;
                                decimal creditLimitIncomeBased = repaymentCapacity * (repaymentTerm / 12);

                                // Step 2: Evaluate Collateral
                                decimal ltvRatio = 0.8M; // Example: 80% Loan-to-Value ratio
                                decimal creditLimitCollateralBased = estimatedValue * ltvRatio;

                                // Final Credit Limit
                                decimal finalCreditLimit = Math.Max(creditLimitIncomeBased, creditLimitCollateralBased);

                                // Display Final Credit Limit
                                pendingCreditLimit.Text = $"₱{finalCreditLimit:N2}";

                                // Step 3: Debt-to-Income Ratio (DTI)
                                decimal dti = monthlyIncome > 0 ? (expenses / monthlyIncome) * 100 : 0;

                                // Step 4: Credit Score Calculation
                                int creditScore = 0;
                                creditScore += annualIncome >= 500000 ? 20 : 10; // Maximum: 20
                                creditScore += dti <= 30 ? 15 : (dti <= 50 ? 10 : 5); // Maximum: 15
                                creditScore += employmentStatus == "Full-time" && yearsEmployment >= 3 ? 10 : 5; // Maximum: 10

                                creditScore += loanPurpose.ToLower() == "home renovation" || loanPurpose.ToLower() == "essential" ? 10 : 5; // Maximum: 10
                                creditScore += estimatedValue > loanAmount ? 10 : 0; // Maximum: 10

                                switch (loanType.ToLower())
                                {
                                    case "Personal loan": creditScore += 5; break; // Maximum: 5
                                    case "Home loan": creditScore += 10; break; // Maximum: 10
                                    case "Car loan": creditScore += 8; break; // Maximum: 8
                                    case "Business loan": creditScore += 15; break; // Maximum: 15
                                    case "Educational loan": creditScore += 7; break; // Maximum: 7
                                }

                                creditScore += repaymentTerm <= 12 ? 10 : repaymentTerm <= 36 ? 8 : repaymentTerm <= 60 ? 5 : 3; // Maximum: 10

                                string creditColor = creditScore >= 80 ? "Green Zone" :
                                                     creditScore >= 50 ? "Yellow Zone" :
                                                     creditScore >= 30 ? "Orange Zone" : "Red Zone";

                                string rbp = creditColor == "Green Zone" ? "Low Risk" :
                                             creditColor == "Yellow Zone" ? "Medium Risk" :
                                             creditColor == "Orange Zone" ? "Moderate Risk" : "High Risk";

                                decimal recommendedAmount = creditScore >= 80 ? loanAmount :
                                                            creditScore >= 50 ? loanAmount * 0.75M :
                                                            creditScore >= 30 ? loanAmount * 0.50M : loanAmount * 0.25M;

                                rbp += $" - ₱{recommendedAmount:N2}";

                                // Calculate RBP Values
                                decimal rbpMonthlyPayment = recommendedAmount * (monthlyInterestRate + (monthlyInterestRate / denominator));
                                decimal rbpTotalRepayment = rbpMonthlyPayment * repaymentTerm;
                                decimal rbpTotalInterest = rbpTotalRepayment - recommendedAmount;
                                decimal rbpInterestPercentage = rbpTotalInterest / recommendedAmount * 100;

                                // Update RBP Labels
                                repaymentRBP.Text = $"₱{rbpTotalRepayment:N2}";
                                monthlyRBP.Text = $"₱{rbpMonthlyPayment:N2}";
                                interestRBP.Text = $"₱{rbpTotalInterest:N2}";
                                percentRBP.Text = $"{rbpInterestPercentage:N2}%";

                                pendingCreditScore.Text = creditScore.ToString();
                                pendingRBP.Text = rbp;
                                pendingCreditColor.Text = creditColor;

                                pendingCreditPanel.BackColor = creditColor == "Green Zone" ? Color.SeaGreen :
                                                                creditColor == "Yellow Zone" ? Color.Khaki :
                                                                creditColor == "Orange Zone" ? Color.Orange :
                                                                Color.IndianRed;
                            }
                            else
                            {
                                ClearPanelLabels();
                                MessageBox.Show("No details found for the selected ID.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while retrieving details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormPending_FormClosing(object sender, FormClosingEventArgs e)
        {
            RevertOnKYCToPending();
        }

        private void RevertOnKYCToPending()
        {
            string connectionString = "Data Source=XIREN\\SQLEXPRESS;Initial Catalog=LoanWise;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";

            try
            {
                // SQL query to update all "On KYC" statuses to "Pending"
                string query = "UPDATE newapplication SET status = 'Pending' WHERE status = 'On KYC'";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        int rowsAffected = cmd.ExecuteNonQuery(); // Execute the update
                        if (rowsAffected > 0)
                        {
                            Console.WriteLine($"{rowsAffected} rows updated to 'Pending' status.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions during the update process
                MessageBox.Show($"An error occurred while reverting statuses: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private bool isColumnsConfigured = false; // Track whether columns are already configured

        private void LoadData()
        {
            // Connection string - replace with your database details
            string connectionString = "Data Source=XIREN\\SQLEXPRESS;Initial Catalog=LoanWise;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";

            try
            {
                // SQL query to retrieve data
                string query = "SELECT id, lastname, status FROM newapplication WHERE status IN ('Pending', 'On KYC')";

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

                    // Configure columns only once
                    if (!isColumnsConfigured)
                    {
                        ConfigureDataGridViewColumns();
                        isColumnsConfigured = true; // Mark columns as configured
                    }
                }
            }
            catch (Exception ex)
            {
                // Show error message
                MessageBox.Show($"An error occurred while loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigureDataGridViewColumns()
        {
            // Ensure DataGridView does not auto-generate columns
            dataGridView1.AutoGenerateColumns = false;

            dataGridView1.Columns.Clear();

            // Set DataGridView to fill all columns proportionally
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            // Configure columns with proper DataPropertyName
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Application ID",
                DataPropertyName = "id", // Match database column
                Name = "idColumn"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Applicant Name",
                DataPropertyName = "lastname", // Match database column
                Name = "applicantNameColumn"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Verification Status",
                DataPropertyName = "status", // Match database column
                Name = "statusColumn"
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
