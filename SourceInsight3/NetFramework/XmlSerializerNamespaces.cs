public class XmlSerializerNamespaces
{

	// Constructors
	public XmlSerializerNamespaces() {}
	public XmlSerializerNamespaces(XmlSerializerNamespaces namespaces) {}
	public XmlSerializerNamespaces(System.Xml.XmlQualifiedName[] namespaces) {}

	// Methods
	public void Add(string prefix, string ns) {}
	public System.Xml.XmlQualifiedName[] ToArray() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Count { get{} }
}

