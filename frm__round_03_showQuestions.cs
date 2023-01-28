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
    public partial class frm__round_03_showQuestions : Form
    {
        int timeSuyNghi;
        int timeTraLoi;
        int timeBoSung;

        int indexQuestion;
        int countQuestion;
        List<Hint_Question> listQuestions;
        
        public frm__round_03_showQuestions(int index)
        {
            InitializeComponent();
            timeSuyNghi = 45;
            timeTraLoi = 10;
            timeBoSung = 20;

            indexQuestion = index;
            countQuestion = 0;
            listQuestions = new List<Hint_Question>();
            tm_traLoi.Enabled = false;
            tm_boSung.Enabled = false;
            loadQuestionsFormFile();
            showQuestion();
        }
        void loadQuestionsFormFile()
        {
            Hint_Question question = new Hint_Question();
            string path = "deThi/BangCanbovienchuc/Round_04_Questions.txt";
            FileStream f = new FileStream(@path, FileMode.Open);
            StreamReader sr = new StreamReader(f);

            while ((question.Question = sr.ReadLine()) != null)
            {
                question.Hint01 = sr.ReadLine();
                question.Hint02 = sr.ReadLine();
                question.Hint03 = sr.ReadLine();
                question.Result = sr.ReadLine();

                countQuestion++;
                listQuestions.Add(question);
                question = new Hint_Question();
            }

            sr.Close();
        }

        void showQuestion()
        {
            lb_Question.Text = listQuestions[indexQuestion].Question;
            lb_Hint01.Text = listQuestions[indexQuestion].Hint01;
            lb_Hint02.Text = listQuestions[indexQuestion].Hint02;
            lb_Hint03.Text = listQuestions[indexQuestion].Hint03;
            lb_Result.Text = listQuestions[indexQuestion].Result;
        }

        public string countDown (int thoiGian)
        {
            string seconds_str = thoiGian.ToString();
            if (thoiGian == 44)
            {
                lb_Hint01.Visible = true;
            }
            else if (thoiGian == 30)
            {
                lb_Hint02.Visible = true;
            }
            else if (thoiGian == 15)
            {
                lb_Hint03.Visible = true;
            }

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

        private void tm_suyNghi_Tick(object sender, EventArgs e)
        {
            timeSuyNghi--;
            lb_clockSuyNghi.Text = countDown(timeSuyNghi);
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

        private void frm__round_03_showQuestions_Load(object sender, EventArgs e)
        {

        }

        private void lb_traLoi_Click(object sender, EventArgs e)
        {
            tm_suyNghi.Enabled = false;
            tm_boSung.Enabled = false;
            tm_traLoi.Enabled = true;
        }

        private void lb_traLoi_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void lb_boSung_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_DoubleClick(object sender, EventArgs e)
        {
            lb_Result.Visible = true;
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            tm_suyNghi.Enabled = false;
            tm_boSung.Enabled = false;
            tm_traLoi.Enabled = false;
        }

        private void btn_continue_Click(object sender, EventArgs e)
        {
            tm_boSung.Enabled = false;
            tm_traLoi.Enabled = false;
            tm_suyNghi.Enabled = true;
            timeTraLoi = 10;
            lb_clockTraLoi.Text = "10";
        }

        private void lb_boSung_Click_1(object sender, EventArgs e)
        {
            tm_suyNghi.Enabled = false;
            tm_traLoi.Enabled = false;
            tm_boSung.Enabled = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
