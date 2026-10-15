using System;
using System.Runtime.Serialization;

namespace System.Net.Http
{
	// Token: 0x02000316 RID: 790
	[Serializable]
	public class HttpRequestException : Exception
	{
		// Token: 0x06002526 RID: 9510 RVA: 0x00082DF8 File Offset: 0x00080FF8
		public HttpRequestException() : this(null, null)
		{
		}

		// Token: 0x06002527 RID: 9511 RVA: 0x00082E04 File Offset: 0x00081004
		public HttpRequestException(string message) : this(message, null)
		{
		}

		// Token: 0x06002528 RID: 9512 RVA: 0x00082E10 File Offset: 0x00081010
		public HttpRequestException(string message, Exception inner) : base(message, inner)
		{
			base.SerializeObjectState += HttpRequestException.handleSerialization;
		}

		// Token: 0x06002529 RID: 9513 RVA: 0x00082E28 File Offset: 0x00081028
		private static void HandleSerialization(object exception, SafeSerializationEventArgs eventArgs)
		{
			eventArgs.AddSerializedState(new HttpRequestException.EmptyState());
		}

		// Token: 0x040010D1 RID: 4305
		private static readonly EventHandler<SafeSerializationEventArgs> handleSerialization = new EventHandler<SafeSerializationEventArgs>(HttpRequestException.HandleSerialization);

		// Token: 0x020003CE RID: 974
		[Serializable]
		private class EmptyState : ISafeSerializationData
		{
			// Token: 0x06002884 RID: 10372 RVA: 0x0008E830 File Offset: 0x0008CA30
			public void CompleteDeserialization(object deserialized)
			{
				HttpRequestException ex = (HttpRequestException)deserialized;
				ex.SerializeObjectState += HttpRequestException.handleSerialization;
			}
		}
	}
}
