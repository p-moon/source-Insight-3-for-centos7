public class CodeConditionStatement : CodeStatement
{

	// Constructors
	public CodeConditionStatement() {}
	public CodeConditionStatement(CodeExpression condition, CodeStatement[] trueStatements) {}
	public CodeConditionStatement(CodeExpression condition, CodeStatement[] trueStatements, CodeStatement[] falseStatements) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public CodeExpression Condition { get{} set{} }
	public CodeStatementCollection TrueStatements { get{} }
	public CodeStatementCollection FalseStatements { get{} }
	public CodeLinePragma LinePragma { get{} set{} }
	public CodeDirectiveCollection StartDirectives { get{} }
	public CodeDirectiveCollection EndDirectives { get{} }
	public System.Collections.IDictionary UserData { get{} }
}

