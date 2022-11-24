using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;
using IMA.Properties;

namespace IMA
{
	// Token: 0x02000003 RID: 3
	public partial class Main : Form
	{
		// Token: 0x06000005 RID: 5
		public Main()
		{
			this.InitializeComponent();
			MessageBox.Show("decompiled by uid#7790");
		}

		// Token: 0x06000006 RID: 6
		public void zaladuj()
		{
			MessageBox.Show("Załaduj Obraz!", "Ima BetaTester");
		}

		// Token: 0x06000007 RID: 7
		private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog Dlg = new OpenFileDialog();
			Dlg.Filter = "";
			Dlg.Title = "Wybierz Obraz/Projekt";
			this.Text = "Ima - " + Dlg.FileName;
			if (Dlg.ShowDialog() == DialogResult.OK)
			{
				try
				{
					this.Img = Image.FromFile(Dlg.FileName);
					this.zaldaduj();
				}
				catch
				{
					MessageBox.Show("Podałeś Plik Z Nieprawidłowym Formatem!", "IMA");
				}
			}
		}

		// Token: 0x06000008 RID: 8
		private void zaldaduj()
		{
			int imgWidth = this.Img.Width;
			int imghieght = this.Img.Height;
			this.PictureBox1.Width = imgWidth;
			this.PictureBox1.Height = imghieght;
			this.PictureBox1.Image = this.Img;
			this.PictureBoxLocation();
			this.OriginalImageSize = new Size(imgWidth, imghieght);
			this.SetResizeInfo();
		}

		// Token: 0x06000009 RID: 9
		private void PictureBoxLocation()
		{
			int _x = 0;
			int _y = 0;
			if (this.SplitContainer1.Panel1.Width > this.PictureBox1.Width)
			{
				_x = (this.SplitContainer1.Panel1.Width - this.PictureBox1.Width) / 2;
			}
			if (this.SplitContainer1.Panel1.Height > this.PictureBox1.Height)
			{
				_y = (this.SplitContainer1.Panel1.Height - this.PictureBox1.Height) / 2;
			}
			this.PictureBox1.Location = new Point(_x, _y);
		}

		// Token: 0x0600000A RID: 10
		private void SetResizeInfo()
		{
			this.lbloriginalSize.Text = this.OriginalImageSize.ToString();
			this.lblModifiedSize.Text = this.ModifiedImageSize.ToString();
		}

		// Token: 0x0600000B RID: 11
		private void SplitContainer1_Panel1_Resize(object sender, EventArgs e)
		{
			this.PictureBoxLocation();
		}

		// Token: 0x0600000C RID: 12
		private void btnOk_Click(object sender, EventArgs e)
		{
			try
			{
				Bitmap bm_source = new Bitmap(this.PictureBox1.Image);
				Bitmap bm_dest = new Bitmap(Convert.ToInt32(this.ModifiedImageSize.Width), Convert.ToInt32(this.ModifiedImageSize.Height));
				Graphics.FromImage(bm_dest).DrawImage(bm_source, 0, 0, bm_dest.Width + 1, bm_dest.Height + 1);
				this.PictureBox1.Image = bm_dest;
				this.PictureBox1.Width = bm_dest.Width;
				this.PictureBox1.Height = bm_dest.Height;
				this.PictureBoxLocation();
			}
			catch
			{
				MessageBox.Show("Załaduj Obraz!", "Ima BetaTester");
			}
		}

		// Token: 0x0600000D RID: 13
		private void DomainUpDown1_SelectedItemChanged(object sender, EventArgs e)
		{
			try
			{
				int percentage = Convert.ToInt32(this.DomainUpDown1.Text);
				this.ModifiedImageSize = new Size(this.OriginalImageSize.Width * percentage / 100, this.OriginalImageSize.Height * percentage / 100);
				this.SetResizeInfo();
			}
			catch
			{
				MessageBox.Show("Załaduj Obraz!", "Ima BetaTester");
			}
		}

		// Token: 0x0600000E RID: 14
		private void BindDomainIUpDown()
		{
			for (int i = 1; i <= 999; i++)
			{
				this.DomainUpDown1.Items.Add(i);
			}
			this.DomainUpDown1.Text = "100";
		}

