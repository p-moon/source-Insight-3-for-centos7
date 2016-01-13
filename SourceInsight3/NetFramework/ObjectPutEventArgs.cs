public class ObjectPutEventArgs : ManagementEventArgs
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ManagementPath Path { get{} }
	public object Context { get{} }
}

