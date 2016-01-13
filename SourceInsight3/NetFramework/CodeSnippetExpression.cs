public class CodeSnippetExpression : CodeExpression
{

	// Constructors
	public CodeSnippetExpression() {}
	public CodeSnippetExpression(string value) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Value { get{} set{} }
	public System.Collections.IDictionary UserData { get{} }
}

