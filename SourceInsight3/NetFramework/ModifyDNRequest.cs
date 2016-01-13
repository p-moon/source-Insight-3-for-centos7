public class ModifyDNRequest : DirectoryRequest
{

	// Constructors
	public ModifyDNRequest() {}
	public ModifyDNRequest(string distinguishedName, string newParentDistinguishedName, string newName) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string DistinguishedName { get{} set{} }
	public string NewParentDistinguishedName { get{} set{} }
	public string NewName { get{} set{} }
	public bool DeleteOldRdn { get{} set{} }
	public string RequestId { get{} set{} }
	public DirectoryControlCollection Controls { get{} }
}

