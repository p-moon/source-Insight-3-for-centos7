public class HttpListenerBasicIdentity : System.Security.Principal.GenericIdentity, System.Security.Principal.IIdentity
{

	// Constructors
	public HttpListenerBasicIdentity(string username, string password) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Password { get{} }
	public string Name { get{} }
	public string AuthenticationType { get{} }
	public bool IsAuthenticated { get{} }
}

