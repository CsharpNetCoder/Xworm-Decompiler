using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace System.Net.Http.Headers
{
	// Token: 0x020002ED RID: 749
	public class ContentDispositionHeaderValue : ICloneable
	{
		// Token: 0x17000A13 RID: 2579
		// (get) Token: 0x06002265 RID: 8805 RVA: 0x00078844 File Offset: 0x00076A44
		// (set) Token: 0x06002266 RID: 8806 RVA: 0x0007884C File Offset: 0x00076A4C
		public string DispositionType
		{
			get
			{
				return this.dispositionType;
			}
			set
			{
				ContentDispositionHeaderValue.CheckDispositionTypeFormat(value, "value");
				this.dispositionType = value;
			}
		}

		// Token: 0x17000A14 RID: 2580
		// (get) Token: 0x06002267 RID: 8807 RVA: 0x00078860 File Offset: 0x00076A60
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

		// Token: 0x17000A15 RID: 2581
		// (get) Token: 0x06002268 RID: 8808 RVA: 0x00078880 File Offset: 0x00076A80
		// (set) Token: 0x06002269 RID: 8809 RVA: 0x00078890 File Offset: 0x00076A90
		public string Name
		{
			get
			{
				return this.GetName("name");
			}
			set
			{
				this.SetName("name", value);
			}
		}

		// Token: 0x17000A16 RID: 2582
		// (get) Token: 0x0600226A RID: 8810 RVA: 0x000788A0 File Offset: 0x00076AA0
		// (set) Token: 0x0600226B RID: 8811 RVA: 0x000788B0 File Offset: 0x00076AB0
		public string FileName
		{
			get
			{
				return this.GetName("filename");
			}
			set
			{
				this.SetName("filename", value);
			}
		}

		// Token: 0x17000A17 RID: 2583
		// (get) Token: 0x0600226C RID: 8812 RVA: 0x000788C0 File Offset: 0x00076AC0
		// (set) Token: 0x0600226D RID: 8813 RVA: 0x000788D0 File Offset: 0x00076AD0
		public string FileNameStar
		{
			get
			{
				return this.GetName("filename*");
			}
			set
			{
				this.SetName("filename*", value);
			}
		}

		// Token: 0x17000A18 RID: 2584
		// (get) Token: 0x0600226E RID: 8814 RVA: 0x000788E0 File Offset: 0x00076AE0
		// (set) Token: 0x0600226F RID: 8815 RVA: 0x000788F0 File Offset: 0x00076AF0
		public DateTimeOffset? CreationDate
		{
			get
			{
				return this.GetDate("creation-date");
			}
			set
			{
				this.SetDate("creation-date", value);
			}
		}

		// Token: 0x17000A19 RID: 2585
		// (get) Token: 0x06002270 RID: 8816 RVA: 0x00078900 File Offset: 0x00076B00
		// (set) Token: 0x06002271 RID: 8817 RVA: 0x00078910 File Offset: 0x00076B10
		public DateTimeOffset? ModificationDate
		{
			get
			{
				return this.GetDate("modification-date");
			}
			set
			{
				this.SetDate("modification-date", value);
			}
		}

		// Token: 0x17000A1A RID: 2586
		// (get) Token: 0x06002272 RID: 8818 RVA: 0x00078920 File Offset: 0x00076B20
		// (set) Token: 0x06002273 RID: 8819 RVA: 0x00078930 File Offset: 0x00076B30
		public DateTimeOffset? ReadDate
		{
			get
			{
				return this.GetDate("read-date");
			}
			set
			{
				this.SetDate("read-date", value);
			}
		}

		// Token: 0x17000A1B RID: 2587
		// (get) Token: 0x06002274 RID: 8820 RVA: 0x00078940 File Offset: 0x00076B40
		// (set) Token: 0x06002275 RID: 8821 RVA: 0x00078994 File Offset: 0x00076B94
		public long? Size
		{
			get
			{
				NameValueHeaderValue nameValueHeaderValue = NameValueHeaderValue.Find(this.parameters, "size");
				if (nameValueHeaderValue != null)
				{
					string value = nameValueHeaderValue.Value;
					ulong value2;
					if (ulong.TryParse(value, NumberStyles.Integer, CultureInfo.InvariantCulture, out value2))
					{
						return new long?((long)value2);
					}
				}
				return null;
			}
			set
			{
				NameValueHeaderValue nameValueHeaderValue = NameValueHeaderValue.Find(this.parameters, "size");
				if (value == null)
				{
					if (nameValueHeaderValue != null)
					{
						this.parameters.Remove(nameValueHeaderValue);
						return;
					}
				}
				else
				{
					if (value < 0L)
					{
						throw new ArgumentOutOfRangeException("value");
					}
					if (nameValueHeaderValue != null)
					{
						nameValueHeaderValue.Value = value.Value.ToString(CultureInfo.InvariantCulture);
						return;
					}
					string value2 = value.Value.ToString(CultureInfo.InvariantCulture);
					this.parameters.Add(new NameValueHeaderValue("size", value2));
				}
			}
		}

		// Token: 0x06002276 RID: 8822 RVA: 0x00078A54 File Offset: 0x00076C54
		internal ContentDispositionHeaderValue()
		{
		}

		// Token: 0x06002277 RID: 8823 RVA: 0x00078A5C File Offset: 0x00076C5C
		protected ContentDispositionHeaderValue(ContentDispositionHeaderValue source)
		{
			this.dispositionType = source.dispositionType;
			if (source.parameters != null)
			{
				foreach (NameValueHeaderValue nameValueHeaderValue in source.parameters)
				{
					this.Parameters.Add((NameValueHeaderValue)((ICloneable)nameValueHeaderValue).Clone());
				}
			}
		}

		// Token: 0x06002278 RID: 8824 RVA: 0x00078AE0 File Offset: 0x00076CE0
		public ContentDispositionHeaderValue(string dispositionType)
		{
			ContentDispositionHeaderValue.CheckDispositionTypeFormat(dispositionType, "dispositionType");
			this.dispositionType = dispositionType;
		}

		// Token: 0x06002279 RID: 8825 RVA: 0x00078AFC File Offset: 0x00076CFC
		public override string ToString()
		{
			return this.dispositionType + NameValueHeaderValue.ToString(this.parameters, ';', true);
		}

		// Token: 0x0600227A RID: 8826 RVA: 0x00078B18 File Offset: 0x00076D18
		public override bool Equals(object obj)
		{
			ContentDispositionHeaderValue contentDispositionHeaderValue = obj as ContentDispositionHeaderValue;
			return contentDispositionHeaderValue != null && string.Compare(this.dispositionType, contentDispositionHeaderValue.dispositionType, StringComparison.OrdinalIgnoreCase) == 0 && HeaderUtilities.AreEqualCollections<NameValueHeaderValue>(this.parameters, contentDispositionHeaderValue.parameters);
		}

		// Token: 0x0600227B RID: 8827 RVA: 0x00078B64 File Offset: 0x00076D64
		public override int GetHashCode()
		{
			return this.dispositionType.ToLowerInvariant().GetHashCode() ^ NameValueHeaderValue.GetHashCode(this.parameters);
		}

		// Token: 0x0600227C RID: 8828 RVA: 0x00078B84 File Offset: 0x00076D84
		object ICloneable.Clone()
		{
			return new ContentDispositionHeaderValue(this);
		}

		// Token: 0x0600227D RID: 8829 RVA: 0x00078B8C File Offset: 0x00076D8C
		public static ContentDispositionHeaderValue Parse(string input)
		{
			int num = 0;
			return (ContentDispositionHeaderValue)GenericHeaderParser.ContentDispositionParser.ParseValue(input, null, ref num);
		}

		// Token: 0x0600227E RID: 8830 RVA: 0x00078BB4 File Offset: 0x00076DB4
		public static bool TryParse(string input, out ContentDispositionHeaderValue parsedValue)
		{
			int num = 0;
			parsedValue = null;
			object obj;
			if (GenericHeaderParser.ContentDispositionParser.TryParseValue(input, null, ref num, out obj))
			{
				parsedValue = (ContentDispositionHeaderValue)obj;
				return true;
			}
			return false;
		}

		// Token: 0x0600227F RID: 8831 RVA: 0x00078BEC File Offset: 0x00076DEC
		internal static int GetDispositionTypeLength(string input, int startIndex, out object parsedValue)
		{
			parsedValue = null;
			if (string.IsNullOrEmpty(input) || startIndex >= input.Length)
			{
				return 0;
			}
			string text = null;
			int dispositionTypeExpressionLength = ContentDispositionHeaderValue.GetDispositionTypeExpressionLength(input, startIndex, out text);
			if (dispositionTypeExpressionLength == 0)
			{
				return 0;
			}
			int num = startIndex + dispositionTypeExpressionLength;
			num += HttpRuleParser.GetWhitespaceLength(input, num);
			ContentDispositionHeaderValue contentDispositionHeaderValue = new ContentDispositionHeaderValue();
			contentDispositionHeaderValue.dispositionType = text;
			if (num >= input.Length || input[num] != ';')
			{
				parsedValue = contentDispositionHeaderValue;
				return num - startIndex;
			}
			num++;
			int nameValueListLength = NameValueHeaderValue.GetNameValueListLength(input, num, ';', contentDispositionHeaderValue.Parameters);
			if (nameValueListLength == 0)
			{
				return 0;
			}
			parsedValue = contentDispositionHeaderValue;
			return num + nameValueListLength - startIndex;
		}

		// Token: 0x06002280 RID: 8832 RVA: 0x00078C90 File Offset: 0x00076E90
		private static int GetDispositionTypeExpressionLength(string input, int startIndex, out string dispositionType)
		{
			dispositionType = null;
			int tokenLength = HttpRuleParser.GetTokenLength(input, startIndex);
			if (tokenLength == 0)
			{
				return 0;
			}
			dispositionType = input.Substring(startIndex, tokenLength);
			return tokenLength;
		}

		// Token: 0x06002281 RID: 8833 RVA: 0x00078CC0 File Offset: 0x00076EC0
		private static void CheckDispositionTypeFormat(string dispositionType, string parameterName)
		{
			if (string.IsNullOrEmpty(dispositionType))
			{
				throw new ArgumentException(SR.net_http_argument_empty_string, parameterName);
			}
			string text;
			int dispositionTypeExpressionLength = ContentDispositionHeaderValue.GetDispositionTypeExpressionLength(dispositionType, 0, out text);
			if (dispositionTypeExpressionLength == 0 || text.Length != dispositionType.Length)
			{
				throw new FormatException(string.Format(CultureInfo.InvariantCulture, SR.net_http_headers_invalid_value, new object[]
				{
					dispositionType
				}));
			}
		}

		// Token: 0x06002282 RID: 8834 RVA: 0x00078D2C File Offset: 0x00076F2C
		private DateTimeOffset? GetDate(string parameter)
		{
			NameValueHeaderValue nameValueHeaderValue = NameValueHeaderValue.Find(this.parameters, parameter);
			if (nameValueHeaderValue != null)
			{
				string text = nameValueHeaderValue.Value;
				if (this.IsQuoted(text))
				{
					text = text.Substring(1, text.Length - 2);
				}
				DateTimeOffset value;
				if (HttpRuleParser.TryStringToDate(text, out value))
				{
					return new DateTimeOffset?(value);
				}
			}
			return null;
		}

		// Token: 0x06002283 RID: 8835 RVA: 0x00078D90 File Offset: 0x00076F90
		private void SetDate(string parameter, DateTimeOffset? date)
		{
			NameValueHeaderValue nameValueHeaderValue = NameValueHeaderValue.Find(this.parameters, parameter);
			if (date == null)
			{
				if (nameValueHeaderValue != null)
				{
					this.parameters.Remove(nameValueHeaderValue);
					return;
				}
			}
			else
			{
				string value = string.Format(CultureInfo.InvariantCulture, "\"{0}\"", new object[]
				{
					HttpRuleParser.DateToString(date.Value)
				});
				if (nameValueHeaderValue != null)
				{
					nameValueHeaderValue.Value = value;
					return;
				}
				this.Parameters.Add(new NameValueHeaderValue(parameter, value));
			}
		}

		// Token: 0x06002284 RID: 8836 RVA: 0x00078E18 File Offset: 0x00077018
		private string GetName(string parameter)
		{
			NameValueHeaderValue nameValueHeaderValue = NameValueHeaderValue.Find(this.parameters, parameter);
			if (nameValueHeaderValue == null)
			{
				return null;
			}
			if (parameter.EndsWith("*", StringComparison.Ordinal))
			{
				string result;
				if (this.TryDecode5987(nameValueHeaderValue.Value, out result))
				{
					return result;
				}
				return null;
			}
			else
			{
				string result;
				if (this.TryDecodeMime(nameValueHeaderValue.Value, out result))
				{
					return result;
				}
				return nameValueHeaderValue.Value;
			}
		}

		// Token: 0x06002285 RID: 8837 RVA: 0x00078E84 File Offset: 0x00077084
		private void SetName(string parameter, string value)
		{
			NameValueHeaderValue nameValueHeaderValue = NameValueHeaderValue.Find(this.parameters, parameter);
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
				string value2 = string.Empty;
				if (parameter.EndsWith("*", StringComparison.Ordinal))
				{
					value2 = this.Encode5987(value);
				}
				else
				{
					value2 = this.EncodeAndQuoteMime(value);
				}
				if (nameValueHeaderValue != null)
				{
					nameValueHeaderValue.Value = value2;
					return;
				}
				this.Parameters.Add(new NameValueHeaderValue(parameter, value2));
			}
		}

		// Token: 0x06002286 RID: 8838 RVA: 0x00078F10 File Offset: 0x00077110
		private string EncodeAndQuoteMime(string input)
		{
			string text = input;
			bool flag = false;
			if (this.IsQuoted(text))
			{
				text = text.Substring(1, text.Length - 2);
				flag = true;
			}
			if (text.IndexOf("\"", 0, StringComparison.Ordinal) >= 0)
			{
				throw new ArgumentException(string.Format(CultureInfo.InvariantCulture, SR.net_http_headers_invalid_value, new object[]
				{
					input
				}));
			}
			if (this.RequiresEncoding(text))
			{
				flag = true;
				text = this.EncodeMime(text);
			}
			else if (!flag && HttpRuleParser.GetTokenLength(text, 0) != text.Length)
			{
				flag = true;
			}
			if (flag)
			{
				text = string.Format(CultureInfo.InvariantCulture, "\"{0}\"", new object[]
				{
					text
				});
			}
			return text;
		}

		// Token: 0x06002287 RID: 8839 RVA: 0x00078FD0 File Offset: 0x000771D0
		private bool IsQuoted(string value)
		{
			return value.Length > 1 && value.StartsWith("\"", StringComparison.Ordinal) && value.EndsWith("\"", StringComparison.Ordinal);
		}

		// Token: 0x06002288 RID: 8840 RVA: 0x00079000 File Offset: 0x00077200
		private bool RequiresEncoding(string input)
		{
			foreach (char c in input)
			{
				if (c > '\u007f')
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06002289 RID: 8841 RVA: 0x00079044 File Offset: 0x00077244
		private string EncodeMime(string input)
		{
			byte[] bytes = Encoding.UTF8.GetBytes(input);
			string text = Convert.ToBase64String(bytes);
			return string.Format(CultureInfo.InvariantCulture, "=?utf-8?B?{0}?=", new object[]
			{
				text
			});
		}

		// Token: 0x0600228A RID: 8842 RVA: 0x00079084 File Offset: 0x00077284
		private bool TryDecodeMime(string input, out string output)
		{
			output = null;
			if (!this.IsQuoted(input) || input.Length < 10)
			{
				return false;
			}
			string[] array = input.Split(new char[]
			{
				'?'
			});
			if (array.Length != 5 || array[0] != "\"=" || array[4] != "=\"" || array[2].ToLowerInvariant() != "b")
			{
				return false;
			}
			try
			{
				Encoding encoding = Encoding.GetEncoding(array[1]);
				byte[] bytes = Convert.FromBase64String(array[3]);
				output = encoding.GetString(bytes);
				return true;
			}
			catch (ArgumentException)
			{
			}
			catch (FormatException)
			{
			}
			return false;
		}

		// Token: 0x0600228B RID: 8843 RVA: 0x00079170 File Offset: 0x00077370
		private string Encode5987(string input)
		{
			StringBuilder stringBuilder = new StringBuilder("utf-8''");
			foreach (char c in input)
			{
				if (c > '\u007f')
				{
					byte[] bytes = Encoding.UTF8.GetBytes(c.ToString());
					foreach (byte character in bytes)
					{
						stringBuilder.Append(Uri.HexEscape((char)character));
					}
				}
				else if (!HttpRuleParser.IsTokenChar(c) || c == '*' || c == '\'' || c == '%')
				{
					stringBuilder.Append(Uri.HexEscape(c));
				}
				else
				{
					stringBuilder.Append(c);
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600228C RID: 8844 RVA: 0x00079240 File Offset: 0x00077440
		private bool TryDecode5987(string input, out string output)
		{
			output = null;
			string[] array = input.Split(new char[]
			{
				'\''
			});
			if (array.Length != 3)
			{
				return false;
			}
			StringBuilder stringBuilder = new StringBuilder();
			try
			{
				Encoding encoding = Encoding.GetEncoding(array[0]);
				string text = array[2];
				byte[] array2 = new byte[text.Length];
				int num = 0;
				for (int i = 0; i < text.Length; i++)
				{
					if (Uri.IsHexEncoding(text, i))
					{
						array2[num++] = (byte)Uri.HexUnescape(text, ref i);
						i--;
					}
					else
					{
						if (num > 0)
						{
							stringBuilder.Append(encoding.GetString(array2, 0, num));
							num = 0;
						}
						stringBuilder.Append(text[i]);
					}
				}
				if (num > 0)
				{
					stringBuilder.Append(encoding.GetString(array2, 0, num));
				}
			}
			catch (ArgumentException)
			{
				return false;
			}
			output = stringBuilder.ToString();
			return true;
		}

		// Token: 0x04001008 RID: 4104
		private const string fileName = "filename";

		// Token: 0x04001009 RID: 4105
		private const string name = "name";

		// Token: 0x0400100A RID: 4106
		private const string fileNameStar = "filename*";

		// Token: 0x0400100B RID: 4107
		private const string creationDate = "creation-date";

		// Token: 0x0400100C RID: 4108
		private const string modificationDate = "modification-date";

		// Token: 0x0400100D RID: 4109
		private const string readDate = "read-date";

		// Token: 0x0400100E RID: 4110
		private const string size = "size";

		// Token: 0x0400100F RID: 4111
		private ICollection<NameValueHeaderValue> parameters;

		// Token: 0x04001010 RID: 4112
		private string dispositionType;
	}
}
