namespace XWorm
{
	// Token: 0x0200001E RID: 30
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Maps : global::System.Windows.Forms.Form
	{
		// Token: 0x06000629 RID: 1577 RVA: 0x00037870 File Offset: 0x00035A70
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

		// Token: 0x0600062A RID: 1578 RVA: 0x000378C0 File Offset: 0x00035AC0
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::XWorm.Maps));
			this.GMapControl1 = new global::GMap.NET.WindowsForms.GMapControl();
			this.Timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.StatusStrip1 = new global::System.Windows.Forms.StatusStrip();
			this.ToolStripStatusLabel1 = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.Guna2ContextMenuStrip2 = new global::Guna.UI2.WinForms.Guna2ContextMenuStrip();
			this.GPSToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.IPAPIToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.BrowserToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.StatusStrip1.SuspendLayout();
			this.Guna2ContextMenuStrip2.SuspendLayout();
			base.SuspendLayout();
			this.GMapControl1.Bearing = 0f;
			this.GMapControl1.CanDragMap = true;
			this.GMapControl1.ContextMenuStrip = this.Guna2ContextMenuStrip2;
			this.GMapControl1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.GMapControl1.EmptyTileColor = global::System.Drawing.Color.Navy;
			this.GMapControl1.GrayScaleMode = false;
			this.GMapControl1.HelperLineOption = 0;
			this.GMapControl1.LevelsKeepInMemmory = 5;
			this.GMapControl1.Location = new global::System.Drawing.Point(0, 0);
			this.GMapControl1.MarkersEnabled = true;
			this.GMapControl1.MaxZoom = 16;
			this.GMapControl1.MinZoom = 0;
			this.GMapControl1.MouseWheelZoomEnabled = true;
			this.GMapControl1.MouseWheelZoomType = 0;
			this.GMapControl1.Name = "GMapControl1";
			this.GMapControl1.NegativeMode = false;
			this.GMapControl1.PolygonsEnabled = true;
			this.GMapControl1.RetryLoadTile = 0;
			this.GMapControl1.RoutesEnabled = true;
			this.GMapControl1.ScaleMode = 0;
			this.GMapControl1.SelectedAreaFillColor = global::System.Drawing.Color.FromArgb(33, 65, 105, 225);
			this.GMapControl1.ShowTileGridLines = false;
			this.GMapControl1.Size = new global::System.Drawing.Size(492, 270);
			this.GMapControl1.TabIndex = 11;
			this.GMapControl1.Zoom = 5.0;
			this.Timer1.Enabled = true;
			this.Timer1.Interval = 1000;
			this.StatusStrip1.BackColor = global::System.Drawing.Color.White;
			this.StatusStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.ToolStripStatusLabel1
			});
			this.StatusStrip1.Location = new global::System.Drawing.Point(0, 270);
			this.StatusStrip1.Name = "StatusStrip1";
			this.StatusStrip1.Size = new global::System.Drawing.Size(492, 22);
			this.StatusStrip1.TabIndex = 12;
			this.StatusStrip1.Text = "StatusStrip1";
			this.ToolStripStatusLabel1.ForeColor = global::System.Drawing.Color.Black;
			this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
			this.ToolStripStatusLabel1.Size = new global::System.Drawing.Size(13, 17);
			this.ToolStripStatusLabel1.Text = "..";
			this.Guna2ContextMenuStrip2.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.GPSToolStripMenuItem1,
				this.IPAPIToolStripMenuItem,
				this.BrowserToolStripMenuItem
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
			this.Guna2ContextMenuStrip2.Size = new global::System.Drawing.Size(181, 92);
			this.GPSToolStripMenuItem1.BackColor = global::System.Drawing.Color.White;
			this.GPSToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("GPSToolStripMenuItem1.Image");
			this.GPSToolStripMenuItem1.Name = "GPSToolStripMenuItem1";
			this.GPSToolStripMenuItem1.Size = new global::System.Drawing.Size(180, 22);
			this.GPSToolStripMenuItem1.Text = "[ GPS ]";
			this.IPAPIToolStripMenuItem.BackColor = global::System.Drawing.Color.White;
			this.IPAPIToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("IPAPIToolStripMenuItem.Image");
			this.IPAPIToolStripMenuItem.Name = "IPAPIToolStripMenuItem";
			this.IPAPIToolStripMenuItem.Size = new global::System.Drawing.Size(180, 22);
			this.IPAPIToolStripMenuItem.Text = "[ IP-API ]";
			this.BrowserToolStripMenuItem.BackColor = global::System.Drawing.Color.White;
			this.BrowserToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("BrowserToolStripMenuItem.Image");
			this.BrowserToolStripMenuItem.Name = "BrowserToolStripMenuItem";
			this.BrowserToolStripMenuItem.Size = new global::System.Drawing.Size(180, 22);
			this.BrowserToolStripMenuItem.Text = "[ Browser ]";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(492, 292);
			base.Controls.Add(this.GMapControl1);
			base.Controls.Add(this.StatusStrip1);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Maps";
			this.Text = "Maps";
			this.StatusStrip1.ResumeLayout(false);
			this.StatusStrip1.PerformLayout();
			this.Guna2ContextMenuStrip2.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400027D RID: 637
		private global::System.ComponentModel.IContainer components;
	}
}
