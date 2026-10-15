using System;
using System.Collections.Generic;

namespace System.Net.Http.Headers
{
	// Token: 0x0200030B RID: 779
	public class TransferCodingHeaderValue : ICloneable
	{
		// Token: 0x17000A8A RID: 2698
		// (get) Token: 0x06002457 RID: 9303 RVA: 0x0007FBE4 File Offset: 0x0007DDE4
		public string Value
		{
			get
			{
				return this.value;
			}
		}

		// Token: 0x17000A8B RID: 2699
		// (get) Token: 0x06002458 RID: 9304 RVA: 0x0007FBEC File Offset: 0x0007DDEC
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

		// Token: 0x06002459 RID: 9305 RVA: 0x0007FC0C File Offset: 0x0007DE0C
		internal TransferCodingHeaderValue()
		{
		}

		// Token: 0x0600245A RID: 9306 RVA: 0x0007FC14 File Offset: 0x0007DE14
		protected TransferCodingHeaderValue(TransferCodingHeaderValue source)
		{
			this.value = source.value;
			if (source.parameters != null)
			{
				foreach (NameValueHeaderValue nameValueHeaderValue in source.parameters)
				{
					this.Parameters.Add((NameValueHeaderValue)((ICloneable)nameValueHeaderValue).Clone());
				}
			}
		}

		// Token: 0x0600245B RID: 9307 RVA: 0x0007FC98 File Offset: 0x0007DE98
		public TransferCodingHeaderValue(string value)
		{
			HeaderUtilities.CheckValidToken(value, "value");
			this.value = value;
		}

		// Token: 0x0600245C RID: 9308 RVA: 0x0007FCB4 File Offset: 0x0007DEB4
		public static TransferCodingHeaderValue Parse(string input)
		{
			int num = 0;
			return (TransferCodingHeaderValue)TransferCodingHeaderParser.SingleValueParser.ParseValue(input, null, ref num);
		}

		// Token: 0x0600245D RID: 9309 RVA: 0x0007FCDC File Offset: 0x0007DEDC
		public static bool TryParse(string input, out TransferCodingHeaderValue parsedValue)
		{
			int num = 0;
			parsedValue = null;
			object obj;
			if (TransferCodingHeaderParser.SingleValueParser.TryParseValue(input, null, ref num, out obj))
			{
				parsedValue = (TransferCodingHeaderValue)obj;
				return true;
			}
			return false;
		}

		// Token: 0x0600245E RID: 9310 RVA: 0x0007FD14 File Offset: 0x0007DF14
		internal static int GetTransferCodingLength(string input, int startIndex, Func<TransferCodingHeaderValue> transferCodingCreator, out TransferCodingHeaderValue parsedValue)
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
			string text = input.Substring(startIndex, tokenLength);
			int num = startIndex + tokenLength;
			num += HttpRuleParser.GetWhitespaceLength(input, num);
			TransferCodingHeaderValue transferCodingHeaderValue;
			if (num >= input.Length || input[num] != ';')
			{
				transferCodingHeaderValue = transferCodingCreator();
				transferCodingHeaderValue.value = text;
				parsedValue = transferCodingHeaderValue;
				return num - startIndex;
			}
			transferCodingHeaderValue = transferCodingCreator();
			transferCodingHeaderValue.value = text;
			num++;
			int nameValueListLength = NameValueHeaderValue.GetNameValueListLength(input, num, ';', transferCodingHeaderValue.Parameters);
			if (nameValueListLength == 0)
			{
				return 0;
			}
			parsedValue = transferCodingHeaderValue;
			return num + nameValueListLength - startIndex;
		}

		// Token: 0x0600245F RID: 9311 RVA: 0x0007FDD0 File Offset: 0x0007DFD0
		public override string ToString()
		{
			return this.value + NameValueHeaderValue.ToString(this.parameters, ';', true);
		}

		// Token: 0x06002460 RID: 9312 RVA: 0x0007FDEC File Offset: 0x0007DFEC
		public override bool Equals(object obj)
		{
			TransferCodingHeaderValue transferCodingHeaderValue = obj as TransferCodingHeaderValue;
			return transferCodingHeaderValue != null && string.Compare(this.value, transferCodingHeaderValue.value, StringComparison.OrdinalIgnoreCase) == 0 && HeaderUtilities.AreEqualCollections<NameValueHeaderValue>(this.parameters, transferCodingHeaderValue.parameters);
		}

		// Token: 0x06002461 RID: 9313 RVA: 0x0007FE38 File Offset: 0x0007E038
		public override int GetHashCode()
		{
			return this.value.ToLowerInvariant().GetHashCode() ^ NameValueHeaderValue.GetHashCode(this.parameters);
		}

		// Token: 0x06002462 RID: 9314 RVA: 0x0007FE58 File Offset: 0x0007E058
		object ICloneable.Clone()
		{
			return new TransferCodingHeaderValue(this);
		}

		// Token: 0x0400108E RID: 4238
		private ICollection<NameValueHeaderValue> parameters;

		// Token: 0x0400108F RID: 4239
		private string value;
	}
}
