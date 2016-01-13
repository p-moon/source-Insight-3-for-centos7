public class AttributeUsageAttribute : Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public AttributeUsageAttribute(AttributeTargets validOn) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public AttributeTargets ValidOn { get{} }
	public bool AllowMultiple { get{} set{} }
	public bool Inherited { get{} set{} }
	public object TypeId { get{} }
}

