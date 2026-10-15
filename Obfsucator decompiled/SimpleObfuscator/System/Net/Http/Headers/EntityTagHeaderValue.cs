using System;

namespace System.Net.Http.Headers
{
	// Token: 0x020002F0 RID: 752
	public class EntityTagHeaderValue : ICloneable
	{
		// Token: 0x17000A22 RID: 2594
		// (get) Token: 0x060022A7 RID: 8871 RVA: 0x00079B6C File Offset: 0x00077D6C
		public string Tag
		{
			get
			{
				return this.tag;
			}
		}

		// Token: 0x17000A23 RID: 2595
		// (get) Token: 0x060022A8 RID: 8872 RVA: 0x00079B74 File Offset: 0x00077D74
		public bool IsWeak
		{
			get
			{
				return this.isWeak;
			}
		}

		// Token: 0x17000A24 RID: 2596
		// (get) Token: 0x060022A9 RID: 8873 RVA: 0x00079B7C File Offset: 0x00077D7C
		public static EntityTagHeaderValue Any
		{
			get
			{
				if (EntityTagHeaderValue.any == null)
				{
					EntityTagHeaderValue.any = new EntityTagHeaderValue();
					EntityTagHeaderValue.any.tag = "*";
					EntityTagHeaderValue.any.isWeak = false;
				}
				return EntityTagHeaderValue.any;
			}
		}

		// Token: 0x060022AA RID: 8874 RVA: 0x00079BB4 File Offset: 0x00077DB4
		public EntityTagHeaderValue(string tag) : this(tag, false)
		{
		}

		// Token: 0x060022AB RID: 8875 RVA: 0x00079BC0 File Offset: 0x00077DC0
		public EntityTagHeaderValue(string tag, bool isWeak)
		{
			if (string.IsNullOrEmpty(tag))
			{
				throw new ArgumentException(SR.net_http_argument_empty_string, "tag");
			}
			int num = 0;
			if (HttpRuleParser.GetQuotedStringLength(tag, 0, out num) != HttpParseResult.Parsed || num != tag.Length)
			{
				throw new FormatException(SR.net_http_headers_invalid_etag_name);
			}
			this.tag = tag;
			this.isWeak = isWeak;
		}

		// Token: 0x060022AC RID: 8876 RVA: 0x00079C28 File Offset: 0x00077E28
		private EntityTagHeaderValue(EntityTagHeaderValue source)
		{
			this.tag = source.tag;
			this.isWeak = source.isWeak;
		}

		// Token: 0x060022AD RID: 8877 RVA: 0x00079C48 File Offset: 0x00077E48
		private EntityTagHeaderValue()
		{
		}

		// Token: 0x060022AE RID: 8878 RVA: 0x00079C50 File Offset: 0x00077E50
		public override string ToString()
		{
			if (this.isWeak)
			{
				return "W/" + this.tag;
			}
			return this.tag;
		}

		// Token: 0x060022AF RID: 8879 RVA: 0x00079C74 File Offset: 0x00077E74
		public override bool Equals(object obj)
		{
			EntityTagHeaderValue entityTagHeaderValue = obj as EntityTagHeaderValue;
			return entityTagHeaderValue != null && this.isWeak == entityTagHeaderValue.isWeak && string.CompareOrdinal(this.tag, entityTagHeaderValue.tag) == 0;
		}

		// Token: 0x060022B0 RID: 8880 RVA: 0x00079CBC File Offset: 0x00077EBC
		public override int GetHashCode()
		{
			return this.tag.GetHashCode() ^ this.isWeak.GetHashCode();
		}

		// Token: 0x060022B1 RID: 8881 RVA: 0x00079CD8 File Offset: 0x00077ED8
		public static EntityTagHeaderValue Parse(string input)
		{
			int num = 0;
			return (EntityTagHeaderValue)GenericHeaderParser.SingleValueEntityTagParser.ParseValue(input, null, ref num);
		}

		// Token: 0x060022B2 RID: 8882 RVA: 0x00079D00 File Offset: 0x00077F00
		public static bool TryParse(string input, out EntityTagHeaderValue parsedValue)
		{
			int num = 0;
			parsedValue = null;
			object obj;
			if (GenericHeaderParser.SingleValueEntityTagParser.TryParseValue(input, null, ref num, out obj))
			{
				parsedValue = (EntityTagHeaderValue)obj;
				return true;
			}
			return false;
		}

		// Token: 0x060022B3 RID: 8883 RVA: 0x00079D38 File Offset: 0x00077F38
		internal static int GetEntityTagLength(string input, int startIndex, out EntityTagHeaderValue parsedValue)
		{
			parsedValue = null;
			if (string.IsNullOrEmpty(input) || startIndex >= input.Length)
			{
				return 0;
			}
			bool flag = false;
			int num = startIndex;
			char c = input[startIndex];
			if (c == '*')
			{
				parsedValue = EntityTagHeaderValue.Any;
				num++;
			}
			else
			{
				if (c == 'W' || c == 'w')
				{
					num++;
					if (num + 2 >= input.Length || input[num] != '/')
					{
						return 0;
					}
					flag = true;
					num++;
					num += HttpRuleParser.GetWhitespaceLength(input, num);
				}
				int startIndex2 = num;
				int num2 = 0;
				if (HttpRuleParser.GetQuotedStringLength(input, num, out num2) != HttpParseResult.Parsed)
				{
					return 0;
				}
				parsedValue = new EntityTagHeaderValue();
				if (num2 == input.Length)
				{
					parsedValue.tag = input;
					parsedValue.isWeak = false;
				}
				else
				{
					parsedValue.tag = input.Substring(startIndex2, num2);
					parsedValue.isWeak = flag;
				}
				num += num2;
			}
			num += HttpRuleParser.GetWhitespaceLength(input, num);
			return num - startIndex;
		}

		// Token: 0x060022B4 RID: 8884 RVA: 0x00079E34 File Offset: 0x00078034
		object ICloneable.Clone()
		{
			if (this == EntityTagHeaderValue.any)
			{
				return EntityTagHeaderValue.any;
			}
			return new EntityTagHeaderValue(this);
		}

		// Token: 0x04001016 RID: 4118
		private static EntityTagHeaderValue any;

		// Token: 0x04001017 RID: 4119
		private string tag;

		// Token: 0x04001018 RID: 4120
		private bool isWeak;
	}
}
