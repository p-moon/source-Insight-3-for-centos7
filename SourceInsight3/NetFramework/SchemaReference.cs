public class SchemaReference : DiscoveryReference
{

	// Constructors
	public SchemaReference() {}
	public SchemaReference(string url) {}

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
	public string TargetNamespace { get{} set{} }
	public string Url { get{} set{} }
	public string DefaultFilename { get{} }
	public System.Xml.Schema.XmlSchema Schema { get{} }
	public DiscoveryClientProtocol ClientProtocol { get{} set{} }
}

