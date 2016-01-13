public class SoapHeaderException : SoapException, System.Runtime.Serialization.ISerializable, System.Runtime.InteropServices._Exception
{

	// Constructors
	public SoapHeaderException() {}
	public SoapHeaderException(string message, System.Xml.XmlQualifiedName code, string actor) {}
	public SoapHeaderException(string message, System.Xml.XmlQualifiedName code, string actor, System.Exception innerException) {}
	public SoapHeaderException(string message, System.Xml.XmlQualifiedName code) {}
	public SoapHeaderException(string message, System.Xml.XmlQualifiedName code, System.Exception innerException) {}
	public SoapHeaderException(string message, System.Xml.XmlQualifiedName code, string actor, string role, SoapFaultSubCode subCode, System.Exception innerException) {}
	public SoapHeaderException(string message, System.Xml.XmlQualifiedName code, string actor, string role, string lang, SoapFaultSubCode subCode, System.Exception innerException) {}

	// Methods
	public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) {}
	public virtual System.Exception GetBaseException() {}
	public virtual string ToString() {}
	public virtual Type GetType() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Actor { get{} }
	public System.Xml.XmlQualifiedName Code { get{} }
	public System.Xml.XmlNode Detail { get{} }
	public string Lang { get{} }
	public string Node { get{} }
	public string Role { get{} }
	public SoapFaultSubCode SubCode { get{} }
	public string Message { get{} }
	public System.Collections.IDictionary Data { get{} }
	public System.Exception InnerException { get{} }
	public System.Reflection.MethodBase TargetSite { get{} }
	public string StackTrace { get{} }
	public string HelpLink { get{} set{} }
	public string Source { get{} set{} }
}

