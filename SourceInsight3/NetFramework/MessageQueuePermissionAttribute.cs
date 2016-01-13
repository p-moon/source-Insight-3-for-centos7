public class MessageQueuePermissionAttribute : System.Security.Permissions.CodeAccessSecurityAttribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public MessageQueuePermissionAttribute(System.Security.Permissions.SecurityAction action) {}

	// Methods
	public virtual System.Security.IPermission CreatePermission() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public string Category { get{} set{} }
	public string Label { get{} set{} }
	public string MachineName { get{} set{} }
	public string Path { get{} set{} }
	public MessageQueuePermissionAccess PermissionAccess { get{} set{} }
	public System.Security.Permissions.SecurityAction Action { get{} set{} }
	public bool Unrestricted { get{} set{} }
	public object TypeId { get{} }
}

