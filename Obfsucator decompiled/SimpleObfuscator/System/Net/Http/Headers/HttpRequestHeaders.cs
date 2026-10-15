using System;
using System.Collections.Generic;

namespace System.Net.Http.Headers
{
	// Token: 0x020002F7 RID: 759
	public sealed class HttpRequestHeaders : HttpHeaders
	{
		// Token: 0x17000A41 RID: 2625
		// (get) Token: 0x06002349 RID: 9033 RVA: 0x0007C76C File Offset: 0x0007A96C
		public HttpHeaderValueCollection<MediaTypeWithQualityHeaderValue> Accept
		{
			get
			{
				if (this.accept == null)
				{
					this.accept = new HttpHeaderValueCollection<MediaTypeWithQualityHeaderValue>("Accept", this);
				}
				return this.accept;
			}
		}

		// Token: 0x17000A42 RID: 2626
		// (get) Token: 0x0600234A RID: 9034 RVA: 0x0007C790 File Offset: 0x0007A990
		public HttpHeaderValueCollection<StringWithQualityHeaderValue> AcceptCharset
		{
			get
			{
				if (this.acceptCharset == null)
				{
					this.acceptCharset = new HttpHeaderValueCollection<StringWithQualityHeaderValue>("Accept-Charset", this);
				}
				return this.acceptCharset;
			}
		}

		// Token: 0x17000A43 RID: 2627
		// (get) Token: 0x0600234B RID: 9035 RVA: 0x0007C7B4 File Offset: 0x0007A9B4
		public HttpHeaderValueCollection<StringWithQualityHeaderValue> AcceptEncoding
		{
			get
			{
				if (this.acceptEncoding == null)
				{
					this.acceptEncoding = new HttpHeaderValueCollection<StringWithQualityHeaderValue>("Accept-Encoding", this);
				}
				return this.acceptEncoding;
			}
		}

		// Token: 0x17000A44 RID: 2628
		// (get) Token: 0x0600234C RID: 9036 RVA: 0x0007C7D8 File Offset: 0x0007A9D8
		public HttpHeaderValueCollection<StringWithQualityHeaderValue> AcceptLanguage
		{
			get
			{
				if (this.acceptLanguage == null)
				{
					this.acceptLanguage = new HttpHeaderValueCollection<StringWithQualityHeaderValue>("Accept-Language", this);
				}
				return this.acceptLanguage;
			}
		}

		// Token: 0x17000A45 RID: 2629
		// (get) Token: 0x0600234D RID: 9037 RVA: 0x0007C7FC File Offset: 0x0007A9FC
		// (set) Token: 0x0600234E RID: 9038 RVA: 0x0007C810 File Offset: 0x0007AA10
		public AuthenticationHeaderValue Authorization
		{
			get
			{
				return (AuthenticationHeaderValue)base.GetParsedValues("Authorization");
			}
			set
			{
				base.SetOrRemoveParsedValue("Authorization", value);
			}
		}

		// Token: 0x17000A46 RID: 2630
		// (get) Token: 0x0600234F RID: 9039 RVA: 0x0007C820 File Offset: 0x0007AA20
		public HttpHeaderValueCollection<NameValueWithParametersHeaderValue> Expect
		{
			get
			{
				return this.ExpectCore;
			}
		}

		// Token: 0x17000A47 RID: 2631
		// (get) Token: 0x06002350 RID: 9040 RVA: 0x0007C828 File Offset: 0x0007AA28
		// (set) Token: 0x06002351 RID: 9041 RVA: 0x0007C86C File Offset: 0x0007AA6C
		public bool? ExpectContinue
		{
			get
			{
				if (this.ExpectCore.IsSpecialValueSet)
				{
					return new bool?(true);
				}
				if (this.expectContinueSet)
				{
					return new bool?(false);
				}
				return null;
			}
			set
			{
				if (value == true)
				{
					this.expectContinueSet = true;
					this.ExpectCore.SetSpecialValue();
					return;
				}
				this.expectContinueSet = (value != null);
				this.ExpectCore.RemoveSpecialValue();
			}
		}

