public class CodeCastExpression : CodeExpression
{

	// Constructors
	public CodeCastExpression() {}
	public CodeCastExpression(CodeTypeReference targetType, CodeExpression expression) {}
	public CodeCastExpression(string targetType, CodeExpression expression) {}
	public CodeCastExpression(Type targetType, CodeExpression expression) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public CodeTypeReference TargetType { get{} set{} }
	public CodeExpression Expression { get{} set{} }
	public System.Collections.IDictionary UserData { get{} }
}

