public class ProcessModelSection : System.Configuration.ConfigurationSection
{

	// Constructors
	public ProcessModelSection() {}

	// Methods
	public virtual bool IsReadOnly() {}
	public virtual bool Equals(object compareTo) {}
	public virtual int GetHashCode() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public bool Enable { get{} set{} }
	public System.TimeSpan Timeout { get{} set{} }
	public System.TimeSpan IdleTimeout { get{} set{} }
	public System.TimeSpan ShutdownTimeout { get{} set{} }
	public int RequestLimit { get{} set{} }
	public int RequestQueueLimit { get{} set{} }
	public int RestartQueueLimit { get{} set{} }
	public int MemoryLimit { get{} set{} }
	public bool WebGarden { get{} set{} }
	public int CpuMask { get{} set{} }
	public string UserName { get{} set{} }
	public string Password { get{} set{} }
	public ProcessModelLogLevel LogLevel { get{} set{} }
	public System.TimeSpan ClientConnectedCheck { get{} set{} }
	public ProcessModelComAuthenticationLevel ComAuthenticationLevel { get{} set{} }
	public ProcessModelComImpersonationLevel ComImpersonationLevel { get{} set{} }
	public System.TimeSpan ResponseDeadlockInterval { get{} set{} }
	public System.TimeSpan ResponseRestartDeadlockInterval { get{} set{} }
	public bool AutoConfig { get{} set{} }
	public int MaxWorkerThreads { get{} set{} }
	public int MaxIOThreads { get{} set{} }
	public int MinWorkerThreads { get{} set{} }
	public int MinIOThreads { get{} set{} }
	public string ServerErrorMessageFile { get{} set{} }
	public System.TimeSpan PingFrequency { get{} set{} }
	public System.TimeSpan PingTimeout { get{} set{} }
	public int MaxAppDomains { get{} set{} }
	public System.Configuration.SectionInformation SectionInformation { get{} }
	public System.Configuration.ConfigurationLockCollection LockAttributes { get{} }
	public System.Configuration.ConfigurationLockCollection LockAllAttributesExcept { get{} }
	public System.Configuration.ConfigurationLockCollection LockElements { get{} }
	public System.Configuration.ConfigurationLockCollection LockAllElementsExcept { get{} }
	public bool LockItem { get{} set{} }
	public System.Configuration.ElementInformation ElementInformation { get{} }
}