		// Token: 0x17000A48 RID: 2632
		// (get) Token: 0x06002352 RID: 9042 RVA: 0x0007C8C8 File Offset: 0x0007AAC8
		// (set) Token: 0x06002353 RID: 9043 RVA: 0x0007C8DC File Offset: 0x0007AADC
		public string From
		{
			get
			{
				return (string)base.GetParsedValues("From");
			}
			set
			{
				if (value == string.Empty)
				{
					value = null;
				}
				if (value != null && !HeaderUtilities.IsValidEmailAddress(value))
				{
					throw new FormatException(SR.net_http_headers_invalid_from_header);
				}
				base.SetOrRemoveParsedValue("From", value);
			}
		}

		// Token: 0x17000A49 RID: 2633
		// (get) Token: 0x06002354 RID: 9044 RVA: 0x0007C91C File Offset: 0x0007AB1C
		// (set) Token: 0x06002355 RID: 9045 RVA: 0x0007C930 File Offset: 0x0007AB30
		public string Host
		{
			get
			{
				return (string)base.GetParsedValues("Host");
			}
			set
			{
				if (value == string.Empty)
				{
					value = null;
				}
				string text = null;
				if (value != null && HttpRuleParser.GetHostLength(value, 0, false, out text) != value.Length)
				{
					throw new FormatException(SR.net_http_headers_invalid_host_header);
				}
				base.SetOrRemoveParsedValue("Host", value);
			}
		}

		// Token: 0x17000A4A RID: 2634
		// (get) Token: 0x06002356 RID: 9046 RVA: 0x0007C988 File Offset: 0x0007AB88
		public HttpHeaderValueCollection<EntityTagHeaderValue> IfMatch
		{
			get
			{
				if (this.ifMatch == null)
				{
					this.ifMatch = new HttpHeaderValueCollection<EntityTagHeaderValue>("If-Match", this);
				}
				return this.ifMatch;
			}
		}

		// Token: 0x17000A4B RID: 2635
		// (get) Token: 0x06002357 RID: 9047 RVA: 0x0007C9AC File Offset: 0x0007ABAC
		// (set) Token: 0x06002358 RID: 9048 RVA: 0x0007C9BC File Offset: 0x0007ABBC
		public DateTimeOffset? IfModifiedSince
		{
			get
			{
				return HeaderUtilities.GetDateTimeOffsetValue("If-Modified-Since", this);
			}
			set
			{
				base.SetOrRemoveParsedValue("If-Modified-Since", value);
			}
		}

		// Token: 0x17000A4C RID: 2636
		// (get) Token: 0x06002359 RID: 9049 RVA: 0x0007C9D0 File Offset: 0x0007ABD0
		public HttpHeaderValueCollection<EntityTagHeaderValue> IfNoneMatch
		{
			get
			{
				if (this.ifNoneMatch == null)
				{
					this.ifNoneMatch = new HttpHeaderValueCollection<EntityTagHeaderValue>("If-None-Match", this);
				}
				return this.ifNoneMatch;
			}
		}

		// Token: 0x17000A4D RID: 2637
		// (get) Token: 0x0600235A RID: 9050 RVA: 0x0007C9F4 File Offset: 0x0007ABF4
		// (set) Token: 0x0600235B RID: 9051 RVA: 0x0007CA08 File Offset: 0x0007AC08
		public RangeConditionHeaderValue IfRange
		{
			get
			{
				return (RangeConditionHeaderValue)base.GetParsedValues("If-Range");
			}
			set
			{
				base.SetOrRemoveParsedValue("If-Range", value);
			}
		}

		// Token: 0x17000A4E RID: 2638
		// (get) Token: 0x0600235C RID: 9052 RVA: 0x0007CA18 File Offset: 0x0007AC18
		// (set) Token: 0x0600235D RID: 9053 RVA: 0x0007CA28 File Offset: 0x0007AC28
		public DateTimeOffset? IfUnmodifiedSince
		{
			get
			{
				return HeaderUtilities.GetDateTimeOffsetValue("If-Unmodified-Since", this);
			}
			set
			{
				base.SetOrRemoveParsedValue("If-Unmodified-Since", value);
			}
		}

		// Token: 0x17000A4F RID: 2639
		// (get) Token: 0x0600235E RID: 9054 RVA: 0x0007CA3C File Offset: 0x0007AC3C
		// (set) Token: 0x0600235F RID: 9055 RVA: 0x0007CA74 File Offset: 0x0007AC74
		public int? MaxForwards
		{
			get
			{
				object parsedValues = base.GetParsedValues("Max-Forwards");
				if (parsedValues != null)
				{
					return new int?((int)parsedValues);
				}
				return null;
			}
			set
			{
				base.SetOrRemoveParsedValue("Max-Forwards", value);
			}
		}

