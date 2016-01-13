public class FileLogTraceListener : System.Diagnostics.TraceListener, System.IDisposable
{

	// Constructors
	public FileLogTraceListener(string name) {}
	public FileLogTraceListener() {}

	// Methods
	public virtual void Write(string message) {}
	public virtual void WriteLine(string message) {}
	public virtual void TraceEvent(System.Diagnostics.TraceEventCache eventCache, string source, System.Diagnostics.TraceEventType eventType, int id, string message) {}
	public virtual void TraceEvent(System.Diagnostics.TraceEventCache eventCache, string source, System.Diagnostics.TraceEventType eventType, int id, string format, object[] args) {}
	public virtual void TraceData(System.Diagnostics.TraceEventCache eventCache, string source, System.Diagnostics.TraceEventType eventType, int id, object data) {}
	public virtual void TraceData(System.Diagnostics.TraceEventCache eventCache, string source, System.Diagnostics.TraceEventType eventType, int id, object[] data) {}
	public virtual void Flush() {}
	public virtual void Close() {}
	public virtual void Dispose() {}
	public virtual void Fail(string message) {}
	public virtual void Fail(string message, string detailMessage) {}
	public virtual void Write(object o) {}
	public virtual void Write(string message, string category) {}
	public virtual void Write(object o, string category) {}
	public virtual void WriteLine(object o) {}
	public virtual void WriteLine(string message, string category) {}
	public virtual void WriteLine(object o, string category) {}
	public virtual void TraceEvent(System.Diagnostics.TraceEventCache eventCache, string source, System.Diagnostics.TraceEventType eventType, int id) {}
	public virtual void TraceTransfer(System.Diagnostics.TraceEventCache eventCache, string source, int id, string message, System.Guid relatedActivityId) {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public LogFileLocation Location { get{} set{} }
	public bool AutoFlush { get{} set{} }
	public bool IncludeHostName { get{} set{} }
	public bool Append { get{} set{} }
	public DiskSpaceExhaustedOption DiskSpaceExhaustedBehavior { get{} set{} }
	public string BaseFileName { get{} set{} }
	public string FullLogFileName { get{} }
	public LogFileCreationScheduleOption LogFileCreationSchedule { get{} set{} }
	public long MaxFileSize { get{} set{} }
	public long ReserveDiskSpace { get{} set{} }
	public string Delimiter { get{} set{} }
	public System.Text.Encoding Encoding { get{} set{} }
	public string CustomLocation { get{} set{} }
	public System.Collections.Specialized.StringDictionary Attributes { get{} }
	public string Name { get{} set{} }
	public bool IsThreadSafe { get{} }
	public int IndentLevel { get{} set{} }
	public int IndentSize { get{} set{} }
	public System.Diagnostics.TraceFilter Filter { get{} set{} }
	public System.Diagnostics.TraceOptions TraceOutputOptions { get{} set{} }
}

