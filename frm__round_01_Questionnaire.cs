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
    public partial class frm__round_01_Questionnaire : Form
    {
        public frm__round_01_Questionnaire()
        {
            InitializeComponent();
        }

        private void lb_showRound01_question01_Click(object sender, EventArgs e)
        {
            lb_textQuestion01.Visible = false;
            frm__round_01_showQuestions frm = new frm__round_01_showQuestions("01");
            frm.Show();
        }

        private void lb_showRound01_question02_Click(object sender, EventArgs e)
        {
            lb_textQuestion02.Visible = false;
            frm__round_01_showQuestions frm = new frm__round_01_showQuestions("02");
            frm.Show();
        }

        private void lb_showRound01_question03_Click(object sender, EventArgs e)
        {
            lb_textQuestion03.Visible = false;
            frm__round_01_showQuestions frm = new frm__round_01_showQuestions("03");
            frm.Show();
        }
    }
}
