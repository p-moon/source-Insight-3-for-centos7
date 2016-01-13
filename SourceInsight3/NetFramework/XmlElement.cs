public class XmlElement : XmlLinkedNode, System.ICloneable, System.Collections.IEnumerable, System.Xml.XPath.IXPathNavigable
{

	// Methods
	public virtual XmlNode CloneNode(bool deep) {}
	public virtual string GetAttribute(string name) {}
	public virtual void SetAttribute(string name, string value) {}
	public virtual void RemoveAttribute(string name) {}
	public virtual XmlAttribute GetAttributeNode(string name) {}
	public virtual XmlAttribute SetAttributeNode(XmlAttribute newAttr) {}
	public virtual XmlAttribute RemoveAttributeNode(XmlAttribute oldAttr) {}
	public virtual XmlNodeList GetElementsByTagName(string name) {}
	public virtual string GetAttribute(string localName, string namespaceURI) {}
	public virtual string SetAttribute(string localName, string namespaceURI, string value) {}
	public virtual void RemoveAttribute(string localName, string namespaceURI) {}
	public virtual XmlAttribute GetAttributeNode(string localName, string namespaceURI) {}
	public virtual XmlAttribute SetAttributeNode(string localName, string namespaceURI) {}
	public virtual XmlAttribute RemoveAttributeNode(string localName, string namespaceURI) {}
	public virtual XmlNodeList GetElementsByTagName(string localName, string namespaceURI) {}
	public virtual bool HasAttribute(string name) {}
	public virtual bool HasAttribute(string localName, string namespaceURI) {}
	public virtual void WriteTo(XmlWriter w) {}
	public virtual void WriteContentTo(XmlWriter w) {}
	public virtual XmlNode RemoveAttributeAt(int i) {}
	public virtual void RemoveAllAttributes() {}
	public virtual void RemoveAll() {}
	public virtual XmlNode InsertBefore(XmlNode newChild, XmlNode refChild) {}
	public virtual XmlNode InsertAfter(XmlNode newChild, XmlNode refChild) {}
	public virtual XmlNode ReplaceChild(XmlNode newChild, XmlNode oldChild) {}
	public virtual XmlNode RemoveChild(XmlNode oldChild) {}
	public virtual XmlNode PrependChild(XmlNode newChild) {}
	public virtual XmlNode AppendChild(XmlNode newChild) {}
	public virtual void Normalize() {}
	public virtual bool Supports(string feature, string version) {}
	public virtual XmlNode Clone() {}
	public virtual string GetNamespaceOfPrefix(string prefix) {}
	public virtual string GetPrefixOfNamespace(string namespaceURI) {}
	public virtual System.Xml.XPath.XPathNavigator CreateNavigator() {}
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
	public string Name { get{} }
	public string LocalName { get{} }
	public string NamespaceURI { get{} }
	public string Prefix { get{} set{} }
	public XmlNodeType NodeType { get{} }
	public XmlNode ParentNode { get{} }
	public XmlDocument OwnerDocument { get{} }
	public bool IsEmpty { get{} set{} }
	public XmlAttributeCollection Attributes { get{} }
	public bool HasAttributes { get{} }
	public System.Xml.Schema.IXmlSchemaInfo SchemaInfo { get{} }
	public string InnerXml { get{} set{} }
	public string InnerText { get{} set{} }
	public XmlNode NextSibling { get{} }
	public XmlNode PreviousSibling { get{} }
	public string Value { get{} set{} }
	public XmlNodeList ChildNodes { get{} }
	public XmlNode FirstChild { get{} }
	public XmlNode LastChild { get{} }
	public bool HasChildNodes { get{} }
	public bool IsReadOnly { get{} }
	public string OuterXml { get{} }
	public string BaseURI { get{} }
	public XmlElement Item { get{} }
	public XmlElement Item { get{} }
}

