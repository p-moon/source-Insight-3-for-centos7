public class ProfileEventArgs : System.EventArgs
{

	// Constructors
	public ProfileEventArgs(System.Web.HttpContext context) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Web.HttpContext Context { get{} }
	public ProfileBase Profile { get{} set{} }
}

