public class CodeCatchClause
{

	// Constructors
	public CodeCatchClause() {}
	public CodeCatchClause(string localName) {}
	public CodeCatchClause(string localName, CodeTypeReference catchExceptionType) {}
	public CodeCatchClause(string localName, CodeTypeReference catchExceptionType, CodeStatement[] statements) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string LocalName { get{} set{} }
	public CodeTypeReference CatchExceptionType { get{} set{} }
	public CodeStatementCollection Statements { get{} }
}

