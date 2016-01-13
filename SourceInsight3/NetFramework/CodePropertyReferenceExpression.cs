public class CodePropertyReferenceExpression : CodeExpression
{

	// Constructors
	public CodePropertyReferenceExpression() {}
	public CodePropertyReferenceExpression(CodeExpression targetObject, string propertyName) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public CodeExpression TargetObject { get{} set{} }
	public string PropertyName { get{} set{} }
	public System.Collections.IDictionary UserData { get{} }
}

