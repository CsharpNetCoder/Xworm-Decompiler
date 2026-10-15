using System;
using System.Globalization;
using System.Net.Http.Headers;
using System.Text;

namespace System.Net.Http
{
	// Token: 0x02000318 RID: 792
	public class HttpResponseMessage : IDisposable
	{
		// Token: 0x17000AB7 RID: 2743
		// (get) Token: 0x0600253E RID: 9534 RVA: 0x000832B4 File Offset: 0x000814B4
		// (set) Token: 0x0600253F RID: 9535 RVA: 0x000832BC File Offset: 0x000814BC
		public Version Version
		{
			get
			{
				return this.version;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("value");
				}
				this.CheckDisposed();
				this.version = value;
			}
		}

		// Token: 0x17000AB8 RID: 2744
		// (get) Token: 0x06002540 RID: 9536 RVA: 0x000832E4 File Offset: 0x000814E4
		// (set) Token: 0x06002541 RID: 9537 RVA: 0x000832EC File Offset: 0x000814EC
		public HttpContent Content
		{
			get
			{
				return this.content;
			}
			set
			{
				this.CheckDisposed();
				if (Logging.On)
				{
					if (value == null)
					{
						Logging.PrintInfo(Logging.Http, this, SR.net_http_log_content_null);
					}
					else
					{
						Logging.Associate(Logging.Http, this, value);
					}
				}
				this.content = value;
			}
		}

		// Token: 0x17000AB9 RID: 2745
		// (get) Token: 0x06002542 RID: 9538 RVA: 0x0008332C File Offset: 0x0008152C
		// (set) Token: 0x06002543 RID: 9539 RVA: 0x00083334 File Offset: 0x00081534
		public HttpStatusCode StatusCode
		{
			get
			{
				return this.statusCode;
			}
			set
			{
				if (value < (HttpStatusCode)0 || value > (HttpStatusCode)999)
				{
					throw new ArgumentOutOfRangeException("value");
				}
				this.CheckDisposed();
				this.statusCode = value;
			}
		}

		// Token: 0x17000ABA RID: 2746
		// (get) Token: 0x06002544 RID: 9540 RVA: 0x00083360 File Offset: 0x00081560
		// (set) Token: 0x06002545 RID: 9541 RVA: 0x00083380 File Offset: 0x00081580
		public string ReasonPhrase
		{
			get
			{
				if (this.reasonPhrase != null)
				{
					return this.reasonPhrase;
				}
				return HttpStatusDescription.Get(this.StatusCode);
			}
			set
			{
				if (value != null && this.ContainsNewLineCharacter(value))
				{
					throw new FormatException(SR.net_http_reasonphrase_format_error);
				}
				this.CheckDisposed();
				this.reasonPhrase = value;
			}
		}

		// Token: 0x17000ABB RID: 2747
		// (get) Token: 0x06002546 RID: 9542 RVA: 0x000833AC File Offset: 0x000815AC
		public HttpResponseHeaders Headers
		{
			get
			{
				if (this.headers == null)
				{
					this.headers = new HttpResponseHeaders();
				}
				return this.headers;
			}
		}

		// Token: 0x17000ABC RID: 2748
		// (get) Token: 0x06002547 RID: 9543 RVA: 0x000833CC File Offset: 0x000815CC
		// (set) Token: 0x06002548 RID: 9544 RVA: 0x000833D4 File Offset: 0x000815D4
		public HttpRequestMessage RequestMessage
		{
			get
			{
				return this.requestMessage;
			}
			set
			{
				this.CheckDisposed();
				if (Logging.On && value != null)
				{
					Logging.Associate(Logging.Http, this, value);
				}
				this.requestMessage = value;
			}
		}

		// Token: 0x17000ABD RID: 2749
		// (get) Token: 0x06002549 RID: 9545 RVA: 0x00083400 File Offset: 0x00081600
		public bool IsSuccessStatusCode
		{
			get
			{
				return this.statusCode >= HttpStatusCode.OK && this.statusCode <= (HttpStatusCode)299;
			}
		}

