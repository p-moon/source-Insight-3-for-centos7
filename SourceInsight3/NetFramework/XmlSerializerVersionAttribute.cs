public class XmlSerializerVersionAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public XmlSerializerVersionAttribute() {}
	public XmlSerializerVersionAttribute(Type type) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public string ParentAssemblyId { get{} set{} }
	public string Version { get{} set{} }
	public string Namespace { get{} set{} }
	public Type Type { get{} set{} }
	public object TypeId { get{} }
}

