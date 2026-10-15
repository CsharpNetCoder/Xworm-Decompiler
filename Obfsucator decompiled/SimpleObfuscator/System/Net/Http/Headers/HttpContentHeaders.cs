using System;
using System.Collections.Generic;

namespace System.Net.Http.Headers
{
	// Token: 0x020002F4 RID: 756
	public sealed class HttpContentHeaders : HttpHeaders
	{
		// Token: 0x17000A26 RID: 2598
		// (get) Token: 0x06002308 RID: 8968 RVA: 0x0007BBD8 File Offset: 0x00079DD8
		public ICollection<string> Allow
		{
			get
			{
				if (this.allow == null)
				{
					this.allow = new HttpHeaderValueCollection<string>("Allow", this, HeaderUtilities.TokenValidator);
				}
				return this.allow;
			}
		}

		// Token: 0x17000A27 RID: 2599
		// (get) Token: 0x06002309 RID: 8969 RVA: 0x0007BC04 File Offset: 0x00079E04
		// (set) Token: 0x0600230A RID: 8970 RVA: 0x0007BC18 File Offset: 0x00079E18
		public ContentDispositionHeaderValue ContentDisposition
		{
			get
			{
				return (ContentDispositionHeaderValue)base.GetParsedValues("Content-Disposition");
			}
			set
			{
				base.SetOrRemoveParsedValue("Content-Disposition", value);
			}
		}

		// Token: 0x17000A28 RID: 2600
		// (get) Token: 0x0600230B RID: 8971 RVA: 0x0007BC28 File Offset: 0x00079E28
		public ICollection<string> ContentEncoding
		{
			get
			{
				if (this.contentEncoding == null)
				{
					this.contentEncoding = new HttpHeaderValueCollection<string>("Content-Encoding", this, HeaderUtilities.TokenValidator);
				}
				return this.contentEncoding;
			}
		}

		// Token: 0x17000A29 RID: 2601
		// (get) Token: 0x0600230C RID: 8972 RVA: 0x0007BC54 File Offset: 0x00079E54
		public ICollection<string> ContentLanguage
		{
			get
			{
				if (this.contentLanguage == null)
				{
					this.contentLanguage = new HttpHeaderValueCollection<string>("Content-Language", this, HeaderUtilities.TokenValidator);
				}
				return this.contentLanguage;
			}
		}

		// Token: 0x17000A2A RID: 2602
		// (get) Token: 0x0600230D RID: 8973 RVA: 0x0007BC80 File Offset: 0x00079E80
		// (set) Token: 0x0600230E RID: 8974 RVA: 0x0007BCFC File Offset: 0x00079EFC
		public long? ContentLength
		{
			get
			{
				object parsedValues = base.GetParsedValues("Content-Length");
				if (!this.contentLengthSet && parsedValues == null)
				{
					long? result = this.calculateLengthFunc();
					if (result != null)
					{
						base.SetParsedValue("Content-Length", result.Value);
					}
					return result;
				}
				if (parsedValues == null)
				{
					return null;
				}
				return new long?((long)parsedValues);
			}
			set
			{
				base.SetOrRemoveParsedValue("Content-Length", value);
				this.contentLengthSet = true;
			}
		}

		// Token: 0x17000A2B RID: 2603
		// (get) Token: 0x0600230F RID: 8975 RVA: 0x0007BD18 File Offset: 0x00079F18
		// (set) Token: 0x06002310 RID: 8976 RVA: 0x0007BD2C File Offset: 0x00079F2C
		public Uri ContentLocation
		{
			get
			{
				return (Uri)base.GetParsedValues("Content-Location");
			}
			set
			{
				base.SetOrRemoveParsedValue("Content-Location", value);
			}
		}

		// Token: 0x17000A2C RID: 2604
		// (get) Token: 0x06002311 RID: 8977 RVA: 0x0007BD3C File Offset: 0x00079F3C
		// (set) Token: 0x06002312 RID: 8978 RVA: 0x0007BD50 File Offset: 0x00079F50
		public byte[] ContentMD5
		{
			get
			{
				return (byte[])base.GetParsedValues("Content-MD5");
			}
			set
			{
				base.SetOrRemoveParsedValue("Content-MD5", value);
			}
		}

		// Token: 0x17000A2D RID: 2605
		// (get) Token: 0x06002313 RID: 8979 RVA: 0x0007BD60 File Offset: 0x00079F60
		// (set) Token: 0x06002314 RID: 8980 RVA: 0x0007BD74 File Offset: 0x00079F74
		public ContentRangeHeaderValue ContentRange
		{
			get
			{
				return (ContentRangeHeaderValue)base.GetParsedValues("Content-Range");
			}
			set
			{
				base.SetOrRemoveParsedValue("Content-Range", value);
			}
		}

