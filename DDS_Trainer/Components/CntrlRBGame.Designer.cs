namespace DDS_Trainer.Components
{
    partial class CntrlRBGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CntrlRBGame));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.BookTimer = new System.Windows.Forms.Timer(this.components);
            this.imageListBooks = new System.Windows.Forms.ImageList(this.components);
            this.btnPlay = new System.Windows.Forms.Button();
            this.TimeTimer = new System.Windows.Forms.Timer(this.components);
            this.lblAddedScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Retro Computer", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(1046, 40);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(179, 37);
            this.lblScore.TabIndex = 3;
            this.lblScore.Text = "Score: 0";
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Retro Computer", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(1046, 3);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(235, 37);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "Time: 00:00";
            // 
            // BookTimer
            // 
            this.BookTimer.Enabled = true;
            this.BookTimer.Interval = 20;
            this.BookTimer.Tick += new System.EventHandler(this.CntrlBookTimerEvent);
            // 
            // imageListBooks
            // 
            this.imageListBooks.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListBooks.ImageStream")));
            this.imageListBooks.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListBooks.Images.SetKeyName(0, "PixBookBlue.png");
            this.imageListBooks.Images.SetKeyName(1, "PixBookDarkBlue.png");
            this.imageListBooks.Images.SetKeyName(2, "PixBookGreen.png");
            this.imageListBooks.Images.SetKeyName(3, "PixBookPurple.png");
            this.imageListBooks.Images.SetKeyName(4, "PixBookRed.png");
            this.imageListBooks.Images.SetKeyName(5, "PixBookYellow.png");
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
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = " PLAY\r\n";
            this.btnPlay.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPlay.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // TimeTimer
            // 
            this.TimeTimer.Enabled = true;
            this.TimeTimer.Interval = 1000;
            this.TimeTimer.Tick += new System.EventHandler(this.CntrlTimeTimerEvent);
            // 
            // lblAddedScore
            // 
            this.lblAddedScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAddedScore.AutoSize = true;
            this.lblAddedScore.BackColor = System.Drawing.Color.Transparent;
            this.lblAddedScore.Font = new System.Drawing.Font("Retro Computer", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddedScore.ForeColor = System.Drawing.Color.White;
            this.lblAddedScore.Location = new System.Drawing.Point(1174, 77);
            this.lblAddedScore.Name = "lblAddedScore";
            this.lblAddedScore.Size = new System.Drawing.Size(93, 37);
            this.lblAddedScore.TabIndex = 5;
            this.lblAddedScore.Text = "+100";
            this.lblAddedScore.Visible = false;
            // 
            // CntrlRBGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::DDS_Trainer.Properties.Resources.output_onlinepngtools__15_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lblAddedScore);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblScore);
            this.DoubleBuffered = true;
            this.Name = "CntrlRBGame";
            this.Size = new System.Drawing.Size(1284, 683);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormPaintEvent);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormMouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormMouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer BookTimer;
        private System.Windows.Forms.ImageList imageListBooks;
        private System.Windows.Forms.Timer TimeTimer;
        private System.Windows.Forms.Label lblAddedScore;
    }
}
