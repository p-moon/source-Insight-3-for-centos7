public class ServiceDescription : NamedItem
{

	// Constructors
	public ServiceDescription() {}

	// Methods
	public static ServiceDescription Read(System.IO.TextReader textReader) {}
	public static ServiceDescription Read(System.IO.Stream stream) {}
	public static ServiceDescription Read(System.Xml.XmlReader reader) {}
	public static ServiceDescription Read(string fileName) {}
	public static ServiceDescription Read(System.IO.TextReader textReader, bool validate) {}
	public static ServiceDescription Read(System.IO.Stream stream, bool validate) {}
	public static ServiceDescription Read(string fileName, bool validate) {}
	public static ServiceDescription Read(System.Xml.XmlReader reader, bool validate) {}
	public static bool CanRead(System.Xml.XmlReader reader) {}
	public void Write(string fileName) {}
	public void Write(System.IO.TextWriter writer) {}
	public void Write(System.IO.Stream stream) {}
	public void Write(System.Xml.XmlWriter writer) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public string Namespace;

	// Properties
	public string RetrievalUrl { get{} set{} }
	public ServiceDescriptionCollection ServiceDescriptions { get{} }
	public ServiceDescriptionFormatExtensionCollection Extensions { get{} }
	public ImportCollection Imports { get{} }
	public Types Types { get{} set{} }
	public MessageCollection Messages { get{} }
	public PortTypeCollection PortTypes { get{} }
	public BindingCollection Bindings { get{} }
	public ServiceCollection Services { get{} }
	public string TargetNamespace { get{} set{} }
	public System.Xml.Schema.XmlSchema Schema { get{} }
	public System.Collections.Specialized.StringCollection ValidationWarnings { get{} }
	public System.Xml.Serialization.XmlSerializer Serializer { get{} }
	public string Name { get{} set{} }
	public string Documentation { get{} set{} }
	public System.Xml.XmlElement DocumentationElement { get{} set{} }
	public System.Xml.XmlAttribute[] ExtensibleAttributes { get{} set{} }
	public System.Xml.Serialization.XmlSerializerNamespaces Namespaces { get{} set{} }
}

