public class XmlSchemaSet
{

	// Constructors
	public XmlSchemaSet() {}
	public XmlSchemaSet(System.Xml.XmlNameTable nameTable) {}

	// Methods
	public XmlSchema Add(string targetNamespace, string schemaUri) {}
	public XmlSchema Add(string targetNamespace, System.Xml.XmlReader schemaDocument) {}
	public void Add(XmlSchemaSet schemas) {}
	public XmlSchema Add(XmlSchema schema) {}
	public XmlSchema Remove(XmlSchema schema) {}
	public bool RemoveRecursive(XmlSchema schemaToRemove) {}
	public bool Contains(string targetNamespace) {}
	public bool Contains(XmlSchema schema) {}
	public void Compile() {}
	public XmlSchema Reprocess(XmlSchema schema) {}
	public void CopyTo(XmlSchema[] schemas, int index) {}
	public System.Collections.ICollection Schemas() {}
	public System.Collections.ICollection Schemas(string targetNamespace) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Xml.XmlNameTable NameTable { get{} }
	public bool IsCompiled { get{} }
	public System.Xml.XmlResolver XmlResolver { set{} }
	public XmlSchemaCompilationSettings CompilationSettings { get{} set{} }
	public int Count { get{} }
	public XmlSchemaObjectTable GlobalElements { get{} }
	public XmlSchemaObjectTable GlobalAttributes { get{} }
	public XmlSchemaObjectTable GlobalTypes { get{} }

	// Events
	public event System.Xml.Schema.ValidationEventHandler ValidationEventHandler;
}

