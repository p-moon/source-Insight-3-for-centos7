public class Mutex : WaitHandle, System.IDisposable
{

	// Constructors
	public Mutex(bool initiallyOwned, string nameout , System.Boolean& createdNew) {}
	public Mutex(bool initiallyOwned, string nameout , System.Boolean& createdNew, System.Security.AccessControl.MutexSecurity mutexSecurity) {}
	public Mutex(bool initiallyOwned, string name) {}
	public Mutex(bool initiallyOwned) {}
	public Mutex() {}

	// Methods
	public static Mutex OpenExisting(string name) {}
	public static Mutex OpenExisting(string name, System.Security.AccessControl.MutexRights rights) {}
	public void ReleaseMutex() {}
	public System.Security.AccessControl.MutexSecurity GetAccessControl() {}
	public void SetAccessControl(System.Security.AccessControl.MutexSecurity mutexSecurity) {}
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

