public class EventLogPermissionEntry
{

	// Constructors
	public EventLogPermissionEntry(EventLogPermissionAccess permissionAccess, string machineName) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string MachineName { get{} }
	public EventLogPermissionAccess PermissionAccess { get{} }
}

