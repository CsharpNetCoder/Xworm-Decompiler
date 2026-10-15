using System;
using System.Globalization;
using System.Text;

namespace System.Net.Http.Headers
{
	// Token: 0x020002EE RID: 750
	public class ContentRangeHeaderValue : ICloneable
	{
		// Token: 0x17000A1C RID: 2588
		// (get) Token: 0x0600228D RID: 8845 RVA: 0x00079354 File Offset: 0x00077554
		// (set) Token: 0x0600228E RID: 8846 RVA: 0x0007935C File Offset: 0x0007755C
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

		// Token: 0x17000A1D RID: 2589
		// (get) Token: 0x0600228F RID: 8847 RVA: 0x00079370 File Offset: 0x00077570
		public long? From
		{
			get
			{
				return this.from;
			}
		}

		// Token: 0x17000A1E RID: 2590
		// (get) Token: 0x06002290 RID: 8848 RVA: 0x00079378 File Offset: 0x00077578
		public long? To
		{
			get
			{
				return this.to;
			}
		}

		// Token: 0x17000A1F RID: 2591
		// (get) Token: 0x06002291 RID: 8849 RVA: 0x00079380 File Offset: 0x00077580
		public long? Length
		{
			get
			{
				return this.length;
			}
		}

		// Token: 0x17000A20 RID: 2592
		// (get) Token: 0x06002292 RID: 8850 RVA: 0x00079388 File Offset: 0x00077588
		public bool HasLength
		{
			get
			{
				return this.length != null;
			}
		}

		// Token: 0x17000A21 RID: 2593
		// (get) Token: 0x06002293 RID: 8851 RVA: 0x00079398 File Offset: 0x00077598
		public bool HasRange
		{
			get
			{
				return this.from != null;
			}
		}

		// Token: 0x06002294 RID: 8852 RVA: 0x000793A8 File Offset: 0x000775A8
		public ContentRangeHeaderValue(long from, long to, long length)
		{
			if (length < 0L)
			{
				throw new ArgumentOutOfRangeException("length");
			}
			if (to < 0L || to > length)
			{
				throw new ArgumentOutOfRangeException("to");
			}
			if (from < 0L || from > to)
			{
				throw new ArgumentOutOfRangeException("from");
			}
			this.from = new long?(from);
			this.to = new long?(to);
			this.length = new long?(length);
			this.unit = "bytes";
		}

		// Token: 0x06002295 RID: 8853 RVA: 0x00079438 File Offset: 0x00077638
		public ContentRangeHeaderValue(long length)
		{
			if (length < 0L)
			{
				throw new ArgumentOutOfRangeException("length");
			}
			this.length = new long?(length);
			this.unit = "bytes";
		}

		// Token: 0x06002296 RID: 8854 RVA: 0x0007946C File Offset: 0x0007766C
		public ContentRangeHeaderValue(long from, long to)
		{
			if (to < 0L)
			{
				throw new ArgumentOutOfRangeException("to");
			}
			if (from < 0L || from > to)
			{
				throw new ArgumentOutOfRangeException("from");
			}
			this.from = new long?(from);
			this.to = new long?(to);
			this.unit = "bytes";
		}

		// Token: 0x06002297 RID: 8855 RVA: 0x000794D4 File Offset: 0x000776D4
		private ContentRangeHeaderValue()
		{
		}

		// Token: 0x06002298 RID: 8856 RVA: 0x000794DC File Offset: 0x000776DC
		private ContentRangeHeaderValue(ContentRangeHeaderValue source)
		{
			this.from = source.from;
			this.to = source.to;
			this.length = source.length;
			this.unit = source.unit;
		}

		// Token: 0x06002299 RID: 8857 RVA: 0x00079514 File Offset: 0x00077714
		public override bool Equals(object obj)
		{
			ContentRangeHeaderValue contentRangeHeaderValue = obj as ContentRangeHeaderValue;
			return contentRangeHeaderValue != null && (this.from == contentRangeHeaderValue.from && this.to == contentRangeHeaderValue.to && this.length == contentRangeHeaderValue.length) && string.Compare(this.unit, contentRangeHeaderValue.unit, StringComparison.OrdinalIgnoreCase) == 0;
		}

