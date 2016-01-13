public class ConfigXmlDocument : System.Xml.XmlDocument, System.ICloneable, System.Collections.IEnumerable, System.Xml.XPath.IXPathNavigable, System.Configuration.Internal.IConfigErrorInfo
{

	// Constructors
	public ConfigXmlDocument() {}

	// Methods
	public virtual void Load(string filename) {}
	public void LoadSingleElement(string filename, System.Xml.XmlTextReader sourceReader) {}
	public virtual System.Xml.XmlAttribute CreateAttribute(string prefix, string localName, string namespaceUri) {}
	public virtual System.Xml.XmlElement CreateElement(string prefix, string localName, string namespaceUri) {}
	public virtual System.Xml.XmlText CreateTextNode(string text) {}
	public virtual System.Xml.XmlCDataSection CreateCDataSection(string data) {}
	public virtual System.Xml.XmlComment CreateComment(string data) {}
	public virtual System.Xml.XmlSignificantWhitespace CreateSignificantWhitespace(string data) {}
	public virtual System.Xml.XmlWhitespace CreateWhitespace(string data) {}
	public virtual System.Xml.XmlNode CloneNode(bool deep) {}
	public virtual System.Xml.XmlDocumentType CreateDocumentType(string name, string publicId, string systemId, string internalSubset) {}
	public virtual System.Xml.XmlDocumentFragment CreateDocumentFragment() {}
	public virtual System.Xml.XmlEntityReference CreateEntityReference(string name) {}
	public virtual System.Xml.XmlProcessingInstruction CreateProcessingInstruction(string target, string data) {}
	public virtual System.Xml.XmlDeclaration CreateXmlDeclaration(string version, string encoding, string standalone) {}
	public virtual System.Xml.XPath.XPathNavigator CreateNavigator() {}
	public virtual System.Xml.XmlNodeList GetElementsByTagName(string name) {}
	public virtual System.Xml.XmlNodeList GetElementsByTagName(string localName, string namespaceURI) {}
	public virtual System.Xml.XmlElement GetElementById(string elementId) {}
	public virtual System.Xml.XmlNode ImportNode(System.Xml.XmlNode node, bool deep) {}
	public virtual System.Xml.XmlNode CreateNode(System.Xml.XmlNodeType type, string prefix, string name, string namespaceURI) {}
	public virtual System.Xml.XmlNode CreateNode(string nodeTypeString, string name, string namespaceURI) {}
	public virtual System.Xml.XmlNode CreateNode(System.Xml.XmlNodeType type, string name, string namespaceURI) {}
	public virtual System.Xml.XmlNode ReadNode(System.Xml.XmlReader reader) {}
	public virtual void Load(System.IO.Stream inStream) {}
	public virtual void Load(System.IO.TextReader txtReader) {}
	public virtual void Load(System.Xml.XmlReader reader) {}
	public virtual void LoadXml(string xml) {}
	public virtual void Save(string filename) {}
	public virtual void Save(System.IO.Stream outStream) {}
	public virtual void Save(System.IO.TextWriter writer) {}
	public virtual void Save(System.Xml.XmlWriter w) {}
	public virtual void WriteTo(System.Xml.XmlWriter w) {}
	public virtual void WriteContentTo(System.Xml.XmlWriter xw) {}
	public System.Xml.XmlAttribute CreateAttribute(string name) {}
	public System.Xml.XmlElement CreateElement(string name) {}
	public System.Xml.XmlAttribute CreateAttribute(string qualifiedName, string namespaceURI) {}
	public System.Xml.XmlElement CreateElement(string qualifiedName, string namespaceURI) {}
	public void Validate(System.Xml.Schema.ValidationEventHandler validationEventHandler) {}
	public void Validate(System.Xml.Schema.ValidationEventHandler validationEventHandler, System.Xml.XmlNode nodeToValidate) {}
	public virtual System.Xml.XmlNode InsertBefore(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild) {}
	public virtual System.Xml.XmlNode InsertAfter(System.Xml.XmlNode newChild, System.Xml.XmlNode refChild) {}
	public virtual System.Xml.XmlNode ReplaceChild(System.Xml.XmlNode newChild, System.Xml.XmlNode oldChild) {}
	public virtual System.Xml.XmlNode RemoveChild(System.Xml.XmlNode oldChild) {}
	public virtual System.Xml.XmlNode PrependChild(System.Xml.XmlNode newChild) {}
	public virtual System.Xml.XmlNode AppendChild(System.Xml.XmlNode newChild) {}
	public virtual void Normalize() {}
	public virtual bool Supports(string feature, string version) {}
	public virtual System.Xml.XmlNode Clone() {}
	public virtual void RemoveAll() {}
	public virtual string GetNamespaceOfPrefix(string prefix) {}
	public virtual string GetPrefixOfNamespace(string namespaceURI) {}
	public System.Xml.XmlNode SelectSingleNode(string xpath) {}
	public System.Xml.XmlNode SelectSingleNode(string xpath, System.Xml.XmlNamespaceManager nsmgr) {}
	public System.Xml.XmlNodeList SelectNodes(string xpath) {}
	public System.Xml.XmlNodeList SelectNodes(string xpath, System.Xml.XmlNamespaceManager nsmgr) {}
	public System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int LineNumber { get{} }
	public string Filename { get{} }
	public System.Xml.XmlNodeType NodeType { get{} }
	public System.Xml.XmlNode ParentNode { get{} }
	public System.Xml.XmlDocumentType DocumentType { get{} }
	public System.Xml.XmlImplementation Implementation { get{} }
	public string Name { get{} }
	public string LocalName { get{} }
	public System.Xml.XmlElement DocumentElement { get{} }
	public System.Xml.XmlDocument OwnerDocument { get{} }
	public System.Xml.Schema.XmlSchemaSet Schemas { get{} set{} }
	public System.Xml.XmlResolver XmlResolver { set{} }
	public System.Xml.XmlNameTable NameTable { get{} }
	public bool PreserveWhitespace { get{} set{} }
	public bool IsReadOnly { get{} }
	public string InnerXml { get{} set{} }
	public System.Xml.Schema.IXmlSchemaInfo SchemaInfo { get{} }
	public string BaseURI { get{} }
	public string Value { get{} set{} }
	public System.Xml.XmlNodeList ChildNodes { get{} }
	public System.Xml.XmlNode PreviousSibling { get{} }
	public System.Xml.XmlNode NextSibling { get{} }
	public System.Xml.XmlAttributeCollection Attributes { get{} }
	public System.Xml.XmlNode FirstChild { get{} }
	public System.Xml.XmlNode LastChild { get{} }
	public bool HasChildNodes { get{} }
	public string NamespaceURI { get{} }
	public string Prefix { get{} set{} }
	public string InnerText { get{} set{} }
	public string OuterXml { get{} }
	public System.Xml.XmlElement Item { get{} }
	public System.Xml.XmlElement Item { get{} }

	// Events
	public event System.Xml.XmlNodeChangedEventHandler NodeInserting;
	public event System.Xml.XmlNodeChangedEventHandler NodeInserted;
	public event System.Xml.XmlNodeChangedEventHandler NodeRemoving;
	public event System.Xml.XmlNodeChangedEventHandler NodeRemoved;
	public event System.Xml.XmlNodeChangedEventHandler NodeChanging;
	public event System.Xml.XmlNodeChangedEventHandler NodeChanged;
}

