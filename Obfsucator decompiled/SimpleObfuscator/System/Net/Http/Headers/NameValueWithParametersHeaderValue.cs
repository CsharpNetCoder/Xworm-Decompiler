using System;
using System.Collections.Generic;

namespace System.Net.Http.Headers
{
	// Token: 0x020002FF RID: 767
	public class NameValueWithParametersHeaderValue : NameValueHeaderValue, ICloneable
	{
		// Token: 0x17000A7B RID: 2683
		// (get) Token: 0x060023DC RID: 9180 RVA: 0x0007E048 File Offset: 0x0007C248
		public ICollection<NameValueHeaderValue> Parameters
		{
			get
			{
				if (this.parameters == null)
				{
					this.parameters = new ObjectCollection<NameValueHeaderValue>();
				}
				return this.parameters;
			}
		}

		// Token: 0x060023DD RID: 9181 RVA: 0x0007E068 File Offset: 0x0007C268
		public NameValueWithParametersHeaderValue(string name) : base(name)
		{
		}

		// Token: 0x060023DE RID: 9182 RVA: 0x0007E074 File Offset: 0x0007C274
		public NameValueWithParametersHeaderValue(string name, string value) : base(name, value)
		{
		}

		// Token: 0x060023DF RID: 9183 RVA: 0x0007E080 File Offset: 0x0007C280
		internal NameValueWithParametersHeaderValue()
		{
		}

		// Token: 0x060023E0 RID: 9184 RVA: 0x0007E088 File Offset: 0x0007C288
		protected NameValueWithParametersHeaderValue(NameValueWithParametersHeaderValue source) : base(source)
		{
			if (source.parameters != null)
			{
				foreach (NameValueHeaderValue nameValueHeaderValue in source.parameters)
				{
					this.Parameters.Add((NameValueHeaderValue)((ICloneable)nameValueHeaderValue).Clone());
				}
			}
		}

		// Token: 0x060023E1 RID: 9185 RVA: 0x0007E100 File Offset: 0x0007C300
		public override bool Equals(object obj)
		{
			bool flag = base.Equals(obj);
			if (flag)
			{
				NameValueWithParametersHeaderValue nameValueWithParametersHeaderValue = obj as NameValueWithParametersHeaderValue;
				return nameValueWithParametersHeaderValue != null && HeaderUtilities.AreEqualCollections<NameValueHeaderValue>(this.parameters, nameValueWithParametersHeaderValue.parameters);
			}
			return false;
		}

		// Token: 0x060023E2 RID: 9186 RVA: 0x0007E144 File Offset: 0x0007C344
		public override int GetHashCode()
		{
			return base.GetHashCode() ^ NameValueHeaderValue.GetHashCode(this.parameters);
		}

		// Token: 0x060023E3 RID: 9187 RVA: 0x0007E158 File Offset: 0x0007C358
		public override string ToString()
		{
			return base.ToString() + NameValueHeaderValue.ToString(this.parameters, ';', true);
		}

		// Token: 0x060023E4 RID: 9188 RVA: 0x0007E174 File Offset: 0x0007C374
		public new static NameValueWithParametersHeaderValue Parse(string input)
		{
			int num = 0;
			return (NameValueWithParametersHeaderValue)GenericHeaderParser.SingleValueNameValueWithParametersParser.ParseValue(input, null, ref num);
		}

		// Token: 0x060023E5 RID: 9189 RVA: 0x0007E19C File Offset: 0x0007C39C
		public static bool TryParse(string input, out NameValueWithParametersHeaderValue parsedValue)
		{
			int num = 0;
			parsedValue = null;
			object obj;
			if (GenericHeaderParser.SingleValueNameValueWithParametersParser.TryParseValue(input, null, ref num, out obj))
			{
				parsedValue = (NameValueWithParametersHeaderValue)obj;
				return true;
			}
			return false;
		}

		// Token: 0x060023E6 RID: 9190 RVA: 0x0007E1D4 File Offset: 0x0007C3D4
		internal static int GetNameValueWithParametersLength(string input, int startIndex, out object parsedValue)
		{
			parsedValue = null;
			if (string.IsNullOrEmpty(input) || startIndex >= input.Length)
			{
				return 0;
			}
			NameValueHeaderValue nameValueHeaderValue = null;
			int nameValueLength = NameValueHeaderValue.GetNameValueLength(input, startIndex, NameValueWithParametersHeaderValue.nameValueCreator, out nameValueHeaderValue);
			if (nameValueLength == 0)
			{
				return 0;
			}
			int num = startIndex + nameValueLength;
			num += HttpRuleParser.GetWhitespaceLength(input, num);
			NameValueWithParametersHeaderValue nameValueWithParametersHeaderValue = nameValueHeaderValue as NameValueWithParametersHeaderValue;
			if (num >= input.Length || input[num] != ';')
			{
				parsedValue = nameValueWithParametersHeaderValue;
				return num - startIndex;
			}
			num++;
			int nameValueListLength = NameValueHeaderValue.GetNameValueListLength(input, num, ';', nameValueWithParametersHeaderValue.Parameters);
			if (nameValueListLength == 0)
			{
				return 0;
			}
			parsedValue = nameValueWithParametersHeaderValue;
			return num + nameValueListLength - startIndex;
		}

		// Token: 0x060023E7 RID: 9191 RVA: 0x0007E278 File Offset: 0x0007C478
		private static NameValueHeaderValue CreateNameValue()
		{
			return new NameValueWithParametersHeaderValue();
		}

		// Token: 0x060023E8 RID: 9192 RVA: 0x0007E280 File Offset: 0x0007C480
		object ICloneable.Clone()
		{
			return new NameValueWithParametersHeaderValue(this);
		}

		// Token: 0x04001073 RID: 4211
		private static readonly Func<NameValueHeaderValue> nameValueCreator = new Func<NameValueHeaderValue>(NameValueWithParametersHeaderValue.CreateNameValue);

		// Token: 0x04001074 RID: 4212
		private ICollection<NameValueHeaderValue> parameters;
	}
}
