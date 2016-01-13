public class BuildWarningEventArgs : BuildEventArgs
{

	// Constructors
	public BuildWarningEventArgs(string subcategory, string code, string file, int lineNumber, int columnNumber, int endLineNumber, int endColumnNumber, string message, string helpKeyword, string senderName) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Subcategory { get{} }
	public string Code { get{} }
	public string File { get{} }
	public int LineNumber { get{} }
	public int ColumnNumber { get{} }
	public int EndLineNumber { get{} }
	public int EndColumnNumber { get{} }
	public System.DateTime Timestamp { get{} }
	public int ThreadId { get{} }
	public string Message { get{} }
	public string HelpKeyword { get{} }
	public string SenderName { get{} }
}

