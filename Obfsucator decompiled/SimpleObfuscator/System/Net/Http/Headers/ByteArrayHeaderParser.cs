using System;
using System.Globalization;

namespace System.Net.Http.Headers
{
	// Token: 0x020002EA RID: 746
	internal class ByteArrayHeaderParser : HttpHeaderParser
	{
		// Token: 0x0600222F RID: 8751 RVA: 0x000776D8 File Offset: 0x000758D8
		private ByteArrayHeaderParser() : base(false)
		{
		}

		// Token: 0x06002230 RID: 8752 RVA: 0x000776E4 File Offset: 0x000758E4
		public override string ToString(object value)
		{
			return Convert.ToBase64String((byte[])value);
		}

		// Token: 0x06002231 RID: 8753 RVA: 0x000776F4 File Offset: 0x000758F4
		public override bool TryParseValue(string value, object storeValue, ref int index, out object parsedValue)
		{
			parsedValue = null;
			if (string.IsNullOrEmpty(value) || index == value.Length)
			{
				return false;
			}
			string text = value;
			if (index > 0)
			{
				text = value.Substring(index);
			}
			try
			{
				parsedValue = Convert.FromBase64String(text);
				index = value.Length;
				return true;
			}
			catch (FormatException ex)
			{
				if (Logging.On)
				{
					Logging.PrintError(Logging.Http, string.Format(CultureInfo.InvariantCulture, SR.net_http_parser_invalid_base64_string, new object[]
					{
						text,
						ex.Message
					}));
				}
			}
			return false;
		}

		// Token: 0x04000FE8 RID: 4072
		internal static readonly ByteArrayHeaderParser Parser = new ByteArrayHeaderParser();
	}
}
