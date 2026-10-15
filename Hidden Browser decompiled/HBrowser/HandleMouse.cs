using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using HBrowser;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

// Token: 0x02000004 RID: 4
internal class HandleMouse
{
	// Token: 0x06000012 RID: 18
	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern int SendMessage(IntPtr hWnd, uint Msg, int wParam, string lParam);

	// Token: 0x06000013 RID: 19 RVA: 0x00002C1C File Offset: 0x00000E1C
	public static void Copy(string hParent)
	{
		bool flag = !Helper.WindowrActive.Equals(IntPtr.Zero);
		if (flag)
		{
			int num = HandleMouse.SendMessage(Helper.WindowrActive, 14U, 0, null);
			string lParam = Strings.Space(num + 1);
			HandleMouse.SendMessage(Helper.WindowrActive, 13U, num + 1, lParam);
		}
	}

	// Token: 0x06000014 RID: 20
	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern bool PostMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

	// Token: 0x06000015 RID: 21
	[DllImport("user32.dll")]
	private static extern bool GetWindowRect(IntPtr hWnd, ref HandleMouse.RECT lpRect);

	// Token: 0x06000016 RID: 22 RVA: 0x00002C74 File Offset: 0x00000E74
	public static int MakeLParam(int LoWord, int HiWord)
	{
		return HiWord << 16 | (LoWord & 65535);
	}

	// Token: 0x06000017 RID: 23 RVA: 0x00002C94 File Offset: 0x00000E94
	public static void MouseLeftDown(int x, int y)
	{
		HandleMouse.RECT rect = default(HandleMouse.RECT);
		HandleMouse.GetWindowRect(Helper.WindowrActive, ref rect);
		Point point = new Point(10000 + x - rect.Left, 10000 + y - rect.Top);
		HandleMouse.PostMessage(Helper.WindowrActive, 513U, (IntPtr)0, (IntPtr)HandleMouse.MakeLParam(point.X, point.Y));
	}

	// Token: 0x06000018 RID: 24 RVA: 0x00002D08 File Offset: 0x00000F08
	public static void MouseLeftUp(int x, int y)
	{
		HandleMouse.RECT rect = default(HandleMouse.RECT);
		HandleMouse.GetWindowRect(Helper.WindowrActive, ref rect);
		Point point = new Point(10000 + x - rect.Left, 10000 + y - rect.Top);
		HandleMouse.PostMessage(Helper.WindowrActive, 514U, (IntPtr)0, (IntPtr)HandleMouse.MakeLParam(point.X, point.Y));
	}

	// Token: 0x06000019 RID: 25 RVA: 0x00002D7C File Offset: 0x00000F7C
	public static void MouseRightDown(int x, int y)
	{
		HandleMouse.RECT rect = default(HandleMouse.RECT);
		HandleMouse.GetWindowRect(Helper.WindowrActive, ref rect);
		Point point = new Point(10000 + x - rect.Left, 10000 + y - rect.Top);
		HandleMouse.PostMessage(Helper.WindowrActive, 516U, (IntPtr)0, (IntPtr)HandleMouse.MakeLParam(x - rect.Left, y - rect.Top));
	}

	// Token: 0x0600001A RID: 26 RVA: 0x00002DF4 File Offset: 0x00000FF4
	public static void MouseRghitUp(int x, int y)
	{
		HandleMouse.RECT rect = default(HandleMouse.RECT);
		HandleMouse.GetWindowRect(Helper.WindowrActive, ref rect);
		Point point = new Point(10000 + x - rect.Left, 10000 + y - rect.Top);
		HandleMouse.PostMessage(Helper.WindowrActive, 517U, (IntPtr)0, (IntPtr)HandleMouse.MakeLParam(x - rect.Left, y - rect.Top));
	}

	// Token: 0x0600001B RID: 27 RVA: 0x00002E6C File Offset: 0x0000106C
	public static void MouseMove(int x, int y)
	{
		HandleMouse.RECT rect = default(HandleMouse.RECT);
		HandleMouse.GetWindowRect(Helper.WindowrActive, ref rect);
		Point point = new Point(10000 + x - rect.Left, 10000 + y - rect.Top);
		HandleMouse.PostMessage(Helper.WindowrActive, 512U, (IntPtr)0, (IntPtr)HandleMouse.MakeLParam(x - rect.Left, y - rect.Top));
	}

	// Token: 0x0600001C RID: 28 RVA: 0x00002EE4 File Offset: 0x000010E4
	public static IntPtr CreateLParamFor_WM_KEYDOWN(ushort RepeatCount, byte ScanCode, bool IsExtendedKey, bool DownBefore)
	{
		return HandleMouse.KeysLParam(RepeatCount, ScanCode, IsExtendedKey, DownBefore, false);
	}

	// Token: 0x0600001D RID: 29 RVA: 0x00002F00 File Offset: 0x00001100
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

	// Token: 0x0600001E RID: 30 RVA: 0x00002F54 File Offset: 0x00001154
	public static void KeyboardDown(string k)
	{
		string @string = Encoding.UTF8.GetString(Convert.FromBase64String(k));
		int num = Strings.AscW(@string);
		bool flag = num == 8 || num == 13;
		if (flag)
		{
			HandleMouse.PostMessage(Helper.WindowrActive, 256U, (IntPtr)Conversions.ToInteger("&H" + Conversion.Hex(Strings.AscW(@string))), HandleMouse.CreateLParamFor_WM_KEYDOWN(1, 30, false, false));
			HandleMouse.PostMessage(Helper.WindowrActive, 257U, (IntPtr)Conversions.ToInteger("&H" + Conversion.Hex(Strings.AscW(@string))), HandleMouse.CreateLParamFor_WM_KEYUP(1, 30, false));
		}
		else
		{
			HandleMouse.PostMessage(Helper.WindowrActive, 258U, (IntPtr)Strings.AscW(@string), (IntPtr)1);
		}
	}

	// Token: 0x0600001F RID: 31 RVA: 0x00003024 File Offset: 0x00001224
	public static IntPtr CreateLParamFor_WM_KEYUP(ushort RepeatCount, byte ScanCode, bool IsExtendedKey)
	{
		return HandleMouse.KeysLParam(RepeatCount, ScanCode, IsExtendedKey, true, true);
	}

	// Token: 0x04000004 RID: 4
	private const int WM_SETTEXT = 12;

	// Token: 0x04000005 RID: 5
	private const int WM_GETTEXT = 13;

	// Token: 0x04000006 RID: 6
	private const int WM_GETTEXTLENGTH = 14;

	// Token: 0x0200000F RID: 15
	public struct RECT
	{
		// Token: 0x04000030 RID: 48
		public int Left;

		// Token: 0x04000031 RID: 49
		public int Top;

		// Token: 0x04000032 RID: 50
		public int Right;

		// Token: 0x04000033 RID: 51
		public int Bottom;
	}
}
