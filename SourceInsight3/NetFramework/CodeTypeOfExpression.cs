public class CodeTypeOfExpression : CodeExpression
{

	// Constructors
	public CodeTypeOfExpression() {}
	public CodeTypeOfExpression(CodeTypeReference type) {}
	public CodeTypeOfExpression(string type) {}
	public CodeTypeOfExpression(Type type) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public CodeTypeReference Type { get{} set{} }
	public System.Collections.IDictionary UserData { get{} }
}

