using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

namespace System.Net
{
	// Token: 0x02000326 RID: 806
	internal static class TimerThread
	{
		// Token: 0x060025D3 RID: 9683 RVA: 0x000860B8 File Offset: 0x000842B8
		static TimerThread()
		{
			TimerThread.s_ThreadEvents = new WaitHandle[]
			{
				TimerThread.s_ThreadShutdownEvent,
				TimerThread.s_ThreadReadyEvent
			};
			AppDomain.CurrentDomain.DomainUnload += TimerThread.OnDomainUnload;
		}

		// Token: 0x060025D4 RID: 9684 RVA: 0x00086140 File Offset: 0x00084340
		internal static TimerThread.Queue CreateQueue(int durationMilliseconds)
		{
			if (durationMilliseconds == -1)
			{
				return new TimerThread.InfiniteTimerQueue();
			}
			if (durationMilliseconds < 0)
			{
				throw new ArgumentOutOfRangeException("durationMilliseconds");
			}
			TimerThread.TimerQueue timerQueue;
			lock (TimerThread.s_NewQueues)
			{
				timerQueue = new TimerThread.TimerQueue(durationMilliseconds);
				WeakReference value = new WeakReference(timerQueue);
				TimerThread.s_NewQueues.AddLast(value);
			}
			return timerQueue;
		}

		// Token: 0x060025D5 RID: 9685 RVA: 0x000861BC File Offset: 0x000843BC
		internal static TimerThread.Queue GetOrCreateQueue(int durationMilliseconds)
		{
			if (durationMilliseconds == -1)
			{
				return new TimerThread.InfiniteTimerQueue();
			}
			if (durationMilliseconds < 0)
			{
				throw new ArgumentOutOfRangeException("durationMilliseconds");
			}
			WeakReference weakReference = (WeakReference)TimerThread.s_QueuesCache[durationMilliseconds];
			TimerThread.TimerQueue timerQueue;
			if (weakReference == null || (timerQueue = (TimerThread.TimerQueue)weakReference.Target) == null)
			{
				lock (TimerThread.s_NewQueues)
				{
					weakReference = (WeakReference)TimerThread.s_QueuesCache[durationMilliseconds];
					if (weakReference == null || (timerQueue = (TimerThread.TimerQueue)weakReference.Target) == null)
					{
						timerQueue = new TimerThread.TimerQueue(durationMilliseconds);
						weakReference = new WeakReference(timerQueue);
						TimerThread.s_NewQueues.AddLast(weakReference);
						TimerThread.s_QueuesCache[durationMilliseconds] = weakReference;
						if (++TimerThread.s_CacheScanIteration % 32 == 0)
						{
							List<int> list = new List<int>();
							foreach (object obj2 in TimerThread.s_QueuesCache)
							{
								DictionaryEntry dictionaryEntry = (DictionaryEntry)obj2;
								if (((WeakReference)dictionaryEntry.Value).Target == null)
								{
									list.Add((int)dictionaryEntry.Key);
								}
							}
							for (int i = 0; i < list.Count; i++)
							{
								TimerThread.s_QueuesCache.Remove(list[i]);
							}
						}
					}
				}
			}
			return timerQueue;
		}

		// Token: 0x060025D6 RID: 9686 RVA: 0x00086384 File Offset: 0x00084584
		private static void Prod()
		{
			TimerThread.s_ThreadReadyEvent.Set();
			if (Interlocked.CompareExchange(ref TimerThread.s_ThreadState, 1, 0) == 0)
			{
				new Thread(new ThreadStart(TimerThread.ThreadProc)).Start();
			}
		}

