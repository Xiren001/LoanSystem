namespace LoanSystem
{
    partial class formNewApp
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
            label3 = new Label();
            label4 = new Label();
            lastname = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            fileSystemWatcher1 = new FileSystemWatcher();
            panel1 = new Panel();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            panel2 = new Panel();
            textBox9 = new TextBox();
            comboBox6 = new ComboBox();
            comboBox5 = new ComboBox();
            textBox8 = new TextBox();
            comboBox4 = new ComboBox();
            textBox7 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(90, 10);
            label1.Name = "label1";
            label1.Size = new Size(190, 23);
            label1.TabIndex = 0;
            label1.Text = " Personal Information";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(84, 19);
            label2.Name = "label2";
            label2.Size = new Size(218, 23);
            label2.TabIndex = 1;
            label2.Text = "Employment Information";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(618, 39);
            label3.Name = "label3";
            label3.Size = new Size(111, 23);
            label3.TabIndex = 2;
            label3.Text = "Loan Details";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(848, 22);
            label4.Name = "label4";
            label4.Size = new Size(187, 23);
            label4.TabIndex = 3;
            label4.Text = "Financial Information";
            // 
            // lastname
            // 
            lastname.BorderStyle = BorderStyle.FixedSingle;
            lastname.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lastname.Location = new Point(3, 55);
            lastname.Name = "lastname";
            lastname.PlaceholderText = " Last Name";
            lastname.Size = new Size(100, 27);
            lastname.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(128, 55);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = " First Name";
            textBox1.Size = new Size(100, 27);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(252, 55);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = " Middle Name";
            textBox2.Size = new Size(112, 27);
            textBox2.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.CalendarForeColor = SystemColors.ControlDark;
            dateTimePicker1.CalendarTitleBackColor = SystemColors.ControlText;
            dateTimePicker1.CalendarTitleForeColor = SystemColors.ControlDark;
            dateTimePicker1.Font = new Font("Tahoma", 11F);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(3, 97);
            dateTimePicker1.MaxDate = new DateTime(2004, 12, 31, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(100, 25);
            dateTimePicker1.TabIndex = 7;
            dateTimePicker1.Value = new DateTime(2004, 12, 31, 0, 0, 0, 0);
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox6);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(comboBox3);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(lastname);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(368, 222);
            panel1.TabIndex = 8;
            // 
            // textBox6
            // 
            textBox6.BorderStyle = BorderStyle.FixedSingle;
            textBox6.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox6.Location = new Point(184, 183);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "Home Address";
            textBox6.Size = new Size(181, 27);
            textBox6.TabIndex = 14;
            // 
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(3, 183);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Email Address";
            textBox5.Size = new Size(160, 27);
            textBox5.TabIndex = 13;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(252, 138);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Phone Number";
            textBox4.Size = new Size(112, 27);
            textBox4.TabIndex = 12;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(128, 138);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "ID number";
            textBox3.Size = new Size(100, 27);
            textBox3.TabIndex = 11;
            // 
            // comboBox3
            // 
            comboBox3.Font = new Font("Tahoma", 12F);
            comboBox3.ForeColor = SystemColors.WindowFrame;
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "National ID", "SSS" });
            comboBox3.Location = new Point(3, 138);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(100, 27);
            comboBox3.TabIndex = 10;
            comboBox3.Text = "ID type";
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Tahoma", 11F);
            comboBox2.ForeColor = SystemColors.WindowFrame;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Single ", "Married", "Divorced" });
            comboBox2.Location = new Point(252, 97);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(112, 26);
            comboBox2.TabIndex = 9;
            comboBox2.Text = "Marital Status";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Tahoma", 11F);
            comboBox1.ForeColor = SystemColors.WindowFrame;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Male", "Female" });
            comboBox1.Location = new Point(128, 97);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(100, 26);
            comboBox1.TabIndex = 8;
            comboBox1.Text = "Gender";
            // 
            // panel2
            // 
            panel2.Controls.Add(textBox9);
            panel2.Controls.Add(comboBox6);
            panel2.Controls.Add(comboBox5);
            panel2.Controls.Add(textBox8);
            panel2.Controls.Add(comboBox4);
            panel2.Controls.Add(textBox7);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(12, 240);
            panel2.Name = "panel2";
            panel2.Size = new Size(368, 193);
            panel2.TabIndex = 9;
            // 
            // textBox9
            // 
            textBox9.BorderStyle = BorderStyle.FixedSingle;
            textBox9.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox9.Location = new Point(180, 156);
            textBox9.Name = "textBox9";
            textBox9.PlaceholderText = "Employer Contact Details";
            textBox9.Size = new Size(184, 27);
            textBox9.TabIndex = 13;
            // 
            // comboBox6
            // 
            comboBox6.Font = new Font("Tahoma", 11F);
            comboBox6.ForeColor = SystemColors.WindowFrame;
            comboBox6.FormattingEnabled = true;
            comboBox6.Items.AddRange(new object[] { "1", "2", "3", "4", "5+" });
            comboBox6.Location = new Point(3, 156);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(160, 26);
            comboBox6.TabIndex = 12;
            comboBox6.Text = "Years of Employment";
            // 
            // comboBox5
            // 
            comboBox5.Font = new Font("Tahoma", 11F);
            comboBox5.ForeColor = SystemColors.WindowFrame;
            comboBox5.FormattingEnabled = true;
            comboBox5.Items.AddRange(new object[] { "Php 10000 - php 20000", "Php 10000 - php 20000", "Php 10000 - php 20000", "Php 10000 - php 20000" });
            comboBox5.Location = new Point(177, 112);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(184, 26);
            comboBox5.TabIndex = 11;
            comboBox5.Text = "Annual Income";
            // 
            // textBox8
            // 
            textBox8.BorderStyle = BorderStyle.FixedSingle;
            textBox8.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox8.Location = new Point(0, 111);
            textBox8.Name = "textBox8";
            textBox8.PlaceholderText = "Job Title / Position";
            textBox8.Size = new Size(160, 27);
            textBox8.TabIndex = 10;
            // 
            // comboBox4
            // 
            comboBox4.Font = new Font("Tahoma", 11F);
            comboBox4.ForeColor = SystemColors.WindowFrame;
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "Full-time", "Part-time", "Self-employed", "Unemployed", "Retired" });
            comboBox4.Location = new Point(252, 64);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(112, 26);
            comboBox4.TabIndex = 9;
            comboBox4.Text = "Status";
            // 
            // textBox7
            // 
            textBox7.BorderStyle = BorderStyle.FixedSingle;
            textBox7.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox7.Location = new Point(3, 63);
            textBox7.Name = "textBox7";
            textBox7.PlaceholderText = "Employer Name";
            textBox7.Size = new Size(225, 27);
            textBox7.TabIndex = 6;
            // 
            // formNewApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1092, 609);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formNewApp";
            Text = "formNewApp";
            Load += formNewApp_Load;
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox lastname;
        private TextBox textBox1;
        private TextBox textBox2;
        private DateTimePicker dateTimePicker1;
        private FileSystemWatcher fileSystemWatcher1;
        private Panel panel1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private TextBox textBox3;
        private ComboBox comboBox3;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox6;
        private Panel panel2;
        private TextBox textBox9;
        private ComboBox comboBox6;
        private ComboBox comboBox5;
        private TextBox textBox8;
        private ComboBox comboBox4;
        private TextBox textBox7;
    }
}