public class FormsAuthenticationTicket
{

	// Constructors
	public FormsAuthenticationTicket(int version, string name, System.DateTime issueDate, System.DateTime expiration, bool isPersistent, string userData) {}
	public FormsAuthenticationTicket(int version, string name, System.DateTime issueDate, System.DateTime expiration, bool isPersistent, string userData, string cookiePath) {}
	public FormsAuthenticationTicket(string name, bool isPersistent, int timeout) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Version { get{} }
	public string Name { get{} }
	public System.DateTime Expiration { get{} }
	public System.DateTime IssueDate { get{} }
	public bool IsPersistent { get{} }
	public bool Expired { get{} }
	public string UserData { get{} }
	public string CookiePath { get{} }
}

