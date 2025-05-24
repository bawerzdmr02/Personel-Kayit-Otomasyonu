namespace PersonelKayitSistemi
{
	// Token: 0x02000004 RID: 4
	public partial class FrmIstatistik : global::System.Windows.Forms.Form
	{
		// Token: 0x06000014 RID: 20 RVA: 0x00004518 File Offset: 0x00002718
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00004550 File Offset: 0x00002750
		private void InitializeComponent()
		{
			this.label1 = new global::System.Windows.Forms.Label();
			this.LblTopPer = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.LblEvliPer = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			this.LblBekarPer = new global::System.Windows.Forms.Label();
			this.label7 = new global::System.Windows.Forms.Label();
			this.LblSehir = new global::System.Windows.Forms.Label();
			this.label9 = new global::System.Windows.Forms.Label();
			this.LblTopMaas = new global::System.Windows.Forms.Label();
			this.label11 = new global::System.Windows.Forms.Label();
			this.LblOrtMaas = new global::System.Windows.Forms.Label();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(13, 27);
			this.label1.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(240, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "Toplam Personel Sayisi :";
			this.LblTopPer.AutoSize = true;
			this.LblTopPer.Font = new global::System.Drawing.Font("Arial", 15.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 162);
			this.LblTopPer.Location = new global::System.Drawing.Point(259, 27);
			this.LblTopPer.Name = "LblTopPer";
			this.LblTopPer.Size = new global::System.Drawing.Size(22, 24);
			this.LblTopPer.TabIndex = 1;
			this.LblTopPer.Text = "0";
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(44, 61);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(209, 24);
			this.label3.TabIndex = 3;
			this.label3.Text = "Evli Personel Sayisi :";
			this.LblEvliPer.AutoSize = true;
			this.LblEvliPer.Font = new global::System.Drawing.Font("Arial", 15.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 162);
			this.LblEvliPer.Location = new global::System.Drawing.Point(259, 61);
			this.LblEvliPer.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.LblEvliPer.Name = "LblEvliPer";
			this.LblEvliPer.Size = new global::System.Drawing.Size(22, 24);
			this.LblEvliPer.TabIndex = 2;
			this.LblEvliPer.Text = "0";
			this.label5.AutoSize = true;
			this.label5.Location = new global::System.Drawing.Point(23, 96);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(230, 24);
			this.label5.TabIndex = 4;
			this.label5.Text = "Bekar Personel Sayisi :";
			this.LblBekarPer.AutoSize = true;
			this.LblBekarPer.Font = new global::System.Drawing.Font("Arial", 15.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 162);
			this.LblBekarPer.Location = new global::System.Drawing.Point(259, 96);
			this.LblBekarPer.Name = "LblBekarPer";
			this.LblBekarPer.Size = new global::System.Drawing.Size(22, 24);
			this.LblBekarPer.TabIndex = 5;
			this.LblBekarPer.Text = "0";
			this.label7.AutoSize = true;
			this.label7.Location = new global::System.Drawing.Point(118, 130);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(135, 24);
			this.label7.TabIndex = 6;
			this.label7.Text = "Sehir Sayisi :";
			this.LblSehir.AutoSize = true;
			this.LblSehir.Font = new global::System.Drawing.Font("Arial", 15.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 162);
			this.LblSehir.Location = new global::System.Drawing.Point(259, 130);
			this.LblSehir.Name = "LblSehir";
			this.LblSehir.Size = new global::System.Drawing.Size(22, 24);
			this.LblSehir.TabIndex = 7;
			this.LblSehir.Text = "0";
			this.label9.AutoSize = true;
			this.label9.Location = new global::System.Drawing.Point(108, 164);
			this.label9.Name = "label9";
			this.label9.Size = new global::System.Drawing.Size(145, 24);
			this.label9.TabIndex = 8;
			this.label9.Text = "Toplam Maas :";
			this.LblTopMaas.AutoSize = true;
			this.LblTopMaas.Font = new global::System.Drawing.Font("Arial", 15.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 162);
			this.LblTopMaas.Location = new global::System.Drawing.Point(259, 163);
			this.LblTopMaas.Name = "LblTopMaas";
			this.LblTopMaas.Size = new global::System.Drawing.Size(22, 24);
			this.LblTopMaas.TabIndex = 9;
			this.LblTopMaas.Text = "0";
			this.label11.AutoSize = true;
			this.label11.Font = new global::System.Drawing.Font("Arial", 15.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 162);
			this.label11.Location = new global::System.Drawing.Point(88, 195);
			this.label11.Name = "label11";
			this.label11.Size = new global::System.Drawing.Size(165, 24);
			this.label11.TabIndex = 10;
			this.label11.Text = "Ortalama Maas :";
			this.LblOrtMaas.AutoSize = true;
			this.LblOrtMaas.Font = new global::System.Drawing.Font("Arial", 15.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 162);
			this.LblOrtMaas.Location = new global::System.Drawing.Point(259, 195);
			this.LblOrtMaas.Name = "LblOrtMaas";
			this.LblOrtMaas.Size = new global::System.Drawing.Size(22, 24);
			this.LblOrtMaas.TabIndex = 11;
			this.LblOrtMaas.Text = "0";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(12f, 24f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.LightSeaGreen;
			base.ClientSize = new global::System.Drawing.Size(369, 259);
			base.Controls.Add(this.LblOrtMaas);
			base.Controls.Add(this.label11);
			base.Controls.Add(this.LblTopMaas);
			base.Controls.Add(this.label9);
			base.Controls.Add(this.LblSehir);
			base.Controls.Add(this.label7);
			base.Controls.Add(this.LblBekarPer);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.LblEvliPer);
			base.Controls.Add(this.LblTopPer);
			base.Controls.Add(this.label1);
			this.Font = new global::System.Drawing.Font("Arial", 15.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 162);
			base.Margin = new global::System.Windows.Forms.Padding(5, 5, 5, 5);
			base.Name = "FrmIstatistik";
			this.Text = "FrmIstatistik";
			base.Load += new global::System.EventHandler(this.FrmIstatistik_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000031 RID: 49
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000032 RID: 50
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000033 RID: 51
		private global::System.Windows.Forms.Label LblTopPer;

		// Token: 0x04000034 RID: 52
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000035 RID: 53
		private global::System.Windows.Forms.Label LblEvliPer;

		// Token: 0x04000036 RID: 54
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000037 RID: 55
		private global::System.Windows.Forms.Label LblBekarPer;

		// Token: 0x04000038 RID: 56
		private global::System.Windows.Forms.Label label7;

		// Token: 0x04000039 RID: 57
		private global::System.Windows.Forms.Label LblSehir;

		// Token: 0x0400003A RID: 58
		private global::System.Windows.Forms.Label label9;

		// Token: 0x0400003B RID: 59
		private global::System.Windows.Forms.Label LblTopMaas;

		// Token: 0x0400003C RID: 60
		private global::System.Windows.Forms.Label label11;

		// Token: 0x0400003D RID: 61
		private global::System.Windows.Forms.Label LblOrtMaas;
	}
}
