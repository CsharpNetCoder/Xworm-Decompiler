using System;
using System.Net.Http.Headers;
using System.Text;

namespace System.Net.Http
{
	// Token: 0x02000320 RID: 800
	public class StringContent : ByteArrayContent
	{
		// Token: 0x06002593 RID: 9619 RVA: 0x00084DCC File Offset: 0x00082FCC
		public StringContent(string content) : this(content, null, null)
		{
		}

		// Token: 0x06002594 RID: 9620 RVA: 0x00084DD8 File Offset: 0x00082FD8
		public StringContent(string content, Encoding encoding) : this(content, encoding, null)
		{
		}

		// Token: 0x06002595 RID: 9621 RVA: 0x00084DE4 File Offset: 0x00082FE4
		public StringContent(string content, Encoding encoding, string mediaType) : base(StringContent.GetContentByteArray(content, encoding))
		{
			MediaTypeHeaderValue mediaTypeHeaderValue = new MediaTypeHeaderValue((mediaType == null) ? "text/plain" : mediaType);
			mediaTypeHeaderValue.CharSet = ((encoding == null) ? HttpContent.DefaultStringEncoding.WebName : encoding.WebName);
			base.Headers.ContentType = mediaTypeHeaderValue;
		}

		// Token: 0x06002596 RID: 9622 RVA: 0x00084E48 File Offset: 0x00083048
		private static byte[] GetContentByteArray(string content, Encoding encoding)
		{
			if (content == null)
			{
				throw new ArgumentNullException("content");
			}
			if (encoding == null)
			{
				encoding = HttpContent.DefaultStringEncoding;
			}
			return encoding.GetBytes(content);
		}

		// Token: 0x04001104 RID: 4356
		private const string defaultMediaType = "text/plain";
	}
}
