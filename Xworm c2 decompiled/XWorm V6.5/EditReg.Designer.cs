namespace XWorm
{
	// Token: 0x0200000F RID: 15
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class EditReg : global::System.Windows.Forms.Form
	{
		// Token: 0x060000C1 RID: 193 RVA: 0x000073DC File Offset: 0x000055DC
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

		// Token: 0x060000C2 RID: 194 RVA: 0x0000742C File Offset: 0x0000562C
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::XWorm.EditReg));
			this.Panel1 = new global::System.Windows.Forms.Panel();
			this.Guna2TextBox1 = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.Guna2ComboBox1 = new global::Guna.UI2.WinForms.Guna2ComboBox();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Panel5 = new global::System.Windows.Forms.Panel();
			this.Guna2Panel1 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.Guna2GradientButton1 = new global::Guna.UI2.WinForms.Guna2GradientButton();
			this.Guna2Panel3 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.Guna2Panel2 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.Guna2TextBox3 = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.Panel1.SuspendLayout();
			this.Panel5.SuspendLayout();
			this.Guna2Panel1.SuspendLayout();
			base.SuspendLayout();
			this.Panel1.Controls.Add(this.Guna2TextBox1);
			this.Panel1.Controls.Add(this.Guna2ComboBox1);
			this.Panel1.Controls.Add(this.Label3);
			this.Panel1.Controls.Add(this.Label1);
			this.Panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Panel1.Location = new global::System.Drawing.Point(0, 32);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new global::System.Drawing.Size(359, 53);
			this.Panel1.TabIndex = 0;
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
			this.Guna2TextBox1.Location = new global::System.Drawing.Point(156, 26);
			this.Guna2TextBox1.Name = "Guna2TextBox1";
			this.Guna2TextBox1.PasswordChar = '\0';
			this.Guna2TextBox1.PlaceholderForeColor = global::System.Drawing.Color.Black;
			this.Guna2TextBox1.PlaceholderText = "";
			this.Guna2TextBox1.SelectedText = "";
			this.Guna2TextBox1.Size = new global::System.Drawing.Size(192, 21);
			this.Guna2TextBox1.TabIndex = 50;
			this.Guna2ComboBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.Guna2ComboBox1.BorderColor = global::System.Drawing.Color.FromArgb(40, 192, 182);
			this.Guna2ComboBox1.BorderRadius = 3;
			this.Guna2ComboBox1.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.Guna2ComboBox1.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Guna2ComboBox1.FocusedColor = global::System.Drawing.Color.FromArgb(40, 192, 182);
			this.Guna2ComboBox1.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(40, 192, 182);
			this.Guna2ComboBox1.Font = new global::System.Drawing.Font("Segoe UI", 8.25f);
			this.Guna2ComboBox1.ForeColor = global::System.Drawing.Color.Black;
			this.Guna2ComboBox1.ItemHeight = 15;
			this.Guna2ComboBox1.Items.AddRange(new object[]
			{
				"Binary",
				"DWord",
				"ExpandString",
				"MultiString",
				"QWord",
				"String"
			});
			this.Guna2ComboBox1.Location = new global::System.Drawing.Point(12, 26);
			this.Guna2ComboBox1.Name = "Guna2ComboBox1";
			this.Guna2ComboBox1.Size = new global::System.Drawing.Size(138, 21);
			this.Guna2ComboBox1.TabIndex = 94;
			this.Label3.AutoSize = true;
			this.Label3.ForeColor = global::System.Drawing.Color.Black;
			this.Label3.Location = new global::System.Drawing.Point(153, 10);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(43, 13);
			this.Label3.TabIndex = 31;
			this.Label3.Text = "Name _";
			this.Label1.AutoSize = true;
			this.Label1.ForeColor = global::System.Drawing.Color.Black;
			this.Label1.Location = new global::System.Drawing.Point(9, 10);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(40, 13);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Type _";
			this.Panel5.Controls.Add(this.Guna2Panel1);
			this.Panel5.Controls.Add(this.Guna2Panel3);
			this.Panel5.Controls.Add(this.Guna2Panel2);
			this.Panel5.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Panel5.Location = new global::System.Drawing.Point(0, 0);
			this.Panel5.Name = "Panel5";
			this.Panel5.Size = new global::System.Drawing.Size(359, 32);
			this.Panel5.TabIndex = 35;
			this.Guna2Panel1.Controls.Add(this.Guna2GradientButton1);
			this.Guna2Panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Guna2Panel1.Location = new global::System.Drawing.Point(27, 0);
			this.Guna2Panel1.Name = "Guna2Panel1";
			this.Guna2Panel1.Size = new global::System.Drawing.Size(305, 21);
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
			this.Guna2GradientButton1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("Guna2GradientButton1.Image");
			this.Guna2GradientButton1.ImageAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.Guna2GradientButton1.ImageSize = new global::System.Drawing.Size(15, 15);
			this.Guna2GradientButton1.Location = new global::System.Drawing.Point(0, 0);
			this.Guna2GradientButton1.Name = "Guna2GradientButton1";
			this.Guna2GradientButton1.Size = new global::System.Drawing.Size(305, 21);
			this.Guna2GradientButton1.TabIndex = 34;
			this.Guna2GradientButton1.Text = "Save";
			this.Guna2Panel3.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.Guna2Panel3.Location = new global::System.Drawing.Point(0, 0);
			this.Guna2Panel3.Name = "Guna2Panel3";
			this.Guna2Panel3.Size = new global::System.Drawing.Size(27, 32);
			this.Guna2Panel3.TabIndex = 37;
			this.Guna2Panel2.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.Guna2Panel2.Location = new global::System.Drawing.Point(332, 0);
			this.Guna2Panel2.Name = "Guna2Panel2";
			this.Guna2Panel2.Size = new global::System.Drawing.Size(27, 32);
			this.Guna2Panel2.TabIndex = 36;
			this.Guna2TextBox3.BorderColor = global::System.Drawing.Color.FromArgb(40, 192, 182);
			this.Guna2TextBox3.BorderRadius = 3;
			this.Guna2TextBox3.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.Guna2TextBox3.DefaultText = "";
			this.Guna2TextBox3.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.Guna2TextBox3.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.Guna2TextBox3.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.Guna2TextBox3.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.Guna2TextBox3.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.Guna2TextBox3.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.Guna2TextBox3.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.Guna2TextBox3.ForeColor = global::System.Drawing.Color.Black;
			this.Guna2TextBox3.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.Guna2TextBox3.Location = new global::System.Drawing.Point(0, 85);
			this.Guna2TextBox3.Multiline = true;
			this.Guna2TextBox3.Name = "Guna2TextBox3";
			this.Guna2TextBox3.PasswordChar = '\0';
			this.Guna2TextBox3.PlaceholderForeColor = global::System.Drawing.Color.Black;
			this.Guna2TextBox3.PlaceholderText = "";
			this.Guna2TextBox3.ScrollBars = global::System.Windows.Forms.ScrollBars.Both;
			this.Guna2TextBox3.SelectedText = "";
			this.Guna2TextBox3.Size = new global::System.Drawing.Size(359, 155);
			this.Guna2TextBox3.TabIndex = 51;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.White;
			base.ClientSize = new global::System.Drawing.Size(359, 240);
			base.Controls.Add(this.Guna2TextBox3);
			base.Controls.Add(this.Panel1);
			base.Controls.Add(this.Panel5);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "EditReg";
			this.Text = "EditReg";
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.Panel5.ResumeLayout(false);
			this.Guna2Panel1.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x0400004A RID: 74
		private global::System.ComponentModel.IContainer components;
	}
}
