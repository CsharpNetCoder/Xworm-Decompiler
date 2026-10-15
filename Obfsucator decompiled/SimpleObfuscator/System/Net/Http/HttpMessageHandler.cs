using System;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net.Http
{
	// Token: 0x020002E3 RID: 739
	public abstract class HttpMessageHandler : IDisposable
	{
		// Token: 0x060021ED RID: 8685 RVA: 0x00076D40 File Offset: 0x00074F40
		protected HttpMessageHandler()
		{
			if (Logging.On)
			{
				Logging.Enter(Logging.Http, this, ".ctor", null);
			}
			if (Logging.On)
			{
				Logging.Exit(Logging.Http, this, ".ctor", null);
			}
		}

		// Token: 0x060021EE RID: 8686
		protected internal abstract Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken);

		// Token: 0x060021EF RID: 8687 RVA: 0x00076D80 File Offset: 0x00074F80
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x060021F0 RID: 8688 RVA: 0x00076D84 File Offset: 0x00074F84
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}
	}
}