		// Token: 0x0600000F RID: 15
		private void Form1_Load(object sender, EventArgs e)
		{
			this.Text = Settings.Default["NazwaProgramu"].ToString();
			this.f.Show();
			this.f.Visible = false;
			this.BindDomainIUpDown();
			Console.WriteLine();
			base.Opacity = double.Parse(Settings.Default["Opacity"].ToString());
			this.BackColor = (Color)Settings.Default["Color"];
			this.SplitContainer1.BackColor = (Color)Settings.Default["Color"];
			this.PictureBox1.BackColor = (Color)Settings.Default["Color"];
			this.SplitContainer1.Panel1.BackColor = (Color)Settings.Default["Color"];
			this.TabPage1.BackColor = (Color)Settings.Default["Color"];
			this.TabPage2.BackColor = (Color)Settings.Default["Color"];
			this.TabPage3.BackColor = (Color)Settings.Default["Color"];
			this.TabPage4.BackColor = (Color)Settings.Default["Color"];
			this.TabPage5.BackColor = (Color)Settings.Default["Color"];
			this.MenuStrip1.BackColor = (Color)Settings.Default["Color"];
			this.tabPage6.BackColor = (Color)Settings.Default["Color"];
			this.tabPage7.BackColor = (Color)Settings.Default["Color"];
			this.button1.BackColor = (Color)Settings.Default["Color"];
			this.button2.BackColor = (Color)Settings.Default["Color"];
			this.button3.BackColor = (Color)Settings.Default["Color"];
			this.button4.BackColor = (Color)Settings.Default["Color"];
			this.button5.BackColor = (Color)Settings.Default["Color"];
			this.button6.BackColor = (Color)Settings.Default["Color"];
			this.button7.BackColor = (Color)Settings.Default["Color"];
			this.button8.BackColor = (Color)Settings.Default["Color"];
			this.button9.BackColor = (Color)Settings.Default["Color"];
			this.button10.BackColor = (Color)Settings.Default["Color"];
			this.DomainUpDown1.BackColor = (Color)Settings.Default["Color"];
			this.DomainUpDownBrightness.BackColor = (Color)Settings.Default["Color"];
			this.trackBar1.BackColor = (Color)Settings.Default["Color"];
			this.EditToolStripMenuItem.BackColor = (Color)Settings.Default["Color"];
			this.FileToolStripMenuItem.BackColor = (Color)Settings.Default["Color"];
			this.OpenToolStripMenuItem.BackColor = (Color)Settings.Default["Color"];
			this.SaveToolStripMenuItem.BackColor = (Color)Settings.Default["Color"];
			this.ExitToolStripMenuItem.BackColor = (Color)Settings.Default["Color"];
			this.nowyPlikToolStripMenuItem.BackColor = (Color)Settings.Default["Color"];
			this.UndoToolStripMenuItem.BackColor = (Color)Settings.Default["Color"];
			this.normalizujOknoToolStripMenuItem.BackColor = (Color)Settings.Default["Color"];
			this.TrackBarBrightness.BackColor = (Color)Settings.Default["Color"];
		}

		// Token: 0x06000010 RID: 16
		private void btnMakeSelection_Click(object sender, EventArgs e)
		{
			this.Makeselection = true;
			this.btnCrop.Enabled = true;
		}

