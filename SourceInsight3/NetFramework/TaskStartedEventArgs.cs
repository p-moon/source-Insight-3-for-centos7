public class TaskStartedEventArgs : BuildStatusEventArgs
{

	// Constructors
	public TaskStartedEventArgs(string message, string helpKeyword, string projectFile, string taskFile, string taskName) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string TaskName { get{} }
	public string ProjectFile { get{} }
	public string TaskFile { get{} }
	public System.DateTime Timestamp { get{} }
	public int ThreadId { get{} }
	public string Message { get{} }
	public string HelpKeyword { get{} }
	public string SenderName { get{} }
}

