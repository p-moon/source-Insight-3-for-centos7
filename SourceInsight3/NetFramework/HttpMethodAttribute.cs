public class HttpMethodAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public HttpMethodAttribute() {}
	public HttpMethodAttribute(Type returnFormatter, Type parameterFormatter) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public Type ReturnFormatter { get{} set{} }
	public Type ParameterFormatter { get{} set{} }
	public object TypeId { get{} }
}

