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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignupForm));
            signupPass = new TextBox();
            signupEmail = new TextBox();
            signupConpass = new TextBox();
            signupName = new TextBox();
            dataGridView1 = new DataGridView();
            EmployeeID = new DataGridViewTextBoxColumn();
            FullName = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Position = new DataGridViewTextBoxColumn();
            SignUpBtn = new Button();
            label8 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label9 = new Label();
            label10 = new Label();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // signupPass
            // 
            signupPass.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            signupPass.BackColor = Color.White;
            signupPass.BorderStyle = BorderStyle.FixedSingle;
            signupPass.Font = new Font("Tahoma", 12F);
            signupPass.ForeColor = Color.Black;
            signupPass.ImeMode = ImeMode.NoControl;
            signupPass.Location = new Point(24, 394);
            signupPass.Name = "signupPass";
            signupPass.PasswordChar = '*';
            signupPass.Size = new Size(198, 27);
            signupPass.TabIndex = 4;
            // 
            // signupEmail
            // 
            signupEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            signupEmail.BackColor = Color.White;
            signupEmail.BorderStyle = BorderStyle.FixedSingle;
            signupEmail.Font = new Font("Tahoma", 12F);
            signupEmail.ForeColor = Color.Black;
            signupEmail.ImeMode = ImeMode.NoControl;
            signupEmail.Location = new Point(228, 78);
            signupEmail.Name = "signupEmail";
            signupEmail.Size = new Size(198, 27);
            signupEmail.TabIndex = 4;
            // 
            // signupConpass
            // 
            signupConpass.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            signupConpass.BackColor = Color.White;
            signupConpass.BorderStyle = BorderStyle.FixedSingle;
            signupConpass.Font = new Font("Tahoma", 12F);
            signupConpass.ForeColor = Color.Black;
            signupConpass.ImeMode = ImeMode.NoControl;
            signupConpass.Location = new Point(228, 394);
            signupConpass.Name = "signupConpass";
            signupConpass.PasswordChar = '*';
            signupConpass.Size = new Size(198, 27);
            signupConpass.TabIndex = 4;
            // 
            // signupName
            // 
            signupName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            signupName.BackColor = Color.White;
            signupName.BorderStyle = BorderStyle.FixedSingle;
            signupName.Font = new Font("Tahoma", 12F);
            signupName.ForeColor = Color.Black;
            signupName.ImeMode = ImeMode.NoControl;
            signupName.Location = new Point(24, 78);
            signupName.Name = "signupName";
            signupName.Size = new Size(198, 27);
            signupName.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.DarkGray;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { EmployeeID, FullName, Email, Position });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Location = new Point(460, 78);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(625, 519);
            dataGridView1.TabIndex = 12;
            // 
            // EmployeeID
            // 
            EmployeeID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            EmployeeID.HeaderText = "Employee ID";
            EmployeeID.Name = "EmployeeID";
            EmployeeID.ReadOnly = true;
            EmployeeID.Width = 125;
            // 
            // FullName
            // 
            FullName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            FullName.HeaderText = "Full Name";
            FullName.Name = "FullName";
            FullName.ReadOnly = true;
            // 
            // Email
            // 
            Email.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Email.HeaderText = "Email";
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // Position
            // 
            Position.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Position.HeaderText = "Position";
            Position.Name = "Position";
            Position.ReadOnly = true;
            Position.Width = 90;
            // 
            // SignUpBtn
            // 
            SignUpBtn.BackColor = Color.SeaGreen;
            SignUpBtn.FlatAppearance.BorderColor = Color.White;
            SignUpBtn.FlatAppearance.BorderSize = 2;
            SignUpBtn.FlatStyle = FlatStyle.Flat;
            SignUpBtn.ForeColor = Color.White;
            SignUpBtn.Location = new Point(24, 523);
            SignUpBtn.Name = "SignUpBtn";
            SignUpBtn.Size = new Size(148, 43);
            SignUpBtn.TabIndex = 10;
            SignUpBtn.Text = "Create";
            SignUpBtn.UseVisualStyleBackColor = false;
            SignUpBtn.Click += SignUpBtn_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ControlText;
            label8.Location = new Point(24, 57);
            label8.Name = "label8";
            label8.Size = new Size(90, 18);
            label8.TabIndex = 56;
            label8.Text = "First Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(228, 57);
            label1.Name = "label1";
            label1.Size = new Size(49, 18);
            label1.TabIndex = 57;
            label1.Text = "Email";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Tahoma", 12F);
            textBox1.ForeColor = Color.Black;
            textBox1.ImeMode = ImeMode.NoControl;
            textBox1.Location = new Point(882, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(198, 27);
            textBox1.TabIndex = 58;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(816, 30);
            label2.Name = "label2";
            label2.Size = new Size(60, 18);
            label2.TabIndex = 59;
            label2.Text = "Search";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(24, 373);
            label3.Name = "label3";
            label3.Size = new Size(81, 18);
            label3.TabIndex = 60;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(228, 373);
            label4.Name = "label4";
            label4.Size = new Size(144, 18);
            label4.TabIndex = 61;
            label4.Text = "Confirm Password";
            // 
            // button1
            // 
            button1.BackColor = Color.Khaki;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(178, 523);
            button1.Name = "button1";
            button1.Size = new Size(148, 43);
            button1.TabIndex = 62;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.BackColor = Color.White;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Tahoma", 12F);
            textBox2.ForeColor = Color.Black;
            textBox2.ImeMode = ImeMode.NoControl;
            textBox2.Location = new Point(24, 154);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(198, 27);
            textBox2.TabIndex = 63;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox3.BackColor = Color.White;
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Font = new Font("Tahoma", 12F);
            textBox3.ForeColor = Color.Black;
            textBox3.ImeMode = ImeMode.NoControl;
            textBox3.Location = new Point(228, 154);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(198, 27);
            textBox3.TabIndex = 64;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox4.BackColor = Color.White;
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Font = new Font("Tahoma", 12F);
            textBox4.ForeColor = Color.Black;
            textBox4.ImeMode = ImeMode.NoControl;
            textBox4.Location = new Point(24, 228);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(198, 27);
            textBox4.TabIndex = 65;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.CalendarForeColor = SystemColors.ControlDark;
            dateTimePicker1.CalendarTitleBackColor = SystemColors.ControlText;
            dateTimePicker1.CalendarTitleForeColor = SystemColors.ControlDark;
            dateTimePicker1.Font = new Font("Tahoma", 11F);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(228, 230);
            dateTimePicker1.MaxDate = new DateTime(2004, 12, 31, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(198, 25);
            dateTimePicker1.TabIndex = 67;
            dateTimePicker1.Value = new DateTime(2004, 12, 31, 0, 0, 0, 0);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(24, 133);
            label5.Name = "label5";
            label5.Size = new Size(65, 18);
            label5.TabIndex = 68;
            label5.Text = "Contact";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlText;
            label6.Location = new Point(228, 133);
            label6.Name = "label6";
            label6.Size = new Size(114, 18);
            label6.TabIndex = 69;
            label6.Text = "Home Address";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlText;
            label7.Location = new Point(24, 207);
            label7.Name = "label7";
            label7.Size = new Size(151, 18);
            label7.TabIndex = 70;
            label7.Text = "Emergency Contact";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ControlText;
            label9.Location = new Point(228, 209);
            label9.Name = "label9";
            label9.Size = new Size(103, 18);
            label9.TabIndex = 71;
            label9.Text = "Date of Birth";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ControlText;
            label10.Location = new Point(24, 307);
            label10.Name = "label10";
            label10.Size = new Size(69, 18);
            label10.TabIndex = 72;
            label10.Text = "Position";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Loan Officer", " Accountant", "Branch Manager" });
            comboBox1.Location = new Point(24, 328);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(198, 27);
            comboBox1.TabIndex = 73;
            // 
            // SignupForm
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1092, 609);
            Controls.Add(comboBox1);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(label8);
            Controls.Add(SignUpBtn);
            Controls.Add(signupConpass);
            Controls.Add(dataGridView1);
            Controls.Add(signupPass);
            Controls.Add(signupEmail);
            Controls.Add(signupName);
            Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "SignupForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Signup";
            TransparencyKey = Color.FromArgb(0, 64, 0);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox signupPass;
        private TextBox signupEmail;
        private TextBox signupConpass;
        private TextBox signupName;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn EmployeeID;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Position;
        private Button SignUpBtn;
        private Label label8;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label9;
        private Label label10;
        private ComboBox comboBox1;
    }
}