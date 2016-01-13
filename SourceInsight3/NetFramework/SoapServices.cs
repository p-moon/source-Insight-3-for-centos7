public class SoapServices
{

	// Methods
	public static void RegisterInteropXmlElement(string xmlElement, string xmlNamespace, Type type) {}
	public static void RegisterInteropXmlType(string xmlType, string xmlTypeNamespace, Type type) {}
	public static void PreLoad(Type type) {}
	public static void PreLoad(System.Reflection.Assembly assembly) {}
	public static Type GetInteropTypeFromXmlElement(string xmlElement, string xmlNamespace) {}
	public static Type GetInteropTypeFromXmlType(string xmlType, string xmlTypeNamespace) {}
	public static void GetInteropFieldTypeAndNameFromXmlElement(Type containingType, string xmlElement, string xmlNamespaceout , System.Type& typeout , System.String& name) {}
	public static void GetInteropFieldTypeAndNameFromXmlAttribute(Type containingType, string xmlAttribute, string xmlNamespaceout , System.Type& typeout , System.String& name) {}
	public static bool GetXmlElementForInteropType(Type typeout , System.String& xmlElementout , System.String& xmlNamespace) {}
	public static bool GetXmlTypeForInteropType(Type typeout , System.String& xmlTypeout , System.String& xmlTypeNamespace) {}
	public static string GetXmlNamespaceForMethodCall(System.Reflection.MethodBase mb) {}
	public static string GetXmlNamespaceForMethodResponse(System.Reflection.MethodBase mb) {}
	public static void RegisterSoapActionForMethodBase(System.Reflection.MethodBase mb) {}
	public static void RegisterSoapActionForMethodBase(System.Reflection.MethodBase mb, string soapAction) {}
	public static string GetSoapActionFromMethodBase(System.Reflection.MethodBase mb) {}
	public static bool IsSoapActionValidForMethodBase(string soapAction, System.Reflection.MethodBase mb) {}
	public static bool GetTypeAndMethodNameFromSoapAction(string soapActionout , System.String& typeNameout , System.String& methodName) {}
	public static bool IsClrTypeNamespace(string namespaceString) {}
	public static string CodeXmlNamespaceForClrTypeNamespace(string typeNamespace, string assemblyName) {}
	public static bool DecodeXmlNamespaceForClrTypeNamespace(string inNamespaceout , System.String& typeNamespaceout , System.String& assemblyName) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string XmlNsForClrType { get{} }
	public string XmlNsForClrTypeWithAssembly { get{} }
	public string XmlNsForClrTypeWithNs { get{} }
	public string XmlNsForClrTypeWithNsAndAssembly { get{} }
}

