public class CodeTypeParameter : CodeObject
{

	// Constructors
	public CodeTypeParameter() {}
	public CodeTypeParameter(string name) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Name { get{} set{} }
	public CodeTypeReferenceCollection Constraints { get{} }
	public CodeAttributeDeclarationCollection CustomAttributes { get{} }
	public bool HasConstructorConstraint { get{} set{} }
	public System.Collections.IDictionary UserData { get{} }
}

