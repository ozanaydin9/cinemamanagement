namespace Sinema
{
    partial class AdminFilmEkle
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
            this.textBoxFilmAdi = new System.Windows.Forms.TextBox();
            this.textBoxFilmYonetmen = new System.Windows.Forms.TextBox();
            this.textBoxFilmTur = new System.Windows.Forms.TextBox();
            this.labelFilmAdi = new System.Windows.Forms.Label();
            this.labelFilmYonetmen = new System.Windows.Forms.Label();
            this.labelFilmTuru = new System.Windows.Forms.Label();
            this.buttonFilmEkleFilmEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxFilmAdi
            // 
            this.textBoxFilmAdi.Location = new System.Drawing.Point(84, 15);
            this.textBoxFilmAdi.Name = "textBoxFilmAdi";
            this.textBoxFilmAdi.Size = new System.Drawing.Size(100, 20);
            this.textBoxFilmAdi.TabIndex = 0;
            
            // 
            // textBoxFilmYonetmen
            // 
            this.textBoxFilmYonetmen.Location = new System.Drawing.Point(84, 48);
            this.textBoxFilmYonetmen.Name = "textBoxFilmYonetmen";
            this.textBoxFilmYonetmen.Size = new System.Drawing.Size(100, 20);
            this.textBoxFilmYonetmen.TabIndex = 1;
            // 
            // textBoxFilmTur
            // 
            this.textBoxFilmTur.Location = new System.Drawing.Point(84, 80);
            this.textBoxFilmTur.Name = "textBoxFilmTur";
            this.textBoxFilmTur.Size = new System.Drawing.Size(100, 20);
            this.textBoxFilmTur.TabIndex = 2;
            // 
            // labelFilmAdi
            // 
            this.labelFilmAdi.AutoSize = true;
            this.labelFilmAdi.Location = new System.Drawing.Point(25, 18);
            this.labelFilmAdi.Name = "labelFilmAdi";
            this.labelFilmAdi.Size = new System.Drawing.Size(46, 13);
            this.labelFilmAdi.TabIndex = 3;
            this.labelFilmAdi.Text = "Film Adı:";
            this.labelFilmAdi.Click += new System.EventHandler(this.labelFilmAdi_Click);
            // 
            // labelFilmYonetmen
            // 
            this.labelFilmYonetmen.AutoSize = true;
            this.labelFilmYonetmen.Location = new System.Drawing.Point(13, 51);
            this.labelFilmYonetmen.Name = "labelFilmYonetmen";
            this.labelFilmYonetmen.Size = new System.Drawing.Size(58, 13);
            this.labelFilmYonetmen.TabIndex = 4;
            this.labelFilmYonetmen.Text = "Yönetmen:";
            // 
            // labelFilmTuru
            // 
            this.labelFilmTuru.AutoSize = true;
            this.labelFilmTuru.Location = new System.Drawing.Point(18, 83);
            this.labelFilmTuru.Name = "labelFilmTuru";
            this.labelFilmTuru.Size = new System.Drawing.Size(53, 13);
            this.labelFilmTuru.TabIndex = 5;
            this.labelFilmTuru.Text = "Film Türü:";
            // 
            // buttonFilmEkleFilmEkle
            // 
            this.buttonFilmEkleFilmEkle.Location = new System.Drawing.Point(109, 116);
            this.buttonFilmEkleFilmEkle.Name = "buttonFilmEkleFilmEkle";
            this.buttonFilmEkleFilmEkle.Size = new System.Drawing.Size(75, 23);
            this.buttonFilmEkleFilmEkle.TabIndex = 6;
            this.buttonFilmEkleFilmEkle.Text = "Film Ekle";
            this.buttonFilmEkleFilmEkle.UseVisualStyleBackColor = true;
            this.buttonFilmEkleFilmEkle.Click += new System.EventHandler(this.buttonFilmEkleFilmEkle_Click);
            // 
            // AdminFilmEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(306, 170);
            this.Controls.Add(this.buttonFilmEkleFilmEkle);
            this.Controls.Add(this.labelFilmTuru);
            this.Controls.Add(this.labelFilmYonetmen);
            this.Controls.Add(this.labelFilmAdi);
            this.Controls.Add(this.textBoxFilmTur);
            this.Controls.Add(this.textBoxFilmYonetmen);
            this.Controls.Add(this.textBoxFilmAdi);
            this.Name = "AdminFilmEkle";
            this.Text = "Film Ekle";
            this.Load += new System.EventHandler(this.AdminFilmEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFilmAdi;
        private System.Windows.Forms.TextBox textBoxFilmYonetmen;
        private System.Windows.Forms.TextBox textBoxFilmTur;
        private System.Windows.Forms.Label labelFilmAdi;
        private System.Windows.Forms.Label labelFilmYonetmen;
        private System.Windows.Forms.Label labelFilmTuru;
        private System.Windows.Forms.Button buttonFilmEkleFilmEkle;
    }
}