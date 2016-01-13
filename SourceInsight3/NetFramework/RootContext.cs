public class RootContext
{

	// Constructors
	public RootContext(System.CodeDom.CodeExpression expression, object value) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.CodeDom.CodeExpression Expression { get{} }
	public object Value { get{} }
}

