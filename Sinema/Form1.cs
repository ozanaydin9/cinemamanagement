using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;


namespace Sinema
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonKullaniciGirisi_Click(object sender, EventArgs e)
        {
            this.Hide();
            KulKulGiris kul = new KulKulGiris();
            kul.Show();
            

        }

        private void buttonAdminGirisi_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminGiris admin = new AdminGiris();
            admin.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KullaniciEkle kEkle = new KullaniciEkle();
            kEkle.ShowDialog();
        }

       
   
    }
}
