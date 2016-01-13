public class Oid
{

	// Constructors
	public Oid() {}
	public Oid(string oid) {}
	public Oid(string value, string friendlyName) {}
	public Oid(Oid oid) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Value { get{} set{} }
	public string FriendlyName { get{} set{} }
}

