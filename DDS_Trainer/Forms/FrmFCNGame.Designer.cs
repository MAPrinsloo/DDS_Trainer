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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFCNGame));
            this.btnBack = new System.Windows.Forms.Button();
            this.btnTutorial = new System.Windows.Forms.Button();
            this.cntrlFCNGame1 = new DDS_Trainer.Components.CntrlFCNGame();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = global::DDS_Trainer.Properties.Resources.CloseButtonCrop;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
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
            // btnTutorial
            // 
            this.btnTutorial.BackColor = System.Drawing.Color.Transparent;
            this.btnTutorial.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTutorial.BackgroundImage")));
            this.btnTutorial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTutorial.FlatAppearance.BorderSize = 0;
            this.btnTutorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTutorial.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnTutorial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTutorial.Location = new System.Drawing.Point(1216, 12);
            this.btnTutorial.Name = "btnTutorial";
            this.btnTutorial.Size = new System.Drawing.Size(37, 39);
            this.btnTutorial.TabIndex = 3;
            this.btnTutorial.UseVisualStyleBackColor = false;
            this.btnTutorial.Click += new System.EventHandler(this.btnTutorial_Click);
            // 
            // cntrlFCNGame1
            // 
            this.cntrlFCNGame1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cntrlFCNGame1.BackgroundImage")));
            this.cntrlFCNGame1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cntrlFCNGame1.Location = new System.Drawing.Point(12, 57);
            this.cntrlFCNGame1.Name = "cntrlFCNGame1";
            this.cntrlFCNGame1.Size = new System.Drawing.Size(1284, 683);
            this.cntrlFCNGame1.TabIndex = 0;
            // 
            // FrmFCNGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::DDS_Trainer.Properties.Resources.PixWrinkledPaper;
            this.ClientSize = new System.Drawing.Size(1308, 752);
            this.Controls.Add(this.btnTutorial);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cntrlFCNGame1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmFCNGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFCNGame";
            this.ResumeLayout(false);

        }

        #endregion

        private Components.CntrlFCNGame cntrlFCNGame1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnTutorial;
    }
}