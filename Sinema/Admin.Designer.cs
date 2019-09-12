namespace Sinema
{
    partial class Admin
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
            this.buttonAdminFilmEkle = new System.Windows.Forms.Button();
            this.buttonAdminKullaniciEkle = new System.Windows.Forms.Button();
            this.buttonAdminAdminEkle = new System.Windows.Forms.Button();
            this.buttonAdminSatis = new System.Windows.Forms.Button();
            this.buttonAdminSalonEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAdminFilmEkle
            // 
            this.buttonAdminFilmEkle.Location = new System.Drawing.Point(173, 12);
            this.buttonAdminFilmEkle.Name = "buttonAdminFilmEkle";
            this.buttonAdminFilmEkle.Size = new System.Drawing.Size(121, 23);
            this.buttonAdminFilmEkle.TabIndex = 0;
            this.buttonAdminFilmEkle.Text = "Film Ekle";
            this.buttonAdminFilmEkle.UseVisualStyleBackColor = true;
            this.buttonAdminFilmEkle.Click += new System.EventHandler(this.buttonAdminFilmEkle_Click);
            // 
            // buttonAdminKullaniciEkle
            // 
            this.buttonAdminKullaniciEkle.Location = new System.Drawing.Point(12, 12);
            this.buttonAdminKullaniciEkle.Name = "buttonAdminKullaniciEkle";
            this.buttonAdminKullaniciEkle.Size = new System.Drawing.Size(121, 23);
            this.buttonAdminKullaniciEkle.TabIndex = 1;
            this.buttonAdminKullaniciEkle.Text = "Kullanici Ekle";
            this.buttonAdminKullaniciEkle.UseVisualStyleBackColor = true;
            this.buttonAdminKullaniciEkle.Click += new System.EventHandler(this.buttonAdminKullaniciEkle_Click);
            // 
            // buttonAdminAdminEkle
            // 
            this.buttonAdminAdminEkle.Location = new System.Drawing.Point(12, 41);
            this.buttonAdminAdminEkle.Name = "buttonAdminAdminEkle";
            this.buttonAdminAdminEkle.Size = new System.Drawing.Size(121, 23);
            this.buttonAdminAdminEkle.TabIndex = 2;
            this.buttonAdminAdminEkle.Text = "Admin Ekle";
            this.buttonAdminAdminEkle.UseVisualStyleBackColor = true;
            this.buttonAdminAdminEkle.Click += new System.EventHandler(this.buttonAdminAdminEkle_Click);
            // 
            // buttonAdminSatis
            // 
            this.buttonAdminSatis.Location = new System.Drawing.Point(77, 87);
            this.buttonAdminSatis.Name = "buttonAdminSatis";
            this.buttonAdminSatis.Size = new System.Drawing.Size(156, 47);
            this.buttonAdminSatis.TabIndex = 3;
            this.buttonAdminSatis.Text = "Bilet Satış / Rezervasyon";
            this.buttonAdminSatis.UseVisualStyleBackColor = true;
            this.buttonAdminSatis.Click += new System.EventHandler(this.buttonAdminSatis_Click);
            // 
            // buttonAdminSalonEkle
            // 
            this.buttonAdminSalonEkle.Location = new System.Drawing.Point(173, 41);
            this.buttonAdminSalonEkle.Name = "buttonAdminSalonEkle";
            this.buttonAdminSalonEkle.Size = new System.Drawing.Size(121, 23);
            this.buttonAdminSalonEkle.TabIndex = 4;
            this.buttonAdminSalonEkle.Text = "Salon Ekle";
            this.buttonAdminSalonEkle.UseVisualStyleBackColor = true;
            this.buttonAdminSalonEkle.Click += new System.EventHandler(this.buttonAdminSalonEkle_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(306, 170);
            this.Controls.Add(this.buttonAdminSalonEkle);
            this.Controls.Add(this.buttonAdminSatis);
            this.Controls.Add(this.buttonAdminAdminEkle);
            this.Controls.Add(this.buttonAdminKullaniciEkle);
            this.Controls.Add(this.buttonAdminFilmEkle);
            this.Name = "Admin";
            this.Text = "Admin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAdminFilmEkle;
        private System.Windows.Forms.Button buttonAdminKullaniciEkle;
        private System.Windows.Forms.Button buttonAdminAdminEkle;
        private System.Windows.Forms.Button buttonAdminSatis;
        private System.Windows.Forms.Button buttonAdminSalonEkle;
    }
}