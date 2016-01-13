public class GenericIdentity : IIdentity
{

	// Constructors
	public GenericIdentity(string name) {}
	public GenericIdentity(string name, string type) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Name { get{} }
	public string AuthenticationType { get{} }
	public bool IsAuthenticated { get{} }
}