		// Token: 0x060025D7 RID: 9687 RVA: 0x000863CC File Offset: 0x000845CC
		private static void ThreadProc()
		{
			Thread.CurrentThread.IsBackground = true;
			lock (TimerThread.s_Queues)
			{
				if (Interlocked.CompareExchange(ref TimerThread.s_ThreadState, 1, 1) == 1)
				{
					bool flag2 = true;
					while (flag2)
					{
						try
						{
							TimerThread.s_ThreadReadyEvent.Reset();
							for (;;)
							{
								if (TimerThread.s_NewQueues.Count > 0)
								{
									lock (TimerThread.s_NewQueues)
									{
										for (LinkedListNode<WeakReference> first = TimerThread.s_NewQueues.First; first != null; first = TimerThread.s_NewQueues.First)
										{
											TimerThread.s_NewQueues.Remove(first);
											TimerThread.s_Queues.AddLast(first);
										}
									}
								}
								int tickCount = Environment.TickCount;
								int num = 0;
								bool flag4 = false;
								LinkedListNode<WeakReference> linkedListNode = TimerThread.s_Queues.First;
								while (linkedListNode != null)
								{
									TimerThread.TimerQueue timerQueue = (TimerThread.TimerQueue)linkedListNode.Value.Target;
									if (timerQueue == null)
									{
										LinkedListNode<WeakReference> next = linkedListNode.Next;
										TimerThread.s_Queues.Remove(linkedListNode);
										linkedListNode = next;
									}
									else
									{
										int num2;
										if (timerQueue.Fire(out num2) && (!flag4 || TimerThread.IsTickBetween(tickCount, num, num2)))
										{
											num = num2;
											flag4 = true;
										}
										linkedListNode = linkedListNode.Next;
									}
								}
								int tickCount2 = Environment.TickCount;
								int millisecondsTimeout = (int)(flag4 ? (TimerThread.IsTickBetween(tickCount, num, tickCount2) ? (Math.Min((uint)(num - tickCount2), 2147483632U) + 15U) : 0U) : 30000U);
								int num3 = WaitHandle.WaitAny(TimerThread.s_ThreadEvents, millisecondsTimeout, false);
								if (num3 == 0)
								{
									break;
								}
								if (num3 == 258 && !flag4)
								{
									Interlocked.CompareExchange(ref TimerThread.s_ThreadState, 0, 1);
									if (!TimerThread.s_ThreadReadyEvent.WaitOne(0, false) || Interlocked.CompareExchange(ref TimerThread.s_ThreadState, 1, 0) != 0)
									{
										goto IL_1E1;
									}
								}
							}
							flag2 = false;
							continue;
							IL_1E1:
							flag2 = false;
						}
						catch (Exception ex)
						{
							if (NclUtilities.IsFatal(ex))
							{
								throw;
							}
							if (Logging.On)
							{
								Logging.PrintError(Logging.Web, "TimerThread#" + Thread.CurrentThread.ManagedThreadId.ToString(NumberFormatInfo.InvariantInfo) + "::ThreadProc() - Exception:" + ex.ToString());
							}
							Thread.Sleep(1000);
						}
					}
				}
			}
		}

		// Token: 0x060025D8 RID: 9688 RVA: 0x00086688 File Offset: 0x00084888
		private static void StopTimerThread()
		{
			Interlocked.Exchange(ref TimerThread.s_ThreadState, 2);
			TimerThread.s_ThreadShutdownEvent.Set();
		}

		// Token: 0x060025D9 RID: 9689 RVA: 0x000866A4 File Offset: 0x000848A4
		private static bool IsTickBetween(int start, int end, int comparand)
		{
			return start <= comparand == end <= comparand != start <= end;
		}

		// Token: 0x060025DA RID: 9690 RVA: 0x000866C4 File Offset: 0x000848C4
		private static void OnDomainUnload(object sender, EventArgs e)
		{
			try
			{
				TimerThread.StopTimerThread();
			}
			catch
			{
			}
		}

		// Token: 0x04001160 RID: 4448
		private const int c_ThreadIdleTimeoutMilliseconds = 30000;

		// Token: 0x04001161 RID: 4449
		private const int c_CacheScanPerIterations = 32;

		// Token: 0x04001162 RID: 4450
		private const int c_TickCountResolution = 15;

		// Token: 0x04001163 RID: 4451
		private static LinkedList<WeakReference> s_Queues = new LinkedList<WeakReference>();

		// Token: 0x04001164 RID: 4452
		private static LinkedList<WeakReference> s_NewQueues = new LinkedList<WeakReference>();

		// Token: 0x04001165 RID: 4453
		private static int s_ThreadState = 0;

		// Token: 0x04001166 RID: 4454
		private static AutoResetEvent s_ThreadReadyEvent = new AutoResetEvent(false);

		// Token: 0x04001167 RID: 4455
		private static ManualResetEvent s_ThreadShutdownEvent = new ManualResetEvent(false);

		// Token: 0x04001168 RID: 4456
		private static WaitHandle[] s_ThreadEvents;

