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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=WH;Initial Catalog=sinema;Integrated Security=True");

        private void buttonAdminSalonEkle_Click(object sender, EventArgs e)
        {
           
            baglan.Open();

            SqlCommand komut = new SqlCommand();

            komut.Connection = baglan;
            
            komut.CommandText = "INSERT INTO tblSalon(salonId,salonAdi) VALUES (" + 5 + ",'" + "Salon5" + "')";

            komut.ExecuteNonQuery();

            komut.Dispose();

            MessageBox.Show("Salon eklendi");

            baglan.Close();
            

        }

        private void buttonAdminSatis_Click(object sender, EventArgs e)
        {
            this.Hide();
            BiletSatisRez bSatRez = new BiletSatisRez();
            bSatRez.ShowDialog();
        }

        private void buttonAdminKullaniciEkle_Click(object sender, EventArgs e)
        {
            KullaniciEkle kEkle = new KullaniciEkle();
            kEkle.ShowDialog();
        }

        private void buttonAdminFilmEkle_Click(object sender, EventArgs e)
        {
            AdminFilmEkle adFilmEkle = new AdminFilmEkle();
            adFilmEkle.ShowDialog();
        }

        private void buttonAdminAdminEkle_Click(object sender, EventArgs e)
        {
            AdminEkle aEkle = new AdminEkle();
            aEkle.ShowDialog();
        }
    }
}
