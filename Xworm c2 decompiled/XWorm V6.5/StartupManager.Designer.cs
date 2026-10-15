namespace XWorm
{
	// Token: 0x0200002D RID: 45
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class StartupManager : global::System.Windows.Forms.Form
	{
		// Token: 0x0600085F RID: 2143 RVA: 0x00049254 File Offset: 0x00047454
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

		// Token: 0x06000860 RID: 2144 RVA: 0x000492A4 File Offset: 0x000474A4
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::XWorm.StartupManager));
			this.ListView1 = new global::System.Windows.Forms.ListView();
			this.ColumnHeader3 = new global::System.Windows.Forms.ColumnHeader();
			this.ColumnHeader4 = new global::System.Windows.Forms.ColumnHeader();
			this.ColumnHeader5 = new global::System.Windows.Forms.ColumnHeader();
			this.ImageList1 = new global::System.Windows.Forms.ImageList(this.components);
			this.StatusStrip1 = new global::System.Windows.Forms.StatusStrip();
			this.ToolStripStatusLabel3 = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.ToolStripStatusLabel4 = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.Timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.Guna2ContextMenuStrip1 = new global::Guna.UI2.WinForms.Guna2ContextMenuStrip();
			this.ToolStripMenuItem4 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.DeleteToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.StatusStrip1.SuspendLayout();
			this.Guna2ContextMenuStrip1.SuspendLayout();
			base.SuspendLayout();
			this.ListView1.BackColor = global::System.Drawing.Color.White;
			this.ListView1.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.ListView1.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.ColumnHeader3,
				this.ColumnHeader4,
				this.ColumnHeader5
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
			this.ListView1.ShowGroups = false;
			this.ListView1.ShowItemToolTips = true;
			this.ListView1.Size = new global::System.Drawing.Size(469, 285);
			this.ListView1.SmallImageList = this.ImageList1;
			this.ListView1.TabIndex = 3;
			this.ListView1.UseCompatibleStateImageBehavior = false;
			this.ListView1.View = global::System.Windows.Forms.View.Details;
			this.ColumnHeader3.Text = "[ Name ]";
			this.ColumnHeader3.Width = 183;
			this.ColumnHeader4.Text = "[ Type ]";
			this.ColumnHeader4.Width = 98;
			this.ColumnHeader5.Text = "[ Path ]";
			this.ColumnHeader5.Width = 245;
			this.ImageList1.ImageStream = (global::System.Windows.Forms.ImageListStreamer)componentResourceManager.GetObject("ImageList1.ImageStream");
			this.ImageList1.TransparentColor = global::System.Drawing.Color.Transparent;
			this.ImageList1.Images.SetKeyName(0, "icons8-clock-20.png");
			this.ImageList1.Images.SetKeyName(1, "icons8-document-20.png");
			this.ImageList1.Images.SetKeyName(2, "icons8-registry-editor-20 (1).png");
			this.StatusStrip1.BackColor = global::System.Drawing.Color.White;
			this.StatusStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.ToolStripStatusLabel3,
				this.ToolStripStatusLabel4
			});
			this.StatusStrip1.Location = new global::System.Drawing.Point(0, 285);
			this.StatusStrip1.Name = "StatusStrip1";
			this.StatusStrip1.Size = new global::System.Drawing.Size(469, 22);
			this.StatusStrip1.TabIndex = 4;
			this.StatusStrip1.Text = "StatusStrip1";
			this.ToolStripStatusLabel3.ForeColor = global::System.Drawing.Color.Black;
			this.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3";
			this.ToolStripStatusLabel3.Size = new global::System.Drawing.Size(68, 17);
			this.ToolStripStatusLabel3.Text = "Selected [0]";
			this.ToolStripStatusLabel4.ForeColor = global::System.Drawing.Color.Black;
			this.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4";
			this.ToolStripStatusLabel4.Size = new global::System.Drawing.Size(13, 17);
			this.ToolStripStatusLabel4.Text = "..";
			this.Timer1.Enabled = true;
			this.Timer1.Interval = 1000;
			this.Guna2ContextMenuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.ToolStripMenuItem4,
				this.DeleteToolStripMenuItem
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
			this.Guna2ContextMenuStrip1.Size = new global::System.Drawing.Size(128, 48);
			this.ToolStripMenuItem4.BackColor = global::System.Drawing.Color.White;
			this.ToolStripMenuItem4.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("ToolStripMenuItem4.Image");
			this.ToolStripMenuItem4.Name = "ToolStripMenuItem4";
			this.ToolStripMenuItem4.Size = new global::System.Drawing.Size(127, 22);
			this.ToolStripMenuItem4.Text = "[ Refresh ]";
			this.DeleteToolStripMenuItem.BackColor = global::System.Drawing.Color.White;
			this.DeleteToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("DeleteToolStripMenuItem.Image");
			this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
			this.DeleteToolStripMenuItem.Size = new global::System.Drawing.Size(127, 22);
			this.DeleteToolStripMenuItem.Text = "[ Delete ]";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.White;
			base.ClientSize = new global::System.Drawing.Size(469, 307);
			base.Controls.Add(this.ListView1);
			base.Controls.Add(this.StatusStrip1);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "StartupManager";
			this.Text = "Startup Manager";
			this.StatusStrip1.ResumeLayout(false);
			this.StatusStrip1.PerformLayout();
			this.Guna2ContextMenuStrip1.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000378 RID: 888
		private global::System.ComponentModel.IContainer components;
	}
}
