using System;

namespace System.Net.Http.Headers
{
	// Token: 0x020002EF RID: 751
	internal class DateHeaderParser : HttpHeaderParser
	{
		// Token: 0x060022A3 RID: 8867 RVA: 0x00079AE0 File Offset: 0x00077CE0
		private DateHeaderParser() : base(false)
		{
		}

		// Token: 0x060022A4 RID: 8868 RVA: 0x00079AEC File Offset: 0x00077CEC
		public override string ToString(object value)
		{
			return HttpRuleParser.DateToString((DateTimeOffset)value);
		}

		// Token: 0x060022A5 RID: 8869 RVA: 0x00079AFC File Offset: 0x00077CFC
		public override bool TryParseValue(string value, object storeValue, ref int index, out object parsedValue)
		{
			parsedValue = null;
			if (string.IsNullOrEmpty(value) || index == value.Length)
			{
				return false;
			}
			string input = value;
			if (index > 0)
			{
				input = value.Substring(index);
			}
			DateTimeOffset dateTimeOffset;
			if (!HttpRuleParser.TryStringToDate(input, out dateTimeOffset))
			{
				return false;
			}
			index = value.Length;
			parsedValue = dateTimeOffset;
			return true;
		}

		// Token: 0x04001015 RID: 4117
		internal static readonly DateHeaderParser Parser = new DateHeaderParser();
	}
}
