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
            panel1 = new Panel();
            label2 = new Label();
            closeSignUp = new Label();
            login = new Button();
            label1 = new Label();
            SigninHello = new Label();
            SignUpBtn = new Button();
            panel2 = new Panel();
            signupPass = new TextBox();
            panel3 = new Panel();
            signupEmail = new TextBox();
            lblSign = new Label();
            panel4 = new Panel();
            signupConpass = new TextBox();
            panel5 = new Panel();
            signupName = new TextBox();
            SignupShowpass = new CheckBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaGreen;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(closeSignUp);
            panel1.Controls.Add(login);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(SigninHello);
            panel1.Location = new Point(392, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(363, 450);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(84, 230);
            label2.Name = "label2";
            label2.Size = new Size(190, 19);
            label2.TabIndex = 12;
            label2.Text = "Already have an account?";
            // 
            // closeSignUp
            // 
            closeSignUp.AutoSize = true;
            closeSignUp.BackColor = Color.Transparent;
            closeSignUp.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            closeSignUp.ForeColor = Color.White;
            closeSignUp.Location = new Point(337, 9);
            closeSignUp.Name = "closeSignUp";
            closeSignUp.Size = new Size(14, 16);
            closeSignUp.TabIndex = 11;
            closeSignUp.Text = "x";
            closeSignUp.Click += closeSignUp_Click;
            // 
            // login
            // 
            login.BackColor = Color.SeaGreen;
            login.FlatAppearance.BorderColor = Color.White;
            login.FlatAppearance.BorderSize = 2;
            login.FlatStyle = FlatStyle.Flat;
            login.ForeColor = Color.White;
            login.Location = new Point(118, 269);
            login.Name = "login";
            login.Size = new Size(129, 43);
            login.TabIndex = 7;
            login.Text = "Sign in";
            login.UseVisualStyleBackColor = false;
            login.Click += login_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(53, 196);
            label1.Name = "label1";
            label1.Size = new Size(265, 19);
            label1.TabIndex = 6;
            label1.Text = "Fill up the form to create an account";
            // 
            // SigninHello
            // 
            SigninHello.AutoSize = true;
            SigninHello.BackColor = Color.Transparent;
            SigninHello.Font = new Font("Tahoma", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SigninHello.ForeColor = Color.White;
            SigninHello.Location = new Point(130, 138);
            SigninHello.Name = "SigninHello";
            SigninHello.Size = new Size(100, 35);
            SigninHello.TabIndex = 5;
            SigninHello.Text = "Hello!";
            // 
            // SignUpBtn
            // 
            SignUpBtn.BackColor = Color.SeaGreen;
            SignUpBtn.FlatAppearance.BorderColor = Color.White;
            SignUpBtn.FlatAppearance.BorderSize = 2;
            SignUpBtn.FlatStyle = FlatStyle.Flat;
            SignUpBtn.ForeColor = Color.White;
            SignUpBtn.Location = new Point(35, 365);
            SignUpBtn.Name = "SignUpBtn";
            SignUpBtn.Size = new Size(325, 43);
            SignUpBtn.TabIndex = 10;
            SignUpBtn.Text = "Sign up";
            SignUpBtn.UseVisualStyleBackColor = false;
            SignUpBtn.Click += SignUpBtn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Controls.Add(signupPass);
            panel2.Location = new Point(35, 204);
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
            panel3.Location = new Point(35, 147);
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
            // lblSign
            // 
            lblSign.AutoSize = true;
            lblSign.BackColor = Color.MintCream;
            lblSign.Font = new Font("Tahoma", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSign.Location = new Point(122, 42);
            lblSign.Name = "lblSign";
            lblSign.Size = new Size(140, 35);
            lblSign.TabIndex = 6;
            lblSign.Text = "SIGN UP";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Gainsboro;
            panel4.Controls.Add(signupConpass);
            panel4.Location = new Point(35, 264);
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
            panel5.Location = new Point(35, 90);
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
            // SignupShowpass
            // 
            SignupShowpass.AutoSize = true;
            SignupShowpass.Location = new Point(221, 312);
            SignupShowpass.Name = "SignupShowpass";
            SignupShowpass.Size = new Size(139, 23);
            SignupShowpass.TabIndex = 11;
            SignupShowpass.Text = "Show Password";
            SignupShowpass.UseVisualStyleBackColor = true;
            SignupShowpass.CheckedChanged += SignupShowpass_CheckedChanged;
            // 
            // SignupForm
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(755, 450);
            Controls.Add(SignupShowpass);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(SignUpBtn);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(lblSign);
            Controls.Add(panel1);
            Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "SignupForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Signup";
            TransparencyKey = Color.FromArgb(0, 64, 0);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button SignUpBtn;
        private Panel panel2;
        private TextBox signupPass;
        private Panel panel3;
        private TextBox signupEmail;
        private Label lblSign;
        private Button login;
        private Label label1;
        private Label SigninHello;
        private Panel panel4;
        private TextBox signupConpass;
        private Panel panel5;
        private TextBox signupName;
        private Label label2;
        private Label closeSignUp;
        private CheckBox SignupShowpass;
    }
}