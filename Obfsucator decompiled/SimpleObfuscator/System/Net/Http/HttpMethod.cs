using System;

namespace System.Net.Http
{
	// Token: 0x02000314 RID: 788
	public class HttpMethod : IEquatable<HttpMethod>
	{
		// Token: 0x17000AA9 RID: 2729
		// (get) Token: 0x06002516 RID: 9494 RVA: 0x00082C4C File Offset: 0x00080E4C
		public static HttpMethod Get
		{
			get
			{
				return HttpMethod.getMethod;
			}
		}

		// Token: 0x17000AAA RID: 2730
		// (get) Token: 0x06002517 RID: 9495 RVA: 0x00082C54 File Offset: 0x00080E54
		public static HttpMethod Put
		{
			get
			{
				return HttpMethod.putMethod;
			}
		}

		// Token: 0x17000AAB RID: 2731
		// (get) Token: 0x06002518 RID: 9496 RVA: 0x00082C5C File Offset: 0x00080E5C
		public static HttpMethod Post
		{
			get
			{
				return HttpMethod.postMethod;
			}
		}

		// Token: 0x17000AAC RID: 2732
		// (get) Token: 0x06002519 RID: 9497 RVA: 0x00082C64 File Offset: 0x00080E64
		public static HttpMethod Delete
		{
			get
			{
				return HttpMethod.deleteMethod;
			}
		}

		// Token: 0x17000AAD RID: 2733
		// (get) Token: 0x0600251A RID: 9498 RVA: 0x00082C6C File Offset: 0x00080E6C
		public static HttpMethod Head
		{
			get
			{
				return HttpMethod.headMethod;
			}
		}

		// Token: 0x17000AAE RID: 2734
		// (get) Token: 0x0600251B RID: 9499 RVA: 0x00082C74 File Offset: 0x00080E74
		public static HttpMethod Options
		{
			get
			{
				return HttpMethod.optionsMethod;
			}
		}

		// Token: 0x17000AAF RID: 2735
		// (get) Token: 0x0600251C RID: 9500 RVA: 0x00082C7C File Offset: 0x00080E7C
		public static HttpMethod Trace
		{
			get
			{
				return HttpMethod.traceMethod;
			}
		}

		// Token: 0x17000AB0 RID: 2736
		// (get) Token: 0x0600251D RID: 9501 RVA: 0x00082C84 File Offset: 0x00080E84
		public string Method
		{
			get
			{
				return this.method;
			}
		}

		// Token: 0x0600251E RID: 9502 RVA: 0x00082C8C File Offset: 0x00080E8C
		public HttpMethod(string method)
		{
			if (string.IsNullOrEmpty(method))
			{
				throw new ArgumentException(SR.net_http_argument_empty_string, "method");
			}
			if (HttpRuleParser.GetTokenLength(method, 0) != method.Length)
			{
				throw new FormatException(SR.net_http_httpmethod_format_error);
			}
			this.method = method;
		}

		// Token: 0x0600251F RID: 9503 RVA: 0x00082CE4 File Offset: 0x00080EE4
		public bool Equals(HttpMethod other)
		{
			return other != null && (object.ReferenceEquals(this.method, other.method) || string.Compare(this.method, other.method, StringComparison.OrdinalIgnoreCase) == 0);
		}

		// Token: 0x06002520 RID: 9504 RVA: 0x00082D1C File Offset: 0x00080F1C
		public override bool Equals(object obj)
		{
			return this.Equals(obj as HttpMethod);
		}

		// Token: 0x06002521 RID: 9505 RVA: 0x00082D2C File Offset: 0x00080F2C
		public override int GetHashCode()
		{
			return this.method.ToUpperInvariant().GetHashCode();
		}

		// Token: 0x06002522 RID: 9506 RVA: 0x00082D40 File Offset: 0x00080F40
		public override string ToString()
		{
			return this.method.ToString();
		}

		// Token: 0x06002523 RID: 9507 RVA: 0x00082D50 File Offset: 0x00080F50
		public static bool operator ==(HttpMethod left, HttpMethod right)
		{
			if (left == null)
			{
				return right == null;
			}
			if (right == null)
			{
				return left == null;
			}
			return left.Equals(right);
		}

		// Token: 0x06002524 RID: 9508 RVA: 0x00082D70 File Offset: 0x00080F70
		public static bool operator !=(HttpMethod left, HttpMethod right)
		{
			return !(left == right);
		}

		// Token: 0x040010C5 RID: 4293
		private string method;

		// Token: 0x040010C6 RID: 4294
		private static readonly HttpMethod getMethod = new HttpMethod("GET");

		// Token: 0x040010C7 RID: 4295
		private static readonly HttpMethod putMethod = new HttpMethod("PUT");

		// Token: 0x040010C8 RID: 4296
		private static readonly HttpMethod postMethod = new HttpMethod("POST");

		// Token: 0x040010C9 RID: 4297
		private static readonly HttpMethod deleteMethod = new HttpMethod("DELETE");

		// Token: 0x040010CA RID: 4298
		private static readonly HttpMethod headMethod = new HttpMethod("HEAD");

		// Token: 0x040010CB RID: 4299
		private static readonly HttpMethod optionsMethod = new HttpMethod("OPTIONS");

		// Token: 0x040010CC RID: 4300
		private static readonly HttpMethod traceMethod = new HttpMethod("TRACE");
	}
}
