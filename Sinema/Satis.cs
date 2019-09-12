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
using System.Collections;

namespace Sinema
{
    public partial class Satis : Form
    {
        public Satis()
        {
            InitializeComponent();
        }
       
        public string filmAdi = "";

        public string salonAdi = "";

        public string tarih = "";

        ArrayList koltuklar = new ArrayList();

        ArrayList iptalKoltuk = new ArrayList();

        int filmID = 0;

        int salonID = 0;

       
     SqlConnection baglan = new SqlConnection("Data Source=WH;Initial Catalog=sinema;Integrated Security=True");

         void baglantiKur()
     {
         if (baglan.State == ConnectionState.Closed)
         {
             baglan.Open();
         }
     }
        private void btnKoltuk_Click(object sender, EventArgs e)
        {
            //if (((Button)sender).BackColor != Color.Red)
            if (((Button)sender).BackColor == Color.Chartreuse) // yeşil
            {
                ((Button)sender).BackColor = Color.Orange;
                if (!koltuklar.Contains(((Button)sender).Text))
                {
                    koltuklar.Add(((Button)sender).Text);
                }
                koltukYazdir();
            }
            else if (((Button)sender).BackColor == Color.Orange) // turuncu
            {
                ((Button)sender).BackColor = Color.Chartreuse;
                if (koltuklar.Contains(((Button)sender).Text))
                {
                     koltuklar.Remove(((Button)sender).Text);
                }
                koltukYazdir();
            }
            else // kırmızı
            {
                if (!iptalKoltuk.Contains(((Button)sender).Text))
                {
                    iptalKoltuk.Add(((Button)sender).Text);
                }
                else 
                {
                    iptalKoltuk.Remove(((Button)sender).Text);
                }

                string koltuk = "";
                for (int i = 0; i < iptalKoltuk.Count; i++)
                {
                    koltuk += iptalKoltuk[i].ToString() + ",";
                }
                if (iptalKoltuk.Count >= 1)
                {
                    koltuk = koltuk.Remove(koltuk.Length - 1, 1);
                }
                textBoxSipKno.Text = koltuk;
            }           
        }

        void koltukYazdir()
        {
            string koltuk = "";
            for (int i = 0; i < koltuklar.Count; i++)
            {
                koltuk += koltuklar[i].ToString() + ",";
            }

            if (koltuklar.Count >= 1)
            {
                koltuk = koltuk.Remove(koltuk.Length - 1, 1);
            }

            textBoxSKno.Text = koltuk;

        }

