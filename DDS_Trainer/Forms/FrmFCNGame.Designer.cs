namespace DDS_Trainer.Forms
{
    partial class FrmFCNGame
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
            this.cntrlFCNGame1 = new DDS_Trainer.Components.CntrlFCNGame();
            this.SuspendLayout();
            // 
            // cntrlFCNGame1
            // 
            this.cntrlFCNGame1.Location = new System.Drawing.Point(12, 12);
            this.cntrlFCNGame1.Name = "cntrlFCNGame1";
            this.cntrlFCNGame1.Size = new System.Drawing.Size(356, 350);
            this.cntrlFCNGame1.TabIndex = 0;
            // 
            // FrmFCNGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 502);
            this.Controls.Add(this.cntrlFCNGame1);
            this.Name = "FrmFCNGame";
            this.Text = "FrmFCNGame";
            this.ResumeLayout(false);

        }

        #endregion

        private Components.CntrlFCNGame cntrlFCNGame1;
    }
}