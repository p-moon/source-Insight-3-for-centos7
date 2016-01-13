public class ExtendedRequest : DirectoryRequest
{

	// Constructors
	public ExtendedRequest() {}
	public ExtendedRequest(string requestName) {}
	public ExtendedRequest(string requestName, byte[] requestValue) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string RequestName { get{} set{} }
	public byte[] RequestValue { get{} set{} }
	public string RequestId { get{} set{} }
	public DirectoryControlCollection Controls { get{} }
}

