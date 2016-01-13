public class SynchronizationContext
{

	// Constructors
	public SynchronizationContext() {}

	// Methods
	public virtual int Wait(System.IntPtr[] waitHandles, bool waitAll, int millisecondsTimeout) {}
	public bool IsWaitNotificationRequired() {}
	public virtual void Send(SendOrPostCallback d, object state) {}
	public virtual void Post(SendOrPostCallback d, object state) {}
	public virtual void OperationStarted() {}
	public virtual void OperationCompleted() {}
	public static void SetSynchronizationContext(SynchronizationContext syncContext) {}
	public virtual SynchronizationContext CreateCopy() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public SynchronizationContext Current { get{} }
}

