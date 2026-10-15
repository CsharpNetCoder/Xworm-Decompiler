using System;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net.Http
{
	// Token: 0x020002E4 RID: 740
	public abstract class DelegatingHandler : HttpMessageHandler
	{
		// Token: 0x170009F5 RID: 2549
		// (get) Token: 0x060021F1 RID: 8689 RVA: 0x00076D94 File Offset: 0x00074F94
		// (set) Token: 0x060021F2 RID: 8690 RVA: 0x00076D9C File Offset: 0x00074F9C
		public HttpMessageHandler InnerHandler
		{
			get
			{
				return this.innerHandler;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("value");
				}
				this.CheckDisposedOrStarted();
				if (Logging.On)
				{
					Logging.Associate(Logging.Http, this, value);
				}
				this.innerHandler = value;
			}
		}

		// Token: 0x060021F3 RID: 8691 RVA: 0x00076DD4 File Offset: 0x00074FD4
		protected DelegatingHandler()
		{
		}

		// Token: 0x060021F4 RID: 8692 RVA: 0x00076DDC File Offset: 0x00074FDC
		protected DelegatingHandler(HttpMessageHandler innerHandler)
		{
			this.InnerHandler = innerHandler;
		}

		// Token: 0x060021F5 RID: 8693 RVA: 0x00076DEC File Offset: 0x00074FEC
		protected internal override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
		{
			if (request == null)
			{
				throw new ArgumentNullException("request", SR.net_http_handler_norequest);
			}
			this.SetOperationStarted();
			return this.innerHandler.SendAsync(request, cancellationToken);
		}

		// Token: 0x060021F6 RID: 8694 RVA: 0x00076E18 File Offset: 0x00075018
		protected override void Dispose(bool disposing)
		{
			if (disposing && !this.disposed)
			{
				this.disposed = true;
				if (this.innerHandler != null)
				{
					this.innerHandler.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		// Token: 0x060021F7 RID: 8695 RVA: 0x00076E54 File Offset: 0x00075054
		private void CheckDisposed()
		{
			if (this.disposed)
			{
				throw new ObjectDisposedException(base.GetType().FullName);
			}
		}

		// Token: 0x060021F8 RID: 8696 RVA: 0x00076E74 File Offset: 0x00075074
		private void CheckDisposedOrStarted()
		{
			this.CheckDisposed();
			if (this.operationStarted)
			{
				throw new InvalidOperationException(SR.net_http_operation_started);
			}
		}

		// Token: 0x060021F9 RID: 8697 RVA: 0x00076E94 File Offset: 0x00075094
		private void SetOperationStarted()
		{
			this.CheckDisposed();
			if (this.innerHandler == null)
			{
				throw new InvalidOperationException(SR.net_http_handler_not_assigned);
			}
			if (!this.operationStarted)
			{
				this.operationStarted = true;
			}
		}

		// Token: 0x04000FDF RID: 4063
		private HttpMessageHandler innerHandler;

		// Token: 0x04000FE0 RID: 4064
		private volatile bool operationStarted;

		// Token: 0x04000FE1 RID: 4065
		private volatile bool disposed;
	}
}
