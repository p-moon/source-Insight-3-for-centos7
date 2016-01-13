public class OperationBinding : NamedItem
{

	// Constructors
	public OperationBinding() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public Binding Binding { get{} }
	public ServiceDescriptionFormatExtensionCollection Extensions { get{} }
	public InputBinding Input { get{} set{} }
	public OutputBinding Output { get{} set{} }
	public FaultBindingCollection Faults { get{} }
	public string Name { get{} set{} }
	public string Documentation { get{} set{} }
	public System.Xml.XmlElement DocumentationElement { get{} set{} }
	public System.Xml.XmlAttribute[] ExtensibleAttributes { get{} set{} }
	public System.Xml.Serialization.XmlSerializerNamespaces Namespaces { get{} set{} }
}

