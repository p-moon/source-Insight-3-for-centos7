public class CodeLinePragma
{

	// Constructors
	public CodeLinePragma() {}
	public CodeLinePragma(string fileName, int lineNumber) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string FileName { get{} set{} }
	public int LineNumber { get{} set{} }
}

