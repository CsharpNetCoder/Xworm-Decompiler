using System;
using System.IO;
using System.Threading.Tasks;

namespace System.Net.Http
{
	// Token: 0x0200031F RID: 799
	internal class StreamToStreamCopy
	{
		// Token: 0x0600258C RID: 9612 RVA: 0x00084A3C File Offset: 0x00082C3C
		public StreamToStreamCopy(Stream source, Stream destination, int bufferSize, bool disposeSource)
		{
			this.buffer = new byte[bufferSize];
			this.source = source;
			this.destination = destination;
			this.sourceIsMemoryStream = (source is MemoryStream);
			this.destinationIsMemoryStream = (destination is MemoryStream);
			this.bufferSize = bufferSize;
			this.bufferReadCallback = new AsyncCallback(this.BufferReadCallback);
			this.bufferWrittenCallback = new AsyncCallback(this.BufferWrittenCallback);
			this.disposeSource = disposeSource;
			this.tcs = new TaskCompletionSource<object>();
		}

		// Token: 0x0600258D RID: 9613 RVA: 0x00084ACC File Offset: 0x00082CCC
		public Task StartAsync()
		{
			if (this.sourceIsMemoryStream && this.destinationIsMemoryStream)
			{
				MemoryStream memoryStream = this.source as MemoryStream;
				try
				{
					int num = (int)memoryStream.Position;
					this.destination.Write(memoryStream.ToArray(), num, (int)this.source.Length - num);
					this.SetCompleted(null);
					goto IL_69;
				}
				catch (Exception completed)
				{
					this.SetCompleted(completed);
					goto IL_69;
				}
			}
			this.StartRead();
			IL_69:
			return this.tcs.Task;
		}

		// Token: 0x0600258E RID: 9614 RVA: 0x00084B60 File Offset: 0x00082D60
		private void StartRead()
		{
			try
			{
				for (;;)
				{
					bool flag;
					if (this.sourceIsMemoryStream)
					{
						int num = this.source.Read(this.buffer, 0, this.bufferSize);
						if (num == 0)
						{
							break;
						}
						flag = this.TryStartWriteSync(num);
					}
					else
					{
						IAsyncResult asyncResult = this.source.BeginRead(this.buffer, 0, this.bufferSize, this.bufferReadCallback, null);
						flag = asyncResult.CompletedSynchronously;
						if (flag)
						{
							int num = this.source.EndRead(asyncResult);
							if (num == 0)
							{
								goto Block_4;
							}
							flag = this.TryStartWriteSync(num);
						}
					}
					if (!flag)
					{
						goto Block_5;
					}
				}
				this.SetCompleted(null);
				return;
				Block_4:
				this.SetCompleted(null);
				Block_5:;
			}
			catch (Exception completed)
			{
				this.SetCompleted(completed);
			}
		}

		// Token: 0x0600258F RID: 9615 RVA: 0x00084C30 File Offset: 0x00082E30
		private bool TryStartWriteSync(int bytesRead)
		{
			if (this.destinationIsMemoryStream)
			{
				this.destination.Write(this.buffer, 0, bytesRead);
				return true;
			}
			IAsyncResult asyncResult = this.destination.BeginWrite(this.buffer, 0, bytesRead, this.bufferWrittenCallback, null);
			if (asyncResult.CompletedSynchronously)
			{
				this.destination.EndWrite(asyncResult);
				return true;
			}
			return false;
		}

		// Token: 0x06002590 RID: 9616 RVA: 0x00084C98 File Offset: 0x00082E98
		private void BufferReadCallback(IAsyncResult ar)
		{
			if (!ar.CompletedSynchronously)
			{
				try
				{
					int num = this.source.EndRead(ar);
					if (num == 0)
					{
						this.SetCompleted(null);
					}
					else if (this.TryStartWriteSync(num))
					{
						this.StartRead();
					}
				}
				catch (Exception completed)
				{
					this.SetCompleted(completed);
				}
			}
		}

		// Token: 0x06002591 RID: 9617 RVA: 0x00084D04 File Offset: 0x00082F04
		private void BufferWrittenCallback(IAsyncResult ar)
		{
			if (!ar.CompletedSynchronously)
			{
				try
				{
					this.destination.EndWrite(ar);
					this.StartRead();
				}
				catch (Exception completed)
				{
					this.SetCompleted(completed);
				}
			}
		}

		// Token: 0x06002592 RID: 9618 RVA: 0x00084D50 File Offset: 0x00082F50
		private void SetCompleted(Exception error)
		{
			try
			{
				if (this.disposeSource)
				{
					this.source.Dispose();
				}
			}
			catch (Exception e)
			{
				if (Logging.On)
				{
					Logging.Exception(Logging.Http, this, "SetCompleted", e);
				}
			}
			if (error == null)
			{
				this.tcs.TrySetResult(null);
				return;
			}
			this.tcs.TrySetException(error);
		}

		// Token: 0x040010FA RID: 4346
		private byte[] buffer;

		// Token: 0x040010FB RID: 4347
		private int bufferSize;

		// Token: 0x040010FC RID: 4348
		private Stream source;

		// Token: 0x040010FD RID: 4349
		private Stream destination;

		// Token: 0x040010FE RID: 4350
		private AsyncCallback bufferReadCallback;

		// Token: 0x040010FF RID: 4351
		private AsyncCallback bufferWrittenCallback;

		// Token: 0x04001100 RID: 4352
		private TaskCompletionSource<object> tcs;

		// Token: 0x04001101 RID: 4353
		private bool sourceIsMemoryStream;

		// Token: 0x04001102 RID: 4354
		private bool destinationIsMemoryStream;

		// Token: 0x04001103 RID: 4355
		private bool disposeSource;
	}
}
