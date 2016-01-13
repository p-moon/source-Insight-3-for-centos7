public class ActiveDirectorySiteLinkBridge : System.IDisposable
{

	// Constructors
	public ActiveDirectorySiteLinkBridge(DirectoryContext context, string bridgeName) {}
	public ActiveDirectorySiteLinkBridge(DirectoryContext context, string bridgeName, ActiveDirectoryTransportType transport) {}

	// Methods
	public static ActiveDirectorySiteLinkBridge FindByName(DirectoryContext context, string bridgeName) {}
	public static ActiveDirectorySiteLinkBridge FindByName(DirectoryContext context, string bridgeName, ActiveDirectoryTransportType transport) {}
	public void Save() {}
	public void Delete() {}
	public virtual string ToString() {}
	public System.DirectoryServices.DirectoryEntry GetDirectoryEntry() {}
	public virtual void Dispose() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Name { get{} }
	public ActiveDirectorySiteLinkCollection SiteLinks { get{} }
	public ActiveDirectoryTransportType TransportType { get{} }
}

