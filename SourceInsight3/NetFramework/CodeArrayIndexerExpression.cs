public class CodeArrayIndexerExpression : CodeExpression
{

	// Constructors
	public CodeArrayIndexerExpression() {}
	public CodeArrayIndexerExpression(CodeExpression targetObject, CodeExpression[] indices) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public CodeExpression TargetObject { get{} set{} }
	public CodeExpressionCollection Indices { get{} }
	public System.Collections.IDictionary UserData { get{} }
}

