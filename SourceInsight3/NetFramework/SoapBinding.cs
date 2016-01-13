public class SoapBinding : ServiceDescriptionFormatExtension
{

	// Constructors
	public SoapBinding() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public string Namespace;
	public string HttpTransport;

	// Properties
	public string Transport { get{} set{} }
	public SoapBindingStyle Style { get{} set{} }
	public System.Xml.Schema.XmlSchema Schema { get{} }
	public object Parent { get{} }
	public bool Required { get{} set{} }
	public bool Handled { get{} set{} }
}

