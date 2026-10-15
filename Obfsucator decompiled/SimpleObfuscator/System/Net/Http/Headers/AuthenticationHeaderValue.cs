using System;

namespace System.Net.Http.Headers
{
	// Token: 0x020002E7 RID: 743
	public class AuthenticationHeaderValue : ICloneable
	{
		// Token: 0x170009FE RID: 2558
		// (get) Token: 0x06002215 RID: 8725 RVA: 0x00077160 File Offset: 0x00075360
		public string Scheme
		{
			get
			{
				return this.scheme;
			}
		}

		// Token: 0x170009FF RID: 2559
		// (get) Token: 0x06002216 RID: 8726 RVA: 0x00077168 File Offset: 0x00075368
		public string Parameter
		{
			get
			{
				return this.parameter;
			}
		}

		// Token: 0x06002217 RID: 8727 RVA: 0x00077170 File Offset: 0x00075370
		public AuthenticationHeaderValue(string scheme) : this(scheme, null)
		{
		}

		// Token: 0x06002218 RID: 8728 RVA: 0x0007717C File Offset: 0x0007537C
		public AuthenticationHeaderValue(string scheme, string parameter)
		{
			HeaderUtilities.CheckValidToken(scheme, "scheme");
			this.scheme = scheme;
			this.parameter = parameter;
		}

		// Token: 0x06002219 RID: 8729 RVA: 0x000771A0 File Offset: 0x000753A0
		private AuthenticationHeaderValue(AuthenticationHeaderValue source)
		{
			this.scheme = source.scheme;
			this.parameter = source.parameter;
		}

		// Token: 0x0600221A RID: 8730 RVA: 0x000771C0 File Offset: 0x000753C0
		private AuthenticationHeaderValue()
		{
		}

		// Token: 0x0600221B RID: 8731 RVA: 0x000771C8 File Offset: 0x000753C8
		public override string ToString()
		{
			if (string.IsNullOrEmpty(this.parameter))
			{
				return this.scheme;
			}
			return this.scheme + " " + this.parameter;
		}

		// Token: 0x0600221C RID: 8732 RVA: 0x000771F8 File Offset: 0x000753F8
		public override bool Equals(object obj)
		{
			AuthenticationHeaderValue authenticationHeaderValue = obj as AuthenticationHeaderValue;
			if (authenticationHeaderValue == null)
			{
				return false;
			}
			if (string.IsNullOrEmpty(this.parameter) && string.IsNullOrEmpty(authenticationHeaderValue.parameter))
			{
				return string.Compare(this.scheme, authenticationHeaderValue.scheme, StringComparison.OrdinalIgnoreCase) == 0;
			}
			return string.Compare(this.scheme, authenticationHeaderValue.scheme, StringComparison.OrdinalIgnoreCase) == 0 && string.CompareOrdinal(this.parameter, authenticationHeaderValue.parameter) == 0;
		}

		// Token: 0x0600221D RID: 8733 RVA: 0x0007727C File Offset: 0x0007547C
		public override int GetHashCode()
		{
			int num = this.scheme.ToLowerInvariant().GetHashCode();
			if (!string.IsNullOrEmpty(this.parameter))
			{
				num ^= this.parameter.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600221E RID: 8734 RVA: 0x000772C0 File Offset: 0x000754C0
		public static AuthenticationHeaderValue Parse(string input)
		{
			int num = 0;
			return (AuthenticationHeaderValue)GenericHeaderParser.SingleValueAuthenticationParser.ParseValue(input, null, ref num);
		}

		// Token: 0x0600221F RID: 8735 RVA: 0x000772E8 File Offset: 0x000754E8
		public static bool TryParse(string input, out AuthenticationHeaderValue parsedValue)
		{
			int num = 0;
			parsedValue = null;
			object obj;
			if (GenericHeaderParser.SingleValueAuthenticationParser.TryParseValue(input, null, ref num, out obj))
			{
				parsedValue = (AuthenticationHeaderValue)obj;
				return true;
			}
			return false;
		}

		// Token: 0x06002220 RID: 8736 RVA: 0x00077320 File Offset: 0x00075520
		internal static int GetAuthenticationLength(string input, int startIndex, out object parsedValue)
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
			AuthenticationHeaderValue authenticationHeaderValue = new AuthenticationHeaderValue();
			authenticationHeaderValue.scheme = input.Substring(startIndex, tokenLength);
			int num = startIndex + tokenLength;
			int whitespaceLength = HttpRuleParser.GetWhitespaceLength(input, num);
			num += whitespaceLength;
			if (num == input.Length || input[num] == ',')
			{
				parsedValue = authenticationHeaderValue;
				return num - startIndex;
			}
			if (whitespaceLength == 0)
			{
				return 0;
			}
			int num2 = num;
			int num3 = num;
			if (!AuthenticationHeaderValue.TrySkipFirstBlob(input, ref num, ref num3))
			{
				return 0;
			}
			if (num < input.Length && !AuthenticationHeaderValue.TryGetParametersEndIndex(input, ref num, ref num3))
			{
				return 0;
			}
			authenticationHeaderValue.parameter = input.Substring(num2, num3 - num2 + 1);
			parsedValue = authenticationHeaderValue;
			return num - startIndex;
		}

		// Token: 0x06002221 RID: 8737 RVA: 0x000773FC File Offset: 0x000755FC
		private static bool TrySkipFirstBlob(string input, ref int current, ref int parameterEndIndex)
		{
			while (current < input.Length && input[current] != ',')
			{
				if (input[current] == '"')
				{
					int num = 0;
					if (HttpRuleParser.GetQuotedStringLength(input, current, out num) != HttpParseResult.Parsed)
					{
						return false;
					}
					current += num;
					parameterEndIndex = current - 1;
				}
				else
				{
					int whitespaceLength = HttpRuleParser.GetWhitespaceLength(input, current);
					if (whitespaceLength == 0)
					{
						parameterEndIndex = current;
						current++;
					}
					else
					{
						current += whitespaceLength;
					}
				}
			}
			return true;
		}

		// Token: 0x06002222 RID: 8738 RVA: 0x00077484 File Offset: 0x00075684
		private static bool TryGetParametersEndIndex(string input, ref int parseEndIndex, ref int parameterEndIndex)
		{
			int num = parseEndIndex;
			for (;;)
			{
				num++;
				bool flag = false;
				num = HeaderUtilities.GetNextNonEmptyOrWhitespaceIndex(input, num, true, out flag);
				if (num == input.Length)
				{
					break;
				}
				int tokenLength = HttpRuleParser.GetTokenLength(input, num);
				if (tokenLength == 0)
				{
					return false;
				}
				num += tokenLength;
				num += HttpRuleParser.GetWhitespaceLength(input, num);
				if (num == input.Length || input[num] != '=')
				{
					return true;
				}
				num++;
				num += HttpRuleParser.GetWhitespaceLength(input, num);
				int valueLength = NameValueHeaderValue.GetValueLength(input, num);
				if (valueLength == 0)
				{
					return false;
				}
				num += valueLength;
				parameterEndIndex = num - 1;
				num += HttpRuleParser.GetWhitespaceLength(input, num);
				parseEndIndex = num;
				if (num >= input.Length || input[num] != ',')
				{
					return true;
				}
			}
			return true;
		}

		// Token: 0x06002223 RID: 8739 RVA: 0x00077540 File Offset: 0x00075740
		object ICloneable.Clone()
		{
			return new AuthenticationHeaderValue(this);
		}

		// Token: 0x04000FE3 RID: 4067
		private string scheme;

		// Token: 0x04000FE4 RID: 4068
		private string parameter;
	}
}
