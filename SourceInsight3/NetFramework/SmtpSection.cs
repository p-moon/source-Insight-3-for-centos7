public class SmtpSection : System.Configuration.ConfigurationSection
{

	// Constructors
	public SmtpSection() {}

	// Methods
	public virtual bool IsReadOnly() {}
	public virtual bool Equals(object compareTo) {}
	public virtual int GetHashCode() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public System.Net.Mail.SmtpDeliveryMethod DeliveryMethod { get{} set{} }
	public string From { get{} set{} }
	public SmtpNetworkElement Network { get{} }
	public SmtpSpecifiedPickupDirectoryElement SpecifiedPickupDirectory { get{} }
	public System.Configuration.SectionInformation SectionInformation { get{} }
	public System.Configuration.ConfigurationLockCollection LockAttributes { get{} }
	public System.Configuration.ConfigurationLockCollection LockAllAttributesExcept { get{} }
	public System.Configuration.ConfigurationLockCollection LockElements { get{} }
	public System.Configuration.ConfigurationLockCollection LockAllElementsExcept { get{} }
	public bool LockItem { get{} set{} }
	public System.Configuration.ElementInformation ElementInformation { get{} }
}

