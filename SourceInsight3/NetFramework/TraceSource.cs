public class TraceSource
{

	// Constructors
	public TraceSource(string name) {}
	public TraceSource(string name, SourceLevels defaultLevel) {}

	// Methods
	public void Close() {}
	public void Flush() {}
	public void TraceEvent(TraceEventType eventType, int id) {}
	public void TraceEvent(TraceEventType eventType, int id, string message) {}
	public void TraceEvent(TraceEventType eventType, int id, string format, object[] args) {}
	public void TraceData(TraceEventType eventType, int id, object data) {}
	public void TraceData(TraceEventType eventType, int id, object[] data) {}
	public void TraceInformation(string message) {}
	public void TraceInformation(string format, object[] args) {}
	public void TraceTransfer(int id, string message, System.Guid relatedActivityId) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Collections.Specialized.StringDictionary Attributes { get{} }
	public string Name { get{} }
	public TraceListenerCollection Listeners { get{} }
	public SourceSwitch Switch { get{} set{} }
}

