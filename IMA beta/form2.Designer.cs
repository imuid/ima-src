namespace IMA
{
	// Token: 0x02000005 RID: 5
	public partial class form2 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000040 RID: 64 RVA: 0x000052D4 File Offset: 0x000034D4
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x0000530C File Offset: 0x0000350C
		private void InitializeComponent()
		{
			this.button1 = new global::System.Windows.Forms.Button();
			this.trackBar1 = new global::System.Windows.Forms.TrackBar();
			this.label1 = new global::System.Windows.Forms.Label();
			this.button2 = new global::System.Windows.Forms.Button();
			this.label2 = new global::System.Windows.Forms.Label();
			this.colorDialog1 = new global::System.Windows.Forms.ColorDialog();
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.textBox2 = new global::System.Windows.Forms.TextBox();
			this.button3 = new global::System.Windows.Forms.Button();
			((global::System.ComponentModel.ISupportInitialize)this.trackBar1).BeginInit();
			base.SuspendLayout();
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new global::System.Drawing.Font("Segoe UI", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 238);
			this.button1.Location = new global::System.Drawing.Point(370, 12);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(75, 27);
			this.button1.TabIndex = 0;
			this.button1.Text = "Zamknij";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.trackBar1.Location = new global::System.Drawing.Point(449, 95);
			this.trackBar1.Maximum = 100;
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new global::System.Drawing.Size(104, 45);
			this.trackBar1.TabIndex = 1;
			this.trackBar1.Scroll += new global::System.EventHandler(this.trackBar1_Scroll);
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Segoe UI", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 238);
			this.label1.Location = new global::System.Drawing.Point(315, 95);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(85, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Przezroczystość";
			this.button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new global::System.Drawing.Font("Segoe UI", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 238);
			this.button2.Location = new global::System.Drawing.Point(449, 146);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(63, 27);
			this.button2.TabIndex = 3;
			this.button2.Text = "Wybierz";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Segoe UI", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 238);
			this.label2.Location = new global::System.Drawing.Point(315, 153);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(87, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Kolor Programu";
			this.textBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.textBox1.Font = new global::System.Drawing.Font("Segoe UI", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 238);
			this.textBox1.Location = new global::System.Drawing.Point(449, 187);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new global::System.Drawing.Size(95, 20);
			this.textBox1.TabIndex = 5;
			this.textBox1.TextChanged += new global::System.EventHandler(this.textBox1_TextChanged);
			this.label3.AutoSize = true;
			this.label3.Font = new global::System.Drawing.Font("Segoe UI", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 238);
			this.label3.Location = new global::System.Drawing.Point(315, 194);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(109, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Nazwa użytkownika";
			this.label4.AutoSize = true;
			this.label4.Font = new global::System.Drawing.Font("Segoe UI", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 238);
			this.label4.Location = new global::System.Drawing.Point(315, 233);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(115, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "tytuł okna głównego";
			this.textBox2.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.textBox2.Font = new global::System.Drawing.Font("Segoe UI", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 238);
			this.textBox2.Location = new global::System.Drawing.Point(449, 233);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new global::System.Drawing.Size(95, 20);
			this.textBox2.TabIndex = 8;
			this.textBox2.TextChanged += new global::System.EventHandler(this.textBox2_TextChanged);
			this.button3.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button3.Location = new global::System.Drawing.Point(318, 415);
			this.button3.Name = "button3";
			this.button3.Size = new global::System.Drawing.Size(145, 23);
			this.button3.TabIndex = 10;
			this.button3.Text = "Otwórz Konsolę IMy 2";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new global::System.EventHandler(this.button3_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			base.ClientSize = new global::System.Drawing.Size(800, 450);
			base.Controls.Add(this.button3);
			base.Controls.Add(this.textBox2);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.textBox1);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.trackBar1);
			base.Controls.Add(this.button1);
			this.Cursor = global::System.Windows.Forms.Cursors.Cross;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "form2";
			base.ShowInTaskbar = false;
			this.Text = "ustawienia";
			base.Load += new global::System.EventHandler(this.form2_Load);
			((global::System.ComponentModel.ISupportInitialize)this.trackBar1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400004B RID: 75
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400004C RID: 76
		private global::System.Windows.Forms.Button button1;

		// Token: 0x0400004D RID: 77
		private global::System.Windows.Forms.TrackBar trackBar1;

		// Token: 0x0400004E RID: 78
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400004F RID: 79
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04000050 RID: 80
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000051 RID: 81
		private global::System.Windows.Forms.ColorDialog colorDialog1;

		// Token: 0x04000052 RID: 82
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x04000053 RID: 83
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000054 RID: 84
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000055 RID: 85
		private global::System.Windows.Forms.TextBox textBox2;

		// Token: 0x04000056 RID: 86
		private global::System.Windows.Forms.Button button3;
	}
}
