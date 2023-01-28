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
    public partial class frm__introRound02 : Form
    {
        public frm__introRound02()
        {
            InitializeComponent();
        }

        private void lb_showRules02_Click(object sender, EventArgs e)
        {
            frm__round_02_showRules frm = new frm__round_02_showRules();
            frm.Show();
        }
    }
}
