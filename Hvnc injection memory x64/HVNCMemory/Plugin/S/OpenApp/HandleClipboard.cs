using System;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Plugin.S.OpenApp
{
	// Token: 0x02000007 RID: 7
	public class HandleClipboard
	{
		// Token: 0x06000042 RID: 66
		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern bool PostMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

		// Token: 0x06000043 RID: 67 RVA: 0x00003264 File Offset: 0x00001464
		public static void Paste(string k)
		{
			string @string = Encoding.UTF8.GetString(Convert.FromBase64String(k));
			for (int i = 0; i < @string.Length; i++)
			{
				int num = Strings.AscW(@string[i].ToString());
				bool flag = num == 8 || num == 13;
				if (flag)
				{
					HandleClipboard.PostMessage(HandelMouse.ActiveHandel, 256U, (IntPtr)Conversions.ToInteger("&H" + Conversion.Hex(Strings.AscW(@string[i].ToString()))), HandleClipboard.CreateLParamFor_WM_KEYDOWN(1, 30, false, false));
					HandleClipboard.PostMessage(HandelMouse.ActiveHandel, 257U, (IntPtr)Conversions.ToInteger("&H" + Conversion.Hex(Strings.AscW(@string[i].ToString()))), HandleClipboard.CreateLParamFor_WM_KEYUP(1, 30, false));
				}
				else
				{
					HandleClipboard.PostMessage(HandelMouse.ActiveHandel, 258U, (IntPtr)Strings.AscW(@string[i].ToString()), (IntPtr)1);
				}
			}
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00003390 File Offset: 0x00001590
		public static IntPtr CreateLParamFor_WM_KEYUP(ushort RepeatCount, byte ScanCode, bool IsExtendedKey)
		{
			return HandleClipboard.KeysLParam(RepeatCount, ScanCode, IsExtendedKey, true, true);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x000033AC File Offset: 0x000015AC
		public static IntPtr CreateLParamFor_WM_KEYDOWN(ushort RepeatCount, byte ScanCode, bool IsExtendedKey, bool DownBefore)
		{
			return HandleClipboard.KeysLParam(RepeatCount, ScanCode, IsExtendedKey, DownBefore, false);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x000033C8 File Offset: 0x000015C8
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
