public class ReplicationOperation
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.DateTime TimeEnqueued { get{} }
	public int OperationNumber { get{} }
	public int Priority { get{} }
	public ReplicationOperationType OperationType { get{} }
	public string PartitionName { get{} }
	public string SourceServer { get{} }
}

