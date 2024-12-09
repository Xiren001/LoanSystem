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
            pictureBox1 = new PictureBox();
            SigninEmail = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            SigninPassword = new TextBox();
            SignInBtn = new Button();
            SigninShowpass = new CheckBox();
            panelSign = new Panel();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panelSign.SuspendLayout();
            SuspendLayout();
            // 
            // lblSign
            // 
            lblSign.AutoSize = true;
            lblSign.BackColor = Color.Transparent;
            lblSign.Font = new Font("Tahoma", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSign.ForeColor = Color.FromArgb(12, 154, 140);
            lblSign.Location = new Point(505, 134);
            lblSign.Name = "lblSign";
            lblSign.Size = new Size(248, 35);
            lblSign.TabIndex = 1;
            lblSign.Text = "Loan Wise Bank";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(526, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(182, 104);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // SigninEmail
            // 
            SigninEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SigninEmail.BackColor = Color.White;
            SigninEmail.BorderStyle = BorderStyle.None;
            SigninEmail.Font = new Font("Tahoma", 12F);
            SigninEmail.ForeColor = Color.Black;
            SigninEmail.ImeMode = ImeMode.NoControl;
            SigninEmail.Location = new Point(15, 12);
            SigninEmail.Name = "SigninEmail";
            SigninEmail.PlaceholderText = "Email";
            SigninEmail.Size = new Size(424, 20);
            SigninEmail.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(SigninEmail);
            panel1.Location = new Point(394, 209);
            panel1.Name = "panel1";
            panel1.Size = new Size(453, 42);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(SigninPassword);
            panel2.Location = new Point(394, 266);
            panel2.Name = "panel2";
            panel2.Size = new Size(453, 42);
            panel2.TabIndex = 2;
            // 
            // SigninPassword
            // 
            SigninPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SigninPassword.BackColor = Color.White;
            SigninPassword.BorderStyle = BorderStyle.None;
            SigninPassword.Font = new Font("Tahoma", 12F);
            SigninPassword.ForeColor = Color.Black;
            SigninPassword.ImeMode = ImeMode.NoControl;
            SigninPassword.Location = new Point(15, 12);
            SigninPassword.Name = "SigninPassword";
            SigninPassword.PasswordChar = '*';
            SigninPassword.PlaceholderText = "Password";
            SigninPassword.Size = new Size(424, 20);
            SigninPassword.TabIndex = 4;
            // 
            // SignInBtn
            // 
            SignInBtn.BackColor = Color.FromArgb(12, 154, 140);
            SignInBtn.FlatAppearance.BorderColor = Color.White;
            SignInBtn.FlatAppearance.BorderSize = 2;
            SignInBtn.FlatStyle = FlatStyle.Flat;
            SignInBtn.ForeColor = Color.White;
            SignInBtn.Location = new Point(394, 391);
            SignInBtn.Name = "SignInBtn";
            SignInBtn.Size = new Size(453, 43);
            SignInBtn.TabIndex = 5;
            SignInBtn.Text = "Sign in";
            SignInBtn.UseVisualStyleBackColor = false;
            SignInBtn.Click += SignInBtn_Click;
            // 
            // SigninShowpass
            // 
            SigninShowpass.AutoSize = true;
            SigninShowpass.ForeColor = Color.Black;
            SigninShowpass.Location = new Point(708, 314);
            SigninShowpass.Name = "SigninShowpass";
            SigninShowpass.Size = new Size(139, 23);
            SigninShowpass.TabIndex = 6;
            SigninShowpass.Text = "Show Password";
            SigninShowpass.UseVisualStyleBackColor = true;
            SigninShowpass.CheckedChanged += SigninShowpass_CheckedChanged;
            // 
            // panelSign
            // 
            panelSign.BackColor = Color.FromArgb(12, 154, 140);
            panelSign.Controls.Add(label2);
            panelSign.Controls.Add(label1);
            panelSign.Location = new Point(0, -1);
            panelSign.Name = "panelSign";
            panelSign.Size = new Size(368, 518);
            panelSign.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(74, 263);
            label2.Name = "label2";
            label2.Size = new Size(207, 46);
            label2.TabIndex = 3;
            label2.Text = "Please enter your \r\ncredentials to log in.";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(116, 197);
            label1.Name = "label1";
            label1.Size = new Size(128, 45);
            label1.TabIndex = 2;
            label1.Text = "Hello!";
            // 
            // SignInForm
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(872, 516);
            Controls.Add(pictureBox1);
            Controls.Add(SigninShowpass);
            Controls.Add(SignInBtn);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panelSign);
            Controls.Add(lblSign);
            Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "SignInForm";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            TransparencyKey = Color.FromArgb(0, 64, 0);
            Load += SignInForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panelSign.ResumeLayout(false);
            panelSign.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblSign;
        private TextBox SigninEmail;
        private Panel panel1;
        private Panel panel2;
        private TextBox SigninPassword;
        private Button SignInBtn;
        private CheckBox SigninShowpass;
        private PictureBox pictureBox1;
        public Panel panelSign;
        private Label label2;
        private Label label1;
    }
}
