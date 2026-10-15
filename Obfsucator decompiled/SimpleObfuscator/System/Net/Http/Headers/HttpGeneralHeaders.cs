using System;
using System.Collections.Generic;

namespace System.Net.Http.Headers
{
	// Token: 0x020002F5 RID: 757
	internal sealed class HttpGeneralHeaders
	{
		// Token: 0x17000A31 RID: 2609
		// (get) Token: 0x0600231E RID: 8990 RVA: 0x0007BFD4 File Offset: 0x0007A1D4
		// (set) Token: 0x0600231F RID: 8991 RVA: 0x0007BFEC File Offset: 0x0007A1EC
		public CacheControlHeaderValue CacheControl
		{
			get
			{
				return (CacheControlHeaderValue)this.parent.GetParsedValues("Cache-Control");
			}
			set
			{
				this.parent.SetOrRemoveParsedValue("Cache-Control", value);
			}
		}

		// Token: 0x17000A32 RID: 2610
		// (get) Token: 0x06002320 RID: 8992 RVA: 0x0007C000 File Offset: 0x0007A200
		public HttpHeaderValueCollection<string> Connection
		{
			get
			{
				return this.ConnectionCore;
			}
		}

		// Token: 0x17000A33 RID: 2611
		// (get) Token: 0x06002321 RID: 8993 RVA: 0x0007C008 File Offset: 0x0007A208
		// (set) Token: 0x06002322 RID: 8994 RVA: 0x0007C04C File Offset: 0x0007A24C
		public bool? ConnectionClose
		{
			get
			{
				if (this.ConnectionCore.IsSpecialValueSet)
				{
					return new bool?(true);
				}
				if (this.connectionCloseSet)
				{
					return new bool?(false);
				}
				return null;
			}
			set
			{
				if (value == true)
				{
					this.connectionCloseSet = true;
					this.ConnectionCore.SetSpecialValue();
					return;
				}
				this.connectionCloseSet = (value != null);
				this.ConnectionCore.RemoveSpecialValue();
			}
		}

		// Token: 0x17000A34 RID: 2612
		// (get) Token: 0x06002323 RID: 8995 RVA: 0x0007C0A8 File Offset: 0x0007A2A8
		// (set) Token: 0x06002324 RID: 8996 RVA: 0x0007C0BC File Offset: 0x0007A2BC
		public DateTimeOffset? Date
		{
			get
			{
				return HeaderUtilities.GetDateTimeOffsetValue("Date", this.parent);
			}
			set
			{
				this.parent.SetOrRemoveParsedValue("Date", value);
			}
		}

		// Token: 0x17000A35 RID: 2613
		// (get) Token: 0x06002325 RID: 8997 RVA: 0x0007C0D4 File Offset: 0x0007A2D4
		public HttpHeaderValueCollection<NameValueHeaderValue> Pragma
		{
			get
			{
				if (this.pragma == null)
				{
					this.pragma = new HttpHeaderValueCollection<NameValueHeaderValue>("Pragma", this.parent);
				}
				return this.pragma;
			}
		}

		// Token: 0x17000A36 RID: 2614
		// (get) Token: 0x06002326 RID: 8998 RVA: 0x0007C100 File Offset: 0x0007A300
		public HttpHeaderValueCollection<string> Trailer
		{
			get
			{
				if (this.trailer == null)
				{
					this.trailer = new HttpHeaderValueCollection<string>("Trailer", this.parent, HeaderUtilities.TokenValidator);
				}
				return this.trailer;
			}
		}

		// Token: 0x17000A37 RID: 2615
		// (get) Token: 0x06002327 RID: 8999 RVA: 0x0007C130 File Offset: 0x0007A330
		public HttpHeaderValueCollection<TransferCodingHeaderValue> TransferEncoding
		{
			get
			{
				return this.TransferEncodingCore;
			}
		}

		// Token: 0x17000A38 RID: 2616
		// (get) Token: 0x06002328 RID: 9000 RVA: 0x0007C138 File Offset: 0x0007A338
		// (set) Token: 0x06002329 RID: 9001 RVA: 0x0007C17C File Offset: 0x0007A37C
		public bool? TransferEncodingChunked
		{
			get
			{
				if (this.TransferEncodingCore.IsSpecialValueSet)
				{
					return new bool?(true);
				}
				if (this.transferEncodingChunkedSet)
				{
					return new bool?(false);
				}
				return null;
			}
			set
			{
				if (value == true)
				{
					this.transferEncodingChunkedSet = true;
					this.TransferEncodingCore.SetSpecialValue();
					return;
				}
				this.transferEncodingChunkedSet = (value != null);
				this.TransferEncodingCore.RemoveSpecialValue();
			}
		}

		// Token: 0x17000A39 RID: 2617
		// (get) Token: 0x0600232A RID: 9002 RVA: 0x0007C1D8 File Offset: 0x0007A3D8
		public HttpHeaderValueCollection<ProductHeaderValue> Upgrade
		{
			get
			{
				if (this.upgrade == null)
				{
					this.upgrade = new HttpHeaderValueCollection<ProductHeaderValue>("Upgrade", this.parent);
				}
				return this.upgrade;
			}
		}

