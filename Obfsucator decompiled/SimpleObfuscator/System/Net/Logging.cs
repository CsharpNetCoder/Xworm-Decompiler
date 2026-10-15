using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading;

namespace System.Net
{
	// Token: 0x02000325 RID: 805
	internal class Logging
	{
		// Token: 0x060025A4 RID: 9636 RVA: 0x000850EC File Offset: 0x000832EC
		private Logging()
		{
		}

		// Token: 0x17000ABE RID: 2750
		// (get) Token: 0x060025A5 RID: 9637 RVA: 0x000850F4 File Offset: 0x000832F4
		private static object InternalSyncObject
		{
			get
			{
				if (Logging.s_InternalSyncObject == null)
				{
					object value = new object();
					Interlocked.CompareExchange(ref Logging.s_InternalSyncObject, value, null);
				}
				return Logging.s_InternalSyncObject;
			}
		}

		// Token: 0x17000ABF RID: 2751
		// (get) Token: 0x060025A6 RID: 9638 RVA: 0x00085128 File Offset: 0x00083328
		internal static bool On
		{
			get
			{
				if (!Logging.s_LoggingInitialized)
				{
					Logging.InitializeLogging();
				}
				return Logging.s_LoggingEnabled;
			}
		}

		// Token: 0x060025A7 RID: 9639 RVA: 0x00085144 File Offset: 0x00083344
		internal static bool IsVerbose(TraceSource traceSource)
		{
			return Logging.ValidateSettings(traceSource, TraceEventType.Verbose);
		}

		// Token: 0x17000AC0 RID: 2752
		// (get) Token: 0x060025A8 RID: 9640 RVA: 0x00085150 File Offset: 0x00083350
		internal static TraceSource Web
		{
			get
			{
				if (!Logging.s_LoggingInitialized)
				{
					Logging.InitializeLogging();
				}
				if (!Logging.s_LoggingEnabled)
				{
					return null;
				}
				return Logging.s_WebTraceSource;
			}
		}

		// Token: 0x17000AC1 RID: 2753
		// (get) Token: 0x060025A9 RID: 9641 RVA: 0x00085178 File Offset: 0x00083378
		internal static TraceSource Http
		{
			get
			{
				if (!Logging.s_LoggingInitialized)
				{
					Logging.InitializeLogging();
				}
				if (!Logging.s_LoggingEnabled)
				{
					return null;
				}
				return Logging.s_TraceSourceHttpName;
			}
		}

		// Token: 0x17000AC2 RID: 2754
		// (get) Token: 0x060025AA RID: 9642 RVA: 0x000851A0 File Offset: 0x000833A0
		internal static TraceSource HttpListener
		{
			get
			{
				if (!Logging.s_LoggingInitialized)
				{
					Logging.InitializeLogging();
				}
				if (!Logging.s_LoggingEnabled)
				{
					return null;
				}
				return Logging.s_HttpListenerTraceSource;
			}
		}

		// Token: 0x17000AC3 RID: 2755
		// (get) Token: 0x060025AB RID: 9643 RVA: 0x000851C8 File Offset: 0x000833C8
		internal static TraceSource Sockets
		{
			get
			{
				if (!Logging.s_LoggingInitialized)
				{
					Logging.InitializeLogging();
				}
				if (!Logging.s_LoggingEnabled)
				{
					return null;
				}
				return Logging.s_SocketsTraceSource;
			}
		}

		// Token: 0x17000AC4 RID: 2756
		// (get) Token: 0x060025AC RID: 9644 RVA: 0x000851F0 File Offset: 0x000833F0
		internal static TraceSource RequestCache
		{
			get
			{
				if (!Logging.s_LoggingInitialized)
				{
					Logging.InitializeLogging();
				}
				if (!Logging.s_LoggingEnabled)
				{
					return null;
				}
				return Logging.s_CacheTraceSource;
			}
		}

