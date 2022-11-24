namespace IMA
{
	// Token: 0x02000003 RID: 3
	public partial class Main : global::System.Windows.Forms.Form
	{
		// Token: 0x06000035 RID: 53
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000036 RID: 54
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager resources = new global::System.ComponentModel.ComponentResourceManager(typeof(global::IMA.Main));
			this.SplitContainer1 = new global::System.Windows.Forms.SplitContainer();
			this.PictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.TabControl1 = new global::System.Windows.Forms.TabControl();
			this.tabPage6 = new global::System.Windows.Forms.TabPage();
			this.button8 = new global::System.Windows.Forms.Button();
			this.button7 = new global::System.Windows.Forms.Button();
			this.button6 = new global::System.Windows.Forms.Button();
			this.button5 = new global::System.Windows.Forms.Button();
			this.button4 = new global::System.Windows.Forms.Button();
			this.button3 = new global::System.Windows.Forms.Button();
			this.label8 = new global::System.Windows.Forms.Label();
			this.TabPage5 = new global::System.Windows.Forms.TabPage();
			this.label9 = new global::System.Windows.Forms.Label();
			this.rozmiar = new global::System.Windows.Forms.ComboBox();
			this.btnCreateText = new global::System.Windows.Forms.Button();
			this.cmbFonts = new global::System.Windows.Forms.ComboBox();
			this.TabPage3 = new global::System.Windows.Forms.TabPage();
			this.label11 = new global::System.Windows.Forms.Label();
			this.btnCrop = new global::System.Windows.Forms.Button();
			this.btnMakeSelection = new global::System.Windows.Forms.Button();
			this.TabPage1 = new global::System.Windows.Forms.TabPage();
			this.Label7 = new global::System.Windows.Forms.Label();
			this.lbloriginalSize = new global::System.Windows.Forms.Label();
			this.lblModifiedSize = new global::System.Windows.Forms.Label();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.btnOk = new global::System.Windows.Forms.Button();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.DomainUpDown1 = new global::System.Windows.Forms.DomainUpDown();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.TabPage2 = new global::System.Windows.Forms.TabPage();
			this.Label5 = new global::System.Windows.Forms.Label();
			this.DomainUpDownBrightness = new global::System.Windows.Forms.DomainUpDown();
			this.TrackBarBrightness = new global::System.Windows.Forms.TrackBar();
			this.TabPage4 = new global::System.Windows.Forms.TabPage();
			this.label6 = new global::System.Windows.Forms.Label();
			this.btnRotateRight = new global::System.Windows.Forms.Button();
			this.btnRotateHorizantal = new global::System.Windows.Forms.Button();
			this.btnRotatevertical = new global::System.Windows.Forms.Button();
			this.btnRotateLeft = new global::System.Windows.Forms.Button();
			this.tabPage7 = new global::System.Windows.Forms.TabPage();
			this.trackBar1 = new global::System.Windows.Forms.TrackBar();
			this.label10 = new global::System.Windows.Forms.Label();
			this.button1 = new global::System.Windows.Forms.Button();
			this.button2 = new global::System.Windows.Forms.Button();
			this.colorDialog1 = new global::System.Windows.Forms.ColorDialog();
			this.button9 = new global::System.Windows.Forms.Button();
			this.saveFileDialog1 = new global::System.Windows.Forms.SaveFileDialog();
			this.FileToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.OpenToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.SaveToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.ExitToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.nowyPlikToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.EditToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.UndoToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.normalizujOknoToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.MenuStrip1 = new global::System.Windows.Forms.MenuStrip();
			this.button10 = new global::System.Windows.Forms.Button();
			((global::System.ComponentModel.ISupportInitialize)this.SplitContainer1).BeginInit();
			this.SplitContainer1.Panel1.SuspendLayout();
			this.SplitContainer1.Panel2.SuspendLayout();
			this.SplitContainer1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
			this.TabControl1.SuspendLayout();
			this.tabPage6.SuspendLayout();
			this.TabPage5.SuspendLayout();
			this.TabPage3.SuspendLayout();
			this.TabPage1.SuspendLayout();
			this.TabPage2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.TrackBarBrightness).BeginInit();
			this.TabPage4.SuspendLayout();
			this.tabPage7.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.trackBar1).BeginInit();
			this.MenuStrip1.SuspendLayout();
			base.SuspendLayout();
			resources.ApplyResources(this.SplitContainer1, "SplitContainer1");
			this.SplitContainer1.Name = "SplitContainer1";
			resources.ApplyResources(this.SplitContainer1.Panel1, "SplitContainer1.Panel1");
			this.SplitContainer1.Panel1.BackColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.SplitContainer1.Panel1.Controls.Add(this.PictureBox1);
			this.SplitContainer1.Panel1.Paint += new global::System.Windows.Forms.PaintEventHandler(this.SplitContainer1_Panel1_Paint);
			this.SplitContainer1.Panel1.Resize += new global::System.EventHandler(this.SplitContainer1_Panel1_Resize);
			resources.ApplyResources(this.SplitContainer1.Panel2, "SplitContainer1.Panel2");
			this.SplitContainer1.Panel2.Controls.Add(this.TabControl1);
			resources.ApplyResources(this.PictureBox1, "PictureBox1");
			this.PictureBox1.BackColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.PictureBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.TabStop = false;
			this.PictureBox1.Click += new global::System.EventHandler(this.PictureBox1_Click);
			this.PictureBox1.DragDrop += new global::System.Windows.Forms.DragEventHandler(this.PictureBox1_DragDrop);
			this.PictureBox1.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseDown);
			this.PictureBox1.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseMove);
			this.PictureBox1.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseUp);
			resources.ApplyResources(this.TabControl1, "TabControl1");
			this.TabControl1.Controls.Add(this.tabPage6);
			this.TabControl1.Controls.Add(this.TabPage5);
			this.TabControl1.Controls.Add(this.TabPage3);
			this.TabControl1.Controls.Add(this.TabPage1);
			this.TabControl1.Controls.Add(this.TabPage2);
			this.TabControl1.Controls.Add(this.TabPage4);
			this.TabControl1.Controls.Add(this.tabPage7);
			this.TabControl1.Name = "TabControl1";
			this.TabControl1.SelectedIndex = 0;
			resources.ApplyResources(this.tabPage6, "tabPage6");
			this.tabPage6.BackColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.tabPage6.Controls.Add(this.button8);
			this.tabPage6.Controls.Add(this.button7);
			this.tabPage6.Controls.Add(this.button6);
			this.tabPage6.Controls.Add(this.button5);
			this.tabPage6.Controls.Add(this.button4);
			this.tabPage6.Controls.Add(this.button3);
			this.tabPage6.Controls.Add(this.label8);
			this.tabPage6.Name = "tabPage6";
			resources.ApplyResources(this.button8, "button8");
			this.button8.BackColor = global::System.Drawing.Color.Black;
			this.button8.ForeColor = global::System.Drawing.SystemColors.ControlLight;
			this.button8.Name = "button8";
			this.button8.UseVisualStyleBackColor = false;
			this.button8.Click += new global::System.EventHandler(this.button8_Click);
			resources.ApplyResources(this.button7, "button7");
			this.button7.BackColor = global::System.Drawing.Color.Magenta;
			this.button7.ForeColor = global::System.Drawing.SystemColors.ControlLight;
			this.button7.Name = "button7";
			this.button7.UseVisualStyleBackColor = false;
			this.button7.Click += new global::System.EventHandler(this.button7_Click);
			resources.ApplyResources(this.button6, "button6");
			this.button6.BackColor = global::System.Drawing.Color.Yellow;
			this.button6.ForeColor = global::System.Drawing.SystemColors.ControlLight;
			this.button6.Name = "button6";
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += new global::System.EventHandler(this.button6_Click);
			resources.ApplyResources(this.button5, "button5");
			this.button5.BackColor = global::System.Drawing.Color.Red;
			this.button5.ForeColor = global::System.Drawing.SystemColors.ControlLight;
			this.button5.Name = "button5";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new global::System.EventHandler(this.button5_Click);
			resources.ApplyResources(this.button4, "button4");
			this.button4.BackColor = global::System.Drawing.Color.Blue;
			this.button4.ForeColor = global::System.Drawing.SystemColors.ControlLight;
			this.button4.Name = "button4";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new global::System.EventHandler(this.button4_Click);
			resources.ApplyResources(this.button3, "button3");
			this.button3.BackColor = global::System.Drawing.Color.Lime;
			this.button3.ForeColor = global::System.Drawing.SystemColors.ControlLight;
			this.button3.Name = "button3";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new global::System.EventHandler(this.button3_Click);
			resources.ApplyResources(this.label8, "label8");
			this.label8.Name = "label8";
			resources.ApplyResources(this.TabPage5, "TabPage5");
			this.TabPage5.BackColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.TabPage5.Controls.Add(this.label9);
			this.TabPage5.Controls.Add(this.rozmiar);
			this.TabPage5.Controls.Add(this.btnCreateText);
			this.TabPage5.Controls.Add(this.cmbFonts);
			this.TabPage5.Name = "TabPage5";
			resources.ApplyResources(this.label9, "label9");
			this.label9.Name = "label9";
			resources.ApplyResources(this.rozmiar, "rozmiar");
			this.rozmiar.FormattingEnabled = true;
			this.rozmiar.Items.AddRange(new object[]
			{
				resources.GetString("rozmiar.Items"),
				resources.GetString("rozmiar.Items1"),
				resources.GetString("rozmiar.Items2"),
				resources.GetString("rozmiar.Items3"),
				resources.GetString("rozmiar.Items4"),
				resources.GetString("rozmiar.Items5"),
				resources.GetString("rozmiar.Items6"),
				resources.GetString("rozmiar.Items7"),
				resources.GetString("rozmiar.Items8"),
				resources.GetString("rozmiar.Items9"),
				resources.GetString("rozmiar.Items10"),
				resources.GetString("rozmiar.Items11"),
				resources.GetString("rozmiar.Items12"),
				resources.GetString("rozmiar.Items13"),
				resources.GetString("rozmiar.Items14"),
				resources.GetString("rozmiar.Items15"),
				resources.GetString("rozmiar.Items16"),
				resources.GetString("rozmiar.Items17"),
				resources.GetString("rozmiar.Items18"),
				resources.GetString("rozmiar.Items19"),
				resources.GetString("rozmiar.Items20"),
				resources.GetString("rozmiar.Items21"),
				resources.GetString("rozmiar.Items22"),
				resources.GetString("rozmiar.Items23"),
				resources.GetString("rozmiar.Items24"),
				resources.GetString("rozmiar.Items25"),
				resources.GetString("rozmiar.Items26"),
				resources.GetString("rozmiar.Items27"),
				resources.GetString("rozmiar.Items28"),
				resources.GetString("rozmiar.Items29"),
				resources.GetString("rozmiar.Items30")
			});
			this.rozmiar.Name = "rozmiar";
			resources.ApplyResources(this.btnCreateText, "btnCreateText");
			this.btnCreateText.Name = "btnCreateText";
			this.btnCreateText.UseVisualStyleBackColor = true;
			this.btnCreateText.Click += new global::System.EventHandler(this.btnCreateText_Click);
			resources.ApplyResources(this.cmbFonts, "cmbFonts");
			this.cmbFonts.FormattingEnabled = true;
			this.cmbFonts.Items.AddRange(new object[]
			{
				resources.GetString("cmbFonts.Items"),
				resources.GetString("cmbFonts.Items1"),
				resources.GetString("cmbFonts.Items2"),
				resources.GetString("cmbFonts.Items3"),
				resources.GetString("cmbFonts.Items4"),
				resources.GetString("cmbFonts.Items5"),
				resources.GetString("cmbFonts.Items6"),
				resources.GetString("cmbFonts.Items7")
			});
			this.cmbFonts.Name = "cmbFonts";
			resources.ApplyResources(this.TabPage3, "TabPage3");
			this.TabPage3.BackColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.TabPage3.Controls.Add(this.label11);
			this.TabPage3.Controls.Add(this.btnCrop);
			this.TabPage3.Controls.Add(this.btnMakeSelection);
			this.TabPage3.Name = "TabPage3";
			resources.ApplyResources(this.label11, "label11");
			this.label11.Name = "label11";
			resources.ApplyResources(this.btnCrop, "btnCrop");
			this.btnCrop.ForeColor = global::System.Drawing.Color.Black;
			this.btnCrop.Name = "btnCrop";
			this.btnCrop.UseVisualStyleBackColor = true;
			this.btnCrop.Click += new global::System.EventHandler(this.btnCrop_Click);
			resources.ApplyResources(this.btnMakeSelection, "btnMakeSelection");
			this.btnMakeSelection.Name = "btnMakeSelection";
			this.btnMakeSelection.UseVisualStyleBackColor = true;
			this.btnMakeSelection.Click += new global::System.EventHandler(this.btnMakeSelection_Click);
			resources.ApplyResources(this.TabPage1, "TabPage1");
			this.TabPage1.BackColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.TabPage1.Controls.Add(this.Label7);
			this.TabPage1.Controls.Add(this.lbloriginalSize);
			this.TabPage1.Controls.Add(this.lblModifiedSize);
			this.TabPage1.Controls.Add(this.Label4);
			this.TabPage1.Controls.Add(this.btnOk);
			this.TabPage1.Controls.Add(this.Label3);
			this.TabPage1.Controls.Add(this.DomainUpDown1);
			this.TabPage1.Controls.Add(this.Label2);
			this.TabPage1.Controls.Add(this.Label1);
			this.TabPage1.Name = "TabPage1";
			resources.ApplyResources(this.Label7, "Label7");
			this.Label7.Name = "Label7";
			resources.ApplyResources(this.lbloriginalSize, "lbloriginalSize");
			this.lbloriginalSize.Name = "lbloriginalSize";
			resources.ApplyResources(this.lblModifiedSize, "lblModifiedSize");
			this.lblModifiedSize.Name = "lblModifiedSize";
			resources.ApplyResources(this.Label4, "Label4");
			this.Label4.Name = "Label4";
			resources.ApplyResources(this.btnOk, "btnOk");
			this.btnOk.ForeColor = global::System.Drawing.Color.FromArgb(192, 192, 255);
			this.btnOk.Name = "btnOk";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new global::System.EventHandler(this.btnOk_Click);
			resources.ApplyResources(this.Label3, "Label3");
			this.Label3.Name = "Label3";
			resources.ApplyResources(this.DomainUpDown1, "DomainUpDown1");
			this.DomainUpDown1.BackColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.DomainUpDown1.Name = "DomainUpDown1";
			this.DomainUpDown1.SelectedItemChanged += new global::System.EventHandler(this.DomainUpDown1_SelectedItemChanged);
			resources.ApplyResources(this.Label2, "Label2");
			this.Label2.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.Label2.Name = "Label2";
			resources.ApplyResources(this.Label1, "Label1");
			this.Label1.Name = "Label1";
			this.Label1.Tag = "";
			resources.ApplyResources(this.TabPage2, "TabPage2");
			this.TabPage2.BackColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.TabPage2.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.TabPage2.Controls.Add(this.Label5);
			this.TabPage2.Controls.Add(this.DomainUpDownBrightness);
			this.TabPage2.Controls.Add(this.TrackBarBrightness);
			this.TabPage2.Name = "TabPage2";
			resources.ApplyResources(this.Label5, "Label5");
			this.Label5.Name = "Label5";
			resources.ApplyResources(this.DomainUpDownBrightness, "DomainUpDownBrightness");
			this.DomainUpDownBrightness.BackColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.DomainUpDownBrightness.Name = "DomainUpDownBrightness";
			this.DomainUpDownBrightness.ReadOnly = true;
			this.DomainUpDownBrightness.SelectedItemChanged += new global::System.EventHandler(this.DomainUpDownBrightness_SelectedItemChanged);
			resources.ApplyResources(this.TrackBarBrightness, "TrackBarBrightness");
			this.TrackBarBrightness.BackColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.TrackBarBrightness.Maximum = 100;
			this.TrackBarBrightness.Minimum = -100;
			this.TrackBarBrightness.Name = "TrackBarBrightness";
			this.TrackBarBrightness.Scroll += new global::System.EventHandler(this.TrackBarBrightness_Scroll);
			resources.ApplyResources(this.TabPage4, "TabPage4");
			this.TabPage4.BackColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.TabPage4.Controls.Add(this.label6);
			this.TabPage4.Controls.Add(this.btnRotateRight);
			this.TabPage4.Controls.Add(this.btnRotateHorizantal);
			this.TabPage4.Controls.Add(this.btnRotatevertical);
			this.TabPage4.Controls.Add(this.btnRotateLeft);
			this.TabPage4.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.TabPage4.Name = "TabPage4";
			resources.ApplyResources(this.label6, "label6");
			this.label6.Name = "label6";
			resources.ApplyResources(this.btnRotateRight, "btnRotateRight");
			this.btnRotateRight.Name = "btnRotateRight";
			this.btnRotateRight.UseVisualStyleBackColor = true;
			this.btnRotateRight.Click += new global::System.EventHandler(this.btnRotateRight_Click);
			resources.ApplyResources(this.btnRotateHorizantal, "btnRotateHorizantal");
			this.btnRotateHorizantal.Name = "btnRotateHorizantal";
			this.btnRotateHorizantal.UseVisualStyleBackColor = true;
			this.btnRotateHorizantal.Click += new global::System.EventHandler(this.btnRotateHorizantal_Click);
			resources.ApplyResources(this.btnRotatevertical, "btnRotatevertical");
			this.btnRotatevertical.Name = "btnRotatevertical";
			this.btnRotatevertical.UseVisualStyleBackColor = true;
			this.btnRotatevertical.Click += new global::System.EventHandler(this.btnRotatevertical_Click);
			resources.ApplyResources(this.btnRotateLeft, "btnRotateLeft");
			this.btnRotateLeft.Name = "btnRotateLeft";
			this.btnRotateLeft.UseVisualStyleBackColor = true;
			this.btnRotateLeft.Click += new global::System.EventHandler(this.btnRotateLeft_Click);
			resources.ApplyResources(this.tabPage7, "tabPage7");
			this.tabPage7.BackColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.tabPage7.Controls.Add(this.trackBar1);
			this.tabPage7.Controls.Add(this.label10);
			this.tabPage7.Name = "tabPage7";
			resources.ApplyResources(this.trackBar1, "trackBar1");
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Scroll += new global::System.EventHandler(this.trackBar1_Scroll);
			resources.ApplyResources(this.label10, "label10");
			this.label10.Name = "label10";
			resources.ApplyResources(this.button1, "button1");
			this.button1.BackColor = global::System.Drawing.Color.FromArgb(192, 192, 255);
			this.button1.ForeColor = global::System.Drawing.Color.Black;
			this.button1.Name = "button1";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			resources.ApplyResources(this.button2, "button2");
			this.button2.BackColor = global::System.Drawing.Color.FromArgb(192, 192, 255);
			this.button2.ForeColor = global::System.Drawing.Color.Black;
			this.button2.Name = "button2";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			resources.ApplyResources(this.button9, "button9");
			this.button9.BackColor = global::System.Drawing.Color.FromArgb(192, 192, 255);
			this.button9.ForeColor = global::System.Drawing.Color.Black;
			this.button9.Name = "button9";
			this.button9.UseVisualStyleBackColor = false;
			this.button9.Click += new global::System.EventHandler(this.button9_Click);
			this.button9.MouseClick += new global::System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseUp);
			resources.ApplyResources(this.saveFileDialog1, "saveFileDialog1");
			this.saveFileDialog1.FileOk += new global::System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
			resources.ApplyResources(this.FileToolStripMenuItem, "FileToolStripMenuItem");
			this.FileToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.OpenToolStripMenuItem,
				this.SaveToolStripMenuItem,
				this.ExitToolStripMenuItem,
				this.nowyPlikToolStripMenuItem
			});
			this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
			resources.ApplyResources(this.OpenToolStripMenuItem, "OpenToolStripMenuItem");
			this.OpenToolStripMenuItem.BackColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
			this.OpenToolStripMenuItem.Click += new global::System.EventHandler(this.OpenToolStripMenuItem_Click);
			resources.ApplyResources(this.SaveToolStripMenuItem, "SaveToolStripMenuItem");
			this.SaveToolStripMenuItem.BackColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
			this.SaveToolStripMenuItem.Click += new global::System.EventHandler(this.SaveToolStripMenuItem_Click);
			resources.ApplyResources(this.ExitToolStripMenuItem, "ExitToolStripMenuItem");
			this.ExitToolStripMenuItem.BackColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
			this.ExitToolStripMenuItem.Click += new global::System.EventHandler(this.ExitToolStripMenuItem_Click);
			resources.ApplyResources(this.nowyPlikToolStripMenuItem, "nowyPlikToolStripMenuItem");
			this.nowyPlikToolStripMenuItem.BackColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.nowyPlikToolStripMenuItem.Name = "nowyPlikToolStripMenuItem";
			this.nowyPlikToolStripMenuItem.Click += new global::System.EventHandler(this.nowyPlikToolStripMenuItem_Click);
			resources.ApplyResources(this.EditToolStripMenuItem, "EditToolStripMenuItem");
			this.EditToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.UndoToolStripMenuItem,
				this.normalizujOknoToolStripMenuItem
			});
			this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
			resources.ApplyResources(this.UndoToolStripMenuItem, "UndoToolStripMenuItem");
			this.UndoToolStripMenuItem.BackColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem";
			this.UndoToolStripMenuItem.Click += new global::System.EventHandler(this.UndoToolStripMenuItem_Click);
			resources.ApplyResources(this.normalizujOknoToolStripMenuItem, "normalizujOknoToolStripMenuItem");
			this.normalizujOknoToolStripMenuItem.BackColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.normalizujOknoToolStripMenuItem.Name = "normalizujOknoToolStripMenuItem";
			this.normalizujOknoToolStripMenuItem.Click += new global::System.EventHandler(this.normalizujOknoToolStripMenuItem_Click);
			resources.ApplyResources(this.MenuStrip1, "MenuStrip1");
			this.MenuStrip1.BackColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.MenuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.FileToolStripMenuItem,
				this.EditToolStripMenuItem
			});
			this.MenuStrip1.Name = "MenuStrip1";
			this.MenuStrip1.RenderMode = global::System.Windows.Forms.ToolStripRenderMode.Professional;
			this.MenuStrip1.ItemClicked += new global::System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStrip1_ItemClicked);
			resources.ApplyResources(this.button10, "button10");
			this.button10.BackColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.button10.ForeColor = global::System.Drawing.Color.Black;
			this.button10.Name = "button10";
			this.button10.UseVisualStyleBackColor = false;
			this.button10.Click += new global::System.EventHandler(this.button10_Click_1);
			resources.ApplyResources(this, "$this");
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.button10);
			base.Controls.Add(this.button9);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.SplitContainer1);
			base.Controls.Add(this.MenuStrip1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "Main";
			base.ShowInTaskbar = false;
			base.Load += new global::System.EventHandler(this.Form1_Load);
			this.SplitContainer1.Panel1.ResumeLayout(false);
			this.SplitContainer1.Panel2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.SplitContainer1).EndInit();
			this.SplitContainer1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
			this.TabControl1.ResumeLayout(false);
			this.tabPage6.ResumeLayout(false);
			this.tabPage6.PerformLayout();
			this.TabPage5.ResumeLayout(false);
			this.TabPage5.PerformLayout();
			this.TabPage3.ResumeLayout(false);
			this.TabPage3.PerformLayout();
			this.TabPage1.ResumeLayout(false);
			this.TabPage1.PerformLayout();
			this.TabPage2.ResumeLayout(false);
			this.TabPage2.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.TrackBarBrightness).EndInit();
			this.TabPage4.ResumeLayout(false);
			this.TabPage4.PerformLayout();
			this.tabPage7.ResumeLayout(false);
			this.tabPage7.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.trackBar1).EndInit();
			this.MenuStrip1.ResumeLayout(false);
			this.MenuStrip1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000010 RID: 16
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000011 RID: 17
		internal global::System.Windows.Forms.SplitContainer SplitContainer1;

		// Token: 0x04000012 RID: 18
		internal global::System.Windows.Forms.PictureBox PictureBox1;

		// Token: 0x04000013 RID: 19
		internal global::System.Windows.Forms.TabControl TabControl1;

		// Token: 0x04000014 RID: 20
		internal global::System.Windows.Forms.TabPage TabPage1;

		// Token: 0x04000015 RID: 21
		internal global::System.Windows.Forms.Label Label7;

		// Token: 0x04000016 RID: 22
		internal global::System.Windows.Forms.Label lbloriginalSize;

		// Token: 0x04000017 RID: 23
		internal global::System.Windows.Forms.Label lblModifiedSize;

		// Token: 0x04000018 RID: 24
		internal global::System.Windows.Forms.Label Label4;

		// Token: 0x04000019 RID: 25
		internal global::System.Windows.Forms.Button btnOk;

		// Token: 0x0400001A RID: 26
		internal global::System.Windows.Forms.Label Label3;

		// Token: 0x0400001B RID: 27
		internal global::System.Windows.Forms.DomainUpDown DomainUpDown1;

		// Token: 0x0400001C RID: 28
		internal global::System.Windows.Forms.Label Label2;

		// Token: 0x0400001D RID: 29
		internal global::System.Windows.Forms.Label Label1;

		// Token: 0x0400001E RID: 30
		internal global::System.Windows.Forms.TabPage TabPage3;

		// Token: 0x0400001F RID: 31
		internal global::System.Windows.Forms.Button btnCrop;

		// Token: 0x04000020 RID: 32
		internal global::System.Windows.Forms.Button btnMakeSelection;

		// Token: 0x04000021 RID: 33
		internal global::System.Windows.Forms.TabPage TabPage2;

		// Token: 0x04000022 RID: 34
		internal global::System.Windows.Forms.Label Label5;

		// Token: 0x04000023 RID: 35
		internal global::System.Windows.Forms.DomainUpDown DomainUpDownBrightness;

		// Token: 0x04000024 RID: 36
		internal global::System.Windows.Forms.TrackBar TrackBarBrightness;

		// Token: 0x04000025 RID: 37
		internal global::System.Windows.Forms.TabPage TabPage4;

		// Token: 0x04000026 RID: 38
		internal global::System.Windows.Forms.Button btnRotateRight;

		// Token: 0x04000027 RID: 39
		internal global::System.Windows.Forms.Button btnRotateHorizantal;

		// Token: 0x04000028 RID: 40
		internal global::System.Windows.Forms.Button btnRotatevertical;

		// Token: 0x04000029 RID: 41
		internal global::System.Windows.Forms.Button btnRotateLeft;

		// Token: 0x0400002A RID: 42
		internal global::System.Windows.Forms.TabPage TabPage5;

		// Token: 0x0400002B RID: 43
		internal global::System.Windows.Forms.Button btnCreateText;

		// Token: 0x0400002C RID: 44
		internal global::System.Windows.Forms.ComboBox cmbFonts;

		// Token: 0x0400002D RID: 45
		private global::System.Windows.Forms.Button button1;

		// Token: 0x0400002E RID: 46
		private global::System.Windows.Forms.Button button2;

		// Token: 0x0400002F RID: 47
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000030 RID: 48
		private global::System.Windows.Forms.TabPage tabPage6;

		// Token: 0x04000031 RID: 49
		private global::System.Windows.Forms.Button button3;

		// Token: 0x04000032 RID: 50
		private global::System.Windows.Forms.Label label8;

		// Token: 0x04000033 RID: 51
		private global::System.Windows.Forms.ColorDialog colorDialog1;

		// Token: 0x04000034 RID: 52
		private global::System.Windows.Forms.Button button4;

		// Token: 0x04000035 RID: 53
		private global::System.Windows.Forms.Button button5;

		// Token: 0x04000036 RID: 54
		private global::System.Windows.Forms.Button button7;

		// Token: 0x04000037 RID: 55
		private global::System.Windows.Forms.Button button6;

		// Token: 0x04000038 RID: 56
		private global::System.Windows.Forms.Button button8;

		// Token: 0x04000039 RID: 57
		private global::System.Windows.Forms.Button button9;

		// Token: 0x0400003A RID: 58
		private global::System.Windows.Forms.Label label9;

		// Token: 0x0400003B RID: 59
		internal global::System.Windows.Forms.ComboBox rozmiar;

		// Token: 0x0400003C RID: 60
		private global::System.Windows.Forms.SaveFileDialog saveFileDialog1;

		// Token: 0x0400003D RID: 61
		private global::System.Windows.Forms.TabPage tabPage7;

		// Token: 0x0400003E RID: 62
		private global::System.Windows.Forms.Label label10;

		// Token: 0x0400003F RID: 63
		private global::System.Windows.Forms.Label label11;

		// Token: 0x04000040 RID: 64
		internal global::System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;

		// Token: 0x04000041 RID: 65
		internal global::System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;

		// Token: 0x04000042 RID: 66
		internal global::System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;

		// Token: 0x04000043 RID: 67
		internal global::System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;

		// Token: 0x04000044 RID: 68
		private global::System.Windows.Forms.ToolStripMenuItem nowyPlikToolStripMenuItem;

		// Token: 0x04000045 RID: 69
		internal global::System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;

		// Token: 0x04000046 RID: 70
		internal global::System.Windows.Forms.ToolStripMenuItem UndoToolStripMenuItem;

		// Token: 0x04000047 RID: 71
		private global::System.Windows.Forms.ToolStripMenuItem normalizujOknoToolStripMenuItem;

		// Token: 0x04000048 RID: 72
		internal global::System.Windows.Forms.MenuStrip MenuStrip1;

		// Token: 0x04000049 RID: 73
		private global::System.Windows.Forms.TrackBar trackBar1;

		// Token: 0x0400004A RID: 74
		internal global::System.Windows.Forms.Button button10;
	}
}
