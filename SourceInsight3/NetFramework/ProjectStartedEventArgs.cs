public class ProjectStartedEventArgs : BuildStatusEventArgs
{

	// Constructors
	public ProjectStartedEventArgs(string message, string helpKeyword, string projectFile, string targetNames, System.Collections.IEnumerable properties, System.Collections.IEnumerable items) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string ProjectFile { get{} }
	public string TargetNames { get{} }
	public System.Collections.IEnumerable Properties { get{} }
	public System.Collections.IEnumerable Items { get{} }
	public System.DateTime Timestamp { get{} }
	public int ThreadId { get{} }
	public string Message { get{} }
	public string HelpKeyword { get{} }
	public string SenderName { get{} }
}

