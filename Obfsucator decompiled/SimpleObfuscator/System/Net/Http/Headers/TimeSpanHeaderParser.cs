using System;
using System.Globalization;

namespace System.Net.Http.Headers
{
	// Token: 0x02000309 RID: 777
	internal class TimeSpanHeaderParser : BaseHeaderParser
	{
		// Token: 0x0600244E RID: 9294 RVA: 0x0007FA8C File Offset: 0x0007DC8C
		private TimeSpanHeaderParser() : base(false)
		{
		}

		// Token: 0x0600244F RID: 9295 RVA: 0x0007FA98 File Offset: 0x0007DC98
		public override string ToString(object value)
		{
			return ((int)((TimeSpan)value).TotalSeconds).ToString(NumberFormatInfo.InvariantInfo);
		}

		// Token: 0x06002450 RID: 9296 RVA: 0x0007FAC8 File Offset: 0x0007DCC8
		protected override int GetParsedValueLength(string value, int startIndex, object storeValue, out object parsedValue)
		{
			parsedValue = null;
			int numberLength = HttpRuleParser.GetNumberLength(value, startIndex, false);
			if (numberLength == 0 || numberLength > 10)
			{
				return 0;
			}
			int seconds = 0;
			if (!HeaderUtilities.TryParseInt32(value.Substring(startIndex, numberLength), out seconds))
			{
				return 0;
			}
			parsedValue = new TimeSpan(0, 0, seconds);
			return numberLength;
		}

		// Token: 0x04001088 RID: 4232
		internal static readonly TimeSpanHeaderParser Parser = new TimeSpanHeaderParser();
	}
}
