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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.GridColor = Color.Black;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(1068, 585);
            dataGridView1.TabIndex = 27;
            // 
            // LoanID
            // 
            LoanID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            LoanID.HeaderText = "Loan ID";
            LoanID.Name = "LoanID";
            // 
            // ApplicantName
            // 
            ApplicantName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ApplicantName.HeaderText = "Applicant Name";
            ApplicantName.Name = "ApplicantName";
            ApplicantName.Width = 108;
            // 
            // LoanType
            // 
            LoanType.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            LoanType.HeaderText = "Loan Type";
            LoanType.Name = "LoanType";
            // 
            // OriginalLoanAmount
            // 
            OriginalLoanAmount.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            OriginalLoanAmount.HeaderText = "Original Loan Amount";
            OriginalLoanAmount.Name = "OriginalLoanAmount";
            // 
            // MonthlyPaymentAmount
            // 
            MonthlyPaymentAmount.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MonthlyPaymentAmount.HeaderText = "Monthly Payment Amount";
            MonthlyPaymentAmount.Name = "MonthlyPaymentAmount";
            // 
            // LastPaymentDate
            // 
            LastPaymentDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            LastPaymentDate.HeaderText = "Last Payment Date";
            LastPaymentDate.Name = "LastPaymentDate";
            // 
            // NextPaymentDueDate
            // 
            NextPaymentDueDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NextPaymentDueDate.HeaderText = "Next Payment Due Date";
            NextPaymentDueDate.Name = "NextPaymentDueDate";
            // 
            // OutstandingBalance
            // 
            OutstandingBalance.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            OutstandingBalance.HeaderText = "Outstanding Balance";
            OutstandingBalance.Name = "OutstandingBalance";
            // 
            // RepaymentStatus
            // 
            RepaymentStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            RepaymentStatus.HeaderText = "Repayment Status";
            RepaymentStatus.Name = "RepaymentStatus";
            // 
            // LoanTermRemaining
            // 
            LoanTermRemaining.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            LoanTermRemaining.HeaderText = "Loan Term Remaining";
            LoanTermRemaining.Name = "LoanTermRemaining";
            // 
            // Action
            // 
            Action.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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