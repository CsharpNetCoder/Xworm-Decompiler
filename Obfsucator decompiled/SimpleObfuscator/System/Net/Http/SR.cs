using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace System.Net.Http
{
	// Token: 0x020002DD RID: 733
	[CompilerGenerated]
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	[DebuggerNonUserCode]
	internal class SR
	{
		// Token: 0x06002190 RID: 8592 RVA: 0x00075BA8 File Offset: 0x00073DA8
		internal SR()
		{
		}

		// Token: 0x170009BA RID: 2490
		// (get) Token: 0x06002191 RID: 8593 RVA: 0x00075BB0 File Offset: 0x00073DB0
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (object.ReferenceEquals(SR.resourceMan, null))
				{
					ResourceManager resourceManager = new ResourceManager("System.Net.Http.SR", typeof(SR).Assembly);
					SR.resourceMan = resourceManager;
				}
				return SR.resourceMan;
			}
		}

		// Token: 0x170009BB RID: 2491
		// (get) Token: 0x06002192 RID: 8594 RVA: 0x00075BF8 File Offset: 0x00073DF8
		// (set) Token: 0x06002193 RID: 8595 RVA: 0x00075C00 File Offset: 0x00073E00
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return SR.resourceCulture;
			}
			set
			{
				SR.resourceCulture = value;
			}
		}

		// Token: 0x170009BC RID: 2492
		// (get) Token: 0x06002194 RID: 8596 RVA: 0x00075C08 File Offset: 0x00073E08
		internal static string net_http_argument_empty_string
		{
			get
			{
				return SR.ResourceManager.GetString("net_http_argument_empty_string", SR.resourceCulture);
			}
		}

		// Token: 0x170009BD RID: 2493
		// (get) Token: 0x06002195 RID: 8597 RVA: 0x00075C20 File Offset: 0x00073E20
		internal static string net_http_client_absolute_baseaddress_required
		{
			get
			{
				return SR.ResourceManager.GetString("net_http_client_absolute_baseaddress_required", SR.resourceCulture);
			}
		}

		// Token: 0x170009BE RID: 2494
		// (get) Token: 0x06002196 RID: 8598 RVA: 0x00075C38 File Offset: 0x00073E38
		internal static string net_http_client_content_headers
		{
			get
			{
				return SR.ResourceManager.GetString("net_http_client_content_headers", SR.resourceCulture);
			}
		}

		// Token: 0x170009BF RID: 2495
		// (get) Token: 0x06002197 RID: 8599 RVA: 0x00075C50 File Offset: 0x00073E50
		internal static string net_http_client_execution_error
		{
			get
			{
				return SR.ResourceManager.GetString("net_http_client_execution_error", SR.resourceCulture);
			}
		}

		// Token: 0x170009C0 RID: 2496
		// (get) Token: 0x06002198 RID: 8600 RVA: 0x00075C68 File Offset: 0x00073E68
		internal static string net_http_client_http_baseaddress_required
		{
			get
			{
				return SR.ResourceManager.GetString("net_http_client_http_baseaddress_required", SR.resourceCulture);
			}
		}

		// Token: 0x170009C1 RID: 2497
		// (get) Token: 0x06002199 RID: 8601 RVA: 0x00075C80 File Offset: 0x00073E80
		internal static string net_http_client_invalid_requesturi
		{
			get
			{
				return SR.ResourceManager.GetString("net_http_client_invalid_requesturi", SR.resourceCulture);
			}
		}

		// Token: 0x170009C2 RID: 2498
		// (get) Token: 0x0600219A RID: 8602 RVA: 0x00075C98 File Offset: 0x00073E98
		internal static string net_http_client_request_already_sent
		{
			get
			{
				return SR.ResourceManager.GetString("net_http_client_request_already_sent", SR.resourceCulture);
			}
		}

		// Token: 0x170009C3 RID: 2499
		// (get) Token: 0x0600219B RID: 8603 RVA: 0x00075CB0 File Offset: 0x00073EB0
		internal static string net_http_client_request_headers
		{
			get
			{
				return SR.ResourceManager.GetString("net_http_client_request_headers", SR.resourceCulture);
			}
		}

		// Token: 0x170009C4 RID: 2500
		// (get) Token: 0x0600219C RID: 8604 RVA: 0x00075CC8 File Offset: 0x00073EC8
		internal static string net_http_client_response_headers
		{
			get
			{
				return SR.ResourceManager.GetString("net_http_client_response_headers", SR.resourceCulture);
			}
		}

		// Token: 0x170009C5 RID: 2501
		// (get) Token: 0x0600219D RID: 8605 RVA: 0x00075CE0 File Offset: 0x00073EE0
		internal static string net_http_client_send_canceled
		{
			get
			{
				return SR.ResourceManager.GetString("net_http_client_send_canceled", SR.resourceCulture);
			}
		}

		// Token: 0x170009C6 RID: 2502
		// (get) Token: 0x0600219E RID: 8606 RVA: 0x00075CF8 File Offset: 0x00073EF8
		internal static string net_http_client_send_completed
		{
			get
			{
				return SR.ResourceManager.GetString("net_http_client_send_completed", SR.resourceCulture);
			}
		}

		// Token: 0x170009C7 RID: 2503
		// (get) Token: 0x0600219F RID: 8607 RVA: 0x00075D10 File Offset: 0x00073F10
		internal static string net_http_client_send_error
		{
			get
			{
				return SR.ResourceManager.GetString("net_http_client_send_error", SR.resourceCulture);
			}
		}

		// Token: 0x170009C8 RID: 2504
		// (get) Token: 0x060021A0 RID: 8608 RVA: 0x00075D28 File Offset: 0x00073F28
		internal static string net_http_content_buffersize_exceeded
		{
			get
			{
				return SR.ResourceManager.GetString("net_http_content_buffersize_exceeded", SR.resourceCulture);
			}
		}

		// Token: 0x170009C9 RID: 2505
		// (get) Token: 0x060021A1 RID: 8609 RVA: 0x00075D40 File Offset: 0x00073F40
		internal static string net_http_content_buffersize_limit
		{
			get
			{
				return SR.ResourceManager.GetString("net_http_content_buffersize_limit", SR.resourceCulture);
			}
		}

		// Token: 0x170009CA RID: 2506
		// (get) Token: 0x060021A2 RID: 8610 RVA: 0x00075D58 File Offset: 0x00073F58
		internal static string net_http_content_encoding_set
		{
			get
			{
				return SR.ResourceManager.GetString("net_http_content_encoding_set", SR.resourceCulture);
			}
		}

		// Token: 0x170009CB RID: 2507
		// (get) Token: 0x060021A3 RID: 8611 RVA: 0x00075D70 File Offset: 0x00073F70
		internal static string net_http_content_field_too_long
		{
			get
			{
				return SR.ResourceManager.GetString("net_http_content_field_too_long", SR.resourceCulture);
			}
		}

		// Token: 0x170009CC RID: 2508
		// (get) Token: 0x060021A4 RID: 8612 RVA: 0x00075D88 File Offset: 0x00073F88
		internal static string net_http_content_invalid_charset
		{
			get
			{
				return SR.ResourceManager.GetString("net_http_content_invalid_charset", SR.resourceCulture);
			}
		}

		// Token: 0x170009CD RID: 2509
		// (get) Token: 0x060021A5 RID: 8613 RVA: 0x00075DA0 File Offset: 0x00073FA0
		internal static string net_http_content_no_task_returned
		{
			get
			{
				return SR.ResourceManager.GetString("net_http_content_no_task_returned", SR.resourceCulture);
			}
		}

		// Token: 0x170009CE RID: 2510
		// (get) Token: 0x060021A6 RID: 8614 RVA: 0x00075DB8 File Offset: 0x00073FB8
		internal static string net_http_content_readonly_stream
		{
			get
			{
				return SR.ResourceManager.GetString("net_http_content_readonly_stream", SR.resourceCulture);
			}
		}

		// Token: 0x170009CF RID: 2511
		// (get) Token: 0x060021A7 RID: 8615 RVA: 0x00075DD0 File Offset: 0x00073FD0
		internal static string net_http_content_stream_already_read
		{
			get
			{
				return SR.ResourceManager.GetString("net_http_content_stream_already_read", SR.resourceCulture);
			}
		}

		// Token: 0x170009D0 RID: 2512
		// (get) Token: 0x060021A8 RID: 8616 RVA: 0x00075DE8 File Offset: 0x00073FE8
		internal static string net_http_content_stream_copy_error
		{
			get
			{
				return SR.ResourceManager.GetString("net_http_content_stream_copy_error", SR.resourceCulture);
			}
		}

		// Token: 0x170009D1 RID: 2513
		// (get) Token: 0x060021A9 RID: 8617 RVA: 0x00075E00 File Offset: 0x00074000
		internal static string net_http_copyto_array_too_small
		{
			get
			{
				return SR.ResourceManager.GetString("net_http_copyto_array_too_small", SR.resourceCulture);
			}
		}

		// Token: 0x170009D2 RID: 2514
		// (get) Token: 0x060021AA RID: 8618 RVA: 0x00075E18 File Offset: 0x00074018
		internal static string net_http_handler_nocontentlength
		{
			get
			{
				return SR.ResourceManager.GetString("net_http_handler_nocontentlength", SR.resourceCulture);
			}
		}

		// Token: 0x170009D3 RID: 2515
		// (get) Token: 0x060021AB RID: 8619 RVA: 0x00075E30 File Offset: 0x00074030
		internal static string net_http_handler_norequest
		{
			get
			{
				return SR.ResourceManager.GetString("net_http_handler_norequest", SR.resourceCulture);
			}
		}

		// Token: 0x170009D4 RID: 2516
		// (get) Token: 0x060021AC RID: 8620 RVA: 0x00075E48 File Offset: 0x00074048
		internal static string net_http_handler_noresponse
		{
			get
			{
				return SR.ResourceManager.GetString("net_http_handler_noresponse", SR.resourceCulture);
			}
		}

		// Token: 0x170009D5 RID: 2517
		// (get) Token: 0x060021AD RID: 8621 RVA: 0x00075E60 File Offset: 0x00074060
		internal static string net_http_handler_not_assigned
		{
			get
			{
				return SR.ResourceManager.GetString("net_http_handler_not_assigned", SR.resourceCulture);
			}
		}

		// Token: 0x170009D6 RID: 2518
		// (get) Token: 0x060021AE RID: 8622 RVA: 0x00075E78 File Offset: 0x00074078
		internal static string net_http_headers_cant_add_any_to_collection
		{
			get
			{
				return SR.ResourceManager.GetString("net_http_headers_cant_add_any_to_collection", SR.resourceCulture);
			}
		}

		// Token: 0x170009D7 RID: 2519
		// (get) Token: 0x060021AF RID: 8623 RVA: 0x00075E90 File Offset: 0x00074090
		internal static string net_http_headers_invalid_etag_name
		{
			get
			{
				return SR.ResourceManager.GetString("net_http_headers_invalid_etag_name", SR.resourceCulture);
			}
		}

		// Token: 0x170009D8 RID: 2520
		// (get) Token: 0x060021B0 RID: 8624 RVA: 0x00075EA8 File Offset: 0x000740A8
		internal static string net_http_headers_invalid_from_header
		{
			get
			{
				return SR.ResourceManager.GetString("net_http_headers_invalid_from_header", SR.resourceCulture);
			}
		}

		// Token: 0x170009D9 RID: 2521
		// (get) Token: 0x060021B1 RID: 8625 RVA: 0x00075EC0 File Offset: 0x000740C0
		internal static string net_http_headers_invalid_header_name
		{
			get
			{
				return SR.ResourceManager.GetString("net_http_headers_invalid_header_name", SR.resourceCulture);
			}
		}

		// Token: 0x170009DA RID: 2522
		// (get) Token: 0x060021B2 RID: 8626 RVA: 0x00075ED8 File Offset: 0x000740D8
		internal static string net_http_headers_invalid_host_header
		{
			get
			{
				return SR.ResourceManager.GetString("net_http_headers_invalid_host_header", SR.resourceCulture);
			}
		}

		// Token: 0x170009DB RID: 2523
		// (get) Token: 0x060021B3 RID: 8627 RVA: 0x00075EF0 File Offset: 0x000740F0
		internal static string net_http_headers_invalid_range
		{
			get
			{
				return SR.ResourceManager.GetString("net_http_headers_invalid_range", SR.resourceCulture);
			}
		}

		// Token: 0x170009DC RID: 2524
		// (get) Token: 0x060021B4 RID: 8628 RVA: 0x00075F08 File Offset: 0x00074108
		internal static string net_http_headers_invalid_value
		{
			get
			{
				return SR.ResourceManager.GetString("net_http_headers_invalid_value", SR.resourceCulture);
			}
		}

		// Token: 0x170009DD RID: 2525
		// (get) Token: 0x060021B5 RID: 8629 RVA: 0x00075F20 File Offset: 0x00074120
		internal static string net_http_headers_no_newlines
		{
			get
			{
				return SR.ResourceManager.GetString("net_http_headers_no_newlines", SR.resourceCulture);
			}
		}

		// Token: 0x170009DE RID: 2526
		// (get) Token: 0x060021B6 RID: 8630 RVA: 0x00075F38 File Offset: 0x00074138
		internal static string net_http_headers_not_allowed_header_name
		{
			get
			{
				return SR.ResourceManager.GetString("net_http_headers_not_allowed_header_name", SR.resourceCulture);
			}
		}

		// Token: 0x170009DF RID: 2527
		// (get) Token: 0x060021B7 RID: 8631 RVA: 0x00075F50 File Offset: 0x00074150
		internal static string net_http_headers_not_found
		{
			get
			{
				return SR.ResourceManager.GetString("net_http_headers_not_found", SR.resourceCulture);
			}
		}

		// Token: 0x170009E0 RID: 2528
		// (get) Token: 0x060021B8 RID: 8632 RVA: 0x00075F68 File Offset: 0x00074168
		internal static string net_http_headers_single_value_header
		{
			get
			{
				return SR.ResourceManager.GetString("net_http_headers_single_value_header", SR.resourceCulture);
			}
		}

		// Token: 0x170009E1 RID: 2529
		// (get) Token: 0x060021B9 RID: 8633 RVA: 0x00075F80 File Offset: 0x00074180
		internal static string net_http_httpmethod_format_error
		{
			get
			{
				return SR.ResourceManager.GetString("net_http_httpmethod_format_error", SR.resourceCulture);
			}
		}

		// Token: 0x170009E2 RID: 2530
		// (get) Token: 0x060021BA RID: 8634 RVA: 0x00075F98 File Offset: 0x00074198
		internal static string net_http_invalid_enable_first
		{
			get
			{
				return SR.ResourceManager.GetString("net_http_invalid_enable_first", SR.resourceCulture);
			}
		}

		// Token: 0x170009E3 RID: 2531
		// (get) Token: 0x060021BB RID: 8635 RVA: 0x00075FB0 File Offset: 0x000741B0
		internal static string net_http_log_content_no_task_returned_copytoasync
		{
			get
			{
				return SR.ResourceManager.GetString("net_http_log_content_no_task_returned_copytoasync", SR.resourceCulture);
			}
		}

		// Token: 0x170009E4 RID: 2532
		// (get) Token: 0x060021BC RID: 8636 RVA: 0x00075FC8 File Offset: 0x000741C8
		internal static string net_http_log_content_null
		{
			get
			{
				return SR.ResourceManager.GetString("net_http_log_content_null", SR.resourceCulture);
			}
		}

		// Token: 0x170009E5 RID: 2533
		// (get) Token: 0x060021BD RID: 8637 RVA: 0x00075FE0 File Offset: 0x000741E0
		internal static string net_http_log_content_offload_async
		{
			get
			{
				return SR.ResourceManager.GetString("net_http_log_content_offload_async", SR.resourceCulture);
			}
		}

		// Token: 0x170009E6 RID: 2534
		// (get) Token: 0x060021BE RID: 8638 RVA: 0x00075FF8 File Offset: 0x000741F8
		internal static string net_http_log_headers_invalid_quality
		{
			get
			{
				return SR.ResourceManager.GetString("net_http_log_headers_invalid_quality", SR.resourceCulture);
			}
		}

		// Token: 0x170009E7 RID: 2535
		// (get) Token: 0x060021BF RID: 8639 RVA: 0x00076010 File Offset: 0x00074210
		internal static string net_http_log_headers_invalid_value
		{
			get
			{
				return SR.ResourceManager.GetString("net_http_log_headers_invalid_value", SR.resourceCulture);
			}
		}

		// Token: 0x170009E8 RID: 2536
		// (get) Token: 0x060021C0 RID: 8640 RVA: 0x00076028 File Offset: 0x00074228
		internal static string net_http_log_headers_no_newlines
		{
			get
			{
				return SR.ResourceManager.GetString("net_http_log_headers_no_newlines", SR.resourceCulture);
			}
		}

		// Token: 0x170009E9 RID: 2537
		// (get) Token: 0x060021C1 RID: 8641 RVA: 0x00076040 File Offset: 0x00074240
		internal static string net_http_log_headers_wrong_email_format
		{
			get
			{
				return SR.ResourceManager.GetString("net_http_log_headers_wrong_email_format", SR.resourceCulture);
			}
		}

		// Token: 0x170009EA RID: 2538
		// (get) Token: 0x060021C2 RID: 8642 RVA: 0x00076058 File Offset: 0x00074258
		internal static string net_http_message_not_success_statuscode
		{
			get
			{
				return SR.ResourceManager.GetString("net_http_message_not_success_statuscode", SR.resourceCulture);
			}
		}

		// Token: 0x170009EB RID: 2539
		// (get) Token: 0x060021C3 RID: 8643 RVA: 0x00076070 File Offset: 0x00074270
		internal static string net_http_operation_started
		{
			get
			{
				return SR.ResourceManager.GetString("net_http_operation_started", SR.resourceCulture);
			}
		}

		// Token: 0x170009EC RID: 2540
		// (get) Token: 0x060021C4 RID: 8644 RVA: 0x00076088 File Offset: 0x00074288
		internal static string net_http_parser_invalid_base64_string
		{
			get
			{
				return SR.ResourceManager.GetString("net_http_parser_invalid_base64_string", SR.resourceCulture);
			}
		}

		// Token: 0x170009ED RID: 2541
		// (get) Token: 0x060021C5 RID: 8645 RVA: 0x000760A0 File Offset: 0x000742A0
		internal static string net_http_parser_invalid_date_format
		{
			get
			{
				return SR.ResourceManager.GetString("net_http_parser_invalid_date_format", SR.resourceCulture);
			}
		}

		// Token: 0x170009EE RID: 2542
		// (get) Token: 0x060021C6 RID: 8646 RVA: 0x000760B8 File Offset: 0x000742B8
		internal static string net_http_read_error
		{
			get
			{
				return SR.ResourceManager.GetString("net_http_read_error", SR.resourceCulture);
			}
		}

		// Token: 0x170009EF RID: 2543
		// (get) Token: 0x060021C7 RID: 8647 RVA: 0x000760D0 File Offset: 0x000742D0
		internal static string net_http_reasonphrase_format_error
		{
			get
			{
				return SR.ResourceManager.GetString("net_http_reasonphrase_format_error", SR.resourceCulture);
			}
		}

		// Token: 0x04000FCC RID: 4044
		private static ResourceManager resourceMan;

		// Token: 0x04000FCD RID: 4045
		private static CultureInfo resourceCulture;
	}
}
