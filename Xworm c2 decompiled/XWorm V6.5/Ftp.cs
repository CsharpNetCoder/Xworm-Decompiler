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
	// Token: 0x02000019 RID: 25
	[DesignerGenerated]
	public partial class Ftp : Form
	{
		// Token: 0x17000203 RID: 515
		// (get) Token: 0x06000567 RID: 1383 RVA: 0x00031BFE File Offset: 0x0002FDFE
		// (set) Token: 0x06000568 RID: 1384 RVA: 0x00031C08 File Offset: 0x0002FE08
		private virtual Label label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x06000569 RID: 1385 RVA: 0x00031C11 File Offset: 0x0002FE11
		// (set) Token: 0x0600056A RID: 1386 RVA: 0x00031C1B File Offset: 0x0002FE1B
		private virtual Label label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x0600056B RID: 1387 RVA: 0x00031C24 File Offset: 0x0002FE24
		// (set) Token: 0x0600056C RID: 1388 RVA: 0x00031C2E File Offset: 0x0002FE2E
		private virtual Label label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x0600056D RID: 1389 RVA: 0x00031C37 File Offset: 0x0002FE37
		// (set) Token: 0x0600056E RID: 1390 RVA: 0x00031C41 File Offset: 0x0002FE41
		private virtual Label label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x0600056F RID: 1391 RVA: 0x00031C4A File Offset: 0x0002FE4A
		// (set) Token: 0x06000570 RID: 1392 RVA: 0x00031C54 File Offset: 0x0002FE54
		internal virtual Guna2TextBox Guna2TextBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x06000571 RID: 1393 RVA: 0x00031C5D File Offset: 0x0002FE5D
		// (set) Token: 0x06000572 RID: 1394 RVA: 0x00031C67 File Offset: 0x0002FE67
		internal virtual Guna2TextBox Guna2TextBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06000573 RID: 1395 RVA: 0x00031C70 File Offset: 0x0002FE70
		// (set) Token: 0x06000574 RID: 1396 RVA: 0x00031C7A File Offset: 0x0002FE7A
		internal virtual Guna2TextBox Guna2TextBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x06000575 RID: 1397 RVA: 0x00031C83 File Offset: 0x0002FE83
		// (set) Token: 0x06000576 RID: 1398 RVA: 0x00031C8D File Offset: 0x0002FE8D
		internal virtual Guna2NumericUpDown Guna2NumericUpDown1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x06000577 RID: 1399 RVA: 0x00031C96 File Offset: 0x0002FE96
		// (set) Token: 0x06000578 RID: 1400 RVA: 0x00031CA0 File Offset: 0x0002FEA0
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

		// Token: 0x06000579 RID: 1401 RVA: 0x00031CE4 File Offset: 0x0002FEE4
		public Ftp()
		{
			base.Load += this.Ftp_Load;
			this.InitializeComponent();
			base.Opacity = 0.0;
			Helper.FadeIn(this, 20);
			this.Guna2TextBox1.Select();
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x00031D38 File Offset: 0x0002FF38
		private void Ftp_Load(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.ConditionalCompareObjectEqual(MyProject.Computer.Registry.GetValue(SettingsHelper.RegSave, "Ftphost", null), null, false);
				if (flag)
				{
					this.Guna2TextBox1.Text = "ftp.exmple.com";
				}
				else
				{
					this.Guna2TextBox1.Text = Conversions.ToString(MyProject.Computer.Registry.GetValue(SettingsHelper.RegSave, "Ftphost", null));
				}
				bool flag2 = Operators.ConditionalCompareObjectEqual(MyProject.Computer.Registry.GetValue(SettingsHelper.RegSave, "Ftpuser", null), null, false);
				if (flag2)
				{
					this.Guna2TextBox2.Text = "ftp-username";
				}
				else
				{
					this.Guna2TextBox2.Text = Conversions.ToString(MyProject.Computer.Registry.GetValue(SettingsHelper.RegSave, "Ftpuser", null));
				}
				bool flag3 = Operators.ConditionalCompareObjectEqual(MyProject.Computer.Registry.GetValue(SettingsHelper.RegSave, "Ftppass", null), null, false);
				if (flag3)
				{
					this.Guna2TextBox3.Text = "ftp-password";
				}
				else
				{
					this.Guna2TextBox3.Text = Conversions.ToString(MyProject.Computer.Registry.GetValue(SettingsHelper.RegSave, "Ftppass", null));
				}
				bool flag4 = Operators.ConditionalCompareObjectEqual(MyProject.Computer.Registry.GetValue(SettingsHelper.RegSave, "Ftpport", null), null, false);
				if (flag4)
				{
					this.Guna2NumericUpDown1.Value = 21m;
				}
				else
				{
					this.Guna2NumericUpDown1.Value = new decimal(Convert.ToInt32(RuntimeHelpers.GetObjectValue(MyProject.Computer.Registry.GetValue(SettingsHelper.RegSave, "Ftpport", null))));
				}
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
			}
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x00031F28 File Offset: 0x00030128
		private void Guna2GradientButton1_Click(object sender, EventArgs e)
		{
			try
			{
				MyProject.Computer.Registry.SetValue(SettingsHelper.RegSave, "Ftphost", this.Guna2TextBox1.Text);
				MyProject.Computer.Registry.SetValue(SettingsHelper.RegSave, "Ftpuser", this.Guna2TextBox2.Text);
				MyProject.Computer.Registry.SetValue(SettingsHelper.RegSave, "Ftppass", this.Guna2TextBox3.Text);
				MyProject.Computer.Registry.SetValue(SettingsHelper.RegSave, "Ftpport", this.Guna2NumericUpDown1.Value.ToString());
				base.Close();
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
			}
		}
	}
}
