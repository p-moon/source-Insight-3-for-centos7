public class CodeParameterDeclarationExpression : CodeExpression
{

	// Constructors
	public CodeParameterDeclarationExpression() {}
	public CodeParameterDeclarationExpression(CodeTypeReference type, string name) {}
	public CodeParameterDeclarationExpression(string type, string name) {}
	public CodeParameterDeclarationExpression(Type type, string name) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public CodeAttributeDeclarationCollection CustomAttributes { get{} set{} }
	public FieldDirection Direction { get{} set{} }
	public CodeTypeReference Type { get{} set{} }
	public string Name { get{} set{} }
	public System.Collections.IDictionary UserData { get{} }
}

