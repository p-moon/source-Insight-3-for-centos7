public class XmlSchemaCollection : System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public XmlSchemaCollection() {}
	public XmlSchemaCollection(System.Xml.XmlNameTable nametable) {}

	// Methods
	public XmlSchema Add(string ns, string uri) {}
	public XmlSchema Add(string ns, System.Xml.XmlReader reader) {}
	public XmlSchema Add(string ns, System.Xml.XmlReader reader, System.Xml.XmlResolver resolver) {}
	public XmlSchema Add(XmlSchema schema) {}
	public XmlSchema Add(XmlSchema schema, System.Xml.XmlResolver resolver) {}
	public void Add(XmlSchemaCollection schema) {}
	public bool Contains(XmlSchema schema) {}
	public bool Contains(string ns) {}
	public XmlSchemaCollectionEnumerator GetEnumerator() {}
	public void CopyTo(XmlSchema[] array, int index) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Count { get{} }
	public System.Xml.XmlNameTable NameTable { get{} }
	public XmlSchema Item { get{} }

	// Events
	public event System.Xml.Schema.ValidationEventHandler ValidationEventHandler;
}

