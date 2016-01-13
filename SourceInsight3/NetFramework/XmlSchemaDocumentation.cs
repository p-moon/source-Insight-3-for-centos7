public class XmlSchemaDocumentation : XmlSchemaObject
{

	// Constructors
	public XmlSchemaDocumentation() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Source { get{} set{} }
	public string Language { get{} set{} }
	public System.Xml.XmlNode[] Markup { get{} set{} }
	public int LineNumber { get{} set{} }
	public int LinePosition { get{} set{} }
	public string SourceUri { get{} set{} }
	public XmlSchemaObject Parent { get{} set{} }
	public System.Xml.Serialization.XmlSerializerNamespaces Namespaces { get{} set{} }
}

