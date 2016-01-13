public class CodePrimitiveExpression : CodeExpression
{

	// Constructors
	public CodePrimitiveExpression() {}
	public CodePrimitiveExpression(object value) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public object Value { get{} set{} }
	public System.Collections.IDictionary UserData { get{} }
}

