namespace XWorm
{
	// Token: 0x02000010 RID: 16
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class FilesSearcher : global::System.Windows.Forms.Form
	{
		// Token: 0x060000DC RID: 220 RVA: 0x00008318 File Offset: 0x00006518
		[global::System.Diagnostics.DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				bool flag = disposing && this.components != null;
				if (flag)
				{
					this.components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00008368 File Offset: 0x00006568
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::XWorm.FilesSearcher));
			this.ListBox1 = new global::System.Windows.Forms.ListBox();
			this.Guna2ContextMenuStrip2 = new global::Guna.UI2.WinForms.Guna2ContextMenuStrip();
			this.AddToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.RemoveToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem7 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.Panel1 = new global::System.Windows.Forms.Panel();
			this.Guna2NumericUpDown1 = new global::Guna.UI2.WinForms.Guna2NumericUpDown();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.ToolStripStatusLabel1 = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.StatusStrip1 = new global::System.Windows.Forms.StatusStrip();
			this.Timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.Panel5 = new global::System.Windows.Forms.Panel();
			this.Guna2Panel1 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.Guna2GradientButton1 = new global::Guna.UI2.WinForms.Guna2GradientButton();
			this.Guna2Panel3 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.Guna2Panel2 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.Guna2ContextMenuStrip2.SuspendLayout();
			this.Panel1.SuspendLayout();
			this.Guna2NumericUpDown1.BeginInit();
			this.StatusStrip1.SuspendLayout();
			this.Panel5.SuspendLayout();
			this.Guna2Panel1.SuspendLayout();
			base.SuspendLayout();
			this.ListBox1.BackColor = global::System.Drawing.Color.White;
			this.ListBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.ListBox1.ContextMenuStrip = this.Guna2ContextMenuStrip2;
			this.ListBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.ListBox1.Font = new global::System.Drawing.Font("Tahoma", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ListBox1.ForeColor = global::System.Drawing.Color.Black;
			this.ListBox1.FormattingEnabled = true;
			this.ListBox1.ItemHeight = 14;
			this.ListBox1.Items.AddRange(new object[]
			{
				".txt",
				".pdf",
				".doc"
			});
			this.ListBox1.Location = new global::System.Drawing.Point(0, 32);
			this.ListBox1.Name = "ListBox1";
			this.ListBox1.SelectionMode = global::System.Windows.Forms.SelectionMode.MultiExtended;
			this.ListBox1.Size = new global::System.Drawing.Size(400, 149);
			this.ListBox1.TabIndex = 0;
			this.Guna2ContextMenuStrip2.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.AddToolStripMenuItem1,
				this.RemoveToolStripMenuItem1,
				this.ToolStripMenuItem7
			});
			this.Guna2ContextMenuStrip2.Name = "Guna2ContextMenuStrip2";
			this.Guna2ContextMenuStrip2.RenderStyle.ArrowColor = global::System.Drawing.Color.FromArgb(151, 143, 255);
			this.Guna2ContextMenuStrip2.RenderStyle.BorderColor = global::System.Drawing.Color.Gainsboro;
			this.Guna2ContextMenuStrip2.RenderStyle.ColorTable = null;
			this.Guna2ContextMenuStrip2.RenderStyle.RoundedEdges = true;
			this.Guna2ContextMenuStrip2.RenderStyle.SelectionArrowColor = global::System.Drawing.Color.White;
			this.Guna2ContextMenuStrip2.RenderStyle.SelectionBackColor = global::System.Drawing.Color.FromArgb(113, 74, 250);
			this.Guna2ContextMenuStrip2.RenderStyle.SelectionForeColor = global::System.Drawing.Color.White;
			this.Guna2ContextMenuStrip2.RenderStyle.SeparatorColor = global::System.Drawing.Color.Gainsboro;
			this.Guna2ContextMenuStrip2.RenderStyle.TextRenderingHint = global::System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			this.Guna2ContextMenuStrip2.Size = new global::System.Drawing.Size(132, 70);
			this.AddToolStripMenuItem1.BackColor = global::System.Drawing.Color.White;
			this.AddToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("AddToolStripMenuItem1.Image");
			this.AddToolStripMenuItem1.Name = "AddToolStripMenuItem1";
			this.AddToolStripMenuItem1.Size = new global::System.Drawing.Size(131, 22);
			this.AddToolStripMenuItem1.Text = "[ Add ]";
			this.RemoveToolStripMenuItem1.BackColor = global::System.Drawing.Color.White;
			this.RemoveToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("RemoveToolStripMenuItem1.Image");
			this.RemoveToolStripMenuItem1.Name = "RemoveToolStripMenuItem1";
			this.RemoveToolStripMenuItem1.Size = new global::System.Drawing.Size(131, 22);
			this.RemoveToolStripMenuItem1.Text = "[ Remove ]";
			this.ToolStripMenuItem7.BackColor = global::System.Drawing.Color.White;
			this.ToolStripMenuItem7.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("ToolStripMenuItem7.Image");
			this.ToolStripMenuItem7.Name = "ToolStripMenuItem7";
			this.ToolStripMenuItem7.Size = new global::System.Drawing.Size(131, 22);
			this.ToolStripMenuItem7.Text = "[ Clear ]";
			this.Panel1.Controls.Add(this.Label2);
			this.Panel1.Controls.Add(this.Guna2NumericUpDown1);
			this.Panel1.Controls.Add(this.Label1);
			this.Panel1.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.Panel1.Location = new global::System.Drawing.Point(0, 181);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new global::System.Drawing.Size(400, 36);
			this.Panel1.TabIndex = 8;
			this.Guna2NumericUpDown1.BackColor = global::System.Drawing.Color.Transparent;
			this.Guna2NumericUpDown1.BorderRadius = 3;
			this.Guna2NumericUpDown1.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.Guna2NumericUpDown1.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.Guna2NumericUpDown1.Location = new global::System.Drawing.Point(76, 6);
			this.Guna2NumericUpDown1.Name = "Guna2NumericUpDown1";
			this.Guna2NumericUpDown1.Size = new global::System.Drawing.Size(80, 24);
			this.Guna2NumericUpDown1.TabIndex = 74;
			this.Guna2NumericUpDown1.UpDownButtonFillColor = global::System.Drawing.Color.FromArgb(136, 200, 236);
			global::Guna.UI2.WinForms.Guna2NumericUpDown guna2NumericUpDown = this.Guna2NumericUpDown1;
			int[] array = new int[4];
			array[0] = 3;
			guna2NumericUpDown.Value = new decimal(array);
			this.Label2.AutoSize = true;
			this.Label2.ForeColor = global::System.Drawing.Color.Black;
			this.Label2.Location = new global::System.Drawing.Point(162, 12);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(21, 13);
			this.Label2.TabIndex = 2;
			this.Label2.Text = "MB";
			this.Label1.AutoSize = true;
			this.Label1.ForeColor = global::System.Drawing.Color.Black;
			this.Label1.Location = new global::System.Drawing.Point(18, 11);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(56, 13);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "MaxSize : ";
			this.ToolStripStatusLabel1.ForeColor = global::System.Drawing.Color.Black;
			this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
			this.ToolStripStatusLabel1.Size = new global::System.Drawing.Size(13, 17);
			this.ToolStripStatusLabel1.Text = "..";
			this.StatusStrip1.BackColor = global::System.Drawing.Color.White;
			this.StatusStrip1.ImageScalingSize = new global::System.Drawing.Size(24, 24);
			this.StatusStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.ToolStripStatusLabel1
			});
			this.StatusStrip1.Location = new global::System.Drawing.Point(0, 217);
			this.StatusStrip1.Name = "StatusStrip1";
			this.StatusStrip1.Padding = new global::System.Windows.Forms.Padding(1, 0, 9, 0);
			this.StatusStrip1.Size = new global::System.Drawing.Size(400, 22);
			this.StatusStrip1.TabIndex = 7;
			this.StatusStrip1.Text = "StatusStrip1";
			this.Timer1.Enabled = true;
			this.Timer1.Interval = 1000;
			this.Panel5.Controls.Add(this.Guna2Panel1);
			this.Panel5.Controls.Add(this.Guna2Panel3);
			this.Panel5.Controls.Add(this.Guna2Panel2);
			this.Panel5.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Panel5.Location = new global::System.Drawing.Point(0, 0);
			this.Panel5.Name = "Panel5";
			this.Panel5.Size = new global::System.Drawing.Size(400, 32);
			this.Panel5.TabIndex = 31;
			this.Guna2Panel1.Controls.Add(this.Guna2GradientButton1);
			this.Guna2Panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Guna2Panel1.Location = new global::System.Drawing.Point(33, 0);
			this.Guna2Panel1.Name = "Guna2Panel1";
			this.Guna2Panel1.Size = new global::System.Drawing.Size(334, 21);
			this.Guna2Panel1.TabIndex = 35;
			this.Guna2GradientButton1.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.Guna2GradientButton1.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.Guna2GradientButton1.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.Guna2GradientButton1.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.Guna2GradientButton1.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.Guna2GradientButton1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.Guna2GradientButton1.FillColor2 = global::System.Drawing.Color.FromArgb(40, 192, 182);
			this.Guna2GradientButton1.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.Guna2GradientButton1.ForeColor = global::System.Drawing.Color.White;
			this.Guna2GradientButton1.Image = global::XWorm.My.Resources.Resources.Play;
			this.Guna2GradientButton1.ImageAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.Guna2GradientButton1.ImageSize = new global::System.Drawing.Size(15, 15);
			this.Guna2GradientButton1.Location = new global::System.Drawing.Point(0, 0);
			this.Guna2GradientButton1.Name = "Guna2GradientButton1";
			this.Guna2GradientButton1.Size = new global::System.Drawing.Size(334, 21);
			this.Guna2GradientButton1.TabIndex = 34;
			this.Guna2GradientButton1.Text = "Run";
			this.Guna2Panel3.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.Guna2Panel3.Location = new global::System.Drawing.Point(0, 0);
			this.Guna2Panel3.Name = "Guna2Panel3";
			this.Guna2Panel3.Size = new global::System.Drawing.Size(33, 32);
			this.Guna2Panel3.TabIndex = 37;
			this.Guna2Panel2.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.Guna2Panel2.Location = new global::System.Drawing.Point(367, 0);
			this.Guna2Panel2.Name = "Guna2Panel2";
			this.Guna2Panel2.Size = new global::System.Drawing.Size(33, 32);
			this.Guna2Panel2.TabIndex = 36;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.White;
			base.ClientSize = new global::System.Drawing.Size(400, 239);
			base.Controls.Add(this.ListBox1);
			base.Controls.Add(this.Panel5);
			base.Controls.Add(this.Panel1);
			base.Controls.Add(this.StatusStrip1);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "FilesSearcher";
			this.Text = "Files Searcher";
			this.Guna2ContextMenuStrip2.ResumeLayout(false);
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.Guna2NumericUpDown1.EndInit();
			this.StatusStrip1.ResumeLayout(false);
			this.StatusStrip1.PerformLayout();
			this.Panel5.ResumeLayout(false);
			this.Guna2Panel1.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000058 RID: 88
		private global::System.ComponentModel.IContainer components;
	}
}
