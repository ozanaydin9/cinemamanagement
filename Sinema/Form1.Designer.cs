namespace Sinema
{
    partial class Form1
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
            this.buttonAdminGirisi = new System.Windows.Forms.Button();
            this.buttonKullaniciGirisi = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAdminGirisi
            // 
            this.buttonAdminGirisi.Location = new System.Drawing.Point(82, 12);
            this.buttonAdminGirisi.Name = "buttonAdminGirisi";
            this.buttonAdminGirisi.Size = new System.Drawing.Size(120, 50);
            this.buttonAdminGirisi.TabIndex = 0;
            this.buttonAdminGirisi.Text = "Admin Girişi";
            this.buttonAdminGirisi.UseVisualStyleBackColor = true;
            this.buttonAdminGirisi.Click += new System.EventHandler(this.buttonAdminGirisi_Click);
            // 
            // buttonKullaniciGirisi
            // 
            this.buttonKullaniciGirisi.Location = new System.Drawing.Point(82, 91);
            this.buttonKullaniciGirisi.Name = "buttonKullaniciGirisi";
            this.buttonKullaniciGirisi.Size = new System.Drawing.Size(120, 50);
            this.buttonKullaniciGirisi.TabIndex = 1;
            this.buttonKullaniciGirisi.Text = "Kullanıcı Girişi";
            this.buttonKullaniciGirisi.UseVisualStyleBackColor = true;
            this.buttonKullaniciGirisi.Click += new System.EventHandler(this.buttonKullaniciGirisi_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(219, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "k kayıt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(306, 170);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonKullaniciGirisi);
            this.Controls.Add(this.buttonAdminGirisi);
            this.Name = "Form1";
            this.Text = "Sinema Otomasyonu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAdminGirisi;
        private System.Windows.Forms.Button buttonKullaniciGirisi;
        private System.Windows.Forms.Button button1;

    }
}

