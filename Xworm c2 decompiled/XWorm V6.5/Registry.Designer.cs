namespace XWorm
{
	// Token: 0x02000028 RID: 40
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Registry : global::System.Windows.Forms.Form
	{
		// Token: 0x0600079A RID: 1946 RVA: 0x000432D4 File Offset: 0x000414D4
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

		// Token: 0x0600079B RID: 1947 RVA: 0x00043324 File Offset: 0x00041524
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.Windows.Forms.TreeNode treeNode = new global::System.Windows.Forms.TreeNode("HKEY_CLASSES_ROOT");
			global::System.Windows.Forms.TreeNode treeNode2 = new global::System.Windows.Forms.TreeNode("HKEY_CURRENT_USER");
			global::System.Windows.Forms.TreeNode treeNode3 = new global::System.Windows.Forms.TreeNode("HKEY_LOCAL_MACHINE");
			global::System.Windows.Forms.TreeNode treeNode4 = new global::System.Windows.Forms.TreeNode("HKEY_USERS");
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::XWorm.Registry));
			this.StatusStrip1 = new global::System.Windows.Forms.StatusStrip();
			this.ToolStripProgressBar1 = new global::System.Windows.Forms.ToolStripProgressBar();
			this.ToolStripStatusLabel1 = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.RGk = new global::System.Windows.Forms.TreeView();
			this.img = new global::System.Windows.Forms.ImageList(this.components);
			this.ListView1 = new global::System.Windows.Forms.ListView();
			this.ColumnHeader1 = new global::System.Windows.Forms.ColumnHeader();
			this.ColumnHeader2 = new global::System.Windows.Forms.ColumnHeader();
			this.ColumnHeader3 = new global::System.Windows.Forms.ColumnHeader();
			this.Timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.Splitter1 = new global::System.Windows.Forms.Splitter();
			this.Guna2ContextMenuStrip2 = new global::Guna.UI2.WinForms.Guna2ContextMenuStrip();
			this.AddToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.RemoveToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.RefreshToolStripMenuItem2 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.Guna2ContextMenuStrip1 = new global::Guna.UI2.WinForms.Guna2ContextMenuStrip();
			this.ToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.NewValueToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.EditToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.DeleteToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.StatusStrip1.SuspendLayout();
			this.Guna2ContextMenuStrip2.SuspendLayout();
			this.Guna2ContextMenuStrip1.SuspendLayout();
			base.SuspendLayout();
			this.StatusStrip1.BackColor = global::System.Drawing.Color.White;
			this.StatusStrip1.ImageScalingSize = new global::System.Drawing.Size(24, 24);
			this.StatusStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.ToolStripProgressBar1,
				this.ToolStripStatusLabel1
			});
			this.StatusStrip1.Location = new global::System.Drawing.Point(0, 328);
			this.StatusStrip1.Name = "StatusStrip1";
			this.StatusStrip1.Padding = new global::System.Windows.Forms.Padding(1, 0, 9, 0);
			this.StatusStrip1.Size = new global::System.Drawing.Size(636, 22);
			this.StatusStrip1.TabIndex = 5;
			this.StatusStrip1.Text = "v";
			this.ToolStripProgressBar1.Name = "ToolStripProgressBar1";
			this.ToolStripProgressBar1.Size = new global::System.Drawing.Size(100, 16);
			this.ToolStripStatusLabel1.ForeColor = global::System.Drawing.Color.Black;
			this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
			this.ToolStripStatusLabel1.Size = new global::System.Drawing.Size(13, 17);
			this.ToolStripStatusLabel1.Text = "..";
			this.RGk.BackColor = global::System.Drawing.Color.White;
			this.RGk.ContextMenuStrip = this.Guna2ContextMenuStrip2;
			this.RGk.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.RGk.ForeColor = global::System.Drawing.Color.Black;
			this.RGk.ImageIndex = 0;
			this.RGk.ImageList = this.img;
			this.RGk.Location = new global::System.Drawing.Point(0, 0);
			this.RGk.Name = "RGk";
			treeNode.ImageIndex = -2;
			treeNode.Name = "HKEY_CLASSES_ROOT";
			treeNode.Text = "HKEY_CLASSES_ROOT";
			treeNode2.ImageIndex = -2;
			treeNode2.Name = "HKEY_CURRENT_USER";
			treeNode2.Text = "HKEY_CURRENT_USER";
			treeNode3.ImageIndex = -2;
			treeNode3.Name = "HKEY_LOCAL_MACHINE";
			treeNode3.Text = "HKEY_LOCAL_MACHINE";
			treeNode4.ImageIndex = -2;
			treeNode4.Name = "HKEY_USERS";
			treeNode4.Text = "HKEY_USERS";
			this.RGk.Nodes.AddRange(new global::System.Windows.Forms.TreeNode[]
			{
				treeNode,
				treeNode2,
				treeNode3,
				treeNode4
			});
			this.RGk.SelectedImageIndex = 0;
			this.RGk.Size = new global::System.Drawing.Size(200, 328);
			this.RGk.TabIndex = 10;
			this.img.ImageStream = (global::System.Windows.Forms.ImageListStreamer)componentResourceManager.GetObject("img.ImageStream");
			this.img.TransparentColor = global::System.Drawing.Color.Transparent;
			this.img.Images.SetKeyName(0, "image0.png");
			this.img.Images.SetKeyName(1, "1.png");
			this.img.Images.SetKeyName(2, "2.png");
			this.ListView1.BackColor = global::System.Drawing.Color.White;
			this.ListView1.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.ListView1.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.ColumnHeader1,
				this.ColumnHeader2,
				this.ColumnHeader3
			});
			this.ListView1.ContextMenuStrip = this.Guna2ContextMenuStrip1;
			this.ListView1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.ListView1.Font = new global::System.Drawing.Font("Tahoma", 8f);
			this.ListView1.ForeColor = global::System.Drawing.Color.Black;
			this.ListView1.FullRowSelect = true;
			this.ListView1.HeaderStyle = global::System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.ListView1.HideSelection = false;
			this.ListView1.Location = new global::System.Drawing.Point(200, 0);
			this.ListView1.Name = "ListView1";
			this.ListView1.Size = new global::System.Drawing.Size(436, 328);
			this.ListView1.SmallImageList = this.img;
			this.ListView1.TabIndex = 11;
			this.ListView1.UseCompatibleStateImageBehavior = false;
			this.ListView1.View = global::System.Windows.Forms.View.Details;
			this.ColumnHeader1.Text = "[ Name ]";
			this.ColumnHeader1.Width = 105;
			this.ColumnHeader2.Text = "[ Type ]";
			this.ColumnHeader2.Width = 125;
			this.ColumnHeader3.Text = "[ Value ]";
			this.ColumnHeader3.Width = 131;
			this.Timer1.Enabled = true;
			this.Timer1.Interval = 1000;
			this.Splitter1.BackColor = global::System.Drawing.Color.White;
			this.Splitter1.Location = new global::System.Drawing.Point(200, 0);
			this.Splitter1.Name = "Splitter1";
			this.Splitter1.Size = new global::System.Drawing.Size(3, 328);
			this.Splitter1.TabIndex = 12;
			this.Splitter1.TabStop = false;
			this.Guna2ContextMenuStrip2.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.RefreshToolStripMenuItem2,
				this.AddToolStripMenuItem1,
				this.RemoveToolStripMenuItem1
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
			this.Guna2ContextMenuStrip2.Size = new global::System.Drawing.Size(142, 70);
			this.AddToolStripMenuItem1.BackColor = global::System.Drawing.Color.White;
			this.AddToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("AddToolStripMenuItem1.Image");
			this.AddToolStripMenuItem1.Name = "AddToolStripMenuItem1";
			this.AddToolStripMenuItem1.Size = new global::System.Drawing.Size(141, 22);
			this.AddToolStripMenuItem1.Text = "[ CreateKey ]";
			this.RemoveToolStripMenuItem1.BackColor = global::System.Drawing.Color.White;
			this.RemoveToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("RemoveToolStripMenuItem1.Image");
			this.RemoveToolStripMenuItem1.Name = "RemoveToolStripMenuItem1";
			this.RemoveToolStripMenuItem1.Size = new global::System.Drawing.Size(141, 22);
			this.RemoveToolStripMenuItem1.Text = "[ DeleteKey ]";
			this.RefreshToolStripMenuItem2.BackColor = global::System.Drawing.Color.White;
			this.RefreshToolStripMenuItem2.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("RefreshToolStripMenuItem2.Image");
			this.RefreshToolStripMenuItem2.Name = "RefreshToolStripMenuItem2";
			this.RefreshToolStripMenuItem2.Size = new global::System.Drawing.Size(141, 22);
			this.RefreshToolStripMenuItem2.Text = "[ Refresh ]";
			this.Guna2ContextMenuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.ToolStripMenuItem1,
				this.NewValueToolStripMenuItem1,
				this.EditToolStripMenuItem1,
				this.DeleteToolStripMenuItem1
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
			this.ToolStripMenuItem1.BackColor = global::System.Drawing.Color.White;
			this.ToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("ToolStripMenuItem1.Image");
			this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
			this.ToolStripMenuItem1.Size = new global::System.Drawing.Size(140, 22);
			this.ToolStripMenuItem1.Text = "[ Refresh ]";
			this.NewValueToolStripMenuItem1.BackColor = global::System.Drawing.Color.White;
			this.NewValueToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("NewValueToolStripMenuItem1.Image");
			this.NewValueToolStripMenuItem1.Name = "NewValueToolStripMenuItem1";
			this.NewValueToolStripMenuItem1.Size = new global::System.Drawing.Size(180, 22);
			this.NewValueToolStripMenuItem1.Text = "[ NewValue ]";
			this.EditToolStripMenuItem1.BackColor = global::System.Drawing.Color.White;
			this.EditToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("EditToolStripMenuItem1.Image");
			this.EditToolStripMenuItem1.Name = "EditToolStripMenuItem1";
			this.EditToolStripMenuItem1.Size = new global::System.Drawing.Size(180, 22);
			this.EditToolStripMenuItem1.Text = "[ Edit ]";
			this.DeleteToolStripMenuItem1.BackColor = global::System.Drawing.Color.White;
			this.DeleteToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("DeleteToolStripMenuItem1.Image");
			this.DeleteToolStripMenuItem1.Name = "DeleteToolStripMenuItem1";
			this.DeleteToolStripMenuItem1.Size = new global::System.Drawing.Size(180, 22);
			this.DeleteToolStripMenuItem1.Text = "[ Delete ]";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.White;
			base.ClientSize = new global::System.Drawing.Size(636, 350);
			base.Controls.Add(this.Splitter1);
			base.Controls.Add(this.ListView1);
			base.Controls.Add(this.RGk);
			base.Controls.Add(this.StatusStrip1);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Registry";
			this.Text = "Registry Editor";
			this.StatusStrip1.ResumeLayout(false);
			this.StatusStrip1.PerformLayout();
			this.Guna2ContextMenuStrip2.ResumeLayout(false);
			this.Guna2ContextMenuStrip1.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000321 RID: 801
		private global::System.ComponentModel.IContainer components;
	}
}
