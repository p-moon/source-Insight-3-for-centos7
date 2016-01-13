public class IDReferencePropertyAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public IDReferencePropertyAttribute() {}
	public IDReferencePropertyAttribute(Type referencedControlType) {}

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public Type ReferencedControlType { get{} }
	public object TypeId { get{} }
}

