using System;
using System.Net.Http.Headers;

namespace System.Net.Http
{
	// Token: 0x0200031D RID: 797
	public class MultipartFormDataContent : MultipartContent
	{
		// Token: 0x0600257F RID: 9599 RVA: 0x00084754 File Offset: 0x00082954
		public MultipartFormDataContent() : base("form-data")
		{
		}

		// Token: 0x06002580 RID: 9600 RVA: 0x00084764 File Offset: 0x00082964
		public MultipartFormDataContent(string boundary) : base("form-data", boundary)
		{
		}

		// Token: 0x06002581 RID: 9601 RVA: 0x00084774 File Offset: 0x00082974
		public override void Add(HttpContent content)
		{
			if (content == null)
			{
				throw new ArgumentNullException("content");
			}
			if (content.Headers.ContentDisposition == null)
			{
				content.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data");
			}
			base.Add(content);
		}

		// Token: 0x06002582 RID: 9602 RVA: 0x000847B4 File Offset: 0x000829B4
		public void Add(HttpContent content, string name)
		{
			if (content == null)
			{
				throw new ArgumentNullException("content");
			}
			if (string.IsNullOrWhiteSpace(name))
			{
				throw new ArgumentException(SR.net_http_argument_empty_string, "name");
			}
			this.AddInternal(content, name, null);
		}

		// Token: 0x06002583 RID: 9603 RVA: 0x000847EC File Offset: 0x000829EC
		public void Add(HttpContent content, string name, string fileName)
		{
			if (content == null)
			{
				throw new ArgumentNullException("content");
			}
			if (string.IsNullOrWhiteSpace(name))
			{
				throw new ArgumentException(SR.net_http_argument_empty_string, "name");
			}
			if (string.IsNullOrWhiteSpace(fileName))
			{
				throw new ArgumentException(SR.net_http_argument_empty_string, "fileName");
			}
			this.AddInternal(content, name, fileName);
		}

		// Token: 0x06002584 RID: 9604 RVA: 0x00084850 File Offset: 0x00082A50
		private void AddInternal(HttpContent content, string name, string fileName)
		{
			if (content.Headers.ContentDisposition == null)
			{
				ContentDispositionHeaderValue contentDispositionHeaderValue = new ContentDispositionHeaderValue("form-data");
				contentDispositionHeaderValue.Name = name;
				contentDispositionHeaderValue.FileName = fileName;
				contentDispositionHeaderValue.FileNameStar = fileName;
				content.Headers.ContentDisposition = contentDispositionHeaderValue;
			}
			base.Add(content);
		}

		// Token: 0x040010F4 RID: 4340
		private const string formData = "form-data";
	}
}
