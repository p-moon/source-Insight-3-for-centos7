public class EditorAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public EditorAttribute() {}
	public EditorAttribute(string typeName, string baseTypeName) {}
	public EditorAttribute(string typeName, Type baseType) {}
	public EditorAttribute(Type type, Type baseType) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public string EditorBaseTypeName { get{} }
	public string EditorTypeName { get{} }
	public object TypeId { get{} }
}

