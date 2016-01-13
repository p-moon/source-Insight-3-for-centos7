public class CodeEventReferenceExpression : CodeExpression
{

	// Constructors
	public CodeEventReferenceExpression() {}
	public CodeEventReferenceExpression(CodeExpression targetObject, string eventName) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public CodeExpression TargetObject { get{} set{} }
	public string EventName { get{} set{} }
	public System.Collections.IDictionary UserData { get{} }
}

