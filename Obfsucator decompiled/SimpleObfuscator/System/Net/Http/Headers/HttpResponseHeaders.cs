using System;
using System.Collections.Generic;

namespace System.Net.Http.Headers
{
	// Token: 0x020002F8 RID: 760
	public sealed class HttpResponseHeaders : HttpHeaders
	{
		// Token: 0x17000A61 RID: 2657
		// (get) Token: 0x0600237C RID: 9084 RVA: 0x0007CF84 File Offset: 0x0007B184
		public HttpHeaderValueCollection<string> AcceptRanges
		{
			get
			{
				if (this.acceptRanges == null)
				{
					this.acceptRanges = new HttpHeaderValueCollection<string>("Accept-Ranges", this, HeaderUtilities.TokenValidator);
				}
				return this.acceptRanges;
			}
		}

		// Token: 0x17000A62 RID: 2658
		// (get) Token: 0x0600237D RID: 9085 RVA: 0x0007CFB0 File Offset: 0x0007B1B0
		// (set) Token: 0x0600237E RID: 9086 RVA: 0x0007CFC0 File Offset: 0x0007B1C0
		public TimeSpan? Age
		{
			get
			{
				return HeaderUtilities.GetTimeSpanValue("Age", this);
			}
			set
			{
				base.SetOrRemoveParsedValue("Age", value);
			}
		}

		// Token: 0x17000A63 RID: 2659
		// (get) Token: 0x0600237F RID: 9087 RVA: 0x0007CFD4 File Offset: 0x0007B1D4
		// (set) Token: 0x06002380 RID: 9088 RVA: 0x0007CFE8 File Offset: 0x0007B1E8
		public EntityTagHeaderValue ETag
		{
			get
			{
				return (EntityTagHeaderValue)base.GetParsedValues("ETag");
			}
			set
			{
				base.SetOrRemoveParsedValue("ETag", value);
			}
		}

		// Token: 0x17000A64 RID: 2660
		// (get) Token: 0x06002381 RID: 9089 RVA: 0x0007CFF8 File Offset: 0x0007B1F8
		// (set) Token: 0x06002382 RID: 9090 RVA: 0x0007D00C File Offset: 0x0007B20C
		public Uri Location
		{
			get
			{
				return (Uri)base.GetParsedValues("Location");
			}
			set
			{
				base.SetOrRemoveParsedValue("Location", value);
			}
		}

		// Token: 0x17000A65 RID: 2661
		// (get) Token: 0x06002383 RID: 9091 RVA: 0x0007D01C File Offset: 0x0007B21C
		public HttpHeaderValueCollection<AuthenticationHeaderValue> ProxyAuthenticate
		{
			get
			{
				if (this.proxyAuthenticate == null)
				{
					this.proxyAuthenticate = new HttpHeaderValueCollection<AuthenticationHeaderValue>("Proxy-Authenticate", this);
				}
				return this.proxyAuthenticate;
			}
		}

		// Token: 0x17000A66 RID: 2662
		// (get) Token: 0x06002384 RID: 9092 RVA: 0x0007D040 File Offset: 0x0007B240
		// (set) Token: 0x06002385 RID: 9093 RVA: 0x0007D054 File Offset: 0x0007B254
		public RetryConditionHeaderValue RetryAfter
		{
			get
			{
				return (RetryConditionHeaderValue)base.GetParsedValues("Retry-After");
			}
			set
			{
				base.SetOrRemoveParsedValue("Retry-After", value);
			}
		}

		// Token: 0x17000A67 RID: 2663
		// (get) Token: 0x06002386 RID: 9094 RVA: 0x0007D064 File Offset: 0x0007B264
		public HttpHeaderValueCollection<ProductInfoHeaderValue> Server
		{
			get
			{
				if (this.server == null)
				{
					this.server = new HttpHeaderValueCollection<ProductInfoHeaderValue>("Server", this);
				}
				return this.server;
			}
		}

		// Token: 0x17000A68 RID: 2664
		// (get) Token: 0x06002387 RID: 9095 RVA: 0x0007D088 File Offset: 0x0007B288
		public HttpHeaderValueCollection<string> Vary
		{
			get
			{
				if (this.vary == null)
				{
					this.vary = new HttpHeaderValueCollection<string>("Vary", this, HeaderUtilities.TokenValidator);
				}
				return this.vary;
			}
		}

