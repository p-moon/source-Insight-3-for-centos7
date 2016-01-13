public class ResourcePermissionBaseEntry
{

	// Constructors
	public ResourcePermissionBaseEntry() {}
	public ResourcePermissionBaseEntry(int permissionAccess, string[] permissionAccessPath) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int PermissionAccess { get{} }
	public string[] PermissionAccessPath { get{} }
}

