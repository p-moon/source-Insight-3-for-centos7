public class CodeFieldReferenceExpression : CodeExpression
{

	// Constructors
	public CodeFieldReferenceExpression() {}
	public CodeFieldReferenceExpression(CodeExpression targetObject, string fieldName) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public CodeExpression TargetObject { get{} set{} }
	public string FieldName { get{} set{} }
	public System.Collections.IDictionary UserData { get{} }
}