		// Token: 0x17000A69 RID: 2665
		// (get) Token: 0x06002388 RID: 9096 RVA: 0x0007D0B4 File Offset: 0x0007B2B4
		public HttpHeaderValueCollection<AuthenticationHeaderValue> WwwAuthenticate
		{
			get
			{
				if (this.wwwAuthenticate == null)
				{
					this.wwwAuthenticate = new HttpHeaderValueCollection<AuthenticationHeaderValue>("WWW-Authenticate", this);
				}
				return this.wwwAuthenticate;
			}
		}

		// Token: 0x17000A6A RID: 2666
		// (get) Token: 0x06002389 RID: 9097 RVA: 0x0007D0D8 File Offset: 0x0007B2D8
		// (set) Token: 0x0600238A RID: 9098 RVA: 0x0007D0E8 File Offset: 0x0007B2E8
		public CacheControlHeaderValue CacheControl
		{
			get
			{
				return this.generalHeaders.CacheControl;
			}
			set
			{
				this.generalHeaders.CacheControl = value;
			}
		}

		// Token: 0x17000A6B RID: 2667
		// (get) Token: 0x0600238B RID: 9099 RVA: 0x0007D0F8 File Offset: 0x0007B2F8
		public HttpHeaderValueCollection<string> Connection
		{
			get
			{
				return this.generalHeaders.Connection;
			}
		}

		// Token: 0x17000A6C RID: 2668
		// (get) Token: 0x0600238C RID: 9100 RVA: 0x0007D108 File Offset: 0x0007B308
		// (set) Token: 0x0600238D RID: 9101 RVA: 0x0007D118 File Offset: 0x0007B318
		public bool? ConnectionClose
		{
			get
			{
				return this.generalHeaders.ConnectionClose;
			}
			set
			{
				this.generalHeaders.ConnectionClose = value;
			}
		}

		// Token: 0x17000A6D RID: 2669
		// (get) Token: 0x0600238E RID: 9102 RVA: 0x0007D128 File Offset: 0x0007B328
		// (set) Token: 0x0600238F RID: 9103 RVA: 0x0007D138 File Offset: 0x0007B338
		public DateTimeOffset? Date
		{
			get
			{
				return this.generalHeaders.Date;
			}
			set
			{
				this.generalHeaders.Date = value;
			}
		}

		// Token: 0x17000A6E RID: 2670
		// (get) Token: 0x06002390 RID: 9104 RVA: 0x0007D148 File Offset: 0x0007B348
		public HttpHeaderValueCollection<NameValueHeaderValue> Pragma
		{
			get
			{
				return this.generalHeaders.Pragma;
			}
		}

		// Token: 0x17000A6F RID: 2671
		// (get) Token: 0x06002391 RID: 9105 RVA: 0x0007D158 File Offset: 0x0007B358
		public HttpHeaderValueCollection<string> Trailer
		{
			get
			{
				return this.generalHeaders.Trailer;
			}
		}

		// Token: 0x17000A70 RID: 2672
		// (get) Token: 0x06002392 RID: 9106 RVA: 0x0007D168 File Offset: 0x0007B368
		public HttpHeaderValueCollection<TransferCodingHeaderValue> TransferEncoding
		{
			get
			{
				return this.generalHeaders.TransferEncoding;
			}
		}

		// Token: 0x17000A71 RID: 2673
		// (get) Token: 0x06002393 RID: 9107 RVA: 0x0007D178 File Offset: 0x0007B378
		// (set) Token: 0x06002394 RID: 9108 RVA: 0x0007D188 File Offset: 0x0007B388
		public bool? TransferEncodingChunked
		{
			get
			{
				return this.generalHeaders.TransferEncodingChunked;
			}
			set
			{
				this.generalHeaders.TransferEncodingChunked = value;
			}
		}

		// Token: 0x17000A72 RID: 2674
		// (get) Token: 0x06002395 RID: 9109 RVA: 0x0007D198 File Offset: 0x0007B398
		public HttpHeaderValueCollection<ProductHeaderValue> Upgrade
		{
			get
			{
				return this.generalHeaders.Upgrade;
			}
		}

		// Token: 0x17000A73 RID: 2675
		// (get) Token: 0x06002396 RID: 9110 RVA: 0x0007D1A8 File Offset: 0x0007B3A8
		public HttpHeaderValueCollection<ViaHeaderValue> Via
		{
			get
			{
				return this.generalHeaders.Via;
			}
		}

