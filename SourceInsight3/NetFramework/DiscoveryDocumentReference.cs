public class DiscoveryDocumentReference : DiscoveryReference
{

	// Constructors
	public DiscoveryDocumentReference() {}
	public DiscoveryDocumentReference(string href) {}

	// Methods
	public virtual void WriteDocument(object document, System.IO.Stream stream) {}
	public virtual object ReadDocument(System.IO.Stream stream) {}
	public void ResolveAll() {}
	public void Resolve() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Ref { get{} set{} }
	public string DefaultFilename { get{} }
	public DiscoveryDocument Document { get{} }
	public string Url { get{} set{} }
	public DiscoveryClientProtocol ClientProtocol { get{} set{} }
}

