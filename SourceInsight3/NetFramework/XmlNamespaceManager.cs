public class XmlNamespaceManager : IXmlNamespaceResolver, System.Collections.IEnumerable
{

	// Constructors
	public XmlNamespaceManager(XmlNameTable nameTable) {}

	// Methods
	public virtual void AddNamespace(string prefix, string uri) {}
	public virtual void PushScope() {}
	public virtual bool PopScope() {}
	public virtual void RemoveNamespace(string prefix, string uri) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public virtual IDictionary<string,string> GetNamespacesInScope(XmlNamespaceScope scope) {}
	public virtual string LookupNamespace(string prefix) {}
	public virtual string LookupPrefix(string uri) {}
	public virtual bool HasNamespace(string prefix) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public XmlNameTable NameTable { get{} }
	public string DefaultNamespace { get{} }
}

