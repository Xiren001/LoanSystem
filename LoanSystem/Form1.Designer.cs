namespace LoanSystem
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
            label1 = new Label();
            SigninHello = new Label();
            SigninEmail = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            SigninPassword = new TextBox();
            SignInBtn = new Button();
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
            lblSign.Size = new Size(112, 35);
            lblSign.TabIndex = 1;
            lblSign.Text = "LOGIN";
            // 
            // panelSign
            // 
            panelSign.BackColor = Color.SeaGreen;
            panelSign.Controls.Add(label1);
            panelSign.Controls.Add(SigninHello);
            panelSign.Location = new Point(0, -1);
            panelSign.Name = "panelSign";
            panelSign.Size = new Size(363, 450);
            panelSign.TabIndex = 2;
            panelSign.Paint += panelSign_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(91, 215);
            label1.Name = "label1";
            label1.Size = new Size(186, 19);
            label1.TabIndex = 3;
            label1.Text = "Enter you details to login";
            // 
            // SigninHello
            // 
            SigninHello.AutoSize = true;
            SigninHello.BackColor = Color.Transparent;
            SigninHello.Font = new Font("Tahoma", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SigninHello.ForeColor = Color.White;
            SigninHello.Location = new Point(131, 158);
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
        private TextBox SigninEmail;
        private Panel panel1;
        private Panel panel2;
        private TextBox SigninPassword;
        private Button SignInBtn;
        private CheckBox SigninShowpass;
        private Label closeSignin;
    }
}