		// Token: 0x04001169 RID: 4457
		private static int s_CacheScanIteration;

		// Token: 0x0400116A RID: 4458
		private static Hashtable s_QueuesCache = new Hashtable();

		// Token: 0x020003D2 RID: 978
		internal abstract class Queue
		{
			// Token: 0x06002894 RID: 10388 RVA: 0x0008E9C4 File Offset: 0x0008CBC4
			internal Queue(int durationMilliseconds)
			{
				this.m_DurationMilliseconds = durationMilliseconds;
			}

			// Token: 0x17000B37 RID: 2871
			// (get) Token: 0x06002895 RID: 10389 RVA: 0x0008E9D4 File Offset: 0x0008CBD4
			internal int Duration
			{
				get
				{
					return this.m_DurationMilliseconds;
				}
			}

			// Token: 0x06002896 RID: 10390 RVA: 0x0008E9DC File Offset: 0x0008CBDC
			internal TimerThread.Timer CreateTimer()
			{
				return this.CreateTimer(null, null);
			}

			// Token: 0x06002897 RID: 10391
			internal abstract TimerThread.Timer CreateTimer(TimerThread.Callback callback, object context);

			// Token: 0x04001414 RID: 5140
			private readonly int m_DurationMilliseconds;
		}

		// Token: 0x020003D3 RID: 979
		internal abstract class Timer : IDisposable
		{
			// Token: 0x06002898 RID: 10392 RVA: 0x0008E9E8 File Offset: 0x0008CBE8
			internal Timer(int durationMilliseconds)
			{
				this.m_DurationMilliseconds = durationMilliseconds;
				this.m_StartTimeMilliseconds = Environment.TickCount;
			}

			// Token: 0x17000B38 RID: 2872
			// (get) Token: 0x06002899 RID: 10393 RVA: 0x0008EA04 File Offset: 0x0008CC04
			internal int Duration
			{
				get
				{
					return this.m_DurationMilliseconds;
				}
			}

			// Token: 0x17000B39 RID: 2873
			// (get) Token: 0x0600289A RID: 10394 RVA: 0x0008EA0C File Offset: 0x0008CC0C
			internal int StartTime
			{
				get
				{
					return this.m_StartTimeMilliseconds;
				}
			}

			// Token: 0x17000B3A RID: 2874
			// (get) Token: 0x0600289B RID: 10395 RVA: 0x0008EA14 File Offset: 0x0008CC14
			internal int Expiration
			{
				get
				{
					return this.m_StartTimeMilliseconds + this.m_DurationMilliseconds;
				}
			}

			// Token: 0x17000B3B RID: 2875
			// (get) Token: 0x0600289C RID: 10396 RVA: 0x0008EA24 File Offset: 0x0008CC24
			internal int TimeRemaining
			{
				get
				{
					if (this.HasExpired)
					{
						return 0;
					}
					if (this.Duration == -1)
					{
						return -1;
					}
					int tickCount = Environment.TickCount;
					int num = (int)(TimerThread.IsTickBetween(this.StartTime, this.Expiration, tickCount) ? Math.Min((uint)(this.Expiration - tickCount), 2147483647U) : 0U);
					if (num >= 2)
					{
						return num;
					}
					return num + 1;
				}
			}

			// Token: 0x0600289D RID: 10397
			internal abstract bool Cancel();

			// Token: 0x17000B3C RID: 2876
			// (get) Token: 0x0600289E RID: 10398
			internal abstract bool HasExpired { get; }

			// Token: 0x0600289F RID: 10399 RVA: 0x0008EA94 File Offset: 0x0008CC94
			public void Dispose()
			{
				this.Cancel();
			}

			// Token: 0x04001415 RID: 5141
			private readonly int m_StartTimeMilliseconds;

			// Token: 0x04001416 RID: 5142
			private readonly int m_DurationMilliseconds;
		}

		// Token: 0x020003D4 RID: 980
		// (Invoke) Token: 0x060028A1 RID: 10401
		internal delegate void Callback(TimerThread.Timer timer, int timeNoticed, object context);

		// Token: 0x020003D5 RID: 981
		private enum TimerThreadState
		{
			// Token: 0x04001418 RID: 5144
			Idle,
			// Token: 0x04001419 RID: 5145
			Running,
			// Token: 0x0400141A RID: 5146
			Stopped
		}