		// Token: 0x17000A2E RID: 2606
		// (get) Token: 0x06002315 RID: 8981 RVA: 0x0007BD84 File Offset: 0x00079F84
		// (set) Token: 0x06002316 RID: 8982 RVA: 0x0007BD98 File Offset: 0x00079F98
		public MediaTypeHeaderValue ContentType
		{
			get
			{
				return (MediaTypeHeaderValue)base.GetParsedValues("Content-Type");
			}
			set
			{
				base.SetOrRemoveParsedValue("Content-Type", value);
			}
		}

		// Token: 0x17000A2F RID: 2607
		// (get) Token: 0x06002317 RID: 8983 RVA: 0x0007BDA8 File Offset: 0x00079FA8
		// (set) Token: 0x06002318 RID: 8984 RVA: 0x0007BDB8 File Offset: 0x00079FB8
		public DateTimeOffset? Expires
		{
			get
			{
				return HeaderUtilities.GetDateTimeOffsetValue("Expires", this);
			}
			set
			{
				base.SetOrRemoveParsedValue("Expires", value);
			}
		}

		// Token: 0x17000A30 RID: 2608
		// (get) Token: 0x06002319 RID: 8985 RVA: 0x0007BDCC File Offset: 0x00079FCC
		// (set) Token: 0x0600231A RID: 8986 RVA: 0x0007BDDC File Offset: 0x00079FDC
		public DateTimeOffset? LastModified
		{
			get
			{
				return HeaderUtilities.GetDateTimeOffsetValue("Last-Modified", this);
			}
			set
			{
				base.SetOrRemoveParsedValue("Last-Modified", value);
			}
		}

		// Token: 0x0600231B RID: 8987 RVA: 0x0007BDF0 File Offset: 0x00079FF0
		internal HttpContentHeaders(Func<long?> calculateLengthFunc)
		{
			this.calculateLengthFunc = calculateLengthFunc;
			base.SetConfiguration(HttpContentHeaders.parserStore, HttpContentHeaders.invalidHeaders);
		}

		// Token: 0x0600231C RID: 8988 RVA: 0x0007BE10 File Offset: 0x0007A010
		static HttpContentHeaders()
		{
			HttpContentHeaders.parserStore.Add("Allow", GenericHeaderParser.TokenListParser);
			HttpContentHeaders.parserStore.Add("Content-Disposition", GenericHeaderParser.ContentDispositionParser);
			HttpContentHeaders.parserStore.Add("Content-Encoding", GenericHeaderParser.TokenListParser);
			HttpContentHeaders.parserStore.Add("Content-Language", GenericHeaderParser.TokenListParser);
			HttpContentHeaders.parserStore.Add("Content-Length", Int64NumberHeaderParser.Parser);
			HttpContentHeaders.parserStore.Add("Content-Location", UriHeaderParser.RelativeOrAbsoluteUriParser);
			HttpContentHeaders.parserStore.Add("Content-MD5", ByteArrayHeaderParser.Parser);
			HttpContentHeaders.parserStore.Add("Content-Range", GenericHeaderParser.ContentRangeParser);
			HttpContentHeaders.parserStore.Add("Content-Type", MediaTypeHeaderParser.SingleValueParser);
			HttpContentHeaders.parserStore.Add("Expires", DateHeaderParser.Parser);
			HttpContentHeaders.parserStore.Add("Last-Modified", DateHeaderParser.Parser);
			HttpContentHeaders.invalidHeaders = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
			HttpRequestHeaders.AddKnownHeaders(HttpContentHeaders.invalidHeaders);
			HttpResponseHeaders.AddKnownHeaders(HttpContentHeaders.invalidHeaders);
			HttpGeneralHeaders.AddKnownHeaders(HttpContentHeaders.invalidHeaders);
		}

		// Token: 0x0600231D RID: 8989 RVA: 0x0007BF3C File Offset: 0x0007A13C
		internal static void AddKnownHeaders(HashSet<string> headerSet)
		{
			headerSet.Add("Allow");
			headerSet.Add("Content-Disposition");
			headerSet.Add("Content-Encoding");
			headerSet.Add("Content-Language");
			headerSet.Add("Content-Length");
			headerSet.Add("Content-Location");
			headerSet.Add("Content-MD5");
			headerSet.Add("Content-Range");
			headerSet.Add("Content-Type");
			headerSet.Add("Expires");
			headerSet.Add("Last-Modified");
		}

		// Token: 0x0400103C RID: 4156
		private static readonly Dictionary<string, HttpHeaderParser> parserStore = new Dictionary<string, HttpHeaderParser>(StringComparer.OrdinalIgnoreCase);

		// Token: 0x0400103D RID: 4157
		private static readonly HashSet<string> invalidHeaders;

		// Token: 0x0400103E RID: 4158
		private Func<long?> calculateLengthFunc;

		// Token: 0x0400103F RID: 4159
		private bool contentLengthSet;

		// Token: 0x04001040 RID: 4160
		private HttpHeaderValueCollection<string> allow;

		// Token: 0x04001041 RID: 4161
		private HttpHeaderValueCollection<string> contentEncoding;

		// Token: 0x04001042 RID: 4162
		private HttpHeaderValueCollection<string> contentLanguage;
	}
}
