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
    public partial class Dashboard : Form
    {

        formDashboard? dashb;
        formNewApp? newApplication;
        formApproved? approved;
        formPending? pending;
        formCustomer? customer;
        formRepayment? rePayment;
        formReport? report;
        SignupForm? signup;

        public Dashboard()
        {
            InitializeComponent();
            mdiProp();
            SetRolePermissions();
        }

        private void SetRolePermissions()
        {
            // Set default text for btnEmplo
            btnEmplo.Text = "Employee";

            switch (CurrentUser.Usertype)
            {
                case UserType.LoanOfficer:
                    EnableLoanOfficerFeatures();
                    btnEmplo.Text = "Profile"; // Update text for LoanOfficer
                    break;
                case UserType.BranchManager:
                    EnableBranchManagerFeatures();
                    btnEmplo.Text = "Profile"; // Update text for BranchManager
                    break;
                case UserType.Accountant:
                    EnableAccountantFeatures();
                    btnEmplo.Text = "Profile"; // Update text for Accountant
                    break;
                case UserType.SystemAdministrator:
                    EnableSystemAdministratorFeatures();
                    // No change for System Administrator
                    break;
                default:
                    MessageBox.Show("Unauthorized access. Contact administrator.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                    break;
            }
        }


        private void EnableLoanOfficerFeatures()
        {
            btnNewApp.Enabled = true;
            btnPending.Enabled = true;
            btnAppRej.Enabled = true;
            btnRepayment.Enabled = true;
            btnCustomer.Enabled = true;

            // Disable unnecessary features
            btnEmplo.Enabled = true;
        }

        private void EnableBranchManagerFeatures()
        {
            btnNewApp.Enabled = true;
            btnPending.Enabled = true;
            btnAppRej.Enabled = true;
            btnCustomer.Enabled = true;

            // Disable unnecessary features
            btnRepayment.Enabled = false;
            btnEmplo.Enabled = true;
        }

        private void EnableAccountantFeatures()
        {
            btnRepayment.Enabled = true;

            // Disable unnecessary features
            btnNewApp.Enabled = false;
            btnPending.Enabled = false;
            btnAppRej.Enabled = false;
            btnEmplo.Enabled = true;
        }

        private void EnableSystemAdministratorFeatures()
        {
            // Full access
            btnCustomer.Enabled = false;
            btnNewApp.Enabled = true;
            btnPending.Enabled = true;
            btnAppRej.Enabled = true;
            btnRepayment.Enabled = true;
            btnCustomer.Enabled = true;
            btnEmplo.Enabled = true;
        }

        bool menuExpand = false;

        private void mdiProp()
        {
            this.SetBevel(false);
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(232, 234, 237);
        }

        private void menuTransition_Tick(object sender, EventArgs e)
        {

            if (menuExpand == false)
            {
                menuContainer.Height += 10;
                if (menuContainer.Height >= 219)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                menuContainer.Height -= 10;
                if (menuContainer.Height <= 53)
                {
                    menuTransition.Stop();
                    menuExpand = false;
                }
            }
        }

        private void loanApp_Click(object sender, EventArgs e)
        {
            menuTransition.Start();

        }

        bool sidebarExpand = true;

        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= 74)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();

                    pnDashboard.Width = sidebar.Width;
                    pnCustomer.Width = sidebar.Width;
                    pnRepayment.Width = sidebar.Width;
                    pnEmplo.Width = sidebar.Width;
                    menuContainer.Width = sidebar.Width;


                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= 237)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();

                    pnDashboard.Width = sidebar.Width;
                    pnCustomer.Width = sidebar.Width;
                    pnRepayment.Width = sidebar.Width;
                    pnEmplo.Width = sidebar.Width;
                    menuContainer.Width = sidebar.Width;
                }
            }
        }

        private void menu_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            formDashboard initialForm = new formDashboard();
            initialForm.MdiParent = this;
            initialForm.Dock = DockStyle.Fill;
            initialForm.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            if (dashb == null)
            {
                dashb = new formDashboard();
                dashb.FormClosed += Dashb_FormClosed;
                dashb.MdiParent = this;
                dashb.Dock = DockStyle.Fill;
                dashb.Show();

            }
            else
            {
                dashb.Activate();
            }
        }

        private void Dashb_FormClosed(object? sender, FormClosedEventArgs e)
        {
            dashb = null;
        }

        private void btnNewApp_Click(object sender, EventArgs e)
        {
            if (newApplication == null)
            {
                newApplication = new formNewApp();
                newApplication.FormClosed += newApplication_FormClosed;
                newApplication.MdiParent = this;
                newApplication.Dock = DockStyle.Fill;
                newApplication.Show();


            }
            else
            {
                newApplication.Activate();
            }
        }

        private void newApplication_FormClosed(object? sender, FormClosedEventArgs e)
        {
            newApplication = null;
        }

        private void btnPending_Click(object sender, EventArgs e)
        {
            if (pending == null)
            {
                pending = new formPending();
                pending.FormClosed += pending_FormClosed;
                pending.MdiParent = this;
                pending.Dock = DockStyle.Fill;
                pending.Show();

            }
            else
            {
                pending.Activate();
            }
        }

        private void pending_FormClosed(object? sender, FormClosedEventArgs e)
        {
            pending = null;
        }

        private void btnAppRej_Click(object sender, EventArgs e)
        {
            if (approved == null)
            {
                approved = new formApproved();
                approved.FormClosed += approved_FormClosed;
                approved.MdiParent = this;
                approved.Dock = DockStyle.Fill;
                approved.Show();

            }
            else
            {
                approved.Activate();
            }
        }

        private void approved_FormClosed(object? sender, FormClosedEventArgs e)
        {
            approved = null;
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            if (customer == null)
            {
                customer = new formCustomer();
                customer.FormClosed += customer_FormClosed;
                customer.MdiParent = this;
                customer.Dock = DockStyle.Fill;
                customer.Show();

            }
            else
            {
                customer.Activate();
            }
        }

        private void customer_FormClosed(object? sender, FormClosedEventArgs e)
        {
            customer = null;
        }

        private void btnRepayment_Click(object sender, EventArgs e)
        {
            if (rePayment == null)
            {
                rePayment = new formRepayment();
                rePayment.FormClosed += rePayment_FormClosed;
                rePayment.MdiParent = this;
                rePayment.Dock = DockStyle.Fill;
                rePayment.Show();

            }
            else
            {
                rePayment.Activate();
            }
        }

        private void rePayment_FormClosed(object? sender, FormClosedEventArgs e)
        {
            rePayment = null;
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (report == null)
            {
                report = new formReport();
                report.FormClosed += report_FormClosed;
                report.MdiParent = this;
                report.Dock = DockStyle.Fill;
                report.Show();

            }
            else
            {
                report.Activate();
            }
        }

        private void report_FormClosed(object? sender, FormClosedEventArgs e)
        {
            report = null;
        }

        private void btnEmplo_Click(object sender, EventArgs e)
        {

            if (signup == null)
            {
                signup = new SignupForm();
                signup.FormClosed += signup_FormClosed;
                signup.MdiParent = this;
                signup.Dock = DockStyle.Fill;
                signup.Show();

            }
            else
            {
                signup.Activate();
            }

        }

        private void signup_FormClosed(object? sender, FormClosedEventArgs e)
        {
            signup = null;
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

            // Show the custom logout confirmation dialog
            using (LogoutConfirmationForm logoutDialog = new LogoutConfirmationForm())
            {
                logoutDialog.ShowDialog();

                // Handle the user's choice
                switch (logoutDialog.UserChoice)
                {
                    case LogoutConfirmationForm.LogoutAction.LogoutAndClose:
                        Application.Exit();
                        break;

                    case LogoutConfirmationForm.LogoutAction.Logout:
                        // Show the login form
                        SignInForm loginForm = new SignInForm();
                        loginForm.Show();

                        // Close the current dashboard
                        this.Close();
                        break;

                    case LogoutConfirmationForm.LogoutAction.Cancel:
                    default:
                        // Do nothing, stay on the current form
                        break;
                }
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Show the custom logout confirmation dialog
            using (LogoutConfirmationForm logoutDialog = new LogoutConfirmationForm())
            {
                logoutDialog.ShowDialog();

                // Handle the user's choice
                switch (logoutDialog.UserChoice)
                {
                    case LogoutConfirmationForm.LogoutAction.LogoutAndClose:
                        Application.Exit();
                        break;

                    case LogoutConfirmationForm.LogoutAction.Logout:
                        // Show the login form
                        SignInForm loginForm = new SignInForm();
                        loginForm.Show();

                        // Close the current dashboard
                        this.Close();
                        break;

                    case LogoutConfirmationForm.LogoutAction.Cancel:
                    default:
                        // Do nothing, stay on the current form
                        break;
                }
            }
        }
    }
}
