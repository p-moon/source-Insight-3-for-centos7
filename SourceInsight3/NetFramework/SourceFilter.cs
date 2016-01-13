public class SourceFilter : TraceFilter
{

	// Constructors
	public SourceFilter(string source) {}

	// Methods
	public virtual bool ShouldTrace(TraceEventCache cache, string source, TraceEventType eventType, int id, string formatOrMessage, object[] args, object data1, object[] data) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Source { get{} set{} }
}

