public class WebServicesSection : System.Configuration.ConfigurationSection
{

	// Constructors
	public WebServicesSection() {}

	// Methods
	public static WebServicesSection GetSection(System.Configuration.Configuration config) {}
	public virtual bool IsReadOnly() {}
	public virtual bool Equals(object compareTo) {}
	public virtual int GetHashCode() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public WsiProfilesElementCollection ConformanceWarnings { get{} }
	public WebServicesSection Current { get{} }
	public WebServiceProtocols EnabledProtocols { get{} }
	public ProtocolElementCollection Protocols { get{} }
	public SoapEnvelopeProcessingElement SoapEnvelopeProcessing { get{} set{} }
	public DiagnosticsElement Diagnostics { get{} set{} }
	public TypeElementCollection ServiceDescriptionFormatExtensionTypes { get{} }
	public TypeElementCollection SoapExtensionImporterTypes { get{} }
	public TypeElementCollection SoapExtensionReflectorTypes { get{} }
	public SoapExtensionTypeElementCollection SoapExtensionTypes { get{} }
	public TypeElement SoapServerProtocolFactoryType { get{} }
	public TypeElementCollection SoapTransportImporterTypes { get{} }
	public WsdlHelpGeneratorElement WsdlHelpGenerator { get{} }
	public System.Configuration.SectionInformation SectionInformation { get{} }
	public System.Configuration.ConfigurationLockCollection LockAttributes { get{} }
	public System.Configuration.ConfigurationLockCollection LockAllAttributesExcept { get{} }
	public System.Configuration.ConfigurationLockCollection LockElements { get{} }
	public System.Configuration.ConfigurationLockCollection LockAllElementsExcept { get{} }
	public bool LockItem { get{} set{} }
	public System.Configuration.ElementInformation ElementInformation { get{} }
}

