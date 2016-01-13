public class Semaphore : WaitHandle, System.IDisposable
{

	// Constructors
	public Semaphore(int initialCount, int maximumCount) {}
	public Semaphore(int initialCount, int maximumCount, string name) {}
	public Semaphore(int initialCount, int maximumCount, string nameout , System.Boolean& createdNew) {}
	public Semaphore(int initialCount, int maximumCount, string nameout , System.Boolean& createdNew, System.Security.AccessControl.SemaphoreSecurity semaphoreSecurity) {}

	// Methods
	public static Semaphore OpenExisting(string name) {}
	public static Semaphore OpenExisting(string name, System.Security.AccessControl.SemaphoreRights rights) {}
	public int Release() {}
	public int Release(int releaseCount) {}
	public System.Security.AccessControl.SemaphoreSecurity GetAccessControl() {}
	public void SetAccessControl(System.Security.AccessControl.SemaphoreSecurity semaphoreSecurity) {}
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

