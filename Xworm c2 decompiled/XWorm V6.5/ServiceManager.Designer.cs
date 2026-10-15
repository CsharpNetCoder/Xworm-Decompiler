namespace XWorm
{
	// Token: 0x0200002B RID: 43
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class ServiceManager : global::System.Windows.Forms.Form
	{
		// Token: 0x06000820 RID: 2080 RVA: 0x0004798C File Offset: 0x00045B8C
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

		// Token: 0x06000821 RID: 2081 RVA: 0x000479DC File Offset: 0x00045BDC
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::XWorm.ServiceManager));
			this.ListView1 = new global::System.Windows.Forms.ListView();
			this.ColumnHeader1 = new global::System.Windows.Forms.ColumnHeader();
			this.ColumnHeader2 = new global::System.Windows.Forms.ColumnHeader();
			this.ColumnHeader7 = new global::System.Windows.Forms.ColumnHeader();
			this.ColumnHeader8 = new global::System.Windows.Forms.ColumnHeader();
			this.ColumnHeader9 = new global::System.Windows.Forms.ColumnHeader();
			this.Guna2ContextMenuStrip1 = new global::Guna.UI2.WinForms.Guna2ContextMenuStrip();
			this.ToolStripMenuItem4 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.RunningToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.StoppedToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.PauseToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.ImageList1 = new global::System.Windows.Forms.ImageList(this.components);
			this.StatusStrip1 = new global::System.Windows.Forms.StatusStrip();
			this.ToolStripStatusLabel1 = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.ToolStripStatusLabel2 = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.Timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.Guna2ContextMenuStrip1.SuspendLayout();
			this.StatusStrip1.SuspendLayout();
			base.SuspendLayout();
			this.ListView1.BackColor = global::System.Drawing.Color.White;
			this.ListView1.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.ListView1.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.ColumnHeader1,
				this.ColumnHeader2,
				this.ColumnHeader7,
				this.ColumnHeader8,
				this.ColumnHeader9
			});
			this.ListView1.ContextMenuStrip = this.Guna2ContextMenuStrip1;
			this.ListView1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.ListView1.Font = new global::System.Drawing.Font("Tahoma", 8f);
			this.ListView1.ForeColor = global::System.Drawing.Color.Black;
			this.ListView1.FullRowSelect = true;
			this.ListView1.HeaderStyle = global::System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.ListView1.HideSelection = false;
			this.ListView1.Location = new global::System.Drawing.Point(0, 0);
			this.ListView1.Name = "ListView1";
			this.ListView1.Size = new global::System.Drawing.Size(469, 285);
			this.ListView1.SmallImageList = this.ImageList1;
			this.ListView1.Sorting = global::System.Windows.Forms.SortOrder.Ascending;
			this.ListView1.TabIndex = 5;
			this.ListView1.UseCompatibleStateImageBehavior = false;
			this.ListView1.View = global::System.Windows.Forms.View.Details;
			this.ColumnHeader1.Text = "[ Name ]";
			this.ColumnHeader1.Width = 125;
			this.ColumnHeader2.Text = "[ DisplayName ]";
			this.ColumnHeader2.Width = 118;
			this.ColumnHeader7.Text = "[ ServiceType ]";
			this.ColumnHeader7.Width = 107;
			this.ColumnHeader8.Text = "[ Status ]";
			this.ColumnHeader8.Width = 89;
			this.ColumnHeader9.Text = "[ CanStop? ]";
			this.ColumnHeader9.Width = 99;
			this.Guna2ContextMenuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.ToolStripMenuItem4,
				this.RunningToolStripMenuItem,
				this.StoppedToolStripMenuItem,
				this.PauseToolStripMenuItem1
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
			this.Guna2ContextMenuStrip1.Size = new global::System.Drawing.Size(181, 114);
			this.ToolStripMenuItem4.BackColor = global::System.Drawing.Color.White;
			this.ToolStripMenuItem4.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("ToolStripMenuItem4.Image");
			this.ToolStripMenuItem4.Name = "ToolStripMenuItem4";
			this.ToolStripMenuItem4.Size = new global::System.Drawing.Size(180, 22);
			this.ToolStripMenuItem4.Text = "[ Refresh ]";
			this.RunningToolStripMenuItem.BackColor = global::System.Drawing.Color.White;
			this.RunningToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("RunningToolStripMenuItem.Image");
			this.RunningToolStripMenuItem.Name = "RunningToolStripMenuItem";
			this.RunningToolStripMenuItem.Size = new global::System.Drawing.Size(180, 22);
			this.RunningToolStripMenuItem.Text = "[ Running ]";
			this.StoppedToolStripMenuItem.BackColor = global::System.Drawing.Color.White;
			this.StoppedToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("StoppedToolStripMenuItem.Image");
			this.StoppedToolStripMenuItem.Name = "StoppedToolStripMenuItem";
			this.StoppedToolStripMenuItem.Size = new global::System.Drawing.Size(180, 22);
			this.StoppedToolStripMenuItem.Text = "[ Stopped ]";
			this.PauseToolStripMenuItem1.BackColor = global::System.Drawing.Color.White;
			this.PauseToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("PauseToolStripMenuItem1.Image");
			this.PauseToolStripMenuItem1.Name = "PauseToolStripMenuItem1";
			this.PauseToolStripMenuItem1.Size = new global::System.Drawing.Size(180, 22);
			this.PauseToolStripMenuItem1.Text = "[ Pause ]";
			this.ImageList1.ImageStream = (global::System.Windows.Forms.ImageListStreamer)componentResourceManager.GetObject("ImageList1.ImageStream");
			this.ImageList1.TransparentColor = global::System.Drawing.Color.Transparent;
			this.ImageList1.Images.SetKeyName(0, "icons8-settings-20 (1).png");
			this.StatusStrip1.BackColor = global::System.Drawing.Color.White;
			this.StatusStrip1.ImageScalingSize = new global::System.Drawing.Size(24, 24);
			this.StatusStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.ToolStripStatusLabel1,
				this.ToolStripStatusLabel2
			});
			this.StatusStrip1.Location = new global::System.Drawing.Point(0, 285);
			this.StatusStrip1.Name = "StatusStrip1";
			this.StatusStrip1.Padding = new global::System.Windows.Forms.Padding(1, 0, 9, 0);
			this.StatusStrip1.Size = new global::System.Drawing.Size(469, 22);
			this.StatusStrip1.TabIndex = 6;
			this.StatusStrip1.Text = "StatusStrip1";
			this.ToolStripStatusLabel1.ForeColor = global::System.Drawing.Color.Black;
			this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
			this.ToolStripStatusLabel1.Size = new global::System.Drawing.Size(68, 17);
			this.ToolStripStatusLabel1.Text = "Selected [0]";
			this.ToolStripStatusLabel2.ForeColor = global::System.Drawing.Color.Black;
			this.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2";
			this.ToolStripStatusLabel2.Size = new global::System.Drawing.Size(13, 17);
			this.ToolStripStatusLabel2.Text = "..";
			this.Timer1.Enabled = true;
			this.Timer1.Interval = 1000;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.White;
			base.ClientSize = new global::System.Drawing.Size(469, 307);
			base.Controls.Add(this.ListView1);
			base.Controls.Add(this.StatusStrip1);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "ServiceManager";
			this.Text = "Service Manager";
			this.Guna2ContextMenuStrip1.ResumeLayout(false);
			this.StatusStrip1.ResumeLayout(false);
			this.StatusStrip1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400035C RID: 860
		private global::System.ComponentModel.IContainer components;
	}
}
