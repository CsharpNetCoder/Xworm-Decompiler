using System;
using System.Globalization;

namespace System.Net.Http.Headers
{
	// Token: 0x020002FA RID: 762
	internal class Int64NumberHeaderParser : BaseHeaderParser
	{
		// Token: 0x060023A0 RID: 9120 RVA: 0x0007D420 File Offset: 0x0007B620
		private Int64NumberHeaderParser() : base(false)
		{
		}

		// Token: 0x060023A1 RID: 9121 RVA: 0x0007D42C File Offset: 0x0007B62C
		public override string ToString(object value)
		{
			return ((long)value).ToString(NumberFormatInfo.InvariantInfo);
		}

		// Token: 0x060023A2 RID: 9122 RVA: 0x0007D450 File Offset: 0x0007B650
		protected override int GetParsedValueLength(string value, int startIndex, object storeValue, out object parsedValue)
		{
			parsedValue = null;
			int numberLength = HttpRuleParser.GetNumberLength(value, startIndex, false);
			if (numberLength == 0 || numberLength > 19)
			{
				return 0;
			}
			long num = 0L;
			if (!HeaderUtilities.TryParseInt64(value.Substring(startIndex, numberLength), out num))
			{
				return 0;
			}
			parsedValue = num;
			return numberLength;
		}

		// Token: 0x04001067 RID: 4199
		internal static readonly Int64NumberHeaderParser Parser = new Int64NumberHeaderParser();
	}
}
