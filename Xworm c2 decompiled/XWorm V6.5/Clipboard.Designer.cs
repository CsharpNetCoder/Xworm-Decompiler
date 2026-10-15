namespace XWorm
{
	// Token: 0x02000013 RID: 19
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Clipboard : global::System.Windows.Forms.Form
	{
		// Token: 0x06000231 RID: 561 RVA: 0x0001586C File Offset: 0x00013A6C
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

		// Token: 0x06000232 RID: 562 RVA: 0x000158BC File Offset: 0x00013ABC
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::XWorm.Clipboard));
			this.RichTextBox1 = new global::System.Windows.Forms.RichTextBox();
			this.Guna2ContextMenuStrip2 = new global::Guna.UI2.WinForms.Guna2ContextMenuStrip();
			this.GetTextToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.SetTextToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.CopyToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem7 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.Timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.Guna2ContextMenuStrip2.SuspendLayout();
			base.SuspendLayout();
			this.RichTextBox1.BackColor = global::System.Drawing.Color.White;
			this.RichTextBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.RichTextBox1.ContextMenuStrip = this.Guna2ContextMenuStrip2;
			this.RichTextBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.RichTextBox1.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.RichTextBox1.ForeColor = global::System.Drawing.Color.Black;
			this.RichTextBox1.Location = new global::System.Drawing.Point(0, 0);
			this.RichTextBox1.Name = "RichTextBox1";
			this.RichTextBox1.Size = new global::System.Drawing.Size(412, 256);
			this.RichTextBox1.TabIndex = 1;
			this.RichTextBox1.Text = "";
			this.Guna2ContextMenuStrip2.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.GetTextToolStripMenuItem,
				this.SetTextToolStripMenuItem,
				this.CopyToolStripMenuItem1,
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
			this.Guna2ContextMenuStrip2.Size = new global::System.Drawing.Size(181, 114);
			this.GetTextToolStripMenuItem.BackColor = global::System.Drawing.Color.White;
			this.GetTextToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("GetTextToolStripMenuItem.Image");
			this.GetTextToolStripMenuItem.Name = "GetTextToolStripMenuItem";
			this.GetTextToolStripMenuItem.Size = new global::System.Drawing.Size(180, 22);
			this.GetTextToolStripMenuItem.Text = "[ Get Text ]";
			this.SetTextToolStripMenuItem.BackColor = global::System.Drawing.Color.White;
			this.SetTextToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("SetTextToolStripMenuItem.Image");
			this.SetTextToolStripMenuItem.Name = "SetTextToolStripMenuItem";
			this.SetTextToolStripMenuItem.Size = new global::System.Drawing.Size(180, 22);
			this.SetTextToolStripMenuItem.Text = "[ Set Text ]";
			this.CopyToolStripMenuItem1.BackColor = global::System.Drawing.Color.White;
			this.CopyToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("CopyToolStripMenuItem1.Image");
			this.CopyToolStripMenuItem1.Name = "CopyToolStripMenuItem1";
			this.CopyToolStripMenuItem1.Size = new global::System.Drawing.Size(180, 22);
			this.CopyToolStripMenuItem1.Text = "[ Copy ]";
			this.ToolStripMenuItem7.BackColor = global::System.Drawing.Color.White;
			this.ToolStripMenuItem7.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("ToolStripMenuItem7.Image");
			this.ToolStripMenuItem7.Name = "ToolStripMenuItem7";
			this.ToolStripMenuItem7.Size = new global::System.Drawing.Size(180, 22);
			this.ToolStripMenuItem7.Text = "[ Clear ]";
			this.Timer1.Enabled = true;
			this.Timer1.Interval = 1000;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.White;
			base.ClientSize = new global::System.Drawing.Size(412, 256);
			base.Controls.Add(this.RichTextBox1);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Clipboard";
			this.Text = "Clipboard";
			this.Guna2ContextMenuStrip2.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x040000E8 RID: 232
		private global::System.ComponentModel.IContainer components;
	}
}
