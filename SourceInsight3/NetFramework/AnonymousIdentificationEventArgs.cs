public class AnonymousIdentificationEventArgs : System.EventArgs
{

	// Constructors
	public AnonymousIdentificationEventArgs(System.Web.HttpContext context) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string AnonymousID { get{} set{} }
	public System.Web.HttpContext Context { get{} }
}

