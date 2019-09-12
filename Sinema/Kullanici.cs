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
    public partial class Kullanici : Form
    {
        public Kullanici()
        {
            InitializeComponent();
        }

         SqlConnection baglan = new SqlConnection("Data Source=WH;Initial Catalog=sinema;Integrated Security=True");

        private void Kullanici_Load(object sender, EventArgs e)
        {

        }

        private void buttonKbilSatRez_Click(object sender, EventArgs e)
        {
            this.Hide();
            BiletSatisRez bSatRez = new BiletSatisRez();
            bSatRez.ShowDialog();
        }

        private void buttonKampanya_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mevcut Kampanyamız Bulunmamaktadır. Tam Bilet:10TL / Öğrenci:8TL");
        }

        private void buttonKullaniciFilmler_Click(object sender, EventArgs e)
        {
          
            Filmler film = new Filmler();
            film.ShowDialog();

}

        }
    }

