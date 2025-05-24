using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace PersonelKayitSistemi
{
	// Token: 0x02000005 RID: 5
	public partial class Frm_Giris : Form
	{
		// Token: 0x06000016 RID: 22 RVA: 0x00004D81 File Offset: 0x00002F81
		public Frm_Giris()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00004DAC File Offset: 0x00002FAC
		private void BtnGiris_Click(object sender, EventArgs e)
		{
			this.baglanti.Open();
			SqlCommand komut = new SqlCommand("Select * From Tbl_Yonetici where KullaniciAd=@p1 and Sifre=@p2", this.baglanti);
			komut.Parameters.AddWithValue("@p1", this.TxtKullanici.Text);
			komut.Parameters.AddWithValue("@p2", this.TxtSifre.Text);
			SqlDataReader data = komut.ExecuteReader();
			bool flag = data.Read();
			if (flag)
			{
				FrmAnaForm form = new FrmAnaForm();
				form.Show();
				base.Hide();
			}
			else
			{
				MessageBox.Show("Hatali Giris!");
			}
			this.baglanti.Close();
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00004E51 File Offset: 0x00003051
		private void Frm_Giris_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x0400003E RID: 62
		private SqlConnection baglanti = new SqlConnection("Data Source=bawerpc\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True;TrustServerCertificate=True");
	}
}
