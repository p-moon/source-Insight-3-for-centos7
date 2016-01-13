public class SwitchLevelAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public SwitchLevelAttribute(Type switchLevelType) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public Type SwitchLevelType { get{} set{} }
	public object TypeId { get{} }
}