		// Token: 0x0600254A RID: 9546 RVA: 0x00083424 File Offset: 0x00081624
		public HttpResponseMessage() : this(HttpStatusCode.OK)
		{
		}

		// Token: 0x0600254B RID: 9547 RVA: 0x00083434 File Offset: 0x00081634
		public HttpResponseMessage(HttpStatusCode statusCode)
		{
			if (Logging.On)
			{
				Logging.Enter(Logging.Http, this, ".ctor", string.Concat(new object[]
				{
					"StatusCode: ",
					(int)statusCode,
					", ReasonPhrase: '",
					this.reasonPhrase,
					"'"
				}));
			}
			if (statusCode < (HttpStatusCode)0 || statusCode > (HttpStatusCode)999)
			{
				throw new ArgumentOutOfRangeException("statusCode");
			}
			this.statusCode = statusCode;
			this.version = HttpUtilities.DefaultVersion;
			if (Logging.On)
			{
				Logging.Exit(Logging.Http, this, ".ctor", null);
			}
		}

		// Token: 0x0600254C RID: 9548 RVA: 0x000834E8 File Offset: 0x000816E8
		public HttpResponseMessage EnsureSuccessStatusCode()
		{
			if (!this.IsSuccessStatusCode)
			{
				if (this.content != null)
				{
					this.content.Dispose();
				}
				throw new HttpRequestException(string.Format(CultureInfo.InvariantCulture, SR.net_http_message_not_success_statuscode, new object[]
				{
					(int)this.statusCode,
					this.ReasonPhrase
				}));
			}
			return this;
		}

		// Token: 0x0600254D RID: 9549 RVA: 0x00083550 File Offset: 0x00081750
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("StatusCode: ");
			stringBuilder.Append((int)this.statusCode);
			stringBuilder.Append(", ReasonPhrase: '");
			stringBuilder.Append(this.ReasonPhrase ?? "<null>");
			stringBuilder.Append("', Version: ");
			stringBuilder.Append(this.version);
			stringBuilder.Append(", Content: ");
			stringBuilder.Append((this.content == null) ? "<null>" : this.content.GetType().FullName);
			stringBuilder.Append(", Headers:\r\n");
			stringBuilder.Append(HeaderUtilities.DumpHeaders(new HttpHeaders[]
			{
				this.headers,
				(this.content == null) ? null : this.content.Headers
			}));
			return stringBuilder.ToString();
		}

		// Token: 0x0600254E RID: 9550 RVA: 0x00083648 File Offset: 0x00081848
		private bool ContainsNewLineCharacter(string value)
		{
			foreach (char c in value)
			{
				if (c == '\r' || c == '\n')
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600254F RID: 9551 RVA: 0x00083694 File Offset: 0x00081894
		protected virtual void Dispose(bool disposing)
		{
			if (disposing && !this.disposed)
			{
				this.disposed = true;
				if (this.content != null)
				{
					this.content.Dispose();
				}
			}
		}

		// Token: 0x06002550 RID: 9552 RVA: 0x000836C4 File Offset: 0x000818C4
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06002551 RID: 9553 RVA: 0x000836D4 File Offset: 0x000818D4
		private void CheckDisposed()
		{
			if (this.disposed)
			{
				throw new ObjectDisposedException(base.GetType().FullName);
			}
		}

		// Token: 0x040010DC RID: 4316
		private const HttpStatusCode defaultStatusCode = HttpStatusCode.OK;

		// Token: 0x040010DD RID: 4317
		private HttpStatusCode statusCode;

		// Token: 0x040010DE RID: 4318
		private HttpResponseHeaders headers;

		// Token: 0x040010DF RID: 4319
		private string reasonPhrase;

		// Token: 0x040010E0 RID: 4320
		private HttpRequestMessage requestMessage;

		// Token: 0x040010E1 RID: 4321
		private Version version;

		// Token: 0x040010E2 RID: 4322
		private HttpContent content;

		// Token: 0x040010E3 RID: 4323
		private bool disposed;
	}
}
