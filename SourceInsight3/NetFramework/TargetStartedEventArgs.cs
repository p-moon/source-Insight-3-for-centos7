public class TargetStartedEventArgs : BuildStatusEventArgs
{

	// Constructors
	public TargetStartedEventArgs(string message, string helpKeyword, string targetName, string projectFile, string targetFile) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string TargetName { get{} }
	public string ProjectFile { get{} }
	public string TargetFile { get{} }
	public System.DateTime Timestamp { get{} }
	public int ThreadId { get{} }
	public string Message { get{} }
	public string HelpKeyword { get{} }
	public string SenderName { get{} }
}

