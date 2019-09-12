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
    public partial class Filmler : Form
    {
        public Filmler()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        SqlConnection baglan = new SqlConnection("Data Source=WH;Initial Catalog=sinema;Integrated Security=True");

        private void Filmler_Load(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand sorgu = new SqlCommand("select * from tblFilm", baglan);
            SqlDataAdapter da = new SqlDataAdapter(sorgu);
            DataTable tbl = new DataTable();
            da.Fill(tbl);
            dataGridViewFilmler.DataSource = tbl;
            baglan.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (radioButtonFisim.Checked == true)
            {
                baglan.Open();
                string sql = "SELECT * FROM tblFilm WHERE filmAdi LIKE'%" + textBoxAra.Text + "%'";
                SqlDataAdapter adaptor = new SqlDataAdapter(sql, baglan);
                DataTable tablo = new DataTable();
                adaptor.Fill(tablo);
                dataGridViewFilmler.DataSource = tablo;
                baglan.Close();
            }
            else if (radioButtonFyonetmen.Checked == true)
            {
                baglan.Open();
                string sql = "SELECT * FROM tblFilm WHERE filmYonetmen LIKE'%" + textBoxAra.Text + "%'";
                SqlDataAdapter adaptor = new SqlDataAdapter(sql, baglan);
                DataTable tablo = new DataTable();
                adaptor.Fill(tablo);
                dataGridViewFilmler.DataSource = tablo;
                baglan.Close();
            }
            else if (radioButtonFtur.Checked == true)
            {
                baglan.Open();
                string sql = "SELECT * FROM tblFilm WHERE filmTur LIKE'%" + textBoxAra.Text + "%'";
                SqlDataAdapter adaptor = new SqlDataAdapter(sql, baglan);
                DataTable tablo = new DataTable();
                adaptor.Fill(tablo);
                dataGridViewFilmler.DataSource = tablo;
                baglan.Close();
            }
            
        }

        
    }
}
