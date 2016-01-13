public class CreateUserErrorEventArgs : System.EventArgs
{

	// Constructors
	public CreateUserErrorEventArgs(System.Web.Security.MembershipCreateStatus s) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Web.Security.MembershipCreateStatus CreateUserError { get{} set{} }
}