		// Token: 0x17000A3A RID: 2618
		// (get) Token: 0x0600232B RID: 9003 RVA: 0x0007C204 File Offset: 0x0007A404
		public HttpHeaderValueCollection<ViaHeaderValue> Via
		{
			get
			{
				if (this.via == null)
				{
					this.via = new HttpHeaderValueCollection<ViaHeaderValue>("Via", this.parent);
				}
				return this.via;
			}
		}

		// Token: 0x17000A3B RID: 2619
		// (get) Token: 0x0600232C RID: 9004 RVA: 0x0007C230 File Offset: 0x0007A430
		public HttpHeaderValueCollection<WarningHeaderValue> Warning
		{
			get
			{
				if (this.warning == null)
				{
					this.warning = new HttpHeaderValueCollection<WarningHeaderValue>("Warning", this.parent);
				}
				return this.warning;
			}
		}

		// Token: 0x17000A3C RID: 2620
		// (get) Token: 0x0600232D RID: 9005 RVA: 0x0007C25C File Offset: 0x0007A45C
		private HttpHeaderValueCollection<string> ConnectionCore
		{
			get
			{
				if (this.connection == null)
				{
					this.connection = new HttpHeaderValueCollection<string>("Connection", this.parent, "close", HeaderUtilities.TokenValidator);
				}
				return this.connection;
			}
		}

		// Token: 0x17000A3D RID: 2621
		// (get) Token: 0x0600232E RID: 9006 RVA: 0x0007C290 File Offset: 0x0007A490
		private HttpHeaderValueCollection<TransferCodingHeaderValue> TransferEncodingCore
		{
			get
			{
				if (this.transferEncoding == null)
				{
					this.transferEncoding = new HttpHeaderValueCollection<TransferCodingHeaderValue>("Transfer-Encoding", this.parent, HeaderUtilities.TransferEncodingChunked);
				}
				return this.transferEncoding;
			}
		}

		// Token: 0x0600232F RID: 9007 RVA: 0x0007C2C0 File Offset: 0x0007A4C0
		internal HttpGeneralHeaders(HttpHeaders parent)
		{
			this.parent = parent;
		}

		// Token: 0x06002330 RID: 9008 RVA: 0x0007C2D0 File Offset: 0x0007A4D0
		internal static void AddParsers(Dictionary<string, HttpHeaderParser> parserStore)
		{
			parserStore.Add("Cache-Control", CacheControlHeaderParser.Parser);
			parserStore.Add("Connection", GenericHeaderParser.TokenListParser);
			parserStore.Add("Date", DateHeaderParser.Parser);
			parserStore.Add("Pragma", GenericHeaderParser.MultipleValueNameValueParser);
			parserStore.Add("Trailer", GenericHeaderParser.TokenListParser);
			parserStore.Add("Transfer-Encoding", TransferCodingHeaderParser.MultipleValueParser);
			parserStore.Add("Upgrade", GenericHeaderParser.MultipleValueProductParser);
			parserStore.Add("Via", GenericHeaderParser.MultipleValueViaParser);
			parserStore.Add("Warning", GenericHeaderParser.MultipleValueWarningParser);
		}

		// Token: 0x06002331 RID: 9009 RVA: 0x0007C374 File Offset: 0x0007A574
		internal static void AddKnownHeaders(HashSet<string> headerSet)
		{
			headerSet.Add("Cache-Control");
			headerSet.Add("Connection");
			headerSet.Add("Date");
			headerSet.Add("Pragma");
			headerSet.Add("Trailer");
			headerSet.Add("Transfer-Encoding");
			headerSet.Add("Upgrade");
			headerSet.Add("Via");
			headerSet.Add("Warning");
		}

		// Token: 0x06002332 RID: 9010 RVA: 0x0007C3F4 File Offset: 0x0007A5F4
		internal void AddSpecialsFrom(HttpGeneralHeaders sourceHeaders)
		{
			if (this.TransferEncodingChunked == null)
			{
				this.TransferEncodingChunked = sourceHeaders.TransferEncodingChunked;
			}
			if (this.ConnectionClose == null)
			{
				this.ConnectionClose = sourceHeaders.ConnectionClose;
			}
		}

		// Token: 0x04001043 RID: 4163
		private HttpHeaderValueCollection<string> connection;

		// Token: 0x04001044 RID: 4164
		private HttpHeaderValueCollection<string> trailer;

		// Token: 0x04001045 RID: 4165
		private HttpHeaderValueCollection<TransferCodingHeaderValue> transferEncoding;

		// Token: 0x04001046 RID: 4166
		private HttpHeaderValueCollection<ProductHeaderValue> upgrade;

		// Token: 0x04001047 RID: 4167
		private HttpHeaderValueCollection<ViaHeaderValue> via;

		// Token: 0x04001048 RID: 4168
		private HttpHeaderValueCollection<WarningHeaderValue> warning;

		// Token: 0x04001049 RID: 4169
		private HttpHeaderValueCollection<NameValueHeaderValue> pragma;

		// Token: 0x0400104A RID: 4170
		private HttpHeaders parent;

		// Token: 0x0400104B RID: 4171
		private bool transferEncodingChunkedSet;

		// Token: 0x0400104C RID: 4172
		private bool connectionCloseSet;
	}
}
