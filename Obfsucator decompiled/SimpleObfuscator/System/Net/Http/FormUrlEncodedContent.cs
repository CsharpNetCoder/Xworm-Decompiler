using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace System.Net.Http
{
	// Token: 0x020002E6 RID: 742
	public class FormUrlEncodedContent : ByteArrayContent
	{
		// Token: 0x06002212 RID: 8722 RVA: 0x0007705C File Offset: 0x0007525C
		public FormUrlEncodedContent(IEnumerable<KeyValuePair<string, string>> nameValueCollection) : base(FormUrlEncodedContent.GetContentByteArray(nameValueCollection))
		{
			base.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");
		}

		// Token: 0x06002213 RID: 8723 RVA: 0x00077080 File Offset: 0x00075280
		private static byte[] GetContentByteArray(IEnumerable<KeyValuePair<string, string>> nameValueCollection)
		{
			if (nameValueCollection == null)
			{
				throw new ArgumentNullException("nameValueCollection");
			}
			StringBuilder stringBuilder = new StringBuilder();
			foreach (KeyValuePair<string, string> keyValuePair in nameValueCollection)
			{
				if (stringBuilder.Length > 0)
				{
					stringBuilder.Append('&');
				}
				stringBuilder.Append(FormUrlEncodedContent.Encode(keyValuePair.Key));
				stringBuilder.Append('=');
				stringBuilder.Append(FormUrlEncodedContent.Encode(keyValuePair.Value));
			}
			return HttpRuleParser.DefaultHttpEncoding.GetBytes(stringBuilder.ToString());
		}

		// Token: 0x06002214 RID: 8724 RVA: 0x00077138 File Offset: 0x00075338
		private static string Encode(string data)
		{
			if (string.IsNullOrEmpty(data))
			{
				return string.Empty;
			}
			return Uri.EscapeDataString(data).Replace("%20", "+");
		}
	}
}
