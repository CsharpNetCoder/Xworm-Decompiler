using System;
using System.Globalization;
using System.IO;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net.Http
{
	// Token: 0x02000311 RID: 785
	public class HttpClient : HttpMessageInvoker
	{
		// Token: 0x17000A95 RID: 2709
		// (get) Token: 0x0600249D RID: 9373 RVA: 0x00080CF4 File Offset: 0x0007EEF4
		private TimerThread.Queue TimerQueue
		{
			get
			{
				if (this.timerQueue == null)
				{
					this.timerQueue = TimerThread.GetOrCreateQueue((int)this.timeout.TotalMilliseconds);
				}
				return this.timerQueue;
			}
		}

		// Token: 0x0600249E RID: 9374 RVA: 0x00080D20 File Offset: 0x0007EF20
		private static void TimeoutCallback(TimerThread.Timer timer, int timeNoticed, object context)
		{
			try
			{
				((CancellationTokenSource)context).Cancel();
			}
			catch (ObjectDisposedException)
			{
			}
			catch (AggregateException e)
			{
				if (Logging.On)
				{
					Logging.Exception(Logging.Http, context, "TimeoutCallback", e);
				}
			}
		}

		// Token: 0x17000A96 RID: 2710
		// (get) Token: 0x0600249F RID: 9375 RVA: 0x00080D80 File Offset: 0x0007EF80
		public HttpRequestHeaders DefaultRequestHeaders
		{
			get
			{
				if (this.defaultRequestHeaders == null)
				{
					this.defaultRequestHeaders = new HttpRequestHeaders();
				}
				return this.defaultRequestHeaders;
			}
		}

		// Token: 0x17000A97 RID: 2711
		// (get) Token: 0x060024A0 RID: 9376 RVA: 0x00080DA0 File Offset: 0x0007EFA0
		// (set) Token: 0x060024A1 RID: 9377 RVA: 0x00080DA8 File Offset: 0x0007EFA8
		public Uri BaseAddress
		{
			get
			{
				return this.baseAddress;
			}
			set
			{
				HttpClient.CheckBaseAddress(value, "value");
				this.CheckDisposedOrStarted();
				if (Logging.On)
				{
					Logging.PrintInfo(Logging.Http, this, "BaseAddress: '" + this.baseAddress + "'");
				}
				this.baseAddress = value;
			}
		}

		// Token: 0x17000A98 RID: 2712
		// (get) Token: 0x060024A2 RID: 9378 RVA: 0x00080DFC File Offset: 0x0007EFFC
		// (set) Token: 0x060024A3 RID: 9379 RVA: 0x00080E04 File Offset: 0x0007F004
		public TimeSpan Timeout
		{
			get
			{
				return this.timeout;
			}
			set
			{
				if (value != HttpClient.infiniteTimeout && (value <= TimeSpan.Zero || value > HttpClient.maxTimeout))
				{
					throw new ArgumentOutOfRangeException("value");
				}
				this.CheckDisposedOrStarted();
				this.timeout = value;
			}
		}

		// Token: 0x17000A99 RID: 2713
		// (get) Token: 0x060024A4 RID: 9380 RVA: 0x00080E60 File Offset: 0x0007F060
		// (set) Token: 0x060024A5 RID: 9381 RVA: 0x00080E68 File Offset: 0x0007F068
		public long MaxResponseContentBufferSize
		{
			get
			{
				return this.maxResponseContentBufferSize;
			}
			set
			{
				if (value <= 0L)
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
				this.maxResponseContentBufferSize = value;
			}
		}

		// Token: 0x060024A6 RID: 9382 RVA: 0x00080EDC File Offset: 0x0007F0DC
		public HttpClient() : this(new HttpClientHandler())
		{
		}

		// Token: 0x060024A7 RID: 9383 RVA: 0x00080EEC File Offset: 0x0007F0EC
		public HttpClient(HttpMessageHandler handler) : this(handler, true)
		{
		}

		// Token: 0x060024A8 RID: 9384 RVA: 0x00080EF8 File Offset: 0x0007F0F8
		public HttpClient(HttpMessageHandler handler, bool disposeHandler) : base(handler, disposeHandler)
		{
			if (Logging.On)
			{
				Logging.Enter(Logging.Http, this, ".ctor", handler);
			}
			this.timeout = HttpClient.defaultTimeout;
			this.maxResponseContentBufferSize = 2147483647L;
			this.pendingRequestsCts = new CancellationTokenSource();
			if (Logging.On)
			{
				Logging.Exit(Logging.Http, this, ".ctor", null);
			}
		}

		// Token: 0x060024A9 RID: 9385 RVA: 0x00080F6C File Offset: 0x0007F16C
		public Task<string> GetStringAsync(string requestUri)
		{
			return this.GetStringAsync(this.CreateUri(requestUri));
		}

		// Token: 0x060024AA RID: 9386 RVA: 0x00080F7C File Offset: 0x0007F17C
		public Task<string> GetStringAsync(Uri requestUri)
		{
			return this.GetContentAsync<string>(requestUri, HttpCompletionOption.ResponseContentRead, string.Empty, (HttpContent content) => content.ReadAsStringAsync());
		}

		// Token: 0x060024AB RID: 9387 RVA: 0x00080FBC File Offset: 0x0007F1BC
		public Task<byte[]> GetByteArrayAsync(string requestUri)
		{
			return this.GetByteArrayAsync(this.CreateUri(requestUri));
		}

		// Token: 0x060024AC RID: 9388 RVA: 0x00080FCC File Offset: 0x0007F1CC
		public Task<byte[]> GetByteArrayAsync(Uri requestUri)
		{
			return this.GetContentAsync<byte[]>(requestUri, HttpCompletionOption.ResponseContentRead, HttpUtilities.EmptyByteArray, (HttpContent content) => content.ReadAsByteArrayAsync());
		}

		// Token: 0x060024AD RID: 9389 RVA: 0x0008100C File Offset: 0x0007F20C
		public Task<Stream> GetStreamAsync(string requestUri)
		{
			return this.GetStreamAsync(this.CreateUri(requestUri));
		}

		// Token: 0x060024AE RID: 9390 RVA: 0x0008101C File Offset: 0x0007F21C
		public Task<Stream> GetStreamAsync(Uri requestUri)
		{
			return this.GetContentAsync<Stream>(requestUri, HttpCompletionOption.ResponseHeadersRead, Stream.Null, (HttpContent content) => content.ReadAsStreamAsync());
		}

		// Token: 0x060024AF RID: 9391 RVA: 0x0008105C File Offset: 0x0007F25C
		private Task<T> GetContentAsync<T>(Uri requestUri, HttpCompletionOption completionOption, T defaultValue, Func<HttpContent, Task<T>> readAs)
		{
			TaskCompletionSource<T> tcs = new TaskCompletionSource<T>();
			this.GetAsync(requestUri, completionOption).ContinueWithStandard(delegate(Task<HttpResponseMessage> requestTask)
			{
				if (HttpClient.HandleRequestFaultsAndCancelation<T>(requestTask, tcs))
				{
					return;
				}
				HttpResponseMessage result = requestTask.Result;
				if (result.Content == null)
				{
					tcs.TrySetResult(defaultValue);
					return;
				}
				try
				{
					readAs(result.Content).ContinueWithStandard(delegate(Task<T> contentTask)
					{
						if (!HttpUtilities.HandleFaultsAndCancelation<T>(contentTask, tcs))
						{
							tcs.TrySetResult(contentTask.Result);
						}
					});
				}
				catch (Exception exception)
				{
					tcs.TrySetException(exception);
				}
			});
			return tcs.Task;
		}

		// Token: 0x060024B0 RID: 9392 RVA: 0x000810BC File Offset: 0x0007F2BC
		public Task<HttpResponseMessage> GetAsync(string requestUri)
		{
			return this.GetAsync(this.CreateUri(requestUri));
		}

		// Token: 0x060024B1 RID: 9393 RVA: 0x000810CC File Offset: 0x0007F2CC
		public Task<HttpResponseMessage> GetAsync(Uri requestUri)
		{
			return this.GetAsync(requestUri, HttpCompletionOption.ResponseContentRead);
		}

		// Token: 0x060024B2 RID: 9394 RVA: 0x000810D8 File Offset: 0x0007F2D8
		public Task<HttpResponseMessage> GetAsync(string requestUri, HttpCompletionOption completionOption)
		{
			return this.GetAsync(this.CreateUri(requestUri), completionOption);
		}

		// Token: 0x060024B3 RID: 9395 RVA: 0x000810E8 File Offset: 0x0007F2E8
		public Task<HttpResponseMessage> GetAsync(Uri requestUri, HttpCompletionOption completionOption)
		{
			return this.GetAsync(requestUri, completionOption, CancellationToken.None);
		}

		// Token: 0x060024B4 RID: 9396 RVA: 0x000810F8 File Offset: 0x0007F2F8
		public Task<HttpResponseMessage> GetAsync(string requestUri, CancellationToken cancellationToken)
		{
			return this.GetAsync(this.CreateUri(requestUri), cancellationToken);
		}

		// Token: 0x060024B5 RID: 9397 RVA: 0x00081108 File Offset: 0x0007F308
		public Task<HttpResponseMessage> GetAsync(Uri requestUri, CancellationToken cancellationToken)
		{
			return this.GetAsync(requestUri, HttpCompletionOption.ResponseContentRead, cancellationToken);
		}

		// Token: 0x060024B6 RID: 9398 RVA: 0x00081114 File Offset: 0x0007F314
		public Task<HttpResponseMessage> GetAsync(string requestUri, HttpCompletionOption completionOption, CancellationToken cancellationToken)
		{
			return this.GetAsync(this.CreateUri(requestUri), completionOption, cancellationToken);
		}

		// Token: 0x060024B7 RID: 9399 RVA: 0x00081128 File Offset: 0x0007F328
		public Task<HttpResponseMessage> GetAsync(Uri requestUri, HttpCompletionOption completionOption, CancellationToken cancellationToken)
		{
			return this.SendAsync(new HttpRequestMessage(HttpMethod.Get, requestUri), completionOption, cancellationToken);
		}

		// Token: 0x060024B8 RID: 9400 RVA: 0x00081140 File Offset: 0x0007F340
		public Task<HttpResponseMessage> PostAsync(string requestUri, HttpContent content)
		{
			return this.PostAsync(this.CreateUri(requestUri), content);
		}

		// Token: 0x060024B9 RID: 9401 RVA: 0x00081150 File Offset: 0x0007F350
		public Task<HttpResponseMessage> PostAsync(Uri requestUri, HttpContent content)
		{
			return this.PostAsync(requestUri, content, CancellationToken.None);
		}

		// Token: 0x060024BA RID: 9402 RVA: 0x00081160 File Offset: 0x0007F360
		public Task<HttpResponseMessage> PostAsync(string requestUri, HttpContent content, CancellationToken cancellationToken)
		{
			return this.PostAsync(this.CreateUri(requestUri), content, cancellationToken);
		}

		// Token: 0x060024BB RID: 9403 RVA: 0x00081174 File Offset: 0x0007F374
		public Task<HttpResponseMessage> PostAsync(Uri requestUri, HttpContent content, CancellationToken cancellationToken)
		{
			return this.SendAsync(new HttpRequestMessage(HttpMethod.Post, requestUri)
			{
				Content = content
			}, cancellationToken);
		}

		// Token: 0x060024BC RID: 9404 RVA: 0x000811A0 File Offset: 0x0007F3A0
		public Task<HttpResponseMessage> PutAsync(string requestUri, HttpContent content)
		{
			return this.PutAsync(this.CreateUri(requestUri), content);
		}

		// Token: 0x060024BD RID: 9405 RVA: 0x000811B0 File Offset: 0x0007F3B0
		public Task<HttpResponseMessage> PutAsync(Uri requestUri, HttpContent content)
		{
			return this.PutAsync(requestUri, content, CancellationToken.None);
		}

		// Token: 0x060024BE RID: 9406 RVA: 0x000811C0 File Offset: 0x0007F3C0
		public Task<HttpResponseMessage> PutAsync(string requestUri, HttpContent content, CancellationToken cancellationToken)
		{
			return this.PutAsync(this.CreateUri(requestUri), content, cancellationToken);
		}

		// Token: 0x060024BF RID: 9407 RVA: 0x000811D4 File Offset: 0x0007F3D4
		public Task<HttpResponseMessage> PutAsync(Uri requestUri, HttpContent content, CancellationToken cancellationToken)
		{
			return this.SendAsync(new HttpRequestMessage(HttpMethod.Put, requestUri)
			{
				Content = content
			}, cancellationToken);
		}

		// Token: 0x060024C0 RID: 9408 RVA: 0x00081200 File Offset: 0x0007F400
		public Task<HttpResponseMessage> DeleteAsync(string requestUri)
		{
			return this.DeleteAsync(this.CreateUri(requestUri));
		}

		// Token: 0x060024C1 RID: 9409 RVA: 0x00081210 File Offset: 0x0007F410
		public Task<HttpResponseMessage> DeleteAsync(Uri requestUri)
		{
			return this.DeleteAsync(requestUri, CancellationToken.None);
		}

		// Token: 0x060024C2 RID: 9410 RVA: 0x00081220 File Offset: 0x0007F420
		public Task<HttpResponseMessage> DeleteAsync(string requestUri, CancellationToken cancellationToken)
		{
			return this.DeleteAsync(this.CreateUri(requestUri), cancellationToken);
		}

		// Token: 0x060024C3 RID: 9411 RVA: 0x00081230 File Offset: 0x0007F430
		public Task<HttpResponseMessage> DeleteAsync(Uri requestUri, CancellationToken cancellationToken)
		{
			return this.SendAsync(new HttpRequestMessage(HttpMethod.Delete, requestUri), cancellationToken);
		}

		// Token: 0x060024C4 RID: 9412 RVA: 0x00081244 File Offset: 0x0007F444
		public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request)
		{
			return this.SendAsync(request, HttpCompletionOption.ResponseContentRead, CancellationToken.None);
		}

		// Token: 0x060024C5 RID: 9413 RVA: 0x00081254 File Offset: 0x0007F454
		public override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
		{
			return this.SendAsync(request, HttpCompletionOption.ResponseContentRead, cancellationToken);
		}

		// Token: 0x060024C6 RID: 9414 RVA: 0x00081260 File Offset: 0x0007F460
		public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, HttpCompletionOption completionOption)
		{
			return this.SendAsync(request, completionOption, CancellationToken.None);
		}

		// Token: 0x060024C7 RID: 9415 RVA: 0x00081270 File Offset: 0x0007F470
		public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, HttpCompletionOption completionOption, CancellationToken cancellationToken)
		{
			if (request == null)
			{
				throw new ArgumentNullException("request");
			}
			this.CheckDisposed();
			HttpClient.CheckRequestMessage(request);
			this.SetOperationStarted();
			this.PrepareRequestMessage(request);
			CancellationTokenSource linkedCts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken, this.pendingRequestsCts.Token);
			TimerThread.Timer timeoutTimer = this.SetTimeout(linkedCts);
			TaskCompletionSource<HttpResponseMessage> tcs = new TaskCompletionSource<HttpResponseMessage>();
			try
			{
				base.SendAsync(request, linkedCts.Token).ContinueWithStandard(delegate(Task<HttpResponseMessage> task)
				{
					try
					{
						this.DisposeRequestContent(request);
						if (task.IsFaulted)
						{
							this.SetTaskFaulted(request, linkedCts, tcs, task.Exception.GetBaseException(), timeoutTimer);
						}
						else if (task.IsCanceled)
						{
							this.SetTaskCanceled(request, linkedCts, tcs, timeoutTimer);
						}
						else
						{
							HttpResponseMessage result = task.Result;
							if (result == null)
							{
								this.SetTaskFaulted(request, linkedCts, tcs, new InvalidOperationException(SR.net_http_handler_noresponse), timeoutTimer);
							}
							else if (result.Content == null || completionOption == HttpCompletionOption.ResponseHeadersRead)
							{
								this.SetTaskCompleted(request, linkedCts, tcs, result, timeoutTimer);
							}
							else
							{
								this.StartContentBuffering(request, linkedCts, tcs, result, timeoutTimer);
							}
						}
					}
					catch (Exception ex)
					{
						if (Logging.On)
						{
							Logging.Exception(Logging.Http, this, "SendAsync", ex);
						}
						tcs.TrySetException(ex);
					}
				});
			}
			catch
			{
				HttpClient.DisposeTimer(timeoutTimer);
				throw;
			}
			return tcs.Task;
		}

		// Token: 0x060024C8 RID: 9416 RVA: 0x00081368 File Offset: 0x0007F568
		public void CancelPendingRequests()
		{
			this.CheckDisposed();
			if (Logging.On)
			{
				Logging.Enter(Logging.Http, this, "CancelPendingRequests", "");
			}
			CancellationTokenSource cancellationTokenSource = Interlocked.Exchange<CancellationTokenSource>(ref this.pendingRequestsCts, new CancellationTokenSource());
			cancellationTokenSource.Cancel();
			cancellationTokenSource.Dispose();
			if (Logging.On)
			{
				Logging.Exit(Logging.Http, this, "CancelPendingRequests", "");
			}
		}

		// Token: 0x060024C9 RID: 9417 RVA: 0x000813DC File Offset: 0x0007F5DC
		protected override void Dispose(bool disposing)
		{
			if (disposing && !this.disposed)
			{
				this.disposed = true;
				this.pendingRequestsCts.Cancel();
				this.pendingRequestsCts.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060024CA RID: 9418 RVA: 0x00081418 File Offset: 0x0007F618
		private void DisposeRequestContent(HttpRequestMessage request)
		{
			HttpContent content = request.Content;
			if (content != null)
			{
				content.Dispose();
			}
		}

		// Token: 0x060024CB RID: 9419 RVA: 0x0008143C File Offset: 0x0007F63C
		private void StartContentBuffering(HttpRequestMessage request, CancellationTokenSource cancellationTokenSource, TaskCompletionSource<HttpResponseMessage> tcs, HttpResponseMessage response, TimerThread.Timer timeoutTimer)
		{
			response.Content.LoadIntoBufferAsync(this.maxResponseContentBufferSize).ContinueWithStandard(delegate(Task contentTask)
			{
				try
				{
					bool isCancellationRequested = cancellationTokenSource.Token.IsCancellationRequested;
					if (contentTask.IsFaulted)
					{
						response.Dispose();
						if (isCancellationRequested && contentTask.Exception.GetBaseException() is HttpRequestException)
						{
							this.SetTaskCanceled(request, cancellationTokenSource, tcs, timeoutTimer);
						}
						else
						{
							this.SetTaskFaulted(request, cancellationTokenSource, tcs, contentTask.Exception.GetBaseException(), timeoutTimer);
						}
					}
					else if (contentTask.IsCanceled)
					{
						response.Dispose();
						this.SetTaskCanceled(request, cancellationTokenSource, tcs, timeoutTimer);
					}
					else
					{
						this.SetTaskCompleted(request, cancellationTokenSource, tcs, response, timeoutTimer);
					}
				}
				catch (Exception ex)
				{
					response.Dispose();
					tcs.TrySetException(ex);
					if (Logging.On)
					{
						Logging.Exception(Logging.Http, this, "SendAsync", ex);
					}
				}
			});
		}

		// Token: 0x060024CC RID: 9420 RVA: 0x000814A8 File Offset: 0x0007F6A8
		private void SetOperationStarted()
		{
			if (!this.operationStarted)
			{
				this.operationStarted = true;
			}
		}

		// Token: 0x060024CD RID: 9421 RVA: 0x000814C0 File Offset: 0x0007F6C0
		private void CheckDisposedOrStarted()
		{
			this.CheckDisposed();
			if (this.operationStarted)
			{
				throw new InvalidOperationException(SR.net_http_operation_started);
			}
		}

		// Token: 0x060024CE RID: 9422 RVA: 0x000814E0 File Offset: 0x0007F6E0
		private void CheckDisposed()
		{
			if (this.disposed)
			{
				throw new ObjectDisposedException(base.GetType().FullName);
			}
		}

		// Token: 0x060024CF RID: 9423 RVA: 0x00081500 File Offset: 0x0007F700
		private static void CheckRequestMessage(HttpRequestMessage request)
		{
			if (!request.MarkAsSent())
			{
				throw new InvalidOperationException(SR.net_http_client_request_already_sent);
			}
		}

		// Token: 0x060024D0 RID: 9424 RVA: 0x00081518 File Offset: 0x0007F718
		private void PrepareRequestMessage(HttpRequestMessage request)
		{
			Uri uri = null;
			if (request.RequestUri == null && this.baseAddress == null)
			{
				throw new InvalidOperationException(SR.net_http_client_invalid_requesturi);
			}
			if (request.RequestUri == null)
			{
				uri = this.baseAddress;
			}
			else if (!request.RequestUri.IsAbsoluteUri)
			{
				if (this.baseAddress == null)
				{
					throw new InvalidOperationException(SR.net_http_client_invalid_requesturi);
				}
				uri = new Uri(this.baseAddress, request.RequestUri);
			}
			if (uri != null)
			{
				request.RequestUri = uri;
			}
			if (this.defaultRequestHeaders != null)
			{
				request.Headers.AddHeaders(this.defaultRequestHeaders);
			}
		}

		// Token: 0x060024D1 RID: 9425 RVA: 0x000815E4 File Offset: 0x0007F7E4
		private static void CheckBaseAddress(Uri baseAddress, string parameterName)
		{
			if (baseAddress == null)
			{
				return;
			}
			if (!baseAddress.IsAbsoluteUri)
			{
				throw new ArgumentException(SR.net_http_client_absolute_baseaddress_required, parameterName);
			}
			if (!HttpUtilities.IsHttpUri(baseAddress))
			{
				throw new ArgumentException(SR.net_http_client_http_baseaddress_required, parameterName);
			}
		}

		// Token: 0x060024D2 RID: 9426 RVA: 0x00081624 File Offset: 0x0007F824
		private void SetTaskFaulted(HttpRequestMessage request, CancellationTokenSource cancellationTokenSource, TaskCompletionSource<HttpResponseMessage> tcs, Exception e, TimerThread.Timer timeoutTimer)
		{
			this.LogSendError(request, cancellationTokenSource, "SendAsync", e);
			tcs.TrySetException(e);
			HttpClient.DisposeCancellationTokenAndTimer(cancellationTokenSource, timeoutTimer);
		}

		// Token: 0x060024D3 RID: 9427 RVA: 0x00081648 File Offset: 0x0007F848
		private void SetTaskCanceled(HttpRequestMessage request, CancellationTokenSource cancellationTokenSource, TaskCompletionSource<HttpResponseMessage> tcs, TimerThread.Timer timeoutTimer)
		{
			this.LogSendError(request, cancellationTokenSource, "SendAsync", null);
			tcs.TrySetCanceled();
			HttpClient.DisposeCancellationTokenAndTimer(cancellationTokenSource, timeoutTimer);
		}

		// Token: 0x060024D4 RID: 9428 RVA: 0x00081668 File Offset: 0x0007F868
		private void SetTaskCompleted(HttpRequestMessage request, CancellationTokenSource cancellationTokenSource, TaskCompletionSource<HttpResponseMessage> tcs, HttpResponseMessage response, TimerThread.Timer timeoutTimer)
		{
			if (Logging.On)
			{
				Logging.PrintInfo(Logging.Http, this, string.Format(CultureInfo.InvariantCulture, SR.net_http_client_send_completed, new object[]
				{
					Logging.GetObjectLogHash(request),
					Logging.GetObjectLogHash(response),
					response
				}));
			}
			tcs.TrySetResult(response);
			HttpClient.DisposeCancellationTokenAndTimer(cancellationTokenSource, timeoutTimer);
		}

		// Token: 0x060024D5 RID: 9429 RVA: 0x000816D0 File Offset: 0x0007F8D0
		private static void DisposeCancellationTokenAndTimer(CancellationTokenSource cancellationTokenSource, TimerThread.Timer timeoutTimer)
		{
			try
			{
				cancellationTokenSource.Dispose();
			}
			catch (ObjectDisposedException)
			{
			}
			finally
			{
				HttpClient.DisposeTimer(timeoutTimer);
			}
		}

		// Token: 0x060024D6 RID: 9430 RVA: 0x00081718 File Offset: 0x0007F918
		private static void DisposeTimer(TimerThread.Timer timeoutTimer)
		{
			if (timeoutTimer != null)
			{
				timeoutTimer.Dispose();
			}
		}

		// Token: 0x060024D7 RID: 9431 RVA: 0x00081728 File Offset: 0x0007F928
		private TimerThread.Timer SetTimeout(CancellationTokenSource cancellationTokenSource)
		{
			TimerThread.Timer result = null;
			if (this.timeout != HttpClient.infiniteTimeout)
			{
				result = this.TimerQueue.CreateTimer(HttpClient.timeoutCallback, cancellationTokenSource);
			}
			return result;
		}

		// Token: 0x060024D8 RID: 9432 RVA: 0x00081764 File Offset: 0x0007F964
		private void LogSendError(HttpRequestMessage request, CancellationTokenSource cancellationTokenSource, string method, Exception e)
		{
			if (cancellationTokenSource.IsCancellationRequested)
			{
				if (Logging.On)
				{
					Logging.PrintError(Logging.Http, this, method, string.Format(CultureInfo.InvariantCulture, SR.net_http_client_send_canceled, new object[]
					{
						Logging.GetObjectLogHash(request)
					}));
					return;
				}
			}
			else if (Logging.On)
			{
				Logging.PrintError(Logging.Http, this, method, string.Format(CultureInfo.InvariantCulture, SR.net_http_client_send_error, new object[]
				{
					Logging.GetObjectLogHash(request),
					e
				}));
			}
		}

		// Token: 0x060024D9 RID: 9433 RVA: 0x000817F4 File Offset: 0x0007F9F4
		private Uri CreateUri(string uri)
		{
			if (string.IsNullOrEmpty(uri))
			{
				return null;
			}
			return new Uri(uri, UriKind.RelativeOrAbsolute);
		}

		// Token: 0x060024DA RID: 9434 RVA: 0x0008180C File Offset: 0x0007FA0C
		private static bool HandleRequestFaultsAndCancelation<T>(Task<HttpResponseMessage> task, TaskCompletionSource<T> tcs)
		{
			if (HttpUtilities.HandleFaultsAndCancelation<T>(task, tcs))
			{
				return true;
			}
			HttpResponseMessage result = task.Result;
			if (!result.IsSuccessStatusCode)
			{
				if (result.Content != null)
				{
					result.Content.Dispose();
				}
				tcs.TrySetException(new HttpRequestException(string.Format(CultureInfo.InvariantCulture, SR.net_http_message_not_success_statuscode, new object[]
				{
					(int)result.StatusCode,
					result.ReasonPhrase
				})));
				return true;
			}
			return false;
		}

		// Token: 0x0400109D RID: 4253
		private const HttpCompletionOption defaultCompletionOption = HttpCompletionOption.ResponseContentRead;

		// Token: 0x0400109E RID: 4254
		private static readonly TimeSpan defaultTimeout = TimeSpan.FromSeconds(100.0);

		// Token: 0x0400109F RID: 4255
		private static readonly TimeSpan maxTimeout = TimeSpan.FromMilliseconds(2147483647.0);

		// Token: 0x040010A0 RID: 4256
		private static readonly TimeSpan infiniteTimeout = TimeSpan.FromMilliseconds(-1.0);

		// Token: 0x040010A1 RID: 4257
		private volatile bool operationStarted;

		// Token: 0x040010A2 RID: 4258
		private volatile bool disposed;

		// Token: 0x040010A3 RID: 4259
		private CancellationTokenSource pendingRequestsCts;

		// Token: 0x040010A4 RID: 4260
		private HttpRequestHeaders defaultRequestHeaders;

		// Token: 0x040010A5 RID: 4261
		private Uri baseAddress;

		// Token: 0x040010A6 RID: 4262
		private TimeSpan timeout;

		// Token: 0x040010A7 RID: 4263
		private long maxResponseContentBufferSize;

		// Token: 0x040010A8 RID: 4264
		private TimerThread.Queue timerQueue;

		// Token: 0x040010A9 RID: 4265
		private static readonly TimerThread.Callback timeoutCallback = new TimerThread.Callback(HttpClient.TimeoutCallback);
	}
}
