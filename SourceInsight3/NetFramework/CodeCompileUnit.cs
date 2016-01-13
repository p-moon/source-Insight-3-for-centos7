public class CodeCompileUnit : CodeObject
{

	// Constructors
	public CodeCompileUnit() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public CodeNamespaceCollection Namespaces { get{} }
	public System.Collections.Specialized.StringCollection ReferencedAssemblies { get{} }
	public CodeAttributeDeclarationCollection AssemblyCustomAttributes { get{} }
	public CodeDirectiveCollection StartDirectives { get{} }
	public CodeDirectiveCollection EndDirectives { get{} }
	public System.Collections.IDictionary UserData { get{} }
}

