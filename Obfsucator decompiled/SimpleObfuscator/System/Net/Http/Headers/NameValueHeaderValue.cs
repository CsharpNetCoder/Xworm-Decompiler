using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace System.Net.Http.Headers
{
	// Token: 0x020002FE RID: 766
	public class NameValueHeaderValue : ICloneable
	{
		// Token: 0x17000A79 RID: 2681
		// (get) Token: 0x060023C3 RID: 9155 RVA: 0x0007DA54 File Offset: 0x0007BC54
		public string Name
		{
			get
			{
				return this.name;
			}
		}

		// Token: 0x17000A7A RID: 2682
		// (get) Token: 0x060023C4 RID: 9156 RVA: 0x0007DA5C File Offset: 0x0007BC5C
		// (set) Token: 0x060023C5 RID: 9157 RVA: 0x0007DA64 File Offset: 0x0007BC64
		public string Value
		{
			get
			{
				return this.value;
			}
			set
			{
				NameValueHeaderValue.CheckValueFormat(value);
				this.value = value;
			}
		}

		// Token: 0x060023C6 RID: 9158 RVA: 0x0007DA74 File Offset: 0x0007BC74
		internal NameValueHeaderValue()
		{
		}

		// Token: 0x060023C7 RID: 9159 RVA: 0x0007DA7C File Offset: 0x0007BC7C
		public NameValueHeaderValue(string name) : this(name, null)
		{
		}

		// Token: 0x060023C8 RID: 9160 RVA: 0x0007DA88 File Offset: 0x0007BC88
		public NameValueHeaderValue(string name, string value)
		{
			NameValueHeaderValue.CheckNameValueFormat(name, value);
			this.name = name;
			this.value = value;
		}

		// Token: 0x060023C9 RID: 9161 RVA: 0x0007DAA8 File Offset: 0x0007BCA8
		protected NameValueHeaderValue(NameValueHeaderValue source)
		{
			this.name = source.name;
			this.value = source.value;
		}

		// Token: 0x060023CA RID: 9162 RVA: 0x0007DAC8 File Offset: 0x0007BCC8
		public override int GetHashCode()
		{
			int hashCode = this.name.ToLowerInvariant().GetHashCode();
			if (string.IsNullOrEmpty(this.value))
			{
				return hashCode;
			}
			if (this.value[0] == '"')
			{
				return hashCode ^ this.value.GetHashCode();
			}
			return hashCode ^ this.value.ToLowerInvariant().GetHashCode();
		}

		// Token: 0x060023CB RID: 9163 RVA: 0x0007DB30 File Offset: 0x0007BD30
		public override bool Equals(object obj)
		{
			NameValueHeaderValue nameValueHeaderValue = obj as NameValueHeaderValue;
			if (nameValueHeaderValue == null)
			{
				return false;
			}
			if (string.Compare(this.name, nameValueHeaderValue.name, StringComparison.OrdinalIgnoreCase) != 0)
			{
				return false;
			}
			if (string.IsNullOrEmpty(this.value))
			{
				return string.IsNullOrEmpty(nameValueHeaderValue.value);
			}
			if (this.value[0] == '"')
			{
				return string.CompareOrdinal(this.value, nameValueHeaderValue.value) == 0;
			}
			return string.Compare(this.value, nameValueHeaderValue.value, StringComparison.OrdinalIgnoreCase) == 0;
		}

		// Token: 0x060023CC RID: 9164 RVA: 0x0007DBC4 File Offset: 0x0007BDC4
		public static NameValueHeaderValue Parse(string input)
		{
			int num = 0;
			return (NameValueHeaderValue)GenericHeaderParser.SingleValueNameValueParser.ParseValue(input, null, ref num);
		}

		// Token: 0x060023CD RID: 9165 RVA: 0x0007DBEC File Offset: 0x0007BDEC
		public static bool TryParse(string input, out NameValueHeaderValue parsedValue)
		{
			int num = 0;
			parsedValue = null;
			object obj;
			if (GenericHeaderParser.SingleValueNameValueParser.TryParseValue(input, null, ref num, out obj))
			{
				parsedValue = (NameValueHeaderValue)obj;
				return true;
			}
			return false;
		}

		// Token: 0x060023CE RID: 9166 RVA: 0x0007DC24 File Offset: 0x0007BE24
		public override string ToString()
		{
			if (!string.IsNullOrEmpty(this.value))
			{
				return this.name + "=" + this.value;
			}
			return this.name;
		}

		// Token: 0x060023CF RID: 9167 RVA: 0x0007DC54 File Offset: 0x0007BE54
		internal static void ToString(ICollection<NameValueHeaderValue> values, char separator, bool leadingSeparator, StringBuilder destination)
		{
			if (values == null || values.Count == 0)
			{
				return;
			}
			foreach (NameValueHeaderValue nameValueHeaderValue in values)
			{
				if (leadingSeparator || destination.Length > 0)
				{
					destination.Append(separator);
					destination.Append(' ');
				}
				destination.Append(nameValueHeaderValue.ToString());
			}
		}

		// Token: 0x060023D0 RID: 9168 RVA: 0x0007DCE0 File Offset: 0x0007BEE0
		internal static string ToString(ICollection<NameValueHeaderValue> values, char separator, bool leadingSeparator)
		{
			if (values == null || values.Count == 0)
			{
				return null;
			}
			StringBuilder stringBuilder = new StringBuilder();
			NameValueHeaderValue.ToString(values, separator, leadingSeparator, stringBuilder);
			return stringBuilder.ToString();
		}

		// Token: 0x060023D1 RID: 9169 RVA: 0x0007DD1C File Offset: 0x0007BF1C
		internal static int GetHashCode(ICollection<NameValueHeaderValue> values)
		{
			if (values == null || values.Count == 0)
			{
				return 0;
			}
			int num = 0;
			foreach (NameValueHeaderValue nameValueHeaderValue in values)
			{
				num ^= nameValueHeaderValue.GetHashCode();
			}
			return num;
		}

		// Token: 0x060023D2 RID: 9170 RVA: 0x0007DD88 File Offset: 0x0007BF88
		internal static int GetNameValueLength(string input, int startIndex, out NameValueHeaderValue parsedValue)
		{
			return NameValueHeaderValue.GetNameValueLength(input, startIndex, NameValueHeaderValue.defaultNameValueCreator, out parsedValue);
		}

		// Token: 0x060023D3 RID: 9171 RVA: 0x0007DD98 File Offset: 0x0007BF98
		internal static int GetNameValueLength(string input, int startIndex, Func<NameValueHeaderValue> nameValueCreator, out NameValueHeaderValue parsedValue)
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
			num += HttpRuleParser.GetWhitespaceLength(input, num);
			if (num == input.Length || input[num] != '=')
			{
				parsedValue = nameValueCreator();
				parsedValue.name = text;
				num += HttpRuleParser.GetWhitespaceLength(input, num);
				return num - startIndex;
			}
			num++;
			num += HttpRuleParser.GetWhitespaceLength(input, num);
			int valueLength = NameValueHeaderValue.GetValueLength(input, num);
			if (valueLength == 0)
			{
				return 0;
			}
			parsedValue = nameValueCreator();
			parsedValue.name = text;
			parsedValue.value = input.Substring(num, valueLength);
			num += valueLength;
			num += HttpRuleParser.GetWhitespaceLength(input, num);
			return num - startIndex;
		}

		// Token: 0x060023D4 RID: 9172 RVA: 0x0007DE74 File Offset: 0x0007C074
		internal static int GetNameValueListLength(string input, int startIndex, char delimiter, ICollection<NameValueHeaderValue> nameValueCollection)
		{
			if (string.IsNullOrEmpty(input) || startIndex >= input.Length)
			{
				return 0;
			}
			int num = startIndex + HttpRuleParser.GetWhitespaceLength(input, startIndex);
			for (;;)
			{
				NameValueHeaderValue item = null;
				int nameValueLength = NameValueHeaderValue.GetNameValueLength(input, num, NameValueHeaderValue.defaultNameValueCreator, out item);
				if (nameValueLength == 0)
				{
					break;
				}
				nameValueCollection.Add(item);
				num += nameValueLength;
				num += HttpRuleParser.GetWhitespaceLength(input, num);
				if (num == input.Length || input[num] != delimiter)
				{
					goto IL_6A;
				}
				num++;
				num += HttpRuleParser.GetWhitespaceLength(input, num);
			}
			return 0;
			IL_6A:
			return num - startIndex;
		}

		// Token: 0x060023D5 RID: 9173 RVA: 0x0007DF04 File Offset: 0x0007C104
		internal static NameValueHeaderValue Find(ICollection<NameValueHeaderValue> values, string name)
		{
			if (values == null || values.Count == 0)
			{
				return null;
			}
			foreach (NameValueHeaderValue nameValueHeaderValue in values)
			{
				if (string.Compare(nameValueHeaderValue.Name, name, StringComparison.OrdinalIgnoreCase) == 0)
				{
					return nameValueHeaderValue;
				}
			}
			return null;
		}

		// Token: 0x060023D6 RID: 9174 RVA: 0x0007DF80 File Offset: 0x0007C180
		internal static int GetValueLength(string input, int startIndex)
		{
			if (startIndex >= input.Length)
			{
				return 0;
			}
			int tokenLength = HttpRuleParser.GetTokenLength(input, startIndex);
			if (tokenLength == 0 && HttpRuleParser.GetQuotedStringLength(input, startIndex, out tokenLength) != HttpParseResult.Parsed)
			{
				return 0;
			}
			return tokenLength;
		}

		// Token: 0x060023D7 RID: 9175 RVA: 0x0007DFC0 File Offset: 0x0007C1C0
		private static void CheckNameValueFormat(string name, string value)
		{
			HeaderUtilities.CheckValidToken(name, "name");
			NameValueHeaderValue.CheckValueFormat(value);
		}

		// Token: 0x060023D8 RID: 9176 RVA: 0x0007DFD4 File Offset: 0x0007C1D4
		private static void CheckValueFormat(string value)
		{
			if (!string.IsNullOrEmpty(value) && NameValueHeaderValue.GetValueLength(value, 0) != value.Length)
			{
				throw new FormatException(string.Format(CultureInfo.InvariantCulture, SR.net_http_headers_invalid_value, new object[]
				{
					value
				}));
			}
		}

		// Token: 0x060023D9 RID: 9177 RVA: 0x0007E024 File Offset: 0x0007C224
		private static NameValueHeaderValue CreateNameValue()
		{
			return new NameValueHeaderValue();
		}

		// Token: 0x060023DA RID: 9178 RVA: 0x0007E02C File Offset: 0x0007C22C
		object ICloneable.Clone()
		{
			return new NameValueHeaderValue(this);
		}

		// Token: 0x04001070 RID: 4208
		private static readonly Func<NameValueHeaderValue> defaultNameValueCreator = new Func<NameValueHeaderValue>(NameValueHeaderValue.CreateNameValue);

		// Token: 0x04001071 RID: 4209
		private string name;

		// Token: 0x04001072 RID: 4210
		private string value;
	}
}
