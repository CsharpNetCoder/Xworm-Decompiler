using System;
using dnlib.DotNet;

namespace SimpleObfuscator.Core.Protections.Analyzer
{
	// Token: 0x02000005 RID: 5
	public class EventDefAnalyzer : iAnalyze
	{
		// Token: 0x0600000A RID: 10 RVA: 0x0000246C File Offset: 0x0000066C
		public override bool Execute(object context)
		{
			EventDef eventDef = (EventDef)context;
			bool isRuntimeSpecialName = eventDef.IsRuntimeSpecialName;
			return !isRuntimeSpecialName;
		}
	}
}
