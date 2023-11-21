namespace DDS_Trainer.Components
{
    partial class CntrlIAGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CntrlIAGame));
            this.lblQuestion1 = new System.Windows.Forms.Label();
            this.ilColorMarks = new System.Windows.Forms.ImageList(this.components);
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblQuestion2 = new System.Windows.Forms.Label();
            this.lblQuestion3 = new System.Windows.Forms.Label();
            this.lblQuestion4 = new System.Windows.Forms.Label();
            this.lblOption1 = new System.Windows.Forms.Label();
            this.lblOption2 = new System.Windows.Forms.Label();
            this.lblOption3 = new System.Windows.Forms.Label();
            this.lblOption4 = new System.Windows.Forms.Label();
            this.lblOption5 = new System.Windows.Forms.Label();
            this.lblOption6 = new System.Windows.Forms.Label();
            this.lblOption7 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblAddedScore = new System.Windows.Forms.Label();
            this.TimeTimer = new System.Windows.Forms.Timer(this.components);
            this.ilMarkers = new System.Windows.Forms.ImageList(this.components);
            this.btnMarker = new System.Windows.Forms.Button();
            this.lblTitleQuestions = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAddedTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblQuestion1
            // 
            this.lblQuestion1.AutoSize = true;
            this.lblQuestion1.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestion1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblQuestion1.Font = new System.Drawing.Font("Retro Computer", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblQuestion1.ImageIndex = 1;
            this.lblQuestion1.ImageList = this.ilColorMarks;
            this.lblQuestion1.Location = new System.Drawing.Point(271, 220);
            this.lblQuestion1.Name = "lblQuestion1";
            this.lblQuestion1.Size = new System.Drawing.Size(124, 19);
            this.lblQuestion1.TabIndex = 1;
            this.lblQuestion1.Text = "Question 1";
            this.lblQuestion1.Visible = false;
            this.lblQuestion1.Click += new System.EventHandler(this.lblQuestion1_Click);
            // 
            // ilColorMarks
            // 
            this.ilColorMarks.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilColorMarks.ImageStream")));
            this.ilColorMarks.TransparentColor = System.Drawing.Color.Transparent;
            this.ilColorMarks.Images.SetKeyName(0, "pixEmptyMark.png");
            this.ilColorMarks.Images.SetKeyName(1, "pixRedMark.png");
            this.ilColorMarks.Images.SetKeyName(2, "pixBlueMark.png");
            this.ilColorMarks.Images.SetKeyName(3, "pixPurpleMark.png");
            this.ilColorMarks.Images.SetKeyName(4, "pixGreenMark.png");
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.BackgroundImage = global::DDS_Trainer.Properties.Resources.PixStopWatch;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("Retro Computer", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.White;
            this.btnPlay.Location = new System.Drawing.Point(595, 3);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(91, 156);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.Text = " PLAY\r\n";
            this.btnPlay.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPlay.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lblQuestion2
            // 
            this.lblQuestion2.AutoSize = true;
            this.lblQuestion2.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestion2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblQuestion2.Font = new System.Drawing.Font("Retro Computer", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblQuestion2.ImageIndex = 2;
            this.lblQuestion2.ImageList = this.ilColorMarks;
            this.lblQuestion2.Location = new System.Drawing.Point(271, 260);
            this.lblQuestion2.Name = "lblQuestion2";
            this.lblQuestion2.Size = new System.Drawing.Size(131, 19);
            this.lblQuestion2.TabIndex = 3;
            this.lblQuestion2.Text = "Question 2";
            this.lblQuestion2.Visible = false;
            this.lblQuestion2.Click += new System.EventHandler(this.lblQuestion2_Click);
            // 
            // lblQuestion3
            // 
            this.lblQuestion3.AutoSize = true;
            this.lblQuestion3.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestion3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblQuestion3.Font = new System.Drawing.Font("Retro Computer", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblQuestion3.ImageIndex = 3;
            this.lblQuestion3.ImageList = this.ilColorMarks;
            this.lblQuestion3.Location = new System.Drawing.Point(271, 300);
            this.lblQuestion3.Name = "lblQuestion3";
            this.lblQuestion3.Size = new System.Drawing.Size(131, 19);
            this.lblQuestion3.TabIndex = 4;
            this.lblQuestion3.Text = "Question 3";
            this.lblQuestion3.Visible = false;
            this.lblQuestion3.Click += new System.EventHandler(this.lblQuestion3_Click);
            // 
            // lblQuestion4
            // 
            this.lblQuestion4.AutoSize = true;
            this.lblQuestion4.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestion4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblQuestion4.Font = new System.Drawing.Font("Retro Computer", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblQuestion4.ImageIndex = 4;
            this.lblQuestion4.ImageList = this.ilColorMarks;
            this.lblQuestion4.Location = new System.Drawing.Point(271, 340);
            this.lblQuestion4.Name = "lblQuestion4";
            this.lblQuestion4.Size = new System.Drawing.Size(131, 19);
            this.lblQuestion4.TabIndex = 5;
            this.lblQuestion4.Text = "Question 4";
            this.lblQuestion4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblQuestion4.Visible = false;
            this.lblQuestion4.Click += new System.EventHandler(this.lblQuestion4_Click);
            // 
            // lblOption1
            // 
            this.lblOption1.AutoSize = true;
            this.lblOption1.BackColor = System.Drawing.Color.Transparent;
            this.lblOption1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblOption1.Font = new System.Drawing.Font("Retro Computer", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOption1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblOption1.ImageIndex = 0;
            this.lblOption1.ImageList = this.ilColorMarks;
            this.lblOption1.Location = new System.Drawing.Point(722, 220);
            this.lblOption1.Name = "lblOption1";
            this.lblOption1.Size = new System.Drawing.Size(98, 19);
            this.lblOption1.TabIndex = 6;
            this.lblOption1.Text = "Option 1";
            this.lblOption1.Visible = false;
            this.lblOption1.Click += new System.EventHandler(this.lblOption1_Click);
            // 
            // lblOption2
            // 
            this.lblOption2.AutoSize = true;
            this.lblOption2.BackColor = System.Drawing.Color.Transparent;
            this.lblOption2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblOption2.Font = new System.Drawing.Font("Retro Computer", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOption2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblOption2.ImageIndex = 0;
            this.lblOption2.ImageList = this.ilColorMarks;
            this.lblOption2.Location = new System.Drawing.Point(722, 260);
            this.lblOption2.Name = "lblOption2";
            this.lblOption2.Size = new System.Drawing.Size(105, 19);
            this.lblOption2.TabIndex = 7;
            this.lblOption2.Text = "Option 2";
            this.lblOption2.Visible = false;
            this.lblOption2.Click += new System.EventHandler(this.lblOption2_Click);
            // 
            // lblOption3
            // 
            this.lblOption3.AutoSize = true;
            this.lblOption3.BackColor = System.Drawing.Color.Transparent;
            this.lblOption3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblOption3.Font = new System.Drawing.Font("Retro Computer", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOption3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblOption3.ImageIndex = 0;
            this.lblOption3.ImageList = this.ilColorMarks;
            this.lblOption3.Location = new System.Drawing.Point(722, 300);
            this.lblOption3.Name = "lblOption3";
            this.lblOption3.Size = new System.Drawing.Size(105, 19);
            this.lblOption3.TabIndex = 8;
            this.lblOption3.Text = "Option 3";
            this.lblOption3.Visible = false;
            this.lblOption3.Click += new System.EventHandler(this.lblOption3_Click);
            // 
            // lblOption4
            // 
            this.lblOption4.AutoSize = true;
            this.lblOption4.BackColor = System.Drawing.Color.Transparent;
            this.lblOption4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblOption4.Font = new System.Drawing.Font("Retro Computer", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOption4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblOption4.ImageIndex = 0;
            this.lblOption4.ImageList = this.ilColorMarks;
            this.lblOption4.Location = new System.Drawing.Point(722, 340);
            this.lblOption4.Name = "lblOption4";
            this.lblOption4.Size = new System.Drawing.Size(105, 19);
            this.lblOption4.TabIndex = 9;
            this.lblOption4.Text = "Option 4";
            this.lblOption4.Visible = false;
            this.lblOption4.Click += new System.EventHandler(this.lblOption4_Click);
            // 
            // lblOption5
            // 
            this.lblOption5.AutoSize = true;
            this.lblOption5.BackColor = System.Drawing.Color.Transparent;
            this.lblOption5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblOption5.Font = new System.Drawing.Font("Retro Computer", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOption5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblOption5.ImageIndex = 0;
            this.lblOption5.ImageList = this.ilColorMarks;
            this.lblOption5.Location = new System.Drawing.Point(722, 380);
            this.lblOption5.Name = "lblOption5";
            this.lblOption5.Size = new System.Drawing.Size(105, 19);
            this.lblOption5.TabIndex = 10;
            this.lblOption5.Text = "Option 5";
            this.lblOption5.Visible = false;
            this.lblOption5.Click += new System.EventHandler(this.lblOption5_Click);
            // 
            // lblOption6
            // 
            this.lblOption6.AutoSize = true;
            this.lblOption6.BackColor = System.Drawing.Color.Transparent;
            this.lblOption6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblOption6.Font = new System.Drawing.Font("Retro Computer", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOption6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblOption6.ImageIndex = 0;
            this.lblOption6.ImageList = this.ilColorMarks;
            this.lblOption6.Location = new System.Drawing.Point(722, 420);
            this.lblOption6.Name = "lblOption6";
            this.lblOption6.Size = new System.Drawing.Size(105, 19);
            this.lblOption6.TabIndex = 11;
            this.lblOption6.Text = "Option 6";
            this.lblOption6.Visible = false;
            this.lblOption6.Click += new System.EventHandler(this.lblOption6_Click);
            // 
            // lblOption7
            // 
            this.lblOption7.AutoSize = true;
            this.lblOption7.BackColor = System.Drawing.Color.Transparent;
            this.lblOption7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblOption7.Font = new System.Drawing.Font("Retro Computer", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOption7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblOption7.ImageIndex = 0;
            this.lblOption7.ImageList = this.ilColorMarks;
            this.lblOption7.Location = new System.Drawing.Point(722, 460);
            this.lblOption7.Name = "lblOption7";
            this.lblOption7.Size = new System.Drawing.Size(105, 19);
            this.lblOption7.TabIndex = 12;
            this.lblOption7.Text = "Option 7";
            this.lblOption7.Visible = false;
            this.lblOption7.Click += new System.EventHandler(this.lblOption7_Click);
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Retro Computer", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(1049, 3);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(235, 37);
            this.lblTime.TabIndex = 13;
            this.lblTime.Text = "Time: 00:00";
            // 
            // lblScore
            // 
            this.lblScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Retro Computer", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(1049, 77);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(179, 37);
            this.lblScore.TabIndex = 14;
            this.lblScore.Text = "Score: 0";
            // 
            // lblAddedScore
            // 
            this.lblAddedScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAddedScore.AutoSize = true;
            this.lblAddedScore.BackColor = System.Drawing.Color.Transparent;
            this.lblAddedScore.Font = new System.Drawing.Font("Retro Computer", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddedScore.ForeColor = System.Drawing.Color.White;
            this.lblAddedScore.Location = new System.Drawing.Point(1174, 114);
            this.lblAddedScore.Name = "lblAddedScore";
            this.lblAddedScore.Size = new System.Drawing.Size(93, 37);
            this.lblAddedScore.TabIndex = 15;
            this.lblAddedScore.Text = "+100";
            this.lblAddedScore.Visible = false;
            // 
            // TimeTimer
            // 
            this.TimeTimer.Interval = 1000;
            this.TimeTimer.Tick += new System.EventHandler(this.cntrlTimeTimerEvent);
            // 
            // ilMarkers
            // 
            this.ilMarkers.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilMarkers.ImageStream")));
            this.ilMarkers.TransparentColor = System.Drawing.Color.Transparent;
            this.ilMarkers.Images.SetKeyName(0, "pixMarker.png");
            this.ilMarkers.Images.SetKeyName(1, "pixMarkerRed.png");
            this.ilMarkers.Images.SetKeyName(2, "pixMarkerBlue.png");
            this.ilMarkers.Images.SetKeyName(3, "pixMarkerPurple.png");
            this.ilMarkers.Images.SetKeyName(4, "pixMarkerGreen.png");
            // 
            // btnMarker
            // 
            this.btnMarker.BackColor = System.Drawing.Color.Transparent;
            this.btnMarker.FlatAppearance.BorderSize = 0;
            this.btnMarker.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMarker.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMarker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarker.ImageIndex = 0;
            this.btnMarker.ImageList = this.ilMarkers;
            this.btnMarker.Location = new System.Drawing.Point(375, 379);
            this.btnMarker.Name = "btnMarker";
            this.btnMarker.Size = new System.Drawing.Size(250, 250);
            this.btnMarker.TabIndex = 16;
            this.btnMarker.UseVisualStyleBackColor = false;
            this.btnMarker.Click += new System.EventHandler(this.btnMarker_Click);
            // 
            // lblTitleQuestions
            // 
            this.lblTitleQuestions.AutoSize = true;
            this.lblTitleQuestions.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleQuestions.Font = new System.Drawing.Font("Retro Computer", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleQuestions.Location = new System.Drawing.Point(243, 135);
            this.lblTitleQuestions.Name = "lblTitleQuestions";
            this.lblTitleQuestions.Size = new System.Drawing.Size(346, 35);
            this.lblTitleQuestions.TabIndex = 17;
            this.lblTitleQuestions.Text = "Match Questions";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Retro Computer", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(720, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 35);
            this.label1.TabIndex = 18;
            this.label1.Text = "To Answers";
            // 
            // lblAddedTime
            // 
            this.lblAddedTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAddedTime.AutoSize = true;
            this.lblAddedTime.BackColor = System.Drawing.Color.Transparent;
            this.lblAddedTime.Font = new System.Drawing.Font("Retro Computer", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddedTime.ForeColor = System.Drawing.Color.White;
            this.lblAddedTime.Location = new System.Drawing.Point(1212, 40);
            this.lblAddedTime.Name = "lblAddedTime";
            this.lblAddedTime.Size = new System.Drawing.Size(69, 37);
            this.lblAddedTime.TabIndex = 19;
            this.lblAddedTime.Text = "+10";
            this.lblAddedTime.Visible = false;
            // 
            // CntrlIAGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::DDS_Trainer.Properties.Resources.IAGameBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lblAddedTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitleQuestions);
            this.Controls.Add(this.btnMarker);
            this.Controls.Add(this.lblAddedScore);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblQuestion4);
            this.Controls.Add(this.lblQuestion3);
            this.Controls.Add(this.lblQuestion2);
            this.Controls.Add(this.lblQuestion1);
            this.Controls.Add(this.lblOption7);
            this.Controls.Add(this.lblOption6);
            this.Controls.Add(this.lblOption5);
            this.Controls.Add(this.lblOption4);
            this.Controls.Add(this.lblOption3);
            this.Controls.Add(this.lblOption2);
            this.Controls.Add(this.lblOption1);
            this.Controls.Add(this.btnPlay);
            this.DoubleBuffered = true;
            this.Name = "CntrlIAGame";
            this.Size = new System.Drawing.Size(1284, 683);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblQuestion1;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblQuestion2;
        private System.Windows.Forms.Label lblQuestion3;
        private System.Windows.Forms.Label lblQuestion4;
        private System.Windows.Forms.Label lblOption1;
        private System.Windows.Forms.Label lblOption2;
        private System.Windows.Forms.Label lblOption3;
        private System.Windows.Forms.Label lblOption4;
        private System.Windows.Forms.Label lblOption5;
        private System.Windows.Forms.Label lblOption6;
        private System.Windows.Forms.Label lblOption7;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblAddedScore;
        private System.Windows.Forms.Timer TimeTimer;
        private System.Windows.Forms.ImageList ilColorMarks;
        private System.Windows.Forms.ImageList ilMarkers;
        private System.Windows.Forms.Button btnMarker;
        private System.Windows.Forms.Label lblTitleQuestions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAddedTime;
    }
}
