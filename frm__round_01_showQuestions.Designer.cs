
namespace _60nam_vongBanket
{
    partial class frm__round_01_showQuestions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm__round_01_showQuestions));
            this.lb_showQuestionTitle = new System.Windows.Forms.Label();
            this.lb_showAnswerA = new System.Windows.Forms.Label();
            this.lb_showAnswerB = new System.Windows.Forms.Label();
            this.lb_showAnswerC = new System.Windows.Forms.Label();
            this.lb_showAnswerD = new System.Windows.Forms.Label();
            this.lb_showResult = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lb_TimeCountDown = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.btn_nextQuestion = new System.Windows.Forms.Button();
            this.lb_showScore = new System.Windows.Forms.Label();
            this.btn_trueQuestion = new System.Windows.Forms.Button();
            this.btn_falseQuestion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_showQuestionTitle
            // 
            this.lb_showQuestionTitle.BackColor = System.Drawing.Color.Transparent;
            this.lb_showQuestionTitle.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_showQuestionTitle.Location = new System.Drawing.Point(106, 337);
            this.lb_showQuestionTitle.Name = "lb_showQuestionTitle";
            this.lb_showQuestionTitle.Size = new System.Drawing.Size(1592, 157);
            this.lb_showQuestionTitle.TabIndex = 0;
            this.lb_showQuestionTitle.Text = "lb_showQuestionTitle";
            this.lb_showQuestionTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_showAnswerA
            // 
            this.lb_showAnswerA.BackColor = System.Drawing.Color.Transparent;
            this.lb_showAnswerA.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_showAnswerA.Location = new System.Drawing.Point(104, 655);
            this.lb_showAnswerA.Name = "lb_showAnswerA";
            this.lb_showAnswerA.Size = new System.Drawing.Size(1594, 65);
            this.lb_showAnswerA.TabIndex = 1;
            this.lb_showAnswerA.Text = "lb_showAnswerA";
            this.lb_showAnswerA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_showAnswerB
            // 
            this.lb_showAnswerB.BackColor = System.Drawing.Color.Transparent;
            this.lb_showAnswerB.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_showAnswerB.Location = new System.Drawing.Point(104, 736);
            this.lb_showAnswerB.Name = "lb_showAnswerB";
            this.lb_showAnswerB.Size = new System.Drawing.Size(1594, 65);
            this.lb_showAnswerB.TabIndex = 2;
            this.lb_showAnswerB.Text = "lb_showAnswerB";
            this.lb_showAnswerB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_showAnswerC
            // 
            this.lb_showAnswerC.BackColor = System.Drawing.Color.Transparent;
            this.lb_showAnswerC.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_showAnswerC.Location = new System.Drawing.Point(104, 816);
            this.lb_showAnswerC.Name = "lb_showAnswerC";
            this.lb_showAnswerC.Size = new System.Drawing.Size(1594, 65);
            this.lb_showAnswerC.TabIndex = 3;
            this.lb_showAnswerC.Text = "lb_showAnswerC";
            this.lb_showAnswerC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_showAnswerC.Click += new System.EventHandler(this.lb_showAnswerC_Click);
            // 
            // lb_showAnswerD
            // 
            this.lb_showAnswerD.BackColor = System.Drawing.Color.Transparent;
            this.lb_showAnswerD.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_showAnswerD.Location = new System.Drawing.Point(104, 896);
            this.lb_showAnswerD.Name = "lb_showAnswerD";
            this.lb_showAnswerD.Size = new System.Drawing.Size(1594, 65);
            this.lb_showAnswerD.TabIndex = 4;
            this.lb_showAnswerD.Text = "lb_showAnswerD";
            this.lb_showAnswerD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_showResult
            // 
            this.lb_showResult.BackColor = System.Drawing.Color.Transparent;
            this.lb_showResult.Location = new System.Drawing.Point(87, 571);
            this.lb_showResult.Name = "lb_showResult";
            this.lb_showResult.Size = new System.Drawing.Size(171, 57);
            this.lb_showResult.TabIndex = 5;
            this.lb_showResult.Click += new System.EventHandler(this.lb_showResult_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lb_TimeCountDown
            // 
            this.lb_TimeCountDown.BackColor = System.Drawing.Color.Transparent;
            this.lb_TimeCountDown.Font = new System.Drawing.Font("SVN-Androgyne", 64.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TimeCountDown.ForeColor = System.Drawing.Color.Gold;
            this.lb_TimeCountDown.Location = new System.Drawing.Point(1741, 381);
            this.lb_TimeCountDown.Name = "lb_TimeCountDown";
            this.lb_TimeCountDown.Size = new System.Drawing.Size(193, 171);
            this.lb_TimeCountDown.TabIndex = 6;
            this.lb_TimeCountDown.Text = "15";
            // 
            // axWindowsMediaPlayer
            // 
            this.axWindowsMediaPlayer.Enabled = true;
            this.axWindowsMediaPlayer.Location = new System.Drawing.Point(1, 3);
            this.axWindowsMediaPlayer.Name = "axWindowsMediaPlayer";
            this.axWindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer.OcxState")));
            this.axWindowsMediaPlayer.Size = new System.Drawing.Size(154, 89);
            this.axWindowsMediaPlayer.TabIndex = 7;
            this.axWindowsMediaPlayer.Visible = false;
            // 
            // btn_nextQuestion
            // 
            this.btn_nextQuestion.BackColor = System.Drawing.Color.Transparent;
            this.btn_nextQuestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nextQuestion.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_nextQuestion.FlatAppearance.BorderSize = 2;
            this.btn_nextQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nextQuestion.Font = new System.Drawing.Font("Calibri", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_nextQuestion.ForeColor = System.Drawing.Color.Snow;
            this.btn_nextQuestion.Location = new System.Drawing.Point(841, 1024);
            this.btn_nextQuestion.Name = "btn_nextQuestion";
            this.btn_nextQuestion.Size = new System.Drawing.Size(235, 44);
            this.btn_nextQuestion.TabIndex = 8;
            this.btn_nextQuestion.Text = "CÂU TIẾP THEO";
            this.btn_nextQuestion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_nextQuestion.UseVisualStyleBackColor = false;
            this.btn_nextQuestion.Click += new System.EventHandler(this.btn_nextQuestion_Click);
            // 
            // lb_showScore
            // 
            this.lb_showScore.AutoSize = true;
            this.lb_showScore.BackColor = System.Drawing.Color.Transparent;
            this.lb_showScore.Font = new System.Drawing.Font("SVN-Androgyne", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_showScore.ForeColor = System.Drawing.Color.OrangeRed;
            this.lb_showScore.Location = new System.Drawing.Point(1618, 541);
            this.lb_showScore.Name = "lb_showScore";
            this.lb_showScore.Size = new System.Drawing.Size(81, 62);
            this.lb_showScore.TabIndex = 9;
            this.lb_showScore.Text = "00";
            // 
            // btn_trueQuestion
            // 
            this.btn_trueQuestion.BackColor = System.Drawing.Color.Transparent;
            this.btn_trueQuestion.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_trueQuestion.FlatAppearance.BorderSize = 2;
            this.btn_trueQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_trueQuestion.Font = new System.Drawing.Font("Calibri", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_trueQuestion.ForeColor = System.Drawing.Color.Snow;
            this.btn_trueQuestion.Location = new System.Drawing.Point(670, 1024);
            this.btn_trueQuestion.Name = "btn_trueQuestion";
            this.btn_trueQuestion.Size = new System.Drawing.Size(156, 44);
            this.btn_trueQuestion.TabIndex = 10;
            this.btn_trueQuestion.Text = "ĐÚNG";
            this.btn_trueQuestion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_trueQuestion.UseVisualStyleBackColor = false;
            this.btn_trueQuestion.Click += new System.EventHandler(this.btn_trueQuestion_Click);
            // 
            // btn_falseQuestion
            // 
            this.btn_falseQuestion.BackColor = System.Drawing.Color.Transparent;
            this.btn_falseQuestion.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_falseQuestion.FlatAppearance.BorderSize = 2;
            this.btn_falseQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_falseQuestion.Font = new System.Drawing.Font("Calibri", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_falseQuestion.ForeColor = System.Drawing.Color.Snow;
            this.btn_falseQuestion.Location = new System.Drawing.Point(1091, 1024);
            this.btn_falseQuestion.Name = "btn_falseQuestion";
            this.btn_falseQuestion.Size = new System.Drawing.Size(112, 44);
            this.btn_falseQuestion.TabIndex = 11;
            this.btn_falseQuestion.Text = "SAI";
            this.btn_falseQuestion.UseVisualStyleBackColor = false;
            this.btn_falseQuestion.Click += new System.EventHandler(this.btn_falseQuestion_Click);
            // 
            // frm__round_01_showQuestions
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.btn_falseQuestion);
            this.Controls.Add(this.btn_trueQuestion);
            this.Controls.Add(this.lb_showScore);
            this.Controls.Add(this.btn_nextQuestion);
            this.Controls.Add(this.axWindowsMediaPlayer);
            this.Controls.Add(this.lb_TimeCountDown);
            this.Controls.Add(this.lb_showResult);
            this.Controls.Add(this.lb_showAnswerD);
            this.Controls.Add(this.lb_showAnswerC);
            this.Controls.Add(this.lb_showAnswerB);
            this.Controls.Add(this.lb_showAnswerA);
            this.Controls.Add(this.lb_showQuestionTitle);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm__round_01_showQuestions";
            this.Text = "frm__round_01_showQuestions";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_showQuestionTitle;
        private System.Windows.Forms.Label lb_showAnswerA;
        private System.Windows.Forms.Label lb_showAnswerB;
        private System.Windows.Forms.Label lb_showAnswerC;
        private System.Windows.Forms.Label lb_showAnswerD;
        private System.Windows.Forms.Label lb_showResult;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lb_TimeCountDown;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer;
        private System.Windows.Forms.Button btn_nextQuestion;
        private System.Windows.Forms.Label lb_showScore;
        private System.Windows.Forms.Button btn_trueQuestion;
        private System.Windows.Forms.Button btn_falseQuestion;
    }
}