using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Methods.Native
{
	// Token: 0x02000011 RID: 17
	internal class HandelNative
	{
		// Token: 0x06000065 RID: 101
		[DllImport("SHCore.dll", SetLastError = true)]
		public static extern int SetProcessDpiAwareness(int awareness);

		// Token: 0x06000066 RID: 102
		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		public static extern int GetSystemMetrics(int smIndex);

		// Token: 0x06000067 RID: 103
		[DllImport("user32.dll")]
		public static extern IntPtr GetWindowLong(IntPtr hWnd, int nIndex);

		// Token: 0x06000068 RID: 104
		[DllImport("dwmapi.dll", PreserveSig = false)]
		public static extern void DwmEnableComposition(bool bEnable);

		// Token: 0x06000069 RID: 105
		[DllImport("kernel32.dll")]
		public static extern bool CreateProcess(string lpApplicationName, string lpCommandLine, IntPtr lpProcessAttributes, IntPtr lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, IntPtr lpEnvironment, string lpCurrentDirectory, ref HandelNative.STARTUPINFO lpStartupInfo, ref HandelNative.PROCESS_INFORMATION lpProcessInformation);

		// Token: 0x0600006A RID: 106
		[DllImport("user32.dll")]
		public static extern IntPtr CreateDesktop(string lpszDesktop, IntPtr lpszDevice, IntPtr pDevmode, int dwFlags, long dwDesiredAccess, IntPtr lpsa);

		// Token: 0x0600006B RID: 107
		[DllImport("user32.dll")]
		public static extern IntPtr OpenDesktop(string lpszDesktop, int dwFlags, bool fInherit, long dwDesiredAccess);

		// Token: 0x0600006C RID: 108
		[DllImport("user32.dll")]
		public static extern int SetWindowLong(IntPtr hWnd, [MarshalAs(UnmanagedType.I4)] HandelNative.WindowLongFlags nIndex, int dwNewintptr);

		// Token: 0x0600006D RID: 109
		[DllImport("user32.dll")]
		public static extern bool SetThreadDesktop(IntPtr hDesktop);

		// Token: 0x0600006E RID: 110
		[DllImport("user32.dll")]
		public static extern bool CloseDesktop(IntPtr hDesktop);

		// Token: 0x0600006F RID: 111
		[DllImport("user32.dll")]
		public static extern IntPtr GetProcessWindowStation();

		// Token: 0x06000070 RID: 112
		[DllImport("user32.dll")]
		public static extern bool EnumDesktops(IntPtr hwinsta, HandelNative.EnumDesktopProc lpEnumFunc, IntPtr lParam);

		// Token: 0x06000071 RID: 113
		[DllImport("kernel32", CharSet = CharSet.Unicode)]
		public static extern bool DeleteFile(string name);

		// Token: 0x06000072 RID: 114
		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

		// Token: 0x06000073 RID: 115
		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		public static extern IntPtr FindWindowEx(IntPtr parentHandle, IntPtr childAfter, string lclassName, string windowTitle);

		// Token: 0x06000074 RID: 116
		[DllImport("user32.dll", EntryPoint = "FindWindowEx")]
		public static extern IntPtr FindWindowEx2(IntPtr hWnd1, IntPtr hWnd2, IntPtr lpsz1, string lpsz2);

		// Token: 0x06000075 RID: 117
		[DllImport("advapi32.dll")]
		public static extern bool GetCurrentHwProfile(IntPtr fProfile);

		// Token: 0x06000076 RID: 118
		[DllImport("user32.dll")]
		public static extern IntPtr GetForegroundWindow();

		// Token: 0x06000077 RID: 119
		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		public static extern IntPtr GetWindow(IntPtr hWnd, uint uCmd);

		// Token: 0x06000078 RID: 120
		[DllImport("user32.dll", EntryPoint = "GetWindowTextW")]
		public static extern int GetWindowText([In] IntPtr hWnd, [MarshalAs(UnmanagedType.LPWStr)] out StringBuilder lpString, int nMaxCount);

		// Token: 0x06000079 RID: 121
		[DllImport("winmm.dll")]
		public static extern int mciSendString(string command, string buffer, int bufferSize, IntPtr hwndCallback);

		// Token: 0x0600007A RID: 122
		[DllImport("user32.dll")]
		public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, int dwExtraInfo);

		// Token: 0x0600007B RID: 123
		[DllImport("Kernel32.dll")]
		public static extern bool QueryFullProcessImageName([In] IntPtr hProcess, [In] uint dwFlags, out StringBuilder lpExeName, out uint lpdwSize);

		// Token: 0x0600007C RID: 124
		[DllImport("user32.dll", CharSet = CharSet.Ansi)]
		public static extern IntPtr SendMessage(IntPtr hWnd, int hMsg, IntPtr wParam, IntPtr lParam);

		// Token: 0x0600007D RID: 125
		[DllImport("user32.dll")]
		public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

		// Token: 0x0600007E RID: 126
		[DllImport("kernel32.dll", EntryPoint = "Sleep")]
		public static extern void SleepThread(int ms);

		// Token: 0x0600007F RID: 127
		[DllImport("urlmon.dll", CharSet = CharSet.Auto)]
		public static extern int URLDownloadToFile([MarshalAs(UnmanagedType.IUnknown)] object pCaller, [MarshalAs(UnmanagedType.LPWStr)] string szURL, [MarshalAs(UnmanagedType.LPWStr)] string szFileName, int dwReserved, IntPtr lpfnCB);

		// Token: 0x06000080 RID: 128
		[DllImport("user32.dll")]
		public static extern IntPtr SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int x, int y, int cx, int cy, int wFlags);

		// Token: 0x04000032 RID: 50
		public static bool Right = false;

		// Token: 0x04000033 RID: 51
		public const int NORMAL_PRIORITY_CLASS = 32;

		// Token: 0x04000034 RID: 52
		public static List<int> m_lstProcessID = new List<int>();

		// Token: 0x04000035 RID: 53
		public const long DESKTOP_CREATEWINDOW = 2L;

		// Token: 0x04000036 RID: 54
		public const long DESKTOP_ENUMERATE = 64L;

		// Token: 0x04000037 RID: 55
		public const long DESKTOP_WRITEOBJECTS = 128L;

		// Token: 0x04000038 RID: 56
		public const long DESKTOP_SWITCHDESKTOP = 256L;

		// Token: 0x04000039 RID: 57
		public const long DESKTOP_CREATEMENU = 4L;

		// Token: 0x0400003A RID: 58
		public const long DESKTOP_HOOKCONTROL = 8L;

		// Token: 0x0400003B RID: 59
		public const long DESKTOP_READOBJECTS = 1L;

		// Token: 0x0400003C RID: 60
		public const long DESKTOP_JOURNALRECORD = 16L;

		// Token: 0x0400003D RID: 61
		public const long DESKTOP_JOURNALPLAYBACK = 32L;

		// Token: 0x0400003E RID: 62
		public const long AccessRights = 511L;

		// Token: 0x0400003F RID: 63
		public const short SWP_NOMOVE = 2;

		// Token: 0x04000040 RID: 64
		public const short SWP_NOSIZE = 1;

		// Token: 0x04000041 RID: 65
		public const short SWP_NOZORDER = 4;

		// Token: 0x04000042 RID: 66
		public const short SWP_SHOWWINDOW = 64;

		// Token: 0x04000043 RID: 67
		private readonly IntPtr HWND_BOTTOM = new IntPtr(1);

		// Token: 0x0200001F RID: 31
		public struct RECT
		{
			// Token: 0x04000069 RID: 105
			public int Left;

			// Token: 0x0400006A RID: 106
			public int Top;

			// Token: 0x0400006B RID: 107
			public int Right;

			// Token: 0x0400006C RID: 108
			public int Bottom;
		}

		// Token: 0x02000020 RID: 32
		public struct PROCESS_INFORMATION
		{
			// Token: 0x0400006D RID: 109
			public IntPtr hProcess;

			// Token: 0x0400006E RID: 110
			public IntPtr hThread;

			// Token: 0x0400006F RID: 111
			public int dwProcessId;

			// Token: 0x04000070 RID: 112
			public int dwThreadId;
		}

		// Token: 0x02000021 RID: 33
		public struct STARTUPINFO
		{
			// Token: 0x04000071 RID: 113
			public int cb;

			// Token: 0x04000072 RID: 114
			public string lpReserved;

			// Token: 0x04000073 RID: 115
			public string lpDesktop;

			// Token: 0x04000074 RID: 116
			public string lpTitle;

			// Token: 0x04000075 RID: 117
			public int dwX;

			// Token: 0x04000076 RID: 118
			public int dwY;

			// Token: 0x04000077 RID: 119
			public int dwXSize;

			// Token: 0x04000078 RID: 120
			public int dwYSize;

			// Token: 0x04000079 RID: 121
			public int dwXCountChars;

			// Token: 0x0400007A RID: 122
			public int dwYCountChars;

			// Token: 0x0400007B RID: 123
			public int dwFillAttribute;

			// Token: 0x0400007C RID: 124
			public int dwFlags;

			// Token: 0x0400007D RID: 125
			public short wShowWindow;

			// Token: 0x0400007E RID: 126
			public short cbReserved2;

			// Token: 0x0400007F RID: 127
			public IntPtr lpReserved2;

			// Token: 0x04000080 RID: 128
			public IntPtr hStdInput;

			// Token: 0x04000081 RID: 129
			public IntPtr hStdOutput;

			// Token: 0x04000082 RID: 130
			public IntPtr hStdError;
		}

		// Token: 0x02000022 RID: 34
		[Flags]
		internal enum DESKTOP_ACCESS : uint
		{
			// Token: 0x04000084 RID: 132
			DESKTOP_NONE = 0U,
			// Token: 0x04000085 RID: 133
			DESKTOP_READOBJECTS = 1U,
			// Token: 0x04000086 RID: 134
			DESKTOP_CREATEWINDOW = 2U,
			// Token: 0x04000087 RID: 135
			DESKTOP_CREATEMENU = 4U,
			// Token: 0x04000088 RID: 136
			DESKTOP_HOOKCONTROL = 8U,
			// Token: 0x04000089 RID: 137
			DESKTOP_JOURNALRECORD = 16U,
			// Token: 0x0400008A RID: 138
			DESKTOP_JOURNALPLAYBACK = 32U,
			// Token: 0x0400008B RID: 139
			DESKTOP_ENUMERATE = 64U,
			// Token: 0x0400008C RID: 140
			DESKTOP_WRITEOBJECTS = 128U,
			// Token: 0x0400008D RID: 141
			DESKTOP_SWITCHDESKTOP = 256U,
			// Token: 0x0400008E RID: 142
			GENERIC_ALL = 511U
		}

		// Token: 0x02000023 RID: 35
		[Flags]
		public enum MouseEventFlags : uint
		{
			// Token: 0x04000090 RID: 144
			MOUSEEVENTF_ABSOLUTE = 32768U,
			// Token: 0x04000091 RID: 145
			MOUSEEVENTF_LEFTDOWN = 2U,
			// Token: 0x04000092 RID: 146
			MOUSEEVENTF_LEFTUP = 4U,
			// Token: 0x04000093 RID: 147
			MOUSEEVENTF_MIDDLEDOWN = 32U,
			// Token: 0x04000094 RID: 148
			MOUSEEVENTF_MIDDLEUP = 64U,
			// Token: 0x04000095 RID: 149
			MOUSEEVENTF_MOVE = 1U,
			// Token: 0x04000096 RID: 150
			MOUSEEVENTF_RIGHTDOWN = 8U,
			// Token: 0x04000097 RID: 151
			MOUSEEVENTF_RIGHTUP = 16U,
			// Token: 0x04000098 RID: 152
			MOUSEEVENTF_XDOWN = 128U,
			// Token: 0x04000099 RID: 153
			MOUSEEVENTF_XUP = 256U,
			// Token: 0x0400009A RID: 154
			MOUSEEVENTF_WHEEL = 2048U,
			// Token: 0x0400009B RID: 155
			MOUSEEVENTF_HWHEEL = 4096U
		}

		// Token: 0x02000024 RID: 36
		public enum WindowLongFlags
		{
			// Token: 0x0400009D RID: 157
			DWLP_DLGPROC = 4,
			// Token: 0x0400009E RID: 158
			DWLP_MSGRESULT = 0,
			// Token: 0x0400009F RID: 159
			DWLP_USER = 8,
			// Token: 0x040000A0 RID: 160
			GWL_EXSTYLE = -20,
			// Token: 0x040000A1 RID: 161
			GWL_ID = -12,
			// Token: 0x040000A2 RID: 162
			GWL_STYLE = -16,
			// Token: 0x040000A3 RID: 163
			GWL_USERDATA = -21,
			// Token: 0x040000A4 RID: 164
			GWL_WNDPROC = -4,
			// Token: 0x040000A5 RID: 165
			GWLP_HINSTANCE = -6,
			// Token: 0x040000A6 RID: 166
			GWLP_HWNDPARENT = -8
		}

		// Token: 0x02000025 RID: 37
		// (Invoke) Token: 0x060000B2 RID: 178
		public delegate bool EnumDesktopProc(string lpszDesktop, IntPtr lParam);
	}
}
