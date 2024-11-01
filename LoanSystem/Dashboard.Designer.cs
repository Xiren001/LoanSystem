﻿namespace LoanSystem
{
    partial class Dashboard
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            menu = new PictureBox();
            sidebar = new FlowLayoutPanel();
            pnDashboard = new Panel();
            btnDashboard = new Button();
            menuContainer = new FlowLayoutPanel();
            panel3 = new Panel();
            loanApp = new Button();
            panel8 = new Panel();
            btnNewApp = new Button();
            panel9 = new Panel();
            btnPending = new Button();
            panel10 = new Panel();
            btnAppRej = new Button();
            pnLoanM = new Panel();
            btnLoanM = new Button();
            pnCustomer = new Panel();
            btnCustomer = new Button();
            pnRepayment = new Panel();
            btnRepayment = new Button();
            pnReport = new Panel();
            btnReport = new Button();
            menuTransition = new System.Windows.Forms.Timer(components);
            sidebarTransition = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menu).BeginInit();
            sidebar.SuspendLayout();
            pnDashboard.SuspendLayout();
            menuContainer.SuspendLayout();
            panel3.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            pnLoanM.SuspendLayout();
            pnCustomer.SuspendLayout();
            pnRepayment.SuspendLayout();
            pnReport.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(menu);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1165, 52);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(1124, 16);
            label2.Name = "label2";
            label2.Size = new Size(14, 16);
            label2.TabIndex = 2;
            label2.Text = "x";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 16);
            label1.Name = "label1";
            label1.Size = new Size(120, 19);
            label1.TabIndex = 1;
            label1.Text = "Loan Wise Bank";
            // 
            // menu
            // 
            menu.Image = (Image)resources.GetObject("menu.Image");
            menu.Location = new Point(27, 16);
            menu.Name = "menu";
            menu.Size = new Size(29, 23);
            menu.SizeMode = PictureBoxSizeMode.CenterImage;
            menu.TabIndex = 1;
            menu.TabStop = false;
            menu.Click += menu_Click;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.SeaGreen;
            sidebar.Controls.Add(pnDashboard);
            sidebar.Controls.Add(menuContainer);
            sidebar.Controls.Add(pnLoanM);
            sidebar.Controls.Add(pnCustomer);
            sidebar.Controls.Add(pnRepayment);
            sidebar.Controls.Add(pnReport);
            sidebar.Location = new Point(0, 50);
            sidebar.Name = "sidebar";
            sidebar.Padding = new Padding(0, 15, 0, 0);
            sidebar.Size = new Size(237, 612);
            sidebar.TabIndex = 1;
            // 
            // pnDashboard
            // 
            pnDashboard.Controls.Add(btnDashboard);
            pnDashboard.Location = new Point(3, 18);
            pnDashboard.Name = "pnDashboard";
            pnDashboard.Size = new Size(230, 48);
            pnDashboard.TabIndex = 3;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.SeaGreen;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.ForeColor = Color.Transparent;
            btnDashboard.Image = (Image)resources.GetObject("btnDashboard.Image");
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(-9, -10);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(25, 0, 0, 0);
            btnDashboard.Size = new Size(248, 68);
            btnDashboard.TabIndex = 2;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // menuContainer
            // 
            menuContainer.Controls.Add(panel3);
            menuContainer.Controls.Add(panel8);
            menuContainer.Controls.Add(panel9);
            menuContainer.Controls.Add(panel10);
            menuContainer.Location = new Point(3, 72);
            menuContainer.Name = "menuContainer";
            menuContainer.Size = new Size(230, 225);
            menuContainer.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.Controls.Add(loanApp);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(230, 48);
            panel3.TabIndex = 4;
            // 
            // loanApp
            // 
            loanApp.BackColor = Color.SeaGreen;
            loanApp.FlatStyle = FlatStyle.Flat;
            loanApp.ForeColor = Color.Transparent;
            loanApp.Image = (Image)resources.GetObject("loanApp.Image");
            loanApp.ImageAlign = ContentAlignment.MiddleLeft;
            loanApp.Location = new Point(-12, -10);
            loanApp.Name = "loanApp";
            loanApp.Padding = new Padding(25, 0, 0, 0);
            loanApp.Size = new Size(248, 68);
            loanApp.TabIndex = 2;
            loanApp.Text = "     Loan Applications";
            loanApp.UseVisualStyleBackColor = false;
            loanApp.Click += loanApp_Click;
            // 
            // panel8
            // 
            panel8.Controls.Add(btnNewApp);
            panel8.Location = new Point(3, 57);
            panel8.Name = "panel8";
            panel8.Size = new Size(230, 48);
            panel8.TabIndex = 5;
            // 
            // btnNewApp
            // 
            btnNewApp.BackColor = Color.SeaGreen;
            btnNewApp.FlatStyle = FlatStyle.Flat;
            btnNewApp.ForeColor = Color.Transparent;
            btnNewApp.Image = (Image)resources.GetObject("btnNewApp.Image");
            btnNewApp.ImageAlign = ContentAlignment.MiddleLeft;
            btnNewApp.Location = new Point(-9, -10);
            btnNewApp.Name = "btnNewApp";
            btnNewApp.Padding = new Padding(35, 0, 0, 0);
            btnNewApp.Size = new Size(248, 68);
            btnNewApp.TabIndex = 2;
            btnNewApp.Text = "    New Application";
            btnNewApp.UseVisualStyleBackColor = false;
            btnNewApp.Click += btnNewApp_Click;
            // 
            // panel9
            // 
            panel9.Controls.Add(btnPending);
            panel9.Location = new Point(3, 111);
            panel9.Name = "panel9";
            panel9.Size = new Size(230, 48);
            panel9.TabIndex = 5;
            // 
            // btnPending
            // 
            btnPending.BackColor = Color.SeaGreen;
            btnPending.FlatStyle = FlatStyle.Flat;
            btnPending.ForeColor = Color.Transparent;
            btnPending.Image = (Image)resources.GetObject("btnPending.Image");
            btnPending.ImageAlign = ContentAlignment.MiddleLeft;
            btnPending.Location = new Point(-9, -10);
            btnPending.Name = "btnPending";
            btnPending.Padding = new Padding(35, 0, 0, 0);
            btnPending.Size = new Size(248, 68);
            btnPending.TabIndex = 2;
            btnPending.Text = "      Pending Applications\r\n";
            btnPending.UseVisualStyleBackColor = false;
            btnPending.Click += btnPending_Click;
            // 
            // panel10
            // 
            panel10.Controls.Add(btnAppRej);
            panel10.Location = new Point(3, 165);
            panel10.Name = "panel10";
            panel10.Size = new Size(230, 48);
            panel10.TabIndex = 5;
            // 
            // btnAppRej
            // 
            btnAppRej.BackColor = Color.SeaGreen;
            btnAppRej.FlatStyle = FlatStyle.Flat;
            btnAppRej.ForeColor = Color.Transparent;
            btnAppRej.Image = (Image)resources.GetObject("btnAppRej.Image");
            btnAppRej.ImageAlign = ContentAlignment.MiddleLeft;
            btnAppRej.Location = new Point(-9, -10);
            btnAppRej.Name = "btnAppRej";
            btnAppRej.Padding = new Padding(35, 0, 0, 0);
            btnAppRej.Size = new Size(248, 68);
            btnAppRej.TabIndex = 2;
            btnAppRej.Text = "      Approved/Rejected Applications";
            btnAppRej.UseVisualStyleBackColor = false;
            btnAppRej.Click += btnAppRej_Click;
            // 
            // pnLoanM
            // 
            pnLoanM.Controls.Add(btnLoanM);
            pnLoanM.Location = new Point(3, 303);
            pnLoanM.Name = "pnLoanM";
            pnLoanM.Size = new Size(230, 48);
            pnLoanM.TabIndex = 4;
            // 
            // btnLoanM
            // 
            btnLoanM.BackColor = Color.SeaGreen;
            btnLoanM.FlatStyle = FlatStyle.Flat;
            btnLoanM.ForeColor = Color.Transparent;
            btnLoanM.Image = (Image)resources.GetObject("btnLoanM.Image");
            btnLoanM.ImageAlign = ContentAlignment.MiddleLeft;
            btnLoanM.Location = new Point(-9, -10);
            btnLoanM.Name = "btnLoanM";
            btnLoanM.Padding = new Padding(25, 0, 0, 0);
            btnLoanM.Size = new Size(248, 68);
            btnLoanM.TabIndex = 2;
            btnLoanM.Text = "      Loan Management";
            btnLoanM.UseVisualStyleBackColor = false;
            btnLoanM.Click += btnLoanM_Click;
            // 
            // pnCustomer
            // 
            pnCustomer.Controls.Add(btnCustomer);
            pnCustomer.Location = new Point(3, 357);
            pnCustomer.Name = "pnCustomer";
            pnCustomer.Size = new Size(230, 48);
            pnCustomer.TabIndex = 4;
            // 
            // btnCustomer
            // 
            btnCustomer.BackColor = Color.SeaGreen;
            btnCustomer.FlatStyle = FlatStyle.Flat;
            btnCustomer.ForeColor = Color.Transparent;
            btnCustomer.Image = (Image)resources.GetObject("btnCustomer.Image");
            btnCustomer.ImageAlign = ContentAlignment.MiddleLeft;
            btnCustomer.Location = new Point(-9, -10);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Padding = new Padding(25, 0, 0, 0);
            btnCustomer.Size = new Size(248, 68);
            btnCustomer.TabIndex = 2;
            btnCustomer.Text = "Customers";
            btnCustomer.UseVisualStyleBackColor = false;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // pnRepayment
            // 
            pnRepayment.Controls.Add(btnRepayment);
            pnRepayment.Location = new Point(3, 411);
            pnRepayment.Name = "pnRepayment";
            pnRepayment.Size = new Size(230, 48);
            pnRepayment.TabIndex = 4;
            // 
            // btnRepayment
            // 
            btnRepayment.BackColor = Color.SeaGreen;
            btnRepayment.FlatStyle = FlatStyle.Flat;
            btnRepayment.ForeColor = Color.Transparent;
            btnRepayment.Image = (Image)resources.GetObject("btnRepayment.Image");
            btnRepayment.ImageAlign = ContentAlignment.MiddleLeft;
            btnRepayment.Location = new Point(-9, -10);
            btnRepayment.Name = "btnRepayment";
            btnRepayment.Padding = new Padding(25, 0, 0, 0);
            btnRepayment.Size = new Size(248, 68);
            btnRepayment.TabIndex = 2;
            btnRepayment.Text = "Repayment";
            btnRepayment.UseVisualStyleBackColor = false;
            btnRepayment.Click += btnRepayment_Click;
            // 
            // pnReport
            // 
            pnReport.Controls.Add(btnReport);
            pnReport.Location = new Point(3, 465);
            pnReport.Name = "pnReport";
            pnReport.Size = new Size(230, 48);
            pnReport.TabIndex = 4;
            // 
            // btnReport
            // 
            btnReport.BackColor = Color.SeaGreen;
            btnReport.FlatStyle = FlatStyle.Flat;
            btnReport.ForeColor = Color.Transparent;
            btnReport.Image = (Image)resources.GetObject("btnReport.Image");
            btnReport.ImageAlign = ContentAlignment.MiddleLeft;
            btnReport.Location = new Point(-21, -11);
            btnReport.Name = "btnReport";
            btnReport.Padding = new Padding(25, 0, 0, 0);
            btnReport.Size = new Size(248, 68);
            btnReport.TabIndex = 2;
            btnReport.Text = "         Reports and Analytics";
            btnReport.UseVisualStyleBackColor = false;
            btnReport.Click += btnReport_Click;
            // 
            // menuTransition
            // 
            menuTransition.Interval = 10;
            menuTransition.Tick += menuTransition_Tick;
            // 
            // sidebarTransition
            // 
            sidebarTransition.Interval = 10;
            sidebarTransition.Tick += sidebarTransition_Tick;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1164, 661);
            Controls.Add(sidebar);
            Controls.Add(panel1);
            Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            Margin = new Padding(4);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Loan Management System";
            Load += Dashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)menu).EndInit();
            sidebar.ResumeLayout(false);
            pnDashboard.ResumeLayout(false);
            menuContainer.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel10.ResumeLayout(false);
            pnLoanM.ResumeLayout(false);
            pnCustomer.ResumeLayout(false);
            pnRepayment.ResumeLayout(false);
            pnReport.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox menu;
        private Label label1;
        private FlowLayoutPanel sidebar;
        private Button btnDashboard;
        private Panel pnDashboard;
        private Panel panel3;
        private Button loanApp;
        private Panel pnLoanM;
        private Button btnLoanM;
        private Panel pnCustomer;
        private Button btnCustomer;
        private Panel pnRepayment;
        private Button btnRepayment;
        private Panel pnReport;
        private Button btnReport;
        private Panel panel8;
        private Button btnNewApp;
        private Panel panel9;
        private Button btnPending;
        private Panel panel10;
        private Button btnAppRej;
        private FlowLayoutPanel menuContainer;
        private System.Windows.Forms.Timer menuTransition;
        private System.Windows.Forms.Timer sidebarTransition;
        private Label label2;
    }
}