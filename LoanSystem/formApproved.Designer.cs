namespace LoanSystem
{
    partial class formApproved
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
            ApprovalDate = new DataGridViewTextBoxColumn();
            LoanType = new DataGridViewTextBoxColumn();
            LoanAmount = new DataGridViewTextBoxColumn();
            RepaymentTerm = new DataGridViewTextBoxColumn();
            MonthlyPayment = new DataGridViewTextBoxColumn();
            OutstandingBalance = new DataGridViewTextBoxColumn();
            NextPaymentDueDate = new DataGridViewTextBoxColumn();
            RepaymentStatus = new DataGridViewTextBoxColumn();
            Action = new DataGridViewTextBoxColumn();
            btnTransfer = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            dataGridViewCellStyle1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ApplicationID, ApplicantName, ApprovalDate, LoanType, LoanAmount, RepaymentTerm, MonthlyPayment, OutstandingBalance, NextPaymentDueDate, RepaymentStatus, Action });
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
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1383, 752);
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
            ApplicantName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ApplicantName.HeaderText = "Applicant Name";
            ApplicantName.Name = "ApplicantName";
            ApplicantName.ReadOnly = true;
            ApplicantName.Width = 149;
            // 
            // ApprovalDate
            // 
            ApprovalDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ApprovalDate.HeaderText = "Approval Date";
            ApprovalDate.Name = "ApprovalDate";
            ApprovalDate.ReadOnly = true;
            // 
            // LoanType
            // 
            LoanType.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            LoanType.HeaderText = "Loan Type";
            LoanType.Name = "LoanType";
            LoanType.ReadOnly = true;
            // 
            // LoanAmount
            // 
            LoanAmount.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            LoanAmount.HeaderText = "Loan Amount";
            LoanAmount.Name = "LoanAmount";
            LoanAmount.ReadOnly = true;
            // 
            // RepaymentTerm
            // 
            RepaymentTerm.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            RepaymentTerm.HeaderText = "Repayment Term";
            RepaymentTerm.Name = "RepaymentTerm";
            RepaymentTerm.ReadOnly = true;
            // 
            // MonthlyPayment
            // 
            MonthlyPayment.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MonthlyPayment.HeaderText = "Monthly Payment";
            MonthlyPayment.Name = "MonthlyPayment";
            MonthlyPayment.ReadOnly = true;
            // 
            // OutstandingBalance
            // 
            OutstandingBalance.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            OutstandingBalance.HeaderText = "Outstanding Balance";
            OutstandingBalance.Name = "OutstandingBalance";
            OutstandingBalance.ReadOnly = true;
            // 
            // NextPaymentDueDate
            // 
            NextPaymentDueDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NextPaymentDueDate.HeaderText = "Next Payment Due Date";
            NextPaymentDueDate.Name = "NextPaymentDueDate";
            NextPaymentDueDate.ReadOnly = true;
            // 
            // RepaymentStatus
            // 
            RepaymentStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            RepaymentStatus.HeaderText = "Repayment Status";
            RepaymentStatus.Name = "RepaymentStatus";
            RepaymentStatus.ReadOnly = true;
            // 
            // Action
            // 
            Action.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Action.HeaderText = "Action";
            Action.Name = "Action";
            Action.ReadOnly = true;
            // 
            // btnTransfer
            // 
            btnTransfer.BackColor = Color.SeaGreen;
            btnTransfer.FlatAppearance.BorderSize = 0;
            btnTransfer.FlatStyle = FlatStyle.Flat;
            btnTransfer.ForeColor = Color.Transparent;
            btnTransfer.Location = new Point(1164, 770);
            btnTransfer.Name = "btnTransfer";
            btnTransfer.Size = new Size(231, 38);
            btnTransfer.TabIndex = 27;
            btnTransfer.Text = "Proceed to Repayment";
            btnTransfer.UseVisualStyleBackColor = false;
            btnTransfer.Click += btnTransfer_Click_1;
            // 
            // formApproved
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1407, 820);
            Controls.Add(btnTransfer);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formApproved";
            Text = "formApproved";
            Load += formApproved_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ApplicationID;
        private DataGridViewTextBoxColumn ApplicantName;
        private DataGridViewTextBoxColumn ApprovalDate;
        private DataGridViewTextBoxColumn LoanType;
        private DataGridViewTextBoxColumn LoanAmount;
        private DataGridViewTextBoxColumn RepaymentTerm;
        private DataGridViewTextBoxColumn MonthlyPayment;
        private DataGridViewTextBoxColumn OutstandingBalance;
        private DataGridViewTextBoxColumn NextPaymentDueDate;
        private DataGridViewTextBoxColumn RepaymentStatus;
        private DataGridViewTextBoxColumn Action;
        private Button btnTransfer;
    }
}