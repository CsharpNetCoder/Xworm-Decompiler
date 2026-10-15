using System;
using System.Globalization;
using System.Text;

namespace System.Net.Http
{
	// Token: 0x02000319 RID: 793
	internal static class HttpRuleParser
	{
		// Token: 0x06002552 RID: 9554 RVA: 0x000836F4 File Offset: 0x000818F4
		static HttpRuleParser()
		{
			HttpRuleParser.tokenChars = new bool[128];
			for (int i = 33; i < 127; i++)
			{
				HttpRuleParser.tokenChars[i] = true;
			}
			HttpRuleParser.tokenChars[40] = false;
			HttpRuleParser.tokenChars[41] = false;
			HttpRuleParser.tokenChars[60] = false;
			HttpRuleParser.tokenChars[62] = false;
			HttpRuleParser.tokenChars[64] = false;
			HttpRuleParser.tokenChars[44] = false;
			HttpRuleParser.tokenChars[59] = false;
			HttpRuleParser.tokenChars[58] = false;
			HttpRuleParser.tokenChars[92] = false;
			HttpRuleParser.tokenChars[34] = false;
			HttpRuleParser.tokenChars[47] = false;
			HttpRuleParser.tokenChars[91] = false;
			HttpRuleParser.tokenChars[93] = false;
			HttpRuleParser.tokenChars[63] = false;
			HttpRuleParser.tokenChars[61] = false;
			HttpRuleParser.tokenChars[123] = false;
			HttpRuleParser.tokenChars[125] = false;
		}

		// Token: 0x06002553 RID: 9555 RVA: 0x000838A0 File Offset: 0x00081AA0
		internal static bool IsTokenChar(char character)
		{
			return character <= '\u007f' && HttpRuleParser.tokenChars[(int)character];
		}

		// Token: 0x06002554 RID: 9556 RVA: 0x000838B4 File Offset: 0x00081AB4
		internal static int GetTokenLength(string input, int startIndex)
		{
			if (startIndex >= input.Length)
			{
				return 0;
			}
			for (int i = startIndex; i < input.Length; i++)
			{
				if (!HttpRuleParser.IsTokenChar(input[i]))
				{
					return i - startIndex;
				}
			}
			return input.Length - startIndex;
		}

		// Token: 0x06002555 RID: 9557 RVA: 0x00083904 File Offset: 0x00081B04
		internal static int GetWhitespaceLength(string input, int startIndex)
		{
			if (startIndex >= input.Length)
			{
				return 0;
			}
			for (int i = startIndex; i < input.Length; i++)
			{
				char c = input[i];
				if (c != ' ' && c != '\t')
				{
					if (c == '\r' && i + 2 < input.Length && input[i + 1] == '\n')
					{
						char c2 = input[i + 2];
						if (c2 == ' ' || c2 == '\t')
						{
							i += 3;
							continue;
						}
					}
					return i - startIndex;
				}
			}
			return input.Length - startIndex;
		}

		// Token: 0x06002556 RID: 9558 RVA: 0x000839AC File Offset: 0x00081BAC
		internal static bool ContainsInvalidNewLine(string value)
		{
			return HttpRuleParser.ContainsInvalidNewLine(value, 0);
		}

		// Token: 0x06002557 RID: 9559 RVA: 0x000839B8 File Offset: 0x00081BB8
		internal static bool ContainsInvalidNewLine(string value, int startIndex)
		{
			for (int i = startIndex; i < value.Length; i++)
			{
				if (value[i] == '\r')
				{
					int num = i + 1;
					if (num < value.Length && value[num] == '\n')
					{
						i = num + 1;
						if (i == value.Length)
						{
							return true;
						}
						char c = value[i];
						if (c != ' ' && c != '\t')
						{
							return true;
						}
					}
				}
			}
			return false;
		}

		// Token: 0x06002558 RID: 9560 RVA: 0x00083A38 File Offset: 0x00081C38
		internal static int GetNumberLength(string input, int startIndex, bool allowDecimal)
		{
			int i = startIndex;
			bool flag = !allowDecimal;
			if (input[i] == '.')
			{
				return 0;
			}
			while (i < input.Length)
			{
				char c = input[i];
				if (c >= '0' && c <= '9')
				{
					i++;
				}
				else
				{
					if (flag || c != '.')
					{
						break;
					}
					flag = true;
					i++;
				}
			}
			return i - startIndex;
		}

		// Token: 0x06002559 RID: 9561 RVA: 0x00083AA4 File Offset: 0x00081CA4
		internal static int GetHostLength(string input, int startIndex, bool allowToken, out string host)
		{
			host = null;
			if (startIndex >= input.Length)
			{
				return 0;
			}
			int i = startIndex;
			bool flag = true;
			while (i < input.Length)
			{
				char c = input[i];
				if (c == '/')
				{
					return 0;
				}
				if (c == ' ' || c == '\t' || c == '\r' || c == ',')
				{
					break;
				}
				flag = (flag && HttpRuleParser.IsTokenChar(c));
				i++;
			}
			int num = i - startIndex;
			if (num == 0)
			{
				return 0;
			}
			string text = input.Substring(startIndex, num);
			if ((!allowToken || !flag) && !HttpRuleParser.IsValidHostName(text))
			{
				return 0;
			}
			host = text;
			return num;
		}

