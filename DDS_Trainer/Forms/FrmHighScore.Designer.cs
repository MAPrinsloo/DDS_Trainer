namespace DDS_Trainer.Forms
{
    partial class FrmHighScore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHighScore));
            this.cntrlHighScore1 = new DDS_Trainer.Components.CntrlHighScore();
            this.SuspendLayout();
            // 
            // cntrlHighScore1
            // 
            this.cntrlHighScore1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cntrlHighScore1.BackgroundImage")));
            this.cntrlHighScore1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cntrlHighScore1.Location = new System.Drawing.Point(0, 0);
            this.cntrlHighScore1.Name = "cntrlHighScore1";
            this.cntrlHighScore1.Size = new System.Drawing.Size(380, 366);
            this.cntrlHighScore1.TabIndex = 0;
            this.cntrlHighScore1.Load += new System.EventHandler(this.cntrlHighScore1_Load);
            // 
            // FrmHighScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 366);
            this.Controls.Add(this.cntrlHighScore1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmHighScore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmHighScore";
            this.ResumeLayout(false);

        }

        #endregion

        private Components.CntrlHighScore cntrlHighScore1;
    }
}