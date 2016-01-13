public class SoapSchemaMember
{

	// Constructors
	public SoapSchemaMember() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Xml.XmlQualifiedName MemberType { get{} set{} }
	public string MemberName { get{} set{} }
}

