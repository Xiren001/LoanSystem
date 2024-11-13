namespace LoanSystem
{
    partial class formRepayment
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
            dataGridView1 = new DataGridView();
            LoanID = new DataGridViewTextBoxColumn();
            ApplicantName = new DataGridViewTextBoxColumn();
            LoanType = new DataGridViewTextBoxColumn();
            OriginalLoanAmount = new DataGridViewTextBoxColumn();
            MonthlyPaymentAmount = new DataGridViewTextBoxColumn();
            LastPaymentDate = new DataGridViewTextBoxColumn();
            NextPaymentDueDate = new DataGridViewTextBoxColumn();
            OutstandingBalance = new DataGridViewTextBoxColumn();
            RepaymentStatus = new DataGridViewTextBoxColumn();
            LoanTermRemaining = new DataGridViewTextBoxColumn();
            Action = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { LoanID, ApplicantName, LoanType, OriginalLoanAmount, MonthlyPaymentAmount, LastPaymentDate, NextPaymentDueDate, OutstandingBalance, RepaymentStatus, LoanTermRemaining, Action });
            dataGridView1.GridColor = Color.Black;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1068, 585);
            dataGridView1.TabIndex = 27;
            // 
            // LoanID
            // 
            LoanID.HeaderText = "Loan ID";
            LoanID.Name = "LoanID";
            LoanID.Width = 77;
            // 
            // ApplicantName
            // 
            ApplicantName.HeaderText = "Applicant Name";
            ApplicantName.Name = "ApplicantName";
            // 
            // LoanType
            // 
            LoanType.HeaderText = "Loan Type";
            LoanType.Name = "LoanType";
            LoanType.Width = 80;
            // 
            // OriginalLoanAmount
            // 
            OriginalLoanAmount.HeaderText = "Original Loan Amount";
            OriginalLoanAmount.Name = "OriginalLoanAmount";
            // 
            // MonthlyPaymentAmount
            // 
            MonthlyPaymentAmount.HeaderText = "Monthly Payment Amount";
            MonthlyPaymentAmount.Name = "MonthlyPaymentAmount";
            // 
            // LastPaymentDate
            // 
            LastPaymentDate.HeaderText = "Last Payment Date";
            LastPaymentDate.Name = "LastPaymentDate";
            // 
            // NextPaymentDueDate
            // 
            NextPaymentDueDate.HeaderText = "Next Payment Due Date";
            NextPaymentDueDate.Name = "NextPaymentDueDate";
            // 
            // OutstandingBalance
            // 
            OutstandingBalance.HeaderText = "Outstanding Balance";
            OutstandingBalance.Name = "OutstandingBalance";
            // 
            // RepaymentStatus
            // 
            RepaymentStatus.HeaderText = "Repayment Status";
            RepaymentStatus.Name = "RepaymentStatus";
            RepaymentStatus.Width = 80;
            // 
            // LoanTermRemaining
            // 
            LoanTermRemaining.HeaderText = "Loan Term Remaining";
            LoanTermRemaining.Name = "LoanTermRemaining";
            LoanTermRemaining.Width = 90;
            // 
            // Action
            // 
            Action.HeaderText = "Action";
            Action.Name = "Action";
            // 
            // formRepayment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1092, 609);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formRepayment";
            Text = "formRepayment";
            Load += formRepayment_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn LoanID;
        private DataGridViewTextBoxColumn ApplicantName;
        private DataGridViewTextBoxColumn LoanType;
        private DataGridViewTextBoxColumn OriginalLoanAmount;
        private DataGridViewTextBoxColumn MonthlyPaymentAmount;
        private DataGridViewTextBoxColumn LastPaymentDate;
        private DataGridViewTextBoxColumn NextPaymentDueDate;
        private DataGridViewTextBoxColumn OutstandingBalance;
        private DataGridViewTextBoxColumn RepaymentStatus;
        private DataGridViewTextBoxColumn LoanTermRemaining;
        private DataGridViewTextBoxColumn Action;
    }
}