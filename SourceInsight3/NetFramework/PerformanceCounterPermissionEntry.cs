public class PerformanceCounterPermissionEntry
{

	// Constructors
	public PerformanceCounterPermissionEntry(PerformanceCounterPermissionAccess permissionAccess, string machineName, string categoryName) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string CategoryName { get{} }
	public string MachineName { get{} }
	public PerformanceCounterPermissionAccess PermissionAccess { get{} }
}

