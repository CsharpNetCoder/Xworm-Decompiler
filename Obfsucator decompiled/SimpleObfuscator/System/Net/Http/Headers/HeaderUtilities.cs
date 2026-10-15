using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Mail;
using System.Text;

namespace System.Net.Http.Headers
{
	// Token: 0x020002F2 RID: 754
	internal static class HeaderUtilities
	{
		// Token: 0x060022C1 RID: 8897 RVA: 0x0007A1FC File Offset: 0x000783FC
		internal static void SetQuality(ICollection<NameValueHeaderValue> parameters, double? value)
		{
			NameValueHeaderValue nameValueHeaderValue = NameValueHeaderValue.Find(parameters, "q");
			if (value != null)
			{
				double? num = value;
				if (num.GetValueOrDefault() >= 0.0 || num == null)
				{
					double? num2 = value;
					if (num2.GetValueOrDefault() <= 1.0 || num2 == null)
					{
						string value2 = value.Value.ToString("0.0##", NumberFormatInfo.InvariantInfo);
						if (nameValueHeaderValue != null)
						{
							nameValueHeaderValue.Value = value2;
							return;
						}
						parameters.Add(new NameValueHeaderValue("q", value2));
						return;
					}
				}
				throw new ArgumentOutOfRangeException("value");
			}
			if (nameValueHeaderValue != null)
			{
				parameters.Remove(nameValueHeaderValue);
			}
		}

		// Token: 0x060022C2 RID: 8898 RVA: 0x0007A2D0 File Offset: 0x000784D0
		internal static double? GetQuality(ICollection<NameValueHeaderValue> parameters)
		{
			NameValueHeaderValue nameValueHeaderValue = NameValueHeaderValue.Find(parameters, "q");
			if (nameValueHeaderValue != null)
			{
				double value = 0.0;
				if (double.TryParse(nameValueHeaderValue.Value, NumberStyles.AllowDecimalPoint, NumberFormatInfo.InvariantInfo, out value))
				{
					return new double?(value);
				}
				if (Logging.On)
				{
					Logging.PrintError(Logging.Http, string.Format(CultureInfo.InvariantCulture, SR.net_http_log_headers_invalid_quality, new object[]
					{
						nameValueHeaderValue.Value
					}));
				}
			}
			return null;
		}

		// Token: 0x060022C3 RID: 8899 RVA: 0x0007A35C File Offset: 0x0007855C
		internal static void CheckValidToken(string value, string parameterName)
		{
			if (string.IsNullOrEmpty(value))
			{
				throw new ArgumentException(SR.net_http_argument_empty_string, parameterName);
			}
			if (HttpRuleParser.GetTokenLength(value, 0) != value.Length)
			{
				throw new FormatException(string.Format(CultureInfo.InvariantCulture, SR.net_http_headers_invalid_value, new object[]
				{
					value
				}));
			}
		}

		// Token: 0x060022C4 RID: 8900 RVA: 0x0007A3B8 File Offset: 0x000785B8
		internal static void CheckValidComment(string value, string parameterName)
		{
			if (string.IsNullOrEmpty(value))
			{
				throw new ArgumentException(SR.net_http_argument_empty_string, parameterName);
			}
			int num = 0;
			if (HttpRuleParser.GetCommentLength(value, 0, out num) != HttpParseResult.Parsed || num != value.Length)
			{
				throw new FormatException(string.Format(CultureInfo.InvariantCulture, SR.net_http_headers_invalid_value, new object[]
				{
					value
				}));
			}
		}

		// Token: 0x060022C5 RID: 8901 RVA: 0x0007A420 File Offset: 0x00078620
		internal static void CheckValidQuotedString(string value, string parameterName)
		{
			if (string.IsNullOrEmpty(value))
			{
				throw new ArgumentException(SR.net_http_argument_empty_string, parameterName);
			}
			int num = 0;
			if (HttpRuleParser.GetQuotedStringLength(value, 0, out num) != HttpParseResult.Parsed || num != value.Length)
			{
				throw new FormatException(string.Format(CultureInfo.InvariantCulture, SR.net_http_headers_invalid_value, new object[]
				{
					value
				}));
			}
		}

		// Token: 0x060022C6 RID: 8902 RVA: 0x0007A488 File Offset: 0x00078688
		internal static bool AreEqualCollections<T>(ICollection<T> x, ICollection<T> y)
		{
			return HeaderUtilities.AreEqualCollections<T>(x, y, null);
		}

