namespace DDS_Trainer.Forms
{
    partial class FrmRBGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRBGame));
            this.control_Icons = new System.Windows.Forms.ImageList(this.components);
            this.btnBack = new System.Windows.Forms.Button();
            this.cntrlRBGame1 = new DDS_Trainer.Components.CntrlRBGame();
            this.SuspendLayout();
            // 
            // control_Icons
            // 
            this.control_Icons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("control_Icons.ImageStream")));
            this.control_Icons.TransparentColor = System.Drawing.Color.Transparent;
            this.control_Icons.Images.SetKeyName(0, "2048px-Back_Arrow.svg.png");
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = global::DDS_Trainer.Properties.Resources.CloseButton2;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Location = new System.Drawing.Point(1259, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(37, 39);
            this.btnBack.TabIndex = 1;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cntrlRBGame1
            // 
            this.cntrlRBGame1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cntrlRBGame1.BackColor = System.Drawing.Color.White;
            this.cntrlRBGame1.BackgroundImage = global::DDS_Trainer.Properties.Resources.output_onlinepngtools__15_;
            this.cntrlRBGame1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cntrlRBGame1.Location = new System.Drawing.Point(12, 57);
            this.cntrlRBGame1.Name = "cntrlRBGame1";
            this.cntrlRBGame1.Size = new System.Drawing.Size(1284, 683);
            this.cntrlRBGame1.TabIndex = 2;
            // 
            // FrmRBGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::DDS_Trainer.Properties.Resources.PixWrinkledPaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1308, 752);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cntrlRBGame1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRBGame";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmReplacingBooks";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ImageList control_Icons;
        private Components.CntrlRBGame cntrlRBGame1;
    }
}