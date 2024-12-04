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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignupForm));
            signupEmail = new TextBox();
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
            signupBtnUpdate = new Button();
            signupContact = new TextBox();
            signupHome = new TextBox();
            signupEmergency = new TextBox();
            signupDob = new DateTimePicker();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label9 = new Label();
            label10 = new Label();
            signupPosition = new ComboBox();
            profilePanel = new Panel();
            UploadButton = new Button();
            profileConfirmPassword = new TextBox();
            profileNewPassword = new TextBox();
            profilePosition = new Label();
            profileEmergencyContact = new Label();
            profileAddress = new Label();
            profileBirthday = new Label();
            profileNumber = new Label();
            profileEmail = new Label();
            profileUpdate = new Button();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label4 = new Label();
            profileName = new Label();
            lbl = new Label();
            profileImage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            profilePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)profileImage).BeginInit();
            SuspendLayout();
            // 
            // signupEmail
            // 
            signupEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            signupEmail.BackColor = Color.White;
            signupEmail.BorderStyle = BorderStyle.FixedSingle;
            signupEmail.Font = new Font("Tahoma", 12F);
            signupEmail.ForeColor = Color.Black;
            signupEmail.ImeMode = ImeMode.NoControl;
            signupEmail.Location = new Point(241, 98);
            signupEmail.Name = "signupEmail";
            signupEmail.Size = new Size(185, 27);
            signupEmail.TabIndex = 4;
            // 
            // signupName
            // 
            signupName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            signupName.BackColor = Color.White;
            signupName.BorderStyle = BorderStyle.FixedSingle;
            signupName.Font = new Font("Tahoma", 12F);
            signupName.ForeColor = Color.Black;
            signupName.ImeMode = ImeMode.NoControl;
            signupName.Location = new Point(24, 98);
            signupName.Name = "signupName";
            signupName.Size = new Size(189, 27);
            signupName.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { EmployeeID, FullName, Email, Position });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(460, 78);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(625, 519);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // EmployeeID
            // 
            EmployeeID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            EmployeeID.HeaderText = "Employee ID";
            EmployeeID.Name = "EmployeeID";
            EmployeeID.ReadOnly = true;
            EmployeeID.Width = 108;
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
            Position.Width = 82;
            // 
            // SignUpBtn
            // 
            SignUpBtn.BackColor = Color.SeaGreen;
            SignUpBtn.FlatAppearance.BorderColor = Color.White;
            SignUpBtn.FlatAppearance.BorderSize = 2;
            SignUpBtn.FlatStyle = FlatStyle.Flat;
            SignUpBtn.ForeColor = Color.White;
            SignUpBtn.Location = new Point(50, 554);
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
            label8.Location = new Point(24, 77);
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
            label1.Location = new Point(241, 77);
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
            // signupBtnUpdate
            // 
            signupBtnUpdate.BackColor = Color.Khaki;
            signupBtnUpdate.FlatAppearance.BorderColor = Color.White;
            signupBtnUpdate.FlatAppearance.BorderSize = 2;
            signupBtnUpdate.FlatStyle = FlatStyle.Flat;
            signupBtnUpdate.ForeColor = Color.Black;
            signupBtnUpdate.Location = new Point(241, 554);
            signupBtnUpdate.Name = "signupBtnUpdate";
            signupBtnUpdate.Size = new Size(148, 43);
            signupBtnUpdate.TabIndex = 62;
            signupBtnUpdate.Text = "Update";
            signupBtnUpdate.UseVisualStyleBackColor = false;
            signupBtnUpdate.Click += signupBtnUpdate_Click;
            // 
            // signupContact
            // 
            signupContact.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            signupContact.BackColor = Color.White;
            signupContact.BorderStyle = BorderStyle.FixedSingle;
            signupContact.Font = new Font("Tahoma", 12F);
            signupContact.ForeColor = Color.Black;
            signupContact.ImeMode = ImeMode.NoControl;
            signupContact.Location = new Point(24, 174);
            signupContact.Name = "signupContact";
            signupContact.Size = new Size(189, 27);
            signupContact.TabIndex = 63;
            // 
            // signupHome
            // 
            signupHome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            signupHome.BackColor = Color.White;
            signupHome.BorderStyle = BorderStyle.FixedSingle;
            signupHome.Font = new Font("Tahoma", 12F);
            signupHome.ForeColor = Color.Black;
            signupHome.ImeMode = ImeMode.NoControl;
            signupHome.Location = new Point(241, 174);
            signupHome.Name = "signupHome";
            signupHome.Size = new Size(185, 27);
            signupHome.TabIndex = 64;
            // 
            // signupEmergency
            // 
            signupEmergency.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            signupEmergency.BackColor = Color.White;
            signupEmergency.BorderStyle = BorderStyle.FixedSingle;
            signupEmergency.Font = new Font("Tahoma", 12F);
            signupEmergency.ForeColor = Color.Black;
            signupEmergency.ImeMode = ImeMode.NoControl;
            signupEmergency.Location = new Point(24, 248);
            signupEmergency.Name = "signupEmergency";
            signupEmergency.Size = new Size(189, 27);
            signupEmergency.TabIndex = 65;
            // 
            // signupDob
            // 
            signupDob.CalendarFont = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signupDob.CalendarForeColor = SystemColors.ControlDark;
            signupDob.CalendarTitleBackColor = SystemColors.ControlText;
            signupDob.CalendarTitleForeColor = SystemColors.ControlDark;
            signupDob.Checked = false;
            signupDob.Font = new Font("Tahoma", 11F);
            signupDob.Format = DateTimePickerFormat.Short;
            signupDob.Location = new Point(241, 250);
            signupDob.MaxDate = new DateTime(2004, 12, 31, 0, 0, 0, 0);
            signupDob.Name = "signupDob";
            signupDob.Size = new Size(185, 25);
            signupDob.TabIndex = 67;
            signupDob.Value = new DateTime(2004, 12, 31, 0, 0, 0, 0);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(24, 153);
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
            label6.Location = new Point(241, 153);
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
            label7.Location = new Point(24, 227);
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
            label9.Location = new Point(241, 229);
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
            label10.Location = new Point(24, 305);
            label10.Name = "label10";
            label10.Size = new Size(69, 18);
            label10.TabIndex = 72;
            label10.Text = "Position";
            // 
            // signupPosition
            // 
            signupPosition.FormattingEnabled = true;
            signupPosition.Items.AddRange(new object[] { "LoanOfficer", "Accountant", "BranchManager" });
            signupPosition.Location = new Point(24, 326);
            signupPosition.Name = "signupPosition";
            signupPosition.Size = new Size(189, 27);
            signupPosition.TabIndex = 73;
            // 
            // profilePanel
            // 
            profilePanel.Controls.Add(UploadButton);
            profilePanel.Controls.Add(profileConfirmPassword);
            profilePanel.Controls.Add(profileNewPassword);
            profilePanel.Controls.Add(profilePosition);
            profilePanel.Controls.Add(profileEmergencyContact);
            profilePanel.Controls.Add(profileAddress);
            profilePanel.Controls.Add(profileBirthday);
            profilePanel.Controls.Add(profileNumber);
            profilePanel.Controls.Add(profileEmail);
            profilePanel.Controls.Add(profileUpdate);
            profilePanel.Controls.Add(label17);
            profilePanel.Controls.Add(label16);
            profilePanel.Controls.Add(label15);
            profilePanel.Controls.Add(label14);
            profilePanel.Controls.Add(label13);
            profilePanel.Controls.Add(label12);
            profilePanel.Controls.Add(label11);
            profilePanel.Controls.Add(label4);
            profilePanel.Controls.Add(profileName);
            profilePanel.Controls.Add(lbl);
            profilePanel.Controls.Add(profileImage);
            profilePanel.Location = new Point(12, 12);
            profilePanel.Name = "profilePanel";
            profilePanel.Size = new Size(1073, 585);
            profilePanel.TabIndex = 74;
            profilePanel.Visible = false;
            profilePanel.Paint += profilePanel_Paint;
            // 
            // UploadButton
            // 
            UploadButton.BackColor = Color.Khaki;
            UploadButton.FlatAppearance.BorderColor = Color.White;
            UploadButton.FlatAppearance.BorderSize = 2;
            UploadButton.FlatStyle = FlatStyle.Flat;
            UploadButton.ForeColor = Color.Black;
            UploadButton.Location = new Point(53, 508);
            UploadButton.Name = "UploadButton";
            UploadButton.Size = new Size(148, 43);
            UploadButton.TabIndex = 72;
            UploadButton.Text = "Upload Profile";
            UploadButton.UseVisualStyleBackColor = false;
            UploadButton.Click += UploadButton_Click;
            // 
            // profileConfirmPassword
            // 
            profileConfirmPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            profileConfirmPassword.BackColor = Color.White;
            profileConfirmPassword.BorderStyle = BorderStyle.FixedSingle;
            profileConfirmPassword.Font = new Font("Tahoma", 12F);
            profileConfirmPassword.ForeColor = Color.Black;
            profileConfirmPassword.ImeMode = ImeMode.NoControl;
            profileConfirmPassword.Location = new Point(272, 420);
            profileConfirmPassword.Name = "profileConfirmPassword";
            profileConfirmPassword.Size = new Size(184, 27);
            profileConfirmPassword.TabIndex = 71;
            // 
            // profileNewPassword
            // 
            profileNewPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            profileNewPassword.BackColor = Color.White;
            profileNewPassword.BorderStyle = BorderStyle.FixedSingle;
            profileNewPassword.Font = new Font("Tahoma", 12F);
            profileNewPassword.ForeColor = Color.Black;
            profileNewPassword.ImeMode = ImeMode.NoControl;
            profileNewPassword.Location = new Point(15, 420);
            profileNewPassword.Name = "profileNewPassword";
            profileNewPassword.Size = new Size(184, 27);
            profileNewPassword.TabIndex = 70;
            // 
            // profilePosition
            // 
            profilePosition.AutoSize = true;
            profilePosition.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            profilePosition.ForeColor = SystemColors.ButtonShadow;
            profilePosition.Location = new Point(861, 190);
            profilePosition.Name = "profilePosition";
            profilePosition.Size = new Size(84, 19);
            profilePosition.TabIndex = 69;
            profilePosition.Text = "John Doe";
            // 
            // profileEmergencyContact
            // 
            profileEmergencyContact.AutoSize = true;
            profileEmergencyContact.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            profileEmergencyContact.ForeColor = SystemColors.ButtonShadow;
            profileEmergencyContact.Location = new Point(584, 190);
            profileEmergencyContact.Name = "profileEmergencyContact";
            profileEmergencyContact.Size = new Size(84, 19);
            profileEmergencyContact.TabIndex = 68;
            profileEmergencyContact.Text = "John Doe";
            // 
            // profileAddress
            // 
            profileAddress.AutoSize = true;
            profileAddress.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            profileAddress.ForeColor = SystemColors.ButtonShadow;
            profileAddress.Location = new Point(17, 292);
            profileAddress.Name = "profileAddress";
            profileAddress.Size = new Size(84, 19);
            profileAddress.TabIndex = 67;
            profileAddress.Text = "John Doe";
            // 
            // profileBirthday
            // 
            profileBirthday.AutoSize = true;
            profileBirthday.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            profileBirthday.ForeColor = SystemColors.ButtonShadow;
            profileBirthday.Location = new Point(861, 65);
            profileBirthday.Name = "profileBirthday";
            profileBirthday.Size = new Size(84, 19);
            profileBirthday.TabIndex = 66;
            profileBirthday.Text = "John Doe";
            // 
            // profileNumber
            // 
            profileNumber.AutoSize = true;
            profileNumber.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            profileNumber.ForeColor = SystemColors.ButtonShadow;
            profileNumber.Location = new Point(584, 66);
            profileNumber.Name = "profileNumber";
            profileNumber.Size = new Size(84, 19);
            profileNumber.TabIndex = 65;
            profileNumber.Text = "John Doe";
            // 
            // profileEmail
            // 
            profileEmail.AutoSize = true;
            profileEmail.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            profileEmail.ForeColor = SystemColors.ButtonShadow;
            profileEmail.Location = new Point(335, 190);
            profileEmail.Name = "profileEmail";
            profileEmail.Size = new Size(84, 19);
            profileEmail.TabIndex = 64;
            profileEmail.Text = "John Doe";
            // 
            // profileUpdate
            // 
            profileUpdate.BackColor = Color.Khaki;
            profileUpdate.FlatAppearance.BorderColor = Color.White;
            profileUpdate.FlatAppearance.BorderSize = 2;
            profileUpdate.FlatStyle = FlatStyle.Flat;
            profileUpdate.ForeColor = Color.Black;
            profileUpdate.Location = new Point(898, 522);
            profileUpdate.Name = "profileUpdate";
            profileUpdate.Size = new Size(148, 43);
            profileUpdate.TabIndex = 63;
            profileUpdate.Text = "Save Changes";
            profileUpdate.UseVisualStyleBackColor = false;
            profileUpdate.Click += profileUpdate_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(272, 378);
            label17.Name = "label17";
            label17.Size = new Size(156, 19);
            label17.TabIndex = 10;
            label17.Text = "Confirm Password";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(15, 378);
            label16.Name = "label16";
            label16.Size = new Size(128, 19);
            label16.TabIndex = 9;
            label16.Text = "New Password";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(861, 159);
            label15.Name = "label15";
            label15.Size = new Size(75, 19);
            label15.TabIndex = 8;
            label15.Text = "Position";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(861, 35);
            label14.Name = "label14";
            label14.Size = new Size(93, 19);
            label14.TabIndex = 7;
            label14.Text = "Birth Date";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(17, 257);
            label13.Name = "label13";
            label13.Size = new Size(126, 19);
            label13.TabIndex = 6;
            label13.Text = "Home Address";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(584, 159);
            label12.Name = "label12";
            label12.Size = new Size(166, 19);
            label12.TabIndex = 5;
            label12.Text = "Emergency Contact";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(584, 35);
            label11.Name = "label11";
            label11.Size = new Size(129, 19);
            label11.TabIndex = 4;
            label11.Text = "Phone Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(335, 159);
            label4.Name = "label4";
            label4.Size = new Size(54, 19);
            label4.TabIndex = 3;
            label4.Text = "Email";
            // 
            // profileName
            // 
            profileName.AutoSize = true;
            profileName.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            profileName.ForeColor = SystemColors.ButtonShadow;
            profileName.Location = new Point(335, 64);
            profileName.Name = "profileName";
            profileName.Size = new Size(84, 19);
            profileName.TabIndex = 2;
            profileName.Text = "John Doe";
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl.Location = new Point(335, 35);
            lbl.Name = "lbl";
            lbl.Size = new Size(56, 19);
            lbl.TabIndex = 1;
            lbl.Text = "Name";
            // 
            // profileImage
            // 
            profileImage.Image = (Image)resources.GetObject("profileImage.Image");
            profileImage.Location = new Point(17, 13);
            profileImage.Name = "profileImage";
            profileImage.Size = new Size(265, 217);
            profileImage.SizeMode = PictureBoxSizeMode.StretchImage;
            profileImage.TabIndex = 0;
            profileImage.TabStop = false;
            // 
            // SignupForm
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1092, 609);
            Controls.Add(profilePanel);
            Controls.Add(signupPosition);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(signupDob);
            Controls.Add(signupEmergency);
            Controls.Add(signupHome);
            Controls.Add(signupContact);
            Controls.Add(signupBtnUpdate);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(label8);
            Controls.Add(SignUpBtn);
            Controls.Add(dataGridView1);
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
            Load += SignupForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            profilePanel.ResumeLayout(false);
            profilePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)profileImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox signupEmail;
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
        private Button signupBtnUpdate;
        private TextBox signupContact;
        private TextBox signupHome;
        private TextBox signupEmergency;
        private DateTimePicker signupDob;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label9;
        private Label label10;
        private ComboBox signupPosition;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label4;
        private Label lbl;

        private Panel profilePanel;
        private PictureBox profileImage;
        private Button profileUpdate;
        private Label profileName;
        private TextBox profileConfirmPassword;
        private TextBox profileNewPassword;
        private Label profilePosition;
        private Label profileEmergencyContact;
        private Label profileAddress;
        private Label profileBirthday;
        private Label profileNumber;
        private Label profileEmail;
        private Button UploadButton;
    }
}