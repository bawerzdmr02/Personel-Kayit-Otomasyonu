using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;

namespace PersonelKayitSistemi.PersonelVeriTabaniDataSetTableAdapters
{
	// Token: 0x0200000B RID: 11
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[HelpKeyword("vs.data.TableAdapterManager")]
	public class TableAdapterManager : Component
	{
		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600004A RID: 74 RVA: 0x00006354 File Offset: 0x00004554
		// (set) Token: 0x0600004B RID: 75 RVA: 0x0000636C File Offset: 0x0000456C
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public TableAdapterManager.UpdateOrderOption UpdateOrder
		{
			get
			{
				return this._updateOrder;
			}
			set
			{
				this._updateOrder = value;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600004C RID: 76 RVA: 0x00006378 File Offset: 0x00004578
		// (set) Token: 0x0600004D RID: 77 RVA: 0x00006390 File Offset: 0x00004590
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
		public Tbl_PersonelTableAdapter Tbl_PersonelTableAdapter
		{
			get
			{
				return this._tbl_PersonelTableAdapter;
			}
			set
			{
				this._tbl_PersonelTableAdapter = value;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600004E RID: 78 RVA: 0x0000639C File Offset: 0x0000459C
		// (set) Token: 0x0600004F RID: 79 RVA: 0x000063B4 File Offset: 0x000045B4
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool BackupDataSetBeforeUpdate
		{
			get
			{
				return this._backupDataSetBeforeUpdate;
			}
			set
			{
				this._backupDataSetBeforeUpdate = value;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000050 RID: 80 RVA: 0x000063C0 File Offset: 0x000045C0
		// (set) Token: 0x06000051 RID: 81 RVA: 0x00006416 File Offset: 0x00004616
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[Browsable(false)]
		public IDbConnection Connection
		{
			get
			{
				bool flag = this._connection != null;
				IDbConnection result;
				if (flag)
				{
					result = this._connection;
				}
				else
				{
					bool flag2 = this._tbl_PersonelTableAdapter != null && this._tbl_PersonelTableAdapter.Connection != null;
					if (flag2)
					{
						result = this._tbl_PersonelTableAdapter.Connection;
					}
					else
					{
						result = null;
					}
				}
				return result;
			}
			set
			{
				this._connection = value;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000052 RID: 82 RVA: 0x00006420 File Offset: 0x00004620
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[Browsable(false)]
		public int TableAdapterInstanceCount
		{
			get
			{
				int count = 0;
				bool flag = this._tbl_PersonelTableAdapter != null;
				if (flag)
				{
					count++;
				}
				return count;
			}
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00006448 File Offset: 0x00004648
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		private int UpdateUpdatedRows(PersonelVeriTabaniDataSet dataSet, List<DataRow> allChangedRows, List<DataRow> allAddedRows)
		{
			int result = 0;
			bool flag = this._tbl_PersonelTableAdapter != null;
			if (flag)
			{
				DataRow[] updatedRows = dataSet.Tbl_Personel.Select(null, null, DataViewRowState.ModifiedCurrent);
				updatedRows = this.GetRealUpdatedRows(updatedRows, allAddedRows);
				bool flag2 = updatedRows != null && updatedRows.Length != 0;
				if (flag2)
				{
					result += this._tbl_PersonelTableAdapter.Update(updatedRows);
					allChangedRows.AddRange(updatedRows);
				}
			}
			return result;
		}

		// Token: 0x06000054 RID: 84 RVA: 0x000064B0 File Offset: 0x000046B0
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		private int UpdateInsertedRows(PersonelVeriTabaniDataSet dataSet, List<DataRow> allAddedRows)
		{
			int result = 0;
			bool flag = this._tbl_PersonelTableAdapter != null;
			if (flag)
			{
				DataRow[] addedRows = dataSet.Tbl_Personel.Select(null, null, DataViewRowState.Added);
				bool flag2 = addedRows != null && addedRows.Length != 0;
				if (flag2)
				{
					result += this._tbl_PersonelTableAdapter.Update(addedRows);
					allAddedRows.AddRange(addedRows);
				}
			}
			return result;
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00006510 File Offset: 0x00004710
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		private int UpdateDeletedRows(PersonelVeriTabaniDataSet dataSet, List<DataRow> allChangedRows)
		{
			int result = 0;
			bool flag = this._tbl_PersonelTableAdapter != null;
			if (flag)
			{
				DataRow[] deletedRows = dataSet.Tbl_Personel.Select(null, null, DataViewRowState.Deleted);
				bool flag2 = deletedRows != null && deletedRows.Length != 0;
				if (flag2)
				{
					result += this._tbl_PersonelTableAdapter.Update(deletedRows);
					allChangedRows.AddRange(deletedRows);
				}
			}
			return result;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00006570 File Offset: 0x00004770
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		private DataRow[] GetRealUpdatedRows(DataRow[] updatedRows, List<DataRow> allAddedRows)
		{
			bool flag = updatedRows == null || updatedRows.Length < 1;
			DataRow[] result;
			if (flag)
			{
				result = updatedRows;
			}
			else
			{
				bool flag2 = allAddedRows == null || allAddedRows.Count < 1;
				if (flag2)
				{
					result = updatedRows;
				}
				else
				{
					List<DataRow> realUpdatedRows = new List<DataRow>();
					foreach (DataRow row in updatedRows)
					{
						bool flag3 = !allAddedRows.Contains(row);
						if (flag3)
						{
							realUpdatedRows.Add(row);
						}
					}
					result = realUpdatedRows.ToArray();
				}
			}
			return result;
		}

		// Token: 0x06000057 RID: 87 RVA: 0x000065F8 File Offset: 0x000047F8
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public virtual int UpdateAll(PersonelVeriTabaniDataSet dataSet)
		{
			bool flag = dataSet == null;
			if (flag)
			{
				throw new ArgumentNullException("dataSet");
			}
			bool flag2 = !dataSet.HasChanges();
			int result2;
			if (flag2)
			{
				result2 = 0;
			}
			else
			{
				bool flag3 = this._tbl_PersonelTableAdapter != null && !this.MatchTableAdapterConnection(this._tbl_PersonelTableAdapter.Connection);
				if (flag3)
				{
					throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
				}
				IDbConnection workConnection = this.Connection;
				bool flag4 = workConnection == null;
				if (flag4)
				{
					throw new ApplicationException("TableAdapterManager contains no connection information. Set each TableAdapterManager TableAdapter property to a valid TableAdapter instance.");
				}
				bool workConnOpened = false;
				bool flag5 = (workConnection.State & ConnectionState.Broken) == ConnectionState.Broken;
				if (flag5)
				{
					workConnection.Close();
				}
				bool flag6 = workConnection.State == ConnectionState.Closed;
				if (flag6)
				{
					workConnection.Open();
					workConnOpened = true;
				}
				IDbTransaction workTransaction = workConnection.BeginTransaction();
				bool flag7 = workTransaction == null;
				if (flag7)
				{
					throw new ApplicationException("The transaction cannot begin. The current data connection does not support transactions or the current state is not allowing the transaction to begin.");
				}
				List<DataRow> allChangedRows = new List<DataRow>();
				List<DataRow> allAddedRows = new List<DataRow>();
				List<DataAdapter> adaptersWithAcceptChangesDuringUpdate = new List<DataAdapter>();
				Dictionary<object, IDbConnection> revertConnections = new Dictionary<object, IDbConnection>();
				int result = 0;
				DataSet backupDataSet = null;
				bool backupDataSetBeforeUpdate = this.BackupDataSetBeforeUpdate;
				if (backupDataSetBeforeUpdate)
				{
					backupDataSet = new DataSet();
					backupDataSet.Merge(dataSet);
				}
				try
				{
					bool flag8 = this._tbl_PersonelTableAdapter != null;
					if (flag8)
					{
						revertConnections.Add(this._tbl_PersonelTableAdapter, this._tbl_PersonelTableAdapter.Connection);
						this._tbl_PersonelTableAdapter.Connection = (SqlConnection)workConnection;
						this._tbl_PersonelTableAdapter.Transaction = (SqlTransaction)workTransaction;
						bool acceptChangesDuringUpdate = this._tbl_PersonelTableAdapter.Adapter.AcceptChangesDuringUpdate;
						if (acceptChangesDuringUpdate)
						{
							this._tbl_PersonelTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
							adaptersWithAcceptChangesDuringUpdate.Add(this._tbl_PersonelTableAdapter.Adapter);
						}
					}
					bool flag9 = this.UpdateOrder == TableAdapterManager.UpdateOrderOption.UpdateInsertDelete;
					if (flag9)
					{
						result += this.UpdateUpdatedRows(dataSet, allChangedRows, allAddedRows);
						result += this.UpdateInsertedRows(dataSet, allAddedRows);
					}
					else
					{
						result += this.UpdateInsertedRows(dataSet, allAddedRows);
						result += this.UpdateUpdatedRows(dataSet, allChangedRows, allAddedRows);
					}
					result += this.UpdateDeletedRows(dataSet, allChangedRows);
					workTransaction.Commit();
					bool flag10 = 0 < allAddedRows.Count;
					if (flag10)
					{
						DataRow[] rows = new DataRow[allAddedRows.Count];
						allAddedRows.CopyTo(rows);
						foreach (DataRow row in rows)
						{
							row.AcceptChanges();
						}
					}
					bool flag11 = 0 < allChangedRows.Count;
					if (flag11)
					{
						DataRow[] rows2 = new DataRow[allChangedRows.Count];
						allChangedRows.CopyTo(rows2);
						foreach (DataRow row2 in rows2)
						{
							row2.AcceptChanges();
						}
					}
				}
				catch (Exception ex)
				{
					workTransaction.Rollback();
					bool backupDataSetBeforeUpdate2 = this.BackupDataSetBeforeUpdate;
					if (backupDataSetBeforeUpdate2)
					{
						Debug.Assert(backupDataSet != null);
						dataSet.Clear();
						dataSet.Merge(backupDataSet);
					}
					else
					{
						bool flag12 = 0 < allAddedRows.Count;
						if (flag12)
						{
							DataRow[] rows3 = new DataRow[allAddedRows.Count];
							allAddedRows.CopyTo(rows3);
							foreach (DataRow row3 in rows3)
							{
								row3.AcceptChanges();
								row3.SetAdded();
							}
						}
					}
					throw ex;
				}
				finally
				{
					bool flag13 = workConnOpened;
					if (flag13)
					{
						workConnection.Close();
					}
					bool flag14 = this._tbl_PersonelTableAdapter != null;
					if (flag14)
					{
						this._tbl_PersonelTableAdapter.Connection = (SqlConnection)revertConnections[this._tbl_PersonelTableAdapter];
						this._tbl_PersonelTableAdapter.Transaction = null;
					}
					bool flag15 = 0 < adaptersWithAcceptChangesDuringUpdate.Count;
					if (flag15)
					{
						DataAdapter[] adapters = new DataAdapter[adaptersWithAcceptChangesDuringUpdate.Count];
						adaptersWithAcceptChangesDuringUpdate.CopyTo(adapters);
						foreach (DataAdapter adapter in adapters)
						{
							adapter.AcceptChangesDuringUpdate = true;
						}
					}
				}
				result2 = result;
			}
			return result2;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00006A2C File Offset: 0x00004C2C
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected virtual void SortSelfReferenceRows(DataRow[] rows, DataRelation relation, bool childFirst)
		{
			Array.Sort<DataRow>(rows, new TableAdapterManager.SelfReferenceComparer(relation, childFirst));
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00006A40 File Offset: 0x00004C40
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected virtual bool MatchTableAdapterConnection(IDbConnection inputConnection)
		{
			bool flag = this._connection != null;
			bool result;
			if (flag)
			{
				result = true;
			}
			else
			{
				bool flag2 = this.Connection == null || inputConnection == null;
				if (flag2)
				{
					result = true;
				}
				else
				{
					bool flag3 = string.Equals(this.Connection.ConnectionString, inputConnection.ConnectionString, StringComparison.Ordinal);
					result = flag3;
				}
			}
			return result;
		}

		// Token: 0x04000050 RID: 80
		private TableAdapterManager.UpdateOrderOption _updateOrder;

		// Token: 0x04000051 RID: 81
		private Tbl_PersonelTableAdapter _tbl_PersonelTableAdapter;

		// Token: 0x04000052 RID: 82
		private bool _backupDataSetBeforeUpdate;

		// Token: 0x04000053 RID: 83
		private IDbConnection _connection;

		// Token: 0x02000010 RID: 16
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public enum UpdateOrderOption
		{
			// Token: 0x04000063 RID: 99
			InsertUpdateDelete,
			// Token: 0x04000064 RID: 100
			UpdateInsertDelete
		}

		// Token: 0x02000011 RID: 17
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		private class SelfReferenceComparer : IComparer<DataRow>
		{
			// Token: 0x060000A0 RID: 160 RVA: 0x000079C0 File Offset: 0x00005BC0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
			internal SelfReferenceComparer(DataRelation relation, bool childFirst)
			{
				this._relation = relation;
				if (childFirst)
				{
					this._childFirst = -1;
				}
				else
				{
					this._childFirst = 1;
				}
			}

			// Token: 0x060000A1 RID: 161 RVA: 0x000079F8 File Offset: 0x00005BF8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
			private DataRow GetRoot(DataRow row, out int distance)
			{
				Debug.Assert(row != null);
				DataRow root = row;
				distance = 0;
				IDictionary<DataRow, DataRow> traversedRows = new Dictionary<DataRow, DataRow>();
				traversedRows[row] = row;
				DataRow parent = row.GetParentRow(this._relation, DataRowVersion.Default);
				while (parent != null && !traversedRows.ContainsKey(parent))
				{
					distance++;
					root = parent;
					traversedRows[parent] = parent;
					parent = parent.GetParentRow(this._relation, DataRowVersion.Default);
				}
				bool flag = distance == 0;
				if (flag)
				{
					traversedRows.Clear();
					traversedRows[row] = row;
					parent = row.GetParentRow(this._relation, DataRowVersion.Original);
					while (parent != null && !traversedRows.ContainsKey(parent))
					{
						distance++;
						root = parent;
						traversedRows[parent] = parent;
						parent = parent.GetParentRow(this._relation, DataRowVersion.Original);
					}
				}
				return root;
			}

			// Token: 0x060000A2 RID: 162 RVA: 0x00007AE4 File Offset: 0x00005CE4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
			public int Compare(DataRow row1, DataRow row2)
			{
				bool flag = row1 == row2;
				int result;
				if (flag)
				{
					result = 0;
				}
				else
				{
					bool flag2 = row1 == null;
					if (flag2)
					{
						result = -1;
					}
					else
					{
						bool flag3 = row2 == null;
						if (flag3)
						{
							result = 1;
						}
						else
						{
							int distance = 0;
							DataRow root = this.GetRoot(row1, out distance);
							int distance2 = 0;
							DataRow root2 = this.GetRoot(row2, out distance2);
							bool flag4 = root == root2;
							if (flag4)
							{
								result = this._childFirst * distance.CompareTo(distance2);
							}
							else
							{
								Debug.Assert(root.Table != null && root2.Table != null);
								bool flag5 = root.Table.Rows.IndexOf(root) < root2.Table.Rows.IndexOf(root2);
								if (flag5)
								{
									result = -1;
								}
								else
								{
									result = 1;
								}
							}
						}
					}
				}
				return result;
			}

			// Token: 0x04000065 RID: 101
			private DataRelation _relation;

			// Token: 0x04000066 RID: 102
			private int _childFirst;
		}
	}
}
