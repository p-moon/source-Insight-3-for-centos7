public class CodeNamespace : CodeObject
{

	// Constructors
	public CodeNamespace() {}
	public CodeNamespace(string name) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public CodeTypeDeclarationCollection Types { get{} }
	public CodeNamespaceImportCollection Imports { get{} }
	public string Name { get{} set{} }
	public CodeCommentStatementCollection Comments { get{} }
	public System.Collections.IDictionary UserData { get{} }

	// Events
	public event System.EventHandler PopulateComments;
	public event System.EventHandler PopulateImports;
	public event System.EventHandler PopulateTypes;
}

