using System;
using System.Globalization;
using System.Text;

namespace System.Net.Http.Headers
{
	// Token: 0x0200030F RID: 783
	public class WarningHeaderValue : ICloneable
	{
		// Token: 0x17000A91 RID: 2705
		// (get) Token: 0x06002483 RID: 9347 RVA: 0x000805B0 File Offset: 0x0007E7B0
		public int Code
		{
			get
			{
				return this.code;
			}
		}

		// Token: 0x17000A92 RID: 2706
		// (get) Token: 0x06002484 RID: 9348 RVA: 0x000805B8 File Offset: 0x0007E7B8
		public string Agent
		{
			get
			{
				return this.agent;
			}
		}

		// Token: 0x17000A93 RID: 2707
		// (get) Token: 0x06002485 RID: 9349 RVA: 0x000805C0 File Offset: 0x0007E7C0
		public string Text
		{
			get
			{
				return this.text;
			}
		}

		// Token: 0x17000A94 RID: 2708
		// (get) Token: 0x06002486 RID: 9350 RVA: 0x000805C8 File Offset: 0x0007E7C8
		public DateTimeOffset? Date
		{
			get
			{
				return this.date;
			}
		}

		// Token: 0x06002487 RID: 9351 RVA: 0x000805D0 File Offset: 0x0007E7D0
		public WarningHeaderValue(int code, string agent, string text)
		{
			WarningHeaderValue.CheckCode(code);
			WarningHeaderValue.CheckAgent(agent);
			HeaderUtilities.CheckValidQuotedString(text, "text");
			this.code = code;
			this.agent = agent;
			this.text = text;
		}

		// Token: 0x06002488 RID: 9352 RVA: 0x00080604 File Offset: 0x0007E804
		public WarningHeaderValue(int code, string agent, string text, DateTimeOffset date)
		{
			WarningHeaderValue.CheckCode(code);
			WarningHeaderValue.CheckAgent(agent);
			HeaderUtilities.CheckValidQuotedString(text, "text");
			this.code = code;
			this.agent = agent;
			this.text = text;
			this.date = new DateTimeOffset?(date);
		}

		// Token: 0x06002489 RID: 9353 RVA: 0x00080654 File Offset: 0x0007E854
		private WarningHeaderValue()
		{
		}

		// Token: 0x0600248A RID: 9354 RVA: 0x0008065C File Offset: 0x0007E85C
		private WarningHeaderValue(WarningHeaderValue source)
		{
			this.code = source.code;
			this.agent = source.agent;
			this.text = source.text;
			this.date = source.date;
		}

