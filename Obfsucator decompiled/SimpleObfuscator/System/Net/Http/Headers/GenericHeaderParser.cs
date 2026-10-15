using System;
using System.Collections;

namespace System.Net.Http.Headers
{
	// Token: 0x020002F1 RID: 753
	internal sealed class GenericHeaderParser : BaseHeaderParser
	{
		// Token: 0x17000A25 RID: 2597
		// (get) Token: 0x060022B5 RID: 8885 RVA: 0x00079E50 File Offset: 0x00078050
		public override IEqualityComparer Comparer
		{
			get
			{
				return this.comparer;
			}
		}

		// Token: 0x060022B6 RID: 8886 RVA: 0x00079E58 File Offset: 0x00078058
		private GenericHeaderParser(bool supportsMultipleValues, GenericHeaderParser.GetParsedValueLengthDelegate getParsedValueLength) : this(supportsMultipleValues, getParsedValueLength, null)
		{
		}

		// Token: 0x060022B7 RID: 8887 RVA: 0x00079E64 File Offset: 0x00078064
		private GenericHeaderParser(bool supportsMultipleValues, GenericHeaderParser.GetParsedValueLengthDelegate getParsedValueLength, IEqualityComparer comparer) : base(supportsMultipleValues)
		{
			this.getParsedValueLength = getParsedValueLength;
			this.comparer = comparer;
		}

		// Token: 0x060022B8 RID: 8888 RVA: 0x00079E7C File Offset: 0x0007807C
		protected override int GetParsedValueLength(string value, int startIndex, object storeValue, out object parsedValue)
		{
			return this.getParsedValueLength(value, startIndex, out parsedValue);
		}

		// Token: 0x060022B9 RID: 8889 RVA: 0x00079E90 File Offset: 0x00078090
		private static int ParseNameValue(string value, int startIndex, out object parsedValue)
		{
			NameValueHeaderValue nameValueHeaderValue = null;
			int nameValueLength = NameValueHeaderValue.GetNameValueLength(value, startIndex, out nameValueHeaderValue);
			parsedValue = nameValueHeaderValue;
			return nameValueLength;
		}

		// Token: 0x060022BA RID: 8890 RVA: 0x00079EB4 File Offset: 0x000780B4
		private static int ParseProduct(string value, int startIndex, out object parsedValue)
		{
			ProductHeaderValue productHeaderValue = null;
			int productLength = ProductHeaderValue.GetProductLength(value, startIndex, out productHeaderValue);
			parsedValue = productHeaderValue;
			return productLength;
		}

		// Token: 0x060022BB RID: 8891 RVA: 0x00079ED8 File Offset: 0x000780D8
		private static int ParseSingleEntityTag(string value, int startIndex, out object parsedValue)
		{
			EntityTagHeaderValue entityTagHeaderValue = null;
			parsedValue = null;
			int entityTagLength = EntityTagHeaderValue.GetEntityTagLength(value, startIndex, out entityTagHeaderValue);
			if (entityTagHeaderValue == EntityTagHeaderValue.Any)
			{
				return 0;
			}
			parsedValue = entityTagHeaderValue;
			return entityTagLength;
		}

		// Token: 0x060022BC RID: 8892 RVA: 0x00079F0C File Offset: 0x0007810C
		private static int ParseMultipleEntityTags(string value, int startIndex, out object parsedValue)
		{
			EntityTagHeaderValue entityTagHeaderValue = null;
			int entityTagLength = EntityTagHeaderValue.GetEntityTagLength(value, startIndex, out entityTagHeaderValue);
			parsedValue = entityTagHeaderValue;
			return entityTagLength;
		}

		// Token: 0x060022BD RID: 8893 RVA: 0x00079F30 File Offset: 0x00078130
		private static int ParseMailAddress(string value, int startIndex, out object parsedValue)
		{
			parsedValue = null;
			if (HttpRuleParser.ContainsInvalidNewLine(value, startIndex))
			{
				return 0;
			}
			string text = value.Substring(startIndex);
			if (!HeaderUtilities.IsValidEmailAddress(text))
			{
				return 0;
			}
			parsedValue = text;
			return text.Length;
		}

