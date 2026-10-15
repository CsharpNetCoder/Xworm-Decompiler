namespace XWorm
{
	// Token: 0x02000017 RID: 23
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class HVNC : global::System.Windows.Forms.Form
	{
		// Token: 0x060004B5 RID: 1205 RVA: 0x0002B2C0 File Offset: 0x000294C0
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

		// Token: 0x060004B6 RID: 1206 RVA: 0x0002B310 File Offset: 0x00029510
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::XWorm.HVNC));
			this.PictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.StatusStrip1 = new global::System.Windows.Forms.StatusStrip();
			this.ToolStripStatusLabel1 = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.Timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.Timer2 = new global::System.Windows.Forms.Timer(this.components);
			this.Timer3 = new global::System.Windows.Forms.Timer(this.components);
			this.Panel2 = new global::System.Windows.Forms.Panel();
			this.Guna2Panel1 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.Guna2GradientButton1 = new global::Guna.UI2.WinForms.Guna2GradientButton();
			this.Guna2ComboBox1 = new global::Guna.UI2.WinForms.Guna2ComboBox();
			this.Guna2Panel3 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.Guna2Panel2 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.Guna2ComboBox3 = new global::Guna.UI2.WinForms.Guna2ComboBox();
			this.Guna2ComboBox2 = new global::Guna.UI2.WinForms.Guna2ComboBox();
			this.Guna2GradientButton6 = new global::Guna.UI2.WinForms.Guna2GradientButton();
			this.Guna2GradientButton2 = new global::Guna.UI2.WinForms.Guna2GradientButton();
			this.Guna2GroupBox1 = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.Guna2GradientButton3 = new global::Guna.UI2.WinForms.Guna2GradientButton();
			this.Guna2GradientButton4 = new global::Guna.UI2.WinForms.Guna2GradientButton();
			this.Guna2ComboBox4 = new global::Guna.UI2.WinForms.Guna2ComboBox();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.Guna2GradientButton5 = new global::Guna.UI2.WinForms.Guna2GradientButton();
			this.Guna2Panel4 = new global::Guna.UI2.WinForms.Guna2Panel();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
			this.StatusStrip1.SuspendLayout();
			this.Panel2.SuspendLayout();
			this.Guna2Panel1.SuspendLayout();
			this.Guna2GroupBox1.SuspendLayout();
			this.Guna2Panel4.SuspendLayout();
			base.SuspendLayout();
			this.PictureBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.PictureBox1.Location = new global::System.Drawing.Point(0, 65);
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.Size = new global::System.Drawing.Size(815, 332);
			this.PictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.PictureBox1.TabIndex = 1;
			this.PictureBox1.TabStop = false;
			this.Label3.AutoSize = true;
			this.Label3.ForeColor = global::System.Drawing.Color.Black;
			this.Label3.Location = new global::System.Drawing.Point(246, 38);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(45, 13);
			this.Label3.TabIndex = 14;
			this.Label3.Text = "Resize :";
			this.Label1.AutoSize = true;
			this.Label1.ForeColor = global::System.Drawing.Color.Black;
			this.Label1.Location = new global::System.Drawing.Point(19, 38);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(59, 15);
			this.Label1.TabIndex = 11;
			this.Label1.Text = "Software :";
			this.Label2.AutoSize = true;
			this.Label2.ForeColor = global::System.Drawing.Color.Black;
			this.Label2.Location = new global::System.Drawing.Point(74, 38);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(48, 13);
			this.Label2.TabIndex = 12;
			this.Label2.Text = "Quality :";
			this.StatusStrip1.BackColor = global::System.Drawing.Color.White;
			this.StatusStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.ToolStripStatusLabel1
			});
			this.StatusStrip1.Location = new global::System.Drawing.Point(0, 467);
			this.StatusStrip1.Name = "StatusStrip1";
			this.StatusStrip1.Size = new global::System.Drawing.Size(815, 22);
			this.StatusStrip1.TabIndex = 4;
			this.StatusStrip1.Text = "StatusStrip1";
			this.ToolStripStatusLabel1.ForeColor = global::System.Drawing.Color.Black;
			this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
			this.ToolStripStatusLabel1.Size = new global::System.Drawing.Size(13, 17);
			this.ToolStripStatusLabel1.Text = "..";
			this.Timer1.Enabled = true;
			this.Timer1.Interval = 1000;
			this.Panel2.Controls.Add(this.Guna2Panel4);
			this.Panel2.Controls.Add(this.Guna2ComboBox3);
			this.Panel2.Controls.Add(this.Label3);
			this.Panel2.Controls.Add(this.Guna2Panel1);
			this.Panel2.Controls.Add(this.Guna2ComboBox1);
			this.Panel2.Controls.Add(this.Guna2Panel3);
			this.Panel2.Controls.Add(this.Guna2Panel2);
			this.Panel2.Controls.Add(this.Label2);
			this.Panel2.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Panel2.Location = new global::System.Drawing.Point(0, 0);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new global::System.Drawing.Size(815, 65);
			this.Panel2.TabIndex = 30;
			this.Guna2Panel1.Controls.Add(this.Guna2GradientButton1);
			this.Guna2Panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Guna2Panel1.Location = new global::System.Drawing.Point(68, 0);
			this.Guna2Panel1.Name = "Guna2Panel1";
			this.Guna2Panel1.Size = new global::System.Drawing.Size(679, 21);
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
			this.Guna2GradientButton1.Size = new global::System.Drawing.Size(679, 21);
			this.Guna2GradientButton1.TabIndex = 34;
			this.Guna2GradientButton1.Text = "OFF";
			this.Guna2ComboBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.Guna2ComboBox1.BorderColor = global::System.Drawing.Color.FromArgb(40, 192, 182);
			this.Guna2ComboBox1.BorderRadius = 3;
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
			this.Guna2ComboBox1.Location = new global::System.Drawing.Point(128, 34);
			this.Guna2ComboBox1.Name = "Guna2ComboBox1";
			this.Guna2ComboBox1.Size = new global::System.Drawing.Size(107, 21);
			this.Guna2ComboBox1.TabIndex = 28;
			this.Guna2Panel3.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.Guna2Panel3.Location = new global::System.Drawing.Point(0, 0);
			this.Guna2Panel3.Name = "Guna2Panel3";
			this.Guna2Panel3.Size = new global::System.Drawing.Size(68, 65);
			this.Guna2Panel3.TabIndex = 37;
			this.Guna2Panel2.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.Guna2Panel2.Location = new global::System.Drawing.Point(747, 0);
			this.Guna2Panel2.Name = "Guna2Panel2";
			this.Guna2Panel2.Size = new global::System.Drawing.Size(68, 65);
			this.Guna2Panel2.TabIndex = 36;
			this.Guna2ComboBox3.BackColor = global::System.Drawing.Color.Transparent;
			this.Guna2ComboBox3.BorderColor = global::System.Drawing.Color.FromArgb(40, 192, 182);
			this.Guna2ComboBox3.BorderRadius = 3;
			this.Guna2ComboBox3.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.Guna2ComboBox3.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Guna2ComboBox3.FocusedColor = global::System.Drawing.Color.FromArgb(40, 192, 182);
			this.Guna2ComboBox3.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(40, 192, 182);
			this.Guna2ComboBox3.Font = new global::System.Drawing.Font("Segoe UI", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Guna2ComboBox3.ForeColor = global::System.Drawing.Color.Black;
			this.Guna2ComboBox3.ItemHeight = 15;
			this.Guna2ComboBox3.Items.AddRange(new object[]
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
			this.Guna2ComboBox3.Location = new global::System.Drawing.Point(297, 34);
			this.Guna2ComboBox3.Name = "Guna2ComboBox3";
			this.Guna2ComboBox3.Size = new global::System.Drawing.Size(107, 21);
			this.Guna2ComboBox3.TabIndex = 38;
			this.Guna2ComboBox2.BackColor = global::System.Drawing.Color.Transparent;
			this.Guna2ComboBox2.BorderColor = global::System.Drawing.Color.FromArgb(40, 192, 182);
			this.Guna2ComboBox2.BorderRadius = 3;
			this.Guna2ComboBox2.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.Guna2ComboBox2.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Guna2ComboBox2.FocusedColor = global::System.Drawing.Color.FromArgb(40, 192, 182);
			this.Guna2ComboBox2.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(40, 192, 182);
			this.Guna2ComboBox2.Font = new global::System.Drawing.Font("Segoe UI", 8.25f);
			this.Guna2ComboBox2.ForeColor = global::System.Drawing.Color.Black;
			this.Guna2ComboBox2.ItemHeight = 15;
			this.Guna2ComboBox2.Items.AddRange(new object[]
			{
				"EdgeBrowser",
				"BraveBrowser",
				"FireFoxBrowser",
				"ChromeBrowser",
				"CommandPrompt",
				"PowerShell"
			});
			this.Guna2ComboBox2.Location = new global::System.Drawing.Point(84, 36);
			this.Guna2ComboBox2.Name = "Guna2ComboBox2";
			this.Guna2ComboBox2.Size = new global::System.Drawing.Size(156, 21);
			this.Guna2ComboBox2.TabIndex = 39;
			this.Guna2GradientButton6.BorderRadius = 3;
			this.Guna2GradientButton6.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.Guna2GradientButton6.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.Guna2GradientButton6.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.Guna2GradientButton6.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.Guna2GradientButton6.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.Guna2GradientButton6.FillColor2 = global::System.Drawing.Color.FromArgb(40, 192, 182);
			this.Guna2GradientButton6.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.Guna2GradientButton6.ForeColor = global::System.Drawing.Color.White;
			this.Guna2GradientButton6.ImageAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.Guna2GradientButton6.ImageSize = new global::System.Drawing.Size(17, 17);
			this.Guna2GradientButton6.Location = new global::System.Drawing.Point(246, 36);
			this.Guna2GradientButton6.Name = "Guna2GradientButton6";
			this.Guna2GradientButton6.Size = new global::System.Drawing.Size(76, 21);
			this.Guna2GradientButton6.TabIndex = 74;
			this.Guna2GradientButton6.Text = "Run";
			this.Guna2GradientButton2.BorderRadius = 3;
			this.Guna2GradientButton2.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.Guna2GradientButton2.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.Guna2GradientButton2.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.Guna2GradientButton2.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.Guna2GradientButton2.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.Guna2GradientButton2.FillColor2 = global::System.Drawing.Color.FromArgb(40, 192, 182);
			this.Guna2GradientButton2.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.Guna2GradientButton2.ForeColor = global::System.Drawing.Color.White;
			this.Guna2GradientButton2.ImageAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.Guna2GradientButton2.ImageSize = new global::System.Drawing.Size(17, 17);
			this.Guna2GradientButton2.Location = new global::System.Drawing.Point(328, 36);
			this.Guna2GradientButton2.Name = "Guna2GradientButton2";
			this.Guna2GradientButton2.Size = new global::System.Drawing.Size(76, 21);
			this.Guna2GradientButton2.TabIndex = 75;
			this.Guna2GradientButton2.Text = "Custom";
			this.Guna2GroupBox1.Controls.Add(this.Guna2GradientButton4);
			this.Guna2GroupBox1.Controls.Add(this.Guna2GradientButton3);
			this.Guna2GroupBox1.Controls.Add(this.Guna2GradientButton2);
			this.Guna2GroupBox1.Controls.Add(this.Guna2ComboBox2);
			this.Guna2GroupBox1.Controls.Add(this.Guna2GradientButton6);
			this.Guna2GroupBox1.Controls.Add(this.Label1);
			this.Guna2GroupBox1.CustomBorderThickness = new global::System.Windows.Forms.Padding(0);
			this.Guna2GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.Guna2GroupBox1.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.Guna2GroupBox1.ForeColor = global::System.Drawing.Color.Black;
			this.Guna2GroupBox1.Location = new global::System.Drawing.Point(0, 397);
			this.Guna2GroupBox1.Name = "Guna2GroupBox1";
			this.Guna2GroupBox1.Size = new global::System.Drawing.Size(815, 70);
			this.Guna2GroupBox1.TabIndex = 31;
			this.Guna2GroupBox1.Text = "Options";
			this.Guna2GradientButton3.BorderRadius = 3;
			this.Guna2GradientButton3.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.Guna2GradientButton3.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.Guna2GradientButton3.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.Guna2GradientButton3.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.Guna2GradientButton3.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.Guna2GradientButton3.FillColor2 = global::System.Drawing.Color.FromArgb(40, 192, 182);
			this.Guna2GradientButton3.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.Guna2GradientButton3.ForeColor = global::System.Drawing.Color.White;
			this.Guna2GradientButton3.ImageAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.Guna2GradientButton3.ImageSize = new global::System.Drawing.Size(17, 17);
			this.Guna2GradientButton3.Location = new global::System.Drawing.Point(410, 36);
			this.Guna2GradientButton3.Name = "Guna2GradientButton3";
			this.Guna2GradientButton3.Size = new global::System.Drawing.Size(76, 21);
			this.Guna2GradientButton3.TabIndex = 76;
			this.Guna2GradientButton3.Text = "Copy";
			this.Guna2GradientButton4.BorderRadius = 3;
			this.Guna2GradientButton4.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.Guna2GradientButton4.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.Guna2GradientButton4.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.Guna2GradientButton4.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.Guna2GradientButton4.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.Guna2GradientButton4.FillColor2 = global::System.Drawing.Color.FromArgb(40, 192, 182);
			this.Guna2GradientButton4.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.Guna2GradientButton4.ForeColor = global::System.Drawing.Color.White;
			this.Guna2GradientButton4.ImageAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.Guna2GradientButton4.ImageSize = new global::System.Drawing.Size(17, 17);
			this.Guna2GradientButton4.Location = new global::System.Drawing.Point(492, 36);
			this.Guna2GradientButton4.Name = "Guna2GradientButton4";
			this.Guna2GradientButton4.Size = new global::System.Drawing.Size(76, 21);
			this.Guna2GradientButton4.TabIndex = 77;
			this.Guna2GradientButton4.Text = "Paste";
			this.Guna2ComboBox4.BackColor = global::System.Drawing.Color.Transparent;
			this.Guna2ComboBox4.BorderColor = global::System.Drawing.Color.FromArgb(40, 192, 182);
			this.Guna2ComboBox4.BorderRadius = 3;
			this.Guna2ComboBox4.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.Guna2ComboBox4.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Guna2ComboBox4.FocusedColor = global::System.Drawing.Color.FromArgb(40, 192, 182);
			this.Guna2ComboBox4.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(40, 192, 182);
			this.Guna2ComboBox4.Font = new global::System.Drawing.Font("Segoe UI", 8.25f);
			this.Guna2ComboBox4.ForeColor = global::System.Drawing.Color.Black;
			this.Guna2ComboBox4.ItemHeight = 15;
			this.Guna2ComboBox4.Items.AddRange(new object[]
			{
				"Close",
				"Minimize",
				"Maximize"
			});
			this.Guna2ComboBox4.Location = new global::System.Drawing.Point(63, 13);
			this.Guna2ComboBox4.Name = "Guna2ComboBox4";
			this.Guna2ComboBox4.Size = new global::System.Drawing.Size(105, 21);
			this.Guna2ComboBox4.TabIndex = 41;
			this.Label4.AutoSize = true;
			this.Label4.ForeColor = global::System.Drawing.Color.Black;
			this.Label4.Location = new global::System.Drawing.Point(5, 17);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(52, 13);
			this.Label4.TabIndex = 42;
			this.Label4.Text = "Window :";
			this.Guna2GradientButton5.BorderRadius = 3;
			this.Guna2GradientButton5.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.Guna2GradientButton5.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.Guna2GradientButton5.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.Guna2GradientButton5.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.Guna2GradientButton5.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.Guna2GradientButton5.FillColor2 = global::System.Drawing.Color.FromArgb(40, 192, 182);
			this.Guna2GradientButton5.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.Guna2GradientButton5.ForeColor = global::System.Drawing.Color.White;
			this.Guna2GradientButton5.ImageAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.Guna2GradientButton5.ImageSize = new global::System.Drawing.Size(17, 17);
			this.Guna2GradientButton5.Location = new global::System.Drawing.Point(174, 13);
			this.Guna2GradientButton5.Name = "Guna2GradientButton5";
			this.Guna2GradientButton5.Size = new global::System.Drawing.Size(47, 21);
			this.Guna2GradientButton5.TabIndex = 79;
			this.Guna2GradientButton5.Text = "Ok";
			this.Guna2Panel4.Controls.Add(this.Label4);
			this.Guna2Panel4.Controls.Add(this.Guna2GradientButton5);
			this.Guna2Panel4.Controls.Add(this.Guna2ComboBox4);
			this.Guna2Panel4.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.Guna2Panel4.Location = new global::System.Drawing.Point(521, 21);
			this.Guna2Panel4.Name = "Guna2Panel4";
			this.Guna2Panel4.Size = new global::System.Drawing.Size(226, 44);
			this.Guna2Panel4.TabIndex = 80;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.White;
			base.ClientSize = new global::System.Drawing.Size(815, 489);
			base.Controls.Add(this.PictureBox1);
			base.Controls.Add(this.Panel2);
			base.Controls.Add(this.Guna2GroupBox1);
			base.Controls.Add(this.StatusStrip1);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.MinimumSize = new global::System.Drawing.Size(831, 528);
			base.Name = "Form2";
			this.Text = "Hidden VNC";
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
			this.StatusStrip1.ResumeLayout(false);
			this.StatusStrip1.PerformLayout();
			this.Panel2.ResumeLayout(false);
			this.Panel2.PerformLayout();
			this.Guna2Panel1.ResumeLayout(false);
			this.Guna2GroupBox1.ResumeLayout(false);
			this.Guna2GroupBox1.PerformLayout();
			this.Guna2Panel4.ResumeLayout(false);
			this.Guna2Panel4.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040001DD RID: 477
		private global::System.ComponentModel.IContainer components;
	}
}
