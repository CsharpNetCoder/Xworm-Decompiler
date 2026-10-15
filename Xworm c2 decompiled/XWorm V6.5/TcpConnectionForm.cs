using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic.CompilerServices;

namespace XWorm
{
	// Token: 0x0200002F RID: 47
	[DesignerGenerated]
	public partial class TcpConnectionForm : Form
	{
		// Token: 0x06000891 RID: 2193 RVA: 0x0004A9F4 File Offset: 0x00048BF4
		public TcpConnectionForm()
		{
			base.Load += this.TcpConnectionForm_Load;
			base.FormClosing += this.TcpConnectionForm_FormClosing;
			this.InitializeComponent();
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x06000894 RID: 2196 RVA: 0x0004B1A3 File Offset: 0x000493A3
		// (set) Token: 0x06000895 RID: 2197 RVA: 0x0004B1B0 File Offset: 0x000493B0
		internal virtual ListView ListView1
		{
			[CompilerGenerated]
			get
			{
				return this._ListView1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ListView1_SelectedIndexChanged);
				KeyEventHandler value3 = new KeyEventHandler(this.ListView1_KeyDown);
				ListView listView = this._ListView1;
				if (listView != null)
				{
					listView.SelectedIndexChanged -= value2;
					listView.KeyDown -= value3;
				}
				this._ListView1 = value;
				listView = this._ListView1;
				if (listView != null)
				{
					listView.SelectedIndexChanged += value2;
					listView.KeyDown += value3;
				}
			}
		}

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x06000896 RID: 2198 RVA: 0x0004B20E File Offset: 0x0004940E
		// (set) Token: 0x06000897 RID: 2199 RVA: 0x0004B218 File Offset: 0x00049418
		internal virtual ColumnHeader ColumnHeader1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x06000898 RID: 2200 RVA: 0x0004B221 File Offset: 0x00049421
		// (set) Token: 0x06000899 RID: 2201 RVA: 0x0004B22B File Offset: 0x0004942B
		internal virtual ColumnHeader ColumnHeader2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x0600089A RID: 2202 RVA: 0x0004B234 File Offset: 0x00049434
		// (set) Token: 0x0600089B RID: 2203 RVA: 0x0004B23E File Offset: 0x0004943E
		internal virtual ColumnHeader ColumnHeader3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x0600089C RID: 2204 RVA: 0x0004B247 File Offset: 0x00049447
		// (set) Token: 0x0600089D RID: 2205 RVA: 0x0004B251 File Offset: 0x00049451
		internal virtual ColumnHeader ColumnHeader4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x0600089E RID: 2206 RVA: 0x0004B25A File Offset: 0x0004945A
		// (set) Token: 0x0600089F RID: 2207 RVA: 0x0004B264 File Offset: 0x00049464
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

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x060008A0 RID: 2208 RVA: 0x0004B2A7 File Offset: 0x000494A7
		// (set) Token: 0x060008A1 RID: 2209 RVA: 0x0004B2B1 File Offset: 0x000494B1
		internal virtual StatusStrip StatusStrip1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x060008A2 RID: 2210 RVA: 0x0004B2BA File Offset: 0x000494BA
		// (set) Token: 0x060008A3 RID: 2211 RVA: 0x0004B2C4 File Offset: 0x000494C4
		internal virtual ToolStripStatusLabel ToolStripStatusLabel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x060008A4 RID: 2212 RVA: 0x0004B2CD File Offset: 0x000494CD
		// (set) Token: 0x060008A5 RID: 2213 RVA: 0x0004B2D7 File Offset: 0x000494D7
		internal virtual ToolStripStatusLabel ToolStripStatusLabel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x060008A6 RID: 2214 RVA: 0x0004B2E0 File Offset: 0x000494E0
		// (set) Token: 0x060008A7 RID: 2215 RVA: 0x0004B2EA File Offset: 0x000494EA
		internal virtual ImageList ImageList1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x060008A8 RID: 2216 RVA: 0x0004B2F3 File Offset: 0x000494F3
		// (set) Token: 0x060008A9 RID: 2217 RVA: 0x0004B2FD File Offset: 0x000494FD
		internal virtual Guna2ContextMenuStrip Guna2ContextMenuStrip1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x060008AA RID: 2218 RVA: 0x0004B306 File Offset: 0x00049506
		// (set) Token: 0x060008AB RID: 2219 RVA: 0x0004B310 File Offset: 0x00049510
		internal virtual ToolStripMenuItem ToolStripMenuItem4
		{
			[CompilerGenerated]
			get
			{
				return this._ToolStripMenuItem4;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripMenuItem4_Click);
				ToolStripMenuItem toolStripMenuItem = this._ToolStripMenuItem4;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= value2;
				}
				this._ToolStripMenuItem4 = value;
				toolStripMenuItem = this._ToolStripMenuItem4;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x060008AC RID: 2220 RVA: 0x0004B353 File Offset: 0x00049553
		// (set) Token: 0x060008AD RID: 2221 RVA: 0x0004B360 File Offset: 0x00049560
		internal virtual ToolStripMenuItem ToolStripMenuItem6
		{
			[CompilerGenerated]
			get
			{
				return this._ToolStripMenuItem6;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripMenuItem6_Click);
				ToolStripMenuItem toolStripMenuItem = this._ToolStripMenuItem6;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= value2;
				}
				this._ToolStripMenuItem6 = value;
				toolStripMenuItem = this._ToolStripMenuItem6;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x060008AE RID: 2222 RVA: 0x0004B3A3 File Offset: 0x000495A3
		private void TcpConnectionForm_Load(object sender, EventArgs e)
		{
			this.Refresh();
		}

