public class XmlDocument : XmlNode, System.ICloneable, System.Collections.IEnumerable, System.Xml.XPath.IXPathNavigable
{

	// Constructors
	public XmlDocument() {}
	public XmlDocument(XmlNameTable nt) {}

	// Methods
	public virtual XmlNode CloneNode(bool deep) {}
	public virtual XmlDocumentType CreateDocumentType(string name, string publicId, string systemId, string internalSubset) {}
	public virtual XmlDocumentFragment CreateDocumentFragment() {}
	public virtual XmlEntityReference CreateEntityReference(string name) {}
	public virtual XmlProcessingInstruction CreateProcessingInstruction(string target, string data) {}
	public virtual XmlDeclaration CreateXmlDeclaration(string version, string encoding, string standalone) {}
	public virtual XmlText CreateTextNode(string text) {}
	public virtual System.Xml.XPath.XPathNavigator CreateNavigator() {}
	public virtual XmlNodeList GetElementsByTagName(string name) {}
	public virtual XmlNodeList GetElementsByTagName(string localName, string namespaceURI) {}
	public virtual XmlElement GetElementById(string elementId) {}
	public virtual XmlNode ImportNode(XmlNode node, bool deep) {}
	public virtual XmlNode CreateNode(XmlNodeType type, string prefix, string name, string namespaceURI) {}
	public virtual XmlNode CreateNode(string nodeTypeString, string name, string namespaceURI) {}
	public virtual XmlNode CreateNode(XmlNodeType type, string name, string namespaceURI) {}
	public virtual XmlNode ReadNode(XmlReader reader) {}
	public virtual void Load(System.IO.Stream inStream) {}
	public virtual void Load(System.IO.TextReader txtReader) {}
	public virtual void Load(XmlReader reader) {}
	public virtual void LoadXml(string xml) {}
	public virtual void Save(string filename) {}
	public virtual void Save(System.IO.Stream outStream) {}
	public virtual void Save(System.IO.TextWriter writer) {}
	public virtual void Save(XmlWriter w) {}
	public virtual void WriteTo(XmlWriter w) {}
	public virtual void WriteContentTo(XmlWriter xw) {}
	public XmlAttribute CreateAttribute(string name) {}
	public virtual XmlCDataSection CreateCDataSection(string data) {}
	public virtual XmlComment CreateComment(string data) {}
	public XmlElement CreateElement(string name) {}
	public virtual XmlSignificantWhitespace CreateSignificantWhitespace(string text) {}
	public virtual XmlWhitespace CreateWhitespace(string text) {}
	public XmlAttribute CreateAttribute(string qualifiedName, string namespaceURI) {}
	public XmlElement CreateElement(string qualifiedName, string namespaceURI) {}
	public virtual XmlAttribute CreateAttribute(string prefix, string localName, string namespaceURI) {}
	public virtual XmlElement CreateElement(string prefix, string localName, string namespaceURI) {}
	public virtual void Load(string filename) {}
	public void Validate(System.Xml.Schema.ValidationEventHandler validationEventHandler) {}
	public void Validate(System.Xml.Schema.ValidationEventHandler validationEventHandler, XmlNode nodeToValidate) {}
	public virtual XmlNode InsertBefore(XmlNode newChild, XmlNode refChild) {}
	public virtual XmlNode InsertAfter(XmlNode newChild, XmlNode refChild) {}
	public virtual XmlNode ReplaceChild(XmlNode newChild, XmlNode oldChild) {}
	public virtual XmlNode RemoveChild(XmlNode oldChild) {}
	public virtual XmlNode PrependChild(XmlNode newChild) {}
	public virtual XmlNode AppendChild(XmlNode newChild) {}
	public virtual void Normalize() {}
	public virtual bool Supports(string feature, string version) {}
	public virtual XmlNode Clone() {}
	public virtual void RemoveAll() {}
	public virtual string GetNamespaceOfPrefix(string prefix) {}
	public virtual string GetPrefixOfNamespace(string namespaceURI) {}
	public XmlNode SelectSingleNode(string xpath) {}
	public XmlNode SelectSingleNode(string xpath, XmlNamespaceManager nsmgr) {}
	public XmlNodeList SelectNodes(string xpath) {}
	public XmlNodeList SelectNodes(string xpath, XmlNamespaceManager nsmgr) {}
	public System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public XmlNodeType NodeType { get{} }
	public XmlNode ParentNode { get{} }
	public XmlDocumentType DocumentType { get{} }
	public XmlImplementation Implementation { get{} }
	public string Name { get{} }
	public string LocalName { get{} }
	public XmlElement DocumentElement { get{} }
	public XmlDocument OwnerDocument { get{} }
	public System.Xml.Schema.XmlSchemaSet Schemas { get{} set{} }
	public XmlResolver XmlResolver { set{} }
	public XmlNameTable NameTable { get{} }
	public bool PreserveWhitespace { get{} set{} }
	public bool IsReadOnly { get{} }
	public string InnerXml { get{} set{} }
	public System.Xml.Schema.IXmlSchemaInfo SchemaInfo { get{} }
	public string BaseURI { get{} }
	public string Value { get{} set{} }
	public XmlNodeList ChildNodes { get{} }
	public XmlNode PreviousSibling { get{} }
	public XmlNode NextSibling { get{} }
	public XmlAttributeCollection Attributes { get{} }
	public XmlNode FirstChild { get{} }
	public XmlNode LastChild { get{} }
	public bool HasChildNodes { get{} }
	public string NamespaceURI { get{} }
	public string Prefix { get{} set{} }
	public string InnerText { get{} set{} }
	public string OuterXml { get{} }
	public XmlElement Item { get{} }
	public XmlElement Item { get{} }

	// Events
	public event System.Xml.XmlNodeChangedEventHandler NodeInserting;
	public event System.Xml.XmlNodeChangedEventHandler NodeInserted;
	public event System.Xml.XmlNodeChangedEventHandler NodeRemoving;
	public event System.Xml.XmlNodeChangedEventHandler NodeRemoved;
	public event System.Xml.XmlNodeChangedEventHandler NodeChanging;
	public event System.Xml.XmlNodeChangedEventHandler NodeChanged;
}

