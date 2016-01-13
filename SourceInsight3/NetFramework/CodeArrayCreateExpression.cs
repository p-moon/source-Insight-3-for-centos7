public class CodeArrayCreateExpression : CodeExpression
{

	// Constructors
	public CodeArrayCreateExpression() {}
	public CodeArrayCreateExpression(CodeTypeReference createType, CodeExpression[] initializers) {}
	public CodeArrayCreateExpression(string createType, CodeExpression[] initializers) {}
	public CodeArrayCreateExpression(Type createType, CodeExpression[] initializers) {}
	public CodeArrayCreateExpression(CodeTypeReference createType, int size) {}
	public CodeArrayCreateExpression(string createType, int size) {}
	public CodeArrayCreateExpression(Type createType, int size) {}
	public CodeArrayCreateExpression(CodeTypeReference createType, CodeExpression size) {}
	public CodeArrayCreateExpression(string createType, CodeExpression size) {}
	public CodeArrayCreateExpression(Type createType, CodeExpression size) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public CodeTypeReference CreateType { get{} set{} }
	public CodeExpressionCollection Initializers { get{} }
	public int Size { get{} set{} }
	public CodeExpression SizeExpression { get{} set{} }
	public System.Collections.IDictionary UserData { get{} }
}

