public class ProtocolReflector
{

	// Methods
	public ServiceDescription GetServiceDescription(string ns) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public Service Service { get{} }
	public ServiceDescription ServiceDescription { get{} }
	public ServiceDescriptionCollection ServiceDescriptions { get{} }
	public System.Xml.Serialization.XmlSchemas Schemas { get{} }
	public System.Xml.Serialization.XmlSchemaExporter SchemaExporter { get{} }
	public System.Xml.Serialization.XmlReflectionImporter ReflectionImporter { get{} }
	public string DefaultNamespace { get{} }
	public string ServiceUrl { get{} }
	public Type ServiceType { get{} }
	public System.Web.Services.Protocols.LogicalMethodInfo Method { get{} }
	public Binding Binding { get{} }
	public PortType PortType { get{} }
	public Port Port { get{} }
	public Operation Operation { get{} }
	public OperationBinding OperationBinding { get{} }
	public System.Web.Services.WebMethodAttribute MethodAttribute { get{} }
	public System.Web.Services.Protocols.LogicalMethodInfo[] Methods { get{} }
	public Message InputMessage { get{} }
	public Message OutputMessage { get{} }
	public MessageCollection HeaderMessages { get{} }
	public string ProtocolName { get{} }
}

