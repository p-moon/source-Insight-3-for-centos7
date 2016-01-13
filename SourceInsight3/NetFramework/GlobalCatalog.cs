public class GlobalCatalog : DomainController, System.IDisposable
{

	// Methods
	public static GlobalCatalog GetGlobalCatalog(DirectoryContext context) {}
	public static GlobalCatalog FindOne(DirectoryContext context) {}
	public static GlobalCatalog FindOne(DirectoryContext context, string siteName) {}
	public static GlobalCatalog FindOne(DirectoryContext context, LocatorOptions flag) {}
	public static GlobalCatalog FindOne(DirectoryContext context, string siteName, LocatorOptions flag) {}
	public static GlobalCatalogCollection FindAll(DirectoryContext context) {}
	public static GlobalCatalogCollection FindAll(DirectoryContext context, string siteName) {}
	public virtual GlobalCatalog EnableGlobalCatalog() {}
	public DomainController DisableGlobalCatalog() {}
	public virtual bool IsGlobalCatalog() {}
	public ReadOnlyActiveDirectorySchemaPropertyCollection FindAllProperties() {}
	public virtual System.DirectoryServices.DirectorySearcher GetDirectorySearcher() {}
	public void TransferRoleOwnership(ActiveDirectoryRole role) {}
	public void SeizeRoleOwnership(ActiveDirectoryRole role) {}
	public virtual void CheckReplicationConsistency() {}
	public virtual ReplicationCursorCollection GetReplicationCursors(string partition) {}
	public virtual ReplicationOperationInformation GetReplicationOperationInformation() {}
	public virtual ReplicationNeighborCollection GetReplicationNeighbors(string partition) {}
	public virtual ReplicationNeighborCollection GetAllReplicationNeighbors() {}
	public virtual ReplicationFailureCollection GetReplicationConnectionFailures() {}
	public virtual ActiveDirectoryReplicationMetadata GetReplicationMetadata(string objectPath) {}
	public virtual void SyncReplicaFromServer(string partition, string sourceServer) {}
	public virtual void TriggerSyncReplicaFromNeighbors(string partition) {}
	public virtual void SyncReplicaFromAllServers(string partition, SyncFromAllServersOptions options) {}
	public virtual void Dispose() {}
	public virtual string ToString() {}
	public void MoveToAnotherSite(string siteName) {}
	public System.DirectoryServices.DirectoryEntry GetDirectoryEntry() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public Forest Forest { get{} }
	public System.DateTime CurrentTime { get{} }
	public long HighestCommittedUsn { get{} }
	public string OSVersion { get{} }
	public ActiveDirectoryRoleCollection Roles { get{} }
	public Domain Domain { get{} }
	public string IPAddress { get{} }
	public string SiteName { get{} }
	public SyncUpdateCallback SyncFromAllServersCallback { get{} set{} }
	public ReplicationConnectionCollection InboundConnections { get{} }
	public ReplicationConnectionCollection OutboundConnections { get{} }
	public string Name { get{} }
	public ReadOnlyStringCollection Partitions { get{} }
}

