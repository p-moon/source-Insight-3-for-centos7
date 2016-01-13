public class DefaultTraceListener : TraceListener, System.IDisposable
{

	// Constructors
	public DefaultTraceListener() {}

	// Methods
	public virtual void Fail(string message) {}
	public virtual void Fail(string message, string detailMessage) {}
	public virtual void Write(string message) {}
	public virtual void WriteLine(string message) {}
	public virtual void Dispose() {}
	public virtual void Close() {}
	public virtual void Flush() {}
	public virtual void Write(object o) {}
	public virtual void Write(string message, string category) {}
	public virtual void Write(object o, string category) {}
	public virtual void WriteLine(object o) {}
	public virtual void WriteLine(string message, string category) {}
	public virtual void WriteLine(object o, string category) {}
	public virtual void TraceData(TraceEventCache eventCache, string source, TraceEventType eventType, int id, object data) {}
	public virtual void TraceData(TraceEventCache eventCache, string source, TraceEventType eventType, int id, object[] data) {}
	public virtual void TraceEvent(TraceEventCache eventCache, string source, TraceEventType eventType, int id) {}
	public virtual void TraceEvent(TraceEventCache eventCache, string source, TraceEventType eventType, int id, string message) {}
	public virtual void TraceEvent(TraceEventCache eventCache, string source, TraceEventType eventType, int id, string format, object[] args) {}
	public virtual void TraceTransfer(TraceEventCache eventCache, string source, int id, string message, System.Guid relatedActivityId) {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool AssertUiEnabled { get{} set{} }
	public string LogFileName { get{} set{} }
	public System.Collections.Specialized.StringDictionary Attributes { get{} }
	public string Name { get{} set{} }
	public bool IsThreadSafe { get{} }
	public int IndentLevel { get{} set{} }
	public int IndentSize { get{} set{} }
	public TraceFilter Filter { get{} set{} }
	public TraceOptions TraceOutputOptions { get{} set{} }
}

