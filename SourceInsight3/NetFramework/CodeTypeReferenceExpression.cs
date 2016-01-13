public class CodeTypeReferenceExpression : CodeExpression
{

	// Constructors
	public CodeTypeReferenceExpression() {}
	public CodeTypeReferenceExpression(CodeTypeReference type) {}
	public CodeTypeReferenceExpression(string type) {}
	public CodeTypeReferenceExpression(Type type) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public CodeTypeReference Type { get{} set{} }
	public System.Collections.IDictionary UserData { get{} }
}