		// Token: 0x17000A50 RID: 2640
		// (get) Token: 0x06002360 RID: 9056 RVA: 0x0007CA88 File Offset: 0x0007AC88
		// (set) Token: 0x06002361 RID: 9057 RVA: 0x0007CA9C File Offset: 0x0007AC9C
		public AuthenticationHeaderValue ProxyAuthorization
		{
			get
			{
				return (AuthenticationHeaderValue)base.GetParsedValues("Proxy-Authorization");
			}
			set
			{
				base.SetOrRemoveParsedValue("Proxy-Authorization", value);
			}
		}

		// Token: 0x17000A51 RID: 2641
		// (get) Token: 0x06002362 RID: 9058 RVA: 0x0007CAAC File Offset: 0x0007ACAC
		// (set) Token: 0x06002363 RID: 9059 RVA: 0x0007CAC0 File Offset: 0x0007ACC0
		public RangeHeaderValue Range
		{
			get
			{
				return (RangeHeaderValue)base.GetParsedValues("Range");
			}
			set
			{
				base.SetOrRemoveParsedValue("Range", value);
			}
		}

		// Token: 0x17000A52 RID: 2642
		// (get) Token: 0x06002364 RID: 9060 RVA: 0x0007CAD0 File Offset: 0x0007ACD0
		// (set) Token: 0x06002365 RID: 9061 RVA: 0x0007CAE4 File Offset: 0x0007ACE4
		public Uri Referrer
		{
			get
			{
				return (Uri)base.GetParsedValues("Referer");
			}
			set
			{
				base.SetOrRemoveParsedValue("Referer", value);
			}
		}

		// Token: 0x17000A53 RID: 2643
		// (get) Token: 0x06002366 RID: 9062 RVA: 0x0007CAF4 File Offset: 0x0007ACF4
		public HttpHeaderValueCollection<TransferCodingWithQualityHeaderValue> TE
		{
			get
			{
				if (this.te == null)
				{
					this.te = new HttpHeaderValueCollection<TransferCodingWithQualityHeaderValue>("TE", this);
				}
				return this.te;
			}
		}

		// Token: 0x17000A54 RID: 2644
		// (get) Token: 0x06002367 RID: 9063 RVA: 0x0007CB18 File Offset: 0x0007AD18
		public HttpHeaderValueCollection<ProductInfoHeaderValue> UserAgent
		{
			get
			{
				if (this.userAgent == null)
				{
					this.userAgent = new HttpHeaderValueCollection<ProductInfoHeaderValue>("User-Agent", this);
				}
				return this.userAgent;
			}
		}

		// Token: 0x17000A55 RID: 2645
		// (get) Token: 0x06002368 RID: 9064 RVA: 0x0007CB3C File Offset: 0x0007AD3C
		private HttpHeaderValueCollection<NameValueWithParametersHeaderValue> ExpectCore
		{
			get
			{
				if (this.expect == null)
				{
					this.expect = new HttpHeaderValueCollection<NameValueWithParametersHeaderValue>("Expect", this, HeaderUtilities.ExpectContinue);
				}
				return this.expect;
			}
		}

		// Token: 0x17000A56 RID: 2646
		// (get) Token: 0x06002369 RID: 9065 RVA: 0x0007CB68 File Offset: 0x0007AD68
		// (set) Token: 0x0600236A RID: 9066 RVA: 0x0007CB78 File Offset: 0x0007AD78
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

		// Token: 0x17000A57 RID: 2647
		// (get) Token: 0x0600236B RID: 9067 RVA: 0x0007CB88 File Offset: 0x0007AD88
		public HttpHeaderValueCollection<string> Connection
		{
			get
			{
				return this.generalHeaders.Connection;
			}
		}

		// Token: 0x17000A58 RID: 2648
		// (get) Token: 0x0600236C RID: 9068 RVA: 0x0007CB98 File Offset: 0x0007AD98
		// (set) Token: 0x0600236D RID: 9069 RVA: 0x0007CBA8 File Offset: 0x0007ADA8
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

		// Token: 0x17000A59 RID: 2649
		// (get) Token: 0x0600236E RID: 9070 RVA: 0x0007CBB8 File Offset: 0x0007ADB8
		// (set) Token: 0x0600236F RID: 9071 RVA: 0x0007CBC8 File Offset: 0x0007ADC8
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

