using System;
using System.Reflection;

// Token: 0x02000679 RID: 1657
internal class AssemblyInfo
{
	// Token: 0x17000931 RID: 2353
	// (get) Token: 0x060039D3 RID: 14803 RVA: 0x00128A5C File Offset: 0x00126C5C
	public static string Version
	{
		get
		{
			if (AssemblyInfo.version == null)
			{
				AssemblyInfo.version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
				if (AssemblyInfo.version == null)
				{
					AssemblyInfo.version = string.Empty;
				}
			}
			return AssemblyInfo.version;
		}
	}

	// Token: 0x04001B7B RID: 7035
	private static string version = null;
}
