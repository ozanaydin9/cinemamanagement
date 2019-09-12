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
    public partial class KullaniciEkle : Form
    {
        public KullaniciEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=WH;Initial Catalog=sinema;Integrated Security=True");

        private void buttonKekleKekle_Click(object sender, EventArgs e)
        {
            baglan.Open();
            
            SqlCommand komut = new SqlCommand();
 
    komut.Connection = baglan; 
 
    komut.CommandText = "INSERT INTO tblKullanici(kullaniciAdi,kullaniciSifre) VALUES ('" + textBoxKullaniciAdi.Text + "','" + textBoxKekleSifre.Text + "')";
 
    komut.ExecuteNonQuery();
 
    komut.Dispose();
    
    baglan.Close();


    MessageBox.Show("Kullanıcı ekleme başarılı");
 
    textBoxKullaniciAdi.Clear();
 
    textBoxKekleSifre.Clear();
 
  
        }
    }
}