		// Token: 0x060022C7 RID: 8903 RVA: 0x0007A494 File Offset: 0x00078694
		internal static bool AreEqualCollections<T>(ICollection<T> x, ICollection<T> y, IEqualityComparer<T> comparer)
		{
			if (x == null)
			{
				return y == null || y.Count == 0;
			}
			if (y == null)
			{
				return x.Count == 0;
			}
			if (x.Count != y.Count)
			{
				return false;
			}
			if (x.Count == 0)
			{
				return true;
			}
			bool[] array = new bool[x.Count];
			foreach (T x2 in x)
			{
				int num = 0;
				bool flag = false;
				foreach (T t in y)
				{
					if (!array[num] && ((comparer == null && x2.Equals(t)) || (comparer != null && comparer.Equals(x2, t))))
					{
						array[num] = true;
						flag = true;
						break;
					}
					num++;
				}
				if (!flag)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060022C8 RID: 8904 RVA: 0x0007A5DC File Offset: 0x000787DC
		internal static int GetNextNonEmptyOrWhitespaceIndex(string input, int startIndex, bool skipEmptyValues, out bool separatorFound)
		{
			separatorFound = false;
			int num = startIndex + HttpRuleParser.GetWhitespaceLength(input, startIndex);
			if (num == input.Length || input[num] != ',')
			{
				return num;
			}
			separatorFound = true;
			num++;
			num += HttpRuleParser.GetWhitespaceLength(input, num);
			if (skipEmptyValues)
			{
				while (num < input.Length && input[num] == ',')
				{
					num++;
					num += HttpRuleParser.GetWhitespaceLength(input, num);
				}
			}
			return num;
		}

		// Token: 0x060022C9 RID: 8905 RVA: 0x0007A658 File Offset: 0x00078858
		internal static DateTimeOffset? GetDateTimeOffsetValue(string headerName, HttpHeaders store)
		{
			object parsedValues = store.GetParsedValues(headerName);
			if (parsedValues != null)
			{
				return new DateTimeOffset?((DateTimeOffset)parsedValues);
			}
			return null;
		}

		// Token: 0x060022CA RID: 8906 RVA: 0x0007A68C File Offset: 0x0007888C
		internal static TimeSpan? GetTimeSpanValue(string headerName, HttpHeaders store)
		{
			object parsedValues = store.GetParsedValues(headerName);
			if (parsedValues != null)
			{
				return new TimeSpan?((TimeSpan)parsedValues);
			}
			return null;
		}

		// Token: 0x060022CB RID: 8907 RVA: 0x0007A6C0 File Offset: 0x000788C0
		internal static bool TryParseInt32(string value, out int result)
		{
			return int.TryParse(value, NumberStyles.None, NumberFormatInfo.InvariantInfo, out result);
		}

		// Token: 0x060022CC RID: 8908 RVA: 0x0007A6D0 File Offset: 0x000788D0
		internal static bool TryParseInt64(string value, out long result)
		{
			return long.TryParse(value, NumberStyles.None, NumberFormatInfo.InvariantInfo, out result);
		}

		// Token: 0x060022CD RID: 8909 RVA: 0x0007A6E0 File Offset: 0x000788E0
		internal static string DumpHeaders(params HttpHeaders[] headers)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("{\r\n");
			for (int i = 0; i < headers.Length; i++)
			{
				if (headers[i] != null)
				{
					foreach (KeyValuePair<string, IEnumerable<string>> keyValuePair in headers[i])
					{
						foreach (string value in keyValuePair.Value)
						{
							stringBuilder.Append("  ");
							stringBuilder.Append(keyValuePair.Key);
							stringBuilder.Append(": ");
							stringBuilder.Append(value);
							stringBuilder.Append("\r\n");
						}
					}
				}
			}
			stringBuilder.Append('}');
			return stringBuilder.ToString();
		}

		// Token: 0x060022CE RID: 8910 RVA: 0x0007A7F4 File Offset: 0x000789F4
		internal static bool IsValidEmailAddress(string value)
		{
			try
			{
				new MailAddress(value);
				return true;
			}
			catch (FormatException ex)
			{
				if (Logging.On)
				{
					Logging.PrintError(Logging.Http, string.Format(CultureInfo.InvariantCulture, SR.net_http_log_headers_wrong_email_format, new object[]
					{
						value,
						ex.Message
					}));
				}
			}
			return false;
		}

		// Token: 0x060022CF RID: 8911 RVA: 0x0007A860 File Offset: 0x00078A60
		private static void ValidateToken(HttpHeaderValueCollection<string> collection, string value)
		{
			HeaderUtilities.CheckValidToken(value, "item");
		}

		// Token: 0x04001033 RID: 4147
		private const string qualityName = "q";

		// Token: 0x04001034 RID: 4148
		internal const string ConnectionClose = "close";

		// Token: 0x04001035 RID: 4149
		internal const string BytesUnit = "bytes";

		// Token: 0x04001036 RID: 4150
		internal static readonly TransferCodingHeaderValue TransferEncodingChunked = new TransferCodingHeaderValue("chunked");

		// Token: 0x04001037 RID: 4151
		internal static readonly NameValueWithParametersHeaderValue ExpectContinue = new NameValueWithParametersHeaderValue("100-continue");

		// Token: 0x04001038 RID: 4152
		internal static readonly Action<HttpHeaderValueCollection<string>, string> TokenValidator = new Action<HttpHeaderValueCollection<string>, string>(HeaderUtilities.ValidateToken);
	}
}
