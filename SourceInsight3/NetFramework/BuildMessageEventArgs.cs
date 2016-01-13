public class BuildMessageEventArgs : BuildEventArgs
{

	// Constructors
	public BuildMessageEventArgs(string message, string helpKeyword, string senderName, MessageImportance importance) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public MessageImportance Importance { get{} }
	public System.DateTime Timestamp { get{} }
	public int ThreadId { get{} }
	public string Message { get{} }
	public string HelpKeyword { get{} }
	public string SenderName { get{} }
}

