namespace Sinema
{
    partial class Filmler
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
            this.dataGridViewFilmler = new System.Windows.Forms.DataGridView();
            this.buttonAra = new System.Windows.Forms.Button();
            this.labelArama = new System.Windows.Forms.Label();
            this.radioButtonFisim = new System.Windows.Forms.RadioButton();
            this.radioButtonFyonetmen = new System.Windows.Forms.RadioButton();
            this.radioButtonFtur = new System.Windows.Forms.RadioButton();
            this.textBoxAra = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilmler)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFilmler
            // 
            this.dataGridViewFilmler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFilmler.Location = new System.Drawing.Point(24, 107);
            this.dataGridViewFilmler.Name = "dataGridViewFilmler";
            this.dataGridViewFilmler.Size = new System.Drawing.Size(497, 191);
            this.dataGridViewFilmler.TabIndex = 0;
            this.dataGridViewFilmler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // buttonAra
            // 
            this.buttonAra.Location = new System.Drawing.Point(246, 76);
            this.buttonAra.Name = "buttonAra";
            this.buttonAra.Size = new System.Drawing.Size(75, 23);
            this.buttonAra.TabIndex = 1;
            this.buttonAra.Text = "Ara";
            this.buttonAra.UseVisualStyleBackColor = true;
            this.buttonAra.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelArama
            // 
            this.labelArama.AutoSize = true;
            this.labelArama.Location = new System.Drawing.Point(24, 19);
            this.labelArama.Name = "labelArama";
            this.labelArama.Size = new System.Drawing.Size(58, 13);
            this.labelArama.TabIndex = 2;
            this.labelArama.Text = "Film Arama";
            // 
            // radioButtonFisim
            // 
            this.radioButtonFisim.AutoSize = true;
            this.radioButtonFisim.Location = new System.Drawing.Point(27, 44);
            this.radioButtonFisim.Name = "radioButtonFisim";
            this.radioButtonFisim.Size = new System.Drawing.Size(73, 17);
            this.radioButtonFisim.TabIndex = 3;
            this.radioButtonFisim.TabStop = true;
            this.radioButtonFisim.Text = "İsme Göre";
            this.radioButtonFisim.UseVisualStyleBackColor = true;
            // 
            // radioButtonFyonetmen
            // 
            this.radioButtonFyonetmen.AutoSize = true;
            this.radioButtonFyonetmen.Location = new System.Drawing.Point(106, 44);
            this.radioButtonFyonetmen.Name = "radioButtonFyonetmen";
            this.radioButtonFyonetmen.Size = new System.Drawing.Size(105, 17);
            this.radioButtonFyonetmen.TabIndex = 4;
            this.radioButtonFyonetmen.TabStop = true;
            this.radioButtonFyonetmen.Text = "Yönetmene Göre";
            this.radioButtonFyonetmen.UseVisualStyleBackColor = true;
            // 
            // radioButtonFtur
            // 
            this.radioButtonFtur.AutoSize = true;
            this.radioButtonFtur.Location = new System.Drawing.Point(217, 44);
            this.radioButtonFtur.Name = "radioButtonFtur";
            this.radioButtonFtur.Size = new System.Drawing.Size(73, 17);
            this.radioButtonFtur.TabIndex = 5;
            this.radioButtonFtur.TabStop = true;
            this.radioButtonFtur.Text = "Türe Göre";
            this.radioButtonFtur.UseVisualStyleBackColor = true;
            // 
            // textBoxAra
            // 
            this.textBoxAra.Location = new System.Drawing.Point(27, 78);
            this.textBoxAra.Name = "textBoxAra";
            this.textBoxAra.Size = new System.Drawing.Size(204, 20);
            this.textBoxAra.TabIndex = 6;
            // 
            // Filmler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 310);
            this.Controls.Add(this.textBoxAra);
            this.Controls.Add(this.radioButtonFtur);
            this.Controls.Add(this.radioButtonFyonetmen);
            this.Controls.Add(this.radioButtonFisim);
            this.Controls.Add(this.labelArama);
            this.Controls.Add(this.buttonAra);
            this.Controls.Add(this.dataGridViewFilmler);
            this.Name = "Filmler";
            this.Text = "Filmler";
            this.Load += new System.EventHandler(this.Filmler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilmler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFilmler;
        private System.Windows.Forms.Button buttonAra;
        private System.Windows.Forms.Label labelArama;
        private System.Windows.Forms.RadioButton radioButtonFisim;
        private System.Windows.Forms.RadioButton radioButtonFyonetmen;
        private System.Windows.Forms.RadioButton radioButtonFtur;
        private System.Windows.Forms.TextBox textBoxAra;
    }
}