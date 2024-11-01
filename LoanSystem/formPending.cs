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
    public partial class formPending : Form
    {
        public formPending()
        {
            InitializeComponent();
        }

        private void formPending_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}
