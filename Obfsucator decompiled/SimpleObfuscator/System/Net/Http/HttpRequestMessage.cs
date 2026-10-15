using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;

namespace System.Net.Http
{
	// Token: 0x02000317 RID: 791
	public class HttpRequestMessage : IDisposable
	{
		// Token: 0x17000AB1 RID: 2737
		// (get) Token: 0x0600252B RID: 9515 RVA: 0x00082E4C File Offset: 0x0008104C
		// (set) Token: 0x0600252C RID: 9516 RVA: 0x00082E54 File Offset: 0x00081054
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

		// Token: 0x17000AB2 RID: 2738
		// (get) Token: 0x0600252D RID: 9517 RVA: 0x00082E7C File Offset: 0x0008107C
		// (set) Token: 0x0600252E RID: 9518 RVA: 0x00082E84 File Offset: 0x00081084
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

		// Token: 0x17000AB3 RID: 2739
		// (get) Token: 0x0600252F RID: 9519 RVA: 0x00082EC4 File Offset: 0x000810C4
		// (set) Token: 0x06002530 RID: 9520 RVA: 0x00082ECC File Offset: 0x000810CC
		public HttpMethod Method
		{
			get
			{
				return this.method;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("value");
				}
				this.CheckDisposed();
				this.method = value;
			}
		}

		// Token: 0x17000AB4 RID: 2740
		// (get) Token: 0x06002531 RID: 9521 RVA: 0x00082EF4 File Offset: 0x000810F4
		// (set) Token: 0x06002532 RID: 9522 RVA: 0x00082EFC File Offset: 0x000810FC
		public Uri RequestUri
		{
			get
			{
				return this.requestUri;
			}
			set
			{
				if (value != null && value.IsAbsoluteUri && !HttpUtilities.IsHttpUri(value))
				{
					throw new ArgumentException(SR.net_http_client_http_baseaddress_required, "value");
				}
				this.CheckDisposed();
				this.requestUri = value;
			}
		}

		// Token: 0x17000AB5 RID: 2741
		// (get) Token: 0x06002533 RID: 9523 RVA: 0x00082F4C File Offset: 0x0008114C
		public HttpRequestHeaders Headers
		{
			get
			{
				if (this.headers == null)
				{
					this.headers = new HttpRequestHeaders();
				}
				return this.headers;
			}
		}

		// Token: 0x17000AB6 RID: 2742
		// (get) Token: 0x06002534 RID: 9524 RVA: 0x00082F6C File Offset: 0x0008116C
		public IDictionary<string, object> Properties
		{
			get
			{
				if (this.properties == null)
				{
					this.properties = new Dictionary<string, object>();
				}
				return this.properties;
			}
		}

		// Token: 0x06002535 RID: 9525 RVA: 0x00082F8C File Offset: 0x0008118C
		public HttpRequestMessage() : this(HttpMethod.Get, null)
		{
		}

		// Token: 0x06002536 RID: 9526 RVA: 0x00082F9C File Offset: 0x0008119C
		public HttpRequestMessage(HttpMethod method, Uri requestUri)
		{
			if (Logging.On)
			{
				Logging.Enter(Logging.Http, this, ".ctor", string.Concat(new object[]
				{
					"Method: ",
					method,
					", Uri: '",
					requestUri,
					"'"
				}));
			}
			this.InitializeValues(method, requestUri);
			if (Logging.On)
			{
				Logging.Exit(Logging.Http, this, ".ctor", null);
			}
		}

		// Token: 0x06002537 RID: 9527 RVA: 0x00083020 File Offset: 0x00081220
		public HttpRequestMessage(HttpMethod method, string requestUri)
		{
			if (Logging.On)
			{
				Logging.Enter(Logging.Http, this, ".ctor", string.Concat(new object[]
				{
					"Method: ",
					method,
					", Uri: '",
					requestUri,
					"'"
				}));
			}
			if (string.IsNullOrEmpty(requestUri))
			{
				this.InitializeValues(method, null);
			}
			else
			{
				this.InitializeValues(method, new Uri(requestUri, UriKind.RelativeOrAbsolute));
			}
			if (Logging.On)
			{
				Logging.Exit(Logging.Http, this, ".ctor", null);
			}
		}

		// Token: 0x06002538 RID: 9528 RVA: 0x000830C0 File Offset: 0x000812C0
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("Method: ");
			stringBuilder.Append(this.method);
			stringBuilder.Append(", RequestUri: '");
			stringBuilder.Append((this.requestUri == null) ? "<null>" : this.requestUri.ToString());
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

		// Token: 0x06002539 RID: 9529 RVA: 0x000831CC File Offset: 0x000813CC
		private void InitializeValues(HttpMethod method, Uri requestUri)
		{
			if (method == null)
			{
				throw new ArgumentNullException("method");
			}
			if (requestUri != null && requestUri.IsAbsoluteUri && !HttpUtilities.IsHttpUri(requestUri))
			{
				throw new ArgumentException(SR.net_http_client_http_baseaddress_required, "requestUri");
			}
			this.method = method;
			this.requestUri = requestUri;
			this.version = HttpUtilities.DefaultVersion;
		}

		// Token: 0x0600253A RID: 9530 RVA: 0x00083240 File Offset: 0x00081440
		internal bool MarkAsSent()
		{
			return Interlocked.Exchange(ref this.sendStatus, 1) == 0;
		}

		// Token: 0x0600253B RID: 9531 RVA: 0x00083254 File Offset: 0x00081454
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

		// Token: 0x0600253C RID: 9532 RVA: 0x00083284 File Offset: 0x00081484
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x0600253D RID: 9533 RVA: 0x00083294 File Offset: 0x00081494
		private void CheckDisposed()
		{
			if (this.disposed)
			{
				throw new ObjectDisposedException(base.GetType().FullName);
			}
		}

		// Token: 0x040010D2 RID: 4306
		private const int messageAlreadySent = 1;

		// Token: 0x040010D3 RID: 4307
		private const int messageNotYetSent = 0;

		// Token: 0x040010D4 RID: 4308
		private int sendStatus;

		// Token: 0x040010D5 RID: 4309
		private HttpMethod method;

		// Token: 0x040010D6 RID: 4310
		private Uri requestUri;

		// Token: 0x040010D7 RID: 4311
		private HttpRequestHeaders headers;

		// Token: 0x040010D8 RID: 4312
		private Version version;

		// Token: 0x040010D9 RID: 4313
		private HttpContent content;

		// Token: 0x040010DA RID: 4314
		private bool disposed;

		// Token: 0x040010DB RID: 4315
		private IDictionary<string, object> properties;
	}
}
