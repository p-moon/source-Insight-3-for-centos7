public class NetSectionGroup : System.Configuration.ConfigurationSectionGroup
{

	// Constructors
	public NetSectionGroup() {}

	// Methods
	public static NetSectionGroup GetSectionGroup(System.Configuration.Configuration config) {}
	public void ForceDeclaration() {}
	public void ForceDeclaration(bool force) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public AuthenticationModulesSection AuthenticationModules { get{} }
	public ConnectionManagementSection ConnectionManagement { get{} }
	public DefaultProxySection DefaultProxy { get{} }
	public MailSettingsSectionGroup MailSettings { get{} }
	public RequestCachingSection RequestCaching { get{} }
	public SettingsSection Settings { get{} }
	public WebRequestModulesSection WebRequestModules { get{} }
	public bool IsDeclared { get{} }
	public bool IsDeclarationRequired { get{} }
	public string SectionGroupName { get{} }
	public string Name { get{} }
	public string Type { get{} set{} }
	public System.Configuration.ConfigurationSectionCollection Sections { get{} }
	public System.Configuration.ConfigurationSectionGroupCollection SectionGroups { get{} }
}

