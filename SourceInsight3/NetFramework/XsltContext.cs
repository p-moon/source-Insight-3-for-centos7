public class XsltContext : System.Xml.XmlNamespaceManager, System.Xml.IXmlNamespaceResolver, System.Collections.IEnumerable
{

	// Methods
	public abstract virtual IXsltContextVariable ResolveVariable(string prefix, string name) {}
	public abstract virtual IXsltContextFunction ResolveFunction(string prefix, string name, System.Xml.XPath.XPathResultType[] ArgTypes) {}
	public abstract virtual bool PreserveWhitespace(System.Xml.XPath.XPathNavigator node) {}
	public abstract virtual int CompareDocument(string baseUri, string nextbaseUri) {}
	public virtual void AddNamespace(string prefix, string uri) {}
	public virtual void PushScope() {}
	public virtual bool PopScope() {}
	public virtual void RemoveNamespace(string prefix, string uri) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public virtual IDictionary<string,string> GetNamespacesInScope(System.Xml.XmlNamespaceScope scope) {}
	public virtual string LookupNamespace(string prefix) {}
	public virtual string LookupPrefix(string uri) {}
	public virtual bool HasNamespace(string prefix) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool Whitespace { get{} }
	public System.Xml.XmlNameTable NameTable { get{} }
	public string DefaultNamespace { get{} }
}

