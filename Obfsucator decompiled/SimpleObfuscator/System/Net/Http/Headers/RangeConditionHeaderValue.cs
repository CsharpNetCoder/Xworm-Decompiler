using System;

namespace System.Net.Http.Headers
{
	// Token: 0x02000304 RID: 772
	public class RangeConditionHeaderValue : ICloneable
	{
		// Token: 0x17000A80 RID: 2688
		// (get) Token: 0x0600240E RID: 9230 RVA: 0x0007E8C0 File Offset: 0x0007CAC0
		public DateTimeOffset? Date
		{
			get
			{
				return this.date;
			}
		}

		// Token: 0x17000A81 RID: 2689
		// (get) Token: 0x0600240F RID: 9231 RVA: 0x0007E8C8 File Offset: 0x0007CAC8
		public EntityTagHeaderValue EntityTag
		{
			get
			{
				return this.entityTag;
			}
		}

		// Token: 0x06002410 RID: 9232 RVA: 0x0007E8D0 File Offset: 0x0007CAD0
		public RangeConditionHeaderValue(DateTimeOffset date)
		{
			this.date = new DateTimeOffset?(date);
		}

		// Token: 0x06002411 RID: 9233 RVA: 0x0007E8E4 File Offset: 0x0007CAE4
		public RangeConditionHeaderValue(EntityTagHeaderValue entityTag)
		{
			if (entityTag == null)
			{
				throw new ArgumentNullException("entityTag");
			}
			this.entityTag = entityTag;
		}

		// Token: 0x06002412 RID: 9234 RVA: 0x0007E904 File Offset: 0x0007CB04
		public RangeConditionHeaderValue(string entityTag) : this(new EntityTagHeaderValue(entityTag))
		{
		}

		// Token: 0x06002413 RID: 9235 RVA: 0x0007E914 File Offset: 0x0007CB14
		private RangeConditionHeaderValue(RangeConditionHeaderValue source)
		{
			this.entityTag = source.entityTag;
			this.date = source.date;
		}

		// Token: 0x06002414 RID: 9236 RVA: 0x0007E934 File Offset: 0x0007CB34
		private RangeConditionHeaderValue()
		{
		}

		// Token: 0x06002415 RID: 9237 RVA: 0x0007E93C File Offset: 0x0007CB3C
		public override string ToString()
		{
			if (this.entityTag == null)
			{
				return HttpRuleParser.DateToString(this.date.Value);
			}
			return this.entityTag.ToString();
		}

		// Token: 0x06002416 RID: 9238 RVA: 0x0007E968 File Offset: 0x0007CB68
		public override bool Equals(object obj)
		{
			RangeConditionHeaderValue rangeConditionHeaderValue = obj as RangeConditionHeaderValue;
			if (rangeConditionHeaderValue == null)
			{
				return false;
			}
			if (this.entityTag == null)
			{
				return rangeConditionHeaderValue.date != null && this.date.Value == rangeConditionHeaderValue.date.Value;
			}
			return this.entityTag.Equals(rangeConditionHeaderValue.entityTag);
		}

		// Token: 0x06002417 RID: 9239 RVA: 0x0007E9D4 File Offset: 0x0007CBD4
		public override int GetHashCode()
		{
			if (this.entityTag == null)
			{
				return this.date.Value.GetHashCode();
			}
			return this.entityTag.GetHashCode();
		}

		// Token: 0x06002418 RID: 9240 RVA: 0x0007EA18 File Offset: 0x0007CC18
		public static RangeConditionHeaderValue Parse(string input)
		{
			int num = 0;
			return (RangeConditionHeaderValue)GenericHeaderParser.RangeConditionParser.ParseValue(input, null, ref num);
		}

		// Token: 0x06002419 RID: 9241 RVA: 0x0007EA40 File Offset: 0x0007CC40
		public static bool TryParse(string input, out RangeConditionHeaderValue parsedValue)
		{
			int num = 0;
			parsedValue = null;
			object obj;
			if (GenericHeaderParser.RangeConditionParser.TryParseValue(input, null, ref num, out obj))
			{
				parsedValue = (RangeConditionHeaderValue)obj;
				return true;
			}
			return false;
		}

		// Token: 0x0600241A RID: 9242 RVA: 0x0007EA78 File Offset: 0x0007CC78
		internal static int GetRangeConditionLength(string input, int startIndex, out object parsedValue)
		{
			parsedValue = null;
			if (string.IsNullOrEmpty(input) || startIndex + 1 >= input.Length)
			{
				return 0;
			}
			DateTimeOffset minValue = DateTimeOffset.MinValue;
			EntityTagHeaderValue entityTagHeaderValue = null;
			char c = input[startIndex];
			char c2 = input[startIndex + 1];
			int num;
			if (c == '"' || ((c == 'w' || c == 'W') && c2 == '/'))
			{
				int entityTagLength = EntityTagHeaderValue.GetEntityTagLength(input, startIndex, out entityTagHeaderValue);
				if (entityTagLength == 0)
				{
					return 0;
				}
				num = startIndex + entityTagLength;
				if (num != input.Length)
				{
					return 0;
				}
			}
			else
			{
				if (!HttpRuleParser.TryStringToDate(input.Substring(startIndex), out minValue))
				{
					return 0;
				}
				num = input.Length;
			}
			RangeConditionHeaderValue rangeConditionHeaderValue = new RangeConditionHeaderValue();
			if (entityTagHeaderValue == null)
			{
				rangeConditionHeaderValue.date = new DateTimeOffset?(minValue);
			}
			else
			{
				rangeConditionHeaderValue.entityTag = entityTagHeaderValue;
			}
			parsedValue = rangeConditionHeaderValue;
			return num - startIndex;
		}

		// Token: 0x0600241B RID: 9243 RVA: 0x0007EB58 File Offset: 0x0007CD58
		object ICloneable.Clone()
		{
			return new RangeConditionHeaderValue(this);
		}

		// Token: 0x0400107E RID: 4222
		private DateTimeOffset? date;

		// Token: 0x0400107F RID: 4223
		private EntityTagHeaderValue entityTag;
	}
}
