using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;

namespace Plugin
{
	// Token: 0x0200000D RID: 13
	public class N
	{
		// Token: 0x0600002B RID: 43 RVA: 0x000033E8 File Offset: 0x000015E8
		[DebuggerNonUserCode]
		public N()
		{
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000033F4 File Offset: 0x000015F4
		private IntPtr GetRegistryKeyHandle(RegistryKey RegisteryKey)
		{
			SafeHandle safeHandle = (SafeHandle)Type.GetType("Microsoft.Win32.RegistryKey").GetField("hkey", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(RegisteryKey);
			safeHandle.DangerousGetHandle();
			return safeHandle.DangerousGetHandle();
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00003438 File Offset: 0x00001638
		public RegistryKey OpenSubKey(RegistryKey ParentKey, string SubKeyName, bool Writeable, N.RegWow64Options Options)
		{
			bool flag = ParentKey == null || this.GetRegistryKeyHandle(ParentKey).Equals(IntPtr.Zero);
			bool flag2 = flag;
			if (flag2)
			{
				throw new Exception("OpenSubKey: Parent key is not open");
			}
			int num = 131097;
			if (Writeable)
			{
				num = 131078;
			}
			int value;
			int num2 = N.RegOpenKeyEx(this.GetRegistryKeyHandle(ParentKey), ref SubKeyName, 0, num | (int)Options, ref value);
			flag = (num2 != 0);
			bool flag3 = flag;
			if (flag3)
			{
				Win32Exception innerException = new Win32Exception();
				throw new Exception("OpenSubKey: Exception encountered opening key", innerException);
			}
			return this.PointerToRegistryKey((IntPtr)value, Writeable, false);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000034E0 File Offset: 0x000016E0
		private RegistryKey PointerToRegistryKey(IntPtr hKey, bool writable, bool ownsHandle)
		{
			Type type = typeof(SafeHandleZeroOrMinusOneIsInvalid).Assembly.GetType("Microsoft.Win32.SafeHandles.SafeRegistryHandle");
			Type[] types = new Type[]
			{
				typeof(IntPtr),
				typeof(bool)
			};
			object objectValue = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(type.GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic, null, types, null).Invoke(new object[]
			{
				hKey,
				ownsHandle
			})))));
			Type typeFromHandle = typeof(RegistryKey);
			Type[] types2 = new Type[]
			{
				type,
				typeof(bool)
			};
			return (RegistryKey)typeFromHandle.GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic, null, types2, null).Invoke(new object[]
			{
				RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(objectValue))),
				writable
			});
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000035C8 File Offset: 0x000017C8
		private static int RegOpenKeyEx(IntPtr hKey, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpSubKey, int ulOptions, int samDesired, ref int phkResult)
		{
			int result;
			return result;
		}

		// Token: 0x02000011 RID: 17
		private enum RegistryRights
		{
			// Token: 0x0400001D RID: 29
			ReadKey = 131097,
			// Token: 0x0400001E RID: 30
			WriteKey = 131078
		}

		// Token: 0x02000012 RID: 18
		public enum RegWow64Options
		{
			// Token: 0x04000020 RID: 32
			KEY_WOW64_32KEY = 512,
			// Token: 0x04000021 RID: 33
			KEY_WOW64_64KEY = 256,
			// Token: 0x04000022 RID: 34
			None = 0
		}
	}
}
