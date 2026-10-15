namespace XWorm
{
	// Token: 0x02000032 RID: 50
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class TXT : global::System.Windows.Forms.Form
	{
		// Token: 0x06000945 RID: 2373 RVA: 0x00051058 File Offset: 0x0004F258
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

		// Token: 0x06000946 RID: 2374 RVA: 0x000510A8 File Offset: 0x0004F2A8
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::XWorm.TXT));
			this.MenuStrip1 = new global::System.Windows.Forms.MenuStrip();
			this.ToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.Timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.Guna2TextBox1 = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.Guna2TextBox2 = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.MenuStrip1.SuspendLayout();
			base.SuspendLayout();
			this.MenuStrip1.BackColor = global::System.Drawing.Color.White;
			this.MenuStrip1.Font = new global::System.Drawing.Font("Arial", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.MenuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.ToolStripMenuItem1
			});
			this.MenuStrip1.LayoutStyle = global::System.Windows.Forms.ToolStripLayoutStyle.Flow;
			this.MenuStrip1.Location = new global::System.Drawing.Point(0, 0);
			this.MenuStrip1.Name = "MenuStrip1";
			this.MenuStrip1.Size = new global::System.Drawing.Size(457, 24);
			this.MenuStrip1.TabIndex = 3;
			this.MenuStrip1.Text = "MenuStrip1";
			this.ToolStripMenuItem1.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.ToolStripMenuItem1.ForeColor = global::System.Drawing.Color.Black;
			this.ToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("ToolStripMenuItem1.Image");
			this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
			this.ToolStripMenuItem1.Size = new global::System.Drawing.Size(108, 20);
			this.ToolStripMenuItem1.Text = "Save Changes";
			this.Timer1.Enabled = true;
			this.Timer1.Interval = 1000;
			this.Guna2TextBox1.BorderColor = global::System.Drawing.Color.FromArgb(40, 192, 182);
			this.Guna2TextBox1.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.Guna2TextBox1.DefaultText = "";
			this.Guna2TextBox1.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.Guna2TextBox1.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.Guna2TextBox1.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.Guna2TextBox1.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.Guna2TextBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.Guna2TextBox1.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.Guna2TextBox1.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.Guna2TextBox1.ForeColor = global::System.Drawing.Color.Black;
			this.Guna2TextBox1.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.Guna2TextBox1.Location = new global::System.Drawing.Point(0, 24);
			this.Guna2TextBox1.Multiline = true;
			this.Guna2TextBox1.Name = "Guna2TextBox1";
			this.Guna2TextBox1.PasswordChar = '\0';
			this.Guna2TextBox1.PlaceholderForeColor = global::System.Drawing.Color.Black;
			this.Guna2TextBox1.PlaceholderText = "";
			this.Guna2TextBox1.ScrollBars = global::System.Windows.Forms.ScrollBars.Both;
			this.Guna2TextBox1.SelectedText = "";
			this.Guna2TextBox1.Size = new global::System.Drawing.Size(457, 200);
			this.Guna2TextBox1.TabIndex = 51;
			this.Guna2TextBox2.BorderColor = global::System.Drawing.Color.FromArgb(40, 192, 182);
			this.Guna2TextBox2.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.Guna2TextBox2.DefaultText = "";
			this.Guna2TextBox2.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.Guna2TextBox2.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.Guna2TextBox2.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.Guna2TextBox2.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.Guna2TextBox2.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.Guna2TextBox2.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.Guna2TextBox2.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.Guna2TextBox2.ForeColor = global::System.Drawing.Color.Black;
			this.Guna2TextBox2.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.Guna2TextBox2.Location = new global::System.Drawing.Point(0, 224);
			this.Guna2TextBox2.Name = "Guna2TextBox2";
			this.Guna2TextBox2.PasswordChar = '\0';
			this.Guna2TextBox2.PlaceholderForeColor = global::System.Drawing.Color.Black;
			this.Guna2TextBox2.PlaceholderText = "";
			this.Guna2TextBox2.ReadOnly = true;
			this.Guna2TextBox2.SelectedText = "";
			this.Guna2TextBox2.Size = new global::System.Drawing.Size(457, 21);
			this.Guna2TextBox2.TabIndex = 52;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.White;
			base.ClientSize = new global::System.Drawing.Size(457, 245);
			base.Controls.Add(this.Guna2TextBox1);
			base.Controls.Add(this.MenuStrip1);
			base.Controls.Add(this.Guna2TextBox2);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "TXT";
			this.Text = "Text Viewer";
			this.MenuStrip1.ResumeLayout(false);
			this.MenuStrip1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040003DE RID: 990
		private global::System.ComponentModel.IContainer components;
	}
}
