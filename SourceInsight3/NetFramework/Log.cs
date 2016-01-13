public class Log
{

	// Constructors
	public Log() {}
	public Log(string name) {}

	// Methods
	public void WriteEntry(string message) {}
	public void WriteEntry(string message, System.Diagnostics.TraceEventType severity) {}
	public void WriteEntry(string message, System.Diagnostics.TraceEventType severity, int id) {}
	public void WriteException(System.Exception ex) {}
	public void WriteException(System.Exception ex, System.Diagnostics.TraceEventType severity, string additionalInfo) {}
	public void WriteException(System.Exception ex, System.Diagnostics.TraceEventType severity, string additionalInfo, int id) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Diagnostics.TraceSource TraceSource { get{} }
	public FileLogTraceListener DefaultFileLogWriter { get{} }
}

