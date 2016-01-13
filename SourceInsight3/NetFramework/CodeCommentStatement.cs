public class CodeCommentStatement : CodeStatement
{

	// Constructors
	public CodeCommentStatement() {}
	public CodeCommentStatement(CodeComment comment) {}
	public CodeCommentStatement(string text) {}
	public CodeCommentStatement(string text, bool docComment) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public CodeComment Comment { get{} set{} }
	public CodeLinePragma LinePragma { get{} set{} }
	public CodeDirectiveCollection StartDirectives { get{} }
	public CodeDirectiveCollection EndDirectives { get{} }
	public System.Collections.IDictionary UserData { get{} }
}