		// Token: 0x0600255A RID: 9562 RVA: 0x00083B58 File Offset: 0x00081D58
		internal static HttpParseResult GetCommentLength(string input, int startIndex, out int length)
		{
			int num = 0;
			return HttpRuleParser.GetExpressionLength(input, startIndex, '(', ')', true, ref num, out length);
		}

		// Token: 0x0600255B RID: 9563 RVA: 0x00083B7C File Offset: 0x00081D7C
		internal static HttpParseResult GetQuotedStringLength(string input, int startIndex, out int length)
		{
			int num = 0;
			return HttpRuleParser.GetExpressionLength(input, startIndex, '"', '"', false, ref num, out length);
		}

		// Token: 0x0600255C RID: 9564 RVA: 0x00083BA0 File Offset: 0x00081DA0
		internal static HttpParseResult GetQuotedPairLength(string input, int startIndex, out int length)
		{
			length = 0;
			if (input[startIndex] != '\\')
			{
				return HttpParseResult.NotParsed;
			}
			if (startIndex + 2 > input.Length || input[startIndex + 1] > '\u007f')
			{
				return HttpParseResult.InvalidFormat;
			}
			length = 2;
			return HttpParseResult.Parsed;
		}

		// Token: 0x0600255D RID: 9565 RVA: 0x00083BDC File Offset: 0x00081DDC
		internal static string DateToString(DateTimeOffset dateTime)
		{
			return dateTime.ToUniversalTime().ToString("r", CultureInfo.InvariantCulture);
		}

		// Token: 0x0600255E RID: 9566 RVA: 0x00083C08 File Offset: 0x00081E08
		internal static bool TryStringToDate(string input, out DateTimeOffset result)
		{
			return DateTimeOffset.TryParseExact(input, HttpRuleParser.dateFormats, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.AllowLeadingWhite | DateTimeStyles.AllowTrailingWhite | DateTimeStyles.AllowInnerWhite | DateTimeStyles.AssumeUniversal, out result);
		}

		// Token: 0x0600255F RID: 9567 RVA: 0x00083C28 File Offset: 0x00081E28
		private static HttpParseResult GetExpressionLength(string input, int startIndex, char openChar, char closeChar, bool supportsNesting, ref int nestedCount, out int length)
		{
			length = 0;
			if (input[startIndex] != openChar)
			{
				return HttpParseResult.NotParsed;
			}
			int i = startIndex + 1;
			while (i < input.Length)
			{
				int num = 0;
				if (i + 2 < input.Length && HttpRuleParser.GetQuotedPairLength(input, i, out num) == HttpParseResult.Parsed)
				{
					i += num;
				}
				else
				{
					if (supportsNesting && input[i] == openChar)
					{
						nestedCount++;
						try
						{
							if (nestedCount > 5)
							{
								return HttpParseResult.InvalidFormat;
							}
							int num2 = 0;
							switch (HttpRuleParser.GetExpressionLength(input, i, openChar, closeChar, supportsNesting, ref nestedCount, out num2))
							{
							case HttpParseResult.Parsed:
								i += num2;
								break;
							case HttpParseResult.InvalidFormat:
								return HttpParseResult.InvalidFormat;
							}
						}
						finally
						{
							nestedCount--;
						}
					}
					if (input[i] == closeChar)
					{
						length = i - startIndex + 1;
						return HttpParseResult.Parsed;
					}
					i++;
				}
			}
			return HttpParseResult.InvalidFormat;
		}

		// Token: 0x06002560 RID: 9568 RVA: 0x00083D2C File Offset: 0x00081F2C
		private static bool IsValidHostName(string host)
		{
			Uri uri;
			return Uri.TryCreate("http://u@" + host + "/", UriKind.Absolute, out uri);
		}

		// Token: 0x040010E4 RID: 4324
		private const int maxNestedCount = 5;

		// Token: 0x040010E5 RID: 4325
		internal const char CR = '\r';

		// Token: 0x040010E6 RID: 4326
		internal const char LF = '\n';

		// Token: 0x040010E7 RID: 4327
		internal const int MaxInt64Digits = 19;

		// Token: 0x040010E8 RID: 4328
		internal const int MaxInt32Digits = 10;

		// Token: 0x040010E9 RID: 4329
		private static readonly bool[] tokenChars;

		// Token: 0x040010EA RID: 4330
		private static readonly string[] dateFormats = new string[]
		{
			"ddd, d MMM yyyy H:m:s 'GMT'",
			"ddd, d MMM yyyy H:m:s",
			"d MMM yyyy H:m:s 'GMT'",
			"d MMM yyyy H:m:s",
			"ddd, d MMM yy H:m:s 'GMT'",
			"ddd, d MMM yy H:m:s",
			"d MMM yy H:m:s 'GMT'",
			"d MMM yy H:m:s",
			"dddd, d'-'MMM'-'yy H:m:s 'GMT'",
			"dddd, d'-'MMM'-'yy H:m:s",
			"ddd MMM d H:m:s yyyy",
			"ddd, d MMM yyyy H:m:s zzz",
			"ddd, d MMM yyyy H:m:s",
			"d MMM yyyy H:m:s zzz",
			"d MMM yyyy H:m:s"
		};

		// Token: 0x040010EB RID: 4331
		internal static readonly Encoding DefaultHttpEncoding = Encoding.GetEncoding(28591);
	}
}
