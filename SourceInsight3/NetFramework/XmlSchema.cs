public class XmlSchema : XmlSchemaObject
{

	// Constructors
	public XmlSchema() {}

	// Methods
	public static XmlSchema Read(System.IO.TextReader reader, ValidationEventHandler validationEventHandler) {}
	public static XmlSchema Read(System.IO.Stream stream, ValidationEventHandler validationEventHandler) {}
	public static XmlSchema Read(System.Xml.XmlReader reader, ValidationEventHandler validationEventHandler) {}
	public void Write(System.IO.Stream stream) {}
	public void Write(System.IO.Stream stream, System.Xml.XmlNamespaceManager namespaceManager) {}
	public void Write(System.IO.TextWriter writer) {}
	public void Write(System.IO.TextWriter writer, System.Xml.XmlNamespaceManager namespaceManager) {}
	public void Write(System.Xml.XmlWriter writer) {}
	public void Write(System.Xml.XmlWriter writer, System.Xml.XmlNamespaceManager namespaceManager) {}
	public void Compile(ValidationEventHandler validationEventHandler) {}
	public void Compile(ValidationEventHandler validationEventHandler, System.Xml.XmlResolver resolver) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public string Namespace;
	public string InstanceNamespace;

	// Properties
	public XmlSchemaForm AttributeFormDefault { get{} set{} }
	public XmlSchemaDerivationMethod BlockDefault { get{} set{} }
	public XmlSchemaDerivationMethod FinalDefault { get{} set{} }
	public XmlSchemaForm ElementFormDefault { get{} set{} }
	public string TargetNamespace { get{} set{} }
	public string Version { get{} set{} }
	public XmlSchemaObjectCollection Includes { get{} }
	public XmlSchemaObjectCollection Items { get{} }
	public bool IsCompiled { get{} }
	public XmlSchemaObjectTable Attributes { get{} }
	public XmlSchemaObjectTable AttributeGroups { get{} }
	public XmlSchemaObjectTable SchemaTypes { get{} }
	public XmlSchemaObjectTable Elements { get{} }
	public string Id { get{} set{} }
	public System.Xml.XmlAttribute[] UnhandledAttributes { get{} set{} }
	public XmlSchemaObjectTable Groups { get{} }
	public XmlSchemaObjectTable Notations { get{} }
	public int LineNumber { get{} set{} }
	public int LinePosition { get{} set{} }
	public string SourceUri { get{} set{} }
	public XmlSchemaObject Parent { get{} set{} }
	public System.Xml.Serialization.XmlSerializerNamespaces Namespaces { get{} set{} }
}

