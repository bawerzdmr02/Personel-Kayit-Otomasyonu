namespace PersonelKayitSistemi
{
	// Token: 0x02000003 RID: 3
	public partial class FrmGrafikler : global::System.Windows.Forms.Form
	{
		// Token: 0x06000010 RID: 16 RVA: 0x00003FA8 File Offset: 0x000021A8
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00003FE0 File Offset: 0x000021E0
		private void InitializeComponent()
		{
			global::System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea = new global::System.Windows.Forms.DataVisualization.Charting.ChartArea();
			global::System.Windows.Forms.DataVisualization.Charting.Legend legend = new global::System.Windows.Forms.DataVisualization.Charting.Legend();
			global::System.Windows.Forms.DataVisualization.Charting.Series series = new global::System.Windows.Forms.DataVisualization.Charting.Series();
			global::System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new global::System.Windows.Forms.DataVisualization.Charting.ChartArea();
			global::System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new global::System.Windows.Forms.DataVisualization.Charting.Legend();
			global::System.Windows.Forms.DataVisualization.Charting.Series series2 = new global::System.Windows.Forms.DataVisualization.Charting.Series();
			this.chart1 = new global::System.Windows.Forms.DataVisualization.Charting.Chart();
			this.chart2 = new global::System.Windows.Forms.DataVisualization.Charting.Chart();
			((global::System.ComponentModel.ISupportInitialize)this.chart1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.chart2).BeginInit();
			base.SuspendLayout();
			chartArea.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea);
			legend.Name = "Legend1";
			this.chart1.Legends.Add(legend);
			this.chart1.Location = new global::System.Drawing.Point(12, 12);
			this.chart1.Name = "chart1";
			this.chart1.Palette = global::System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
			series.ChartArea = "ChartArea1";
			series.Legend = "Legend1";
			series.Name = "Sehirler";
			this.chart1.Series.Add(series);
			this.chart1.Size = new global::System.Drawing.Size(377, 231);
			this.chart1.TabIndex = 0;
			this.chart1.Text = "chart1";
			chartArea2.Name = "ChartArea1";
			this.chart2.ChartAreas.Add(chartArea2);
			legend2.Name = "Legend1";
			this.chart2.Legends.Add(legend2);
			this.chart2.Location = new global::System.Drawing.Point(407, 12);
			this.chart2.Name = "chart2";
			series2.ChartArea = "ChartArea1";
			series2.ChartType = global::System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
			series2.Legend = "Legend1";
			series2.Name = "Maaslar";
			this.chart2.Series.Add(series2);
			this.chart2.Size = new global::System.Drawing.Size(377, 231);
			this.chart2.TabIndex = 1;
			this.chart2.Text = "chart2";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.LightSeaGreen;
			base.ClientSize = new global::System.Drawing.Size(802, 262);
			base.Controls.Add(this.chart2);
			base.Controls.Add(this.chart1);
			base.Name = "FrmGrafikler";
			this.Text = "FrmGrafikler";
			base.Load += new global::System.EventHandler(this.FrmGrafikler_Load);
			((global::System.ComponentModel.ISupportInitialize)this.chart1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.chart2).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0400002D RID: 45
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400002E RID: 46
		private global::System.Windows.Forms.DataVisualization.Charting.Chart chart1;

		// Token: 0x0400002F RID: 47
		private global::System.Windows.Forms.DataVisualization.Charting.Chart chart2;
	}
}
