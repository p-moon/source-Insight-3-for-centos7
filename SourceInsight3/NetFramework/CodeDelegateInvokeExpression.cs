public class CodeDelegateInvokeExpression : CodeExpression
{

	// Constructors
	public CodeDelegateInvokeExpression() {}
	public CodeDelegateInvokeExpression(CodeExpression targetObject) {}
	public CodeDelegateInvokeExpression(CodeExpression targetObject, CodeExpression[] parameters) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public CodeExpression TargetObject { get{} set{} }
	public CodeExpressionCollection Parameters { get{} }
	public System.Collections.IDictionary UserData { get{} }
}

