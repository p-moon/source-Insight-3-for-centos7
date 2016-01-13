public class CodeLabeledStatement : CodeStatement
{

	// Constructors
	public CodeLabeledStatement() {}
	public CodeLabeledStatement(string label) {}
	public CodeLabeledStatement(string label, CodeStatement statement) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Label { get{} set{} }
	public CodeStatement Statement { get{} set{} }
	public CodeLinePragma LinePragma { get{} set{} }
	public CodeDirectiveCollection StartDirectives { get{} }
	public CodeDirectiveCollection EndDirectives { get{} }
	public System.Collections.IDictionary UserData { get{} }
}

