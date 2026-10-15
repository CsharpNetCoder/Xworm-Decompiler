using System;
using System.Collections.Generic;
using System.Globalization;

namespace System.Net.Http.Headers
{
	// Token: 0x020002FC RID: 764
	public class MediaTypeHeaderValue : ICloneable
	{
		// Token: 0x17000A75 RID: 2677
		// (get) Token: 0x060023A9 RID: 9129 RVA: 0x0007D558 File Offset: 0x0007B758
		// (set) Token: 0x060023AA RID: 9130 RVA: 0x0007D588 File Offset: 0x0007B788
		public string CharSet
		{
			get
			{
				NameValueHeaderValue nameValueHeaderValue = NameValueHeaderValue.Find(this.parameters, "charset");
				if (nameValueHeaderValue != null)
				{
					return nameValueHeaderValue.Value;
				}
				return null;
			}
			set
			{
				NameValueHeaderValue nameValueHeaderValue = NameValueHeaderValue.Find(this.parameters, "charset");
				if (string.IsNullOrEmpty(value))
				{
					if (nameValueHeaderValue != null)
					{
						this.parameters.Remove(nameValueHeaderValue);
						return;
					}
				}
				else
				{
					if (nameValueHeaderValue != null)
					{
						nameValueHeaderValue.Value = value;
						return;
					}
					this.Parameters.Add(new NameValueHeaderValue("charset", value));
				}
			}
		}

		// Token: 0x17000A76 RID: 2678
		// (get) Token: 0x060023AB RID: 9131 RVA: 0x0007D5F0 File Offset: 0x0007B7F0
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

		// Token: 0x17000A77 RID: 2679
		// (get) Token: 0x060023AC RID: 9132 RVA: 0x0007D610 File Offset: 0x0007B810
		// (set) Token: 0x060023AD RID: 9133 RVA: 0x0007D618 File Offset: 0x0007B818
		public string MediaType
		{
			get
			{
				return this.mediaType;
			}
			set
			{
				MediaTypeHeaderValue.CheckMediaTypeFormat(value, "value");
				this.mediaType = value;
			}
		}

		// Token: 0x060023AE RID: 9134 RVA: 0x0007D62C File Offset: 0x0007B82C
		internal MediaTypeHeaderValue()
		{
		}

		// Token: 0x060023AF RID: 9135 RVA: 0x0007D634 File Offset: 0x0007B834
		protected MediaTypeHeaderValue(MediaTypeHeaderValue source)
		{
			this.mediaType = source.mediaType;
			if (source.parameters != null)
			{
				foreach (NameValueHeaderValue nameValueHeaderValue in source.parameters)
				{
					this.Parameters.Add((NameValueHeaderValue)((ICloneable)nameValueHeaderValue).Clone());
				}
			}
		}

		// Token: 0x060023B0 RID: 9136 RVA: 0x0007D6B8 File Offset: 0x0007B8B8
		public MediaTypeHeaderValue(string mediaType)
		{
			MediaTypeHeaderValue.CheckMediaTypeFormat(mediaType, "mediaType");
			this.mediaType = mediaType;
		}

		// Token: 0x060023B1 RID: 9137 RVA: 0x0007D6D4 File Offset: 0x0007B8D4
		public override string ToString()
		{
			return this.mediaType + NameValueHeaderValue.ToString(this.parameters, ';', true);
		}

		// Token: 0x060023B2 RID: 9138 RVA: 0x0007D6F0 File Offset: 0x0007B8F0
		public override bool Equals(object obj)
		{
			MediaTypeHeaderValue mediaTypeHeaderValue = obj as MediaTypeHeaderValue;
			return mediaTypeHeaderValue != null && string.Compare(this.mediaType, mediaTypeHeaderValue.mediaType, StringComparison.OrdinalIgnoreCase) == 0 && HeaderUtilities.AreEqualCollections<NameValueHeaderValue>(this.parameters, mediaTypeHeaderValue.parameters);
		}

		// Token: 0x060023B3 RID: 9139 RVA: 0x0007D73C File Offset: 0x0007B93C
		public override int GetHashCode()
		{
			return this.mediaType.ToLowerInvariant().GetHashCode() ^ NameValueHeaderValue.GetHashCode(this.parameters);
		}

		// Token: 0x060023B4 RID: 9140 RVA: 0x0007D75C File Offset: 0x0007B95C
		public static MediaTypeHeaderValue Parse(string input)
		{
			int num = 0;
			return (MediaTypeHeaderValue)MediaTypeHeaderParser.SingleValueParser.ParseValue(input, null, ref num);
		}

