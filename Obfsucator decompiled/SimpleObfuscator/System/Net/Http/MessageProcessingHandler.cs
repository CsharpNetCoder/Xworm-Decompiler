using System;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net.Http
{
	// Token: 0x0200031B RID: 795
	public abstract class MessageProcessingHandler : DelegatingHandler
	{
		// Token: 0x06002566 RID: 9574 RVA: 0x00083E24 File Offset: 0x00082024
		protected MessageProcessingHandler()
		{
		}

		// Token: 0x06002567 RID: 9575 RVA: 0x00083E2C File Offset: 0x0008202C
		protected MessageProcessingHandler(HttpMessageHandler innerHandler) : base(innerHandler)
		{
		}

		// Token: 0x06002568 RID: 9576
		protected abstract HttpRequestMessage ProcessRequest(HttpRequestMessage request, CancellationToken cancellationToken);

		// Token: 0x06002569 RID: 9577
		protected abstract HttpResponseMessage ProcessResponse(HttpResponseMessage response, CancellationToken cancellationToken);

		// Token: 0x0600256A RID: 9578 RVA: 0x00083E38 File Offset: 0x00082038
		protected internal sealed override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
		{
			if (request == null)
			{
				throw new ArgumentNullException("request", SR.net_http_handler_norequest);
			}
			TaskCompletionSource<HttpResponseMessage> tcs = new TaskCompletionSource<HttpResponseMessage>();
			try
			{
				HttpRequestMessage request2 = this.ProcessRequest(request, cancellationToken);
				Task<HttpResponseMessage> task2 = base.SendAsync(request2, cancellationToken);
				task2.ContinueWithStandard(delegate(Task<HttpResponseMessage> task)
				{
					if (task.IsFaulted)
					{
						tcs.TrySetException(task.Exception.GetBaseException());
						return;
					}
					if (task.IsCanceled)
					{
						tcs.TrySetCanceled();
						return;
					}
					if (task.Result == null)
					{
						tcs.TrySetException(new InvalidOperationException(SR.net_http_handler_noresponse));
						return;
					}
					try
					{
						HttpResponseMessage result = this.ProcessResponse(task.Result, cancellationToken);
						tcs.TrySetResult(result);
					}
					catch (OperationCanceledException e2)
					{
						MessageProcessingHandler.HandleCanceledOperations(cancellationToken, tcs, e2);
					}
					catch (Exception exception2)
					{
						tcs.TrySetException(exception2);
					}
				});
			}
			catch (OperationCanceledException e)
			{
				MessageProcessingHandler.HandleCanceledOperations(cancellationToken, tcs, e);
			}
			catch (Exception exception)
			{
				tcs.TrySetException(exception);
			}
			return tcs.Task;
		}

		// Token: 0x0600256B RID: 9579 RVA: 0x00083F10 File Offset: 0x00082110
		private static void HandleCanceledOperations(CancellationToken cancellationToken, TaskCompletionSource<HttpResponseMessage> tcs, OperationCanceledException e)
		{
			if (cancellationToken.IsCancellationRequested && e.CancellationToken == cancellationToken)
			{
				tcs.TrySetCanceled();
				return;
			}
			tcs.TrySetException(e);
		}
	}
}
