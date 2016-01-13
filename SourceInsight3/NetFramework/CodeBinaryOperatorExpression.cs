public class CodeBinaryOperatorExpression : CodeExpression
{

	// Constructors
	public CodeBinaryOperatorExpression() {}
	public CodeBinaryOperatorExpression(CodeExpression left, CodeBinaryOperatorType op, CodeExpression right) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public CodeExpression Right { get{} set{} }
	public CodeExpression Left { get{} set{} }
	public CodeBinaryOperatorType Operator { get{} set{} }
	public System.Collections.IDictionary UserData { get{} }
}

