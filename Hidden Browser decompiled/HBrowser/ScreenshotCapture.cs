using System;
using System.Drawing;
using System.Runtime.InteropServices;
using HBrowser;

// Token: 0x02000005 RID: 5
internal sealed class ScreenshotCapture
{
	// Token: 0x06000021 RID: 33 RVA: 0x0000304C File Offset: 0x0000124C
	public static Bitmap CaptureWindow(IntPtr handle)
	{
		ScreenshotCapture.User32.Rect rect = default(ScreenshotCapture.User32.Rect);
		ScreenshotCapture.User32.GetWindowRect(handle, ref rect);
		int num = rect.right - rect.left;
		int num2 = rect.bottom - rect.top;
		int x = Helper.X;
		int y = Helper.Y;
		Bitmap bitmap = (!Helper.Resize) ? new Bitmap(num + 1, num2 + 1) : new Bitmap(x + 1, y + 1);
		using (Graphics graphics = Graphics.FromImage(bitmap))
		{
			IntPtr hdc = graphics.GetHdc();
			ScreenshotCapture.User32.PrintWindow(handle, hdc, 2U);
		}
		return bitmap;
	}

	// Token: 0x02000010 RID: 16
	private class User32
	{
		// Token: 0x0600005A RID: 90
		[DllImport("user32.dll")]
		public static extern IntPtr GetWindowRect(IntPtr hWnd, ref ScreenshotCapture.User32.Rect rect);

		// Token: 0x0600005B RID: 91
		[DllImport("user32.dll")]
		public static extern bool PrintWindow(IntPtr hwnd, IntPtr hdcBlt, uint nFlags);

		// Token: 0x02000012 RID: 18
		public struct Rect
		{
			// Token: 0x04000038 RID: 56
			public int left;

			// Token: 0x04000039 RID: 57
			public int top;

			// Token: 0x0400003A RID: 58
			public int right;

			// Token: 0x0400003B RID: 59
			public int bottom;
		}
	}
}
