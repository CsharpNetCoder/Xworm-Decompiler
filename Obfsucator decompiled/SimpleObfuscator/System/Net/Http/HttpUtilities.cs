using System;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net.Http
{
	// Token: 0x0200031A RID: 794
	internal static class HttpUtilities
	{
		// Token: 0x06002561 RID: 9569 RVA: 0x00083D58 File Offset: 0x00081F58
		internal static bool IsHttpUri(Uri uri)
		{
			string scheme = uri.Scheme;
			return string.Compare("http", scheme, StringComparison.OrdinalIgnoreCase) == 0 || string.Compare("https", scheme, StringComparison.OrdinalIgnoreCase) == 0;
		}

		// Token: 0x06002562 RID: 9570 RVA: 0x00083D94 File Offset: 0x00081F94
		internal static bool HandleFaultsAndCancelation<T>(Task task, TaskCompletionSource<T> tcs)
		{
			if (task.IsFaulted)
			{
				tcs.TrySetException(task.Exception.GetBaseException());
				return true;
			}
			if (task.IsCanceled)
			{
				tcs.TrySetCanceled();
				return true;
			}
			return false;
		}

		// Token: 0x06002563 RID: 9571 RVA: 0x00083DDC File Offset: 0x00081FDC
		internal static Task ContinueWithStandard(this Task task, Action<Task> continuation)
		{
			return task.ContinueWith(continuation, CancellationToken.None, TaskContinuationOptions.ExecuteSynchronously, TaskScheduler.Default);
		}

		// Token: 0x06002564 RID: 9572 RVA: 0x00083DF4 File Offset: 0x00081FF4
		internal static Task ContinueWithStandard<T>(this Task<T> task, Action<Task<T>> continuation)
		{
			return task.ContinueWith(continuation, CancellationToken.None, TaskContinuationOptions.ExecuteSynchronously, TaskScheduler.Default);
		}

		// Token: 0x040010EC RID: 4332
		internal static readonly Version DefaultVersion = HttpVersion.Version11;

		// Token: 0x040010ED RID: 4333
		internal static readonly byte[] EmptyByteArray = new byte[0];
	}
}
