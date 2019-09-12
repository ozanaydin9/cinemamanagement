namespace Sinema
{
    partial class AdminEkle
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
            this.textBoxAEkleSifre = new System.Windows.Forms.TextBox();
            this.textBoxAEkleAdi = new System.Windows.Forms.TextBox();
            this.labelAdminSifre = new System.Windows.Forms.Label();
            this.labelAdminEkle = new System.Windows.Forms.Label();
            this.buttonAekleKekle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxAEkleSifre
            // 
            this.textBoxAEkleSifre.Location = new System.Drawing.Point(106, 57);
            this.textBoxAEkleSifre.Name = "textBoxAEkleSifre";
            this.textBoxAEkleSifre.Size = new System.Drawing.Size(100, 20);
            this.textBoxAEkleSifre.TabIndex = 9;
            // 
            // textBoxAEkleAdi
            // 
            this.textBoxAEkleAdi.Location = new System.Drawing.Point(106, 23);
            this.textBoxAEkleAdi.Name = "textBoxAEkleAdi";
            this.textBoxAEkleAdi.Size = new System.Drawing.Size(100, 20);
            this.textBoxAEkleAdi.TabIndex = 8;
            // 
            // labelAdminSifre
            // 
            this.labelAdminSifre.AutoSize = true;
            this.labelAdminSifre.Location = new System.Drawing.Point(69, 57);
            this.labelAdminSifre.Name = "labelAdminSifre";
            this.labelAdminSifre.Size = new System.Drawing.Size(31, 13);
            this.labelAdminSifre.TabIndex = 7;
            this.labelAdminSifre.Text = "Şifre:";
            // 
            // labelAdminEkle
            // 
            this.labelAdminEkle.AutoSize = true;
            this.labelAdminEkle.Location = new System.Drawing.Point(37, 26);
            this.labelAdminEkle.Name = "labelAdminEkle";
            this.labelAdminEkle.Size = new System.Drawing.Size(57, 13);
            this.labelAdminEkle.TabIndex = 6;
            this.labelAdminEkle.Text = "Admin Adı:";
            // 
            // buttonAekleKekle
            // 
            this.buttonAekleKekle.Location = new System.Drawing.Point(106, 92);
            this.buttonAekleKekle.Name = "buttonAekleKekle";
            this.buttonAekleKekle.Size = new System.Drawing.Size(100, 23);
            this.buttonAekleKekle.TabIndex = 5;
            this.buttonAekleKekle.Text = "Admin Ekle";
            this.buttonAekleKekle.UseVisualStyleBackColor = true;
            this.buttonAekleKekle.Click += new System.EventHandler(this.buttonAekleKekle_Click);
            // 
            // AdminEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(306, 170);
            this.Controls.Add(this.textBoxAEkleSifre);
            this.Controls.Add(this.textBoxAEkleAdi);
            this.Controls.Add(this.labelAdminSifre);
            this.Controls.Add(this.labelAdminEkle);
            this.Controls.Add(this.buttonAekleKekle);
            this.Name = "AdminEkle";
            this.Text = "AdminEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAEkleSifre;
        private System.Windows.Forms.TextBox textBoxAEkleAdi;
        private System.Windows.Forms.Label labelAdminSifre;
        private System.Windows.Forms.Label labelAdminEkle;
        private System.Windows.Forms.Button buttonAekleKekle;
    }
}