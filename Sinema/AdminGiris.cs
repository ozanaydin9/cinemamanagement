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
    public partial class AdminGiris : Form
    {
        public AdminGiris()
        {
            InitializeComponent();
        }

        private void buttonAdgiris_Click(object sender, EventArgs e)
        {
            Admin adminana = new Admin();
           
            try
            {
                SqlConnection baglan = new SqlConnection();
                baglan.ConnectionString = "Data Source=WH;Initial Catalog=sinema;Integrated Security=True;";
                baglan.Open();
                string sql = "SELECT * FROM tblAdmin WHERE adminAdi=@AAdi AND adminSifre=@ASifre";
                SqlParameter prms1 = new SqlParameter("@AAdi", textBoxAdadi.Text);
                SqlParameter prms2 = new SqlParameter("@ASifre", textBoxAdsifre.Text);
                SqlCommand cmd = new SqlCommand(sql, baglan);
                cmd.Parameters.Add(prms1);
                cmd.Parameters.Add(prms2);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    this.Hide();
                    MessageBox.Show("Hoşgeldin " + textBoxAdadi.Text);
                    adminana.Show();
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
