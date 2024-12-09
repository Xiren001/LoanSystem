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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formRepayment));
            dataGridView1 = new DataGridView();
            LoanID = new DataGridViewTextBoxColumn();
            ApplicantName = new DataGridViewTextBoxColumn();
            LoanType = new DataGridViewTextBoxColumn();
            RepaymentStatus = new DataGridViewTextBoxColumn();
            pendingPanel = new Panel();
            repaymentbtn = new Button();
            repaymentInterestrate = new Label();
            label12 = new Label();
            repaymentOutstandingLtv = new Label();
            repaymentMaturityDate = new Label();
            repaymentIssueDate = new Label();
            repaymentLoanTerm = new Label();
            repaymentOverdueInterest = new Label();
            repaymentPrincipalDept = new Label();
            repaymentInterest = new Label();
            repaymentOverduePrincipalDept = new Label();
            repaymentOriginalLoanAmount = new Label();
            button1 = new Button();
            panel2 = new Panel();
            repaymentNextPayment = new Label();
            repaymentMonthlyPayment = new Label();
            label23 = new Label();
            label4 = new Label();
            label21 = new Label();
            repaymentLoantermm = new Label();
            repaymentApplicantName = new Label();
            repaymentLoanAmount = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            repaymentBalance = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label11 = new Label();
            label8 = new Label();
            label7 = new Label();
            label10 = new Label();
            label6 = new Label();
            label5 = new Label();
            repaymentStat = new Label();
            repaymentApplicationId = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            pendingPanel.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { LoanID, ApplicantName, LoanType, RepaymentStatus });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.GridColor = Color.Black;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(391, 796);
            dataGridView1.TabIndex = 27;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // LoanID
            // 
            LoanID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            LoanID.HeaderText = "Loan ID";
            LoanID.Name = "LoanID";
            LoanID.ReadOnly = true;
            LoanID.Width = 89;
            // 
            // ApplicantName
            // 
            ApplicantName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ApplicantName.HeaderText = "Applicant Name";
            ApplicantName.Name = "ApplicantName";
            ApplicantName.ReadOnly = true;
            // 
            // LoanType
            // 
            LoanType.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            LoanType.HeaderText = "Loan Type";
            LoanType.Name = "LoanType";
            LoanType.ReadOnly = true;
            LoanType.Width = 108;
            // 
            // RepaymentStatus
            // 
            RepaymentStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            RepaymentStatus.HeaderText = " Status";
            RepaymentStatus.Name = "RepaymentStatus";
            RepaymentStatus.ReadOnly = true;
            RepaymentStatus.Width = 91;
            // 
            // pendingPanel
            // 
            pendingPanel.BackColor = Color.White;
            pendingPanel.BorderStyle = BorderStyle.Fixed3D;
            pendingPanel.Controls.Add(repaymentbtn);
            pendingPanel.Controls.Add(repaymentInterestrate);
            pendingPanel.Controls.Add(label12);
            pendingPanel.Controls.Add(repaymentOutstandingLtv);
            pendingPanel.Controls.Add(repaymentMaturityDate);
            pendingPanel.Controls.Add(repaymentIssueDate);
            pendingPanel.Controls.Add(repaymentLoanTerm);
            pendingPanel.Controls.Add(repaymentOverdueInterest);
            pendingPanel.Controls.Add(repaymentPrincipalDept);
            pendingPanel.Controls.Add(repaymentInterest);
            pendingPanel.Controls.Add(repaymentOverduePrincipalDept);
            pendingPanel.Controls.Add(repaymentOriginalLoanAmount);
            pendingPanel.Controls.Add(button1);
            pendingPanel.Controls.Add(panel2);
            pendingPanel.Controls.Add(label18);
            pendingPanel.Controls.Add(label17);
            pendingPanel.Controls.Add(label16);
            pendingPanel.Controls.Add(label15);
            pendingPanel.Controls.Add(label11);
            pendingPanel.Controls.Add(label8);
            pendingPanel.Controls.Add(label7);
            pendingPanel.Controls.Add(label10);
            pendingPanel.Controls.Add(label6);
            pendingPanel.Controls.Add(label5);
            pendingPanel.Controls.Add(repaymentStat);
            pendingPanel.Controls.Add(repaymentApplicationId);
            pendingPanel.Location = new Point(409, -14);
            pendingPanel.Name = "pendingPanel";
            pendingPanel.Size = new Size(1009, 845);
            pendingPanel.TabIndex = 28;
            // 
            // repaymentbtn
            // 
            repaymentbtn.BackColor = Color.SeaGreen;
            repaymentbtn.FlatStyle = FlatStyle.Flat;
            repaymentbtn.ForeColor = Color.Transparent;
            repaymentbtn.Location = new Point(821, 24);
            repaymentbtn.Name = "repaymentbtn";
            repaymentbtn.Size = new Size(163, 38);
            repaymentbtn.TabIndex = 61;
            repaymentbtn.Text = "Repay";
            repaymentbtn.UseVisualStyleBackColor = false;
            repaymentbtn.Click += repaymentbtn_Click;
            // 
            // repaymentInterestrate
            // 
            repaymentInterestrate.AutoSize = true;
            repaymentInterestrate.Font = new Font("Tahoma", 12F);
            repaymentInterestrate.ForeColor = SystemColors.ControlDarkDark;
            repaymentInterestrate.Location = new Point(279, 465);
            repaymentInterestrate.Name = "repaymentInterestrate";
            repaymentInterestrate.Size = new Size(63, 19);
            repaymentInterestrate.TabIndex = 60;
            repaymentInterestrate.Text = "Interest";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Tahoma", 12F);
            label12.ForeColor = SystemColors.ControlDarkDark;
            label12.Location = new Point(18, 465);
            label12.Name = "label12";
            label12.Size = new Size(95, 19);
            label12.TabIndex = 59;
            label12.Text = "Interest rate";
            // 
            // repaymentOutstandingLtv
            // 
            repaymentOutstandingLtv.AutoSize = true;
            repaymentOutstandingLtv.Font = new Font("Tahoma", 12F);
            repaymentOutstandingLtv.ForeColor = SystemColors.ControlDarkDark;
            repaymentOutstandingLtv.Location = new Point(776, 548);
            repaymentOutstandingLtv.Name = "repaymentOutstandingLtv";
            repaymentOutstandingLtv.Size = new Size(144, 19);
            repaymentOutstandingLtv.TabIndex = 58;
            repaymentOutstandingLtv.Text = "Outstanding LTV%";
            // 
            // repaymentMaturityDate
            // 
            repaymentMaturityDate.AutoSize = true;
            repaymentMaturityDate.Font = new Font("Tahoma", 12F);
            repaymentMaturityDate.ForeColor = SystemColors.ControlDarkDark;
            repaymentMaturityDate.Location = new Point(776, 465);
            repaymentMaturityDate.Name = "repaymentMaturityDate";
            repaymentMaturityDate.Size = new Size(103, 19);
            repaymentMaturityDate.TabIndex = 57;
            repaymentMaturityDate.Text = "Maturity Date";
            // 
            // repaymentIssueDate
            // 
            repaymentIssueDate.AutoSize = true;
            repaymentIssueDate.Font = new Font("Tahoma", 12F);
            repaymentIssueDate.ForeColor = SystemColors.ControlDarkDark;
            repaymentIssueDate.Location = new Point(779, 424);
            repaymentIssueDate.Name = "repaymentIssueDate";
            repaymentIssueDate.Size = new Size(83, 19);
            repaymentIssueDate.TabIndex = 56;
            repaymentIssueDate.Text = "Issue Date";
            // 
            // repaymentLoanTerm
            // 
            repaymentLoanTerm.AutoSize = true;
            repaymentLoanTerm.Font = new Font("Tahoma", 12F);
            repaymentLoanTerm.ForeColor = SystemColors.ControlDarkDark;
            repaymentLoanTerm.Location = new Point(779, 379);
            repaymentLoanTerm.Name = "repaymentLoanTerm";
            repaymentLoanTerm.Size = new Size(86, 19);
            repaymentLoanTerm.TabIndex = 55;
            repaymentLoanTerm.Text = "Loan Term";
            // 
            // repaymentOverdueInterest
            // 
            repaymentOverdueInterest.AutoSize = true;
            repaymentOverdueInterest.Font = new Font("Tahoma", 12F);
            repaymentOverdueInterest.ForeColor = SystemColors.ControlDarkDark;
            repaymentOverdueInterest.Location = new Point(279, 590);
            repaymentOverdueInterest.Name = "repaymentOverdueInterest";
            repaymentOverdueInterest.Size = new Size(128, 19);
            repaymentOverdueInterest.TabIndex = 54;
            repaymentOverdueInterest.Text = "Overdue Interest";
            // 
            // repaymentPrincipalDept
            // 
            repaymentPrincipalDept.AutoSize = true;
            repaymentPrincipalDept.Font = new Font("Tahoma", 12F);
            repaymentPrincipalDept.ForeColor = SystemColors.ControlDarkDark;
            repaymentPrincipalDept.Location = new Point(279, 507);
            repaymentPrincipalDept.Name = "repaymentPrincipalDept";
            repaymentPrincipalDept.Size = new Size(107, 19);
            repaymentPrincipalDept.TabIndex = 52;
            repaymentPrincipalDept.Text = "Principal Dept";
            // 
            // repaymentInterest
            // 
            repaymentInterest.AutoSize = true;
            repaymentInterest.Font = new Font("Tahoma", 12F);
            repaymentInterest.ForeColor = SystemColors.ControlDarkDark;
            repaymentInterest.Location = new Point(282, 424);
            repaymentInterest.Name = "repaymentInterest";
            repaymentInterest.Size = new Size(63, 19);
            repaymentInterest.TabIndex = 51;
            repaymentInterest.Text = "Interest";
            // 
            // repaymentOverduePrincipalDept
            // 
            repaymentOverduePrincipalDept.AutoSize = true;
            repaymentOverduePrincipalDept.Font = new Font("Tahoma", 12F);
            repaymentOverduePrincipalDept.ForeColor = SystemColors.ControlDarkDark;
            repaymentOverduePrincipalDept.Location = new Point(276, 548);
            repaymentOverduePrincipalDept.Name = "repaymentOverduePrincipalDept";
            repaymentOverduePrincipalDept.Size = new Size(172, 19);
            repaymentOverduePrincipalDept.TabIndex = 50;
            repaymentOverduePrincipalDept.Text = "Overdue Principal Dept";
            // 
            // repaymentOriginalLoanAmount
            // 
            repaymentOriginalLoanAmount.AutoSize = true;
            repaymentOriginalLoanAmount.Font = new Font("Tahoma", 12F);
            repaymentOriginalLoanAmount.ForeColor = SystemColors.ControlDarkDark;
            repaymentOriginalLoanAmount.Location = new Point(282, 379);
            repaymentOriginalLoanAmount.Name = "repaymentOriginalLoanAmount";
            repaymentOriginalLoanAmount.Size = new Size(166, 19);
            repaymentOriginalLoanAmount.TabIndex = 49;
            repaymentOriginalLoanAmount.Text = "Original Loan Amount";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(773, 28);
            button1.Name = "button1";
            button1.Size = new Size(32, 31);
            button1.TabIndex = 28;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Controls.Add(repaymentNextPayment);
            panel2.Controls.Add(repaymentMonthlyPayment);
            panel2.Controls.Add(label23);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label21);
            panel2.Controls.Add(repaymentLoantermm);
            panel2.Controls.Add(repaymentApplicantName);
            panel2.Controls.Add(repaymentLoanAmount);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(repaymentBalance);
            panel2.Location = new Point(8, 86);
            panel2.Name = "panel2";
            panel2.Size = new Size(976, 221);
            panel2.TabIndex = 38;
            // 
            // repaymentNextPayment
            // 
            repaymentNextPayment.AutoSize = true;
            repaymentNextPayment.Font = new Font("Tahoma", 12F);
            repaymentNextPayment.Location = new Point(704, 154);
            repaymentNextPayment.Name = "repaymentNextPayment";
            repaymentNextPayment.Size = new Size(54, 19);
            repaymentNextPayment.TabIndex = 25;
            repaymentNextPayment.Text = "20000";
            // 
            // repaymentMonthlyPayment
            // 
            repaymentMonthlyPayment.AutoSize = true;
            repaymentMonthlyPayment.Font = new Font("Tahoma", 12F);
            repaymentMonthlyPayment.Location = new Point(371, 154);
            repaymentMonthlyPayment.Name = "repaymentMonthlyPayment";
            repaymentMonthlyPayment.Size = new Size(54, 19);
            repaymentMonthlyPayment.TabIndex = 24;
            repaymentMonthlyPayment.Text = "20000";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Tahoma", 15.75F, FontStyle.Bold);
            label23.Location = new Point(704, 123);
            label23.Name = "label23";
            label23.Size = new Size(161, 25);
            label23.TabIndex = 23;
            label23.Text = "Next Payment";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 15.75F, FontStyle.Bold);
            label4.Location = new Point(371, 123);
            label4.Name = "label4";
            label4.Size = new Size(196, 25);
            label4.TabIndex = 22;
            label4.Text = "Monthly Payment";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Tahoma", 15.75F, FontStyle.Bold);
            label21.Location = new Point(13, 123);
            label21.Name = "label21";
            label21.Size = new Size(123, 25);
            label21.TabIndex = 21;
            label21.Text = "Loan Term";
            // 
            // repaymentLoantermm
            // 
            repaymentLoantermm.AutoSize = true;
            repaymentLoantermm.Font = new Font("Tahoma", 12F);
            repaymentLoantermm.Location = new Point(13, 154);
            repaymentLoantermm.Name = "repaymentLoantermm";
            repaymentLoantermm.Size = new Size(54, 19);
            repaymentLoantermm.TabIndex = 19;
            repaymentLoantermm.Text = "20000";
            // 
            // repaymentApplicantName
            // 
            repaymentApplicantName.AutoSize = true;
            repaymentApplicantName.Font = new Font("Tahoma", 18F, FontStyle.Bold);
            repaymentApplicantName.Location = new Point(13, 48);
            repaymentApplicantName.Name = "repaymentApplicantName";
            repaymentApplicantName.Size = new Size(202, 29);
            repaymentApplicantName.TabIndex = 2;
            repaymentApplicantName.Text = "Applicant Name";
            // 
            // repaymentLoanAmount
            // 
            repaymentLoanAmount.AutoSize = true;
            repaymentLoanAmount.BackColor = Color.Transparent;
            repaymentLoanAmount.Font = new Font("Tahoma", 18F, FontStyle.Bold);
            repaymentLoanAmount.Location = new Point(371, 48);
            repaymentLoanAmount.Margin = new Padding(0);
            repaymentLoanAmount.Name = "repaymentLoanAmount";
            repaymentLoanAmount.Size = new Size(107, 29);
            repaymentLoanAmount.TabIndex = 3;
            repaymentLoanAmount.Text = "Amount";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(13, 20);
            label1.Name = "label1";
            label1.Size = new Size(74, 19);
            label1.TabIndex = 4;
            label1.Text = "Borrower";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(371, 20);
            label2.Name = "label2";
            label2.Size = new Size(166, 19);
            label2.TabIndex = 6;
            label2.Text = "Original Loan Amount";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(704, 20);
            label3.Name = "label3";
            label3.Size = new Size(153, 19);
            label3.TabIndex = 8;
            label3.Text = "Outstanding Balance";
            // 
            // repaymentBalance
            // 
            repaymentBalance.AutoSize = true;
            repaymentBalance.Font = new Font("Tahoma", 18F, FontStyle.Bold);
            repaymentBalance.Location = new Point(704, 48);
            repaymentBalance.Name = "repaymentBalance";
            repaymentBalance.Size = new Size(106, 29);
            repaymentBalance.TabIndex = 9;
            repaymentBalance.Text = "Balance";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Tahoma", 12F);
            label18.ForeColor = SystemColors.ControlDarkDark;
            label18.Location = new Point(572, 548);
            label18.Name = "label18";
            label18.Size = new Size(144, 19);
            label18.TabIndex = 48;
            label18.Text = "Outstanding LTV%";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Tahoma", 12F);
            label17.ForeColor = SystemColors.ControlDarkDark;
            label17.Location = new Point(572, 465);
            label17.Name = "label17";
            label17.Size = new Size(103, 19);
            label17.TabIndex = 47;
            label17.Text = "Maturity Date";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Tahoma", 12F);
            label16.ForeColor = SystemColors.ControlDarkDark;
            label16.Location = new Point(575, 424);
            label16.Name = "label16";
            label16.Size = new Size(83, 19);
            label16.TabIndex = 46;
            label16.Text = "Issue Date";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Tahoma", 12F);
            label15.ForeColor = SystemColors.ControlDarkDark;
            label15.Location = new Point(574, 379);
            label15.Name = "label15";
            label15.Size = new Size(86, 19);
            label15.TabIndex = 45;
            label15.Text = "Loan Term";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Tahoma", 12F);
            label11.ForeColor = SystemColors.ControlDarkDark;
            label11.Location = new Point(18, 590);
            label11.Name = "label11";
            label11.Size = new Size(128, 19);
            label11.TabIndex = 41;
            label11.Text = "Overdue Interest";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 12F);
            label8.ForeColor = SystemColors.ControlDarkDark;
            label8.Location = new Point(18, 507);
            label8.Name = "label8";
            label8.Size = new Size(107, 19);
            label8.TabIndex = 39;
            label8.Text = "Principal Dept";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 12F);
            label7.ForeColor = SystemColors.ControlDarkDark;
            label7.Location = new Point(21, 424);
            label7.Name = "label7";
            label7.Size = new Size(63, 19);
            label7.TabIndex = 38;
            label7.Text = "Interest";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 12F);
            label10.ForeColor = SystemColors.ControlDarkDark;
            label10.Location = new Point(18, 548);
            label10.Name = "label10";
            label10.Size = new Size(172, 19);
            label10.TabIndex = 16;
            label10.Text = "Overdue Principal Dept";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 12F);
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(21, 379);
            label6.Name = "label6";
            label6.Size = new Size(166, 19);
            label6.TabIndex = 12;
            label6.Text = "Original Loan Amount";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(18, 339);
            label5.Name = "label5";
            label5.Size = new Size(142, 25);
            label5.TabIndex = 11;
            label5.Text = "Loan Details";
            // 
            // repaymentStat
            // 
            repaymentStat.AutoSize = true;
            repaymentStat.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            repaymentStat.Location = new Point(275, 37);
            repaymentStat.Name = "repaymentStat";
            repaymentStat.Padding = new Padding(3);
            repaymentStat.Size = new Size(67, 25);
            repaymentStat.TabIndex = 1;
            repaymentStat.Text = "Status";
            // 
            // repaymentApplicationId
            // 
            repaymentApplicationId.AutoSize = true;
            repaymentApplicationId.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            repaymentApplicationId.Location = new Point(18, 33);
            repaymentApplicationId.Name = "repaymentApplicationId";
            repaymentApplicationId.Size = new Size(184, 29);
            repaymentApplicationId.TabIndex = 0;
            repaymentApplicationId.Text = "Application ID";
            // 
            // formRepayment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1407, 820);
            Controls.Add(pendingPanel);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formRepayment";
            Text = "formRepayment";
            Load += formRepayment_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            pendingPanel.ResumeLayout(false);
            pendingPanel.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn LoanID;
        private DataGridViewTextBoxColumn ApplicantName;
        private DataGridViewTextBoxColumn LoanType;
        private DataGridViewTextBoxColumn RepaymentStatus;
        private Panel pendingPanel;
        private Button button1;
        private Panel panel2;
        private Label repaymentNextPayment;
        private Label repaymentMonthlyPayment;
        private Label label23;
        private Label label4;
        private Label label21;
        private Label repaymentLoantermm;
        private Label repaymentApplicantName;
        private Label repaymentLoanAmount;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label repaymentBalance;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label11;
        private Label label8;
        private Label label7;
        private Label label10;
        private Label label6;
        private Label label5;
        private Label repaymentStat;
        private Label repaymentApplicationId;
        private Label repaymentOutstandingLtv;
        private Label repaymentMaturityDate;
        private Label repaymentIssueDate;
        private Label repaymentLoanTerm;
        private Label repaymentOverdueInterest;
        private Label repaymentPrincipalDept;
        private Label repaymentInterest;
        private Label repaymentOverduePrincipalDept;
        private Label repaymentOriginalLoanAmount;
        private Label repaymentInterestrate;
        private Label label12;
        private Button repaymentbtn;
    }
}