		// Token: 0x17000A74 RID: 2676
		// (get) Token: 0x06002397 RID: 9111 RVA: 0x0007D1B8 File Offset: 0x0007B3B8
		public HttpHeaderValueCollection<WarningHeaderValue> Warning
		{
			get
			{
				return this.generalHeaders.Warning;
			}
		}

		// Token: 0x06002398 RID: 9112 RVA: 0x0007D1C8 File Offset: 0x0007B3C8
		internal HttpResponseHeaders()
		{
			this.generalHeaders = new HttpGeneralHeaders(this);
			base.SetConfiguration(HttpResponseHeaders.parserStore, HttpResponseHeaders.invalidHeaders);
		}

		// Token: 0x06002399 RID: 9113 RVA: 0x0007D1EC File Offset: 0x0007B3EC
		static HttpResponseHeaders()
		{
			HttpResponseHeaders.parserStore.Add("Accept-Ranges", GenericHeaderParser.TokenListParser);
			HttpResponseHeaders.parserStore.Add("Age", TimeSpanHeaderParser.Parser);
			HttpResponseHeaders.parserStore.Add("ETag", GenericHeaderParser.SingleValueEntityTagParser);
			HttpResponseHeaders.parserStore.Add("Location", UriHeaderParser.RelativeOrAbsoluteUriParser);
			HttpResponseHeaders.parserStore.Add("Proxy-Authenticate", GenericHeaderParser.MultipleValueAuthenticationParser);
			HttpResponseHeaders.parserStore.Add("Retry-After", GenericHeaderParser.RetryConditionParser);
			HttpResponseHeaders.parserStore.Add("Server", ProductInfoHeaderParser.MultipleValueParser);
			HttpResponseHeaders.parserStore.Add("Vary", GenericHeaderParser.TokenListParser);
			HttpResponseHeaders.parserStore.Add("WWW-Authenticate", GenericHeaderParser.MultipleValueAuthenticationParser);
			HttpGeneralHeaders.AddParsers(HttpResponseHeaders.parserStore);
			HttpResponseHeaders.invalidHeaders = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
			HttpContentHeaders.AddKnownHeaders(HttpResponseHeaders.invalidHeaders);
		}

		// Token: 0x0600239A RID: 9114 RVA: 0x0007D2E4 File Offset: 0x0007B4E4
		internal static void AddKnownHeaders(HashSet<string> headerSet)
		{
			headerSet.Add("Accept-Ranges");
			headerSet.Add("Age");
			headerSet.Add("ETag");
			headerSet.Add("Location");
			headerSet.Add("Proxy-Authenticate");
			headerSet.Add("Retry-After");
			headerSet.Add("Server");
			headerSet.Add("Vary");
			headerSet.Add("WWW-Authenticate");
		}

		// Token: 0x0600239B RID: 9115 RVA: 0x0007D364 File Offset: 0x0007B564
		internal override void AddHeaders(HttpHeaders sourceHeaders)
		{
			base.AddHeaders(sourceHeaders);
			HttpResponseHeaders httpResponseHeaders = sourceHeaders as HttpResponseHeaders;
			this.generalHeaders.AddSpecialsFrom(httpResponseHeaders.generalHeaders);
		}

		// Token: 0x0400105E RID: 4190
		private static readonly Dictionary<string, HttpHeaderParser> parserStore = new Dictionary<string, HttpHeaderParser>(StringComparer.OrdinalIgnoreCase);

		// Token: 0x0400105F RID: 4191
		private static readonly HashSet<string> invalidHeaders;

		// Token: 0x04001060 RID: 4192
		private HttpGeneralHeaders generalHeaders;

		// Token: 0x04001061 RID: 4193
		private HttpHeaderValueCollection<string> acceptRanges;

		// Token: 0x04001062 RID: 4194
		private HttpHeaderValueCollection<AuthenticationHeaderValue> wwwAuthenticate;

		// Token: 0x04001063 RID: 4195
		private HttpHeaderValueCollection<AuthenticationHeaderValue> proxyAuthenticate;

		// Token: 0x04001064 RID: 4196
		private HttpHeaderValueCollection<ProductInfoHeaderValue> server;

		// Token: 0x04001065 RID: 4197
		private HttpHeaderValueCollection<string> vary;
	}
}
