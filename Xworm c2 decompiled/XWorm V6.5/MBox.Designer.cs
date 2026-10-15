namespace XWorm
{
	// Token: 0x0200001F RID: 31
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class MBox : global::System.Windows.Forms.Form
	{
		// Token: 0x06000641 RID: 1601 RVA: 0x000382A8 File Offset: 0x000364A8
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

		// Token: 0x06000642 RID: 1602 RVA: 0x000382F8 File Offset: 0x000364F8
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::XWorm.MBox));
			this.ImageList1 = new global::System.Windows.Forms.ImageList(this.components);
			this.Timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.StatusStrip1 = new global::System.Windows.Forms.StatusStrip();
			this.ToolStripStatusLabel1 = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.PictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Label6 = new global::System.Windows.Forms.Label();
			this.Label7 = new global::System.Windows.Forms.Label();
			this.PictureBox2 = new global::System.Windows.Forms.PictureBox();
			this.Label5 = new global::System.Windows.Forms.Label();
			this.Guna2TabControl1 = new global::Guna.UI2.WinForms.Guna2TabControl();
			this.TabPage1 = new global::System.Windows.Forms.TabPage();
			this.TabPage2 = new global::System.Windows.Forms.TabPage();
			this.Guna2GradientButton1 = new global::Guna.UI2.WinForms.Guna2GradientButton();
			this.Guna2ComboBox1 = new global::Guna.UI2.WinForms.Guna2ComboBox();
			this.Guna2ComboBox2 = new global::Guna.UI2.WinForms.Guna2ComboBox();
			this.Guna2TextBox1 = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.Guna2TextBox2 = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.Guna2ComboBox3 = new global::Guna.UI2.WinForms.Guna2ComboBox();
			this.Guna2TextBox3 = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.Guna2TextBox4 = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.Guna2GradientButton2 = new global::Guna.UI2.WinForms.Guna2GradientButton();
			this.StatusStrip1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox2).BeginInit();
			this.Guna2TabControl1.SuspendLayout();
			this.TabPage1.SuspendLayout();
			this.TabPage2.SuspendLayout();
			base.SuspendLayout();
			this.ImageList1.ImageStream = (global::System.Windows.Forms.ImageListStreamer)componentResourceManager.GetObject("ImageList1.ImageStream");
			this.ImageList1.TransparentColor = global::System.Drawing.Color.Transparent;
			this.ImageList1.Images.SetKeyName(0, "icons8-letter-16.png");
			this.ImageList1.Images.SetKeyName(1, "comments.png");
			this.Timer1.Enabled = true;
			this.Timer1.Interval = 1000;
			this.StatusStrip1.BackColor = global::System.Drawing.Color.White;
			this.StatusStrip1.ImageScalingSize = new global::System.Drawing.Size(24, 24);
			this.StatusStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.ToolStripStatusLabel1
			});
			this.StatusStrip1.Location = new global::System.Drawing.Point(0, 298);
			this.StatusStrip1.Name = "StatusStrip1";
			this.StatusStrip1.Padding = new global::System.Windows.Forms.Padding(1, 0, 9, 0);
			this.StatusStrip1.Size = new global::System.Drawing.Size(479, 22);
			this.StatusStrip1.TabIndex = 11;
			this.StatusStrip1.Text = "StatusStrip1";
			this.ToolStripStatusLabel1.ForeColor = global::System.Drawing.Color.Black;
			this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
			this.ToolStripStatusLabel1.Size = new global::System.Drawing.Size(13, 17);
			this.ToolStripStatusLabel1.Text = "..";
			this.Label4.AutoSize = true;
			this.Label4.ForeColor = global::System.Drawing.Color.Black;
			this.Label4.Location = new global::System.Drawing.Point(13, 140);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(49, 13);
			this.Label4.TabIndex = 7;
			this.Label4.Text = "Message";
			this.Label3.AutoSize = true;
			this.Label3.ForeColor = global::System.Drawing.Color.Black;
			this.Label3.Location = new global::System.Drawing.Point(13, 100);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(72, 13);
			this.Label3.TabIndex = 5;
			this.Label3.Text = "Message Title";
			this.Label2.AutoSize = true;
			this.Label2.ForeColor = global::System.Drawing.Color.Black;
			this.Label2.Location = new global::System.Drawing.Point(13, 48);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(99, 13);
			this.Label2.TabIndex = 3;
			this.Label2.Text = "MessageBoxButton";
			this.PictureBox1.Location = new global::System.Drawing.Point(176, 24);
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.Size = new global::System.Drawing.Size(22, 22);
			this.PictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.PictureBox1.TabIndex = 2;
			this.PictureBox1.TabStop = false;
			this.PictureBox1.Visible = false;
			this.Label1.AutoSize = true;
			this.Label1.ForeColor = global::System.Drawing.Color.Black;
			this.Label1.Location = new global::System.Drawing.Point(13, 8);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(88, 13);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "MessageBoxIcon";
			this.Label6.AutoSize = true;
			this.Label6.ForeColor = global::System.Drawing.Color.Black;
			this.Label6.Location = new global::System.Drawing.Point(14, 118);
			this.Label6.Name = "Label6";
			this.Label6.Size = new global::System.Drawing.Size(29, 13);
			this.Label6.TabIndex = 12;
			this.Label6.Text = "Text";
			this.Label7.AutoSize = true;
			this.Label7.ForeColor = global::System.Drawing.Color.Black;
			this.Label7.Location = new global::System.Drawing.Point(14, 78);
			this.Label7.Name = "Label7";
			this.Label7.Size = new global::System.Drawing.Size(27, 13);
			this.Label7.TabIndex = 10;
			this.Label7.Text = "Title";
			this.PictureBox2.Location = new global::System.Drawing.Point(177, 41);
			this.PictureBox2.Name = "PictureBox2";
			this.PictureBox2.Size = new global::System.Drawing.Size(22, 22);
			this.PictureBox2.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.PictureBox2.TabIndex = 5;
			this.PictureBox2.TabStop = false;
			this.PictureBox2.Visible = false;
			this.Label5.AutoSize = true;
			this.Label5.ForeColor = global::System.Drawing.Color.Black;
			this.Label5.Location = new global::System.Drawing.Point(14, 25);
			this.Label5.Name = "Label5";
			this.Label5.Size = new global::System.Drawing.Size(28, 13);
			this.Label5.TabIndex = 3;
			this.Label5.Text = "Icon";
			this.Guna2TabControl1.Controls.Add(this.TabPage1);
			this.Guna2TabControl1.Controls.Add(this.TabPage2);
			this.Guna2TabControl1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.Guna2TabControl1.ImageList = this.ImageList1;
			this.Guna2TabControl1.ItemSize = new global::System.Drawing.Size(140, 30);
			this.Guna2TabControl1.Location = new global::System.Drawing.Point(0, 0);
			this.Guna2TabControl1.Name = "Guna2TabControl1";
			this.Guna2TabControl1.SelectedIndex = 0;
			this.Guna2TabControl1.Size = new global::System.Drawing.Size(479, 298);
			this.Guna2TabControl1.TabButtonHoverState.BorderColor = global::System.Drawing.Color.Empty;
			this.Guna2TabControl1.TabButtonHoverState.FillColor = global::System.Drawing.Color.FromArgb(216, 214, 228);
			this.Guna2TabControl1.TabButtonHoverState.Font = new global::System.Drawing.Font("Segoe UI Semibold", 10f);
			this.Guna2TabControl1.TabButtonHoverState.ForeColor = global::System.Drawing.Color.White;
			this.Guna2TabControl1.TabButtonHoverState.InnerColor = global::System.Drawing.Color.FromArgb(216, 214, 228);
			this.Guna2TabControl1.TabButtonIdleState.BorderColor = global::System.Drawing.Color.Empty;
			this.Guna2TabControl1.TabButtonIdleState.FillColor = global::System.Drawing.Color.White;
			this.Guna2TabControl1.TabButtonIdleState.Font = new global::System.Drawing.Font("Segoe UI Semibold", 10f);
			this.Guna2TabControl1.TabButtonIdleState.ForeColor = global::System.Drawing.Color.Black;
			this.Guna2TabControl1.TabButtonIdleState.InnerColor = global::System.Drawing.Color.White;
			this.Guna2TabControl1.TabButtonSelectedState.BorderColor = global::System.Drawing.Color.Empty;
			this.Guna2TabControl1.TabButtonSelectedState.FillColor = global::System.Drawing.Color.White;
			this.Guna2TabControl1.TabButtonSelectedState.Font = new global::System.Drawing.Font("Segoe UI Semibold", 10f);
			this.Guna2TabControl1.TabButtonSelectedState.ForeColor = global::System.Drawing.Color.Black;
			this.Guna2TabControl1.TabButtonSelectedState.InnerColor = global::System.Drawing.Color.FromArgb(40, 192, 182);
			this.Guna2TabControl1.TabButtonSize = new global::System.Drawing.Size(140, 30);
			this.Guna2TabControl1.TabIndex = 91;
			this.Guna2TabControl1.TabMenuBackColor = global::System.Drawing.Color.White;
			this.Guna2TabControl1.TabMenuOrientation = 0;
			this.TabPage1.BackColor = global::System.Drawing.Color.White;
			this.TabPage1.Controls.Add(this.Guna2TextBox2);
			this.TabPage1.Controls.Add(this.Guna2TextBox1);
			this.TabPage1.Controls.Add(this.Guna2ComboBox2);
			this.TabPage1.Controls.Add(this.Label4);
			this.TabPage1.Controls.Add(this.Guna2ComboBox1);
			this.TabPage1.Controls.Add(this.Guna2GradientButton1);
			this.TabPage1.Controls.Add(this.Label3);
			this.TabPage1.Controls.Add(this.Label1);
			this.TabPage1.Controls.Add(this.PictureBox1);
			this.TabPage1.Controls.Add(this.Label2);
			this.TabPage1.ImageKey = "icons8-letter-16.png";
			this.TabPage1.Location = new global::System.Drawing.Point(4, 34);
			this.TabPage1.Name = "TabPage1";
			this.TabPage1.Padding = new global::System.Windows.Forms.Padding(3);
			this.TabPage1.Size = new global::System.Drawing.Size(471, 260);
			this.TabPage1.TabIndex = 0;
			this.TabPage1.Text = "MessageBox";
			this.TabPage2.BackColor = global::System.Drawing.Color.White;
			this.TabPage2.Controls.Add(this.Guna2GradientButton2);
			this.TabPage2.Controls.Add(this.Guna2TextBox4);
			this.TabPage2.Controls.Add(this.Guna2TextBox3);
			this.TabPage2.Controls.Add(this.Guna2ComboBox3);
			this.TabPage2.Controls.Add(this.Label6);
			this.TabPage2.Controls.Add(this.Label5);
			this.TabPage2.Controls.Add(this.PictureBox2);
			this.TabPage2.Controls.Add(this.Label7);
			this.TabPage2.ImageKey = "comments.png";
			this.TabPage2.Location = new global::System.Drawing.Point(4, 34);
			this.TabPage2.Name = "TabPage2";
			this.TabPage2.Padding = new global::System.Windows.Forms.Padding(3);
			this.TabPage2.Size = new global::System.Drawing.Size(471, 260);
			this.TabPage2.TabIndex = 1;
			this.TabPage2.Text = "BallonTooltip";
			this.Guna2GradientButton1.BorderRadius = 4;
			this.Guna2GradientButton1.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.Guna2GradientButton1.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.Guna2GradientButton1.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.Guna2GradientButton1.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.Guna2GradientButton1.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.Guna2GradientButton1.FillColor2 = global::System.Drawing.Color.FromArgb(40, 192, 182);
			this.Guna2GradientButton1.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.Guna2GradientButton1.ForeColor = global::System.Drawing.Color.White;
			this.Guna2GradientButton1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("Guna2GradientButton1.Image");
			this.Guna2GradientButton1.ImageAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.Guna2GradientButton1.ImageSize = new global::System.Drawing.Size(17, 17);
			this.Guna2GradientButton1.Location = new global::System.Drawing.Point(16, 225);
			this.Guna2GradientButton1.Name = "Guna2GradientButton1";
			this.Guna2GradientButton1.Size = new global::System.Drawing.Size(438, 27);
			this.Guna2GradientButton1.TabIndex = 56;
			this.Guna2GradientButton1.Text = "Ok";
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
				"Information",
				"Question",
				"Warning",
				"Error",
				"None"
			});
			this.Guna2ComboBox1.Location = new global::System.Drawing.Point(16, 24);
			this.Guna2ComboBox1.Name = "Guna2ComboBox1";
			this.Guna2ComboBox1.Size = new global::System.Drawing.Size(154, 21);
			this.Guna2ComboBox1.TabIndex = 94;
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
				"YesNo",
				"YesNoCancel",
				"OK",
				"OKCancel",
				"RetryCancel",
				"AbortRetryIgnore"
			});
			this.Guna2ComboBox2.Location = new global::System.Drawing.Point(16, 64);
			this.Guna2ComboBox2.Name = "Guna2ComboBox2";
			this.Guna2ComboBox2.Size = new global::System.Drawing.Size(154, 21);
			this.Guna2ComboBox2.TabIndex = 95;
			this.Guna2TextBox1.BorderColor = global::System.Drawing.Color.FromArgb(40, 192, 182);
			this.Guna2TextBox1.BorderRadius = 3;
			this.Guna2TextBox1.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.Guna2TextBox1.DefaultText = "MessageBox";
			this.Guna2TextBox1.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.Guna2TextBox1.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.Guna2TextBox1.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.Guna2TextBox1.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.Guna2TextBox1.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.Guna2TextBox1.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.Guna2TextBox1.ForeColor = global::System.Drawing.Color.Black;
			this.Guna2TextBox1.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.Guna2TextBox1.Location = new global::System.Drawing.Point(16, 116);
			this.Guna2TextBox1.Name = "Guna2TextBox1";
			this.Guna2TextBox1.PasswordChar = '\0';
			this.Guna2TextBox1.PlaceholderForeColor = global::System.Drawing.Color.Black;
			this.Guna2TextBox1.PlaceholderText = "";
			this.Guna2TextBox1.SelectedText = "";
			this.Guna2TextBox1.Size = new global::System.Drawing.Size(438, 21);
			this.Guna2TextBox1.TabIndex = 96;
			this.Guna2TextBox2.BorderColor = global::System.Drawing.Color.FromArgb(40, 192, 182);
			this.Guna2TextBox2.BorderRadius = 3;
			this.Guna2TextBox2.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.Guna2TextBox2.DefaultText = "Hello World!";
			this.Guna2TextBox2.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.Guna2TextBox2.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.Guna2TextBox2.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.Guna2TextBox2.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.Guna2TextBox2.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.Guna2TextBox2.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.Guna2TextBox2.ForeColor = global::System.Drawing.Color.Black;
			this.Guna2TextBox2.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.Guna2TextBox2.Location = new global::System.Drawing.Point(16, 156);
			this.Guna2TextBox2.Multiline = true;
			this.Guna2TextBox2.Name = "Guna2TextBox2";
			this.Guna2TextBox2.PasswordChar = '\0';
			this.Guna2TextBox2.PlaceholderForeColor = global::System.Drawing.Color.Black;
			this.Guna2TextBox2.PlaceholderText = "";
			this.Guna2TextBox2.ScrollBars = global::System.Windows.Forms.ScrollBars.Both;
			this.Guna2TextBox2.SelectedText = "";
			this.Guna2TextBox2.Size = new global::System.Drawing.Size(438, 63);
			this.Guna2TextBox2.TabIndex = 97;
			this.Guna2ComboBox3.BackColor = global::System.Drawing.Color.Transparent;
			this.Guna2ComboBox3.BorderColor = global::System.Drawing.Color.FromArgb(40, 192, 182);
			this.Guna2ComboBox3.BorderRadius = 3;
			this.Guna2ComboBox3.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.Guna2ComboBox3.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Guna2ComboBox3.FocusedColor = global::System.Drawing.Color.FromArgb(40, 192, 182);
			this.Guna2ComboBox3.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(40, 192, 182);
			this.Guna2ComboBox3.Font = new global::System.Drawing.Font("Segoe UI", 8.25f);
			this.Guna2ComboBox3.ForeColor = global::System.Drawing.Color.Black;
			this.Guna2ComboBox3.ItemHeight = 15;
			this.Guna2ComboBox3.Items.AddRange(new object[]
			{
				"Info",
				"Warning",
				"Error",
				"None"
			});
			this.Guna2ComboBox3.Location = new global::System.Drawing.Point(17, 41);
			this.Guna2ComboBox3.Name = "Guna2ComboBox3";
			this.Guna2ComboBox3.Size = new global::System.Drawing.Size(154, 21);
			this.Guna2ComboBox3.TabIndex = 96;
			this.Guna2TextBox3.BorderColor = global::System.Drawing.Color.FromArgb(40, 192, 182);
			this.Guna2TextBox3.BorderRadius = 3;
			this.Guna2TextBox3.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.Guna2TextBox3.DefaultText = "Hello World!";
			this.Guna2TextBox3.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.Guna2TextBox3.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.Guna2TextBox3.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.Guna2TextBox3.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.Guna2TextBox3.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.Guna2TextBox3.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.Guna2TextBox3.ForeColor = global::System.Drawing.Color.Black;
			this.Guna2TextBox3.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.Guna2TextBox3.Location = new global::System.Drawing.Point(17, 134);
			this.Guna2TextBox3.Multiline = true;
			this.Guna2TextBox3.Name = "Guna2TextBox3";
			this.Guna2TextBox3.PasswordChar = '\0';
			this.Guna2TextBox3.PlaceholderForeColor = global::System.Drawing.Color.Black;
			this.Guna2TextBox3.PlaceholderText = "";
			this.Guna2TextBox3.ScrollBars = global::System.Windows.Forms.ScrollBars.Both;
			this.Guna2TextBox3.SelectedText = "";
			this.Guna2TextBox3.Size = new global::System.Drawing.Size(438, 74);
			this.Guna2TextBox3.TabIndex = 97;
			this.Guna2TextBox4.BorderColor = global::System.Drawing.Color.FromArgb(40, 192, 182);
			this.Guna2TextBox4.BorderRadius = 3;
			this.Guna2TextBox4.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.Guna2TextBox4.DefaultText = "BalloonTip";
			this.Guna2TextBox4.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.Guna2TextBox4.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.Guna2TextBox4.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.Guna2TextBox4.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.Guna2TextBox4.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.Guna2TextBox4.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.Guna2TextBox4.ForeColor = global::System.Drawing.Color.Black;
			this.Guna2TextBox4.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.Guna2TextBox4.Location = new global::System.Drawing.Point(17, 94);
			this.Guna2TextBox4.Name = "Guna2TextBox4";
			this.Guna2TextBox4.PasswordChar = '\0';
			this.Guna2TextBox4.PlaceholderForeColor = global::System.Drawing.Color.Black;
			this.Guna2TextBox4.PlaceholderText = "";
			this.Guna2TextBox4.SelectedText = "";
			this.Guna2TextBox4.Size = new global::System.Drawing.Size(438, 21);
			this.Guna2TextBox4.TabIndex = 98;
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
			this.Guna2GradientButton2.Location = new global::System.Drawing.Point(17, 214);
			this.Guna2GradientButton2.Name = "Guna2GradientButton2";
			this.Guna2GradientButton2.Size = new global::System.Drawing.Size(438, 27);
			this.Guna2GradientButton2.TabIndex = 99;
			this.Guna2GradientButton2.Text = "Ok";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.White;
			base.ClientSize = new global::System.Drawing.Size(479, 320);
			base.Controls.Add(this.Guna2TabControl1);
			base.Controls.Add(this.StatusStrip1);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "MBox";
			this.Text = "MessageBox";
			this.StatusStrip1.ResumeLayout(false);
			this.StatusStrip1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox2).EndInit();
			this.Guna2TabControl1.ResumeLayout(false);
			this.TabPage1.ResumeLayout(false);
			this.TabPage1.PerformLayout();
			this.TabPage2.ResumeLayout(false);
			this.TabPage2.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000287 RID: 647
		private global::System.ComponentModel.IContainer components;
	}
}
