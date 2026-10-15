using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic.CompilerServices;

namespace XWorm
{
	// Token: 0x0200001A RID: 26
	[DesignerGenerated]
	public partial class Fun : Form
	{
		// Token: 0x0600057C RID: 1404 RVA: 0x00032008 File Offset: 0x00030208
		public Fun()
		{
			base.FormClosing += this.Fun_FormClosing;
			this.InitializeComponent();
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x0600057F RID: 1407 RVA: 0x00034C11 File Offset: 0x00032E11
		// (set) Token: 0x06000580 RID: 1408 RVA: 0x00034C1B File Offset: 0x00032E1B
		internal virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x06000581 RID: 1409 RVA: 0x00034C24 File Offset: 0x00032E24
		// (set) Token: 0x06000582 RID: 1410 RVA: 0x00034C2E File Offset: 0x00032E2E
		internal virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x06000583 RID: 1411 RVA: 0x00034C37 File Offset: 0x00032E37
		// (set) Token: 0x06000584 RID: 1412 RVA: 0x00034C41 File Offset: 0x00032E41
		internal virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x06000585 RID: 1413 RVA: 0x00034C4A File Offset: 0x00032E4A
		// (set) Token: 0x06000586 RID: 1414 RVA: 0x00034C54 File Offset: 0x00032E54
		internal virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x06000587 RID: 1415 RVA: 0x00034C5D File Offset: 0x00032E5D
		// (set) Token: 0x06000588 RID: 1416 RVA: 0x00034C67 File Offset: 0x00032E67
		internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x06000589 RID: 1417 RVA: 0x00034C70 File Offset: 0x00032E70
		// (set) Token: 0x0600058A RID: 1418 RVA: 0x00034C7A File Offset: 0x00032E7A
		internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x0600058B RID: 1419 RVA: 0x00034C83 File Offset: 0x00032E83
		// (set) Token: 0x0600058C RID: 1420 RVA: 0x00034C8D File Offset: 0x00032E8D
		internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x0600058D RID: 1421 RVA: 0x00034C96 File Offset: 0x00032E96
		// (set) Token: 0x0600058E RID: 1422 RVA: 0x00034CA0 File Offset: 0x00032EA0
		internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x0600058F RID: 1423 RVA: 0x00034CA9 File Offset: 0x00032EA9
		// (set) Token: 0x06000590 RID: 1424 RVA: 0x00034CB3 File Offset: 0x00032EB3
		internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x06000591 RID: 1425 RVA: 0x00034CBC File Offset: 0x00032EBC
		// (set) Token: 0x06000592 RID: 1426 RVA: 0x00034CC6 File Offset: 0x00032EC6
		internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x06000593 RID: 1427 RVA: 0x00034CCF File Offset: 0x00032ECF
		// (set) Token: 0x06000594 RID: 1428 RVA: 0x00034CDC File Offset: 0x00032EDC
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

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x06000595 RID: 1429 RVA: 0x00034D1F File Offset: 0x00032F1F
		// (set) Token: 0x06000596 RID: 1430 RVA: 0x00034D2C File Offset: 0x00032F2C
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

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x06000597 RID: 1431 RVA: 0x00034D6F File Offset: 0x00032F6F
		// (set) Token: 0x06000598 RID: 1432 RVA: 0x00034D7C File Offset: 0x00032F7C
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

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x06000599 RID: 1433 RVA: 0x00034DBF File Offset: 0x00032FBF
		// (set) Token: 0x0600059A RID: 1434 RVA: 0x00034DCC File Offset: 0x00032FCC
		internal virtual Guna2GradientButton Guna2GradientButton3
		{
			[CompilerGenerated]
			get
			{
				return this._Guna2GradientButton3;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Guna2GradientButton3_Click);
				Guna2GradientButton guna2GradientButton = this._Guna2GradientButton3;
				if (guna2GradientButton != null)
				{
					guna2GradientButton.Click -= value2;
				}
				this._Guna2GradientButton3 = value;
				guna2GradientButton = this._Guna2GradientButton3;
				if (guna2GradientButton != null)
				{
					guna2GradientButton.Click += value2;
				}
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x0600059B RID: 1435 RVA: 0x00034E0F File Offset: 0x0003300F
		// (set) Token: 0x0600059C RID: 1436 RVA: 0x00034E1C File Offset: 0x0003301C
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

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x0600059D RID: 1437 RVA: 0x00034E5F File Offset: 0x0003305F
		// (set) Token: 0x0600059E RID: 1438 RVA: 0x00034E6C File Offset: 0x0003306C
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

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x0600059F RID: 1439 RVA: 0x00034EAF File Offset: 0x000330AF
		// (set) Token: 0x060005A0 RID: 1440 RVA: 0x00034EBC File Offset: 0x000330BC
		internal virtual Guna2GradientButton Guna2GradientButton6
		{
			[CompilerGenerated]
			get
			{
				return this._Guna2GradientButton6;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Guna2GradientButton6_Click);
				Guna2GradientButton guna2GradientButton = this._Guna2GradientButton6;
				if (guna2GradientButton != null)
				{
					guna2GradientButton.Click -= value2;
				}
				this._Guna2GradientButton6 = value;
				guna2GradientButton = this._Guna2GradientButton6;
				if (guna2GradientButton != null)
				{
					guna2GradientButton.Click += value2;
				}
			}
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x060005A1 RID: 1441 RVA: 0x00034EFF File Offset: 0x000330FF
		// (set) Token: 0x060005A2 RID: 1442 RVA: 0x00034F0C File Offset: 0x0003310C
		internal virtual Guna2GradientButton Guna2GradientButton7
		{
			[CompilerGenerated]
			get
			{
				return this._Guna2GradientButton7;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Guna2GradientButton7_Click);
				Guna2GradientButton guna2GradientButton = this._Guna2GradientButton7;
				if (guna2GradientButton != null)
				{
					guna2GradientButton.Click -= value2;
				}
				this._Guna2GradientButton7 = value;
				guna2GradientButton = this._Guna2GradientButton7;
				if (guna2GradientButton != null)
				{
					guna2GradientButton.Click += value2;
				}
			}
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x060005A3 RID: 1443 RVA: 0x00034F4F File Offset: 0x0003314F
		// (set) Token: 0x060005A4 RID: 1444 RVA: 0x00034F5C File Offset: 0x0003315C
		internal virtual Guna2GradientButton Guna2GradientButton8
		{
			[CompilerGenerated]
			get
			{
				return this._Guna2GradientButton8;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Guna2GradientButton8_Click);
				Guna2GradientButton guna2GradientButton = this._Guna2GradientButton8;
				if (guna2GradientButton != null)
				{
					guna2GradientButton.Click -= value2;
				}
				this._Guna2GradientButton8 = value;
				guna2GradientButton = this._Guna2GradientButton8;
				if (guna2GradientButton != null)
				{
					guna2GradientButton.Click += value2;
				}
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x060005A5 RID: 1445 RVA: 0x00034F9F File Offset: 0x0003319F
		// (set) Token: 0x060005A6 RID: 1446 RVA: 0x00034FAC File Offset: 0x000331AC
		internal virtual Guna2GradientButton Guna2GradientButton9
		{
			[CompilerGenerated]
			get
			{
				return this._Guna2GradientButton9;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Guna2GradientButton9_Click);
				Guna2GradientButton guna2GradientButton = this._Guna2GradientButton9;
				if (guna2GradientButton != null)
				{
					guna2GradientButton.Click -= value2;
				}
				this._Guna2GradientButton9 = value;
				guna2GradientButton = this._Guna2GradientButton9;
				if (guna2GradientButton != null)
				{
					guna2GradientButton.Click += value2;
				}
			}
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x060005A7 RID: 1447 RVA: 0x00034FEF File Offset: 0x000331EF
		// (set) Token: 0x060005A8 RID: 1448 RVA: 0x00034FFC File Offset: 0x000331FC
		internal virtual Guna2GradientButton Guna2GradientButton10
		{
			[CompilerGenerated]
			get
			{
				return this._Guna2GradientButton10;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Guna2GradientButton10_Click);
				Guna2GradientButton guna2GradientButton = this._Guna2GradientButton10;
				if (guna2GradientButton != null)
				{
					guna2GradientButton.Click -= value2;
				}
				this._Guna2GradientButton10 = value;
				guna2GradientButton = this._Guna2GradientButton10;
				if (guna2GradientButton != null)
				{
					guna2GradientButton.Click += value2;
				}
			}
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x060005A9 RID: 1449 RVA: 0x0003503F File Offset: 0x0003323F
		// (set) Token: 0x060005AA RID: 1450 RVA: 0x0003504C File Offset: 0x0003324C
		internal virtual Guna2GradientButton Guna2GradientButton11
		{
			[CompilerGenerated]
			get
			{
				return this._Guna2GradientButton11;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Guna2GradientButton11_Click);
				Guna2GradientButton guna2GradientButton = this._Guna2GradientButton11;
				if (guna2GradientButton != null)
				{
					guna2GradientButton.Click -= value2;
				}
				this._Guna2GradientButton11 = value;
				guna2GradientButton = this._Guna2GradientButton11;
				if (guna2GradientButton != null)
				{
					guna2GradientButton.Click += value2;
				}
			}
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x060005AB RID: 1451 RVA: 0x0003508F File Offset: 0x0003328F
		// (set) Token: 0x060005AC RID: 1452 RVA: 0x0003509C File Offset: 0x0003329C
		internal virtual Guna2GradientButton Guna2GradientButton12
		{
			[CompilerGenerated]
			get
			{
				return this._Guna2GradientButton12;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Guna2GradientButton12_Click);
				Guna2GradientButton guna2GradientButton = this._Guna2GradientButton12;
				if (guna2GradientButton != null)
				{
					guna2GradientButton.Click -= value2;
				}
				this._Guna2GradientButton12 = value;
				guna2GradientButton = this._Guna2GradientButton12;
				if (guna2GradientButton != null)
				{
					guna2GradientButton.Click += value2;
				}
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x060005AD RID: 1453 RVA: 0x000350DF File Offset: 0x000332DF
		// (set) Token: 0x060005AE RID: 1454 RVA: 0x000350EC File Offset: 0x000332EC
		internal virtual Guna2GradientButton Guna2GradientButton13
		{
			[CompilerGenerated]
			get
			{
				return this._Guna2GradientButton13;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Guna2GradientButton13_Click);
				Guna2GradientButton guna2GradientButton = this._Guna2GradientButton13;
				if (guna2GradientButton != null)
				{
					guna2GradientButton.Click -= value2;
				}
				this._Guna2GradientButton13 = value;
				guna2GradientButton = this._Guna2GradientButton13;
				if (guna2GradientButton != null)
				{
					guna2GradientButton.Click += value2;
				}
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x060005AF RID: 1455 RVA: 0x0003512F File Offset: 0x0003332F
		// (set) Token: 0x060005B0 RID: 1456 RVA: 0x0003513C File Offset: 0x0003333C
		internal virtual Guna2GradientButton Guna2GradientButton14
		{
			[CompilerGenerated]
			get
			{
				return this._Guna2GradientButton14;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Guna2GradientButton14_Click);
				Guna2GradientButton guna2GradientButton = this._Guna2GradientButton14;
				if (guna2GradientButton != null)
				{
					guna2GradientButton.Click -= value2;
				}
				this._Guna2GradientButton14 = value;
				guna2GradientButton = this._Guna2GradientButton14;
				if (guna2GradientButton != null)
				{
					guna2GradientButton.Click += value2;
				}
			}
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x060005B1 RID: 1457 RVA: 0x0003517F File Offset: 0x0003337F
		// (set) Token: 0x060005B2 RID: 1458 RVA: 0x0003518C File Offset: 0x0003338C
		internal virtual Guna2GradientButton Guna2GradientButton15
		{
			[CompilerGenerated]
			get
			{
				return this._Guna2GradientButton15;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Guna2GradientButton15_Click);
				Guna2GradientButton guna2GradientButton = this._Guna2GradientButton15;
				if (guna2GradientButton != null)
				{
					guna2GradientButton.Click -= value2;
				}
				this._Guna2GradientButton15 = value;
				guna2GradientButton = this._Guna2GradientButton15;
				if (guna2GradientButton != null)
				{
					guna2GradientButton.Click += value2;
				}
			}
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x060005B3 RID: 1459 RVA: 0x000351CF File Offset: 0x000333CF
		// (set) Token: 0x060005B4 RID: 1460 RVA: 0x000351DC File Offset: 0x000333DC
		internal virtual Guna2GradientButton Guna2GradientButton16
		{
			[CompilerGenerated]
			get
			{
				return this._Guna2GradientButton16;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Guna2GradientButton16_Click);
				Guna2GradientButton guna2GradientButton = this._Guna2GradientButton16;
				if (guna2GradientButton != null)
				{
					guna2GradientButton.Click -= value2;
				}
				this._Guna2GradientButton16 = value;
				guna2GradientButton = this._Guna2GradientButton16;
				if (guna2GradientButton != null)
				{
					guna2GradientButton.Click += value2;
				}
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x060005B5 RID: 1461 RVA: 0x0003521F File Offset: 0x0003341F
		// (set) Token: 0x060005B6 RID: 1462 RVA: 0x00035229 File Offset: 0x00033429
		internal virtual Label Label12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x060005B7 RID: 1463 RVA: 0x00035232 File Offset: 0x00033432
		// (set) Token: 0x060005B8 RID: 1464 RVA: 0x0003523C File Offset: 0x0003343C
		internal virtual Guna2GradientButton Guna2GradientButton17
		{
			[CompilerGenerated]
			get
			{
				return this._Guna2GradientButton17;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Guna2GradientButton17_Click);
				Guna2GradientButton guna2GradientButton = this._Guna2GradientButton17;
				if (guna2GradientButton != null)
				{
					guna2GradientButton.Click -= value2;
				}
				this._Guna2GradientButton17 = value;
				guna2GradientButton = this._Guna2GradientButton17;
				if (guna2GradientButton != null)
				{
					guna2GradientButton.Click += value2;
				}
			}
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x060005B9 RID: 1465 RVA: 0x0003527F File Offset: 0x0003347F
		// (set) Token: 0x060005BA RID: 1466 RVA: 0x0003528C File Offset: 0x0003348C
		internal virtual Guna2GradientButton Guna2GradientButton18
		{
			[CompilerGenerated]
			get
			{
				return this._Guna2GradientButton18;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Guna2GradientButton18_Click);
				Guna2GradientButton guna2GradientButton = this._Guna2GradientButton18;
				if (guna2GradientButton != null)
				{
					guna2GradientButton.Click -= value2;
				}
				this._Guna2GradientButton18 = value;
				guna2GradientButton = this._Guna2GradientButton18;
				if (guna2GradientButton != null)
				{
					guna2GradientButton.Click += value2;
				}
			}
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x060005BB RID: 1467 RVA: 0x000352CF File Offset: 0x000334CF
		// (set) Token: 0x060005BC RID: 1468 RVA: 0x000352DC File Offset: 0x000334DC
		internal virtual Guna2GradientButton Guna2GradientButton20
		{
			[CompilerGenerated]
			get
			{
				return this._Guna2GradientButton20;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Guna2GradientButton20_Click);
				Guna2GradientButton guna2GradientButton = this._Guna2GradientButton20;
				if (guna2GradientButton != null)
				{
					guna2GradientButton.Click -= value2;
				}
				this._Guna2GradientButton20 = value;
				guna2GradientButton = this._Guna2GradientButton20;
				if (guna2GradientButton != null)
				{
					guna2GradientButton.Click += value2;
				}
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x060005BD RID: 1469 RVA: 0x0003531F File Offset: 0x0003351F
		// (set) Token: 0x060005BE RID: 1470 RVA: 0x0003532C File Offset: 0x0003352C
		internal virtual Guna2GradientButton Guna2GradientButton19
		{
			[CompilerGenerated]
			get
			{
				return this._Guna2GradientButton19;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Guna2GradientButton19_Click);
				Guna2GradientButton guna2GradientButton = this._Guna2GradientButton19;
				if (guna2GradientButton != null)
				{
					guna2GradientButton.Click -= value2;
				}
				this._Guna2GradientButton19 = value;
				guna2GradientButton = this._Guna2GradientButton19;
				if (guna2GradientButton != null)
				{
					guna2GradientButton.Click += value2;
				}
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x060005BF RID: 1471 RVA: 0x0003536F File Offset: 0x0003356F
		// (set) Token: 0x060005C0 RID: 1472 RVA: 0x0003537C File Offset: 0x0003357C
		internal virtual Guna2GradientButton Guna2GradientButton21
		{
			[CompilerGenerated]
			get
			{
				return this._Guna2GradientButton21;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Guna2GradientButton21_Click);
				Guna2GradientButton guna2GradientButton = this._Guna2GradientButton21;
				if (guna2GradientButton != null)
				{
					guna2GradientButton.Click -= value2;
				}
				this._Guna2GradientButton21 = value;
				guna2GradientButton = this._Guna2GradientButton21;
				if (guna2GradientButton != null)
				{
					guna2GradientButton.Click += value2;
				}
			}
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x060005C1 RID: 1473 RVA: 0x000353BF File Offset: 0x000335BF
		// (set) Token: 0x060005C2 RID: 1474 RVA: 0x000353C9 File Offset: 0x000335C9
		internal virtual Guna2TextBox Guna2TextBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x060005C3 RID: 1475 RVA: 0x000353D2 File Offset: 0x000335D2
		// (set) Token: 0x060005C4 RID: 1476 RVA: 0x000353DC File Offset: 0x000335DC
		internal virtual Guna2GradientButton Guna2GradientButton22
		{
			[CompilerGenerated]
			get
			{
				return this._Guna2GradientButton22;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Guna2GradientButton22_Click);
				Guna2GradientButton guna2GradientButton = this._Guna2GradientButton22;
				if (guna2GradientButton != null)
				{
					guna2GradientButton.Click -= value2;
				}
				this._Guna2GradientButton22 = value;
				guna2GradientButton = this._Guna2GradientButton22;
				if (guna2GradientButton != null)
				{
					guna2GradientButton.Click += value2;
				}
			}
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x0003541F File Offset: 0x0003361F
		private void Fun_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.SendF("ClFun");
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x00035430 File Offset: 0x00033630
		public object SendF(string MSG)
		{
			byte[] state = Helper.SB(MSG);
			Client $VB$NonLocal_2 = this.C;
			ThreadPool.QueueUserWorkItem(delegate(object a0)
			{
				$VB$NonLocal_2.BeginSend((byte[])a0);
			}, state);
			object result;
			return result;
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x0003546C File Offset: 0x0003366C
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

		// Token: 0x060005C8 RID: 1480 RVA: 0x000354C4 File Offset: 0x000336C4
		private void Guna2GradientButton1_Click(object sender, EventArgs e)
		{
			this.SendF("openCD");
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x000354D3 File Offset: 0x000336D3
		private void Guna2GradientButton2_Click(object sender, EventArgs e)
		{
			this.SendF("closeCD");
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x000354E2 File Offset: 0x000336E2
		private void Guna2GradientButton4_Click(object sender, EventArgs e)
		{
			this.SendF("TaskShow");
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x000354F1 File Offset: 0x000336F1
		private void Guna2GradientButton3_Click(object sender, EventArgs e)
		{
			this.SendF("Taskhide");
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x00035500 File Offset: 0x00033700
		private void Guna2GradientButton6_Click(object sender, EventArgs e)
		{
			this.SendF("showstart");
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x0003550F File Offset: 0x0003370F
		private void Guna2GradientButton5_Click(object sender, EventArgs e)
		{
			this.SendF("hidestart");
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x0003551E File Offset: 0x0003371E
		private void Guna2GradientButton8_Click(object sender, EventArgs e)
		{
			this.SendF("KillEXP");
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x0003552D File Offset: 0x0003372D
		private void Guna2GradientButton7_Click(object sender, EventArgs e)
		{
			this.SendF("STEXP");
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x0003553C File Offset: 0x0003373C
		private void Guna2GradientButton10_Click(object sender, EventArgs e)
		{
			this.SendF("showDESK");
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x0003554B File Offset: 0x0003374B
		private void Guna2GradientButton9_Click(object sender, EventArgs e)
		{
			this.SendF("hideDESK");
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x0003555A File Offset: 0x0003375A
		private void Guna2GradientButton12_Click(object sender, EventArgs e)
		{
			this.SendF("SWMouseD");
		}

		// Token: 0x060005D3 RID: 1491 RVA: 0x00035569 File Offset: 0x00033769
		private void Guna2GradientButton11_Click(object sender, EventArgs e)
		{
			this.SendF("SWMouseE");
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x00035578 File Offset: 0x00033778
		private void Guna2GradientButton14_Click(object sender, EventArgs e)
		{
			this.SendF("ScreenON");
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x00035587 File Offset: 0x00033787
		private void Guna2GradientButton13_Click(object sender, EventArgs e)
		{
			this.SendF("ScreenOFF");
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x00035596 File Offset: 0x00033796
		private void Guna2GradientButton16_Click(object sender, EventArgs e)
		{
			this.SendF("showClock");
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x000355A5 File Offset: 0x000337A5
		private void Guna2GradientButton15_Click(object sender, EventArgs e)
		{
			this.SendF("hideClock");
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x000355B4 File Offset: 0x000337B4
		private void Guna2GradientButton18_Click(object sender, EventArgs e)
		{
			this.SendF("showTray");
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x000355C3 File Offset: 0x000337C3
		private void Guna2GradientButton17_Click(object sender, EventArgs e)
		{
			this.SendF("hideTray");
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x000355D2 File Offset: 0x000337D2
		private void Guna2GradientButton20_Click(object sender, EventArgs e)
		{
			this.SendF("VUP");
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x000355E1 File Offset: 0x000337E1
		private void Guna2GradientButton19_Click(object sender, EventArgs e)
		{
			this.SendF("VDWM");
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x000355F0 File Offset: 0x000337F0
		private void Guna2GradientButton21_Click(object sender, EventArgs e)
		{
			this.SendF("VMUT");
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x00035600 File Offset: 0x00033800
		private void Guna2GradientButton22_Click(object sender, EventArgs e)
		{
			byte[] state = Helper.SB("speak" + SettingsHelper.SPL + this.Guna2TextBox1.Text.ToString());
			Client $VB$NonLocal_2 = this.C;
			ThreadPool.QueueUserWorkItem(delegate(object a0)
			{
				$VB$NonLocal_2.BeginSend((byte[])a0);
			}, state);
		}

		// Token: 0x0400025A RID: 602
		public Client C;
	}
}
