public class CodeVariableDeclarationStatement : CodeStatement
{

	// Constructors
	public CodeVariableDeclarationStatement() {}
	public CodeVariableDeclarationStatement(CodeTypeReference type, string name) {}
	public CodeVariableDeclarationStatement(string type, string name) {}
	public CodeVariableDeclarationStatement(Type type, string name) {}
	public CodeVariableDeclarationStatement(CodeTypeReference type, string name, CodeExpression initExpression) {}
	public CodeVariableDeclarationStatement(string type, string name, CodeExpression initExpression) {}
	public CodeVariableDeclarationStatement(Type type, string name, CodeExpression initExpression) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public CodeExpression InitExpression { get{} set{} }
	public string Name { get{} set{} }
	public CodeTypeReference Type { get{} set{} }
	public CodeLinePragma LinePragma { get{} set{} }
	public CodeDirectiveCollection StartDirectives { get{} }
	public CodeDirectiveCollection EndDirectives { get{} }
	public System.Collections.IDictionary UserData { get{} }
}

