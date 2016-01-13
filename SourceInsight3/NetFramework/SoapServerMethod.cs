public class SoapServerMethod
{

	// Constructors
	public SoapServerMethod() {}
	public SoapServerMethod(Type serverType, LogicalMethodInfo methodInfo) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public LogicalMethodInfo MethodInfo { get{} }
	public System.Xml.Serialization.XmlSerializer ReturnSerializer { get{} }
	public System.Xml.Serialization.XmlSerializer ParameterSerializer { get{} }
	public System.Xml.Serialization.XmlSerializer InHeaderSerializer { get{} }
	public System.Xml.Serialization.XmlSerializer OutHeaderSerializer { get{} }
	public SoapHeaderMapping[] InHeaderMappings { get{} }
	public SoapHeaderMapping[] OutHeaderMappings { get{} }
	public string Action { get{} }
	public bool OneWay { get{} }
	public bool Rpc { get{} }
	public System.Web.Services.Description.SoapBindingUse BindingUse { get{} }
	public SoapParameterStyle ParameterStyle { get{} }
	public System.Web.Services.WsiProfiles WsiClaims { get{} }
}