		// Token: 0x060008AF RID: 2223 RVA: 0x0004B3B0 File Offset: 0x000495B0
		public new void Refresh()
		{
			this.ListView1.Items.Clear();
			this.ToolStripStatusLabel2.Text = "Wait..";
			byte[] state = Helper.SB("GetTCPConnection");
			Client $VB$NonLocal_2 = this.C;
			ThreadPool.QueueUserWorkItem(delegate(object a0)
			{
				$VB$NonLocal_2.BeginSend((byte[])a0);
			}, state);
		}

		// Token: 0x060008B0 RID: 2224 RVA: 0x0004B410 File Offset: 0x00049610
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

		// Token: 0x060008B1 RID: 2225 RVA: 0x0004B468 File Offset: 0x00049668
		private void TcpConnectionForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			byte[] state = Helper.SB("CloseTCPConnections");
			Client $VB$NonLocal_2 = this.C;
			ThreadPool.QueueUserWorkItem(delegate(object a0)
			{
				$VB$NonLocal_2.BeginSend((byte[])a0);
			}, state);
		}

		// Token: 0x060008B2 RID: 2226 RVA: 0x0004B4A8 File Offset: 0x000496A8
		private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				this.ToolStripStatusLabel1.Text = "Selected [" + this.ListView1.SelectedItems.Count.ToString() + "]";
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
			}
		}

		// Token: 0x060008B3 RID: 2227 RVA: 0x0004B518 File Offset: 0x00049718
		private void ListView1_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				bool flag = e.Modifiers == Keys.Control && e.KeyCode == Keys.A;
				if (flag)
				{
					bool flag2 = this.ListView1.Items.Count > 0;
					if (flag2)
					{
						try
						{
							foreach (object obj in this.ListView1.Items)
							{
								ListViewItem listViewItem = (ListViewItem)obj;
								listViewItem.Selected = true;
							}
						}
						finally
						{
							IEnumerator enumerator;
							if (enumerator is IDisposable)
							{
								(enumerator as IDisposable).Dispose();
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
			}
		}

		// Token: 0x060008B4 RID: 2228 RVA: 0x0004B3A3 File Offset: 0x000495A3
		private void ToolStripMenuItem4_Click(object sender, EventArgs e)
		{
			this.Refresh();
		}

		// Token: 0x060008B5 RID: 2229 RVA: 0x0004B5E8 File Offset: 0x000497E8
		private void ToolStripMenuItem6_Click(object sender, EventArgs e)
		{
			string text = null;
			try
			{
				foreach (object obj in this.ListView1.SelectedItems)
				{
					ListViewItem listViewItem = (ListViewItem)obj;
					text = text + "-=>" + listViewItem.SubItems[0].Text;
				}
			}
			finally
			{
				IEnumerator enumerator;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			byte[] state = Helper.SB("KillTCPConnection" + SettingsHelper.SPL + text);
			TcpConnectionForm._Closure$__R64-4 CS$<>8__locals1 = new TcpConnectionForm._Closure$__R64-4(CS$<>8__locals1);
			CS$<>8__locals1.$VB$NonLocal_2 = this.C;
			ThreadPool.QueueUserWorkItem(delegate(object a0)
			{
				CS$<>8__locals1.$VB$NonLocal_2.BeginSend((byte[])a0);
			}, state);
		}

		// Token: 0x0400039A RID: 922
		public Client C;
	}
}
