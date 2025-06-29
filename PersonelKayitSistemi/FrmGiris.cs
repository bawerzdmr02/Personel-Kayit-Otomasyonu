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
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=bawerpc\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True;TrustServerCertificate=True");

        private void FrmGiris_Load(object sender, EventArgs e)
        {

        }

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
    }
}
