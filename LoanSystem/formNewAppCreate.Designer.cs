namespace LoanSystem
{
    partial class newAppCreate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCancelNewApp = new Button();
            btnCreateNewApp = new Button();
            estematedValue = new TextBox();
            repaymentTerm = new ComboBox();
            collateralDesription = new TextBox();
            expenses = new TextBox();
            collateralType = new ComboBox();
            loanPurpose = new ComboBox();
            collateralDocument = new CheckBox();
            amountLoan = new TextBox();
            monthlyIncome = new TextBox();
            loanType = new ComboBox();
            employerContact = new TextBox();
            label3 = new Label();
            label4 = new Label();
            identityProof = new CheckBox();
            label1 = new Label();
            yearEmployment = new ComboBox();
            fileSystemWatcher1 = new FileSystemWatcher();
            incomeProof = new CheckBox();
            address = new TextBox();
            annualIncome = new ComboBox();
            position = new TextBox();
            email = new TextBox();
            employmentStatus = new ComboBox();
            employerName = new TextBox();
            phoneNumber = new TextBox();
            label2 = new Label();
            idNumber = new TextBox();
            idType = new ComboBox();
            martialStatus = new ComboBox();
            gender = new ComboBox();
            lastName = new TextBox();
            firstName = new TextBox();
            birthdate = new DateTimePicker();
            middleName = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            label23 = new Label();
            label5 = new Label();
            label24 = new Label();
            label25 = new Label();
            label26 = new Label();
            label27 = new Label();
            label28 = new Label();
            label29 = new Label();
            label30 = new Label();
            label31 = new Label();
            label6 = new Label();
            applicationdate = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // btnCancelNewApp
            // 
            btnCancelNewApp.BackColor = Color.Gray;
            btnCancelNewApp.Font = new Font("Tahoma", 12F);
            btnCancelNewApp.ForeColor = Color.White;
            btnCancelNewApp.Location = new Point(781, 513);
            btnCancelNewApp.Name = "btnCancelNewApp";
            btnCancelNewApp.Size = new Size(133, 40);
            btnCancelNewApp.TabIndex = 53;
            btnCancelNewApp.Text = "Cancel";
            btnCancelNewApp.UseVisualStyleBackColor = false;
            btnCancelNewApp.Click += btnCancelNewApp_Click;
            // 
            // btnCreateNewApp
            // 
            btnCreateNewApp.BackColor = Color.SeaGreen;
            btnCreateNewApp.Font = new Font("Tahoma", 12F);
            btnCreateNewApp.ForeColor = Color.White;
            btnCreateNewApp.Location = new Point(920, 513);
            btnCreateNewApp.Name = "btnCreateNewApp";
            btnCreateNewApp.Size = new Size(133, 40);
            btnCreateNewApp.TabIndex = 52;
            btnCreateNewApp.Text = "Create";
            btnCreateNewApp.UseVisualStyleBackColor = false;
            btnCreateNewApp.Click += btnCreateNewApp_Click;
            // 
            // estematedValue
            // 
            estematedValue.BorderStyle = BorderStyle.FixedSingle;
            estematedValue.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            estematedValue.Location = new Point(581, 389);
            estematedValue.Name = "estematedValue";
            estematedValue.Size = new Size(181, 27);
            estematedValue.TabIndex = 46;
            // 
            // repaymentTerm
            // 
            repaymentTerm.Font = new Font("Tahoma", 11F);
            repaymentTerm.ForeColor = SystemColors.WindowFrame;
            repaymentTerm.FormattingEnabled = true;
            repaymentTerm.Items.AddRange(new object[] { "12 months", "24 months", "36 months" });
            repaymentTerm.Location = new Point(210, 460);
            repaymentTerm.Name = "repaymentTerm";
            repaymentTerm.Size = new Size(163, 26);
            repaymentTerm.TabIndex = 50;
            // 
            // collateralDesription
            // 
            collateralDesription.BorderStyle = BorderStyle.FixedSingle;
            collateralDesription.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            collateralDesription.Location = new Point(407, 459);
            collateralDesription.Name = "collateralDesription";
            collateralDesription.Size = new Size(355, 27);
            collateralDesription.TabIndex = 40;
            // 
            // expenses
            // 
            expenses.BorderStyle = BorderStyle.FixedSingle;
            expenses.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            expenses.Location = new Point(794, 460);
            expenses.Name = "expenses";
            expenses.Size = new Size(258, 27);
            expenses.TabIndex = 32;
            // 
            // collateralType
            // 
            collateralType.Font = new Font("Tahoma", 12F);
            collateralType.ForeColor = SystemColors.WindowFrame;
            collateralType.FormattingEnabled = true;
            collateralType.Items.AddRange(new object[] { "Property", "Vehicle", "Jewelry" });
            collateralType.Location = new Point(407, 389);
            collateralType.Name = "collateralType";
            collateralType.Size = new Size(168, 27);
            collateralType.TabIndex = 36;
            // 
            // loanPurpose
            // 
            loanPurpose.Font = new Font("Tahoma", 12F);
            loanPurpose.ForeColor = SystemColors.WindowFrame;
            loanPurpose.FormattingEnabled = true;
            loanPurpose.Items.AddRange(new object[] { "education", "debt consolidation", "home renovation" });
            loanPurpose.Location = new Point(24, 460);
            loanPurpose.Name = "loanPurpose";
            loanPurpose.Size = new Size(181, 27);
            loanPurpose.TabIndex = 45;
            // 
            // collateralDocument
            // 
            collateralDocument.AutoSize = true;
            collateralDocument.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            collateralDocument.Location = new Point(873, 284);
            collateralDocument.Name = "collateralDocument";
            collateralDocument.Size = new Size(179, 22);
            collateralDocument.TabIndex = 33;
            collateralDocument.Text = "Collateral Document";
            collateralDocument.UseVisualStyleBackColor = true;
            // 
            // amountLoan
            // 
            amountLoan.BorderStyle = BorderStyle.FixedSingle;
            amountLoan.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            amountLoan.Location = new Point(211, 390);
            amountLoan.Name = "amountLoan";
            amountLoan.Size = new Size(162, 27);
            amountLoan.TabIndex = 39;
            // 
            // monthlyIncome
            // 
            monthlyIncome.BorderStyle = BorderStyle.FixedSingle;
            monthlyIncome.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            monthlyIncome.Location = new Point(794, 390);
            monthlyIncome.Name = "monthlyIncome";
            monthlyIncome.Size = new Size(259, 27);
            monthlyIncome.TabIndex = 27;
            // 
            // loanType
            // 
            loanType.Font = new Font("Tahoma", 12F);
            loanType.ForeColor = SystemColors.WindowFrame;
            loanType.FormattingEnabled = true;
            loanType.Items.AddRange(new object[] { "Personal Loan", " Auto Loan", "Home Loan", "Business Loan" });
            loanType.Location = new Point(24, 390);
            loanType.Name = "loanType";
            loanType.Size = new Size(181, 27);
            loanType.TabIndex = 43;
            // 
            // employerContact
            // 
            employerContact.BorderStyle = BorderStyle.FixedSingle;
            employerContact.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            employerContact.Location = new Point(829, 215);
            employerContact.Name = "employerContact";
            employerContact.Size = new Size(224, 27);
            employerContact.TabIndex = 49;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(24, 328);
            label3.Name = "label3";
            label3.Size = new Size(128, 23);
            label3.TabIndex = 19;
            label3.Text = "Loan Details";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(795, 329);
            label4.Name = "label4";
            label4.Size = new Size(216, 23);
            label4.TabIndex = 21;
            label4.Text = "Financial Information";
            // 
            // identityProof
            // 
            identityProof.AutoSize = true;
            identityProof.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            identityProof.Location = new Point(727, 284);
            identityProof.Name = "identityProof";
            identityProof.Size = new Size(132, 22);
            identityProof.TabIndex = 31;
            identityProof.Text = "Identity Proof";
            identityProof.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(24, 18);
            label1.Name = "label1";
            label1.Size = new Size(187, 23);
            label1.TabIndex = 17;
            label1.Text = "Client Information";
            // 
            // yearEmployment
            // 
            yearEmployment.Font = new Font("Tahoma", 12F);
            yearEmployment.ForeColor = SystemColors.WindowFrame;
            yearEmployment.FormattingEnabled = true;
            yearEmployment.Items.AddRange(new object[] { "1", "2", "3", "4", "5+" });
            yearEmployment.Location = new Point(581, 215);
            yearEmployment.Name = "yearEmployment";
            yearEmployment.Size = new Size(242, 27);
            yearEmployment.TabIndex = 44;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // incomeProof
            // 
            incomeProof.AutoSize = true;
            incomeProof.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            incomeProof.Location = new Point(582, 285);
            incomeProof.Name = "incomeProof";
            incomeProof.Size = new Size(127, 22);
            incomeProof.TabIndex = 28;
            incomeProof.Text = "Income Proof";
            incomeProof.UseVisualStyleBackColor = true;
            // 
            // address
            // 
            address.BorderStyle = BorderStyle.FixedSingle;
            address.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            address.Location = new Point(279, 284);
            address.Name = "address";
            address.Size = new Size(268, 27);
            address.TabIndex = 51;
            // 
            // annualIncome
            // 
            annualIncome.Font = new Font("Tahoma", 12F);
            annualIncome.ForeColor = SystemColors.WindowFrame;
            annualIncome.FormattingEnabled = true;
            annualIncome.Items.AddRange(new object[] { "10000 ", "20000", "30000", "40000" });
            annualIncome.Location = new Point(829, 146);
            annualIncome.Name = "annualIncome";
            annualIncome.Size = new Size(223, 27);
            annualIncome.TabIndex = 42;
            // 
            // position
            // 
            position.BorderStyle = BorderStyle.FixedSingle;
            position.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            position.Location = new Point(581, 146);
            position.Name = "position";
            position.Size = new Size(242, 27);
            position.TabIndex = 37;
            // 
            // email
            // 
            email.BorderStyle = BorderStyle.FixedSingle;
            email.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            email.Location = new Point(24, 284);
            email.Name = "email";
            email.Size = new Size(249, 27);
            email.TabIndex = 48;
            // 
            // employmentStatus
            // 
            employmentStatus.Font = new Font("Tahoma", 12F);
            employmentStatus.ForeColor = SystemColors.WindowFrame;
            employmentStatus.FormattingEnabled = true;
            employmentStatus.Items.AddRange(new object[] { "Full-time", "Part-time", "Self-employed", "Unemployed", "Retired" });
            employmentStatus.Location = new Point(904, 80);
            employmentStatus.Name = "employmentStatus";
            employmentStatus.Size = new Size(148, 27);
            employmentStatus.TabIndex = 34;
            // 
            // employerName
            // 
            employerName.BorderStyle = BorderStyle.FixedSingle;
            employerName.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            employerName.Location = new Point(581, 81);
            employerName.Name = "employerName";
            employerName.Size = new Size(317, 27);
            employerName.TabIndex = 26;
            // 
            // phoneNumber
            // 
            phoneNumber.BorderStyle = BorderStyle.FixedSingle;
            phoneNumber.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phoneNumber.Location = new Point(379, 216);
            phoneNumber.Name = "phoneNumber";
            phoneNumber.Size = new Size(168, 27);
            phoneNumber.TabIndex = 47;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(581, 18);
            label2.Name = "label2";
            label2.Size = new Size(251, 23);
            label2.TabIndex = 18;
            label2.Text = "Employment Information";
            // 
            // idNumber
            // 
            idNumber.BorderStyle = BorderStyle.FixedSingle;
            idNumber.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            idNumber.Location = new Point(211, 216);
            idNumber.Name = "idNumber";
            idNumber.Size = new Size(162, 27);
            idNumber.TabIndex = 41;
            // 
            // idType
            // 
            idType.Font = new Font("Tahoma", 12F);
            idType.ForeColor = SystemColors.WindowFrame;
            idType.FormattingEnabled = true;
            idType.Items.AddRange(new object[] { "National ID", "SSS" });
            idType.Location = new Point(24, 216);
            idType.Name = "idType";
            idType.Size = new Size(181, 27);
            idType.TabIndex = 38;
            // 
            // martialStatus
            // 
            martialStatus.Font = new Font("Tahoma", 11F);
            martialStatus.ForeColor = SystemColors.WindowFrame;
            martialStatus.FormattingEnabled = true;
            martialStatus.Items.AddRange(new object[] { "Single ", "Married", "Divorced" });
            martialStatus.Location = new Point(379, 148);
            martialStatus.Name = "martialStatus";
            martialStatus.Size = new Size(168, 26);
            martialStatus.TabIndex = 35;
            // 
            // gender
            // 
            gender.Font = new Font("Tahoma", 11F);
            gender.ForeColor = SystemColors.WindowFrame;
            gender.FormattingEnabled = true;
            gender.Items.AddRange(new object[] { "Male", "Female" });
            gender.Location = new Point(211, 148);
            gender.Name = "gender";
            gender.Size = new Size(162, 26);
            gender.TabIndex = 30;
            // 
            // lastName
            // 
            lastName.BorderStyle = BorderStyle.FixedSingle;
            lastName.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lastName.Location = new Point(24, 81);
            lastName.Name = "lastName";
            lastName.Size = new Size(181, 27);
            lastName.TabIndex = 23;
            // 
            // firstName
            // 
            firstName.BorderStyle = BorderStyle.FixedSingle;
            firstName.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firstName.Location = new Point(211, 81);
            firstName.Name = "firstName";
            firstName.Size = new Size(162, 27);
            firstName.TabIndex = 24;
            // 
            // birthdate
            // 
            birthdate.CalendarFont = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            birthdate.CalendarForeColor = SystemColors.ControlDark;
            birthdate.CalendarTitleBackColor = SystemColors.ControlText;
            birthdate.CalendarTitleForeColor = SystemColors.ControlDark;
            birthdate.Font = new Font("Tahoma", 11F);
            birthdate.Format = DateTimePickerFormat.Short;
            birthdate.Location = new Point(24, 149);
            birthdate.MaxDate = new DateTime(2024, 11, 19, 0, 0, 0, 0);
            birthdate.Name = "birthdate";
            birthdate.Size = new Size(181, 25);
            birthdate.TabIndex = 29;
            birthdate.Value = new DateTime(2004, 12, 31, 0, 0, 0, 0);
            // 
            // middleName
            // 
            middleName.BorderStyle = BorderStyle.FixedSingle;
            middleName.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            middleName.Location = new Point(379, 81);
            middleName.Name = "middleName";
            middleName.Size = new Size(168, 27);
            middleName.TabIndex = 25;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlText;
            label7.Location = new Point(24, 60);
            label7.Name = "label7";
            label7.Size = new Size(87, 18);
            label7.TabIndex = 54;
            label7.Text = "Last Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ControlText;
            label8.Location = new Point(211, 60);
            label8.Name = "label8";
            label8.Size = new Size(90, 18);
            label8.TabIndex = 55;
            label8.Text = "First Name";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ControlText;
            label9.Location = new Point(379, 60);
            label9.Name = "label9";
            label9.Size = new Size(105, 18);
            label9.TabIndex = 56;
            label9.Text = "Middle Name";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ControlText;
            label10.Location = new Point(24, 128);
            label10.Name = "label10";
            label10.Size = new Size(84, 18);
            label10.TabIndex = 57;
            label10.Text = "Birth Date";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ControlText;
            label11.Location = new Point(211, 128);
            label11.Name = "label11";
            label11.Size = new Size(62, 18);
            label11.TabIndex = 58;
            label11.Text = "Gender";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.ControlText;
            label12.Location = new Point(379, 128);
            label12.Name = "label12";
            label12.Size = new Size(114, 18);
            label12.TabIndex = 59;
            label12.Text = "Martial Status";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = SystemColors.ControlText;
            label13.Location = new Point(24, 195);
            label13.Name = "label13";
            label13.Size = new Size(66, 18);
            label13.TabIndex = 60;
            label13.Text = "ID Type";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = SystemColors.ControlText;
            label14.Location = new Point(211, 195);
            label14.Name = "label14";
            label14.Size = new Size(89, 18);
            label14.TabIndex = 61;
            label14.Text = "ID Number";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = SystemColors.ControlText;
            label15.Location = new Point(379, 195);
            label15.Name = "label15";
            label15.Size = new Size(117, 18);
            label15.TabIndex = 62;
            label15.Text = "Phone Number";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = SystemColors.ControlText;
            label16.Location = new Point(24, 263);
            label16.Name = "label16";
            label16.Size = new Size(49, 18);
            label16.TabIndex = 63;
            label16.Text = "Email";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = SystemColors.ControlText;
            label17.Location = new Point(279, 263);
            label17.Name = "label17";
            label17.Size = new Size(68, 18);
            label17.TabIndex = 64;
            label17.Text = "Address";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.ForeColor = SystemColors.ControlText;
            label18.Location = new Point(581, 60);
            label18.Name = "label18";
            label18.Size = new Size(125, 18);
            label18.TabIndex = 65;
            label18.Text = "Employer Name";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.ForeColor = SystemColors.ControlText;
            label19.Location = new Point(904, 60);
            label19.Name = "label19";
            label19.Size = new Size(56, 18);
            label19.TabIndex = 66;
            label19.Text = "Status";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.ForeColor = SystemColors.ControlText;
            label20.Location = new Point(581, 125);
            label20.Name = "label20";
            label20.Size = new Size(69, 18);
            label20.TabIndex = 67;
            label20.Text = "Position";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.ForeColor = SystemColors.ControlText;
            label21.Location = new Point(829, 128);
            label21.Name = "label21";
            label21.Size = new Size(118, 18);
            label21.TabIndex = 68;
            label21.Text = "Annual Income";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.ForeColor = SystemColors.ControlText;
            label22.Location = new Point(581, 195);
            label22.Name = "label22";
            label22.Size = new Size(169, 18);
            label22.TabIndex = 69;
            label22.Text = "Years Of Employment";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label23.ForeColor = SystemColors.ControlText;
            label23.Location = new Point(829, 195);
            label23.Name = "label23";
            label23.Size = new Size(122, 18);
            label23.TabIndex = 70;
            label23.Text = "Contact Details";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(24, 369);
            label5.Name = "label5";
            label5.Size = new Size(84, 18);
            label5.TabIndex = 71;
            label5.Text = "Loan Type";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label24.ForeColor = SystemColors.ControlText;
            label24.Location = new Point(210, 369);
            label24.Name = "label24";
            label24.Size = new Size(64, 18);
            label24.TabIndex = 72;
            label24.Text = "Amount";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label25.ForeColor = SystemColors.ControlText;
            label25.Location = new Point(24, 439);
            label25.Name = "label25";
            label25.Size = new Size(109, 18);
            label25.TabIndex = 73;
            label25.Text = "Loan Purpose";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label26.ForeColor = SystemColors.ControlText;
            label26.Location = new Point(211, 439);
            label26.Name = "label26";
            label26.Size = new Size(134, 18);
            label26.TabIndex = 74;
            label26.Text = "Repayment Term";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label27.ForeColor = SystemColors.ControlText;
            label27.Location = new Point(582, 368);
            label27.Name = "label27";
            label27.Size = new Size(132, 18);
            label27.TabIndex = 75;
            label27.Text = "Estemated Value";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label28.ForeColor = SystemColors.ControlText;
            label28.Location = new Point(407, 369);
            label28.Name = "label28";
            label28.Size = new Size(122, 18);
            label28.TabIndex = 76;
            label28.Text = "Collateral Type";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label29.ForeColor = SystemColors.ControlText;
            label29.Location = new Point(407, 438);
            label29.Name = "label29";
            label29.Size = new Size(172, 18);
            label29.TabIndex = 77;
            label29.Text = "Collateral Description";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label30.ForeColor = SystemColors.ControlText;
            label30.Location = new Point(794, 371);
            label30.Name = "label30";
            label30.Size = new Size(127, 18);
            label30.TabIndex = 78;
            label30.Text = "Monthly Income";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label31.ForeColor = SystemColors.ControlText;
            label31.Location = new Point(794, 440);
            label31.Name = "label31";
            label31.Size = new Size(78, 18);
            label31.TabIndex = 79;
            label31.Text = "Expenses";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(407, 328);
            label6.Name = "label6";
            label6.Size = new Size(223, 23);
            label6.TabIndex = 80;
            label6.Text = "Collateral Information";
            // 
            // applicationdate
            // 
            applicationdate.Enabled = false;
            applicationdate.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            applicationdate.Location = new Point(24, 535);
            applicationdate.Name = "applicationdate";
            applicationdate.Size = new Size(249, 23);
            applicationdate.TabIndex = 81;
            applicationdate.Visible = false;
            // 
            // newAppCreate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1076, 570);
            Controls.Add(applicationdate);
            Controls.Add(label6);
            Controls.Add(label31);
            Controls.Add(label30);
            Controls.Add(label29);
            Controls.Add(label28);
            Controls.Add(label27);
            Controls.Add(label26);
            Controls.Add(label25);
            Controls.Add(label24);
            Controls.Add(label5);
            Controls.Add(label23);
            Controls.Add(label22);
            Controls.Add(label21);
            Controls.Add(label20);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(btnCancelNewApp);
            Controls.Add(btnCreateNewApp);
            Controls.Add(estematedValue);
            Controls.Add(repaymentTerm);
            Controls.Add(collateralDesription);
            Controls.Add(expenses);
            Controls.Add(collateralType);
            Controls.Add(loanPurpose);
            Controls.Add(collateralDocument);
            Controls.Add(amountLoan);
            Controls.Add(monthlyIncome);
            Controls.Add(loanType);
            Controls.Add(employerContact);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(identityProof);
            Controls.Add(label1);
            Controls.Add(yearEmployment);
            Controls.Add(incomeProof);
            Controls.Add(address);
            Controls.Add(annualIncome);
            Controls.Add(position);
            Controls.Add(email);
            Controls.Add(employmentStatus);
            Controls.Add(employerName);
            Controls.Add(phoneNumber);
            Controls.Add(label2);
            Controls.Add(idNumber);
            Controls.Add(idType);
            Controls.Add(martialStatus);
            Controls.Add(gender);
            Controls.Add(lastName);
            Controls.Add(firstName);
            Controls.Add(birthdate);
            Controls.Add(middleName);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "newAppCreate";
            Text = "formNewAppCreate";
            Load += newAppCreate_Load;
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelNewApp;
        private Button btnCreateNewApp;
        private TextBox estematedValue;
        private ComboBox repaymentTerm;
        private TextBox collateralDesription;
        private TextBox expenses;
        private ComboBox collateralType;
        private ComboBox loanPurpose;
        private CheckBox collateralDocument;
        private TextBox amountLoan;
        private TextBox monthlyIncome;
        private ComboBox loanType;
        private TextBox employerContact;
        private Label label3;
        private Label label4;
        private CheckBox identityProof;
        private Label label1;
        private ComboBox yearEmployment;
        private FileSystemWatcher fileSystemWatcher1;
        private CheckBox incomeProof;
        private TextBox address;
        private ComboBox annualIncome;
        private TextBox position;
        private TextBox email;
        private ComboBox employmentStatus;
        private TextBox employerName;
        private TextBox phoneNumber;
        private Label label2;
        private TextBox idNumber;
        private ComboBox idType;
        private ComboBox martialStatus;
        private ComboBox gender;
        private TextBox lastName;
        private TextBox firstName;
        private DateTimePicker birthdate;
        private TextBox middleName;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label23;
        private Label label22;
        private Label label21;
        private Label label20;
        private Label label26;
        private Label label25;
        private Label label24;
        private Label label5;
        private Label label31;
        private Label label30;
        private Label label29;
        private Label label28;
        private Label label27;
        private Label label6;
        private DateTimePicker applicationdate;
    }
}