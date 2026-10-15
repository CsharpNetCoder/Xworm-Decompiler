using System;

namespace System.Net.Http.Headers
{
	// Token: 0x02000301 RID: 769
	public class ProductHeaderValue : ICloneable
	{
		// Token: 0x17000A7C RID: 2684
		// (get) Token: 0x060023F0 RID: 9200 RVA: 0x0007E330 File Offset: 0x0007C530
		public string Name
		{
			get
			{
				return this.name;
			}
		}

		// Token: 0x17000A7D RID: 2685
		// (get) Token: 0x060023F1 RID: 9201 RVA: 0x0007E338 File Offset: 0x0007C538
		public string Version
		{
			get
			{
				return this.version;
			}
		}

		// Token: 0x060023F2 RID: 9202 RVA: 0x0007E340 File Offset: 0x0007C540
		public ProductHeaderValue(string name) : this(name, null)
		{
		}

		// Token: 0x060023F3 RID: 9203 RVA: 0x0007E34C File Offset: 0x0007C54C
		public ProductHeaderValue(string name, string version)
		{
			HeaderUtilities.CheckValidToken(name, "name");
			if (!string.IsNullOrEmpty(version))
			{
				HeaderUtilities.CheckValidToken(version, "version");
				this.version = version;
			}
			this.name = name;
		}

		// Token: 0x060023F4 RID: 9204 RVA: 0x0007E384 File Offset: 0x0007C584
		private ProductHeaderValue(ProductHeaderValue source)
		{
			this.name = source.name;
			this.version = source.version;
		}

		// Token: 0x060023F5 RID: 9205 RVA: 0x0007E3A4 File Offset: 0x0007C5A4
		private ProductHeaderValue()
		{
		}

		// Token: 0x060023F6 RID: 9206 RVA: 0x0007E3AC File Offset: 0x0007C5AC
		public override string ToString()
		{
			if (string.IsNullOrEmpty(this.version))
			{
				return this.name;
			}
			return this.name + "/" + this.version;
		}

		// Token: 0x060023F7 RID: 9207 RVA: 0x0007E3DC File Offset: 0x0007C5DC
		public override bool Equals(object obj)
		{
			ProductHeaderValue productHeaderValue = obj as ProductHeaderValue;
			return productHeaderValue != null && string.Compare(this.name, productHeaderValue.name, StringComparison.OrdinalIgnoreCase) == 0 && string.Compare(this.version, productHeaderValue.version, StringComparison.OrdinalIgnoreCase) == 0;
		}

		// Token: 0x060023F8 RID: 9208 RVA: 0x0007E42C File Offset: 0x0007C62C
		public override int GetHashCode()
		{
			int num = this.name.ToLowerInvariant().GetHashCode();
			if (!string.IsNullOrEmpty(this.version))
			{
				num ^= this.version.ToLowerInvariant().GetHashCode();
			}
			return num;
		}

		// Token: 0x060023F9 RID: 9209 RVA: 0x0007E474 File Offset: 0x0007C674
		public static ProductHeaderValue Parse(string input)
		{
			int num = 0;
			return (ProductHeaderValue)GenericHeaderParser.SingleValueProductParser.ParseValue(input, null, ref num);
		}

		// Token: 0x060023FA RID: 9210 RVA: 0x0007E49C File Offset: 0x0007C69C
		public static bool TryParse(string input, out ProductHeaderValue parsedValue)
		{
			int num = 0;
			parsedValue = null;
			object obj;
			if (GenericHeaderParser.SingleValueProductParser.TryParseValue(input, null, ref num, out obj))
			{
				parsedValue = (ProductHeaderValue)obj;
				return true;
			}
			return false;
		}

		// Token: 0x060023FB RID: 9211 RVA: 0x0007E4D4 File Offset: 0x0007C6D4
		internal static int GetProductLength(string input, int startIndex, out ProductHeaderValue parsedValue)
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
			ProductHeaderValue productHeaderValue = new ProductHeaderValue();
			productHeaderValue.name = input.Substring(startIndex, tokenLength);
			int num = startIndex + tokenLength;
			num += HttpRuleParser.GetWhitespaceLength(input, num);
			if (num == input.Length || input[num] != '/')
			{
				parsedValue = productHeaderValue;
				return num - startIndex;
			}
			num++;
			num += HttpRuleParser.GetWhitespaceLength(input, num);
			int tokenLength2 = HttpRuleParser.GetTokenLength(input, num);
			if (tokenLength2 == 0)
			{
				return 0;
			}
			productHeaderValue.version = input.Substring(num, tokenLength2);
			num += tokenLength2;
			num += HttpRuleParser.GetWhitespaceLength(input, num);
			parsedValue = productHeaderValue;
			return num - startIndex;
		}

		// Token: 0x060023FC RID: 9212 RVA: 0x0007E594 File Offset: 0x0007C794
		object ICloneable.Clone()
		{
			return new ProductHeaderValue(this);
		}

		// Token: 0x04001077 RID: 4215
		private string name;

		// Token: 0x04001078 RID: 4216
		private string version;
	}
}
