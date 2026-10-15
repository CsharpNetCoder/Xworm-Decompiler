using System;
using System.Threading;

namespace System.Net
{
	// Token: 0x02000321 RID: 801
	internal static class NclUtilities
	{
		// Token: 0x06002597 RID: 9623 RVA: 0x00084E70 File Offset: 0x00083070
		internal static bool IsFatal(Exception exception)
		{
			return exception != null && (exception is OutOfMemoryException || exception is StackOverflowException || exception is ThreadAbortException);
		}
	}
}
