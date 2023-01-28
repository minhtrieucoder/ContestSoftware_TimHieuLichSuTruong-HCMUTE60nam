
namespace _60nam_vongBanket
{
    partial class frm__Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm__Main));
            this.lb_showFormControl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_showFormControl
            // 
            this.lb_showFormControl.BackColor = System.Drawing.Color.Transparent;
            this.lb_showFormControl.Font = new System.Drawing.Font("Calibri", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_showFormControl.ForeColor = System.Drawing.Color.White;
            this.lb_showFormControl.Location = new System.Drawing.Point(825, 1002);
            this.lb_showFormControl.Name = "lb_showFormControl";
            this.lb_showFormControl.Size = new System.Drawing.Size(271, 76);
            this.lb_showFormControl.TabIndex = 0;
            this.lb_showFormControl.Text = "BẮT ĐẦU";
            this.lb_showFormControl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_showFormControl.Click += new System.EventHandler(this.lb_showFormControl_Click);
            // 
            // frm__Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.lb_showFormControl);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm__Main";
            this.Text = "frm__Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_showFormControl;
    }
}