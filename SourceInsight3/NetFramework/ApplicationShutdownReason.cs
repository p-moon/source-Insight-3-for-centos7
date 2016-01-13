public class ApplicationShutdownReason : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
{

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual string ToString() {}
	public virtual string ToString(string format, System.IFormatProvider provider) {}
	public virtual int CompareTo(object target) {}
	public virtual string ToString(System.IFormatProvider provider) {}
	public virtual System.TypeCode GetTypeCode() {}
	public string ToString(string format) {}
	public Type GetType() {}

	// Fields
	public int value__;
	public ApplicationShutdownReason None;
	public ApplicationShutdownReason HostingEnvironment;
	public ApplicationShutdownReason ChangeInGlobalAsax;
	public ApplicationShutdownReason ConfigurationChange;
	public ApplicationShutdownReason UnloadAppDomainCalled;
	public ApplicationShutdownReason ChangeInSecurityPolicyFile;
	public ApplicationShutdownReason BinDirChangeOrDirectoryRename;
	public ApplicationShutdownReason BrowsersDirChangeOrDirectoryRename;
	public ApplicationShutdownReason CodeDirChangeOrDirectoryRename;
	public ApplicationShutdownReason ResourcesDirChangeOrDirectoryRename;
	public ApplicationShutdownReason IdleTimeout;
	public ApplicationShutdownReason PhysicalApplicationPathChanged;
	public ApplicationShutdownReason HttpRuntimeClose;
	public ApplicationShutdownReason InitializationError;
	public ApplicationShutdownReason MaxRecompilationsReached;
	public ApplicationShutdownReason BuildManagerChange;
}

