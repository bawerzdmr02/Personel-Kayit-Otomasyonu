namespace PersonelKayitSistemi
{
	// Token: 0x02000005 RID: 5
	public partial class Frm_Giris : global::System.Windows.Forms.Form
	{
		// Token: 0x06000019 RID: 25 RVA: 0x00004E54 File Offset: 0x00003054
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00004E8C File Offset: 0x0000308C
		private void InitializeComponent()
		{
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.TxtKullanici = new global::System.Windows.Forms.TextBox();
			this.TxtSifre = new global::System.Windows.Forms.TextBox();
			this.BtnGiris = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Segoe Print", 18f, global::System.Drawing.FontStyle.Bold | global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Point, 162);
			this.label1.Location = new global::System.Drawing.Point(105, 16);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(270, 43);
			this.label1.TabIndex = 0;
			this.label1.Text = "Kullanici Giris Paneli";
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(38, 85);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(121, 22);
			this.label2.TabIndex = 1;
			this.label2.Text = "Kullanici Adi :";
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(99, 120);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(60, 22);
			this.label3.TabIndex = 2;
			this.label3.Text = "Sifre :";
			this.TxtKullanici.Location = new global::System.Drawing.Point(165, 82);
			this.TxtKullanici.Name = "TxtKullanici";
			this.TxtKullanici.Size = new global::System.Drawing.Size(169, 29);
			this.TxtKullanici.TabIndex = 3;
			this.TxtSifre.Location = new global::System.Drawing.Point(165, 117);
			this.TxtSifre.Name = "TxtSifre";
			this.TxtSifre.Size = new global::System.Drawing.Size(169, 29);
			this.TxtSifre.TabIndex = 4;
			this.TxtSifre.UseSystemPasswordChar = true;
			this.BtnGiris.Location = new global::System.Drawing.Point(165, 152);
			this.BtnGiris.Name = "BtnGiris";
			this.BtnGiris.Size = new global::System.Drawing.Size(169, 32);
			this.BtnGiris.TabIndex = 5;
			this.BtnGiris.Text = "Giris Yap";
			this.BtnGiris.UseVisualStyleBackColor = true;
			this.BtnGiris.Click += new global::System.EventHandler(this.BtnGiris_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(11f, 22f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.DarkSeaGreen;
			base.ClientSize = new global::System.Drawing.Size(478, 234);
			base.Controls.Add(this.BtnGiris);
			base.Controls.Add(this.TxtSifre);
			base.Controls.Add(this.TxtKullanici);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			this.Font = new global::System.Drawing.Font("Arial", 14.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 162);
			base.Margin = new global::System.Windows.Forms.Padding(6, 5, 6, 5);
			base.Name = "Frm_Giris";
			this.Text = "Frm_Giris";
			base.Load += new global::System.EventHandler(this.Frm_Giris_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400003F RID: 63
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000040 RID: 64
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000041 RID: 65
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000042 RID: 66
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000043 RID: 67
		private global::System.Windows.Forms.TextBox TxtKullanici;

		// Token: 0x04000044 RID: 68
		private global::System.Windows.Forms.TextBox TxtSifre;

		// Token: 0x04000045 RID: 69
		private global::System.Windows.Forms.Button BtnGiris;
	}
}
