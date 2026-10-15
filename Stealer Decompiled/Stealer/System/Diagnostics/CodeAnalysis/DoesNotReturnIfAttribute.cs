using System;

namespace System.Diagnostics.CodeAnalysis
{
	// Token: 0x020006D8 RID: 1752
	[AttributeUsage(AttributeTargets.Parameter, Inherited = false)]
	internal class DoesNotReturnIfAttribute : Attribute
	{
		// Token: 0x06003D37 RID: 15671 RVA: 0x0013F198 File Offset: 0x0013D398
		public DoesNotReturnIfAttribute(bool parameterValue)
		{
			this.ParameterValue = parameterValue;
		}

		// Token: 0x17000A01 RID: 2561
		// (get) Token: 0x06003D38 RID: 15672 RVA: 0x0013F1A8 File Offset: 0x0013D3A8
		public bool ParameterValue { get; }
	}
}
