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
    public partial class frm__Control : Form
    {
        public frm__Control()
        {
            InitializeComponent();
        }

        private void lb__showForm_intro01_Click(object sender, EventArgs e)
        {
            frm__introRound01 frm = new frm__introRound01();
            frm.Show();
        }

        private void lb__showForm_intro02_Click(object sender, EventArgs e)
        {
            frm__introRound02 frm = new frm__introRound02();
            frm.Show();
        }

        private void lb__showForm_intro03_Click(object sender, EventArgs e)
        {
            frm__introRound03 frm = new frm__introRound03();
            frm.Show();
        }
    }
}
