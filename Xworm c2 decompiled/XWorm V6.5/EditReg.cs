using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace XWorm
{
	// Token: 0x0200000F RID: 15
	[DesignerGenerated]
	public partial class EditReg : Form
	{
		// Token: 0x060000C0 RID: 192 RVA: 0x000073CC File Offset: 0x000055CC
		public EditReg()
		{
			this.InitializeComponent();
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x00008004 File Offset: 0x00006204
		// (set) Token: 0x060000C4 RID: 196 RVA: 0x0000800E File Offset: 0x0000620E
		internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060000C5 RID: 197 RVA: 0x00008017 File Offset: 0x00006217
		// (set) Token: 0x060000C6 RID: 198 RVA: 0x00008021 File Offset: 0x00006221
		internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060000C7 RID: 199 RVA: 0x0000802A File Offset: 0x0000622A
		// (set) Token: 0x060000C8 RID: 200 RVA: 0x00008034 File Offset: 0x00006234
		internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x0000803D File Offset: 0x0000623D
		// (set) Token: 0x060000CA RID: 202 RVA: 0x00008047 File Offset: 0x00006247
		internal virtual Panel Panel5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060000CB RID: 203 RVA: 0x00008050 File Offset: 0x00006250
		// (set) Token: 0x060000CC RID: 204 RVA: 0x0000805A File Offset: 0x0000625A
		internal virtual Guna2Panel Guna2Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060000CD RID: 205 RVA: 0x00008063 File Offset: 0x00006263
		// (set) Token: 0x060000CE RID: 206 RVA: 0x00008070 File Offset: 0x00006270
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

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060000CF RID: 207 RVA: 0x000080B3 File Offset: 0x000062B3
		// (set) Token: 0x060000D0 RID: 208 RVA: 0x000080BD File Offset: 0x000062BD
		internal virtual Guna2Panel Guna2Panel3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x000080C6 File Offset: 0x000062C6
		// (set) Token: 0x060000D2 RID: 210 RVA: 0x000080D0 File Offset: 0x000062D0
		internal virtual Guna2Panel Guna2Panel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x000080D9 File Offset: 0x000062D9
		// (set) Token: 0x060000D4 RID: 212 RVA: 0x000080E3 File Offset: 0x000062E3
		internal virtual Guna2ComboBox Guna2ComboBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x000080EC File Offset: 0x000062EC
		// (set) Token: 0x060000D6 RID: 214 RVA: 0x000080F6 File Offset: 0x000062F6
		internal virtual Guna2TextBox Guna2TextBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x000080FF File Offset: 0x000062FF
		// (set) Token: 0x060000D8 RID: 216 RVA: 0x00008109 File Offset: 0x00006309
		internal virtual Guna2TextBox Guna2TextBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x060000D9 RID: 217 RVA: 0x00008114 File Offset: 0x00006314
		public int Typ(string t)
		{
			string left = t.ToLower();
			bool flag = Operators.CompareString(left, RegistryValueKind.Binary.ToString().ToLower(), false) == 0;
			int result;
			if (flag)
			{
				result = 3;
			}
			else
			{
				bool flag2 = Operators.CompareString(left, RegistryValueKind.DWord.ToString().ToLower(), false) == 0;
				if (flag2)
				{
					result = 4;
				}
				else
				{
					bool flag3 = Operators.CompareString(left, RegistryValueKind.ExpandString.ToString().ToLower(), false) == 0;
					if (flag3)
					{
						result = 2;
					}
					else
					{
						bool flag4 = Operators.CompareString(left, RegistryValueKind.MultiString.ToString().ToLower(), false) == 0;
						if (flag4)
						{
							result = 7;
						}
						else
						{
							bool flag5 = Operators.CompareString(left, RegistryValueKind.QWord.ToString().ToLower(), false) == 0;
							if (flag5)
							{
								result = 11;
							}
							else
							{
								bool flag6 = Operators.CompareString(left, RegistryValueKind.String.ToString().ToLower(), false) == 0;
								if (flag6)
								{
									result = 1;
								}
								else
								{
									int num;
									result = num;
								}
							}
						}
					}
				}
			}
			return result;
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00008234 File Offset: 0x00006434
		private void Guna2GradientButton1_Click(object sender, EventArgs e)
		{
			byte[] state = Helper.SB(string.Concat(new string[]
			{
				"RG",
				SettingsHelper.SPL,
				"!",
				SettingsHelper.SPL,
				this.Path,
				SettingsHelper.SPL,
				this.Guna2TextBox1.Text,
				SettingsHelper.SPL,
				this.Guna2TextBox3.Text,
				SettingsHelper.SPL,
				Conversions.ToString(this.Typ(this.Guna2ComboBox1.Text))
			}));
			Client $VB$NonLocal_2 = this.C;
			ThreadPool.QueueUserWorkItem(delegate(object a0)
			{
				$VB$NonLocal_2.BeginSend((byte[])a0);
			}, state);
			base.Close();
		}

		// Token: 0x04000056 RID: 86
		public Client C;

		// Token: 0x04000057 RID: 87
		public string Path;
	}
}
