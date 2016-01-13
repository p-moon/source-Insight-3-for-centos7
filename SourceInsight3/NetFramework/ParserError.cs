public class ParserError
{

	// Constructors
	public ParserError() {}
	public ParserError(string errorText, string virtualPath, int line) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string VirtualPath { get{} set{} }
	public string ErrorText { get{} set{} }
	public int Line { get{} set{} }
}

