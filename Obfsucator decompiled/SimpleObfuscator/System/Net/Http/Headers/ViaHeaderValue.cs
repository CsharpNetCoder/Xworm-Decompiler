using System;
using System.Globalization;
using System.Text;

namespace System.Net.Http.Headers
{
	// Token: 0x0200030E RID: 782
	public class ViaHeaderValue : ICloneable
	{
		// Token: 0x17000A8D RID: 2701
		// (get) Token: 0x06002471 RID: 9329 RVA: 0x000800D4 File Offset: 0x0007E2D4
		public string ProtocolName
		{
			get
			{
				return this.protocolName;
			}
		}

		// Token: 0x17000A8E RID: 2702
		// (get) Token: 0x06002472 RID: 9330 RVA: 0x000800DC File Offset: 0x0007E2DC
		public string ProtocolVersion
		{
			get
			{
				return this.protocolVersion;
			}
		}

		// Token: 0x17000A8F RID: 2703
		// (get) Token: 0x06002473 RID: 9331 RVA: 0x000800E4 File Offset: 0x0007E2E4
		public string ReceivedBy
		{
			get
			{
				return this.receivedBy;
			}
		}

		// Token: 0x17000A90 RID: 2704
		// (get) Token: 0x06002474 RID: 9332 RVA: 0x000800EC File Offset: 0x0007E2EC
		public string Comment
		{
			get
			{
				return this.comment;
			}
		}

		// Token: 0x06002475 RID: 9333 RVA: 0x000800F4 File Offset: 0x0007E2F4
		public ViaHeaderValue(string protocolVersion, string receivedBy) : this(protocolVersion, receivedBy, null, null)
		{
		}

		// Token: 0x06002476 RID: 9334 RVA: 0x00080100 File Offset: 0x0007E300
		public ViaHeaderValue(string protocolVersion, string receivedBy, string protocolName) : this(protocolVersion, receivedBy, protocolName, null)
		{
		}

		// Token: 0x06002477 RID: 9335 RVA: 0x0008010C File Offset: 0x0007E30C
		public ViaHeaderValue(string protocolVersion, string receivedBy, string protocolName, string comment)
		{
			HeaderUtilities.CheckValidToken(protocolVersion, "protocolVersion");
			ViaHeaderValue.CheckReceivedBy(receivedBy);
			if (!string.IsNullOrEmpty(protocolName))
			{
				HeaderUtilities.CheckValidToken(protocolName, "protocolName");
				this.protocolName = protocolName;
			}
			if (!string.IsNullOrEmpty(comment))
			{
				HeaderUtilities.CheckValidComment(comment, "comment");
				this.comment = comment;
			}
			this.protocolVersion = protocolVersion;
			this.receivedBy = receivedBy;
		}

		// Token: 0x06002478 RID: 9336 RVA: 0x00080180 File Offset: 0x0007E380
		private ViaHeaderValue()
		{
		}

		// Token: 0x06002479 RID: 9337 RVA: 0x00080188 File Offset: 0x0007E388
		private ViaHeaderValue(ViaHeaderValue source)
		{
			this.protocolName = source.protocolName;
			this.protocolVersion = source.protocolVersion;
			this.receivedBy = source.receivedBy;
			this.comment = source.comment;
		}

