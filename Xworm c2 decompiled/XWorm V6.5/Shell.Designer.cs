namespace XWorm
{
	// Token: 0x02000030 RID: 48
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Shell : global::System.Windows.Forms.Form
	{
		// Token: 0x060008B7 RID: 2231 RVA: 0x0004B704 File Offset: 0x00049904
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

		// Token: 0x060008B8 RID: 2232 RVA: 0x0004B754 File Offset: 0x00049954
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::XWorm.Shell));
			this.Timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.Guna2TextBox1 = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.Guna2TextBox2 = new global::Guna.UI2.WinForms.Guna2TextBox();
			base.SuspendLayout();
			this.Timer1.Enabled = true;
			this.Timer1.Interval = 1000;
			this.Guna2TextBox1.BorderColor = global::System.Drawing.Color.FromArgb(40, 192, 182);
			this.Guna2TextBox1.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.Guna2TextBox1.DefaultText = "";
			this.Guna2TextBox1.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.Guna2TextBox1.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.Guna2TextBox1.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.Guna2TextBox1.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.Guna2TextBox1.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.Guna2TextBox1.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.Guna2TextBox1.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.Guna2TextBox1.ForeColor = global::System.Drawing.Color.Black;
			this.Guna2TextBox1.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.Guna2TextBox1.Location = new global::System.Drawing.Point(0, 278);
			this.Guna2TextBox1.Name = "Guna2TextBox1";
			this.Guna2TextBox1.PasswordChar = '\0';
			this.Guna2TextBox1.PlaceholderForeColor = global::System.Drawing.Color.Black;
			this.Guna2TextBox1.PlaceholderText = "";
			this.Guna2TextBox1.SelectedText = "";
			this.Guna2TextBox1.Size = new global::System.Drawing.Size(459, 21);
			this.Guna2TextBox1.TabIndex = 50;
			this.Guna2TextBox2.BorderColor = global::System.Drawing.Color.FromArgb(40, 192, 182);
			this.Guna2TextBox2.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.Guna2TextBox2.DefaultText = "";
			this.Guna2TextBox2.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.Guna2TextBox2.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.Guna2TextBox2.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.Guna2TextBox2.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.Guna2TextBox2.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.Guna2TextBox2.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.Guna2TextBox2.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.Guna2TextBox2.ForeColor = global::System.Drawing.Color.Black;
			this.Guna2TextBox2.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.Guna2TextBox2.Location = new global::System.Drawing.Point(0, 0);
			this.Guna2TextBox2.Multiline = true;
			this.Guna2TextBox2.Name = "Guna2TextBox2";
			this.Guna2TextBox2.PasswordChar = '\0';
			this.Guna2TextBox2.PlaceholderForeColor = global::System.Drawing.Color.Black;
			this.Guna2TextBox2.PlaceholderText = "";
			this.Guna2TextBox2.ReadOnly = true;
			this.Guna2TextBox2.ScrollBars = global::System.Windows.Forms.ScrollBars.Both;
			this.Guna2TextBox2.SelectedText = "";
			this.Guna2TextBox2.Size = new global::System.Drawing.Size(459, 278);
			this.Guna2TextBox2.TabIndex = 51;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.White;
			base.ClientSize = new global::System.Drawing.Size(459, 299);
			base.Controls.Add(this.Guna2TextBox2);
			base.Controls.Add(this.Guna2TextBox1);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Shell";
			this.Text = "Shell";
			base.ResumeLayout(false);
		}

		// Token: 0x0400039B RID: 923
		private global::System.ComponentModel.IContainer components;
	}
}
