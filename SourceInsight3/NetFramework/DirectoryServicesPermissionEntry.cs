public class DirectoryServicesPermissionEntry
{

	// Constructors
	public DirectoryServicesPermissionEntry(DirectoryServicesPermissionAccess permissionAccess, string path) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Path { get{} }
	public DirectoryServicesPermissionAccess PermissionAccess { get{} }
}