		// Token: 0x17000AC5 RID: 2757
		// (get) Token: 0x060025AD RID: 9645 RVA: 0x00085218 File Offset: 0x00083418
		internal static TraceSource WebSockets
		{
			get
			{
				if (!Logging.s_LoggingInitialized)
				{
					Logging.InitializeLogging();
				}
				if (!Logging.s_LoggingEnabled)
				{
					return null;
				}
				return Logging.s_WebSocketsTraceSource;
			}
		}

		// Token: 0x060025AE RID: 9646 RVA: 0x00085240 File Offset: 0x00083440
		private static bool GetUseProtocolTextSetting(TraceSource traceSource)
		{
			bool result = false;
			if (traceSource.Attributes["tracemode"] == "protocolonly")
			{
				result = true;
			}
			return result;
		}

		// Token: 0x060025AF RID: 9647 RVA: 0x00085278 File Offset: 0x00083478
		private static int GetMaxDumpSizeSetting(TraceSource traceSource)
		{
			int result = 1024;
			if (traceSource.Attributes.ContainsKey("maxdatasize"))
			{
				try
				{
					result = int.Parse(traceSource.Attributes["maxdatasize"], NumberFormatInfo.InvariantInfo);
				}
				catch (Exception ex)
				{
					if (ex is ThreadAbortException || ex is StackOverflowException || ex is OutOfMemoryException)
					{
						throw;
					}
					traceSource.Attributes["maxdatasize"] = result.ToString(NumberFormatInfo.InvariantInfo);
				}
			}
			return result;
		}

		// Token: 0x060025B0 RID: 9648 RVA: 0x00085318 File Offset: 0x00083518
		[SecuritySafeCritical]
		private static void InitializeLogging()
		{
			lock (Logging.InternalSyncObject)
			{
				if (!Logging.s_LoggingInitialized)
				{
					bool flag2 = false;
					if (typeof(Logging).Assembly.IsFullyTrusted)
					{
						Logging.s_WebTraceSource = new Logging.NclTraceSource("System.Net");
						Logging.s_HttpListenerTraceSource = new Logging.NclTraceSource("System.Net.HttpListener");
						Logging.s_SocketsTraceSource = new Logging.NclTraceSource("System.Net.Sockets");
						Logging.s_WebSocketsTraceSource = new Logging.NclTraceSource("System.Net.WebSockets");
						Logging.s_CacheTraceSource = new Logging.NclTraceSource("System.Net.Cache");
						Logging.s_TraceSourceHttpName = new Logging.NclTraceSource("System.Net.Http");
						try
						{
							flag2 = (Logging.s_WebTraceSource.Switch.ShouldTrace(TraceEventType.Critical) || Logging.s_HttpListenerTraceSource.Switch.ShouldTrace(TraceEventType.Critical) || Logging.s_SocketsTraceSource.Switch.ShouldTrace(TraceEventType.Critical) || Logging.s_WebSocketsTraceSource.Switch.ShouldTrace(TraceEventType.Critical) || Logging.s_CacheTraceSource.Switch.ShouldTrace(TraceEventType.Critical) || Logging.s_TraceSourceHttpName.Switch.ShouldTrace(TraceEventType.Critical));
						}
						catch (SecurityException)
						{
							Logging.Close();
							flag2 = false;
						}
					}
					if (flag2)
					{
						AppDomain currentDomain = AppDomain.CurrentDomain;
						currentDomain.UnhandledException += Logging.UnhandledExceptionHandler;
						currentDomain.DomainUnload += Logging.AppDomainUnloadEvent;
						currentDomain.ProcessExit += Logging.ProcessExitEvent;
					}
					Logging.s_LoggingEnabled = flag2;
					Logging.s_LoggingInitialized = true;
				}
			}
		}

