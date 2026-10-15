using System;

namespace System
{
	// Token: 0x020002D8 RID: 728
	internal static class Array2
	{
		// Token: 0x0600218B RID: 8587 RVA: 0x00075B3C File Offset: 0x00073D3C
		public static T[] Empty<T>()
		{
			return Array2.EmptyClass<T>.Empty;
		}

		// Token: 0x020003B2 RID: 946
		private static class EmptyClass<T>
		{
			// Token: 0x040013C6 RID: 5062
			public static readonly T[] Empty = new T[0];
		}
	}
}
