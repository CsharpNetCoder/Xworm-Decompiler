using System;
using System.IO;
using System.Threading.Tasks;

namespace System.Net.Http
{
	// Token: 0x0200031E RID: 798
	public class StreamContent : HttpContent
	{
		// Token: 0x06002585 RID: 9605 RVA: 0x000848A4 File Offset: 0x00082AA4
		public StreamContent(Stream content) : this(content, 4096)
		{
		}

		// Token: 0x06002586 RID: 9606 RVA: 0x000848B4 File Offset: 0x00082AB4
		public StreamContent(Stream content, int bufferSize)
		{
			if (content == null)
			{
				throw new ArgumentNullException("content");
			}
			if (bufferSize <= 0)
			{
				throw new ArgumentOutOfRangeException("bufferSize");
			}
			this.content = content;
			this.bufferSize = bufferSize;
			if (content.CanSeek)
			{
				this.start = content.Position;
			}
			if (Logging.On)
			{
				Logging.Associate(Logging.Http, this, content);
			}
		}

		// Token: 0x06002587 RID: 9607 RVA: 0x0008492C File Offset: 0x00082B2C
		protected override Task SerializeToStreamAsync(Stream stream, TransportContext context)
		{
			this.PrepareContent();
			StreamToStreamCopy streamToStreamCopy = new StreamToStreamCopy(this.content, stream, this.bufferSize, !this.content.CanSeek);
			return streamToStreamCopy.StartAsync();
		}

		// Token: 0x06002588 RID: 9608 RVA: 0x0008496C File Offset: 0x00082B6C
		protected internal override bool TryComputeLength(out long length)
		{
			if (this.content.CanSeek)
			{
				length = this.content.Length - this.start;
				return true;
			}
			length = 0L;
			return false;
		}

		// Token: 0x06002589 RID: 9609 RVA: 0x0008499C File Offset: 0x00082B9C
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				this.content.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600258A RID: 9610 RVA: 0x000849B8 File Offset: 0x00082BB8
		protected override Task<Stream> CreateContentReadStreamAsync()
		{
			TaskCompletionSource<Stream> taskCompletionSource = new TaskCompletionSource<Stream>();
			taskCompletionSource.TrySetResult(new StreamContent.ReadOnlyStream(this.content));
			return taskCompletionSource.Task;
		}

		// Token: 0x0600258B RID: 9611 RVA: 0x000849E8 File Offset: 0x00082BE8
		private void PrepareContent()
		{
			if (this.contentConsumed)
			{
				if (!this.content.CanSeek)
				{
					throw new InvalidOperationException(SR.net_http_content_stream_already_read);
				}
				this.content.Position = this.start;
			}
			this.contentConsumed = true;
		}

		// Token: 0x040010F5 RID: 4341
		private const int defaultBufferSize = 4096;

		// Token: 0x040010F6 RID: 4342
		private Stream content;

		// Token: 0x040010F7 RID: 4343
		private int bufferSize;

		// Token: 0x040010F8 RID: 4344
		private bool contentConsumed;

		// Token: 0x040010F9 RID: 4345
		private long start;

		// Token: 0x020003D0 RID: 976
		private class ReadOnlyStream : DelegatingStream
		{
			// Token: 0x17000B35 RID: 2869
			// (get) Token: 0x06002888 RID: 10376 RVA: 0x0008E940 File Offset: 0x0008CB40
			public override bool CanWrite
			{
				get
				{
					return false;
				}
			}

			// Token: 0x17000B36 RID: 2870
			// (get) Token: 0x06002889 RID: 10377 RVA: 0x0008E944 File Offset: 0x0008CB44
			// (set) Token: 0x0600288A RID: 10378 RVA: 0x0008E950 File Offset: 0x0008CB50
			public override int WriteTimeout
			{
				get
				{
					throw new NotSupportedException(SR.net_http_content_readonly_stream);
				}
				set
				{
					throw new NotSupportedException(SR.net_http_content_readonly_stream);
				}
			}

			// Token: 0x0600288B RID: 10379 RVA: 0x0008E95C File Offset: 0x0008CB5C
			public ReadOnlyStream(Stream innerStream) : base(innerStream)
			{
			}

			// Token: 0x0600288C RID: 10380 RVA: 0x0008E968 File Offset: 0x0008CB68
			public override void Flush()
			{
				throw new NotSupportedException(SR.net_http_content_readonly_stream);
			}

			// Token: 0x0600288D RID: 10381 RVA: 0x0008E974 File Offset: 0x0008CB74
			public override void SetLength(long value)
			{
				throw new NotSupportedException(SR.net_http_content_readonly_stream);
			}

			// Token: 0x0600288E RID: 10382 RVA: 0x0008E980 File Offset: 0x0008CB80
			public override void Write(byte[] buffer, int offset, int count)
			{
				throw new NotSupportedException(SR.net_http_content_readonly_stream);
			}

			// Token: 0x0600288F RID: 10383 RVA: 0x0008E98C File Offset: 0x0008CB8C
			public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
			{
				throw new NotSupportedException(SR.net_http_content_readonly_stream);
			}

			// Token: 0x06002890 RID: 10384 RVA: 0x0008E998 File Offset: 0x0008CB98
			public override void EndWrite(IAsyncResult asyncResult)
			{
				throw new NotSupportedException(SR.net_http_content_readonly_stream);
			}

			// Token: 0x06002891 RID: 10385 RVA: 0x0008E9A4 File Offset: 0x0008CBA4
			public override void WriteByte(byte value)
			{
				throw new NotSupportedException(SR.net_http_content_readonly_stream);
			}
		}
	}
}
