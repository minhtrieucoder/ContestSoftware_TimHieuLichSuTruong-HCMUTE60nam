using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _60nam_vongBanket
{
    public partial class frm__Main : Form
    {
        public frm__Main()
        {
            InitializeComponent();
        }

        private void lb_showFormControl_Click(object sender, EventArgs e)
        {
            frm__Control frm = new frm__Control();
            frm.Show();
        }
    }
}
