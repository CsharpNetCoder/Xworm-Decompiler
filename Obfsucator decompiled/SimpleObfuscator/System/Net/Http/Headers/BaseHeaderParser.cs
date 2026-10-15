using System;

namespace System.Net.Http.Headers
{
	// Token: 0x020002E9 RID: 745
	internal abstract class BaseHeaderParser : HttpHeaderParser
	{
		// Token: 0x0600222C RID: 8748 RVA: 0x000775F8 File Offset: 0x000757F8
		protected BaseHeaderParser(bool supportsMultipleValues) : base(supportsMultipleValues)
		{
		}

		// Token: 0x0600222D RID: 8749
		protected abstract int GetParsedValueLength(string value, int startIndex, object storeValue, out object parsedValue);

		// Token: 0x0600222E RID: 8750 RVA: 0x00077604 File Offset: 0x00075804
		public sealed override bool TryParseValue(string value, object storeValue, ref int index, out object parsedValue)
		{
			parsedValue = null;
			if (string.IsNullOrEmpty(value) || index == value.Length)
			{
				return base.SupportsMultipleValues;
			}
			bool flag = false;
			int num = HeaderUtilities.GetNextNonEmptyOrWhitespaceIndex(value, index, base.SupportsMultipleValues, out flag);
			if (flag && !base.SupportsMultipleValues)
			{
				return false;
			}
			if (num == value.Length)
			{
				if (base.SupportsMultipleValues)
				{
					index = num;
				}
				return base.SupportsMultipleValues;
			}
			object obj = null;
			int parsedValueLength = this.GetParsedValueLength(value, num, storeValue, out obj);
			if (parsedValueLength == 0)
			{
				return false;
			}
			num += parsedValueLength;
			num = HeaderUtilities.GetNextNonEmptyOrWhitespaceIndex(value, num, base.SupportsMultipleValues, out flag);
			if ((flag && !base.SupportsMultipleValues) || (!flag && num < value.Length))
			{
				return false;
			}
			index = num;
			parsedValue = obj;
			return true;
		}
	}
}
