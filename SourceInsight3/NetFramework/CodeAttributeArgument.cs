public class CodeAttributeArgument
{

	// Constructors
	public CodeAttributeArgument() {}
	public CodeAttributeArgument(CodeExpression value) {}
	public CodeAttributeArgument(string name, CodeExpression value) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Name { get{} set{} }
	public CodeExpression Value { get{} set{} }
}

