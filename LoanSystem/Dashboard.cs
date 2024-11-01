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
        formLoanM? loanM;

        public Dashboard()
        {
            InitializeComponent();
            mdiProp();
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
                sidebar.Width -= 5;
                if (sidebar.Width <= 77)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();

                    pnDashboard.Width = sidebar.Width;
                    pnLoanM.Width = sidebar.Width;
                    pnCustomer.Width = sidebar.Width;
                    pnRepayment.Width = sidebar.Width;
                    pnReport.Width = sidebar.Width;
                    menuContainer.Width = sidebar.Width;

                }
            }
            else
            {
                sidebar.Width += 5;
                if (sidebar.Width >= 237)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();

                    pnDashboard.Width = sidebar.Width;
                    pnLoanM.Width = sidebar.Width;
                    pnCustomer.Width = sidebar.Width;
                    pnRepayment.Width = sidebar.Width;
                    pnReport.Width = sidebar.Width;
                    menuContainer.Width = sidebar.Width;
                }
            }
        }

        private void menu_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            if (dashb == null)
            {
                dashb = new formDashboard();
                dashb.FormClosed += Dashb_FormClosed;
                dashb.MdiParent = this;
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

        private void btnLoanM_Click(object sender, EventArgs e)
        {
            if (loanM == null)
            {
                loanM = new formLoanM();
                loanM.FormClosed += loanM_FormClosed;
                loanM.MdiParent = this;
                loanM.Dock = DockStyle.Fill;
                loanM.Show();

            }
            else
            {
                loanM.Activate();
            }
        }

        private void loanM_FormClosed(object? sender, FormClosedEventArgs e)
        {
            loanM = null;
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
    }
}
