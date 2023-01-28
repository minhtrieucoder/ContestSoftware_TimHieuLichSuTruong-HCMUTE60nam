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
    public partial class frm__round_03_Questionnaire : Form
    {
        public frm__round_03_Questionnaire()
        {
            InitializeComponent();
        }

        private void lb__showRound03_question01_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            frm__round_03_showQuestions frm = new frm__round_03_showQuestions(00);
            frm.Show();
        }

        private void lb__showRound03_question02_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            frm__round_03_showQuestions frm = new frm__round_03_showQuestions(01);
            frm.Show();
        }

        private void lb__showRound03_question03_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            frm__round_03_showQuestions frm = new frm__round_03_showQuestions(02);
            frm.Show();
        }

        private void lb__showRound03_question04_Click(object sender, EventArgs e)
        {
            label4.Visible = false;
            frm__round_03_showQuestions frm = new frm__round_03_showQuestions(03);
            frm.Show();
        }

        private void lb__showRound03_question05_Click(object sender, EventArgs e)
        {
            label5.Visible = false;
            frm__round_03_showQuestions frm = new frm__round_03_showQuestions(04);
            frm.Show();
        }

        private void lb__showRound03_question06_Click(object sender, EventArgs e)
        {
            label6.Visible = false;
            frm__round_03_showQuestions frm = new frm__round_03_showQuestions(05);
            frm.Show();
        }

        private void lb__showRound03_question07_Click(object sender, EventArgs e)
        {
            label7.Visible = false;
            frm__round_03_showQuestions frm = new frm__round_03_showQuestions(06);
            frm.Show();
        }

        private void lb__showRound03_question08_Click(object sender, EventArgs e)
        {
            label8.Visible = false;
            frm__round_03_showQuestions frm = new frm__round_03_showQuestions(07);
            frm.Show();
        }

        private void lb__showRound03_question09_Click(object sender, EventArgs e)
        {
            label9.Visible = false;
            frm__round_03_showQuestions frm = new frm__round_03_showQuestions(08);
            frm.Show();
        }
    }
}
