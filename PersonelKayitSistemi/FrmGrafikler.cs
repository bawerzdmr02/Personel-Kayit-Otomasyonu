using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PersonelKayitSistemi
{
	// Token: 0x02000003 RID: 3
	public partial class FrmGrafikler : Form
	{
		// Token: 0x0600000E RID: 14 RVA: 0x00003E81 File Offset: 0x00002081
		public FrmGrafikler()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00003EAC File Offset: 0x000020AC
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

		// Token: 0x0400002C RID: 44
		private SqlConnection baglanti = new SqlConnection("Data Source=bawerpc\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True;TrustServerCertificate=True");
	}
}
