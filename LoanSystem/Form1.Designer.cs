﻿namespace LoanSystem
{
    partial class SignInForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignInForm));
            lblSign = new Label();
            panelSign = new Panel();
            label2 = new Label();
            register = new Button();
            label1 = new Label();
            SigninHello = new Label();
            SigninEmail = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            SigninPassword = new TextBox();
            SignInBtn = new Button();
            forgotpass = new LinkLabel();
            SigninShowpass = new CheckBox();
            closeSignin = new Label();
            panelSign.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblSign
            // 
            lblSign.AutoSize = true;
            lblSign.BackColor = Color.MintCream;
            lblSign.Font = new Font("Tahoma", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSign.Location = new Point(486, 59);
            lblSign.Name = "lblSign";
            lblSign.Size = new Size(136, 35);
            lblSign.TabIndex = 1;
            lblSign.Text = "SIGN IN";
            // 
            // panelSign
            // 
            panelSign.BackColor = Color.SeaGreen;
            panelSign.Controls.Add(label2);
            panelSign.Controls.Add(register);
            panelSign.Controls.Add(label1);
            panelSign.Controls.Add(SigninHello);
            panelSign.Location = new Point(0, -1);
            panelSign.Name = "panelSign";
            panelSign.Size = new Size(363, 450);
            panelSign.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(95, 237);
            label2.Name = "label2";
            label2.Size = new Size(173, 19);
            label2.TabIndex = 5;
            label2.Text = "Don't have an account?";
            // 
            // register
            // 
            register.BackColor = Color.SeaGreen;
            register.FlatAppearance.BorderColor = Color.White;
            register.FlatAppearance.BorderSize = 2;
            register.FlatStyle = FlatStyle.Flat;
            register.ForeColor = Color.White;
            register.Location = new Point(118, 274);
            register.Name = "register";
            register.Size = new Size(129, 43);
            register.TabIndex = 4;
            register.Text = "Sign up";
            register.UseVisualStyleBackColor = false;
            register.Click += register_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(82, 203);
            label1.Name = "label1";
            label1.Size = new Size(198, 19);
            label1.TabIndex = 3;
            label1.Text = "Enter you details to sign in";
            // 
            // SigninHello
            // 
            SigninHello.AutoSize = true;
            SigninHello.BackColor = Color.Transparent;
            SigninHello.Font = new Font("Tahoma", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SigninHello.ForeColor = Color.White;
            SigninHello.Location = new Point(130, 143);
            SigninHello.Name = "SigninHello";
            SigninHello.Size = new Size(100, 35);
            SigninHello.TabIndex = 2;
            SigninHello.Text = "Hello!";
            // 
            // SigninEmail
            // 
            SigninEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SigninEmail.BackColor = Color.Gainsboro;
            SigninEmail.BorderStyle = BorderStyle.None;
            SigninEmail.Font = new Font("Tahoma", 12F);
            SigninEmail.ForeColor = Color.Black;
            SigninEmail.ImeMode = ImeMode.NoControl;
            SigninEmail.Location = new Point(15, 12);
            SigninEmail.Name = "SigninEmail";
            SigninEmail.PlaceholderText = "Email";
            SigninEmail.Size = new Size(298, 20);
            SigninEmail.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(SigninEmail);
            panel1.Location = new Point(396, 145);
            panel1.Name = "panel1";
            panel1.Size = new Size(325, 42);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Controls.Add(SigninPassword);
            panel2.Location = new Point(396, 202);
            panel2.Name = "panel2";
            panel2.Size = new Size(325, 42);
            panel2.TabIndex = 2;
            // 
            // SigninPassword
            // 
            SigninPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SigninPassword.BackColor = Color.Gainsboro;
            SigninPassword.BorderStyle = BorderStyle.None;
            SigninPassword.Font = new Font("Tahoma", 12F);
            SigninPassword.ForeColor = Color.Black;
            SigninPassword.ImeMode = ImeMode.NoControl;
            SigninPassword.Location = new Point(15, 12);
            SigninPassword.Name = "SigninPassword";
            SigninPassword.PasswordChar = '*';
            SigninPassword.PlaceholderText = "Password";
            SigninPassword.Size = new Size(298, 20);
            SigninPassword.TabIndex = 4;
            // 
            // SignInBtn
            // 
            SignInBtn.BackColor = Color.SeaGreen;
            SignInBtn.FlatAppearance.BorderColor = Color.White;
            SignInBtn.FlatAppearance.BorderSize = 2;
            SignInBtn.FlatStyle = FlatStyle.Flat;
            SignInBtn.ForeColor = Color.White;
            SignInBtn.Location = new Point(396, 296);
            SignInBtn.Name = "SignInBtn";
            SignInBtn.Size = new Size(325, 43);
            SignInBtn.TabIndex = 5;
            SignInBtn.Text = "Sign in";
            SignInBtn.UseVisualStyleBackColor = false;
            SignInBtn.Click += SignInBtn_Click;
            // 
            // forgotpass
            // 
            forgotpass.ActiveLinkColor = Color.WhiteSmoke;
            forgotpass.AutoSize = true;
            forgotpass.Font = new Font("Tahoma", 10F);
            forgotpass.LinkColor = Color.Black;
            forgotpass.Location = new Point(396, 342);
            forgotpass.Name = "forgotpass";
            forgotpass.Size = new Size(151, 17);
            forgotpass.TabIndex = 5;
            forgotpass.TabStop = true;
            forgotpass.Text = "Forgot your password?";
            forgotpass.VisitedLinkColor = Color.Gray;
            // 
            // SigninShowpass
            // 
            SigninShowpass.AutoSize = true;
            SigninShowpass.Location = new Point(582, 250);
            SigninShowpass.Name = "SigninShowpass";
            SigninShowpass.Size = new Size(139, 23);
            SigninShowpass.TabIndex = 6;
            SigninShowpass.Text = "Show Password";
            SigninShowpass.UseVisualStyleBackColor = true;
            SigninShowpass.CheckedChanged += SigninShowpass_CheckedChanged;
            // 
            // closeSignin
            // 
            closeSignin.AutoSize = true;
            closeSignin.BackColor = Color.Transparent;
            closeSignin.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            closeSignin.ForeColor = Color.Black;
            closeSignin.Location = new Point(729, 9);
            closeSignin.Name = "closeSignin";
            closeSignin.Size = new Size(14, 16);
            closeSignin.TabIndex = 6;
            closeSignin.Text = "x";
            closeSignin.Click += closeSignin_Click;
            // 
            // SignInForm
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(755, 450);
            Controls.Add(closeSignin);
            Controls.Add(SigninShowpass);
            Controls.Add(forgotpass);
            Controls.Add(SignInBtn);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panelSign);
            Controls.Add(lblSign);
            Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "SignInForm";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Signin";
            TransparencyKey = Color.FromArgb(0, 64, 0);
            Load += SignInForm_Load;
            panelSign.ResumeLayout(false);
            panelSign.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblSign;
        public Panel panelSign;
        private Label SigninHello;
        private Label label1;
        private Button register;
        private TextBox SigninEmail;
        private Panel panel1;
        private Panel panel2;
        private TextBox SigninPassword;
        private Button SignInBtn;
        private LinkLabel forgotpass;
        private CheckBox SigninShowpass;
        private Label label2;
        private Label closeSignin;
    }
}