        int ucret = 0;
        private void Satis_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            filmID = Convert.ToInt32(araGetir("SELECT * FROM tblFilm WHERE filmAdi='" + filmAdi + "'"));
            salonID = Convert.ToInt32(araGetir("SELECT * FROM tblSalon WHERE salonAdi='" + salonAdi + "'"));
            LogAl();

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            labelSaat.Text = DateTime.Now.ToLongTimeString();
            labelTarih.Text = DateTime.Now.Date.ToShortDateString();
        }
        string araGetir(string sql)
        {
            baglantiKur();
            SqlCommand cmd = new SqlCommand(sql, baglan);
            SqlDataReader oku = cmd.ExecuteReader();
            oku.Read();
            string deger = oku[0].ToString();
            baglan.Close();
            return deger;
        }
        void biletAyir()
        {
            baglantiKur();
            if (baglan.State == ConnectionState.Closed)
            {
                baglan.Open();
            }
           
            if (radioButtonOgr.Checked) ucret = 8;
            else ucret = 12;

            for (int i = 0; i < koltuklar.Count; i++)
            {
                string sql = "INSERT INTO tblSatis(filmId,salonId,tarih,seans,satisAdi,satisSoyadi,koltukNo,ucret) VALUES (" + filmID + "," + salonID + ",'" + labelTarih.Text + "','" + tarih + "','" + textBoxSad.Text + "','" + textBoxSsoyad.Text + "'," + Convert.ToInt32(koltuklar[i]) + "," + ucret + ")";
                SqlCommand cmd = new SqlCommand(sql, baglan);
                //cmd.ExecuteNonQuery();
                this.Controls.Find("buttonKlt" + koltuklar[i].ToString(), true)[0].BackColor = Color.Red;

                //SqlCommand cmd = new SqlCommand();
                //String trh = Convert.ToString(DateTime.Now);
                //cmd.CommandText = "INSERT INTO tblSatis(filmId,salonId,tarih,seans,satisAdi,satisSoyadi,koltukNo,ucret) VALUES (" + filmID + "," + salonID + ",'" + @labelTarih.Text + "','" + tarih + "','" + textBoxSad.Text + "','" + textBoxSsoyad.Text + "'," + Convert.ToInt32(koltuklar[i]) + ",'" + ucret + "')";
                //cmd.Parameters.AddWithValue("@labelTarih.Text", DateTime.Parse(tarih));
                ////string sql = "INSERT INTO tblSatis(filmId,salonId,tarih,seans,satisAdi,satisSoyadi,koltukNo,ucret) VALUES (" + filmID + "," + salonID + ",'" + labelTarih.Text + "','" + tarih + "','" + textBoxSad.Text + "','" + textBoxSsoyad.Text + "'," + Convert.ToInt32(koltuklar[i]) + ",'" + ucret + "')";

                ////cmd.ExecuteNonQuery();
                //this.Controls.Find("buttonKlt" + koltuklar[i].ToString(), true)[0].BackColor = Color.Red;

            }
            baglan.Close();
        }
        private void buttonBiletAl_Click(object sender, EventArgs e)
        {

            if (textBoxSKno.Text != "")
            {
                if (textBoxSKno.Text != "" && textBoxSad.Text != "" && textBoxSsoyad.Text != "")
                {
                    biletAyir();
                    MessageBox.Show(textBoxSad.Text + " " + textBoxSsoyad.Text + " bilgili kişinin " + textBoxSKno.Text + " no'lu koltukları ayrılmıştır. Fiyat:" + koltuklar.Count*ucret);
                    textBoxSKno.Text = "";
                    textBoxSad.Text = "";
                    textBoxSsoyad.Text = "";
                    koltuklar.Clear();
                }
                else
                {
                    MessageBox.Show("Tüm bilgileri eksiksiz doldurmalısınız.");
                }
            }
            else
            {
                MessageBox.Show("Koltuk numarasını seçmediniz.");
            }

        }
        void LogAl()
        {
            baglantiKur();
            string sql = "SELECT * FROM tblSatis WHERE filmId=" + filmID + " AND salonId=" + salonID + " AND seans='" + tarih + "'";
            SqlCommand cmd = new SqlCommand(sql, baglan);
            SqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                string koltukNo = oku[7].ToString();
                this.Controls.Find("buttonKlt" + koltukNo, true)[0].BackColor = Color.Red;
            }
            baglan.Close();
        }
       

        

        private void buttonBltIptal_Click(object sender, EventArgs e)
        {
            if (textBoxSipKno.Text != "")
            {
                baglantiKur();
                for (int i = 0; i < iptalKoltuk.Count; i++)
                {
                    string sql = "DELETE FROM tblSatis WHERE koltukNo=" + Convert.ToInt32(iptalKoltuk[i]);
                    SqlCommand cmd = new SqlCommand(sql, baglan);
                    //cmd.ExecuteNonQuery();
                    this.Controls.Find("buttonKlt" + iptalKoltuk[i].ToString(), true)[0].BackColor = Color.Chartreuse;
                }

                baglan.Close();
                iptalKoltuk.Clear();
                MessageBox.Show(textBoxSipKno.Text + " koltuk numaralı bilet iptal edilmiştir.");
                textBoxSipKno.Text = "";
                textBoxSad.Text = "";
                textBoxSsoyad.Text = "";                
            } 
            else
            {
                MessageBox.Show("Koltuk numarasını seçmediniz.");                
            }
        }

        
        

        
        }

      
       
    }
