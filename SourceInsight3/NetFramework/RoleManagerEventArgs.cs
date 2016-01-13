public class RoleManagerEventArgs : System.EventArgs
{

	// Constructors
	public RoleManagerEventArgs(System.Web.HttpContext context) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool RolesPopulated { get{} set{} }
	public System.Web.HttpContext Context { get{} }
}

