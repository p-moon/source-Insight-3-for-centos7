public class CodeVariableReferenceExpression : CodeExpression
{

	// Constructors
	public CodeVariableReferenceExpression() {}
	public CodeVariableReferenceExpression(string variableName) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string VariableName { get{} set{} }
	public System.Collections.IDictionary UserData { get{} }
}

