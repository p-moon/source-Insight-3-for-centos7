public class ExpressionEditorAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public ExpressionEditorAttribute(Type type) {}
	public ExpressionEditorAttribute(string typeName) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public string EditorTypeName { get{} }
	public object TypeId { get{} }
}

