namespace LoanSystem
{
    partial class SignupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignupForm));
            SignUpBtn = new Button();
            panel2 = new Panel();
            signupPass = new TextBox();
            panel3 = new Panel();
            signupEmail = new TextBox();
            panel4 = new Panel();
            signupConpass = new TextBox();
            panel5 = new Panel();
            signupName = new TextBox();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // SignUpBtn
            // 
            SignUpBtn.BackColor = Color.SeaGreen;
            SignUpBtn.FlatAppearance.BorderColor = Color.White;
            SignUpBtn.FlatAppearance.BorderSize = 2;
            SignUpBtn.FlatStyle = FlatStyle.Flat;
            SignUpBtn.ForeColor = Color.White;
            SignUpBtn.Location = new Point(210, 332);
            SignUpBtn.Name = "SignUpBtn";
            SignUpBtn.Size = new Size(325, 43);
            SignUpBtn.TabIndex = 10;
            SignUpBtn.Text = "Create";
            SignUpBtn.UseVisualStyleBackColor = false;
            SignUpBtn.Click += SignUpBtn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Controls.Add(signupPass);
            panel2.Location = new Point(210, 171);
            panel2.Name = "panel2";
            panel2.Size = new Size(325, 42);
            panel2.TabIndex = 7;
            // 
            // signupPass
            // 
            signupPass.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            signupPass.BackColor = Color.Gainsboro;
            signupPass.BorderStyle = BorderStyle.None;
            signupPass.Font = new Font("Tahoma", 12F);
            signupPass.ForeColor = Color.Black;
            signupPass.ImeMode = ImeMode.NoControl;
            signupPass.Location = new Point(15, 12);
            signupPass.Name = "signupPass";
            signupPass.PasswordChar = '*';
            signupPass.PlaceholderText = "Password";
            signupPass.Size = new Size(299, 20);
            signupPass.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gainsboro;
            panel3.Controls.Add(signupEmail);
            panel3.Location = new Point(210, 114);
            panel3.Name = "panel3";
            panel3.Size = new Size(325, 42);
            panel3.TabIndex = 8;
            // 
            // signupEmail
            // 
            signupEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            signupEmail.BackColor = Color.Gainsboro;
            signupEmail.BorderStyle = BorderStyle.None;
            signupEmail.Font = new Font("Tahoma", 12F);
            signupEmail.ForeColor = Color.Black;
            signupEmail.ImeMode = ImeMode.NoControl;
            signupEmail.Location = new Point(15, 12);
            signupEmail.Name = "signupEmail";
            signupEmail.PlaceholderText = "Email";
            signupEmail.Size = new Size(299, 20);
            signupEmail.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Gainsboro;
            panel4.Controls.Add(signupConpass);
            panel4.Location = new Point(210, 231);
            panel4.Name = "panel4";
            panel4.Size = new Size(325, 42);
            panel4.TabIndex = 8;
            // 
            // signupConpass
            // 
            signupConpass.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            signupConpass.BackColor = Color.Gainsboro;
            signupConpass.BorderStyle = BorderStyle.None;
            signupConpass.Font = new Font("Tahoma", 12F);
            signupConpass.ForeColor = Color.Black;
            signupConpass.ImeMode = ImeMode.NoControl;
            signupConpass.Location = new Point(15, 12);
            signupConpass.Name = "signupConpass";
            signupConpass.PasswordChar = '*';
            signupConpass.PlaceholderText = "Confirm Password";
            signupConpass.Size = new Size(299, 20);
            signupConpass.TabIndex = 4;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Gainsboro;
            panel5.Controls.Add(signupName);
            panel5.Location = new Point(210, 57);
            panel5.Name = "panel5";
            panel5.Size = new Size(325, 42);
            panel5.TabIndex = 9;
            // 
            // signupName
            // 
            signupName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            signupName.BackColor = Color.Gainsboro;
            signupName.BorderStyle = BorderStyle.None;
            signupName.Font = new Font("Tahoma", 12F);
            signupName.ForeColor = Color.Black;
            signupName.ImeMode = ImeMode.NoControl;
            signupName.Location = new Point(15, 12);
            signupName.Name = "signupName";
            signupName.PlaceholderText = "Name";
            signupName.Size = new Size(299, 20);
            signupName.TabIndex = 4;
            // 
            // SignupForm
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(755, 450);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(SignUpBtn);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "SignupForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Signup";
            TransparencyKey = Color.FromArgb(0, 64, 0);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button SignUpBtn;
        private Panel panel2;
        private TextBox signupPass;
        private Panel panel3;
        private TextBox signupEmail;
        private Panel panel4;
        private TextBox signupConpass;
        private Panel panel5;
        private TextBox signupName;
    }
}