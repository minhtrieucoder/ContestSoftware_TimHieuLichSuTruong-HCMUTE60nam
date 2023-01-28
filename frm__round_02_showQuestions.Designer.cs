
namespace _60nam_vongBanket
{
    partial class frm__round_02_showQuestions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm__round_02_showQuestions));
            this.lb_showQuestion = new System.Windows.Forms.Label();
            this.lb_showResult = new System.Windows.Forms.Label();
            this.tm_traLoi = new System.Windows.Forms.Timer(this.components);
            this.tm_boSung = new System.Windows.Forms.Timer(this.components);
            this.lb_clockBoSung = new System.Windows.Forms.Label();
            this.lb_clockTraLoi = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lb_boSung = new System.Windows.Forms.Label();
            this.lb_traLoi = new System.Windows.Forms.Label();
            this.btn_boSung = new System.Windows.Forms.Button();
            this.btn_traLoi = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_showQuestion
            // 
            this.lb_showQuestion.BackColor = System.Drawing.Color.Transparent;
            this.lb_showQuestion.Font = new System.Drawing.Font("SVN-Androgyne", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_showQuestion.Location = new System.Drawing.Point(116, 390);
            this.lb_showQuestion.Name = "lb_showQuestion";
            this.lb_showQuestion.Size = new System.Drawing.Size(1093, 278);
            this.lb_showQuestion.TabIndex = 0;
            this.lb_showQuestion.Text = "lb_showQuestion";
            this.lb_showQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_showResult
            // 
            this.lb_showResult.BackColor = System.Drawing.Color.Transparent;
            this.lb_showResult.Font = new System.Drawing.Font("SVN-Androgyne", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_showResult.Location = new System.Drawing.Point(116, 781);
            this.lb_showResult.Name = "lb_showResult";
            this.lb_showResult.Size = new System.Drawing.Size(1093, 163);
            this.lb_showResult.TabIndex = 1;
            this.lb_showResult.Text = "lb_showResult";
            this.lb_showResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_showResult.Visible = false;
            // 
            // tm_traLoi
            // 
            this.tm_traLoi.Enabled = true;
            this.tm_traLoi.Interval = 1000;
            this.tm_traLoi.Tick += new System.EventHandler(this.tm_traLoi_Tick);
            // 
            // tm_boSung
            // 
            this.tm_boSung.Enabled = true;
            this.tm_boSung.Interval = 1000;
            this.tm_boSung.Tick += new System.EventHandler(this.tm_boSung_Tick);
            // 
            // lb_clockBoSung
            // 
            this.lb_clockBoSung.BackColor = System.Drawing.Color.Transparent;
            this.lb_clockBoSung.Font = new System.Drawing.Font("SVN-Androgyne", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_clockBoSung.ForeColor = System.Drawing.Color.OrangeRed;
            this.lb_clockBoSung.Location = new System.Drawing.Point(1353, 721);
            this.lb_clockBoSung.Name = "lb_clockBoSung";
            this.lb_clockBoSung.Size = new System.Drawing.Size(132, 95);
            this.lb_clockBoSung.TabIndex = 14;
            this.lb_clockBoSung.Text = "15";
            this.lb_clockBoSung.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_clockTraLoi
            // 
            this.lb_clockTraLoi.BackColor = System.Drawing.Color.Transparent;
            this.lb_clockTraLoi.Font = new System.Drawing.Font("SVN-Androgyne", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_clockTraLoi.ForeColor = System.Drawing.Color.OrangeRed;
            this.lb_clockTraLoi.Location = new System.Drawing.Point(1358, 490);
            this.lb_clockTraLoi.Name = "lb_clockTraLoi";
            this.lb_clockTraLoi.Size = new System.Drawing.Size(123, 95);
            this.lb_clockTraLoi.TabIndex = 13;
            this.lb_clockTraLoi.Text = "20";
            this.lb_clockTraLoi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            // 
            // lb_boSung
            // 
            this.lb_boSung.BackColor = System.Drawing.Color.Transparent;
            this.lb_boSung.Location = new System.Drawing.Point(1507, 726);
            this.lb_boSung.Name = "lb_boSung";
            this.lb_boSung.Size = new System.Drawing.Size(327, 97);
            this.lb_boSung.TabIndex = 19;
            this.lb_boSung.Click += new System.EventHandler(this.lb_boSung_Click);
            // 
            // lb_traLoi
            // 
            this.lb_traLoi.BackColor = System.Drawing.Color.Transparent;
            this.lb_traLoi.Location = new System.Drawing.Point(1507, 493);
            this.lb_traLoi.Name = "lb_traLoi";
            this.lb_traLoi.Size = new System.Drawing.Size(327, 107);
            this.lb_traLoi.TabIndex = 18;
            this.lb_traLoi.Click += new System.EventHandler(this.lb_traLoi_Click);
            // 
            // btn_boSung
            // 
            this.btn_boSung.BackColor = System.Drawing.Color.Transparent;
            this.btn_boSung.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_boSung.FlatAppearance.BorderSize = 2;
            this.btn_boSung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_boSung.Font = new System.Drawing.Font("Calibri", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_boSung.ForeColor = System.Drawing.Color.White;
            this.btn_boSung.Location = new System.Drawing.Point(1410, 1025);
            this.btn_boSung.Name = "btn_boSung";
            this.btn_boSung.Size = new System.Drawing.Size(126, 43);
            this.btn_boSung.TabIndex = 21;
            this.btn_boSung.Text = "BỔ SUNG";
            this.btn_boSung.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_boSung.UseVisualStyleBackColor = false;
            this.btn_boSung.Click += new System.EventHandler(this.btn_boSung_Click);
            // 
            // btn_traLoi
            // 
            this.btn_traLoi.BackColor = System.Drawing.Color.Transparent;
            this.btn_traLoi.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_traLoi.FlatAppearance.BorderSize = 2;
            this.btn_traLoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_traLoi.Font = new System.Drawing.Font("Calibri", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_traLoi.ForeColor = System.Drawing.Color.White;
            this.btn_traLoi.Location = new System.Drawing.Point(1265, 1025);
            this.btn_traLoi.Name = "btn_traLoi";
            this.btn_traLoi.Size = new System.Drawing.Size(130, 43);
            this.btn_traLoi.TabIndex = 20;
            this.btn_traLoi.Text = "TRẢ LỜI";
            this.btn_traLoi.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_traLoi.UseVisualStyleBackColor = false;
            this.btn_traLoi.Click += new System.EventHandler(this.btn_traLoi_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(85, 706);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 53);
            this.label5.TabIndex = 22;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            this.label5.DoubleClick += new System.EventHandler(this.label5_DoubleClick);
            // 
            // frm__round_02_showQuestions
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_boSung);
            this.Controls.Add(this.btn_traLoi);
            this.Controls.Add(this.lb_boSung);
            this.Controls.Add(this.lb_traLoi);
            this.Controls.Add(this.lb_clockBoSung);
            this.Controls.Add(this.lb_clockTraLoi);
            this.Controls.Add(this.lb_showResult);
            this.Controls.Add(this.lb_showQuestion);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm__round_02_showQuestions";
            this.Text = "frm__round_02_showQuestions";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_showQuestion;
        private System.Windows.Forms.Label lb_showResult;
        private System.Windows.Forms.Timer tm_traLoi;
        private System.Windows.Forms.Timer tm_boSung;
        private System.Windows.Forms.Label lb_clockBoSung;
        private System.Windows.Forms.Label lb_clockTraLoi;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lb_boSung;
        private System.Windows.Forms.Label lb_traLoi;
        private System.Windows.Forms.Button btn_boSung;
        private System.Windows.Forms.Button btn_traLoi;
        private System.Windows.Forms.Label label5;
    }
}