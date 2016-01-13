public class GlobalizationSection : System.Configuration.ConfigurationSection
{

	// Constructors
	public GlobalizationSection() {}

	// Methods
	public virtual bool IsReadOnly() {}
	public virtual bool Equals(object compareTo) {}
	public virtual int GetHashCode() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public System.Text.Encoding RequestEncoding { get{} set{} }
	public System.Text.Encoding ResponseEncoding { get{} set{} }
	public System.Text.Encoding ResponseHeaderEncoding { get{} set{} }
	public System.Text.Encoding FileEncoding { get{} set{} }
	public string Culture { get{} set{} }
	public string UICulture { get{} set{} }
	public bool EnableClientBasedCulture { get{} set{} }
	public string ResourceProviderFactoryType { get{} set{} }
	public bool EnableBestFitResponseEncoding { get{} set{} }
	public System.Configuration.SectionInformation SectionInformation { get{} }
	public System.Configuration.ConfigurationLockCollection LockAttributes { get{} }
	public System.Configuration.ConfigurationLockCollection LockAllAttributesExcept { get{} }
	public System.Configuration.ConfigurationLockCollection LockElements { get{} }
	public System.Configuration.ConfigurationLockCollection LockAllElementsExcept { get{} }
	public bool LockItem { get{} set{} }
	public System.Configuration.ElementInformation ElementInformation { get{} }
}

