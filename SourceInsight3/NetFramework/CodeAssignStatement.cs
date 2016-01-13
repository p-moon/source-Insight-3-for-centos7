public class CodeAssignStatement : CodeStatement
{

	// Constructors
	public CodeAssignStatement() {}
	public CodeAssignStatement(CodeExpression left, CodeExpression right) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public CodeExpression Left { get{} set{} }
	public CodeExpression Right { get{} set{} }
	public CodeLinePragma LinePragma { get{} set{} }
	public CodeDirectiveCollection StartDirectives { get{} }
	public CodeDirectiveCollection EndDirectives { get{} }
	public System.Collections.IDictionary UserData { get{} }
}

