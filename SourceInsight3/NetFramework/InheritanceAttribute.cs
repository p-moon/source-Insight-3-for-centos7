public class InheritanceAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public InheritanceAttribute() {}
	public InheritanceAttribute(InheritanceLevel inheritanceLevel) {}

	// Methods
	public virtual bool Equals(object value) {}
	public virtual int GetHashCode() {}
	public virtual bool IsDefaultAttribute() {}
	public virtual string ToString() {}
	public virtual bool Match(object obj) {}
	public Type GetType() {}

	// Fields
	public InheritanceAttribute Inherited;
	public InheritanceAttribute InheritedReadOnly;
	public InheritanceAttribute NotInherited;
	public InheritanceAttribute Default;

	// Properties
	public InheritanceLevel InheritanceLevel { get{} }
	public object TypeId { get{} }
}

