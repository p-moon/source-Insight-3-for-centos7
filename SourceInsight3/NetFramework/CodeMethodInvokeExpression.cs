public class CodeMethodInvokeExpression : CodeExpression
{

	// Constructors
	public CodeMethodInvokeExpression() {}
	public CodeMethodInvokeExpression(CodeMethodReferenceExpression method, CodeExpression[] parameters) {}
	public CodeMethodInvokeExpression(CodeExpression targetObject, string methodName, CodeExpression[] parameters) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public CodeMethodReferenceExpression Method { get{} set{} }
	public CodeExpressionCollection Parameters { get{} }
	public System.Collections.IDictionary UserData { get{} }
}

