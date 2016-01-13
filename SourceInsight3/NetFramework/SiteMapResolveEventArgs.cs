public class SiteMapResolveEventArgs : System.EventArgs
{

	// Constructors
	public SiteMapResolveEventArgs(HttpContext context, SiteMapProvider provider) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public SiteMapProvider Provider { get{} }
	public HttpContext Context { get{} }
}

