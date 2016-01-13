public class SoapFaultSubCode
{

	// Constructors
	public SoapFaultSubCode(System.Xml.XmlQualifiedName code) {}
	public SoapFaultSubCode(System.Xml.XmlQualifiedName code, SoapFaultSubCode subCode) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Xml.XmlQualifiedName Code { get{} }
	public SoapFaultSubCode SubCode { get{} }
}

