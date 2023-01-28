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
    public partial class frm__round02_showGoiCau : Form
    {
        int indexQuestion;
        public frm__round02_showGoiCau(int index)
        {
            InitializeComponent();
            indexQuestion = index;
        }

        private void lb_goi6_Click(object sender, EventArgs e)
        {
            frm__round_02_showQuestions frm = new frm__round_02_showQuestions(indexQuestion, 06);
            frm.Show();
        }

        private void lb_goi10_Click(object sender, EventArgs e)
        {
            frm__round_02_showQuestions frm = new frm__round_02_showQuestions(indexQuestion, 10);
            frm.Show();
        }
    }
}
