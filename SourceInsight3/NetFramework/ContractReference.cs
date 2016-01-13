public class ContractReference : DiscoveryReference
{

	// Constructors
	public ContractReference() {}
	public ContractReference(string href) {}
	public ContractReference(string href, string docRef) {}

	// Methods
	public virtual void WriteDocument(object document, System.IO.Stream stream) {}
	public virtual object ReadDocument(System.IO.Stream stream) {}
	public void Resolve() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public string Namespace;

	// Properties
	public string Ref { get{} set{} }
	public string DocRef { get{} set{} }
	public string Url { get{} set{} }
	public System.Web.Services.Description.ServiceDescription Contract { get{} }
	public string DefaultFilename { get{} }
	public DiscoveryClientProtocol ClientProtocol { get{} set{} }
}

