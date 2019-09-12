namespace Sinema
{
    partial class KulKulGiris
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
            this.labelKadi = new System.Windows.Forms.Label();
            this.labelKulsifre = new System.Windows.Forms.Label();
            this.textBoxKadi = new System.Windows.Forms.TextBox();
            this.textBoxKsifre = new System.Windows.Forms.TextBox();
            this.buttonKgiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelKadi
            // 
            this.labelKadi.AutoSize = true;
            this.labelKadi.Location = new System.Drawing.Point(43, 31);
            this.labelKadi.Name = "labelKadi";
            this.labelKadi.Size = new System.Drawing.Size(67, 13);
            this.labelKadi.TabIndex = 0;
            this.labelKadi.Text = "Kullanıcı Adı:";
            // 
            // labelKulsifre
            // 
            this.labelKulsifre.AutoSize = true;
            this.labelKulsifre.Location = new System.Drawing.Point(46, 66);
            this.labelKulsifre.Name = "labelKulsifre";
            this.labelKulsifre.Size = new System.Drawing.Size(31, 13);
            this.labelKulsifre.TabIndex = 1;
            this.labelKulsifre.Text = "Şifre:";
            // 
            // textBoxKadi
            // 
            this.textBoxKadi.Location = new System.Drawing.Point(116, 28);
            this.textBoxKadi.Name = "textBoxKadi";
            this.textBoxKadi.Size = new System.Drawing.Size(100, 20);
            this.textBoxKadi.TabIndex = 2;
            // 
            // textBoxKsifre
            // 
            this.textBoxKsifre.Location = new System.Drawing.Point(116, 63);
            this.textBoxKsifre.Name = "textBoxKsifre";
            this.textBoxKsifre.Size = new System.Drawing.Size(100, 20);
            this.textBoxKsifre.TabIndex = 3;
            // 
            // buttonKgiris
            // 
            this.buttonKgiris.Location = new System.Drawing.Point(141, 106);
            this.buttonKgiris.Name = "buttonKgiris";
            this.buttonKgiris.Size = new System.Drawing.Size(75, 23);
            this.buttonKgiris.TabIndex = 4;
            this.buttonKgiris.Text = "Giriş";
            this.buttonKgiris.UseVisualStyleBackColor = true;
            this.buttonKgiris.Click += new System.EventHandler(this.buttonKgiris_Click);
            // 
            // KulKulGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(306, 170);
            this.Controls.Add(this.buttonKgiris);
            this.Controls.Add(this.textBoxKsifre);
            this.Controls.Add(this.textBoxKadi);
            this.Controls.Add(this.labelKulsifre);
            this.Controls.Add(this.labelKadi);
            this.Name = "KulKulGiris";
            this.Text = "Kullanıcı Girişi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelKadi;
        private System.Windows.Forms.Label labelKulsifre;
        private System.Windows.Forms.TextBox textBoxKadi;
        private System.Windows.Forms.TextBox textBoxKsifre;
        private System.Windows.Forms.Button buttonKgiris;
    }
}