		// Token: 0x060022BE RID: 8894 RVA: 0x00079F70 File Offset: 0x00078170
		private static int ParseHost(string value, int startIndex, out object parsedValue)
		{
			string text = null;
			int hostLength = HttpRuleParser.GetHostLength(value, startIndex, false, out text);
			parsedValue = text;
			return hostLength;
		}

		// Token: 0x060022BF RID: 8895 RVA: 0x00079F94 File Offset: 0x00078194
		private static int ParseTokenList(string value, int startIndex, out object parsedValue)
		{
			int tokenLength = HttpRuleParser.GetTokenLength(value, startIndex);
			parsedValue = value.Substring(startIndex, tokenLength);
			return tokenLength;
		}

		// Token: 0x04001019 RID: 4121
		internal static readonly HttpHeaderParser HostParser = new GenericHeaderParser(false, new GenericHeaderParser.GetParsedValueLengthDelegate(GenericHeaderParser.ParseHost), StringComparer.OrdinalIgnoreCase);

		// Token: 0x0400101A RID: 4122
		internal static readonly HttpHeaderParser TokenListParser = new GenericHeaderParser(true, new GenericHeaderParser.GetParsedValueLengthDelegate(GenericHeaderParser.ParseTokenList), StringComparer.OrdinalIgnoreCase);

		// Token: 0x0400101B RID: 4123
		internal static readonly HttpHeaderParser SingleValueNameValueWithParametersParser = new GenericHeaderParser(false, new GenericHeaderParser.GetParsedValueLengthDelegate(NameValueWithParametersHeaderValue.GetNameValueWithParametersLength));

		// Token: 0x0400101C RID: 4124
		internal static readonly HttpHeaderParser MultipleValueNameValueWithParametersParser = new GenericHeaderParser(true, new GenericHeaderParser.GetParsedValueLengthDelegate(NameValueWithParametersHeaderValue.GetNameValueWithParametersLength));

		// Token: 0x0400101D RID: 4125
		internal static readonly HttpHeaderParser SingleValueNameValueParser = new GenericHeaderParser(false, new GenericHeaderParser.GetParsedValueLengthDelegate(GenericHeaderParser.ParseNameValue));

		// Token: 0x0400101E RID: 4126
		internal static readonly HttpHeaderParser MultipleValueNameValueParser = new GenericHeaderParser(true, new GenericHeaderParser.GetParsedValueLengthDelegate(GenericHeaderParser.ParseNameValue));

		// Token: 0x0400101F RID: 4127
		internal static readonly HttpHeaderParser MailAddressParser = new GenericHeaderParser(false, new GenericHeaderParser.GetParsedValueLengthDelegate(GenericHeaderParser.ParseMailAddress));

		// Token: 0x04001020 RID: 4128
		internal static readonly HttpHeaderParser SingleValueProductParser = new GenericHeaderParser(false, new GenericHeaderParser.GetParsedValueLengthDelegate(GenericHeaderParser.ParseProduct));

		// Token: 0x04001021 RID: 4129
		internal static readonly HttpHeaderParser MultipleValueProductParser = new GenericHeaderParser(true, new GenericHeaderParser.GetParsedValueLengthDelegate(GenericHeaderParser.ParseProduct));

		// Token: 0x04001022 RID: 4130
		internal static readonly HttpHeaderParser RangeConditionParser = new GenericHeaderParser(false, new GenericHeaderParser.GetParsedValueLengthDelegate(RangeConditionHeaderValue.GetRangeConditionLength));

		// Token: 0x04001023 RID: 4131
		internal static readonly HttpHeaderParser SingleValueAuthenticationParser = new GenericHeaderParser(false, new GenericHeaderParser.GetParsedValueLengthDelegate(AuthenticationHeaderValue.GetAuthenticationLength));

