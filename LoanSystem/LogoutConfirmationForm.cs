using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoanSystem
{
    public partial class LogoutConfirmationForm : Form
    {
        public enum LogoutAction
        {
            LogoutAndClose,
            Logout,
            Cancel
        }

        public LogoutAction UserChoice { get; private set; }

        public LogoutConfirmationForm()
        {
            InitializeComponent();

            // Set default action to Cancel
            UserChoice = LogoutAction.Cancel;
        }

        private void btnLogoutAndClose_Click(object sender, EventArgs e)
        {
            UserChoice = LogoutAction.LogoutAndClose;
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            UserChoice = LogoutAction.Logout;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            UserChoice = LogoutAction.Cancel;
            this.Close();
        }
    }

}
