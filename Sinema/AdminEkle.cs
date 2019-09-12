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
    public partial class AdminEkle : Form
    {
        public AdminEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=WH;Initial Catalog=sinema;Integrated Security=True");

        private void buttonAekleKekle_Click(object sender, EventArgs e)
        {
            baglan.Open();

            SqlCommand komut = new SqlCommand();

            komut.Connection = baglan;

            komut.CommandText = "INSERT INTO tblAdmin(adminAdi,adminSifre) VALUES ('" + textBoxAEkleAdi.Text + "','" + textBoxAEkleSifre.Text + "')";

            komut.ExecuteNonQuery();

            komut.Dispose();

            baglan.Close();

            MessageBox.Show("Admin ekleme başarılı");

            textBoxAEkleAdi.Clear();

            textBoxAEkleSifre.Clear();
 
        }
    }
}
