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
            label17 = new Label();
            label16 = new Label();
            profileConfirmPassword = new TextBox();
            profileNewPassword = new TextBox();
            profilePosition = new Label();
            profileEmergencyContact = new Label();
            profileAddress = new Label();
            profileBirthday = new Label();
            profileNumber = new Label();
            profileEmail = new Label();
            profileUpdate = new Button();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            profileImage = new PictureBox();
            UploadButton = new Button();
            profileName = new Label();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            profilePanel.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)profileImage).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // signupEmail
            // 
            signupEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            signupEmail.BackColor = Color.WhiteSmoke;
            signupEmail.BorderStyle = BorderStyle.FixedSingle;
            signupEmail.Font = new Font("Tahoma", 14.25F);
            signupEmail.ForeColor = Color.Black;
            signupEmail.ImeMode = ImeMode.NoControl;
            signupEmail.Location = new Point(27, 411);
            signupEmail.Name = "signupEmail";
            signupEmail.Size = new Size(561, 30);
            signupEmail.TabIndex = 4;
            // 
            // signupName
            // 
            signupName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            signupName.BackColor = Color.WhiteSmoke;
            signupName.BorderStyle = BorderStyle.FixedSingle;
            signupName.Font = new Font("Tahoma", 14.25F);
            signupName.ForeColor = Color.Black;
            signupName.ImeMode = ImeMode.NoControl;
            signupName.Location = new Point(27, 72);
            signupName.Name = "signupName";
            signupName.Size = new Size(561, 30);
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
            dataGridViewCellStyle1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { EmployeeID, FullName, Email, Position });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(625, 65);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(770, 736);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // EmployeeID
            // 
            EmployeeID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            EmployeeID.HeaderText = "Employee ID";
            EmployeeID.Name = "EmployeeID";
            EmployeeID.ReadOnly = true;
            EmployeeID.Width = 137;
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
            // 
            // SignUpBtn
            // 
            SignUpBtn.BackColor = Color.FromArgb(12, 154, 140);
            SignUpBtn.FlatAppearance.BorderColor = Color.White;
            SignUpBtn.FlatAppearance.BorderSize = 2;
            SignUpBtn.FlatStyle = FlatStyle.Flat;
            SignUpBtn.ForeColor = Color.White;
            SignUpBtn.Location = new Point(273, 765);
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
            label8.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            label8.ForeColor = SystemColors.ControlText;
            label8.Location = new Point(27, 55);
            label8.Name = "label8";
            label8.Size = new Size(114, 23);
            label8.TabIndex = 56;
            label8.Text = "First Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(27, 394);
            label1.Name = "label1";
            label1.Size = new Size(63, 23);
            label1.TabIndex = 57;
            label1.Text = "Email";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Tahoma", 14.25F);
            textBox1.ForeColor = Color.Black;
            textBox1.ImeMode = ImeMode.NoControl;
            textBox1.Location = new Point(1094, 25);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(301, 30);
            textBox1.TabIndex = 58;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(1094, 9);
            label2.Name = "label2";
            label2.Size = new Size(74, 23);
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
            signupBtnUpdate.Location = new Point(440, 765);
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
            signupContact.BackColor = Color.WhiteSmoke;
            signupContact.BorderStyle = BorderStyle.FixedSingle;
            signupContact.Font = new Font("Tahoma", 14.25F);
            signupContact.ForeColor = Color.Black;
            signupContact.ImeMode = ImeMode.NoControl;
            signupContact.Location = new Point(27, 154);
            signupContact.Name = "signupContact";
            signupContact.Size = new Size(561, 30);
            signupContact.TabIndex = 63;
            // 
            // signupHome
            // 
            signupHome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            signupHome.BackColor = Color.WhiteSmoke;
            signupHome.BorderStyle = BorderStyle.FixedSingle;
            signupHome.Font = new Font("Tahoma", 14.25F);
            signupHome.ForeColor = Color.Black;
            signupHome.ImeMode = ImeMode.NoControl;
            signupHome.Location = new Point(27, 498);
            signupHome.Name = "signupHome";
            signupHome.Size = new Size(561, 30);
            signupHome.TabIndex = 64;
            // 
            // signupEmergency
            // 
            signupEmergency.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            signupEmergency.BackColor = Color.WhiteSmoke;
            signupEmergency.BorderStyle = BorderStyle.FixedSingle;
            signupEmergency.Font = new Font("Tahoma", 14.25F);
            signupEmergency.ForeColor = Color.Black;
            signupEmergency.ImeMode = ImeMode.NoControl;
            signupEmergency.Location = new Point(27, 239);
            signupEmergency.Name = "signupEmergency";
            signupEmergency.Size = new Size(561, 30);
            signupEmergency.TabIndex = 65;
            // 
            // signupDob
            // 
            signupDob.CalendarFont = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signupDob.CalendarForeColor = Color.Black;
            signupDob.CalendarMonthBackground = Color.WhiteSmoke;
            signupDob.CalendarTitleBackColor = SystemColors.ControlText;
            signupDob.CalendarTitleForeColor = Color.WhiteSmoke;
            signupDob.CalendarTrailingForeColor = Color.WhiteSmoke;
            signupDob.Checked = false;
            signupDob.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signupDob.Location = new Point(27, 590);
            signupDob.MaxDate = new DateTime(2004, 12, 31, 0, 0, 0, 0);
            signupDob.Name = "signupDob";
            signupDob.Size = new Size(350, 30);
            signupDob.TabIndex = 67;
            signupDob.Value = new DateTime(2004, 12, 31, 0, 0, 0, 0);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(27, 138);
            label5.Name = "label5";
            label5.Size = new Size(84, 23);
            label5.TabIndex = 68;
            label5.Text = "Contact";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ControlText;
            label6.Location = new Point(27, 483);
            label6.Name = "label6";
            label6.Size = new Size(148, 23);
            label6.TabIndex = 69;
            label6.Text = "Home Address";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ControlText;
            label7.Location = new Point(27, 218);
            label7.Name = "label7";
            label7.Size = new Size(195, 23);
            label7.TabIndex = 70;
            label7.Text = "Emergency Contact";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            label9.ForeColor = SystemColors.ControlText;
            label9.Location = new Point(27, 573);
            label9.Name = "label9";
            label9.Size = new Size(132, 23);
            label9.TabIndex = 71;
            label9.Text = "Date of Birth";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            label10.ForeColor = SystemColors.ControlText;
            label10.Location = new Point(27, 310);
            label10.Name = "label10";
            label10.Size = new Size(88, 23);
            label10.TabIndex = 72;
            label10.Text = "Position";
            // 
            // signupPosition
            // 
            signupPosition.BackColor = Color.WhiteSmoke;
            signupPosition.Font = new Font("Tahoma", 14.25F);
            signupPosition.FormattingEnabled = true;
            signupPosition.Items.AddRange(new object[] { "LoanOfficer", "Accountant", "BranchManager" });
            signupPosition.Location = new Point(27, 331);
            signupPosition.Name = "signupPosition";
            signupPosition.Size = new Size(561, 31);
            signupPosition.TabIndex = 73;
            // 
            // profilePanel
            // 
            profilePanel.Controls.Add(label17);
            profilePanel.Controls.Add(label16);
            profilePanel.Controls.Add(profileConfirmPassword);
            profilePanel.Controls.Add(profileNewPassword);
            profilePanel.Controls.Add(profilePosition);
            profilePanel.Controls.Add(profileEmergencyContact);
            profilePanel.Controls.Add(profileAddress);
            profilePanel.Controls.Add(profileBirthday);
            profilePanel.Controls.Add(profileNumber);
            profilePanel.Controls.Add(profileEmail);
            profilePanel.Controls.Add(profileUpdate);
            profilePanel.Controls.Add(label15);
            profilePanel.Controls.Add(label14);
            profilePanel.Controls.Add(label13);
            profilePanel.Controls.Add(label12);
            profilePanel.Controls.Add(label11);
            profilePanel.Controls.Add(label4);
            profilePanel.Controls.Add(panel1);
            profilePanel.Location = new Point(-9, -7);
            profilePanel.Name = "profilePanel";
            profilePanel.Size = new Size(1431, 838);
            profilePanel.TabIndex = 74;
            profilePanel.Visible = false;
            profilePanel.Paint += profilePanel_Paint;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            label17.Location = new Point(735, 640);
            label17.Name = "label17";
            label17.Size = new Size(184, 23);
            label17.TabIndex = 10;
            label17.Text = "Confirm Password";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            label16.Location = new Point(379, 640);
            label16.Name = "label16";
            label16.Size = new Size(151, 23);
            label16.TabIndex = 9;
            label16.Text = "New Password";
            // 
            // profileConfirmPassword
            // 
            profileConfirmPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            profileConfirmPassword.BackColor = Color.White;
            profileConfirmPassword.BorderStyle = BorderStyle.FixedSingle;
            profileConfirmPassword.Font = new Font("Tahoma", 14.25F);
            profileConfirmPassword.ForeColor = Color.Black;
            profileConfirmPassword.ImeMode = ImeMode.NoControl;
            profileConfirmPassword.Location = new Point(735, 656);
            profileConfirmPassword.Name = "profileConfirmPassword";
            profileConfirmPassword.Size = new Size(327, 30);
            profileConfirmPassword.TabIndex = 71;
            // 
            // profileNewPassword
            // 
            profileNewPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            profileNewPassword.BackColor = Color.White;
            profileNewPassword.BorderStyle = BorderStyle.FixedSingle;
            profileNewPassword.Font = new Font("Tahoma", 14.25F);
            profileNewPassword.ForeColor = Color.Black;
            profileNewPassword.ImeMode = ImeMode.NoControl;
            profileNewPassword.Location = new Point(379, 656);
            profileNewPassword.Name = "profileNewPassword";
            profileNewPassword.Size = new Size(331, 30);
            profileNewPassword.TabIndex = 70;
            // 
            // profilePosition
            // 
            profilePosition.AutoSize = true;
            profilePosition.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            profilePosition.ForeColor = SystemColors.ButtonShadow;
            profilePosition.Location = new Point(908, 551);
            profilePosition.Name = "profilePosition";
            profilePosition.Size = new Size(99, 23);
            profilePosition.TabIndex = 69;
            profilePosition.Text = "John Doe";
            // 
            // profileEmergencyContact
            // 
            profileEmergencyContact.AutoSize = true;
            profileEmergencyContact.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            profileEmergencyContact.ForeColor = SystemColors.ButtonShadow;
            profileEmergencyContact.Location = new Point(631, 551);
            profileEmergencyContact.Name = "profileEmergencyContact";
            profileEmergencyContact.Size = new Size(99, 23);
            profileEmergencyContact.TabIndex = 68;
            profileEmergencyContact.Text = "John Doe";
            // 
            // profileAddress
            // 
            profileAddress.AutoSize = true;
            profileAddress.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            profileAddress.ForeColor = SystemColors.ButtonShadow;
            profileAddress.Location = new Point(382, 450);
            profileAddress.Name = "profileAddress";
            profileAddress.Size = new Size(99, 23);
            profileAddress.TabIndex = 67;
            profileAddress.Text = "John Doe";
            // 
            // profileBirthday
            // 
            profileBirthday.AutoSize = true;
            profileBirthday.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            profileBirthday.ForeColor = SystemColors.ButtonShadow;
            profileBirthday.Location = new Point(911, 445);
            profileBirthday.Name = "profileBirthday";
            profileBirthday.Size = new Size(99, 23);
            profileBirthday.TabIndex = 66;
            profileBirthday.Text = "John Doe";
            // 
            // profileNumber
            // 
            profileNumber.AutoSize = true;
            profileNumber.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            profileNumber.ForeColor = SystemColors.ButtonShadow;
            profileNumber.Location = new Point(634, 446);
            profileNumber.Name = "profileNumber";
            profileNumber.Size = new Size(99, 23);
            profileNumber.TabIndex = 65;
            profileNumber.Text = "John Doe";
            // 
            // profileEmail
            // 
            profileEmail.AutoSize = true;
            profileEmail.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            profileEmail.ForeColor = SystemColors.ButtonShadow;
            profileEmail.Location = new Point(382, 551);
            profileEmail.Name = "profileEmail";
            profileEmail.Size = new Size(99, 23);
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
            profileUpdate.Location = new Point(634, 749);
            profileUpdate.Name = "profileUpdate";
            profileUpdate.Size = new Size(148, 43);
            profileUpdate.TabIndex = 63;
            profileUpdate.Text = "Save Changes";
            profileUpdate.UseVisualStyleBackColor = false;
            profileUpdate.Click += profileUpdate_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            label15.Location = new Point(908, 520);
            label15.Name = "label15";
            label15.Size = new Size(88, 23);
            label15.TabIndex = 8;
            label15.Text = "Position";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            label14.Location = new Point(911, 415);
            label14.Name = "label14";
            label14.Size = new Size(107, 23);
            label14.TabIndex = 7;
            label14.Text = "Birth Date";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            label13.Location = new Point(382, 415);
            label13.Name = "label13";
            label13.Size = new Size(148, 23);
            label13.TabIndex = 6;
            label13.Text = "Home Address";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            label12.Location = new Point(631, 520);
            label12.Name = "label12";
            label12.Size = new Size(195, 23);
            label12.TabIndex = 5;
            label12.Text = "Emergency Contact";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            label11.Location = new Point(634, 415);
            label11.Name = "label11";
            label11.Size = new Size(151, 23);
            label11.TabIndex = 4;
            label11.Text = "Phone Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 14.25F, FontStyle.Bold);
            label4.Location = new Point(382, 520);
            label4.Name = "label4";
            label4.Size = new Size(63, 23);
            label4.TabIndex = 3;
            label4.Text = "Email";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(12, 154, 140);
            panel1.Controls.Add(profileImage);
            panel1.Controls.Add(UploadButton);
            panel1.Controls.Add(profileName);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1435, 388);
            panel1.TabIndex = 73;
            // 
            // profileImage
            // 
            profileImage.Image = (Image)resources.GetObject("profileImage.Image");
            profileImage.Location = new Point(575, 16);
            profileImage.Name = "profileImage";
            profileImage.Size = new Size(270, 270);
            profileImage.SizeMode = PictureBoxSizeMode.CenterImage;
            profileImage.TabIndex = 0;
            profileImage.TabStop = false;
            // 
            // UploadButton
            // 
            UploadButton.BackColor = Color.Transparent;
            UploadButton.FlatAppearance.BorderColor = Color.White;
            UploadButton.FlatAppearance.BorderSize = 0;
            UploadButton.FlatStyle = FlatStyle.Flat;
            UploadButton.ForeColor = Color.White;
            UploadButton.Location = new Point(575, 344);
            UploadButton.Name = "UploadButton";
            UploadButton.Size = new Size(270, 31);
            UploadButton.TabIndex = 72;
            UploadButton.Text = "Upload Profile";
            UploadButton.UseVisualStyleBackColor = false;
            UploadButton.Click += UploadButton_Click;
            // 
            // profileName
            // 
            profileName.AutoSize = true;
            profileName.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            profileName.ForeColor = Color.White;
            profileName.Location = new Point(655, 299);
            profileName.Name = "profileName";
            profileName.Size = new Size(124, 29);
            profileName.TabIndex = 2;
            profileName.Text = "John Doe";
            profileName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(SignUpBtn);
            panel2.Controls.Add(signupBtnUpdate);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(signupName);
            panel2.Controls.Add(signupEmail);
            panel2.Controls.Add(signupPosition);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(signupContact);
            panel2.Controls.Add(signupHome);
            panel2.Controls.Add(signupDob);
            panel2.Controls.Add(signupEmergency);
            panel2.Location = new Point(-9, -7);
            panel2.Name = "panel2";
            panel2.Size = new Size(613, 841);
            panel2.TabIndex = 75;
            // 
            // SignupForm
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1407, 820);
            Controls.Add(profilePanel);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)profileImage).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private Panel panel1;
        private Panel panel2;
    }
}