public class ImportContext
{

	// Constructors
	public ImportContext(CodeIdentifiers identifiers, bool shareTypes) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public CodeIdentifiers TypeIdentifiers { get{} }
	public bool ShareTypes { get{} }
	public System.Collections.Specialized.StringCollection Warnings { get{} }
}

