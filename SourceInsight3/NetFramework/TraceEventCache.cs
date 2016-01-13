public class TraceEventCache
{

	// Constructors
	public TraceEventCache() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Callstack { get{} }
	public System.Collections.Stack LogicalOperationStack { get{} }
	public System.DateTime DateTime { get{} }
	public int ProcessId { get{} }
	public string ThreadId { get{} }
	public long Timestamp { get{} }
}

