public class CompareRequest : DirectoryRequest
{

	// Constructors
	public CompareRequest() {}
	public CompareRequest(string distinguishedName, string attributeName, string value) {}
	public CompareRequest(string distinguishedName, string attributeName, byte[] value) {}
	public CompareRequest(string distinguishedName, string attributeName, System.Uri value) {}
	public CompareRequest(string distinguishedName, DirectoryAttribute assertion) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string DistinguishedName { get{} set{} }
	public DirectoryAttribute Assertion { get{} }
	public string RequestId { get{} set{} }
	public DirectoryControlCollection Controls { get{} }
}

