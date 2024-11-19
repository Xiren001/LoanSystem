namespace LoanSystem
{
    partial class LogoutConfirmationForm
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
            label1 = new Label();
            label2 = new Label();
            btnLogoutAndClose = new Button();
            btnLogout = new Button();
            btnCancel = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(136, 68);
            label1.Name = "label1";
            label1.Size = new Size(196, 16);
            label1.TabIndex = 0;
            label1.Text = "Are you sure you want to logout?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(189, 26);
            label2.Name = "label2";
            label2.Size = new Size(85, 25);
            label2.TabIndex = 1;
            label2.Text = "Logout";
            // 
            // btnLogoutAndClose
            // 
            btnLogoutAndClose.BackColor = Color.IndianRed;
            btnLogoutAndClose.FlatStyle = FlatStyle.Flat;
            btnLogoutAndClose.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogoutAndClose.ForeColor = Color.White;
            btnLogoutAndClose.Location = new Point(19, 123);
            btnLogoutAndClose.Name = "btnLogoutAndClose";
            btnLogoutAndClose.Size = new Size(130, 25);
            btnLogoutAndClose.TabIndex = 2;
            btnLogoutAndClose.Text = "Logout and Close";
            btnLogoutAndClose.UseVisualStyleBackColor = false;
            btnLogoutAndClose.Click += btnLogoutAndClose_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Khaki;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.Black;
            btnLogout.Location = new Point(180, 123);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(108, 25);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ActiveBorder;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(321, 123);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(108, 25);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnLogoutAndClose);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(443, 180);
            panel1.TabIndex = 5;
            // 
            // LogoutConfirmationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(449, 186);
            Controls.Add(panel1);
            Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LogoutConfirmationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LogoutConfirmationForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnLogoutAndClose;
        private Button btnLogout;
        private Button btnCancel;
        private Panel panel1;
    }
}