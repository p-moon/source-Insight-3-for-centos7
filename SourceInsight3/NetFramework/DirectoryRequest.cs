public class DirectoryRequest : DirectoryOperation
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string RequestId { get{} set{} }
	public DirectoryControlCollection Controls { get{} }
}

