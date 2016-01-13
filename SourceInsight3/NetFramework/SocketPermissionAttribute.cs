public class SocketPermissionAttribute : System.Security.Permissions.CodeAccessSecurityAttribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public SocketPermissionAttribute(System.Security.Permissions.SecurityAction action) {}

	// Methods
	public virtual System.Security.IPermission CreatePermission() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public string Access { get{} set{} }
	public string Host { get{} set{} }
	public string Transport { get{} set{} }
	public string Port { get{} set{} }
	public System.Security.Permissions.SecurityAction Action { get{} set{} }
	public bool Unrestricted { get{} set{} }
	public object TypeId { get{} }
}

