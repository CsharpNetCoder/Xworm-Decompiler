using System;
using System.Linq;
using dnlib.DotNet;
using dnlib.DotNet.Emit;
using SimpleObfuscator.Core.Utils;

namespace SimpleObfuscator.Core.Protections.AddRandoms
{
	// Token: 0x0200000A RID: 10
	internal class RandomOutlinedMethods : Randoms
	{
		// Token: 0x06000014 RID: 20 RVA: 0x000025DC File Offset: 0x000007DC
		public static void Execute(ModuleDef module)
		{
			foreach (TypeDef typeDef in module.Types)
			{
				foreach (MethodDef source_method in typeDef.Methods.ToArray<MethodDef>())
				{
					MethodDef item = RandomOutlinedMethods.CreateReturnMethodDef(Randoms.RandomString(), source_method);
					MethodDef item2 = RandomOutlinedMethods.CreateReturnMethodDef(Randoms.RandomInt(), source_method);
					typeDef.Methods.Add(item);
					typeDef.Methods.Add(item2);
				}
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002698 File Offset: 0x00000898
		private static MethodDef CreateReturnMethodDef(object value, MethodDef source_method)
		{
			CorLibTypeSig retType = null;
			bool flag = value is int;
			if (flag)
			{
				retType = source_method.Module.CorLibTypes.Int32;
			}
			else
			{
				bool flag2 = value is float;
				if (flag2)
				{
					retType = source_method.Module.CorLibTypes.Single;
				}
				else
				{
					bool flag3 = value is string;
					if (flag3)
					{
						retType = source_method.Module.CorLibTypes.String;
					}
				}
			}
			MethodDef methodDef = new MethodDefUser(Randoms.RandomString(), MethodSig.CreateStatic(retType), MethodImplAttributes.IL, MethodAttributes.FamANDAssem | MethodAttributes.Family | MethodAttributes.Static | MethodAttributes.HideBySig)
			{
				Body = new CilBody()
			};
			bool flag4 = value is int;
			if (flag4)
			{
				methodDef.Body.Instructions.Add(Instruction.Create(OpCodes.Ldc_I4, (int)value));
			}
			else
			{
				bool flag5 = value is float;
				if (flag5)
				{
					methodDef.Body.Instructions.Add(Instruction.Create(OpCodes.Ldc_R4, (double)value));
				}
				else
				{
					bool flag6 = value is string;
					if (flag6)
					{
						methodDef.Body.Instructions.Add(Instruction.Create(OpCodes.Ldstr, (string)value));
					}
				}
			}
			methodDef.Body.Instructions.Add(new Instruction(OpCodes.Ret));
			return methodDef;
		}
	}
}
