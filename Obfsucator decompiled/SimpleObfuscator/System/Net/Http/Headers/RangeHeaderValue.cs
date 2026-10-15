using System;
using System.Collections.Generic;
using System.Text;

namespace System.Net.Http.Headers
{
	// Token: 0x02000305 RID: 773
	public class RangeHeaderValue : ICloneable
	{
		// Token: 0x17000A82 RID: 2690
		// (get) Token: 0x0600241C RID: 9244 RVA: 0x0007EB60 File Offset: 0x0007CD60
		// (set) Token: 0x0600241D RID: 9245 RVA: 0x0007EB68 File Offset: 0x0007CD68
		public string Unit
		{
			get
			{
				return this.unit;
			}
			set
			{
				HeaderUtilities.CheckValidToken(value, "value");
				this.unit = value;
			}
		}

		// Token: 0x17000A83 RID: 2691
		// (get) Token: 0x0600241E RID: 9246 RVA: 0x0007EB7C File Offset: 0x0007CD7C
		public ICollection<RangeItemHeaderValue> Ranges
		{
			get
			{
				if (this.ranges == null)
				{
					this.ranges = new ObjectCollection<RangeItemHeaderValue>();
				}
				return this.ranges;
			}
		}

		// Token: 0x0600241F RID: 9247 RVA: 0x0007EB9C File Offset: 0x0007CD9C
		public RangeHeaderValue()
		{
			this.unit = "bytes";
		}

		// Token: 0x06002420 RID: 9248 RVA: 0x0007EBB0 File Offset: 0x0007CDB0
		public RangeHeaderValue(long? from, long? to)
		{
			this.unit = "bytes";
			this.Ranges.Add(new RangeItemHeaderValue(from, to));
		}

		// Token: 0x06002421 RID: 9249 RVA: 0x0007EBD8 File Offset: 0x0007CDD8
		private RangeHeaderValue(RangeHeaderValue source)
		{
			this.unit = source.unit;
			if (source.ranges != null)
			{
				foreach (RangeItemHeaderValue rangeItemHeaderValue in source.ranges)
				{
					this.Ranges.Add((RangeItemHeaderValue)((ICloneable)rangeItemHeaderValue).Clone());
				}
			}
		}

		// Token: 0x06002422 RID: 9250 RVA: 0x0007EC5C File Offset: 0x0007CE5C
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder(this.unit);
			stringBuilder.Append('=');
			bool flag = true;
			foreach (RangeItemHeaderValue rangeItemHeaderValue in this.Ranges)
			{
				if (flag)
				{
					flag = false;
				}
				else
				{
					stringBuilder.Append(", ");
				}
				stringBuilder.Append(rangeItemHeaderValue.From);
				stringBuilder.Append('-');
				stringBuilder.Append(rangeItemHeaderValue.To);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06002423 RID: 9251 RVA: 0x0007ED10 File Offset: 0x0007CF10
		public override bool Equals(object obj)
		{
			RangeHeaderValue rangeHeaderValue = obj as RangeHeaderValue;
			return rangeHeaderValue != null && string.Compare(this.unit, rangeHeaderValue.unit, StringComparison.OrdinalIgnoreCase) == 0 && HeaderUtilities.AreEqualCollections<RangeItemHeaderValue>(this.Ranges, rangeHeaderValue.Ranges);
		}

		// Token: 0x06002424 RID: 9252 RVA: 0x0007ED5C File Offset: 0x0007CF5C
		public override int GetHashCode()
		{
			int num = this.unit.ToLowerInvariant().GetHashCode();
			foreach (RangeItemHeaderValue rangeItemHeaderValue in this.Ranges)
			{
				num ^= rangeItemHeaderValue.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002425 RID: 9253 RVA: 0x0007EDC8 File Offset: 0x0007CFC8
		public static RangeHeaderValue Parse(string input)
		{
			int num = 0;
			return (RangeHeaderValue)GenericHeaderParser.RangeParser.ParseValue(input, null, ref num);
		}

		// Token: 0x06002426 RID: 9254 RVA: 0x0007EDF0 File Offset: 0x0007CFF0
		public static bool TryParse(string input, out RangeHeaderValue parsedValue)
		{
			int num = 0;
			parsedValue = null;
			object obj;
			if (GenericHeaderParser.RangeParser.TryParseValue(input, null, ref num, out obj))
			{
				parsedValue = (RangeHeaderValue)obj;
				return true;
			}
			return false;
		}

		// Token: 0x06002427 RID: 9255 RVA: 0x0007EE28 File Offset: 0x0007D028
		internal static int GetRangeLength(string input, int startIndex, out object parsedValue)
		{
			parsedValue = null;
			if (string.IsNullOrEmpty(input) || startIndex >= input.Length)
			{
				return 0;
			}
			int tokenLength = HttpRuleParser.GetTokenLength(input, startIndex);
			if (tokenLength == 0)
			{
				return 0;
			}
			RangeHeaderValue rangeHeaderValue = new RangeHeaderValue();
			rangeHeaderValue.unit = input.Substring(startIndex, tokenLength);
			int num = startIndex + tokenLength;
			num += HttpRuleParser.GetWhitespaceLength(input, num);
			if (num == input.Length || input[num] != '=')
			{
				return 0;
			}
			num++;
			num += HttpRuleParser.GetWhitespaceLength(input, num);
			int rangeItemListLength = RangeItemHeaderValue.GetRangeItemListLength(input, num, rangeHeaderValue.Ranges);
			if (rangeItemListLength == 0)
			{
				return 0;
			}
			num += rangeItemListLength;
			parsedValue = rangeHeaderValue;
			return num - startIndex;
		}

		// Token: 0x06002428 RID: 9256 RVA: 0x0007EED4 File Offset: 0x0007D0D4
		object ICloneable.Clone()
		{
			return new RangeHeaderValue(this);
		}

		// Token: 0x04001080 RID: 4224
		private string unit;

		// Token: 0x04001081 RID: 4225
		private ICollection<RangeItemHeaderValue> ranges;
	}
}
