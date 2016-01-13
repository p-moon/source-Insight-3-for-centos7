public class SyncFromAllServersErrorInformation
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public SyncFromAllServersErrorCategory ErrorCategory { get{} }
	public int ErrorCode { get{} }
	public string ErrorMessage { get{} }
	public string TargetServer { get{} }
	public string SourceServer { get{} }
}

