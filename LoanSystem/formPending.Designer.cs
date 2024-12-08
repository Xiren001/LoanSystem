namespace LoanSystem
{
    partial class formPending
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPending));
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            pendingPanel = new Panel();
            button1 = new Button();
            panel2 = new Panel();
            repaymentRBP = new Label();
            label29 = new Label();
            monthlyRBP = new Label();
            label28 = new Label();
            percentRBP = new Label();
            label27 = new Label();
            interestRBP = new Label();
            label26 = new Label();
            label25 = new Label();
            pendingTotalRepayment = new Label();
            pendingMonthlyPayment = new Label();
            label23 = new Label();
            label4 = new Label();
            label21 = new Label();
            pendingCreditLimit = new Label();
            pendingApplicantName = new Label();
            pendingLoanAmount = new Label();
            label1 = new Label();
            pendingPhoneNumber = new Label();
            label2 = new Label();
            pendingRepaymentTerm = new Label();
            label3 = new Label();
            pendingInterest = new Label();
            pendingPercent = new Label();
            pendingYear = new Label();
            pendingIncome = new Label();
            pendingPosition = new Label();
            pendingEmployementStatus = new Label();
            pendingEmployeName = new Label();
            pendingId = new Label();
            pendingGender = new Label();
            pendingAddress = new Label();
            pendingEmail = new Label();
            pendingMiddleName = new Label();
            pendingFirstName = new Label();
            pendingPhone = new Label();
            pendingLastName = new Label();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            pendingCreditPanel = new Panel();
            pendingCreditColor = new Label();
            pendingRepaymentTerm2 = new Label();
            pendingRBP = new Label();
            label22 = new Label();
            pendingCreditScore = new Label();
            label20 = new Label();
            pendingUpdateStatus = new ComboBox();
            label10 = new Label();
            label6 = new Label();
            label5 = new Label();
            pendingStatus = new Label();
            pendingApplicationId = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            pendingPanel.SuspendLayout();
            panel2.SuspendLayout();
            pendingCreditPanel.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, name, status });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.GridColor = Color.Black;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle3.Padding = new Padding(0, 5, 0, 5);
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(366, 796);
            dataGridView1.TabIndex = 26;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ID
            // 
            ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ID.HeaderText = "Column1";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 105;
            // 
            // name
            // 
            name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            name.HeaderText = "Column1";
            name.Name = "name";
            name.ReadOnly = true;
            // 
            // status
            // 
            status.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            status.HeaderText = "Column1";
            status.Name = "status";
            status.ReadOnly = true;
            // 
            // pendingPanel
            // 
            pendingPanel.BackColor = Color.White;
            pendingPanel.BorderStyle = BorderStyle.Fixed3D;
            pendingPanel.Controls.Add(button1);
            pendingPanel.Controls.Add(panel2);
            pendingPanel.Controls.Add(pendingYear);
            pendingPanel.Controls.Add(pendingIncome);
            pendingPanel.Controls.Add(pendingPosition);
            pendingPanel.Controls.Add(pendingEmployementStatus);
            pendingPanel.Controls.Add(pendingEmployeName);
            pendingPanel.Controls.Add(pendingId);
            pendingPanel.Controls.Add(pendingGender);
            pendingPanel.Controls.Add(pendingAddress);
            pendingPanel.Controls.Add(pendingEmail);
            pendingPanel.Controls.Add(pendingMiddleName);
            pendingPanel.Controls.Add(pendingFirstName);
            pendingPanel.Controls.Add(pendingPhone);
            pendingPanel.Controls.Add(pendingLastName);
            pendingPanel.Controls.Add(label19);
            pendingPanel.Controls.Add(label18);
            pendingPanel.Controls.Add(label17);
            pendingPanel.Controls.Add(label16);
            pendingPanel.Controls.Add(label15);
            pendingPanel.Controls.Add(label14);
            pendingPanel.Controls.Add(label13);
            pendingPanel.Controls.Add(label12);
            pendingPanel.Controls.Add(label11);
            pendingPanel.Controls.Add(label9);
            pendingPanel.Controls.Add(label8);
            pendingPanel.Controls.Add(label7);
            pendingPanel.Controls.Add(pendingCreditPanel);
            pendingPanel.Controls.Add(pendingUpdateStatus);
            pendingPanel.Controls.Add(label10);
            pendingPanel.Controls.Add(label6);
            pendingPanel.Controls.Add(label5);
            pendingPanel.Controls.Add(pendingStatus);
            pendingPanel.Controls.Add(pendingApplicationId);
            pendingPanel.Location = new Point(384, -8);
            pendingPanel.Name = "pendingPanel";
            pendingPanel.Size = new Size(1033, 838);
            pendingPanel.TabIndex = 27;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(777, 25);
            button1.Name = "button1";
            button1.Size = new Size(32, 31);
            button1.TabIndex = 28;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Controls.Add(repaymentRBP);
            panel2.Controls.Add(label29);
            panel2.Controls.Add(monthlyRBP);
            panel2.Controls.Add(label28);
            panel2.Controls.Add(percentRBP);
            panel2.Controls.Add(label27);
            panel2.Controls.Add(interestRBP);
            panel2.Controls.Add(label26);
            panel2.Controls.Add(label25);
            panel2.Controls.Add(pendingTotalRepayment);
            panel2.Controls.Add(pendingMonthlyPayment);
            panel2.Controls.Add(label23);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label21);
            panel2.Controls.Add(pendingCreditLimit);
            panel2.Controls.Add(pendingApplicantName);
            panel2.Controls.Add(pendingLoanAmount);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pendingPhoneNumber);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pendingRepaymentTerm);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(pendingInterest);
            panel2.Controls.Add(pendingPercent);
            panel2.Location = new Point(10, 148);
            panel2.Name = "panel2";
            panel2.Size = new Size(994, 254);
            panel2.TabIndex = 38;
            // 
            // repaymentRBP
            // 
            repaymentRBP.AutoSize = true;
            repaymentRBP.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            repaymentRBP.Location = new Point(791, 220);
            repaymentRBP.Name = "repaymentRBP";
            repaymentRBP.Size = new Size(47, 16);
            repaymentRBP.TabIndex = 66;
            repaymentRBP.Text = "20000";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label29.ForeColor = SystemColors.ControlDarkDark;
            label29.Location = new Point(791, 203);
            label29.Name = "label29";
            label29.Size = new Size(101, 14);
            label29.TabIndex = 29;
            label29.Text = "Total Repayment";
            // 
            // monthlyRBP
            // 
            monthlyRBP.AutoSize = true;
            monthlyRBP.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            monthlyRBP.Location = new Point(582, 220);
            monthlyRBP.Name = "monthlyRBP";
            monthlyRBP.Size = new Size(47, 16);
            monthlyRBP.TabIndex = 65;
            monthlyRBP.Text = "20000";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label28.ForeColor = SystemColors.ControlDarkDark;
            label28.Location = new Point(582, 203);
            label28.Name = "label28";
            label28.Size = new Size(102, 14);
            label28.TabIndex = 28;
            label28.Text = "Monthly Payment";
            // 
            // percentRBP
            // 
            percentRBP.AutoSize = true;
            percentRBP.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            percentRBP.Location = new Point(391, 220);
            percentRBP.Name = "percentRBP";
            percentRBP.Size = new Size(47, 16);
            percentRBP.TabIndex = 64;
            percentRBP.Text = "20000";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label27.ForeColor = SystemColors.ControlDarkDark;
            label27.Location = new Point(391, 203);
            label27.Name = "label27";
            label27.Size = new Size(70, 14);
            label27.TabIndex = 27;
            label27.Text = "Percentage";
            // 
            // interestRBP
            // 
            interestRBP.AutoSize = true;
            interestRBP.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            interestRBP.Location = new Point(229, 220);
            interestRBP.Name = "interestRBP";
            interestRBP.Size = new Size(47, 16);
            interestRBP.TabIndex = 63;
            interestRBP.Text = "20000";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label26.ForeColor = SystemColors.ControlDarkDark;
            label26.Location = new Point(229, 203);
            label26.Name = "label26";
            label26.Size = new Size(51, 14);
            label26.TabIndex = 26;
            label26.Text = "Interest";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label25.Location = new Point(10, 213);
            label25.Name = "label25";
            label25.Size = new Size(196, 23);
            label25.TabIndex = 18;
            label25.Text = "Recomended (RBP)";
            // 
            // pendingTotalRepayment
            // 
            pendingTotalRepayment.AutoSize = true;
            pendingTotalRepayment.Font = new Font("Tahoma", 12F);
            pendingTotalRepayment.Location = new Point(791, 150);
            pendingTotalRepayment.Name = "pendingTotalRepayment";
            pendingTotalRepayment.Size = new Size(54, 19);
            pendingTotalRepayment.TabIndex = 25;
            pendingTotalRepayment.Text = "20000";
            // 
            // pendingMonthlyPayment
            // 
            pendingMonthlyPayment.AutoSize = true;
            pendingMonthlyPayment.Font = new Font("Tahoma", 12F);
            pendingMonthlyPayment.Location = new Point(430, 149);
            pendingMonthlyPayment.Name = "pendingMonthlyPayment";
            pendingMonthlyPayment.Size = new Size(54, 19);
            pendingMonthlyPayment.TabIndex = 24;
            pendingMonthlyPayment.Text = "20000";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            label23.Location = new Point(791, 126);
            label23.Name = "label23";
            label23.Size = new Size(173, 23);
            label23.TabIndex = 23;
            label23.Text = "Total Repayment";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            label4.Location = new Point(430, 126);
            label4.Name = "label4";
            label4.Size = new Size(177, 23);
            label4.TabIndex = 22;
            label4.Text = "Monthly Payment";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            label21.Location = new Point(10, 126);
            label21.Name = "label21";
            label21.Size = new Size(123, 23);
            label21.TabIndex = 21;
            label21.Text = "Credit Limit";
            // 
            // pendingCreditLimit
            // 
            pendingCreditLimit.AutoSize = true;
            pendingCreditLimit.Font = new Font("Tahoma", 12F);
            pendingCreditLimit.Location = new Point(10, 149);
            pendingCreditLimit.Name = "pendingCreditLimit";
            pendingCreditLimit.Size = new Size(54, 19);
            pendingCreditLimit.TabIndex = 19;
            pendingCreditLimit.Text = "20000";
            // 
            // pendingApplicantName
            // 
            pendingApplicantName.AutoSize = true;
            pendingApplicantName.Font = new Font("Tahoma", 18F, FontStyle.Bold);
            pendingApplicantName.Location = new Point(10, 39);
            pendingApplicantName.Name = "pendingApplicantName";
            pendingApplicantName.Size = new Size(202, 29);
            pendingApplicantName.TabIndex = 2;
            pendingApplicantName.Text = "Applicant Name";
            // 
            // pendingLoanAmount
            // 
            pendingLoanAmount.AutoSize = true;
            pendingLoanAmount.BackColor = Color.Transparent;
            pendingLoanAmount.Font = new Font("Tahoma", 18F, FontStyle.Bold);
            pendingLoanAmount.Location = new Point(430, 39);
            pendingLoanAmount.Margin = new Padding(0);
            pendingLoanAmount.Name = "pendingLoanAmount";
            pendingLoanAmount.Size = new Size(107, 29);
            pendingLoanAmount.TabIndex = 3;
            pendingLoanAmount.Text = "Amount";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 11.25F);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(10, 10);
            label1.Name = "label1";
            label1.Size = new Size(66, 18);
            label1.TabIndex = 4;
            label1.Text = "Borrower";
            // 
            // pendingPhoneNumber
            // 
            pendingPhoneNumber.AutoSize = true;
            pendingPhoneNumber.Font = new Font("Tahoma", 12F);
            pendingPhoneNumber.Location = new Point(10, 80);
            pendingPhoneNumber.Name = "pendingPhoneNumber";
            pendingPhoneNumber.Size = new Size(66, 19);
            pendingPhoneNumber.TabIndex = 5;
            pendingPhoneNumber.Text = "Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 11.25F);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(430, 10);
            label2.Name = "label2";
            label2.Size = new Size(77, 18);
            label2.TabIndex = 6;
            label2.Text = "Requested";
            // 
            // pendingRepaymentTerm
            // 
            pendingRepaymentTerm.AutoSize = true;
            pendingRepaymentTerm.Font = new Font("Tahoma", 12F);
            pendingRepaymentTerm.Location = new Point(430, 80);
            pendingRepaymentTerm.Name = "pendingRepaymentTerm";
            pendingRepaymentTerm.Size = new Size(131, 19);
            pendingRepaymentTerm.TabIndex = 7;
            pendingRepaymentTerm.Text = "Repayment Term";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 11.25F);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(791, 10);
            label3.Name = "label3";
            label3.Size = new Size(98, 18);
            label3.TabIndex = 8;
            label3.Text = "Total Interest";
            // 
            // pendingInterest
            // 
            pendingInterest.AutoSize = true;
            pendingInterest.Font = new Font("Tahoma", 18F, FontStyle.Bold);
            pendingInterest.Location = new Point(791, 39);
            pendingInterest.Name = "pendingInterest";
            pendingInterest.Size = new Size(110, 29);
            pendingInterest.TabIndex = 9;
            pendingInterest.Text = "Interest";
            // 
            // pendingPercent
            // 
            pendingPercent.AutoSize = true;
            pendingPercent.Font = new Font("Tahoma", 12F);
            pendingPercent.Location = new Point(791, 80);
            pendingPercent.Name = "pendingPercent";
            pendingPercent.Size = new Size(61, 19);
            pendingPercent.TabIndex = 10;
            pendingPercent.Text = "Percent";
            // 
            // pendingYear
            // 
            pendingYear.AutoSize = true;
            pendingYear.Font = new Font("Tahoma", 12F);
            pendingYear.ForeColor = SystemColors.ControlDarkDark;
            pendingYear.Location = new Point(731, 640);
            pendingYear.Name = "pendingYear";
            pendingYear.Size = new Size(161, 19);
            pendingYear.TabIndex = 62;
            pendingYear.Text = "Years of Employment";
            // 
            // pendingIncome
            // 
            pendingIncome.AutoSize = true;
            pendingIncome.Font = new Font("Tahoma", 12F);
            pendingIncome.ForeColor = SystemColors.ControlDarkDark;
            pendingIncome.Location = new Point(731, 596);
            pendingIncome.Name = "pendingIncome";
            pendingIncome.Size = new Size(117, 19);
            pendingIncome.TabIndex = 61;
            pendingIncome.Text = "Annual Income";
            // 
            // pendingPosition
            // 
            pendingPosition.AutoSize = true;
            pendingPosition.Font = new Font("Tahoma", 12F);
            pendingPosition.ForeColor = SystemColors.ControlDarkDark;
            pendingPosition.Location = new Point(731, 553);
            pendingPosition.Name = "pendingPosition";
            pendingPosition.Size = new Size(65, 19);
            pendingPosition.TabIndex = 60;
            pendingPosition.Text = "Position";
            // 
            // pendingEmployementStatus
            // 
            pendingEmployementStatus.AutoSize = true;
            pendingEmployementStatus.Font = new Font("Tahoma", 12F);
            pendingEmployementStatus.ForeColor = SystemColors.ControlDarkDark;
            pendingEmployementStatus.Location = new Point(731, 512);
            pendingEmployementStatus.Name = "pendingEmployementStatus";
            pendingEmployementStatus.Size = new Size(146, 19);
            pendingEmployementStatus.TabIndex = 59;
            pendingEmployementStatus.Text = "Employment Status";
            // 
            // pendingEmployeName
            // 
            pendingEmployeName.AutoSize = true;
            pendingEmployeName.Font = new Font("Tahoma", 12F);
            pendingEmployeName.ForeColor = SystemColors.ControlDarkDark;
            pendingEmployeName.Location = new Point(731, 466);
            pendingEmployeName.Name = "pendingEmployeName";
            pendingEmployeName.Size = new Size(122, 19);
            pendingEmployeName.TabIndex = 58;
            pendingEmployeName.Text = "Employer Name";
            // 
            // pendingId
            // 
            pendingId.AutoSize = true;
            pendingId.Font = new Font("Tahoma", 12F);
            pendingId.ForeColor = SystemColors.ControlDarkDark;
            pendingId.Location = new Point(220, 770);
            pendingId.Name = "pendingId";
            pendingId.Size = new Size(66, 19);
            pendingId.TabIndex = 57;
            pendingId.Text = "ID Type";
            // 
            // pendingGender
            // 
            pendingGender.AutoSize = true;
            pendingGender.Font = new Font("Tahoma", 12F);
            pendingGender.ForeColor = SystemColors.ControlDarkDark;
            pendingGender.Location = new Point(220, 726);
            pendingGender.Name = "pendingGender";
            pendingGender.Size = new Size(60, 19);
            pendingGender.TabIndex = 56;
            pendingGender.Text = "Gender";
            // 
            // pendingAddress
            // 
            pendingAddress.AutoSize = true;
            pendingAddress.Font = new Font("Tahoma", 12F);
            pendingAddress.ForeColor = SystemColors.ControlDarkDark;
            pendingAddress.Location = new Point(218, 682);
            pendingAddress.Name = "pendingAddress";
            pendingAddress.Size = new Size(66, 19);
            pendingAddress.TabIndex = 55;
            pendingAddress.Text = "Address";
            // 
            // pendingEmail
            // 
            pendingEmail.AutoSize = true;
            pendingEmail.Font = new Font("Tahoma", 12F);
            pendingEmail.ForeColor = SystemColors.ControlDarkDark;
            pendingEmail.Location = new Point(220, 596);
            pendingEmail.Name = "pendingEmail";
            pendingEmail.Size = new Size(48, 19);
            pendingEmail.TabIndex = 54;
            pendingEmail.Text = "Email";
            // 
            // pendingMiddleName
            // 
            pendingMiddleName.AutoSize = true;
            pendingMiddleName.Font = new Font("Tahoma", 12F);
            pendingMiddleName.ForeColor = SystemColors.ControlDarkDark;
            pendingMiddleName.Location = new Point(218, 553);
            pendingMiddleName.Name = "pendingMiddleName";
            pendingMiddleName.Size = new Size(101, 19);
            pendingMiddleName.TabIndex = 53;
            pendingMiddleName.Text = "Middle Name";
            // 
            // pendingFirstName
            // 
            pendingFirstName.AutoSize = true;
            pendingFirstName.Font = new Font("Tahoma", 12F);
            pendingFirstName.ForeColor = SystemColors.ControlDarkDark;
            pendingFirstName.Location = new Point(218, 512);
            pendingFirstName.Name = "pendingFirstName";
            pendingFirstName.Size = new Size(85, 19);
            pendingFirstName.TabIndex = 52;
            pendingFirstName.Text = "First Name";
            // 
            // pendingPhone
            // 
            pendingPhone.AutoSize = true;
            pendingPhone.Font = new Font("Tahoma", 12F);
            pendingPhone.ForeColor = SystemColors.ControlDarkDark;
            pendingPhone.Location = new Point(220, 640);
            pendingPhone.Name = "pendingPhone";
            pendingPhone.Size = new Size(53, 19);
            pendingPhone.TabIndex = 51;
            pendingPhone.Text = "Phone";
            // 
            // pendingLastName
            // 
            pendingLastName.AutoSize = true;
            pendingLastName.Font = new Font("Tahoma", 12F);
            pendingLastName.ForeColor = SystemColors.ControlDarkDark;
            pendingLastName.Location = new Point(218, 466);
            pendingLastName.Name = "pendingLastName";
            pendingLastName.Size = new Size(83, 19);
            pendingLastName.TabIndex = 50;
            pendingLastName.Text = "Last Name";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Tahoma", 12F);
            label19.ForeColor = SystemColors.ControlDarkDark;
            label19.Location = new Point(521, 640);
            label19.Name = "label19";
            label19.Size = new Size(161, 19);
            label19.TabIndex = 49;
            label19.Text = "Years of Employment";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Tahoma", 12F);
            label18.ForeColor = SystemColors.ControlDarkDark;
            label18.Location = new Point(521, 596);
            label18.Name = "label18";
            label18.Size = new Size(117, 19);
            label18.TabIndex = 48;
            label18.Text = "Annual Income";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Tahoma", 12F);
            label17.ForeColor = SystemColors.ControlDarkDark;
            label17.Location = new Point(521, 553);
            label17.Name = "label17";
            label17.Size = new Size(65, 19);
            label17.TabIndex = 47;
            label17.Text = "Position";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Tahoma", 12F);
            label16.ForeColor = SystemColors.ControlDarkDark;
            label16.Location = new Point(521, 512);
            label16.Name = "label16";
            label16.Size = new Size(146, 19);
            label16.TabIndex = 46;
            label16.Text = "Employment Status";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Tahoma", 12F);
            label15.ForeColor = SystemColors.ControlDarkDark;
            label15.Location = new Point(521, 466);
            label15.Name = "label15";
            label15.Size = new Size(122, 19);
            label15.TabIndex = 45;
            label15.Text = "Employer Name";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Tahoma", 15.75F, FontStyle.Bold);
            label14.Location = new Point(521, 415);
            label14.Name = "label14";
            label14.Size = new Size(193, 25);
            label14.TabIndex = 44;
            label14.Text = "Employment Info";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Tahoma", 12F);
            label13.ForeColor = SystemColors.ControlDarkDark;
            label13.Location = new Point(20, 770);
            label13.Name = "label13";
            label13.Size = new Size(66, 19);
            label13.TabIndex = 43;
            label13.Text = "ID Type";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Tahoma", 12F);
            label12.ForeColor = SystemColors.ControlDarkDark;
            label12.Location = new Point(20, 726);
            label12.Name = "label12";
            label12.Size = new Size(60, 19);
            label12.TabIndex = 42;
            label12.Text = "Gender";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Tahoma", 12F);
            label11.ForeColor = SystemColors.ControlDarkDark;
            label11.Location = new Point(20, 682);
            label11.Name = "label11";
            label11.Size = new Size(66, 19);
            label11.TabIndex = 41;
            label11.Text = "Address";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 12F);
            label9.ForeColor = SystemColors.ControlDarkDark;
            label9.Location = new Point(20, 596);
            label9.Name = "label9";
            label9.Size = new Size(48, 19);
            label9.TabIndex = 40;
            label9.Text = "Email";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 12F);
            label8.ForeColor = SystemColors.ControlDarkDark;
            label8.Location = new Point(20, 553);
            label8.Name = "label8";
            label8.Size = new Size(101, 19);
            label8.TabIndex = 39;
            label8.Text = "Middle Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 12F);
            label7.ForeColor = SystemColors.ControlDarkDark;
            label7.Location = new Point(20, 512);
            label7.Name = "label7";
            label7.Size = new Size(85, 19);
            label7.TabIndex = 38;
            label7.Text = "First Name";
            // 
            // pendingCreditPanel
            // 
            pendingCreditPanel.BackColor = Color.Yellow;
            pendingCreditPanel.Controls.Add(pendingCreditColor);
            pendingCreditPanel.Controls.Add(pendingRepaymentTerm2);
            pendingCreditPanel.Controls.Add(pendingRBP);
            pendingCreditPanel.Controls.Add(label22);
            pendingCreditPanel.Controls.Add(pendingCreditScore);
            pendingCreditPanel.Controls.Add(label20);
            pendingCreditPanel.Location = new Point(10, 72);
            pendingCreditPanel.Name = "pendingCreditPanel";
            pendingCreditPanel.Size = new Size(994, 83);
            pendingCreditPanel.TabIndex = 37;
            // 
            // pendingCreditColor
            // 
            pendingCreditColor.AutoSize = true;
            pendingCreditColor.Font = new Font("Tahoma", 12F);
            pendingCreditColor.Location = new Point(229, 31);
            pendingCreditColor.Name = "pendingCreditColor";
            pendingCreditColor.Size = new Size(87, 19);
            pendingCreditColor.TabIndex = 17;
            pendingCreditColor.Text = "Color Zone";
            // 
            // pendingRepaymentTerm2
            // 
            pendingRepaymentTerm2.AutoSize = true;
            pendingRepaymentTerm2.Font = new Font("Tahoma", 12F);
            pendingRepaymentTerm2.Location = new Point(879, 29);
            pendingRepaymentTerm2.Name = "pendingRepaymentTerm2";
            pendingRepaymentTerm2.Size = new Size(42, 19);
            pendingRepaymentTerm2.TabIndex = 16;
            pendingRepaymentTerm2.Text = "term";
            // 
            // pendingRBP
            // 
            pendingRBP.AutoSize = true;
            pendingRBP.Font = new Font("Tahoma", 12F);
            pendingRBP.Location = new Point(621, 29);
            pendingRBP.Name = "pendingRBP";
            pendingRBP.Size = new Size(63, 19);
            pendingRBP.TabIndex = 14;
            pendingRBP.Text = "200000";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Tahoma", 15.75F, FontStyle.Bold);
            label22.Location = new Point(391, 24);
            label22.Name = "label22";
            label22.Size = new Size(215, 25);
            label22.TabIndex = 13;
            label22.Text = "Recomended (RBP)";
            // 
            // pendingCreditScore
            // 
            pendingCreditScore.AutoSize = true;
            pendingCreditScore.Font = new Font("Tahoma", 12F);
            pendingCreditScore.Location = new Point(167, 30);
            pendingCreditScore.Name = "pendingCreditScore";
            pendingCreditScore.Size = new Size(32, 19);
            pendingCreditScore.TabIndex = 12;
            pendingCreditScore.Text = "sco";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Tahoma", 15.75F, FontStyle.Bold);
            label20.Location = new Point(10, 25);
            label20.Name = "label20";
            label20.Size = new Size(139, 25);
            label20.TabIndex = 11;
            label20.Text = "Credit Score";
            // 
            // pendingUpdateStatus
            // 
            pendingUpdateStatus.FlatStyle = FlatStyle.Flat;
            pendingUpdateStatus.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pendingUpdateStatus.FormattingEnabled = true;
            pendingUpdateStatus.Items.AddRange(new object[] { "Approved", "Rejected" });
            pendingUpdateStatus.Location = new Point(827, 29);
            pendingUpdateStatus.Name = "pendingUpdateStatus";
            pendingUpdateStatus.Size = new Size(177, 27);
            pendingUpdateStatus.TabIndex = 36;
            pendingUpdateStatus.Text = "Operation";
            pendingUpdateStatus.SelectedIndexChanged += pendingUpdateStatus_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 12F);
            label10.ForeColor = SystemColors.ControlDarkDark;
            label10.Location = new Point(20, 640);
            label10.Name = "label10";
            label10.Size = new Size(53, 19);
            label10.TabIndex = 16;
            label10.Text = "Phone";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 12F);
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(20, 466);
            label6.Name = "label6";
            label6.Size = new Size(83, 19);
            label6.TabIndex = 12;
            label6.Text = "Last Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 15.75F, FontStyle.Bold);
            label5.Location = new Point(20, 415);
            label5.Name = "label5";
            label5.Size = new Size(160, 25);
            label5.TabIndex = 11;
            label5.Text = "Borrower Info";
            // 
            // pendingStatus
            // 
            pendingStatus.AutoSize = true;
            pendingStatus.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pendingStatus.Location = new Point(264, 32);
            pendingStatus.Name = "pendingStatus";
            pendingStatus.Size = new Size(62, 23);
            pendingStatus.TabIndex = 1;
            pendingStatus.Text = "Status";
            // 
            // pendingApplicationId
            // 
            pendingApplicationId.AutoSize = true;
            pendingApplicationId.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pendingApplicationId.Location = new Point(20, 27);
            pendingApplicationId.Name = "pendingApplicationId";
            pendingApplicationId.Size = new Size(184, 29);
            pendingApplicationId.TabIndex = 0;
            pendingApplicationId.Text = "Application ID";
            // 
            // formPending
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1407, 820);
            Controls.Add(pendingPanel);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formPending";
            Text = "formPending";
            Load += formPending_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            pendingPanel.ResumeLayout(false);
            pendingPanel.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            pendingCreditPanel.ResumeLayout(false);
            pendingCreditPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel pendingPanel;
        private Label pendingLoanAmount;
        private Label pendingApplicantName;
        private Label pendingStatus;
        private Label pendingApplicationId;
        private Label label1;
        private Label label2;
        private Label pendingPhoneNumber;
        private Label label3;
        private Label pendingRepaymentTerm;
        private Label label5;
        private Label label6;
        private Label label10;
        private ComboBox pendingUpdateStatus;
        private Panel pendingCreditPanel;
        private Panel panel2;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label11;
        private Label label13;
        private Label label12;
        private Label label14;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label pendingYear;
        private Label pendingIncome;
        private Label pendingPosition;
        private Label pendingEmployementStatus;
        private Label pendingEmployeName;
        private Label pendingId;
        private Label pendingGender;
        private Label pendingAddress;
        private Label pendingEmail;
        private Label pendingMiddleName;
        private Label pendingFirstName;
        private Label pendingPhone;
        private Label pendingLastName;
        private Label label20;
        private Label pendingRepaymentTerm2;
        private Label pendingRBP;
        private Label label22;
        private Label pendingCreditScore;
        private Label pendingCreditColor;
        private Label pendingCreditLimit;
        private Label label21;
        private Label pendingTotalRepayment;
        private Label pendingMonthlyPayment;
        private Label pendingPercent;
        private Label pendingInterest;
        private Label label23;
        private Label label4;
        private Label repaymentRBP;
        private Label monthlyRBP;
        private Label percentRBP;
        private Label interestRBP;
        private Label label29;
        private Label label28;
        private Label label27;
        private Label label26;
        private Label label25;
        private Button button1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn status;
    }
}