		// Token: 0x060025B1 RID: 9649 RVA: 0x000854E0 File Offset: 0x000836E0
		[SecurityCritical]
		private static void Close()
		{
			if (Logging.s_WebTraceSource != null)
			{
				Logging.s_WebTraceSource.Close();
			}
			if (Logging.s_HttpListenerTraceSource != null)
			{
				Logging.s_HttpListenerTraceSource.Close();
			}
			if (Logging.s_SocketsTraceSource != null)
			{
				Logging.s_SocketsTraceSource.Close();
			}
			if (Logging.s_WebSocketsTraceSource != null)
			{
				Logging.s_WebSocketsTraceSource.Close();
			}
			if (Logging.s_CacheTraceSource != null)
			{
				Logging.s_CacheTraceSource.Close();
			}
			if (Logging.s_TraceSourceHttpName != null)
			{
				Logging.s_TraceSourceHttpName.Close();
			}
		}

		// Token: 0x060025B2 RID: 9650 RVA: 0x0008556C File Offset: 0x0008376C
		private static void UnhandledExceptionHandler(object sender, UnhandledExceptionEventArgs args)
		{
			Exception e = (Exception)args.ExceptionObject;
			Logging.Exception(Logging.Web, sender, "UnhandledExceptionHandler", e);
		}

		// Token: 0x060025B3 RID: 9651 RVA: 0x0008559C File Offset: 0x0008379C
		[SecurityCritical]
		private static void ProcessExitEvent(object sender, EventArgs e)
		{
			Logging.Close();
			Logging.s_AppDomainShutdown = true;
		}

		// Token: 0x060025B4 RID: 9652 RVA: 0x000855AC File Offset: 0x000837AC
		[SecurityCritical]
		private static void AppDomainUnloadEvent(object sender, EventArgs e)
		{
			Logging.Close();
			Logging.s_AppDomainShutdown = true;
		}

		// Token: 0x060025B5 RID: 9653 RVA: 0x000855BC File Offset: 0x000837BC
		private static bool ValidateSettings(TraceSource traceSource, TraceEventType traceLevel)
		{
			if (!Logging.s_LoggingEnabled)
			{
				return false;
			}
			if (!Logging.s_LoggingInitialized)
			{
				Logging.InitializeLogging();
			}
			return traceSource != null && traceSource.Switch.ShouldTrace(traceLevel) && !Logging.s_AppDomainShutdown;
		}

		// Token: 0x060025B6 RID: 9654 RVA: 0x00085614 File Offset: 0x00083814
		private static string GetObjectName(object obj)
		{
			if (obj is Uri || obj is IPAddress || obj is IPEndPoint)
			{
				return obj.ToString();
			}
			return obj.GetType().Name;
		}

