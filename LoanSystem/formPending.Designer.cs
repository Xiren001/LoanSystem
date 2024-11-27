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
            pendingUpdateStatus = new ComboBox();
            label29 = new Label();
            label28 = new Label();
            label27 = new Label();
            label26 = new Label();
            label25 = new Label();
            label24 = new Label();
            label23 = new Label();
            label22 = new Label();
            label21 = new Label();
            label20 = new Label();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            pendingPercent = new Label();
            label4 = new Label();
            label3 = new Label();
            pendingRepaymentTerm = new Label();
            label2 = new Label();
            pendingPhoneNumber = new Label();
            label1 = new Label();
            pendingLoanAmount = new Label();
            pendingApplicantName = new Label();
            pendingStatus = new Label();
            pendingApplicationId = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            pendingPanel.SuspendLayout();
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
            dataGridView1.Size = new Size(420, 585);
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
            pendingPanel.Controls.Add(panel1);
            pendingPanel.Controls.Add(pendingUpdateStatus);
            pendingPanel.Controls.Add(label29);
            pendingPanel.Controls.Add(label28);
            pendingPanel.Controls.Add(label27);
            pendingPanel.Controls.Add(label26);
            pendingPanel.Controls.Add(label25);
            pendingPanel.Controls.Add(label24);
            pendingPanel.Controls.Add(label23);
            pendingPanel.Controls.Add(label22);
            pendingPanel.Controls.Add(label21);
            pendingPanel.Controls.Add(label20);
            pendingPanel.Controls.Add(label19);
            pendingPanel.Controls.Add(label18);
            pendingPanel.Controls.Add(label17);
            pendingPanel.Controls.Add(label16);
            pendingPanel.Controls.Add(label15);
            pendingPanel.Controls.Add(label14);
            pendingPanel.Controls.Add(label13);
            pendingPanel.Controls.Add(label12);
            pendingPanel.Controls.Add(label11);
            pendingPanel.Controls.Add(label10);
            pendingPanel.Controls.Add(label9);
            pendingPanel.Controls.Add(label8);
            pendingPanel.Controls.Add(label7);
            pendingPanel.Controls.Add(label6);
            pendingPanel.Controls.Add(label5);
            pendingPanel.Controls.Add(pendingPercent);
            pendingPanel.Controls.Add(label4);
            pendingPanel.Controls.Add(label3);
            pendingPanel.Controls.Add(pendingRepaymentTerm);
            pendingPanel.Controls.Add(label2);
            pendingPanel.Controls.Add(pendingPhoneNumber);
            pendingPanel.Controls.Add(label1);
            pendingPanel.Controls.Add(pendingLoanAmount);
            pendingPanel.Controls.Add(pendingApplicantName);
            pendingPanel.Controls.Add(pendingStatus);
            pendingPanel.Controls.Add(pendingApplicationId);
            pendingPanel.Location = new Point(438, 12);
            pendingPanel.Name = "pendingPanel";
            pendingPanel.Size = new Size(642, 585);
            pendingPanel.TabIndex = 27;
            // 
            // pendingUpdateStatus
            // 
            pendingUpdateStatus.FlatStyle = FlatStyle.Flat;
            pendingUpdateStatus.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pendingUpdateStatus.FormattingEnabled = true;
            pendingUpdateStatus.Items.AddRange(new object[] { "Approve", "Reject" });
            pendingUpdateStatus.Location = new Point(458, 14);
            pendingUpdateStatus.Name = "pendingUpdateStatus";
            pendingUpdateStatus.Size = new Size(147, 22);
            pendingUpdateStatus.TabIndex = 36;
            pendingUpdateStatus.Text = "Pending";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label29.Location = new Point(443, 547);
            label29.Name = "label29";
            label29.Size = new Size(57, 14);
            label29.TabIndex = 35;
            label29.Text = "Borrower";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label28.Location = new Point(443, 518);
            label28.Name = "label28";
            label28.Size = new Size(57, 14);
            label28.TabIndex = 34;
            label28.Text = "Borrower";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label27.Location = new Point(443, 488);
            label27.Name = "label27";
            label27.Size = new Size(57, 14);
            label27.TabIndex = 33;
            label27.Text = "Borrower";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label26.Location = new Point(443, 458);
            label26.Name = "label26";
            label26.Size = new Size(57, 14);
            label26.TabIndex = 32;
            label26.Text = "Borrower";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label25.Location = new Point(443, 429);
            label25.Name = "label25";
            label25.Size = new Size(57, 14);
            label25.TabIndex = 31;
            label25.Text = "Borrower";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label24.Location = new Point(443, 401);
            label24.Name = "label24";
            label24.Size = new Size(57, 14);
            label24.TabIndex = 30;
            label24.Text = "Borrower";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label23.Location = new Point(443, 373);
            label23.Name = "label23";
            label23.Size = new Size(57, 14);
            label23.TabIndex = 29;
            label23.Text = "Borrower";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label22.Location = new Point(443, 342);
            label22.Name = "label22";
            label22.Size = new Size(57, 14);
            label22.TabIndex = 28;
            label22.Text = "Borrower";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label21.Location = new Point(238, 547);
            label21.Name = "label21";
            label21.Size = new Size(57, 14);
            label21.TabIndex = 27;
            label21.Text = "Borrower";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label20.Location = new Point(238, 518);
            label20.Name = "label20";
            label20.Size = new Size(57, 14);
            label20.TabIndex = 26;
            label20.Text = "Borrower";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label19.Location = new Point(238, 488);
            label19.Name = "label19";
            label19.Size = new Size(57, 14);
            label19.TabIndex = 25;
            label19.Text = "Borrower";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.Location = new Point(238, 458);
            label18.Name = "label18";
            label18.Size = new Size(57, 14);
            label18.TabIndex = 24;
            label18.Text = "Borrower";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.Location = new Point(238, 429);
            label17.Name = "label17";
            label17.Size = new Size(57, 14);
            label17.TabIndex = 23;
            label17.Text = "Borrower";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.Location = new Point(238, 401);
            label16.Name = "label16";
            label16.Size = new Size(57, 14);
            label16.TabIndex = 22;
            label16.Text = "Borrower";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(238, 373);
            label15.Name = "label15";
            label15.Size = new Size(57, 14);
            label15.TabIndex = 21;
            label15.Text = "Borrower";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(238, 342);
            label14.Name = "label14";
            label14.Size = new Size(57, 14);
            label14.TabIndex = 20;
            label14.Text = "Borrower";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(22, 547);
            label13.Name = "label13";
            label13.Size = new Size(57, 14);
            label13.TabIndex = 19;
            label13.Text = "Borrower";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(22, 518);
            label12.Name = "label12";
            label12.Size = new Size(57, 14);
            label12.TabIndex = 18;
            label12.Text = "Borrower";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(22, 488);
            label11.Name = "label11";
            label11.Size = new Size(57, 14);
            label11.TabIndex = 17;
            label11.Text = "Borrower";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(22, 458);
            label10.Name = "label10";
            label10.Size = new Size(57, 14);
            label10.TabIndex = 16;
            label10.Text = "Borrower";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(22, 429);
            label9.Name = "label9";
            label9.Size = new Size(57, 14);
            label9.TabIndex = 15;
            label9.Text = "Borrower";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(22, 401);
            label8.Name = "label8";
            label8.Size = new Size(57, 14);
            label8.TabIndex = 14;
            label8.Text = "Borrower";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(22, 373);
            label7.Name = "label7";
            label7.Size = new Size(57, 14);
            label7.TabIndex = 13;
            label7.Text = "Borrower";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(22, 342);
            label6.Name = "label6";
            label6.Size = new Size(57, 14);
            label6.TabIndex = 12;
            label6.Text = "Borrower";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(22, 310);
            label5.Name = "label5";
            label5.Size = new Size(123, 19);
            label5.TabIndex = 11;
            label5.Text = "Borrower Info";
            // 
            // pendingPercent
            // 
            pendingPercent.AutoSize = true;
            pendingPercent.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pendingPercent.Location = new Point(443, 230);
            pendingPercent.Name = "pendingPercent";
            pendingPercent.Size = new Size(61, 19);
            pendingPercent.TabIndex = 10;
            pendingPercent.Text = "Percent";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(443, 191);
            label4.Name = "label4";
            label4.Size = new Size(136, 25);
            label4.TabIndex = 9;
            label4.Text = "Loan Amount";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(443, 165);
            label3.Name = "label3";
            label3.Size = new Size(83, 14);
            label3.TabIndex = 8;
            label3.Text = "Total Interest";
            // 
            // pendingRepaymentTerm
            // 
            pendingRepaymentTerm.AutoSize = true;
            pendingRepaymentTerm.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pendingRepaymentTerm.Location = new Point(238, 230);
            pendingRepaymentTerm.Name = "pendingRepaymentTerm";
            pendingRepaymentTerm.Size = new Size(131, 19);
            pendingRepaymentTerm.TabIndex = 7;
            pendingRepaymentTerm.Text = "Repayment Term";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(238, 165);
            label2.Name = "label2";
            label2.Size = new Size(66, 14);
            label2.TabIndex = 6;
            label2.Text = "Requested";
            // 
            // pendingPhoneNumber
            // 
            pendingPhoneNumber.AutoSize = true;
            pendingPhoneNumber.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pendingPhoneNumber.Location = new Point(13, 230);
            pendingPhoneNumber.Name = "pendingPhoneNumber";
            pendingPhoneNumber.Size = new Size(66, 19);
            pendingPhoneNumber.TabIndex = 5;
            pendingPhoneNumber.Text = "Number";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 165);
            label1.Name = "label1";
            label1.Size = new Size(57, 14);
            label1.TabIndex = 4;
            label1.Text = "Borrower";
            // 
            // pendingLoanAmount
            // 
            pendingLoanAmount.AutoSize = true;
            pendingLoanAmount.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pendingLoanAmount.Location = new Point(238, 191);
            pendingLoanAmount.Name = "pendingLoanAmount";
            pendingLoanAmount.Size = new Size(136, 25);
            pendingLoanAmount.TabIndex = 3;
            pendingLoanAmount.Text = "Loan Amount";
            // 
            // pendingApplicantName
            // 
            pendingApplicantName.AutoSize = true;
            pendingApplicantName.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pendingApplicantName.Location = new Point(13, 191);
            pendingApplicantName.Name = "pendingApplicantName";
            pendingApplicantName.Size = new Size(160, 25);
            pendingApplicantName.TabIndex = 2;
            pendingApplicantName.Text = "Applicant Name";
            // 
            // pendingStatus
            // 
            pendingStatus.AutoSize = true;
            pendingStatus.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pendingStatus.Location = new Point(163, 10);
            pendingStatus.Name = "pendingStatus";
            pendingStatus.Size = new Size(70, 25);
            pendingStatus.TabIndex = 1;
            pendingStatus.Text = "Status";
            // 
            // pendingApplicationId
            // 
            pendingApplicationId.AutoSize = true;
            pendingApplicationId.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pendingApplicationId.Location = new Point(13, 10);
            pendingApplicationId.Name = "pendingApplicationId";
            pendingApplicationId.Size = new Size(144, 25);
            pendingApplicationId.TabIndex = 0;
            pendingApplicationId.Text = "Application ID";
            // 
            // panel1
            // 
            panel1.Location = new Point(12, 74);
            panel1.Name = "panel1";
            panel1.Size = new Size(616, 45);
            panel1.TabIndex = 37;
            // 
            // formPending
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1092, 609);
            Controls.Add(pendingPanel);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formPending";
            Text = "formPending";
            Load += formPending_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            pendingPanel.ResumeLayout(false);
            pendingPanel.PerformLayout();
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
        private Label label21;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private ComboBox pendingUpdateStatus;
        private Label label29;
        private Label label28;
        private Label label27;
        private Label label26;
        private Label label25;
        private Label label24;
        private Label label23;
        private Label label22;
        private Panel panel1;
    }
}