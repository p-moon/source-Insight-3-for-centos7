public class MessageQueuePermissionEntry
{

	// Constructors
	public MessageQueuePermissionEntry(MessageQueuePermissionAccess permissionAccess, string path) {}
	public MessageQueuePermissionEntry(MessageQueuePermissionAccess permissionAccess, string machineName, string label, string category) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Category { get{} }
	public string Label { get{} }
	public string MachineName { get{} }
	public string Path { get{} }
	public MessageQueuePermissionAccess PermissionAccess { get{} }
}

