public class BufferModeSettings : System.Configuration.ConfigurationElement
{

	// Constructors
	public BufferModeSettings(string name, int maxBufferSize, int maxFlushSize, int urgentFlushThreshold, System.TimeSpan regularFlushInterval, System.TimeSpan urgentFlushInterval, int maxBufferThreads) {}

	// Methods
	public virtual bool IsReadOnly() {}
	public virtual bool Equals(object compareTo) {}
	public virtual int GetHashCode() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public string Name { get{} set{} }
	public int MaxBufferSize { get{} set{} }
	public int MaxFlushSize { get{} set{} }
	public int UrgentFlushThreshold { get{} set{} }
	public System.TimeSpan RegularFlushInterval { get{} set{} }
	public System.TimeSpan UrgentFlushInterval { get{} set{} }
	public int MaxBufferThreads { get{} set{} }
	public System.Configuration.ConfigurationLockCollection LockAttributes { get{} }
	public System.Configuration.ConfigurationLockCollection LockAllAttributesExcept { get{} }
	public System.Configuration.ConfigurationLockCollection LockElements { get{} }
	public System.Configuration.ConfigurationLockCollection LockAllElementsExcept { get{} }
	public bool LockItem { get{} set{} }
	public System.Configuration.ElementInformation ElementInformation { get{} }
}

