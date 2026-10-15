using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace System.Net.Http.Headers
{
	// Token: 0x020002EC RID: 748
	public class CacheControlHeaderValue : ICloneable
	{
		// Token: 0x17000A03 RID: 2563
		// (get) Token: 0x06002236 RID: 8758 RVA: 0x000777E8 File Offset: 0x000759E8
		// (set) Token: 0x06002237 RID: 8759 RVA: 0x000777F0 File Offset: 0x000759F0
		public bool NoCache
		{
			get
			{
				return this.noCache;
			}
			set
			{
				this.noCache = value;
			}
		}

		// Token: 0x17000A04 RID: 2564
		// (get) Token: 0x06002238 RID: 8760 RVA: 0x000777FC File Offset: 0x000759FC
		public ICollection<string> NoCacheHeaders
		{
			get
			{
				if (this.noCacheHeaders == null)
				{
					this.noCacheHeaders = new ObjectCollection<string>(CacheControlHeaderValue.checkIsValidToken);
				}
				return this.noCacheHeaders;
			}
		}

		// Token: 0x17000A05 RID: 2565
		// (get) Token: 0x06002239 RID: 8761 RVA: 0x00077820 File Offset: 0x00075A20
		// (set) Token: 0x0600223A RID: 8762 RVA: 0x00077828 File Offset: 0x00075A28
		public bool NoStore
		{
			get
			{
				return this.noStore;
			}
			set
			{
				this.noStore = value;
			}
		}

		// Token: 0x17000A06 RID: 2566
		// (get) Token: 0x0600223B RID: 8763 RVA: 0x00077834 File Offset: 0x00075A34
		// (set) Token: 0x0600223C RID: 8764 RVA: 0x0007783C File Offset: 0x00075A3C
		public TimeSpan? MaxAge
		{
			get
			{
				return this.maxAge;
			}
			set
			{
				this.maxAge = value;
			}
		}

		// Token: 0x17000A07 RID: 2567
		// (get) Token: 0x0600223D RID: 8765 RVA: 0x00077848 File Offset: 0x00075A48
		// (set) Token: 0x0600223E RID: 8766 RVA: 0x00077850 File Offset: 0x00075A50
		public TimeSpan? SharedMaxAge
		{
			get
			{
				return this.sharedMaxAge;
			}
			set
			{
				this.sharedMaxAge = value;
			}
		}

		// Token: 0x17000A08 RID: 2568
		// (get) Token: 0x0600223F RID: 8767 RVA: 0x0007785C File Offset: 0x00075A5C
		// (set) Token: 0x06002240 RID: 8768 RVA: 0x00077864 File Offset: 0x00075A64
		public bool MaxStale
		{
			get
			{
				return this.maxStale;
			}
			set
			{
				this.maxStale = value;
			}
		}

		// Token: 0x17000A09 RID: 2569
		// (get) Token: 0x06002241 RID: 8769 RVA: 0x00077870 File Offset: 0x00075A70
		// (set) Token: 0x06002242 RID: 8770 RVA: 0x00077878 File Offset: 0x00075A78
		public TimeSpan? MaxStaleLimit
		{
			get
			{
				return this.maxStaleLimit;
			}
			set
			{
				this.maxStaleLimit = value;
			}
		}

		// Token: 0x17000A0A RID: 2570
		// (get) Token: 0x06002243 RID: 8771 RVA: 0x00077884 File Offset: 0x00075A84
		// (set) Token: 0x06002244 RID: 8772 RVA: 0x0007788C File Offset: 0x00075A8C
		public TimeSpan? MinFresh
		{
			get
			{
				return this.minFresh;
			}
			set
			{
				this.minFresh = value;
			}
		}

		// Token: 0x17000A0B RID: 2571
		// (get) Token: 0x06002245 RID: 8773 RVA: 0x00077898 File Offset: 0x00075A98
		// (set) Token: 0x06002246 RID: 8774 RVA: 0x000778A0 File Offset: 0x00075AA0
		public bool NoTransform
		{
			get
			{
				return this.noTransform;
			}
			set
			{
				this.noTransform = value;
			}
		}

		// Token: 0x17000A0C RID: 2572
		// (get) Token: 0x06002247 RID: 8775 RVA: 0x000778AC File Offset: 0x00075AAC
		// (set) Token: 0x06002248 RID: 8776 RVA: 0x000778B4 File Offset: 0x00075AB4
		public bool OnlyIfCached
		{
			get
			{
				return this.onlyIfCached;
			}
			set
			{
				this.onlyIfCached = value;
			}
		}

		// Token: 0x17000A0D RID: 2573
		// (get) Token: 0x06002249 RID: 8777 RVA: 0x000778C0 File Offset: 0x00075AC0
		// (set) Token: 0x0600224A RID: 8778 RVA: 0x000778C8 File Offset: 0x00075AC8
		public bool Public
		{
			get
			{
				return this.publicField;
			}
			set
			{
				this.publicField = value;
			}
		}

		// Token: 0x17000A0E RID: 2574
		// (get) Token: 0x0600224B RID: 8779 RVA: 0x000778D4 File Offset: 0x00075AD4
		// (set) Token: 0x0600224C RID: 8780 RVA: 0x000778DC File Offset: 0x00075ADC
		public bool Private
		{
			get
			{
				return this.privateField;
			}
			set
			{
				this.privateField = value;
			}
		}

		// Token: 0x17000A0F RID: 2575
		// (get) Token: 0x0600224D RID: 8781 RVA: 0x000778E8 File Offset: 0x00075AE8
		public ICollection<string> PrivateHeaders
		{
			get
			{
				if (this.privateHeaders == null)
				{
					this.privateHeaders = new ObjectCollection<string>(CacheControlHeaderValue.checkIsValidToken);
				}
				return this.privateHeaders;
			}
		}

		// Token: 0x17000A10 RID: 2576
		// (get) Token: 0x0600224E RID: 8782 RVA: 0x0007790C File Offset: 0x00075B0C
		// (set) Token: 0x0600224F RID: 8783 RVA: 0x00077914 File Offset: 0x00075B14
		public bool MustRevalidate
		{
			get
			{
				return this.mustRevalidate;
			}
			set
			{
				this.mustRevalidate = value;
			}
		}

		// Token: 0x17000A11 RID: 2577
		// (get) Token: 0x06002250 RID: 8784 RVA: 0x00077920 File Offset: 0x00075B20
		// (set) Token: 0x06002251 RID: 8785 RVA: 0x00077928 File Offset: 0x00075B28
		public bool ProxyRevalidate
		{
			get
			{
				return this.proxyRevalidate;
			}
			set
			{
				this.proxyRevalidate = value;
			}
		}

		// Token: 0x17000A12 RID: 2578
		// (get) Token: 0x06002252 RID: 8786 RVA: 0x00077934 File Offset: 0x00075B34
		public ICollection<NameValueHeaderValue> Extensions
		{
			get
			{
				if (this.extensions == null)
				{
					this.extensions = new ObjectCollection<NameValueHeaderValue>();
				}
				return this.extensions;
			}
		}

		// Token: 0x06002253 RID: 8787 RVA: 0x00077954 File Offset: 0x00075B54
		public CacheControlHeaderValue()
		{
		}

		// Token: 0x06002254 RID: 8788 RVA: 0x0007795C File Offset: 0x00075B5C
		private CacheControlHeaderValue(CacheControlHeaderValue source)
		{
			this.noCache = source.noCache;
			this.noStore = source.noStore;
			this.maxAge = source.maxAge;
			this.sharedMaxAge = source.sharedMaxAge;
			this.maxStale = source.maxStale;
			this.maxStaleLimit = source.maxStaleLimit;
			this.minFresh = source.minFresh;
			this.noTransform = source.noTransform;
			this.onlyIfCached = source.onlyIfCached;
			this.publicField = source.publicField;
			this.privateField = source.privateField;
			this.mustRevalidate = source.mustRevalidate;
			this.proxyRevalidate = source.proxyRevalidate;
			if (source.noCacheHeaders != null)
			{
				foreach (string item in source.noCacheHeaders)
				{
					this.NoCacheHeaders.Add(item);
				}
			}
			if (source.privateHeaders != null)
			{
				foreach (string item2 in source.privateHeaders)
				{
					this.PrivateHeaders.Add(item2);
				}
			}
			if (source.extensions != null)
			{
				foreach (NameValueHeaderValue nameValueHeaderValue in source.extensions)
				{
					this.Extensions.Add((NameValueHeaderValue)((ICloneable)nameValueHeaderValue).Clone());
				}
			}
		}

		// Token: 0x06002255 RID: 8789 RVA: 0x00077B20 File Offset: 0x00075D20
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			CacheControlHeaderValue.AppendValueIfRequired(stringBuilder, this.noStore, "no-store");
			CacheControlHeaderValue.AppendValueIfRequired(stringBuilder, this.noTransform, "no-transform");
			CacheControlHeaderValue.AppendValueIfRequired(stringBuilder, this.onlyIfCached, "only-if-cached");
			CacheControlHeaderValue.AppendValueIfRequired(stringBuilder, this.publicField, "public");
			CacheControlHeaderValue.AppendValueIfRequired(stringBuilder, this.mustRevalidate, "must-revalidate");
			CacheControlHeaderValue.AppendValueIfRequired(stringBuilder, this.proxyRevalidate, "proxy-revalidate");
			if (this.noCache)
			{
				CacheControlHeaderValue.AppendValueWithSeparatorIfRequired(stringBuilder, "no-cache");
				if (this.noCacheHeaders != null && this.noCacheHeaders.Count > 0)
				{
					stringBuilder.Append("=\"");
					CacheControlHeaderValue.AppendValues(stringBuilder, this.noCacheHeaders);
					stringBuilder.Append('"');
				}
			}
			if (this.maxAge != null)
			{
				CacheControlHeaderValue.AppendValueWithSeparatorIfRequired(stringBuilder, "max-age");
				stringBuilder.Append('=');
				stringBuilder.Append(((int)this.maxAge.Value.TotalSeconds).ToString(NumberFormatInfo.InvariantInfo));
			}
			if (this.sharedMaxAge != null)
			{
				CacheControlHeaderValue.AppendValueWithSeparatorIfRequired(stringBuilder, "s-maxage");
				stringBuilder.Append('=');
				stringBuilder.Append(((int)this.sharedMaxAge.Value.TotalSeconds).ToString(NumberFormatInfo.InvariantInfo));
			}
			if (this.maxStale)
			{
				CacheControlHeaderValue.AppendValueWithSeparatorIfRequired(stringBuilder, "max-stale");
				if (this.maxStaleLimit != null)
				{
					stringBuilder.Append('=');
					stringBuilder.Append(((int)this.maxStaleLimit.Value.TotalSeconds).ToString(NumberFormatInfo.InvariantInfo));
				}
			}
			if (this.minFresh != null)
			{
				CacheControlHeaderValue.AppendValueWithSeparatorIfRequired(stringBuilder, "min-fresh");
				stringBuilder.Append('=');
				stringBuilder.Append(((int)this.minFresh.Value.TotalSeconds).ToString(NumberFormatInfo.InvariantInfo));
			}
			if (this.privateField)
			{
				CacheControlHeaderValue.AppendValueWithSeparatorIfRequired(stringBuilder, "private");
				if (this.privateHeaders != null && this.privateHeaders.Count > 0)
				{
					stringBuilder.Append("=\"");
					CacheControlHeaderValue.AppendValues(stringBuilder, this.privateHeaders);
					stringBuilder.Append('"');
				}
			}
			NameValueHeaderValue.ToString(this.extensions, ',', false, stringBuilder);
			return stringBuilder.ToString();
		}

		// Token: 0x06002256 RID: 8790 RVA: 0x00077D98 File Offset: 0x00075F98
		public override bool Equals(object obj)
		{
			CacheControlHeaderValue cacheControlHeaderValue = obj as CacheControlHeaderValue;
			return cacheControlHeaderValue != null && (this.noCache == cacheControlHeaderValue.noCache && this.noStore == cacheControlHeaderValue.noStore) && !(this.maxAge != cacheControlHeaderValue.maxAge) && (!(this.sharedMaxAge != cacheControlHeaderValue.sharedMaxAge) && this.maxStale == cacheControlHeaderValue.maxStale) && !(this.maxStaleLimit != cacheControlHeaderValue.maxStaleLimit) && !(this.minFresh != cacheControlHeaderValue.minFresh) && this.noTransform == cacheControlHeaderValue.noTransform && this.onlyIfCached == cacheControlHeaderValue.onlyIfCached && this.publicField == cacheControlHeaderValue.publicField && this.privateField == cacheControlHeaderValue.privateField && this.mustRevalidate == cacheControlHeaderValue.mustRevalidate && this.proxyRevalidate == cacheControlHeaderValue.proxyRevalidate && HeaderUtilities.AreEqualCollections<string>(this.noCacheHeaders, cacheControlHeaderValue.noCacheHeaders, StringComparer.OrdinalIgnoreCase) && HeaderUtilities.AreEqualCollections<string>(this.privateHeaders, cacheControlHeaderValue.privateHeaders, StringComparer.OrdinalIgnoreCase) && HeaderUtilities.AreEqualCollections<NameValueHeaderValue>(this.extensions, cacheControlHeaderValue.extensions);
		}

		// Token: 0x06002257 RID: 8791 RVA: 0x00077FF0 File Offset: 0x000761F0
		public override int GetHashCode()
		{
			int num = this.noCache.GetHashCode() ^ this.noStore.GetHashCode() << 1 ^ this.maxStale.GetHashCode() << 2 ^ this.noTransform.GetHashCode() << 3 ^ this.onlyIfCached.GetHashCode() << 4 ^ this.publicField.GetHashCode() << 5 ^ this.privateField.GetHashCode() << 6 ^ this.mustRevalidate.GetHashCode() << 7 ^ this.proxyRevalidate.GetHashCode() << 8;
			num = (num ^ ((this.maxAge != null) ? (this.maxAge.Value.GetHashCode() ^ 1) : 0) ^ ((this.sharedMaxAge != null) ? (this.sharedMaxAge.Value.GetHashCode() ^ 2) : 0) ^ ((this.maxStaleLimit != null) ? (this.maxStaleLimit.Value.GetHashCode() ^ 4) : 0) ^ ((this.minFresh != null) ? (this.minFresh.Value.GetHashCode() ^ 8) : 0));
			if (this.noCacheHeaders != null && this.noCacheHeaders.Count > 0)
			{
				foreach (string text in this.noCacheHeaders)
				{
					num ^= text.ToLowerInvariant().GetHashCode();
				}
			}
			if (this.privateHeaders != null && this.privateHeaders.Count > 0)
			{
				foreach (string text2 in this.privateHeaders)
				{
					num ^= text2.ToLowerInvariant().GetHashCode();
				}
			}
			if (this.extensions != null && this.extensions.Count > 0)
			{
				foreach (NameValueHeaderValue nameValueHeaderValue in this.extensions)
				{
					num ^= nameValueHeaderValue.GetHashCode();
				}
			}
			return num;
		}

		// Token: 0x06002258 RID: 8792 RVA: 0x00078294 File Offset: 0x00076494
		public static CacheControlHeaderValue Parse(string input)
		{
			int num = 0;
			return (CacheControlHeaderValue)CacheControlHeaderParser.Parser.ParseValue(input, null, ref num);
		}

		// Token: 0x06002259 RID: 8793 RVA: 0x000782BC File Offset: 0x000764BC
		public static bool TryParse(string input, out CacheControlHeaderValue parsedValue)
		{
			int num = 0;
			parsedValue = null;
			object obj;
			if (CacheControlHeaderParser.Parser.TryParseValue(input, null, ref num, out obj))
			{
				parsedValue = (CacheControlHeaderValue)obj;
				return true;
			}
			return false;
		}

		// Token: 0x0600225A RID: 8794 RVA: 0x000782F4 File Offset: 0x000764F4
		internal static int GetCacheControlLength(string input, int startIndex, CacheControlHeaderValue storeValue, out CacheControlHeaderValue parsedValue)
		{
			parsedValue = null;
			if (string.IsNullOrEmpty(input) || startIndex >= input.Length)
			{
				return 0;
			}
			int i = startIndex;
			object obj = null;
			List<NameValueHeaderValue> list = new List<NameValueHeaderValue>();
			while (i < input.Length)
			{
				if (!CacheControlHeaderValue.nameValueListParser.TryParseValue(input, null, ref i, out obj))
				{
					return 0;
				}
				list.Add(obj as NameValueHeaderValue);
			}
			CacheControlHeaderValue cacheControlHeaderValue = storeValue;
			if (cacheControlHeaderValue == null)
			{
				cacheControlHeaderValue = new CacheControlHeaderValue();
			}
			if (!CacheControlHeaderValue.TrySetCacheControlValues(cacheControlHeaderValue, list))
			{
				return 0;
			}
			if (storeValue == null)
			{
				parsedValue = cacheControlHeaderValue;
			}
			return input.Length - startIndex;
		}

		// Token: 0x0600225B RID: 8795 RVA: 0x0007838C File Offset: 0x0007658C
		private static bool TrySetCacheControlValues(CacheControlHeaderValue cc, List<NameValueHeaderValue> nameValueList)
		{
			foreach (NameValueHeaderValue nameValueHeaderValue in nameValueList)
			{
				bool flag = true;
				string text = nameValueHeaderValue.Name.ToLowerInvariant();
				string key;
				if ((key = text) == null)
				{
					goto IL_22B;
				}
				if (<PrivateImplementationDetails>{C0B29235-E7B6-44DD-8DDB-FA00FEF3B379}.$$method0x60000cd-1 == null)
				{
					<PrivateImplementationDetails>{C0B29235-E7B6-44DD-8DDB-FA00FEF3B379}.$$method0x60000cd-1 = new Dictionary<string, int>(12)
					{
						{
							"no-cache",
							0
						},
						{
							"no-store",
							1
						},
						{
							"max-age",
							2
						},
						{
							"max-stale",
							3
						},
						{
							"min-fresh",
							4
						},
						{
							"no-transform",
							5
						},
						{
							"only-if-cached",
							6
						},
						{
							"public",
							7
						},
						{
							"private",
							8
						},
						{
							"must-revalidate",
							9
						},
						{
							"proxy-revalidate",
							10
						},
						{
							"s-maxage",
							11
						}
					};
				}
				int num;
				if (!<PrivateImplementationDetails>{C0B29235-E7B6-44DD-8DDB-FA00FEF3B379}.$$method0x60000cd-1.TryGetValue(key, out num))
				{
					goto IL_22B;
				}
				switch (num)
				{
				case 0:
					flag = CacheControlHeaderValue.TrySetOptionalTokenList(nameValueHeaderValue, ref cc.noCache, ref cc.noCacheHeaders);
					break;
				case 1:
					flag = CacheControlHeaderValue.TrySetTokenOnlyValue(nameValueHeaderValue, ref cc.noStore);
					break;
				case 2:
					flag = CacheControlHeaderValue.TrySetTimeSpan(nameValueHeaderValue, ref cc.maxAge);
					break;
				case 3:
					flag = (nameValueHeaderValue.Value == null || CacheControlHeaderValue.TrySetTimeSpan(nameValueHeaderValue, ref cc.maxStaleLimit));
					if (flag)
					{
						cc.maxStale = true;
					}
					break;
				case 4:
					flag = CacheControlHeaderValue.TrySetTimeSpan(nameValueHeaderValue, ref cc.minFresh);
					break;
				case 5:
					flag = CacheControlHeaderValue.TrySetTokenOnlyValue(nameValueHeaderValue, ref cc.noTransform);
					break;
				case 6:
					flag = CacheControlHeaderValue.TrySetTokenOnlyValue(nameValueHeaderValue, ref cc.onlyIfCached);
					break;
				case 7:
					flag = CacheControlHeaderValue.TrySetTokenOnlyValue(nameValueHeaderValue, ref cc.publicField);
					break;
				case 8:
					flag = CacheControlHeaderValue.TrySetOptionalTokenList(nameValueHeaderValue, ref cc.privateField, ref cc.privateHeaders);
					break;
				case 9:
					flag = CacheControlHeaderValue.TrySetTokenOnlyValue(nameValueHeaderValue, ref cc.mustRevalidate);
					break;
				case 10:
					flag = CacheControlHeaderValue.TrySetTokenOnlyValue(nameValueHeaderValue, ref cc.proxyRevalidate);
					break;
				case 11:
					flag = CacheControlHeaderValue.TrySetTimeSpan(nameValueHeaderValue, ref cc.sharedMaxAge);
					break;
				default:
					goto IL_22B;
				}
				IL_237:
				if (!flag)
				{
					return false;
				}
				continue;
				IL_22B:
				cc.Extensions.Add(nameValueHeaderValue);
				goto IL_237;
			}
			return true;
		}

		// Token: 0x0600225C RID: 8796 RVA: 0x00078620 File Offset: 0x00076820
		private static bool TrySetTokenOnlyValue(NameValueHeaderValue nameValue, ref bool boolField)
		{
			if (nameValue.Value != null)
			{
				return false;
			}
			boolField = true;
			return true;
		}

		// Token: 0x0600225D RID: 8797 RVA: 0x00078634 File Offset: 0x00076834
		private static bool TrySetOptionalTokenList(NameValueHeaderValue nameValue, ref bool boolField, ref ICollection<string> destination)
		{
			if (nameValue.Value == null)
			{
				boolField = true;
				return true;
			}
			string value = nameValue.Value;
			if (value.Length < 3 || value[0] != '"' || value[value.Length - 1] != '"')
			{
				return false;
			}
			int i = 1;
			int num = value.Length - 1;
			bool flag = false;
			int num2 = (destination == null) ? 0 : destination.Count;
			while (i < num)
			{
				i = HeaderUtilities.GetNextNonEmptyOrWhitespaceIndex(value, i, true, out flag);
				if (i == num)
				{
					break;
				}
				int tokenLength = HttpRuleParser.GetTokenLength(value, i);
				if (tokenLength == 0)
				{
					return false;
				}
				if (destination == null)
				{
					destination = new ObjectCollection<string>(CacheControlHeaderValue.checkIsValidToken);
				}
				destination.Add(value.Substring(i, tokenLength));
				i += tokenLength;
			}
			if (destination != null && destination.Count > num2)
			{
				boolField = true;
				return true;
			}
			return false;
		}

		// Token: 0x0600225E RID: 8798 RVA: 0x00078720 File Offset: 0x00076920
		private static bool TrySetTimeSpan(NameValueHeaderValue nameValue, ref TimeSpan? timeSpan)
		{
			if (nameValue.Value == null)
			{
				return false;
			}
			int seconds;
			if (!HeaderUtilities.TryParseInt32(nameValue.Value, out seconds))
			{
				return false;
			}
			timeSpan = new TimeSpan?(new TimeSpan(0, 0, seconds));
			return true;
		}

		// Token: 0x0600225F RID: 8799 RVA: 0x00078768 File Offset: 0x00076968
		private static void AppendValueIfRequired(StringBuilder sb, bool appendValue, string value)
		{
			if (appendValue)
			{
				CacheControlHeaderValue.AppendValueWithSeparatorIfRequired(sb, value);
			}
		}

		// Token: 0x06002260 RID: 8800 RVA: 0x00078778 File Offset: 0x00076978
		private static void AppendValueWithSeparatorIfRequired(StringBuilder sb, string value)
		{
			if (sb.Length > 0)
			{
				sb.Append(", ");
			}
			sb.Append(value);
		}

		// Token: 0x06002261 RID: 8801 RVA: 0x0007879C File Offset: 0x0007699C
		private static void AppendValues(StringBuilder sb, IEnumerable<string> values)
		{
			bool flag = true;
			foreach (string value in values)
			{
				if (flag)
				{
					flag = false;
				}
				else
				{
					sb.Append(", ");
				}
				sb.Append(value);
			}
		}

		// Token: 0x06002262 RID: 8802 RVA: 0x0007880C File Offset: 0x00076A0C
		private static void CheckIsValidToken(string item)
		{
			HeaderUtilities.CheckValidToken(item, "item");
		}

		// Token: 0x06002263 RID: 8803 RVA: 0x0007881C File Offset: 0x00076A1C
		object ICloneable.Clone()
		{
			return new CacheControlHeaderValue(this);
		}

		// Token: 0x04000FEA RID: 4074
		private const string maxAgeString = "max-age";

		// Token: 0x04000FEB RID: 4075
		private const string maxStaleString = "max-stale";

		// Token: 0x04000FEC RID: 4076
		private const string minFreshString = "min-fresh";

		// Token: 0x04000FED RID: 4077
		private const string mustRevalidateString = "must-revalidate";

		// Token: 0x04000FEE RID: 4078
		private const string noCacheString = "no-cache";

		// Token: 0x04000FEF RID: 4079
		private const string noStoreString = "no-store";

		// Token: 0x04000FF0 RID: 4080
		private const string noTransformString = "no-transform";

		// Token: 0x04000FF1 RID: 4081
		private const string onlyIfCachedString = "only-if-cached";

		// Token: 0x04000FF2 RID: 4082
		private const string privateString = "private";

		// Token: 0x04000FF3 RID: 4083
		private const string proxyRevalidateString = "proxy-revalidate";

		// Token: 0x04000FF4 RID: 4084
		private const string publicString = "public";

		// Token: 0x04000FF5 RID: 4085
		private const string sharedMaxAgeString = "s-maxage";

		// Token: 0x04000FF6 RID: 4086
		private static readonly HttpHeaderParser nameValueListParser = GenericHeaderParser.MultipleValueNameValueParser;

		// Token: 0x04000FF7 RID: 4087
		private static readonly Action<string> checkIsValidToken = new Action<string>(CacheControlHeaderValue.CheckIsValidToken);

		// Token: 0x04000FF8 RID: 4088
		private bool noCache;

		// Token: 0x04000FF9 RID: 4089
		private ICollection<string> noCacheHeaders;

		// Token: 0x04000FFA RID: 4090
		private bool noStore;

		// Token: 0x04000FFB RID: 4091
		private TimeSpan? maxAge;

		// Token: 0x04000FFC RID: 4092
		private TimeSpan? sharedMaxAge;

		// Token: 0x04000FFD RID: 4093
		private bool maxStale;

		// Token: 0x04000FFE RID: 4094
		private TimeSpan? maxStaleLimit;

		// Token: 0x04000FFF RID: 4095
		private TimeSpan? minFresh;

		// Token: 0x04001000 RID: 4096
		private bool noTransform;

		// Token: 0x04001001 RID: 4097
		private bool onlyIfCached;

		// Token: 0x04001002 RID: 4098
		private bool publicField;

		// Token: 0x04001003 RID: 4099
		private bool privateField;

		// Token: 0x04001004 RID: 4100
		private ICollection<string> privateHeaders;

		// Token: 0x04001005 RID: 4101
		private bool mustRevalidate;

		// Token: 0x04001006 RID: 4102
		private bool proxyRevalidate;

		// Token: 0x04001007 RID: 4103
		private ICollection<NameValueHeaderValue> extensions;
	}
}
