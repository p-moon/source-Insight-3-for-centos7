public class CodeAttributeDeclaration
{

	// Constructors
	public CodeAttributeDeclaration() {}
	public CodeAttributeDeclaration(string name) {}
	public CodeAttributeDeclaration(string name, CodeAttributeArgument[] arguments) {}
	public CodeAttributeDeclaration(CodeTypeReference attributeType) {}
	public CodeAttributeDeclaration(CodeTypeReference attributeType, CodeAttributeArgument[] arguments) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Name { get{} set{} }
	public CodeAttributeArgumentCollection Arguments { get{} }
	public CodeTypeReference AttributeType { get{} }
}

