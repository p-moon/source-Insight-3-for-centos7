public class DataBindingHandlerAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public DataBindingHandlerAttribute() {}
	public DataBindingHandlerAttribute(Type type) {}
	public DataBindingHandlerAttribute(string typeName) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Fields
	public DataBindingHandlerAttribute Default;

	// Properties
	public string HandlerTypeName { get{} }
	public object TypeId { get{} }
}

