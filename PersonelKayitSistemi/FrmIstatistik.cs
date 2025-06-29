using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PersonelKayitSistemi
{
    public partial class FrmIstatistik : Form
    {
        public FrmIstatistik()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=bawerpc\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True;TrustServerCertificate=True");

        private void FrmIstatistik_Load(object sender, EventArgs e)
        {
            this.baglanti.Open();
            SqlCommand komut = new SqlCommand("Select Count(*) From Tbl_Personel", this.baglanti);
            SqlDataReader data = komut.ExecuteReader();
            while (data.Read())
            {
                this.LblTopPer.Text = data[0].ToString();
            }
            this.baglanti.Close();
            this.baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select Count(*) From Tbl_Personel where PerDurum=1", this.baglanti);
            SqlDataReader data2 = komut2.ExecuteReader();
            while (data2.Read())
            {
                this.LblEvliPer.Text = data2[0].ToString();
            }
            this.baglanti.Close();
            this.baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Select Count(*) From Tbl_Personel where PerDurum=0", this.baglanti);
            SqlDataReader data3 = komut3.ExecuteReader();
            while (data3.Read())
            {
                this.LblBekarPer.Text = data3[0].ToString();
            }
            this.baglanti.Close();
            this.baglanti.Open();
            SqlCommand komut4 = new SqlCommand("Select Count(distinct(PerSehir)) From Tbl_Personel", this.baglanti);
            SqlDataReader data4 = komut4.ExecuteReader();
            while (data4.Read())
            {
                this.LblSehir.Text = data4[0].ToString();
            }
            this.baglanti.Close();
            this.baglanti.Open();
            SqlCommand komut5 = new SqlCommand("Select Sum(PerMaas) From Tbl_Personel", this.baglanti);
            SqlDataReader data5 = komut5.ExecuteReader();
            while (data5.Read())
            {
                this.LblTopMaas.Text = data5[0].ToString();
            }
            this.baglanti.Close();
            this.baglanti.Open();
            SqlCommand komut6 = new SqlCommand("Select Avg(PerMaas) From Tbl_Personel", this.baglanti);
            SqlDataReader data6 = komut6.ExecuteReader();
            while (data6.Read())
            {
                this.LblOrtMaas.Text = data6[0].ToString();
            }
            this.baglanti.Close();
        }
    }
}
