using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic.CompilerServices;
using XWorm.My;

namespace XWorm
{
	// Token: 0x0200002E RID: 46
	[DesignerGenerated]
	public partial class TBotNotify : Form
	{
		// Token: 0x17000320 RID: 800
		// (get) Token: 0x06000884 RID: 2180 RVA: 0x0004A7CC File Offset: 0x000489CC
		// (set) Token: 0x06000885 RID: 2181 RVA: 0x0004A7D6 File Offset: 0x000489D6
		internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x06000886 RID: 2182 RVA: 0x0004A7DF File Offset: 0x000489DF
		// (set) Token: 0x06000887 RID: 2183 RVA: 0x0004A7E9 File Offset: 0x000489E9
		internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x06000888 RID: 2184 RVA: 0x0004A7F2 File Offset: 0x000489F2
		// (set) Token: 0x06000889 RID: 2185 RVA: 0x0004A7FC File Offset: 0x000489FC
		internal virtual Guna2TextBox Guna2TextBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x0600088A RID: 2186 RVA: 0x0004A805 File Offset: 0x00048A05
		// (set) Token: 0x0600088B RID: 2187 RVA: 0x0004A80F File Offset: 0x00048A0F
		internal virtual Guna2TextBox Guna2TextBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x0600088C RID: 2188 RVA: 0x0004A818 File Offset: 0x00048A18
		// (set) Token: 0x0600088D RID: 2189 RVA: 0x0004A824 File Offset: 0x00048A24
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

		// Token: 0x0600088E RID: 2190 RVA: 0x0004A868 File Offset: 0x00048A68
		public TBotNotify()
		{
			base.Load += this.TBotNotify_Load;
			this.InitializeComponent();
			base.Opacity = 0.0;
			Helper.FadeIn(this, 20);
			this.Guna2TextBox1.Select();
		}

		// Token: 0x0600088F RID: 2191 RVA: 0x0004A8BC File Offset: 0x00048ABC
		private void TBotNotify_Load(object sender, EventArgs e)
		{
			try
			{
				bool flag = Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(MyProject.Computer.Registry.GetValue(SettingsHelper.RegSave, "BotToken", null), null, false)));
				if (flag)
				{
					this.Guna2TextBox1.Text = Conversions.ToString(MyProject.Computer.Registry.GetValue(SettingsHelper.RegSave, "BotToken", null));
				}
				bool flag2 = Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(MyProject.Computer.Registry.GetValue(SettingsHelper.RegSave, "Botid", null), null, false)));
				if (flag2)
				{
					this.Guna2TextBox2.Text = Conversions.ToString(MyProject.Computer.Registry.GetValue(SettingsHelper.RegSave, "Botid", null));
				}
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
			}
		}

		// Token: 0x06000890 RID: 2192 RVA: 0x0004A9B4 File Offset: 0x00048BB4
		private void Guna2GradientButton1_Click(object sender, EventArgs e)
		{
			bool flag = string.IsNullOrWhiteSpace(this.Guna2TextBox1.Text) | string.IsNullOrWhiteSpace(this.Guna2TextBox2.Text);
			if (!flag)
			{
				base.DialogResult = DialogResult.OK;
			}
		}
	}
}
