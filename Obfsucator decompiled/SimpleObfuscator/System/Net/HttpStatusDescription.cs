using System;

namespace System.Net
{
	// Token: 0x020002DF RID: 735
	internal static class HttpStatusDescription
	{
		// Token: 0x060021CD RID: 8653 RVA: 0x00076160 File Offset: 0x00074360
		internal static string Get(HttpStatusCode code)
		{
			return HttpStatusDescription.Get((int)code);
		}

		// Token: 0x060021CE RID: 8654 RVA: 0x00076168 File Offset: 0x00074368
		internal static string Get(int code)
		{
			if (code >= 100 && code < 600)
			{
				int num = code / 100;
				int num2 = code % 100;
				if (num2 < HttpStatusDescription.httpStatusDescriptions[num].Length)
				{
					return HttpStatusDescription.httpStatusDescriptions[num][num2];
				}
			}
			return null;
		}

		// Token: 0x060021CF RID: 8655 RVA: 0x000761BC File Offset: 0x000743BC
		// Note: this type is marked as 'beforefieldinit'.
		static HttpStatusDescription()
		{
			string[][] array = new string[6][];
			array[1] = new string[]
			{
				"Continue",
				"Switching Protocols",
				"Processing"
			};
			array[2] = new string[]
			{
				"OK",
				"Created",
				"Accepted",
				"Non-Authoritative Information",
				"No Content",
				"Reset Content",
				"Partial Content",
				"Multi-Status"
			};
			array[3] = new string[]
			{
				"Multiple Choices",
				"Moved Permanently",
				"Found",
				"See Other",
				"Not Modified",
				"Use Proxy",
				null,
				"Temporary Redirect"
			};
			string[][] array2 = array;
			int num = 4;
			string[] array3 = new string[26];
			array3[0] = "Bad Request";
			array3[1] = "Unauthorized";
			array3[2] = "Payment Required";
			array3[3] = "Forbidden";
			array3[4] = "Not Found";
			array3[5] = "Method Not Allowed";
			array3[6] = "Not Acceptable";
			array3[7] = "Proxy Authentication Required";
			array3[8] = "Request Timeout";
			array3[9] = "Conflict";
			array3[10] = "Gone";
			array3[11] = "Length Required";
			array3[12] = "Precondition Failed";
			array3[13] = "Request Entity Too Large";
			array3[14] = "Request-Uri Too Long";
			array3[15] = "Unsupported Media Type";
			array3[16] = "Requested Range Not Satisfiable";
			array3[17] = "Expectation Failed";
			array3[22] = "Unprocessable Entity";
			array3[23] = "Locked";
			array3[24] = "Failed Dependency";
			array2[num] = array3;
			array[5] = new string[]
			{
				"Internal Server Error",
				"Not Implemented",
				"Bad Gateway",
				"Service Unavailable",
				"Gateway Timeout",
				"Http Version Not Supported",
				null,
				"Insufficient Storage"
			};
			HttpStatusDescription.httpStatusDescriptions = array;
		}

		// Token: 0x04000FD0 RID: 4048
		private static readonly string[][] httpStatusDescriptions;
	}
}
