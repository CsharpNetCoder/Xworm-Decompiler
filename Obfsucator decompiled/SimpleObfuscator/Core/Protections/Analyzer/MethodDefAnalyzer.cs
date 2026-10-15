using System;
using dnlib.DotNet;

namespace SimpleObfuscator.Core.Protections.Analyzer
{
	// Token: 0x02000008 RID: 8
	public class MethodDefAnalyzer : iAnalyze
	{
		// Token: 0x06000010 RID: 16 RVA: 0x00002528 File Offset: 0x00000728
		public override bool Execute(object context)
		{
			MethodDef methodDef = (MethodDef)context;
			bool isRuntimeSpecialName = methodDef.IsRuntimeSpecialName;
			bool result;
			if (isRuntimeSpecialName)
			{
				result = false;
			}
			else
			{
				bool isForwarder = methodDef.DeclaringType.IsForwarder;
				result = !isForwarder;
			}
			return result;
		}
	}
}
