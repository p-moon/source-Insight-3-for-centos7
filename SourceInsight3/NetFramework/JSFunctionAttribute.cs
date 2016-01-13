public class JSFunctionAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public JSFunctionAttribute(JSFunctionAttributeEnum value) {}
	public JSFunctionAttribute(JSFunctionAttributeEnum value, JSBuiltin builtinFunction) {}

	// Methods
	public JSFunctionAttributeEnum GetAttributeValue() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public object TypeId { get{} }
}

