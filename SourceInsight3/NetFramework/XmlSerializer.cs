public class XmlSerializer
{

	// Constructors
	public XmlSerializer(Type type, XmlAttributeOverrides overrides, Type[] extraTypes, XmlRootAttribute root, string defaultNamespace) {}
	public XmlSerializer(Type type, XmlRootAttribute root) {}
	public XmlSerializer(Type type, Type[] extraTypes) {}
	public XmlSerializer(Type type, XmlAttributeOverrides overrides) {}
	public XmlSerializer(XmlTypeMapping xmlTypeMapping) {}
	public XmlSerializer(Type type) {}
	public XmlSerializer(Type type, string defaultNamespace) {}
	public XmlSerializer(Type type, XmlAttributeOverrides overrides, Type[] extraTypes, XmlRootAttribute root, string defaultNamespace, string location, System.Security.Policy.Evidence evidence) {}

	// Methods
	public void Serialize(System.IO.TextWriter textWriter, object o) {}
	public void Serialize(System.IO.TextWriter textWriter, object o, XmlSerializerNamespaces namespaces) {}
	public void Serialize(System.IO.Stream stream, object o) {}
	public void Serialize(System.IO.Stream stream, object o, XmlSerializerNamespaces namespaces) {}
	public void Serialize(System.Xml.XmlWriter xmlWriter, object o) {}
	public void Serialize(System.Xml.XmlWriter xmlWriter, object o, XmlSerializerNamespaces namespaces) {}
	public void Serialize(System.Xml.XmlWriter xmlWriter, object o, XmlSerializerNamespaces namespaces, string encodingStyle) {}
	public void Serialize(System.Xml.XmlWriter xmlWriter, object o, XmlSerializerNamespaces namespaces, string encodingStyle, string id) {}
	public object Deserialize(System.IO.Stream stream) {}
	public object Deserialize(System.IO.TextReader textReader) {}
	public object Deserialize(System.Xml.XmlReader xmlReader) {}
	public object Deserialize(System.Xml.XmlReader xmlReader, XmlDeserializationEvents events) {}
	public object Deserialize(System.Xml.XmlReader xmlReader, string encodingStyle) {}
	public object Deserialize(System.Xml.XmlReader xmlReader, string encodingStyle, XmlDeserializationEvents events) {}
	public virtual bool CanDeserialize(System.Xml.XmlReader xmlReader) {}
	public static XmlSerializer[] FromMappings(XmlMapping[] mappings) {}
	public static XmlSerializer[] FromMappings(XmlMapping[] mappings, Type type) {}
	public static XmlSerializer[] FromMappings(XmlMapping[] mappings, System.Security.Policy.Evidence evidence) {}
	public static System.Reflection.Assembly GenerateSerializer(Type[] types, XmlMapping[] mappings) {}
	public static System.Reflection.Assembly GenerateSerializer(Type[] types, XmlMapping[] mappings, System.CodeDom.Compiler.CompilerParameters parameters) {}
	public static XmlSerializer[] FromTypes(Type[] types) {}
	public static string GetXmlSerializerAssemblyName(Type type) {}
	public static string GetXmlSerializerAssemblyName(Type type, string defaultNamespace) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Events
	public event System.Xml.Serialization.XmlNodeEventHandler UnknownNode;
	public event System.Xml.Serialization.XmlAttributeEventHandler UnknownAttribute;
	public event System.Xml.Serialization.XmlElementEventHandler UnknownElement;
	public event System.Xml.Serialization.UnreferencedObjectEventHandler UnreferencedObject;
}

