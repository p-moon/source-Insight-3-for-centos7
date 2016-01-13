public class CodeObjectCreateExpression : CodeExpression
{

	// Constructors
	public CodeObjectCreateExpression() {}
	public CodeObjectCreateExpression(CodeTypeReference createType, CodeExpression[] parameters) {}
	public CodeObjectCreateExpression(string createType, CodeExpression[] parameters) {}
	public CodeObjectCreateExpression(Type createType, CodeExpression[] parameters) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public CodeTypeReference CreateType { get{} set{} }
	public CodeExpressionCollection Parameters { get{} }
	public System.Collections.IDictionary UserData { get{} }
}

