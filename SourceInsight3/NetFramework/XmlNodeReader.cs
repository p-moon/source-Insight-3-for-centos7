public class XmlNodeReader : XmlReader, System.IDisposable, IXmlNamespaceResolver
{

	// Constructors
	public XmlNodeReader(XmlNode node) {}

	// Methods
	public virtual string GetAttribute(string name) {}
	public virtual string GetAttribute(string name, string namespaceURI) {}
	public virtual string GetAttribute(int attributeIndex) {}
	public virtual bool MoveToAttribute(string name) {}
	public virtual bool MoveToAttribute(string name, string namespaceURI) {}
	public virtual void MoveToAttribute(int attributeIndex) {}
	public virtual bool MoveToFirstAttribute() {}
	public virtual bool MoveToNextAttribute() {}
	public virtual bool MoveToElement() {}
	public virtual bool Read() {}
	public virtual void Close() {}
	public virtual void Skip() {}
	public virtual string ReadString() {}
	public virtual string LookupNamespace(string prefix) {}
	public virtual void ResolveEntity() {}
	public virtual bool ReadAttributeValue() {}
	public virtual int ReadContentAsBase64(byte[] buffer, int index, int count) {}
	public virtual int ReadContentAsBinHex(byte[] buffer, int index, int count) {}
	public virtual int ReadElementContentAsBase64(byte[] buffer, int index, int count) {}
	public virtual int ReadElementContentAsBinHex(byte[] buffer, int index, int count) {}
	public virtual object ReadContentAsObject() {}
	public virtual bool ReadContentAsBoolean() {}
	public virtual System.DateTime ReadContentAsDateTime() {}
	public virtual double ReadContentAsDouble() {}
	public virtual float ReadContentAsFloat() {}
	public virtual decimal ReadContentAsDecimal() {}
	public virtual int ReadContentAsInt() {}
	public virtual long ReadContentAsLong() {}
	public virtual string ReadContentAsString() {}
	public virtual object ReadContentAs(Type returnType, IXmlNamespaceResolver namespaceResolver) {}
	public virtual object ReadElementContentAsObject() {}
	public virtual object ReadElementContentAsObject(string localName, string namespaceURI) {}
	public virtual bool ReadElementContentAsBoolean() {}
	public virtual bool ReadElementContentAsBoolean(string localName, string namespaceURI) {}
	public virtual System.DateTime ReadElementContentAsDateTime() {}
	public virtual System.DateTime ReadElementContentAsDateTime(string localName, string namespaceURI) {}
	public virtual double ReadElementContentAsDouble() {}
	public virtual double ReadElementContentAsDouble(string localName, string namespaceURI) {}
	public virtual float ReadElementContentAsFloat() {}
	public virtual float ReadElementContentAsFloat(string localName, string namespaceURI) {}
	public virtual decimal ReadElementContentAsDecimal() {}
	public virtual decimal ReadElementContentAsDecimal(string localName, string namespaceURI) {}
	public virtual int ReadElementContentAsInt() {}
	public virtual int ReadElementContentAsInt(string localName, string namespaceURI) {}
	public virtual long ReadElementContentAsLong() {}
	public virtual long ReadElementContentAsLong(string localName, string namespaceURI) {}
	public virtual string ReadElementContentAsString() {}
	public virtual string ReadElementContentAsString(string localName, string namespaceURI) {}
	public virtual object ReadElementContentAs(Type returnType, IXmlNamespaceResolver namespaceResolver) {}
	public virtual object ReadElementContentAs(Type returnType, IXmlNamespaceResolver namespaceResolver, string localName, string namespaceURI) {}
	public virtual int ReadValueChunk(char[] buffer, int index, int count) {}
	public virtual XmlNodeType MoveToContent() {}
	public virtual void ReadStartElement() {}
	public virtual void ReadStartElement(string name) {}
	public virtual void ReadStartElement(string localname, string ns) {}
	public virtual string ReadElementString() {}
	public virtual string ReadElementString(string name) {}
	public virtual string ReadElementString(string localname, string ns) {}
	public virtual void ReadEndElement() {}
	public virtual bool IsStartElement() {}
	public virtual bool IsStartElement(string name) {}
	public virtual bool IsStartElement(string localname, string ns) {}
	public virtual bool ReadToFollowing(string name) {}
	public virtual bool ReadToFollowing(string localName, string namespaceURI) {}
	public virtual bool ReadToDescendant(string name) {}
	public virtual bool ReadToDescendant(string localName, string namespaceURI) {}
	public virtual bool ReadToNextSibling(string name) {}
	public virtual bool ReadToNextSibling(string localName, string namespaceURI) {}
	public virtual string ReadInnerXml() {}
	public virtual string ReadOuterXml() {}
	public virtual XmlReader ReadSubtree() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public XmlNodeType NodeType { get{} }
	public string Name { get{} }
	public string LocalName { get{} }
	public string NamespaceURI { get{} }
	public string Prefix { get{} }
	public bool HasValue { get{} }
	public string Value { get{} }
	public int Depth { get{} }
	public string BaseURI { get{} }
	public bool CanResolveEntity { get{} }
	public bool IsEmptyElement { get{} }
	public bool IsDefault { get{} }
	public XmlSpace XmlSpace { get{} }
	public string XmlLang { get{} }
	public System.Xml.Schema.IXmlSchemaInfo SchemaInfo { get{} }
	public int AttributeCount { get{} }
	public bool EOF { get{} }
	public ReadState ReadState { get{} }
	public bool HasAttributes { get{} }
	public XmlNameTable NameTable { get{} }
	public bool CanReadBinaryContent { get{} }
	public XmlReaderSettings Settings { get{} }
	public char QuoteChar { get{} }
	public Type ValueType { get{} }
	public string Item { get{} }
	public string Item { get{} }
	public string Item { get{} }
	public bool CanReadValueChunk { get{} }
}

