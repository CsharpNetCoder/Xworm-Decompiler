using System;
using System.Globalization;

namespace System.Net
{
	// Token: 0x02000322 RID: 802
	internal static class ValidationHelper
	{
		// Token: 0x06002598 RID: 9624 RVA: 0x00084E9C File Offset: 0x0008309C
		public static string[] MakeEmptyArrayNull(string[] stringArray)
		{
			if (stringArray == null || stringArray.Length == 0)
			{
				return null;
			}
			return stringArray;
		}

		// Token: 0x06002599 RID: 9625 RVA: 0x00084EB0 File Offset: 0x000830B0
		public static string MakeStringNull(string stringValue)
		{
			if (stringValue == null || stringValue.Length == 0)
			{
				return null;
			}
			return stringValue;
		}

		// Token: 0x0600259A RID: 9626 RVA: 0x00084EC8 File Offset: 0x000830C8
		public static string ExceptionMessage(Exception exception)
		{
			if (exception == null)
			{
				return string.Empty;
			}
			if (exception.InnerException == null)
			{
				return exception.Message;
			}
			return exception.Message + " (" + ValidationHelper.ExceptionMessage(exception.InnerException) + ")";
		}

		// Token: 0x0600259B RID: 9627 RVA: 0x00084F18 File Offset: 0x00083118
		public static string ToString(object objectValue)
		{
			if (objectValue == null)
			{
				return "(null)";
			}
			if (objectValue is string && ((string)objectValue).Length == 0)
			{
				return "(string.empty)";
			}
			if (objectValue is Exception)
			{
				return ValidationHelper.ExceptionMessage(objectValue as Exception);
			}
			if (objectValue is IntPtr)
			{
				return "0x" + ((IntPtr)objectValue).ToString("x");
			}
			return objectValue.ToString();
		}

		// Token: 0x0600259C RID: 9628 RVA: 0x00084F9C File Offset: 0x0008319C
		public static string HashString(object objectValue)
		{
			if (objectValue == null)
			{
				return "(null)";
			}
			if (objectValue is string && ((string)objectValue).Length == 0)
			{
				return "(string.empty)";
			}
			return objectValue.GetHashCode().ToString(NumberFormatInfo.InvariantInfo);
		}

		// Token: 0x0600259D RID: 9629 RVA: 0x00084FF0 File Offset: 0x000831F0
		public static bool IsInvalidHttpString(string stringValue)
		{
			return stringValue.IndexOfAny(ValidationHelper.InvalidParamChars) != -1;
		}

		// Token: 0x0600259E RID: 9630 RVA: 0x00085004 File Offset: 0x00083204
		public static bool IsBlankString(string stringValue)
		{
			return stringValue == null || stringValue.Length == 0;
		}

		// Token: 0x0600259F RID: 9631 RVA: 0x00085018 File Offset: 0x00083218
		public static bool ValidateTcpPort(int port)
		{
			return port >= 0 && port <= 65535;
		}

		// Token: 0x060025A0 RID: 9632 RVA: 0x00085030 File Offset: 0x00083230
		public static bool ValidateRange(int actual, int fromAllowed, int toAllowed)
		{
			return actual >= fromAllowed && actual <= toAllowed;
		}

		// Token: 0x060025A1 RID: 9633 RVA: 0x00085044 File Offset: 0x00083244
		internal static void ValidateSegment(ArraySegment<byte> segment)
		{
			if (segment.Offset < 0 || segment.Count < 0 || segment.Count > segment.Array.Length - segment.Offset)
			{
				throw new ArgumentOutOfRangeException("segment");
			}
		}

		// Token: 0x04001105 RID: 4357
		public static string[] EmptyArray = new string[0];

		// Token: 0x04001106 RID: 4358
		internal static readonly char[] InvalidMethodChars = new char[]
		{
			' ',
			'\r',
			'\n',
			'\t'
		};

		// Token: 0x04001107 RID: 4359
		internal static readonly char[] InvalidParamChars = new char[]
		{
			'(',
			')',
			'<',
			'>',
			'@',
			',',
			';',
			':',
			'\\',
			'"',
			'\'',
			'/',
			'[',
			']',
			'?',
			'=',
			'{',
			'}',
			' ',
			'\t',
			'\r',
			'\n'
		};
	}
}
