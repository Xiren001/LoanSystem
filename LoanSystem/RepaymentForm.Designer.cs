namespace LoanSystem
{
    partial class RepaymentForm
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
            txtRepaymentAmount = new TextBox();
            label1 = new Label();
            btnConfirmRepayment = new Button();
            SuspendLayout();
            // 
            // txtRepaymentAmount
            // 
            txtRepaymentAmount.BackColor = Color.White;
            txtRepaymentAmount.BorderStyle = BorderStyle.FixedSingle;
            txtRepaymentAmount.Font = new Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtRepaymentAmount.Location = new Point(12, 43);
            txtRepaymentAmount.Multiline = true;
            txtRepaymentAmount.Name = "txtRepaymentAmount";
            txtRepaymentAmount.Size = new Size(310, 50);
            txtRepaymentAmount.TabIndex = 24;
            txtRepaymentAmount.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(196, 25);
            label1.TabIndex = 25;
            label1.Text = "Enter the Amount";
            // 
            // btnConfirmRepayment
            // 
            btnConfirmRepayment.BackColor = Color.FromArgb(255, 255, 128);
            btnConfirmRepayment.FlatStyle = FlatStyle.Flat;
            btnConfirmRepayment.ForeColor = Color.Black;
            btnConfirmRepayment.Location = new Point(81, 108);
            btnConfirmRepayment.Name = "btnConfirmRepayment";
            btnConfirmRepayment.Size = new Size(168, 38);
            btnConfirmRepayment.TabIndex = 26;
            btnConfirmRepayment.Text = "Pay";
            btnConfirmRepayment.UseVisualStyleBackColor = false;
            btnConfirmRepayment.Click += btnConfirmRepayment_Click_2;
            // 
            // RepaymentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(334, 158);
            Controls.Add(btnConfirmRepayment);
            Controls.Add(label1);
            Controls.Add(txtRepaymentAmount);
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "RepaymentForm";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtRepaymentAmount;
        private Label label1;
        private Button btnConfirmRepayment;
    }
}