using System;
using System.IO;

namespace System.Net.Http
{
	// Token: 0x020002E5 RID: 741
	internal abstract class DelegatingStream : Stream
	{
		// Token: 0x170009F6 RID: 2550
		// (get) Token: 0x060021FA RID: 8698 RVA: 0x00076EC8 File Offset: 0x000750C8
		public override bool CanRead
		{
			get
			{
				return this.innerStream.CanRead;
			}
		}

		// Token: 0x170009F7 RID: 2551
		// (get) Token: 0x060021FB RID: 8699 RVA: 0x00076ED8 File Offset: 0x000750D8
		public override bool CanSeek
		{
			get
			{
				return this.innerStream.CanSeek;
			}
		}

		// Token: 0x170009F8 RID: 2552
		// (get) Token: 0x060021FC RID: 8700 RVA: 0x00076EE8 File Offset: 0x000750E8
		public override bool CanWrite
		{
			get
			{
				return this.innerStream.CanWrite;
			}
		}

		// Token: 0x170009F9 RID: 2553
		// (get) Token: 0x060021FD RID: 8701 RVA: 0x00076EF8 File Offset: 0x000750F8
		public override long Length
		{
			get
			{
				return this.innerStream.Length;
			}
		}

		// Token: 0x170009FA RID: 2554
		// (get) Token: 0x060021FE RID: 8702 RVA: 0x00076F08 File Offset: 0x00075108
		// (set) Token: 0x060021FF RID: 8703 RVA: 0x00076F18 File Offset: 0x00075118
		public override long Position
		{
			get
			{
				return this.innerStream.Position;
			}
			set
			{
				this.innerStream.Position = value;
			}
		}

		// Token: 0x170009FB RID: 2555
		// (get) Token: 0x06002200 RID: 8704 RVA: 0x00076F28 File Offset: 0x00075128
		// (set) Token: 0x06002201 RID: 8705 RVA: 0x00076F38 File Offset: 0x00075138
		public override int ReadTimeout
		{
			get
			{
				return this.innerStream.ReadTimeout;
			}
			set
			{
				this.innerStream.ReadTimeout = value;
			}
		}

		// Token: 0x170009FC RID: 2556
		// (get) Token: 0x06002202 RID: 8706 RVA: 0x00076F48 File Offset: 0x00075148
		public override bool CanTimeout
		{
			get
			{
				return this.innerStream.CanTimeout;
			}
		}

		// Token: 0x170009FD RID: 2557
		// (get) Token: 0x06002203 RID: 8707 RVA: 0x00076F58 File Offset: 0x00075158
		// (set) Token: 0x06002204 RID: 8708 RVA: 0x00076F68 File Offset: 0x00075168
		public override int WriteTimeout
		{
			get
			{
				return this.innerStream.WriteTimeout;
			}
			set
			{
				this.innerStream.WriteTimeout = value;
			}
		}

		// Token: 0x06002205 RID: 8709 RVA: 0x00076F78 File Offset: 0x00075178
		protected DelegatingStream(Stream innerStream)
		{
			this.innerStream = innerStream;
		}

		// Token: 0x06002206 RID: 8710 RVA: 0x00076F88 File Offset: 0x00075188
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				this.innerStream.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06002207 RID: 8711 RVA: 0x00076FA4 File Offset: 0x000751A4
		public override long Seek(long offset, SeekOrigin origin)
		{
			return this.innerStream.Seek(offset, origin);
		}

		// Token: 0x06002208 RID: 8712 RVA: 0x00076FB4 File Offset: 0x000751B4
		public override int Read(byte[] buffer, int offset, int count)
		{
			return this.innerStream.Read(buffer, offset, count);
		}

		// Token: 0x06002209 RID: 8713 RVA: 0x00076FC4 File Offset: 0x000751C4
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			return this.innerStream.BeginRead(buffer, offset, count, callback, state);
		}

		// Token: 0x0600220A RID: 8714 RVA: 0x00076FD8 File Offset: 0x000751D8
		public override int EndRead(IAsyncResult asyncResult)
		{
			return this.innerStream.EndRead(asyncResult);
		}

		// Token: 0x0600220B RID: 8715 RVA: 0x00076FE8 File Offset: 0x000751E8
		public override int ReadByte()
		{
			return this.innerStream.ReadByte();
		}

		// Token: 0x0600220C RID: 8716 RVA: 0x00076FF8 File Offset: 0x000751F8
		public override void Flush()
		{
			this.innerStream.Flush();
		}

		// Token: 0x0600220D RID: 8717 RVA: 0x00077008 File Offset: 0x00075208
		public override void SetLength(long value)
		{
			this.innerStream.SetLength(value);
		}

		// Token: 0x0600220E RID: 8718 RVA: 0x00077018 File Offset: 0x00075218
		public override void Write(byte[] buffer, int offset, int count)
		{
			this.innerStream.Write(buffer, offset, count);
		}

		// Token: 0x0600220F RID: 8719 RVA: 0x00077028 File Offset: 0x00075228
		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			return this.innerStream.BeginWrite(buffer, offset, count, callback, state);
		}

		// Token: 0x06002210 RID: 8720 RVA: 0x0007703C File Offset: 0x0007523C
		public override void EndWrite(IAsyncResult asyncResult)
		{
			this.innerStream.EndWrite(asyncResult);
		}

		// Token: 0x06002211 RID: 8721 RVA: 0x0007704C File Offset: 0x0007524C
		public override void WriteByte(byte value)
		{
			this.innerStream.WriteByte(value);
		}

		// Token: 0x04000FE2 RID: 4066
		private Stream innerStream;
	}
}
