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
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=bawerpc\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True;TrustServerCertificate=True");
        private void Form1_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from Tbl_Personel", baglanti);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();

        }

        private void BtnList_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from Tbl_Personel", baglanti);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();


        }

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

        private void temizle()
        {
            BtnKaydet.Enabled = true;
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

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            this.baglanti.Open();
            SqlCommand delete = new SqlCommand("Delete From Tbl_Personel Where Perid=@k1", this.baglanti);
            delete.Parameters.AddWithValue("@k1", this.TxtPersonelid.Text);
            delete.ExecuteNonQuery();
            this.baglanti.Close();
            MessageBox.Show("Personel Kaydi Silindi");
        }

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

        private void BtnIstatistik_Click(object sender, EventArgs e)
        {
            FrmIstatistik frmIstatistik = new FrmIstatistik();
            frmIstatistik.Show();
        }

        private void BtnGrafik_Click(object sender, EventArgs e)
        {
            FrmGrafikler frmGrafikler = new FrmGrafikler();
            frmGrafikler.Show();
        }
    }
}
