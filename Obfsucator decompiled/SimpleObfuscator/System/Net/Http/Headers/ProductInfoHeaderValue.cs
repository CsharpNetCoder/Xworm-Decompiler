using System;
using System.Globalization;

namespace System.Net.Http.Headers
{
	// Token: 0x02000303 RID: 771
	public class ProductInfoHeaderValue : ICloneable
	{
		// Token: 0x17000A7E RID: 2686
		// (get) Token: 0x06002400 RID: 9216 RVA: 0x0007E658 File Offset: 0x0007C858
		public ProductHeaderValue Product
		{
			get
			{
				return this.product;
			}
		}

		// Token: 0x17000A7F RID: 2687
		// (get) Token: 0x06002401 RID: 9217 RVA: 0x0007E660 File Offset: 0x0007C860
		public string Comment
		{
			get
			{
				return this.comment;
			}
		}

		// Token: 0x06002402 RID: 9218 RVA: 0x0007E668 File Offset: 0x0007C868
		public ProductInfoHeaderValue(string productName, string productVersion) : this(new ProductHeaderValue(productName, productVersion))
		{
		}

		// Token: 0x06002403 RID: 9219 RVA: 0x0007E678 File Offset: 0x0007C878
		public ProductInfoHeaderValue(ProductHeaderValue product)
		{
			if (product == null)
			{
				throw new ArgumentNullException("product");
			}
			this.product = product;
		}

		// Token: 0x06002404 RID: 9220 RVA: 0x0007E698 File Offset: 0x0007C898
		public ProductInfoHeaderValue(string comment)
		{
			HeaderUtilities.CheckValidComment(comment, "comment");
			this.comment = comment;
		}

		// Token: 0x06002405 RID: 9221 RVA: 0x0007E6B4 File Offset: 0x0007C8B4
		private ProductInfoHeaderValue(ProductInfoHeaderValue source)
		{
			this.product = source.product;
			this.comment = source.comment;
		}

		// Token: 0x06002406 RID: 9222 RVA: 0x0007E6D4 File Offset: 0x0007C8D4
		private ProductInfoHeaderValue()
		{
		}

		// Token: 0x06002407 RID: 9223 RVA: 0x0007E6DC File Offset: 0x0007C8DC
		public override string ToString()
		{
			if (this.product == null)
			{
				return this.comment;
			}
			return this.product.ToString();
		}

		// Token: 0x06002408 RID: 9224 RVA: 0x0007E6FC File Offset: 0x0007C8FC
		public override bool Equals(object obj)
		{
			ProductInfoHeaderValue productInfoHeaderValue = obj as ProductInfoHeaderValue;
			if (productInfoHeaderValue == null)
			{
				return false;
			}
			if (this.product == null)
			{
				return string.CompareOrdinal(this.comment, productInfoHeaderValue.comment) == 0;
			}
			return this.product.Equals(productInfoHeaderValue.product);
		}

		// Token: 0x06002409 RID: 9225 RVA: 0x0007E750 File Offset: 0x0007C950
		public override int GetHashCode()
		{
			if (this.product == null)
			{
				return this.comment.GetHashCode();
			}
			return this.product.GetHashCode();
		}

		// Token: 0x0600240A RID: 9226 RVA: 0x0007E774 File Offset: 0x0007C974
		public static ProductInfoHeaderValue Parse(string input)
		{
			int num = 0;
			object obj = ProductInfoHeaderParser.SingleValueParser.ParseValue(input, null, ref num);
			if (num < input.Length)
			{
				throw new FormatException(string.Format(CultureInfo.InvariantCulture, SR.net_http_headers_invalid_value, new object[]
				{
					input.Substring(num)
				}));
			}
			return (ProductInfoHeaderValue)obj;
		}

		// Token: 0x0600240B RID: 9227 RVA: 0x0007E7D0 File Offset: 0x0007C9D0
		public static bool TryParse(string input, out ProductInfoHeaderValue parsedValue)
		{
			int num = 0;
			parsedValue = null;
			object obj;
			if (!ProductInfoHeaderParser.SingleValueParser.TryParseValue(input, null, ref num, out obj))
			{
				return false;
			}
			if (num < input.Length)
			{
				return false;
			}
			parsedValue = (ProductInfoHeaderValue)obj;
			return true;
		}

		// Token: 0x0600240C RID: 9228 RVA: 0x0007E814 File Offset: 0x0007CA14
		internal static int GetProductInfoLength(string input, int startIndex, out ProductInfoHeaderValue parsedValue)
		{
			parsedValue = null;
			if (string.IsNullOrEmpty(input) || startIndex >= input.Length)
			{
				return 0;
			}
			string text = null;
			ProductHeaderValue productHeaderValue = null;
			int num2;
			if (input[startIndex] == '(')
			{
				int num = 0;
				if (HttpRuleParser.GetCommentLength(input, startIndex, out num) != HttpParseResult.Parsed)
				{
					return 0;
				}
				text = input.Substring(startIndex, num);
				num2 = startIndex + num;
				num2 += HttpRuleParser.GetWhitespaceLength(input, num2);
			}
			else
			{
				int productLength = ProductHeaderValue.GetProductLength(input, startIndex, out productHeaderValue);
				if (productLength == 0)
				{
					return 0;
				}
				num2 = startIndex + productLength;
			}
			parsedValue = new ProductInfoHeaderValue();
			parsedValue.product = productHeaderValue;
			parsedValue.comment = text;
			return num2 - startIndex;
		}

		// Token: 0x0600240D RID: 9229 RVA: 0x0007E8B8 File Offset: 0x0007CAB8
		object ICloneable.Clone()
		{
			return new ProductInfoHeaderValue(this);
		}

		// Token: 0x0400107C RID: 4220
		private ProductHeaderValue product;

		// Token: 0x0400107D RID: 4221
		private string comment;
	}
}
