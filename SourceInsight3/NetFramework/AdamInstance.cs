public class AdamInstance : DirectoryServer, System.IDisposable
{

	// Methods
	public static AdamInstance GetAdamInstance(DirectoryContext context) {}
	public static AdamInstance FindOne(DirectoryContext context, string partitionName) {}
	public static AdamInstanceCollection FindAll(DirectoryContext context, string partitionName) {}
	public void TransferRoleOwnership(AdamRole role) {}
	public void SeizeRoleOwnership(AdamRole role) {}
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
	public void Save() {}
	public virtual void Dispose() {}
	public virtual string ToString() {}
	public void MoveToAnotherSite(string siteName) {}
	public System.DirectoryServices.DirectoryEntry GetDirectoryEntry() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ConfigurationSet ConfigurationSet { get{} }
	public string HostName { get{} }
	public int LdapPort { get{} }
	public int SslPort { get{} }
	public AdamRoleCollection Roles { get{} }
	public string DefaultPartition { get{} set{} }
	public string IPAddress { get{} }
	public string SiteName { get{} }
	public SyncUpdateCallback SyncFromAllServersCallback { get{} set{} }
	public ReplicationConnectionCollection InboundConnections { get{} }
	public ReplicationConnectionCollection OutboundConnections { get{} }
	public string Name { get{} }
	public ReadOnlyStringCollection Partitions { get{} }
}