		// Token: 0x04001024 RID: 4132
		internal static readonly HttpHeaderParser MultipleValueAuthenticationParser = new GenericHeaderParser(true, new GenericHeaderParser.GetParsedValueLengthDelegate(AuthenticationHeaderValue.GetAuthenticationLength));

		// Token: 0x04001025 RID: 4133
		internal static readonly HttpHeaderParser RangeParser = new GenericHeaderParser(false, new GenericHeaderParser.GetParsedValueLengthDelegate(RangeHeaderValue.GetRangeLength));

		// Token: 0x04001026 RID: 4134
		internal static readonly HttpHeaderParser RetryConditionParser = new GenericHeaderParser(false, new GenericHeaderParser.GetParsedValueLengthDelegate(RetryConditionHeaderValue.GetRetryConditionLength));

		// Token: 0x04001027 RID: 4135
		internal static readonly HttpHeaderParser ContentRangeParser = new GenericHeaderParser(false, new GenericHeaderParser.GetParsedValueLengthDelegate(ContentRangeHeaderValue.GetContentRangeLength));

		// Token: 0x04001028 RID: 4136
		internal static readonly HttpHeaderParser ContentDispositionParser = new GenericHeaderParser(false, new GenericHeaderParser.GetParsedValueLengthDelegate(ContentDispositionHeaderValue.GetDispositionTypeLength));

		// Token: 0x04001029 RID: 4137
		internal static readonly HttpHeaderParser SingleValueStringWithQualityParser = new GenericHeaderParser(false, new GenericHeaderParser.GetParsedValueLengthDelegate(StringWithQualityHeaderValue.GetStringWithQualityLength));

		// Token: 0x0400102A RID: 4138
		internal static readonly HttpHeaderParser MultipleValueStringWithQualityParser = new GenericHeaderParser(true, new GenericHeaderParser.GetParsedValueLengthDelegate(StringWithQualityHeaderValue.GetStringWithQualityLength));

		// Token: 0x0400102B RID: 4139
		internal static readonly HttpHeaderParser SingleValueEntityTagParser = new GenericHeaderParser(false, new GenericHeaderParser.GetParsedValueLengthDelegate(GenericHeaderParser.ParseSingleEntityTag));

		// Token: 0x0400102C RID: 4140
		internal static readonly HttpHeaderParser MultipleValueEntityTagParser = new GenericHeaderParser(true, new GenericHeaderParser.GetParsedValueLengthDelegate(GenericHeaderParser.ParseMultipleEntityTags));

		// Token: 0x0400102D RID: 4141
		internal static readonly HttpHeaderParser SingleValueViaParser = new GenericHeaderParser(false, new GenericHeaderParser.GetParsedValueLengthDelegate(ViaHeaderValue.GetViaLength));

		// Token: 0x0400102E RID: 4142
		internal static readonly HttpHeaderParser MultipleValueViaParser = new GenericHeaderParser(true, new GenericHeaderParser.GetParsedValueLengthDelegate(ViaHeaderValue.GetViaLength));

		// Token: 0x0400102F RID: 4143
		internal static readonly HttpHeaderParser SingleValueWarningParser = new GenericHeaderParser(false, new GenericHeaderParser.GetParsedValueLengthDelegate(WarningHeaderValue.GetWarningLength));

		// Token: 0x04001030 RID: 4144
		internal static readonly HttpHeaderParser MultipleValueWarningParser = new GenericHeaderParser(true, new GenericHeaderParser.GetParsedValueLengthDelegate(WarningHeaderValue.GetWarningLength));

		// Token: 0x04001031 RID: 4145
		private GenericHeaderParser.GetParsedValueLengthDelegate getParsedValueLength;

		// Token: 0x04001032 RID: 4146
		private IEqualityComparer comparer;

		// Token: 0x020003C0 RID: 960
		// (Invoke) Token: 0x0600284E RID: 10318
		private delegate int GetParsedValueLengthDelegate(string value, int startIndex, out object parsedValue);
	}
}
