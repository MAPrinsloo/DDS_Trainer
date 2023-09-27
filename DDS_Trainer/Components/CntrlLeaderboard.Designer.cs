namespace DDS_Trainer.Components
{
    partial class CntrlLeaderboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlLeaderboard = new System.Windows.Forms.Panel();
            this.txtLeaderboardTitle = new System.Windows.Forms.TextBox();
            this.rtLeaderboard = new System.Windows.Forms.RichTextBox();
            this.pnlLeaderboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeaderboard
            // 
            this.pnlLeaderboard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLeaderboard.BackColor = System.Drawing.Color.Black;
            this.pnlLeaderboard.Controls.Add(this.txtLeaderboardTitle);
            this.pnlLeaderboard.Controls.Add(this.rtLeaderboard);
            this.pnlLeaderboard.Location = new System.Drawing.Point(14, 27);
            this.pnlLeaderboard.Name = "pnlLeaderboard";
            this.pnlLeaderboard.Size = new System.Drawing.Size(272, 289);
            this.pnlLeaderboard.TabIndex = 0;
            // 
            // txtLeaderboardTitle
            // 
            this.txtLeaderboardTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLeaderboardTitle.BackColor = System.Drawing.Color.Black;
            this.txtLeaderboardTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLeaderboardTitle.Font = new System.Drawing.Font("Retro Computer", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLeaderboardTitle.ForeColor = System.Drawing.Color.SandyBrown;
            this.txtLeaderboardTitle.Location = new System.Drawing.Point(3, 3);
            this.txtLeaderboardTitle.Name = "txtLeaderboardTitle";
            this.txtLeaderboardTitle.ReadOnly = true;
            this.txtLeaderboardTitle.Size = new System.Drawing.Size(266, 28);
            this.txtLeaderboardTitle.TabIndex = 1;
            this.txtLeaderboardTitle.Text = "Leaderboard";
            this.txtLeaderboardTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rtLeaderboard
            // 
            this.rtLeaderboard.AcceptsTab = true;
            this.rtLeaderboard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtLeaderboard.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rtLeaderboard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtLeaderboard.Font = new System.Drawing.Font("Retro Computer", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtLeaderboard.ForeColor = System.Drawing.Color.White;
            this.rtLeaderboard.Location = new System.Drawing.Point(3, 37);
            this.rtLeaderboard.Name = "rtLeaderboard";
            this.rtLeaderboard.ReadOnly = true;
            this.rtLeaderboard.Size = new System.Drawing.Size(269, 249);
            this.rtLeaderboard.TabIndex = 2;
            this.rtLeaderboard.Text = "Rank\tScore\tName\n1\t\t1000\tMat\n2\t\t1000\tMat\n3\t\t1000\tMat\n4\t\t1000\tMat\n5\t\t1000\tMat\n6\t\t10" +
    "00\tMat\n7\t\t1000\tMat\n8\t\t1000\tMat\n9\t\t1000\tMat\n10\t\t100\t\tMat\n";
            // 
            // CntrlLeaderboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DDS_Trainer.Properties.Resources.PixWrinkledPaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.pnlLeaderboard);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(300, 350);
            this.Name = "CntrlLeaderboard";
            this.Size = new System.Drawing.Size(300, 330);
            this.pnlLeaderboard.ResumeLayout(false);
            this.pnlLeaderboard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeaderboard;
        private System.Windows.Forms.RichTextBox rtLeaderboard;
        private System.Windows.Forms.TextBox txtLeaderboardTitle;
    }
}
