public class DsmlAuthRequest : DirectoryRequest
{

	// Constructors
	public DsmlAuthRequest() {}
	public DsmlAuthRequest(string principal) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Principal { get{} set{} }
	public string RequestId { get{} set{} }
	public DirectoryControlCollection Controls { get{} }
}

