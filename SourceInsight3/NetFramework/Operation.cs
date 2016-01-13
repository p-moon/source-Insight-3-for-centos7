public class Operation : NamedItem
{

	// Constructors
	public Operation() {}

	// Methods
	public bool IsBoundBy(OperationBinding operationBinding) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ServiceDescriptionFormatExtensionCollection Extensions { get{} }
	public PortType PortType { get{} }
	public string ParameterOrderString { get{} set{} }
	public string[] ParameterOrder { get{} set{} }
	public OperationMessageCollection Messages { get{} }
	public OperationFaultCollection Faults { get{} }
	public string Name { get{} set{} }
	public string Documentation { get{} set{} }
	public System.Xml.XmlElement DocumentationElement { get{} set{} }
	public System.Xml.XmlAttribute[] ExtensibleAttributes { get{} set{} }
	public System.Xml.Serialization.XmlSerializerNamespaces Namespaces { get{} set{} }
}

