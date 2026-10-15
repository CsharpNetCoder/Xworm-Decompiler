using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace System.Net.Http
{
	// Token: 0x0200031C RID: 796
	public class MultipartContent : HttpContent, IEnumerable<HttpContent>, IEnumerable
	{
		// Token: 0x0600256C RID: 9580 RVA: 0x00083F40 File Offset: 0x00082140
		public MultipartContent() : this("mixed", MultipartContent.GetDefaultBoundary())
		{
		}

		// Token: 0x0600256D RID: 9581 RVA: 0x00083F54 File Offset: 0x00082154
		public MultipartContent(string subtype) : this(subtype, MultipartContent.GetDefaultBoundary())
		{
		}

		// Token: 0x0600256E RID: 9582 RVA: 0x00083F64 File Offset: 0x00082164
		public MultipartContent(string subtype, string boundary)
		{
			if (string.IsNullOrWhiteSpace(subtype))
			{
				throw new ArgumentException(SR.net_http_argument_empty_string, "subtype");
			}
			MultipartContent.ValidateBoundary(boundary);
			this.boundary = boundary;
			string text = boundary;
			if (!text.StartsWith("\"", StringComparison.Ordinal))
			{
				text = "\"" + text + "\"";
			}
			MediaTypeHeaderValue mediaTypeHeaderValue = new MediaTypeHeaderValue("multipart/" + subtype);
			mediaTypeHeaderValue.Parameters.Add(new NameValueHeaderValue("boundary", text));
			base.Headers.ContentType = mediaTypeHeaderValue;
			this.nestedContent = new List<HttpContent>();
		}

		// Token: 0x0600256F RID: 9583 RVA: 0x00084008 File Offset: 0x00082208
		private static void ValidateBoundary(string boundary)
		{
			if (string.IsNullOrWhiteSpace(boundary))
			{
				throw new ArgumentException(SR.net_http_argument_empty_string, "boundary");
			}
			if (boundary.Length > 70)
			{
				throw new ArgumentOutOfRangeException("boundary", boundary, string.Format(CultureInfo.InvariantCulture, SR.net_http_content_field_too_long, new object[]
				{
					70
				}));
			}
			if (boundary.EndsWith(" ", StringComparison.Ordinal))
			{
				throw new ArgumentException(string.Format(CultureInfo.InvariantCulture, SR.net_http_headers_invalid_value, new object[]
				{
					boundary
				}), "boundary");
			}
			string text = "'()+_,-./:=? ";
			foreach (char c in boundary)
			{
				if (('0' > c || c > '9') && ('a' > c || c > 'z') && ('A' > c || c > 'Z') && text.IndexOf(c) < 0)
				{
					throw new ArgumentException(string.Format(CultureInfo.InvariantCulture, SR.net_http_headers_invalid_value, new object[]
					{
						boundary
					}), "boundary");
				}
			}
		}

		// Token: 0x06002570 RID: 9584 RVA: 0x00084140 File Offset: 0x00082340
		private static string GetDefaultBoundary()
		{
			return Guid.NewGuid().ToString();
		}

		// Token: 0x06002571 RID: 9585 RVA: 0x00084164 File Offset: 0x00082364
		public virtual void Add(HttpContent content)
		{
			if (content == null)
			{
				throw new ArgumentNullException("content");
			}
			this.nestedContent.Add(content);
		}

		// Token: 0x06002572 RID: 9586 RVA: 0x00084184 File Offset: 0x00082384
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				foreach (HttpContent httpContent in this.nestedContent)
				{
					httpContent.Dispose();
				}
				this.nestedContent.Clear();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06002573 RID: 9587 RVA: 0x000841F4 File Offset: 0x000823F4
		public IEnumerator<HttpContent> GetEnumerator()
		{
			return this.nestedContent.GetEnumerator();
		}

		// Token: 0x06002574 RID: 9588 RVA: 0x00084208 File Offset: 0x00082408
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.nestedContent.GetEnumerator();
		}

		// Token: 0x06002575 RID: 9589 RVA: 0x0008421C File Offset: 0x0008241C
		protected override Task SerializeToStreamAsync(Stream stream, TransportContext context)
		{
			TaskCompletionSource<object> taskCompletionSource = new TaskCompletionSource<object>();
			this.tcs = taskCompletionSource;
			this.outputStream = stream;
			this.nextContentIndex = 0;
			MultipartContent.EncodeStringToStreamAsync(this.outputStream, "--" + this.boundary + "\r\n").ContinueWithStandard(new Action<Task>(this.WriteNextContentHeadersAsync));
			return taskCompletionSource.Task;
		}

		// Token: 0x06002576 RID: 9590 RVA: 0x00084280 File Offset: 0x00082480
		private void WriteNextContentHeadersAsync(Task task)
		{
			if (task.IsFaulted)
			{
				this.HandleAsyncException("WriteNextContentHeadersAsync", task.Exception.GetBaseException());
				return;
			}
			try
			{
				if (this.nextContentIndex >= this.nestedContent.Count)
				{
					this.WriteTerminatingBoundaryAsync();
				}
				else
				{
					string value = "\r\n--" + this.boundary + "\r\n";
					StringBuilder stringBuilder = new StringBuilder();
					if (this.nextContentIndex != 0)
					{
						stringBuilder.Append(value);
					}
					HttpContent httpContent = this.nestedContent[this.nextContentIndex];
					foreach (KeyValuePair<string, IEnumerable<string>> keyValuePair in httpContent.Headers)
					{
						stringBuilder.Append(keyValuePair.Key + ": " + string.Join(", ", keyValuePair.Value) + "\r\n");
					}
					stringBuilder.Append("\r\n");
					MultipartContent.EncodeStringToStreamAsync(this.outputStream, stringBuilder.ToString()).ContinueWithStandard(new Action<Task>(this.WriteNextContentAsync));
				}
			}
			catch (Exception ex)
			{
				this.HandleAsyncException("WriteNextContentHeadersAsync", ex);
			}
		}

		// Token: 0x06002577 RID: 9591 RVA: 0x000843D8 File Offset: 0x000825D8
		private void WriteNextContentAsync(Task task)
		{
			if (task.IsFaulted)
			{
				this.HandleAsyncException("WriteNextContentAsync", task.Exception.GetBaseException());
				return;
			}
			try
			{
				HttpContent httpContent = this.nestedContent[this.nextContentIndex];
				this.nextContentIndex++;
				httpContent.CopyToAsync(this.outputStream).ContinueWithStandard(new Action<Task>(this.WriteNextContentHeadersAsync));
			}
			catch (Exception ex)
			{
				this.HandleAsyncException("WriteNextContentAsync", ex);
			}
		}

		// Token: 0x06002578 RID: 9592 RVA: 0x0008446C File Offset: 0x0008266C
		private void WriteTerminatingBoundaryAsync()
		{
			try
			{
				MultipartContent.EncodeStringToStreamAsync(this.outputStream, "\r\n--" + this.boundary + "--\r\n").ContinueWithStandard(delegate(Task task)
				{
					if (task.IsFaulted)
					{
						this.HandleAsyncException("WriteTerminatingBoundaryAsync", task.Exception.GetBaseException());
						return;
					}
					TaskCompletionSource<object> taskCompletionSource = this.CleanupAsync();
					taskCompletionSource.TrySetResult(null);
				});
			}
			catch (Exception ex)
			{
				this.HandleAsyncException("WriteTerminatingBoundaryAsync", ex);
			}
		}

		// Token: 0x06002579 RID: 9593 RVA: 0x000844DC File Offset: 0x000826DC
		private static Task EncodeStringToStreamAsync(Stream stream, string input)
		{
			byte[] bytes = HttpRuleParser.DefaultHttpEncoding.GetBytes(input);
			return Task.Factory.FromAsync<byte[], int, int>(new Func<byte[], int, int, AsyncCallback, object, IAsyncResult>(stream.BeginWrite), new Action<IAsyncResult>(stream.EndWrite), bytes, 0, bytes.Length, null);
		}

		// Token: 0x0600257A RID: 9594 RVA: 0x00084524 File Offset: 0x00082724
		private TaskCompletionSource<object> CleanupAsync()
		{
			TaskCompletionSource<object> result = this.tcs;
			this.outputStream = null;
			this.nextContentIndex = 0;
			this.tcs = null;
			return result;
		}

		// Token: 0x0600257B RID: 9595 RVA: 0x00084554 File Offset: 0x00082754
		private void HandleAsyncException(string method, Exception ex)
		{
			if (Logging.On)
			{
				Logging.Exception(Logging.Http, this, method, ex);
			}
			TaskCompletionSource<object> taskCompletionSource = this.CleanupAsync();
			taskCompletionSource.TrySetException(ex);
		}

		// Token: 0x0600257C RID: 9596 RVA: 0x0008458C File Offset: 0x0008278C
		protected internal override bool TryComputeLength(out long length)
		{
			long num = 0L;
			long num2 = (long)MultipartContent.GetEncodedLength("\r\n--" + this.boundary + "\r\n");
			num += (long)MultipartContent.GetEncodedLength("--" + this.boundary + "\r\n");
			bool flag = true;
			foreach (HttpContent httpContent in this.nestedContent)
			{
				if (flag)
				{
					flag = false;
				}
				else
				{
					num += num2;
				}
				foreach (KeyValuePair<string, IEnumerable<string>> keyValuePair in httpContent.Headers)
				{
					num += (long)MultipartContent.GetEncodedLength(keyValuePair.Key + ": " + string.Join(", ", keyValuePair.Value) + "\r\n");
				}
				num += (long)"\r\n".Length;
				long num3 = 0L;
				if (!httpContent.TryComputeLength(out num3))
				{
					length = 0L;
					return false;
				}
				num += num3;
			}
			num += (long)MultipartContent.GetEncodedLength("\r\n--" + this.boundary + "--\r\n");
			length = num;
			return true;
		}

		// Token: 0x0600257D RID: 9597 RVA: 0x00084700 File Offset: 0x00082900
		private static int GetEncodedLength(string input)
		{
			return HttpRuleParser.DefaultHttpEncoding.GetByteCount(input);
		}

		// Token: 0x040010EE RID: 4334
		private const string crlf = "\r\n";

		// Token: 0x040010EF RID: 4335
		private List<HttpContent> nestedContent;

		// Token: 0x040010F0 RID: 4336
		private string boundary;

		// Token: 0x040010F1 RID: 4337
		private int nextContentIndex;

		// Token: 0x040010F2 RID: 4338
		private Stream outputStream;

		// Token: 0x040010F3 RID: 4339
		private TaskCompletionSource<object> tcs;
	}
}
