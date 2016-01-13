public class SecurityIdentity
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string AccountName { get{} }
	public int AuthenticationService { get{} }
	public ImpersonationLevelOption ImpersonationLevel { get{} }
	public AuthenticationOption AuthenticationLevel { get{} }
}

