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
            dataGridView1 = new DataGridView();
            ApplicationID = new DataGridViewTextBoxColumn();
            ApplicantName = new DataGridViewTextBoxColumn();
            repaymentterm = new DataGridViewTextBoxColumn();
            LoanAmount = new DataGridViewTextBoxColumn();
            VerificationStatus = new DataGridViewTextBoxColumn();
            pendingPanel = new Panel();
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
            panel1 = new Panel();
            pendingUpdateStatus = new ComboBox();
            label10 = new Label();
            label6 = new Label();
            label5 = new Label();
            pendingStatus = new Label();
            pendingApplicationId = new Label();
            pendingPercent = new Label();
            label4 = new Label();
            label3 = new Label();
            pendingRepaymentTerm = new Label();
            label2 = new Label();
            pendingPhoneNumber = new Label();
            label1 = new Label();
            pendingLoanAmount = new Label();
            pendingApplicantName = new Label();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            pendingPanel.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ApplicationID, ApplicantName, repaymentterm, LoanAmount, VerificationStatus });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.GridColor = Color.Black;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(407, 585);
            dataGridView1.TabIndex = 26;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ApplicationID
            // 
            ApplicationID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ApplicationID.HeaderText = "Application ID";
            ApplicationID.Name = "ApplicationID";
            ApplicationID.ReadOnly = true;
            // 
            // ApplicantName
            // 
            ApplicantName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ApplicantName.HeaderText = "Applicant Name";
            ApplicantName.Name = "ApplicantName";
            ApplicantName.ReadOnly = true;
            // 
            // repaymentterm
            // 
            repaymentterm.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            repaymentterm.HeaderText = "Repayment Term";
            repaymentterm.Name = "repaymentterm";
            repaymentterm.ReadOnly = true;
            // 
            // LoanAmount
            // 
            LoanAmount.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            LoanAmount.HeaderText = "Loan Amount";
            LoanAmount.Name = "LoanAmount";
            LoanAmount.ReadOnly = true;
            // 
            // VerificationStatus
            // 
            VerificationStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            VerificationStatus.HeaderText = "Verification Status";
            VerificationStatus.Name = "VerificationStatus";
            VerificationStatus.ReadOnly = true;
            // 
            // pendingPanel
            // 
            pendingPanel.BackColor = Color.White;
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
            pendingPanel.Controls.Add(panel1);
            pendingPanel.Controls.Add(pendingUpdateStatus);
            pendingPanel.Controls.Add(label10);
            pendingPanel.Controls.Add(label6);
            pendingPanel.Controls.Add(label5);
            pendingPanel.Controls.Add(pendingStatus);
            pendingPanel.Controls.Add(pendingApplicationId);
            pendingPanel.Location = new Point(425, 12);
            pendingPanel.Name = "pendingPanel";
            pendingPanel.Size = new Size(655, 585);
            pendingPanel.TabIndex = 27;
            // 
            // pendingYear
            // 
            pendingYear.AutoSize = true;
            pendingYear.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pendingYear.ForeColor = SystemColors.ControlDarkDark;
            pendingYear.Location = new Point(504, 451);
            pendingYear.Name = "pendingYear";
            pendingYear.Size = new Size(124, 14);
            pendingYear.TabIndex = 62;
            pendingYear.Text = "Years of Employment";
            // 
            // pendingIncome
            // 
            pendingIncome.AutoSize = true;
            pendingIncome.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pendingIncome.ForeColor = SystemColors.ControlDarkDark;
            pendingIncome.Location = new Point(504, 422);
            pendingIncome.Name = "pendingIncome";
            pendingIncome.Size = new Size(89, 14);
            pendingIncome.TabIndex = 61;
            pendingIncome.Text = "Annual Income";
            // 
            // pendingPosition
            // 
            pendingPosition.AutoSize = true;
            pendingPosition.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pendingPosition.ForeColor = SystemColors.ControlDarkDark;
            pendingPosition.Location = new Point(504, 394);
            pendingPosition.Name = "pendingPosition";
            pendingPosition.Size = new Size(49, 14);
            pendingPosition.TabIndex = 60;
            pendingPosition.Text = "Position";
            // 
            // pendingEmployementStatus
            // 
            pendingEmployementStatus.AutoSize = true;
            pendingEmployementStatus.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pendingEmployementStatus.ForeColor = SystemColors.ControlDarkDark;
            pendingEmployementStatus.Location = new Point(504, 365);
            pendingEmployementStatus.Name = "pendingEmployementStatus";
            pendingEmployementStatus.Size = new Size(114, 14);
            pendingEmployementStatus.TabIndex = 59;
            pendingEmployementStatus.Text = "Employment Status";
            // 
            // pendingEmployeName
            // 
            pendingEmployeName.AutoSize = true;
            pendingEmployeName.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pendingEmployeName.ForeColor = SystemColors.ControlDarkDark;
            pendingEmployeName.Location = new Point(504, 335);
            pendingEmployeName.Name = "pendingEmployeName";
            pendingEmployeName.Size = new Size(92, 14);
            pendingEmployeName.TabIndex = 58;
            pendingEmployeName.Text = "Employer Name";
            // 
            // pendingId
            // 
            pendingId.AutoSize = true;
            pendingId.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pendingId.ForeColor = SystemColors.ControlDarkDark;
            pendingId.Location = new Point(148, 540);
            pendingId.Name = "pendingId";
            pendingId.Size = new Size(51, 14);
            pendingId.TabIndex = 57;
            pendingId.Text = "ID Type";
            // 
            // pendingGender
            // 
            pendingGender.AutoSize = true;
            pendingGender.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pendingGender.ForeColor = SystemColors.ControlDarkDark;
            pendingGender.Location = new Point(148, 511);
            pendingGender.Name = "pendingGender";
            pendingGender.Size = new Size(47, 14);
            pendingGender.TabIndex = 56;
            pendingGender.Text = "Gender";
            // 
            // pendingAddress
            // 
            pendingAddress.AutoSize = true;
            pendingAddress.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pendingAddress.ForeColor = SystemColors.ControlDarkDark;
            pendingAddress.Location = new Point(148, 481);
            pendingAddress.Name = "pendingAddress";
            pendingAddress.Size = new Size(50, 14);
            pendingAddress.TabIndex = 55;
            pendingAddress.Text = "Address";
            // 
            // pendingEmail
            // 
            pendingEmail.AutoSize = true;
            pendingEmail.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pendingEmail.ForeColor = SystemColors.ControlDarkDark;
            pendingEmail.Location = new Point(148, 422);
            pendingEmail.Name = "pendingEmail";
            pendingEmail.Size = new Size(34, 14);
            pendingEmail.TabIndex = 54;
            pendingEmail.Text = "Email";
            // 
            // pendingMiddleName
            // 
            pendingMiddleName.AutoSize = true;
            pendingMiddleName.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pendingMiddleName.ForeColor = SystemColors.ControlDarkDark;
            pendingMiddleName.Location = new Point(148, 394);
            pendingMiddleName.Name = "pendingMiddleName";
            pendingMiddleName.Size = new Size(76, 14);
            pendingMiddleName.TabIndex = 53;
            pendingMiddleName.Text = "Middle Name";
            // 
            // pendingFirstName
            // 
            pendingFirstName.AutoSize = true;
            pendingFirstName.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pendingFirstName.ForeColor = SystemColors.ControlDarkDark;
            pendingFirstName.Location = new Point(148, 365);
            pendingFirstName.Name = "pendingFirstName";
            pendingFirstName.Size = new Size(64, 14);
            pendingFirstName.TabIndex = 52;
            pendingFirstName.Text = "First Name";
            // 
            // pendingPhone
            // 
            pendingPhone.AutoSize = true;
            pendingPhone.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pendingPhone.ForeColor = SystemColors.ControlDarkDark;
            pendingPhone.Location = new Point(148, 451);
            pendingPhone.Name = "pendingPhone";
            pendingPhone.Size = new Size(42, 14);
            pendingPhone.TabIndex = 51;
            pendingPhone.Text = "Phone";
            // 
            // pendingLastName
            // 
            pendingLastName.AutoSize = true;
            pendingLastName.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pendingLastName.ForeColor = SystemColors.ControlDarkDark;
            pendingLastName.Location = new Point(148, 335);
            pendingLastName.Name = "pendingLastName";
            pendingLastName.Size = new Size(64, 14);
            pendingLastName.TabIndex = 50;
            pendingLastName.Text = "Last Name";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label19.ForeColor = SystemColors.ControlDarkDark;
            label19.Location = new Point(333, 451);
            label19.Name = "label19";
            label19.Size = new Size(124, 14);
            label19.TabIndex = 49;
            label19.Text = "Years of Employment";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.ForeColor = SystemColors.ControlDarkDark;
            label18.Location = new Point(333, 422);
            label18.Name = "label18";
            label18.Size = new Size(89, 14);
            label18.TabIndex = 48;
            label18.Text = "Annual Income";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.ForeColor = SystemColors.ControlDarkDark;
            label17.Location = new Point(333, 394);
            label17.Name = "label17";
            label17.Size = new Size(49, 14);
            label17.TabIndex = 47;
            label17.Text = "Position";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.ForeColor = SystemColors.ControlDarkDark;
            label16.Location = new Point(333, 365);
            label16.Name = "label16";
            label16.Size = new Size(114, 14);
            label16.TabIndex = 46;
            label16.Text = "Employment Status";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.ForeColor = SystemColors.ControlDarkDark;
            label15.Location = new Point(333, 335);
            label15.Name = "label15";
            label15.Size = new Size(92, 14);
            label15.TabIndex = 45;
            label15.Text = "Employer Name";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(333, 290);
            label14.Name = "label14";
            label14.Size = new Size(148, 19);
            label14.TabIndex = 44;
            label14.Text = "Employment Info";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = SystemColors.ControlDarkDark;
            label13.Location = new Point(22, 540);
            label13.Name = "label13";
            label13.Size = new Size(51, 14);
            label13.TabIndex = 43;
            label13.Text = "ID Type";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.ControlDarkDark;
            label12.Location = new Point(22, 511);
            label12.Name = "label12";
            label12.Size = new Size(47, 14);
            label12.TabIndex = 42;
            label12.Text = "Gender";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ControlDarkDark;
            label11.Location = new Point(22, 481);
            label11.Name = "label11";
            label11.Size = new Size(50, 14);
            label11.TabIndex = 41;
            label11.Text = "Address";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ControlDarkDark;
            label9.Location = new Point(22, 422);
            label9.Name = "label9";
            label9.Size = new Size(34, 14);
            label9.TabIndex = 40;
            label9.Text = "Email";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ControlDarkDark;
            label8.Location = new Point(22, 394);
            label8.Name = "label8";
            label8.Size = new Size(76, 14);
            label8.TabIndex = 39;
            label8.Text = "Middle Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlDarkDark;
            label7.Location = new Point(22, 365);
            label7.Name = "label7";
            label7.Size = new Size(64, 14);
            label7.TabIndex = 38;
            label7.Text = "First Name";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Yellow;
            panel1.Location = new Point(12, 74);
            panel1.Name = "panel1";
            panel1.Size = new Size(629, 45);
            panel1.TabIndex = 37;
            // 
            // pendingUpdateStatus
            // 
            pendingUpdateStatus.FlatStyle = FlatStyle.Flat;
            pendingUpdateStatus.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pendingUpdateStatus.FormattingEnabled = true;
            pendingUpdateStatus.Items.AddRange(new object[] { "Approved", "Rejected" });
            pendingUpdateStatus.Location = new Point(522, 14);
            pendingUpdateStatus.Name = "pendingUpdateStatus";
            pendingUpdateStatus.Size = new Size(83, 22);
            pendingUpdateStatus.TabIndex = 36;
            pendingUpdateStatus.Text = "Operation";
            pendingUpdateStatus.SelectedIndexChanged += pendingUpdateStatus_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ControlDarkDark;
            label10.Location = new Point(22, 451);
            label10.Name = "label10";
            label10.Size = new Size(42, 14);
            label10.TabIndex = 16;
            label10.Text = "Phone";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(22, 335);
            label6.Name = "label6";
            label6.Size = new Size(64, 14);
            label6.TabIndex = 12;
            label6.Text = "Last Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(22, 290);
            label5.Name = "label5";
            label5.Size = new Size(123, 19);
            label5.TabIndex = 11;
            label5.Text = "Borrower Info";
            // 
            // pendingStatus
            // 
            pendingStatus.AutoSize = true;
            pendingStatus.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pendingStatus.Location = new Point(225, 11);
            pendingStatus.Name = "pendingStatus";
            pendingStatus.Size = new Size(62, 23);
            pendingStatus.TabIndex = 1;
            pendingStatus.Text = "Status";
            // 
            // pendingApplicationId
            // 
            pendingApplicationId.AutoSize = true;
            pendingApplicationId.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pendingApplicationId.Location = new Point(13, 10);
            pendingApplicationId.Name = "pendingApplicationId";
            pendingApplicationId.Size = new Size(161, 25);
            pendingApplicationId.TabIndex = 0;
            pendingApplicationId.Text = "Application ID";
            // 
            // pendingPercent
            // 
            pendingPercent.AutoSize = true;
            pendingPercent.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pendingPercent.Location = new Point(499, 83);
            pendingPercent.Name = "pendingPercent";
            pendingPercent.Size = new Size(57, 18);
            pendingPercent.TabIndex = 10;
            pendingPercent.Text = "Percent";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(499, 49);
            label4.Name = "label4";
            label4.Size = new Size(97, 25);
            label4.TabIndex = 9;
            label4.Text = "Interest";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(499, 19);
            label3.Name = "label3";
            label3.Size = new Size(83, 14);
            label3.TabIndex = 8;
            label3.Text = "Total Interest";
            // 
            // pendingRepaymentTerm
            // 
            pendingRepaymentTerm.AutoSize = true;
            pendingRepaymentTerm.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pendingRepaymentTerm.Location = new Point(330, 83);
            pendingRepaymentTerm.Name = "pendingRepaymentTerm";
            pendingRepaymentTerm.Size = new Size(124, 18);
            pendingRepaymentTerm.TabIndex = 7;
            pendingRepaymentTerm.Text = "Repayment Term";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(330, 19);
            label2.Name = "label2";
            label2.Size = new Size(66, 14);
            label2.TabIndex = 6;
            label2.Text = "Requested";
            // 
            // pendingPhoneNumber
            // 
            pendingPhoneNumber.AutoSize = true;
            pendingPhoneNumber.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pendingPhoneNumber.Location = new Point(10, 83);
            pendingPhoneNumber.Name = "pendingPhoneNumber";
            pendingPhoneNumber.Size = new Size(60, 18);
            pendingPhoneNumber.TabIndex = 5;
            pendingPhoneNumber.Text = "Number";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(10, 19);
            label1.Name = "label1";
            label1.Size = new Size(57, 14);
            label1.TabIndex = 4;
            label1.Text = "Borrower";
            // 
            // pendingLoanAmount
            // 
            pendingLoanAmount.AutoSize = true;
            pendingLoanAmount.BackColor = Color.Transparent;
            pendingLoanAmount.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pendingLoanAmount.Location = new Point(330, 49);
            pendingLoanAmount.Margin = new Padding(0);
            pendingLoanAmount.Name = "pendingLoanAmount";
            pendingLoanAmount.Size = new Size(94, 25);
            pendingLoanAmount.TabIndex = 3;
            pendingLoanAmount.Text = "Amount";
            // 
            // pendingApplicantName
            // 
            pendingApplicantName.AutoSize = true;
            pendingApplicantName.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pendingApplicantName.Location = new Point(10, 49);
            pendingApplicantName.Name = "pendingApplicantName";
            pendingApplicantName.Size = new Size(177, 25);
            pendingApplicantName.TabIndex = 2;
            pendingApplicantName.Text = "Applicant Name";
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.Controls.Add(pendingApplicantName);
            panel2.Controls.Add(pendingLoanAmount);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pendingPhoneNumber);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pendingRepaymentTerm);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(pendingPercent);
            panel2.Location = new Point(437, 147);
            panel2.Name = "panel2";
            panel2.Size = new Size(629, 130);
            panel2.TabIndex = 38;
            // 
            // formPending
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1092, 609);
            Controls.Add(panel2);
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
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ApplicationID;
        private DataGridViewTextBoxColumn ApplicantName;
        private DataGridViewTextBoxColumn repaymentterm;
        private DataGridViewTextBoxColumn LoanAmount;
        private DataGridViewTextBoxColumn VerificationStatus;
        private Panel pendingPanel;
        private Label pendingLoanAmount;
        private Label pendingApplicantName;
        private Label pendingStatus;
        private Label pendingApplicationId;
        private Label label1;
        private Label label2;
        private Label pendingPhoneNumber;
        private Label pendingPercent;
        private Label label4;
        private Label label3;
        private Label pendingRepaymentTerm;
        private Label label5;
        private Label label6;
        private Label label10;
        private ComboBox pendingUpdateStatus;
        private Panel panel1;
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
    }
}