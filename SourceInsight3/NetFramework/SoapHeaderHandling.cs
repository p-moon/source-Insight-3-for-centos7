public class SoapHeaderHandling
{

	// Constructors
	public SoapHeaderHandling() {}

	// Methods
	public string ReadHeaders(System.Xml.XmlReader reader, System.Xml.Serialization.XmlSerializer serializer, SoapHeaderCollection headers, SoapHeaderMapping[] mappings, SoapHeaderDirection direction, string envelopeNS, string encodingStyle, bool checkRequiredHeaders) {}
	public static void WriteHeaders(System.Xml.XmlWriter writer, System.Xml.Serialization.XmlSerializer serializer, SoapHeaderCollection headers, SoapHeaderMapping[] mappings, SoapHeaderDirection direction, bool isEncoded, string defaultNS, bool serviceDefaultIsEncoded, string envelopeNS) {}
	public static void WriteUnknownHeaders(System.Xml.XmlWriter writer, SoapHeaderCollection headers, string envelopeNS) {}
	public static void SetHeaderMembers(SoapHeaderCollection headers, object target, SoapHeaderMapping[] mappings, SoapHeaderDirection direction, bool client) {}
	public static void GetHeaderMembers(SoapHeaderCollection headers, object target, SoapHeaderMapping[] mappings, SoapHeaderDirection direction, bool client) {}
	public static void EnsureHeadersUnderstood(SoapHeaderCollection headers) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}

