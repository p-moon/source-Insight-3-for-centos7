public class CodeNamespaceImport : CodeObject
{

	// Constructors
	public CodeNamespaceImport() {}
	public CodeNamespaceImport(string nameSpace) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public CodeLinePragma LinePragma { get{} set{} }
	public string Namespace { get{} set{} }
	public System.Collections.IDictionary UserData { get{} }
}

