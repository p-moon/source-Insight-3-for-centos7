public class SoapServerType : ServerType
{

	// Constructors
	public SoapServerType(Type type, System.Web.Services.Configuration.WebServiceProtocols protocolsSupported) {}

	// Methods
	public SoapServerMethod GetMethod(object key) {}
	public SoapServerMethod GetDuplicateMethod(object key) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string ServiceNamespace { get{} }
	public bool ServiceDefaultIsEncoded { get{} }
	public bool ServiceRoutingOnSoapAction { get{} }
}

