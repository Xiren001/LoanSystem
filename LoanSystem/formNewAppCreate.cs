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

        private int applicationId = 0; // Default to 0 for Create mode


        public newAppCreate()
        {
            InitializeComponent();
        }


        // Constructor for update mode
        public newAppCreate(int id) : this() // Calls the default constructor
        {
            applicationId = id;
            LoadApplicationData(); // Load data into the form fields
        }

        private void LoadApplicationData()
        {
            // Database connection string
            string connectionString = "Data Source=XIREN\\SQLEXPRESS;Initial Catalog=LoanWise;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";

            // Query to fetch all data for the selected application
            string query = "SELECT * FROM newapplication WHERE id = @Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", applicationId);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Populate fields with data from the database
                                lastName.Text = reader["lastname"].ToString();
                                firstName.Text = reader["firstname"].ToString();
                                middleName.Text = reader["middlename"].ToString();
                                birthdate.Value = Convert.ToDateTime(reader["dob"]);
                                gender.SelectedItem = reader["gender"].ToString();
                                martialStatus.SelectedItem = reader["martialstatus"].ToString();
                                idType.SelectedItem = reader["idtype"].ToString();
                                idNumber.Text = reader["idnumber"].ToString();
                                phoneNumber.Text = reader["phonenumber"].ToString();
                                email.Text = reader["email"].ToString();
                                address.Text = reader["address"].ToString();
                                employerName.Text = reader["employername"].ToString();
                                employmentStatus.SelectedItem = reader["employmentstatus"].ToString();
                                position.Text = reader["position"].ToString();
                                annualIncome.SelectedItem = reader["annualincome"].ToString();
                                yearEmployment.SelectedItem = reader["yearsemployment"].ToString();
                                employerContact.Text = reader["employercontact"].ToString();
                                incomeProof.Checked = Convert.ToBoolean(reader["incomeproof"]);
                                identityProof.Checked = Convert.ToBoolean(reader["identtityproof"]);
                                collateralDocument.Checked = Convert.ToBoolean(reader["collateraldocument"]);
                                loanType.SelectedItem = reader["loantype"].ToString();
                                amountLoan.Text = reader["amount"].ToString();
                                loanPurpose.SelectedItem = reader["loanpurpose"].ToString();
                                repaymentTerm.SelectedItem = reader["repaymentterm"].ToString();
                                collateralType.SelectedItem = reader["collateraltype"].ToString();
                                estematedValue.Text = reader["estimatedvalue"].ToString();
                                collateralDesription.Text = reader["collateraldescription"].ToString();
                                monthlyIncome.Text = reader["monthlyincome"].ToString();
                                expenses.Text = reader["expenses"].ToString();
                                applicationdate.Value = Convert.ToDateTime(reader["applicationdate"]);
                            }
                            else
                            {
                                MessageBox.Show("Application not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void newAppCreate_Load(object sender, EventArgs e)
        {
            // Initialize the DateTimePicker with no value
            birthdate.Format = DateTimePickerFormat.Custom;
            birthdate.CustomFormat = " "; // Display as blank initially

            // Attach the ValueChanged event
            birthdate.ValueChanged += dateTimePicker1_ValueChanged;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // Set the format to display the date when a date is selected
            birthdate.Format = DateTimePickerFormat.Short;
        }



        private void btnCreateNewApp_Click(object sender, EventArgs e)
        {
            // Validate inputs (Add your validation logic here)
            if (string.IsNullOrWhiteSpace(lastName.Text) || string.IsNullOrWhiteSpace(firstName.Text))
            {
                MessageBox.Show("First Name and Last Name are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string connectionString = "Data Source=XIREN\\SQLEXPRESS;Initial Catalog=LoanWise;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                if (applicationId == 0) // Create new application
                {
                    string insertQuery = @"
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

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        // Add parameters
                        AddParametersToCommand(command);

                        try
                        {
                            command.ExecuteNonQuery();
                            MessageBox.Show("New application created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Clear all fields after successful creation
                            ClearFields();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error creating application: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else // Update existing application
                {
                    string updateQuery = @"
            UPDATE newapplication 
            SET 
                lastname = @LastName, 
                firstname = @FirstName, 
                middlename = @MiddleName, 
                dob = @DOB, 
                gender = @Gender, 
                martialstatus = @MartialStatus, 
                idtype = @IdType, 
                idnumber = @IdNumber, 
                phonenumber = @PhoneNumber, 
                email = @Email, 
                address = @Address, 
                employername = @EmployerName, 
                employmentstatus = @EmploymentStatus, 
                position = @Position, 
                annualincome = @AnnualIncome, 
                yearsemployment = @YearsEmployment, 
                employercontact = @EmployerContact, 
                incomeproof = @IncomeProof, 
                identtityproof = @IdentityProof, 
                collateraldocument = @CollateralDocument, 
                loantype = @LoanType, 
                amount = @Amount, 
                loanpurpose = @LoanPurpose, 
                repaymentterm = @RepaymentTerm, 
                collateraltype = @CollateralType, 
                estimatedvalue = @EstimatedValue, 
                collateraldescription = @CollateralDescription, 
                monthlyincome = @MonthlyIncome, 
                expenses = @Expenses, 
                applicationdate = @ApplicationDate
            WHERE id = @Id";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        // Add parameters
                        AddParametersToCommand(command);
                        command.Parameters.AddWithValue("@Id", applicationId);

                        try
                        {
                            command.ExecuteNonQuery();
                            MessageBox.Show("Application updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            formNewApp newAppForm = new formNewApp();
                            newAppForm.MdiParent = this.MdiParent;
                            newAppForm.Dock = DockStyle.Fill;
                            newAppForm.Show();
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error updating application: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        // Method to clear all fields
        private void ClearFields()
        {
            lastName.Clear();
            firstName.Clear();
            middleName.Clear();
            birthdate.Format = DateTimePickerFormat.Custom;
            gender.SelectedIndex = -1;
            martialStatus.SelectedIndex = -1;
            idType.SelectedIndex = -1;
            idNumber.Clear();
            phoneNumber.Clear();
            email.Clear();
            address.Clear();
            employerName.Clear();
            employmentStatus.SelectedIndex = -1;
            position.Clear();
            annualIncome.SelectedIndex = -1;
            yearEmployment.SelectedIndex = -1;
            employerContact.Clear();
            incomeProof.Checked = false;
            identityProof.Checked = false;
            collateralDocument.Checked = false;
            loanType.SelectedIndex = -1;
            amountLoan.Clear();
            loanPurpose.SelectedIndex = -1;
            repaymentTerm.SelectedIndex = -1;
            collateralType.SelectedIndex = -1;
            estematedValue.Clear();
            collateralDesription.Clear();
            monthlyIncome.Clear();
            expenses.Clear();
            applicationdate.Value = DateTime.Now;
        }

        // Method to add parameters to the command
        private void AddParametersToCommand(SqlCommand command)
        {
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
