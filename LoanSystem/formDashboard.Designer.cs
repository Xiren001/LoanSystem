namespace LoanSystem
{
    partial class formDashboard
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
            panel1 = new Panel();
            label6 = new Label();
            label10 = new Label();
            clients = new Label();
            approvedLoan = new Label();
            label5 = new Label();
            newApplication = new Label();
            panel2 = new Panel();
            label9 = new Label();
            activeBorrower = new Label();
            panel3 = new Panel();
            label3 = new Label();
            completedLoans = new Label();
            label7 = new Label();
            rejected = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Khaki;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(clients);
            panel1.Controls.Add(approvedLoan);
            panel1.Location = new Point(56, 29);
            panel1.Name = "panel1";
            panel1.Size = new Size(607, 163);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 20.25F, FontStyle.Bold);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(37, 91);
            label6.Name = "label6";
            label6.Size = new Size(133, 33);
            label6.TabIndex = 5;
            label6.Text = "Appoved";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 20.25F, FontStyle.Bold);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(345, 91);
            label10.Name = "label10";
            label10.Size = new Size(107, 33);
            label10.TabIndex = 6;
            label10.Text = "Clients";
            // 
            // clients
            // 
            clients.AutoSize = true;
            clients.Font = new Font("Tahoma", 27.75F, FontStyle.Bold);
            clients.ForeColor = Color.Black;
            clients.Location = new Point(345, 32);
            clients.Name = "clients";
            clients.Size = new Size(92, 45);
            clients.TabIndex = 2;
            clients.Text = "568";
            // 
            // approvedLoan
            // 
            approvedLoan.AutoSize = true;
            approvedLoan.Font = new Font("Tahoma", 27.75F, FontStyle.Bold);
            approvedLoan.ForeColor = Color.Black;
            approvedLoan.Location = new Point(37, 32);
            approvedLoan.Name = "approvedLoan";
            approvedLoan.Size = new Size(79, 45);
            approvedLoan.TabIndex = 1;
            approvedLoan.Text = "23 ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 20.25F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(54, 100);
            label5.Name = "label5";
            label5.Size = new Size(235, 33);
            label5.TabIndex = 4;
            label5.Text = "New Application";
            // 
            // newApplication
            // 
            newApplication.AutoSize = true;
            newApplication.Font = new Font("Tahoma", 27.75F, FontStyle.Bold);
            newApplication.ForeColor = Color.White;
            newApplication.Location = new Point(54, 32);
            newApplication.Name = "newApplication";
            newApplication.Size = new Size(68, 45);
            newApplication.TabIndex = 0;
            newApplication.Text = "69";
            // 
            // panel2
            // 
            panel2.BackColor = Color.SeaGreen;
            panel2.Controls.Add(label9);
            panel2.Controls.Add(activeBorrower);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(newApplication);
            panel2.Location = new Point(698, 29);
            panel2.Name = "panel2";
            panel2.Size = new Size(672, 163);
            panel2.TabIndex = 8;
            panel2.Paint += panel2_Paint;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 20.25F, FontStyle.Bold);
            label9.ForeColor = Color.White;
            label9.Location = new Point(358, 100);
            label9.Name = "label9";
            label9.Size = new Size(235, 33);
            label9.TabIndex = 7;
            label9.Text = "Active Borrower";
            // 
            // activeBorrower
            // 
            activeBorrower.AutoSize = true;
            activeBorrower.Font = new Font("Tahoma", 27.75F, FontStyle.Bold);
            activeBorrower.ForeColor = Color.White;
            activeBorrower.Location = new Point(358, 32);
            activeBorrower.Name = "activeBorrower";
            activeBorrower.Size = new Size(92, 45);
            activeBorrower.TabIndex = 3;
            activeBorrower.Text = "121";
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightCoral;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(completedLoans);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(rejected);
            panel3.Location = new Point(345, 215);
            panel3.Name = "panel3";
            panel3.Size = new Size(642, 167);
            panel3.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 20.25F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(334, 98);
            label3.Name = "label3";
            label3.Size = new Size(248, 33);
            label3.TabIndex = 7;
            label3.Text = "Completed Loans";
            // 
            // completedLoans
            // 
            completedLoans.AutoSize = true;
            completedLoans.Font = new Font("Tahoma", 27.75F, FontStyle.Bold);
            completedLoans.ForeColor = Color.White;
            completedLoans.Location = new Point(334, 30);
            completedLoans.Name = "completedLoans";
            completedLoans.Size = new Size(92, 45);
            completedLoans.TabIndex = 3;
            completedLoans.Text = "121";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 20.25F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(37, 98);
            label7.Name = "label7";
            label7.Size = new Size(135, 33);
            label7.TabIndex = 4;
            label7.Text = "Rejected";
            // 
            // rejected
            // 
            rejected.AutoSize = true;
            rejected.Font = new Font("Tahoma", 27.75F, FontStyle.Bold);
            rejected.ForeColor = Color.White;
            rejected.Location = new Point(37, 30);
            rejected.Name = "rejected";
            rejected.Size = new Size(68, 45);
            rejected.TabIndex = 0;
            rejected.Text = "69";
            // 
            // formDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1407, 820);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formDashboard";
            Text = "formDashboard";
            Load += formDashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label newApplication;
        private Label label6;
        private Label label5;
        private Label approvedLoan;
        private Label label10;
        private Label clients;
        private Panel panel2;
        private Label label9;
        private Label activeBorrower;
        private Panel panel3;
        private Label label3;
        private Label completedLoans;
        private Label label7;
        private Label rejected;
    }
}