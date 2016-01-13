public class TraceSection : System.Configuration.ConfigurationSection
{

	// Constructors
	public TraceSection() {}

	// Methods
	public virtual bool IsReadOnly() {}
	public virtual bool Equals(object compareTo) {}
	public virtual int GetHashCode() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public bool Enabled { get{} set{} }
	public bool MostRecent { get{} set{} }
	public bool LocalOnly { get{} set{} }
	public bool PageOutput { get{} set{} }
	public int RequestLimit { get{} set{} }
	public TraceDisplayMode TraceMode { get{} set{} }
	public bool WriteToDiagnosticsTrace { get{} set{} }
	public System.Configuration.SectionInformation SectionInformation { get{} }
	public System.Configuration.ConfigurationLockCollection LockAttributes { get{} }
	public System.Configuration.ConfigurationLockCollection LockAllAttributesExcept { get{} }
	public System.Configuration.ConfigurationLockCollection LockElements { get{} }
	public System.Configuration.ConfigurationLockCollection LockAllElementsExcept { get{} }
	public bool LockItem { get{} set{} }
	public System.Configuration.ElementInformation ElementInformation { get{} }
}

