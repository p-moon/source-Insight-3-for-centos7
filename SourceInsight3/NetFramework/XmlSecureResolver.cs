public class XmlSecureResolver : XmlResolver
{

	// Constructors
	public XmlSecureResolver(XmlResolver resolver, string securityUrl) {}
	public XmlSecureResolver(XmlResolver resolver, System.Security.Policy.Evidence evidence) {}
	public XmlSecureResolver(XmlResolver resolver, System.Security.PermissionSet permissionSet) {}

	// Methods
	public virtual object GetEntity(System.Uri absoluteUri, string role, Type ofObjectToReturn) {}
	public virtual System.Uri ResolveUri(System.Uri baseUri, string relativeUri) {}
	public static System.Security.Policy.Evidence CreateEvidenceForUrl(string securityUrl) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Net.ICredentials Credentials { set{} }
}

