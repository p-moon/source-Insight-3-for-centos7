public class EventSourceCreationData
{

	// Constructors
	public EventSourceCreationData(string source, string logName) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string LogName { get{} set{} }
	public string MachineName { get{} set{} }
	public string Source { get{} set{} }
	public string MessageResourceFile { get{} set{} }
	public string ParameterResourceFile { get{} set{} }
	public string CategoryResourceFile { get{} set{} }
	public int CategoryCount { get{} set{} }
}

