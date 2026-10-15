using System;
using System.Globalization;

namespace System.Net.Http.Headers
{
	// Token: 0x02000308 RID: 776
	public class StringWithQualityHeaderValue : ICloneable
	{
		// Token: 0x17000A88 RID: 2696
		// (get) Token: 0x06002440 RID: 9280 RVA: 0x0007F6A8 File Offset: 0x0007D8A8
		public string Value
		{
			get
			{
				return this.value;
			}
		}

		// Token: 0x17000A89 RID: 2697
		// (get) Token: 0x06002441 RID: 9281 RVA: 0x0007F6B0 File Offset: 0x0007D8B0
		public double? Quality
		{
			get
			{
				return this.quality;
			}
		}

		// Token: 0x06002442 RID: 9282 RVA: 0x0007F6B8 File Offset: 0x0007D8B8
		public StringWithQualityHeaderValue(string value)
		{
			HeaderUtilities.CheckValidToken(value, "value");
			this.value = value;
		}

		// Token: 0x06002443 RID: 9283 RVA: 0x0007F6D4 File Offset: 0x0007D8D4
		public StringWithQualityHeaderValue(string value, double quality)
		{
			HeaderUtilities.CheckValidToken(value, "value");
			if (quality < 0.0 || quality > 1.0)
			{
				throw new ArgumentOutOfRangeException("quality");
			}
			this.value = value;
			this.quality = new double?(quality);
		}

		// Token: 0x06002444 RID: 9284 RVA: 0x0007F734 File Offset: 0x0007D934
		private StringWithQualityHeaderValue(StringWithQualityHeaderValue source)
		{
			this.value = source.value;
			this.quality = source.quality;
		}

		// Token: 0x06002445 RID: 9285 RVA: 0x0007F754 File Offset: 0x0007D954
		private StringWithQualityHeaderValue()
		{
		}

		// Token: 0x06002446 RID: 9286 RVA: 0x0007F75C File Offset: 0x0007D95C
		public override string ToString()
		{
			if (this.quality != null)
			{
				return this.value + "; q=" + this.quality.Value.ToString("0.0##", NumberFormatInfo.InvariantInfo);
			}
			return this.value;
		}

		// Token: 0x06002447 RID: 9287 RVA: 0x0007F7B4 File Offset: 0x0007D9B4
		public override bool Equals(object obj)
		{
			StringWithQualityHeaderValue stringWithQualityHeaderValue = obj as StringWithQualityHeaderValue;
			if (stringWithQualityHeaderValue == null)
			{
				return false;
			}
			if (string.Compare(this.value, stringWithQualityHeaderValue.value, StringComparison.OrdinalIgnoreCase) != 0)
			{
				return false;
			}
			if (this.quality != null)
			{
				return stringWithQualityHeaderValue.quality != null && this.quality.Value == stringWithQualityHeaderValue.quality.Value;
			}
			return stringWithQualityHeaderValue.quality == null;
		}

		// Token: 0x06002448 RID: 9288 RVA: 0x0007F838 File Offset: 0x0007DA38
		public override int GetHashCode()
		{
			int num = this.value.ToLowerInvariant().GetHashCode();
			if (this.quality != null)
			{
				num ^= this.quality.Value.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002449 RID: 9289 RVA: 0x0007F884 File Offset: 0x0007DA84
		public static StringWithQualityHeaderValue Parse(string input)
		{
			int num = 0;
			return (StringWithQualityHeaderValue)GenericHeaderParser.SingleValueStringWithQualityParser.ParseValue(input, null, ref num);
		}

		// Token: 0x0600244A RID: 9290 RVA: 0x0007F8AC File Offset: 0x0007DAAC
		public static bool TryParse(string input, out StringWithQualityHeaderValue parsedValue)
		{
			int num = 0;
			parsedValue = null;
			object obj;
			if (GenericHeaderParser.SingleValueStringWithQualityParser.TryParseValue(input, null, ref num, out obj))
			{
				parsedValue = (StringWithQualityHeaderValue)obj;
				return true;
			}
			return false;
		}

		// Token: 0x0600244B RID: 9291 RVA: 0x0007F8E4 File Offset: 0x0007DAE4
		internal static int GetStringWithQualityLength(string input, int startIndex, out object parsedValue)
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
			StringWithQualityHeaderValue stringWithQualityHeaderValue = new StringWithQualityHeaderValue();
			stringWithQualityHeaderValue.value = input.Substring(startIndex, tokenLength);
			int num = startIndex + tokenLength;
			num += HttpRuleParser.GetWhitespaceLength(input, num);
			if (num == input.Length || input[num] != ';')
			{
				parsedValue = stringWithQualityHeaderValue;
				return num - startIndex;
			}
			num++;
			num += HttpRuleParser.GetWhitespaceLength(input, num);
			if (!StringWithQualityHeaderValue.TryReadQuality(input, stringWithQualityHeaderValue, ref num))
			{
				return 0;
			}
			parsedValue = stringWithQualityHeaderValue;
			return num - startIndex;
		}

		// Token: 0x0600244C RID: 9292 RVA: 0x0007F988 File Offset: 0x0007DB88
		private static bool TryReadQuality(string input, StringWithQualityHeaderValue result, ref int index)
		{
			int num = index;
			if (num == input.Length || (input[num] != 'q' && input[num] != 'Q'))
			{
				return false;
			}
			num++;
			num += HttpRuleParser.GetWhitespaceLength(input, num);
			if (num == input.Length || input[num] != '=')
			{
				return false;
			}
			num++;
			num += HttpRuleParser.GetWhitespaceLength(input, num);
			if (num == input.Length)
			{
				return false;
			}
			int numberLength = HttpRuleParser.GetNumberLength(input, num, true);
			if (numberLength == 0)
			{
				return false;
			}
			double num2 = 0.0;
			if (!double.TryParse(input.Substring(num, numberLength), NumberStyles.AllowDecimalPoint, NumberFormatInfo.InvariantInfo, out num2))
			{
				return false;
			}
			if (num2 < 0.0 || num2 > 1.0)
			{
				return false;
			}
			result.quality = new double?(num2);
			num += numberLength;
			num += HttpRuleParser.GetWhitespaceLength(input, num);
			index = num;
			return true;
		}

		// Token: 0x0600244D RID: 9293 RVA: 0x0007FA84 File Offset: 0x0007DC84
		object ICloneable.Clone()
		{
			return new StringWithQualityHeaderValue(this);
		}

		// Token: 0x04001086 RID: 4230
		private string value;

		// Token: 0x04001087 RID: 4231
		private double? quality;
	}
}
