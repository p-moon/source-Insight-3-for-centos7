public class ActiveDirectoryInterSiteTransport : System.IDisposable
{

	// Methods
	public static ActiveDirectoryInterSiteTransport FindByTransportType(DirectoryContext context, ActiveDirectoryTransportType transport) {}
	public void Save() {}
	public System.DirectoryServices.DirectoryEntry GetDirectoryEntry() {}
	public virtual void Dispose() {}
	public virtual string ToString() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ActiveDirectoryTransportType TransportType { get{} }
	public bool IgnoreReplicationSchedule { get{} set{} }
	public bool BridgeAllSiteLinks { get{} set{} }
	public ReadOnlySiteLinkCollection SiteLinks { get{} }
	public ReadOnlySiteLinkBridgeCollection SiteLinkBridges { get{} }
}

