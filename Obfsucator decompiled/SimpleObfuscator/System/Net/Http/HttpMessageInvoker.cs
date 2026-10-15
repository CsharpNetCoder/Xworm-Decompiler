using System;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net.Http
{
	// Token: 0x02000310 RID: 784
	public class HttpMessageInvoker : IDisposable
	{
		// Token: 0x06002497 RID: 9367 RVA: 0x00080B80 File Offset: 0x0007ED80
		public HttpMessageInvoker(HttpMessageHandler handler) : this(handler, true)
		{
		}

		// Token: 0x06002498 RID: 9368 RVA: 0x00080B8C File Offset: 0x0007ED8C
		public HttpMessageInvoker(HttpMessageHandler handler, bool disposeHandler)
		{
			if (Logging.On)
			{
				Logging.Enter(Logging.Http, this, ".ctor", handler);
			}
			if (handler == null)
			{
				throw new ArgumentNullException("handler");
			}
			if (Logging.On)
			{
				Logging.Associate(Logging.Http, this, handler);
			}
			this.handler = handler;
			this.disposeHandler = disposeHandler;
			if (Logging.On)
			{
				Logging.Exit(Logging.Http, this, ".ctor", null);
			}
		}

		// Token: 0x06002499 RID: 9369 RVA: 0x00080C10 File Offset: 0x0007EE10
		public virtual Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
		{
			if (request == null)
			{
				throw new ArgumentNullException("request");
			}
			this.CheckDisposed();
			if (Logging.On)
			{
				Logging.Enter(Logging.Http, this, "SendAsync", Logging.GetObjectLogHash(request) + ": " + request);
			}
			Task<HttpResponseMessage> task = this.handler.SendAsync(request, cancellationToken);
			if (Logging.On)
			{
				Logging.Exit(Logging.Http, this, "SendAsync", task);
			}
			return task;
		}

		// Token: 0x0600249A RID: 9370 RVA: 0x00080C90 File Offset: 0x0007EE90
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x0600249B RID: 9371 RVA: 0x00080CA0 File Offset: 0x0007EEA0
		protected virtual void Dispose(bool disposing)
		{
			if (disposing && !this.disposed)
			{
				this.disposed = true;
				if (this.disposeHandler)
				{
					this.handler.Dispose();
				}
			}
		}

		// Token: 0x0600249C RID: 9372 RVA: 0x00080CD4 File Offset: 0x0007EED4
		private void CheckDisposed()
		{
			if (this.disposed)
			{
				throw new ObjectDisposedException(base.GetType().FullName);
			}
		}

		// Token: 0x0400109A RID: 4250
		private volatile bool disposed;

		// Token: 0x0400109B RID: 4251
		private bool disposeHandler;

		// Token: 0x0400109C RID: 4252
		private HttpMessageHandler handler;
	}
}
