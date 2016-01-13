public class CompilerError
{

	// Constructors
	public CompilerError() {}
	public CompilerError(string fileName, int line, int column, string errorNumber, string errorText) {}

	// Methods
	public virtual string ToString() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Line { get{} set{} }
	public int Column { get{} set{} }
	public string ErrorNumber { get{} set{} }
	public string ErrorText { get{} set{} }
	public bool IsWarning { get{} set{} }
	public string FileName { get{} set{} }
}

