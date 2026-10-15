using System;
using dnlib.DotNet;
using SimpleObfuscator.Core.Protections;
using SimpleObfuscator.Core.Protections.AddRandoms;

namespace SimpleObfuscator
{
	// Token: 0x02000002 RID: 2
	public class Obfuscator
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002048 File Offset: 0x00000248
		public static string Save(byte[] Byte, string Path)
		{
			string result;
			try
			{
				ModuleDefMD moduleDefMD = ModuleDefMD.Load(Byte, null);
				Obfuscator.Execute(moduleDefMD);
				moduleDefMD.Write(Path);
				result = "Obfuscated!";
			}
			catch (Exception ex)
			{
				result = ex.Message;
			}
			return result;
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002098 File Offset: 0x00000298
		private static void Execute(ModuleDefMD module)
		{
			Renamer.Execute(module);
			RandomOutlinedMethods.Execute(module);
		}
	}
}
