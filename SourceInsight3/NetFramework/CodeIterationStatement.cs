public class CodeIterationStatement : CodeStatement
{

	// Constructors
	public CodeIterationStatement() {}
	public CodeIterationStatement(CodeStatement initStatement, CodeExpression testExpression, CodeStatement incrementStatement, CodeStatement[] statements) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public CodeStatement InitStatement { get{} set{} }
	public CodeExpression TestExpression { get{} set{} }
	public CodeStatement IncrementStatement { get{} set{} }
	public CodeStatementCollection Statements { get{} }
	public CodeLinePragma LinePragma { get{} set{} }
	public CodeDirectiveCollection StartDirectives { get{} }
	public CodeDirectiveCollection EndDirectives { get{} }
	public System.Collections.IDictionary UserData { get{} }
}

