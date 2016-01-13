public class Logger : Microsoft.Build.Framework.ILogger
{

	// Methods
	public abstract virtual void Initialize(Microsoft.Build.Framework.IEventSource eventSource) {}
	public virtual void Shutdown() {}
	public virtual string FormatErrorEvent(Microsoft.Build.Framework.BuildErrorEventArgs args) {}
	public virtual string FormatWarningEvent(Microsoft.Build.Framework.BuildWarningEventArgs args) {}
	public bool IsVerbosityAtLeast(Microsoft.Build.Framework.LoggerVerbosity checkVerbosity) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public Microsoft.Build.Framework.LoggerVerbosity Verbosity { get{} set{} }
	public string Parameters { get{} set{} }
}

