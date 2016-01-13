public class CodeDefaultValueExpression : CodeExpression
{

	// Constructors
	public CodeDefaultValueExpression() {}
	public CodeDefaultValueExpression(CodeTypeReference type) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public CodeTypeReference Type { get{} set{} }
	public System.Collections.IDictionary UserData { get{} }
}

