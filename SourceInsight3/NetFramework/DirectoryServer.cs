public class DirectoryServer : System.IDisposable
{

	// Methods
	public virtual void Dispose() {}
	public virtual string ToString() {}
	public void MoveToAnotherSite(string siteName) {}
	public System.DirectoryServices.DirectoryEntry GetDirectoryEntry() {}
	public abstract virtual void CheckReplicationConsistency() {}
	public abstract virtual ReplicationCursorCollection GetReplicationCursors(string partition) {}
	public abstract virtual ReplicationOperationInformation GetReplicationOperationInformation() {}
	public abstract virtual ReplicationNeighborCollection GetReplicationNeighbors(string partition) {}
	public abstract virtual ReplicationNeighborCollection GetAllReplicationNeighbors() {}
	public abstract virtual ReplicationFailureCollection GetReplicationConnectionFailures() {}
	public abstract virtual ActiveDirectoryReplicationMetadata GetReplicationMetadata(string objectPath) {}
	public abstract virtual void SyncReplicaFromServer(string partition, string sourceServer) {}
	public abstract virtual void TriggerSyncReplicaFromNeighbors(string partition) {}
	public abstract virtual void SyncReplicaFromAllServers(string partition, SyncFromAllServersOptions options) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Name { get{} }
	public ReadOnlyStringCollection Partitions { get{} }
	public string IPAddress { get{} }
	public string SiteName { get{} }
	public SyncUpdateCallback SyncFromAllServersCallback { get{} set{} }
	public ReplicationConnectionCollection InboundConnections { get{} }
	public ReplicationConnectionCollection OutboundConnections { get{} }
}

