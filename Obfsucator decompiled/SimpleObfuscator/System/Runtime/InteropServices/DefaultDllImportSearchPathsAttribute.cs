using System;

namespace System.Runtime.InteropServices
{
	// Token: 0x020002DA RID: 730
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Method, AllowMultiple = false)]
	internal sealed class DefaultDllImportSearchPathsAttribute : Attribute
	{
		// Token: 0x0600218D RID: 8589 RVA: 0x00075B4C File Offset: 0x00073D4C
		public DefaultDllImportSearchPathsAttribute(DllImportSearchPath paths)
		{
			this._paths = paths;
		}

		// Token: 0x170009B9 RID: 2489
		// (get) Token: 0x0600218E RID: 8590 RVA: 0x00075B5C File Offset: 0x00073D5C
		public DllImportSearchPath Paths
		{
			get
			{
				return this._paths;
			}
		}

		// Token: 0x04000FBB RID: 4027
		internal DllImportSearchPath _paths;
	}
}
