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
	// Token: 0x0200002B RID: 43
	[DesignerGenerated]
	public partial class ServiceManager : Form
	{
		// Token: 0x0600081F RID: 2079 RVA: 0x00047958 File Offset: 0x00045B58
		public ServiceManager()
		{
			base.Load += this.ServiceManager_Load;
			base.FormClosing += this.ServiceManager_FormClosing;
			this.InitializeComponent();
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06000822 RID: 2082 RVA: 0x00048233 File Offset: 0x00046433
		// (set) Token: 0x06000823 RID: 2083 RVA: 0x00048240 File Offset: 0x00046440
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

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06000824 RID: 2084 RVA: 0x0004829E File Offset: 0x0004649E
		// (set) Token: 0x06000825 RID: 2085 RVA: 0x000482A8 File Offset: 0x000464A8
		internal virtual ImageList ImageList1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06000826 RID: 2086 RVA: 0x000482B1 File Offset: 0x000464B1
		// (set) Token: 0x06000827 RID: 2087 RVA: 0x000482BB File Offset: 0x000464BB
		internal virtual StatusStrip StatusStrip1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06000828 RID: 2088 RVA: 0x000482C4 File Offset: 0x000464C4
		// (set) Token: 0x06000829 RID: 2089 RVA: 0x000482CE File Offset: 0x000464CE
		internal virtual ToolStripStatusLabel ToolStripStatusLabel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x0600082A RID: 2090 RVA: 0x000482D7 File Offset: 0x000464D7
		// (set) Token: 0x0600082B RID: 2091 RVA: 0x000482E1 File Offset: 0x000464E1
		internal virtual ToolStripStatusLabel ToolStripStatusLabel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x0600082C RID: 2092 RVA: 0x000482EA File Offset: 0x000464EA
		// (set) Token: 0x0600082D RID: 2093 RVA: 0x000482F4 File Offset: 0x000464F4
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

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x0600082E RID: 2094 RVA: 0x00048337 File Offset: 0x00046537
		// (set) Token: 0x0600082F RID: 2095 RVA: 0x00048341 File Offset: 0x00046541
		internal virtual ColumnHeader ColumnHeader1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06000830 RID: 2096 RVA: 0x0004834A File Offset: 0x0004654A
		// (set) Token: 0x06000831 RID: 2097 RVA: 0x00048354 File Offset: 0x00046554
		internal virtual ColumnHeader ColumnHeader2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06000832 RID: 2098 RVA: 0x0004835D File Offset: 0x0004655D
		// (set) Token: 0x06000833 RID: 2099 RVA: 0x00048367 File Offset: 0x00046567
		internal virtual ColumnHeader ColumnHeader7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06000834 RID: 2100 RVA: 0x00048370 File Offset: 0x00046570
		// (set) Token: 0x06000835 RID: 2101 RVA: 0x0004837A File Offset: 0x0004657A
		internal virtual ColumnHeader ColumnHeader8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06000836 RID: 2102 RVA: 0x00048383 File Offset: 0x00046583
		// (set) Token: 0x06000837 RID: 2103 RVA: 0x0004838D File Offset: 0x0004658D
		internal virtual ColumnHeader ColumnHeader9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06000838 RID: 2104 RVA: 0x00048396 File Offset: 0x00046596
		// (set) Token: 0x06000839 RID: 2105 RVA: 0x000483A0 File Offset: 0x000465A0
		internal virtual Guna2ContextMenuStrip Guna2ContextMenuStrip1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x0600083A RID: 2106 RVA: 0x000483A9 File Offset: 0x000465A9
		// (set) Token: 0x0600083B RID: 2107 RVA: 0x000483B4 File Offset: 0x000465B4
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

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x0600083C RID: 2108 RVA: 0x000483F7 File Offset: 0x000465F7
		// (set) Token: 0x0600083D RID: 2109 RVA: 0x00048404 File Offset: 0x00046604
		internal virtual ToolStripMenuItem RunningToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._RunningToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.RunningToolStripMenuItem_Click);
				ToolStripMenuItem runningToolStripMenuItem = this._RunningToolStripMenuItem;
				if (runningToolStripMenuItem != null)
				{
					runningToolStripMenuItem.Click -= value2;
				}
				this._RunningToolStripMenuItem = value;
				runningToolStripMenuItem = this._RunningToolStripMenuItem;
				if (runningToolStripMenuItem != null)
				{
					runningToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x0600083E RID: 2110 RVA: 0x00048447 File Offset: 0x00046647
		// (set) Token: 0x0600083F RID: 2111 RVA: 0x00048454 File Offset: 0x00046654
		internal virtual ToolStripMenuItem StoppedToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._StoppedToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.StoppedToolStripMenuItem_Click);
				ToolStripMenuItem stoppedToolStripMenuItem = this._StoppedToolStripMenuItem;
				if (stoppedToolStripMenuItem != null)
				{
					stoppedToolStripMenuItem.Click -= value2;
				}
				this._StoppedToolStripMenuItem = value;
				stoppedToolStripMenuItem = this._StoppedToolStripMenuItem;
				if (stoppedToolStripMenuItem != null)
				{
					stoppedToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06000840 RID: 2112 RVA: 0x00048497 File Offset: 0x00046697
		// (set) Token: 0x06000841 RID: 2113 RVA: 0x000484A4 File Offset: 0x000466A4
		internal virtual ToolStripMenuItem PauseToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._PauseToolStripMenuItem1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.PauseToolStripMenuItem1_Click);
				ToolStripMenuItem pauseToolStripMenuItem = this._PauseToolStripMenuItem1;
				if (pauseToolStripMenuItem != null)
				{
					pauseToolStripMenuItem.Click -= value2;
				}
				this._PauseToolStripMenuItem1 = value;
				pauseToolStripMenuItem = this._PauseToolStripMenuItem1;
				if (pauseToolStripMenuItem != null)
				{
					pauseToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x06000842 RID: 2114 RVA: 0x000484E7 File Offset: 0x000466E7
		private void ServiceManager_Load(object sender, EventArgs e)
		{
			this.Refresh();
		}

		// Token: 0x06000843 RID: 2115 RVA: 0x000484F4 File Offset: 0x000466F4
		public new void Refresh()
		{
			this.ListView1.Items.Clear();
			this.ToolStripStatusLabel2.Text = "Wait..";
			byte[] state = Helper.SB("GetService");
			Client $VB$NonLocal_2 = this.C;
			ThreadPool.QueueUserWorkItem(delegate(object a0)
			{
				$VB$NonLocal_2.BeginSend((byte[])a0);
			}, state);
		}

		// Token: 0x06000844 RID: 2116 RVA: 0x00048554 File Offset: 0x00046754
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

		// Token: 0x06000845 RID: 2117 RVA: 0x000485AC File Offset: 0x000467AC
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

		// Token: 0x06000846 RID: 2118 RVA: 0x0004861C File Offset: 0x0004681C
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

		// Token: 0x06000847 RID: 2119 RVA: 0x000486EC File Offset: 0x000468EC
		private void ServiceManager_FormClosing(object sender, FormClosingEventArgs e)
		{
			byte[] state = Helper.SB("CloseServiceManager");
			Client $VB$NonLocal_2 = this.C;
			ThreadPool.QueueUserWorkItem(delegate(object a0)
			{
				$VB$NonLocal_2.BeginSend((byte[])a0);
			}, state);
		}

		// Token: 0x06000848 RID: 2120 RVA: 0x000484E7 File Offset: 0x000466E7
		private void ToolStripMenuItem4_Click(object sender, EventArgs e)
		{
			this.Refresh();
		}

		// Token: 0x06000849 RID: 2121 RVA: 0x0004872C File Offset: 0x0004692C
		private void RunningToolStripMenuItem_Click(object sender, EventArgs e)
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
			byte[] state = Helper.SB("RunService" + SettingsHelper.SPL + text);
			ServiceManager._Closure$__R76-4 CS$<>8__locals1 = new ServiceManager._Closure$__R76-4(CS$<>8__locals1);
			CS$<>8__locals1.$VB$NonLocal_2 = this.C;
			ThreadPool.QueueUserWorkItem(delegate(object a0)
			{
				CS$<>8__locals1.$VB$NonLocal_2.BeginSend((byte[])a0);
			}, state);
		}

		// Token: 0x0600084A RID: 2122 RVA: 0x000487EC File Offset: 0x000469EC
		private void StoppedToolStripMenuItem_Click(object sender, EventArgs e)
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
			byte[] state = Helper.SB("StopService" + SettingsHelper.SPL + text);
			ServiceManager._Closure$__R77-6 CS$<>8__locals1 = new ServiceManager._Closure$__R77-6(CS$<>8__locals1);
			CS$<>8__locals1.$VB$NonLocal_2 = this.C;
			ThreadPool.QueueUserWorkItem(delegate(object a0)
			{
				CS$<>8__locals1.$VB$NonLocal_2.BeginSend((byte[])a0);
			}, state);
		}

		// Token: 0x0600084B RID: 2123 RVA: 0x000488AC File Offset: 0x00046AAC
		private void PauseToolStripMenuItem1_Click(object sender, EventArgs e)
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
			byte[] state = Helper.SB("PauseService" + SettingsHelper.SPL + text);
			ServiceManager._Closure$__R78-8 CS$<>8__locals1 = new ServiceManager._Closure$__R78-8(CS$<>8__locals1);
			CS$<>8__locals1.$VB$NonLocal_2 = this.C;
			ThreadPool.QueueUserWorkItem(delegate(object a0)
			{
				CS$<>8__locals1.$VB$NonLocal_2.BeginSend((byte[])a0);
			}, state);
		}

		// Token: 0x0400036D RID: 877
		public Client C;
	}
}
