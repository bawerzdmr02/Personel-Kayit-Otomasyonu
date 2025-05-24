using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using PersonelKayitSistemi.PersonelVeriTabaniDataSetTableAdapters;

namespace PersonelKayitSistemi
{
	// Token: 0x02000002 RID: 2
	public partial class FrmAnaForm : Form
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public FrmAnaForm()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002078 File Offset: 0x00000278
		private void temizle()
		{
			this.TxtAd.Text = string.Empty;
			this.TxtMeslek.Text = string.Empty;
			this.TxtSoyad.Text = string.Empty;
			this.TxtPersonelid.Text = string.Empty;
			this.CmbSehir.Text = string.Empty;
			this.MtbMaas.Text = string.Empty;
			this.REvli.Checked = false;
			this.RBekar.Checked = false;
			this.TxtAd.Focus();
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002112 File Offset: 0x00000312
		private void Form1_Load(object sender, EventArgs e)
		{
			this.tbl_PersonelTableAdapter.Fill(this.personelVeriTabaniDataSet.Tbl_Personel);
		}

		// Token: 0x06000004 RID: 4 RVA: 0x0000212C File Offset: 0x0000032C
		private void BtnList_Click(object sender, EventArgs e)
		{
			this.tbl_PersonelTableAdapter.Fill(this.personelVeriTabaniDataSet.Tbl_Personel);
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002148 File Offset: 0x00000348
		private void BtnKaydet_Click(object sender, EventArgs e)
		{
			this.baglanti.Open();
			SqlCommand komut = new SqlCommand("insert into Tbl_Personel (PerAd,PerSoyad,PerSehir,PerMaas,PerDurum,PerMeslek) values(@p1,@p2,@p3,@p4,@p5,@p6)", this.baglanti);
			komut.Parameters.AddWithValue("@p1", this.TxtAd.Text);
			komut.Parameters.AddWithValue("@p2", this.TxtSoyad.Text);
			komut.Parameters.AddWithValue("@p3", this.CmbSehir.Text);
			komut.Parameters.AddWithValue("@p4", this.MtbMaas.Text);
			bool flag = this.REvli.Checked == base.Enabled;
			if (flag)
			{
				komut.Parameters.AddWithValue("@p5", 1);
			}
			else
			{
				komut.Parameters.AddWithValue("@p5", 0);
			}
			komut.Parameters.AddWithValue("@p6", this.TxtMeslek.Text);
			komut.ExecuteNonQuery();
			this.baglanti.Close();
			MessageBox.Show("Personel Eklendi");
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002268 File Offset: 0x00000468
		private void BtnTemizle_Click(object sender, EventArgs e)
		{
			this.temizle();
			this.BtnKaydet.Enabled = true;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002280 File Offset: 0x00000480
		private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			this.BtnKaydet.Enabled = false;
			int select = this.dataGridView1.SelectedCells[0].RowIndex;
			this.TxtPersonelid.Text = this.dataGridView1.Rows[select].Cells[0].Value.ToString();
			this.TxtAd.Text = this.dataGridView1.Rows[select].Cells[1].Value.ToString();
			this.TxtSoyad.Text = this.dataGridView1.Rows[select].Cells[2].Value.ToString();
			this.CmbSehir.Text = this.dataGridView1.Rows[select].Cells[3].Value.ToString();
			this.MtbMaas.Text = this.dataGridView1.Rows[select].Cells[4].Value.ToString();
			bool flag = this.dataGridView1.Rows[select].Cells[5].Value.ToString() == "True";
			if (flag)
			{
				this.REvli.Checked = base.Enabled;
			}
			else
			{
				this.RBekar.Checked = base.Enabled;
			}
			this.TxtMeslek.Text = this.dataGridView1.Rows[select].Cells[6].Value.ToString();
		}

		// Token: 0x06000008 RID: 8 RVA: 0x0000243C File Offset: 0x0000063C
		private void BtnSil_Click(object sender, EventArgs e)
		{
			this.baglanti.Open();
			SqlCommand delete = new SqlCommand("Delete From Tbl_Personel Where Perid=@k1", this.baglanti);
			delete.Parameters.AddWithValue("@k1", this.TxtPersonelid.Text);
			delete.ExecuteNonQuery();
			this.baglanti.Close();
			MessageBox.Show("Personel Kaydi Silindi");
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000024A4 File Offset: 0x000006A4
		private void BtnGun_Click(object sender, EventArgs e)
		{
			this.baglanti.Open();
			SqlCommand update = new SqlCommand("Update Tbl_Personel Set PerAd=@ad,PerSoyad=@soyad,PerSehir=@sehir,PerMaas=@maas,PerDurum=@durum,PerMeslek=@meslek  Where Perid=@id", this.baglanti);
			update.Parameters.AddWithValue("@ad", this.TxtAd.Text);
			update.Parameters.AddWithValue("@soyad", this.TxtSoyad.Text);
			update.Parameters.AddWithValue("@sehir", this.CmbSehir.Text);
			update.Parameters.AddWithValue("@maas", this.MtbMaas.Text);
			bool flag = this.REvli.Checked == base.Enabled;
			if (flag)
			{
				update.Parameters.AddWithValue("@durum", true);
			}
			bool flag2 = this.RBekar.Checked == base.Enabled;
			if (flag2)
			{
				update.Parameters.AddWithValue("@durum", false);
			}
			update.Parameters.AddWithValue("@meslek", this.TxtMeslek.Text);
			update.Parameters.AddWithValue("@id", this.TxtPersonelid.Text);
			update.ExecuteNonQuery();
			this.baglanti.Close();
			MessageBox.Show("Personel Bilgileri Guncellendi");
			this.BtnKaydet.Enabled = true;
			this.temizle();
		}

		// Token: 0x0600000A RID: 10 RVA: 0x0000260C File Offset: 0x0000080C
		private void BtnIstatistik_Click(object sender, EventArgs e)
		{
			FrmIstatistik frmIstatistik = new FrmIstatistik();
			frmIstatistik.Show();
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002628 File Offset: 0x00000828
		private void BtnGrafik_Click(object sender, EventArgs e)
		{
			FrmGrafikler frmGrafikler = new FrmGrafikler();
			frmGrafikler.Show();
		}

		// Token: 0x04000001 RID: 1
		private SqlConnection baglanti = new SqlConnection("Data Source=bawerpc\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True;TrustServerCertificate=True");
	}
}
