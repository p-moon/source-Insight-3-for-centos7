public class XmlSchemas : System.Collections.CollectionBase, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable, IEnumerable<System.Xml.Schema.XmlSchema>
{

	// Constructors
	public XmlSchemas() {}

	// Methods
	public System.Collections.IList GetSchemas(string ns) {}
	public int Add(System.Xml.Schema.XmlSchema schema) {}
	public int Add(System.Xml.Schema.XmlSchema schema, System.Uri baseUri) {}
	public void Add(XmlSchemas schemas) {}
	public void AddReference(System.Xml.Schema.XmlSchema schema) {}
	public void Insert(int index, System.Xml.Schema.XmlSchema schema) {}
	public int IndexOf(System.Xml.Schema.XmlSchema schema) {}
	public bool Contains(System.Xml.Schema.XmlSchema schema) {}
	public bool Contains(string targetNamespace) {}
	public void Remove(System.Xml.Schema.XmlSchema schema) {}
	public void CopyTo(System.Xml.Schema.XmlSchema[] array, int index) {}
	public object Find(System.Xml.XmlQualifiedName name, Type type) {}
	public static bool IsDataSet(System.Xml.Schema.XmlSchema schema) {}
	public void Compile(System.Xml.Schema.ValidationEventHandler handler, bool fullCompile) {}
	public virtual void Clear() {}
	public virtual void RemoveAt(int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Xml.Schema.XmlSchema Item { get{} set{} }
	public System.Xml.Schema.XmlSchema Item { get{} }
	public bool IsCompiled { get{} }
	public int Capacity { get{} set{} }
	public int Count { get{} }
}

