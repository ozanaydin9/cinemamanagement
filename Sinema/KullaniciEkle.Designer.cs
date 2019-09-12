namespace Sinema
{
    partial class KullaniciEkle
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
            this.buttonKekleKekle = new System.Windows.Forms.Button();
            this.labelKullaniciEkle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxKullaniciAdi = new System.Windows.Forms.TextBox();
            this.textBoxKekleSifre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonKekleKekle
            // 
            this.buttonKekleKekle.Location = new System.Drawing.Point(99, 94);
            this.buttonKekleKekle.Name = "buttonKekleKekle";
            this.buttonKekleKekle.Size = new System.Drawing.Size(100, 23);
            this.buttonKekleKekle.TabIndex = 0;
            this.buttonKekleKekle.Text = "Kullanıcı Ekle";
            this.buttonKekleKekle.UseVisualStyleBackColor = true;
            this.buttonKekleKekle.Click += new System.EventHandler(this.buttonKekleKekle_Click);
            // 
            // labelKullaniciEkle
            // 
            this.labelKullaniciEkle.AutoSize = true;
            this.labelKullaniciEkle.Location = new System.Drawing.Point(30, 28);
            this.labelKullaniciEkle.Name = "labelKullaniciEkle";
            this.labelKullaniciEkle.Size = new System.Drawing.Size(67, 13);
            this.labelKullaniciEkle.TabIndex = 1;
            this.labelKullaniciEkle.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre:";
            // 
            // textBoxKullaniciAdi
            // 
            this.textBoxKullaniciAdi.Location = new System.Drawing.Point(99, 25);
            this.textBoxKullaniciAdi.Name = "textBoxKullaniciAdi";
            this.textBoxKullaniciAdi.Size = new System.Drawing.Size(100, 20);
            this.textBoxKullaniciAdi.TabIndex = 3;
            // 
            // textBoxKekleSifre
            // 
            this.textBoxKekleSifre.Location = new System.Drawing.Point(99, 59);
            this.textBoxKekleSifre.Name = "textBoxKekleSifre";
            this.textBoxKekleSifre.Size = new System.Drawing.Size(100, 20);
            this.textBoxKekleSifre.TabIndex = 4;
            // 
            // KullaniciEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(306, 170);
            this.Controls.Add(this.textBoxKekleSifre);
            this.Controls.Add(this.textBoxKullaniciAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelKullaniciEkle);
            this.Controls.Add(this.buttonKekleKekle);
            this.Name = "KullaniciEkle";
            this.Text = "Kullanici Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonKekleKekle;
        private System.Windows.Forms.Label labelKullaniciEkle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxKullaniciAdi;
        private System.Windows.Forms.TextBox textBoxKekleSifre;
    }
}