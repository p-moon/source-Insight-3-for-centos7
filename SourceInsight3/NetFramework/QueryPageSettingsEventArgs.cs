public class QueryPageSettingsEventArgs : PrintEventArgs
{

	// Constructors
	public QueryPageSettingsEventArgs(PageSettings pageSettings) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public PageSettings PageSettings { get{} set{} }
	public PrintAction PrintAction { get{} }
	public bool Cancel { get{} set{} }
}

