public class OptionalFieldAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public OptionalFieldAttribute() {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public int VersionAdded { get{} set{} }
	public object TypeId { get{} }
}

