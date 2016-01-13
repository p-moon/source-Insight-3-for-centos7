public class ConstructorNeedsTagAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public ConstructorNeedsTagAttribute() {}
	public ConstructorNeedsTagAttribute(bool needsTag) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public bool NeedsTag { get{} }
	public object TypeId { get{} }
}

