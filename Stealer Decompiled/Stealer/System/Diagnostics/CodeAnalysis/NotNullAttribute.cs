using System;

namespace System.Diagnostics.CodeAnalysis
{
	// Token: 0x020006D4 RID: 1748
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue, AllowMultiple = true)]
	internal sealed class NotNullAttribute : Attribute
	{
	}
}
