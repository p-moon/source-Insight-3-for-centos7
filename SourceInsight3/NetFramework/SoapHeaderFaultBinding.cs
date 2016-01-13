public class SoapHeaderFaultBinding : ServiceDescriptionFormatExtension
{

	// Constructors
	public SoapHeaderFaultBinding() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Xml.XmlQualifiedName Message { get{} set{} }
	public string Part { get{} set{} }
	public SoapBindingUse Use { get{} set{} }
	public string Encoding { get{} set{} }
	public string Namespace { get{} set{} }
	public object Parent { get{} }
	public bool Required { get{} set{} }
	public bool Handled { get{} set{} }
}

