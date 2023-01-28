using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // su dung de nhap xuat file

namespace _60nam_vongBanket
{
    public partial class frm__round_02_showQuestions : Form
    {
        int timeTraLoi;
        int timeBoSung;

        int indexQuestion;
        int indexGoiCau;
        int countQuestion;
        List<QuestionTwo> listQuestions;
        public frm__round_02_showQuestions(int index, int goiCau)
        {
            InitializeComponent();
            timeTraLoi = 20;
            timeBoSung = 15;

            indexQuestion = index;
            indexGoiCau = goiCau;
            countQuestion = 0;
            listQuestions = new List<QuestionTwo>();
            tm_traLoi.Enabled = false;
            tm_boSung.Enabled = false;
            loadQuestionsFormFile();
            showQuestion();
        }

        void loadQuestionsFormFile()
        {
            QuestionTwo question = new QuestionTwo();
            string path = "deThi/BangCanbovienchuc/round_02/goi_" + indexGoiCau.ToString() + ".txt";
            FileStream f = new FileStream(@path, FileMode.Open);
            StreamReader sr = new StreamReader(f);

            while ((question.QuestionTitle = sr.ReadLine()) != null)
            {
                question.Result = sr.ReadLine();

                countQuestion++;
                listQuestions.Add(question);
                question = new QuestionTwo();
            }

            sr.Close();
        }

        void showQuestion()
        {
            lb_showQuestion.Text = listQuestions[indexQuestion].QuestionTitle;
            lb_showResult.Text = listQuestions[indexQuestion].Result;
        }
        public string countDown(int thoiGian)
        {
            string seconds_str = thoiGian.ToString();
            if (thoiGian < 10)
            {
                seconds_str = "0" + seconds_str;
            }

            if (thoiGian >= 0)
            {
                return seconds_str;

            }

            return "00";
        }

        private void tm_traLoi_Tick(object sender, EventArgs e)
        {
            timeTraLoi--;
            lb_clockTraLoi.Text = countDown(timeTraLoi);
        }

        private void tm_boSung_Tick(object sender, EventArgs e)
        {
            timeBoSung--;
            lb_clockBoSung.Text = countDown(timeBoSung);
        }

        private void lb_traLoi_Click(object sender, EventArgs e)
        {
            tm_boSung.Enabled = false;
            tm_traLoi.Enabled = true;
        }

        private void lb_boSung_Click(object sender, EventArgs e)
        {
            tm_traLoi.Enabled = false;
            tm_boSung.Enabled = true;
        }

        private void btn_traLoi_Click(object sender, EventArgs e)
        {
            tm_boSung.Enabled = false;
            tm_traLoi.Enabled = true;
        }

        private void btn_boSung_Click(object sender, EventArgs e)
        {
            tm_traLoi.Enabled = false;
            tm_boSung.Enabled = true;
        }

        private void label5_DoubleClick(object sender, EventArgs e)
        {
            lb_showResult.Visible = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
