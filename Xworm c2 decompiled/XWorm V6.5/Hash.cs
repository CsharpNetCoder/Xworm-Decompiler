using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic.CompilerServices;

namespace XWorm
{
	// Token: 0x02000014 RID: 20
	[DesignerGenerated]
	public partial class Hash : Form
	{
		// Token: 0x0600024A RID: 586 RVA: 0x000161AA File Offset: 0x000143AA
		public Hash()
		{
			this.InitializeComponent();
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x0600024D RID: 589 RVA: 0x0001670E File Offset: 0x0001490E
		// (set) Token: 0x0600024E RID: 590 RVA: 0x00016718 File Offset: 0x00014918
		internal virtual Guna2TextBox Guna2TextBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x0600024F RID: 591 RVA: 0x00016721 File Offset: 0x00014921
		// (set) Token: 0x06000250 RID: 592 RVA: 0x0001672C File Offset: 0x0001492C
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

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000251 RID: 593 RVA: 0x0001676F File Offset: 0x0001496F
		// (set) Token: 0x06000252 RID: 594 RVA: 0x0001677C File Offset: 0x0001497C
		internal virtual Timer Timer1
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
				Timer timer = this._Timer1;
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

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000253 RID: 595 RVA: 0x000167BF File Offset: 0x000149BF
		// (set) Token: 0x06000254 RID: 596 RVA: 0x000167C9 File Offset: 0x000149C9
		private virtual Label label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x06000255 RID: 597 RVA: 0x000167D4 File Offset: 0x000149D4
		private void Guna2GradientButton1_Click(object sender, EventArgs e)
		{
			try
			{
				Clipboard.SetText(this.Guna2TextBox1.Text);
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
			}
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00016824 File Offset: 0x00014A24
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

		// Token: 0x040000F6 RID: 246
		public Client C;
	}
}
