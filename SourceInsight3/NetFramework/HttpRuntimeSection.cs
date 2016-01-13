public class HttpRuntimeSection : System.Configuration.ConfigurationSection
{

	// Constructors
	public HttpRuntimeSection() {}

	// Methods
	public virtual bool IsReadOnly() {}
	public virtual bool Equals(object compareTo) {}
	public virtual int GetHashCode() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public System.TimeSpan ExecutionTimeout { get{} set{} }
	public int MaxRequestLength { get{} set{} }
	public int RequestLengthDiskThreshold { get{} set{} }
	public bool UseFullyQualifiedRedirectUrl { get{} set{} }
	public int MinFreeThreads { get{} set{} }
	public int MinLocalRequestFreeThreads { get{} set{} }
	public int AppRequestQueueLimit { get{} set{} }
	public bool EnableKernelOutputCache { get{} set{} }
	public bool EnableVersionHeader { get{} set{} }
	public bool ApartmentThreading { get{} set{} }
	public bool RequireRootedSaveAsPath { get{} set{} }
	public bool Enable { get{} set{} }
	public bool SendCacheControlHeader { get{} set{} }
	public System.TimeSpan ShutdownTimeout { get{} set{} }
	public System.TimeSpan DelayNotificationTimeout { get{} set{} }
	public int WaitChangeNotification { get{} set{} }
	public int MaxWaitChangeNotification { get{} set{} }
	public bool EnableHeaderChecking { get{} set{} }
	public System.Configuration.SectionInformation SectionInformation { get{} }
	public System.Configuration.ConfigurationLockCollection LockAttributes { get{} }
	public System.Configuration.ConfigurationLockCollection LockAllAttributesExcept { get{} }
	public System.Configuration.ConfigurationLockCollection LockElements { get{} }
	public System.Configuration.ConfigurationLockCollection LockAllElementsExcept { get{} }
	public bool LockItem { get{} set{} }
	public System.Configuration.ElementInformation ElementInformation { get{} }
}

