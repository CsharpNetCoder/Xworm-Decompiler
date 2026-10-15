using System;

namespace System.Net.Http.Headers
{
	// Token: 0x020002FD RID: 765
	public sealed class MediaTypeWithQualityHeaderValue : MediaTypeHeaderValue, ICloneable
	{
		// Token: 0x17000A78 RID: 2680
		// (get) Token: 0x060023BA RID: 9146 RVA: 0x0007D994 File Offset: 0x0007BB94
		// (set) Token: 0x060023BB RID: 9147 RVA: 0x0007D9A4 File Offset: 0x0007BBA4
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

		// Token: 0x060023BC RID: 9148 RVA: 0x0007D9B4 File Offset: 0x0007BBB4
		internal MediaTypeWithQualityHeaderValue()
		{
		}

		// Token: 0x060023BD RID: 9149 RVA: 0x0007D9BC File Offset: 0x0007BBBC
		public MediaTypeWithQualityHeaderValue(string mediaType) : base(mediaType)
		{
		}

		// Token: 0x060023BE RID: 9150 RVA: 0x0007D9C8 File Offset: 0x0007BBC8
		public MediaTypeWithQualityHeaderValue(string mediaType, double quality) : base(mediaType)
		{
			this.Quality = new double?(quality);
		}

		// Token: 0x060023BF RID: 9151 RVA: 0x0007D9E0 File Offset: 0x0007BBE0
		private MediaTypeWithQualityHeaderValue(MediaTypeWithQualityHeaderValue source) : base(source)
		{
		}

		// Token: 0x060023C0 RID: 9152 RVA: 0x0007D9EC File Offset: 0x0007BBEC
		object ICloneable.Clone()
		{
			return new MediaTypeWithQualityHeaderValue(this);
		}

		// Token: 0x060023C1 RID: 9153 RVA: 0x0007D9F4 File Offset: 0x0007BBF4
		public new static MediaTypeWithQualityHeaderValue Parse(string input)
		{
			int num = 0;
			return (MediaTypeWithQualityHeaderValue)MediaTypeHeaderParser.SingleValueWithQualityParser.ParseValue(input, null, ref num);
		}

		// Token: 0x060023C2 RID: 9154 RVA: 0x0007DA1C File Offset: 0x0007BC1C
		public static bool TryParse(string input, out MediaTypeWithQualityHeaderValue parsedValue)
		{
			int num = 0;
			parsedValue = null;
			object obj;
			if (MediaTypeHeaderParser.SingleValueWithQualityParser.TryParseValue(input, null, ref num, out obj))
			{
				parsedValue = (MediaTypeWithQualityHeaderValue)obj;
				return true;
			}
			return false;
		}
	}
}
