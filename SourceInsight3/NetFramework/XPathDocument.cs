public class XPathDocument : IXPathNavigable
{

	// Constructors
	public XPathDocument(System.Xml.XmlReader reader) {}
	public XPathDocument(System.Xml.XmlReader reader, System.Xml.XmlSpace space) {}
	public XPathDocument(System.IO.TextReader textReader) {}
	public XPathDocument(System.IO.Stream stream) {}
	public XPathDocument(string uri) {}
	public XPathDocument(string uri, System.Xml.XmlSpace space) {}

	// Methods
	public virtual XPathNavigator CreateNavigator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

