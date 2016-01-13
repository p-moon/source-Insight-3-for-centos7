public class ExternalProjectFinishedEventArgs : CustomBuildEventArgs
{

	// Constructors
	public ExternalProjectFinishedEventArgs(string message, string helpKeyword, string senderName, string projectFile, bool succeeded) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string ProjectFile { get{} }
	public bool Succeeded { get{} }
	public System.DateTime Timestamp { get{} }
	public int ThreadId { get{} }
	public string Message { get{} }
	public string HelpKeyword { get{} }
	public string SenderName { get{} }
}

