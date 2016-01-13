public class CompletedEventArgs : ManagementEventArgs
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ManagementBaseObject StatusObject { get{} }
	public ManagementStatus Status { get{} }
	public object Context { get{} }
}

