using System;
using System.Text.RegularExpressions;

namespace System.Net
{
	// Token: 0x02000323 RID: 803
	internal static class ExceptionHelper
	{
		// Token: 0x04001108 RID: 4360
		internal static readonly WebPermission WebPermissionUnrestricted = new WebPermission(NetworkAccess.Connect, new Regex(".*"));
	}
}
