public class SiteMapNodeItemEventArgs : System.EventArgs
{

	// Constructors
	public SiteMapNodeItemEventArgs(SiteMapNodeItem item) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public SiteMapNodeItem Item { get{} }
}

