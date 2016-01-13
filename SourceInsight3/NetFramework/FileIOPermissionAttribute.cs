public class FileIOPermissionAttribute : CodeAccessSecurityAttribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public FileIOPermissionAttribute(SecurityAction action) {}

	// Methods
	public virtual System.Security.IPermission CreatePermission() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public string Read { get{} set{} }
	public string Write { get{} set{} }
	public string Append { get{} set{} }
	public string PathDiscovery { get{} set{} }
	public string ViewAccessControl { get{} set{} }
	public string ChangeAccessControl { get{} set{} }
	public string All { get{} set{} }
	public string ViewAndModify { get{} set{} }
	public FileIOPermissionAccess AllFiles { get{} set{} }
	public FileIOPermissionAccess AllLocalFiles { get{} set{} }
	public SecurityAction Action { get{} set{} }
	public bool Unrestricted { get{} set{} }
	public object TypeId { get{} }
}

