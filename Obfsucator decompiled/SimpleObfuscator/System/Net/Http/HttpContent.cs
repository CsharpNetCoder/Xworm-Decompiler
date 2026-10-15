using System;
using System.Globalization;
using System.IO;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace System.Net.Http
{
	// Token: 0x020002E0 RID: 736
	public abstract class HttpContent : IDisposable
	{
		// Token: 0x170009F3 RID: 2547
		// (get) Token: 0x060021D0 RID: 8656 RVA: 0x00076468 File Offset: 0x00074668
		public HttpContentHeaders Headers
		{
			get
			{
				if (this.headers == null)
				{
					this.headers = new HttpContentHeaders(new Func<long?>(this.GetComputedOrBufferLength));
				}
				return this.headers;
			}
		}

		// Token: 0x170009F4 RID: 2548
		// (get) Token: 0x060021D1 RID: 8657 RVA: 0x00076494 File Offset: 0x00074694
		private bool IsBuffered
		{
			get
			{
				return this.bufferedContent != null;
			}
		}

		// Token: 0x060021D2 RID: 8658 RVA: 0x000764A4 File Offset: 0x000746A4
		protected HttpContent()
		{
			if (Logging.On)
			{
				Logging.Enter(Logging.Http, this, ".ctor", null);
			}
			this.canCalculateLength = true;
			if (Logging.On)
			{
				Logging.Exit(Logging.Http, this, ".ctor", null);
			}
		}

		// Token: 0x060021D3 RID: 8659 RVA: 0x000764F8 File Offset: 0x000746F8
		public Task<string> ReadAsStringAsync()
		{
			this.CheckDisposed();
			TaskCompletionSource<string> tcs = new TaskCompletionSource<string>();
			this.LoadIntoBufferAsync().ContinueWithStandard(delegate(Task task)
			{
				if (HttpUtilities.HandleFaultsAndCancelation<string>(task, tcs))
				{
					return;
				}
				if (this.bufferedContent.Length == 0L)
				{
					tcs.TrySetResult(string.Empty);
					return;
				}
				Encoding encoding = null;
				int num = -1;
				byte[] buffer = this.bufferedContent.GetBuffer();
				int num2 = (int)this.bufferedContent.Length;
				if (this.Headers.ContentType != null && this.Headers.ContentType.CharSet != null)
				{
					try
					{
						encoding = Encoding.GetEncoding(this.Headers.ContentType.CharSet);
					}
					catch (ArgumentException innerException)
					{
						tcs.TrySetException(new InvalidOperationException(SR.net_http_content_invalid_charset, innerException));
						return;
					}
				}
				if (encoding == null)
				{
					foreach (Encoding encoding2 in HttpContent.EncodingsWithBom)
					{
						byte[] preamble = encoding2.GetPreamble();
						if (HttpContent.ByteArrayHasPrefix(buffer, num2, preamble))
						{
							encoding = encoding2;
							num = preamble.Length;
							break;
						}
					}
				}
				encoding = (encoding ?? HttpContent.DefaultStringEncoding);
				if (num == -1)
				{
					byte[] preamble2 = encoding.GetPreamble();
					if (HttpContent.ByteArrayHasPrefix(buffer, num2, preamble2))
					{
						num = preamble2.Length;
					}
					else
					{
						num = 0;
					}
				}
				try
				{
					string @string = encoding.GetString(buffer, num, num2 - num);
					tcs.TrySetResult(@string);
				}
				catch (Exception exception)
				{
					tcs.TrySetException(exception);
				}
			});
			return tcs.Task;
		}

		// Token: 0x060021D4 RID: 8660 RVA: 0x0007654C File Offset: 0x0007474C
		public Task<byte[]> ReadAsByteArrayAsync()
		{
			this.CheckDisposed();
			TaskCompletionSource<byte[]> tcs = new TaskCompletionSource<byte[]>();
			this.LoadIntoBufferAsync().ContinueWithStandard(delegate(Task task)
			{
				if (!HttpUtilities.HandleFaultsAndCancelation<byte[]>(task, tcs))
				{
					tcs.TrySetResult(this.bufferedContent.ToArray());
				}
			});
			return tcs.Task;
		}

		// Token: 0x060021D5 RID: 8661 RVA: 0x000765A0 File Offset: 0x000747A0
		public Task<Stream> ReadAsStreamAsync()
		{
			this.CheckDisposed();
			TaskCompletionSource<Stream> tcs = new TaskCompletionSource<Stream>();
			if (this.contentReadStream == null && this.IsBuffered)
			{
				this.contentReadStream = new MemoryStream(this.bufferedContent.GetBuffer(), 0, (int)this.bufferedContent.Length, false, false);
			}
			if (this.contentReadStream != null)
			{
				tcs.TrySetResult(this.contentReadStream);
				return tcs.Task;
			}
			this.CreateContentReadStreamAsync().ContinueWithStandard(delegate(Task<Stream> task)
			{
				if (!HttpUtilities.HandleFaultsAndCancelation<Stream>(task, tcs))
				{
					this.contentReadStream = task.Result;
					tcs.TrySetResult(this.contentReadStream);
				}
			});
			return tcs.Task;
		}

		// Token: 0x060021D6 RID: 8662
		protected abstract Task SerializeToStreamAsync(Stream stream, TransportContext context);

		// Token: 0x060021D7 RID: 8663 RVA: 0x00076658 File Offset: 0x00074858
		public Task CopyToAsync(Stream stream, TransportContext context)
		{
			this.CheckDisposed();
			if (stream == null)
			{
				throw new ArgumentNullException("stream");
			}
			TaskCompletionSource<object> tcs = new TaskCompletionSource<object>();
			try
			{
				Task task;
				if (this.IsBuffered)
				{
					task = Task.Factory.FromAsync<byte[], int, int>(new Func<byte[], int, int, AsyncCallback, object, IAsyncResult>(stream.BeginWrite), new Action<IAsyncResult>(stream.EndWrite), this.bufferedContent.GetBuffer(), 0, (int)this.bufferedContent.Length, null);
				}
				else
				{
					task = this.SerializeToStreamAsync(stream, context);
					this.CheckTaskNotNull(task);
				}
				task.ContinueWithStandard(delegate(Task copyTask)
				{
					if (copyTask.IsFaulted)
					{
						tcs.TrySetException(HttpContent.GetStreamCopyException(copyTask.Exception.GetBaseException()));
						return;
					}
					if (copyTask.IsCanceled)
					{
						tcs.TrySetCanceled();
						return;
					}
					tcs.TrySetResult(null);
				});
			}
			catch (IOException originalException)
			{
				tcs.TrySetException(HttpContent.GetStreamCopyException(originalException));
			}
			catch (ObjectDisposedException originalException2)
			{
				tcs.TrySetException(HttpContent.GetStreamCopyException(originalException2));
			}
			return tcs.Task;
		}

		// Token: 0x060021D8 RID: 8664 RVA: 0x00076770 File Offset: 0x00074970
		public Task CopyToAsync(Stream stream)
		{
			return this.CopyToAsync(stream, null);
		}

		// Token: 0x060021D9 RID: 8665 RVA: 0x0007677C File Offset: 0x0007497C
		internal void CopyTo(Stream stream)
		{
			this.CopyToAsync(stream).Wait();
		}

		// Token: 0x060021DA RID: 8666 RVA: 0x0007678C File Offset: 0x0007498C
		public Task LoadIntoBufferAsync()
		{
			return this.LoadIntoBufferAsync(2147483647L);
		}

		// Token: 0x060021DB RID: 8667 RVA: 0x0007679C File Offset: 0x0007499C
		public Task LoadIntoBufferAsync(long maxBufferSize)
		{
			this.CheckDisposed();
			if (maxBufferSize > 2147483647L)
			{
				throw new ArgumentOutOfRangeException("maxBufferSize", maxBufferSize, string.Format(CultureInfo.InvariantCulture, SR.net_http_content_buffersize_limit, new object[]
				{
					2147483647L
				}));
			}
			if (this.IsBuffered)
			{
				return HttpContent.CreateCompletedTask();
			}
			TaskCompletionSource<object> tcs = new TaskCompletionSource<object>();
			Exception exception = null;
			MemoryStream tempBuffer = this.CreateMemoryStream(maxBufferSize, out exception);
			if (tempBuffer == null)
			{
				tcs.TrySetException(exception);
			}
			else
			{
				try
				{
					Task task = this.SerializeToStreamAsync(tempBuffer, null);
					this.CheckTaskNotNull(task);
					task.ContinueWithStandard(delegate(Task copyTask)
					{
						try
						{
							if (copyTask.IsFaulted)
							{
								tempBuffer.Dispose();
								tcs.TrySetException(HttpContent.GetStreamCopyException(copyTask.Exception.GetBaseException()));
							}
							else if (copyTask.IsCanceled)
							{
								tempBuffer.Dispose();
								tcs.TrySetCanceled();
							}
							else
							{
								tempBuffer.Seek(0L, SeekOrigin.Begin);
								this.bufferedContent = tempBuffer;
								tcs.TrySetResult(null);
							}
						}
						catch (Exception ex)
						{
							tcs.TrySetException(ex);
							if (Logging.On)
							{
								Logging.Exception(Logging.Http, this, "LoadIntoBufferAsync", ex);
							}
						}
					});
				}
				catch (IOException originalException)
				{
					tcs.TrySetException(HttpContent.GetStreamCopyException(originalException));
				}
				catch (ObjectDisposedException originalException2)
				{
					tcs.TrySetException(HttpContent.GetStreamCopyException(originalException2));
				}
			}
			return tcs.Task;
		}

		// Token: 0x060021DC RID: 8668 RVA: 0x000768E0 File Offset: 0x00074AE0
		protected virtual Task<Stream> CreateContentReadStreamAsync()
		{
			TaskCompletionSource<Stream> tcs = new TaskCompletionSource<Stream>();
			this.LoadIntoBufferAsync().ContinueWithStandard(delegate(Task task)
			{
				if (!HttpUtilities.HandleFaultsAndCancelation<Stream>(task, tcs))
				{
					tcs.TrySetResult(this.bufferedContent);
				}
			});
			return tcs.Task;
		}

		// Token: 0x060021DD RID: 8669
		protected internal abstract bool TryComputeLength(out long length);

		// Token: 0x060021DE RID: 8670 RVA: 0x0007692C File Offset: 0x00074B2C
		private long? GetComputedOrBufferLength()
		{
			this.CheckDisposed();
			if (this.IsBuffered)
			{
				return new long?(this.bufferedContent.Length);
			}
			if (this.canCalculateLength)
			{
				long value = 0L;
				if (this.TryComputeLength(out value))
				{
					return new long?(value);
				}
				this.canCalculateLength = false;
			}
			return null;
		}

		// Token: 0x060021DF RID: 8671 RVA: 0x00076994 File Offset: 0x00074B94
		private MemoryStream CreateMemoryStream(long maxBufferSize, out Exception error)
		{
			error = null;
			long? contentLength = this.Headers.ContentLength;
			if (contentLength == null)
			{
				return new HttpContent.LimitMemoryStream((int)maxBufferSize, 0);
			}
			if (contentLength > maxBufferSize)
			{
				error = new HttpRequestException(string.Format(CultureInfo.InvariantCulture, SR.net_http_content_buffersize_exceeded, new object[]
				{
					maxBufferSize
				}));
				return null;
			}
			return new HttpContent.LimitMemoryStream((int)maxBufferSize, (int)contentLength.Value);
		}

		// Token: 0x060021E0 RID: 8672 RVA: 0x00076A24 File Offset: 0x00074C24
		protected virtual void Dispose(bool disposing)
		{
			if (disposing && !this.disposed)
			{
				this.disposed = true;
				if (this.contentReadStream != null)
				{
					this.contentReadStream.Dispose();
				}
				if (this.IsBuffered)
				{
					this.bufferedContent.Dispose();
				}
			}
		}

		// Token: 0x060021E1 RID: 8673 RVA: 0x00076A7C File Offset: 0x00074C7C
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x060021E2 RID: 8674 RVA: 0x00076A8C File Offset: 0x00074C8C
		private void CheckDisposed()
		{
			if (this.disposed)
			{
				throw new ObjectDisposedException(base.GetType().FullName);
			}
		}

		// Token: 0x060021E3 RID: 8675 RVA: 0x00076AAC File Offset: 0x00074CAC
		private void CheckTaskNotNull(Task task)
		{
			if (task == null)
			{
				if (Logging.On)
				{
					Logging.PrintError(Logging.Http, string.Format(CultureInfo.InvariantCulture, SR.net_http_log_content_no_task_returned_copytoasync, new object[]
					{
						base.GetType().FullName
					}));
				}
				throw new InvalidOperationException(SR.net_http_content_no_task_returned);
			}
		}

		// Token: 0x060021E4 RID: 8676 RVA: 0x00076B08 File Offset: 0x00074D08
		private static Task CreateCompletedTask()
		{
			TaskCompletionSource<object> taskCompletionSource = new TaskCompletionSource<object>();
			taskCompletionSource.TrySetResult(null);
			return taskCompletionSource.Task;
		}

		// Token: 0x060021E5 RID: 8677 RVA: 0x00076B30 File Offset: 0x00074D30
		private static Exception GetStreamCopyException(Exception originalException)
		{
			Exception ex = originalException;
			if (ex is IOException || ex is ObjectDisposedException)
			{
				ex = new HttpRequestException(SR.net_http_content_stream_copy_error, ex);
			}
			return ex;
		}

		// Token: 0x060021E6 RID: 8678 RVA: 0x00076B68 File Offset: 0x00074D68
		private static bool ByteArrayHasPrefix(byte[] byteArray, int dataLength, byte[] prefix)
		{
			if (prefix == null || byteArray == null || prefix.Length > dataLength || prefix.Length == 0)
			{
				return false;
			}
			for (int i = 0; i < prefix.Length; i++)
			{
				if (prefix[i] != byteArray[i])
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x04000FD1 RID: 4049
		internal const long MaxBufferSize = 2147483647L;

		// Token: 0x04000FD2 RID: 4050
		private HttpContentHeaders headers;

		// Token: 0x04000FD3 RID: 4051
		private MemoryStream bufferedContent;

		// Token: 0x04000FD4 RID: 4052
		private bool disposed;

		// Token: 0x04000FD5 RID: 4053
		private Stream contentReadStream;

		// Token: 0x04000FD6 RID: 4054
		private bool canCalculateLength;

		// Token: 0x04000FD7 RID: 4055
		internal static readonly Encoding DefaultStringEncoding = Encoding.UTF8;

		// Token: 0x04000FD8 RID: 4056
		private static Encoding[] EncodingsWithBom = new Encoding[]
		{
			Encoding.UTF8,
			Encoding.UTF32,
			Encoding.Unicode,
			Encoding.BigEndianUnicode
		};

		// Token: 0x020003B9 RID: 953
		private class LimitMemoryStream : MemoryStream
		{
			// Token: 0x0600283C RID: 10300 RVA: 0x0008D698 File Offset: 0x0008B898
			public LimitMemoryStream(int maxSize, int capacity) : base(capacity)
			{
				this.maxSize = maxSize;
			}

			// Token: 0x0600283D RID: 10301 RVA: 0x0008D6A8 File Offset: 0x0008B8A8
			public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
			{
				this.CheckSize(count);
				return base.BeginWrite(buffer, offset, count, callback, state);
			}

			// Token: 0x0600283E RID: 10302 RVA: 0x0008D6D0 File Offset: 0x0008B8D0
			public override void Write(byte[] buffer, int offset, int count)
			{
				this.CheckSize(count);
				base.Write(buffer, offset, count);
			}

			// Token: 0x0600283F RID: 10303 RVA: 0x0008D6E4 File Offset: 0x0008B8E4
			public override void WriteByte(byte value)
			{
				this.CheckSize(1);
				base.WriteByte(value);
			}

			// Token: 0x06002840 RID: 10304 RVA: 0x0008D6F4 File Offset: 0x0008B8F4
			private void CheckSize(int countToAdd)
			{
				if ((long)this.maxSize - this.Length < (long)countToAdd)
				{
					throw new HttpRequestException(string.Format(CultureInfo.InvariantCulture, SR.net_http_content_buffersize_exceeded, new object[]
					{
						this.maxSize
					}));
				}
			}

			// Token: 0x040013C7 RID: 5063
			private int maxSize;
		}
	}
}
