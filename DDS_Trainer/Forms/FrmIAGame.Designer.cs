namespace DDS_Trainer.Forms
{
    partial class FrmIAGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIAGame));
            this.cntrlIAGame1 = new DDS_Trainer.Components.CntrlIAGame();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cntrlIAGame1
            // 
            this.cntrlIAGame1.BackColor = System.Drawing.Color.White;
            this.cntrlIAGame1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cntrlIAGame1.BackgroundImage")));
            this.cntrlIAGame1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cntrlIAGame1.Location = new System.Drawing.Point(12, 57);
            this.cntrlIAGame1.Name = "cntrlIAGame1";
            this.cntrlIAGame1.Size = new System.Drawing.Size(1284, 683);
            this.cntrlIAGame1.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = global::DDS_Trainer.Properties.Resources.CloseButton2;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Location = new System.Drawing.Point(1259, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(37, 39);
            this.btnBack.TabIndex = 2;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FrmIAGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::DDS_Trainer.Properties.Resources.PixWrinkledPaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1308, 752);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cntrlIAGame1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmIAGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmIAGame";
            this.ResumeLayout(false);

        }

        #endregion

        private Components.CntrlIAGame cntrlIAGame1;
        private System.Windows.Forms.Button btnBack;
    }
}