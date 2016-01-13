public class PersistNameAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public PersistNameAttribute(string name) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool IsDefaultAttribute() {}
	public virtual bool Match(object obj) {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Fields
	public PersistNameAttribute Default;

	// Properties
	public string Name { get{} }
	public object TypeId { get{} }
}

