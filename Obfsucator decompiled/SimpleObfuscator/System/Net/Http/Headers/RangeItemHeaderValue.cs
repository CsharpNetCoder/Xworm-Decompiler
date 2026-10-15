using System;
using System.Collections.Generic;
using System.Globalization;

namespace System.Net.Http.Headers
{
	// Token: 0x02000306 RID: 774
	public class RangeItemHeaderValue : ICloneable
	{
		// Token: 0x17000A84 RID: 2692
		// (get) Token: 0x06002429 RID: 9257 RVA: 0x0007EEDC File Offset: 0x0007D0DC
		public long? From
		{
			get
			{
				return this.from;
			}
		}

		// Token: 0x17000A85 RID: 2693
		// (get) Token: 0x0600242A RID: 9258 RVA: 0x0007EEE4 File Offset: 0x0007D0E4
		public long? To
		{
			get
			{
				return this.to;
			}
		}

		// Token: 0x0600242B RID: 9259 RVA: 0x0007EEEC File Offset: 0x0007D0EC
		public RangeItemHeaderValue(long? from, long? to)
		{
			if (from == null && to == null)
			{
				throw new ArgumentException(SR.net_http_headers_invalid_range);
			}
			if (from != null && from.Value < 0L)
			{
				throw new ArgumentOutOfRangeException("from");
			}
			if (to != null && to.Value < 0L)
			{
				throw new ArgumentOutOfRangeException("to");
			}
			if (from != null && to != null && from.Value > to.Value)
			{
				throw new ArgumentOutOfRangeException("from");
			}
			this.from = from;
			this.to = to;
		}

		// Token: 0x0600242C RID: 9260 RVA: 0x0007EFB4 File Offset: 0x0007D1B4
		private RangeItemHeaderValue(RangeItemHeaderValue source)
		{
			this.from = source.from;
			this.to = source.to;
		}

		// Token: 0x0600242D RID: 9261 RVA: 0x0007EFD4 File Offset: 0x0007D1D4
		public override string ToString()
		{
			if (this.from == null)
			{
				return "-" + this.to.Value.ToString(NumberFormatInfo.InvariantInfo);
			}
			if (this.to == null)
			{
				return this.from.Value.ToString(NumberFormatInfo.InvariantInfo) + "-";
			}
			return this.from.Value.ToString(NumberFormatInfo.InvariantInfo) + "-" + this.to.Value.ToString(NumberFormatInfo.InvariantInfo);
		}

		// Token: 0x0600242E RID: 9262 RVA: 0x0007F088 File Offset: 0x0007D288
		public override bool Equals(object obj)
		{
			RangeItemHeaderValue rangeItemHeaderValue = obj as RangeItemHeaderValue;
			return rangeItemHeaderValue != null && this.from == rangeItemHeaderValue.from && this.to == rangeItemHeaderValue.to;
		}

		// Token: 0x0600242F RID: 9263 RVA: 0x0007F11C File Offset: 0x0007D31C
		public override int GetHashCode()
		{
			if (this.from == null)
			{
				return this.to.GetHashCode();
			}
			if (this.to == null)
			{
				return this.from.GetHashCode();
			}
			return this.from.GetHashCode() ^ this.to.GetHashCode();
		}

		// Token: 0x06002430 RID: 9264 RVA: 0x0007F194 File Offset: 0x0007D394
		internal static int GetRangeItemListLength(string input, int startIndex, ICollection<RangeItemHeaderValue> rangeCollection)
		{
			if (string.IsNullOrEmpty(input) || startIndex >= input.Length)
			{
				return 0;
			}
			bool flag = false;
			int num = HeaderUtilities.GetNextNonEmptyOrWhitespaceIndex(input, startIndex, true, out flag);
			if (num == input.Length)
			{
				return 0;
			}
			RangeItemHeaderValue item = null;
			for (;;)
			{
				int rangeItemLength = RangeItemHeaderValue.GetRangeItemLength(input, num, out item);
				if (rangeItemLength == 0)
				{
					break;
				}
				rangeCollection.Add(item);
				num += rangeItemLength;
				num = HeaderUtilities.GetNextNonEmptyOrWhitespaceIndex(input, num, true, out flag);
				if (num < input.Length && !flag)
				{
					return 0;
				}
				if (num == input.Length)
				{
					goto Block_6;
				}
			}
			return 0;
			Block_6:
			return num - startIndex;
		}

		// Token: 0x06002431 RID: 9265 RVA: 0x0007F224 File Offset: 0x0007D424
		internal static int GetRangeItemLength(string input, int startIndex, out RangeItemHeaderValue parsedValue)
		{
			parsedValue = null;
			if (string.IsNullOrEmpty(input) || startIndex >= input.Length)
			{
				return 0;
			}
			int numberLength = HttpRuleParser.GetNumberLength(input, startIndex, false);
			if (numberLength > 19)
			{
				return 0;
			}
			int num = startIndex + numberLength;
			num += HttpRuleParser.GetWhitespaceLength(input, num);
			if (num == input.Length || input[num] != '-')
			{
				return 0;
			}
			num++;
			num += HttpRuleParser.GetWhitespaceLength(input, num);
			int startIndex2 = num;
			int num2 = 0;
			if (num < input.Length)
			{
				num2 = HttpRuleParser.GetNumberLength(input, num, false);
				if (num2 > 19)
				{
					return 0;
				}
				num += num2;
				num += HttpRuleParser.GetWhitespaceLength(input, num);
			}
			if (numberLength == 0 && num2 == 0)
			{
				return 0;
			}
			long num3 = 0L;
			if (numberLength > 0 && !HeaderUtilities.TryParseInt64(input.Substring(startIndex, numberLength), out num3))
			{
				return 0;
			}
			long num4 = 0L;
			if (num2 > 0 && !HeaderUtilities.TryParseInt64(input.Substring(startIndex2, num2), out num4))
			{
				return 0;
			}
			if (numberLength > 0 && num2 > 0 && num3 > num4)
			{
				return 0;
			}
			parsedValue = new RangeItemHeaderValue((numberLength == 0) ? null : new long?(num3), (num2 == 0) ? null : new long?(num4));
			return num - startIndex;
		}

		// Token: 0x06002432 RID: 9266 RVA: 0x0007F388 File Offset: 0x0007D588
		object ICloneable.Clone()
		{
			return new RangeItemHeaderValue(this);
		}

		// Token: 0x04001082 RID: 4226
		private long? from;

		// Token: 0x04001083 RID: 4227
		private long? to;
	}
}