		// Token: 0x0600247A RID: 9338 RVA: 0x000801C0 File Offset: 0x0007E3C0
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			if (!string.IsNullOrEmpty(this.protocolName))
			{
				stringBuilder.Append(this.protocolName);
				stringBuilder.Append('/');
			}
			stringBuilder.Append(this.protocolVersion);
			stringBuilder.Append(' ');
			stringBuilder.Append(this.receivedBy);
			if (!string.IsNullOrEmpty(this.comment))
			{
				stringBuilder.Append(' ');
				stringBuilder.Append(this.comment);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600247B RID: 9339 RVA: 0x0008024C File Offset: 0x0007E44C
		public override bool Equals(object obj)
		{
			ViaHeaderValue viaHeaderValue = obj as ViaHeaderValue;
			return viaHeaderValue != null && (string.Compare(this.protocolVersion, viaHeaderValue.protocolVersion, StringComparison.OrdinalIgnoreCase) == 0 && string.Compare(this.receivedBy, viaHeaderValue.receivedBy, StringComparison.OrdinalIgnoreCase) == 0 && string.Compare(this.protocolName, viaHeaderValue.protocolName, StringComparison.OrdinalIgnoreCase) == 0) && string.CompareOrdinal(this.comment, viaHeaderValue.comment) == 0;
		}

		// Token: 0x0600247C RID: 9340 RVA: 0x000802C8 File Offset: 0x0007E4C8
		public override int GetHashCode()
		{
			int num = this.protocolVersion.ToLowerInvariant().GetHashCode() ^ this.receivedBy.ToLowerInvariant().GetHashCode();
			if (!string.IsNullOrEmpty(this.protocolName))
			{
				num ^= this.protocolName.ToLowerInvariant().GetHashCode();
			}
			if (!string.IsNullOrEmpty(this.comment))
			{
				num ^= this.comment.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600247D RID: 9341 RVA: 0x00080340 File Offset: 0x0007E540
		public static ViaHeaderValue Parse(string input)
		{
			int num = 0;
			return (ViaHeaderValue)GenericHeaderParser.SingleValueViaParser.ParseValue(input, null, ref num);
		}

		// Token: 0x0600247E RID: 9342 RVA: 0x00080368 File Offset: 0x0007E568
		public static bool TryParse(string input, out ViaHeaderValue parsedValue)
		{
			int num = 0;
			parsedValue = null;
			object obj;
			if (GenericHeaderParser.SingleValueViaParser.TryParseValue(input, null, ref num, out obj))
			{
				parsedValue = (ViaHeaderValue)obj;
				return true;
			}
			return false;
		}

		// Token: 0x0600247F RID: 9343 RVA: 0x000803A0 File Offset: 0x0007E5A0
		internal static int GetViaLength(string input, int startIndex, out object parsedValue)
		{
			parsedValue = null;
			if (string.IsNullOrEmpty(input) || startIndex >= input.Length)
			{
				return 0;
			}
			string text = null;
			string text2 = null;
			int num = ViaHeaderValue.GetProtocolEndIndex(input, startIndex, out text, out text2);
			if (num == startIndex || num == input.Length)
			{
				return 0;
			}
			string text3 = null;
			int hostLength = HttpRuleParser.GetHostLength(input, num, true, out text3);
			if (hostLength == 0)
			{
				return 0;
			}
			num += hostLength;
			num += HttpRuleParser.GetWhitespaceLength(input, num);
			string text4 = null;
			if (num < input.Length && input[num] == '(')
			{
				int num2 = 0;
				if (HttpRuleParser.GetCommentLength(input, num, out num2) != HttpParseResult.Parsed)
				{
					return 0;
				}
				text4 = input.Substring(num, num2);
				num += num2;
				num += HttpRuleParser.GetWhitespaceLength(input, num);
			}
			parsedValue = new ViaHeaderValue
			{
				protocolVersion = text2,
				protocolName = text,
				receivedBy = text3,
				comment = text4
			};
			return num - startIndex;
		}

		// Token: 0x06002480 RID: 9344 RVA: 0x00080494 File Offset: 0x0007E694
		private static int GetProtocolEndIndex(string input, int startIndex, out string protocolName, out string protocolVersion)
		{
			protocolName = null;
			protocolVersion = null;
			int tokenLength = HttpRuleParser.GetTokenLength(input, startIndex);
			if (tokenLength == 0)
			{
				return 0;
			}
			int num = startIndex + tokenLength;
			int whitespaceLength = HttpRuleParser.GetWhitespaceLength(input, num);
			num += whitespaceLength;
			if (num == input.Length)
			{
				return 0;
			}
			if (input[num] == '/')
			{
				protocolName = input.Substring(startIndex, tokenLength);
				num++;
				num += HttpRuleParser.GetWhitespaceLength(input, num);
				tokenLength = HttpRuleParser.GetTokenLength(input, num);
				if (tokenLength == 0)
				{
					return 0;
				}
				protocolVersion = input.Substring(num, tokenLength);
				num += tokenLength;
				whitespaceLength = HttpRuleParser.GetWhitespaceLength(input, num);
				num += whitespaceLength;
			}
			else
			{
				protocolVersion = input.Substring(startIndex, tokenLength);
			}
			if (whitespaceLength == 0)
			{
				return 0;
			}
			return num;
		}

		// Token: 0x06002481 RID: 9345 RVA: 0x00080544 File Offset: 0x0007E744
		object ICloneable.Clone()
		{
			return new ViaHeaderValue(this);
		}

		// Token: 0x06002482 RID: 9346 RVA: 0x0008054C File Offset: 0x0007E74C
		private static void CheckReceivedBy(string receivedBy)
		{
			if (string.IsNullOrEmpty(receivedBy))
			{
				throw new ArgumentException(SR.net_http_argument_empty_string, "receivedBy");
			}
			string text = null;
			if (HttpRuleParser.GetHostLength(receivedBy, 0, true, out text) != receivedBy.Length)
			{
				throw new FormatException(string.Format(CultureInfo.InvariantCulture, SR.net_http_headers_invalid_value, new object[]
				{
					receivedBy
				}));
			}
		}

		// Token: 0x04001092 RID: 4242
		private string protocolName;

		// Token: 0x04001093 RID: 4243
		private string protocolVersion;

		// Token: 0x04001094 RID: 4244
		private string receivedBy;

		// Token: 0x04001095 RID: 4245
		private string comment;
	}
}
