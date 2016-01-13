public class WaitHandle : System.MarshalByRefObject, System.IDisposable
{

	// Methods
	public virtual bool WaitOne(int millisecondsTimeout, bool exitContext) {}
	public virtual bool WaitOne(System.TimeSpan timeout, bool exitContext) {}
	public virtual bool WaitOne() {}
	public static bool WaitAll(WaitHandle[] waitHandles, int millisecondsTimeout, bool exitContext) {}
	public static bool WaitAll(WaitHandle[] waitHandles, System.TimeSpan timeout, bool exitContext) {}
	public static bool WaitAll(WaitHandle[] waitHandles) {}
	public static int WaitAny(WaitHandle[] waitHandles, int millisecondsTimeout, bool exitContext) {}
	public static int WaitAny(WaitHandle[] waitHandles, System.TimeSpan timeout, bool exitContext) {}
	public static int WaitAny(WaitHandle[] waitHandles) {}
	public static bool SignalAndWait(WaitHandle toSignal, WaitHandle toWaitOn) {}
	public static bool SignalAndWait(WaitHandle toSignal, WaitHandle toWaitOn, System.TimeSpan timeout, bool exitContext) {}
	public static bool SignalAndWait(WaitHandle toSignal, WaitHandle toWaitOn, int millisecondsTimeout, bool exitContext) {}
	public virtual void Close() {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public int WaitTimeout;

	// Properties
	public System.IntPtr Handle { get{} set{} }
	public Microsoft.Win32.SafeHandles.SafeWaitHandle SafeWaitHandle { get{} set{} }
}

