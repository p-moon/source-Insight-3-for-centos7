public class ApplicationPartition : ActiveDirectoryPartition, System.IDisposable
{

	// Constructors
	public ApplicationPartition(DirectoryContext context, string distinguishedName) {}
	public ApplicationPartition(DirectoryContext context, string distinguishedName, string objectClass) {}

	// Methods
	public static ApplicationPartition GetApplicationPartition(DirectoryContext context) {}
	public static ApplicationPartition FindByName(DirectoryContext context, string distinguishedName) {}
	public DirectoryServer FindDirectoryServer() {}
	public DirectoryServer FindDirectoryServer(string siteName) {}
	public DirectoryServer FindDirectoryServer(bool forceRediscovery) {}
	public DirectoryServer FindDirectoryServer(string siteName, bool forceRediscovery) {}
	public ReadOnlyDirectoryServerCollection FindAllDirectoryServers() {}
	public ReadOnlyDirectoryServerCollection FindAllDirectoryServers(string siteName) {}
	public ReadOnlyDirectoryServerCollection FindAllDiscoverableDirectoryServers() {}
	public ReadOnlyDirectoryServerCollection FindAllDiscoverableDirectoryServers(string siteName) {}
	public void Delete() {}
	public void Save() {}
	public virtual System.DirectoryServices.DirectoryEntry GetDirectoryEntry() {}
	public virtual void Dispose() {}
	public virtual string ToString() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public DirectoryServerCollection DirectoryServers { get{} }
	public string SecurityReferenceDomain { get{} set{} }
	public string Name { get{} }
}

