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
    public partial class frm__round_01_showQuestions : Form
    {
        int score;
        int timeCountDown;
        string indexCauhoi;
        int indexQuestion;
        int countQuestion;
        string result;
        List<Question> listQuestions;
        public frm__round_01_showQuestions(string index)
        {
            InitializeComponent();
            score = 0;
            timeCountDown = 15;
            indexCauhoi = index;
            indexQuestion = 0;
            countQuestion = 0;
            listQuestions = new List<Question>();
            axWindowsMediaPlayer.Ctlcontrols.pause();
            loadQuestionsFormFile();
            showQuestion();
        }

        void loadQuestionsFormFile()
        {
            Question question = new Question();
            string path = "deThi/BangCanbovienchuc/round01_goi" + indexCauhoi +  ".txt";
            FileStream f = new FileStream(@path, FileMode.Open);
            StreamReader sr = new StreamReader(f);

            while ((question.QuestionTitle = sr.ReadLine()) != null)
            {
                question.AnswerA = sr.ReadLine();
                question.AnswerB = sr.ReadLine();
                question.AnswerC = sr.ReadLine();
                question.AnswerD = sr.ReadLine();
                question.Result = sr.ReadLine();

                countQuestion++;
                listQuestions.Add(question);
                question = new Question();
            }

            sr.Close();
        }

        void showQuestion()
        {
            lb_showQuestionTitle.Text = listQuestions[indexQuestion].QuestionTitle;
            lb_showAnswerA.Text = listQuestions[indexQuestion].AnswerA;
            lb_showAnswerB.Text = listQuestions[indexQuestion].AnswerB;
            lb_showAnswerC.Text = listQuestions[indexQuestion].AnswerC;
            lb_showAnswerD.Text = listQuestions[indexQuestion].AnswerD;
            result = listQuestions[indexQuestion].Result;
        }

        private void lb_showResult_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            axWindowsMediaPlayer.Ctlcontrols.pause();
            if (result == "A")
            {
                lb_showAnswerA.Font = new Font("Calibri", 16, FontStyle.Bold);
            }
            if (result == "B")
            {
                lb_showAnswerB.Font = new Font("Calibri", 16, FontStyle.Bold);
            }
            if (result == "C")
            {
                lb_showAnswerC.Font = new Font("Calibri", 16, FontStyle.Bold);
            }
            if (result == "D")
            {
                lb_showAnswerD.Font = new Font("Calibri", 16, FontStyle.Bold);
            }
        }

        private void btn_trueQuestion_Click(object sender, EventArgs e)
        {
            score += 10;
            lb_showScore.Text = score.ToString();
        }

        private void btn_falseQuestion_Click(object sender, EventArgs e)
        {
            score += 0;
            if (score == 0)
            {
                lb_showScore.Text = score.ToString() + "0";

            }
            if (score != 0)
            {
                lb_showScore.Text = score.ToString();
            }
        }

        void countDown()
        {
            timeCountDown--;
            string seconds_str = timeCountDown.ToString();

            if (timeCountDown < 10)
            {
                seconds_str = "0" + seconds_str;
            }

            if (timeCountDown >= 0)
            {
                lb_TimeCountDown.Text = seconds_str;
                
            }
            if (timeCountDown == 10)
            {
                axWindowsMediaPlayer.URL = "10-seconds-countdown.mp3";
                axWindowsMediaPlayer.Ctlcontrols.play();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            countDown();
        }

        private void btn_nextQuestion_Click(object sender, EventArgs e)
        {
            
            
            if (indexQuestion < listQuestions.Count - 1)
            {
                indexQuestion++;
                timeCountDown = 16;

                reChageFont();
                showQuestion();
                timer1.Enabled = true;
                countDown();
            }
        }
        void reChageFont()
        {
            lb_showAnswerA.Font = new Font("Calibri", 14, FontStyle.Regular);
            lb_showAnswerB.Font = new Font("Calibri", 14, FontStyle.Regular);
            lb_showAnswerC.Font = new Font("Calibri", 14, FontStyle.Regular);
            lb_showAnswerD.Font = new Font("Calibri", 14, FontStyle.Regular);
        }

        private void lb_showAnswerC_Click(object sender, EventArgs e)
        {

        }
    }
}