		// Token: 0x060023B5 RID: 9141 RVA: 0x0007D784 File Offset: 0x0007B984
		public static bool TryParse(string input, out MediaTypeHeaderValue parsedValue)
		{
			int num = 0;
			parsedValue = null;
			object obj;
			if (MediaTypeHeaderParser.SingleValueParser.TryParseValue(input, null, ref num, out obj))
			{
				parsedValue = (MediaTypeHeaderValue)obj;
				return true;
			}
			return false;
		}

		// Token: 0x060023B6 RID: 9142 RVA: 0x0007D7BC File Offset: 0x0007B9BC
		internal static int GetMediaTypeLength(string input, int startIndex, Func<MediaTypeHeaderValue> mediaTypeCreator, out MediaTypeHeaderValue parsedValue)
		{
			parsedValue = null;
			if (string.IsNullOrEmpty(input) || startIndex >= input.Length)
			{
				return 0;
			}
			string text = null;
			int mediaTypeExpressionLength = MediaTypeHeaderValue.GetMediaTypeExpressionLength(input, startIndex, out text);
			if (mediaTypeExpressionLength == 0)
			{
				return 0;
			}
			int num = startIndex + mediaTypeExpressionLength;
			num += HttpRuleParser.GetWhitespaceLength(input, num);
			MediaTypeHeaderValue mediaTypeHeaderValue;
			if (num >= input.Length || input[num] != ';')
			{
				mediaTypeHeaderValue = mediaTypeCreator();
				mediaTypeHeaderValue.mediaType = text;
				parsedValue = mediaTypeHeaderValue;
				return num - startIndex;
			}
			mediaTypeHeaderValue = mediaTypeCreator();
			mediaTypeHeaderValue.mediaType = text;
			num++;
			int nameValueListLength = NameValueHeaderValue.GetNameValueListLength(input, num, ';', mediaTypeHeaderValue.Parameters);
			if (nameValueListLength == 0)
			{
				return 0;
			}
			parsedValue = mediaTypeHeaderValue;
			return num + nameValueListLength - startIndex;
		}

		// Token: 0x060023B7 RID: 9143 RVA: 0x0007D874 File Offset: 0x0007BA74
		private static int GetMediaTypeExpressionLength(string input, int startIndex, out string mediaType)
		{
			mediaType = null;
			int tokenLength = HttpRuleParser.GetTokenLength(input, startIndex);
			if (tokenLength == 0)
			{
				return 0;
			}
			int num = startIndex + tokenLength;
			num += HttpRuleParser.GetWhitespaceLength(input, num);
			if (num >= input.Length || input[num] != '/')
			{
				return 0;
			}
			num++;
			num += HttpRuleParser.GetWhitespaceLength(input, num);
			int tokenLength2 = HttpRuleParser.GetTokenLength(input, num);
			if (tokenLength2 == 0)
			{
				return 0;
			}
			int num2 = num + tokenLength2 - startIndex;
			if (tokenLength + tokenLength2 + 1 == num2)
			{
				mediaType = input.Substring(startIndex, num2);
			}
			else
			{
				mediaType = input.Substring(startIndex, tokenLength) + "/" + input.Substring(num, tokenLength2);
			}
			return num2;
		}

		// Token: 0x060023B8 RID: 9144 RVA: 0x0007D920 File Offset: 0x0007BB20
		private static void CheckMediaTypeFormat(string mediaType, string parameterName)
		{
			if (string.IsNullOrEmpty(mediaType))
			{
				throw new ArgumentException(SR.net_http_argument_empty_string, parameterName);
			}
			string text;
			int mediaTypeExpressionLength = MediaTypeHeaderValue.GetMediaTypeExpressionLength(mediaType, 0, out text);
			if (mediaTypeExpressionLength == 0 || text.Length != mediaType.Length)
			{
				throw new FormatException(string.Format(CultureInfo.InvariantCulture, SR.net_http_headers_invalid_value, new object[]
				{
					mediaType
				}));
			}
		}

		// Token: 0x060023B9 RID: 9145 RVA: 0x0007D98C File Offset: 0x0007BB8C
		object ICloneable.Clone()
		{
			return new MediaTypeHeaderValue(this);
		}

		// Token: 0x0400106D RID: 4205
		private const string charSet = "charset";

		// Token: 0x0400106E RID: 4206
		private ICollection<NameValueHeaderValue> parameters;

		// Token: 0x0400106F RID: 4207
		private string mediaType;
	}
}
