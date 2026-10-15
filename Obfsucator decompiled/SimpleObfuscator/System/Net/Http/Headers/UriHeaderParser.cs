using System;
using System.Text;

namespace System.Net.Http.Headers
{
	// Token: 0x0200030D RID: 781
	internal class UriHeaderParser : HttpHeaderParser
	{
		// Token: 0x0600246C RID: 9324 RVA: 0x0007FF20 File Offset: 0x0007E120
		private UriHeaderParser(UriKind uriKind) : base(false)
		{
			this.uriKind = uriKind;
		}

		// Token: 0x0600246D RID: 9325 RVA: 0x0007FF30 File Offset: 0x0007E130
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
			Uri uri;
			if (!Uri.TryCreate(text, this.uriKind, out uri))
			{
				text = UriHeaderParser.DecodeUtf8FromString(text);
				if (!Uri.TryCreate(text, this.uriKind, out uri))
				{
					return false;
				}
			}
			index = value.Length;
			parsedValue = uri;
			return true;
		}

		// Token: 0x0600246E RID: 9326 RVA: 0x0007FFB0 File Offset: 0x0007E1B0
		internal static string DecodeUtf8FromString(string input)
		{
			if (string.IsNullOrWhiteSpace(input))
			{
				return input;
			}
			bool flag = false;
			for (int i = 0; i < input.Length; i++)
			{
				if (input[i] > 'ÿ')
				{
					return input;
				}
				if (input[i] > '\u007f')
				{
					flag = true;
					break;
				}
			}
			if (flag)
			{
				byte[] array = new byte[input.Length];
				for (int j = 0; j < input.Length; j++)
				{
					if (input[j] > 'ÿ')
					{
						return input;
					}
					array[j] = (byte)input[j];
				}
				try
				{
					Encoding encoding = Encoding.GetEncoding("utf-8", EncoderFallback.ExceptionFallback, DecoderFallback.ExceptionFallback);
					return encoding.GetString(array);
				}
				catch (ArgumentException)
				{
				}
				return input;
			}
			return input;
		}

		// Token: 0x0600246F RID: 9327 RVA: 0x0008008C File Offset: 0x0007E28C
		public override string ToString(object value)
		{
			Uri uri = (Uri)value;
			if (uri.IsAbsoluteUri)
			{
				return uri.AbsoluteUri;
			}
			return uri.GetComponents(UriComponents.SerializationInfoString, UriFormat.UriEscaped);
		}

		// Token: 0x04001090 RID: 4240
		private UriKind uriKind;

		// Token: 0x04001091 RID: 4241
		internal static readonly UriHeaderParser RelativeOrAbsoluteUriParser = new UriHeaderParser(UriKind.RelativeOrAbsolute);
	}
}
