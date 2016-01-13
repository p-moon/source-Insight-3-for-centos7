public class CodeDelegateCreateExpression : CodeExpression
{

	// Constructors
	public CodeDelegateCreateExpression() {}
	public CodeDelegateCreateExpression(CodeTypeReference delegateType, CodeExpression targetObject, string methodName) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public CodeTypeReference DelegateType { get{} set{} }
	public CodeExpression TargetObject { get{} set{} }
	public string MethodName { get{} set{} }
	public System.Collections.IDictionary UserData { get{} }
}

