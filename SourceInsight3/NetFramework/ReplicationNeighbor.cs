public class ReplicationNeighbor
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string PartitionName { get{} }
	public string SourceServer { get{} }
	public ActiveDirectoryTransportType TransportType { get{} }
	public ReplicationNeighborOptions ReplicationNeighborOption { get{} }
	public System.Guid SourceInvocationId { get{} }
	public long UsnLastObjectChangeSynced { get{} }
	public long UsnAttributeFilter { get{} }
	public System.DateTime LastSuccessfulSync { get{} }
	public System.DateTime LastAttemptedSync { get{} }
	public int LastSyncResult { get{} }
	public string LastSyncMessage { get{} }
	public int ConsecutiveFailureCount { get{} }
}

