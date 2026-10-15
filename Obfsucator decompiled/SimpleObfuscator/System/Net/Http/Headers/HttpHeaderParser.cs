using System;
using System.Collections;
using System.Globalization;

namespace System.Net.Http.Headers
{
	// Token: 0x020002E8 RID: 744
	internal abstract class HttpHeaderParser
	{
		// Token: 0x17000A00 RID: 2560
		// (get) Token: 0x06002224 RID: 8740 RVA: 0x00077548 File Offset: 0x00075748
		public bool SupportsMultipleValues
		{
			get
			{
				return this.supportsMultipleValues;
			}
		}

		// Token: 0x17000A01 RID: 2561
		// (get) Token: 0x06002225 RID: 8741 RVA: 0x00077550 File Offset: 0x00075750
		public string Separator
		{
			get
			{
				return this.separator;
			}
		}

		// Token: 0x17000A02 RID: 2562
		// (get) Token: 0x06002226 RID: 8742 RVA: 0x00077558 File Offset: 0x00075758
		public virtual IEqualityComparer Comparer
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06002227 RID: 8743 RVA: 0x0007755C File Offset: 0x0007575C
		protected HttpHeaderParser(bool supportsMultipleValues)
		{
			this.supportsMultipleValues = supportsMultipleValues;
			if (supportsMultipleValues)
			{
				this.separator = ", ";
			}
		}

		// Token: 0x06002228 RID: 8744 RVA: 0x0007757C File Offset: 0x0007577C
		protected HttpHeaderParser(bool supportsMultipleValues, string separator)
		{
			this.supportsMultipleValues = supportsMultipleValues;
			this.separator = separator;
		}

		// Token: 0x06002229 RID: 8745
		public abstract bool TryParseValue(string value, object storeValue, ref int index, out object parsedValue);

		// Token: 0x0600222A RID: 8746 RVA: 0x00077594 File Offset: 0x00075794
		public object ParseValue(string value, object storeValue, ref int index)
		{
			object result = null;
			if (!this.TryParseValue(value, storeValue, ref index, out result))
			{
				throw new FormatException(string.Format(CultureInfo.InvariantCulture, SR.net_http_headers_invalid_value, new object[]
				{
					(value == null) ? "<null>" : value.Substring(index)
				}));
			}
			return result;
		}

		// Token: 0x0600222B RID: 8747 RVA: 0x000775F0 File Offset: 0x000757F0
		public virtual string ToString(object value)
		{
			return value.ToString();
		}

		// Token: 0x04000FE5 RID: 4069
		internal const string DefaultSeparator = ", ";

		// Token: 0x04000FE6 RID: 4070
		private bool supportsMultipleValues;

		// Token: 0x04000FE7 RID: 4071
		private string separator;
	}
}
