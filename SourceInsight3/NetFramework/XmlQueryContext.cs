public class XmlQueryContext
{

	// Methods
	public System.Xml.XPath.XPathNavigator GetDataSource(string uriRelative, string uriBase) {}
	public object GetParameter(string localName, string namespaceUri) {}
	public object GetLateBoundObject(string namespaceUri) {}
	public bool LateBoundFunctionExists(string name, string namespaceUri) {}
	public IList<System.Xml.XPath.XPathItem> InvokeXsltLateBoundFunction(string name, string namespaceUri, IList<System.Xml.XPath.XPathItem>[] args) {}
	public void OnXsltMessageEncountered(string message) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Xml.XmlNameTable QueryNameTable { get{} }
	public System.Xml.XmlNameTable DefaultNameTable { get{} }
	public System.Xml.XPath.XPathNavigator DefaultDataSource { get{} }
}

