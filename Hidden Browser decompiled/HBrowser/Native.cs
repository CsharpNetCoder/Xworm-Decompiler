using System;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;

// Token: 0x02000002 RID: 2
public static class Native
{
	// Token: 0x06000001 RID: 1
	[DllImport("user32.dll", SetLastError = true)]
	public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, Native.SetWindowPosFlags uFlags);

	// Token: 0x06000002 RID: 2
	[DllImport("user32")]
	public static extern int GetWindowThreadProcessId(IntPtr hWnd, out int processId);

	// Token: 0x06000003 RID: 3 RVA: 0x00002050 File Offset: 0x00000250
	public static string GetMainModuleFilepath(int id)
	{
		string queryString = "SELECT ProcessId, ExecutablePath FROM Win32_Process WHERE ProcessId = " + id.ToString();
		using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(queryString))
		{
			ManagementObjectCollection source = managementObjectSearcher.Get();
			ManagementObject managementObject = source.Cast<ManagementObject>().FirstOrDefault<ManagementObject>();
			bool flag = managementObject != null;
			if (flag)
			{
				return Convert.ToString(managementObject["ExecutablePath"]);
			}
		}
		return null;
	}

	// Token: 0x0200000D RID: 13
	[Flags]
	public enum SetWindowPosFlags : uint
	{
		// Token: 0x0400001B RID: 27
		AsynchronousWindowPosition = 16384U,
		// Token: 0x0400001C RID: 28
		DeferErase = 8192U,
		// Token: 0x0400001D RID: 29
		DrawFrame = 32U,
		// Token: 0x0400001E RID: 30
		FrameChanged = 32U,
		// Token: 0x0400001F RID: 31
		HideWindow = 128U,
		// Token: 0x04000020 RID: 32
		DoNotActivate = 16U,
		// Token: 0x04000021 RID: 33
		DoNotCopyBits = 256U,
		// Token: 0x04000022 RID: 34
		IgnoreMove = 2U,
		// Token: 0x04000023 RID: 35
		DoNotChangeOwnerZOrder = 512U,
		// Token: 0x04000024 RID: 36
		DoNotRedraw = 8U,
		// Token: 0x04000025 RID: 37
		DoNotReposition = 512U,
		// Token: 0x04000026 RID: 38
		DoNotSendChangingEvent = 1024U,
		// Token: 0x04000027 RID: 39
		IgnoreResize = 1U,
		// Token: 0x04000028 RID: 40
		IgnoreZOrder = 4U,
		// Token: 0x04000029 RID: 41
		ShowWindow = 64U
	}
}
