using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace XWorm
{
	// Token: 0x0200004A RID: 74
	public class SettingsHelper
	{
		// Token: 0x06000A5A RID: 2650 RVA: 0x00061688 File Offset: 0x0005F888
		public static string NerakarWashen(string proj, string key)
		{
			string text = "";
			int length = proj.Length;
			checked
			{
				for (int i = 1; i <= length; i++)
				{
					int charCode = (int)(Strings.GetChar(proj, i) - Strings.GetChar(key, i % key.Length + 1));
					text += Conversions.ToString(Strings.ChrW(charCode));
				}
				return text;
			}
		}

		// Token: 0x06000A5B RID: 2651 RVA: 0x000616E4 File Offset: 0x0005F8E4
		public static void SaveToRegistry()
		{
			try
			{
				RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Default);
				RegistryKey registryKey2 = registryKey.CreateSubKey(SettingsHelper.RegSave);
				registryKey2.SetValue("IP", SettingsHelper.IP);
				registryKey2.SetValue("Port", SettingsHelper.Port);
				registryKey2.SetValue("User", SettingsHelper.User);
				registryKey2.SetValue("LicenseExpire", SettingsHelper.LicenseExpire);
				registryKey2.SetValue("AppName", SettingsHelper.name);
				registryKey2.SetValue("OwnerId", SettingsHelper.ownerid);
				registryKey2.SetValue("Secret", SettingsHelper.secret);
				registryKey2.SetValue("Version", SettingsHelper.version);
				registryKey2.Close();
				registryKey.Close();
			}
			catch (Exception ex)
			{
				Interaction.MsgBox("Failed to save settings to registry: " + ex.Message, MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x06000A5C RID: 2652 RVA: 0x000617E0 File Offset: 0x0005F9E0
		public static void LoadFromRegistry()
		{
			try
			{
				RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Default);
				RegistryKey registryKey2 = registryKey.OpenSubKey(SettingsHelper.RegSave);
				bool flag = registryKey2 != null;
				if (flag)
				{
					SettingsHelper.IP = registryKey2.GetValue("IP", "").ToString();
					SettingsHelper.Port = Convert.ToInt32(RuntimeHelpers.GetObjectValue(registryKey2.GetValue("Port", 0)));
					SettingsHelper.User = registryKey2.GetValue("User", "").ToString();
					SettingsHelper.LicenseExpire = registryKey2.GetValue("LicenseExpire", "").ToString();
					SettingsHelper.name = registryKey2.GetValue("AppName", "").ToString();
					SettingsHelper.ownerid = registryKey2.GetValue("OwnerId", "").ToString();
					SettingsHelper.secret = registryKey2.GetValue("Secret", "").ToString();
					SettingsHelper.version = registryKey2.GetValue("Version", "").ToString();
					registryKey2.Close();
				}
				registryKey.Close();
			}
			catch (Exception ex)
			{
				Interaction.MsgBox("Failed to load settings from registry: " + ex.Message, MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x04000465 RID: 1125
		public static int Port;

		// Token: 0x04000466 RID: 1126
		public static readonly string SPL = "<XWormmm>";

		// Token: 0x04000467 RID: 1127
		public static string KEY;

		// Token: 0x04000468 RID: 1128
		public static string IP;

		// Token: 0x04000469 RID: 1129
		public static bool NOTEF;

		// Token: 0x0400046A RID: 1130
		public static string User;

		// Token: 0x0400046B RID: 1131
		public static bool Screens = false;

		// Token: 0x0400046C RID: 1132
		public static List<Client> Online = new List<Client>();

		// Token: 0x0400046D RID: 1133
		public static List<string> Blocked = new List<string>();

		// Token: 0x0400046E RID: 1134
		public static string RegSave = "Software\\xXWormV6Xx";

		// Token: 0x0400046F RID: 1135
		public static object ListViewSafeThreading = RuntimeHelpers.GetObjectValue(new object());

		// Token: 0x04000470 RID: 1136
		public static string LicenseExpire;

		// Token: 0x04000471 RID: 1137
		public static long Received = 0L;

		// Token: 0x04000472 RID: 1138
		public static long Sent = 0L;

		// Token: 0x04000473 RID: 1139
		public static int MSGS = 0;

		// Token: 0x04000474 RID: 1140
		private static string name;

		// Token: 0x04000475 RID: 1141
		private static string ownerid;

		// Token: 0x04000476 RID: 1142
		private static string secret;

		// Token: 0x04000477 RID: 1143
		private static string version;
	}
}