		// Token: 0x020003D6 RID: 982
		private class TimerQueue : TimerThread.Queue
		{
			// Token: 0x060028A4 RID: 10404 RVA: 0x0008EAA0 File Offset: 0x0008CCA0
			internal TimerQueue(int durationMilliseconds) : base(durationMilliseconds)
			{
				this.m_Timers = new TimerThread.TimerNode();
				this.m_Timers.Next = this.m_Timers;
				this.m_Timers.Prev = this.m_Timers;
			}

			// Token: 0x060028A5 RID: 10405 RVA: 0x0008EAD8 File Offset: 0x0008CCD8
			internal override TimerThread.Timer CreateTimer(TimerThread.Callback callback, object context)
			{
				TimerThread.TimerNode timerNode = new TimerThread.TimerNode(callback, context, base.Duration, this.m_Timers);
				bool flag = false;
				lock (this.m_Timers)
				{
					if (this.m_Timers.Next == this.m_Timers)
					{
						flag = true;
					}
					timerNode.Next = this.m_Timers;
					timerNode.Prev = this.m_Timers.Prev;
					this.m_Timers.Prev.Next = timerNode;
					this.m_Timers.Prev = timerNode;
				}
				if (flag)
				{
					TimerThread.Prod();
				}
				return timerNode;
			}

			// Token: 0x060028A6 RID: 10406 RVA: 0x0008EB8C File Offset: 0x0008CD8C
			internal bool Fire(out int nextExpiration)
			{
				TimerThread.TimerNode next;
				do
				{
					next = this.m_Timers.Next;
					if (next == this.m_Timers)
					{
						lock (this.m_Timers)
						{
							next = this.m_Timers.Next;
							if (next == this.m_Timers)
							{
								nextExpiration = 0;
								return false;
							}
						}
					}
				}
				while (next.Fire());
				nextExpiration = next.Expiration;
				return true;
			}

			// Token: 0x0400141B RID: 5147
			private readonly TimerThread.TimerNode m_Timers;
		}

		// Token: 0x020003D7 RID: 983
		private class InfiniteTimerQueue : TimerThread.Queue
		{
			// Token: 0x060028A7 RID: 10407 RVA: 0x0008EC1C File Offset: 0x0008CE1C
			internal InfiniteTimerQueue() : base(-1)
			{
			}

			// Token: 0x060028A8 RID: 10408 RVA: 0x0008EC28 File Offset: 0x0008CE28
			internal override TimerThread.Timer CreateTimer(TimerThread.Callback callback, object context)
			{
				return new TimerThread.InfiniteTimer();
			}
		}

		// Token: 0x020003D8 RID: 984
		private class TimerNode : TimerThread.Timer
		{
			// Token: 0x060028A9 RID: 10409 RVA: 0x0008EC30 File Offset: 0x0008CE30
			internal TimerNode(TimerThread.Callback callback, object context, int durationMilliseconds, object queueLock) : base(durationMilliseconds)
			{
				if (callback != null)
				{
					this.m_Callback = callback;
					this.m_Context = context;
				}
				this.m_TimerState = TimerThread.TimerNode.TimerState.Ready;
				this.m_QueueLock = queueLock;
			}

			// Token: 0x060028AA RID: 10410 RVA: 0x0008EC5C File Offset: 0x0008CE5C
			internal TimerNode() : base(0)
			{
				this.m_TimerState = TimerThread.TimerNode.TimerState.Sentinel;
			}

			// Token: 0x17000B3D RID: 2877
			// (get) Token: 0x060028AB RID: 10411 RVA: 0x0008EC6C File Offset: 0x0008CE6C
			internal override bool HasExpired
			{
				get
				{
					return this.m_TimerState == TimerThread.TimerNode.TimerState.Fired;
				}
			}

			// Token: 0x17000B3E RID: 2878
			// (get) Token: 0x060028AC RID: 10412 RVA: 0x0008EC78 File Offset: 0x0008CE78
			// (set) Token: 0x060028AD RID: 10413 RVA: 0x0008EC80 File Offset: 0x0008CE80
			internal TimerThread.TimerNode Next
			{
				get
				{
					return this.next;
				}
				set
				{
					this.next = value;
				}
			}

