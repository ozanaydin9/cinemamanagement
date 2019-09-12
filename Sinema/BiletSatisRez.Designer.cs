namespace Sinema
{
    partial class BiletSatisRez
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
            this.comboBoxSalon = new System.Windows.Forms.ComboBox();
            this.comboBoxSeans = new System.Windows.Forms.ComboBox();
            this.labelSatisFilmAdi = new System.Windows.Forms.Label();
            this.labelSatisSalon = new System.Windows.Forms.Label();
            this.labelSatisSeans = new System.Windows.Forms.Label();
            this.buttonBsatrezSatis = new System.Windows.Forms.Button();
            this.buttonBsatrezRez = new System.Windows.Forms.Button();
            this.comboBoxFilmAdi = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBoxSalon
            // 
            this.comboBoxSalon.FormattingEnabled = true;
            this.comboBoxSalon.Location = new System.Drawing.Point(98, 44);
            this.comboBoxSalon.Name = "comboBoxSalon";
            this.comboBoxSalon.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSalon.TabIndex = 3;
            this.comboBoxSalon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBoxSalon_MouseClick);
            // 
            // comboBoxSeans
            // 
            this.comboBoxSeans.FormattingEnabled = true;
            this.comboBoxSeans.Location = new System.Drawing.Point(98, 80);
            this.comboBoxSeans.Name = "comboBoxSeans";
            this.comboBoxSeans.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSeans.TabIndex = 4;
            this.comboBoxSeans.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBoxSeans_MouseClick);
            // 
            // labelSatisFilmAdi
            // 
            this.labelSatisFilmAdi.AutoSize = true;
            this.labelSatisFilmAdi.Location = new System.Drawing.Point(35, 12);
            this.labelSatisFilmAdi.Name = "labelSatisFilmAdi";
            this.labelSatisFilmAdi.Size = new System.Drawing.Size(46, 13);
            this.labelSatisFilmAdi.TabIndex = 5;
            this.labelSatisFilmAdi.Text = "Film Adı:";
            // 
            // labelSatisSalon
            // 
            this.labelSatisSalon.AutoSize = true;
            this.labelSatisSalon.Location = new System.Drawing.Point(44, 47);
            this.labelSatisSalon.Name = "labelSatisSalon";
            this.labelSatisSalon.Size = new System.Drawing.Size(37, 13);
            this.labelSatisSalon.TabIndex = 6;
            this.labelSatisSalon.Text = "Salon:";
            // 
            // labelSatisSeans
            // 
            this.labelSatisSeans.AutoSize = true;
            this.labelSatisSeans.Location = new System.Drawing.Point(41, 83);
            this.labelSatisSeans.Name = "labelSatisSeans";
            this.labelSatisSeans.Size = new System.Drawing.Size(40, 13);
            this.labelSatisSeans.TabIndex = 7;
            this.labelSatisSeans.Text = "Seans:";
            // 
            // buttonBsatrezSatis
            // 
            this.buttonBsatrezSatis.Location = new System.Drawing.Point(114, 135);
            this.buttonBsatrezSatis.Name = "buttonBsatrezSatis";
            this.buttonBsatrezSatis.Size = new System.Drawing.Size(84, 23);
            this.buttonBsatrezSatis.TabIndex = 8;
            this.buttonBsatrezSatis.Text = "Satis";
            this.buttonBsatrezSatis.UseVisualStyleBackColor = true;
            this.buttonBsatrezSatis.Click += new System.EventHandler(this.buttonBsatrezSatis_Click);
            // 
            // buttonBsatrezRez
            // 
            this.buttonBsatrezRez.Location = new System.Drawing.Point(114, 107);
            this.buttonBsatrezRez.Name = "buttonBsatrezRez";
            this.buttonBsatrezRez.Size = new System.Drawing.Size(84, 23);
            this.buttonBsatrezRez.TabIndex = 9;
            this.buttonBsatrezRez.Text = "Rezervasyon";
            this.buttonBsatrezRez.UseVisualStyleBackColor = true;
            this.buttonBsatrezRez.Click += new System.EventHandler(this.buttonBsatrezRez_Click);
            // 
            // comboBoxFilmAdi
            // 
            this.comboBoxFilmAdi.FormattingEnabled = true;
            this.comboBoxFilmAdi.Location = new System.Drawing.Point(98, 9);
            this.comboBoxFilmAdi.Name = "comboBoxFilmAdi";
            this.comboBoxFilmAdi.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFilmAdi.TabIndex = 10;
            this.comboBoxFilmAdi.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBoxFilmAdi_MouseClick);
            // 
            // BiletSatisRez
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(306, 170);
            this.Controls.Add(this.comboBoxFilmAdi);
            this.Controls.Add(this.buttonBsatrezRez);
            this.Controls.Add(this.buttonBsatrezSatis);
            this.Controls.Add(this.labelSatisSeans);
            this.Controls.Add(this.labelSatisSalon);
            this.Controls.Add(this.labelSatisFilmAdi);
            this.Controls.Add(this.comboBoxSeans);
            this.Controls.Add(this.comboBoxSalon);
            this.Name = "BiletSatisRez";
            this.Text = "Bilet Satis ve Rezervasyon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSalon;
        private System.Windows.Forms.ComboBox comboBoxSeans;
        private System.Windows.Forms.Label labelSatisFilmAdi;
        private System.Windows.Forms.Label labelSatisSalon;
        private System.Windows.Forms.Label labelSatisSeans;
        private System.Windows.Forms.Button buttonBsatrezSatis;
        private System.Windows.Forms.Button buttonBsatrezRez;
        private System.Windows.Forms.ComboBox comboBoxFilmAdi;
    }
}