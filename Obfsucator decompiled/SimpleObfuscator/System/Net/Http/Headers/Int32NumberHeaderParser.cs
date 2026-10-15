using System;
using System.Globalization;

namespace System.Net.Http.Headers
{
	// Token: 0x020002F9 RID: 761
	internal class Int32NumberHeaderParser : BaseHeaderParser
	{
		// Token: 0x0600239C RID: 9116 RVA: 0x0007D394 File Offset: 0x0007B594
		private Int32NumberHeaderParser() : base(false)
		{
		}

		// Token: 0x0600239D RID: 9117 RVA: 0x0007D3A0 File Offset: 0x0007B5A0
		public override string ToString(object value)
		{
			return ((int)value).ToString(NumberFormatInfo.InvariantInfo);
		}

		// Token: 0x0600239E RID: 9118 RVA: 0x0007D3C4 File Offset: 0x0007B5C4
		protected override int GetParsedValueLength(string value, int startIndex, object storeValue, out object parsedValue)
		{
			parsedValue = null;
			int numberLength = HttpRuleParser.GetNumberLength(value, startIndex, false);
			if (numberLength == 0 || numberLength > 10)
			{
				return 0;
			}
			int num = 0;
			if (!HeaderUtilities.TryParseInt32(value.Substring(startIndex, numberLength), out num))
			{
				return 0;
			}
			parsedValue = num;
			return numberLength;
		}

		// Token: 0x04001066 RID: 4198
		internal static readonly Int32NumberHeaderParser Parser = new Int32NumberHeaderParser();
	}
}
