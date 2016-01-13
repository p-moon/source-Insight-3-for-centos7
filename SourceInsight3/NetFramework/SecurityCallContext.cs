public class SecurityCallContext
{

	// Methods
	public bool IsCallerInRole(string role) {}
	public bool IsUserInRole(string user, string role) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public SecurityCallContext CurrentCall { get{} }
	public bool IsSecurityEnabled { get{} }
	public SecurityIdentity DirectCaller { get{} }
	public SecurityIdentity OriginalCaller { get{} }
	public int NumCallers { get{} }
	public int MinAuthenticationLevel { get{} }
	public SecurityCallers Callers { get{} }
}

