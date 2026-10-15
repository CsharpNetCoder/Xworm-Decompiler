using System;
using dnlib.DotNet;

namespace SimpleObfuscator.Core.Protections.Analyzer
{
	// Token: 0x02000009 RID: 9
	public class TypeDefAnalyzer : iAnalyze
	{
		// Token: 0x06000012 RID: 18 RVA: 0x00002584 File Offset: 0x00000784
		public override bool Execute(object context)
		{
			TypeDef typeDef = (TypeDef)context;
			bool isRuntimeSpecialName = typeDef.IsRuntimeSpecialName;
			bool result;
			if (isRuntimeSpecialName)
			{
				result = false;
			}
			else
			{
				bool isGlobalModuleType = typeDef.IsGlobalModuleType;
				result = !isGlobalModuleType;
			}
			return result;
		}
	}
}
