namespace XWorm
{
	// Token: 0x0200001C RID: 28
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class INFO : global::System.Windows.Forms.Form
	{
		// Token: 0x060005F3 RID: 1523 RVA: 0x000360E4 File Offset: 0x000342E4
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

		// Token: 0x060005F4 RID: 1524 RVA: 0x00036134 File Offset: 0x00034334
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::XWorm.INFO));
			this.StatusStrip1 = new global::System.Windows.Forms.StatusStrip();
			this.ToolStripStatusLabel1 = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.Timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.ImageList1 = new global::System.Windows.Forms.ImageList(this.components);
			this.ListView1 = new global::System.Windows.Forms.ListView();
			this.ColumnHeader1 = new global::System.Windows.Forms.ColumnHeader();
			this.Guna2ContextMenuStrip1 = new global::Guna.UI2.WinForms.Guna2ContextMenuStrip();
			this.ToolStripMenuItem4 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.SaveToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.StatusStrip1.SuspendLayout();
			this.Guna2ContextMenuStrip1.SuspendLayout();
			base.SuspendLayout();
			this.StatusStrip1.BackColor = global::System.Drawing.Color.White;
			this.StatusStrip1.ImageScalingSize = new global::System.Drawing.Size(24, 24);
			this.StatusStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.ToolStripStatusLabel1
			});
			this.StatusStrip1.Location = new global::System.Drawing.Point(0, 324);
			this.StatusStrip1.Name = "StatusStrip1";
			this.StatusStrip1.Padding = new global::System.Windows.Forms.Padding(1, 0, 9, 0);
			this.StatusStrip1.Size = new global::System.Drawing.Size(407, 22);
			this.StatusStrip1.TabIndex = 8;
			this.StatusStrip1.Text = "StatusStrip1";
			this.ToolStripStatusLabel1.ForeColor = global::System.Drawing.Color.Black;
			this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
			this.ToolStripStatusLabel1.Size = new global::System.Drawing.Size(13, 17);
			this.ToolStripStatusLabel1.Text = "..";
			this.Timer1.Enabled = true;
			this.Timer1.Interval = 1000;
			this.ImageList1.ImageStream = (global::System.Windows.Forms.ImageListStreamer)componentResourceManager.GetObject("ImageList1.ImageStream");
			this.ImageList1.TransparentColor = global::System.Drawing.Color.Transparent;
			this.ImageList1.Images.SetKeyName(0, "battery.png");
			this.ImageList1.Images.SetKeyName(1, "cpu.png");
			this.ImageList1.Images.SetKeyName(2, "gpu.png");
			this.ImageList1.Images.SetKeyName(3, "listdrivers.png");
			this.ImageList1.Images.SetKeyName(4, "listusb.png");
			this.ImageList1.Images.SetKeyName(5, "ram.png");
			this.ImageList1.Images.SetKeyName(6, "client.png");
			this.ImageList1.Images.SetKeyName(7, "process.png");
			this.ImageList1.Images.SetKeyName(8, "firewall.png");
			this.ImageList1.Images.SetKeyName(9, "biosreleasedate.png");
			this.ImageList1.Images.SetKeyName(10, "biosversion.png");
			this.ImageList1.Images.SetKeyName(11, "antivirus.png");
			this.ImageList1.Images.SetKeyName(12, "platform.png");
			this.ImageList1.Images.SetKeyName(13, "ver.png");
			this.ImageList1.Images.SetKeyName(14, "os.png");
			this.ImageList1.Images.SetKeyName(15, "datetime.png");
			this.ImageList1.Images.SetKeyName(16, "identifier.png");
			this.ImageList1.Images.SetKeyName(17, ".net.png");
			this.ImageList1.Images.SetKeyName(18, "systemproductname.png");
			this.ImageList1.Images.SetKeyName(19, "defaultbrowser.png");
			this.ImageList1.Images.SetKeyName(20, "currentlang.png");
			this.ImageList1.Images.SetKeyName(21, "macaddress.png");
			this.ImageList1.Images.SetKeyName(22, "hddserial.png");
			this.ImageList1.Images.SetKeyName(23, "lastreboot.png");
			this.ImageList1.Images.SetKeyName(24, "pcname.png");
			this.ImageList1.Images.SetKeyName(25, "username.png");
			this.ImageList1.Images.SetKeyName(26, "machinetype.png");
			this.ListView1.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.ListView1.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.ColumnHeader1
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
			this.ListView1.Size = new global::System.Drawing.Size(407, 324);
			this.ListView1.SmallImageList = this.ImageList1;
			this.ListView1.TabIndex = 9;
			this.ListView1.UseCompatibleStateImageBehavior = false;
			this.ListView1.View = global::System.Windows.Forms.View.Details;
			this.ColumnHeader1.Text = "[ Information ]";
			this.ColumnHeader1.Width = 380;
			this.Guna2ContextMenuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.ToolStripMenuItem4,
				this.SaveToolStripMenuItem1
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
			this.Guna2ContextMenuStrip1.Size = new global::System.Drawing.Size(181, 70);
			this.ToolStripMenuItem4.BackColor = global::System.Drawing.Color.White;
			this.ToolStripMenuItem4.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("ToolStripMenuItem4.Image");
			this.ToolStripMenuItem4.Name = "ToolStripMenuItem4";
			this.ToolStripMenuItem4.Size = new global::System.Drawing.Size(180, 22);
			this.ToolStripMenuItem4.Text = "[ Refresh ]";
			this.SaveToolStripMenuItem1.BackColor = global::System.Drawing.Color.White;
			this.SaveToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("SaveToolStripMenuItem1.Image");
			this.SaveToolStripMenuItem1.Name = "SaveToolStripMenuItem1";
			this.SaveToolStripMenuItem1.Size = new global::System.Drawing.Size(180, 22);
			this.SaveToolStripMenuItem1.Text = "[ Save ]";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.White;
			base.ClientSize = new global::System.Drawing.Size(407, 346);
			base.Controls.Add(this.ListView1);
			base.Controls.Add(this.StatusStrip1);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "INFO";
			this.Text = "Information";
			this.StatusStrip1.ResumeLayout(false);
			this.StatusStrip1.PerformLayout();
			this.Guna2ContextMenuStrip1.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000264 RID: 612
		private global::System.ComponentModel.IContainer components;
	}
}
