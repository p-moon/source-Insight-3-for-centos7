public class DeleteRequest : DirectoryRequest
{

	// Constructors
	public DeleteRequest() {}
	public DeleteRequest(string distinguishedName) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string DistinguishedName { get{} set{} }
	public string RequestId { get{} set{} }
	public DirectoryControlCollection Controls { get{} }
}

