public class XmlResolver
{

	// Methods
	public virtual System.Uri ResolveUri(System.Uri baseUri, string relativeUri) {}
	public abstract virtual object GetEntity(System.Uri absoluteUri, string role, Type ofObjectToReturn) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Net.ICredentials Credentials { set{} }
}