		// Token: 0x06000011 RID: 17
		private void btnCrop_Click(object sender, EventArgs e)
		{
			this.Cursor = Cursors.Default;
			try
			{
				if (this.cropWidth >= 1)
				{
					Rectangle rect = new Rectangle(this.cropX, this.cropY, this.cropWidth, this.cropHeight);
					Bitmap OriginalImage = new Bitmap(this.PictureBox1.Image, this.PictureBox1.Width, this.PictureBox1.Height);
					Bitmap _img = new Bitmap(this.cropWidth, this.cropHeight);
					Graphics graphics = Graphics.FromImage(_img);
					graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
					graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
					graphics.CompositingQuality = CompositingQuality.HighQuality;
					graphics.DrawImage(OriginalImage, 0, 0, rect, GraphicsUnit.Pixel);
					this.PictureBox1.Image = _img;
					this.PictureBox1.Width = _img.Width;
					this.PictureBox1.Height = _img.Height;
					this.PictureBoxLocation();
					this.btnCrop.Enabled = false;
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000012 RID: 18
		private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
		{
			if (this.TabControl1.SelectedIndex == 4)
			{
				Point location = e.Location;
				if (this.CreateText)
				{
					this.Cursor = Cursors.IBeam;
					return;
				}
			}
			else
			{
				this.Cursor = Cursors.Default;
				if (this.Makeselection)
				{
					try
					{
						if (e.Button == MouseButtons.Left)
						{
							this.Cursor = Cursors.Cross;
							this.cropX = e.X;
							this.cropY = e.Y;
							this.cropPen = new Pen(Color.Black, 1f);
							this.cropPen.DashStyle = DashStyle.DashDotDot;
						}
						this.PictureBox1.Refresh();
					}
					catch (Exception)
					{
					}
				}
			}
		}

		// Token: 0x06000013 RID: 19
		private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
		{
			if (this.Makeselection)
			{
				this.Cursor = Cursors.Default;
			}
		}

		// Token: 0x06000014 RID: 20
		private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
		{
			if (this.TabControl1.SelectedIndex == 4)
			{
				Point location = e.Location;
				if (this.CreateText)
				{
					this.Cursor = Cursors.IBeam;
					return;
				}
			}
			else
			{
				this.Cursor = Cursors.Default;
				if (this.Makeselection)
				{
					try
					{
						if (this.PictureBox1.Image != null && e.Button == MouseButtons.Left)
						{
							this.PictureBox1.Refresh();
							this.cropWidth = e.X - this.cropX;
							this.cropHeight = e.Y - this.cropY;
							this.PictureBox1.CreateGraphics().DrawRectangle(this.cropPen, this.cropX, this.cropY, this.cropWidth, this.cropHeight);
						}
					}
					catch (Exception)
					{
					}
				}
			}
		}

		// Token: 0x06000015 RID: 21
		private void TrackBarBrightness_Scroll(object sender, EventArgs e)
		{
			try
			{
				this.DomainUpDownBrightness.Text = this.TrackBarBrightness.Value.ToString();
				float value = (float)this.TrackBarBrightness.Value * 0.01f;
				float[][] array = new float[5][];
				int num = 0;
				float[] array2 = new float[5];
				array2[0] = 1f;
				array[num] = array2;
				int num2 = 1;
				float[] array3 = new float[5];
				array3[1] = 1f;
				array[num2] = array3;
				int num3 = 2;
				float[] array4 = new float[5];
				array4[2] = 1f;
				array[num3] = array4;
				int num4 = 3;
				float[] array5 = new float[5];
				array5[3] = 1f;
				array[num4] = array5;
				array[4] = new float[]
				{
					value,
					value,
					value,
					0f,
					1f
				};
				ColorMatrix colorMatrix = new ColorMatrix(array);
				ImageAttributes imageAttributes = new ImageAttributes();
				imageAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
				Image _img = this.Img;
				Bitmap bm_dest = new Bitmap(Convert.ToInt32(_img.Width), Convert.ToInt32(_img.Height));
				Graphics.FromImage(bm_dest).DrawImage(_img, new Rectangle(0, 0, bm_dest.Width + 1, bm_dest.Height + 1), 0, 0, bm_dest.Width + 1, bm_dest.Height + 1, GraphicsUnit.Pixel, imageAttributes);
				this.PictureBox1.Image = bm_dest;
			}
			catch
			{
				this.zaladuj();
			}
		}

		// Token: 0x06000016 RID: 22
		private void btnRotateLeft_Click(object sender, EventArgs e)
		{
			try
			{
				this.PictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
				this.PictureBox1.Refresh();
			}
			catch
			{
				MessageBox.Show("Załaduj Obraz!", "Ima BetaTester");
			}
		}

		// Token: 0x06000017 RID: 23
		private void btnRotateRight_Click(object sender, EventArgs e)
		{
			try
			{
				this.PictureBox1.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
				this.PictureBox1.Refresh();
			}
			catch
			{
				this.zaladuj();
			}
		}

		// Token: 0x06000018 RID: 24
		private void btnRotateHorizantal_Click(object sender, EventArgs e)
		{
			try
			{
				this.PictureBox1.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
				this.PictureBox1.Refresh();
			}
			catch
			{
				this.zaladuj();
			}
		}

		// Token: 0x06000019 RID: 25
		private void btnRotatevertical_Click(object sender, EventArgs e)
		{
			try
			{
				this.PictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
				this.PictureBox1.Refresh();
			}
			catch
			{
				this.zaladuj();
			}
		}

		// Token: 0x0600001A RID: 26
		private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x0600001B RID: 27
		private void btnColorDlg_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600001C RID: 28
		private void button1_Click(object sender, EventArgs e)
		{
			string text = "Czy Na pewno chcesz zamknąć imę? wiąże to się z utratą projektu ";
			string title = "IMA";
			MessageBoxButtons buttons = MessageBoxButtons.YesNo;
			if (MessageBox.Show(text, title, buttons) == DialogResult.Yes)
			{
				Environment.Exit(0);
			}
		}

		// Token: 0x0600001D RID: 29
		private void button2_Click(object sender, EventArgs e)
		{
			new Main();
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x0600001E RID: 30
		private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
		}

		// Token: 0x0600001F RID: 31
		private void PictureBox1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000020 RID: 32
		private void UndoToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000021 RID: 33
		private void button3_Click(object sender, EventArgs e)
		{
			this.PictureBox1.Image = new Bitmap(Application.StartupPath + "lime.png");
		}

		// Token: 0x06000022 RID: 34
		private void button4_Click(object sender, EventArgs e)
		{
			this.PictureBox1.Image = new Bitmap(Application.StartupPath + "blue.png");
		}

		// Token: 0x06000023 RID: 35
		private void button5_Click(object sender, EventArgs e)
		{
			this.PictureBox1.Image = new Bitmap(Application.StartupPath + "red.png");
		}

		// Token: 0x06000024 RID: 36
		private void button6_Click(object sender, EventArgs e)
		{
			this.PictureBox1.Image = new Bitmap(Application.StartupPath + "yellow.png");
		}

		// Token: 0x06000025 RID: 37
		private void button7_Click(object sender, EventArgs e)
		{
			this.PictureBox1.Image = new Bitmap(Application.StartupPath + "pink.png");
		}

		// Token: 0x06000026 RID: 38
		private void button8_Click(object sender, EventArgs e)
		{
			this.PictureBox1.Image = new Bitmap(Application.StartupPath + "black.png");
		}

		// Token: 0x06000027 RID: 39
		private void button9_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Maximized;
		}

		// Token: 0x06000028 RID: 40
		private void normalizujOknoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Normal;
		}

		// Token: 0x06000029 RID: 41
		private void btnCreateText_Click(object sender, EventArgs e)
		{
			this.DrawText();
		}

		// Token: 0x0600002A RID: 42
		private void DrawText()
		{
			int r = int.Parse(this.rozmiar.Text);
			Graphics grf = this.PictureBox1.CreateGraphics();
			try
			{
				using (Font myFont = new Font("Arial", (float)r))
				{
					grf.DrawString(this.cmbFonts.Text, myFont, Brushes.Blue, new PointF(2f, 2f));
				}
			}
			finally
			{
				grf.Dispose();
			}
		}

		// Token: 0x0600002B RID: 43
		private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				this.saveFileDialog1.DefaultExt = ".im";
				this.saveFileDialog1.Filter = "Plik PNG|*.png|Plik JPG|*.jpg|Wszystkie Pliki|*|Pliki Programu Ima|*.im";
				if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
				{
					this.PictureBox1.Image.Save(this.saveFileDialog1.FileName);
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Nie zrobiles nic, plik nie zostal zapisany", "Ima Editor");
			}
		}

