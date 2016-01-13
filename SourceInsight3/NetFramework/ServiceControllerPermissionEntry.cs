public class ServiceControllerPermissionEntry
{

	// Constructors
	public ServiceControllerPermissionEntry() {}
	public ServiceControllerPermissionEntry(ServiceControllerPermissionAccess permissionAccess, string machineName, string serviceName) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string MachineName { get{} }
	public ServiceControllerPermissionAccess PermissionAccess { get{} }
	public string ServiceName { get{} }
}

