public class FormsIdentity : System.Security.Principal.IIdentity
{

	// Constructors
	public FormsIdentity(FormsAuthenticationTicket ticket) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Name { get{} }
	public string AuthenticationType { get{} }
	public bool IsAuthenticated { get{} }
	public FormsAuthenticationTicket Ticket { get{} }
}

