public class XmlNamedNodeMap : System.Collections.IEnumerable
{

	// Methods
	public virtual XmlNode GetNamedItem(string name) {}
	public virtual XmlNode SetNamedItem(XmlNode node) {}
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
	public int Count { get{} }
}

