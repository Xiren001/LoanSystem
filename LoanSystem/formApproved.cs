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
    public partial class formApproved : Form
    {
        public formApproved()
        {
            InitializeComponent();
        }

        private void formApproved_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}
