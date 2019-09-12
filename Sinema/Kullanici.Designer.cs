namespace Sinema
{
    partial class Kullanici
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
            this.buttonKullaniciFilmler = new System.Windows.Forms.Button();
            this.buttonKampanya = new System.Windows.Forms.Button();
            this.buttonKbilSatRez = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonKullaniciFilmler
            // 
            this.buttonKullaniciFilmler.Location = new System.Drawing.Point(32, 22);
            this.buttonKullaniciFilmler.Name = "buttonKullaniciFilmler";
            this.buttonKullaniciFilmler.Size = new System.Drawing.Size(109, 42);
            this.buttonKullaniciFilmler.TabIndex = 0;
            this.buttonKullaniciFilmler.Text = "Filmler";
            this.buttonKullaniciFilmler.UseVisualStyleBackColor = true;
            this.buttonKullaniciFilmler.Click += new System.EventHandler(this.buttonKullaniciFilmler_Click);
            // 
            // buttonKampanya
            // 
            this.buttonKampanya.Location = new System.Drawing.Point(166, 22);
            this.buttonKampanya.Name = "buttonKampanya";
            this.buttonKampanya.Size = new System.Drawing.Size(109, 42);
            this.buttonKampanya.TabIndex = 1;
            this.buttonKampanya.Text = "Kampanyalar";
            this.buttonKampanya.UseVisualStyleBackColor = true;
            this.buttonKampanya.Click += new System.EventHandler(this.buttonKampanya_Click);
            // 
            // buttonKbilSatRez
            // 
            this.buttonKbilSatRez.Location = new System.Drawing.Point(75, 101);
            this.buttonKbilSatRez.Name = "buttonKbilSatRez";
            this.buttonKbilSatRez.Size = new System.Drawing.Size(156, 47);
            this.buttonKbilSatRez.TabIndex = 2;
            this.buttonKbilSatRez.Text = "Bilet Satış/Rezervasyon";
            this.buttonKbilSatRez.UseVisualStyleBackColor = true;
            this.buttonKbilSatRez.Click += new System.EventHandler(this.buttonKbilSatRez_Click);
            // 
            // Kullanici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(306, 170);
            this.Controls.Add(this.buttonKbilSatRez);
            this.Controls.Add(this.buttonKampanya);
            this.Controls.Add(this.buttonKullaniciFilmler);
            this.Name = "Kullanici";
            this.Text = "Kullanici";
            this.Load += new System.EventHandler(this.Kullanici_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonKullaniciFilmler;
        private System.Windows.Forms.Button buttonKampanya;
        private System.Windows.Forms.Button buttonKbilSatRez;
    }
}