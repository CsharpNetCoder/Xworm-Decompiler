using System;

namespace System.Net.Http.Headers
{
	// Token: 0x0200030C RID: 780
	public sealed class TransferCodingWithQualityHeaderValue : TransferCodingHeaderValue, ICloneable
	{
		// Token: 0x17000A8C RID: 2700
		// (get) Token: 0x06002463 RID: 9315 RVA: 0x0007FE60 File Offset: 0x0007E060
		// (set) Token: 0x06002464 RID: 9316 RVA: 0x0007FE70 File Offset: 0x0007E070
		public double? Quality
		{
			get
			{
				return HeaderUtilities.GetQuality(base.Parameters);
			}
			set
			{
				HeaderUtilities.SetQuality(base.Parameters, value);
			}
		}

		// Token: 0x06002465 RID: 9317 RVA: 0x0007FE80 File Offset: 0x0007E080
		internal TransferCodingWithQualityHeaderValue()
		{
		}

		// Token: 0x06002466 RID: 9318 RVA: 0x0007FE88 File Offset: 0x0007E088
		public TransferCodingWithQualityHeaderValue(string value) : base(value)
		{
		}

		// Token: 0x06002467 RID: 9319 RVA: 0x0007FE94 File Offset: 0x0007E094
		public TransferCodingWithQualityHeaderValue(string value, double quality) : base(value)
		{
			this.Quality = new double?(quality);
		}

		// Token: 0x06002468 RID: 9320 RVA: 0x0007FEAC File Offset: 0x0007E0AC
		private TransferCodingWithQualityHeaderValue(TransferCodingWithQualityHeaderValue source) : base(source)
		{
		}

		// Token: 0x06002469 RID: 9321 RVA: 0x0007FEB8 File Offset: 0x0007E0B8
		object ICloneable.Clone()
		{
			return new TransferCodingWithQualityHeaderValue(this);
		}

		// Token: 0x0600246A RID: 9322 RVA: 0x0007FEC0 File Offset: 0x0007E0C0
		public new static TransferCodingWithQualityHeaderValue Parse(string input)
		{
			int num = 0;
			return (TransferCodingWithQualityHeaderValue)TransferCodingHeaderParser.SingleValueWithQualityParser.ParseValue(input, null, ref num);
		}

		// Token: 0x0600246B RID: 9323 RVA: 0x0007FEE8 File Offset: 0x0007E0E8
		public static bool TryParse(string input, out TransferCodingWithQualityHeaderValue parsedValue)
		{
			int num = 0;
			parsedValue = null;
			object obj;
			if (TransferCodingHeaderParser.SingleValueWithQualityParser.TryParseValue(input, null, ref num, out obj))
			{
				parsedValue = (TransferCodingWithQualityHeaderValue)obj;
				return true;
			}
			return false;
		}
	}
}
