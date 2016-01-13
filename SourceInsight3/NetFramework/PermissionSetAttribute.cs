public class PermissionSetAttribute : CodeAccessSecurityAttribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public PermissionSetAttribute(SecurityAction action) {}

	// Methods
	public System.Security.PermissionSet CreatePermissionSet() {}
	public virtual System.Security.IPermission CreatePermission() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public string File { get{} set{} }
	public bool UnicodeEncoded { get{} set{} }
	public string Name { get{} set{} }
	public string XML { get{} set{} }
	public string Hex { get{} set{} }
	public SecurityAction Action { get{} set{} }
	public bool Unrestricted { get{} set{} }
	public object TypeId { get{} }
}

