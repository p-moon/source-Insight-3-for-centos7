public class MethodImplAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public MethodImplAttribute(MethodImplOptions methodImplOptions) {}
	public MethodImplAttribute(short value) {}
	public MethodImplAttribute() {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Fields
	public MethodCodeType MethodCodeType;

	// Properties
	public MethodImplOptions Value { get{} }
	public object TypeId { get{} }
}

