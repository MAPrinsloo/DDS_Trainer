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
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(71, 128);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "button1";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lblQuestoin1
            // 
            this.lblQuestoin1.AutoSize = true;
            this.lblQuestoin1.Location = new System.Drawing.Point(65, 238);
            this.lblQuestoin1.Name = "lblQuestoin1";
            this.lblQuestoin1.Size = new System.Drawing.Size(35, 13);
            this.lblQuestoin1.TabIndex = 1;
            this.lblQuestoin1.Text = "label1";
            this.lblQuestoin1.Visible = false;
            this.lblQuestoin1.Click += new System.EventHandler(this.lblQuestoin1_Click);
            // 
            // lblQuestoin2
            // 
            this.lblQuestoin2.AutoSize = true;
            this.lblQuestoin2.Location = new System.Drawing.Point(65, 261);
            this.lblQuestoin2.Name = "lblQuestoin2";
            this.lblQuestoin2.Size = new System.Drawing.Size(35, 13);
            this.lblQuestoin2.TabIndex = 2;
            this.lblQuestoin2.Text = "label2";
            this.lblQuestoin2.Visible = false;
            this.lblQuestoin2.Click += new System.EventHandler(this.lblQuestoin2_Click);
            // 
            // lblQuestoin3
            // 
            this.lblQuestoin3.AutoSize = true;
            this.lblQuestoin3.Location = new System.Drawing.Point(65, 287);
            this.lblQuestoin3.Name = "lblQuestoin3";
            this.lblQuestoin3.Size = new System.Drawing.Size(35, 13);
            this.lblQuestoin3.TabIndex = 3;
            this.lblQuestoin3.Text = "label3";
            this.lblQuestoin3.Visible = false;
            this.lblQuestoin3.Click += new System.EventHandler(this.lblQuestoin3_Click);
            // 
            // lblQuestoin4
            // 
            this.lblQuestoin4.AutoSize = true;
            this.lblQuestoin4.Location = new System.Drawing.Point(65, 313);
            this.lblQuestoin4.Name = "lblQuestoin4";
            this.lblQuestoin4.Size = new System.Drawing.Size(35, 13);
            this.lblQuestoin4.TabIndex = 4;
            this.lblQuestoin4.Text = "label4";
            this.lblQuestoin4.Visible = false;
            this.lblQuestoin4.Click += new System.EventHandler(this.lblQuestoin4_Click);
            // 
            // lblQuestionHeader
            // 
            this.lblQuestionHeader.AutoSize = true;
            this.lblQuestionHeader.Location = new System.Drawing.Point(77, 63);
            this.lblQuestionHeader.Name = "lblQuestionHeader";
            this.lblQuestionHeader.Size = new System.Drawing.Size(35, 13);
            this.lblQuestionHeader.TabIndex = 5;
            this.lblQuestionHeader.Text = "label1";
            // 
            // TimeTimer
            // 
            this.TimeTimer.Interval = 1000;
            this.TimeTimer.Tick += new System.EventHandler(this.cntrlTimeTimerEvent);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(296, 35);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(35, 13);
            this.lblTime.TabIndex = 6;
            this.lblTime.Text = "label1";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(296, 63);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(35, 13);
            this.lblScore.TabIndex = 7;
            this.lblScore.Text = "label1";
            // 
            // lblAddedScore
            // 
            this.lblAddedScore.AutoSize = true;
            this.lblAddedScore.Location = new System.Drawing.Point(296, 87);
            this.lblAddedScore.Name = "lblAddedScore";
            this.lblAddedScore.Size = new System.Drawing.Size(34, 13);
            this.lblAddedScore.TabIndex = 8;
            this.lblAddedScore.Text = "+ 100";
            this.lblAddedScore.Visible = false;
            // 
            // CntrlFCNGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
    }
}
