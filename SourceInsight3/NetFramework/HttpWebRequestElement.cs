public class HttpWebRequestElement : System.Configuration.ConfigurationElement
{

	// Constructors
	public HttpWebRequestElement() {}

	// Methods
	public virtual bool IsReadOnly() {}
	public virtual bool Equals(object compareTo) {}
	public virtual int GetHashCode() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public int MaximumUnauthorizedUploadLength { get{} set{} }
	public int MaximumErrorResponseLength { get{} set{} }
	public int MaximumResponseHeadersLength { get{} set{} }
	public bool UseUnsafeHeaderParsing { get{} set{} }
	public System.Configuration.ConfigurationLockCollection LockAttributes { get{} }
	public System.Configuration.ConfigurationLockCollection LockAllAttributesExcept { get{} }
	public System.Configuration.ConfigurationLockCollection LockElements { get{} }
	public System.Configuration.ConfigurationLockCollection LockAllElementsExcept { get{} }
	public bool LockItem { get{} set{} }
	public System.Configuration.ElementInformation ElementInformation { get{} }
}