		// Token: 0x17000A5A RID: 2650
		// (get) Token: 0x06002370 RID: 9072 RVA: 0x0007CBD8 File Offset: 0x0007ADD8
		public HttpHeaderValueCollection<NameValueHeaderValue> Pragma
		{
			get
			{
				return this.generalHeaders.Pragma;
			}
		}

		// Token: 0x17000A5B RID: 2651
		// (get) Token: 0x06002371 RID: 9073 RVA: 0x0007CBE8 File Offset: 0x0007ADE8
		public HttpHeaderValueCollection<string> Trailer
		{
			get
			{
				return this.generalHeaders.Trailer;
			}
		}

		// Token: 0x17000A5C RID: 2652
		// (get) Token: 0x06002372 RID: 9074 RVA: 0x0007CBF8 File Offset: 0x0007ADF8
		public HttpHeaderValueCollection<TransferCodingHeaderValue> TransferEncoding
		{
			get
			{
				return this.generalHeaders.TransferEncoding;
			}
		}

		// Token: 0x17000A5D RID: 2653
		// (get) Token: 0x06002373 RID: 9075 RVA: 0x0007CC08 File Offset: 0x0007AE08
		// (set) Token: 0x06002374 RID: 9076 RVA: 0x0007CC18 File Offset: 0x0007AE18
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

		// Token: 0x17000A5E RID: 2654
		// (get) Token: 0x06002375 RID: 9077 RVA: 0x0007CC28 File Offset: 0x0007AE28
		public HttpHeaderValueCollection<ProductHeaderValue> Upgrade
		{
			get
			{
				return this.generalHeaders.Upgrade;
			}
		}

		// Token: 0x17000A5F RID: 2655
		// (get) Token: 0x06002376 RID: 9078 RVA: 0x0007CC38 File Offset: 0x0007AE38
		public HttpHeaderValueCollection<ViaHeaderValue> Via
		{
			get
			{
				return this.generalHeaders.Via;
			}
		}

		// Token: 0x17000A60 RID: 2656
		// (get) Token: 0x06002377 RID: 9079 RVA: 0x0007CC48 File Offset: 0x0007AE48
		public HttpHeaderValueCollection<WarningHeaderValue> Warning
		{
			get
			{
				return this.generalHeaders.Warning;
			}
		}

		// Token: 0x06002378 RID: 9080 RVA: 0x0007CC58 File Offset: 0x0007AE58
		internal HttpRequestHeaders()
		{
			this.generalHeaders = new HttpGeneralHeaders(this);
			base.SetConfiguration(HttpRequestHeaders.parserStore, HttpRequestHeaders.invalidHeaders);
		}

		// Token: 0x06002379 RID: 9081 RVA: 0x0007CC7C File Offset: 0x0007AE7C
		static HttpRequestHeaders()
		{
			HttpRequestHeaders.parserStore.Add("Accept", MediaTypeHeaderParser.MultipleValuesParser);
			HttpRequestHeaders.parserStore.Add("Accept-Charset", GenericHeaderParser.MultipleValueStringWithQualityParser);
			HttpRequestHeaders.parserStore.Add("Accept-Encoding", GenericHeaderParser.MultipleValueStringWithQualityParser);
			HttpRequestHeaders.parserStore.Add("Accept-Language", GenericHeaderParser.MultipleValueStringWithQualityParser);
			HttpRequestHeaders.parserStore.Add("Authorization", GenericHeaderParser.SingleValueAuthenticationParser);
			HttpRequestHeaders.parserStore.Add("Expect", GenericHeaderParser.MultipleValueNameValueWithParametersParser);
			HttpRequestHeaders.parserStore.Add("From", GenericHeaderParser.MailAddressParser);
			HttpRequestHeaders.parserStore.Add("Host", GenericHeaderParser.HostParser);
			HttpRequestHeaders.parserStore.Add("If-Match", GenericHeaderParser.MultipleValueEntityTagParser);
			HttpRequestHeaders.parserStore.Add("If-Modified-Since", DateHeaderParser.Parser);
			HttpRequestHeaders.parserStore.Add("If-None-Match", GenericHeaderParser.MultipleValueEntityTagParser);
			HttpRequestHeaders.parserStore.Add("If-Range", GenericHeaderParser.RangeConditionParser);
			HttpRequestHeaders.parserStore.Add("If-Unmodified-Since", DateHeaderParser.Parser);
			HttpRequestHeaders.parserStore.Add("Max-Forwards", Int32NumberHeaderParser.Parser);
			HttpRequestHeaders.parserStore.Add("Proxy-Authorization", GenericHeaderParser.SingleValueAuthenticationParser);
			HttpRequestHeaders.parserStore.Add("Range", GenericHeaderParser.RangeParser);
			HttpRequestHeaders.parserStore.Add("Referer", UriHeaderParser.RelativeOrAbsoluteUriParser);
			HttpRequestHeaders.parserStore.Add("TE", TransferCodingHeaderParser.MultipleValueWithQualityParser);
			HttpRequestHeaders.parserStore.Add("User-Agent", ProductInfoHeaderParser.MultipleValueParser);
			HttpGeneralHeaders.AddParsers(HttpRequestHeaders.parserStore);
			HttpRequestHeaders.invalidHeaders = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
			HttpContentHeaders.AddKnownHeaders(HttpRequestHeaders.invalidHeaders);
		}

