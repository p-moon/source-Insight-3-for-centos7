public class SystemWebSectionGroup : System.Configuration.ConfigurationSectionGroup
{

	// Constructors
	public SystemWebSectionGroup() {}

	// Methods
	public void ForceDeclaration() {}
	public void ForceDeclaration(bool force) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public AnonymousIdentificationSection AnonymousIdentification { get{} }
	public AuthenticationSection Authentication { get{} }
	public AuthorizationSection Authorization { get{} }
	public System.Configuration.DefaultSection BrowserCaps { get{} }
	public ClientTargetSection ClientTarget { get{} }
	public CompilationSection Compilation { get{} }
	public CustomErrorsSection CustomErrors { get{} }
	public DeploymentSection Deployment { get{} }
	public System.Configuration.DefaultSection DeviceFilters { get{} }
	public GlobalizationSection Globalization { get{} }
	public HealthMonitoringSection HealthMonitoring { get{} }
	public HostingEnvironmentSection HostingEnvironment { get{} }
	public HttpCookiesSection HttpCookies { get{} }
	public HttpHandlersSection HttpHandlers { get{} }
	public HttpModulesSection HttpModules { get{} }
	public HttpRuntimeSection HttpRuntime { get{} }
	public IdentitySection Identity { get{} }
	public MachineKeySection MachineKey { get{} }
	public MembershipSection Membership { get{} }
	public System.Configuration.ConfigurationSection MobileControls { get{} }
	public PagesSection Pages { get{} }
	public ProcessModelSection ProcessModel { get{} }
	public ProfileSection Profile { get{} }
	public System.Configuration.DefaultSection Protocols { get{} }
	public RoleManagerSection RoleManager { get{} }
	public SecurityPolicySection SecurityPolicy { get{} }
	public SessionStateSection SessionState { get{} }
	public SiteMapSection SiteMap { get{} }
	public TraceSection Trace { get{} }
	public TrustSection Trust { get{} }
	public UrlMappingsSection UrlMappings { get{} }
	public WebControlsSection WebControls { get{} }
	public WebPartsSection WebParts { get{} }
	public System.Web.Services.Configuration.WebServicesSection WebServices { get{} }
	public XhtmlConformanceSection XhtmlConformance { get{} }
	public bool IsDeclared { get{} }
	public bool IsDeclarationRequired { get{} }
	public string SectionGroupName { get{} }
	public string Name { get{} }
	public string Type { get{} set{} }
	public System.Configuration.ConfigurationSectionCollection Sections { get{} }
	public System.Configuration.ConfigurationSectionGroupCollection SectionGroups { get{} }
}

