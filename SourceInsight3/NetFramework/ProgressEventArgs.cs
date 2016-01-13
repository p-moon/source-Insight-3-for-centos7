public class ProgressEventArgs : ManagementEventArgs
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int UpperBound { get{} }
	public int Current { get{} }
	public string Message { get{} }
	public object Context { get{} }
}

