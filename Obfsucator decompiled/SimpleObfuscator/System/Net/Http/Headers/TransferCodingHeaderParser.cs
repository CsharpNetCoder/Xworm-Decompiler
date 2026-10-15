using System;

namespace System.Net.Http.Headers
{
	// Token: 0x0200030A RID: 778
	internal class TransferCodingHeaderParser : BaseHeaderParser
	{
		// Token: 0x06002452 RID: 9298 RVA: 0x0007FB2C File Offset: 0x0007DD2C
		private TransferCodingHeaderParser(bool supportsMultipleValues, Func<TransferCodingHeaderValue> transferCodingCreator) : base(supportsMultipleValues)
		{
			this.transferCodingCreator = transferCodingCreator;
		}

		// Token: 0x06002453 RID: 9299 RVA: 0x0007FB3C File Offset: 0x0007DD3C
		protected override int GetParsedValueLength(string value, int startIndex, object storeValue, out object parsedValue)
		{
			TransferCodingHeaderValue transferCodingHeaderValue = null;
			int transferCodingLength = TransferCodingHeaderValue.GetTransferCodingLength(value, startIndex, this.transferCodingCreator, out transferCodingHeaderValue);
			parsedValue = transferCodingHeaderValue;
			return transferCodingLength;
		}

		// Token: 0x06002454 RID: 9300 RVA: 0x0007FB64 File Offset: 0x0007DD64
		private static TransferCodingHeaderValue CreateTransferCoding()
		{
			return new TransferCodingHeaderValue();
		}

		// Token: 0x06002455 RID: 9301 RVA: 0x0007FB6C File Offset: 0x0007DD6C
		private static TransferCodingHeaderValue CreateTransferCodingWithQuality()
		{
			return new TransferCodingWithQualityHeaderValue();
		}

		// Token: 0x04001089 RID: 4233
		private Func<TransferCodingHeaderValue> transferCodingCreator;

		// Token: 0x0400108A RID: 4234
		internal static readonly TransferCodingHeaderParser SingleValueParser = new TransferCodingHeaderParser(false, new Func<TransferCodingHeaderValue>(TransferCodingHeaderParser.CreateTransferCoding));

		// Token: 0x0400108B RID: 4235
		internal static readonly TransferCodingHeaderParser MultipleValueParser = new TransferCodingHeaderParser(true, new Func<TransferCodingHeaderValue>(TransferCodingHeaderParser.CreateTransferCoding));

		// Token: 0x0400108C RID: 4236
		internal static readonly TransferCodingHeaderParser SingleValueWithQualityParser = new TransferCodingHeaderParser(false, new Func<TransferCodingHeaderValue>(TransferCodingHeaderParser.CreateTransferCodingWithQuality));

		// Token: 0x0400108D RID: 4237
		internal static readonly TransferCodingHeaderParser MultipleValueWithQualityParser = new TransferCodingHeaderParser(true, new Func<TransferCodingHeaderValue>(TransferCodingHeaderParser.CreateTransferCodingWithQuality));
	}
}
