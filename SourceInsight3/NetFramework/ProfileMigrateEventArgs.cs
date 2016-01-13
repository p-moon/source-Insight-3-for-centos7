public class ProfileMigrateEventArgs : System.EventArgs
{

	// Constructors
	public ProfileMigrateEventArgs(System.Web.HttpContext context, string anonymousId) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Web.HttpContext Context { get{} }
	public string AnonymousID { get{} }
}

