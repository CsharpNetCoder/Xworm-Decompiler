namespace XWorm
{
	// Token: 0x0200002C RID: 44
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Sound : global::System.Windows.Forms.Form
	{
		// Token: 0x0600084D RID: 2125 RVA: 0x000489BC File Offset: 0x00046BBC
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

		// Token: 0x0600084E RID: 2126 RVA: 0x00048A0C File Offset: 0x00046C0C
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::XWorm.Sound));
			this.StatusStrip1 = new global::System.Windows.Forms.StatusStrip();
			this.ToolStripStatusLabel1 = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.PictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.Timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.Guna2GradientButton1 = new global::Guna.UI2.WinForms.Guna2GradientButton();
			this.PictureBox2 = new global::System.Windows.Forms.PictureBox();
			this.StatusStrip1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox2).BeginInit();
			base.SuspendLayout();
			this.StatusStrip1.BackColor = global::System.Drawing.Color.White;
			this.StatusStrip1.ImageScalingSize = new global::System.Drawing.Size(24, 24);
			this.StatusStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.ToolStripStatusLabel1
			});
			this.StatusStrip1.Location = new global::System.Drawing.Point(0, 230);
			this.StatusStrip1.Name = "StatusStrip1";
			this.StatusStrip1.Padding = new global::System.Windows.Forms.Padding(1, 0, 9, 0);
			this.StatusStrip1.Size = new global::System.Drawing.Size(321, 22);
			this.StatusStrip1.TabIndex = 17;
			this.StatusStrip1.Text = "StatusStrip1";
			this.ToolStripStatusLabel1.ForeColor = global::System.Drawing.Color.Black;
			this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
			this.ToolStripStatusLabel1.Size = new global::System.Drawing.Size(13, 17);
			this.ToolStripStatusLabel1.Text = "..";
			this.PictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("PictureBox1.Image");
			this.PictureBox1.Location = new global::System.Drawing.Point(33, 12);
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.Size = new global::System.Drawing.Size(258, 168);
			this.PictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.PictureBox1.TabIndex = 19;
			this.PictureBox1.TabStop = false;
			this.Timer1.Enabled = true;
			this.Timer1.Interval = 1000;
			this.Guna2GradientButton1.BorderRadius = 4;
			this.Guna2GradientButton1.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.Guna2GradientButton1.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.Guna2GradientButton1.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.Guna2GradientButton1.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.Guna2GradientButton1.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.Guna2GradientButton1.FillColor2 = global::System.Drawing.Color.FromArgb(40, 192, 182);
			this.Guna2GradientButton1.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.Guna2GradientButton1.ForeColor = global::System.Drawing.Color.White;
			this.Guna2GradientButton1.Image = global::XWorm.My.Resources.Resources.Play;
			this.Guna2GradientButton1.ImageAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.Guna2GradientButton1.ImageSize = new global::System.Drawing.Size(17, 17);
			this.Guna2GradientButton1.Location = new global::System.Drawing.Point(12, 192);
			this.Guna2GradientButton1.Name = "Guna2GradientButton1";
			this.Guna2GradientButton1.Size = new global::System.Drawing.Size(297, 28);
			this.Guna2GradientButton1.TabIndex = 96;
			this.Guna2GradientButton1.Text = "Start";
			this.PictureBox2.Enabled = false;
			this.PictureBox2.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("PictureBox2.Image");
			this.PictureBox2.Location = new global::System.Drawing.Point(138, 119);
			this.PictureBox2.Name = "PictureBox2";
			this.PictureBox2.Size = new global::System.Drawing.Size(48, 48);
			this.PictureBox2.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.PictureBox2.TabIndex = 97;
			this.PictureBox2.TabStop = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.White;
			base.ClientSize = new global::System.Drawing.Size(321, 252);
			base.Controls.Add(this.PictureBox2);
			base.Controls.Add(this.Guna2GradientButton1);
			base.Controls.Add(this.PictureBox1);
			base.Controls.Add(this.StatusStrip1);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Sound";
			this.Text = "System Sound";
			this.StatusStrip1.ResumeLayout(false);
			this.StatusStrip1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox2).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400036E RID: 878
		private global::System.ComponentModel.IContainer components;
	}
}
