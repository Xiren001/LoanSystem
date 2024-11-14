namespace LoanSystem
{
    partial class formCustomer
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
            ClientID = new DataGridViewTextBoxColumn();
            FullName = new DataGridViewTextBoxColumn();
            ContactInformation = new DataGridViewTextBoxColumn();
            LoanAmount = new DataGridViewTextBoxColumn();
            OutstandingLoanBalance = new DataGridViewTextBoxColumn();
            RecentActivityDate = new DataGridViewTextBoxColumn();
            TotalPaidtoDate = new DataGridViewTextBoxColumn();
            AssignedOfficer = new DataGridViewTextBoxColumn();
            AccountStatus = new DataGridViewTextBoxColumn();
            Action = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ClientID, FullName, ContactInformation, LoanAmount, OutstandingLoanBalance, RecentActivityDate, TotalPaidtoDate, AssignedOfficer, AccountStatus, Action });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
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
            // ClientID
            // 
            ClientID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ClientID.HeaderText = "Client ID";
            ClientID.Name = "ClientID";
            // 
            // FullName
            // 
            FullName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            FullName.HeaderText = "Full Name";
            FullName.Name = "FullName";
            FullName.Width = 79;
            // 
            // ContactInformation
            // 
            ContactInformation.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ContactInformation.HeaderText = "Contact Information";
            ContactInformation.Name = "ContactInformation";
            // 
            // LoanAmount
            // 
            LoanAmount.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            LoanAmount.HeaderText = "Loan Amount";
            LoanAmount.Name = "LoanAmount";
            // 
            // OutstandingLoanBalance
            // 
            OutstandingLoanBalance.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            OutstandingLoanBalance.HeaderText = "Outstanding Loan Balance";
            OutstandingLoanBalance.Name = "OutstandingLoanBalance";
            // 
            // RecentActivityDate
            // 
            RecentActivityDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            RecentActivityDate.HeaderText = "Recent Activity Date";
            RecentActivityDate.Name = "RecentActivityDate";
            // 
            // TotalPaidtoDate
            // 
            TotalPaidtoDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TotalPaidtoDate.HeaderText = "Total Paid to Date";
            TotalPaidtoDate.Name = "TotalPaidtoDate";
            // 
            // AssignedOfficer
            // 
            AssignedOfficer.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            AssignedOfficer.HeaderText = "Assigned Officer";
            AssignedOfficer.Name = "AssignedOfficer";
            // 
            // AccountStatus
            // 
            AccountStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            AccountStatus.HeaderText = "Account Status";
            AccountStatus.Name = "AccountStatus";
            // 
            // Action
            // 
            Action.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Action.HeaderText = "Action";
            Action.Name = "Action";
            Action.Width = 67;
            // 
            // formCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1092, 609);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formCustomer";
            Text = "formCustomer";
            Load += formCustomer_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ClientID;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn ContactInformation;
        private DataGridViewTextBoxColumn LoanAmount;
        private DataGridViewTextBoxColumn OutstandingLoanBalance;
        private DataGridViewTextBoxColumn RecentActivityDate;
        private DataGridViewTextBoxColumn TotalPaidtoDate;
        private DataGridViewTextBoxColumn AssignedOfficer;
        private DataGridViewTextBoxColumn AccountStatus;
        private DataGridViewTextBoxColumn Action;
    }
}