			// Token: 0x17000B3F RID: 2879
			// (get) Token: 0x060028AE RID: 10414 RVA: 0x0008EC8C File Offset: 0x0008CE8C
			// (set) Token: 0x060028AF RID: 10415 RVA: 0x0008EC94 File Offset: 0x0008CE94
			internal TimerThread.TimerNode Prev
			{
				get
				{
					return this.prev;
				}
				set
				{
					this.prev = value;
				}
			}

			// Token: 0x060028B0 RID: 10416 RVA: 0x0008ECA0 File Offset: 0x0008CEA0
			internal override bool Cancel()
			{
				if (this.m_TimerState == TimerThread.TimerNode.TimerState.Ready)
				{
					lock (this.m_QueueLock)
					{
						if (this.m_TimerState == TimerThread.TimerNode.TimerState.Ready)
						{
							this.Next.Prev = this.Prev;
							this.Prev.Next = this.Next;
							this.Next = null;
							this.Prev = null;
							this.m_Callback = null;
							this.m_Context = null;
							this.m_TimerState = TimerThread.TimerNode.TimerState.Cancelled;
							return true;
						}
					}
					return false;
				}
				return false;
			}

			// Token: 0x060028B1 RID: 10417 RVA: 0x0008ED48 File Offset: 0x0008CF48
			internal bool Fire()
			{
				if (this.m_TimerState != TimerThread.TimerNode.TimerState.Ready)
				{
					return true;
				}
				int tickCount = Environment.TickCount;
				if (TimerThread.IsTickBetween(base.StartTime, base.Expiration, tickCount))
				{
					return false;
				}
				bool flag = false;
				lock (this.m_QueueLock)
				{
					if (this.m_TimerState == TimerThread.TimerNode.TimerState.Ready)
					{
						this.m_TimerState = TimerThread.TimerNode.TimerState.Fired;
						this.Next.Prev = this.Prev;
						this.Prev.Next = this.Next;
						this.Next = null;
						this.Prev = null;
						flag = (this.m_Callback != null);
					}
				}
				if (flag)
				{
					try
					{
						TimerThread.Callback callback = this.m_Callback;
						object context = this.m_Context;
						this.m_Callback = null;
						this.m_Context = null;
						callback(this, tickCount, context);
					}
					catch (Exception ex)
					{
						if (NclUtilities.IsFatal(ex))
						{
							throw;
						}
						if (Logging.On)
						{
							Logging.PrintError(Logging.Web, string.Concat(new object[]
							{
								"TimerThreadTimer#",
								base.StartTime.ToString(NumberFormatInfo.InvariantInfo),
								"::Fire() - ",
								ex
							}));
						}
					}
				}
				return true;
			}

			// Token: 0x0400141C RID: 5148
			private TimerThread.TimerNode.TimerState m_TimerState;

			// Token: 0x0400141D RID: 5149
			private TimerThread.Callback m_Callback;

			// Token: 0x0400141E RID: 5150
			private object m_Context;

			// Token: 0x0400141F RID: 5151
			private object m_QueueLock;

			// Token: 0x04001420 RID: 5152
			private TimerThread.TimerNode next;

			// Token: 0x04001421 RID: 5153
			private TimerThread.TimerNode prev;

			// Token: 0x020003E4 RID: 996
			private enum TimerState
			{
				// Token: 0x04001442 RID: 5186
				Ready,
				// Token: 0x04001443 RID: 5187
				Fired,
				// Token: 0x04001444 RID: 5188
				Cancelled,
				// Token: 0x04001445 RID: 5189
				Sentinel
			}
		}

		// Token: 0x020003D9 RID: 985
		private class InfiniteTimer : TimerThread.Timer
		{
			// Token: 0x060028B2 RID: 10418 RVA: 0x0008EEB0 File Offset: 0x0008D0B0
			internal InfiniteTimer() : base(-1)
			{
			}

			// Token: 0x17000B40 RID: 2880
			// (get) Token: 0x060028B3 RID: 10419 RVA: 0x0008EEBC File Offset: 0x0008D0BC
			internal override bool HasExpired
			{
				get
				{
					return false;
				}
			}

			// Token: 0x060028B4 RID: 10420 RVA: 0x0008EEC0 File Offset: 0x0008D0C0
			internal override bool Cancel()
			{
				return Interlocked.Exchange(ref this.cancelled, 1) == 0;
			}

			// Token: 0x04001422 RID: 5154
			private int cancelled;
		}
	}
}
