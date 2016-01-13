public class EventWaitHandle : WaitHandle, System.IDisposable
{

	// Constructors
	public EventWaitHandle(bool initialState, EventResetMode mode) {}
	public EventWaitHandle(bool initialState, EventResetMode mode, string name) {}
	public EventWaitHandle(bool initialState, EventResetMode mode, string nameout , System.Boolean& createdNew) {}
	public EventWaitHandle(bool initialState, EventResetMode mode, string nameout , System.Boolean& createdNew, System.Security.AccessControl.EventWaitHandleSecurity eventSecurity) {}

	// Methods
	public bool Set() {}
	public static EventWaitHandle OpenExisting(string name) {}
	public static EventWaitHandle OpenExisting(string name, System.Security.AccessControl.EventWaitHandleRights rights) {}
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

