using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace SimpleObfuscator.Core.Utils
{
	// Token: 0x02000003 RID: 3
	internal class Randoms
	{
		// Token: 0x06000004 RID: 4 RVA: 0x000020B8 File Offset: 0x000002B8
		public static string RandomString()
		{
			return new string((from s in Enumerable.Repeat<string>("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890", new Random().Next(10, 100))
			select s[new Random(Guid.NewGuid().GetHashCode()).Next(s.Length)]).ToArray<char>());
		}

		// Token: 0x06000005 RID: 5 RVA: 0x0000211C File Offset: 0x0000031C
		public static int RandomInt()
		{
			int seed = Convert.ToInt32(Regex.Match(Guid.NewGuid().ToString(), "\\d+").Value);
			return new Random(seed).Next(0, 99999999);
		}
	}
}