		// Token: 0x0600237A RID: 9082 RVA: 0x0007CE3C File Offset: 0x0007B03C
		internal static void AddKnownHeaders(HashSet<string> headerSet)
		{
			headerSet.Add("Accept");
			headerSet.Add("Accept-Charset");
			headerSet.Add("Accept-Encoding");
			headerSet.Add("Accept-Language");
			headerSet.Add("Authorization");
			headerSet.Add("Expect");
			headerSet.Add("From");
			headerSet.Add("Host");
			headerSet.Add("If-Match");
			headerSet.Add("If-Modified-Since");
			headerSet.Add("If-None-Match");
			headerSet.Add("If-Range");
			headerSet.Add("If-Unmodified-Since");
			headerSet.Add("Max-Forwards");
			headerSet.Add("Proxy-Authorization");
			headerSet.Add("Range");
			headerSet.Add("Referer");
			headerSet.Add("TE");
			headerSet.Add("User-Agent");
		}

		// Token: 0x0600237B RID: 9083 RVA: 0x0007CF34 File Offset: 0x0007B134
		internal override void AddHeaders(HttpHeaders sourceHeaders)
		{
			base.AddHeaders(sourceHeaders);
			HttpRequestHeaders httpRequestHeaders = sourceHeaders as HttpRequestHeaders;
			this.generalHeaders.AddSpecialsFrom(httpRequestHeaders.generalHeaders);
			if (this.ExpectContinue == null)
			{
				this.ExpectContinue = httpRequestHeaders.ExpectContinue;
			}
		}

		// Token: 0x04001051 RID: 4177
		private static readonly Dictionary<string, HttpHeaderParser> parserStore = new Dictionary<string, HttpHeaderParser>(StringComparer.OrdinalIgnoreCase);

		// Token: 0x04001052 RID: 4178
		private static readonly HashSet<string> invalidHeaders;

		// Token: 0x04001053 RID: 4179
		private HttpGeneralHeaders generalHeaders;

		// Token: 0x04001054 RID: 4180
		private HttpHeaderValueCollection<MediaTypeWithQualityHeaderValue> accept;

		// Token: 0x04001055 RID: 4181
		private HttpHeaderValueCollection<NameValueWithParametersHeaderValue> expect;

		// Token: 0x04001056 RID: 4182
		private bool expectContinueSet;

		// Token: 0x04001057 RID: 4183
		private HttpHeaderValueCollection<EntityTagHeaderValue> ifMatch;

		// Token: 0x04001058 RID: 4184
		private HttpHeaderValueCollection<EntityTagHeaderValue> ifNoneMatch;

		// Token: 0x04001059 RID: 4185
		private HttpHeaderValueCollection<TransferCodingWithQualityHeaderValue> te;

		// Token: 0x0400105A RID: 4186
		private HttpHeaderValueCollection<ProductInfoHeaderValue> userAgent;

		// Token: 0x0400105B RID: 4187
		private HttpHeaderValueCollection<StringWithQualityHeaderValue> acceptCharset;

		// Token: 0x0400105C RID: 4188
		private HttpHeaderValueCollection<StringWithQualityHeaderValue> acceptEncoding;

		// Token: 0x0400105D RID: 4189
		private HttpHeaderValueCollection<StringWithQualityHeaderValue> acceptLanguage;
	}
}
