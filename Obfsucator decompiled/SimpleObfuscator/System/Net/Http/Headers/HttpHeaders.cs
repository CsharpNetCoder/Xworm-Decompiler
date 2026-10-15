using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace System.Net.Http.Headers
{
	// Token: 0x020002F3 RID: 755
	public abstract class HttpHeaders : IEnumerable<KeyValuePair<string, IEnumerable<string>>>, IEnumerable
	{
		// Token: 0x060022D2 RID: 8914 RVA: 0x0007A8AC File Offset: 0x00078AAC
		public void Add(string name, string value)
		{
			this.CheckHeaderName(name);
			HttpHeaders.HeaderStoreItemInfo headerStoreItemInfo;
			bool flag;
			this.PrepareHeaderInfoForAdd(name, out headerStoreItemInfo, out flag);
			this.ParseAndAddValue(name, headerStoreItemInfo, value);
			if (flag && headerStoreItemInfo.ParsedValue != null)
			{
				this.AddHeaderToStore(name, headerStoreItemInfo);
			}
		}

		// Token: 0x060022D3 RID: 8915 RVA: 0x0007A8F4 File Offset: 0x00078AF4
		public void Add(string name, IEnumerable<string> values)
		{
			if (values == null)
			{
				throw new ArgumentNullException("values");
			}
			this.CheckHeaderName(name);
			HttpHeaders.HeaderStoreItemInfo headerStoreItemInfo;
			bool flag;
			this.PrepareHeaderInfoForAdd(name, out headerStoreItemInfo, out flag);
			try
			{
				foreach (string value in values)
				{
					this.ParseAndAddValue(name, headerStoreItemInfo, value);
				}
			}
			finally
			{
				if (flag && headerStoreItemInfo.ParsedValue != null)
				{
					this.AddHeaderToStore(name, headerStoreItemInfo);
				}
			}
		}

		// Token: 0x060022D4 RID: 8916 RVA: 0x0007A998 File Offset: 0x00078B98
		public bool TryAddWithoutValidation(string name, string value)
		{
			if (!this.TryCheckHeaderName(name))
			{
				return false;
			}
			if (value == null)
			{
				value = string.Empty;
			}
			HttpHeaders.HeaderStoreItemInfo orCreateHeaderInfo = this.GetOrCreateHeaderInfo(name, false);
			HttpHeaders.AddValue(orCreateHeaderInfo, value, HttpHeaders.StoreLocation.Raw);
			return true;
		}

		// Token: 0x060022D5 RID: 8917 RVA: 0x0007A9D8 File Offset: 0x00078BD8
		public bool TryAddWithoutValidation(string name, IEnumerable<string> values)
		{
			if (values == null)
			{
				throw new ArgumentNullException("values");
			}
			if (!this.TryCheckHeaderName(name))
			{
				return false;
			}
			HttpHeaders.HeaderStoreItemInfo orCreateHeaderInfo = this.GetOrCreateHeaderInfo(name, false);
			foreach (string text in values)
			{
				HttpHeaders.AddValue(orCreateHeaderInfo, text ?? string.Empty, HttpHeaders.StoreLocation.Raw);
			}
			return true;
		}

		// Token: 0x060022D6 RID: 8918 RVA: 0x0007AA60 File Offset: 0x00078C60
		public void Clear()
		{
			if (this.headerStore != null)
			{
				this.headerStore.Clear();
			}
		}

		// Token: 0x060022D7 RID: 8919 RVA: 0x0007AA78 File Offset: 0x00078C78
		public bool Remove(string name)
		{
			this.CheckHeaderName(name);
			return this.headerStore != null && this.headerStore.Remove(name);
		}

		// Token: 0x060022D8 RID: 8920 RVA: 0x0007AA9C File Offset: 0x00078C9C
		public IEnumerable<string> GetValues(string name)
		{
			this.CheckHeaderName(name);
			IEnumerable<string> result;
			if (!this.TryGetValues(name, out result))
			{
				throw new InvalidOperationException(SR.net_http_headers_not_found);
			}
			return result;
		}

		// Token: 0x060022D9 RID: 8921 RVA: 0x0007AAD0 File Offset: 0x00078CD0
		public bool TryGetValues(string name, out IEnumerable<string> values)
		{
			if (!this.TryCheckHeaderName(name))
			{
				values = null;
				return false;
			}
			if (this.headerStore == null)
			{
				values = null;
				return false;
			}
			HttpHeaders.HeaderStoreItemInfo info = null;
			if (this.TryGetAndParseHeaderInfo(name, out info))
			{
				values = HttpHeaders.GetValuesAsStrings(info);
				return true;
			}
			values = null;
			return false;
		}

		// Token: 0x060022DA RID: 8922 RVA: 0x0007AB20 File Offset: 0x00078D20
		public bool Contains(string name)
		{
			this.CheckHeaderName(name);
			if (this.headerStore == null)
			{
				return false;
			}
			HttpHeaders.HeaderStoreItemInfo headerStoreItemInfo = null;
			return this.TryGetAndParseHeaderInfo(name, out headerStoreItemInfo);
		}

		// Token: 0x060022DB RID: 8923 RVA: 0x0007AB50 File Offset: 0x00078D50
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			foreach (KeyValuePair<string, IEnumerable<string>> keyValuePair in this)
			{
				stringBuilder.Append(keyValuePair.Key);
				stringBuilder.Append(": ");
				stringBuilder.Append(this.GetHeaderString(keyValuePair.Key));
				stringBuilder.Append("\r\n");
			}
			return stringBuilder.ToString();
		}

		// Token: 0x060022DC RID: 8924 RVA: 0x0007ABE0 File Offset: 0x00078DE0
		internal IEnumerable<KeyValuePair<string, string>> GetHeaderStrings()
		{
			if (this.headerStore != null)
			{
				foreach (KeyValuePair<string, HttpHeaders.HeaderStoreItemInfo> header in this.headerStore)
				{
					KeyValuePair<string, HttpHeaders.HeaderStoreItemInfo> keyValuePair = header;
					HttpHeaders.HeaderStoreItemInfo info = keyValuePair.Value;
					string stringValue = this.GetHeaderString(info);
					KeyValuePair<string, HttpHeaders.HeaderStoreItemInfo> keyValuePair2 = header;
					yield return new KeyValuePair<string, string>(keyValuePair2.Key, stringValue);
				}
			}
			yield break;
		}

		// Token: 0x060022DD RID: 8925 RVA: 0x0007AC04 File Offset: 0x00078E04
		internal string GetHeaderString(string headerName)
		{
			return this.GetHeaderString(headerName, null);
		}

		// Token: 0x060022DE RID: 8926 RVA: 0x0007AC10 File Offset: 0x00078E10
		internal string GetHeaderString(string headerName, object exclude)
		{
			HttpHeaders.HeaderStoreItemInfo info;
			if (!this.TryGetHeaderInfo(headerName, out info))
			{
				return string.Empty;
			}
			return this.GetHeaderString(info, exclude);
		}

		// Token: 0x060022DF RID: 8927 RVA: 0x0007AC40 File Offset: 0x00078E40
		private string GetHeaderString(HttpHeaders.HeaderStoreItemInfo info)
		{
			return this.GetHeaderString(info, null);
		}

		// Token: 0x060022E0 RID: 8928 RVA: 0x0007AC4C File Offset: 0x00078E4C
		private string GetHeaderString(HttpHeaders.HeaderStoreItemInfo info, object exclude)
		{
			string result = string.Empty;
			string[] valuesAsStrings = HttpHeaders.GetValuesAsStrings(info, exclude);
			if (valuesAsStrings.Length == 1)
			{
				result = valuesAsStrings[0];
			}
			else
			{
				string separator = ", ";
				if (info.Parser != null && info.Parser.SupportsMultipleValues)
				{
					separator = info.Parser.Separator;
				}
				result = string.Join(separator, valuesAsStrings);
			}
			return result;
		}

		// Token: 0x060022E1 RID: 8929 RVA: 0x0007ACB8 File Offset: 0x00078EB8
		public IEnumerator<KeyValuePair<string, IEnumerable<string>>> GetEnumerator()
		{
			if (this.headerStore != null)
			{
				List<string> invalidHeaders = null;
				foreach (KeyValuePair<string, HttpHeaders.HeaderStoreItemInfo> header in this.headerStore)
				{
					KeyValuePair<string, HttpHeaders.HeaderStoreItemInfo> keyValuePair = header;
					HttpHeaders.HeaderStoreItemInfo info = keyValuePair.Value;
					KeyValuePair<string, HttpHeaders.HeaderStoreItemInfo> keyValuePair2 = header;
					if (!this.ParseRawHeaderValues(keyValuePair2.Key, info, false))
					{
						if (invalidHeaders == null)
						{
							invalidHeaders = new List<string>();
						}
						List<string> list = invalidHeaders;
						KeyValuePair<string, HttpHeaders.HeaderStoreItemInfo> keyValuePair3 = header;
						list.Add(keyValuePair3.Key);
					}
					else
					{
						string[] values = HttpHeaders.GetValuesAsStrings(info);
						KeyValuePair<string, HttpHeaders.HeaderStoreItemInfo> keyValuePair4 = header;
						yield return new KeyValuePair<string, IEnumerable<string>>(keyValuePair4.Key, values);
					}
				}
				if (invalidHeaders != null)
				{
					using (List<string>.Enumerator enumerator2 = invalidHeaders.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							string key = enumerator2.Current;
							this.headerStore.Remove(key);
						}
						yield break;
					}
				}
			}
			yield break;
		}

		// Token: 0x060022E2 RID: 8930 RVA: 0x0007ACD8 File Offset: 0x00078ED8
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x060022E3 RID: 8931 RVA: 0x0007ACE0 File Offset: 0x00078EE0
		internal void SetConfiguration(Dictionary<string, HttpHeaderParser> parserStore, HashSet<string> invalidHeaders)
		{
			this.parserStore = parserStore;
			this.invalidHeaders = invalidHeaders;
		}

		// Token: 0x060022E4 RID: 8932 RVA: 0x0007ACF0 File Offset: 0x00078EF0
		internal void AddParsedValue(string name, object value)
		{
			HttpHeaders.HeaderStoreItemInfo orCreateHeaderInfo = this.GetOrCreateHeaderInfo(name, true);
			HttpHeaders.AddValue(orCreateHeaderInfo, value, HttpHeaders.StoreLocation.Parsed);
		}

		// Token: 0x060022E5 RID: 8933 RVA: 0x0007AD14 File Offset: 0x00078F14
		internal void SetParsedValue(string name, object value)
		{
			HttpHeaders.HeaderStoreItemInfo orCreateHeaderInfo = this.GetOrCreateHeaderInfo(name, true);
			orCreateHeaderInfo.InvalidValue = null;
			orCreateHeaderInfo.ParsedValue = null;
			orCreateHeaderInfo.RawValue = null;
			HttpHeaders.AddValue(orCreateHeaderInfo, value, HttpHeaders.StoreLocation.Parsed);
		}

		// Token: 0x060022E6 RID: 8934 RVA: 0x0007AD4C File Offset: 0x00078F4C
		internal void SetOrRemoveParsedValue(string name, object value)
		{
			if (value == null)
			{
				this.Remove(name);
				return;
			}
			this.SetParsedValue(name, value);
		}

		// Token: 0x060022E7 RID: 8935 RVA: 0x0007AD68 File Offset: 0x00078F68
		internal bool RemoveParsedValue(string name, object value)
		{
			if (this.headerStore == null)
			{
				return false;
			}
			HttpHeaders.HeaderStoreItemInfo headerStoreItemInfo = null;
			if (!this.TryGetAndParseHeaderInfo(name, out headerStoreItemInfo))
			{
				return false;
			}
			bool result = false;
			if (headerStoreItemInfo.ParsedValue == null)
			{
				return false;
			}
			IEqualityComparer comparer = headerStoreItemInfo.Parser.Comparer;
			List<object> list = headerStoreItemInfo.ParsedValue as List<object>;
			if (list == null)
			{
				if (this.AreEqual(value, headerStoreItemInfo.ParsedValue, comparer))
				{
					headerStoreItemInfo.ParsedValue = null;
					result = true;
				}
			}
			else
			{
				foreach (object obj in list)
				{
					if (this.AreEqual(value, obj, comparer))
					{
						result = list.Remove(obj);
						break;
					}
				}
				if (list.Count == 0)
				{
					headerStoreItemInfo.ParsedValue = null;
				}
			}
			if (headerStoreItemInfo.IsEmpty)
			{
				this.Remove(name);
			}
			return result;
		}

		// Token: 0x060022E8 RID: 8936 RVA: 0x0007AE68 File Offset: 0x00079068
		internal bool ContainsParsedValue(string name, object value)
		{
			if (this.headerStore == null)
			{
				return false;
			}
			HttpHeaders.HeaderStoreItemInfo headerStoreItemInfo = null;
			if (!this.TryGetAndParseHeaderInfo(name, out headerStoreItemInfo))
			{
				return false;
			}
			if (headerStoreItemInfo.ParsedValue == null)
			{
				return false;
			}
			List<object> list = headerStoreItemInfo.ParsedValue as List<object>;
			IEqualityComparer comparer = headerStoreItemInfo.Parser.Comparer;
			if (list == null)
			{
				return this.AreEqual(value, headerStoreItemInfo.ParsedValue, comparer);
			}
			foreach (object storeValue in list)
			{
				if (this.AreEqual(value, storeValue, comparer))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060022E9 RID: 8937 RVA: 0x0007AF2C File Offset: 0x0007912C
		internal virtual void AddHeaders(HttpHeaders sourceHeaders)
		{
			if (sourceHeaders.headerStore == null)
			{
				return;
			}
			List<string> list = null;
			foreach (KeyValuePair<string, HttpHeaders.HeaderStoreItemInfo> keyValuePair in sourceHeaders.headerStore)
			{
				if (this.headerStore == null || !this.headerStore.ContainsKey(keyValuePair.Key))
				{
					HttpHeaders.HeaderStoreItemInfo value = keyValuePair.Value;
					if (!sourceHeaders.ParseRawHeaderValues(keyValuePair.Key, value, false))
					{
						if (list == null)
						{
							list = new List<string>();
						}
						list.Add(keyValuePair.Key);
					}
					else
					{
						this.AddHeaderInfo(keyValuePair.Key, value);
					}
				}
			}
			if (list != null)
			{
				foreach (string key in list)
				{
					sourceHeaders.headerStore.Remove(key);
				}
			}
		}

		// Token: 0x060022EA RID: 8938 RVA: 0x0007B048 File Offset: 0x00079248
		private void AddHeaderInfo(string headerName, HttpHeaders.HeaderStoreItemInfo sourceInfo)
		{
			HttpHeaders.HeaderStoreItemInfo headerStoreItemInfo = this.CreateAndAddHeaderToStore(headerName);
			if (headerStoreItemInfo.Parser == null)
			{
				headerStoreItemInfo.ParsedValue = HttpHeaders.CloneStringHeaderInfoValues(sourceInfo.ParsedValue);
				return;
			}
			headerStoreItemInfo.InvalidValue = HttpHeaders.CloneStringHeaderInfoValues(sourceInfo.InvalidValue);
			if (sourceInfo.ParsedValue != null)
			{
				List<object> list = sourceInfo.ParsedValue as List<object>;
				if (list == null)
				{
					HttpHeaders.CloneAndAddValue(headerStoreItemInfo, sourceInfo.ParsedValue);
					return;
				}
				foreach (object source in list)
				{
					HttpHeaders.CloneAndAddValue(headerStoreItemInfo, source);
				}
			}
		}

		// Token: 0x060022EB RID: 8939 RVA: 0x0007B0FC File Offset: 0x000792FC
		private static void CloneAndAddValue(HttpHeaders.HeaderStoreItemInfo destinationInfo, object source)
		{
			ICloneable cloneable = source as ICloneable;
			if (cloneable != null)
			{
				HttpHeaders.AddValue(destinationInfo, cloneable.Clone(), HttpHeaders.StoreLocation.Parsed);
				return;
			}
			HttpHeaders.AddValue(destinationInfo, source, HttpHeaders.StoreLocation.Parsed);
		}

		// Token: 0x060022EC RID: 8940 RVA: 0x0007B130 File Offset: 0x00079330
		private static object CloneStringHeaderInfoValues(object source)
		{
			if (source == null)
			{
				return null;
			}
			List<object> list = source as List<object>;
			if (list == null)
			{
				return source;
			}
			return new List<object>(list);
		}

		// Token: 0x060022ED RID: 8941 RVA: 0x0007B160 File Offset: 0x00079360
		private HttpHeaders.HeaderStoreItemInfo GetOrCreateHeaderInfo(string name, bool parseRawValues)
		{
			HttpHeaders.HeaderStoreItemInfo result = null;
			bool flag;
			if (parseRawValues)
			{
				flag = this.TryGetAndParseHeaderInfo(name, out result);
			}
			else
			{
				flag = this.TryGetHeaderInfo(name, out result);
			}
			if (!flag)
			{
				result = this.CreateAndAddHeaderToStore(name);
			}
			return result;
		}

		// Token: 0x060022EE RID: 8942 RVA: 0x0007B1A4 File Offset: 0x000793A4
		private HttpHeaders.HeaderStoreItemInfo CreateAndAddHeaderToStore(string name)
		{
			HttpHeaders.HeaderStoreItemInfo headerStoreItemInfo = new HttpHeaders.HeaderStoreItemInfo(this.GetParser(name));
			this.AddHeaderToStore(name, headerStoreItemInfo);
			return headerStoreItemInfo;
		}

		// Token: 0x060022EF RID: 8943 RVA: 0x0007B1CC File Offset: 0x000793CC
		private void AddHeaderToStore(string name, HttpHeaders.HeaderStoreItemInfo info)
		{
			if (this.headerStore == null)
			{
				this.headerStore = new Dictionary<string, HttpHeaders.HeaderStoreItemInfo>(StringComparer.OrdinalIgnoreCase);
			}
			this.headerStore.Add(name, info);
		}

		// Token: 0x060022F0 RID: 8944 RVA: 0x0007B1F8 File Offset: 0x000793F8
		private bool TryGetHeaderInfo(string name, out HttpHeaders.HeaderStoreItemInfo info)
		{
			if (this.headerStore == null)
			{
				info = null;
				return false;
			}
			return this.headerStore.TryGetValue(name, out info);
		}

		// Token: 0x060022F1 RID: 8945 RVA: 0x0007B218 File Offset: 0x00079418
		private bool TryGetAndParseHeaderInfo(string name, out HttpHeaders.HeaderStoreItemInfo info)
		{
			return this.TryGetHeaderInfo(name, out info) && this.ParseRawHeaderValues(name, info, true);
		}

		// Token: 0x060022F2 RID: 8946 RVA: 0x0007B234 File Offset: 0x00079434
		private bool ParseRawHeaderValues(string name, HttpHeaders.HeaderStoreItemInfo info, bool removeEmptyHeader)
		{
			lock (info)
			{
				if (info.RawValue != null)
				{
					List<string> list = info.RawValue as List<string>;
					if (list == null)
					{
						HttpHeaders.ParseSingleRawHeaderValue(name, info);
					}
					else
					{
						HttpHeaders.ParseMultipleRawHeaderValues(name, info, list);
					}
					info.RawValue = null;
					if (info.InvalidValue == null && info.ParsedValue == null)
					{
						if (removeEmptyHeader)
						{
							this.headerStore.Remove(name);
						}
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x060022F3 RID: 8947 RVA: 0x0007B2DC File Offset: 0x000794DC
		private static void ParseMultipleRawHeaderValues(string name, HttpHeaders.HeaderStoreItemInfo info, List<string> rawValues)
		{
			if (info.Parser == null)
			{
				using (List<string>.Enumerator enumerator = rawValues.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						string value = enumerator.Current;
						if (!HttpHeaders.ContainsInvalidNewLine(value, name))
						{
							HttpHeaders.AddValue(info, value, HttpHeaders.StoreLocation.Parsed);
						}
					}
					return;
				}
			}
			foreach (string text in rawValues)
			{
				if (!HttpHeaders.TryParseAndAddRawHeaderValue(name, info, text, true) && Logging.On)
				{
					Logging.PrintWarning(Logging.Http, string.Format(CultureInfo.InvariantCulture, SR.net_http_log_headers_invalid_value, new object[]
					{
						name,
						text
					}));
				}
			}
		}

		// Token: 0x060022F4 RID: 8948 RVA: 0x0007B3CC File Offset: 0x000795CC
		private static void ParseSingleRawHeaderValue(string name, HttpHeaders.HeaderStoreItemInfo info)
		{
			string text = info.RawValue as string;
			if (info.Parser == null)
			{
				if (!HttpHeaders.ContainsInvalidNewLine(text, name))
				{
					info.ParsedValue = info.RawValue;
					return;
				}
			}
			else if (!HttpHeaders.TryParseAndAddRawHeaderValue(name, info, text, true) && Logging.On)
			{
				Logging.PrintWarning(Logging.Http, string.Format(CultureInfo.InvariantCulture, SR.net_http_log_headers_invalid_value, new object[]
				{
					name,
					text
				}));
			}
		}

		// Token: 0x060022F5 RID: 8949 RVA: 0x0007B450 File Offset: 0x00079650
		internal bool TryParseAndAddValue(string name, string value)
		{
			HttpHeaders.HeaderStoreItemInfo headerStoreItemInfo;
			bool flag;
			this.PrepareHeaderInfoForAdd(name, out headerStoreItemInfo, out flag);
			bool flag2 = HttpHeaders.TryParseAndAddRawHeaderValue(name, headerStoreItemInfo, value, false);
			if (flag2 && flag && headerStoreItemInfo.ParsedValue != null)
			{
				this.AddHeaderToStore(name, headerStoreItemInfo);
			}
			return flag2;
		}

		// Token: 0x060022F6 RID: 8950 RVA: 0x0007B498 File Offset: 0x00079698
		private static bool TryParseAndAddRawHeaderValue(string name, HttpHeaders.HeaderStoreItemInfo info, string value, bool addWhenInvalid)
		{
			if (!info.CanAddValue)
			{
				if (addWhenInvalid)
				{
					HttpHeaders.AddValue(info, value ?? string.Empty, HttpHeaders.StoreLocation.Invalid);
				}
				return false;
			}
			int i = 0;
			object obj = null;
			if (!info.Parser.TryParseValue(value, info.ParsedValue, ref i, out obj))
			{
				if (!HttpHeaders.ContainsInvalidNewLine(value, name) && addWhenInvalid)
				{
					HttpHeaders.AddValue(info, value ?? string.Empty, HttpHeaders.StoreLocation.Invalid);
				}
				return false;
			}
			if (value == null || i == value.Length)
			{
				if (obj != null)
				{
					HttpHeaders.AddValue(info, obj, HttpHeaders.StoreLocation.Parsed);
				}
				return true;
			}
			List<object> list = new List<object>();
			if (obj != null)
			{
				list.Add(obj);
			}
			while (i < value.Length)
			{
				if (!info.Parser.TryParseValue(value, info.ParsedValue, ref i, out obj))
				{
					if (!HttpHeaders.ContainsInvalidNewLine(value, name) && addWhenInvalid)
					{
						HttpHeaders.AddValue(info, value, HttpHeaders.StoreLocation.Invalid);
					}
					return false;
				}
				if (obj != null)
				{
					list.Add(obj);
				}
			}
			foreach (object value2 in list)
			{
				HttpHeaders.AddValue(info, value2, HttpHeaders.StoreLocation.Parsed);
			}
			return true;
		}

		// Token: 0x060022F7 RID: 8951 RVA: 0x0007B5EC File Offset: 0x000797EC
		private static void AddValue(HttpHeaders.HeaderStoreItemInfo info, object value, HttpHeaders.StoreLocation location)
		{
			object obj = null;
			switch (location)
			{
			case HttpHeaders.StoreLocation.Raw:
				obj = info.RawValue;
				HttpHeaders.AddValueToStoreValue<string>(info, value, ref obj);
				info.RawValue = obj;
				return;
			case HttpHeaders.StoreLocation.Invalid:
				obj = info.InvalidValue;
				HttpHeaders.AddValueToStoreValue<string>(info, value, ref obj);
				info.InvalidValue = obj;
				return;
			case HttpHeaders.StoreLocation.Parsed:
				obj = info.ParsedValue;
				HttpHeaders.AddValueToStoreValue<object>(info, value, ref obj);
				info.ParsedValue = obj;
				return;
			default:
				return;
			}
		}

		// Token: 0x060022F8 RID: 8952 RVA: 0x0007B65C File Offset: 0x0007985C
		private static void AddValueToStoreValue<T>(HttpHeaders.HeaderStoreItemInfo info, object value, ref object currentStoreValue) where T : class
		{
			if (currentStoreValue == null)
			{
				currentStoreValue = value;
				return;
			}
			List<T> list = currentStoreValue as List<T>;
			if (list == null)
			{
				list = new List<T>(2);
				list.Add(currentStoreValue as T);
				currentStoreValue = list;
			}
			list.Add(value as T);
		}

		// Token: 0x060022F9 RID: 8953 RVA: 0x0007B6B4 File Offset: 0x000798B4
		internal object GetParsedValues(string name)
		{
			HttpHeaders.HeaderStoreItemInfo headerStoreItemInfo = null;
			if (!this.TryGetAndParseHeaderInfo(name, out headerStoreItemInfo))
			{
				return null;
			}
			return headerStoreItemInfo.ParsedValue;
		}

		// Token: 0x060022FA RID: 8954 RVA: 0x0007B6E0 File Offset: 0x000798E0
		private void PrepareHeaderInfoForAdd(string name, out HttpHeaders.HeaderStoreItemInfo info, out bool addToStore)
		{
			info = null;
			addToStore = false;
			if (!this.TryGetAndParseHeaderInfo(name, out info))
			{
				info = new HttpHeaders.HeaderStoreItemInfo(this.GetParser(name));
				addToStore = true;
			}
		}

		// Token: 0x060022FB RID: 8955 RVA: 0x0007B708 File Offset: 0x00079908
		private void ParseAndAddValue(string name, HttpHeaders.HeaderStoreItemInfo info, string value)
		{
			if (info.Parser == null)
			{
				HttpHeaders.CheckInvalidNewLine(value);
				HttpHeaders.AddValue(info, value ?? string.Empty, HttpHeaders.StoreLocation.Parsed);
				return;
			}
			if (!info.CanAddValue)
			{
				throw new FormatException(string.Format(CultureInfo.InvariantCulture, SR.net_http_headers_single_value_header, new object[]
				{
					name
				}));
			}
			int i = 0;
			object obj = info.Parser.ParseValue(value, info.ParsedValue, ref i);
			if (value == null || i == value.Length)
			{
				if (obj != null)
				{
					HttpHeaders.AddValue(info, obj, HttpHeaders.StoreLocation.Parsed);
				}
				return;
			}
			List<object> list = new List<object>();
			if (obj != null)
			{
				list.Add(obj);
			}
			while (i < value.Length)
			{
				obj = info.Parser.ParseValue(value, info.ParsedValue, ref i);
				if (obj != null)
				{
					list.Add(obj);
				}
			}
			foreach (object value2 in list)
			{
				HttpHeaders.AddValue(info, value2, HttpHeaders.StoreLocation.Parsed);
			}
		}

		// Token: 0x060022FC RID: 8956 RVA: 0x0007B830 File Offset: 0x00079A30
		private HttpHeaderParser GetParser(string name)
		{
			if (this.parserStore == null)
			{
				return null;
			}
			HttpHeaderParser result = null;
			if (this.parserStore.TryGetValue(name, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x060022FD RID: 8957 RVA: 0x0007B868 File Offset: 0x00079A68
		private void CheckHeaderName(string name)
		{
			if (string.IsNullOrEmpty(name))
			{
				throw new ArgumentException(SR.net_http_argument_empty_string, "name");
			}
			if (HttpRuleParser.GetTokenLength(name, 0) != name.Length)
			{
				throw new FormatException(SR.net_http_headers_invalid_header_name);
			}
			if (this.invalidHeaders != null && this.invalidHeaders.Contains(name))
			{
				throw new InvalidOperationException(SR.net_http_headers_not_allowed_header_name);
			}
		}

		// Token: 0x060022FE RID: 8958 RVA: 0x0007B8D8 File Offset: 0x00079AD8
		private bool TryCheckHeaderName(string name)
		{
			return !string.IsNullOrEmpty(name) && HttpRuleParser.GetTokenLength(name, 0) == name.Length && (this.invalidHeaders == null || !this.invalidHeaders.Contains(name));
		}

		// Token: 0x060022FF RID: 8959 RVA: 0x0007B92C File Offset: 0x00079B2C
		private static void CheckInvalidNewLine(string value)
		{
			if (value == null)
			{
				return;
			}
			if (HttpRuleParser.ContainsInvalidNewLine(value))
			{
				throw new FormatException(SR.net_http_headers_no_newlines);
			}
		}

		// Token: 0x06002300 RID: 8960 RVA: 0x0007B94C File Offset: 0x00079B4C
		private static bool ContainsInvalidNewLine(string value, string name)
		{
			if (HttpRuleParser.ContainsInvalidNewLine(value))
			{
				if (Logging.On)
				{
					Logging.PrintError(Logging.Http, string.Format(CultureInfo.InvariantCulture, SR.net_http_log_headers_no_newlines, new object[]
					{
						name,
						value
					}));
				}
				return true;
			}
			return false;
		}

		// Token: 0x06002301 RID: 8961 RVA: 0x0007B9A0 File Offset: 0x00079BA0
		private static string[] GetValuesAsStrings(HttpHeaders.HeaderStoreItemInfo info)
		{
			return HttpHeaders.GetValuesAsStrings(info, null);
		}

		// Token: 0x06002302 RID: 8962 RVA: 0x0007B9AC File Offset: 0x00079BAC
		private static string[] GetValuesAsStrings(HttpHeaders.HeaderStoreItemInfo info, object exclude)
		{
			int valueCount = HttpHeaders.GetValueCount(info);
			string[] array = new string[valueCount];
			if (valueCount > 0)
			{
				int num = 0;
				HttpHeaders.ReadStoreValues<string>(array, info.RawValue, null, null, ref num);
				HttpHeaders.ReadStoreValues<object>(array, info.ParsedValue, info.Parser, exclude, ref num);
				HttpHeaders.ReadStoreValues<string>(array, info.InvalidValue, null, null, ref num);
				if (num < valueCount)
				{
					string[] array2 = new string[num];
					Array.Copy(array, array2, num);
					array = array2;
				}
			}
			return array;
		}

		// Token: 0x06002303 RID: 8963 RVA: 0x0007BA24 File Offset: 0x00079C24
		private static int GetValueCount(HttpHeaders.HeaderStoreItemInfo info)
		{
			int result = 0;
			HttpHeaders.UpdateValueCount<string>(info.RawValue, ref result);
			HttpHeaders.UpdateValueCount<string>(info.InvalidValue, ref result);
			HttpHeaders.UpdateValueCount<object>(info.ParsedValue, ref result);
			return result;
		}

		// Token: 0x06002304 RID: 8964 RVA: 0x0007BA60 File Offset: 0x00079C60
		private static void UpdateValueCount<T>(object valueStore, ref int valueCount)
		{
			if (valueStore == null)
			{
				return;
			}
			List<T> list = valueStore as List<T>;
			if (list != null)
			{
				valueCount += list.Count;
				return;
			}
			valueCount++;
		}

		// Token: 0x06002305 RID: 8965 RVA: 0x0007BA98 File Offset: 0x00079C98
		private static void ReadStoreValues<T>(string[] values, object storeValue, HttpHeaderParser parser, T exclude, ref int currentIndex)
		{
			if (storeValue != null)
			{
				List<T> list = storeValue as List<T>;
				if (list == null)
				{
					if (HttpHeaders.ShouldAdd<T>(storeValue, parser, exclude))
					{
						values[currentIndex] = ((parser == null) ? storeValue.ToString() : parser.ToString(storeValue));
						currentIndex++;
						return;
					}
				}
				else
				{
					foreach (T t in list)
					{
						object obj = t;
						if (HttpHeaders.ShouldAdd<T>(obj, parser, exclude))
						{
							values[currentIndex] = ((parser == null) ? obj.ToString() : parser.ToString(obj));
							currentIndex++;
						}
					}
				}
			}
		}

		// Token: 0x06002306 RID: 8966 RVA: 0x0007BB60 File Offset: 0x00079D60
		private static bool ShouldAdd<T>(object storeValue, HttpHeaderParser parser, T exclude)
		{
			bool result = true;
			if (parser != null && exclude != null)
			{
				if (parser.Comparer != null)
				{
					result = !parser.Comparer.Equals(exclude, storeValue);
				}
				else
				{
					result = !exclude.Equals(storeValue);
				}
			}
			return result;
		}

		// Token: 0x06002307 RID: 8967 RVA: 0x0007BBC0 File Offset: 0x00079DC0
		private bool AreEqual(object value, object storeValue, IEqualityComparer comparer)
		{
			if (comparer != null)
			{
				return comparer.Equals(value, storeValue);
			}
			return value.Equals(storeValue);
		}

		// Token: 0x04001039 RID: 4153
		private Dictionary<string, HttpHeaders.HeaderStoreItemInfo> headerStore;

		// Token: 0x0400103A RID: 4154
		private Dictionary<string, HttpHeaderParser> parserStore;

		// Token: 0x0400103B RID: 4155
		private HashSet<string> invalidHeaders;

		// Token: 0x020003C1 RID: 961
		private enum StoreLocation
		{
			// Token: 0x040013D6 RID: 5078
			Raw,
			// Token: 0x040013D7 RID: 5079
			Invalid,
			// Token: 0x040013D8 RID: 5080
			Parsed
		}

		// Token: 0x020003C2 RID: 962
		private class HeaderStoreItemInfo
		{
			// Token: 0x17000B29 RID: 2857
			// (get) Token: 0x06002851 RID: 10321 RVA: 0x0008DB08 File Offset: 0x0008BD08
			// (set) Token: 0x06002852 RID: 10322 RVA: 0x0008DB10 File Offset: 0x0008BD10
			internal object RawValue
			{
				get
				{
					return this.rawValue;
				}
				set
				{
					this.rawValue = value;
				}
			}

			// Token: 0x17000B2A RID: 2858
			// (get) Token: 0x06002853 RID: 10323 RVA: 0x0008DB1C File Offset: 0x0008BD1C
			// (set) Token: 0x06002854 RID: 10324 RVA: 0x0008DB24 File Offset: 0x0008BD24
			internal object InvalidValue
			{
				get
				{
					return this.invalidValue;
				}
				set
				{
					this.invalidValue = value;
				}
			}

			// Token: 0x17000B2B RID: 2859
			// (get) Token: 0x06002855 RID: 10325 RVA: 0x0008DB30 File Offset: 0x0008BD30
			// (set) Token: 0x06002856 RID: 10326 RVA: 0x0008DB38 File Offset: 0x0008BD38
			internal object ParsedValue
			{
				get
				{
					return this.parsedValue;
				}
				set
				{
					this.parsedValue = value;
				}
			}

			// Token: 0x17000B2C RID: 2860
			// (get) Token: 0x06002857 RID: 10327 RVA: 0x0008DB44 File Offset: 0x0008BD44
			internal HttpHeaderParser Parser
			{
				get
				{
					return this.parser;
				}
			}

			// Token: 0x17000B2D RID: 2861
			// (get) Token: 0x06002858 RID: 10328 RVA: 0x0008DB4C File Offset: 0x0008BD4C
			internal bool CanAddValue
			{
				get
				{
					return this.parser.SupportsMultipleValues || (this.invalidValue == null && this.parsedValue == null);
				}
			}

			// Token: 0x17000B2E RID: 2862
			// (get) Token: 0x06002859 RID: 10329 RVA: 0x0008DB78 File Offset: 0x0008BD78
			internal bool IsEmpty
			{
				get
				{
					return this.rawValue == null && this.invalidValue == null && this.parsedValue == null;
				}
			}

			// Token: 0x0600285A RID: 10330 RVA: 0x0008DB9C File Offset: 0x0008BD9C
			internal HeaderStoreItemInfo(HttpHeaderParser parser)
			{
				this.parser = parser;
			}

			// Token: 0x040013D9 RID: 5081
			private object rawValue;

			// Token: 0x040013DA RID: 5082
			private object invalidValue;

			// Token: 0x040013DB RID: 5083
			private object parsedValue;

			// Token: 0x040013DC RID: 5084
			private HttpHeaderParser parser;
		}
	}
}
