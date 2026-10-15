using System;
using System.Collections;
using System.Collections.Generic;

namespace System.Net.Http.Headers
{
	// Token: 0x020002F6 RID: 758
	public sealed class HttpHeaderValueCollection<T> : ICollection<T>, IEnumerable<!0>, IEnumerable where T : class
	{
		// Token: 0x17000A3E RID: 2622
		// (get) Token: 0x06002333 RID: 9011 RVA: 0x0007C444 File Offset: 0x0007A644
		public int Count
		{
			get
			{
				return this.GetCount();
			}
		}

		// Token: 0x17000A3F RID: 2623
		// (get) Token: 0x06002334 RID: 9012 RVA: 0x0007C44C File Offset: 0x0007A64C
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000A40 RID: 2624
		// (get) Token: 0x06002335 RID: 9013 RVA: 0x0007C450 File Offset: 0x0007A650
		internal bool IsSpecialValueSet
		{
			get
			{
				return this.specialValue != null && this.store.ContainsParsedValue(this.headerName, this.specialValue);
			}
		}

		// Token: 0x06002336 RID: 9014 RVA: 0x0007C480 File Offset: 0x0007A680
		internal HttpHeaderValueCollection(string headerName, HttpHeaders store) : this(headerName, store, default(T), null)
		{
		}

		// Token: 0x06002337 RID: 9015 RVA: 0x0007C4A4 File Offset: 0x0007A6A4
		internal HttpHeaderValueCollection(string headerName, HttpHeaders store, Action<HttpHeaderValueCollection<T>, T> validator) : this(headerName, store, default(T), validator)
		{
		}

		// Token: 0x06002338 RID: 9016 RVA: 0x0007C4C8 File Offset: 0x0007A6C8
		internal HttpHeaderValueCollection(string headerName, HttpHeaders store, T specialValue) : this(headerName, store, specialValue, null)
		{
		}

		// Token: 0x06002339 RID: 9017 RVA: 0x0007C4D4 File Offset: 0x0007A6D4
		internal HttpHeaderValueCollection(string headerName, HttpHeaders store, T specialValue, Action<HttpHeaderValueCollection<T>, T> validator)
		{
			this.store = store;
			this.headerName = headerName;
			this.specialValue = specialValue;
			this.validator = validator;
		}

		// Token: 0x0600233A RID: 9018 RVA: 0x0007C4FC File Offset: 0x0007A6FC
		public void Add(T item)
		{
			this.CheckValue(item);
			this.store.AddParsedValue(this.headerName, item);
		}

		// Token: 0x0600233B RID: 9019 RVA: 0x0007C51C File Offset: 0x0007A71C
		public void ParseAdd(string input)
		{
			this.store.Add(this.headerName, input);
		}

		// Token: 0x0600233C RID: 9020 RVA: 0x0007C530 File Offset: 0x0007A730
		public bool TryParseAdd(string input)
		{
			return this.store.TryParseAndAddValue(this.headerName, input);
		}

		// Token: 0x0600233D RID: 9021 RVA: 0x0007C544 File Offset: 0x0007A744
		public void Clear()
		{
			this.store.Remove(this.headerName);
		}

		// Token: 0x0600233E RID: 9022 RVA: 0x0007C558 File Offset: 0x0007A758
		public bool Contains(T item)
		{
			this.CheckValue(item);
			return this.store.ContainsParsedValue(this.headerName, item);
		}

		// Token: 0x0600233F RID: 9023 RVA: 0x0007C578 File Offset: 0x0007A778
		public void CopyTo(T[] array, int arrayIndex)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (arrayIndex < 0 || arrayIndex > array.Length)
			{
				throw new ArgumentOutOfRangeException("arrayIndex");
			}
			object parsedValues = this.store.GetParsedValues(this.headerName);
			if (parsedValues == null)
			{
				return;
			}
			List<object> list = parsedValues as List<object>;
			if (list != null)
			{
				list.CopyTo((object[])array, arrayIndex);
				return;
			}
			if (arrayIndex == array.Length)
			{
				throw new ArgumentException(SR.net_http_copyto_array_too_small);
			}
			array[arrayIndex] = (parsedValues as T);
		}

		// Token: 0x06002340 RID: 9024 RVA: 0x0007C610 File Offset: 0x0007A810
		public bool Remove(T item)
		{
			this.CheckValue(item);
			return this.store.RemoveParsedValue(this.headerName, item);
		}

		// Token: 0x06002341 RID: 9025 RVA: 0x0007C630 File Offset: 0x0007A830
		public IEnumerator<T> GetEnumerator()
		{
			object storeValue = this.store.GetParsedValues(this.headerName);
			if (storeValue != null)
			{
				List<object> storeValues = storeValue as List<object>;
				if (storeValues == null)
				{
					yield return storeValue as T;
				}
				else
				{
					foreach (object item in storeValues)
					{
						yield return item as T;
					}
				}
			}
			yield break;
		}

		// Token: 0x06002342 RID: 9026 RVA: 0x0007C650 File Offset: 0x0007A850
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x06002343 RID: 9027 RVA: 0x0007C658 File Offset: 0x0007A858
		public override string ToString()
		{
			return this.store.GetHeaderString(this.headerName);
		}

		// Token: 0x06002344 RID: 9028 RVA: 0x0007C66C File Offset: 0x0007A86C
		internal string GetHeaderStringWithoutSpecial()
		{
			if (!this.IsSpecialValueSet)
			{
				return this.ToString();
			}
			return this.store.GetHeaderString(this.headerName, this.specialValue);
		}

		// Token: 0x06002345 RID: 9029 RVA: 0x0007C69C File Offset: 0x0007A89C
		internal void SetSpecialValue()
		{
			if (!this.store.ContainsParsedValue(this.headerName, this.specialValue))
			{
				this.store.AddParsedValue(this.headerName, this.specialValue);
			}
		}

		// Token: 0x06002346 RID: 9030 RVA: 0x0007C6DC File Offset: 0x0007A8DC
		internal void RemoveSpecialValue()
		{
			this.store.RemoveParsedValue(this.headerName, this.specialValue);
		}

		// Token: 0x06002347 RID: 9031 RVA: 0x0007C6FC File Offset: 0x0007A8FC
		private void CheckValue(T item)
		{
			if (item == null)
			{
				throw new ArgumentNullException("item");
			}
			if (this.validator != null)
			{
				this.validator(this, item);
			}
		}

		// Token: 0x06002348 RID: 9032 RVA: 0x0007C72C File Offset: 0x0007A92C
		private int GetCount()
		{
			object parsedValues = this.store.GetParsedValues(this.headerName);
			if (parsedValues == null)
			{
				return 0;
			}
			List<object> list = parsedValues as List<object>;
			if (list == null)
			{
				return 1;
			}
			return list.Count;
		}

		// Token: 0x0400104D RID: 4173
		private string headerName;

		// Token: 0x0400104E RID: 4174
		private HttpHeaders store;

		// Token: 0x0400104F RID: 4175
		private T specialValue;

		// Token: 0x04001050 RID: 4176
		private Action<HttpHeaderValueCollection<T>, T> validator;
	}
}
