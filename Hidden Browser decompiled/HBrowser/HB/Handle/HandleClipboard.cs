using System;
using System.Runtime.InteropServices;
using System.Text;
using HBrowser;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace HB.Handle
{
	// Token: 0x0200000B RID: 11
	public class HandleClipboard
	{
		// Token: 0x06000049 RID: 73
		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern bool PostMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

		// Token: 0x0600004A RID: 74 RVA: 0x00004268 File Offset: 0x00002468
		public static void Paste(string k)
		{
			string @string = Encoding.UTF8.GetString(Convert.FromBase64String(k));
			for (int i = 0; i < @string.Length; i++)
			{
				int num = Strings.AscW(@string[i].ToString());
				bool flag = num == 8 || num == 13;
				if (flag)
				{
					HandleClipboard.PostMessage(Helper.WindowrActive, 256U, (IntPtr)Conversions.ToInteger("&H" + Conversion.Hex(Strings.AscW(@string[i].ToString()))), HandleClipboard.CreateLParamFor_WM_KEYDOWN(1, 30, false, false));
					HandleClipboard.PostMessage(Helper.WindowrActive, 257U, (IntPtr)Conversions.ToInteger("&H" + Conversion.Hex(Strings.AscW(@string[i].ToString()))), HandleClipboard.CreateLParamFor_WM_KEYUP(1, 30, false));
				}
				else
				{
					HandleClipboard.PostMessage(Helper.WindowrActive, 258U, (IntPtr)Strings.AscW(@string[i].ToString()), (IntPtr)1);
				}
			}
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00004394 File Offset: 0x00002594
		public static IntPtr CreateLParamFor_WM_KEYUP(ushort RepeatCount, byte ScanCode, bool IsExtendedKey)
		{
			return HandleClipboard.KeysLParam(RepeatCount, ScanCode, IsExtendedKey, true, true);
		}

		// Token: 0x0600004C RID: 76 RVA: 0x000043B0 File Offset: 0x000025B0
		public static IntPtr CreateLParamFor_WM_KEYDOWN(ushort RepeatCount, byte ScanCode, bool IsExtendedKey, bool DownBefore)
		{
			return HandleClipboard.KeysLParam(RepeatCount, ScanCode, IsExtendedKey, DownBefore, false);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x000043CC File Offset: 0x000025CC
		public static IntPtr KeysLParam(ushort RepeatCount, byte ScanCode, bool IsExtendedKey, bool DownBefore, bool State)
		{
			int num = (int)(RepeatCount | (ushort)(ScanCode << 16));
			if (IsExtendedKey)
			{
				num |= 65536;
			}
			if (DownBefore)
			{
				num |= 1073741824;
			}
			if (State)
			{
				num = (int)((long)num | -2147483648L);
			}
			return new IntPtr(num);
		}
	}
}
