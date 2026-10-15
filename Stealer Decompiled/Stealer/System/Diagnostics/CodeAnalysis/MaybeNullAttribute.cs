using System;

namespace System.Diagnostics.CodeAnalysis
{
	// Token: 0x020006D6 RID: 1750
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue, Inherited = false)]
	internal sealed class MaybeNullAttribute : Attribute
	{
	}
}
