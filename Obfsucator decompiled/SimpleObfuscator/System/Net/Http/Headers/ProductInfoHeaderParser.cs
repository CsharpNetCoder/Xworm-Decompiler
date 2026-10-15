using System;

namespace System.Net.Http.Headers
{
	// Token: 0x02000302 RID: 770
	internal class ProductInfoHeaderParser : HttpHeaderParser
	{
		// Token: 0x060023FD RID: 9213 RVA: 0x0007E59C File Offset: 0x0007C79C
		private ProductInfoHeaderParser(bool supportsMultipleValues) : base(supportsMultipleValues, " ")
		{
		}

		// Token: 0x060023FE RID: 9214 RVA: 0x0007E5AC File Offset: 0x0007C7AC
		public override bool TryParseValue(string value, object storeValue, ref int index, out object parsedValue)
		{
			parsedValue = null;
			if (string.IsNullOrEmpty(value) || index == value.Length)
			{
				return false;
			}
			int num = index + HttpRuleParser.GetWhitespaceLength(value, index);
			if (num == value.Length)
			{
				return false;
			}
			ProductInfoHeaderValue productInfoHeaderValue = null;
			int productInfoLength = ProductInfoHeaderValue.GetProductInfoLength(value, num, out productInfoHeaderValue);
			if (productInfoLength == 0)
			{
				return false;
			}
			num += productInfoLength;
			if (num < value.Length)
			{
				char c = value[num - 1];
				if (c != ' ' && c != '\t')
				{
					return false;
				}
			}
			index = num;
			parsedValue = productInfoHeaderValue;
			return true;
		}

		// Token: 0x04001079 RID: 4217
		private const string separator = " ";

		// Token: 0x0400107A RID: 4218
		internal static readonly ProductInfoHeaderParser SingleValueParser = new ProductInfoHeaderParser(false);

		// Token: 0x0400107B RID: 4219
		internal static readonly ProductInfoHeaderParser MultipleValueParser = new ProductInfoHeaderParser(true);
	}
}
