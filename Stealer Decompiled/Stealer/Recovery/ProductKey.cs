using System;
using Microsoft.Win32;

namespace Recovery
{
	// Token: 0x02000007 RID: 7
	internal class ProductKey
	{
		// Token: 0x06000011 RID: 17 RVA: 0x00002F74 File Offset: 0x00001174
		public static string GetProductKey()
		{
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32);
			bool is64BitOperatingSystem = Environment.Is64BitOperatingSystem;
			if (is64BitOperatingSystem)
			{
				registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
			}
			object value = registryKey.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion").GetValue("DigitalProductId");
			bool flag = value == null;
			string result;
			if (flag)
			{
				result = "Failed to get DigitalProductId from registry";
			}
			else
			{
				byte[] digitalProductId = (byte[])value;
				result = ProductKey.DecodeProductKey(digitalProductId);
			}
			return result;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002FF8 File Offset: 0x000011F8
		private static string DecodeProductKey(byte[] digitalProductId)
		{
			string text = string.Empty;
			byte b = digitalProductId[66] / 6 & 1;
			digitalProductId[66] = ((digitalProductId[66] & 247) | (b & 2) * 4);
			int num = 0;
			for (int i = 24; i >= 0; i--)
			{
				int num2 = 0;
				for (int j = 14; j >= 0; j--)
				{
					num2 *= 256;
					num2 = (int)digitalProductId[j + 52] + num2;
					digitalProductId[j + 52] = (byte)(num2 / 24);
					num2 %= 24;
					num = num2;
				}
				text = "BCDFGHJKMPQRTVWXY2346789"[num2].ToString() + text;
			}
			string str = text.Substring(1, num);
			string str2 = text.Substring(num + 1, text.Length - (num + 1));
			text = str + "N" + str2;
			for (int k = 5; k < text.Length; k += 6)
			{
				text = text.Insert(k, "-");
			}
			return text;
		}
	}
}
