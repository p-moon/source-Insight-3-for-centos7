public class ObjectReadyEventArgs : ManagementEventArgs
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ManagementBaseObject NewObject { get{} }
	public object Context { get{} }
}

