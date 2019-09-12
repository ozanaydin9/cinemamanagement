namespace Sinema
{
    partial class AdminGiris
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
            this.buttonAdgiris = new System.Windows.Forms.Button();
            this.textBoxAdsifre = new System.Windows.Forms.TextBox();
            this.textBoxAdadi = new System.Windows.Forms.TextBox();
            this.labelAdsifre = new System.Windows.Forms.Label();
            this.labelAdadi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAdgiris
            // 
            this.buttonAdgiris.Location = new System.Drawing.Point(143, 106);
            this.buttonAdgiris.Name = "buttonAdgiris";
            this.buttonAdgiris.Size = new System.Drawing.Size(75, 23);
            this.buttonAdgiris.TabIndex = 9;
            this.buttonAdgiris.Text = "Giriş";
            this.buttonAdgiris.UseVisualStyleBackColor = true;
            this.buttonAdgiris.Click += new System.EventHandler(this.buttonAdgiris_Click);
            // 
            // textBoxAdsifre
            // 
            this.textBoxAdsifre.Location = new System.Drawing.Point(118, 63);
            this.textBoxAdsifre.Name = "textBoxAdsifre";
            this.textBoxAdsifre.Size = new System.Drawing.Size(100, 20);
            this.textBoxAdsifre.TabIndex = 8;
            // 
            // textBoxAdadi
            // 
            this.textBoxAdadi.Location = new System.Drawing.Point(118, 28);
            this.textBoxAdadi.Name = "textBoxAdadi";
            this.textBoxAdadi.Size = new System.Drawing.Size(100, 20);
            this.textBoxAdadi.TabIndex = 7;
            // 
            // labelAdsifre
            // 
            this.labelAdsifre.AutoSize = true;
            this.labelAdsifre.Location = new System.Drawing.Point(48, 66);
            this.labelAdsifre.Name = "labelAdsifre";
            this.labelAdsifre.Size = new System.Drawing.Size(31, 13);
            this.labelAdsifre.TabIndex = 6;
            this.labelAdsifre.Text = "Şifre:";
            // 
            // labelAdadi
            // 
            this.labelAdadi.AutoSize = true;
            this.labelAdadi.Location = new System.Drawing.Point(45, 31);
            this.labelAdadi.Name = "labelAdadi";
            this.labelAdadi.Size = new System.Drawing.Size(57, 13);
            this.labelAdadi.TabIndex = 5;
            this.labelAdadi.Text = "Admin Adı:";
            // 
            // AdminGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(306, 170);
            this.Controls.Add(this.buttonAdgiris);
            this.Controls.Add(this.textBoxAdsifre);
            this.Controls.Add(this.textBoxAdadi);
            this.Controls.Add(this.labelAdsifre);
            this.Controls.Add(this.labelAdadi);
            this.Name = "AdminGiris";
            this.Text = "AdminGiris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdgiris;
        private System.Windows.Forms.TextBox textBoxAdsifre;
        private System.Windows.Forms.TextBox textBoxAdadi;
        private System.Windows.Forms.Label labelAdsifre;
        private System.Windows.Forms.Label labelAdadi;
    }
}