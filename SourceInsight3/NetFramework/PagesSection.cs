public class PagesSection : System.Configuration.ConfigurationSection
{

	// Constructors
	public PagesSection() {}

	// Methods
	public virtual bool IsReadOnly() {}
	public virtual bool Equals(object compareTo) {}
	public virtual int GetHashCode() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public bool Buffer { get{} set{} }
	public PagesEnableSessionState EnableSessionState { get{} set{} }
	public bool EnableViewState { get{} set{} }
	public bool EnableViewStateMac { get{} set{} }
	public bool EnableEventValidation { get{} set{} }
	public bool SmartNavigation { get{} set{} }
	public bool AutoEventWireup { get{} set{} }
	public bool MaintainScrollPositionOnPostBack { get{} set{} }
	public string PageBaseType { get{} set{} }
	public string UserControlBaseType { get{} set{} }
	public string PageParserFilterType { get{} set{} }
	public bool ValidateRequest { get{} set{} }
	public string MasterPageFile { get{} set{} }
	public string Theme { get{} set{} }
	public string StyleSheetTheme { get{} set{} }
	public NamespaceCollection Namespaces { get{} }
	public TagPrefixCollection Controls { get{} }
	public int MaxPageStateFieldLength { get{} set{} }
	public TagMapCollection TagMapping { get{} }
	public System.Web.UI.CompilationMode CompilationMode { get{} set{} }
	public System.Web.UI.ViewStateEncryptionMode ViewStateEncryptionMode { get{} set{} }
	public System.TimeSpan AsyncTimeout { get{} set{} }
	public System.Configuration.SectionInformation SectionInformation { get{} }
	public System.Configuration.ConfigurationLockCollection LockAttributes { get{} }
	public System.Configuration.ConfigurationLockCollection LockAllAttributesExcept { get{} }
	public System.Configuration.ConfigurationLockCollection LockElements { get{} }
	public System.Configuration.ConfigurationLockCollection LockAllElementsExcept { get{} }
	public bool LockItem { get{} set{} }
	public System.Configuration.ElementInformation ElementInformation { get{} }
}

