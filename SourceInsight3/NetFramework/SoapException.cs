public class SoapException : System.SystemException, System.Runtime.Serialization.ISerializable, System.Runtime.InteropServices._Exception
{

	// Constructors
	public SoapException() {}
	public SoapException(string message, System.Xml.XmlQualifiedName code, string actor) {}
	public SoapException(string message, System.Xml.XmlQualifiedName code, string actor, System.Exception innerException) {}
	public SoapException(string message, System.Xml.XmlQualifiedName code) {}
	public SoapException(string message, System.Xml.XmlQualifiedName code, System.Exception innerException) {}
	public SoapException(string message, System.Xml.XmlQualifiedName code, string actor, System.Xml.XmlNode detail) {}
	public SoapException(string message, System.Xml.XmlQualifiedName code, string actor, System.Xml.XmlNode detail, System.Exception innerException) {}
	public SoapException(string message, System.Xml.XmlQualifiedName code, SoapFaultSubCode subCode) {}
	public SoapException(string message, System.Xml.XmlQualifiedName code, string actor, string role, System.Xml.XmlNode detail, SoapFaultSubCode subCode, System.Exception innerException) {}
	public SoapException(string message, System.Xml.XmlQualifiedName code, string actor, string role, string lang, System.Xml.XmlNode detail, SoapFaultSubCode subCode, System.Exception innerException) {}

	// Methods
	public static bool IsServerFaultCode(System.Xml.XmlQualifiedName code) {}
	public static bool IsClientFaultCode(System.Xml.XmlQualifiedName code) {}
	public static bool IsVersionMismatchFaultCode(System.Xml.XmlQualifiedName code) {}
	public static bool IsMustUnderstandFaultCode(System.Xml.XmlQualifiedName code) {}
	public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) {}
	public virtual System.Exception GetBaseException() {}
	public virtual string ToString() {}
	public virtual Type GetType() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public System.Xml.XmlQualifiedName ServerFaultCode;
	public System.Xml.XmlQualifiedName ClientFaultCode;
	public System.Xml.XmlQualifiedName VersionMismatchFaultCode;
	public System.Xml.XmlQualifiedName MustUnderstandFaultCode;
	public System.Xml.XmlQualifiedName DetailElementName;

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

