using System;

namespace System.Net.Http.Headers
{
	// Token: 0x020002FB RID: 763
	internal class MediaTypeHeaderParser : BaseHeaderParser
	{
		// Token: 0x060023A4 RID: 9124 RVA: 0x0007D4B0 File Offset: 0x0007B6B0
		private MediaTypeHeaderParser(bool supportsMultipleValues, Func<MediaTypeHeaderValue> mediaTypeCreator) : base(supportsMultipleValues)
		{
			this.supportsMultipleValues = supportsMultipleValues;
			this.mediaTypeCreator = mediaTypeCreator;
		}

		// Token: 0x060023A5 RID: 9125 RVA: 0x0007D4C8 File Offset: 0x0007B6C8
		protected override int GetParsedValueLength(string value, int startIndex, object storeValue, out object parsedValue)
		{
			MediaTypeHeaderValue mediaTypeHeaderValue = null;
			int mediaTypeLength = MediaTypeHeaderValue.GetMediaTypeLength(value, startIndex, this.mediaTypeCreator, out mediaTypeHeaderValue);
			parsedValue = mediaTypeHeaderValue;
			return mediaTypeLength;
		}

		// Token: 0x060023A6 RID: 9126 RVA: 0x0007D4F0 File Offset: 0x0007B6F0
		private static MediaTypeHeaderValue CreateMediaType()
		{
			return new MediaTypeHeaderValue();
		}

		// Token: 0x060023A7 RID: 9127 RVA: 0x0007D4F8 File Offset: 0x0007B6F8
		private static MediaTypeHeaderValue CreateMediaTypeWithQuality()
		{
			return new MediaTypeWithQualityHeaderValue();
		}

		// Token: 0x04001068 RID: 4200
		private bool supportsMultipleValues;

		// Token: 0x04001069 RID: 4201
		private Func<MediaTypeHeaderValue> mediaTypeCreator;

		// Token: 0x0400106A RID: 4202
		internal static readonly MediaTypeHeaderParser SingleValueParser = new MediaTypeHeaderParser(false, new Func<MediaTypeHeaderValue>(MediaTypeHeaderParser.CreateMediaType));

		// Token: 0x0400106B RID: 4203
		internal static readonly MediaTypeHeaderParser SingleValueWithQualityParser = new MediaTypeHeaderParser(false, new Func<MediaTypeHeaderValue>(MediaTypeHeaderParser.CreateMediaTypeWithQuality));

		// Token: 0x0400106C RID: 4204
		internal static readonly MediaTypeHeaderParser MultipleValuesParser = new MediaTypeHeaderParser(true, new Func<MediaTypeHeaderValue>(MediaTypeHeaderParser.CreateMediaTypeWithQuality));
	}
}
