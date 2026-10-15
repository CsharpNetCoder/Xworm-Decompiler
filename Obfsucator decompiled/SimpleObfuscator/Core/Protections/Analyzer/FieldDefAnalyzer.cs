using System;
using dnlib.DotNet;

namespace SimpleObfuscator.Core.Protections.Analyzer
{
	// Token: 0x02000006 RID: 6
	public class FieldDefAnalyzer : iAnalyze
	{
		// Token: 0x0600000C RID: 12 RVA: 0x000024B0 File Offset: 0x000006B0
		public override bool Execute(object context)
		{
			FieldDef fieldDef = (FieldDef)context;
			bool isRuntimeSpecialName = fieldDef.IsRuntimeSpecialName;
			bool result;
			if (isRuntimeSpecialName)
			{
				result = false;
			}
			else
			{
				bool flag = fieldDef.IsLiteral && fieldDef.DeclaringType.IsEnum;
				result = !flag;
			}
			return result;
		}
	}
}
