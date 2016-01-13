public class ManualResetEvent : EventWaitHandle, System.IDisposable
{

	// Constructors
	public ManualResetEvent(bool initialState) {}

	// Methods
	public bool Set() {}
	public bool Reset() {}
	public System.Security.AccessControl.EventWaitHandleSecurity GetAccessControl() {}
	public void SetAccessControl(System.Security.AccessControl.EventWaitHandleSecurity eventSecurity) {}
	public virtual bool WaitOne(int millisecondsTimeout, bool exitContext) {}
	public virtual bool WaitOne(System.TimeSpan timeout, bool exitContext) {}
	public virtual bool WaitOne() {}
	public virtual void Close() {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.IntPtr Handle { get{} set{} }
	public Microsoft.Win32.SafeHandles.SafeWaitHandle SafeWaitHandle { get{} set{} }
}

