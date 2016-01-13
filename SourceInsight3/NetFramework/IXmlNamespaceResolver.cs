public interface IXmlNamespaceResolver
{

	// Methods
	public abstract virtual IDictionary<string,string> GetNamespacesInScope(XmlNamespaceScope scope) {}
	public abstract virtual string LookupNamespace(string prefix) {}
	public abstract virtual string LookupPrefix(string namespaceName) {}
}

