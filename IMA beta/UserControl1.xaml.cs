using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using IMA.Properties;

namespace IMA
{
	// Token: 0x02000006 RID: 6
	public partial class UserControl1 : UserControl
	{
		// Token: 0x06000042 RID: 66 RVA: 0x00005AED File Offset: 0x00003CED
		public UserControl1()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002050 File Offset: 0x00000250
		private void Polecenie_TextChanged(object sender, TextChangedEventArgs e)
		{
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00005B00 File Offset: 0x00003D00
		private void Button_Click(object sender, RoutedEventArgs e)
		{
			bool flag = this.Polecenie.Text.ToLower() == "pomoc";
			if (flag)
			{
				this.polecenie_lbl.Content = "Dostępne Komendy: Kolor \nWersja\nPrzezroczystość";
			}
			else
			{
				bool flag2 = this.Polecenie.Text.ToLower() == "kolor";
				if (flag2)
				{
					this.polecenie_lbl.Content = "Kolor IMy: " + Settings.Default.Color.ToString();
				}
				else
				{
					bool flag3 = this.Polecenie.Text.ToLower() == "przezroczystość";
					if (flag3)
					{
						this.polecenie_lbl.Content = "Przezroczystość IMy: " + Settings.Default.Opacity.ToString();
					}
				}
			}
		}
	}
}
