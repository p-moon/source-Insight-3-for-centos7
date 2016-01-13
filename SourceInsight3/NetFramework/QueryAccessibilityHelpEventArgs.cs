public class QueryAccessibilityHelpEventArgs : System.EventArgs
{

	// Constructors
	public QueryAccessibilityHelpEventArgs() {}
	public QueryAccessibilityHelpEventArgs(string helpNamespace, string helpString, string helpKeyword) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string HelpNamespace { get{} set{} }
	public string HelpString { get{} set{} }
	public string HelpKeyword { get{} set{} }
}

