public class KeyContainerPermissionAttribute : CodeAccessSecurityAttribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public KeyContainerPermissionAttribute(SecurityAction action) {}

	// Methods
	public virtual System.Security.IPermission CreatePermission() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public string KeyStore { get{} set{} }
	public string ProviderName { get{} set{} }
	public int ProviderType { get{} set{} }
	public string KeyContainerName { get{} set{} }
	public int KeySpec { get{} set{} }
	public KeyContainerPermissionFlags Flags { get{} set{} }
	public SecurityAction Action { get{} set{} }
	public bool Unrestricted { get{} set{} }
	public object TypeId { get{} }
}

