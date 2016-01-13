public class ServicePointManagerElement : System.Configuration.ConfigurationElement
{

	// Constructors
	public ServicePointManagerElement() {}

	// Methods
	public virtual bool IsReadOnly() {}
	public virtual bool Equals(object compareTo) {}
	public virtual int GetHashCode() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public bool CheckCertificateName { get{} set{} }
	public bool CheckCertificateRevocationList { get{} set{} }
	public int DnsRefreshTimeout { get{} set{} }
	public bool EnableDnsRoundRobin { get{} set{} }
	public bool Expect100Continue { get{} set{} }
	public bool UseNagleAlgorithm { get{} set{} }
	public System.Configuration.ConfigurationLockCollection LockAttributes { get{} }
	public System.Configuration.ConfigurationLockCollection LockAllAttributesExcept { get{} }
	public System.Configuration.ConfigurationLockCollection LockElements { get{} }
	public System.Configuration.ConfigurationLockCollection LockAllElementsExcept { get{} }
	public bool LockItem { get{} set{} }
	public System.Configuration.ElementInformation ElementInformation { get{} }
}

