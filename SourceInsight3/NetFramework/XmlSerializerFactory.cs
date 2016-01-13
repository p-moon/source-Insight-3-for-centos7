public class XmlSerializerFactory
{

	// Constructors
	public XmlSerializerFactory() {}

	// Methods
	public XmlSerializer CreateSerializer(Type type, XmlAttributeOverrides overrides, Type[] extraTypes, XmlRootAttribute root, string defaultNamespace) {}
	public XmlSerializer CreateSerializer(Type type, XmlRootAttribute root) {}
	public XmlSerializer CreateSerializer(Type type, Type[] extraTypes) {}
	public XmlSerializer CreateSerializer(Type type, XmlAttributeOverrides overrides) {}
	public XmlSerializer CreateSerializer(XmlTypeMapping xmlTypeMapping) {}
	public XmlSerializer CreateSerializer(Type type) {}
	public XmlSerializer CreateSerializer(Type type, string defaultNamespace) {}
	public XmlSerializer CreateSerializer(Type type, XmlAttributeOverrides overrides, Type[] extraTypes, XmlRootAttribute root, string defaultNamespace, string location, System.Security.Policy.Evidence evidence) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

