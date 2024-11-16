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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ApplicationID, ApplicantName, ApprovalDate, LoanType, LoanAmount, RepaymentTerm, MonthlyPayment, OutstandingBalance, NextPaymentDueDate, RepaymentStatus, Action });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.GridColor = Color.Black;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(1068, 585);
            dataGridView1.TabIndex = 26;
            // 
            // ApplicationID
            // 
            ApplicationID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ApplicationID.HeaderText = "Application ID";
            ApplicationID.Name = "ApplicationID";
            // 
            // ApplicantName
            // 
            ApplicantName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ApplicantName.HeaderText = "Applicant Name";
            ApplicantName.Name = "ApplicantName";
            ApplicantName.Width = 108;
            // 
            // ApprovalDate
            // 
            ApprovalDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ApprovalDate.HeaderText = "Approval Date";
            ApprovalDate.Name = "ApprovalDate";
            // 
            // LoanType
            // 
            LoanType.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            LoanType.HeaderText = "Loan Type";
            LoanType.Name = "LoanType";
            // 
            // LoanAmount
            // 
            LoanAmount.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            LoanAmount.HeaderText = "Loan Amount";
            LoanAmount.Name = "LoanAmount";
            // 
            // RepaymentTerm
            // 
            RepaymentTerm.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            RepaymentTerm.HeaderText = "Repayment Term";
            RepaymentTerm.Name = "RepaymentTerm";
            // 
            // MonthlyPayment
            // 
            MonthlyPayment.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MonthlyPayment.HeaderText = "Monthly Payment";
            MonthlyPayment.Name = "MonthlyPayment";
            // 
            // OutstandingBalance
            // 
            OutstandingBalance.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            OutstandingBalance.HeaderText = "Outstanding Balance";
            OutstandingBalance.Name = "OutstandingBalance";
            // 
            // NextPaymentDueDate
            // 
            NextPaymentDueDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NextPaymentDueDate.HeaderText = "Next Payment Due Date";
            NextPaymentDueDate.Name = "NextPaymentDueDate";
            // 
            // RepaymentStatus
            // 
            RepaymentStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            RepaymentStatus.HeaderText = "Repayment Status";
            RepaymentStatus.Name = "RepaymentStatus";
            // 
            // Action
            // 
            Action.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Action.HeaderText = "Action";
            Action.Name = "Action";
            // 
            // formApproved
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1092, 609);
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
    }
}