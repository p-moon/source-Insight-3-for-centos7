public class ModifyRequest : DirectoryRequest
{

	// Constructors
	public ModifyRequest() {}
	public ModifyRequest(string distinguishedName, DirectoryAttributeModification[] modifications) {}
	public ModifyRequest(string distinguishedName, DirectoryAttributeOperation operation, string attributeName, object[] values) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string DistinguishedName { get{} set{} }
	public DirectoryAttributeModificationCollection Modifications { get{} }
	public string RequestId { get{} set{} }
	public DirectoryControlCollection Controls { get{} }
}

