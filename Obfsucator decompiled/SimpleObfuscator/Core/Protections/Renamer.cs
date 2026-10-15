using System;
using dnlib.DotNet;
using SimpleObfuscator.Core.Protections.Analyzer;
using SimpleObfuscator.Core.Utils;

namespace SimpleObfuscator.Core.Protections
{
	// Token: 0x02000004 RID: 4
	internal class Renamer : Randoms
	{
		// Token: 0x06000007 RID: 7 RVA: 0x0000217C File Offset: 0x0000037C
		public static void Execute(ModuleDefMD module)
		{
			foreach (TypeDef typeDef in module.Types)
			{
				bool flag = Renamer.CanRename(typeDef);
				if (flag)
				{
					typeDef.Name = Randoms.RandomString();
				}
				foreach (MethodDef methodDef in typeDef.Methods)
				{
					bool flag2 = Renamer.CanRename(methodDef);
					if (flag2)
					{
						methodDef.Name = Randoms.RandomString();
					}
					foreach (Parameter parameter in methodDef.Parameters)
					{
						parameter.Name = Randoms.RandomString();
					}
				}
				foreach (PropertyDef propertyDef in typeDef.Properties)
				{
					bool flag3 = Renamer.CanRename(propertyDef);
					if (flag3)
					{
						propertyDef.Name = Randoms.RandomString();
					}
				}
				foreach (FieldDef fieldDef in typeDef.Fields)
				{
					bool flag4 = Renamer.CanRename(fieldDef);
					if (flag4)
					{
						fieldDef.Name = Randoms.RandomString();
					}
				}
			}
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000023BC File Offset: 0x000005BC
		public static bool CanRename(object obj)
		{
			iAnalyze iAnalyze = null;
			bool flag = obj is TypeDef;
			if (flag)
			{
				iAnalyze = new TypeDefAnalyzer();
			}
			else
			{
				bool flag2 = obj is MethodDef;
				if (flag2)
				{
					iAnalyze = new MethodDefAnalyzer();
				}
				else
				{
					bool flag3 = obj is EventDef;
					if (flag3)
					{
						iAnalyze = new EventDefAnalyzer();
					}
					else
					{
						bool flag4 = obj is FieldDef;
						if (flag4)
						{
							iAnalyze = new FieldDefAnalyzer();
						}
					}
				}
			}
			bool flag5 = iAnalyze == null;
			return !flag5 && iAnalyze.Execute(obj);
		}
	}
}
