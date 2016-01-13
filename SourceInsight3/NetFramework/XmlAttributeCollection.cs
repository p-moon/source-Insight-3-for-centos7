public class XmlAttributeCollection : XmlNamedNodeMap, System.Collections.IEnumerable, System.Collections.ICollection
{

	// Methods
	public virtual XmlNode SetNamedItem(XmlNode node) {}
	public XmlAttribute Prepend(XmlAttribute node) {}
	public XmlAttribute Append(XmlAttribute node) {}
	public XmlAttribute InsertBefore(XmlAttribute newNode, XmlAttribute refNode) {}
	public XmlAttribute InsertAfter(XmlAttribute newNode, XmlAttribute refNode) {}
	public XmlAttribute Remove(XmlAttribute node) {}
	public XmlAttribute RemoveAt(int i) {}
	public void RemoveAll() {}
	public void CopyTo(XmlAttribute[] array, int index) {}
	public virtual XmlNode GetNamedItem(string name) {}
	public virtual XmlNode RemoveNamedItem(string name) {}
	public virtual XmlNode Item(int index) {}
	public virtual XmlNode GetNamedItem(string localName, string namespaceURI) {}
	public virtual XmlNode RemoveNamedItem(string localName, string namespaceURI) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public XmlAttribute ItemOf { get{} }
	public XmlAttribute ItemOf { get{} }
	public XmlAttribute ItemOf { get{} }
	public int Count { get{} }
}

