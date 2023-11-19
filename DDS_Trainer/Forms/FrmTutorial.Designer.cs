namespace DDS_Trainer.Forms
{
    partial class FrmTutorial
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
            this.cntrlTutorial1 = new DDS_Trainer.Components.CntrlTutorial();
            this.SuspendLayout();
            // 
            // cntrlTutorial1
            // 
            this.cntrlTutorial1.BackColor = System.Drawing.Color.Black;
            this.cntrlTutorial1.Location = new System.Drawing.Point(0, 0);
            this.cntrlTutorial1.Name = "cntrlTutorial1";
            this.cntrlTutorial1.Size = new System.Drawing.Size(500, 300);
            this.cntrlTutorial1.TabIndex = 0;
            this.cntrlTutorial1.Load += new System.EventHandler(this.cntrlTutorial1_Load);
            // 
            // FrmTutorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Controls.Add(this.cntrlTutorial1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTutorial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTutorial";
            this.ResumeLayout(false);

        }

        #endregion

        private Components.CntrlTutorial cntrlTutorial1;
    }
}