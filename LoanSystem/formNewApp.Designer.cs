namespace LoanSystem
{
    partial class formNewApp
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
            newAppBtn = new Button();
            dataGridView1 = new DataGridView();
            ApplicationID = new DataGridViewTextBoxColumn();
            ApplicantName = new DataGridViewTextBoxColumn();
            ApplicationDate = new DataGridViewTextBoxColumn();
            LoanType = new DataGridViewTextBoxColumn();
            LoanAmount = new DataGridViewTextBoxColumn();
            EmploymentStatus = new DataGridViewTextBoxColumn();
            AnnualIncome = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            AssignedOfficer = new DataGridViewTextBoxColumn();
            Action = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // newAppBtn
            // 
            newAppBtn.BackColor = Color.SeaGreen;
            newAppBtn.FlatStyle = FlatStyle.Flat;
            newAppBtn.ForeColor = Color.Transparent;
            newAppBtn.Location = new Point(937, 12);
            newAppBtn.Name = "newAppBtn";
            newAppBtn.Size = new Size(143, 38);
            newAppBtn.TabIndex = 24;
            newAppBtn.Text = "Create";
            newAppBtn.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ApplicationID, ApplicantName, ApplicationDate, LoanType, LoanAmount, EmploymentStatus, AnnualIncome, Status, AssignedOfficer, Action });
            dataGridView1.GridColor = Color.Black;
            dataGridView1.Location = new Point(12, 56);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1068, 541);
            dataGridView1.TabIndex = 25;
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
            // Status
            // 
            Status.HeaderText = "Status";
            Status.Name = "Status";
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
            // formNewApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1092, 609);
            Controls.Add(dataGridView1);
            Controls.Add(newAppBtn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formNewApp";
            Text = "formNewApp";
            Load += formNewApp_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button newAppBtn;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ApplicationID;
        private DataGridViewTextBoxColumn ApplicantName;
        private DataGridViewTextBoxColumn ApplicationDate;
        private DataGridViewTextBoxColumn LoanType;
        private DataGridViewTextBoxColumn LoanAmount;
        private DataGridViewTextBoxColumn EmploymentStatus;
        private DataGridViewTextBoxColumn AnnualIncome;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn AssignedOfficer;
        private DataGridViewTextBoxColumn Action;
    }
}