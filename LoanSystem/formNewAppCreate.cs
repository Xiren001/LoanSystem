using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoanSystem
{
    public partial class newAppCreate : Form
    {

        public newAppCreate()
        {
            InitializeComponent();
        }

        private void newAppCreate_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateNewApp_Click(object sender, EventArgs e)
        {
            // Validate inputs (Add your validation logic here)
            if (string.IsNullOrWhiteSpace(lastName.Text) || string.IsNullOrWhiteSpace(firstName.Text))
            {
                MessageBox.Show("First Name and Last Name are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Database connection string
            string connectionString = "Data Source=XIREN\\SQLEXPRESS;Initial Catalog=LoanWise;Integrated Security=True;Encrypt=True; TrustServerCertificate=True;"; // Replace with your actual connection string

            // SQL query to insert data
            string query = @"
        INSERT INTO newapplication (
            lastname, firstname, middlename, dob, gender, martialstatus, idtype, idnumber, 
            phonenumber, email, address, employername, employmentstatus, position, annualincome, 
            yearsemployment, employercontact, incomeproof, identtityproof, collateraldocument, 
            loantype, amount, loanpurpose, repaymentterm, collateraltype, estimatedvalue, 
            collateraldescription, monthlyincome, expenses, applicationdate
        ) 
        VALUES (
            @LastName, @FirstName, @MiddleName, @DOB, @Gender, @MartialStatus, @IdType, @IdNumber, 
            @PhoneNumber, @Email, @Address, @EmployerName, @EmploymentStatus, @Position, @AnnualIncome, 
            @YearsEmployment, @EmployerContact, @IncomeProof, @IdentityProof, @CollateralDocument, 
            @LoanType, @Amount, @LoanPurpose, @RepaymentTerm, @CollateralType, @EstimatedValue, 
            @CollateralDescription, @MonthlyIncome, @Expenses, @ApplicationDate
        )";

            // Connect to the database and execute the query
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to prevent SQL injection
                        command.Parameters.AddWithValue("@LastName", lastName.Text);
                        command.Parameters.AddWithValue("@FirstName", firstName.Text);
                        command.Parameters.AddWithValue("@MiddleName", middleName.Text);
                        command.Parameters.AddWithValue("@DOB", birthdate.Value);
                        command.Parameters.AddWithValue("@Gender", gender.SelectedItem?.ToString());
                        command.Parameters.AddWithValue("@MartialStatus", martialStatus.SelectedItem?.ToString());
                        command.Parameters.AddWithValue("@IdType", idType.SelectedItem?.ToString());
                        command.Parameters.AddWithValue("@IdNumber", idNumber.Text);
                        command.Parameters.AddWithValue("@PhoneNumber", phoneNumber.Text);
                        command.Parameters.AddWithValue("@Email", email.Text);
                        command.Parameters.AddWithValue("@Address", address.Text);
                        command.Parameters.AddWithValue("@EmployerName", employerName.Text);
                        command.Parameters.AddWithValue("@EmploymentStatus", employmentStatus.SelectedItem?.ToString());
                        command.Parameters.AddWithValue("@Position", position.Text);
                        command.Parameters.AddWithValue("@AnnualIncome", annualIncome.SelectedItem?.ToString());
                        command.Parameters.AddWithValue("@YearsEmployment", yearEmployment.SelectedItem?.ToString());
                        command.Parameters.AddWithValue("@EmployerContact", employerContact.Text);
                        command.Parameters.AddWithValue("@IncomeProof", incomeProof.Checked ? 1 : 0);
                        command.Parameters.AddWithValue("@IdentityProof", identityProof.Checked ? 1 : 0);
                        command.Parameters.AddWithValue("@CollateralDocument", collateralDocument.Checked ? 1 : 0);
                        command.Parameters.AddWithValue("@LoanType", loanType.SelectedItem?.ToString());
                        command.Parameters.AddWithValue("@Amount", amountLoan.Text);
                        command.Parameters.AddWithValue("@LoanPurpose", loanPurpose.SelectedItem?.ToString());
                        command.Parameters.AddWithValue("@RepaymentTerm", repaymentTerm.SelectedItem?.ToString());
                        command.Parameters.AddWithValue("@CollateralType", collateralType.SelectedItem?.ToString());
                        command.Parameters.AddWithValue("@EstimatedValue", estematedValue.Text);
                        command.Parameters.AddWithValue("@CollateralDescription", collateralDesription.Text);
                        command.Parameters.AddWithValue("@MonthlyIncome", monthlyIncome.Text);
                        command.Parameters.AddWithValue("@Expenses", expenses.Text);
                        command.Parameters.AddWithValue("@ApplicationDate", applicationdate.Value);

                        // Execute the query
                        command.ExecuteNonQuery();
                        MessageBox.Show("Application created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Optionally reset the form or navigate to another screen
                        this.Close(); // Close the current form
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btnCancelNewApp_Click(object sender, EventArgs e)
        {
            formNewApp newAppForm = new formNewApp();   
            newAppForm.MdiParent = this.MdiParent;    
            newAppForm.Dock = DockStyle.Fill;         
            newAppForm.Show();                        
            this.Close();                            
        }


    }
}
