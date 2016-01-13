public class XmlUrlResolver : XmlResolver
{

	// Constructors
	public XmlUrlResolver() {}

	// Methods
	public virtual object GetEntity(System.Uri absoluteUri, string role, Type ofObjectToReturn) {}
	public virtual System.Uri ResolveUri(System.Uri baseUri, string relativeUri) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Net.ICredentials Credentials { set{} }
}

