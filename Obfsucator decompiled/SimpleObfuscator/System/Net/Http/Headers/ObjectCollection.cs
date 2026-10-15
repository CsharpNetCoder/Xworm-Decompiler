using System;
using System.Collections.ObjectModel;

namespace System.Net.Http.Headers
{
	// Token: 0x02000300 RID: 768
	internal class ObjectCollection<T> : Collection<T> where T : class
	{
		// Token: 0x060023EA RID: 9194 RVA: 0x0007E29C File Offset: 0x0007C49C
		public ObjectCollection() : this(ObjectCollection<T>.defaultValidator)
		{
		}

		// Token: 0x060023EB RID: 9195 RVA: 0x0007E2AC File Offset: 0x0007C4AC
		public ObjectCollection(Action<T> validator)
		{
			this.validator = validator;
		}

		// Token: 0x060023EC RID: 9196 RVA: 0x0007E2BC File Offset: 0x0007C4BC
		protected override void InsertItem(int index, T item)
		{
			if (this.validator != null)
			{
				this.validator(item);
			}
			base.InsertItem(index, item);
		}

		// Token: 0x060023ED RID: 9197 RVA: 0x0007E2E0 File Offset: 0x0007C4E0
		protected override void SetItem(int index, T item)
		{
			if (this.validator != null)
			{
				this.validator(item);
			}
			base.SetItem(index, item);
		}

		// Token: 0x060023EE RID: 9198 RVA: 0x0007E304 File Offset: 0x0007C504
		private static void CheckNotNull(T item)
		{
			if (item == null)
			{
				throw new ArgumentNullException("item");
			}
		}

		// Token: 0x04001075 RID: 4213
		private static readonly Action<T> defaultValidator = new Action<T>(ObjectCollection<T>.CheckNotNull);

		// Token: 0x04001076 RID: 4214
		private Action<T> validator;
	}
}
