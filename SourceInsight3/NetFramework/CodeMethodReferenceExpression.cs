public class CodeMethodReferenceExpression : CodeExpression
{

	// Constructors
	public CodeMethodReferenceExpression() {}
	public CodeMethodReferenceExpression(CodeExpression targetObject, string methodName) {}
	public CodeMethodReferenceExpression(CodeExpression targetObject, string methodName, CodeTypeReference[] typeParameters) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public CodeExpression TargetObject { get{} set{} }
	public string MethodName { get{} set{} }
	public CodeTypeReferenceCollection TypeArguments { get{} }
	public System.Collections.IDictionary UserData { get{} }
}

