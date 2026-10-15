using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace System.Net.Http
{
	// Token: 0x020002DE RID: 734
	[DebuggerNonUserCode]
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	[CompilerGenerated]
	internal class SysSR
	{
		// Token: 0x060021C8 RID: 8648 RVA: 0x000760E8 File Offset: 0x000742E8
		internal SysSR()
		{
		}

		// Token: 0x170009F0 RID: 2544
		// (get) Token: 0x060021C9 RID: 8649 RVA: 0x000760F0 File Offset: 0x000742F0
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (object.ReferenceEquals(SysSR.resourceMan, null))
				{
					ResourceManager resourceManager = new ResourceManager("System.Net.Http.SysSR", typeof(SysSR).Assembly);
					SysSR.resourceMan = resourceManager;
				}
				return SysSR.resourceMan;
			}
		}

		// Token: 0x170009F1 RID: 2545
		// (get) Token: 0x060021CA RID: 8650 RVA: 0x00076138 File Offset: 0x00074338
		// (set) Token: 0x060021CB RID: 8651 RVA: 0x00076140 File Offset: 0x00074340
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return SysSR.resourceCulture;
			}
			set
			{
				SysSR.resourceCulture = value;
			}
		}

		// Token: 0x170009F2 RID: 2546
		// (get) Token: 0x060021CC RID: 8652 RVA: 0x00076148 File Offset: 0x00074348
		internal static string net_log_exception
		{
			get
			{
				return SysSR.ResourceManager.GetString("net_log_exception", SysSR.resourceCulture);
			}
		}

		// Token: 0x04000FCE RID: 4046
		private static ResourceManager resourceMan;

		// Token: 0x04000FCF RID: 4047
		private static CultureInfo resourceCulture;
	}
}
