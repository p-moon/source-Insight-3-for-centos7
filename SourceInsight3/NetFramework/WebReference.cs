public class WebReference
{

	// Constructors
	public WebReference(System.Web.Services.Discovery.DiscoveryClientDocumentCollection documents, System.CodeDom.CodeNamespace proxyCode, string protocolName, string appSettingUrlKey, string appSettingBaseUrl) {}
	public WebReference(System.Web.Services.Discovery.DiscoveryClientDocumentCollection documents, System.CodeDom.CodeNamespace proxyCode) {}
	public WebReference(System.Web.Services.Discovery.DiscoveryClientDocumentCollection documents, System.CodeDom.CodeNamespace proxyCode, string appSettingUrlKey, string appSettingBaseUrl) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string AppSettingBaseUrl { get{} }
	public string AppSettingUrlKey { get{} }
	public System.Web.Services.Discovery.DiscoveryClientDocumentCollection Documents { get{} }
	public System.CodeDom.CodeNamespace ProxyCode { get{} }
	public System.Collections.Specialized.StringCollection ValidationWarnings { get{} }
	public ServiceDescriptionImportWarnings Warnings { get{} set{} }
	public string ProtocolName { get{} set{} }
}