		// Token: 0x0600248B RID: 9355 RVA: 0x00080694 File Offset: 0x0007E894
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(this.code.ToString("000", NumberFormatInfo.InvariantInfo));
			stringBuilder.Append(' ');
			stringBuilder.Append(this.agent);
			stringBuilder.Append(' ');
			stringBuilder.Append(this.text);
			if (this.date != null)
			{
				stringBuilder.Append(" \"");
				stringBuilder.Append(HttpRuleParser.DateToString(this.date.Value));
				stringBuilder.Append('"');
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600248C RID: 9356 RVA: 0x00080738 File Offset: 0x0007E938
		public override bool Equals(object obj)
		{
			WarningHeaderValue warningHeaderValue = obj as WarningHeaderValue;
			if (warningHeaderValue == null)
			{
				return false;
			}
			if (this.code != warningHeaderValue.code || string.Compare(this.agent, warningHeaderValue.agent, StringComparison.OrdinalIgnoreCase) != 0 || string.CompareOrdinal(this.text, warningHeaderValue.text) != 0)
			{
				return false;
			}
			if (this.date != null)
			{
				return warningHeaderValue.date != null && this.date.Value == warningHeaderValue.date.Value;
			}
			return warningHeaderValue.date == null;
		}

		// Token: 0x0600248D RID: 9357 RVA: 0x000807E4 File Offset: 0x0007E9E4
		public override int GetHashCode()
		{
			int num = this.code.GetHashCode() ^ this.agent.ToLowerInvariant().GetHashCode() ^ this.text.GetHashCode();
			if (this.date != null)
			{
				num ^= this.date.Value.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600248E RID: 9358 RVA: 0x0008084C File Offset: 0x0007EA4C
		public static WarningHeaderValue Parse(string input)
		{
			int num = 0;
			return (WarningHeaderValue)GenericHeaderParser.SingleValueWarningParser.ParseValue(input, null, ref num);
		}

		// Token: 0x0600248F RID: 9359 RVA: 0x00080874 File Offset: 0x0007EA74
		public static bool TryParse(string input, out WarningHeaderValue parsedValue)
		{
			int num = 0;
			parsedValue = null;
			object obj;
			if (GenericHeaderParser.SingleValueWarningParser.TryParseValue(input, null, ref num, out obj))
			{
				parsedValue = (WarningHeaderValue)obj;
				return true;
			}
			return false;
		}

		// Token: 0x06002490 RID: 9360 RVA: 0x000808AC File Offset: 0x0007EAAC
		internal static int GetWarningLength(string input, int startIndex, out object parsedValue)
		{
			parsedValue = null;
			if (string.IsNullOrEmpty(input) || startIndex >= input.Length)
			{
				return 0;
			}
			int num = startIndex;
			int num2;
			if (!WarningHeaderValue.TryReadCode(input, ref num, out num2))
			{
				return 0;
			}
			string text;
			if (!WarningHeaderValue.TryReadAgent(input, num, ref num, out text))
			{
				return 0;
			}
			int num3 = 0;
			int startIndex2 = num;
			if (HttpRuleParser.GetQuotedStringLength(input, num, out num3) != HttpParseResult.Parsed)
			{
				return 0;
			}
			num += num3;
			DateTimeOffset? dateTimeOffset = null;
			if (!WarningHeaderValue.TryReadDate(input, ref num, out dateTimeOffset))
			{
				return 0;
			}
			parsedValue = new WarningHeaderValue
			{
				code = num2,
				agent = text,
				text = input.Substring(startIndex2, num3),
				date = dateTimeOffset
			};
			return num - startIndex;
		}

		// Token: 0x06002491 RID: 9361 RVA: 0x00080968 File Offset: 0x0007EB68
		private static bool TryReadAgent(string input, int startIndex, ref int current, out string agent)
		{
			agent = null;
			int hostLength = HttpRuleParser.GetHostLength(input, startIndex, true, out agent);
			if (hostLength == 0)
			{
				return false;
			}
			current += hostLength;
			int whitespaceLength = HttpRuleParser.GetWhitespaceLength(input, current);
			current += whitespaceLength;
			return whitespaceLength != 0 && current != input.Length;
		}

		// Token: 0x06002492 RID: 9362 RVA: 0x000809BC File Offset: 0x0007EBBC
		private static bool TryReadCode(string input, ref int current, out int code)
		{
			code = 0;
			int numberLength = HttpRuleParser.GetNumberLength(input, current, false);
			if (numberLength == 0 || numberLength > 3)
			{
				return false;
			}
			if (!HeaderUtilities.TryParseInt32(input.Substring(current, numberLength), out code))
			{
				return false;
			}
			current += numberLength;
			int whitespaceLength = HttpRuleParser.GetWhitespaceLength(input, current);
			current += whitespaceLength;
			return whitespaceLength != 0 && current != input.Length;
		}

		// Token: 0x06002493 RID: 9363 RVA: 0x00080A2C File Offset: 0x0007EC2C
		private static bool TryReadDate(string input, ref int current, out DateTimeOffset? date)
		{
			date = null;
			int whitespaceLength = HttpRuleParser.GetWhitespaceLength(input, current);
			current += whitespaceLength;
			if (current < input.Length && input[current] == '"')
			{
				if (whitespaceLength == 0)
				{
					return false;
				}
				current++;
				int num = current;
				while (current < input.Length && input[current] != '"')
				{
					current++;
				}
				if (current == input.Length || current == num)
				{
					return false;
				}
				DateTimeOffset value;
				if (!HttpRuleParser.TryStringToDate(input.Substring(num, current - num), out value))
				{
					return false;
				}
				date = new DateTimeOffset?(value);
				current++;
				current += HttpRuleParser.GetWhitespaceLength(input, current);
			}
			return true;
		}

		// Token: 0x06002494 RID: 9364 RVA: 0x00080AF4 File Offset: 0x0007ECF4
		object ICloneable.Clone()
		{
			return new WarningHeaderValue(this);
		}

		// Token: 0x06002495 RID: 9365 RVA: 0x00080AFC File Offset: 0x0007ECFC
		private static void CheckCode(int code)
		{
			if (code < 0 || code > 999)
			{
				throw new ArgumentOutOfRangeException("code");
			}
		}

		// Token: 0x06002496 RID: 9366 RVA: 0x00080B1C File Offset: 0x0007ED1C
		private static void CheckAgent(string agent)
		{
			if (string.IsNullOrEmpty(agent))
			{
				throw new ArgumentException(SR.net_http_argument_empty_string, "agent");
			}
			string text = null;
			if (HttpRuleParser.GetHostLength(agent, 0, true, out text) != agent.Length)
			{
				throw new FormatException(string.Format(CultureInfo.InvariantCulture, SR.net_http_headers_invalid_value, new object[]
				{
					agent
				}));
			}
		}

		// Token: 0x04001096 RID: 4246
		private int code;

		// Token: 0x04001097 RID: 4247
		private string agent;

		// Token: 0x04001098 RID: 4248
		private string text;

		// Token: 0x04001099 RID: 4249
		private DateTimeOffset? date;
	}
}
