public class ProxyElement : System.Configuration.ConfigurationElement
{

	// Constructors
	public ProxyElement() {}

	// Methods
	public virtual bool IsReadOnly() {}
	public virtual bool Equals(object compareTo) {}
	public virtual int GetHashCode() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public AutoDetectValues AutoDetect { get{} set{} }
	public System.Uri ScriptLocation { get{} set{} }
	public BypassOnLocalValues BypassOnLocal { get{} set{} }
	public System.Uri ProxyAddress { get{} set{} }
	public UseSystemDefaultValues UseSystemDefault { get{} set{} }
	public System.Configuration.ConfigurationLockCollection LockAttributes { get{} }
	public System.Configuration.ConfigurationLockCollection LockAllAttributesExcept { get{} }
	public System.Configuration.ConfigurationLockCollection LockElements { get{} }
	public System.Configuration.ConfigurationLockCollection LockAllElementsExcept { get{} }
	public bool LockItem { get{} set{} }
	public System.Configuration.ElementInformation ElementInformation { get{} }
}

