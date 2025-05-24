using System;
using System.Windows.Forms;

namespace PersonelKayitSistemi
{
	// Token: 0x02000007 RID: 7
	internal static class Program
	{
		// Token: 0x0600002E RID: 46 RVA: 0x000058F8 File Offset: 0x00003AF8
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Frm_Giris());
		}
	}
}
