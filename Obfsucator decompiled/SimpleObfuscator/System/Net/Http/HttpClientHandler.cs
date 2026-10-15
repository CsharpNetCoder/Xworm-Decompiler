using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Security;
using System.Security.Permissions;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net.Http
{
	// Token: 0x02000312 RID: 786
	public class HttpClientHandler : HttpMessageHandler
	{
		// Token: 0x17000A9A RID: 2714
		// (get) Token: 0x060024DF RID: 9439 RVA: 0x00081904 File Offset: 0x0007FB04
		public virtual bool SupportsAutomaticDecompression
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000A9B RID: 2715
		// (get) Token: 0x060024E0 RID: 9440 RVA: 0x00081908 File Offset: 0x0007FB08
		public virtual bool SupportsProxy
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000A9C RID: 2716
		// (get) Token: 0x060024E1 RID: 9441 RVA: 0x0008190C File Offset: 0x0007FB0C
		public virtual bool SupportsRedirectConfiguration
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000A9D RID: 2717
		// (get) Token: 0x060024E2 RID: 9442 RVA: 0x00081910 File Offset: 0x0007FB10
		// (set) Token: 0x060024E3 RID: 9443 RVA: 0x00081918 File Offset: 0x0007FB18
		public bool UseCookies
		{
			get
			{
				return this.useCookies;
			}
			set
			{
				this.CheckDisposedOrStarted();
				this.useCookies = value;
			}
		}

		// Token: 0x17000A9E RID: 2718
		// (get) Token: 0x060024E4 RID: 9444 RVA: 0x00081928 File Offset: 0x0007FB28
		// (set) Token: 0x060024E5 RID: 9445 RVA: 0x00081930 File Offset: 0x0007FB30
		public CookieContainer CookieContainer
		{
			get
			{
				return this.cookieContainer;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("value");
				}
				if (!this.UseCookies)
				{
					throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture, SR.net_http_invalid_enable_first, new object[]
					{
						"UseCookies",
						"true"
					}));
				}
				this.CheckDisposedOrStarted();
				this.cookieContainer = value;
			}
		}

		// Token: 0x17000A9F RID: 2719
		// (get) Token: 0x060024E6 RID: 9446 RVA: 0x00081998 File Offset: 0x0007FB98
		// (set) Token: 0x060024E7 RID: 9447 RVA: 0x000819A0 File Offset: 0x0007FBA0
		public ClientCertificateOption ClientCertificateOptions
		{
			get
			{
				return this.clientCertOptions;
			}
			set
			{
				if (value != ClientCertificateOption.Manual && value != ClientCertificateOption.Automatic)
				{
					throw new ArgumentOutOfRangeException("value");
				}
				this.CheckDisposedOrStarted();
				this.clientCertOptions = value;
			}
		}

		// Token: 0x17000AA0 RID: 2720
		// (get) Token: 0x060024E8 RID: 9448 RVA: 0x000819C8 File Offset: 0x0007FBC8
		// (set) Token: 0x060024E9 RID: 9449 RVA: 0x000819D0 File Offset: 0x0007FBD0
		public DecompressionMethods AutomaticDecompression
		{
			get
			{
				return this.automaticDecompression;
			}
			set
			{
				this.CheckDisposedOrStarted();
				this.automaticDecompression = value;
			}
		}

		// Token: 0x17000AA1 RID: 2721
		// (get) Token: 0x060024EA RID: 9450 RVA: 0x000819E0 File Offset: 0x0007FBE0
		// (set) Token: 0x060024EB RID: 9451 RVA: 0x000819E8 File Offset: 0x0007FBE8
		public bool UseProxy
		{
			get
			{
				return this.useProxy;
			}
			set
			{
				this.CheckDisposedOrStarted();
				this.useProxy = value;
			}
		}

		// Token: 0x17000AA2 RID: 2722
		// (get) Token: 0x060024EC RID: 9452 RVA: 0x000819F8 File Offset: 0x0007FBF8
		// (set) Token: 0x060024ED RID: 9453 RVA: 0x00081A00 File Offset: 0x0007FC00
		public IWebProxy Proxy
		{
			get
			{
				return this.proxy;
			}
			[SecuritySafeCritical]
			set
			{
				if (!this.UseProxy && value != null)
				{
					throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture, SR.net_http_invalid_enable_first, new object[]
					{
						"UseProxy",
						"true"
					}));
				}
				this.CheckDisposedOrStarted();
				ExceptionHelper.WebPermissionUnrestricted.Demand();
				this.proxy = value;
			}
		}

		// Token: 0x17000AA3 RID: 2723
		// (get) Token: 0x060024EE RID: 9454 RVA: 0x00081A68 File Offset: 0x0007FC68
		// (set) Token: 0x060024EF RID: 9455 RVA: 0x00081A70 File Offset: 0x0007FC70
		public bool PreAuthenticate
		{
			get
			{
				return this.preAuthenticate;
			}
			set
			{
				this.CheckDisposedOrStarted();
				this.preAuthenticate = value;
			}
		}

		// Token: 0x17000AA4 RID: 2724
		// (get) Token: 0x060024F0 RID: 9456 RVA: 0x00081A80 File Offset: 0x0007FC80
		// (set) Token: 0x060024F1 RID: 9457 RVA: 0x00081A88 File Offset: 0x0007FC88
		public bool UseDefaultCredentials
		{
			get
			{
				return this.useDefaultCredentials;
			}
			set
			{
				this.CheckDisposedOrStarted();
				this.useDefaultCredentials = value;
			}
		}

		// Token: 0x17000AA5 RID: 2725
		// (get) Token: 0x060024F2 RID: 9458 RVA: 0x00081A98 File Offset: 0x0007FC98
		// (set) Token: 0x060024F3 RID: 9459 RVA: 0x00081AA0 File Offset: 0x0007FCA0
		public ICredentials Credentials
		{
			get
			{
				return this.credentials;
			}
			set
			{
				this.CheckDisposedOrStarted();
				this.credentials = value;
			}
		}

		// Token: 0x17000AA6 RID: 2726
		// (get) Token: 0x060024F4 RID: 9460 RVA: 0x00081AB0 File Offset: 0x0007FCB0
		// (set) Token: 0x060024F5 RID: 9461 RVA: 0x00081AB8 File Offset: 0x0007FCB8
		public bool AllowAutoRedirect
		{
			get
			{
				return this.allowAutoRedirect;
			}
			set
			{
				this.CheckDisposedOrStarted();
				this.allowAutoRedirect = value;
			}
		}

		// Token: 0x17000AA7 RID: 2727
		// (get) Token: 0x060024F6 RID: 9462 RVA: 0x00081AC8 File Offset: 0x0007FCC8
		// (set) Token: 0x060024F7 RID: 9463 RVA: 0x00081AD0 File Offset: 0x0007FCD0
		public int MaxAutomaticRedirections
		{
			get
			{
				return this.maxAutomaticRedirections;
			}
			set
			{
				if (value <= 0)
				{
					throw new ArgumentOutOfRangeException("value");
				}
				this.CheckDisposedOrStarted();
				this.maxAutomaticRedirections = value;
			}
		}

		// Token: 0x17000AA8 RID: 2728
		// (get) Token: 0x060024F8 RID: 9464 RVA: 0x00081AF4 File Offset: 0x0007FCF4
		// (set) Token: 0x060024F9 RID: 9465 RVA: 0x00081AFC File Offset: 0x0007FCFC
		public long MaxRequestContentBufferSize
		{
			get
			{
				return this.maxRequestContentBufferSize;
			}
			set
			{
				if (value < 0L)
				{
					throw new ArgumentOutOfRangeException("value");
				}
				if (value > 2147483647L)
				{
					throw new ArgumentOutOfRangeException("value", value, string.Format(CultureInfo.InvariantCulture, SR.net_http_content_buffersize_limit, new object[]
					{
						2147483647L
					}));
				}
				this.CheckDisposedOrStarted();
				this.maxRequestContentBufferSize = value;
			}
		}

		// Token: 0x060024FA RID: 9466 RVA: 0x00081B70 File Offset: 0x0007FD70
		public HttpClientHandler()
		{
			this.startRequest = new Action<object>(this.StartRequest);
			this.getRequestStreamCallback = new AsyncCallback(this.GetRequestStreamCallback);
			this.getResponseCallback = new AsyncCallback(this.GetResponseCallback);
			this.connectionGroupName = RuntimeHelpers.GetHashCode(this).ToString(NumberFormatInfo.InvariantInfo);
			this.allowAutoRedirect = true;
			this.maxRequestContentBufferSize = 2147483647L;
			this.automaticDecompression = DecompressionMethods.None;
			this.cookieContainer = new CookieContainer();
			this.credentials = null;
			this.maxAutomaticRedirections = 50;
			this.preAuthenticate = false;
			this.proxy = null;
			this.useProxy = true;
			this.useCookies = true;
			this.useDefaultCredentials = false;
			this.clientCertOptions = ClientCertificateOption.Manual;
		}

		// Token: 0x060024FB RID: 9467 RVA: 0x00081C34 File Offset: 0x0007FE34
		protected override void Dispose(bool disposing)
		{
			if (disposing && !this.disposed)
			{
				this.disposed = true;
				if (this.lastUsedRequestUri != null)
				{
					ServicePoint servicePoint = ServicePointManager.FindServicePoint(this.lastUsedRequestUri);
					if (servicePoint != null)
					{
						servicePoint.CloseConnectionGroup(this.connectionGroupName);
					}
				}
			}
			base.Dispose(disposing);
		}

		// Token: 0x060024FC RID: 9468 RVA: 0x00081C98 File Offset: 0x0007FE98
		private HttpWebRequest CreateAndPrepareWebRequest(HttpRequestMessage request)
		{
			HttpWebRequest httpWebRequest = WebRequest.CreateDefault(request.RequestUri) as HttpWebRequest;
			httpWebRequest.ConnectionGroupName = this.connectionGroupName;
			if (Logging.On)
			{
				Logging.Associate(Logging.Http, request, httpWebRequest);
			}
			httpWebRequest.Method = request.Method.Method;
			httpWebRequest.ProtocolVersion = request.Version;
			this.SetDefaultOptions(httpWebRequest);
			HttpClientHandler.SetConnectionOptions(httpWebRequest, request);
			this.SetServicePointOptions(httpWebRequest, request);
			HttpClientHandler.SetRequestHeaders(httpWebRequest, request);
			HttpClientHandler.SetContentHeaders(httpWebRequest, request);
			this.InitializeWebRequest(request, httpWebRequest);
			return httpWebRequest;
		}

		// Token: 0x060024FD RID: 9469 RVA: 0x00081D28 File Offset: 0x0007FF28
		internal virtual void InitializeWebRequest(HttpRequestMessage request, HttpWebRequest webRequest)
		{
		}

		// Token: 0x060024FE RID: 9470 RVA: 0x00081D2C File Offset: 0x0007FF2C
		private void SetDefaultOptions(HttpWebRequest webRequest)
		{
			webRequest.Timeout = -1;
			webRequest.AllowAutoRedirect = this.allowAutoRedirect;
			webRequest.AutomaticDecompression = this.automaticDecompression;
			webRequest.PreAuthenticate = this.preAuthenticate;
			if (this.useDefaultCredentials)
			{
				webRequest.UseDefaultCredentials = true;
			}
			else
			{
				webRequest.Credentials = this.credentials;
			}
			if (this.allowAutoRedirect)
			{
				webRequest.MaximumAutomaticRedirections = this.maxAutomaticRedirections;
			}
			if (this.useProxy)
			{
				if (this.proxy != null)
				{
					webRequest.Proxy = this.proxy;
				}
			}
			else
			{
				webRequest.Proxy = null;
			}
			if (this.useCookies)
			{
				webRequest.CookieContainer = this.cookieContainer;
			}
		}

		// Token: 0x060024FF RID: 9471 RVA: 0x00081DE8 File Offset: 0x0007FFE8
		private static void SetConnectionOptions(HttpWebRequest webRequest, HttpRequestMessage request)
		{
			if (request.Version <= HttpVersion.Version10)
			{
				bool keepAlive = false;
				foreach (string strA in request.Headers.Connection)
				{
					if (string.Compare(strA, "Keep-Alive", StringComparison.OrdinalIgnoreCase) == 0)
					{
						keepAlive = true;
						break;
					}
				}
				webRequest.KeepAlive = keepAlive;
				return;
			}
			if (request.Headers.ConnectionClose == true)
			{
				webRequest.KeepAlive = false;
			}
		}

		// Token: 0x06002500 RID: 9472 RVA: 0x00081EA4 File Offset: 0x000800A4
		private void SetServicePointOptions(HttpWebRequest webRequest, HttpRequestMessage request)
		{
			HttpRequestHeaders headers = request.Headers;
			bool? expectContinue = headers.ExpectContinue;
			if (expectContinue != null)
			{
				ServicePoint servicePoint = webRequest.ServicePoint;
				servicePoint.Expect100Continue = expectContinue.Value;
			}
		}

		// Token: 0x06002501 RID: 9473 RVA: 0x00081EE8 File Offset: 0x000800E8
		private static void SetRequestHeaders(HttpWebRequest webRequest, HttpRequestMessage request)
		{
			WebHeaderCollection headers = webRequest.Headers;
			HttpRequestHeaders headers2 = request.Headers;
			bool flag = headers2.Contains("Host");
			bool flag2 = headers2.Contains("Expect");
			bool flag3 = headers2.Contains("Transfer-Encoding");
			bool flag4 = headers2.Contains("Connection");
			bool flag5 = headers2.Contains("Accept");
			bool flag6 = headers2.Contains("Range");
			bool flag7 = headers2.Contains("Referer");
			bool flag8 = headers2.Contains("User-Agent");
			bool flag9 = headers2.Contains("Date");
			bool flag10 = headers2.Contains("If-Modified-Since");
			if (flag9)
			{
				DateTimeOffset? date = headers2.Date;
				if (date != null)
				{
					webRequest.Date = date.Value.UtcDateTime;
				}
			}
			if (flag10)
			{
				DateTimeOffset? ifModifiedSince = headers2.IfModifiedSince;
				if (ifModifiedSince != null)
				{
					webRequest.IfModifiedSince = ifModifiedSince.Value.UtcDateTime;
				}
			}
			if (flag6)
			{
				RangeHeaderValue range = headers2.Range;
				if (range != null)
				{
					foreach (RangeItemHeaderValue rangeItemHeaderValue in range.Ranges)
					{
						webRequest.AddRange(rangeItemHeaderValue.From.Value, rangeItemHeaderValue.To.Value);
					}
				}
			}
			if (flag7)
			{
				Uri referrer = headers2.Referrer;
				if (referrer != null)
				{
					webRequest.Referer = referrer.OriginalString;
				}
			}
			if (flag5 && headers2.Accept.Count > 0)
			{
				webRequest.Accept = headers2.Accept.ToString();
			}
			if (flag8 && headers2.UserAgent.Count > 0)
			{
				webRequest.UserAgent = headers2.UserAgent.ToString();
			}
			if (flag)
			{
				string host = headers2.Host;
				if (host != null)
				{
					webRequest.Host = host;
				}
			}
			if (flag2)
			{
				string headerStringWithoutSpecial = headers2.Expect.GetHeaderStringWithoutSpecial();
				if (!string.IsNullOrEmpty(headerStringWithoutSpecial) || !headers2.Expect.IsSpecialValueSet)
				{
					webRequest.Expect = headerStringWithoutSpecial;
				}
			}
			if (flag3)
			{
				string headerStringWithoutSpecial2 = headers2.TransferEncoding.GetHeaderStringWithoutSpecial();
				if (!string.IsNullOrEmpty(headerStringWithoutSpecial2) || !headers2.TransferEncoding.IsSpecialValueSet)
				{
					webRequest.SendChunked = true;
					webRequest.TransferEncoding = headerStringWithoutSpecial2;
					webRequest.SendChunked = false;
				}
			}
			if (flag4)
			{
				string text = string.Join(", ", from item in headers2.Connection
				where string.Compare(item, "Keep-Alive", StringComparison.OrdinalIgnoreCase) != 0 && string.Compare(item, "close", StringComparison.OrdinalIgnoreCase) != 0
				select item);
				if (!string.IsNullOrEmpty(text) || !headers2.Connection.IsSpecialValueSet)
				{
					webRequest.Connection = text;
				}
			}
			foreach (KeyValuePair<string, string> keyValuePair in request.Headers.GetHeaderStrings())
			{
				string key = keyValuePair.Key;
				if ((!flag || !HttpClientHandler.AreEqual("Host", key)) && (!flag2 || !HttpClientHandler.AreEqual("Expect", key)) && (!flag3 || !HttpClientHandler.AreEqual("Transfer-Encoding", key)) && (!flag5 || !HttpClientHandler.AreEqual("Accept", key)) && (!flag6 || !HttpClientHandler.AreEqual("Range", key)) && (!flag7 || !HttpClientHandler.AreEqual("Referer", key)) && (!flag8 || !HttpClientHandler.AreEqual("User-Agent", key)) && (!flag9 || !HttpClientHandler.AreEqual("Date", key)) && (!flag10 || !HttpClientHandler.AreEqual("If-Modified-Since", key)) && (!flag4 || !HttpClientHandler.AreEqual("Connection", key)))
				{
					headers.Add(keyValuePair.Key, keyValuePair.Value);
				}
			}
		}

		// Token: 0x06002502 RID: 9474 RVA: 0x00082350 File Offset: 0x00080550
		private static void SetContentHeaders(HttpWebRequest webRequest, HttpRequestMessage request)
		{
			if (request.Content != null)
			{
				HttpContentHeaders headers = request.Content.Headers;
				if (headers.Contains("Content-Length"))
				{
					using (IEnumerator<KeyValuePair<string, IEnumerable<string>>> enumerator = request.Content.Headers.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							KeyValuePair<string, IEnumerable<string>> header = enumerator.Current;
							if (string.Compare("Content-Length", header.Key, StringComparison.OrdinalIgnoreCase) != 0)
							{
								HttpClientHandler.SetContentHeader(webRequest, header);
							}
						}
						return;
					}
				}
				foreach (KeyValuePair<string, IEnumerable<string>> header2 in request.Content.Headers)
				{
					HttpClientHandler.SetContentHeader(webRequest, header2);
				}
			}
		}

		// Token: 0x06002503 RID: 9475 RVA: 0x00082438 File Offset: 0x00080638
		private static void SetContentHeader(HttpWebRequest webRequest, KeyValuePair<string, IEnumerable<string>> header)
		{
			if (string.Compare("Content-Type", header.Key, StringComparison.OrdinalIgnoreCase) == 0)
			{
				webRequest.ContentType = string.Join(", ", header.Value);
				return;
			}
			webRequest.Headers.Add(header.Key, string.Join(", ", header.Value));
		}

		// Token: 0x06002504 RID: 9476 RVA: 0x0008249C File Offset: 0x0008069C
		protected internal override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
		{
			if (request == null)
			{
				throw new ArgumentNullException("request", SR.net_http_handler_norequest);
			}
			this.CheckDisposed();
			if (Logging.On)
			{
				Logging.Enter(Logging.Http, this, "SendAsync", request);
			}
			this.SetOperationStarted();
			TaskCompletionSource<HttpResponseMessage> taskCompletionSource = new TaskCompletionSource<HttpResponseMessage>();
			HttpClientHandler.RequestState requestState = new HttpClientHandler.RequestState();
			requestState.tcs = taskCompletionSource;
			requestState.cancellationToken = cancellationToken;
			requestState.requestMessage = request;
			this.lastUsedRequestUri = request.RequestUri;
			try
			{
				HttpWebRequest httpWebRequest = this.CreateAndPrepareWebRequest(request);
				requestState.webRequest = httpWebRequest;
				cancellationToken.Register(HttpClientHandler.onCancel, httpWebRequest);
				if (ExecutionContext.IsFlowSuppressed())
				{
					IWebProxy webProxy = null;
					if (this.useProxy)
					{
						webProxy = (this.proxy ?? WebRequest.DefaultWebProxy);
					}
					if (this.UseDefaultCredentials || this.Credentials != null || (webProxy != null && webProxy.Credentials != null))
					{
						this.SafeCaptureIdenity(requestState);
					}
				}
				Task.Factory.StartNew(this.startRequest, requestState);
			}
			catch (Exception e)
			{
				this.HandleAsyncException(requestState, e);
			}
			if (Logging.On)
			{
				Logging.Exit(Logging.Http, this, "SendAsync", taskCompletionSource.Task);
			}
			return taskCompletionSource.Task;
		}

		// Token: 0x06002505 RID: 9477 RVA: 0x000825E8 File Offset: 0x000807E8
		private void StartRequest(object obj)
		{
			HttpClientHandler.RequestState requestState = obj as HttpClientHandler.RequestState;
			try
			{
				if (requestState.requestMessage.Content != null)
				{
					this.PrepareAndStartContentUpload(requestState);
				}
				else
				{
					requestState.webRequest.ContentLength = 0L;
					this.StartGettingResponse(requestState);
				}
			}
			catch (Exception e)
			{
				this.HandleAsyncException(requestState, e);
			}
		}

		// Token: 0x06002506 RID: 9478 RVA: 0x00082650 File Offset: 0x00080850
		private void PrepareAndStartContentUpload(HttpClientHandler.RequestState state)
		{
			HttpContent requestContent = state.requestMessage.Content;
			try
			{
				if (state.requestMessage.Headers.TransferEncodingChunked == true)
				{
					state.webRequest.SendChunked = true;
					this.StartGettingRequestStream(state);
				}
				else
				{
					long? contentLength = requestContent.Headers.ContentLength;
					if (contentLength != null)
					{
						state.webRequest.ContentLength = contentLength.Value;
						this.StartGettingRequestStream(state);
					}
					else
					{
						if (this.maxRequestContentBufferSize == 0L)
						{
							throw new HttpRequestException(SR.net_http_handler_nocontentlength);
						}
						requestContent.LoadIntoBufferAsync(this.maxRequestContentBufferSize).ContinueWithStandard(delegate(Task task)
						{
							if (task.IsFaulted)
							{
								this.HandleAsyncException(state, task.Exception.GetBaseException());
								return;
							}
							contentLength = requestContent.Headers.ContentLength;
							state.webRequest.ContentLength = contentLength.Value;
							this.StartGettingRequestStream(state);
						});
					}
				}
			}
			catch (Exception e)
			{
				this.HandleAsyncException(state, e);
			}
		}

		// Token: 0x06002507 RID: 9479 RVA: 0x000827AC File Offset: 0x000809AC
		private void StartGettingRequestStream(HttpClientHandler.RequestState state)
		{
			if (state.identity != null)
			{
				using (state.identity.Impersonate())
				{
					state.webRequest.BeginGetRequestStream(this.getRequestStreamCallback, state);
					return;
				}
			}
			state.webRequest.BeginGetRequestStream(this.getRequestStreamCallback, state);
		}

		// Token: 0x06002508 RID: 9480 RVA: 0x00082818 File Offset: 0x00080A18
		private void GetRequestStreamCallback(IAsyncResult ar)
		{
			HttpClientHandler.RequestState state = ar.AsyncState as HttpClientHandler.RequestState;
			try
			{
				TransportContext context = null;
				Stream stream = state.webRequest.EndGetRequestStream(ar, out context);
				state.requestStream = stream;
				state.requestMessage.Content.CopyToAsync(stream, context).ContinueWithStandard(delegate(Task task)
				{
					try
					{
						if (task.IsFaulted)
						{
							this.HandleAsyncException(state, task.Exception.GetBaseException());
						}
						else if (task.IsCanceled)
						{
							state.tcs.TrySetCanceled();
						}
						else
						{
							state.requestStream.Close();
							this.StartGettingResponse(state);
						}
					}
					catch (Exception e2)
					{
						this.HandleAsyncException(state, e2);
					}
				});
			}
			catch (Exception e)
			{
				this.HandleAsyncException(state, e);
			}
		}

		// Token: 0x06002509 RID: 9481 RVA: 0x000828C4 File Offset: 0x00080AC4
		private void StartGettingResponse(HttpClientHandler.RequestState state)
		{
			if (state.identity != null)
			{
				using (state.identity.Impersonate())
				{
					state.webRequest.BeginGetResponse(this.getResponseCallback, state);
					return;
				}
			}
			state.webRequest.BeginGetResponse(this.getResponseCallback, state);
		}

		// Token: 0x0600250A RID: 9482 RVA: 0x00082930 File Offset: 0x00080B30
		private void GetResponseCallback(IAsyncResult ar)
		{
			HttpClientHandler.RequestState requestState = ar.AsyncState as HttpClientHandler.RequestState;
			try
			{
				HttpWebResponse webResponse = requestState.webRequest.EndGetResponse(ar) as HttpWebResponse;
				requestState.tcs.TrySetResult(this.CreateResponseMessage(webResponse, requestState.requestMessage));
			}
			catch (Exception e)
			{
				this.HandleAsyncException(requestState, e);
			}
		}

		// Token: 0x0600250B RID: 9483 RVA: 0x00082998 File Offset: 0x00080B98
		private bool TryGetExceptionResponse(WebException webException, HttpRequestMessage requestMessage, out HttpResponseMessage httpResponseMessage)
		{
			if (webException != null && webException.Response != null)
			{
				HttpWebResponse httpWebResponse = webException.Response as HttpWebResponse;
				if (httpWebResponse != null)
				{
					httpResponseMessage = this.CreateResponseMessage(httpWebResponse, requestMessage);
					return true;
				}
			}
			httpResponseMessage = null;
			return false;
		}

		// Token: 0x0600250C RID: 9484 RVA: 0x000829DC File Offset: 0x00080BDC
		private HttpResponseMessage CreateResponseMessage(HttpWebResponse webResponse, HttpRequestMessage request)
		{
			HttpResponseMessage httpResponseMessage = new HttpResponseMessage(webResponse.StatusCode);
			httpResponseMessage.ReasonPhrase = webResponse.StatusDescription;
			httpResponseMessage.Version = webResponse.ProtocolVersion;
			httpResponseMessage.RequestMessage = request;
			httpResponseMessage.Content = new StreamContent(new HttpClientHandler.WebExceptionWrapperStream(webResponse.GetResponseStream()));
			request.RequestUri = webResponse.ResponseUri;
			WebHeaderCollection headers = webResponse.Headers;
			HttpContentHeaders headers2 = httpResponseMessage.Content.Headers;
			HttpResponseHeaders headers3 = httpResponseMessage.Headers;
			if (webResponse.ContentLength >= 0L)
			{
				headers2.ContentLength = new long?(webResponse.ContentLength);
			}
			for (int i = 0; i < headers.Count; i++)
			{
				string key = headers.GetKey(i);
				if (string.Compare(key, "Content-Length", StringComparison.OrdinalIgnoreCase) != 0)
				{
					string[] values = headers.GetValues(i);
					if (!headers3.TryAddWithoutValidation(key, values))
					{
						headers2.TryAddWithoutValidation(key, values);
					}
				}
			}
			return httpResponseMessage;
		}

		// Token: 0x0600250D RID: 9485 RVA: 0x00082ACC File Offset: 0x00080CCC
		private void HandleAsyncException(HttpClientHandler.RequestState state, Exception e)
		{
			if (Logging.On)
			{
				Logging.Exception(Logging.Http, this, "SendAsync", e);
			}
			HttpResponseMessage result;
			if (this.TryGetExceptionResponse(e as WebException, state.requestMessage, out result))
			{
				state.tcs.TrySetResult(result);
				return;
			}
			if (state.cancellationToken.IsCancellationRequested)
			{
				state.tcs.TrySetCanceled();
				return;
			}
			if (e is WebException || e is IOException)
			{
				state.tcs.TrySetException(new HttpRequestException(SR.net_http_client_execution_error, e));
				return;
			}
			state.tcs.TrySetException(e);
		}

		// Token: 0x0600250E RID: 9486 RVA: 0x00082B78 File Offset: 0x00080D78
		private static void OnCancel(object state)
		{
			HttpWebRequest httpWebRequest = state as HttpWebRequest;
			httpWebRequest.Abort();
		}

		// Token: 0x0600250F RID: 9487 RVA: 0x00082B98 File Offset: 0x00080D98
		private void SetOperationStarted()
		{
			if (!this.operationStarted)
			{
				this.operationStarted = true;
			}
		}

		// Token: 0x06002510 RID: 9488 RVA: 0x00082BB0 File Offset: 0x00080DB0
		private void CheckDisposed()
		{
			if (this.disposed)
			{
				throw new ObjectDisposedException(base.GetType().FullName);
			}
		}

		// Token: 0x06002511 RID: 9489 RVA: 0x00082BD0 File Offset: 0x00080DD0
		internal void CheckDisposedOrStarted()
		{
			this.CheckDisposed();
			if (this.operationStarted)
			{
				throw new InvalidOperationException(SR.net_http_operation_started);
			}
		}

		// Token: 0x06002512 RID: 9490 RVA: 0x00082BF0 File Offset: 0x00080DF0
		private static bool AreEqual(string x, string y)
		{
			return string.Compare(x, y, StringComparison.OrdinalIgnoreCase) == 0;
		}

		// Token: 0x06002513 RID: 9491 RVA: 0x00082C00 File Offset: 0x00080E00
		[SecuritySafeCritical]
		[SecurityPermission(SecurityAction.Assert, Flags = SecurityPermissionFlag.ControlPrincipal)]
		private void SafeCaptureIdenity(HttpClientHandler.RequestState state)
		{
			state.identity = WindowsIdentity.GetCurrent();
		}

		// Token: 0x040010AD RID: 4269
		private static readonly Action<object> onCancel = new Action<object>(HttpClientHandler.OnCancel);

		// Token: 0x040010AE RID: 4270
		private readonly Action<object> startRequest;

		// Token: 0x040010AF RID: 4271
		private readonly AsyncCallback getRequestStreamCallback;

		// Token: 0x040010B0 RID: 4272
		private readonly AsyncCallback getResponseCallback;

		// Token: 0x040010B1 RID: 4273
		private volatile bool operationStarted;

		// Token: 0x040010B2 RID: 4274
		private volatile bool disposed;

		// Token: 0x040010B3 RID: 4275
		private long maxRequestContentBufferSize;

		// Token: 0x040010B4 RID: 4276
		private CookieContainer cookieContainer;

		// Token: 0x040010B5 RID: 4277
		private bool useCookies;

		// Token: 0x040010B6 RID: 4278
		private DecompressionMethods automaticDecompression;

		// Token: 0x040010B7 RID: 4279
		private IWebProxy proxy;

		// Token: 0x040010B8 RID: 4280
		private bool useProxy;

		// Token: 0x040010B9 RID: 4281
		private bool preAuthenticate;

		// Token: 0x040010BA RID: 4282
		private bool useDefaultCredentials;

		// Token: 0x040010BB RID: 4283
		private ICredentials credentials;

		// Token: 0x040010BC RID: 4284
		private bool allowAutoRedirect;

		// Token: 0x040010BD RID: 4285
		private int maxAutomaticRedirections;

		// Token: 0x040010BE RID: 4286
		private string connectionGroupName;

		// Token: 0x040010BF RID: 4287
		private ClientCertificateOption clientCertOptions;

		// Token: 0x040010C0 RID: 4288
		private Uri lastUsedRequestUri;

		// Token: 0x020003C9 RID: 969
		private class RequestState
		{
			// Token: 0x04001404 RID: 5124
			internal HttpWebRequest webRequest;

			// Token: 0x04001405 RID: 5125
			internal TaskCompletionSource<HttpResponseMessage> tcs;

			// Token: 0x04001406 RID: 5126
			internal CancellationToken cancellationToken;

			// Token: 0x04001407 RID: 5127
			internal HttpRequestMessage requestMessage;

			// Token: 0x04001408 RID: 5128
			internal Stream requestStream;

			// Token: 0x04001409 RID: 5129
			internal WindowsIdentity identity;
		}

		// Token: 0x020003CA RID: 970
		private class WebExceptionWrapperStream : DelegatingStream
		{
			// Token: 0x0600287A RID: 10362 RVA: 0x0008E5DC File Offset: 0x0008C7DC
			internal WebExceptionWrapperStream(Stream innerStream) : base(innerStream)
			{
			}

			// Token: 0x0600287B RID: 10363 RVA: 0x0008E5E8 File Offset: 0x0008C7E8
			public override int Read(byte[] buffer, int offset, int count)
			{
				int result;
				try
				{
					result = base.Read(buffer, offset, count);
				}
				catch (WebException innerException)
				{
					throw new IOException(SR.net_http_read_error, innerException);
				}
				return result;
			}

			// Token: 0x0600287C RID: 10364 RVA: 0x0008E624 File Offset: 0x0008C824
			public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
			{
				IAsyncResult result;
				try
				{
					result = base.BeginRead(buffer, offset, count, callback, state);
				}
				catch (WebException innerException)
				{
					throw new IOException(SR.net_http_read_error, innerException);
				}
				return result;
			}

			// Token: 0x0600287D RID: 10365 RVA: 0x0008E664 File Offset: 0x0008C864
			public override int EndRead(IAsyncResult asyncResult)
			{
				int result;
				try
				{
					result = base.EndRead(asyncResult);
				}
				catch (WebException innerException)
				{
					throw new IOException(SR.net_http_read_error, innerException);
				}
				return result;
			}

			// Token: 0x0600287E RID: 10366 RVA: 0x0008E69C File Offset: 0x0008C89C
			public override int ReadByte()
			{
				int result;
				try
				{
					result = base.ReadByte();
				}
				catch (WebException innerException)
				{
					throw new IOException(SR.net_http_read_error, innerException);
				}
				return result;
			}
		}
	}
}
