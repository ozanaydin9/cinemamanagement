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
    public partial class BiletSatisRez : Form
    {
        public BiletSatisRez()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=WH;Initial Catalog=sinema;Integrated Security=True");


        private void comboBoxFilmAdi_MouseClick(object sender, MouseEventArgs e)
        {
            DataSet ds = new DataSet();
            ds.Clear();
            baglan.Open();

            string sorgu1 = "Select filmAdi from tblFilm";
            SqlDataAdapter da = new SqlDataAdapter(sorgu1, baglan);
            da.Fill(ds, "tblFilm");
            foreach (DataRow Satir1 in ds.Tables["tblFilm"].Rows)
            {
                string deger1 = Satir1[0].ToString();
                bool durum1 = comboBoxFilmAdi.Items.Contains(deger1);

                if (!durum1)
                {
                    comboBoxFilmAdi.Items.Add(deger1).ToString();
                }
                baglan.Close();
            }
        }
        private void comboBoxSalon_MouseClick(object sender, MouseEventArgs e)
        {
            DataSet ds = new DataSet();
            ds.Clear();
            baglan.Open();

            string sorgu2 = "Select salonAdi from tblSalon";
            SqlDataAdapter da = new SqlDataAdapter(sorgu2, baglan);
            da.Fill(ds, "tblSalon");
            foreach (DataRow Satir2 in ds.Tables["tblSalon"].Rows)
            {
                string deger2 = Satir2[0].ToString();
                bool durum2 = comboBoxSalon.Items.Contains(deger2);

                if (!durum2)
                {
                    comboBoxSalon.Items.Add(deger2).ToString();
                }
                baglan.Close();
            }
        }

        private void comboBoxSeans_MouseClick(object sender, MouseEventArgs e)
        {
            DataSet ds = new DataSet();
            ds.Clear();
            baglan.Open();

            string sorgu = "Select tarih from tblSeans";
            SqlDataAdapter da = new SqlDataAdapter(sorgu, baglan);
            da.Fill(ds, "tblSeans");
            foreach (DataRow Satir in ds.Tables["tblSeans"].Rows)
            {
                string deger = Satir[0].ToString();
                bool durum = comboBoxSeans.Items.Contains(deger);

                if (!durum)
                {
                    comboBoxSeans.Items.Add(deger).ToString();
                }
                baglan.Close();

            }
        }

        private void buttonBsatrezRez_Click(object sender, EventArgs e)
        {
            Rezerv rez = new Rezerv();
            if (comboBoxSalon.SelectedIndex != -1 && comboBoxFilmAdi.SelectedIndex != -1 && comboBoxSeans.SelectedIndex != -1)
            {
                rez.filmAdi = comboBoxFilmAdi.Text;

                rez.salonAdi = comboBoxSalon.Text;

                rez.tarih = comboBoxSeans.Text;

                rez.Show();
            }
            else
            {

                MessageBox.Show("Lütfen film bilgilerini eksiksiz doldurunuz.");

            }
        }

        private void buttonBsatrezSatis_Click(object sender, EventArgs e)
        {
            Satis sat = new Satis();
            if (comboBoxSalon.SelectedIndex != -1 && comboBoxFilmAdi.SelectedIndex != -1 && comboBoxSeans.SelectedIndex != -1)
            {
                sat.filmAdi = comboBoxFilmAdi.Text;

                sat.salonAdi = comboBoxSalon.Text;

                sat.tarih = comboBoxSeans.Text;

                sat.Show();
            }
            else
            {

                MessageBox.Show("Lütfen film bilgilerini eksiksiz doldurunuz.");

            }
        }
    }
}
