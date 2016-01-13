public class ReplicationOperationInformation
{

	// Constructors
	public ReplicationOperationInformation() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.DateTime OperationStartTime { get{} }
	public ReplicationOperation CurrentOperation { get{} }
	public ReplicationOperationCollection PendingOperations { get{} }
}

