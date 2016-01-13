public class Authorization
{

	// Constructors
	public Authorization(string token) {}
	public Authorization(string token, bool finished) {}
	public Authorization(string token, bool finished, string connectionGroupId) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Message { get{} }
	public string ConnectionGroupId { get{} }
	public bool Complete { get{} }
	public string[] ProtectionRealm { get{} set{} }
	public bool MutuallyAuthenticated { get{} set{} }
}

