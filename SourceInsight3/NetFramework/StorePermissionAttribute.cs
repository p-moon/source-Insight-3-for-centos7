public class StorePermissionAttribute : CodeAccessSecurityAttribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public StorePermissionAttribute(SecurityAction action) {}

	// Methods
	public virtual System.Security.IPermission CreatePermission() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public StorePermissionFlags Flags { get{} set{} }
	public bool CreateStore { get{} set{} }
	public bool DeleteStore { get{} set{} }
	public bool EnumerateStores { get{} set{} }
	public bool OpenStore { get{} set{} }
	public bool AddToStore { get{} set{} }
	public bool RemoveFromStore { get{} set{} }
	public bool EnumerateCertificates { get{} set{} }
	public SecurityAction Action { get{} set{} }
	public bool Unrestricted { get{} set{} }
	public object TypeId { get{} }
}

