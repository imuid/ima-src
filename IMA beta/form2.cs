using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using IMA.Properties;

namespace IMA
{
	// Token: 0x02000005 RID: 5
	public partial class form2 : Form
	{
		// Token: 0x06000038 RID: 56 RVA: 0x00004F76 File Offset: 0x00003176
		public form2()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00004F90 File Offset: 0x00003190
		private void button1_Click(object sender, EventArgs e)
		{
			Main zmienna = new Main();
			zmienna.Visible = true;
			base.Visible = false;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00004FB4 File Offset: 0x000031B4
		private void trackBar1_Scroll(object sender, EventArgs e)
		{
			Settings.Default["Opacity"] = this.trackBar1.Value;
			Settings.Default.Save();
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00004FE4 File Offset: 0x000031E4
		private void form2_Load(object sender, EventArgs e)
		{
			this.BackColor = (Color)Settings.Default["Color"];
			this.button1.BackColor = (Color)Settings.Default["Color"];
			this.button2.BackColor = (Color)Settings.Default["Color"];
			this.textBox1.BackColor = (Color)Settings.Default["Color"];
			this.textBox2.BackColor = (Color)Settings.Default["Color"];
			this.trackBar1.BackColor = (Color)Settings.Default["Color"];
		}

		// Token: 0x0600003C RID: 60 RVA: 0x000050B0 File Offset: 0x000032B0
		private void button2_Click(object sender, EventArgs e)
		{
			bool flag = this.colorDialog1.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				int value = 25;
				Color color = this.colorDialog1.Color;
				bool flag2 = int.Parse(color.R.ToString()) <= 0;
				int a;
				if (flag2)
				{
					a = 0;
				}
				else
				{
					a = int.Parse(color.R.ToString()) - value;
				}
				bool flag3 = int.Parse(color.G.ToString()) <= 0;
				int a2;
				if (flag3)
				{
					a2 = 0;
				}
				else
				{
					a2 = int.Parse(color.G.ToString()) - value;
				}
				bool flag4 = int.Parse(color.B.ToString()) <= 0;
				int a3;
				if (flag4)
				{
					a3 = 0;
				}
				else
				{
					a3 = int.Parse(color.B.ToString()) - value;
				}
				this.textBox1.BackColor = Color.FromArgb(a, a2, a3);
				this.textBox2.BackColor = Color.FromArgb(a, a2, a3);
				Settings.Default["Color"] = this.colorDialog1.Color;
				Settings.Default.Save();
				this.BackColor = this.colorDialog1.Color;
				this.button1.BackColor = this.colorDialog1.Color;
				this.button2.BackColor = this.colorDialog1.Color;
				this.trackBar1.BackColor = this.colorDialog1.Color;
			}
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00005269 File Offset: 0x00003469
		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			Settings.Default["username"] = this.textBox1.Text;
			Settings.Default.Save();
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00005292 File Offset: 0x00003492
		private void textBox2_TextChanged(object sender, EventArgs e)
		{
			Settings.Default["NazwaProgramu"] = this.textBox2.Text;
			Settings.Default.Save();
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000052BB File Offset: 0x000034BB
		private void button3_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Funkcja Niedługo Dodana.", "Ima Editor", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Asterisk);
		}
	}
}
