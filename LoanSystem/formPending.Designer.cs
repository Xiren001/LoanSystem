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
            dataGridView1 = new DataGridView();
            ApplicationID = new DataGridViewTextBoxColumn();
            ApplicantName = new DataGridViewTextBoxColumn();
            ApplicationDate = new DataGridViewTextBoxColumn();
            LoanType = new DataGridViewTextBoxColumn();
            LoanAmount = new DataGridViewTextBoxColumn();
            EmploymentStatus = new DataGridViewTextBoxColumn();
            AnnualIncome = new DataGridViewTextBoxColumn();
            VerificationStatus = new DataGridViewTextBoxColumn();
            AssignedOfficer = new DataGridViewTextBoxColumn();
            Action = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ApplicationID, ApplicantName, ApplicationDate, LoanType, LoanAmount, EmploymentStatus, AnnualIncome, VerificationStatus, AssignedOfficer, Action });
            dataGridView1.GridColor = Color.Black;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1068, 585);
            dataGridView1.TabIndex = 26;
            // 
            // ApplicationID
            // 
            ApplicationID.HeaderText = "Application ID";
            ApplicationID.Name = "ApplicationID";
            // 
            // ApplicantName
            // 
            ApplicantName.HeaderText = "Applicant Name";
            ApplicantName.Name = "ApplicantName";
            // 
            // ApplicationDate
            // 
            ApplicationDate.HeaderText = "Application Date";
            ApplicationDate.Name = "ApplicationDate";
            // 
            // LoanType
            // 
            LoanType.HeaderText = "Loan Type";
            LoanType.Name = "LoanType";
            // 
            // LoanAmount
            // 
            LoanAmount.HeaderText = "Loan Amount";
            LoanAmount.Name = "LoanAmount";
            // 
            // EmploymentStatus
            // 
            EmploymentStatus.HeaderText = "Employment Status";
            EmploymentStatus.Name = "EmploymentStatus";
            // 
            // AnnualIncome
            // 
            AnnualIncome.HeaderText = "Annual Income";
            AnnualIncome.Name = "AnnualIncome";
            // 
            // VerificationStatus
            // 
            VerificationStatus.HeaderText = "Verification Status";
            VerificationStatus.Name = "VerificationStatus";
            // 
            // AssignedOfficer
            // 
            AssignedOfficer.HeaderText = "Assigned Officer";
            AssignedOfficer.Name = "AssignedOfficer";
            // 
            // Action
            // 
            Action.HeaderText = "Action";
            Action.Name = "Action";
            Action.Width = 125;
            // 
            // formPending
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1092, 609);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formPending";
            Text = "formPending";
            Load += formPending_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ApplicationID;
        private DataGridViewTextBoxColumn ApplicantName;
        private DataGridViewTextBoxColumn ApplicationDate;
        private DataGridViewTextBoxColumn LoanType;
        private DataGridViewTextBoxColumn LoanAmount;
        private DataGridViewTextBoxColumn EmploymentStatus;
        private DataGridViewTextBoxColumn AnnualIncome;
        private DataGridViewTextBoxColumn VerificationStatus;
        private DataGridViewTextBoxColumn AssignedOfficer;
        private DataGridViewTextBoxColumn Action;
    }
}