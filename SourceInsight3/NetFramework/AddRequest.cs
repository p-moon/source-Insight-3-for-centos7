public class AddRequest : DirectoryRequest
{

	// Constructors
	public AddRequest() {}
	public AddRequest(string distinguishedName, DirectoryAttribute[] attributes) {}
	public AddRequest(string distinguishedName, string objectClass) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string DistinguishedName { get{} set{} }
	public DirectoryAttributeCollection Attributes { get{} }
	public string RequestId { get{} set{} }
	public DirectoryControlCollection Controls { get{} }
}

