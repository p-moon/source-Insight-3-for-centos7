public class RootDesignerSerializerAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public RootDesignerSerializerAttribute(Type serializerType, Type baseSerializerType, bool reloadable) {}
	public RootDesignerSerializerAttribute(string serializerTypeName, Type baseSerializerType, bool reloadable) {}
	public RootDesignerSerializerAttribute(string serializerTypeName, string baseSerializerTypeName, bool reloadable) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public bool Reloadable { get{} }
	public string SerializerTypeName { get{} }
	public string SerializerBaseTypeName { get{} }
	public object TypeId { get{} }
}

