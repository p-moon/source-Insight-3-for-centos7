public class SettingsSection : System.Configuration.ConfigurationSection
{

	// Constructors
	public SettingsSection() {}

	// Methods
	public virtual bool IsReadOnly() {}
	public virtual bool Equals(object compareTo) {}
	public virtual int GetHashCode() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public HttpWebRequestElement HttpWebRequest { get{} }
	public Ipv6Element Ipv6 { get{} }
	public ServicePointManagerElement ServicePointManager { get{} }
	public SocketElement Socket { get{} }
	public WebProxyScriptElement WebProxyScript { get{} }
	public PerformanceCountersElement PerformanceCounters { get{} }
	public System.Configuration.SectionInformation SectionInformation { get{} }
	public System.Configuration.ConfigurationLockCollection LockAttributes { get{} }
	public System.Configuration.ConfigurationLockCollection LockAllAttributesExcept { get{} }
	public System.Configuration.ConfigurationLockCollection LockElements { get{} }
	public System.Configuration.ConfigurationLockCollection LockAllElementsExcept { get{} }
	public bool LockItem { get{} set{} }
	public System.Configuration.ElementInformation ElementInformation { get{} }
}

