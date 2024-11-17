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
    public partial class formNewApp : Form
    {
        public formNewApp()
        {
            InitializeComponent();
        }

        private void formNewApp_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void newAppBtn_Click(object sender, EventArgs e)
        {
            newAppCreate newAppForm = new newAppCreate();
            newAppForm.MdiParent = this.MdiParent;
            newAppForm.Dock = DockStyle.Fill;
            newAppForm.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
