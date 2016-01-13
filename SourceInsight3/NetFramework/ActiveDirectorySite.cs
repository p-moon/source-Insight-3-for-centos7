public class ActiveDirectorySite : System.IDisposable
{

	// Constructors
	public ActiveDirectorySite(DirectoryContext context, string siteName) {}

	// Methods
	public static ActiveDirectorySite FindByName(DirectoryContext context, string siteName) {}
	public static ActiveDirectorySite GetComputerSite() {}
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
	public DomainCollection Domains { get{} }
	public ActiveDirectorySubnetCollection Subnets { get{} }
	public ReadOnlyDirectoryServerCollection Servers { get{} }
	public ReadOnlySiteCollection AdjacentSites { get{} }
	public ReadOnlySiteLinkCollection SiteLinks { get{} }
	public DirectoryServer InterSiteTopologyGenerator { get{} set{} }
	public ActiveDirectorySiteOptions Options { get{} set{} }
	public string Location { get{} set{} }
	public ReadOnlyDirectoryServerCollection BridgeheadServers { get{} }
	public DirectoryServerCollection PreferredSmtpBridgeheadServers { get{} }
	public DirectoryServerCollection PreferredRpcBridgeheadServers { get{} }
	public ActiveDirectorySchedule IntraSiteReplicationSchedule { get{} set{} }
}

