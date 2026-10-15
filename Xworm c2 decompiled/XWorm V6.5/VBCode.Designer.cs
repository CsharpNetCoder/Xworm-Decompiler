namespace XWorm
{
	// Token: 0x02000033 RID: 51
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class VBCode : global::System.Windows.Forms.Form
	{
		// Token: 0x06000955 RID: 2389 RVA: 0x00051964 File Offset: 0x0004FB64
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

		// Token: 0x06000956 RID: 2390 RVA: 0x000519B4 File Offset: 0x0004FBB4
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::XWorm.VBCode));
			this.editor = new global::FastColoredTextBoxNS.FastColoredTextBox();
			this.Guna2ContextMenuStrip1 = new global::Guna.UI2.WinForms.Guna2ContextMenuStrip();
			this.CutToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.CopyToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.PasteToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem7 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.ErrorTestToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.StatusStrip1 = new global::System.Windows.Forms.StatusStrip();
			this.ToolStripStatusLabel1 = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.ListBox1 = new global::System.Windows.Forms.ListBox();
			this.Guna2ContextMenuStrip2 = new global::Guna.UI2.WinForms.Guna2ContextMenuStrip();
			this.AddToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.RemoveToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.Panel1 = new global::System.Windows.Forms.Panel();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.Panel5 = new global::System.Windows.Forms.Panel();
			this.Guna2Panel1 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.Guna2GradientButton1 = new global::Guna.UI2.WinForms.Guna2GradientButton();
			this.Guna2Panel3 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.Guna2Panel2 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.editor.BeginInit();
			this.Guna2ContextMenuStrip1.SuspendLayout();
			this.StatusStrip1.SuspendLayout();
			this.Guna2ContextMenuStrip2.SuspendLayout();
			this.Panel1.SuspendLayout();
			this.Panel5.SuspendLayout();
			this.Guna2Panel1.SuspendLayout();
			base.SuspendLayout();
			this.editor.AutoCompleteBracketsList = new char[]
			{
				'(',
				')',
				'{',
				'}',
				'[',
				']',
				'"',
				'"',
				'\'',
				'\''
			};
			this.editor.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.\\(\\)]+\\s*(?<range>=)\\s*(?<range>.+)\r\n";
			this.editor.AutoScrollMinSize = new global::System.Drawing.Size(27, 14);
			this.editor.BackBrush = null;
			this.editor.BracketsHighlightStrategy = 1;
			this.editor.CharHeight = 14;
			this.editor.CharWidth = 8;
			this.editor.CommentPrefix = "'";
			this.editor.ContextMenuStrip = this.Guna2ContextMenuStrip1;
			this.editor.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.editor.DisabledColor = global::System.Drawing.Color.FromArgb(100, 180, 180, 180);
			this.editor.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.editor.ForeColor = global::System.Drawing.Color.Black;
			this.editor.IsReplaceMode = false;
			this.editor.Language = 2;
			this.editor.LeftBracket = '(';
			this.editor.Location = new global::System.Drawing.Point(0, 32);
			this.editor.Name = "editor";
			this.editor.Paddings = new global::System.Windows.Forms.Padding(0);
			this.editor.RightBracket = ')';
			this.editor.SelectionColor = global::System.Drawing.Color.FromArgb(60, 0, 0, 255);
			this.editor.ServiceColors = (global::FastColoredTextBoxNS.ServiceColors)componentResourceManager.GetObject("editor.ServiceColors");
			this.editor.Size = new global::System.Drawing.Size(464, 321);
			this.editor.TabIndex = 5;
			this.editor.Zoom = 100;
			this.Guna2ContextMenuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.CutToolStripMenuItem1,
				this.CopyToolStripMenuItem1,
				this.PasteToolStripMenuItem1,
				this.ToolStripMenuItem7,
				this.ErrorTestToolStripMenuItem
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
			this.Guna2ContextMenuStrip1.Size = new global::System.Drawing.Size(119, 114);
			this.CutToolStripMenuItem1.BackColor = global::System.Drawing.Color.White;
			this.CutToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("CutToolStripMenuItem1.Image");
			this.CutToolStripMenuItem1.Name = "CutToolStripMenuItem1";
			this.CutToolStripMenuItem1.Size = new global::System.Drawing.Size(118, 22);
			this.CutToolStripMenuItem1.Text = "[ Cut ]";
			this.CopyToolStripMenuItem1.BackColor = global::System.Drawing.Color.White;
			this.CopyToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("CopyToolStripMenuItem1.Image");
			this.CopyToolStripMenuItem1.Name = "CopyToolStripMenuItem1";
			this.CopyToolStripMenuItem1.Size = new global::System.Drawing.Size(118, 22);
			this.CopyToolStripMenuItem1.Text = "[ Copy ]";
			this.PasteToolStripMenuItem1.BackColor = global::System.Drawing.Color.White;
			this.PasteToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("PasteToolStripMenuItem1.Image");
			this.PasteToolStripMenuItem1.Name = "PasteToolStripMenuItem1";
			this.PasteToolStripMenuItem1.Size = new global::System.Drawing.Size(118, 22);
			this.PasteToolStripMenuItem1.Text = "[ Paste ]";
			this.ToolStripMenuItem7.BackColor = global::System.Drawing.Color.White;
			this.ToolStripMenuItem7.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("ToolStripMenuItem7.Image");
			this.ToolStripMenuItem7.Name = "ToolStripMenuItem7";
			this.ToolStripMenuItem7.Size = new global::System.Drawing.Size(118, 22);
			this.ToolStripMenuItem7.Text = "[ Clear ]";
			this.ErrorTestToolStripMenuItem.BackColor = global::System.Drawing.Color.White;
			this.ErrorTestToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("ErrorTestToolStripMenuItem.Image");
			this.ErrorTestToolStripMenuItem.Name = "ErrorTestToolStripMenuItem";
			this.ErrorTestToolStripMenuItem.Size = new global::System.Drawing.Size(118, 22);
			this.ErrorTestToolStripMenuItem.Text = "[ Tester ]";
			this.StatusStrip1.BackColor = global::System.Drawing.Color.White;
			this.StatusStrip1.ImageScalingSize = new global::System.Drawing.Size(24, 24);
			this.StatusStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.ToolStripStatusLabel1
			});
			this.StatusStrip1.Location = new global::System.Drawing.Point(0, 353);
			this.StatusStrip1.Name = "StatusStrip1";
			this.StatusStrip1.Padding = new global::System.Windows.Forms.Padding(1, 0, 9, 0);
			this.StatusStrip1.Size = new global::System.Drawing.Size(610, 22);
			this.StatusStrip1.TabIndex = 6;
			this.StatusStrip1.Text = "StatusStrip1";
			this.ToolStripStatusLabel1.ForeColor = global::System.Drawing.Color.Black;
			this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
			this.ToolStripStatusLabel1.Size = new global::System.Drawing.Size(13, 17);
			this.ToolStripStatusLabel1.Text = "..";
			this.ToolStripStatusLabel1.Visible = false;
			this.ListBox1.BackColor = global::System.Drawing.Color.White;
			this.ListBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.ListBox1.ContextMenuStrip = this.Guna2ContextMenuStrip2;
			this.ListBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.ListBox1.ForeColor = global::System.Drawing.Color.Black;
			this.ListBox1.FormattingEnabled = true;
			this.ListBox1.HorizontalScrollbar = true;
			this.ListBox1.Items.AddRange(new object[]
			{
				"System.dll",
				"Microsoft.VisualBasic.dll",
				"System.Data.dll",
				"System.Windows.Forms.dll",
				"System.Management.dll",
				"System.Drawing.dll"
			});
			this.ListBox1.Location = new global::System.Drawing.Point(0, 13);
			this.ListBox1.Name = "ListBox1";
			this.ListBox1.Size = new global::System.Drawing.Size(146, 308);
			this.ListBox1.TabIndex = 7;
			this.Guna2ContextMenuStrip2.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
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
			this.Guna2ContextMenuStrip2.Size = new global::System.Drawing.Size(132, 48);
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
			this.Panel1.BackColor = global::System.Drawing.Color.White;
			this.Panel1.Controls.Add(this.ListBox1);
			this.Panel1.Controls.Add(this.Label1);
			this.Panel1.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.Panel1.Location = new global::System.Drawing.Point(464, 32);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new global::System.Drawing.Size(146, 321);
			this.Panel1.TabIndex = 8;
			this.Label1.AutoSize = true;
			this.Label1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Label1.ForeColor = global::System.Drawing.Color.Black;
			this.Label1.Location = new global::System.Drawing.Point(0, 0);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(69, 13);
			this.Label1.TabIndex = 8;
			this.Label1.Text = "References :";
			this.Timer1.Enabled = true;
			this.Timer1.Interval = 1000;
			this.Panel5.Controls.Add(this.Guna2Panel1);
			this.Panel5.Controls.Add(this.Guna2Panel3);
			this.Panel5.Controls.Add(this.Guna2Panel2);
			this.Panel5.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Panel5.Location = new global::System.Drawing.Point(0, 0);
			this.Panel5.Name = "Panel5";
			this.Panel5.Size = new global::System.Drawing.Size(610, 32);
			this.Panel5.TabIndex = 31;
			this.Guna2Panel1.Controls.Add(this.Guna2GradientButton1);
			this.Guna2Panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Guna2Panel1.Location = new global::System.Drawing.Point(68, 0);
			this.Guna2Panel1.Name = "Guna2Panel1";
			this.Guna2Panel1.Size = new global::System.Drawing.Size(474, 21);
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
			this.Guna2GradientButton1.Size = new global::System.Drawing.Size(474, 21);
			this.Guna2GradientButton1.TabIndex = 34;
			this.Guna2GradientButton1.Text = "Compile";
			this.Guna2Panel3.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.Guna2Panel3.Location = new global::System.Drawing.Point(0, 0);
			this.Guna2Panel3.Name = "Guna2Panel3";
			this.Guna2Panel3.Size = new global::System.Drawing.Size(68, 32);
			this.Guna2Panel3.TabIndex = 37;
			this.Guna2Panel2.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.Guna2Panel2.Location = new global::System.Drawing.Point(542, 0);
			this.Guna2Panel2.Name = "Guna2Panel2";
			this.Guna2Panel2.Size = new global::System.Drawing.Size(68, 32);
			this.Guna2Panel2.TabIndex = 36;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.White;
			base.ClientSize = new global::System.Drawing.Size(610, 375);
			base.Controls.Add(this.editor);
			base.Controls.Add(this.Panel1);
			base.Controls.Add(this.StatusStrip1);
			base.Controls.Add(this.Panel5);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "VBCode";
			this.Text = "VB.Net Compiler";
			this.editor.EndInit();
			this.Guna2ContextMenuStrip1.ResumeLayout(false);
			this.StatusStrip1.ResumeLayout(false);
			this.StatusStrip1.PerformLayout();
			this.Guna2ContextMenuStrip2.ResumeLayout(false);
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.Panel5.ResumeLayout(false);
			this.Guna2Panel1.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040003E5 RID: 997
		private global::System.ComponentModel.IContainer components;
	}
}
