public class TraceContext
{

	// Constructors
	public TraceContext(HttpContext context) {}

	// Methods
	public void Write(string message) {}
	public void Write(string category, string message) {}
	public void Write(string category, string message, System.Exception errorInfo) {}
	public void Warn(string message) {}
	public void Warn(string category, string message) {}
	public void Warn(string category, string message, System.Exception errorInfo) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public TraceMode TraceMode { get{} set{} }
	public bool IsEnabled { get{} set{} }

	// Events
	public event System.Web.TraceContextEventHandler TraceFinished;
}