		// Token: 0x060025B7 RID: 9655
		[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
		internal static extern uint GetCurrentThreadId();

		// Token: 0x060025B8 RID: 9656 RVA: 0x0008564C File Offset: 0x0008384C
		[SecurityCritical]
		internal static uint GetThreadId()
		{
			uint num = Logging.GetCurrentThreadId();
			if (num == 0U)
			{
				num = (uint)Thread.CurrentThread.GetHashCode();
			}
			return num;
		}

		// Token: 0x060025B9 RID: 9657 RVA: 0x00085678 File Offset: 0x00083878
		[SecuritySafeCritical]
		internal static void PrintLine(TraceSource traceSource, TraceEventType eventType, int id, string msg)
		{
			string str = "[" + Logging.GetThreadId().ToString("d4", CultureInfo.InvariantCulture) + "] ";
			traceSource.TraceEvent(eventType, id, str + msg);
		}

		// Token: 0x060025BA RID: 9658 RVA: 0x000856C0 File Offset: 0x000838C0
		internal static void Associate(TraceSource traceSource, object objA, object objB)
		{
			if (!Logging.ValidateSettings(traceSource, TraceEventType.Information))
			{
				return;
			}
			string str = Logging.GetObjectName(objA) + "#" + ValidationHelper.HashString(objA);
			string str2 = Logging.GetObjectName(objB) + "#" + ValidationHelper.HashString(objB);
			Logging.PrintLine(traceSource, TraceEventType.Information, 0, "Associating " + str + " with " + str2);
		}

		// Token: 0x060025BB RID: 9659 RVA: 0x00085728 File Offset: 0x00083928
		internal static void Enter(TraceSource traceSource, object obj, string method, string param)
		{
			if (!Logging.ValidateSettings(traceSource, TraceEventType.Information))
			{
				return;
			}
			Logging.Enter(traceSource, Logging.GetObjectName(obj) + "#" + ValidationHelper.HashString(obj), method, param);
		}

		// Token: 0x060025BC RID: 9660 RVA: 0x00085758 File Offset: 0x00083958
		internal static void Enter(TraceSource traceSource, object obj, string method, object paramObject)
		{
			if (!Logging.ValidateSettings(traceSource, TraceEventType.Information))
			{
				return;
			}
			Logging.Enter(traceSource, Logging.GetObjectName(obj) + "#" + ValidationHelper.HashString(obj), method, paramObject);
		}

		// Token: 0x060025BD RID: 9661 RVA: 0x00085788 File Offset: 0x00083988
		internal static void Enter(TraceSource traceSource, string obj, string method, string param)
		{
			if (!Logging.ValidateSettings(traceSource, TraceEventType.Information))
			{
				return;
			}
			Logging.Enter(traceSource, string.Concat(new string[]
			{
				obj,
				"::",
				method,
				"(",
				param,
				")"
			}));
		}

		// Token: 0x060025BE RID: 9662 RVA: 0x000857F8 File Offset: 0x000839F8
		internal static void Enter(TraceSource traceSource, string obj, string method, object paramObject)
		{
			if (!Logging.ValidateSettings(traceSource, TraceEventType.Information))
			{
				return;
			}
			string text = "";
			if (paramObject != null)
			{
				text = Logging.GetObjectName(paramObject) + "#" + ValidationHelper.HashString(paramObject);
			}
			Logging.Enter(traceSource, string.Concat(new string[]
			{
				obj,
				"::",
				method,
				"(",
				text,
				")"
			}));
		}

		// Token: 0x060025BF RID: 9663 RVA: 0x00085888 File Offset: 0x00083A88
		internal static void Enter(TraceSource traceSource, string method, string parameters)
		{
			if (!Logging.ValidateSettings(traceSource, TraceEventType.Information))
			{
				return;
			}
			Logging.Enter(traceSource, method + "(" + parameters + ")");
		}

		// Token: 0x060025C0 RID: 9664 RVA: 0x000858B0 File Offset: 0x00083AB0
		internal static void Enter(TraceSource traceSource, string msg)
		{
			if (!Logging.ValidateSettings(traceSource, TraceEventType.Information))
			{
				return;
			}
			Logging.PrintLine(traceSource, TraceEventType.Verbose, 0, msg);
		}

		// Token: 0x060025C1 RID: 9665 RVA: 0x000858CC File Offset: 0x00083ACC
		internal static void Exit(TraceSource traceSource, object obj, string method, object retObject)
		{
			if (!Logging.ValidateSettings(traceSource, TraceEventType.Information))
			{
				return;
			}
			string retValue = "";
			if (retObject != null)
			{
				retValue = Logging.GetObjectName(retObject) + "#" + ValidationHelper.HashString(retObject);
			}
			Logging.Exit(traceSource, obj, method, retValue);
		}

		// Token: 0x060025C2 RID: 9666 RVA: 0x00085918 File Offset: 0x00083B18
		internal static void Exit(TraceSource traceSource, string obj, string method, object retObject)
		{
			if (!Logging.ValidateSettings(traceSource, TraceEventType.Information))
			{
				return;
			}
			string retValue = "";
			if (retObject != null)
			{
				retValue = Logging.GetObjectName(retObject) + "#" + ValidationHelper.HashString(retObject);
			}
			Logging.Exit(traceSource, obj, method, retValue);
		}

		// Token: 0x060025C3 RID: 9667 RVA: 0x00085964 File Offset: 0x00083B64
		internal static void Exit(TraceSource traceSource, object obj, string method, string retValue)
		{
			if (!Logging.ValidateSettings(traceSource, TraceEventType.Information))
			{
				return;
			}
			Logging.Exit(traceSource, Logging.GetObjectName(obj) + "#" + ValidationHelper.HashString(obj), method, retValue);
		}

		// Token: 0x060025C4 RID: 9668 RVA: 0x00085994 File Offset: 0x00083B94
		internal static void Exit(TraceSource traceSource, string obj, string method, string retValue)
		{
			if (!Logging.ValidateSettings(traceSource, TraceEventType.Information))
			{
				return;
			}
			if (!ValidationHelper.IsBlankString(retValue))
			{
				retValue = "\t-> " + retValue;
			}
			Logging.Exit(traceSource, string.Concat(new string[]
			{
				obj,
				"::",
				method,
				"() ",
				retValue
			}));
		}

		// Token: 0x060025C5 RID: 9669 RVA: 0x00085A10 File Offset: 0x00083C10
		internal static void Exit(TraceSource traceSource, string method, string parameters)
		{
			if (!Logging.ValidateSettings(traceSource, TraceEventType.Information))
			{
				return;
			}
			Logging.Exit(traceSource, method + "() " + parameters);
		}

		// Token: 0x060025C6 RID: 9670 RVA: 0x00085A34 File Offset: 0x00083C34
		internal static void Exit(TraceSource traceSource, string msg)
		{
			if (!Logging.ValidateSettings(traceSource, TraceEventType.Information))
			{
				return;
			}
			Logging.PrintLine(traceSource, TraceEventType.Verbose, 0, "Exiting " + msg);
		}

		// Token: 0x060025C7 RID: 9671 RVA: 0x00085A58 File Offset: 0x00083C58
		internal static void Exception(TraceSource traceSource, object obj, string method, Exception e)
		{
			if (!Logging.ValidateSettings(traceSource, TraceEventType.Error))
			{
				return;
			}
			StringBuilder stringBuilder = new StringBuilder(e.Message);
			if (e is AggregateException)
			{
				AggregateException ex = e as AggregateException;
				ReadOnlyCollection<Exception> innerExceptions = ex.Flatten().InnerExceptions;
				if (innerExceptions.Count > 0)
				{
					string text = string.Join(", ", from innerException in innerExceptions
					select innerException.Message);
					stringBuilder.AppendFormat(CultureInfo.InvariantCulture, " InnerExceptions: {0}", new object[]
					{
						text
					});
				}
			}
			string text2 = string.Format(CultureInfo.InvariantCulture, SysSR.net_log_exception, new object[]
			{
				Logging.GetObjectLogHash(obj),
				method,
				stringBuilder.ToString()
			});
			if (!ValidationHelper.IsBlankString(e.StackTrace))
			{
				text2 = text2 + "\r\n" + e.StackTrace;
			}
			Logging.PrintLine(traceSource, TraceEventType.Error, 0, text2);
		}

		// Token: 0x060025C8 RID: 9672 RVA: 0x00085B60 File Offset: 0x00083D60
		internal static void PrintInfo(TraceSource traceSource, string msg)
		{
			if (!Logging.ValidateSettings(traceSource, TraceEventType.Information))
			{
				return;
			}
			Logging.PrintLine(traceSource, TraceEventType.Information, 0, msg);
		}

		// Token: 0x060025C9 RID: 9673 RVA: 0x00085B78 File Offset: 0x00083D78
		internal static void PrintInfo(TraceSource traceSource, object obj, string msg)
		{
			if (!Logging.ValidateSettings(traceSource, TraceEventType.Information))
			{
				return;
			}
			Logging.PrintLine(traceSource, TraceEventType.Information, 0, string.Concat(new string[]
			{
				Logging.GetObjectName(obj),
				"#",
				ValidationHelper.HashString(obj),
				" - ",
				msg
			}));
		}

		// Token: 0x060025CA RID: 9674 RVA: 0x00085BE8 File Offset: 0x00083DE8
		internal static void PrintInfo(TraceSource traceSource, object obj, string method, string param)
		{
			if (!Logging.ValidateSettings(traceSource, TraceEventType.Information))
			{
				return;
			}
			Logging.PrintLine(traceSource, TraceEventType.Information, 0, string.Concat(new string[]
			{
				Logging.GetObjectName(obj),
				"#",
				ValidationHelper.HashString(obj),
				"::",
				method,
				"(",
				param,
				")"
			}));
		}

		// Token: 0x060025CB RID: 9675 RVA: 0x00085C78 File Offset: 0x00083E78
		internal static void PrintWarning(TraceSource traceSource, string msg)
		{
			if (!Logging.ValidateSettings(traceSource, TraceEventType.Warning))
			{
				return;
			}
			Logging.PrintLine(traceSource, TraceEventType.Warning, 0, msg);
		}

		// Token: 0x060025CC RID: 9676 RVA: 0x00085C90 File Offset: 0x00083E90
		internal static void PrintWarning(TraceSource traceSource, object obj, string method, string msg)
		{
			if (!Logging.ValidateSettings(traceSource, TraceEventType.Warning))
			{
				return;
			}
			Logging.PrintLine(traceSource, TraceEventType.Warning, 0, string.Concat(new string[]
			{
				Logging.GetObjectName(obj),
				"#",
				ValidationHelper.HashString(obj),
				"::",
				method,
				"() - ",
				msg
			}));
		}

		// Token: 0x060025CD RID: 9677 RVA: 0x00085D14 File Offset: 0x00083F14
		internal static void PrintError(TraceSource traceSource, string msg)
		{
			if (!Logging.ValidateSettings(traceSource, TraceEventType.Error))
			{
				return;
			}
			Logging.PrintLine(traceSource, TraceEventType.Error, 0, msg);
		}

		// Token: 0x060025CE RID: 9678 RVA: 0x00085D2C File Offset: 0x00083F2C
		internal static void PrintError(TraceSource traceSource, object obj, string method, string msg)
		{
			if (!Logging.ValidateSettings(traceSource, TraceEventType.Error))
			{
				return;
			}
			Logging.PrintLine(traceSource, TraceEventType.Error, 0, string.Concat(new string[]
			{
				Logging.GetObjectName(obj),
				"#",
				ValidationHelper.HashString(obj),
				"::",
				method,
				"() - ",
				msg
			}));
		}

		// Token: 0x060025CF RID: 9679 RVA: 0x00085DB0 File Offset: 0x00083FB0
		internal static string GetObjectLogHash(object obj)
		{
			return Logging.GetObjectName(obj) + "#" + ValidationHelper.HashString(obj);
		}

		// Token: 0x060025D0 RID: 9680 RVA: 0x00085DC8 File Offset: 0x00083FC8
		internal static void Dump(TraceSource traceSource, object obj, string method, byte[] buffer, int offset, int length)
		{
			if (!Logging.ValidateSettings(traceSource, TraceEventType.Verbose))
			{
				return;
			}
			if (buffer == null)
			{
				Logging.PrintLine(traceSource, TraceEventType.Verbose, 0, "(null)");
				return;
			}
			if (offset > buffer.Length)
			{
				Logging.PrintLine(traceSource, TraceEventType.Verbose, 0, "(offset out of range)");
				return;
			}
			Logging.PrintLine(traceSource, TraceEventType.Verbose, 0, string.Concat(new string[]
			{
				"Data from ",
				Logging.GetObjectName(obj),
				"#",
				ValidationHelper.HashString(obj),
				"::",
				method
			}));
			int maxDumpSizeSetting = Logging.GetMaxDumpSizeSetting(traceSource);
			if (length > maxDumpSizeSetting)
			{
				Logging.PrintLine(traceSource, TraceEventType.Verbose, 0, string.Concat(new string[]
				{
					"(printing ",
					maxDumpSizeSetting.ToString(NumberFormatInfo.InvariantInfo),
					" out of ",
					length.ToString(NumberFormatInfo.InvariantInfo),
					")"
				}));
				length = maxDumpSizeSetting;
			}
			if (length < 0 || length > buffer.Length - offset)
			{
				length = buffer.Length - offset;
			}
			if (Logging.GetUseProtocolTextSetting(traceSource))
			{
				string msg = "<<" + Logging.headerEncoding.GetString(buffer, offset, length) + ">>";
				Logging.PrintLine(traceSource, TraceEventType.Verbose, 0, msg);
				return;
			}
			do
			{
				int num = Math.Min(length, 16);
				string text = string.Format(CultureInfo.CurrentCulture, "{0:X8} : ", new object[]
				{
					offset
				});
				for (int i = 0; i < num; i++)
				{
					text = text + string.Format(CultureInfo.CurrentCulture, "{0:X2}", new object[]
					{
						buffer[offset + i]
					}) + ((i == 7) ? '-' : ' ');
				}
				for (int j = num; j < 16; j++)
				{
					text += "   ";
				}
				text += ": ";
				for (int k = 0; k < num; k++)
				{
					text += (char)((buffer[offset + k] < 32 || buffer[offset + k] > 126) ? 46 : buffer[offset + k]);
				}
				Logging.PrintLine(traceSource, TraceEventType.Verbose, 0, text);
				offset += num;
				length -= num;
			}
			while (length > 0);
		}

		// Token: 0x04001148 RID: 4424
		private const int DefaultMaxDumpSize = 1024;

		// Token: 0x04001149 RID: 4425
		private const bool DefaultUseProtocolTextOnly = false;

		// Token: 0x0400114A RID: 4426
		private const string AttributeNameMaxSize = "maxdatasize";

		// Token: 0x0400114B RID: 4427
		private const string AttributeNameTraceMode = "tracemode";

		// Token: 0x0400114C RID: 4428
		private const string AttributeValueProtocolOnly = "protocolonly";

		// Token: 0x0400114D RID: 4429
		private const string TraceSourceWebName = "System.Net";

		// Token: 0x0400114E RID: 4430
		private const string TraceSourceHttpListenerName = "System.Net.HttpListener";

		// Token: 0x0400114F RID: 4431
		private const string TraceSourceSocketsName = "System.Net.Sockets";

		// Token: 0x04001150 RID: 4432
		private const string TraceSourceWebSocketsName = "System.Net.WebSockets";

		// Token: 0x04001151 RID: 4433
		private const string TraceSourceCacheName = "System.Net.Cache";

		// Token: 0x04001152 RID: 4434
		private const string TraceSourceHttpName = "System.Net.Http";

		// Token: 0x04001153 RID: 4435
		private static volatile bool s_LoggingEnabled = true;

		// Token: 0x04001154 RID: 4436
		private static volatile bool s_LoggingInitialized;

		// Token: 0x04001155 RID: 4437
		private static volatile bool s_AppDomainShutdown;

		// Token: 0x04001156 RID: 4438
		private static readonly string[] SupportedAttributes = new string[]
		{
			"maxdatasize",
			"tracemode"
		};

		// Token: 0x04001157 RID: 4439
		private static TraceSource s_WebTraceSource;

		// Token: 0x04001158 RID: 4440
		private static TraceSource s_HttpListenerTraceSource;

		// Token: 0x04001159 RID: 4441
		private static TraceSource s_SocketsTraceSource;

		// Token: 0x0400115A RID: 4442
		private static TraceSource s_WebSocketsTraceSource;

		// Token: 0x0400115B RID: 4443
		private static TraceSource s_CacheTraceSource;

		// Token: 0x0400115C RID: 4444
		private static TraceSource s_TraceSourceHttpName;

		// Token: 0x0400115D RID: 4445
		private static object s_InternalSyncObject;

		// Token: 0x0400115E RID: 4446
		private static Encoding headerEncoding = Encoding.GetEncoding(28591);

		// Token: 0x020003D1 RID: 977
		private class NclTraceSource : TraceSource
		{
			// Token: 0x06002892 RID: 10386 RVA: 0x0008E9B0 File Offset: 0x0008CBB0
			internal NclTraceSource(string name) : base(name)
			{
			}

			// Token: 0x06002893 RID: 10387 RVA: 0x0008E9BC File Offset: 0x0008CBBC
			protected override string[] GetSupportedAttributes()
			{
				return Logging.SupportedAttributes;
			}
		}
	}
}
