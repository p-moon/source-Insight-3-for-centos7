public class ReplicationFailure
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string SourceServer { get{} }
	public System.DateTime FirstFailureTime { get{} }
	public int ConsecutiveFailureCount { get{} }
	public int LastErrorCode { get{} }
	public string LastErrorMessage { get{} }
}

