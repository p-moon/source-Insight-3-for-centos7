public class DesignerSerializerAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public DesignerSerializerAttribute(Type serializerType, Type baseSerializerType) {}
	public DesignerSerializerAttribute(string serializerTypeName, Type baseSerializerType) {}
	public DesignerSerializerAttribute(string serializerTypeName, string baseSerializerTypeName) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public string SerializerTypeName { get{} }
	public string SerializerBaseTypeName { get{} }
	public object TypeId { get{} }
}

