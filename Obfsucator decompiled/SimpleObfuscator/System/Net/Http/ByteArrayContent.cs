using System;
using System.IO;
using System.Threading.Tasks;

namespace System.Net.Http
{
	// Token: 0x020002E1 RID: 737
	public class ByteArrayContent : HttpContent
	{
		// Token: 0x060021E8 RID: 8680 RVA: 0x00076C10 File Offset: 0x00074E10
		public ByteArrayContent(byte[] content)
		{
			if (content == null)
			{
				throw new ArgumentNullException("content");
			}
			this.content = content;
			this.offset = 0;
			this.count = content.Length;
		}

		// Token: 0x060021E9 RID: 8681 RVA: 0x00076C40 File Offset: 0x00074E40
		public ByteArrayContent(byte[] content, int offset, int count)
		{
			if (content == null)
			{
				throw new ArgumentNullException("content");
			}
			if (offset < 0 || offset > content.Length)
			{
				throw new ArgumentOutOfRangeException("offset");
			}
			if (count < 0 || count > content.Length - offset)
			{
				throw new ArgumentOutOfRangeException("count");
			}
			this.content = content;
			this.offset = offset;
			this.count = count;
		}

		// Token: 0x060021EA RID: 8682 RVA: 0x00076CB8 File Offset: 0x00074EB8
		protected override Task SerializeToStreamAsync(Stream stream, TransportContext context)
		{
			return Task.Factory.FromAsync<byte[], int, int>(new Func<byte[], int, int, AsyncCallback, object, IAsyncResult>(stream.BeginWrite), new Action<IAsyncResult>(stream.EndWrite), this.content, this.offset, this.count, null);
		}

		// Token: 0x060021EB RID: 8683 RVA: 0x00076CF4 File Offset: 0x00074EF4
		protected internal override bool TryComputeLength(out long length)
		{
			length = (long)this.count;
			return true;
		}

		// Token: 0x060021EC RID: 8684 RVA: 0x00076D00 File Offset: 0x00074F00
		protected override Task<Stream> CreateContentReadStreamAsync()
		{
			TaskCompletionSource<Stream> taskCompletionSource = new TaskCompletionSource<Stream>();
			taskCompletionSource.TrySetResult(new MemoryStream(this.content, this.offset, this.count, false, false));
			return taskCompletionSource.Task;
		}

		// Token: 0x04000FD9 RID: 4057
		private byte[] content;

		// Token: 0x04000FDA RID: 4058
		private int offset;

		// Token: 0x04000FDB RID: 4059
		private int count;
	}
}