		// Token: 0x0600002C RID: 44
		private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
		{
		}

		// Token: 0x0600002D RID: 45
		private void label10_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600002E RID: 46
		private void button10_Click(object sender, EventArgs e)
		{
			this.colorDialog1.ShowDialog();
			if (this.colorDialog1.ShowDialog() == DialogResult.OK)
			{
				this.kolortekstu = this.colorDialog1.Color;
			}
		}

		// Token: 0x0600002F RID: 47
		private void SplitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000030 RID: 48
		private void nowyPlikToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.PictureBox1.Image = null;
		}

		// Token: 0x06000031 RID: 49
		private void trackBar1_Scroll(object sender, EventArgs e)
		{
		}

		// Token: 0x06000032 RID: 50
		private void button10_Click_1(object sender, EventArgs e)
		{
			this.f.Visible = true;
			base.Visible = false;
		}

		// Token: 0x06000033 RID: 51
		private void PictureBox1_DragDrop(object sender, DragEventArgs e)
		{
		}

		// Token: 0x06000034 RID: 52
		private void DomainUpDownBrightness_SelectedItemChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x04000001 RID: 1
		private form2 f = new form2();

		// Token: 0x04000002 RID: 2
		public Color kolortekstu;

		// Token: 0x04000003 RID: 3
		private Image Img;

		// Token: 0x04000004 RID: 4
		private Size OriginalImageSize;

		// Token: 0x04000005 RID: 5
		private Size ModifiedImageSize;

		// Token: 0x04000006 RID: 6
		private int cropX;

		// Token: 0x04000007 RID: 7
		private int cropY;

		// Token: 0x04000008 RID: 8
		private int cropWidth;

		// Token: 0x04000009 RID: 9
		private int cropHeight;

		// Token: 0x0400000A RID: 10
		private int oCropX;

		// Token: 0x0400000B RID: 11
		private int oCropY;

		// Token: 0x0400000C RID: 12
		public Pen cropPen;

		// Token: 0x0400000D RID: 13
		public DashStyle cropDashStyle = DashStyle.DashDot;

		// Token: 0x0400000E RID: 14
		public bool Makeselection;

		// Token: 0x0400000F RID: 15
		public bool CreateText;
	}
}
