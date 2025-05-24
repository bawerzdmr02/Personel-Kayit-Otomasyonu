using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace PersonelKayitSistemi
{
	// Token: 0x02000006 RID: 6
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[XmlSchemaProvider("GetTypedDataSetSchema")]
	[XmlRoot("PersonelVeriTabaniDataSet")]
	[HelpKeyword("vs.data.DataSet")]
	[Serializable]
	public class PersonelVeriTabaniDataSet : DataSet
	{
		// Token: 0x0600001B RID: 27 RVA: 0x00005280 File Offset: 0x00003480
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public PersonelVeriTabaniDataSet()
		{
			base.BeginInit();
			this.InitClass();
			CollectionChangeEventHandler schemaChangedHandler = new CollectionChangeEventHandler(this.SchemaChanged);
			base.Tables.CollectionChanged += schemaChangedHandler;
			base.Relations.CollectionChanged += schemaChangedHandler;
			base.EndInit();
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000052D8 File Offset: 0x000034D8
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected PersonelVeriTabaniDataSet(SerializationInfo info, StreamingContext context) : base(info, context, false)
		{
			bool flag = base.IsBinarySerialized(info, context);
			if (flag)
			{
				this.InitVars(false);
				CollectionChangeEventHandler schemaChangedHandler = new CollectionChangeEventHandler(this.SchemaChanged);
				this.Tables.CollectionChanged += schemaChangedHandler;
				this.Relations.CollectionChanged += schemaChangedHandler;
			}
			else
			{
				string strSchema = (string)info.GetValue("XmlSchema", typeof(string));
				bool flag2 = base.DetermineSchemaSerializationMode(info, context) == SchemaSerializationMode.IncludeSchema;
				if (flag2)
				{
					DataSet ds = new DataSet();
					ds.ReadXmlSchema(new XmlTextReader(new StringReader(strSchema)));
					bool flag3 = ds.Tables["Tbl_Personel"] != null;
					if (flag3)
					{
						base.Tables.Add(new PersonelVeriTabaniDataSet.Tbl_PersonelDataTable(ds.Tables["Tbl_Personel"]));
					}
					base.DataSetName = ds.DataSetName;
					base.Prefix = ds.Prefix;
					base.Namespace = ds.Namespace;
					base.Locale = ds.Locale;
					base.CaseSensitive = ds.CaseSensitive;
					base.EnforceConstraints = ds.EnforceConstraints;
					base.Merge(ds, false, MissingSchemaAction.Add);
					this.InitVars();
				}
				else
				{
					base.ReadXmlSchema(new XmlTextReader(new StringReader(strSchema)));
				}
				base.GetSerializationData(info, context);
				CollectionChangeEventHandler schemaChangedHandler2 = new CollectionChangeEventHandler(this.SchemaChanged);
				base.Tables.CollectionChanged += schemaChangedHandler2;
				this.Relations.CollectionChanged += schemaChangedHandler2;
			}
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600001D RID: 29 RVA: 0x00005470 File Offset: 0x00003670
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public PersonelVeriTabaniDataSet.Tbl_PersonelDataTable Tbl_Personel
		{
			get
			{
				return this.tableTbl_Personel;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600001E RID: 30 RVA: 0x00005488 File Offset: 0x00003688
		// (set) Token: 0x0600001F RID: 31 RVA: 0x000054A0 File Offset: 0x000036A0
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[Browsable(true)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		public override SchemaSerializationMode SchemaSerializationMode
		{
			get
			{
				return this._schemaSerializationMode;
			}
			set
			{
				this._schemaSerializationMode = value;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000020 RID: 32 RVA: 0x000054AC File Offset: 0x000036AC
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public new DataTableCollection Tables
		{
			get
			{
				return base.Tables;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000021 RID: 33 RVA: 0x000054C4 File Offset: 0x000036C4
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public new DataRelationCollection Relations
		{
			get
			{
				return base.Relations;
			}
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000054DC File Offset: 0x000036DC
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override void InitializeDerivedDataSet()
		{
			base.BeginInit();
			this.InitClass();
			base.EndInit();
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000054F4 File Offset: 0x000036F4
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public override DataSet Clone()
		{
			PersonelVeriTabaniDataSet cln = (PersonelVeriTabaniDataSet)base.Clone();
			cln.InitVars();
			cln.SchemaSerializationMode = this.SchemaSerializationMode;
			return cln;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00005528 File Offset: 0x00003728
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override bool ShouldSerializeTables()
		{
			return false;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x0000553C File Offset: 0x0000373C
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override bool ShouldSerializeRelations()
		{
			return false;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00005550 File Offset: 0x00003750
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override void ReadXmlSerializable(XmlReader reader)
		{
			bool flag = base.DetermineSchemaSerializationMode(reader) == SchemaSerializationMode.IncludeSchema;
			if (flag)
			{
				this.Reset();
				DataSet ds = new DataSet();
				ds.ReadXml(reader);
				bool flag2 = ds.Tables["Tbl_Personel"] != null;
				if (flag2)
				{
					base.Tables.Add(new PersonelVeriTabaniDataSet.Tbl_PersonelDataTable(ds.Tables["Tbl_Personel"]));
				}
				base.DataSetName = ds.DataSetName;
				base.Prefix = ds.Prefix;
				base.Namespace = ds.Namespace;
				base.Locale = ds.Locale;
				base.CaseSensitive = ds.CaseSensitive;
				base.EnforceConstraints = ds.EnforceConstraints;
				base.Merge(ds, false, MissingSchemaAction.Add);
				this.InitVars();
			}
			else
			{
				base.ReadXml(reader);
				this.InitVars();
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00005634 File Offset: 0x00003834
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override XmlSchema GetSchemaSerializable()
		{
			MemoryStream stream = new MemoryStream();
			base.WriteXmlSchema(new XmlTextWriter(stream, null));
			stream.Position = 0L;
			return XmlSchema.Read(new XmlTextReader(stream), null);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x0000566F File Offset: 0x0000386F
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		internal void InitVars()
		{
			this.InitVars(true);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x0000567C File Offset: 0x0000387C
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		internal void InitVars(bool initTable)
		{
			this.tableTbl_Personel = (PersonelVeriTabaniDataSet.Tbl_PersonelDataTable)base.Tables["Tbl_Personel"];
			if (initTable)
			{
				bool flag = this.tableTbl_Personel != null;
				if (flag)
				{
					this.tableTbl_Personel.InitVars();
				}
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000056C8 File Offset: 0x000038C8
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		private void InitClass()
		{
			base.DataSetName = "PersonelVeriTabaniDataSet";
			base.Prefix = "";
			base.Namespace = "http://tempuri.org/PersonelVeriTabaniDataSet.xsd";
			base.EnforceConstraints = true;
			this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tableTbl_Personel = new PersonelVeriTabaniDataSet.Tbl_PersonelDataTable();
			base.Tables.Add(this.tableTbl_Personel);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00005728 File Offset: 0x00003928
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		private bool ShouldSerializeTbl_Personel()
		{
			return false;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x0000573C File Offset: 0x0000393C
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		private void SchemaChanged(object sender, CollectionChangeEventArgs e)
		{
			bool flag = e.Action == CollectionChangeAction.Remove;
			if (flag)
			{
				this.InitVars();
			}
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00005760 File Offset: 0x00003960
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
		{
			PersonelVeriTabaniDataSet ds = new PersonelVeriTabaniDataSet();
			XmlSchemaComplexType type = new XmlSchemaComplexType();
			XmlSchemaSequence sequence = new XmlSchemaSequence();
			XmlSchemaAny any = new XmlSchemaAny();
			any.Namespace = ds.Namespace;
			sequence.Items.Add(any);
			type.Particle = sequence;
			XmlSchema dsSchema = ds.GetSchemaSerializable();
			bool flag = xs.Contains(dsSchema.TargetNamespace);
			if (flag)
			{
				MemoryStream s = new MemoryStream();
				MemoryStream s2 = new MemoryStream();
				try
				{
					dsSchema.Write(s);
					foreach (object obj in xs.Schemas(dsSchema.TargetNamespace))
					{
						XmlSchema schema = (XmlSchema)obj;
						s2.SetLength(0L);
						schema.Write(s2);
						bool flag2 = s.Length == s2.Length;
						if (flag2)
						{
							s.Position = 0L;
							s2.Position = 0L;
							while (s.Position != s.Length && s.ReadByte() == s2.ReadByte())
							{
							}
							bool flag3 = s.Position == s.Length;
							if (flag3)
							{
								return type;
							}
						}
					}
				}
				finally
				{
					bool flag4 = s != null;
					if (flag4)
					{
						s.Close();
					}
					bool flag5 = s2 != null;
					if (flag5)
					{
						s2.Close();
					}
				}
			}
			xs.Add(dsSchema);
			return type;
		}

		// Token: 0x04000046 RID: 70
		private PersonelVeriTabaniDataSet.Tbl_PersonelDataTable tableTbl_Personel;

		// Token: 0x04000047 RID: 71
		private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

		// Token: 0x0200000C RID: 12
		// (Invoke) Token: 0x0600005C RID: 92
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public delegate void Tbl_PersonelRowChangeEventHandler(object sender, PersonelVeriTabaniDataSet.Tbl_PersonelRowChangeEvent e);

		// Token: 0x0200000D RID: 13
		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class Tbl_PersonelDataTable : TypedTableBase<PersonelVeriTabaniDataSet.Tbl_PersonelRow>
		{
			// Token: 0x0600005F RID: 95 RVA: 0x00006AA6 File Offset: 0x00004CA6
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
			public Tbl_PersonelDataTable()
			{
				base.TableName = "Tbl_Personel";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			// Token: 0x06000060 RID: 96 RVA: 0x00006AD4 File Offset: 0x00004CD4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
			internal Tbl_PersonelDataTable(DataTable table)
			{
				base.TableName = table.TableName;
				bool flag = table.CaseSensitive != table.DataSet.CaseSensitive;
				if (flag)
				{
					base.CaseSensitive = table.CaseSensitive;
				}
				bool flag2 = table.Locale.ToString() != table.DataSet.Locale.ToString();
				if (flag2)
				{
					base.Locale = table.Locale;
				}
				bool flag3 = table.Namespace != table.DataSet.Namespace;
				if (flag3)
				{
					base.Namespace = table.Namespace;
				}
				base.Prefix = table.Prefix;
				base.MinimumCapacity = table.MinimumCapacity;
			}

			// Token: 0x06000061 RID: 97 RVA: 0x00006B95 File Offset: 0x00004D95
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
			protected Tbl_PersonelDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.InitVars();
			}

			// Token: 0x17000013 RID: 19
			// (get) Token: 0x06000062 RID: 98 RVA: 0x00006BA8 File Offset: 0x00004DA8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
			public DataColumn PeridColumn
			{
				get
				{
					return this.columnPerid;
				}
			}

			// Token: 0x17000014 RID: 20
			// (get) Token: 0x06000063 RID: 99 RVA: 0x00006BC0 File Offset: 0x00004DC0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
			public DataColumn PerAdColumn
			{
				get
				{
					return this.columnPerAd;
				}
			}

			// Token: 0x17000015 RID: 21
			// (get) Token: 0x06000064 RID: 100 RVA: 0x00006BD8 File Offset: 0x00004DD8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
			public DataColumn PerSoyadColumn
			{
				get
				{
					return this.columnPerSoyad;
				}
			}

			// Token: 0x17000016 RID: 22
			// (get) Token: 0x06000065 RID: 101 RVA: 0x00006BF0 File Offset: 0x00004DF0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
			public DataColumn PerSehirColumn
			{
				get
				{
					return this.columnPerSehir;
				}
			}

			// Token: 0x17000017 RID: 23
			// (get) Token: 0x06000066 RID: 102 RVA: 0x00006C08 File Offset: 0x00004E08
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
			public DataColumn PerMaasColumn
			{
				get
				{
					return this.columnPerMaas;
				}
			}

			// Token: 0x17000018 RID: 24
			// (get) Token: 0x06000067 RID: 103 RVA: 0x00006C20 File Offset: 0x00004E20
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
			public DataColumn PerDurumColumn
			{
				get
				{
					return this.columnPerDurum;
				}
			}

			// Token: 0x17000019 RID: 25
			// (get) Token: 0x06000068 RID: 104 RVA: 0x00006C38 File Offset: 0x00004E38
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
			public DataColumn PerMeslekColumn
			{
				get
				{
					return this.columnPerMeslek;
				}
			}

			// Token: 0x1700001A RID: 26
			// (get) Token: 0x06000069 RID: 105 RVA: 0x00006C50 File Offset: 0x00004E50
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
			[Browsable(false)]
			public int Count
			{
				get
				{
					return base.Rows.Count;
				}
			}

			// Token: 0x1700001B RID: 27
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
			public PersonelVeriTabaniDataSet.Tbl_PersonelRow this[int index]
			{
				get
				{
					return (PersonelVeriTabaniDataSet.Tbl_PersonelRow)base.Rows[index];
				}
			}

			// Token: 0x14000001 RID: 1
			// (add) Token: 0x0600006B RID: 107 RVA: 0x00006C94 File Offset: 0x00004E94
			// (remove) Token: 0x0600006C RID: 108 RVA: 0x00006CCC File Offset: 0x00004ECC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			public event PersonelVeriTabaniDataSet.Tbl_PersonelRowChangeEventHandler Tbl_PersonelRowChanging;

			// Token: 0x14000002 RID: 2
			// (add) Token: 0x0600006D RID: 109 RVA: 0x00006D04 File Offset: 0x00004F04
			// (remove) Token: 0x0600006E RID: 110 RVA: 0x00006D3C File Offset: 0x00004F3C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			public event PersonelVeriTabaniDataSet.Tbl_PersonelRowChangeEventHandler Tbl_PersonelRowChanged;

			// Token: 0x14000003 RID: 3
			// (add) Token: 0x0600006F RID: 111 RVA: 0x00006D74 File Offset: 0x00004F74
			// (remove) Token: 0x06000070 RID: 112 RVA: 0x00006DAC File Offset: 0x00004FAC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			public event PersonelVeriTabaniDataSet.Tbl_PersonelRowChangeEventHandler Tbl_PersonelRowDeleting;

			// Token: 0x14000004 RID: 4
			// (add) Token: 0x06000071 RID: 113 RVA: 0x00006DE4 File Offset: 0x00004FE4
			// (remove) Token: 0x06000072 RID: 114 RVA: 0x00006E1C File Offset: 0x0000501C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			public event PersonelVeriTabaniDataSet.Tbl_PersonelRowChangeEventHandler Tbl_PersonelRowDeleted;

			// Token: 0x06000073 RID: 115 RVA: 0x00006E51 File Offset: 0x00005051
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
			public void AddTbl_PersonelRow(PersonelVeriTabaniDataSet.Tbl_PersonelRow row)
			{
				base.Rows.Add(row);
			}

			// Token: 0x06000074 RID: 116 RVA: 0x00006E64 File Offset: 0x00005064
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
			public PersonelVeriTabaniDataSet.Tbl_PersonelRow AddTbl_PersonelRow(string PerAd, string PerSoyad, string PerSehir, short PerMaas, bool PerDurum, string PerMeslek)
			{
				PersonelVeriTabaniDataSet.Tbl_PersonelRow rowTbl_PersonelRow = (PersonelVeriTabaniDataSet.Tbl_PersonelRow)base.NewRow();
				object[] columnValuesArray = new object[]
				{
					null,
					PerAd,
					PerSoyad,
					PerSehir,
					PerMaas,
					PerDurum,
					PerMeslek
				};
				rowTbl_PersonelRow.ItemArray = columnValuesArray;
				base.Rows.Add(rowTbl_PersonelRow);
				return rowTbl_PersonelRow;
			}

			// Token: 0x06000075 RID: 117 RVA: 0x00006EC4 File Offset: 0x000050C4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
			public override DataTable Clone()
			{
				PersonelVeriTabaniDataSet.Tbl_PersonelDataTable cln = (PersonelVeriTabaniDataSet.Tbl_PersonelDataTable)base.Clone();
				cln.InitVars();
				return cln;
			}

			// Token: 0x06000076 RID: 118 RVA: 0x00006EEC File Offset: 0x000050EC
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new PersonelVeriTabaniDataSet.Tbl_PersonelDataTable();
			}

			// Token: 0x06000077 RID: 119 RVA: 0x00006F04 File Offset: 0x00005104
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
			internal void InitVars()
			{
				this.columnPerid = base.Columns["Perid"];
				this.columnPerAd = base.Columns["PerAd"];
				this.columnPerSoyad = base.Columns["PerSoyad"];
				this.columnPerSehir = base.Columns["PerSehir"];
				this.columnPerMaas = base.Columns["PerMaas"];
				this.columnPerDurum = base.Columns["PerDurum"];
				this.columnPerMeslek = base.Columns["PerMeslek"];
			}

			// Token: 0x06000078 RID: 120 RVA: 0x00006FAC File Offset: 0x000051AC
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
			private void InitClass()
			{
				this.columnPerid = new DataColumn("Perid", typeof(short), null, MappingType.Element);
				base.Columns.Add(this.columnPerid);
				this.columnPerAd = new DataColumn("PerAd", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnPerAd);
				this.columnPerSoyad = new DataColumn("PerSoyad", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnPerSoyad);
				this.columnPerSehir = new DataColumn("PerSehir", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnPerSehir);
				this.columnPerMaas = new DataColumn("PerMaas", typeof(short), null, MappingType.Element);
				base.Columns.Add(this.columnPerMaas);
				this.columnPerDurum = new DataColumn("PerDurum", typeof(bool), null, MappingType.Element);
				base.Columns.Add(this.columnPerDurum);
				this.columnPerMeslek = new DataColumn("PerMeslek", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnPerMeslek);
				this.columnPerid.AutoIncrement = true;
				this.columnPerid.AutoIncrementSeed = -1L;
				this.columnPerid.AutoIncrementStep = -1L;
				this.columnPerid.AllowDBNull = false;
				this.columnPerid.ReadOnly = true;
				this.columnPerAd.MaxLength = 10;
				this.columnPerSoyad.MaxLength = 20;
				this.columnPerSehir.MaxLength = 13;
				this.columnPerMeslek.MaxLength = 15;
			}

			// Token: 0x06000079 RID: 121 RVA: 0x00007178 File Offset: 0x00005378
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
			public PersonelVeriTabaniDataSet.Tbl_PersonelRow NewTbl_PersonelRow()
			{
				return (PersonelVeriTabaniDataSet.Tbl_PersonelRow)base.NewRow();
			}

			// Token: 0x0600007A RID: 122 RVA: 0x00007198 File Offset: 0x00005398
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new PersonelVeriTabaniDataSet.Tbl_PersonelRow(builder);
			}

			// Token: 0x0600007B RID: 123 RVA: 0x000071B0 File Offset: 0x000053B0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(PersonelVeriTabaniDataSet.Tbl_PersonelRow);
			}

			// Token: 0x0600007C RID: 124 RVA: 0x000071CC File Offset: 0x000053CC
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				bool flag = this.Tbl_PersonelRowChanged != null;
				if (flag)
				{
					this.Tbl_PersonelRowChanged(this, new PersonelVeriTabaniDataSet.Tbl_PersonelRowChangeEvent((PersonelVeriTabaniDataSet.Tbl_PersonelRow)e.Row, e.Action));
				}
			}

			// Token: 0x0600007D RID: 125 RVA: 0x00007214 File Offset: 0x00005414
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				bool flag = this.Tbl_PersonelRowChanging != null;
				if (flag)
				{
					this.Tbl_PersonelRowChanging(this, new PersonelVeriTabaniDataSet.Tbl_PersonelRowChangeEvent((PersonelVeriTabaniDataSet.Tbl_PersonelRow)e.Row, e.Action));
				}
			}

			// Token: 0x0600007E RID: 126 RVA: 0x0000725C File Offset: 0x0000545C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				bool flag = this.Tbl_PersonelRowDeleted != null;
				if (flag)
				{
					this.Tbl_PersonelRowDeleted(this, new PersonelVeriTabaniDataSet.Tbl_PersonelRowChangeEvent((PersonelVeriTabaniDataSet.Tbl_PersonelRow)e.Row, e.Action));
				}
			}

			// Token: 0x0600007F RID: 127 RVA: 0x000072A4 File Offset: 0x000054A4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				bool flag = this.Tbl_PersonelRowDeleting != null;
				if (flag)
				{
					this.Tbl_PersonelRowDeleting(this, new PersonelVeriTabaniDataSet.Tbl_PersonelRowChangeEvent((PersonelVeriTabaniDataSet.Tbl_PersonelRow)e.Row, e.Action));
				}
			}

			// Token: 0x06000080 RID: 128 RVA: 0x000072EC File Offset: 0x000054EC
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
			public void RemoveTbl_PersonelRow(PersonelVeriTabaniDataSet.Tbl_PersonelRow row)
			{
				base.Rows.Remove(row);
			}

			// Token: 0x06000081 RID: 129 RVA: 0x000072FC File Offset: 0x000054FC
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType type = new XmlSchemaComplexType();
				XmlSchemaSequence sequence = new XmlSchemaSequence();
				PersonelVeriTabaniDataSet ds = new PersonelVeriTabaniDataSet();
				XmlSchemaAny any = new XmlSchemaAny();
				any.Namespace = "http://www.w3.org/2001/XMLSchema";
				any.MinOccurs = 0m;
				any.MaxOccurs = decimal.MaxValue;
				any.ProcessContents = XmlSchemaContentProcessing.Lax;
				sequence.Items.Add(any);
				XmlSchemaAny any2 = new XmlSchemaAny();
				any2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
				any2.MinOccurs = 1m;
				any2.ProcessContents = XmlSchemaContentProcessing.Lax;
				sequence.Items.Add(any2);
				XmlSchemaAttribute attribute = new XmlSchemaAttribute();
				attribute.Name = "namespace";
				attribute.FixedValue = ds.Namespace;
				type.Attributes.Add(attribute);
				XmlSchemaAttribute attribute2 = new XmlSchemaAttribute();
				attribute2.Name = "tableTypeName";
				attribute2.FixedValue = "Tbl_PersonelDataTable";
				type.Attributes.Add(attribute2);
				type.Particle = sequence;
				XmlSchema dsSchema = ds.GetSchemaSerializable();
				bool flag = xs.Contains(dsSchema.TargetNamespace);
				if (flag)
				{
					MemoryStream s = new MemoryStream();
					MemoryStream s2 = new MemoryStream();
					try
					{
						dsSchema.Write(s);
						foreach (object obj in xs.Schemas(dsSchema.TargetNamespace))
						{
							XmlSchema schema = (XmlSchema)obj;
							s2.SetLength(0L);
							schema.Write(s2);
							bool flag2 = s.Length == s2.Length;
							if (flag2)
							{
								s.Position = 0L;
								s2.Position = 0L;
								while (s.Position != s.Length && s.ReadByte() == s2.ReadByte())
								{
								}
								bool flag3 = s.Position == s.Length;
								if (flag3)
								{
									return type;
								}
							}
						}
					}
					finally
					{
						bool flag4 = s != null;
						if (flag4)
						{
							s.Close();
						}
						bool flag5 = s2 != null;
						if (flag5)
						{
							s2.Close();
						}
					}
				}
				xs.Add(dsSchema);
				return type;
			}

			// Token: 0x04000054 RID: 84
			private DataColumn columnPerid;

			// Token: 0x04000055 RID: 85
			private DataColumn columnPerAd;

			// Token: 0x04000056 RID: 86
			private DataColumn columnPerSoyad;

			// Token: 0x04000057 RID: 87
			private DataColumn columnPerSehir;

			// Token: 0x04000058 RID: 88
			private DataColumn columnPerMaas;

			// Token: 0x04000059 RID: 89
			private DataColumn columnPerDurum;

			// Token: 0x0400005A RID: 90
			private DataColumn columnPerMeslek;
		}

		// Token: 0x0200000E RID: 14
		public class Tbl_PersonelRow : DataRow
		{
			// Token: 0x06000082 RID: 130 RVA: 0x00007550 File Offset: 0x00005750
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
			internal Tbl_PersonelRow(DataRowBuilder rb) : base(rb)
			{
				this.tableTbl_Personel = (PersonelVeriTabaniDataSet.Tbl_PersonelDataTable)base.Table;
			}

			// Token: 0x1700001C RID: 28
			// (get) Token: 0x06000083 RID: 131 RVA: 0x0000756C File Offset: 0x0000576C
			// (set) Token: 0x06000084 RID: 132 RVA: 0x00007594 File Offset: 0x00005794
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
			public short Perid
			{
				get
				{
					return (short)base[this.tableTbl_Personel.PeridColumn];
				}
				set
				{
					base[this.tableTbl_Personel.PeridColumn] = value;
				}
			}

			// Token: 0x1700001D RID: 29
			// (get) Token: 0x06000085 RID: 133 RVA: 0x000075B0 File Offset: 0x000057B0
			// (set) Token: 0x06000086 RID: 134 RVA: 0x000075F8 File Offset: 0x000057F8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
			public string PerAd
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableTbl_Personel.PerAdColumn];
					}
					catch (InvalidCastException e)
					{
						throw new StrongTypingException("The value for column 'PerAd' in table 'Tbl_Personel' is DBNull.", e);
					}
					return result;
				}
				set
				{
					base[this.tableTbl_Personel.PerAdColumn] = value;
				}
			}

			// Token: 0x1700001E RID: 30
			// (get) Token: 0x06000087 RID: 135 RVA: 0x00007610 File Offset: 0x00005810
			// (set) Token: 0x06000088 RID: 136 RVA: 0x00007658 File Offset: 0x00005858
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
			public string PerSoyad
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableTbl_Personel.PerSoyadColumn];
					}
					catch (InvalidCastException e)
					{
						throw new StrongTypingException("The value for column 'PerSoyad' in table 'Tbl_Personel' is DBNull.", e);
					}
					return result;
				}
				set
				{
					base[this.tableTbl_Personel.PerSoyadColumn] = value;
				}
			}

			// Token: 0x1700001F RID: 31
			// (get) Token: 0x06000089 RID: 137 RVA: 0x00007670 File Offset: 0x00005870
			// (set) Token: 0x0600008A RID: 138 RVA: 0x000076B8 File Offset: 0x000058B8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
			public string PerSehir
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableTbl_Personel.PerSehirColumn];
					}
					catch (InvalidCastException e)
					{
						throw new StrongTypingException("The value for column 'PerSehir' in table 'Tbl_Personel' is DBNull.", e);
					}
					return result;
				}
				set
				{
					base[this.tableTbl_Personel.PerSehirColumn] = value;
				}
			}

			// Token: 0x17000020 RID: 32
			// (get) Token: 0x0600008B RID: 139 RVA: 0x000076D0 File Offset: 0x000058D0
			// (set) Token: 0x0600008C RID: 140 RVA: 0x00007718 File Offset: 0x00005918
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
			public short PerMaas
			{
				get
				{
					short result;
					try
					{
						result = (short)base[this.tableTbl_Personel.PerMaasColumn];
					}
					catch (InvalidCastException e)
					{
						throw new StrongTypingException("The value for column 'PerMaas' in table 'Tbl_Personel' is DBNull.", e);
					}
					return result;
				}
				set
				{
					base[this.tableTbl_Personel.PerMaasColumn] = value;
				}
			}

			// Token: 0x17000021 RID: 33
			// (get) Token: 0x0600008D RID: 141 RVA: 0x00007734 File Offset: 0x00005934
			// (set) Token: 0x0600008E RID: 142 RVA: 0x0000777C File Offset: 0x0000597C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
			public bool PerDurum
			{
				get
				{
					bool result;
					try
					{
						result = (bool)base[this.tableTbl_Personel.PerDurumColumn];
					}
					catch (InvalidCastException e)
					{
						throw new StrongTypingException("The value for column 'PerDurum' in table 'Tbl_Personel' is DBNull.", e);
					}
					return result;
				}
				set
				{
					base[this.tableTbl_Personel.PerDurumColumn] = value;
				}
			}

			// Token: 0x17000022 RID: 34
			// (get) Token: 0x0600008F RID: 143 RVA: 0x00007798 File Offset: 0x00005998
			// (set) Token: 0x06000090 RID: 144 RVA: 0x000077E0 File Offset: 0x000059E0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
			public string PerMeslek
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tableTbl_Personel.PerMeslekColumn];
					}
					catch (InvalidCastException e)
					{
						throw new StrongTypingException("The value for column 'PerMeslek' in table 'Tbl_Personel' is DBNull.", e);
					}
					return result;
				}
				set
				{
					base[this.tableTbl_Personel.PerMeslekColumn] = value;
				}
			}

			// Token: 0x06000091 RID: 145 RVA: 0x000077F8 File Offset: 0x000059F8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
			public bool IsPerAdNull()
			{
				return base.IsNull(this.tableTbl_Personel.PerAdColumn);
			}

			// Token: 0x06000092 RID: 146 RVA: 0x0000781B File Offset: 0x00005A1B
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
			public void SetPerAdNull()
			{
				base[this.tableTbl_Personel.PerAdColumn] = Convert.DBNull;
			}

			// Token: 0x06000093 RID: 147 RVA: 0x00007838 File Offset: 0x00005A38
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
			public bool IsPerSoyadNull()
			{
				return base.IsNull(this.tableTbl_Personel.PerSoyadColumn);
			}

			// Token: 0x06000094 RID: 148 RVA: 0x0000785B File Offset: 0x00005A5B
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
			public void SetPerSoyadNull()
			{
				base[this.tableTbl_Personel.PerSoyadColumn] = Convert.DBNull;
			}

			// Token: 0x06000095 RID: 149 RVA: 0x00007878 File Offset: 0x00005A78
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
			public bool IsPerSehirNull()
			{
				return base.IsNull(this.tableTbl_Personel.PerSehirColumn);
			}

			// Token: 0x06000096 RID: 150 RVA: 0x0000789B File Offset: 0x00005A9B
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
			public void SetPerSehirNull()
			{
				base[this.tableTbl_Personel.PerSehirColumn] = Convert.DBNull;
			}

			// Token: 0x06000097 RID: 151 RVA: 0x000078B8 File Offset: 0x00005AB8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
			public bool IsPerMaasNull()
			{
				return base.IsNull(this.tableTbl_Personel.PerMaasColumn);
			}

			// Token: 0x06000098 RID: 152 RVA: 0x000078DB File Offset: 0x00005ADB
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
			public void SetPerMaasNull()
			{
				base[this.tableTbl_Personel.PerMaasColumn] = Convert.DBNull;
			}

			// Token: 0x06000099 RID: 153 RVA: 0x000078F8 File Offset: 0x00005AF8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
			public bool IsPerDurumNull()
			{
				return base.IsNull(this.tableTbl_Personel.PerDurumColumn);
			}

			// Token: 0x0600009A RID: 154 RVA: 0x0000791B File Offset: 0x00005B1B
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
			public void SetPerDurumNull()
			{
				base[this.tableTbl_Personel.PerDurumColumn] = Convert.DBNull;
			}

			// Token: 0x0600009B RID: 155 RVA: 0x00007938 File Offset: 0x00005B38
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
			public bool IsPerMeslekNull()
			{
				return base.IsNull(this.tableTbl_Personel.PerMeslekColumn);
			}

			// Token: 0x0600009C RID: 156 RVA: 0x0000795B File Offset: 0x00005B5B
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
			public void SetPerMeslekNull()
			{
				base[this.tableTbl_Personel.PerMeslekColumn] = Convert.DBNull;
			}

			// Token: 0x0400005F RID: 95
			private PersonelVeriTabaniDataSet.Tbl_PersonelDataTable tableTbl_Personel;
		}

		// Token: 0x0200000F RID: 15
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public class Tbl_PersonelRowChangeEvent : EventArgs
		{
			// Token: 0x0600009D RID: 157 RVA: 0x00007975 File Offset: 0x00005B75
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
			public Tbl_PersonelRowChangeEvent(PersonelVeriTabaniDataSet.Tbl_PersonelRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}

			// Token: 0x17000023 RID: 35
			// (get) Token: 0x0600009E RID: 158 RVA: 0x00007990 File Offset: 0x00005B90
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
			public PersonelVeriTabaniDataSet.Tbl_PersonelRow Row
			{
				get
				{
					return this.eventRow;
				}
			}

			// Token: 0x17000024 RID: 36
			// (get) Token: 0x0600009F RID: 159 RVA: 0x000079A8 File Offset: 0x00005BA8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			// Token: 0x04000060 RID: 96
			private PersonelVeriTabaniDataSet.Tbl_PersonelRow eventRow;

			// Token: 0x04000061 RID: 97
			private DataRowAction eventAction;
		}
	}
}
