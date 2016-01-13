public class AsyncOperationManager
{

	// Methods
	public static AsyncOperation CreateOperation(object userSuppliedState) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Threading.SynchronizationContext SynchronizationContext { get{} set{} }
}

