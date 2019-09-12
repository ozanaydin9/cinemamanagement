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
    public partial class AdminFilmEkle : Form
    {
        public AdminFilmEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=WH;Initial Catalog=sinema;Integrated Security=True");

        private void labelFilmAdi_Click(object sender, EventArgs e)
        {

        }

        private void AdminFilmEkle_Load(object sender, EventArgs e)
        {

        }

        private void buttonFilmEkleFilmEkle_Click(object sender, EventArgs e)
        {
            baglan.Open();

            SqlCommand komut = new SqlCommand();

            komut.Connection = baglan;

            komut.CommandText = "INSERT INTO tblFilm(filmAdi,filmYonetmen,FilmTur) VALUES ('" + textBoxFilmAdi.Text + "','" + textBoxFilmYonetmen.Text + "','" + textBoxFilmTur.Text + "')";

            komut.ExecuteNonQuery();

            komut.Dispose();

            baglan.Close();

            MessageBox.Show("Film ekleme başarılı");


            textBoxFilmAdi.Clear();

            textBoxFilmYonetmen.Clear();

            textBoxFilmTur.Clear();
        }

        
    }
}
