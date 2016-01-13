public class ExternalProjectStartedEventArgs : CustomBuildEventArgs
{

	// Constructors
	public ExternalProjectStartedEventArgs(string message, string helpKeyword, string senderName, string projectFile, string targetNames) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string ProjectFile { get{} }
	public string TargetNames { get{} }
	public System.DateTime Timestamp { get{} }
	public int ThreadId { get{} }
	public string Message { get{} }
	public string HelpKeyword { get{} }
	public string SenderName { get{} }
}

