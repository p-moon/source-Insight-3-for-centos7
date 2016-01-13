public class ImplicitResourceKey
{

	// Constructors
	public ImplicitResourceKey() {}
	public ImplicitResourceKey(string filter, string keyPrefix, string property) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Filter { get{} set{} }
	public string KeyPrefix { get{} set{} }
	public string Property { get{} set{} }
}

