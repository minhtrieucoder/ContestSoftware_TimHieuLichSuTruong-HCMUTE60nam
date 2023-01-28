
namespace _60nam_vongBanket
{
    partial class frm__introRound01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm__introRound01));
            this.lb_showRules01 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_showRules01
            // 
            this.lb_showRules01.BackColor = System.Drawing.Color.Transparent;
            this.lb_showRules01.Location = new System.Drawing.Point(785, 370);
            this.lb_showRules01.Name = "lb_showRules01";
            this.lb_showRules01.Size = new System.Drawing.Size(270, 283);
            this.lb_showRules01.TabIndex = 0;
            this.lb_showRules01.Click += new System.EventHandler(this.lb_showRules01_Click);
            // 
            // frm__introRound01
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.lb_showRules01);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm__introRound01";
            this.Text = "frm__introRound01";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_showRules01;
    }
}