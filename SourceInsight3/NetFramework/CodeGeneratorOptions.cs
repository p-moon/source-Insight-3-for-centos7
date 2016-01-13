public class CodeGeneratorOptions
{

	// Constructors
	public CodeGeneratorOptions() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public object Item { get{} set{} }
	public string IndentString { get{} set{} }
	public string BracingStyle { get{} set{} }
	public bool ElseOnClosing { get{} set{} }
	public bool BlankLinesBetweenMembers { get{} set{} }
	public bool VerbatimOrder { get{} set{} }
}

