namespace DDS_Trainer.Components
{
    partial class CntrlHighScore
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
            this.txtInitials = new System.Windows.Forms.TextBox();
            this.lblHighScore = new System.Windows.Forms.Label();
            this.lblInitials = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInitials
            // 
            this.txtInitials.BackColor = System.Drawing.SystemColors.Window;
            this.txtInitials.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtInitials.Font = new System.Drawing.Font("Retro Computer", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInitials.ForeColor = System.Drawing.Color.SandyBrown;
            this.txtInitials.Location = new System.Drawing.Point(98, 78);
            this.txtInitials.MaxLength = 3;
            this.txtInitials.Name = "txtInitials";
            this.txtInitials.Size = new System.Drawing.Size(100, 22);
            this.txtInitials.TabIndex = 0;
            this.txtInitials.Text = "ABC";
            this.txtInitials.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblHighScore
            // 
            this.lblHighScore.AutoSize = true;
            this.lblHighScore.BackColor = System.Drawing.Color.Transparent;
            this.lblHighScore.Font = new System.Drawing.Font("Retro Computer", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighScore.Location = new System.Drawing.Point(22, 11);
            this.lblHighScore.Name = "lblHighScore";
            this.lblHighScore.Size = new System.Drawing.Size(251, 37);
            this.lblHighScore.TabIndex = 1;
            this.lblHighScore.Text = "High Score!";
            // 
            // lblInitials
            // 
            this.lblInitials.AutoSize = true;
            this.lblInitials.Font = new System.Drawing.Font("Retro Computer", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInitials.Location = new System.Drawing.Point(48, 59);
            this.lblInitials.Name = "lblInitials";
            this.lblInitials.Size = new System.Drawing.Size(199, 16);
            this.lblInitials.TabIndex = 2;
            this.lblInitials.Text = "Enter your 3 initials";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.lblHighScore);
            this.panel1.Controls.Add(this.txtInitials);
            this.panel1.Controls.Add(this.lblInitials);
            this.panel1.Location = new System.Drawing.Point(42, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 151);
            this.panel1.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::DDS_Trainer.Properties.Resources.SaveButton;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Retro Computer", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(115, 115);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(73, 33);
            this.btnSave.TabIndex = 3;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // CntrlHighScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DDS_Trainer.Properties.Resources.YellowWhiteStripedBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panel1);
            this.Name = "CntrlHighScore";
            this.Size = new System.Drawing.Size(380, 366);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtInitials;
        private System.Windows.Forms.Label lblHighScore;
        private System.Windows.Forms.Label lblInitials;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
    }
}
