using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using PersonelKayitSistemi.Properties;

namespace PersonelKayitSistemi.PersonelVeriTabaniDataSetTableAdapters
{
	// Token: 0x0200000A RID: 10
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[DataObject(true)]
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[HelpKeyword("vs.data.TableAdapter")]
	public class Tbl_PersonelTableAdapter : Component
	{
		// Token: 0x06000037 RID: 55 RVA: 0x000059E1 File Offset: 0x00003BE1
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public Tbl_PersonelTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000038 RID: 56 RVA: 0x000059F4 File Offset: 0x00003BF4
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected internal SqlDataAdapter Adapter
		{
			get
			{
				bool flag = this._adapter == null;
				if (flag)
				{
					this.InitAdapter();
				}
				return this._adapter;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000039 RID: 57 RVA: 0x00005A24 File Offset: 0x00003C24
		// (set) Token: 0x0600003A RID: 58 RVA: 0x00005A54 File Offset: 0x00003C54
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		internal SqlConnection Connection
		{
			get
			{
				bool flag = this._connection == null;
				if (flag)
				{
					this.InitConnection();
				}
				return this._connection;
			}
			set
			{
				this._connection = value;
				bool flag = this.Adapter.InsertCommand != null;
				if (flag)
				{
					this.Adapter.InsertCommand.Connection = value;
				}
				bool flag2 = this.Adapter.DeleteCommand != null;
				if (flag2)
				{
					this.Adapter.DeleteCommand.Connection = value;
				}
				bool flag3 = this.Adapter.UpdateCommand != null;
				if (flag3)
				{
					this.Adapter.UpdateCommand.Connection = value;
				}
				for (int i = 0; i < this.CommandCollection.Length; i++)
				{
					bool flag4 = this.CommandCollection[i] != null;
					if (flag4)
					{
						this.CommandCollection[i].Connection = value;
					}
				}
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600003B RID: 59 RVA: 0x00005B18 File Offset: 0x00003D18
		// (set) Token: 0x0600003C RID: 60 RVA: 0x00005B30 File Offset: 0x00003D30
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		internal SqlTransaction Transaction
		{
			get
			{
				return this._transaction;
			}
			set
			{
				this._transaction = value;
				for (int i = 0; i < this.CommandCollection.Length; i++)
				{
					this.CommandCollection[i].Transaction = this._transaction;
				}
				bool flag = this.Adapter != null && this.Adapter.DeleteCommand != null;
				if (flag)
				{
					this.Adapter.DeleteCommand.Transaction = this._transaction;
				}
				bool flag2 = this.Adapter != null && this.Adapter.InsertCommand != null;
				if (flag2)
				{
					this.Adapter.InsertCommand.Transaction = this._transaction;
				}
				bool flag3 = this.Adapter != null && this.Adapter.UpdateCommand != null;
				if (flag3)
				{
					this.Adapter.UpdateCommand.Transaction = this._transaction;
				}
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600003D RID: 61 RVA: 0x00005C18 File Offset: 0x00003E18
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected SqlCommand[] CommandCollection
		{
			get
			{
				bool flag = this._commandCollection == null;
				if (flag)
				{
					this.InitCommandCollection();
				}
				return this._commandCollection;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600003E RID: 62 RVA: 0x00005C48 File Offset: 0x00003E48
		// (set) Token: 0x0600003F RID: 63 RVA: 0x00005C60 File Offset: 0x00003E60
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool ClearBeforeFill
		{
			get
			{
				return this._clearBeforeFill;
			}
			set
			{
				this._clearBeforeFill = value;
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00005C6C File Offset: 0x00003E6C
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping tableMapping = new DataTableMapping();
			tableMapping.SourceTable = "Table";
			tableMapping.DataSetTable = "Tbl_Personel";
			tableMapping.ColumnMappings.Add("Perid", "Perid");
			tableMapping.ColumnMappings.Add("PerAd", "PerAd");
			tableMapping.ColumnMappings.Add("PerSoyad", "PerSoyad");
			tableMapping.ColumnMappings.Add("PerSehir", "PerSehir");
			tableMapping.ColumnMappings.Add("PerMaas", "PerMaas");
			tableMapping.ColumnMappings.Add("PerDurum", "PerDurum");
			tableMapping.ColumnMappings.Add("PerMeslek", "PerMeslek");
			this._adapter.TableMappings.Add(tableMapping);
			this._adapter.InsertCommand = new SqlCommand();
			this._adapter.InsertCommand.Connection = this.Connection;
			this._adapter.InsertCommand.CommandText = "INSERT INTO [dbo].[Tbl_Personel] ([PerAd], [PerSoyad], [PerSehir], [PerMaas], [PerDurum], [PerMeslek]) VALUES (@PerAd, @PerSoyad, @PerSehir, @PerMaas, @PerDurum, @PerMeslek)";
			this._adapter.InsertCommand.CommandType = CommandType.Text;
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@PerAd", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "PerAd", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@PerSoyad", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "PerSoyad", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@PerSehir", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "PerSehir", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@PerMaas", SqlDbType.SmallInt, 0, ParameterDirection.Input, 0, 0, "PerMaas", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@PerDurum", SqlDbType.Bit, 0, ParameterDirection.Input, 0, 0, "PerDurum", DataRowVersion.Current, false, null, "", "", ""));
			this._adapter.InsertCommand.Parameters.Add(new SqlParameter("@PerMeslek", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "PerMeslek", DataRowVersion.Current, false, null, "", "", ""));
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00005F24 File Offset: 0x00004124
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		private void InitConnection()
		{
			this._connection = new SqlConnection();
			this._connection.ConnectionString = Settings.Default.PersonelVeriTabaniConnectionString;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00005F48 File Offset: 0x00004148
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[1];
			this._commandCollection[0] = new SqlCommand();
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "SELECT Perid, PerAd, PerSoyad, PerSehir, PerMaas, PerDurum, PerMeslek FROM dbo.Tbl_Personel";
			this._commandCollection[0].CommandType = CommandType.Text;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00005FA8 File Offset: 0x000041A8
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		public virtual int Fill(PersonelVeriTabaniDataSet.Tbl_PersonelDataTable dataTable)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			bool clearBeforeFill = this.ClearBeforeFill;
			if (clearBeforeFill)
			{
				dataTable.Clear();
			}
			return this.Adapter.Fill(dataTable);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00005FF0 File Offset: 0x000041F0
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Select, true)]
		public virtual PersonelVeriTabaniDataSet.Tbl_PersonelDataTable GetData()
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			PersonelVeriTabaniDataSet.Tbl_PersonelDataTable dataTable = new PersonelVeriTabaniDataSet.Tbl_PersonelDataTable();
			this.Adapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x0000602C File Offset: 0x0000422C
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Update(PersonelVeriTabaniDataSet.Tbl_PersonelDataTable dataTable)
		{
			return this.Adapter.Update(dataTable);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x0000604C File Offset: 0x0000424C
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Update(PersonelVeriTabaniDataSet dataSet)
		{
			return this.Adapter.Update(dataSet, "Tbl_Personel");
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00006070 File Offset: 0x00004270
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Update(DataRow dataRow)
		{
			return this.Adapter.Update(new DataRow[]
			{
				dataRow
			});
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00006098 File Offset: 0x00004298
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Update(DataRow[] dataRows)
		{
			return this.Adapter.Update(dataRows);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x000060B8 File Offset: 0x000042B8
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Insert, true)]
		public virtual int Insert(string PerAd, string PerSoyad, string PerSehir, short? PerMaas, bool? PerDurum, string PerMeslek)
		{
			bool flag = PerAd == null;
			if (flag)
			{
				this.Adapter.InsertCommand.Parameters[0].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[0].Value = PerAd;
			}
			bool flag2 = PerSoyad == null;
			if (flag2)
			{
				this.Adapter.InsertCommand.Parameters[1].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[1].Value = PerSoyad;
			}
			bool flag3 = PerSehir == null;
			if (flag3)
			{
				this.Adapter.InsertCommand.Parameters[2].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[2].Value = PerSehir;
			}
			bool flag4 = PerMaas != null;
			if (flag4)
			{
				this.Adapter.InsertCommand.Parameters[3].Value = PerMaas.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[3].Value = DBNull.Value;
			}
			bool flag5 = PerDurum != null;
			if (flag5)
			{
				this.Adapter.InsertCommand.Parameters[4].Value = PerDurum.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[4].Value = DBNull.Value;
			}
			bool flag6 = PerMeslek == null;
			if (flag6)
			{
				this.Adapter.InsertCommand.Parameters[5].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[5].Value = PerMeslek;
			}
			ConnectionState previousConnectionState = this.Adapter.InsertCommand.Connection.State;
			bool flag7 = (this.Adapter.InsertCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open;
			if (flag7)
			{
				this.Adapter.InsertCommand.Connection.Open();
			}
			int result;
			try
			{
				int returnValue = this.Adapter.InsertCommand.ExecuteNonQuery();
				result = returnValue;
			}
			finally
			{
				bool flag8 = previousConnectionState == ConnectionState.Closed;
				if (flag8)
				{
					this.Adapter.InsertCommand.Connection.Close();
				}
			}
			return result;
		}

		// Token: 0x0400004B RID: 75
		private SqlDataAdapter _adapter;

		// Token: 0x0400004C RID: 76
		private SqlConnection _connection;

		// Token: 0x0400004D RID: 77
		private SqlTransaction _transaction;

		// Token: 0x0400004E RID: 78
		private SqlCommand[] _commandCollection;

		// Token: 0x0400004F RID: 79
		private bool _clearBeforeFill;
	}
}
