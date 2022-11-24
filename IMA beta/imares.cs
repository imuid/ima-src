using System;
using System.Windows.Forms;

namespace IMA
{
	// Token: 0x02000002 RID: 2
	internal class imares
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public void loadstatus()
		{
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002053 File Offset: 0x00000253
		public void sndms(string msg)
		{
			Console.WriteLine(msg);
		}

		// Token: 0x06000003 RID: 3 RVA: 0x0000205D File Offset: 0x0000025D
		public void zaladujobraz()
		{
			MessageBox.Show("Załaduj Obraz!", "Ima BetaTester");
		}
	}
}
