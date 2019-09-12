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
    public partial class KulKulGiris : Form
    {
        public KulKulGiris()
        {
            InitializeComponent();
        }

        private void buttonKgiris_Click(object sender, EventArgs e)
        {
            Kullanici kulana = new Kullanici();
            try
            {
                SqlConnection baglan = new SqlConnection();
                baglan.ConnectionString = "Data Source=WH;Initial Catalog=sinema;Integrated Security=True;";
                baglan.Open();
                string sql = "SELECT * FROM tblKullanici WHERE kullaniciAdi=@KAdi AND kullaniciSifre=@KSifre";
                SqlParameter prms1 = new SqlParameter("@KAdi", textBoxKadi.Text);
                SqlParameter prms2 = new SqlParameter("@KSifre", textBoxKsifre.Text);
                SqlCommand cmd = new SqlCommand(sql, baglan);
                cmd.Parameters.Add(prms1);
                cmd.Parameters.Add(prms2);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    this.Hide();
                    MessageBox.Show("Hoşgeldin " + textBoxKadi.Text);
                    kulana.ShowDialog();
                }
                else
                {
                    
                    MessageBox.Show("Veritabanında böyle bir kullanıcı bulunamadı");
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
