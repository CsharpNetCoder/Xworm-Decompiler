namespace XWorm
{
	// Token: 0x02000026 RID: 38
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Proxy : global::System.Windows.Forms.Form
	{
		// Token: 0x06000757 RID: 1879 RVA: 0x00040974 File Offset: 0x0003EB74
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

		// Token: 0x06000758 RID: 1880 RVA: 0x000409C4 File Offset: 0x0003EBC4
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::XWorm.Proxy));
			this.Label6 = new global::System.Windows.Forms.Label();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.PictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.Panel1 = new global::System.Windows.Forms.Panel();
			this.Panel2 = new global::System.Windows.Forms.Panel();
			this.Guna2TextBox4 = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.Guna2GradientButton1 = new global::Guna.UI2.WinForms.Guna2GradientButton();
			this.Guna2TextBox1 = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.Guna2TextBox2 = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.Guna2TextBox3 = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.Guna2GradientButton2 = new global::Guna.UI2.WinForms.Guna2GradientButton();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
			this.Panel1.SuspendLayout();
			this.Panel2.SuspendLayout();
			base.SuspendLayout();
			this.Label6.AutoSize = true;
			this.Label6.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label6.ForeColor = global::System.Drawing.Color.Black;
			this.Label6.Location = new global::System.Drawing.Point(19, 76);
			this.Label6.Name = "Label6";
			this.Label6.Size = new global::System.Drawing.Size(61, 13);
			this.Label6.TabIndex = 10;
			this.Label6.Text = "ClientPort :";
			this.Label3.AutoSize = true;
			this.Label3.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label3.ForeColor = global::System.Drawing.Color.Black;
			this.Label3.Location = new global::System.Drawing.Point(38, 103);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(42, 13);
			this.Label3.TabIndex = 8;
			this.Label3.Text = "Proxy :";
			this.Label2.AutoSize = true;
			this.Label2.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label2.ForeColor = global::System.Drawing.Color.Black;
			this.Label2.Location = new global::System.Drawing.Point(17, 49);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(63, 13);
			this.Label2.TabIndex = 7;
			this.Label2.Text = "ClientHost :";
			this.Timer1.Enabled = true;
			this.Timer1.Interval = 1000;
			this.PictureBox1.Location = new global::System.Drawing.Point(3, 3);
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.Size = new global::System.Drawing.Size(35, 25);
			this.PictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.PictureBox1.TabIndex = 16;
			this.PictureBox1.TabStop = false;
			this.Label1.AutoSize = true;
			this.Label1.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label1.ForeColor = global::System.Drawing.Color.Black;
			this.Label1.Location = new global::System.Drawing.Point(44, 10);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(15, 13);
			this.Label1.TabIndex = 17;
			this.Label1.Text = "..";
			this.Label4.AutoSize = true;
			this.Label4.ForeColor = global::System.Drawing.Color.Black;
			this.Label4.Location = new global::System.Drawing.Point(40, 66);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(34, 13);
			this.Label4.TabIndex = 18;
			this.Label4.Text = "Port :";
			this.Panel1.Controls.Add(this.Guna2GradientButton1);
			this.Panel1.Controls.Add(this.Guna2TextBox4);
			this.Panel1.Controls.Add(this.Label4);
			this.Panel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.Panel1.Location = new global::System.Drawing.Point(0, 0);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new global::System.Drawing.Size(333, 177);
			this.Panel1.TabIndex = 21;
			this.Panel2.Controls.Add(this.Panel1);
			this.Panel2.Controls.Add(this.Guna2GradientButton2);
			this.Panel2.Controls.Add(this.Guna2TextBox2);
			this.Panel2.Controls.Add(this.Guna2TextBox1);
			this.Panel2.Controls.Add(this.Label6);
			this.Panel2.Controls.Add(this.Label3);
			this.Panel2.Controls.Add(this.Guna2TextBox3);
			this.Panel2.Controls.Add(this.Label2);
			this.Panel2.Controls.Add(this.PictureBox1);
			this.Panel2.Controls.Add(this.Label1);
			this.Panel2.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.Panel2.Location = new global::System.Drawing.Point(0, 0);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new global::System.Drawing.Size(333, 177);
			this.Panel2.TabIndex = 22;
			this.Guna2TextBox4.BorderColor = global::System.Drawing.Color.FromArgb(40, 192, 182);
			this.Guna2TextBox4.BorderRadius = 3;
			this.Guna2TextBox4.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.Guna2TextBox4.DefaultText = "8000";
			this.Guna2TextBox4.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.Guna2TextBox4.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.Guna2TextBox4.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.Guna2TextBox4.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.Guna2TextBox4.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.Guna2TextBox4.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.Guna2TextBox4.ForeColor = global::System.Drawing.Color.Black;
			this.Guna2TextBox4.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.Guna2TextBox4.Location = new global::System.Drawing.Point(80, 63);
			this.Guna2TextBox4.Name = "Guna2TextBox4";
			this.Guna2TextBox4.PasswordChar = '\0';
			this.Guna2TextBox4.PlaceholderForeColor = global::System.Drawing.Color.Black;
			this.Guna2TextBox4.PlaceholderText = "";
			this.Guna2TextBox4.SelectedText = "";
			this.Guna2TextBox4.Size = new global::System.Drawing.Size(197, 21);
			this.Guna2TextBox4.TabIndex = 50;
			this.Guna2GradientButton1.BorderRadius = 4;
			this.Guna2GradientButton1.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.Guna2GradientButton1.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.Guna2GradientButton1.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.Guna2GradientButton1.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.Guna2GradientButton1.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.Guna2GradientButton1.FillColor2 = global::System.Drawing.Color.FromArgb(40, 192, 182);
			this.Guna2GradientButton1.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.Guna2GradientButton1.ForeColor = global::System.Drawing.Color.White;
			this.Guna2GradientButton1.ImageSize = new global::System.Drawing.Size(17, 17);
			this.Guna2GradientButton1.Location = new global::System.Drawing.Point(80, 90);
			this.Guna2GradientButton1.Name = "Guna2GradientButton1";
			this.Guna2GradientButton1.Size = new global::System.Drawing.Size(197, 24);
			this.Guna2GradientButton1.TabIndex = 101;
			this.Guna2GradientButton1.Text = "Start";
			this.Guna2TextBox1.BorderColor = global::System.Drawing.Color.FromArgb(40, 192, 182);
			this.Guna2TextBox1.BorderRadius = 3;
			this.Guna2TextBox1.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.Guna2TextBox1.DefaultText = "";
			this.Guna2TextBox1.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.Guna2TextBox1.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.Guna2TextBox1.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.Guna2TextBox1.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.Guna2TextBox1.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.Guna2TextBox1.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.Guna2TextBox1.ForeColor = global::System.Drawing.Color.Black;
			this.Guna2TextBox1.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.Guna2TextBox1.Location = new global::System.Drawing.Point(86, 46);
			this.Guna2TextBox1.Name = "Guna2TextBox1";
			this.Guna2TextBox1.PasswordChar = '\0';
			this.Guna2TextBox1.PlaceholderForeColor = global::System.Drawing.Color.Black;
			this.Guna2TextBox1.PlaceholderText = "";
			this.Guna2TextBox1.ReadOnly = true;
			this.Guna2TextBox1.SelectedText = "";
			this.Guna2TextBox1.Size = new global::System.Drawing.Size(221, 21);
			this.Guna2TextBox1.TabIndex = 102;
			this.Guna2TextBox2.BorderColor = global::System.Drawing.Color.FromArgb(40, 192, 182);
			this.Guna2TextBox2.BorderRadius = 3;
			this.Guna2TextBox2.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.Guna2TextBox2.DefaultText = "";
			this.Guna2TextBox2.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.Guna2TextBox2.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.Guna2TextBox2.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.Guna2TextBox2.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.Guna2TextBox2.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.Guna2TextBox2.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.Guna2TextBox2.ForeColor = global::System.Drawing.Color.Black;
			this.Guna2TextBox2.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.Guna2TextBox2.Location = new global::System.Drawing.Point(86, 73);
			this.Guna2TextBox2.Name = "Guna2TextBox2";
			this.Guna2TextBox2.PasswordChar = '\0';
			this.Guna2TextBox2.PlaceholderForeColor = global::System.Drawing.Color.Black;
			this.Guna2TextBox2.PlaceholderText = "";
			this.Guna2TextBox2.ReadOnly = true;
			this.Guna2TextBox2.SelectedText = "";
			this.Guna2TextBox2.Size = new global::System.Drawing.Size(221, 21);
			this.Guna2TextBox2.TabIndex = 103;
			this.Guna2TextBox3.BorderColor = global::System.Drawing.Color.FromArgb(40, 192, 182);
			this.Guna2TextBox3.BorderRadius = 3;
			this.Guna2TextBox3.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.Guna2TextBox3.DefaultText = "";
			this.Guna2TextBox3.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.Guna2TextBox3.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.Guna2TextBox3.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.Guna2TextBox3.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.Guna2TextBox3.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.Guna2TextBox3.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.Guna2TextBox3.ForeColor = global::System.Drawing.Color.Black;
			this.Guna2TextBox3.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.Guna2TextBox3.Location = new global::System.Drawing.Point(86, 100);
			this.Guna2TextBox3.Name = "Guna2TextBox3";
			this.Guna2TextBox3.PasswordChar = '\0';
			this.Guna2TextBox3.PlaceholderForeColor = global::System.Drawing.Color.Black;
			this.Guna2TextBox3.PlaceholderText = "";
			this.Guna2TextBox3.ReadOnly = true;
			this.Guna2TextBox3.SelectedText = "";
			this.Guna2TextBox3.Size = new global::System.Drawing.Size(221, 21);
			this.Guna2TextBox3.TabIndex = 104;
			this.Guna2GradientButton2.BorderRadius = 4;
			this.Guna2GradientButton2.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.Guna2GradientButton2.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.Guna2GradientButton2.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.Guna2GradientButton2.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.Guna2GradientButton2.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.Guna2GradientButton2.FillColor2 = global::System.Drawing.Color.FromArgb(40, 192, 182);
			this.Guna2GradientButton2.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.Guna2GradientButton2.ForeColor = global::System.Drawing.Color.White;
			this.Guna2GradientButton2.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("Guna2GradientButton2.Image");
			this.Guna2GradientButton2.ImageAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.Guna2GradientButton2.ImageSize = new global::System.Drawing.Size(17, 17);
			this.Guna2GradientButton2.Location = new global::System.Drawing.Point(13, 136);
			this.Guna2GradientButton2.Name = "Guna2GradientButton2";
			this.Guna2GradientButton2.Size = new global::System.Drawing.Size(309, 27);
			this.Guna2GradientButton2.TabIndex = 102;
			this.Guna2GradientButton2.Text = "Disconnect";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.White;
			base.ClientSize = new global::System.Drawing.Size(333, 177);
			base.Controls.Add(this.Panel2);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Proxy";
			this.Text = "Reverse Proxy";
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.Panel2.ResumeLayout(false);
			this.Panel2.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x040002FE RID: 766
		private global::System.ComponentModel.IContainer components;
	}
}
