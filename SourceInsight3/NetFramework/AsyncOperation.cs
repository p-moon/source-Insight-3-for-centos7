public class AsyncOperation
{

	// Methods
	public void Post(System.Threading.SendOrPostCallback d, object arg) {}
	public void PostOperationCompleted(System.Threading.SendOrPostCallback d, object arg) {}
	public void OperationCompleted() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public object UserSuppliedState { get{} }
	public System.Threading.SynchronizationContext SynchronizationContext { get{} }
}

