namespace XWorm
{
	// Token: 0x02000029 RID: 41
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class RemoteDesktop : global::System.Windows.Forms.Form
	{
		// Token: 0x060007D1 RID: 2001 RVA: 0x00044CD8 File Offset: 0x00042ED8
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

		// Token: 0x060007D2 RID: 2002 RVA: 0x00044D28 File Offset: 0x00042F28
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::XWorm.RemoteDesktop));
			this.Timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.StatusStrip1 = new global::System.Windows.Forms.StatusStrip();
			this.ToolStripStatusLabel2 = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.ToolStripStatusLabel6 = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.ToolStripStatusLabel3 = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.ToolStripStatusLabel4 = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.ToolStripStatusLabel5 = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.ToolStripStatusLabel1 = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.Timer2 = new global::System.Windows.Forms.Timer(this.components);
			this.Panel2 = new global::System.Windows.Forms.Panel();
			this.Guna2Panel1 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.Guna2GradientButton1 = new global::Guna.UI2.WinForms.Guna2GradientButton();
			this.Guna2ComboBox1 = new global::Guna.UI2.WinForms.Guna2ComboBox();
			this.Guna2Panel3 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.Guna2ComboBox2 = new global::Guna.UI2.WinForms.Guna2ComboBox();
			this.Guna2Panel2 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.PictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.StatusStrip1.SuspendLayout();
			this.Panel2.SuspendLayout();
			this.Guna2Panel1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
			base.SuspendLayout();
			this.Timer1.Enabled = true;
			this.Timer1.Interval = 1000;
			this.StatusStrip1.BackColor = global::System.Drawing.Color.White;
			this.StatusStrip1.ImageScalingSize = new global::System.Drawing.Size(24, 24);
			this.StatusStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.ToolStripStatusLabel2,
				this.ToolStripStatusLabel6,
				this.ToolStripStatusLabel3,
				this.ToolStripStatusLabel4,
				this.ToolStripStatusLabel5,
				this.ToolStripStatusLabel1
			});
			this.StatusStrip1.Location = new global::System.Drawing.Point(0, 342);
			this.StatusStrip1.Name = "StatusStrip1";
			this.StatusStrip1.Padding = new global::System.Windows.Forms.Padding(1, 0, 9, 0);
			this.StatusStrip1.Size = new global::System.Drawing.Size(586, 22);
			this.StatusStrip1.TabIndex = 7;
			this.StatusStrip1.Text = "StatusStrip1";
			this.ToolStripStatusLabel2.ActiveLinkColor = global::System.Drawing.Color.Red;
			this.ToolStripStatusLabel2.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ToolStripStatusLabel2.ForeColor = global::System.Drawing.Color.Black;
			this.ToolStripStatusLabel2.LinkColor = global::System.Drawing.Color.FromArgb(0, 0, 255);
			this.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2";
			this.ToolStripStatusLabel2.Size = new global::System.Drawing.Size(64, 17);
			this.ToolStripStatusLabel2.Text = "[ Mouse ]";
			this.ToolStripStatusLabel2.VisitedLinkColor = global::System.Drawing.Color.FromArgb(128, 0, 128);
			this.ToolStripStatusLabel6.ActiveLinkColor = global::System.Drawing.Color.Red;
			this.ToolStripStatusLabel6.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ToolStripStatusLabel6.ForeColor = global::System.Drawing.Color.Black;
			this.ToolStripStatusLabel6.LinkColor = global::System.Drawing.Color.FromArgb(0, 0, 255);
			this.ToolStripStatusLabel6.Name = "ToolStripStatusLabel6";
			this.ToolStripStatusLabel6.Size = new global::System.Drawing.Size(97, 17);
			this.ToolStripStatusLabel6.Text = "[ MouseMove ]";
			this.ToolStripStatusLabel6.VisitedLinkColor = global::System.Drawing.Color.FromArgb(128, 0, 128);
			this.ToolStripStatusLabel3.ActiveLinkColor = global::System.Drawing.Color.Red;
			this.ToolStripStatusLabel3.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ToolStripStatusLabel3.ForeColor = global::System.Drawing.Color.Black;
			this.ToolStripStatusLabel3.LinkColor = global::System.Drawing.Color.FromArgb(0, 0, 255);
			this.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3";
			this.ToolStripStatusLabel3.Size = new global::System.Drawing.Size(81, 17);
			this.ToolStripStatusLabel3.Text = "[ Keyboard ]";
			this.ToolStripStatusLabel3.VisitedLinkColor = global::System.Drawing.Color.FromArgb(128, 0, 128);
			this.ToolStripStatusLabel4.ActiveLinkColor = global::System.Drawing.Color.Red;
			this.ToolStripStatusLabel4.ForeColor = global::System.Drawing.Color.Black;
			this.ToolStripStatusLabel4.LinkColor = global::System.Drawing.Color.White;
			this.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4";
			this.ToolStripStatusLabel4.Size = new global::System.Drawing.Size(71, 17);
			this.ToolStripStatusLabel4.Text = "[ AutoSave ]";
			this.ToolStripStatusLabel4.VisitedLinkColor = global::System.Drawing.Color.White;
			this.ToolStripStatusLabel5.ActiveLinkColor = global::System.Drawing.Color.Red;
			this.ToolStripStatusLabel5.ForeColor = global::System.Drawing.Color.Black;
			this.ToolStripStatusLabel5.LinkColor = global::System.Drawing.Color.White;
			this.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5";
			this.ToolStripStatusLabel5.Size = new global::System.Drawing.Size(65, 17);
			this.ToolStripStatusLabel5.Text = "[ Window ]";
			this.ToolStripStatusLabel5.VisitedLinkColor = global::System.Drawing.Color.White;
			this.ToolStripStatusLabel1.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ToolStripStatusLabel1.ForeColor = global::System.Drawing.Color.Black;
			this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
			this.ToolStripStatusLabel1.Size = new global::System.Drawing.Size(14, 17);
			this.ToolStripStatusLabel1.Text = "..";
			this.Timer2.Interval = 300;
			this.Panel2.Controls.Add(this.Guna2Panel1);
			this.Panel2.Controls.Add(this.Guna2Panel3);
			this.Panel2.Controls.Add(this.Guna2ComboBox2);
			this.Panel2.Controls.Add(this.Guna2Panel2);
			this.Panel2.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Panel2.Location = new global::System.Drawing.Point(0, 0);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new global::System.Drawing.Size(586, 38);
			this.Panel2.TabIndex = 29;
			this.Guna2Panel1.Controls.Add(this.Guna2GradientButton1);
			this.Guna2Panel1.Controls.Add(this.Guna2ComboBox1);
			this.Guna2Panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Guna2Panel1.Location = new global::System.Drawing.Point(48, 0);
			this.Guna2Panel1.Name = "Guna2Panel1";
			this.Guna2Panel1.Size = new global::System.Drawing.Size(355, 21);
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
			this.Guna2GradientButton1.Image = global::XWorm.My.Resources.Resources._Stop;
			this.Guna2GradientButton1.ImageAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.Guna2GradientButton1.ImageSize = new global::System.Drawing.Size(15, 15);
			this.Guna2GradientButton1.Location = new global::System.Drawing.Point(0, 0);
			this.Guna2GradientButton1.Name = "Guna2GradientButton1";
			this.Guna2GradientButton1.Size = new global::System.Drawing.Size(265, 21);
			this.Guna2GradientButton1.TabIndex = 34;
			this.Guna2GradientButton1.Text = "OFF";
			this.Guna2ComboBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.Guna2ComboBox1.BorderColor = global::System.Drawing.Color.FromArgb(40, 192, 182);
			this.Guna2ComboBox1.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.Guna2ComboBox1.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.Guna2ComboBox1.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Guna2ComboBox1.FocusedColor = global::System.Drawing.Color.FromArgb(40, 192, 182);
			this.Guna2ComboBox1.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(40, 192, 182);
			this.Guna2ComboBox1.Font = new global::System.Drawing.Font("Segoe UI", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Guna2ComboBox1.ForeColor = global::System.Drawing.Color.Black;
			this.Guna2ComboBox1.ItemHeight = 15;
			this.Guna2ComboBox1.Items.AddRange(new object[]
			{
				"10%",
				"20%",
				"30%",
				"40%",
				"50%",
				"60%",
				"70%",
				"80%",
				"90%",
				"100%"
			});
			this.Guna2ComboBox1.Location = new global::System.Drawing.Point(265, 0);
			this.Guna2ComboBox1.Name = "Guna2ComboBox1";
			this.Guna2ComboBox1.Size = new global::System.Drawing.Size(90, 21);
			this.Guna2ComboBox1.TabIndex = 28;
			this.Guna2Panel3.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.Guna2Panel3.Location = new global::System.Drawing.Point(0, 0);
			this.Guna2Panel3.Name = "Guna2Panel3";
			this.Guna2Panel3.Size = new global::System.Drawing.Size(48, 38);
			this.Guna2Panel3.TabIndex = 37;
			this.Guna2ComboBox2.BackColor = global::System.Drawing.Color.Transparent;
			this.Guna2ComboBox2.BorderColor = global::System.Drawing.Color.FromArgb(40, 192, 182);
			this.Guna2ComboBox2.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.Guna2ComboBox2.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.Guna2ComboBox2.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Guna2ComboBox2.FocusedColor = global::System.Drawing.Color.FromArgb(40, 192, 182);
			this.Guna2ComboBox2.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(40, 192, 182);
			this.Guna2ComboBox2.Font = new global::System.Drawing.Font("Segoe UI", 8.25f);
			this.Guna2ComboBox2.ForeColor = global::System.Drawing.Color.Black;
			this.Guna2ComboBox2.ItemHeight = 15;
			this.Guna2ComboBox2.Location = new global::System.Drawing.Point(403, 0);
			this.Guna2ComboBox2.Name = "Guna2ComboBox2";
			this.Guna2ComboBox2.Size = new global::System.Drawing.Size(135, 21);
			this.Guna2ComboBox2.TabIndex = 38;
			this.Guna2Panel2.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.Guna2Panel2.Location = new global::System.Drawing.Point(538, 0);
			this.Guna2Panel2.Name = "Guna2Panel2";
			this.Guna2Panel2.Size = new global::System.Drawing.Size(48, 38);
			this.Guna2Panel2.TabIndex = 36;
			this.PictureBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.PictureBox1.ErrorImage = null;
			this.PictureBox1.InitialImage = null;
			this.PictureBox1.Location = new global::System.Drawing.Point(0, 38);
			this.PictureBox1.Margin = new global::System.Windows.Forms.Padding(2);
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.Size = new global::System.Drawing.Size(586, 304);
			this.PictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.PictureBox1.TabIndex = 2;
			this.PictureBox1.TabStop = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.White;
			base.ClientSize = new global::System.Drawing.Size(586, 364);
			base.Controls.Add(this.PictureBox1);
			base.Controls.Add(this.Panel2);
			base.Controls.Add(this.StatusStrip1);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "RemoteDesktop";
			this.Text = "Monitor";
			this.StatusStrip1.ResumeLayout(false);
			this.StatusStrip1.PerformLayout();
			this.Panel2.ResumeLayout(false);
			this.Guna2Panel1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000337 RID: 823
		private global::System.ComponentModel.IContainer components;
	}
}
