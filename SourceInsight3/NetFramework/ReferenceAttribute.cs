public class ReferenceAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public ReferenceAttribute(string reference) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Fields
	public string reference;

	// Properties
	public object TypeId { get{} }
}