		// Token: 0x0600229A RID: 8858 RVA: 0x00079604 File Offset: 0x00077804
		public override int GetHashCode()
		{
			int num = this.unit.ToLowerInvariant().GetHashCode();
			if (this.HasRange)
			{
				num = (num ^ this.from.GetHashCode() ^ this.to.GetHashCode());
			}
			if (this.HasLength)
			{
				num ^= this.length.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600229B RID: 8859 RVA: 0x00079678 File Offset: 0x00077878
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder(this.unit);
			stringBuilder.Append(' ');
			if (this.HasRange)
			{
				stringBuilder.Append(this.from.Value.ToString(NumberFormatInfo.InvariantInfo));
				stringBuilder.Append('-');
				stringBuilder.Append(this.to.Value.ToString(NumberFormatInfo.InvariantInfo));
			}
			else
			{
				stringBuilder.Append('*');
			}
			stringBuilder.Append('/');
			if (this.HasLength)
			{
				stringBuilder.Append(this.length.Value.ToString(NumberFormatInfo.InvariantInfo));
			}
			else
			{
				stringBuilder.Append('*');
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600229C RID: 8860 RVA: 0x00079748 File Offset: 0x00077948
		public static ContentRangeHeaderValue Parse(string input)
		{
			int num = 0;
			return (ContentRangeHeaderValue)GenericHeaderParser.ContentRangeParser.ParseValue(input, null, ref num);
		}

		// Token: 0x0600229D RID: 8861 RVA: 0x00079770 File Offset: 0x00077970
		public static bool TryParse(string input, out ContentRangeHeaderValue parsedValue)
		{
			int num = 0;
			parsedValue = null;
			object obj;
			if (GenericHeaderParser.ContentRangeParser.TryParseValue(input, null, ref num, out obj))
			{
				parsedValue = (ContentRangeHeaderValue)obj;
				return true;
			}
			return false;
		}

		// Token: 0x0600229E RID: 8862 RVA: 0x000797A8 File Offset: 0x000779A8
		internal static int GetContentRangeLength(string input, int startIndex, out object parsedValue)
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
			string text = input.Substring(startIndex, tokenLength);
			int num = startIndex + tokenLength;
			int whitespaceLength = HttpRuleParser.GetWhitespaceLength(input, num);
			if (whitespaceLength == 0)
			{
				return 0;
			}
			num += whitespaceLength;
			if (num == input.Length)
			{
				return 0;
			}
			int fromStartIndex = num;
			int fromLength = 0;
			int toStartIndex = 0;
			int toLength = 0;
			if (!ContentRangeHeaderValue.TryGetRangeLength(input, ref num, out fromLength, out toStartIndex, out toLength))
			{
				return 0;
			}
			if (num == input.Length || input[num] != '/')
			{
				return 0;
			}
			num++;
			num += HttpRuleParser.GetWhitespaceLength(input, num);
			if (num == input.Length)
			{
				return 0;
			}
			int lengthStartIndex = num;
			int lengthLength = 0;
			if (!ContentRangeHeaderValue.TryGetLengthLength(input, ref num, out lengthLength))
			{
				return 0;
			}
			if (!ContentRangeHeaderValue.TryCreateContentRange(input, text, fromStartIndex, fromLength, toStartIndex, toLength, lengthStartIndex, lengthLength, out parsedValue))
			{
				return 0;
			}
			return num - startIndex;
		}

		// Token: 0x0600229F RID: 8863 RVA: 0x000798A4 File Offset: 0x00077AA4
		private static bool TryGetLengthLength(string input, ref int current, out int lengthLength)
		{
			lengthLength = 0;
			if (input[current] == '*')
			{
				current++;
			}
			else
			{
				lengthLength = HttpRuleParser.GetNumberLength(input, current, false);
				if (lengthLength == 0 || lengthLength > 19)
				{
					return false;
				}
				current += lengthLength;
			}
			current += HttpRuleParser.GetWhitespaceLength(input, current);
			return true;
		}

		// Token: 0x060022A0 RID: 8864 RVA: 0x00079904 File Offset: 0x00077B04
		private static bool TryGetRangeLength(string input, ref int current, out int fromLength, out int toStartIndex, out int toLength)
		{
			fromLength = 0;
			toStartIndex = 0;
			toLength = 0;
			if (input[current] == '*')
			{
				current++;
			}
			else
			{
				fromLength = HttpRuleParser.GetNumberLength(input, current, false);
				if (fromLength == 0 || fromLength > 19)
				{
					return false;
				}
				current += fromLength;
				current += HttpRuleParser.GetWhitespaceLength(input, current);
				if (current == input.Length || input[current] != '-')
				{
					return false;
				}
				current++;
				current += HttpRuleParser.GetWhitespaceLength(input, current);
				if (current == input.Length)
				{
					return false;
				}
				toStartIndex = current;
				toLength = HttpRuleParser.GetNumberLength(input, current, false);
				if (toLength == 0 || toLength > 19)
				{
					return false;
				}
				current += toLength;
			}
			current += HttpRuleParser.GetWhitespaceLength(input, current);
			return true;
		}

		// Token: 0x060022A1 RID: 8865 RVA: 0x000799E4 File Offset: 0x00077BE4
		private static bool TryCreateContentRange(string input, string unit, int fromStartIndex, int fromLength, int toStartIndex, int toLength, int lengthStartIndex, int lengthLength, out object parsedValue)
		{
			parsedValue = null;
			long num = 0L;
			if (fromLength > 0 && !HeaderUtilities.TryParseInt64(input.Substring(fromStartIndex, fromLength), out num))
			{
				return false;
			}
			long num2 = 0L;
			if (toLength > 0 && !HeaderUtilities.TryParseInt64(input.Substring(toStartIndex, toLength), out num2))
			{
				return false;
			}
			if (fromLength > 0 && toLength > 0 && num > num2)
			{
				return false;
			}
			long num3 = 0L;
			if (lengthLength > 0 && !HeaderUtilities.TryParseInt64(input.Substring(lengthStartIndex, lengthLength), out num3))
			{
				return false;
			}
			if (toLength > 0 && lengthLength > 0 && num2 >= num3)
			{
				return false;
			}
			ContentRangeHeaderValue contentRangeHeaderValue = new ContentRangeHeaderValue();
			contentRangeHeaderValue.unit = unit;
			if (fromLength > 0)
			{
				contentRangeHeaderValue.from = new long?(num);
				contentRangeHeaderValue.to = new long?(num2);
			}
			if (lengthLength > 0)
			{
				contentRangeHeaderValue.length = new long?(num3);
			}
			parsedValue = contentRangeHeaderValue;
			return true;
		}

		// Token: 0x060022A2 RID: 8866 RVA: 0x00079AD8 File Offset: 0x00077CD8
		object ICloneable.Clone()
		{
			return new ContentRangeHeaderValue(this);
		}

		// Token: 0x04001011 RID: 4113
		private string unit;

		// Token: 0x04001012 RID: 4114
		private long? from;

		// Token: 0x04001013 RID: 4115
		private long? to;

		// Token: 0x04001014 RID: 4116
		private long? length;
	}
}
