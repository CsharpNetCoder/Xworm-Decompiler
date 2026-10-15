using System;

namespace System.Diagnostics.CodeAnalysis
{
	// Token: 0x020006D5 RID: 1749
	[AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false)]
	internal sealed class NotNullWhenAttribute : Attribute
	{
		// Token: 0x06003D33 RID: 15667 RVA: 0x0013F170 File Offset: 0x0013D370
		public NotNullWhenAttribute(bool returnValue)
		{
			this.ReturnValue = returnValue;
		}

		// Token: 0x17000A00 RID: 2560
		// (get) Token: 0x06003D34 RID: 15668 RVA: 0x0013F180 File Offset: 0x0013D380
		public bool ReturnValue { get; }
	}
}
