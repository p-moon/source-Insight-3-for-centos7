public class CodeTryCatchFinallyStatement : CodeStatement
{

	// Constructors
	public CodeTryCatchFinallyStatement() {}
	public CodeTryCatchFinallyStatement(CodeStatement[] tryStatements, CodeCatchClause[] catchClauses) {}
	public CodeTryCatchFinallyStatement(CodeStatement[] tryStatements, CodeCatchClause[] catchClauses, CodeStatement[] finallyStatements) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public CodeStatementCollection TryStatements { get{} }
	public CodeCatchClauseCollection CatchClauses { get{} }
	public CodeStatementCollection FinallyStatements { get{} }
	public CodeLinePragma LinePragma { get{} set{} }
	public CodeDirectiveCollection StartDirectives { get{} }
	public CodeDirectiveCollection EndDirectives { get{} }
	public System.Collections.IDictionary UserData { get{} }
}

