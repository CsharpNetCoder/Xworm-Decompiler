using System;

namespace System.Runtime.InteropServices
{
	// Token: 0x020002DB RID: 731
	[Flags]
	internal enum DllImportSearchPath
	{
		// Token: 0x04000FBD RID: 4029
		LegacyBehavior = 0,
		// Token: 0x04000FBE RID: 4030
		AssemblyDirectory = 2,
		// Token: 0x04000FBF RID: 4031
		UseDllDirectoryForDependencies = 256,
		// Token: 0x04000FC0 RID: 4032
		ApplicationDirectory = 512,
		// Token: 0x04000FC1 RID: 4033
		UserDirectories = 1024,
		// Token: 0x04000FC2 RID: 4034
		System32 = 2048,
		// Token: 0x04000FC3 RID: 4035
		SafeDirectories = 4096
	}
}
