public class CodeArgumentReferenceExpression : CodeExpression
{

	// Constructors
	public CodeArgumentReferenceExpression() {}
	public CodeArgumentReferenceExpression(string parameterName) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string ParameterName { get{} set{} }
	public System.Collections.IDictionary UserData { get{} }
}

