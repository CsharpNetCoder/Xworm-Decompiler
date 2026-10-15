using System;

namespace System.Net.Http.Headers
{
	// Token: 0x020002EB RID: 747
	internal class CacheControlHeaderParser : BaseHeaderParser
	{
		// Token: 0x06002233 RID: 8755 RVA: 0x000777A8 File Offset: 0x000759A8
		private CacheControlHeaderParser() : base(true)
		{
		}

		// Token: 0x06002234 RID: 8756 RVA: 0x000777B4 File Offset: 0x000759B4
		protected override int GetParsedValueLength(string value, int startIndex, object storeValue, out object parsedValue)
		{
			CacheControlHeaderValue cacheControlHeaderValue = storeValue as CacheControlHeaderValue;
			int cacheControlLength = CacheControlHeaderValue.GetCacheControlLength(value, startIndex, cacheControlHeaderValue, out cacheControlHeaderValue);
			parsedValue = cacheControlHeaderValue;
			return cacheControlLength;
		}

		// Token: 0x04000FE9 RID: 4073
		internal static readonly CacheControlHeaderParser Parser = new CacheControlHeaderParser();
	}
}
