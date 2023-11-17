namespace DDS_Trainer.Forms
{
    partial class FrmMainMenu
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
        public void test() { }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainMenu));
            this.btnReplacingBooks = new System.Windows.Forms.Button();
            this.btnIdentifyingAreas = new System.Windows.Forms.Button();
            this.btnFindingCallNumb = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cntrlLeaderboard1 = new DDS_Trainer.Components.CntrlLeaderboard();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReplacingBooks
            // 
            this.btnReplacingBooks.BackColor = System.Drawing.Color.Transparent;
            this.btnReplacingBooks.BackgroundImage = global::DDS_Trainer.Properties.Resources.RBActivityIcon;
            this.btnReplacingBooks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReplacingBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReplacingBooks.FlatAppearance.BorderSize = 0;
            this.btnReplacingBooks.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnReplacingBooks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnReplacingBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReplacingBooks.Font = new System.Drawing.Font("Retro Computer", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReplacingBooks.Location = new System.Drawing.Point(3, 1);
            this.btnReplacingBooks.Name = "btnReplacingBooks";
            this.btnReplacingBooks.Size = new System.Drawing.Size(110, 161);
            this.btnReplacingBooks.TabIndex = 1;
            this.btnReplacingBooks.Text = "Replacing-Books.exe";
            this.btnReplacingBooks.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReplacingBooks.UseVisualStyleBackColor = false;
            this.btnReplacingBooks.Click += new System.EventHandler(this.btnReplacingBooks_Click);
            // 
            // btnIdentifyingAreas
            // 
            this.btnIdentifyingAreas.BackColor = System.Drawing.Color.Transparent;
            this.btnIdentifyingAreas.BackgroundImage = global::DDS_Trainer.Properties.Resources.IAActivityIcon;
            this.btnIdentifyingAreas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnIdentifyingAreas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIdentifyingAreas.FlatAppearance.BorderSize = 0;
            this.btnIdentifyingAreas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnIdentifyingAreas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnIdentifyingAreas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIdentifyingAreas.Font = new System.Drawing.Font("Retro Computer", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIdentifyingAreas.Location = new System.Drawing.Point(3, 168);
            this.btnIdentifyingAreas.Name = "btnIdentifyingAreas";
            this.btnIdentifyingAreas.Size = new System.Drawing.Size(120, 180);
            this.btnIdentifyingAreas.TabIndex = 2;
            this.btnIdentifyingAreas.Text = "Identifying-Areas.exe";
            this.btnIdentifyingAreas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIdentifyingAreas.UseVisualStyleBackColor = false;
            this.btnIdentifyingAreas.Click += new System.EventHandler(this.btnIdentifyingAreas_Click);
            // 
            // btnFindingCallNumb
            // 
            this.btnFindingCallNumb.BackColor = System.Drawing.Color.Transparent;
            this.btnFindingCallNumb.BackgroundImage = global::DDS_Trainer.Properties.Resources.FCNActivityIcon;
            this.btnFindingCallNumb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFindingCallNumb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFindingCallNumb.FlatAppearance.BorderSize = 0;
            this.btnFindingCallNumb.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnFindingCallNumb.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnFindingCallNumb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindingCallNumb.Font = new System.Drawing.Font("Retro Computer", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindingCallNumb.Location = new System.Drawing.Point(3, 354);
            this.btnFindingCallNumb.Name = "btnFindingCallNumb";
            this.btnFindingCallNumb.Size = new System.Drawing.Size(130, 161);
            this.btnFindingCallNumb.TabIndex = 3;
            this.btnFindingCallNumb.Text = "Finding-Call-Numbers.exe";
            this.btnFindingCallNumb.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFindingCallNumb.UseVisualStyleBackColor = false;
            this.btnFindingCallNumb.Click += new System.EventHandler(this.btnFindingCallNumb_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClose.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnClose.BackgroundImage = global::DDS_Trainer.Properties.Resources.CloseApp;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(3, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(57, 55);
            this.btnClose.TabIndex = 4;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Location = new System.Drawing.Point(0, 654);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1285, 66);
            this.panel1.TabIndex = 9;
            // 
            // cntrlLeaderboard1
            // 
            this.cntrlLeaderboard1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cntrlLeaderboard1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cntrlLeaderboard1.BackgroundImage")));
            this.cntrlLeaderboard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cntrlLeaderboard1.Location = new System.Drawing.Point(985, 248);
            this.cntrlLeaderboard1.MaximumSize = new System.Drawing.Size(300, 400);
            this.cntrlLeaderboard1.Name = "cntrlLeaderboard1";
            this.cntrlLeaderboard1.Size = new System.Drawing.Size(300, 400);
            this.cntrlLeaderboard1.TabIndex = 6;
            // 
            // FrmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::DDS_Trainer.Properties.Resources.pixelDesktop;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnIdentifyingAreas);
            this.Controls.Add(this.btnReplacingBooks);
            this.Controls.Add(this.btnFindingCallNumb);
            this.Controls.Add(this.cntrlLeaderboard1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMainMenu";
            this.Text = "FrmMainMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnReplacingBooks;
        private System.Windows.Forms.Button btnIdentifyingAreas;
        private System.Windows.Forms.Button btnFindingCallNumb;
        private System.Windows.Forms.Button btnClose;
        private Components.CntrlLeaderboard cntrlLeaderboard1;
        private System.Windows.Forms.Panel panel1;
    }
}