namespace DDS_Trainer.Components
{
    partial class CntrlFCNGame
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
            this.components = new System.ComponentModel.Container();
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblQuestoin1 = new System.Windows.Forms.Label();
            this.lblQuestoin2 = new System.Windows.Forms.Label();
            this.lblQuestoin3 = new System.Windows.Forms.Label();
            this.lblQuestoin4 = new System.Windows.Forms.Label();
            this.lblQuestionHeader = new System.Windows.Forms.Label();
            this.TimeTimer = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblAddedScore = new System.Windows.Forms.Label();
            this.FlashTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.BackgroundImage = global::DDS_Trainer.Properties.Resources.PixStopWatch;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("Retro Computer", 11F);
            this.btnPlay.ForeColor = System.Drawing.Color.White;
            this.btnPlay.Location = new System.Drawing.Point(595, 3);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(91, 156);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "PLAY";
            this.btnPlay.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lblQuestoin1
            // 
            this.lblQuestoin1.AutoSize = true;
            this.lblQuestoin1.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestoin1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblQuestoin1.Font = new System.Drawing.Font("Retro Computer", 11.25F);
            this.lblQuestoin1.ForeColor = System.Drawing.Color.White;
            this.lblQuestoin1.Location = new System.Drawing.Point(243, 325);
            this.lblQuestoin1.Name = "lblQuestoin1";
            this.lblQuestoin1.Size = new System.Drawing.Size(98, 19);
            this.lblQuestoin1.TabIndex = 1;
            this.lblQuestoin1.Text = "Option 1";
            this.lblQuestoin1.Visible = false;
            this.lblQuestoin1.Click += new System.EventHandler(this.lblQuestoin1_Click);
            // 
            // lblQuestoin2
            // 
            this.lblQuestoin2.AutoSize = true;
            this.lblQuestoin2.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestoin2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblQuestoin2.Font = new System.Drawing.Font("Retro Computer", 11.25F);
            this.lblQuestoin2.ForeColor = System.Drawing.Color.White;
            this.lblQuestoin2.Location = new System.Drawing.Point(243, 361);
            this.lblQuestoin2.Name = "lblQuestoin2";
            this.lblQuestoin2.Size = new System.Drawing.Size(105, 19);
            this.lblQuestoin2.TabIndex = 2;
            this.lblQuestoin2.Text = "Option 2";
            this.lblQuestoin2.Visible = false;
            this.lblQuestoin2.Click += new System.EventHandler(this.lblQuestoin2_Click);
            // 
            // lblQuestoin3
            // 
            this.lblQuestoin3.AutoSize = true;
            this.lblQuestoin3.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestoin3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblQuestoin3.Font = new System.Drawing.Font("Retro Computer", 11.25F);
            this.lblQuestoin3.ForeColor = System.Drawing.Color.White;
            this.lblQuestoin3.Location = new System.Drawing.Point(243, 394);
            this.lblQuestoin3.Name = "lblQuestoin3";
            this.lblQuestoin3.Size = new System.Drawing.Size(105, 19);
            this.lblQuestoin3.TabIndex = 3;
            this.lblQuestoin3.Text = "Option 3";
            this.lblQuestoin3.Visible = false;
            this.lblQuestoin3.Click += new System.EventHandler(this.lblQuestoin3_Click);
            // 
            // lblQuestoin4
            // 
            this.lblQuestoin4.AutoSize = true;
            this.lblQuestoin4.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestoin4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblQuestoin4.Font = new System.Drawing.Font("Retro Computer", 11.25F);
            this.lblQuestoin4.ForeColor = System.Drawing.Color.White;
            this.lblQuestoin4.Location = new System.Drawing.Point(243, 426);
            this.lblQuestoin4.Name = "lblQuestoin4";
            this.lblQuestoin4.Size = new System.Drawing.Size(105, 19);
            this.lblQuestoin4.TabIndex = 4;
            this.lblQuestoin4.Text = "Option 4";
            this.lblQuestoin4.Visible = false;
            this.lblQuestoin4.Click += new System.EventHandler(this.lblQuestoin4_Click);
            // 
            // lblQuestionHeader
            // 
            this.lblQuestionHeader.AutoSize = true;
            this.lblQuestionHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestionHeader.Font = new System.Drawing.Font("Retro Computer", 11.25F);
            this.lblQuestionHeader.ForeColor = System.Drawing.Color.White;
            this.lblQuestionHeader.Location = new System.Drawing.Point(243, 198);
            this.lblQuestionHeader.Name = "lblQuestionHeader";
            this.lblQuestionHeader.Size = new System.Drawing.Size(293, 38);
            this.lblQuestionHeader.TabIndex = 5;
            this.lblQuestionHeader.Text = "Find the call number for:\r\n\r\n";
            this.lblQuestionHeader.Visible = false;
            // 
            // TimeTimer
            // 
            this.TimeTimer.Interval = 1000;
            this.TimeTimer.Tick += new System.EventHandler(this.cntrlTimeTimerEvent);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Retro Computer", 21.75F);
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(819, 73);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(235, 37);
            this.lblTime.TabIndex = 6;
            this.lblTime.Text = "Time: 00:00";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Retro Computer", 21.75F);
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(819, 119);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(179, 37);
            this.lblScore.TabIndex = 7;
            this.lblScore.Text = "Score: 0";
            // 
            // lblAddedScore
            // 
            this.lblAddedScore.AutoSize = true;
            this.lblAddedScore.BackColor = System.Drawing.Color.Transparent;
            this.lblAddedScore.Font = new System.Drawing.Font("Retro Computer", 21.75F);
            this.lblAddedScore.ForeColor = System.Drawing.Color.White;
            this.lblAddedScore.Location = new System.Drawing.Point(934, 156);
            this.lblAddedScore.Name = "lblAddedScore";
            this.lblAddedScore.Size = new System.Drawing.Size(103, 37);
            this.lblAddedScore.TabIndex = 8;
            this.lblAddedScore.Text = "+ 100";
            this.lblAddedScore.Visible = false;
            // 
            // FlashTimer
            // 
            this.FlashTimer.Interval = 300;
            this.FlashTimer.Tick += new System.EventHandler(this.cntrlFlashTimerEvent);
            // 
            // CntrlFCNGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DDS_Trainer.Properties.Resources.FNCGameBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lblAddedScore);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblQuestionHeader);
            this.Controls.Add(this.lblQuestoin4);
            this.Controls.Add(this.lblQuestoin3);
            this.Controls.Add(this.lblQuestoin2);
            this.Controls.Add(this.lblQuestoin1);
            this.Controls.Add(this.btnPlay);
            this.Name = "CntrlFCNGame";
            this.Size = new System.Drawing.Size(1284, 683);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblQuestoin1;
        private System.Windows.Forms.Label lblQuestoin2;
        private System.Windows.Forms.Label lblQuestoin3;
        private System.Windows.Forms.Label lblQuestoin4;
        private System.Windows.Forms.Label lblQuestionHeader;
        private System.Windows.Forms.Timer TimeTimer;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblAddedScore;
        private System.Windows.Forms.Timer FlashTimer;
    }
}
