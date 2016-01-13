public class TraceContextRecord
{

	// Constructors
	public TraceContextRecord(string category, string msg, bool isWarning, System.Exception errorInfo) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Category { get{} }
	public System.Exception ErrorInfo { get{} }
	public string Message { get{} }
	public bool IsWarning { get{} }
}

