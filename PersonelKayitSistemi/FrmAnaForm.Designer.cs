namespace PersonelKayitSistemi
{
	// Token: 0x02000002 RID: 2
	public partial class FrmAnaForm : global::System.Windows.Forms.Form
	{
		// Token: 0x0600000C RID: 12 RVA: 0x00002644 File Offset: 0x00000844
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x0000267C File Offset: 0x0000087C
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.ComponentModel.ComponentResourceManager resources = new global::System.ComponentModel.ComponentResourceManager(typeof(global::PersonelKayitSistemi.FrmAnaForm));
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.MtbMaas = new global::System.Windows.Forms.MaskedTextBox();
			this.RBekar = new global::System.Windows.Forms.RadioButton();
			this.REvli = new global::System.Windows.Forms.RadioButton();
			this.TxtMeslek = new global::System.Windows.Forms.TextBox();
			this.CmbSehir = new global::System.Windows.Forms.ComboBox();
			this.TxtSoyad = new global::System.Windows.Forms.TextBox();
			this.TxtAd = new global::System.Windows.Forms.TextBox();
			this.TxtPersonelid = new global::System.Windows.Forms.TextBox();
			this.label7 = new global::System.Windows.Forms.Label();
			this.label6 = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.groupBox2 = new global::System.Windows.Forms.GroupBox();
			this.BtnGrafik = new global::System.Windows.Forms.Button();
			this.BtnIstatistik = new global::System.Windows.Forms.Button();
			this.BtnTemizle = new global::System.Windows.Forms.Button();
			this.BtnGun = new global::System.Windows.Forms.Button();
			this.BtnSil = new global::System.Windows.Forms.Button();
			this.BtnKaydet = new global::System.Windows.Forms.Button();
			this.BtnList = new global::System.Windows.Forms.Button();
			this.groupBox3 = new global::System.Windows.Forms.GroupBox();
			this.dataGridView1 = new global::System.Windows.Forms.DataGridView();
			this.peridDataGridViewTextBoxColumn = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.perAdDataGridViewTextBoxColumn = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.perSoyadDataGridViewTextBoxColumn = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.perSehirDataGridViewTextBoxColumn = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.perMaasDataGridViewTextBoxColumn = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.perDurumDataGridViewCheckBoxColumn = new global::System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.perMeslekDataGridViewTextBoxColumn = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tblPersonelBindingSource2 = new global::System.Windows.Forms.BindingSource(this.components);
			this.personelVeriTabaniDataSetBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.personelVeriTabaniDataSet = new global::PersonelKayitSistemi.PersonelVeriTabaniDataSet();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.tblPersonelBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.tbl_PersonelTableAdapter = new global::PersonelKayitSistemi.PersonelVeriTabaniDataSetTableAdapters.Tbl_PersonelTableAdapter();
			this.tblPersonelBindingSource1 = new global::System.Windows.Forms.BindingSource(this.components);
			this.pictureBox2 = new global::System.Windows.Forms.PictureBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dataGridView1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.tblPersonelBindingSource2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.personelVeriTabaniDataSetBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.personelVeriTabaniDataSet).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.tblPersonelBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.tblPersonelBindingSource1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).BeginInit();
			base.SuspendLayout();
			this.groupBox1.Controls.Add(this.MtbMaas);
			this.groupBox1.Controls.Add(this.RBekar);
			this.groupBox1.Controls.Add(this.REvli);
			this.groupBox1.Controls.Add(this.TxtMeslek);
			this.groupBox1.Controls.Add(this.CmbSehir);
			this.groupBox1.Controls.Add(this.TxtSoyad);
			this.groupBox1.Controls.Add(this.TxtAd);
			this.groupBox1.Controls.Add(this.TxtPersonelid);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new global::System.Drawing.Point(5, 9);
			this.groupBox1.Margin = new global::System.Windows.Forms.Padding(2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new global::System.Windows.Forms.Padding(2);
			this.groupBox1.Size = new global::System.Drawing.Size(332, 319);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Personel Kayit";
			this.MtbMaas.Location = new global::System.Drawing.Point(115, 159);
			this.MtbMaas.Margin = new global::System.Windows.Forms.Padding(2);
			this.MtbMaas.Mask = "0000";
			this.MtbMaas.Name = "MtbMaas";
			this.MtbMaas.Size = new global::System.Drawing.Size(113, 26);
			this.MtbMaas.TabIndex = 5;
			this.MtbMaas.ValidatingType = typeof(int);
			this.RBekar.AutoSize = true;
			this.RBekar.Location = new global::System.Drawing.Point(171, 190);
			this.RBekar.Margin = new global::System.Windows.Forms.Padding(2);
			this.RBekar.Name = "RBekar";
			this.RBekar.Size = new global::System.Drawing.Size(68, 22);
			this.RBekar.TabIndex = 7;
			this.RBekar.TabStop = true;
			this.RBekar.Text = "Bekar";
			this.RBekar.UseVisualStyleBackColor = true;
			this.REvli.AutoSize = true;
			this.REvli.Location = new global::System.Drawing.Point(120, 190);
			this.REvli.Margin = new global::System.Windows.Forms.Padding(2);
			this.REvli.Name = "REvli";
			this.REvli.Size = new global::System.Drawing.Size(51, 22);
			this.REvli.TabIndex = 6;
			this.REvli.TabStop = true;
			this.REvli.Text = "Evli";
			this.REvli.UseVisualStyleBackColor = true;
			this.TxtMeslek.Location = new global::System.Drawing.Point(115, 218);
			this.TxtMeslek.Margin = new global::System.Windows.Forms.Padding(2);
			this.TxtMeslek.Name = "TxtMeslek";
			this.TxtMeslek.Size = new global::System.Drawing.Size(113, 26);
			this.TxtMeslek.TabIndex = 8;
			this.CmbSehir.FormattingEnabled = true;
			this.CmbSehir.Location = new global::System.Drawing.Point(115, 128);
			this.CmbSehir.Margin = new global::System.Windows.Forms.Padding(2);
			this.CmbSehir.Name = "CmbSehir";
			this.CmbSehir.Size = new global::System.Drawing.Size(113, 26);
			this.CmbSehir.TabIndex = 4;
			this.TxtSoyad.Location = new global::System.Drawing.Point(115, 99);
			this.TxtSoyad.Margin = new global::System.Windows.Forms.Padding(2);
			this.TxtSoyad.Name = "TxtSoyad";
			this.TxtSoyad.Size = new global::System.Drawing.Size(113, 26);
			this.TxtSoyad.TabIndex = 3;
			this.TxtAd.Location = new global::System.Drawing.Point(115, 72);
			this.TxtAd.Margin = new global::System.Windows.Forms.Padding(2);
			this.TxtAd.Name = "TxtAd";
			this.TxtAd.Size = new global::System.Drawing.Size(113, 26);
			this.TxtAd.TabIndex = 2;
			this.TxtPersonelid.Location = new global::System.Drawing.Point(115, 46);
			this.TxtPersonelid.Margin = new global::System.Windows.Forms.Padding(2);
			this.TxtPersonelid.Name = "TxtPersonelid";
			this.TxtPersonelid.Size = new global::System.Drawing.Size(113, 26);
			this.TxtPersonelid.TabIndex = 1;
			this.label7.AutoSize = true;
			this.label7.Location = new global::System.Drawing.Point(16, 48);
			this.label7.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(93, 18);
			this.label7.TabIndex = 6;
			this.label7.Text = "Personel ID:";
			this.label6.AutoSize = true;
			this.label6.Location = new global::System.Drawing.Point(49, 220);
			this.label6.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(62, 18);
			this.label6.TabIndex = 5;
			this.label6.Text = "Meslek:";
			this.label5.AutoSize = true;
			this.label5.Location = new global::System.Drawing.Point(53, 192);
			this.label5.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(58, 18);
			this.label5.TabIndex = 4;
			this.label5.Text = "Durum:";
			this.label4.AutoSize = true;
			this.label4.Location = new global::System.Drawing.Point(59, 161);
			this.label4.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(51, 18);
			this.label4.TabIndex = 3;
			this.label4.Text = "Maas:";
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(62, 132);
			this.label3.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(49, 18);
			this.label3.TabIndex = 2;
			this.label3.Text = "Sehir:";
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(53, 101);
			this.label2.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(57, 18);
			this.label2.TabIndex = 1;
			this.label2.Text = "Soyad:";
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(80, 74);
			this.label1.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(32, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "Ad:";
			this.groupBox2.Controls.Add(this.BtnGrafik);
			this.groupBox2.Controls.Add(this.BtnIstatistik);
			this.groupBox2.Controls.Add(this.BtnTemizle);
			this.groupBox2.Controls.Add(this.BtnGun);
			this.groupBox2.Controls.Add(this.BtnSil);
			this.groupBox2.Controls.Add(this.BtnKaydet);
			this.groupBox2.Controls.Add(this.BtnList);
			this.groupBox2.Location = new global::System.Drawing.Point(353, 9);
			this.groupBox2.Margin = new global::System.Windows.Forms.Padding(2);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new global::System.Windows.Forms.Padding(2);
			this.groupBox2.Size = new global::System.Drawing.Size(169, 319);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Islemler";
			this.BtnGrafik.Location = new global::System.Drawing.Point(15, 267);
			this.BtnGrafik.Margin = new global::System.Windows.Forms.Padding(2);
			this.BtnGrafik.Name = "BtnGrafik";
			this.BtnGrafik.Size = new global::System.Drawing.Size(134, 32);
			this.BtnGrafik.TabIndex = 6;
			this.BtnGrafik.Text = "Grafikler";
			this.BtnGrafik.UseVisualStyleBackColor = true;
			this.BtnGrafik.Click += new global::System.EventHandler(this.BtnGrafik_Click);
			this.BtnIstatistik.Location = new global::System.Drawing.Point(15, 229);
			this.BtnIstatistik.Margin = new global::System.Windows.Forms.Padding(2);
			this.BtnIstatistik.Name = "BtnIstatistik";
			this.BtnIstatistik.Size = new global::System.Drawing.Size(134, 32);
			this.BtnIstatistik.TabIndex = 5;
			this.BtnIstatistik.Text = "Istatistik";
			this.BtnIstatistik.UseVisualStyleBackColor = true;
			this.BtnIstatistik.Click += new global::System.EventHandler(this.BtnIstatistik_Click);
			this.BtnTemizle.Location = new global::System.Drawing.Point(15, 191);
			this.BtnTemizle.Margin = new global::System.Windows.Forms.Padding(2);
			this.BtnTemizle.Name = "BtnTemizle";
			this.BtnTemizle.Size = new global::System.Drawing.Size(134, 32);
			this.BtnTemizle.TabIndex = 4;
			this.BtnTemizle.Text = "Temizle";
			this.BtnTemizle.UseVisualStyleBackColor = true;
			this.BtnTemizle.Click += new global::System.EventHandler(this.BtnTemizle_Click);
			this.BtnGun.Location = new global::System.Drawing.Point(15, 154);
			this.BtnGun.Margin = new global::System.Windows.Forms.Padding(2);
			this.BtnGun.Name = "BtnGun";
			this.BtnGun.Size = new global::System.Drawing.Size(134, 32);
			this.BtnGun.TabIndex = 3;
			this.BtnGun.Text = "Guncelle";
			this.BtnGun.UseVisualStyleBackColor = true;
			this.BtnGun.Click += new global::System.EventHandler(this.BtnGun_Click);
			this.BtnSil.Location = new global::System.Drawing.Point(15, 118);
			this.BtnSil.Margin = new global::System.Windows.Forms.Padding(2);
			this.BtnSil.Name = "BtnSil";
			this.BtnSil.Size = new global::System.Drawing.Size(134, 32);
			this.BtnSil.TabIndex = 2;
			this.BtnSil.Text = "Sil";
			this.BtnSil.UseVisualStyleBackColor = true;
			this.BtnSil.Click += new global::System.EventHandler(this.BtnSil_Click);
			this.BtnKaydet.Location = new global::System.Drawing.Point(15, 80);
			this.BtnKaydet.Margin = new global::System.Windows.Forms.Padding(2);
			this.BtnKaydet.Name = "BtnKaydet";
			this.BtnKaydet.Size = new global::System.Drawing.Size(134, 32);
			this.BtnKaydet.TabIndex = 1;
			this.BtnKaydet.Text = "Kaydet";
			this.BtnKaydet.UseVisualStyleBackColor = true;
			this.BtnKaydet.Click += new global::System.EventHandler(this.BtnKaydet_Click);
			this.BtnList.Location = new global::System.Drawing.Point(15, 42);
			this.BtnList.Margin = new global::System.Windows.Forms.Padding(2);
			this.BtnList.Name = "BtnList";
			this.BtnList.Size = new global::System.Drawing.Size(134, 32);
			this.BtnList.TabIndex = 0;
			this.BtnList.Text = "Listele";
			this.BtnList.UseVisualStyleBackColor = true;
			this.BtnList.Click += new global::System.EventHandler(this.BtnList_Click);
			this.groupBox3.Controls.Add(this.dataGridView1);
			this.groupBox3.Location = new global::System.Drawing.Point(5, 332);
			this.groupBox3.Margin = new global::System.Windows.Forms.Padding(2);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Padding = new global::System.Windows.Forms.Padding(2);
			this.groupBox3.Size = new global::System.Drawing.Size(796, 188);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Kayitlar";
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			dataGridViewCellStyle.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = global::System.Drawing.Color.LightSeaGreen;
			dataGridViewCellStyle.Font = new global::System.Drawing.Font("Arial", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 162);
			dataGridViewCellStyle.ForeColor = global::System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
			this.dataGridView1.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.peridDataGridViewTextBoxColumn,
				this.perAdDataGridViewTextBoxColumn,
				this.perSoyadDataGridViewTextBoxColumn,
				this.perSehirDataGridViewTextBoxColumn,
				this.perMaasDataGridViewTextBoxColumn,
				this.perDurumDataGridViewCheckBoxColumn,
				this.perMeslekDataGridViewTextBoxColumn
			});
			this.dataGridView1.DataSource = this.tblPersonelBindingSource2;
			this.dataGridView1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new global::System.Drawing.Point(2, 21);
			this.dataGridView1.Margin = new global::System.Windows.Forms.Padding(2);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new global::System.Drawing.Size(792, 165);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellDoubleClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
			this.peridDataGridViewTextBoxColumn.DataPropertyName = "Perid";
			this.peridDataGridViewTextBoxColumn.HeaderText = "ID";
			this.peridDataGridViewTextBoxColumn.Name = "peridDataGridViewTextBoxColumn";
			this.peridDataGridViewTextBoxColumn.ReadOnly = true;
			this.perAdDataGridViewTextBoxColumn.DataPropertyName = "PerAd";
			this.perAdDataGridViewTextBoxColumn.HeaderText = "Ad";
			this.perAdDataGridViewTextBoxColumn.Name = "perAdDataGridViewTextBoxColumn";
			this.perAdDataGridViewTextBoxColumn.ReadOnly = true;
			this.perSoyadDataGridViewTextBoxColumn.DataPropertyName = "PerSoyad";
			this.perSoyadDataGridViewTextBoxColumn.HeaderText = "Soyad";
			this.perSoyadDataGridViewTextBoxColumn.Name = "perSoyadDataGridViewTextBoxColumn";
			this.perSoyadDataGridViewTextBoxColumn.ReadOnly = true;
			this.perSehirDataGridViewTextBoxColumn.DataPropertyName = "PerSehir";
			this.perSehirDataGridViewTextBoxColumn.HeaderText = "Sehir";
			this.perSehirDataGridViewTextBoxColumn.Name = "perSehirDataGridViewTextBoxColumn";
			this.perSehirDataGridViewTextBoxColumn.ReadOnly = true;
			this.perMaasDataGridViewTextBoxColumn.DataPropertyName = "PerMaas";
			this.perMaasDataGridViewTextBoxColumn.HeaderText = "Maas";
			this.perMaasDataGridViewTextBoxColumn.Name = "perMaasDataGridViewTextBoxColumn";
			this.perMaasDataGridViewTextBoxColumn.ReadOnly = true;
			this.perDurumDataGridViewCheckBoxColumn.DataPropertyName = "PerDurum";
			this.perDurumDataGridViewCheckBoxColumn.HeaderText = "Durum";
			this.perDurumDataGridViewCheckBoxColumn.Name = "perDurumDataGridViewCheckBoxColumn";
			this.perDurumDataGridViewCheckBoxColumn.ReadOnly = true;
			this.perMeslekDataGridViewTextBoxColumn.DataPropertyName = "PerMeslek";
			this.perMeslekDataGridViewTextBoxColumn.HeaderText = "Meslek";
			this.perMeslekDataGridViewTextBoxColumn.Name = "perMeslekDataGridViewTextBoxColumn";
			this.perMeslekDataGridViewTextBoxColumn.ReadOnly = true;
			this.tblPersonelBindingSource2.DataMember = "Tbl_Personel";
			this.tblPersonelBindingSource2.DataSource = this.personelVeriTabaniDataSetBindingSource;
			this.personelVeriTabaniDataSetBindingSource.DataSource = this.personelVeriTabaniDataSet;
			this.personelVeriTabaniDataSetBindingSource.Position = 0;
			this.personelVeriTabaniDataSet.DataSetName = "PersonelVeriTabaniDataSet";
			this.personelVeriTabaniDataSet.SchemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
			this.pictureBox1.Image = (global::System.Drawing.Image)resources.GetObject("pictureBox1.Image");
			this.pictureBox1.Location = new global::System.Drawing.Point(553, 16);
			this.pictureBox1.Margin = new global::System.Windows.Forms.Padding(2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(214, 155);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			this.tblPersonelBindingSource.DataMember = "Tbl_Personel";
			this.tblPersonelBindingSource.DataSource = this.personelVeriTabaniDataSet;
			this.tbl_PersonelTableAdapter.ClearBeforeFill = true;
			this.tblPersonelBindingSource1.DataMember = "Tbl_Personel";
			this.tblPersonelBindingSource1.DataSource = this.personelVeriTabaniDataSetBindingSource;
			this.pictureBox2.Image = (global::System.Drawing.Image)resources.GetObject("pictureBox2.Image");
			this.pictureBox2.Location = new global::System.Drawing.Point(576, 176);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new global::System.Drawing.Size(166, 161);
			this.pictureBox2.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 4;
			this.pictureBox2.TabStop = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 18f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.LightSeaGreen;
			base.ClientSize = new global::System.Drawing.Size(810, 530);
			base.Controls.Add(this.pictureBox2);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.groupBox3);
			base.Controls.Add(this.groupBox2);
			base.Controls.Add(this.groupBox1);
			this.Font = new global::System.Drawing.Font("Arial", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 162);
			base.Margin = new global::System.Windows.Forms.Padding(4);
			base.Name = "FrmAnaForm";
			this.Text = "Personel Panel";
			base.Load += new global::System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.dataGridView1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.tblPersonelBindingSource2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.personelVeriTabaniDataSetBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.personelVeriTabaniDataSet).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.tblPersonelBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.tblPersonelBindingSource1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000002 RID: 2
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000003 RID: 3
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x04000004 RID: 4
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000005 RID: 5
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000006 RID: 6
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000007 RID: 7
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000008 RID: 8
		private global::System.Windows.Forms.RadioButton RBekar;

		// Token: 0x04000009 RID: 9
		private global::System.Windows.Forms.RadioButton REvli;

		// Token: 0x0400000A RID: 10
		private global::System.Windows.Forms.TextBox TxtMeslek;

		// Token: 0x0400000B RID: 11
		private global::System.Windows.Forms.ComboBox CmbSehir;

		// Token: 0x0400000C RID: 12
		private global::System.Windows.Forms.TextBox TxtSoyad;

		// Token: 0x0400000D RID: 13
		private global::System.Windows.Forms.TextBox TxtAd;

		// Token: 0x0400000E RID: 14
		private global::System.Windows.Forms.TextBox TxtPersonelid;

		// Token: 0x0400000F RID: 15
		private global::System.Windows.Forms.Label label7;

		// Token: 0x04000010 RID: 16
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000011 RID: 17
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000012 RID: 18
		private global::System.Windows.Forms.GroupBox groupBox2;

		// Token: 0x04000013 RID: 19
		private global::System.Windows.Forms.Button BtnGrafik;

		// Token: 0x04000014 RID: 20
		private global::System.Windows.Forms.Button BtnIstatistik;

		// Token: 0x04000015 RID: 21
		private global::System.Windows.Forms.Button BtnTemizle;

		// Token: 0x04000016 RID: 22
		private global::System.Windows.Forms.Button BtnGun;

		// Token: 0x04000017 RID: 23
		private global::System.Windows.Forms.Button BtnSil;

		// Token: 0x04000018 RID: 24
		private global::System.Windows.Forms.Button BtnKaydet;

		// Token: 0x04000019 RID: 25
		private global::System.Windows.Forms.Button BtnList;

		// Token: 0x0400001A RID: 26
		private global::System.Windows.Forms.GroupBox groupBox3;

		// Token: 0x0400001B RID: 27
		private global::System.Windows.Forms.DataGridView dataGridView1;

		// Token: 0x0400001C RID: 28
		private global::System.Windows.Forms.MaskedTextBox MtbMaas;

		// Token: 0x0400001D RID: 29
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x0400001E RID: 30
		private global::PersonelKayitSistemi.PersonelVeriTabaniDataSet personelVeriTabaniDataSet;

		// Token: 0x0400001F RID: 31
		private global::System.Windows.Forms.BindingSource tblPersonelBindingSource;

		// Token: 0x04000020 RID: 32
		private global::PersonelKayitSistemi.PersonelVeriTabaniDataSetTableAdapters.Tbl_PersonelTableAdapter tbl_PersonelTableAdapter;

		// Token: 0x04000021 RID: 33
		private global::System.Windows.Forms.BindingSource personelVeriTabaniDataSetBindingSource;

		// Token: 0x04000022 RID: 34
		private global::System.Windows.Forms.BindingSource tblPersonelBindingSource2;

		// Token: 0x04000023 RID: 35
		private global::System.Windows.Forms.BindingSource tblPersonelBindingSource1;

		// Token: 0x04000024 RID: 36
		private global::System.Windows.Forms.DataGridViewTextBoxColumn peridDataGridViewTextBoxColumn;

		// Token: 0x04000025 RID: 37
		private global::System.Windows.Forms.DataGridViewTextBoxColumn perAdDataGridViewTextBoxColumn;

		// Token: 0x04000026 RID: 38
		private global::System.Windows.Forms.DataGridViewTextBoxColumn perSoyadDataGridViewTextBoxColumn;

		// Token: 0x04000027 RID: 39
		private global::System.Windows.Forms.DataGridViewTextBoxColumn perSehirDataGridViewTextBoxColumn;

		// Token: 0x04000028 RID: 40
		private global::System.Windows.Forms.DataGridViewTextBoxColumn perMaasDataGridViewTextBoxColumn;

		// Token: 0x04000029 RID: 41
		private global::System.Windows.Forms.DataGridViewCheckBoxColumn perDurumDataGridViewCheckBoxColumn;

		// Token: 0x0400002A RID: 42
		private global::System.Windows.Forms.DataGridViewTextBoxColumn perMeslekDataGridViewTextBoxColumn;

		// Token: 0x0400002B RID: 43
		private global::System.Windows.Forms.PictureBox pictureBox2;
	}
}
