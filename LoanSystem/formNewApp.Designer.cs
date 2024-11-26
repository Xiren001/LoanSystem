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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
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
            newAppUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // newAppBtn
            // 
            newAppBtn.BackColor = Color.SeaGreen;
            newAppBtn.FlatStyle = FlatStyle.Flat;
            newAppBtn.ForeColor = Color.Transparent;
            newAppBtn.Location = new Point(788, 12);
            newAppBtn.Name = "newAppBtn";
            newAppBtn.Size = new Size(143, 38);
            newAppBtn.TabIndex = 24;
            newAppBtn.Text = "Create";
            newAppBtn.UseVisualStyleBackColor = false;
            newAppBtn.Click += newAppBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ApplicationID, ApplicantName, ApplicationDate, LoanType, LoanAmount, EmploymentStatus, AnnualIncome, Status, AssignedOfficer, Action });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.GridColor = Color.Black;
            dataGridView1.Location = new Point(12, 56);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1068, 541);
            dataGridView1.TabIndex = 25;
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
            ApplicantName.Width = 116;
            // 
            // ApplicationDate
            // 
            ApplicationDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ApplicationDate.HeaderText = "Application Date";
            ApplicationDate.Name = "ApplicationDate";
            ApplicationDate.ReadOnly = true;
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
            // EmploymentStatus
            // 
            EmploymentStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            EmploymentStatus.HeaderText = "Employment Status";
            EmploymentStatus.Name = "EmploymentStatus";
            EmploymentStatus.ReadOnly = true;
            // 
            // AnnualIncome
            // 
            AnnualIncome.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            AnnualIncome.HeaderText = "Annual Income";
            AnnualIncome.Name = "AnnualIncome";
            AnnualIncome.ReadOnly = true;
            // 
            // Status
            // 
            Status.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Status.HeaderText = "Status";
            Status.Name = "Status";
            Status.ReadOnly = true;
            // 
            // AssignedOfficer
            // 
            AssignedOfficer.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            AssignedOfficer.HeaderText = "Assigned Officer";
            AssignedOfficer.Name = "AssignedOfficer";
            AssignedOfficer.ReadOnly = true;
            // 
            // Action
            // 
            Action.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Action.HeaderText = "Action";
            Action.Name = "Action";
            Action.ReadOnly = true;
            // 
            // newAppUpdate
            // 
            newAppUpdate.BackColor = Color.Khaki;
            newAppUpdate.FlatStyle = FlatStyle.Flat;
            newAppUpdate.ForeColor = Color.Black;
            newAppUpdate.Location = new Point(937, 12);
            newAppUpdate.Name = "newAppUpdate";
            newAppUpdate.Size = new Size(143, 38);
            newAppUpdate.TabIndex = 26;
            newAppUpdate.Text = "Create";
            newAppUpdate.UseVisualStyleBackColor = false;
            newAppUpdate.Click += newAppUpdate_Click;
            // 
            // formNewApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1092, 609);
            Controls.Add(newAppUpdate);
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
        private Button newAppUpdate;
    }
}