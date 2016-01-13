public class CodeComment : CodeObject
{

	// Constructors
	public CodeComment() {}
	public CodeComment(string text) {}
	public CodeComment(string text, bool docComment) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool DocComment { get{} set{} }
	public string Text { get{} set{} }
	public System.Collections.IDictionary UserData { get{} }
}

