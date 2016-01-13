public class ConnectionOptions : ManagementOptions, System.ICloneable
{

	// Constructors
	public ConnectionOptions() {}
	public ConnectionOptions(string locale, string username, string password, string authority, ImpersonationLevel impersonation, AuthenticationLevel authentication, bool enablePrivileges, ManagementNamedValueCollection context, System.TimeSpan timeout) {}
	public ConnectionOptions(string locale, string username, System.Security.SecureString password, string authority, ImpersonationLevel impersonation, AuthenticationLevel authentication, bool enablePrivileges, ManagementNamedValueCollection context, System.TimeSpan timeout) {}

	// Methods
	public virtual object Clone() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Locale { get{} set{} }
	public string Username { get{} set{} }
	public string Password { set{} }
	public System.Security.SecureString SecurePassword { set{} }
	public string Authority { get{} set{} }
	public ImpersonationLevel Impersonation { get{} set{} }
	public AuthenticationLevel Authentication { get{} set{} }
	public bool EnablePrivileges { get{} set{} }
	public ManagementNamedValueCollection Context { get{} set{} }
	public System.TimeSpan Timeout { get{} set{} }
}

