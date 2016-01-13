public class ThreadPool
{

	// Methods
	public static bool BindHandle(System.IntPtr osHandle) {}
	public static bool SetMaxThreads(int workerThreads, int completionPortThreads) {}
	public static void GetMaxThreads(out System.Int32& workerThreadsout , System.Int32& completionPortThreads) {}
	public static bool SetMinThreads(int workerThreads, int completionPortThreads) {}
	public static void GetMinThreads(out System.Int32& workerThreadsout , System.Int32& completionPortThreads) {}
	public static void GetAvailableThreads(out System.Int32& workerThreadsout , System.Int32& completionPortThreads) {}
	public static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, uint millisecondsTimeOutInterval, bool executeOnlyOnce) {}
	public static RegisteredWaitHandle UnsafeRegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, uint millisecondsTimeOutInterval, bool executeOnlyOnce) {}
	public static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, int millisecondsTimeOutInterval, bool executeOnlyOnce) {}
	public static RegisteredWaitHandle UnsafeRegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, int millisecondsTimeOutInterval, bool executeOnlyOnce) {}
	public static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, long millisecondsTimeOutInterval, bool executeOnlyOnce) {}
	public static RegisteredWaitHandle UnsafeRegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, long millisecondsTimeOutInterval, bool executeOnlyOnce) {}
	public static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, System.TimeSpan timeout, bool executeOnlyOnce) {}
	public static RegisteredWaitHandle UnsafeRegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, System.TimeSpan timeout, bool executeOnlyOnce) {}
	public static bool QueueUserWorkItem(WaitCallback callBack, object state) {}
	public static bool QueueUserWorkItem(WaitCallback callBack) {}
	public static bool UnsafeQueueUserWorkItem(WaitCallback callBack, object state) {}
	public static bool UnsafeQueueNativeOverlapped(NativeOverlapped* overlapped) {}
	public static bool BindHandle(System.Runtime.InteropServices.SafeHandle osHandle) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

