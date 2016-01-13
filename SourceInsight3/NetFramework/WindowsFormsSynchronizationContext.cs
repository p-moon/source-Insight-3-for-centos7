public class WindowsFormsSynchronizationContext : System.Threading.SynchronizationContext, System.IDisposable
{

	// Constructors
	public WindowsFormsSynchronizationContext() {}

	// Methods
	public virtual void Dispose() {}
	public virtual void Send(System.Threading.SendOrPostCallback d, object state) {}
	public virtual void Post(System.Threading.SendOrPostCallback d, object state) {}
	public virtual System.Threading.SynchronizationContext CreateCopy() {}
	public static void Uninstall() {}
	public virtual int Wait(System.IntPtr[] waitHandles, bool waitAll, int millisecondsTimeout) {}
	public bool IsWaitNotificationRequired() {}
	public virtual void OperationStarted() {}
	public virtual void OperationCompleted() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool AutoInstall { get{} set{} }
}

