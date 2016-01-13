public class ReplicationCursor
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string PartitionName { get{} }
	public System.Guid SourceInvocationId { get{} }
	public long UpToDatenessUsn { get{} }
	public string SourceServer { get{} }
	public System.DateTime LastSuccessfulSyncTime { get{} }
}

