using System;
using System.Globalization;

namespace System.Net.Http.Headers
{
	// Token: 0x02000307 RID: 775
	public class RetryConditionHeaderValue : ICloneable
	{
		// Token: 0x17000A86 RID: 2694
		// (get) Token: 0x06002433 RID: 9267 RVA: 0x0007F390 File Offset: 0x0007D590
		public DateTimeOffset? Date
		{
			get
			{
				return this.date;
			}
		}

		// Token: 0x17000A87 RID: 2695
		// (get) Token: 0x06002434 RID: 9268 RVA: 0x0007F398 File Offset: 0x0007D598
		public TimeSpan? Delta
		{
			get
			{
				return this.delta;
			}
		}

		// Token: 0x06002435 RID: 9269 RVA: 0x0007F3A0 File Offset: 0x0007D5A0
		public RetryConditionHeaderValue(DateTimeOffset date)
		{
			this.date = new DateTimeOffset?(date);
		}

		// Token: 0x06002436 RID: 9270 RVA: 0x0007F3B4 File Offset: 0x0007D5B4
		public RetryConditionHeaderValue(TimeSpan delta)
		{
			if (delta.TotalSeconds > 2147483647.0)
			{
				throw new ArgumentOutOfRangeException("delta");
			}
			this.delta = new TimeSpan?(delta);
		}

		// Token: 0x06002437 RID: 9271 RVA: 0x0007F3E8 File Offset: 0x0007D5E8
		private RetryConditionHeaderValue(RetryConditionHeaderValue source)
		{
			this.delta = source.delta;
			this.date = source.date;
		}

		// Token: 0x06002438 RID: 9272 RVA: 0x0007F408 File Offset: 0x0007D608
		private RetryConditionHeaderValue()
		{
		}

		// Token: 0x06002439 RID: 9273 RVA: 0x0007F410 File Offset: 0x0007D610
		public override string ToString()
		{
			if (this.delta != null)
			{
				return ((int)this.delta.Value.TotalSeconds).ToString(NumberFormatInfo.InvariantInfo);
			}
			return HttpRuleParser.DateToString(this.date.Value);
		}

		// Token: 0x0600243A RID: 9274 RVA: 0x0007F464 File Offset: 0x0007D664
		public override bool Equals(object obj)
		{
			RetryConditionHeaderValue retryConditionHeaderValue = obj as RetryConditionHeaderValue;
			if (retryConditionHeaderValue == null)
			{
				return false;
			}
			if (this.delta != null)
			{
				return retryConditionHeaderValue.delta != null && this.delta.Value == retryConditionHeaderValue.delta.Value;
			}
			return retryConditionHeaderValue.date != null && this.date.Value == retryConditionHeaderValue.date.Value;
		}

		// Token: 0x0600243B RID: 9275 RVA: 0x0007F4F0 File Offset: 0x0007D6F0
		public override int GetHashCode()
		{
			if (this.delta == null)
			{
				return this.date.Value.GetHashCode();
			}
			return this.delta.Value.GetHashCode();
		}

		// Token: 0x0600243C RID: 9276 RVA: 0x0007F544 File Offset: 0x0007D744
		public static RetryConditionHeaderValue Parse(string input)
		{
			int num = 0;
			return (RetryConditionHeaderValue)GenericHeaderParser.RetryConditionParser.ParseValue(input, null, ref num);
		}

		// Token: 0x0600243D RID: 9277 RVA: 0x0007F56C File Offset: 0x0007D76C
		public static bool TryParse(string input, out RetryConditionHeaderValue parsedValue)
		{
			int num = 0;
			parsedValue = null;
			object obj;
			if (GenericHeaderParser.RetryConditionParser.TryParseValue(input, null, ref num, out obj))
			{
				parsedValue = (RetryConditionHeaderValue)obj;
				return true;
			}
			return false;
		}

		// Token: 0x0600243E RID: 9278 RVA: 0x0007F5A4 File Offset: 0x0007D7A4
		internal static int GetRetryConditionLength(string input, int startIndex, out object parsedValue)
		{
			parsedValue = null;
			if (string.IsNullOrEmpty(input) || startIndex >= input.Length)
			{
				return 0;
			}
			DateTimeOffset minValue = DateTimeOffset.MinValue;
			int num = -1;
			char c = input[startIndex];
			int num2;
			if (c >= '0' && c <= '9')
			{
				int numberLength = HttpRuleParser.GetNumberLength(input, startIndex, false);
				if (numberLength == 0 || numberLength > 10)
				{
					return 0;
				}
				num2 = startIndex + numberLength;
				num2 += HttpRuleParser.GetWhitespaceLength(input, num2);
				if (num2 != input.Length)
				{
					return 0;
				}
				if (!HeaderUtilities.TryParseInt32(input.Substring(startIndex, numberLength), out num))
				{
					return 0;
				}
			}
			else
			{
				if (!HttpRuleParser.TryStringToDate(input.Substring(startIndex), out minValue))
				{
					return 0;
				}
				num2 = input.Length;
			}
			RetryConditionHeaderValue retryConditionHeaderValue = new RetryConditionHeaderValue();
			if (num == -1)
			{
				retryConditionHeaderValue.date = new DateTimeOffset?(minValue);
			}
			else
			{
				retryConditionHeaderValue.delta = new TimeSpan?(new TimeSpan(0, 0, num));
			}
			parsedValue = retryConditionHeaderValue;
			return num2 - startIndex;
		}

		// Token: 0x0600243F RID: 9279 RVA: 0x0007F6A0 File Offset: 0x0007D8A0
		object ICloneable.Clone()
		{
			return new RetryConditionHeaderValue(this);
		}

		// Token: 0x04001084 RID: 4228
		private DateTimeOffset? date;

		// Token: 0x04001085 RID: 4229
		private TimeSpan? delta;
	}
}
