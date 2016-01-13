public class Soap12FaultCodes
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public System.Xml.XmlQualifiedName ReceiverFaultCode;
	public System.Xml.XmlQualifiedName SenderFaultCode;
	public System.Xml.XmlQualifiedName VersionMismatchFaultCode;
	public System.Xml.XmlQualifiedName MustUnderstandFaultCode;
	public System.Xml.XmlQualifiedName DataEncodingUnknownFaultCode;
	public System.Xml.XmlQualifiedName RpcProcedureNotPresentFaultCode;
	public System.Xml.XmlQualifiedName RpcBadArgumentsFaultCode;
	public System.Xml.XmlQualifiedName EncodingMissingIdFaultCode;
	public System.Xml.XmlQualifiedName EncodingUntypedValueFaultCode;
}

