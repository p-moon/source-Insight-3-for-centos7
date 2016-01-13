public class CodeTypeReference : CodeObject
{

	// Constructors
	public CodeTypeReference() {}
	public CodeTypeReference(Type type) {}
	public CodeTypeReference(Type type, CodeTypeReferenceOptions codeTypeReferenceOption) {}
	public CodeTypeReference(string typeName, CodeTypeReferenceOptions codeTypeReferenceOption) {}
	public CodeTypeReference(string typeName) {}
	public CodeTypeReference(string typeName, CodeTypeReference[] typeArguments) {}
	public CodeTypeReference(CodeTypeParameter typeParameter) {}
	public CodeTypeReference(string baseType, int rank) {}
	public CodeTypeReference(CodeTypeReference arrayType, int rank) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public CodeTypeReference ArrayElementType { get{} set{} }
	public int ArrayRank { get{} set{} }
	public string BaseType { get{} set{} }
	public CodeTypeReferenceOptions Options { get{} set{} }
	public CodeTypeReferenceCollection TypeArguments { get{} }
	public System.Collections.IDictionary UserData { get{} }
}

