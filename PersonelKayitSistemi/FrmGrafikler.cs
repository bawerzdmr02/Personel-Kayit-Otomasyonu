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
    public partial class FrmGrafikler : Form
    {
        public FrmGrafikler()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=bawerpc\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True;TrustServerCertificate=True");
        private void FrmGrafikler_Load(object sender, EventArgs e)
        {
            this.baglanti.Open();
            SqlCommand komut = new SqlCommand("Select PerSehir,Count(*) From Tbl_Personel group by PerSehir", this.baglanti);
            SqlDataReader data = komut.ExecuteReader();
            while (data.Read())
            {
                this.chart1.Series["Sehirler"].Points.AddXY(data[0], new object[]
                {
                    data[1]
                });
            }
            this.baglanti.Close();
            this.baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select PerMeslek,Avg(PerMaas) From Tbl_Personel group by PerMeslek", this.baglanti);
            SqlDataReader data2 = komut2.ExecuteReader();
            while (data2.Read())
            {
                this.chart2.Series["Maaslar"].Points.AddXY(data2[0], new object[]
                {
                    data2[1]
                });
            }
            this.baglanti.Close();
        }
    }
}
